using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DecalAtlas;

[Serializable]
[Token(Token = "0x2003E9B")]
public class GridForGranularity
{
	[Token(Token = "0x401A720")]
	[FieldOffset(Offset = "0x8")]
	public int Granularity;

	[Token(Token = "0x401A721")]
	[FieldOffset(Offset = "0xC")]
	public int NumberOfCells;

	[Token(Token = "0x401A722")]
	[FieldOffset(Offset = "0x10")]
	private GridCell[] _PersistCells;

	[NonSerialized]
	[Token(Token = "0x401A723")]
	[FieldOffset(Offset = "0x14")]
	public GridCell[] RuntimeCells;

	[NonSerialized]
	[Token(Token = "0x401A724")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<int, int> IndexMap;

	[Token(Token = "0x6019795")]
	[Address(RVA = "0x231E038", Offset = "0x231E038", VA = "0x231E038")]
	public GridForGranularity(int granularity, int cells)
	{
	}

	[Token(Token = "0x6019796")]
	[Address(RVA = "0x231DD60", Offset = "0x231DD60", VA = "0x231DD60")]
	public void Load()
	{
	}
}
