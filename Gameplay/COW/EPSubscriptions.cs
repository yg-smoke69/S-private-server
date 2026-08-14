using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000124")]
internal class EPSubscriptions : CSVBaseData
{
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000773")]
	[FieldOffset(Offset = "0xC")]
	public string Price;

	[Token(Token = "0x4000774")]
	[FieldOffset(Offset = "0x10")]
	public int RebateID;

	[Token(Token = "0x4000775")]
	[FieldOffset(Offset = "0x14")]
	public int ItemID;

	[Token(Token = "0x4000776")]
	[FieldOffset(Offset = "0x18")]
	public int SubscribeBonus;

	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x1C")]
	public PayItemData SubscriptionFromCSV;

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x251AABC", Offset = "0x251AABC", VA = "0x251AABC")]
	public EPSubscriptions()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x251AB40", Offset = "0x251AB40", VA = "0x251AB40", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x251ABA4", Offset = "0x251ABA4", VA = "0x251ABA4")]
	public static string FormatPrimaryKey(string region, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x251ACB8", Offset = "0x251ACB8", VA = "0x251ACB8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x251AED0", Offset = "0x251AED0", VA = "0x251AED0")]
	public static string Detail(EPSubscriptions epSubscriptions)
	{
		return null;
	}
}
