using System;
using Il2CppDummyDll;

namespace COW;

[Serializable]
[Token(Token = "0x2002E03")]
internal class RankScore
{
	[Token(Token = "0x4011A0F")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x4011A10")]
	[FieldOffset(Offset = "0xC")]
	public uint score;

	[Token(Token = "0x6013476")]
	[Address(RVA = "0x196E404", Offset = "0x196E404", VA = "0x196E404")]
	public RankScore(uint rank, uint score)
	{
	}
}
