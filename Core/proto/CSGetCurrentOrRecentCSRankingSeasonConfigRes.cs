using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200154D")]
public class CSGetCurrentOrRecentCSRankingSeasonConfigRes
{
	[Token(Token = "0x40092B0")]
	[FieldOffset(Offset = "0x8")]
	public CSRankingSeasonInfoDesc season_info;

	[Token(Token = "0x40092B1")]
	[FieldOffset(Offset = "0xC")]
	public List<CSRankAwardsDesc> awards;

	[Token(Token = "0x40092B2")]
	[FieldOffset(Offset = "0x10")]
	public List<CSRankTopAwardsDesc> top_awards_with_level;

	[Token(Token = "0x40092B3")]
	[FieldOffset(Offset = "0x14")]
	public List<CSRankingAwardExhibitDesc> award_exhibit;

	[Token(Token = "0x6007B95")]
	[Address(RVA = "0x31837DC", Offset = "0x31837DC", VA = "0x31837DC")]
	public CSGetCurrentOrRecentCSRankingSeasonConfigRes()
	{
	}
}
