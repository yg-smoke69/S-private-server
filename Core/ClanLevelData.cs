using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000D2")]
public class ClanLevelData : CSVBaseData
{
	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x8")]
	public int Level;

	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0xC")]
	public int MinHonor;

	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x10")]
	public int ExpBuffFactor;

	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x14")]
	public int GoldBuffFactor;

	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x18")]
	public int SizeImproved;

	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x1C")]
	public int GoldLimitImproved;

	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x20")]
	public int AwardType1;

	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x24")]
	public int AwardId1;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x28")]
	public int AwardNum1;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x2C")]
	public int AwardMaxNum1;

	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x30")]
	public int AwardType2;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x34")]
	public int AwardId2;

	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x38")]
	public int AwardNum2;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x3C")]
	public int AwardMaxNum2;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x40")]
	public string LevelIcon;

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0x230E410", Offset = "0x230E410", VA = "0x230E410")]
	public ClanLevelData()
	{
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x230E494", Offset = "0x230E494", VA = "0x230E494", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x230E4A0", Offset = "0x230E4A0", VA = "0x230E4A0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
