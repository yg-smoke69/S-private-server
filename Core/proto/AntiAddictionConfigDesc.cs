using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AFE")]
public class AntiAddictionConfigDesc
{
	[Token(Token = "0x400A9C7")]
	[FieldOffset(Offset = "0x8")]
	public string country;

	[Token(Token = "0x400A9C8")]
	[FieldOffset(Offset = "0xC")]
	public EAntiAddiction.AgeState age;

	[Token(Token = "0x400A9C9")]
	[FieldOffset(Offset = "0x10")]
	public uint rest_time;

	[Token(Token = "0x400A9CA")]
	[FieldOffset(Offset = "0x14")]
	public uint continue_time;

	[Token(Token = "0x400A9CB")]
	[FieldOffset(Offset = "0x18")]
	public string continue_time_hint_string;

	[Token(Token = "0x400A9CC")]
	[FieldOffset(Offset = "0x1C")]
	public uint total_time1;

	[Token(Token = "0x400A9CD")]
	[FieldOffset(Offset = "0x20")]
	public EAntiAddiction.TotalTimeBanMode ban_mode1;

	[Token(Token = "0x400A9CE")]
	[FieldOffset(Offset = "0x24")]
	public uint ban_time1;

	[Token(Token = "0x400A9CF")]
	[FieldOffset(Offset = "0x28")]
	public string total_time_hint_string1;

	[Token(Token = "0x400A9D0")]
	[FieldOffset(Offset = "0x2C")]
	public uint total_time2;

	[Token(Token = "0x400A9D1")]
	[FieldOffset(Offset = "0x30")]
	public EAntiAddiction.TotalTimeBanMode ban_mode2;

	[Token(Token = "0x400A9D2")]
	[FieldOffset(Offset = "0x34")]
	public uint ban_time2;

	[Token(Token = "0x400A9D3")]
	[FieldOffset(Offset = "0x38")]
	public string total_time_hint_string2;

	[Token(Token = "0x400A9D4")]
	[FieldOffset(Offset = "0x3C")]
	public uint total_time3;

	[Token(Token = "0x400A9D5")]
	[FieldOffset(Offset = "0x40")]
	public EAntiAddiction.TotalTimeBanMode ban_mode3;

	[Token(Token = "0x400A9D6")]
	[FieldOffset(Offset = "0x44")]
	public uint ban_time3;

	[Token(Token = "0x400A9D7")]
	[FieldOffset(Offset = "0x48")]
	public string total_time_hint_string3;

	[Token(Token = "0x6008159")]
	[Address(RVA = "0x317ABDC", Offset = "0x317ABDC", VA = "0x317ABDC")]
	public AntiAddictionConfigDesc()
	{
	}
}
