using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001FD")]
public class PlatformPromotionProductsData : CSVBaseData
{
	[Token(Token = "0x4000BE8")]
	[FieldOffset(Offset = "0x8")]
	public uint ProductID;

	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0xC")]
	public string Channel;

	[Token(Token = "0x4000BEA")]
	[FieldOffset(Offset = "0x10")]
	public uint AwardId;

	[Token(Token = "0x4000BEB")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardNum;

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x1C06764", Offset = "0x1C06764", VA = "0x1C06764")]
	public PlatformPromotionProductsData()
	{
	}

	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x1C06830", Offset = "0x1C06830", VA = "0x1C06830", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A56")]
	[Address(RVA = "0x1C06894", Offset = "0x1C06894", VA = "0x1C06894", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
