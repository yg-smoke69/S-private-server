using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B28")]
public class CSLeaderboardRankPointDesc
{
	[Token(Token = "0x400AAB1")]
	[FieldOffset(Offset = "0x8")]
	public uint cs_season_id;

	[Token(Token = "0x400AAB2")]
	[FieldOffset(Offset = "0xC")]
	public uint min_cs_rank_point;

	[Token(Token = "0x6008183")]
	[Address(RVA = "0x30975A4", Offset = "0x30975A4", VA = "0x30975A4")]
	public CSLeaderboardRankPointDesc()
	{
	}
}
