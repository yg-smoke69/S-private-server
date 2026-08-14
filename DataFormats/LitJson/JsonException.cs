using System;
using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B77")]
public class JsonException : ApplicationException
{
	[Token(Token = "0x6017B29")]
	[Address(RVA = "0x311FBE8", Offset = "0x311FBE8", VA = "0x311FBE8")]
	public JsonException()
	{
	}

	[Token(Token = "0x6017B2A")]
	[Address(RVA = "0x311FBF0", Offset = "0x311FBF0", VA = "0x311FBF0")]
	internal JsonException(ParserToken token)
	{
	}

	[Token(Token = "0x6017B2B")]
	[Address(RVA = "0x311FCC0", Offset = "0x311FCC0", VA = "0x311FCC0")]
	internal JsonException(ParserToken token, Exception inner_exception)
	{
	}

	[Token(Token = "0x6017B2C")]
	[Address(RVA = "0x311FD98", Offset = "0x311FD98", VA = "0x311FD98")]
	internal JsonException(int c)
	{
	}

	[Token(Token = "0x6017B2D")]
	[Address(RVA = "0x311FE68", Offset = "0x311FE68", VA = "0x311FE68")]
	internal JsonException(int c, Exception inner_exception)
	{
	}

	[Token(Token = "0x6017B2E")]
	[Address(RVA = "0x311FF40", Offset = "0x311FF40", VA = "0x311FF40")]
	public JsonException(string message)
	{
	}

	[Token(Token = "0x6017B2F")]
	[Address(RVA = "0x311FF48", Offset = "0x311FF48", VA = "0x311FF48")]
	public JsonException(string message, Exception inner_exception)
	{
	}
}
