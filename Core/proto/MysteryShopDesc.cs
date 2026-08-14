using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC1")]
public class MysteryShopDesc
{
	[Token(Token = "0x400A86F")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A870")]
	[FieldOffset(Offset = "0xC")]
	public uint mystery_shop_pool_id;

	[Token(Token = "0x400A871")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400A872")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400A873")]
	[FieldOffset(Offset = "0x18")]
	public uint award_time;

	[Token(Token = "0x400A874")]
	[FieldOffset(Offset = "0x1C")]
	public uint gems_price;

	[Token(Token = "0x400A875")]
	[FieldOffset(Offset = "0x20")]
	public uint limited_purchase_times;

	[Token(Token = "0x400A876")]
	[FieldOffset(Offset = "0x24")]
	public string reward_cdn;

	[Token(Token = "0x400A877")]
	[FieldOffset(Offset = "0x28")]
	public bool big_reward;

	[Token(Token = "0x400A878")]
	[FieldOffset(Offset = "0x2C")]
	public string share_cdn;

	[Token(Token = "0x400A879")]
	[FieldOffset(Offset = "0x30")]
	public EInventory.AwardType repeat_change_item_type;

	[Token(Token = "0x400A87A")]
	[FieldOffset(Offset = "0x34")]
	public uint repeat_change_item_id;

	[Token(Token = "0x400A87B")]
	[FieldOffset(Offset = "0x38")]
	public uint repeat_change_item_num;

	[Token(Token = "0x400A87C")]
	[FieldOffset(Offset = "0x3C")]
	public string language;

	[Token(Token = "0x600811E")]
	[Address(RVA = "0x30A98C8", Offset = "0x30A98C8", VA = "0x30A98C8")]
	public MysteryShopDesc()
	{
	}
}
