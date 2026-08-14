using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001319")]
public class ELeaderboard
{
	[Token(Token = "0x200131A")]
	public enum LeaderboardMainType
	{
		[Token(Token = "0x4008728")]
		Leaderboard_REGULAR = 0,
		[Token(Token = "0x4008729")]
		Leaderboard_RANKING_SCORE = 1,
		[Token(Token = "0x400872A")]
		Leaderboard_RANKING_KILLS = 2,
		[Token(Token = "0x400872B")]
		Leaderboard_RANKING_WIN_COUNT = 3,
		[Token(Token = "0x400872C")]
		Leaderboard_CASUAL_KILLS = 4,
		[Token(Token = "0x400872D")]
		Leaderboard_CASUAL_WIN_COUNT = 5,
		[Token(Token = "0x400872E")]
		Leaderboard_ELITEPASS_BADGE = 6,
		[Token(Token = "0x400872F")]
		Leaderboard_GIFT_STORE = 7,
		[Token(Token = "0x4008730")]
		Leaderboard_CHAMPIONSHIP_TRIAL_SCORE = 8,
		[Token(Token = "0x4008731")]
		Leaderboard_CHAMPIONSHIP_TRIAL_KILLS = 9,
		[Token(Token = "0x4008732")]
		Leaderboard_LIMITED_EVENT = 10,
		[Token(Token = "0x4008733")]
		Leaderboard_CS_RANKING_KILLS = 11,
		[Token(Token = "0x4008734")]
		Leaderboard_CS_RANKING_WINS = 12,
		[Token(Token = "0x4008735")]
		Leaderboard_CS_RANKING_SCORE = 13,
		[Token(Token = "0x4008736")]
		Leaderboard_PERIODIC_RANKING_SCORE = 14,
		[Token(Token = "0x4008737")]
		Leaderboard_CLAN_HONOR = 1001,
		[Token(Token = "0x4008738")]
		Leaderboard_CLAN_HONOR_WEEK = 1002,
		[Token(Token = "0x4008739")]
		Leaderboard_CLAN_RACE = 1003,
		[Token(Token = "0x400873A")]
		Leaderboard_CLAN_WAR = 1004
	}

	[Token(Token = "0x6007A4F")]
	[Address(RVA = "0x309F308", Offset = "0x309F308", VA = "0x309F308")]
	public ELeaderboard()
	{
	}
}
