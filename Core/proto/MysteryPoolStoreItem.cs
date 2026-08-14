using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001753")]
public class MysteryPoolStoreItem
{
	[Token(Token = "0x40099EB")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x40099EC")]
	[FieldOffset(Offset = "0xC")]
	public uint mystery_shop_pool_id;

	[Token(Token = "0x40099ED")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x40099EE")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x40099EF")]
	[FieldOffset(Offset = "0x18")]
	public uint award_time;

	[Token(Token = "0x40099F0")]
	[FieldOffset(Offset = "0x1C")]
	public uint gems_price;

	[Token(Token = "0x40099F1")]
	[FieldOffset(Offset = "0x20")]
	public uint limited_purchase_times;

	[Token(Token = "0x40099F2")]
	[FieldOffset(Offset = "0x24")]
	public string reward_cdn;

	[Token(Token = "0x40099F3")]
	[FieldOffset(Offset = "0x28")]
	public string share_cdn;

	[Token(Token = "0x40099F4")]
	[FieldOffset(Offset = "0x2C")]
	public uint purchased_cnt;

	[Token(Token = "0x40099F5")]
	[FieldOffset(Offset = "0x30")]
	public uint discount_price;

	[Token(Token = "0x6007DAD")]
	[Address(RVA = "0x30A977C", Offset = "0x30A977C", VA = "0x30A977C")]
	public MysteryPoolStoreItem()
	{
	}
}
