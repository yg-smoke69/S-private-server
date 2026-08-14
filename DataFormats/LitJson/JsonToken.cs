using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B84")]
public enum JsonToken
{
	[Token(Token = "0x401959C")]
	None,
	[Token(Token = "0x401959D")]
	ObjectStart,
	[Token(Token = "0x401959E")]
	PropertyName,
	[Token(Token = "0x401959F")]
	ObjectEnd,
	[Token(Token = "0x40195A0")]
	ArrayStart,
	[Token(Token = "0x40195A1")]
	ArrayEnd,
	[Token(Token = "0x40195A2")]
	Int,
	[Token(Token = "0x40195A3")]
	Long,
	[Token(Token = "0x40195A4")]
	Double,
	[Token(Token = "0x40195A5")]
	String,
	[Token(Token = "0x40195A6")]
	Boolean,
	[Token(Token = "0x40195A7")]
	Null
}
