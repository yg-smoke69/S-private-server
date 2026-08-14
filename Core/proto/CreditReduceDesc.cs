using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C06")]
public class CreditReduceDesc
{
	[Token(Token = "0x400B04F")]
	[FieldOffset(Offset = "0x8")]
	public ECreditScore.ReportType report_type;

	[Token(Token = "0x400B050")]
	[FieldOffset(Offset = "0xC")]
	public uint behavior_rule_id;

	[Token(Token = "0x400B051")]
	[FieldOffset(Offset = "0x10")]
	public uint credit_reduce;

	[Token(Token = "0x400B052")]
	[FieldOffset(Offset = "0x14")]
	public bool if_report;

	[Token(Token = "0x6008261")]
	[Address(RVA = "0x309D900", Offset = "0x309D900", VA = "0x309D900")]
	public CreditReduceDesc()
	{
	}
}
