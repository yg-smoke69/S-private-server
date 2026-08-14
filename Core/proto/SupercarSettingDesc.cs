using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B55")]
public class SupercarSettingDesc
{
	[Token(Token = "0x400ABE9")]
	[FieldOffset(Offset = "0x8")]
	public uint length;

	[Token(Token = "0x400ABEA")]
	[FieldOffset(Offset = "0xC")]
	public uint second_level_speed;

	[Token(Token = "0x400ABEB")]
	[FieldOffset(Offset = "0x10")]
	public uint third_level_speed;

	[Token(Token = "0x400ABEC")]
	[FieldOffset(Offset = "0x14")]
	public uint max_speed;

	[Token(Token = "0x400ABED")]
	[FieldOffset(Offset = "0x18")]
	public uint token_id;

	[Token(Token = "0x400ABEE")]
	[FieldOffset(Offset = "0x1C")]
	public uint speed_per_token;

	[Token(Token = "0x400ABEF")]
	[FieldOffset(Offset = "0x20")]
	public uint speed_per_help;

	[Token(Token = "0x400ABF0")]
	[FieldOffset(Offset = "0x24")]
	public uint tokens_feed_back_help;

	[Token(Token = "0x400ABF1")]
	[FieldOffset(Offset = "0x28")]
	public AwardDesc helper_award;

	[Token(Token = "0x400ABF2")]
	[FieldOffset(Offset = "0x2C")]
	public string web_event_url;

	[Token(Token = "0x400ABF3")]
	[FieldOffset(Offset = "0x30")]
	public uint web_event_start_timestamp;

	[Token(Token = "0x400ABF4")]
	[FieldOffset(Offset = "0x34")]
	public uint web_event_end_timestamp;

	[Token(Token = "0x400ABF5")]
	[FieldOffset(Offset = "0x38")]
	public string share_web_page_url;

	[Token(Token = "0x60081B0")]
	[Address(RVA = "0x33E2F4C", Offset = "0x33E2F4C", VA = "0x33E2F4C")]
	public SupercarSettingDesc()
	{
	}
}
