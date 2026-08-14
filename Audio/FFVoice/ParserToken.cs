using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B5D")]
internal enum ParserToken
{
	[Token(Token = "0x4019492")]
	None = 65536,
	[Token(Token = "0x4019493")]
	Number,
	[Token(Token = "0x4019494")]
	True,
	[Token(Token = "0x4019495")]
	False,
	[Token(Token = "0x4019496")]
	Null,
	[Token(Token = "0x4019497")]
	CharSeq,
	[Token(Token = "0x4019498")]
	Char,
	[Token(Token = "0x4019499")]
	Text,
	[Token(Token = "0x401949A")]
	Object,
	[Token(Token = "0x401949B")]
	ObjectPrime,
	[Token(Token = "0x401949C")]
	Pair,
	[Token(Token = "0x401949D")]
	PairRest,
	[Token(Token = "0x401949E")]
	Array,
	[Token(Token = "0x401949F")]
	ArrayPrime,
	[Token(Token = "0x40194A0")]
	Value,
	[Token(Token = "0x40194A1")]
	ValueRest,
	[Token(Token = "0x40194A2")]
	String,
	[Token(Token = "0x40194A3")]
	End,
	[Token(Token = "0x40194A4")]
	Epsilon
}
