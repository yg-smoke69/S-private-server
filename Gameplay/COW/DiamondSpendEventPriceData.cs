using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000110")]
public class DiamondSpendEventPriceData : CSVBaseData
{
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0xC")]
	public float OriginalPrice;

	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x10")]
	public uint OriginalPriceItemId;

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x1C92898", Offset = "0x1C92898", VA = "0x1C92898")]
	public DiamondSpendEventPriceData()
	{
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x1C9291C", Offset = "0x1C9291C", VA = "0x1C9291C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x1C9299C", Offset = "0x1C9299C", VA = "0x1C9299C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
