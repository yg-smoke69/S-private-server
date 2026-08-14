using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200151F")]
public class CSGetMatchStatsListRes
{
	[Token(Token = "0x40090CA")]
	[FieldOffset(Offset = "0x8")]
	public List<MatchAccountStats> match_stats_list;

	[Token(Token = "0x6007B68")]
	[Address(RVA = "0x31875E8", Offset = "0x31875E8", VA = "0x31875E8")]
	public CSGetMatchStatsListRes()
	{
	}
}
