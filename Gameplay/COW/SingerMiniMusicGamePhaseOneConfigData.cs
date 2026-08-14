using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200022C")]
public class SingerMiniMusicGamePhaseOneConfigData : CSVBaseData
{
	[Token(Token = "0x4000D5E")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4000D5F")]
	[FieldOffset(Offset = "0xC")]
	public float startTime;

	[Token(Token = "0x4000D60")]
	[FieldOffset(Offset = "0x10")]
	public float finishTime;

	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x14")]
	public float prefectGap;

	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x18")]
	public float goodGap;

	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x1C")]
	public float completeGap;

	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x20ECF90", Offset = "0x20ECF90", VA = "0x20ECF90")]
	public SingerMiniMusicGamePhaseOneConfigData()
	{
	}

	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x20ED014", Offset = "0x20ED014", VA = "0x20ED014", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x20ED078", Offset = "0x20ED078", VA = "0x20ED078", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x20ED260", Offset = "0x20ED260", VA = "0x20ED260")]
	public SingerMiniMusicGamePhaseOneConfigData Clone()
	{
		return null;
	}
}
