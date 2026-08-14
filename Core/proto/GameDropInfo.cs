using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A69")]
public class GameDropInfo
{
	[Token(Token = "0x400A54E")]
	[FieldOffset(Offset = "0x8")]
	public uint drop_id;

	[Token(Token = "0x400A54F")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x400A550")]
	[FieldOffset(Offset = "0x10")]
	public uint start_time;

	[Token(Token = "0x400A551")]
	[FieldOffset(Offset = "0x14")]
	public uint end_time;

	[Token(Token = "0x400A552")]
	[FieldOffset(Offset = "0x18")]
	public uint match_mode;

	[Token(Token = "0x400A553")]
	[FieldOffset(Offset = "0x1C")]
	public uint map_id;

	[Token(Token = "0x400A554")]
	[FieldOffset(Offset = "0x20")]
	public int group_mode;

	[Token(Token = "0x400A555")]
	[FieldOffset(Offset = "0x24")]
	public uint rank;

	[Token(Token = "0x400A556")]
	[FieldOffset(Offset = "0x28")]
	public uint time;

	[Token(Token = "0x400A557")]
	[FieldOffset(Offset = "0x2C")]
	public uint max_drop_count;

	[Token(Token = "0x400A558")]
	[FieldOffset(Offset = "0x30")]
	public uint region_max_drop_count;

	[Token(Token = "0x400A559")]
	[FieldOffset(Offset = "0x34")]
	public uint time_span;

	[Token(Token = "0x400A55A")]
	[FieldOffset(Offset = "0x38")]
	public bool is_mail_notice;

	[Token(Token = "0x400A55B")]
	[FieldOffset(Offset = "0x3C")]
	public string event_detail_url;

	[Token(Token = "0x400A55C")]
	[FieldOffset(Offset = "0x40")]
	public uint award_time;

	[Token(Token = "0x400A55D")]
	[FieldOffset(Offset = "0x44")]
	public uint[] game_mode;

	[Token(Token = "0x60080C6")]
	[Address(RVA = "0x30A18DC", Offset = "0x30A18DC", VA = "0x30A18DC")]
	public GameDropInfo()
	{
	}
}
