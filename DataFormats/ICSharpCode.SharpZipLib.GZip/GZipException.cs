using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.GZip;

[Serializable]
[Token(Token = "0x2003BEB")]
public class GZipException : SharpZipBaseException
{
	[Token(Token = "0x6017E5C")]
	[Address(RVA = "0x351C1D8", Offset = "0x351C1D8", VA = "0x351C1D8")]
	protected GZipException(SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6017E5D")]
	[Address(RVA = "0x351C218", Offset = "0x351C218", VA = "0x351C218")]
	public GZipException()
	{
	}

	[Token(Token = "0x6017E5E")]
	[Address(RVA = "0x351C228", Offset = "0x351C228", VA = "0x351C228")]
	public GZipException(string message)
	{
	}

	[Token(Token = "0x6017E5F")]
	[Address(RVA = "0x351C238", Offset = "0x351C238", VA = "0x351C238")]
	public GZipException(string message, Exception innerException)
	{
	}
}
