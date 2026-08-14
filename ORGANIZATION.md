# Project Organization Structure

This document outlines how the extracted files have been organized into logical categories.

## Directory Structure

### 📁 **Core** (4,276 files)
Core game logic, utilities, and infrastructure
- `ECA` - Entity Component Architecture
- `GCommon` - Common utilities and base classes
- `GCommon.Ads` - Advertisement system
- `GCommon.CommandPattern` - Command pattern implementation
- `GCommon.Obfuscate` - Code obfuscation utilities
- `GCommon.Trails` - Trail effects
- `GCommon.UGCUI` - User Generated Content UI
- `IFix` - Hot fix system
- `message` - Message protocol definitions
- `proto` - Protocol buffers

### 🎮 **Gameplay** (7,381 files)
Game mechanics, AI, level design, and game rules
- `COW.Gameplay` - Core gameplay systems
- `COW.Gameplay.LevelObject` - Level object definitions
- `COW.Gameplay.MultiplayerGame` - Multiplayer game logic
- `COW.Gameplay.UGC` - User Generated Content gameplay
- `COW.SingerBTimeLine` - Timeline-based events
- Various AI, zombie, trigger, and item systems

### 🎨 **Graphics** (111 files)
Rendering, visual effects, and graphics systems
- `COW.Graphics` - Graphics pipeline
- `AmplifyColor` - Post-processing effects
- `DecalAtlas` - Decal management
- Rendering nodes, shaders, materials, lighting

### 🔊 **Audio** (263 files)
Sound, music, and voice systems
- `AK.Wwise` - Wwise audio engine
- `WwiseGameSyncs` - Audio synchronization
- `FFVoice` - Voice system
- `GarenaMSDKUnity.GMSDK` - Garena audio SDK
- Audio synthesis and management

### 🖥️ **UI** (165 files)
User Interface and HUD systems
- `COW.HUD` - Heads-up display
- `ReactUI` - React-based UI components
- UI controllers, menus, panels, and buttons

### 🌐 **Networking** (294 files)
Network communication and multiplayer infrastructure
- `InterApp` - Inter-application communication
- `tcp` - TCP networking protocol
- Synchronization systems for multiplayer

### 💾 **DataFormats** (89 files)
Data serialization and file format handling
- `ICSharpCode.SharpZipLib` - ZIP archive handling
- `LumenWorks.Framework.IO.Csv` - CSV parsing
- `LitJson` - JSON serialization
- `SimpleJSON` - Simple JSON library

### 📦 **ThirdParty** (181 files)
External libraries and SDKs
- `UMA` - Unity Multipurpose Avatar system
- `UMACharacterSystem` - Character system
- `UnityStandardAssets` - Standard Unity assets
- `Unity.Collections` - Unity collections library
- `GarenaMSDK` - Garena SDK

### 🛠️ **Utilities** (9 files)
Helper functions and utility systems
- `WorldStreamer` - World streaming system
- `OrbCreationExtensions` - Orb creation utilities
- `FFTools` - Custom tools
- `FF_TA` - Animation tools

### 📄 **Miscellaneous** (49 files)
Uncategorized or special-purpose code
- `svma-main` - SVMA project
- `ffano` - FF animation
- `TsiU` - Additional utilities
- Private implementation details

## File Statistics
- **Total Files**: ~12,817
- **Total Categories**: 10
- **Largest Category**: Gameplay (57% of files)
- **Smallest Category**: Utilities (0.07% of files)

## Usage
Navigate to the appropriate folder based on what you're looking for:
- Modifying game mechanics? → **Gameplay**
- Working on graphics? → **Graphics**
- Adding audio? → **Audio**
- Creating UI? → **UI**
- Network features? → **Networking**
- Core functionality? → **Core**
