using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200019A")]
public class ManualMapData : CSVBaseData
{
	[Token(Token = "0x40009DB")]
	[FieldOffset(Offset = "0x8")]
	public uint m_EventID;

	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0xC")]
	public uint m_MapID;

	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x10")]
	public uint m_LocationID;

	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x14")]
	public uint m_FragmentRadius;

	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x18")]
	public string m_TriggerName;

	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x1C")]
	public string FragmentName;

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x1532ED8", Offset = "0x1532ED8", VA = "0x1532ED8")]
	public ManualMapData()
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x1532F5C", Offset = "0x1532F5C", VA = "0x1532F5C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x1532FC0", Offset = "0x1532FC0", VA = "0x1532FC0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
