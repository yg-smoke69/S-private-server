using System;
using Il2CppDummyDll;

namespace DecalAtlas;

[Serializable]
[Token(Token = "0x2003E9C")]
public class GranularityGrids
{
	[Token(Token = "0x401A725")]
	[FieldOffset(Offset = "0x8")]
	public int Granularities;

	[Token(Token = "0x401A726")]
	[FieldOffset(Offset = "0xC")]
	private GridForGranularity[] _PersistGrids;

	[NonSerialized]
	[Token(Token = "0x401A727")]
	[FieldOffset(Offset = "0x10")]
	public GridForGranularity[] RuntimeGrids;

	[Token(Token = "0x6019797")]
	[Address(RVA = "0x231DCE4", Offset = "0x231DCE4", VA = "0x231DCE4")]
	public GranularityGrids(int granularities)
	{
	}

	[Token(Token = "0x6019798")]
	[Address(RVA = "0x23186F4", Offset = "0x23186F4", VA = "0x23186F4")]
	public void Load()
	{
	}
}
