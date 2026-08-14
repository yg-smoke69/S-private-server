using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB7")]
public class PayBundleWindowDesc
{
	[Token(Token = "0x400A81D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A81E")]
	[FieldOffset(Offset = "0xC")]
	public uint index_id;

	[Token(Token = "0x400A81F")]
	[FieldOffset(Offset = "0x10")]
	public uint price_item_id;

	[Token(Token = "0x400A820")]
	[FieldOffset(Offset = "0x14")]
	public float price;

	[Token(Token = "0x400A821")]
	[FieldOffset(Offset = "0x18")]
	public uint discount_price_rebate_id;

	[Token(Token = "0x400A822")]
	[FieldOffset(Offset = "0x1C")]
	public uint discount_price_item_id;

	[Token(Token = "0x400A823")]
	[FieldOffset(Offset = "0x20")]
	public float discount_price;

	[Token(Token = "0x400A824")]
	[FieldOffset(Offset = "0x24")]
	public uint rebate_percentage;

	[Token(Token = "0x400A825")]
	[FieldOffset(Offset = "0x28")]
	public uint limited_purchase;

	[Token(Token = "0x400A826")]
	[FieldOffset(Offset = "0x2C")]
	public uint purchase_times;

	[Token(Token = "0x400A827")]
	[FieldOffset(Offset = "0x30")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A828")]
	[FieldOffset(Offset = "0x34")]
	public EStore.RebateCardBillStatus status;

	[Token(Token = "0x400A829")]
	[FieldOffset(Offset = "0x38")]
	public uint diamond_price;

	[Token(Token = "0x400A82A")]
	[FieldOffset(Offset = "0x3C")]
	public uint diamond_discount_price;

	[Token(Token = "0x400A82B")]
	[FieldOffset(Offset = "0x40")]
	public uint start_timestamp;

	[Token(Token = "0x400A82C")]
	[FieldOffset(Offset = "0x44")]
	public uint end_timestamp;

	[Token(Token = "0x400A82D")]
	[FieldOffset(Offset = "0x48")]
	public EStore.BundleRefreshType refresh_type;

	[Token(Token = "0x400A82E")]
	[FieldOffset(Offset = "0x4C")]
	public uint tag;

	[Token(Token = "0x400A82F")]
	[FieldOffset(Offset = "0x50")]
	public string bundle_name;

	[Token(Token = "0x400A830")]
	[FieldOffset(Offset = "0x54")]
	public EStore.PbwActivityType activity_type;

	[Token(Token = "0x400A831")]
	[FieldOffset(Offset = "0x58")]
	public string cdn;

	[Token(Token = "0x400A832")]
	[FieldOffset(Offset = "0x5C")]
	public uint rebate_card_end_timestamp;

	[Token(Token = "0x6008114")]
	[Address(RVA = "0x33DF0BC", Offset = "0x33DF0BC", VA = "0x33DF0BC")]
	public PayBundleWindowDesc()
	{
	}
}
