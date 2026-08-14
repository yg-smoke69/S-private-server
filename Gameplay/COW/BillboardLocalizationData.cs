using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000C8")]
public class BillboardLocalizationData : CSVBaseData
{
	[Token(Token = "0x40004BD")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x40004BE")]
	[FieldOffset(Offset = "0xC")]
	public string BillboardServerAdd;

	[Token(Token = "0x600057C")]
	[Address(RVA = "0x180B1C4", Offset = "0x180B1C4", VA = "0x180B1C4")]
	public BillboardLocalizationData()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x180B248", Offset = "0x180B248", VA = "0x180B248", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x180B2A0", Offset = "0x180B2A0", VA = "0x180B2A0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
