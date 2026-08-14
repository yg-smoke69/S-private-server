using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A61")]
public class LinkProfileDesc
{
	[Token(Token = "0x400A520")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A521")]
	[FieldOffset(Offset = "0xC")]
	public uint link_start_time_stamp;

	[Token(Token = "0x400A522")]
	[FieldOffset(Offset = "0x10")]
	public uint link_end_time_stamp;

	[Token(Token = "0x400A523")]
	[FieldOffset(Offset = "0x14")]
	public uint link_max;

	[Token(Token = "0x400A524")]
	[FieldOffset(Offset = "0x18")]
	public uint link_game_daily_max;

	[Token(Token = "0x400A525")]
	[FieldOffset(Offset = "0x1C")]
	public uint link_exchange_daily_max;

	[Token(Token = "0x400A526")]
	[FieldOffset(Offset = "0x20")]
	public uint drop_time_param;

	[Token(Token = "0x400A527")]
	[FieldOffset(Offset = "0x24")]
	public uint drop_kill_param;

	[Token(Token = "0x400A528")]
	[FieldOffset(Offset = "0x28")]
	public uint drop_damage_param;

	[Token(Token = "0x400A529")]
	[FieldOffset(Offset = "0x2C")]
	public uint link_show_time_stamp;

	[Token(Token = "0x60080B9")]
	[Address(RVA = "0x30A63F4", Offset = "0x30A63F4", VA = "0x30A63F4")]
	public LinkProfileDesc()
	{
	}
}
