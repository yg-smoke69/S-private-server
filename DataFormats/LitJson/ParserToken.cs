using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B8C")]
internal enum ParserToken
{
	[Token(Token = "0x40195FD")]
	None = 65536,
	[Token(Token = "0x40195FE")]
	Number,
	[Token(Token = "0x40195FF")]
	True,
	[Token(Token = "0x4019600")]
	False,
	[Token(Token = "0x4019601")]
	Null,
	[Token(Token = "0x4019602")]
	CharSeq,
	[Token(Token = "0x4019603")]
	Char,
	[Token(Token = "0x4019604")]
	Text,
	[Token(Token = "0x4019605")]
	Object,
	[Token(Token = "0x4019606")]
	ObjectPrime,
	[Token(Token = "0x4019607")]
	Pair,
	[Token(Token = "0x4019608")]
	PairRest,
	[Token(Token = "0x4019609")]
	Array,
	[Token(Token = "0x401960A")]
	ArrayPrime,
	[Token(Token = "0x401960B")]
	Value,
	[Token(Token = "0x401960C")]
	ValueRest,
	[Token(Token = "0x401960D")]
	String,
	[Token(Token = "0x401960E")]
	End,
	[Token(Token = "0x401960F")]
	Epsilon
}
