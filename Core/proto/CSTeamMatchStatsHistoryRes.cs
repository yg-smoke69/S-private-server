using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B3")]
public class CSTeamMatchStatsHistoryRes
{
	[Token(Token = "0x4009B2B")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamChampionshipMatchStats> match_stats;

	[Token(Token = "0x6007E0D")]
	[Address(RVA = "0x309A330", Offset = "0x309A330", VA = "0x309A330")]
	public CSTeamMatchStatsHistoryRes()
	{
	}
}
