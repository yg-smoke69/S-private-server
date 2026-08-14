using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000105")]
public class CSRankData : CSVBaseData
{
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x8")]
	public int Rank;

	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0xC")]
	public string RankName;

	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x10")]
	public uint RankUpStar;

	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x14")]
	public uint LowerBound;

	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x18")]
	public uint UpperBound;

	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsRankProtect;

	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID IconRes;

	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID BigIconRes;

	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID LobbyIconRes;

	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID LadderSeasonRes;

	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID FullScreenRankUpRes;

	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x34")]
	public string FullScreenRankUpClipName;

	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x38")]
	public int RankGroup;

	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x3C")]
	public int LobbyIconVFX;

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x1821638", Offset = "0x1821638", VA = "0x1821638")]
	public CSRankData()
	{
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x18216BC", Offset = "0x18216BC", VA = "0x18216BC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x1821720", Offset = "0x1821720", VA = "0x1821720", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
