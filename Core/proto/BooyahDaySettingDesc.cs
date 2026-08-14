using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B40")]
public class BooyahDaySettingDesc
{
	[Token(Token = "0x400AB7C")]
	[FieldOffset(Offset = "0x8")]
	public uint process_start_timestamp;

	[Token(Token = "0x400AB7D")]
	[FieldOffset(Offset = "0xC")]
	public uint process_end_timestamp;

	[Token(Token = "0x400AB7E")]
	[FieldOffset(Offset = "0x10")]
	public uint web_open_timestamp;

	[Token(Token = "0x400AB7F")]
	[FieldOffset(Offset = "0x14")]
	public uint web_close_timestamp;

	[Token(Token = "0x400AB80")]
	[FieldOffset(Offset = "0x18")]
	public string web_jump;

	[Token(Token = "0x400AB81")]
	[FieldOffset(Offset = "0x1C")]
	public uint mode_jump_gopos;

	[Token(Token = "0x400AB82")]
	[FieldOffset(Offset = "0x20")]
	public uint mode_jump_sub_gopos;

	[Token(Token = "0x400AB83")]
	[FieldOffset(Offset = "0x24")]
	public uint chess_open_timestamp;

	[Token(Token = "0x400AB84")]
	[FieldOffset(Offset = "0x28")]
	public uint chess_close_timestamp;

	[Token(Token = "0x400AB85")]
	[FieldOffset(Offset = "0x2C")]
	public uint sign_in_switch;

	[Token(Token = "0x400AB86")]
	[FieldOffset(Offset = "0x30")]
	public uint store_switch;

	[Token(Token = "0x400AB87")]
	[FieldOffset(Offset = "0x34")]
	public uint ranking_switch;

	[Token(Token = "0x400AB88")]
	[FieldOffset(Offset = "0x38")]
	public uint store_jump;

	[Token(Token = "0x400AB89")]
	[FieldOffset(Offset = "0x3C")]
	public string store_jump_cdn;

	[Token(Token = "0x400AB8A")]
	[FieldOffset(Offset = "0x40")]
	public uint store_start;

	[Token(Token = "0x400AB8B")]
	[FieldOffset(Offset = "0x44")]
	public uint store_end;

	[Token(Token = "0x400AB8C")]
	[FieldOffset(Offset = "0x48")]
	public uint exchange_token;

	[Token(Token = "0x400AB8D")]
	[FieldOffset(Offset = "0x4C")]
	public uint sugar_token;

	[Token(Token = "0x400AB8E")]
	[FieldOffset(Offset = "0x50")]
	public string background_cdn;

	[Token(Token = "0x600819B")]
	[Address(RVA = "0x317CB20", Offset = "0x317CB20", VA = "0x317CB20")]
	public BooyahDaySettingDesc()
	{
	}
}
