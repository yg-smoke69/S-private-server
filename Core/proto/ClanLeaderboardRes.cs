using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001644")]
public class ClanLeaderboardRes
{
	[Token(Token = "0x40095B4")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanLeaderboardItem> items;

	[Token(Token = "0x40095B5")]
	[FieldOffset(Offset = "0xC")]
	public ClanLeaderboardItem self;

	[Token(Token = "0x40095B6")]
	[FieldOffset(Offset = "0x10")]
	public uint leaderboard_size;

	[Token(Token = "0x6007C8E")]
	[Address(RVA = "0x309BB74", Offset = "0x309BB74", VA = "0x309BB74")]
	public ClanLeaderboardRes()
	{
	}
}
