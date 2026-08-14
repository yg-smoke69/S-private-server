using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014CB")]
public class EPoolLeaderboard
{
	[Token(Token = "0x20014CC")]
	public enum PoolLeaderboardID
	{
		[Token(Token = "0x4008FDB")]
		PoolLeaderboardID_NONE,
		[Token(Token = "0x4008FDC")]
		PoolLeaderboardID_BOOYAH_DAY,
		[Token(Token = "0x4008FDD")]
		PoolLeaderboardID_WINTER_LAND,
		[Token(Token = "0x4008FDE")]
		PoolLeaderboardID_FFWS_MANAGER
	}

	[Token(Token = "0x6007B26")]
	[Address(RVA = "0x309F8A4", Offset = "0x309F8A4", VA = "0x309F8A4")]
	public EPoolLeaderboard()
	{
	}
}
