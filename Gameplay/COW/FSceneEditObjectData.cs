using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2003219")]
public class FSceneEditObjectData
{
	[Token(Token = "0x40130F9")]
	[FieldOffset(Offset = "0x8")]
	public uint Index;

	[Token(Token = "0x40130FA")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemID;

	[Token(Token = "0x40130FB")]
	[FieldOffset(Offset = "0x10")]
	public uint Direction;

	[Token(Token = "0x40130FC")]
	[FieldOffset(Offset = "0x14")]
	public uint FreeDirection;

	[Token(Token = "0x40130FD")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Position;

	[Token(Token = "0x40130FE")]
	[FieldOffset(Offset = "0x24")]
	public uint LevelObjectIDByTag;

	[Token(Token = "0x40130FF")]
	[FieldOffset(Offset = "0x28")]
	public string LogicEntityID;

	[Token(Token = "0x4013100")]
	[FieldOffset(Offset = "0x2C")]
	public string CustomizedName;

	[Token(Token = "0x4013101")]
	[FieldOffset(Offset = "0x30")]
	public uint ResetPerRound;

	[Token(Token = "0x4013102")]
	[FieldOffset(Offset = "0x34")]
	public string Color;

	[Token(Token = "0x4013103")]
	[FieldOffset(Offset = "0x38")]
	public FSceneEditObjectTeleportDoorData doorData;

	[Token(Token = "0x4013104")]
	[FieldOffset(Offset = "0x3C")]
	public FSceneEditObjectBuffData buffData;

	[Token(Token = "0x4013105")]
	[FieldOffset(Offset = "0x40")]
	public FSceneEditObjectMusicElementData musicData;

	[Token(Token = "0x4013106")]
	[FieldOffset(Offset = "0x44")]
	public FSceneEditObjectMoveObjectData moveData;

	[Token(Token = "0x4013107")]
	[FieldOffset(Offset = "0x48")]
	public FSceneEditObjectScaleData scaleData;

	[Token(Token = "0x4013108")]
	[FieldOffset(Offset = "0x4C")]
	public FSceneEditObjectTriggerData triggerData;

	[Token(Token = "0x4013109")]
	[FieldOffset(Offset = "0x50")]
	public FSceneEditObjectItemBoxData itemboxData;

	[Token(Token = "0x401310A")]
	[FieldOffset(Offset = "0x54")]
	public KAPNFHPPLLE miniSentryData;

	[Token(Token = "0x401310B")]
	[FieldOffset(Offset = "0x58")]
	public MJJIPKJLIOJ customPathData;

	[Token(Token = "0x401310C")]
	[FieldOffset(Offset = "0x5C")]
	public LEMLJJPLPAL botGenData;

	[Token(Token = "0x401310D")]
	[FieldOffset(Offset = "0x60")]
	public FSceneEditObjectBigToyBallData ballData;

	[Token(Token = "0x6015210")]
	[Address(RVA = "0xDE2FD8", Offset = "0xDE2FD8", VA = "0xDE2FD8")]
	public FSceneEditObjectData()
	{
	}

	[Token(Token = "0x6015211")]
	[Address(RVA = "0xDE30D8", Offset = "0xDE30D8", VA = "0xDE30D8")]
	public static FSceneEditObjectData FromProtoData(float mapGridWidth, JCPEKHFBFNI protoData)
	{
		return null;
	}
}
