using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200154C")]
public class CSPlayerCSRankingSeasonStatsRes
{
	[Token(Token = "0x40092AE")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x40092AF")]
	[FieldOffset(Offset = "0xC")]
	public AccountInfoWithTCStats ranking_stats;

	[Token(Token = "0x6007B94")]
	[Address(RVA = "0x309850C", Offset = "0x309850C", VA = "0x309850C")]
	public CSPlayerCSRankingSeasonStatsRes()
	{
	}
}
