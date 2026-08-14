using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F4")]
public enum EPinSourceType : byte
{
	[Token(Token = "0x4000633")]
	Default = 0,
	[Token(Token = "0x4000634")]
	PinActivity = 1,
	[Token(Token = "0x4000635")]
	PinMatch = 2,
	[Token(Token = "0x4000636")]
	PinFFMax = 3,
	[Token(Token = "0x4000637")]
	UpperLimit = 4,
	[Token(Token = "0x4000638")]
	INVALID = byte.MaxValue
}
