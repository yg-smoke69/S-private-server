using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A50")]
public class RankingActivityConfig
{
	[Token(Token = "0x400A4D7")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A4D8")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A4D9")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A4DA")]
	[FieldOffset(Offset = "0x14")]
	public ERanking.ActivityType activity_type;

	[Token(Token = "0x400A4DB")]
	[FieldOffset(Offset = "0x18")]
	public uint start_timestamp;

	[Token(Token = "0x400A4DC")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_timestamp;

	[Token(Token = "0x60080A8")]
	[Address(RVA = "0x33E0A3C", Offset = "0x33E0A3C", VA = "0x33E0A3C")]
	public RankingActivityConfig()
	{
	}
}
