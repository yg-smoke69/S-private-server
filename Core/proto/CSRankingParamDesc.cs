using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B25")]
public class CSRankingParamDesc
{
	[Token(Token = "0x400AAA2")]
	[FieldOffset(Offset = "0x8")]
	public uint games_played;

	[Token(Token = "0x400AAA3")]
	[FieldOffset(Offset = "0xC")]
	public float KDA;

	[Token(Token = "0x400AAA4")]
	[FieldOffset(Offset = "0x10")]
	public float win_rate;

	[Token(Token = "0x400AAA5")]
	[FieldOffset(Offset = "0x14")]
	public uint min_games;

	[Token(Token = "0x400AAA6")]
	[FieldOffset(Offset = "0x18")]
	public uint mail_warning;

	[Token(Token = "0x400AAA7")]
	[FieldOffset(Offset = "0x1C")]
	public uint ban_cs_ranking;

	[Token(Token = "0x400AAA8")]
	[FieldOffset(Offset = "0x20")]
	public float combine_KD;

	[Token(Token = "0x400AAA9")]
	[FieldOffset(Offset = "0x24")]
	public float combine_Headshot;

	[Token(Token = "0x400AAAA")]
	[FieldOffset(Offset = "0x28")]
	public uint min_rank_show;

	[Token(Token = "0x400AAAB")]
	[FieldOffset(Offset = "0x2C")]
	public uint protect_point_compensation_limit;

	[Token(Token = "0x6008180")]
	[Address(RVA = "0x3098CA0", Offset = "0x3098CA0", VA = "0x3098CA0")]
	public CSRankingParamDesc()
	{
	}
}
