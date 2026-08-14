using System;
using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B48")]
public class JsonException : ApplicationException
{
	[Token(Token = "0x601793B")]
	[Address(RVA = "0x321ED34", Offset = "0x321ED34", VA = "0x321ED34")]
	public JsonException()
	{
	}

	[Token(Token = "0x601793C")]
	[Address(RVA = "0x321ED3C", Offset = "0x321ED3C", VA = "0x321ED3C")]
	internal JsonException(ParserToken token)
	{
	}

	[Token(Token = "0x601793D")]
	[Address(RVA = "0x321EE0C", Offset = "0x321EE0C", VA = "0x321EE0C")]
	internal JsonException(ParserToken token, Exception inner_exception)
	{
	}

	[Token(Token = "0x601793E")]
	[Address(RVA = "0x321EEE4", Offset = "0x321EEE4", VA = "0x321EEE4")]
	internal JsonException(int c)
	{
	}

	[Token(Token = "0x601793F")]
	[Address(RVA = "0x321EFB4", Offset = "0x321EFB4", VA = "0x321EFB4")]
	internal JsonException(int c, Exception inner_exception)
	{
	}

	[Token(Token = "0x6017940")]
	[Address(RVA = "0x321F08C", Offset = "0x321F08C", VA = "0x321F08C")]
	public JsonException(string message)
	{
	}

	[Token(Token = "0x6017941")]
	[Address(RVA = "0x321F094", Offset = "0x321F094", VA = "0x321F094")]
	public JsonException(string message, Exception inner_exception)
	{
	}
}
