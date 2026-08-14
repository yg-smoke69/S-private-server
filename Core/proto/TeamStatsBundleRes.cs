using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017AE")]
public class TeamStatsBundleRes
{
	[Token(Token = "0x4009B1B")]
	[FieldOffset(Offset = "0x8")]
	public List<CSTeamChampionshipSeasonStatsRes> statses;

	[Token(Token = "0x6007E08")]
	[Address(RVA = "0x33E3610", Offset = "0x33E3610", VA = "0x33E3610")]
	public TeamStatsBundleRes()
	{
	}
}
