using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2002E01")]
internal class MatchResultScoreListConfig
{
	[Token(Token = "0x4011A0B")]
	[FieldOffset(Offset = "0x8")]
	public MatchResultScore[] scoreList;

	[Token(Token = "0x6013474")]
	[Address(RVA = "0x1544AE8", Offset = "0x1544AE8", VA = "0x1544AE8")]
	public MatchResultScoreListConfig()
	{
	}
}
