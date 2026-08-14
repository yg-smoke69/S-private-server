using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B3D")]
public class RampageSettingDesc
{
	[Token(Token = "0x400AB65")]
	[FieldOffset(Offset = "0x8")]
	public string main_cdn;

	[Token(Token = "0x400AB66")]
	[FieldOffset(Offset = "0xC")]
	public string b_character_cdn;

	[Token(Token = "0x400AB67")]
	[FieldOffset(Offset = "0x10")]
	public string l_character_cdn;

	[Token(Token = "0x400AB68")]
	[FieldOffset(Offset = "0x14")]
	public string b_store_cdn;

	[Token(Token = "0x400AB69")]
	[FieldOffset(Offset = "0x18")]
	public string l_store_cdn;

	[Token(Token = "0x400AB6A")]
	[FieldOffset(Offset = "0x1C")]
	public string b_signup_cdn;

	[Token(Token = "0x400AB6B")]
	[FieldOffset(Offset = "0x20")]
	public string l_signup_cdn;

	[Token(Token = "0x400AB6C")]
	[FieldOffset(Offset = "0x24")]
	public string web_link;

	[Token(Token = "0x400AB6D")]
	[FieldOffset(Offset = "0x28")]
	public uint mode_id;

	[Token(Token = "0x400AB6E")]
	[FieldOffset(Offset = "0x2C")]
	public uint points_id;

	[Token(Token = "0x400AB6F")]
	[FieldOffset(Offset = "0x30")]
	public uint token_id;

	[Token(Token = "0x400AB70")]
	[FieldOffset(Offset = "0x34")]
	public string b_reward;

	[Token(Token = "0x400AB71")]
	[FieldOffset(Offset = "0x38")]
	public string l_reward;

	[Token(Token = "0x400AB72")]
	[FieldOffset(Offset = "0x3C")]
	public uint pp_start_timestamp;

	[Token(Token = "0x400AB73")]
	[FieldOffset(Offset = "0x40")]
	public uint peak_day_reward_id;

	[Token(Token = "0x400AB74")]
	[FieldOffset(Offset = "0x44")]
	public string winner_reward_cdn;

	[Token(Token = "0x6008198")]
	[Address(RVA = "0x33E0600", Offset = "0x33E0600", VA = "0x33E0600")]
	public RampageSettingDesc()
	{
	}
}
