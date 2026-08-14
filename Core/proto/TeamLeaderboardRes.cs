using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017AC")]
public class TeamLeaderboardRes
{
	[Token(Token = "0x4009B17")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamLeaderboardItem> items;

	[Token(Token = "0x4009B18")]
	[FieldOffset(Offset = "0xC")]
	public TeamLeaderboardItem self;

	[Token(Token = "0x4009B19")]
	[FieldOffset(Offset = "0x10")]
	public uint leaderboard_size;

	[Token(Token = "0x6007E06")]
	[Address(RVA = "0x33E3448", Offset = "0x33E3448", VA = "0x33E3448")]
	public TeamLeaderboardRes()
	{
	}
}
