using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000196")]
public class MailData : CSVBaseData
{
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0xC")]
	public int MaxMailNum;

	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x10")]
	public int ExpireDays;

	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x14")]
	public int MaxReportMailNum;

	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x18")]
	public int ReportMailExpireDays;

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x15325CC", Offset = "0x15325CC", VA = "0x15325CC")]
	public MailData()
	{
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x1532650", Offset = "0x1532650", VA = "0x1532650", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x15327E8", Offset = "0x15327E8", VA = "0x15327E8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
