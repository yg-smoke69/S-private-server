using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B1A")]
public class SubscribeStoreDesc
{
	[Token(Token = "0x400AA4E")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400AA4F")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x400AA50")]
	[FieldOffset(Offset = "0x10")]
	public long added_time;

	[Token(Token = "0x400AA51")]
	[FieldOffset(Offset = "0x18")]
	public long expire_time;

	[Token(Token = "0x400AA52")]
	[FieldOffset(Offset = "0x20")]
	public ESubscription.SubscribeType subscribe_type;

	[Token(Token = "0x400AA53")]
	[FieldOffset(Offset = "0x24")]
	public uint item_id;

	[Token(Token = "0x400AA54")]
	[FieldOffset(Offset = "0x28")]
	public string item_name;

	[Token(Token = "0x400AA55")]
	[FieldOffset(Offset = "0x2C")]
	public uint price_item_id;

	[Token(Token = "0x400AA56")]
	[FieldOffset(Offset = "0x30")]
	public uint price_rebate_id;

	[Token(Token = "0x400AA57")]
	[FieldOffset(Offset = "0x34")]
	public float price;

	[Token(Token = "0x400AA58")]
	[FieldOffset(Offset = "0x38")]
	public ESubscription.PriceType price_type;

	[Token(Token = "0x400AA59")]
	[FieldOffset(Offset = "0x3C")]
	public ESubscription.TagType tag_type;

	[Token(Token = "0x400AA5A")]
	[FieldOffset(Offset = "0x40")]
	public string icon_url;

	[Token(Token = "0x400AA5B")]
	[FieldOffset(Offset = "0x44")]
	public string preview_url;

	[Token(Token = "0x400AA5C")]
	[FieldOffset(Offset = "0x48")]
	public uint subscribe_bonus;

	[Token(Token = "0x400AA5D")]
	[FieldOffset(Offset = "0x4C")]
	public string language;

	[Token(Token = "0x400AA5E")]
	[FieldOffset(Offset = "0x50")]
	public string real_icon_url;

	[Token(Token = "0x400AA5F")]
	[FieldOffset(Offset = "0x54")]
	public string real_preview_url;

	[Token(Token = "0x400AA60")]
	[FieldOffset(Offset = "0x58")]
	public float intro_price;

	[Token(Token = "0x400AA61")]
	[FieldOffset(Offset = "0x5C")]
	public uint intro_time;

	[Token(Token = "0x400AA62")]
	[FieldOffset(Offset = "0x60")]
	public uint ep_value_gems;

	[Token(Token = "0x400AA63")]
	[FieldOffset(Offset = "0x64")]
	public uint ep_award_id1;

	[Token(Token = "0x400AA64")]
	[FieldOffset(Offset = "0x68")]
	public uint ep_award_id2;

	[Token(Token = "0x400AA65")]
	[FieldOffset(Offset = "0x6C")]
	public uint ep_award_id3;

	[Token(Token = "0x400AA66")]
	[FieldOffset(Offset = "0x70")]
	public uint ep_award_id4;

	[Token(Token = "0x400AA67")]
	[FieldOffset(Offset = "0x74")]
	public uint ep_award_id5;

	[Token(Token = "0x400AA68")]
	[FieldOffset(Offset = "0x78")]
	public uint ep_award_id6;

	[Token(Token = "0x6008175")]
	[Address(RVA = "0x33E2C8C", Offset = "0x33E2C8C", VA = "0x33E2C8C")]
	public SubscribeStoreDesc()
	{
	}
}
