using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200020B")]
public class RankBRStarScoreData : CSVBaseData
{
	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x8")]
	public uint Rank;

	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0xC")]
	public uint StarCount;

	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x10")]
	public bool IsFuncAlive;

	[Token(Token = "0x4000C1B")]
	[FieldOffset(Offset = "0x14")]
	public uint LowerBound;

	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x18")]
	public uint UpperBound;

	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID ColorResource;

	[Token(Token = "0x6000A88")]
	[Address(RVA = "0x196D0AC", Offset = "0x196D0AC", VA = "0x196D0AC")]
	public RankBRStarScoreData()
	{
	}

	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x196D178", Offset = "0x196D178", VA = "0x196D178", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A8A")]
	[Address(RVA = "0x196D1DC", Offset = "0x196D1DC", VA = "0x196D1DC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
