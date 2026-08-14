using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D76")]
public class PayItemData
{
	[Token(Token = "0x401170E")]
	[FieldOffset(Offset = "0x8")]
	public string ItemIdentifier;

	[Token(Token = "0x401170F")]
	[FieldOffset(Offset = "0xC")]
	public int VirtualCurrencyCount;

	[Token(Token = "0x4011710")]
	[FieldOffset(Offset = "0x10")]
	public int BonusVirtualCurrencyCount;

	[Token(Token = "0x4011711")]
	[FieldOffset(Offset = "0x14")]
	public int PromotionVirtualCurrencyCount;

	[Token(Token = "0x4011712")]
	[FieldOffset(Offset = "0x18")]
	public float CostAmount;

	[Token(Token = "0x4011713")]
	[FieldOffset(Offset = "0x1C")]
	public string CostString;

	[Token(Token = "0x4011714")]
	[FieldOffset(Offset = "0x20")]
	public string CdnUrl;

	[Token(Token = "0x4011715")]
	[FieldOffset(Offset = "0x24")]
	public string ResourceName;

	[Token(Token = "0x4011716")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID ResourceId;

	[Token(Token = "0x4011717")]
	[FieldOffset(Offset = "0x2C")]
	public Subscription Subscription;

	[Token(Token = "0x4011718")]
	[FieldOffset(Offset = "0x30")]
	public long RebateId;

	[Token(Token = "0x601308C")]
	[Address(RVA = "0x2DBD3C8", Offset = "0x2DBD3C8", VA = "0x2DBD3C8")]
	public PayItemData()
	{
	}

	[Token(Token = "0x601308D")]
	[Address(RVA = "0x2DBD494", Offset = "0x2DBD494", VA = "0x2DBD494")]
	public static string Brief(PayItemData data)
	{
		return null;
	}

	[Token(Token = "0x601308E")]
	[Address(RVA = "0x2DBD7EC", Offset = "0x2DBD7EC", VA = "0x2DBD7EC")]
	public static string Detail(PayItemData data)
	{
		return null;
	}
}
