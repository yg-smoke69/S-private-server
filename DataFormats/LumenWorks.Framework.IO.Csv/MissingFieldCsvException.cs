using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace LumenWorks.Framework.IO.Csv;

[Serializable]
[Token(Token = "0x2003B92")]
public class MissingFieldCsvException : MalformedCsvException
{
	[Token(Token = "0x6017C87")]
	[Address(RVA = "0x1C6A114", Offset = "0x1C6A114", VA = "0x1C6A114")]
	public MissingFieldCsvException()
	{
	}

	[Token(Token = "0x6017C88")]
	[Address(RVA = "0x1C6A120", Offset = "0x1C6A120", VA = "0x1C6A120")]
	public MissingFieldCsvException(string message)
	{
	}

	[Token(Token = "0x6017C89")]
	[Address(RVA = "0x1C6A128", Offset = "0x1C6A128", VA = "0x1C6A128")]
	public MissingFieldCsvException(string message, Exception innerException)
	{
	}

	[Token(Token = "0x6017C8A")]
	[Address(RVA = "0x1C68AC0", Offset = "0x1C68AC0", VA = "0x1C68AC0")]
	public MissingFieldCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex)
	{
	}

	[Token(Token = "0x6017C8B")]
	[Address(RVA = "0x1C6A12C", Offset = "0x1C6A12C", VA = "0x1C6A12C")]
	public MissingFieldCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex, Exception innerException)
	{
	}

	[Token(Token = "0x6017C8C")]
	[Address(RVA = "0x1C6A158", Offset = "0x1C6A158", VA = "0x1C6A158")]
	protected MissingFieldCsvException(SerializationInfo info, StreamingContext context)
	{
	}
}
