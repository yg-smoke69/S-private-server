using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E3")]
public class FlightData : CSVBaseData, _Attribute
{
	[Token(Token = "0x20000E4")]
	public enum EFlightParentTransform
	{
		[Token(Token = "0x4000580")]
		EFlightParentTransform_Bip,
		[Token(Token = "0x4000581")]
		EFlightParentTransform_Toe
	}

	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID previewRes;

	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID inGameRes;

	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID inGameRes3P;

	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID OpenParaSoundID;

	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID DivingOnceSoundID;

	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID DivingLoopSoundID;

	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID AccBoardOnceSoundID;

	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID AccBoardLoopSoundID;

	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID AccParaOnceSoundID;

	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x34")]
	public ResourceID AccParaLoopSoundID;

	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x38")]
	public ResourceID ParaLoopSoundID;

	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x3C")]
	public ResourceID AnimID;

	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID FemaleAnimID;

	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x44")]
	public EFlightParentTransform ParentTransformID;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x48")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x49")]
	public bool EnableFlightShow;

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xDEC67C", Offset = "0xDEC67C", VA = "0xDEC67C")]
	public FlightData()
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xDEC7D8", Offset = "0xDEC7D8", VA = "0xDEC7D8", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xDEC830", Offset = "0xDEC830", VA = "0xDEC830", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xDEC894", Offset = "0xDEC894", VA = "0xDEC894", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
