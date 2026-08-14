using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001620")]
public class CSGetReportMailListRes
{
	[Token(Token = "0x4009539")]
	[FieldOffset(Offset = "0x8")]
	public List<ReportMailInfo> report_mails;

	[Token(Token = "0x6007C6A")]
	[Address(RVA = "0x30952A0", Offset = "0x30952A0", VA = "0x30952A0")]
	public CSGetReportMailListRes()
	{
	}
}
