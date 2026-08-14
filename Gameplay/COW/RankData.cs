using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000167")]
public class RankData : CSVBaseData
{
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x8")]
	public int Rank;

	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0xC")]
	public string RankName;

	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x10")]
	public int LowerBound;

	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x14")]
	public int UpperBound;

	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID IconRes;

	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID BigIconRes;

	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID LobbyIconRes;

	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID LadderSeasonRes;

	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x28")]
	public int RankGroup;

	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID FullScreenRankUpRes;

	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x30")]
	public string FullScreenRankUpClipName;

	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x34")]
	public int LobbyIconVFX;

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x196DA80", Offset = "0x196DA80", VA = "0x196DA80")]
	public RankData()
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x196DB04", Offset = "0x196DB04", VA = "0x196DB04", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x196DB68", Offset = "0x196DB68", VA = "0x196DB68", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
