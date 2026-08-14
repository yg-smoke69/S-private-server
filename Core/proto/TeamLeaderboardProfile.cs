using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001565")]
public class TeamLeaderboardProfile
{
	[Token(Token = "0x4009303")]
	[FieldOffset(Offset = "0x8")]
	public TeamInfo team_info;

	[Token(Token = "0x4009304")]
	[FieldOffset(Offset = "0xC")]
	public TeamChampionshipInfo team_championship_info;

	[Token(Token = "0x4009305")]
	[FieldOffset(Offset = "0x10")]
	public CSTeamChampionshipSeasonStatsRes team_stats;

	[Token(Token = "0x6007BAD")]
	[Address(RVA = "0x33E3440", Offset = "0x33E3440", VA = "0x33E3440")]
	public TeamLeaderboardProfile()
	{
	}
}
