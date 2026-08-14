using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004054")]
public enum HttpErrorCode
{
	[Token(Token = "0x401B134")]
	OK = 0,
	[Token(Token = "0x401B135")]
	InvalidArgs = 1,
	[Token(Token = "0x401B136")]
	Exception = 2,
	[Token(Token = "0x401B137")]
	Timeout = 3,
	[Token(Token = "0x401B138")]
	DataTypeError = 4,
	[Token(Token = "0x401B139")]
	SSLAuthError = 5,
	[Token(Token = "0x401B13A")]
	DefaultHttpOK = 200,
	[Token(Token = "0x401B13B")]
	BadGateway = 502,
	[Token(Token = "0x401B13C")]
	ServiceUnavailable = 503
}
