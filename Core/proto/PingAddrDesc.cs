using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200171E")]
public class PingAddrDesc
{
	[Token(Token = "0x40098CE")]
	[FieldOffset(Offset = "0x8")]
	public string ip;

	[Token(Token = "0x40098CF")]
	[FieldOffset(Offset = "0xC")]
	public bool is_traceroute;

	[Token(Token = "0x6007D78")]
	[Address(RVA = "0x33DF7E8", Offset = "0x33DF7E8", VA = "0x33DF7E8")]
	public PingAddrDesc()
	{
	}
}
