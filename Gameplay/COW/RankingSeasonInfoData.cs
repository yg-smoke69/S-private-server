using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200020E")]
public class RankingSeasonInfoData : CSVBaseData
{
	[Token(Token = "0x4000C29")]
	[FieldOffset(Offset = "0x8")]
	public int Index;

	[Token(Token = "0x4000C2A")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTime;

	[Token(Token = "0x4000C2B")]
	[FieldOffset(Offset = "0x20")]
	public DateTime EndTime;

	[Token(Token = "0x4000C2C")]
	[FieldOffset(Offset = "0x30")]
	public bool IsOpen;

	[Token(Token = "0x4000C2D")]
	[FieldOffset(Offset = "0x34")]
	public string SeasonName;

	[Token(Token = "0x4000C2E")]
	[FieldOffset(Offset = "0x38")]
	public string SeasonRewardBgUrl;

	[Token(Token = "0x4000C2F")]
	[FieldOffset(Offset = "0x3C")]
	public string SeasonInfoPreview;

	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x196E42C", Offset = "0x196E42C", VA = "0x196E42C")]
	public RankingSeasonInfoData()
	{
	}

	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x196E574", Offset = "0x196E574", VA = "0x196E574", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x196E5D8", Offset = "0x196E5D8", VA = "0x196E5D8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
