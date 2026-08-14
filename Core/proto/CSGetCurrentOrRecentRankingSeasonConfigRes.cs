using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001541")]
public class CSGetCurrentOrRecentRankingSeasonConfigRes
{
	[Token(Token = "0x4009288")]
	[FieldOffset(Offset = "0x8")]
	public RankingSeasonInfo season_info;

	[Token(Token = "0x4009289")]
	[FieldOffset(Offset = "0xC")]
	public List<RankAwardsDesc> awards;

	[Token(Token = "0x400928A")]
	[FieldOffset(Offset = "0x10")]
	public List<RankTopAwardsDesc> top_awards_with_level;

	[Token(Token = "0x400928B")]
	[FieldOffset(Offset = "0x14")]
	public List<RankingAwardExhibitDesc> award_exhibit;

	[Token(Token = "0x6007B89")]
	[Address(RVA = "0x31838D0", Offset = "0x31838D0", VA = "0x31838D0")]
	public CSGetCurrentOrRecentRankingSeasonConfigRes()
	{
	}
}
