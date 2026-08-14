using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000123")]
internal class EPPriceData : CSVBaseData
{
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x8")]
	public string Key;

	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0xC")]
	public uint CostValue;

	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x10")]
	public uint BundleValue;

	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x14")]
	public uint BundleBadge;

	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x18")]
	public uint BundleRewardItem1;

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x1C")]
	public uint BundleRewardNum1;

	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x20")]
	public uint BundleRewardTime1;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x24")]
	public EInventory.CurrencyType CostType;

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x2519AE4", Offset = "0x2519AE4", VA = "0x2519AE4")]
	public EPPriceData()
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x2519B68", Offset = "0x2519B68", VA = "0x2519B68", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x2519BC0", Offset = "0x2519BC0", VA = "0x2519BC0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x2519FFC", Offset = "0x2519FFC", VA = "0x2519FFC")]
	public static EPPriceData GetUpgradeToEPPrice(uint EPEventID)
	{
		return null;
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x251A278", Offset = "0x251A278", VA = "0x251A278")]
	public static uint GetBundlePrice(uint EPEventID)
	{
		return default(uint);
	}
}
