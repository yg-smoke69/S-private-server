using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AFD")]
public class AntiAddictionSwitchDesc
{
	[Token(Token = "0x400A9BF")]
	[FieldOffset(Offset = "0x8")]
	public string country;

	[Token(Token = "0x400A9C0")]
	[FieldOffset(Offset = "0xC")]
	public bool function_switch;

	[Token(Token = "0x400A9C1")]
	[FieldOffset(Offset = "0x10")]
	public string limit_age;

	[Token(Token = "0x400A9C2")]
	[FieldOffset(Offset = "0x14")]
	public bool children_group;

	[Token(Token = "0x400A9C3")]
	[FieldOffset(Offset = "0x15")]
	public bool skip;

	[Token(Token = "0x400A9C4")]
	[FieldOffset(Offset = "0x18")]
	public string remind_cdn;

	[Token(Token = "0x400A9C5")]
	[FieldOffset(Offset = "0x1C")]
	public string ban_mode_cdn;

	[Token(Token = "0x400A9C6")]
	[FieldOffset(Offset = "0x20")]
	public bool age_certification_switch;

	[Token(Token = "0x6008158")]
	[Address(RVA = "0x317ACAC", Offset = "0x317ACAC", VA = "0x317ACAC")]
	public AntiAddictionSwitchDesc()
	{
	}
}
