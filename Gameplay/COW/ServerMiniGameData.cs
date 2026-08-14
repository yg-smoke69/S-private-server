using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using SimpleJSON;

namespace COW;

[Token(Token = "0x200024E")]
public class ServerMiniGameData : _Attribute
{
	[Token(Token = "0x4000DFA")]
	[FieldOffset(Offset = "0x8")]
	public uint GameType;

	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID MarkIconRes;

	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x10")]
	public string GameTitleKey;

	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x14")]
	public uint RewardActivitId;

	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x18")]
	public uint RewardItemId;

	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x1C")]
	public uint RewardItemNum;

	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID RewardIconRes;

	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x24")]
	public List<ResourceID> EffectResList;

	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x28")]
	public uint BigEventId;

	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x20DEC58", Offset = "0x20DEC58", VA = "0x20DEC58")]
	public ServerMiniGameData()
	{
	}

	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x20DEC60", Offset = "0x20DEC60", VA = "0x20DEC60", Slot = "4")]
	public void LoadDataFromJsonData(JSONNode jObject)
	{
	}
}
