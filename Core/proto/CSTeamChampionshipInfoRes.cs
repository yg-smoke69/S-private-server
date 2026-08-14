using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001799")]
public class CSTeamChampionshipInfoRes
{
	[Token(Token = "0x4009AB1")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009AB2")]
	[FieldOffset(Offset = "0x10")]
	public List<ChampionshipInfo> championship_infos;

	[Token(Token = "0x6007DF3")]
	[Address(RVA = "0x309A0C8", Offset = "0x309A0C8", VA = "0x309A0C8")]
	public CSTeamChampionshipInfoRes()
	{
	}
}
