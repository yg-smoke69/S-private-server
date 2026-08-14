using GCommon;
using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C41")]
public class NetworkDetection_IPResult
{
	[Token(Token = "0x400B413")]
	[FieldOffset(Offset = "0x8")]
	public string target_ip;

	[Token(Token = "0x400B414")]
	[FieldOffset(Offset = "0xC")]
	public int average_delay;

	[Token(Token = "0x400B415")]
	[FieldOffset(Offset = "0x10")]
	public int loss_rate;

	[Token(Token = "0x400B416")]
	[FieldOffset(Offset = "0x14")]
	public TracerouteNodeResult[] traceroute_node_results;

	[Token(Token = "0x400B417")]
	[FieldOffset(Offset = "0x18")]
	public long time_stamp;

	[Token(Token = "0x400B418")]
	[FieldOffset(Offset = "0x20")]
	public int err_code;

	[Token(Token = "0x6008298")]
	[Address(RVA = "0x364D8F0", Offset = "0x364D8F0", VA = "0x364D8F0")]
	public NetworkDetection_IPResult()
	{
	}
}
