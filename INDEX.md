# Sigma Preservation Project: Documentation Index

**Repository**: yg-smoke69/S-private-server  
**Project**: Game Server Reverse Engineering & Preservation  
**Status**: Phase 1 - Protocol Reconstruction (Investigation Phase)  
**Date**: 2026-08-14

---

## 📚 Documentation Files

### Start Here
1. **[README.md](README.md)** - Original repository description
2. **[ORGANIZATION.md](ORGANIZATION.md)** - How files are organized into 10 categories

### Protocol & Architecture
3. **[ENGINEERING_BRIEF.md](ENGINEERING_BRIEF.md)** ⭐ **PRIMARY DOCUMENT**
   - Complete protocol analysis
   - All 5 critical mismatches identified
   - Architecture diagrams
   - Evidence sources and priority tasks

4. **[SUBSYSTEM_MAP.md](SUBSYSTEM_MAP.md)** - Quick reference guide
   - Directory tree with component descriptions
   - Message type categories
   - File search patterns
   - "Where to find things"

### Implementation
5. **[PHASE_1_TASKS.md](PHASE_1_TASKS.md)** - Detailed task breakdown
   - Investigation phase (4 verification tasks)
   - Implementation phase (5 coding tasks)
   - Integration & testing
   - Success criteria

---

## 🎯 Quick Navigation

### I Need To Understand...

**The Protocol**:
→ Read: `ENGINEERING_BRIEF.md` § III (Protocol Architecture)

**The Architecture**:
→ Read: `ENGINEERING_BRIEF.md` § V (Subsystem Map - Detailed)

**What's Wrong With Current Code**:
→ Read: `ENGINEERING_BRIEF.md` § IV (Critical Protocol Mismatches)

**Where To Find Files**:
→ Read: `SUBSYSTEM_MAP.md` (Quick Reference + Directory Tree)

**What To Do First**:
→ Read: `PHASE_1_TASKS.md` § Investigation Phase

**How To Fix It**:
→ Read: `PHASE_1_TASKS.md` § Implementation Phase

---

## 📊 Key Statistics

| Metric | Value | Note |
|--------|-------|------|
| Total Files | ~12,817 | Organized into 10 categories |
| Core Files | 4,276 | Game logic + protocol |
| Gameplay Files | 7,381 | Game mechanics (largest category) |
| Network Messages | 190 | TCP message types |
| Protobuf Messages | 700+ | Message definitions |
| Python Server | 6 | Minimal reference implementation |

---

## 🔴 Critical Issues Summary

| Issue | Severity | Evidence | Action |
|-------|----------|----------|--------|
| Message ID Mapping Unknown | 🔴 HIGH | IL2CPP: TCPMessageIDReserved | Task 0.1: Verify ID 1002 |
| MajorLoginRes Incomplete | 🔴 HIGH | IL2CPP: MajorLoginRes.cs | Task 1.1: Implement 18 fields |
| HTTP Routing Wrong | 🔴 HIGH | Prototype vs Protocol | Task 1.3: Fix dispatcher |
| LoginReq Not Parsed | 🟡 MEDIUM | IL2CPP: LoginReq.cs | Task 1.2: Add parser |
| Session Mgmt Missing | 🟡 MEDIUM | No token validation | Phase 2: Add database |

---

## 🧭 Execution Path

```
START
  ↓
1. Read ENGINEERING_BRIEF.md (30 min)
   - Understand protocol architecture
   - Review 5 mismatches
   
2. Read SUBSYSTEM_MAP.md (15 min)
   - Know where to find things
   - Understand file organization
   
3. Read PHASE_1_TASKS.md (20 min)
   - Review investigation checklist
   - Plan implementation
   
4. Execute Investigation Phase (2-4 hours)
   - Task 0.1: Search for Message ID 1002
   - Task 0.2: Find message dispatcher
   - Task 0.3: Verify frame format
   - Task 0.4: Find nested message types
   
5. Execute Implementation Phase (4-8 hours)
   - Task 1.1: Implement MajorLoginRes encoder
   - Task 1.2: Add LoginReq parser
   - Task 1.3: Build message dispatcher
   - Task 1.4: Validate frame format
   - Task 1.5: Remove HTTP cruft
   
6. Testing & Integration (2-4 hours)
   - Task 2.1: Integration tests
   - Task 2.2: Binary comparison
   
PHASE 1 COMPLETE ✅
  ↓
Move to Phase 2: Transport Validation
```

---

## 🔍 Evidence Hierarchy

**Always prioritize in this order**:

1. **IL2CPP Dump** (Primary Truth)
   - Location: `/Core/proto/` - Message definitions
   - Location: `/Core/GCommon/` - Message IDs
   - Location: `/Networking/tcp/` - Message types

2. **Working Server Logs** (Secondary)
   - Location: Unknown (search for "debug", "log", "capture")
   - Look for: Packet captures, debug output, server logs

3. **Protobuf Definitions** (Tertiary)
   - Location: `/Core/proto/` (~700 .cs files)
   - Use: Verify field types and structure

4. **Prototype Code** (Reference Only)
   - Location: `/sp server/`
   - Status: Likely incorrect, use as baseline only

---

## 🛠️ Tools & Commands

### Search for Protocol Details
```bash
# Find message ID references
grep -r "1002\|0x3EA" /workspaces/S-private-server/

# Find dispatcher
grep -r "switch.*case\|MessageID\|CommandID" /workspaces/S-private-server/Core/GCommon

# Find frame format references
grep -r "0xFEFF\|FEFF\|Magic" /workspaces/S-private-server/

# Find nested types
find /workspaces/S-private-server -name "BlacklistInfoRes.cs" -o -name "LoginQueueInfo.cs"
```

### Test Protocol Changes
```bash
# Test encoding
python3 -c "import tcp; print(tcp.build_mono_major_login_payload().hex())"

# Compare outputs
diff <(python3 sp_server/tcp.py < old_request.bin) \
     <(python3 sp_server/tcp.py < new_request.bin)
```

---

## 📋 Checklist: Before Starting Phase 1

- [ ] Read ENGINEERING_BRIEF.md completely
- [ ] Understand 5 protocol mismatches
- [ ] Know where MajorLoginRes.cs is located
- [ ] Know where LoginReq.cs is located
- [ ] Know where TCPMessageIDReserved.cs is located
- [ ] Understand Protobuf varint encoding
- [ ] Have Python environment ready
- [ ] Have grep/search tools available

---

## 🚀 Phase 1 Goals

**Goal**: Make server protocol match IL2CPP dump exactly

**Definition of Done**:
- ✅ MajorLoginRes: 18/18 fields encoded correctly
- ✅ LoginReq: 40+/40+ fields parsed correctly
- ✅ Message dispatcher: Routes by ID (not HTTP path)
- ✅ Frame format: Validated against IL2CPP
- ✅ Client: Accepts server response without errors
- ✅ Protocol: Pure TCP binary (no HTTP cruft)

**Metrics**:
- Lines of code changed: ~200-300
- Test coverage: 100% of happy path
- Breaking changes: Yes (HTTP routing removed)

---

## 📖 Reference

### Protobuf Concepts
- **Varint Encoding**: Integer compression using 7-bit chunks
- **Field Key**: `(field_number << 3) | wire_type`
  - wire_type 0 = varint (integers)
  - wire_type 2 = delimited (strings, nested)
- **Repeated Fields**: Same field key repeated multiple times

### TCP Protocol Layers
```
Layer 4: Application (MajorLoginRes, LoginReq, etc.)
Layer 3: Message Frame (0xFEFF + ID + Length + Protobuf)
Layer 2: TCP/HTTP (Port 8080)
Layer 1: Network Socket
```

### Key Files at a Glance
| Purpose | File | Lines |
|---------|------|-------|
| Message IDs | `Core/GCommon/TCPMessageIDReserved.cs` | 10 |
| Login Response Struct | `Core/proto/MajorLoginRes.cs` | 50 |
| Login Request Struct | `Core/proto/LoginReq.cs` | 150+ |
| Network Handler | `sp server/tcp.py` | 165 |
| Server Orchestrator | `sp server/server.py` | 30 |

---

## ❓ FAQ

**Q: Where do I start?**  
A: Read ENGINEERING_BRIEF.md, then PHASE_1_TASKS.md § Investigation Phase

**Q: Is the current server code correct?**  
A: No. It has 5 critical mismatches with the IL2CPP protocol definition.

**Q: Should I keep HTTP support?**  
A: Not for protocol correctness. Keep it as legacy fallback only.

**Q: How do I know my changes are correct?**  
A: Test against IL2CPP expectations (compare bytes) or with actual client.

**Q: What if I can't find the message ID dispatcher?**  
A: It might be in compiled IL2CPP code (not readable source). Try:
- Search for "MajorLogin" handler
- Look for message routing table
- Check network manager classes

**Q: Can I use the prototype as-is?**  
A: No. It's incomplete and incorrect. Use it as a baseline reference only.

**Q: What if there are bugs in my implementation?**  
A: Test against IL2CPP expectations. If it matches the dump, it's correct.

---

## 📞 Support

If stuck on:

**Investigation Phase**:
- Search IL2CPP dump more thoroughly
- Check IFix hooks and compiler mappings
- Look at Unity networking patterns

**Implementation Phase**:
- Verify field encoding with hex dumps
- Test varint encoding separately
- Compare byte-by-byte with prototype

**Integration Phase**:
- Use wireshark or tcpdump to capture packets
- Compare wire format with IL2CPP expectations
- Add verbose logging to track parsing

---

## 🔗 Document Links

**Quick Links**:
- [Engineering Brief (Full Protocol Analysis)](ENGINEERING_BRIEF.md)
- [Subsystem Map (File Reference)](SUBSYSTEM_MAP.md)
- [Phase 1 Task Breakdown](PHASE_1_TASKS.md)
- [File Organization](ORGANIZATION.md)

**IL2CPP Source References**:
- [TCP Message IDs](Core/GCommon/TCPMessageIDReserved.cs)
- [Login Response](Core/proto/MajorLoginRes.cs)
- [Login Request](Core/proto/LoginReq.cs)
- [TCP Messages](Networking/tcp/)

**Prototype Code**:
- [Server Main](sp%20server/server.py)
- [TCP Handler](sp%20server/tcp.py)

---

## 📝 Version History

| Version | Date | Changes |
|---------|------|---------|
| 1.0 | 2026-08-14 | Initial indexing and analysis |

---

**Status**: Ready for Phase 1 Investigation & Implementation  
**Next Action**: Read ENGINEERING_BRIEF.md
