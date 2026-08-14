using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001993")]
public class CSReportNetworkMetricEventReq
{
	[Token(Token = "0x400A01E")]
	[FieldOffset(Offset = "0x8")]
	public NetworkMetricEvent network_metric_event;

	[Token(Token = "0x400A01F")]
	[FieldOffset(Offset = "0xC")]
	public string network_detail;

	[Token(Token = "0x6007FEE")]
	[Address(RVA = "0x3099314", Offset = "0x3099314", VA = "0x3099314")]
	public CSReportNetworkMetricEventReq()
	{
	}
}
