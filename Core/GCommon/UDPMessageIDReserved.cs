using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200409B")]
internal enum UDPMessageIDReserved : uint
{
	[Token(Token = "0x401B243")]
	UDP_HELLO = 1u,
	[Token(Token = "0x401B244")]
	UDP_ACK,
	[Token(Token = "0x401B245")]
	UDP_PING,
	[Token(Token = "0x401B246")]
	UDP_BYEBYE,
	[Token(Token = "0x401B247")]
	UDP_LONGTIMENOSEE
}
