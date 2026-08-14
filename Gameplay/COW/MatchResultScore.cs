using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2002E02")]
internal class MatchResultScore
{
	[Token(Token = "0x4011A0C")]
	[FieldOffset(Offset = "0x8")]
	public uint groupMode;

	[Token(Token = "0x4011A0D")]
	[FieldOffset(Offset = "0xC")]
	public uint scorePerKill;

	[Token(Token = "0x4011A0E")]
	[FieldOffset(Offset = "0x10")]
	public RankScore[] scoreByRank;

	[Token(Token = "0x6013475")]
	[Address(RVA = "0x1544AE0", Offset = "0x1544AE0", VA = "0x1544AE0")]
	public MatchResultScore()
	{
	}
}
