# Sigma Project: Subsystem Quick Reference

## Directory Tree & Component Map

```
S-private-server/
├── sp server/                          [PROTOTYPE SERVER - Python]
│   ├── server.py                       └─ Main orchestrator (TCP + UDP threads)
│   ├── tcp.py                          └─ HTTP/Binary protocol handler (165 lines)
│   ├── udp2.py                         └─ UDP echo server (real-time sync)
│   ├── init_db.py                      └─ SQLite setup
│   ├── requirements.txt                └─ Dependencies: Flask, requests
│   └── data/                           └─ SQLite database
│
├── Core/                               [GAME LOGIC & PROTOCOL - 4,276 files]
│   ├── proto/                          └─ Protobuf message definitions (~700 files)
│   │   ├── MajorLoginRes.cs           └─ Authentication response (18 fields)
│   │   ├── LoginReq.cs                └─ Authentication request (40+ fields)
│   │   ├── LoginRes.cs                └─ Secondary login response
│   │   └── ...
│   ├── message/                        └─ Message type definitions (~2000 files)
│   ├── GCommon/                        └─ Common utilities
│   │   ├── TCPMessageIDReserved.cs    └─ Protocol message type IDs (CRITICAL)
│   │   ├── UDPMessageIDReserved.cs    └─ UDP message type IDs
│   │   ├── UDPSession.cs              └─ UDP session handling
│   │   └── ...
│   ├── ECA/                            └─ Entity Component Architecture
│   ├── IFix/                           └─ Hot fix system
│   └── ...
│
├── Networking/                         [NETWORK LAYER - 294 files]
│   ├── tcp/                            └─ TCP message definitions (~190 files)
│   │   ├── AccountRoleInfo.cs          
│   │   ├── RoomInfo.cs
│   │   ├── MatchmakingStartReq.cs
│   │   ├── *Req.cs                    └─ Client → Server requests
│   │   ├── *Rsp.cs                    └─ Server → Client responses
│   │   ├── *Ntf.cs                    └─ Server push notifications
│   │   └── ... (190 message types)
│   ├── InterApp/                       └─ Platform integrations
│   │   ├── FacebookAppInfo.cs
│   │   ├── LineAppInfo.cs
│   │   └── ...
│   └── NetworkFacade.cs
│
├── Gameplay/                           [GAME MECHANICS - 7,381 files]
│   ├── COW/                            └─ Core game code
│   ├── COW.Gameplay/                   └─ Gameplay systems
│   ├── COW.Gameplay.MultiplayerGame/   └─ Netplay mechanics
│   ├── COW.SingerBTimeLine/            └─ Timeline system
│   └── ... (AI, Zombies, Triggers)
│
├── Graphics/                           [RENDERING - 111 files]
│   ├── COW.Graphics/                   └─ Graphics pipeline
│   ├── AmplifyColor/                   └─ Post-processing
│   ├── DecalAtlas/                     └─ Decal management
│   └── ...
│
├── Audio/                              [AUDIO - 263 files]
│   ├── AK.Wwise/                       └─ Wwise audio engine
│   ├── WwiseGameSyncs/                 └─ Audio sync states
│   ├── FFVoice/                        └─ Voice system
│   └── ...
│
├── UI/                                 [USER INTERFACE - 165 files]
│   ├── COW.HUD/                        └─ Heads-up display
│   └── ReactUI/                        └─ Modern UI framework
│
├── DataFormats/                        [SERIALIZATION - 89 files]
│   ├── ICSharpCode.SharpZipLib/        └─ ZIP compression
│   ├── LitJson/                        └─ JSON library
│   ├── SimpleJSON/                     └─ JSON library
│   └── LumenWorks.Framework.IO.Csv/    └─ CSV parser
│
├── ThirdParty/                         [EXTERNAL SDKS - 181 files]
│   ├── UMA/                            └─ Character avatar system
│   ├── Garena*/                        └─ Platform SDKs
│   └── UnityStandardAssets/            └─ Unity systems
│
├── Miscellaneous/                      [OTHER - 49 files]
│   ├── ffano/                          └─ Animation utilities
│   ├── TsiU/                           └─ Additional utilities
│   └── *PrivateImplementationDetails/  └─ Compiler internals
│
├── Utilities/                          [HELPERS - 9 files]
│   ├── WorldStreamer/                  └─ Level streaming
│   └── ...
│
└── ORGANIZATION.md, ENGINEERING_BRIEF.md, README.md
```

---

## Protocol Stack Overview

```
┌──────────────────────────────────────────────────────┐
│ LAYER 4: Application Messages                        │
│ - MajorLoginRes (Auth)                               │
│ - LoginReq/LoginRes (Game Login)                      │
│ - RoomInfo, MatchmakingStartReq, etc.                │
│ - Encoded in Protobuf Varint Format                  │
└─────────────────────────────────────────────────────┬┘
                                                       │
┌──────────────────────────────────────────────────────┘
│ LAYER 3: Binary Frame Format
│ ┌──────┬──────┬──────┬──────────────┐
│ │Magic │ MsgID│ Len  │ Protobuf     │
│ │0xFEFF│(u16) │(u32) │ Payload      │
│ │ 2B   │ 2B   │ 4B   │ N bytes      │
│ └──────┴──────┴──────┴──────────────┘
└─────────────────────────────────────────────────────┬┘
                                                       │
┌──────────────────────────────────────────────────────┘
│ LAYER 2: TCP/HTTP Transport
│ - HTTP/1.1 Headers (wrapper)
│ - Binary payload in response body
│ - Connection: close
└─────────────────────────────────────────────────────┬┘
                                                       │
┌──────────────────────────────────────────────────────┘
│ LAYER 1: Network Socket
│ - TCP Port 8080
│ - TCP Port 8080 (HTTP GET/POST)
│ - UDP Port 39001 (real-time sync echo)
└──────────────────────────────────────────────────────┘
```

---

## Critical Files by Purpose

### Understanding Protocol
| Purpose | File | Lines | Key Content |
|---------|------|-------|------------|
| Message IDs | `Core/GCommon/TCPMessageIDReserved.cs` | 10 | TCP_INIT=1, TCP_HEARTBEAT=2, TCP_USER=3 |
| Login Response | `Core/proto/MajorLoginRes.cs` | 50 | 18 fields (account_id, token, regions, etc.) |
| Login Request | `Core/proto/LoginReq.cs` | 150+ | 40+ device/system info fields |
| Protocol Handler | `sp server/tcp.py` | 165 | Current binary/HTTP implementation |
| Main Server | `sp server/server.py` | 30 | Thread setup (TCP + UDP) |

### Understanding Game Systems
| System | File | Files | Purpose |
|--------|------|-------|---------|
| Gameplay | `Gameplay/COW/` | 500+ | Main game loop |
| Networking | `Networking/tcp/` | 190 | Message types |
| Economy | `Core/proto/*Desc.cs` | 100+ | Shop, gacha, currency |
| Progression | `Core/proto/*Desc.cs` | 50+ | Levels, rewards, pass |
| Events | `Core/proto/*Desc.cs` | 50+ | Activities, limited events |

### Finding Specific Components
| What You Need | Search Pattern | Example |
|---------------|---|---------|
| Message type | `Networking/tcp/<Name>.cs` | `RoomInfo.cs`, `MatchStartReq.cs` |
| Protobuf struct | `Core/proto/<Name>.cs` | `MajorLoginRes.cs`, `LoginReq.cs` |
| Game config | `Core/proto/*Desc.cs` | `MapDesc.cs`, `WeaponDesc.cs` |
| Message constants | `Core/GCommon/*Reserved.cs` | `TCPMessageIDReserved.cs` |
| Handler logic | `Gameplay/COW/` | `UIModelLogin.cs`, `UIGameScene.cs` |

---

## Protocol Message Categories (Networking/tcp/)

```
ACCOUNT SYSTEM (20+ messages)
├─ AccountRoleInfo
├─ AccountMatchInfo
├─ AccountLevelUpInfo
├─ AccountPrefersInfo
└─ ...

MATCHMAKING (15+ messages)
├─ MatchmakingStartReq/Rsp
├─ ChannelIDReq
├─ GroupCreateReq/GroupInfoReq
└─ ...

ROOM/LOBBY (25+ messages)
├─ RoomInfo
├─ RoomPlayerInfo
├─ RoomGroupInfo
└─ ...

ECONOMY (20+ messages)
├─ StoreInfo
├─ GachaInfo
├─ WalletInfo
└─ ...

EVENTS/ACTIVITIES (15+ messages)
├─ ActivityUpdateNtf
├─ ActivityBingoInfo
└─ ...

SOCIAL (20+ messages)
├─ FriendReq
├─ GroupMemberInfo
├─ ClanMemberInfo
└─ ...

GAMEPLAY (30+ messages)
├─ MatchEndInfo
├─ PlayerActionInfo
├─ GameEventInfo
└─ ...
```

---

## Known Mismatches (Phase 1 Issues)

| # | Component | Issue | Severity | Status |
|---|-----------|-------|----------|--------|
| 1 | Message ID | Using 1002 instead of TCP_USER(3)? | 🔴 HIGH | Needs verification |
| 2 | MajorLoginRes | Only 6/18 fields encoded | 🔴 HIGH | Incomplete |
| 3 | HTTP Routing | Path-based instead of message ID | 🔴 HIGH | Architectural issue |
| 4 | LoginReq Parser | No parsing/validation | 🟡 MEDIUM | Missing implementation |
| 5 | Session Mgmt | Hardcoded account/token | 🟡 MEDIUM | Not persistent |
| 6 | Token Format | Plain string instead of cryptographic | 🟡 MEDIUM | Security issue |
| 7 | UDP Server | Echo-only, no game sync | 🟢 LOW | Placeholder |

---

## Quick Start: Where to Find Things

**Q: How does the client connect?**  
A: `sp server/tcp.py` - Listens on port 8080, accepts HTTP or binary

**Q: What is MajorLogin?**  
A: First authentication response - defined in `Core/proto/MajorLoginRes.cs`

**Q: What fields does the client send?**  
A: LoginReq.cs - 40+ device/system info fields

**Q: How is data encoded?**  
A: Protobuf varint format - see `tcp.py` encode_varint functions

**Q: How does the server know which command to run?**  
A: Currently: HTTP path routing ("majorlogin", "createrole"). Should be: MessageID

**Q: Where is the game logic?**  
A: `/Gameplay/` folder (7,381 files)

**Q: Where are game configs?**  
A: `/Core/proto/` folder - `*Desc.cs` files (700+ files)

**Q: How do I find a message type?**  
A: Search in `/Networking/tcp/` or `/Core/proto/` by name

**Q: Where is the database?**  
A: `/sp server/data/` SQLite file (created by init_db.py)

---

## Evidence Trail (Source of Truth)

### ✅ CONFIRMED (From IL2CPP Dump)
- Message types: TCP_INIT, TCP_HEARTBEAT, TCP_USER
- MajorLoginRes has 18 fields (exact structure in proto file)
- LoginReq has 40+ fields with device fingerprinting
- Protobuf varint encoding (standard protobuf format)
- TCP port 8080, UDP port 39001

### ⚠️ ASSUMED (Not Yet Verified)
- Magic byte 0xFEFF for frame header
- MessageID is u16 in frame header
- Payload length is u32 BE
- Message ID 1002 → MajorLogin command

### ❌ MISSING (Need to Find)
- Actual message handler dispatch logic
- Command ID → function mapping
- Debug/working server logs
- Exact field ordering in responses
- Error handling and edge cases

---

## Phase 1 Execution Checklist

### Investigation
- [ ] Search IL2CPP dump for "1002" usage
- [ ] Find message dispatcher function
- [ ] Locate packet handling code
- [ ] Extract frame format definition

### Implementation  
- [ ] Update MajorLoginRes encoder with all 18 fields
- [ ] Implement LoginReq parser
- [ ] Add frame header validation
- [ ] Create message ID dispatcher
- [ ] Remove HTTP path routing

### Validation
- [ ] Test with client packets (if available)
- [ ] Verify frame format compliance
- [ ] Check encoding/decoding symmetry
- [ ] Validate error handling

### Documentation
- [ ] Document message format
- [ ] Create protocol spec
- [ ] Add examples
- [ ] Note any deviations

---

**Version**: 1.0  
**Last Updated**: 2026-08-14  
**Status**: Reference guide for Phase 1
