using System;
using Il2CppDummyDll;

namespace DecalAtlas;

[Serializable]
[Token(Token = "0x2003E9A")]
public class GridCell
{
	[Token(Token = "0x401A71D")]
	[FieldOffset(Offset = "0x8")]
	public int Index;

	[Token(Token = "0x401A71E")]
	[FieldOffset(Offset = "0xC")]
	public int[] PersistDecals;

	[NonSerialized]
	[Token(Token = "0x401A71F")]
	[FieldOffset(Offset = "0x10")]
	public bool[,] RuntimeDecalVisibilities;

	[Token(Token = "0x6019793")]
	[Address(RVA = "0x231DF38", Offset = "0x231DF38", VA = "0x231DF38")]
	public GridCell(int index)
	{
	}

	[Token(Token = "0x6019794")]
	[Address(RVA = "0x231DF58", Offset = "0x231DF58", VA = "0x231DF58")]
	public void Load()
	{
	}
}
