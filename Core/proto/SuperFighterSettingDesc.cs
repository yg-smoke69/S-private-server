using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B52")]
public class SuperFighterSettingDesc
{
	[Token(Token = "0x400ABD3")]
	[FieldOffset(Offset = "0x8")]
	public uint big_reward_round;

	[Token(Token = "0x400ABD4")]
	[FieldOffset(Offset = "0xC")]
	public AwardDesc big_reward;

	[Token(Token = "0x400ABD5")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc defeat_reward;

	[Token(Token = "0x400ABD6")]
	[FieldOffset(Offset = "0x14")]
	public uint mission_start;

	[Token(Token = "0x400ABD7")]
	[FieldOffset(Offset = "0x18")]
	public uint mission_end;

	[Token(Token = "0x400ABD8")]
	[FieldOffset(Offset = "0x1C")]
	public uint web_event_start;

	[Token(Token = "0x400ABD9")]
	[FieldOffset(Offset = "0x20")]
	public uint web_event_end;

	[Token(Token = "0x400ABDA")]
	[FieldOffset(Offset = "0x24")]
	public uint sugar_id;

	[Token(Token = "0x400ABDB")]
	[FieldOffset(Offset = "0x28")]
	public uint token_id;

	[Token(Token = "0x400ABDC")]
	[FieldOffset(Offset = "0x2C")]
	public string web_url;

	[Token(Token = "0x60081AD")]
	[Address(RVA = "0x33E2D78", Offset = "0x33E2D78", VA = "0x33E2D78")]
	public SuperFighterSettingDesc()
	{
	}
}
