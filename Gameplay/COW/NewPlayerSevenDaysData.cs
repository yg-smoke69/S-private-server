using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20001BA")]
public class NewPlayerSevenDaysData : CSVBaseData
{
	[Token(Token = "0x4000AAD")]
	[FieldOffset(Offset = "0x8")]
	public int achievementID;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0xC")]
	public string achievementIntro;

	[Token(Token = "0x4000AAF")]
	[FieldOffset(Offset = "0x10")]
	public string ahievemtnDetailKey;

	[Token(Token = "0x4000AB0")]
	[FieldOffset(Offset = "0x14")]
	public bool haveGoto;

	[Token(Token = "0x4000AB1")]
	[FieldOffset(Offset = "0x18")]
	public int gotoGuideID;

	[Token(Token = "0x4000AB2")]
	[FieldOffset(Offset = "0x1C")]
	public int CdtValue;

	[Token(Token = "0x4000AB3")]
	[FieldOffset(Offset = "0x20")]
	public AwardDesc award;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x24")]
	public int PreCdtValue;

	[Token(Token = "0x600095C")]
	[Address(RVA = "0x28B3630", Offset = "0x28B3630", VA = "0x28B3630")]
	public NewPlayerSevenDaysData()
	{
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0x28B36B4", Offset = "0x28B36B4", VA = "0x28B36B4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0x28B3718", Offset = "0x28B3718", VA = "0x28B3718", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
