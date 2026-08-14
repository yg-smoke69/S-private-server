using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200406A")]
public enum ETaskType
{
	[Token(Token = "0x401B19D")]
	eNone = 0,
	[Token(Token = "0x401B19E")]
	eIDC = 1,
	[Token(Token = "0x401B19F")]
	eAutoPing = 2,
	[Token(Token = "0x401B1A0")]
	eConnectReport = 4,
	[Token(Token = "0x401B1A1")]
	eCDN = 8,
	[Token(Token = "0x401B1A2")]
	eSelfReport = 0x10
}
