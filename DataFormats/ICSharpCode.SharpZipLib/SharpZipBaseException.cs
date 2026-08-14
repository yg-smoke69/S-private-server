using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib;

[Serializable]
[Token(Token = "0x2003BEF")]
public class SharpZipBaseException : ApplicationException
{
	[Token(Token = "0x6017E6F")]
	[Address(RVA = "0x351C1F8", Offset = "0x351C1F8", VA = "0x351C1F8")]
	protected SharpZipBaseException(SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6017E70")]
	[Address(RVA = "0x351C220", Offset = "0x351C220", VA = "0x351C220")]
	public SharpZipBaseException()
	{
	}

	[Token(Token = "0x6017E71")]
	[Address(RVA = "0x351C230", Offset = "0x351C230", VA = "0x351C230")]
	public SharpZipBaseException(string message)
	{
	}

	[Token(Token = "0x6017E72")]
	[Address(RVA = "0x351C240", Offset = "0x351C240", VA = "0x351C240")]
	public SharpZipBaseException(string message, Exception innerException)
	{
	}
}
