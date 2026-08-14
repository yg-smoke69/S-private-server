using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200408D")]
internal enum TCPMessageIDReserved : byte
{
	[Token(Token = "0x401B210")]
	TCP_INIT = 1,
	[Token(Token = "0x401B211")]
	TCP_HEARTBEAT,
	[Token(Token = "0x401B212")]
	TCP_USER
}
