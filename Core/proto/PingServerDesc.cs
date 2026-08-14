using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AEC")]
public class PingServerDesc
{
	[Token(Token = "0x400A941")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A942")]
	[FieldOffset(Offset = "0xC")]
	public string ip;

	[Token(Token = "0x400A943")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A944")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400A945")]
	[FieldOffset(Offset = "0x18")]
	public float ping_random;

	[Token(Token = "0x400A946")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_traceroute;

	[Token(Token = "0x6008147")]
	[Address(RVA = "0x33DF888", Offset = "0x33DF888", VA = "0x33DF888")]
	public PingServerDesc()
	{
	}
}
