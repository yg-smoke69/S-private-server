using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DFA")]
public class NationFlagData : CSVBaseData
{
	[Token(Token = "0x40119F8")]
	[FieldOffset(Offset = "0x8")]
	public string countryOrArea;

	[Token(Token = "0x40119F9")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x40119FA")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x40119FB")]
	[FieldOffset(Offset = "0x14")]
	public string icon;

	[Token(Token = "0x40119FC")]
	[FieldOffset(Offset = "0x18")]
	public bool switchFlag;

	[Token(Token = "0x40119FD")]
	[FieldOffset(Offset = "0x19")]
	public bool isOpen;

	[Token(Token = "0x6013448")]
	[Address(RVA = "0x229291C", Offset = "0x229291C", VA = "0x229291C")]
	public NationFlagData()
	{
	}

	[Token(Token = "0x6013449")]
	[Address(RVA = "0x22929A0", Offset = "0x22929A0", VA = "0x22929A0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x601344A")]
	[Address(RVA = "0x22929F8", Offset = "0x22929F8", VA = "0x22929F8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
