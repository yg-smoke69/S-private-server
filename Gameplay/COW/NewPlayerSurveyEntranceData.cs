using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001BB")]
public class NewPlayerSurveyEntranceData : CSVBaseData
{
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x8")]
	public uint SurveyId;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0xC")]
	public string SurveyLink;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x10")]
	public uint LevelLimit;

	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x14")]
	public string Region;

	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x18")]
	public uint[] RewardID;

	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] RewardNum;

	[Token(Token = "0x600095F")]
	[Address(RVA = "0x28B3AC8", Offset = "0x28B3AC8", VA = "0x28B3AC8")]
	public NewPlayerSurveyEntranceData()
	{
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0x28B3B4C", Offset = "0x28B3B4C", VA = "0x28B3B4C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0x28B3BB0", Offset = "0x28B3BB0", VA = "0x28B3BB0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
