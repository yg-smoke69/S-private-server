using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB3")]
public class IAPStoreDesc
{
	[Token(Token = "0x400A7FB")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A7FC")]
	[FieldOffset(Offset = "0xC")]
	public uint bundle_id;

	[Token(Token = "0x400A7FD")]
	[FieldOffset(Offset = "0x10")]
	public string bundle_name;

	[Token(Token = "0x400A7FE")]
	[FieldOffset(Offset = "0x14")]
	public uint price_item_id;

	[Token(Token = "0x400A7FF")]
	[FieldOffset(Offset = "0x18")]
	public float price;

	[Token(Token = "0x400A800")]
	[FieldOffset(Offset = "0x1C")]
	public uint discount_price_rebate_id;

	[Token(Token = "0x400A801")]
	[FieldOffset(Offset = "0x20")]
	public uint discount_price_item_id;

	[Token(Token = "0x400A802")]
	[FieldOffset(Offset = "0x24")]
	public float discount_price;

	[Token(Token = "0x400A803")]
	[FieldOffset(Offset = "0x28")]
	public float discount;

	[Token(Token = "0x400A804")]
	[FieldOffset(Offset = "0x2C")]
	public uint diamond_price;

	[Token(Token = "0x400A805")]
	[FieldOffset(Offset = "0x30")]
	public uint discount_diamond_price;

	[Token(Token = "0x400A806")]
	[FieldOffset(Offset = "0x34")]
	public uint diamond_bonus;

	[Token(Token = "0x400A807")]
	[FieldOffset(Offset = "0x38")]
	public bool is_remain_diamond;

	[Token(Token = "0x400A808")]
	[FieldOffset(Offset = "0x39")]
	public bool is_nonconsumable;

	[Token(Token = "0x400A809")]
	[FieldOffset(Offset = "0x3C")]
	public EStore.IapStoreType store_type;

	[Token(Token = "0x400A80A")]
	[FieldOffset(Offset = "0x40")]
	public string web_link;

	[Token(Token = "0x400A80B")]
	[FieldOffset(Offset = "0x44")]
	public uint activity_id;

	[Token(Token = "0x6008110")]
	[Address(RVA = "0x30A3B08", Offset = "0x30A3B08", VA = "0x30A3B08")]
	public IAPStoreDesc()
	{
	}
}
