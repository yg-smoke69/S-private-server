using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001567")]
public class AccountLeaderboardRes
{
	[Token(Token = "0x400930A")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountLeaderboardItem> items;

	[Token(Token = "0x400930B")]
	[FieldOffset(Offset = "0xC")]
	public AccountLeaderboardItem self;

	[Token(Token = "0x400930C")]
	[FieldOffset(Offset = "0x10")]
	public uint leaderboard_size;

	[Token(Token = "0x6007BAF")]
	[Address(RVA = "0x3179964", Offset = "0x3179964", VA = "0x3179964")]
	public AccountLeaderboardRes()
	{
	}
}
