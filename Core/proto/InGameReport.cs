using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001524")]
public class InGameReport
{
	[Token(Token = "0x40091DC")]
	[FieldOffset(Offset = "0x8")]
	public ECreditScore.ReportType report_type;

	[Token(Token = "0x40091DD")]
	[FieldOffset(Offset = "0xC")]
	public ulong[] reported_account_ids;

	[Token(Token = "0x6007B6D")]
	[Address(RVA = "0x30A3C68", Offset = "0x30A3C68", VA = "0x30A3C68")]
	public InGameReport()
	{
	}
}
