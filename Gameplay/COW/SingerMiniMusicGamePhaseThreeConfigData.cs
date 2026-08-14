using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200022E")]
public class SingerMiniMusicGamePhaseThreeConfigData : CSVBaseData
{
	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0xC")]
	public float time;

	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x10")]
	public float prefectGap;

	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x14")]
	public float goodGap;

	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x18")]
	public float completeGap;

	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x1C")]
	public int gameID;

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x20ED8C4", Offset = "0x20ED8C4", VA = "0x20ED8C4")]
	public SingerMiniMusicGamePhaseThreeConfigData()
	{
	}

	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x20ED948", Offset = "0x20ED948", VA = "0x20ED948", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x20ED9AC", Offset = "0x20ED9AC", VA = "0x20ED9AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x20EDB94", Offset = "0x20EDB94", VA = "0x20EDB94")]
	public SingerMiniMusicGamePhaseThreeConfigData Clone()
	{
		return null;
	}
}
