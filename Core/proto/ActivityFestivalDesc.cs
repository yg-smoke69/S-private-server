using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D3")]
public class ActivityFestivalDesc
{
	[Token(Token = "0x400A1EE")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400A1EF")]
	[FieldOffset(Offset = "0xC")]
	public uint table_type;

	[Token(Token = "0x400A1F0")]
	[FieldOffset(Offset = "0x10")]
	public string table_sprite;

	[Token(Token = "0x400A1F1")]
	[FieldOffset(Offset = "0x14")]
	public string language;

	[Token(Token = "0x400A1F2")]
	[FieldOffset(Offset = "0x18")]
	public string event_title;

	[Token(Token = "0x400A1F3")]
	[FieldOffset(Offset = "0x1C")]
	public string event_lobby_icon;

	[Token(Token = "0x400A1F4")]
	[FieldOffset(Offset = "0x20")]
	public string start_time;

	[Token(Token = "0x400A1F5")]
	[FieldOffset(Offset = "0x24")]
	public string end_time;

	[Token(Token = "0x400A1F6")]
	[FieldOffset(Offset = "0x28")]
	public uint festival_item_id;

	[Token(Token = "0x400A1F7")]
	[FieldOffset(Offset = "0x2C")]
	public string cdn_url;

	[Token(Token = "0x400A1F8")]
	[FieldOffset(Offset = "0x30")]
	public uint affiliate_table;

	[Token(Token = "0x400A1F9")]
	[FieldOffset(Offset = "0x34")]
	public uint group_id;

	[Token(Token = "0x400A1FA")]
	[FieldOffset(Offset = "0x38")]
	public string color_value;

	[Token(Token = "0x400A1FB")]
	[FieldOffset(Offset = "0x3C")]
	public string select_line;

	[Token(Token = "0x400A1FC")]
	[FieldOffset(Offset = "0x40")]
	public string event_lobby_vfx;

	[Token(Token = "0x600802B")]
	[Address(RVA = "0x317A3AC", Offset = "0x317A3AC", VA = "0x317A3AC")]
	public ActivityFestivalDesc()
	{
	}
}
