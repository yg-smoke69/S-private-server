using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001374")]
public class ReportMailInfo
{
	[Token(Token = "0x400898E")]
	[FieldOffset(Offset = "0x8")]
	public ulong report_mail_id;

	[Token(Token = "0x400898F")]
	[FieldOffset(Offset = "0x10")]
	public EMail.ReportMailType report_mail_type;

	[Token(Token = "0x4008990")]
	[FieldOffset(Offset = "0x14")]
	public ReportInfo report_info;

	[Token(Token = "0x4008991")]
	[FieldOffset(Offset = "0x18")]
	public long receive_time;

	[Token(Token = "0x4008992")]
	[FieldOffset(Offset = "0x20")]
	public EMail.Status status;

	[Token(Token = "0x6007A75")]
	[Address(RVA = "0x33E1958", Offset = "0x33E1958", VA = "0x33E1958")]
	public ReportMailInfo()
	{
	}
}
