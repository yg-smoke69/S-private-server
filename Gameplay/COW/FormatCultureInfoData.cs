using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200018E")]
public class FormatCultureInfoData : CSVBaseData
{
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x8")]
	public string Language;

	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0xC")]
	public string RegionGroup;

	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x10")]
	public string[] Regions;

	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x14")]
	public string CultureCode;

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0xDEF3E4", Offset = "0xDEF3E4", VA = "0xDEF3E4")]
	public FormatCultureInfoData()
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0xDEF468", Offset = "0xDEF468", VA = "0xDEF468", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0xDEF540", Offset = "0xDEF540", VA = "0xDEF540", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
