using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Serializable]
[Token(Token = "0x2003C08")]
public class ZipException : SharpZipBaseException
{
	[Token(Token = "0x6017F8C")]
	[Address(RVA = "0xA2B89C", Offset = "0xA2B89C", VA = "0xA2B89C")]
	protected ZipException(SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6017F8D")]
	[Address(RVA = "0xA2B8BC", Offset = "0xA2B8BC", VA = "0xA2B8BC")]
	public ZipException()
	{
	}

	[Token(Token = "0x6017F8E")]
	[Address(RVA = "0xA254EC", Offset = "0xA254EC", VA = "0xA254EC")]
	public ZipException(string message)
	{
	}

	[Token(Token = "0x6017F8F")]
	[Address(RVA = "0xA2B8C4", Offset = "0xA2B8C4", VA = "0xA2B8C4")]
	public ZipException(string message, Exception exception)
	{
	}
}
