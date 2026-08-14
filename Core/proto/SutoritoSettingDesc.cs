using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B58")]
public class SutoritoSettingDesc
{
	[Token(Token = "0x400ABFE")]
	[FieldOffset(Offset = "0x8")]
	public uint big_reward_round;

	[Token(Token = "0x400ABFF")]
	[FieldOffset(Offset = "0xC")]
	public AwardDesc big_reward;

	[Token(Token = "0x400AC00")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc defeat_reward;

	[Token(Token = "0x400AC01")]
	[FieldOffset(Offset = "0x14")]
	public uint mission_start;

	[Token(Token = "0x400AC02")]
	[FieldOffset(Offset = "0x18")]
	public uint mission_end;

	[Token(Token = "0x400AC03")]
	[FieldOffset(Offset = "0x1C")]
	public uint web_event_start;

	[Token(Token = "0x400AC04")]
	[FieldOffset(Offset = "0x20")]
	public uint web_event_end;

	[Token(Token = "0x400AC05")]
	[FieldOffset(Offset = "0x24")]
	public string web_url;

	[Token(Token = "0x400AC06")]
	[FieldOffset(Offset = "0x28")]
	public string web_cdn;

	[Token(Token = "0x400AC07")]
	[FieldOffset(Offset = "0x2C")]
	public uint rev_start;

	[Token(Token = "0x400AC08")]
	[FieldOffset(Offset = "0x30")]
	public uint rev_end;

	[Token(Token = "0x400AC09")]
	[FieldOffset(Offset = "0x34")]
	public string rev_gopos;

	[Token(Token = "0x400AC0A")]
	[FieldOffset(Offset = "0x38")]
	public string rev_sub_gopos;

	[Token(Token = "0x400AC0B")]
	[FieldOffset(Offset = "0x3C")]
	public string rev_cdn;

	[Token(Token = "0x400AC0C")]
	[FieldOffset(Offset = "0x40")]
	public uint token_id;

	[Token(Token = "0x400AC0D")]
	[FieldOffset(Offset = "0x44")]
	public uint sugar_id;

	[Token(Token = "0x60081B3")]
	[Address(RVA = "0x33E3148", Offset = "0x33E3148", VA = "0x33E3148")]
	public SutoritoSettingDesc()
	{
	}
}
