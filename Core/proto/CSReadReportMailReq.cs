using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200161F")]
public class CSReadReportMailReq
{
	[Token(Token = "0x4009537")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] report_mail_ids;

	[Token(Token = "0x4009538")]
	[FieldOffset(Offset = "0xC")]
	public uint status;

	[Token(Token = "0x6007C69")]
	[Address(RVA = "0x3098ED4", Offset = "0x3098ED4", VA = "0x3098ED4")]
	public CSReadReportMailReq()
	{
	}
}
