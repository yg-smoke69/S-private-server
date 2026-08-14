using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200193E")]
public class CSReportPlayerBehaviorReq
{
	[Token(Token = "0x4009F37")]
	[FieldOffset(Offset = "0x8")]
	public ulong offender_id;

	[Token(Token = "0x4009F38")]
	[FieldOffset(Offset = "0x10")]
	public string offender_nickname;

	[Token(Token = "0x4009F39")]
	[FieldOffset(Offset = "0x18")]
	public ulong match_id;

	[Token(Token = "0x4009F3A")]
	[FieldOffset(Offset = "0x20")]
	public List<ECreditScore.ReportType> report_types;

	[Token(Token = "0x6007F97")]
	[Address(RVA = "0x30993B4", Offset = "0x30993B4", VA = "0x30993B4")]
	public CSReportPlayerBehaviorReq()
	{
	}
}
