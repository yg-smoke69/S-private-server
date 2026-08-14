using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000218")]
public class ReplayHighlightsData : CSVBaseData
{
	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x8")]
	public string ID;

	[Token(Token = "0x4000C68")]
	[FieldOffset(Offset = "0xC")]
	public uint GameMode;

	[Token(Token = "0x4000C69")]
	[FieldOffset(Offset = "0x10")]
	public uint EventType;

	[Token(Token = "0x4000C6A")]
	[FieldOffset(Offset = "0x14")]
	public uint Score;

	[Token(Token = "0x4000C6B")]
	[FieldOffset(Offset = "0x18")]
	public uint BeforeSecond;

	[Token(Token = "0x4000C6C")]
	[FieldOffset(Offset = "0x1C")]
	public uint AfterSecond;

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x2400D38", Offset = "0x2400D38", VA = "0x2400D38")]
	public ReplayHighlightsData()
	{
	}

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x2400DBC", Offset = "0x2400DBC", VA = "0x2400DBC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x2400E14", Offset = "0x2400E14", VA = "0x2400E14", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
