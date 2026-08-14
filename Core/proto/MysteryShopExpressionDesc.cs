using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC2")]
public class MysteryShopExpressionDesc
{
	[Token(Token = "0x400A87D")]
	[FieldOffset(Offset = "0x8")]
	public uint mystery_shop_id;

	[Token(Token = "0x400A87E")]
	[FieldOffset(Offset = "0xC")]
	public string discount_cdn;

	[Token(Token = "0x400A87F")]
	[FieldOffset(Offset = "0x10")]
	public string shop_enter_icon;

	[Token(Token = "0x400A880")]
	[FieldOffset(Offset = "0x14")]
	public string web_link;

	[Token(Token = "0x400A881")]
	[FieldOffset(Offset = "0x18")]
	public string web_link_cdn;

	[Token(Token = "0x400A882")]
	[FieldOffset(Offset = "0x20")]
	public long start_timestamp;

	[Token(Token = "0x400A883")]
	[FieldOffset(Offset = "0x28")]
	public long end_timestamp;

	[Token(Token = "0x400A884")]
	[FieldOffset(Offset = "0x30")]
	public string language;

	[Token(Token = "0x400A885")]
	[FieldOffset(Offset = "0x34")]
	public bool mab_switch;

	[Token(Token = "0x400A886")]
	[FieldOffset(Offset = "0x38")]
	public uint sort_id;

	[Token(Token = "0x400A887")]
	[FieldOffset(Offset = "0x3C")]
	public string table_sprite;

	[Token(Token = "0x400A888")]
	[FieldOffset(Offset = "0x40")]
	public string table_name;

	[Token(Token = "0x400A889")]
	[FieldOffset(Offset = "0x44")]
	public string select_line;

	[Token(Token = "0x400A88A")]
	[FieldOffset(Offset = "0x48")]
	public uint theme_change;

	[Token(Token = "0x600811F")]
	[Address(RVA = "0x30A9A20", Offset = "0x30A9A20", VA = "0x30A9A20")]
	public MysteryShopExpressionDesc()
	{
	}
}
