using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000199")]
public class ManualInMapData : CSVBaseData
{
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x8")]
	public uint m_EventID;

	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0xC")]
	public uint m_TypeID;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x10")]
	public uint m_PageID;

	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x14")]
	public uint m_LocationID;

	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x18")]
	public string m_UnLockIcon;

	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x1C")]
	public string m_NameKey;

	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x20")]
	public string m_IntroKey;

	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x24")]
	public bool m_link;

	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x25")]
	public bool m_HaveUnkownFactor;

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x1532B34", Offset = "0x1532B34", VA = "0x1532B34")]
	public ManualInMapData()
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x1532BB8", Offset = "0x1532BB8", VA = "0x1532BB8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x1532C1C", Offset = "0x1532C1C", VA = "0x1532C1C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
