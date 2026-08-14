using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002477")]
internal class PlayerLeaderBoardData
{
	[Token(Token = "0x400E247")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG PlayerId;

	[Token(Token = "0x400E248")]
	[FieldOffset(Offset = "0x20")]
	public int Rank;

	[Token(Token = "0x400E249")]
	[FieldOffset(Offset = "0x24")]
	public List<int> ScoreType;

	[Token(Token = "0x600CFD6")]
	[Address(RVA = "0x1C0A160", Offset = "0x1C0A160", VA = "0x1C0A160")]
	public PlayerLeaderBoardData()
	{
	}
}
