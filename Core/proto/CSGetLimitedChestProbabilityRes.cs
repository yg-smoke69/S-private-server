using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200191B")]
public class CSGetLimitedChestProbabilityRes
{
	[Token(Token = "0x4009EC7")]
	[FieldOffset(Offset = "0x8")]
	public List<RareProbability> rare_pr;

	[Token(Token = "0x4009EC8")]
	[FieldOffset(Offset = "0xC")]
	public List<LevelProbability> level_pr;

	[Token(Token = "0x6007F74")]
	[Address(RVA = "0x31868AC", Offset = "0x31868AC", VA = "0x31868AC")]
	public CSGetLimitedChestProbabilityRes()
	{
	}
}
