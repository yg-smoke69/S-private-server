using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E2")]
public class PayItemDisplay_iOS_Data : CSVBaseData
{
	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x8")]
	public string ItemIdentifier;

	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0xC")]
	public string CostString;

	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x10")]
	public string CostCurrency;

	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x14")]
	public float CostAmount;

	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x18")]
	public int VirtualCurrencyAmount;

	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x1C")]
	public int BonusVirtualCurrencyAmount;

	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x20")]
	public int FirstTimeBonusVirtualCurrencyAmount;

	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x24")]
	public string CdnUrlKey;

	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x28")]
	public string ResourceName;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID ResourceId;

	[Token(Token = "0x60009F5")]
	[Address(RVA = "0x2DBDC2C", Offset = "0x2DBDC2C", VA = "0x2DBDC2C")]
	public PayItemDisplay_iOS_Data()
	{
	}

	[Token(Token = "0x60009F6")]
	[Address(RVA = "0x2DBDCB0", Offset = "0x2DBDCB0", VA = "0x2DBDCB0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009F7")]
	[Address(RVA = "0x2DBDD30", Offset = "0x2DBDD30", VA = "0x2DBDD30", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
