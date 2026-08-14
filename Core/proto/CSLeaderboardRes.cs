using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200155E")]
public class CSLeaderboardRes
{
	[Token(Token = "0x40092EA")]
	[FieldOffset(Offset = "0x8")]
	public List<LeaderboardItem> items;

	[Token(Token = "0x40092EB")]
	[FieldOffset(Offset = "0xC")]
	public LeaderboardItem self;

	[Token(Token = "0x40092EC")]
	[FieldOffset(Offset = "0x10")]
	public uint leaderboard_size;

	[Token(Token = "0x6007BA6")]
	[Address(RVA = "0x3097658", Offset = "0x3097658", VA = "0x3097658")]
	public CSLeaderboardRes()
	{
	}
}
