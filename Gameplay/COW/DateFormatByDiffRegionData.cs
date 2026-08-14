using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200010D")]
public class DateFormatByDiffRegionData : CSVBaseData
{
	[Token(Token = "0x40006D6")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x40006D7")]
	[FieldOffset(Offset = "0xC")]
	public string Language;

	[Token(Token = "0x40006D8")]
	[FieldOffset(Offset = "0x10")]
	public string FormatWithYear;

	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x14")]
	public string FormatNoYear;

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x1C88DE4", Offset = "0x1C88DE4", VA = "0x1C88DE4")]
	public DateFormatByDiffRegionData()
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x1C88E68", Offset = "0x1C88E68", VA = "0x1C88E68", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x1C88EE0", Offset = "0x1C88EE0", VA = "0x1C88EE0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
