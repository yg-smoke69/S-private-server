using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000219")]
internal class ReportMainTypeConfigData : CSVBaseData
{
	[Token(Token = "0x4000C6D")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0xC")]
	public string Region;

	[Token(Token = "0x4000C6F")]
	[FieldOffset(Offset = "0x10")]
	public uint ReportMainType;

	[Token(Token = "0x4000C70")]
	[FieldOffset(Offset = "0x14")]
	public uint[] ReportType;

	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x240684C", Offset = "0x240684C", VA = "0x240684C")]
	public ReportMainTypeConfigData()
	{
	}

	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x24068D0", Offset = "0x24068D0", VA = "0x24068D0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x2406AAC", Offset = "0x2406AAC", VA = "0x2406AAC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
