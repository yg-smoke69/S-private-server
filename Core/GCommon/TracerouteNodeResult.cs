using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004067")]
public class TracerouteNodeResult
{
	[Token(Token = "0x401B191")]
	[FieldOffset(Offset = "0x8")]
	public string target_ip;

	[Token(Token = "0x401B192")]
	[FieldOffset(Offset = "0xC")]
	public string status;

	[Token(Token = "0x401B193")]
	[FieldOffset(Offset = "0x10")]
	public int hop;

	[Token(Token = "0x401B194")]
	[FieldOffset(Offset = "0x14")]
	public string route_ip;

	[Token(Token = "0x401B195")]
	[FieldOffset(Offset = "0x18")]
	public bool is_final_route;

	[Token(Token = "0x401B196")]
	[FieldOffset(Offset = "0x1C")]
	public int average_delay;

	[Token(Token = "0x401B197")]
	[FieldOffset(Offset = "0x20")]
	public int loss_rate;

	[Token(Token = "0x601A363")]
	[Address(RVA = "0x323D96C", Offset = "0x323D96C", VA = "0x323D96C")]
	public TracerouteNodeResult()
	{
	}
}
