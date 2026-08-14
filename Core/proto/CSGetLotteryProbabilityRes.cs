using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D9")]
public class CSGetLotteryProbabilityRes
{
	[Token(Token = "0x400977E")]
	[FieldOffset(Offset = "0x8")]
	public List<RareProbability> rare_pr;

	[Token(Token = "0x400977F")]
	[FieldOffset(Offset = "0xC")]
	public List<LevelProbability> level_pr;

	[Token(Token = "0x6007D33")]
	[Address(RVA = "0x3187210", Offset = "0x3187210", VA = "0x3187210")]
	public CSGetLotteryProbabilityRes()
	{
	}
}
