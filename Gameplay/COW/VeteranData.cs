using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000260")]
public class VeteranData : CSVBaseData
{
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0xC")]
	public int LeaveDays;

	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x10")]
	public int VeteranDuration;

	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x14")]
	public int VeteranLevel;

	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x21A007C", Offset = "0x21A007C", VA = "0x21A007C")]
	public VeteranData()
	{
	}

	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x21A0100", Offset = "0x21A0100", VA = "0x21A0100", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x21A0158", Offset = "0x21A0158", VA = "0x21A0158", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
