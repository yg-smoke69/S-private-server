using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA7")]
public class CupSettingDesc
{
	[Token(Token = "0x400ADEC")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400ADED")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400ADEE")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400ADEF")]
	[FieldOffset(Offset = "0x14")]
	public string cup_name;

	[Token(Token = "0x400ADF0")]
	[FieldOffset(Offset = "0x18")]
	public string mode_name;

	[Token(Token = "0x400ADF1")]
	[FieldOffset(Offset = "0x1C")]
	public bool disable_weapon_skin;

	[Token(Token = "0x400ADF2")]
	[FieldOffset(Offset = "0x1D")]
	public bool is_new;

	[Token(Token = "0x400ADF3")]
	[FieldOffset(Offset = "0x1E")]
	public bool tier_inherit;

	[Token(Token = "0x400ADF4")]
	[FieldOffset(Offset = "0x20")]
	public uint[] ticket_item_id;

	[Token(Token = "0x6008202")]
	[Address(RVA = "0x309DDF4", Offset = "0x309DDF4", VA = "0x309DDF4")]
	public CupSettingDesc()
	{
	}
}
