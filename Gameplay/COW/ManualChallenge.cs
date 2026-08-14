using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000198")]
public class ManualChallenge : CSVBaseData
{
	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x8")]
	public uint m_EventID;

	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0xC")]
	public uint m_Type;

	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x10")]
	public uint m_Param1;

	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x14")]
	public uint m_Param2;

	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x18")]
	public string EventDesc;

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x153284C", Offset = "0x153284C", VA = "0x153284C")]
	public ManualChallenge()
	{
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x15328D0", Offset = "0x15328D0", VA = "0x15328D0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x1532934", Offset = "0x1532934", VA = "0x1532934", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
