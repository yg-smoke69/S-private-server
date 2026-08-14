# Phase 1: Protocol Reconstruction - Task Breakdown

**Start Date**: 2026-08-14  
**Objective**: Match client protocol expectations by fixing 5 critical mismatches  
**Status**: Investigation Phase

---

## Investigation Phase (Before Implementation)

### Task 0.1: Search for Message ID 1002 Usage
**Objective**: Verify whether 1002 is the correct command ID for MajorLogin  
**Where to Look**:
- Search entire IL2CPP dump: `grep -r "1002\|0x3EA" /workspaces/S-private-server/`
- Check IFix hooks: `/Core/IFix/ILFixDynamicMethodWrapper.cs`
- Check message routing: Search for "MajorLogin" or "MajorLoginRes"

**Success Criteria**:
- [ ] Found reference to 1002 in code
- [ ] Confirmed it maps to MajorLogin command
- [ ] Or found alternative message ID mapping

**Evidence Type**: IL2CPP Dump

---

### Task 0.2: Locate Message Handler Dispatcher
**Objective**: Find the function that routes messages by ID  
**Search Terms**:
```bash
grep -r "MessageID\|CommandID\|ProtocolID\|switch.*case" \
  /workspaces/S-private-server/Core/GCommon \
  /workspaces/S-private-server/Networking \
  --include="*.cs" | head -50
```

**What to Look For**:
- Switch statement on message ID
- Message handler function table/dictionary
- Dispatcher pattern

**Example Pattern**:
```csharp
switch(messageID) {
    case 1: HandleTCPInit(); break;
    case 2: HandleHeartbeat(); break;
    case 3: HandleUserMessage(); break;
    default: // dispatch to subcommand
}
```

**Success Criteria**:
- [ ] Found dispatcher function
- [ ] Located command ID mapping
- [ ] Understand call flow

**Evidence Type**: IL2CPP Dump

---

### Task 0.3: Extract Frame Format from Client Code
**Objective**: Verify exact binary frame structure  
**Search For**:
- `0xFEFF` references (magic byte)
- Socket read operations with struct.pack/unpack
- Network packet parsing code

**Commands**:
```bash
grep -r "0xFEFF\|FEFF\|Magic" /workspaces/S-private-server/ --include="*.cs"
grep -r "struct.pack\|BinaryReader\|NetworkStream" /workspaces/S-private-server/ --include="*.cs" | head -20
```

**Verify**:
- [ ] Magic byte value (0xFEFF)
- [ ] MessageID size (u16 vs u32)
- [ ] Payload length size (u32 BE)
- [ ] Payload encoding (Protobuf varint)

**Evidence Type**: IL2CPP Dump (network code)

---

### Task 0.4: Find BlacklistInfoRes and LoginQueueInfo Structures
**Objective**: Get definitions of nested types in MajorLoginRes  
**Files to Check**:
```bash
find /workspaces/S-private-server -name "BlacklistInfoRes.cs" -o -name "LoginQueueInfo.cs"
```

**If Not Found**:
- Grep for class definitions: `grep -r "class BlacklistInfoRes\|class LoginQueueInfo"`
- Check for similar naming patterns: `grep -r "BlackList\|Blacklist\|Queue"`

**Extract**:
- [ ] BlacklistInfoRes all fields
- [ ] LoginQueueInfo all fields
- [ ] Any nested types

**Evidence Type**: IL2CPP Dump (proto folder)

---

## Implementation Phase

### Task 1.1: Create MajorLoginRes Encoder
**File**: `/sp server/tcp.py`  
**Current Code** (~12 lines):
```python
def build_mono_major_login_payload():
    pb = bytearray()
    pb.extend(encode_field_varint(1, 0))                    # Code
    pb.extend(encode_field_varint(2, 100000001))            # AccountID
    pb.extend(encode_field_string(3, "GUEST_TOKEN_*"))      # Token
    pb.extend(encode_field_string(4, "127.0.0.1:10000"))    # Server URL
    pb.extend(encode_field_string(5, "IN"))                 # Region
    pb.extend(encode_field_varint(6, 31536000))             # TTL
    ...
```

**Required Changes**:

1. **Add all 18 fields** (from MajorLoginRes.cs):
   - Field 1: account_id (u64 varint)
   - Field 2: lock_region (string)
   - Field 3: noti_region (string)
   - Field 4: ip_region (string)
   - Field 5: agora_environment (string)
   - Field 6: new_active_region (string)
   - Field 7: recommend_regions (repeated string)
   - Field 8: token (string)
   - Field 9: ttl (u32 varint)
   - Field 10: server_url (string)
   - Field 11: emulator_score (u32 varint)
   - Field 12: blacklist (nested BlacklistInfoRes)
   - Field 13: queue_info (nested LoginQueueInfo)
   - Field 14: tp_url (string)
   - Field 15: app_server_id (u32 varint)
   - Field 16: ano_url (string)
   - Field 17: ip_city (string)
   - Field 18: ip_subdivision (string)

2. **Create nested message encoders**:
   ```python
   def encode_blacklist_info_res():
       # Extract fields from BlacklistInfoRes.cs
       
   def encode_login_queue_info():
       # Extract fields from LoginQueueInfo.cs
   ```

3. **Handle repeated fields** (recommend_regions):
   ```python
   def encode_field_repeated_string(field_number, strings):
       # For each string, encode separately with same field number
   ```

**Testing**:
- [ ] Encode produces valid protobuf
- [ ] All fields present and correct type
- [ ] Total payload matches expected size

**Evidence**: MajorLoginRes.cs (exact field list)

---

### Task 1.2: Parse LoginReq
**File**: `/sp server/tcp.py`  
**Current Code**: No parsing at all

**Implementation**:
1. **Create decoder**:
   ```python
   def parse_login_req(raw_protobuf_bytes):
       # Use varint decoder to extract all 40+ fields
       # Return dict with field names and values
       return {
           'account_id': ...,
           'device_id': ...,
           'device_model': ...,
           'client_version': ...,
           # ... etc
       }
   ```

2. **Extract required fields**:
   - account_id (for validation)
   - device_id (fingerprinting)
   - device_model (anti-emulator)
   - client_version (version check)
   - login_token (previous session)
   - region (server selection)
   - platform_sdk_id (SDK version)

3. **Add validation**:
   ```python
   def validate_login_req(req):
       # Check device_id format
       # Verify client_version is compatible
       # Check if login_token is still valid
       return is_valid, error_message
   ```

**Testing**:
- [ ] Can parse LoginReq from client
- [ ] All fields decoded correctly
- [ ] Validation catches invalid data

**Evidence**: LoginReq.cs (field list and types)

---

### Task 1.3: Implement Message Dispatcher by ID
**File**: `/sp server/tcp.py`  
**Current Code**: HTTP path-based routing

**New Implementation**:
```python
def dispatch_message(message_id, payload):
    handlers = {
        1: handle_tcp_init,
        2: handle_tcp_heartbeat,
        3: handle_tcp_user,  # This dispatches to subcommands
    }
    
    handler = handlers.get(message_id)
    if handler:
        return handler(payload)
    else:
        return None  # Unknown message type

def handle_tcp_user(payload):
    # Parse protobuf to get command ID
    command_id = parse_command_id(payload)
    
    subcommands = {
        1002: handle_major_login,  # Or whatever the correct ID is
        # ... other commands
    }
    
    handler = subcommands.get(command_id)
    if handler:
        return handler(payload)
```

**Key Changes**:
- [ ] Parse MessageID from frame header
- [ ] Route to dispatcher
- [ ] Implement TCP_INIT, TCP_HEARTBEAT, TCP_USER handlers
- [ ] Implement MajorLogin handler under TCP_USER

**Testing**:
- [ ] Dispatcher routes to correct handler
- [ ] Unknown message IDs handled gracefully
- [ ] Response wraps in correct frame

**Evidence**: TCPMessageIDReserved.cs, message handler functions in IL2CPP

---

### Task 1.4: Verify Frame Header Format
**File**: `/sp server/tcp.py`  
**Current Code**:
```python
header = struct.pack('>HHI', 0xFEFF, 1002, len(raw_pb))
# Assuming: 0xFEFF (magic) + MessageID(u16) + Length(u32 BE)
```

**Verification Steps**:
1. **Create test frame**:
   ```python
   def create_test_frame():
       magic = 0xFEFF
       msg_id = 1002  # Or correct ID
       payload = b"test"
       length = len(payload)
       
       # Test different orderings
       frame_v1 = struct.pack('>HHI', magic, msg_id, length) + payload
       frame_v2 = struct.pack('>HI', magic, msg_id) + struct.pack('>I', length) + payload
       frame_v3 = struct.pack('>HH', magic, msg_id) + struct.pack('>I', length) + payload
       
       return [frame_v1, frame_v2, frame_v3]
   ```

2. **Compare with IL2CPP**:
   - Find network reader code: `NetworkStream.Read()`, `BinaryReader`
   - Check byte order: `>` (big-endian) vs `<` (little-endian)
   - Verify order of fields

3. **Test with client** (if available):
   - [ ] Send test frames
   - [ ] Observe which format client accepts

**Testing**:
- [ ] Frame parses correctly with client expectations
- [ ] No off-by-one errors in length
- [ ] Magic byte recognizes frame

**Evidence**: Network packet capture (if available), IL2CPP network code

---

### Task 1.5: Remove HTTP Cruft, Keep Pure TCP
**File**: `/sp server/tcp.py`  
**Current Code**: Mixes HTTP headers with binary protocol

**Refactoring**:
```python
def handle_client(client_socket, addr, port):
    try:
        # Step 1: Read exactly until we have full frame
        magic = client_socket.recv(2)
        if magic != b'\xfe\xff':
            # Not a binary frame, maybe legacy HTTP
            # Or: reject as invalid
            pass
        
        # Step 2: Read frame header
        msg_id_bytes = client_socket.recv(2)
        msg_id = struct.unpack('>H', msg_id_bytes)[0]
        
        length_bytes = client_socket.recv(4)
        length = struct.unpack('>I', length_bytes)[0]
        
        # Step 3: Read payload
        payload = client_socket.recv(length)
        
        # Step 4: Dispatch
        response = dispatch_message(msg_id, payload)
        
        # Step 5: Send response (in frame format)
        response_frame = create_frame(msg_id, response)
        client_socket.sendall(response_frame)
        
    finally:
        client_socket.close()
```

**Key Changes**:
- [ ] Remove HTTP parsing (headers, paths)
- [ ] Read binary frame directly
- [ ] Validate magic byte
- [ ] Parse message ID
- [ ] Handle variable-length payloads
- [ ] Send binary response

**Compatibility**:
- [ ] Keep HTTP fallback for old clients? (Or break compatibility)
- [ ] Log all protocol transitions

**Testing**:
- [ ] Pure TCP client works
- [ ] Frame boundaries respected
- [ ] Error handling for incomplete frames

**Evidence**: IL2CPP protocol code

---

## Integration & Testing Phase

### Task 2.1: Integration Test
**Objective**: Verify all subsystems work together

```python
# Test suite
def test_major_login_flow():
    # Create login request
    req = create_login_req(
        account_id=100000001,
        device_id="test-device",
        client_version="1.0.0"
    )
    
    # Send request
    frame = create_frame(3, req)  # TCP_USER
    
    # Parse response
    response_frame = parse_frame(send_recv(frame))
    response = parse_major_login_res(response_frame)
    
    # Verify all fields present
    assert response['account_id'] == 100000001
    assert response['token'] is not None
    assert response['ttl'] > 0
    assert 'lock_region' in response
    assert 'recommend_regions' in response
    
    print("✅ MajorLogin integration test passed")
```

**Test Cases**:
- [ ] Valid login request
- [ ] Invalid device_id
- [ ] Missing fields in request
- [ ] Malformed protobuf
- [ ] Frame boundary conditions

---

### Task 2.2: Compare Binary Output with Prototype
**Objective**: Ensure new code produces same results as working version

```bash
# Before refactoring:
python3 sp_server/tcp.py > /tmp/old_response.bin &

# After refactoring:
python3 sp_server/tcp.py > /tmp/new_response.bin &

# Compare:
diff /tmp/old_response.bin /tmp/new_response.bin
# Should be identical
```

---

## Verification Checklist

### Before Committing Each Task

**Task 1.1 (MajorLoginRes)**:
- [ ] All 18 fields encoded
- [ ] Field numbers match proto
- [ ] Nested messages handled
- [ ] Varint encoding correct
- [ ] No null pointer exceptions

**Task 1.2 (LoginReq Parser)**:
- [ ] All 40+ fields parsed
- [ ] Types correct (u64 vs string)
- [ ] Repeated fields handled
- [ ] Error handling for truncated data
- [ ] Device fingerprint extracted

**Task 1.3 (Dispatcher)**:
- [ ] Message ID routing works
- [ ] TCP_INIT/HEARTBEAT/USER correct
- [ ] Subcommand routing works
- [ ] Unknown IDs handled
- [ ] No exceptions on bad input

**Task 1.4 (Frame Format)**:
- [ ] Magic byte verified
- [ ] MessageID endianness correct
- [ ] Length field accurate
- [ ] Payload boundary respected
- [ ] Client accepts frames

**Task 1.5 (TCP Cleanup)**:
- [ ] No HTTP parsing
- [ ] Binary protocol clean
- [ ] Connection lifecycle correct
- [ ] Timeout handling works
- [ ] Payload size limits enforced

---

## Success Criteria for Phase 1

**Protocol Reconstruction Complete When**:
- [x] Subsystem map created
- [x] Mismatches identified  
- [ ] Message ID mapping verified
- [ ] MajorLoginRes fully implemented (18/18 fields)
- [ ] LoginReq parser implemented (40+/40+ fields)
- [ ] Message dispatcher functional
- [ ] Frame format validated
- [ ] TCP client connects and receives valid response
- [ ] No more HTTP path-based routing
- [ ] Integration tests pass

---

**Document Version**: 1.0  
**Status**: Ready for Investigation Phase  
**Next**: Begin Task 0.1 (Search for Message ID 1002)
