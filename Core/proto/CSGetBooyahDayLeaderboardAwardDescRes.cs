using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200180B")]
public class CSGetBooyahDayLeaderboardAwardDescRes
{
	[Token(Token = "0x4009BF0")]
	[FieldOffset(Offset = "0x8")]
	public List<BooyahDayLeaderboardRewardDesc> game_leaderboard_awards;

	[Token(Token = "0x4009BF1")]
	[FieldOffset(Offset = "0xC")]
	public List<BooyahDayLeaderboardRewardDesc> chess_leaderboard_awards;

	[Token(Token = "0x6007E65")]
	[Address(RVA = "0x31824F8", Offset = "0x31824F8", VA = "0x31824F8")]
	public CSGetBooyahDayLeaderboardAwardDescRes()
	{
	}
}
