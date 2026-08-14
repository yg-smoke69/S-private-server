using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000117")]
internal class EPBadgePriceData : CSVBaseData
{
	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x8")]
	public string RegionName;

	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0xC")]
	public uint EPEventID;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x10")]
	public uint CostValue;

	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x14")]
	public uint DiscountValue1;

	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x18")]
	public uint DiscountValue2;

	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x1C")]
	public uint DiscountValue3;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.CurrencyType CostType;

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x1C9A734", Offset = "0x1C9A734", VA = "0x1C9A734")]
	public EPBadgePriceData()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x1C9A7B8", Offset = "0x1C9A7B8", VA = "0x1C9A7B8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x1C9A89C", Offset = "0x1C9A89C", VA = "0x1C9A89C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x1C9ABB0", Offset = "0x1C9ABB0", VA = "0x1C9ABB0")]
	public static EPBadgePriceData GetPriceByRegion(uint eventID)
	{
		return null;
	}
}
