using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200019B")]
public class ManualMapReward : CSVBaseData
{
	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x8")]
	public uint m_MapID;

	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0xC")]
	public string m_MapTitleKey;

	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x10")]
	public string m_MapIntroKey;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x14")]
	public uint m_AwardType1;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x18")]
	public string m_AwardName1;

	[Token(Token = "0x40009E6")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_AwardID1;

	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x20")]
	public uint m_AwardNum1;

	[Token(Token = "0x40009E8")]
	[FieldOffset(Offset = "0x24")]
	public uint m_AwardTime1;

	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x28")]
	public uint m_AwardType2;

	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0x2C")]
	public string m_AwardName2;

	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x30")]
	public uint m_AwardID2;

	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x34")]
	public uint m_AwardNum2;

	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x38")]
	public uint m_AwardTime2;

	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x3C")]
	public uint m_AwardType3;

	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x40")]
	public string m_AwardName3;

	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x44")]
	public uint m_AwardID3;

	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x48")]
	public uint m_AwardNum3;

	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x4C")]
	public uint m_AwardTime3;

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x15331FC", Offset = "0x15331FC", VA = "0x15331FC")]
	public ManualMapReward()
	{
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x1533280", Offset = "0x1533280", VA = "0x1533280", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x15332E4", Offset = "0x15332E4", VA = "0x15332E4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
