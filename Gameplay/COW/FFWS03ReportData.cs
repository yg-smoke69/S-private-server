using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000132")]
public class FFWS03ReportData : CSVBaseData
{
	[Token(Token = "0x40007D0")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40007D1")]
	[FieldOffset(Offset = "0xC")]
	public uint ReportsType;

	[Token(Token = "0x40007D2")]
	[FieldOffset(Offset = "0x10")]
	public string[] Parameter;

	[Token(Token = "0x40007D3")]
	[FieldOffset(Offset = "0x14")]
	public string Key;

	[Token(Token = "0x40007D4")]
	[FieldOffset(Offset = "0x18")]
	public string VFX;

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x2302D2C", Offset = "0x2302D2C", VA = "0x2302D2C")]
	public FFWS03ReportData()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x2302DB0", Offset = "0x2302DB0", VA = "0x2302DB0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x2302F74", Offset = "0x2302F74", VA = "0x2302F74", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
