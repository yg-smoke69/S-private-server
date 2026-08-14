using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B21")]
public class CSRankAwardsDesc
{
	[Token(Token = "0x400AA90")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400AA91")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> level_awards;

	[Token(Token = "0x400AA92")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_master_level;

	[Token(Token = "0x600817C")]
	[Address(RVA = "0x3098AB4", Offset = "0x3098AB4", VA = "0x3098AB4")]
	public CSRankAwardsDesc()
	{
	}
}
