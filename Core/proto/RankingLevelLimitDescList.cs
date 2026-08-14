using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E7")]
public class RankingLevelLimitDescList
{
	[Token(Token = "0x400A2B1")]
	[FieldOffset(Offset = "0x8")]
	public List<RankingLevelLimitDesc> ranking_level_limits;

	[Token(Token = "0x600803F")]
	[Address(RVA = "0x33E0BC8", Offset = "0x33E0BC8", VA = "0x33E0BC8")]
	public RankingLevelLimitDescList()
	{
	}
}
