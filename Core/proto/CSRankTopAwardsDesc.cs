using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B22")]
public class CSRankTopAwardsDesc
{
	[Token(Token = "0x400AA93")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400AA94")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> season_awards;

	[Token(Token = "0x400AA95")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_master_level;

	[Token(Token = "0x600817D")]
	[Address(RVA = "0x3098BEC", Offset = "0x3098BEC", VA = "0x3098BEC")]
	public CSRankTopAwardsDesc()
	{
	}
}
