using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AAB")]
public class ExchangeStoreItemDesc
{
	[Token(Token = "0x400A79F")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A7A0")]
	[FieldOffset(Offset = "0xC")]
	public uint commodity_id;

	[Token(Token = "0x400A7A1")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400A7A2")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x400A7A3")]
	[FieldOffset(Offset = "0x18")]
	public uint item_id;

	[Token(Token = "0x400A7A4")]
	[FieldOffset(Offset = "0x1C")]
	public uint currency_id;

	[Token(Token = "0x400A7A5")]
	[FieldOffset(Offset = "0x20")]
	public string currency_name;

	[Token(Token = "0x400A7A6")]
	[FieldOffset(Offset = "0x24")]
	public uint currency_price;

	[Token(Token = "0x400A7A7")]
	[FieldOffset(Offset = "0x28")]
	public uint tag_type;

	[Token(Token = "0x400A7A8")]
	[FieldOffset(Offset = "0x2C")]
	public uint tag_value;

	[Token(Token = "0x400A7A9")]
	[FieldOffset(Offset = "0x30")]
	public uint limited_purchase_times;

	[Token(Token = "0x400A7AA")]
	[FieldOffset(Offset = "0x34")]
	public uint purchase_times;

	[Token(Token = "0x400A7AB")]
	[FieldOffset(Offset = "0x38")]
	public string added_time;

	[Token(Token = "0x400A7AC")]
	[FieldOffset(Offset = "0x3C")]
	public string expire_time;

	[Token(Token = "0x400A7AD")]
	[FieldOffset(Offset = "0x40")]
	public string language;

	[Token(Token = "0x400A7AE")]
	[FieldOffset(Offset = "0x44")]
	public string image_url;

	[Token(Token = "0x400A7AF")]
	[FieldOffset(Offset = "0x48")]
	public string real_image_url;

	[Token(Token = "0x400A7B0")]
	[FieldOffset(Offset = "0x4C")]
	public uint gems_cost;

	[Token(Token = "0x400A7B1")]
	[FieldOffset(Offset = "0x50")]
	public uint min_clan_level;

	[Token(Token = "0x400A7B2")]
	[FieldOffset(Offset = "0x54")]
	public uint award_time;

	[Token(Token = "0x400A7B3")]
	[FieldOffset(Offset = "0x58")]
	public long expire_timestamp;

	[Token(Token = "0x6008108")]
	[Address(RVA = "0x309FF5C", Offset = "0x309FF5C", VA = "0x309FF5C")]
	public ExchangeStoreItemDesc()
	{
	}
}
