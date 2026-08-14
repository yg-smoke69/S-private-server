using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004066")]
public class TracerouteResult : NetDetectionResult
{
	[Token(Token = "0x401B18E")]
	[FieldOffset(Offset = "0xC")]
	public TracerouteNodeResult[] traceroute_node_results;

	[Token(Token = "0x401B18F")]
	[FieldOffset(Offset = "0x10")]
	public long time_stamp;

	[Token(Token = "0x401B190")]
	[FieldOffset(Offset = "0x18")]
	public ETraceRouteError err_code;

	[Token(Token = "0x601A362")]
	[Address(RVA = "0x323D974", Offset = "0x323D974", VA = "0x323D974")]
	public TracerouteResult()
	{
	}
}
