using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x20001E8")]
public class PeakRankData : CSVBaseData
{
	[Token(Token = "0x4000B6C")]
	[FieldOffset(Offset = "0x8")]
	public int MinRequestRank;

	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0xC")]
	public DGNDKMLMLPM RankType;

	[Token(Token = "0x4000B6E")]
	[FieldOffset(Offset = "0x10")]
	public int RankMasterLevel;

	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x14")]
	public string RankName;

	[Token(Token = "0x4000B70")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID SmallIconRes;

	[Token(Token = "0x4000B71")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID BigIconRes;

	[Token(Token = "0x4000B72")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID LobbyIconRes;

	[Token(Token = "0x4000B73")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID LadderSeasonRes;

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x2DDEACC", Offset = "0x2DDEACC", VA = "0x2DDEACC")]
	public PeakRankData()
	{
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x2DDEB50", Offset = "0x2DDEB50", VA = "0x2DDEB50", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x2DDEC28", Offset = "0x2DDEC28", VA = "0x2DDEC28", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
