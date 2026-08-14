using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000104")]
public class CSRankingSeasonInfoData : CSVBaseData
{
	[Token(Token = "0x4000672")]
	[FieldOffset(Offset = "0x8")]
	public int Index;

	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0xC")]
	public string SeasonName;

	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTime;

	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x20")]
	public DateTime EndTime;

	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x30")]
	public string SeasonRewardBgUrl;

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x1822008", Offset = "0x1822008", VA = "0x1822008")]
	public CSRankingSeasonInfoData()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x182208C", Offset = "0x182208C", VA = "0x182208C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x18220F0", Offset = "0x18220F0", VA = "0x18220F0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
