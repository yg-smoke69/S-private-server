using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AEA")]
public class GlobalBoxDropInfoDesc
{
	[Token(Token = "0x400A934")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A935")]
	[FieldOffset(Offset = "0xC")]
	public uint region_max_drop_count;

	[Token(Token = "0x400A936")]
	[FieldOffset(Offset = "0x10")]
	public uint time_span_secs;

	[Token(Token = "0x400A937")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400A938")]
	[FieldOffset(Offset = "0x18")]
	public string start_time;

	[Token(Token = "0x400A939")]
	[FieldOffset(Offset = "0x1C")]
	public string end_time;

	[Token(Token = "0x400A93A")]
	[FieldOffset(Offset = "0x20")]
	public bool is_mail_notice;

	[Token(Token = "0x400A93B")]
	[FieldOffset(Offset = "0x24")]
	public string event_detail_url;

	[Token(Token = "0x400A93C")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.AwardType item_type;

	[Token(Token = "0x400A93D")]
	[FieldOffset(Offset = "0x2C")]
	public uint store_box_id;

	[Token(Token = "0x6008145")]
	[Address(RVA = "0x30A2758", Offset = "0x30A2758", VA = "0x30A2758")]
	public GlobalBoxDropInfoDesc()
	{
	}
}
