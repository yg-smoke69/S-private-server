using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001543")]
public class CSGetRankingActivityConfigRes
{
	[Token(Token = "0x400928D")]
	[FieldOffset(Offset = "0x8")]
	public List<RankingActivityConfig> ranking_activity_configs;

	[Token(Token = "0x6007B8B")]
	[Address(RVA = "0x3094EE4", Offset = "0x3094EE4", VA = "0x3094EE4")]
	public CSGetRankingActivityConfigRes()
	{
	}
}
