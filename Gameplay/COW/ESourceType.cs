using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000DD")]
public enum ESourceType : byte
{
	[Token(Token = "0x4000534")]
	ALL = 0,
	[Token(Token = "0x4000535")]
	CHARACTAR = 1,
	[Token(Token = "0x4000536")]
	EVENT = 2,
	[Token(Token = "0x4000537")]
	RANKING = 3,
	[Token(Token = "0x4000538")]
	STORE = 4,
	[Token(Token = "0x4000539")]
	ELITEPASS = 5,
	[Token(Token = "0x400053A")]
	GACHA = 6,
	[Token(Token = "0x400053B")]
	ESPORTS = 7,
	[Token(Token = "0x400053C")]
	OFFLINEEVENT = 8,
	[Token(Token = "0x400053D")]
	OTHER = 9,
	[Token(Token = "0x400053E")]
	NULL = byte.MaxValue
}
