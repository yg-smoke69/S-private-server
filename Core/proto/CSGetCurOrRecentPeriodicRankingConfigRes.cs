using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200192C")]
public class CSGetCurOrRecentPeriodicRankingConfigRes
{
	[Token(Token = "0x4009F04")]
	[FieldOffset(Offset = "0x8")]
	public PeriodicRankingSeasonInfoDesc season_info;

	[Token(Token = "0x4009F05")]
	[FieldOffset(Offset = "0xC")]
	public List<PeriodicRankAwardsDesc> awards;

	[Token(Token = "0x4009F06")]
	[FieldOffset(Offset = "0x10")]
	public bool openingState;

	[Token(Token = "0x6007F85")]
	[Address(RVA = "0x3183750", Offset = "0x3183750", VA = "0x3183750")]
	public CSGetCurOrRecentPeriodicRankingConfigRes()
	{
	}
}
