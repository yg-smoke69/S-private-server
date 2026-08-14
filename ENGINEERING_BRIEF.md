# Sigma Preservation Project: Engineering Brief

**Date**: 2026-08-14  
**Status**: Phase 1 - Protocol Reconstruction  
**Repository**: yg-smoke69/S-private-server  

---

## I. Executive Summary

This is a **game server preservation and reverse-engineering project** for a Battle Royale game (similar to Free Fire). Our objective is to rebuild a compatible server implementation that can communicate with the original game client by reconstructing the original network protocol.

**Key Principle**: Sources of truth (in priority order):
1. IL2CPP dump (decompiled game code) ← **PRIMARY**
2. Working server debug logs
3. Protobuf definitions
4. Existing prototype server code

---

## II. Repository Structure & Subsystems

### A. Core Infrastructure (`/Core/`)
**Files**: 4,276 | **Purpose**: Game logic and protocol definitions

| Subsystem | Location | Purpose |
|-----------|----------|---------|
| **Message IDs** | `GCommon/TCPMessageIDReserved.cs` | TCP protocol message type constants |
| **Protobuf Messages** | `proto/` (700+ files) | All serializable message structures |
| **Message Definitions** | `message/` (2000+ files) | Login, game, economy, progression messages |
| **Entity Component** | `ECA/` | Core game architecture |
| **Common Utils** | `GCommon/` | Shared utilities and base classes |
| **Hot Fix System** | `IFix/` | Live patch capability |

**Key Finding**: TCPMessageIDReserved defines only 3 base types:
```csharp
internal enum TCPMessageIDReserved : byte
{
    TCP_INIT = 1,        // Connection init
    TCP_HEARTBEAT = 2,   // Keep-alive
    TCP_USER = 3         // Application data
}
```

### B. Networking Layer (`/Networking/`)
**Files**: 294 | **Purpose**: Network protocol and message handling

| Component | Files | Purpose |
|-----------|-------|---------|
| **TCP Messages** | `tcp/` (190 files) | Client-Server message definitions (Req/Rsp/Ntf) |
| **Message Types** | See below | Account, Match, Room, Economy, Events |
| **Platform Integration** | `InterApp/` (13 files) | Facebook, LINE, WhatsApp integrations |

**TCP Message Categories**:
```
Account System          Game Sessions           Events & Notifications
├─ AccountRoleInfo      ├─ RoomInfo              ├─ ActivityUpdateNtf
├─ AccountMatchInfo     ├─ GroupInfo             ├─ AwardGameLinkNtf
├─ AccountLevelUpInfo   ├─ MatchmakingStartReq   └─ VipCardPurchaseNtf
└─ AccountPrefersInfo   └─ ChannelIDReq

Gameplay (Game Events)  Economy                 Social
├─ AIInfo               ├─ StoreDesc             ├─ FriendReq
├─ Zombie Systems       ├─ GachaDesc             ├─ GroupCreateReq
├─ Trigger Actions      └─ WalletInfo            └─ ClanMemberInfo
└─ Level Objects
```

### C. Data & Serialization (`/DataFormats/`)
**Files**: 89 | **Purpose**: Format handling for multiple serialization types

| Library | Files | Purpose |
|---------|-------|---------|
| **SharpZipLib** | 10 | ZIP compression (GZip, Deflate) |
| **LitJson** | 1 | Lightweight JSON serialization |
| **SimpleJSON** | 1 | Minimal JSON library |
| **LumenWorks CSV** | 10 | CSV parsing utilities |

### D. Third-Party SDKs (`/ThirdParty/`)
**Files**: 181 | **Purpose**: External integrations

- **UMA** (7 dirs) - Character avatar system
- **Garena SDK** - Asian market distribution
- **Unity Standard Assets** (6 dirs) - Graphics, input, utilities
- **Unity Collections** - Performance-critical data structures

### E. Gameplay Systems (`/Gameplay/`)
**Files**: 7,381 | **Purpose**: Core game mechanics

| System | Purpose |
|--------|---------|
| **COW.Gameplay** | Main gameplay loop |
| **COW.Gameplay.MultiplayerGame** | Netplay mechanics |
| **COW.Gameplay.UGC** | User-generated content |
| **COW.SingerBTimeLine** | Timeline-based events |
| **Zombies/AI** | Enemy behavior |
| **Triggers** | Level event system |

### F. Graphics & Audio (`/Graphics/`, `/Audio/`)
**Files**: 111 + 263 | **Purpose**: Visual and audio rendering

- **Rendering** - Deferred pipeline, post-effects
- **Wwise Integration** - Professional audio engine
- **Decal/Lightmap** - Environmental rendering
- **Voice Systems** - VOIP communication

### G. User Interface (`/UI/`)
**Files**: 165 | **Purpose**: Menu and HUD systems

- **HUD** - In-game UI overlay
- **Controllers** - Input mapping
- **React UI** - Modern UI framework integration

### H. Python Prototype Server (`/sp server/`)
**Files**: 6 | **Status**: Minimal reference implementation

```python
server.py      # Main entry point (TCP + UDP threads)
tcp.py         # HTTP + binary protocol handler (165 lines)
udp2.py        # UDP echo server for real-time sync
init_db.py     # SQLite database setup
requirements.txt  # Flask, requests
data/          # SQLite database
```

---

## III. Protocol Architecture

### Current Implementation (tcp.py)

```
Client Socket (TCP Port 8080)
    ↓
1. Detect Protocol Type
   ├─ Binary Header (0xFEFF) → Parse as Protobuf Binary
   └─ Text Header (GET/POST) → Parse as HTTP Request
    ↓
2. Route by HTTP Path
   ├─ "ver.php" → Version check response (JSON)
   ├─ "majorlogin" → MajorLogin binary response (MessageID 1002)
   ├─ "createrole" → Character creation (JSON)
   └─ * → Catch-all bypass (JSON)
    ↓
3. Encode Response
   ├─ Protobuf Varint Encoding (field key = (number << 3) | type)
   ├─ Wrap in Frame: 0xFEFF + MsgID(u16) + Length(u32 BE) + Payload
   └─ HTTP 200 Response with binary body
    ↓
Client
```

### Frame Format (Binary Protocol)

**Observed** (from tcp.py):
```
Offset   Size   Name           Example
0        2      Magic          0xFEFF
2        2      MessageID      0x03EA (1002 decimal)
4        4      PayloadLen     0x00000042 (66 bytes BE)
8        N      Payload        [protobuf-encoded data]
```

**Varint Encoding** (for protobuf):
```python
# Field key = (field_number << 3) | wire_type
# wire_type: 0=varint, 1=64-bit, 2=delimited, 5=32-bit

# Field 1 (varint): key = (1 << 3) | 0 = 0x08
# Field 2 (varint): key = (2 << 3) | 0 = 0x10
# Field 3 (string): key = (3 << 3) | 2 = 0x1A
```

---

## IV. Critical Protocol Mismatches

### ⚠️ MISMATCH #1: Message ID Mapping Unknown

**Current Prototype**:
```python
# tcp.py line 72
struct.pack('>HHI', 0xFEFF, 1002, 0)  # MessageID = 1002
```

**IL2CPP Source** (TCPMessageIDReserved.cs):
```csharp
internal enum TCPMessageIDReserved : byte
{
    TCP_INIT = 1,
    TCP_HEARTBEAT = 2,
    TCP_USER = 3
}
```

**Issue**: 
- Prototype uses `1002` as MessageID
- IL2CPP defines only 3 protocol-level message types (all ≤ 3)
- Message ID 1002 is NOT in the enum

**Hypothesis**: 
- MessageID at TCP level should be one of {1, 2, 3}
- Command/operation ID (1002) might be embedded in the payload
- Need to examine client packet captures to verify

**Evidence Required**: 
- [ ] Find message handler mapping
- [ ] Examine actual client-server logs
- [ ] Verify frame format against real traffic

---

### ⚠️ MISMATCH #2: MajorLoginRes Missing 9+ Required Fields

**Current Prototype** (6 fields):
```python
pb.extend(encode_field_varint(1, 0))                    # Code
pb.extend(encode_field_varint(2, 100000001))            # AccountID
pb.extend(encode_field_string(3, "GUEST_TOKEN_*"))      # Token
pb.extend(encode_field_string(4, "127.0.0.1:10000"))    # Server URL
pb.extend(encode_field_string(5, "IN"))                 # Region
pb.extend(encode_field_varint(6, 31536000))             # TTL
```

**IL2CPP Source** (MajorLoginRes.cs):
```csharp
public class MajorLoginRes
{
    public ulong account_id;                    // Field 1
    public string lock_region;                  // Field 2
    public string noti_region;                  // Field 3
    public string ip_region;                    // Field 4
    public string agora_environment;            // Field 5
    public string new_active_region;            // Field 6
    public List<string> recommend_regions;      // Field 7
    public string token;                        // Field 8
    public uint ttl;                            // Field 9
    public string server_url;                   // Field 10
    public uint emulator_score;                 // Field 11
    public BlacklistInfoRes blacklist;          // Field 12
    public LoginQueueInfo queue_info;           // Field 13
    public string tp_url;                       // Field 14
    public uint app_server_id;                  // Field 15
    public string ano_url;                      // Field 16
    public string ip_city;                      // Field 17
    public string ip_subdivision;               // Field 18
}
```

**Issue**:
- Prototype encodes only 6 fields (and in wrong order)
- Real message requires 18 fields
- Missing nested objects: `blacklist` (BlacklistInfoRes), `queue_info` (LoginQueueInfo)
- Field numbering and types don't match

**Impact**: Client likely rejects response or fails to parse required fields

**Action Required**: 
- [ ] Implement all 18 fields
- [ ] Handle nested message types (BlacklistInfoRes, LoginQueueInfo)
- [ ] Validate field encoding order

---

### ⚠️ MISMATCH #3: HTTP Routing vs. Binary Message IDs

**Current Prototype** (HTTP path-based routing):
```python
if "majorlogin" in request_path_clean:
    # Send MajorLogin response
elif "createrole" in request_path_clean:
    # Send character creation response
```

**IL2CPP Protocol** (Message ID-based):
- Base message IDs: {1=INIT, 2=HEARTBEAT, 3=USER}
- Command dispatch happens in the payload
- No HTTP path routing

**Issue**:
- Prototype mixes HTTP semantics with binary protocol
- Real protocol uses TCP message IDs, not HTTP paths
- HTTP headers should be transparent wrapper only

**Action Required**:
- [ ] Separate HTTP transport from application protocol
- [ ] Implement message ID dispatcher
- [ ] Map client message IDs to handler functions

---

### ⚠️ MISMATCH #4: LoginReq Structure Ignored

**Client sends** (from LoginReq.cs):
```csharp
// Device/System Info (~40+ fields)
public string device_id;            // Unique device fingerprint
public string device_model;         // Phone model (e.g., "SM-G991B")
public uint screen_width;           // Display resolution
public uint screen_hight;           // (typo in original: "hight")
public string cpu_hardware;         // Processor info
public uint memory;                 // RAM in MB
public string gl_render;            // GPU renderer
public string gl_version;           // OpenGL version
public string client_version;       // App version
public string system_software;      // OS name (Android/iOS)
public uint plat_id;                // Platform ID (1=Android, 2=iOS)
public string network;              // Network type (WiFi/4G/5G)
public string language;             // Device language
public string region;               // Player region
public string ip_region;            // IP-detected region
public string open_id;              // Social platform ID
public string open_id_type;         // SDK type (Facebook/Garena/etc)
public uint platform_sdk_id;        // SDK version
public string login_token;          // Previous session token
// ... more fields
```

**Current Prototype**:
```python
# Simply ignores the entire request body
# No validation or processing
```

**Issue**:
- Client provides critical device fingerprint and validation data
- Server doesn't use any of this
- No anti-cheat checks, device validation, or fraud detection
- Could lead to spoofed login attempts

**Action Required**:
- [ ] Parse LoginReq fields
- [ ] Validate device_id consistency
- [ ] Implement basic anti-emulator checks (emulator_score)
- [ ] Log device telemetry for fraud detection

---

### ⚠️ MISMATCH #5: No Actual Session Management

**Current Prototype**:
```python
# All responses use hardcoded values
account_id = 100000001
token = "GUEST_TOKEN_PERMANENT_BYPASS"
ttl = 31536000  # 1 year - unrealistic
```

**Real Protocol** (from MajorLoginRes):
```csharp
public ulong account_id;        // Should be unique per login
public string token;            // Should be random/secure
public uint ttl;                // Should match actual session duration
```

**Issue**:
- No per-user session state
- Token is predictable string
- TTL is unrealistic (1 year)
- No token validation on subsequent requests

**Action Required**:
- [ ] Implement token generation (random/cryptographic)
- [ ] Add session storage (in-memory or database)
- [ ] Validate token on game server requests
- [ ] Set realistic TTL (15-30 minutes typical)

---

## V. Subsystem Map (Detailed)

```
┌─────────────────────────────────────────────────────────────────────────┐
│                      SIGMA GAME SERVER ARCHITECTURE                      │
└─────────────────────────────────────────────────────────────────────────┘

                        ┌──────────────────────┐
                        │   GAME CLIENT        │
                        │  (Unity IL2CPP)      │
                        └──────────────────────┘
                                  │
                    ┌─────────────┴─────────────┐
                    │      TCP Port 8080        │
                    │  Binary + HTTP Protocol   │
                    └─────────────┬─────────────┘
                                  │
        ┌─────────────────────────┴──────────────────────────┐
        │                                                    │
        │  ┌──────────────────┐         ┌──────────────────┐ │
        │  │   HTTP Wrapper   │         │ Binary Protocol  │ │
        │  │  Frame Detection │         │ Parser & Handler │ │
        │  └─────────┬────────┘         └─────────┬────────┘ │
        │            │                            │           │
        │  ┌─────────▼──────────────────────────────────┐    │
        │  │   Message Dispatcher (By Message ID)      │    │
        │  │  TCP_INIT(1) | TCP_HEARTBEAT(2) | TCP_USER(3)   │
        │  └─────────┬──────────────────────────────────┘    │
        │            │                                        │
        │  ┌─────────▼──────────────────────────────────┐    │
        │  │   Command Router (Per Message Type)        │    │
        │  │  - Login (1002?)                           │    │
        │  │  - GamePlay (300x)                         │    │
        │  │  - Economy (200x)                          │    │
        │  │  - Social (400x)                           │    │
        │  └─────────┬──────────────────────────────────┘    │
        │            │                                        │
        │  ┌─────────▼──────────────────────────────────┐    │
        │  │   Handler Functions                        │    │
        │  │  - OnMajorLogin()                          │    │
        │  │  - OnGameLogin()                           │    │
        │  │  - OnCreateRole()                          │    │
        │  │  - OnJoinRoom()                            │    │
        │  │  - OnPlayerAction()                        │    │
        │  └─────────┬──────────────────────────────────┘    │
        │            │                                        │
        │  ┌─────────▼──────────────────────────────────┐    │
        │  │   Business Logic & State                   │    │
        │  │  - Account/Session Manager                 │    │
        │  │  - Room/Match Manager                      │    │
        │  │  - Economy Manager                         │    │
        │  │  - Player Profile Manager                  │    │
        │  └─────────┬──────────────────────────────────┘    │
        │            │                                        │
        │  ┌─────────▼──────────────────────────────────┐    │
        │  │   Data Layer                               │    │
        │  │  - Session Cache (Redis/In-Memory)         │    │
        │  │  - Player Database (SQLite/MySQL)          │    │
        │  │  - Configuration Cache                     │    │
        │  └─────────────────────────────────────────────┘   │
        │                                                    │
        │  ┌──────────────────┐         ┌──────────────────┐ │
        │  │   UDP Port 39001 │         │ Game Sync Layer  │ │
        │  │   Real-time Data │         │ (State Updates)  │ │
        │  └──────────────────┘         └──────────────────┘ │
        │                                                    │
        └────────────────────────────────────────────────────┘
```

---

## VI. Phase 1: Protocol Reconstruction (Priority Tasks)

### Task 1.1: Determine Actual Message ID Mapping
**Objective**: Map protocol command IDs to handler functions  
**Evidence Sources**: 
- Search for "1002" usage in IL2CPP dump
- Find message ID dispatcher in game code
- Examine working server logs for message sequence

**Verification**:
- [ ] Locate command ID → handler mapping
- [ ] Verify frame format matches client expectations
- [ ] Test with actual client packets

---

### Task 1.2: Implement Complete MajorLoginRes
**Objective**: Encode all 18 required fields  
**Evidence**: MajorLoginRes.cs full field list

**Required Implementations**:
- [ ] Create MajorLoginRes encoder function
- [ ] Implement nested types: BlacklistInfoRes, LoginQueueInfo
- [ ] Add region configuration logic
- [ ] Implement field ordering per protobuf spec

**Testing**:
- [ ] Verify binary encoding matches wire format
- [ ] Test client parsing of response

---

### Task 1.3: Validate Frame Header Format
**Objective**: Confirm 0xFEFF + MessageID + Length structure  
**Evidence Required**:
- [ ] Capture client-server packets
- [ ] Verify magic byte (0xFEFF)
- [ ] Confirm MessageID encoding (u16 vs u32)
- [ ] Validate length field (u32 BE)

**Implementation**:
- [ ] Document frame header spec
- [ ] Add frame parser tests

---

### Task 1.4: Implement LoginReq Parsing
**Objective**: Process incoming client login request  
**Evidence**: LoginReq.cs (40+ fields)

**Implementation Steps**:
- [ ] Parse device_id and device_model
- [ ] Extract region and ip_region
- [ ] Read login_token if present
- [ ] Extract platform_sdk_id for SDK version
- [ ] Log client_version for version checking

**Validation**:
- [ ] Validate device_id format
- [ ] Check client_version compatibility
- [ ] Implement emulator detection (emulator_score)

---

### Task 1.5: Separate HTTP Transport from Application Protocol
**Objective**: Pure TCP binary protocol (remove HTTP cruft)  
**Current Issue**: Mixed HTTP + binary semantics

**Refactor**:
- [ ] Remove HTTP path routing
- [ ] Implement pure TCP message dispatcher
- [ ] Keep HTTP only as fallback/legacy

**Testing**:
- [ ] Verify client connects to TCP (not HTTP)
- [ ] Test with telnet/nc binary protocol

---

## VII. Evidence Collection Checklist

### From IL2CPP Dump
- [ ] Read all message ID definitions
- [ ] Extract frame header structure
- [ ] Find command → message ID mapping
- [ ] Locate message handler functions
- [ ] Identify message encoding/decoding functions

### From Server Logs (if available)
- [ ] [ ] Find login flow sequence
- [ ] Extract exact byte sequences
- [ ] Document timing and acknowledgments
- [ ] Note error handling and edge cases

### From Working Prototype
- [ ] [ ] Current behavior baseline
- [ ] Current encoding/decoding logic
- [ ] Limitations and assumptions

### From Protobuf Definitions
- [ ] Verify message field types
- [ ] Confirm field numbering
- [ ] Validate nested message structures

---

## VIII. Key Constants (From Prototype)

| Constant | Value | Source | Note |
|----------|-------|--------|------|
| TCP Magic | 0xFEFF | tcp.py | Frame header marker |
| TCP Port | 8080 | server.py | Configurable via PORT env |
| UDP Port | 39001 | udp2.py | Hard-coded |
| Test Account ID | 100000001 | tcp.py | Master account |
| Test Token | GUEST_TOKEN_* | tcp.py | Dummy token (insecure) |
| Default Region | "IN" | tcp.py | India |
| TTL | 31536000 | tcp.py | 1 year (unrealistic) |
| Frame Timeout | 5.0s | tcp.py | Socket read timeout |
| Buffer Size | 16384 | tcp.py | Max frame size |

---

## IX. Next Steps

**Immediate** (this session):
1. ✅ Index repository and create subsystem map
2. ✅ Identify protocol mismatches
3. 🔲 Locate debug logs (if available)
4. 🔲 Search for message ID dispatcher

**Short-term** (Phase 1):
1. Implement MajorLoginRes encoder
2. Validate frame format
3. Add LoginReq parser
4. Create message ID dispatcher

**Medium-term** (Phase 2):
1. Implement TCP_HEARTBEAT handler
2. Add session management
3. Implement message routing
4. Add database persistence

**Long-term** (Phase 3+):
1. Implement all remaining message types
2. Add UDP sync layer
3. Implement game logic
4. Performance optimization

---

## X. Working Rules (For This Project)

**DO**:
- ✅ Use IL2CPP dump as source of truth
- ✅ Verify every change against dump or logs
- ✅ Keep implementation simple and readable
- ✅ Document assumptions separately from confirmed facts
- ✅ Work subsystem by subsystem

**DON'T**:
- ❌ Invent protocol behavior without evidence
- ❌ Redesign project structure unnecessarily
- ❌ Introduce complex abstractions
- ❌ Mix concerns (HTTP + binary)
- ❌ Make batch changes without verification

---

**Document Version**: 1.0  
**Last Updated**: 2026-08-14  
**Status**: Ready for Phase 1 Implementation
