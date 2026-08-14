using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200174C")]
public class GiftItem
{
	[Token(Token = "0x40099D5")]
	[FieldOffset(Offset = "0x8")]
	public uint commodity_id;

	[Token(Token = "0x40099D6")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x40099D7")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x40099D8")]
	[FieldOffset(Offset = "0x14")]
	public uint coins_price;

	[Token(Token = "0x40099D9")]
	[FieldOffset(Offset = "0x18")]
	public uint gems_price;

	[Token(Token = "0x40099DA")]
	[FieldOffset(Offset = "0x1C")]
	public uint tag_type;

	[Token(Token = "0x40099DB")]
	[FieldOffset(Offset = "0x20")]
	public uint tag_value;

	[Token(Token = "0x40099DC")]
	[FieldOffset(Offset = "0x24")]
	public uint type_override;

	[Token(Token = "0x40099DD")]
	[FieldOffset(Offset = "0x28")]
	public bool is_original_type_remain;

	[Token(Token = "0x40099DE")]
	[FieldOffset(Offset = "0x29")]
	public bool is_exclusive;

	[Token(Token = "0x40099DF")]
	[FieldOffset(Offset = "0x2C")]
	public string image_url;

	[Token(Token = "0x40099E0")]
	[FieldOffset(Offset = "0x30")]
	public bool is_quick_gift_recommended;

	[Token(Token = "0x40099E1")]
	[FieldOffset(Offset = "0x34")]
	public uint award_time;

	[Token(Token = "0x40099E2")]
	[FieldOffset(Offset = "0x38")]
	public long expire_timestamp;

	[Token(Token = "0x6007DA6")]
	[Address(RVA = "0x30A2370", Offset = "0x30A2370", VA = "0x30A2370")]
	public GiftItem()
	{
	}
}
