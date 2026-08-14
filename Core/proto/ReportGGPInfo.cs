using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014EF")]
public class ReportGGPInfo
{
	[Token(Token = "0x400904F")]
	[FieldOffset(Offset = "0x8")]
	public bool is_report_to_ggp;

	[Token(Token = "0x4009050")]
	[FieldOffset(Offset = "0xC")]
	public string ggp_url;

	[Token(Token = "0x4009051")]
	[FieldOffset(Offset = "0x10")]
	public long ut_flag;

	[Token(Token = "0x6007B3F")]
	[Address(RVA = "0x33E17E4", Offset = "0x33E17E4", VA = "0x33E17E4")]
	public ReportGGPInfo()
	{
	}
}
