using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B55")]
public enum JsonToken
{
	[Token(Token = "0x4019432")]
	None,
	[Token(Token = "0x4019433")]
	ObjectStart,
	[Token(Token = "0x4019434")]
	PropertyName,
	[Token(Token = "0x4019435")]
	ObjectEnd,
	[Token(Token = "0x4019436")]
	ArrayStart,
	[Token(Token = "0x4019437")]
	ArrayEnd,
	[Token(Token = "0x4019438")]
	Int,
	[Token(Token = "0x4019439")]
	Long,
	[Token(Token = "0x401943A")]
	Double,
	[Token(Token = "0x401943B")]
	String,
	[Token(Token = "0x401943C")]
	Boolean,
	[Token(Token = "0x401943D")]
	Null
}
