using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace LumenWorks.Framework.IO.Csv;

[Serializable]
[Token(Token = "0x2003B91")]
public class MalformedCsvException : Exception
{
	[Token(Token = "0x401963F")]
	[FieldOffset(Offset = "0x34")]
	private string _message;

	[Token(Token = "0x4019640")]
	[FieldOffset(Offset = "0x38")]
	private string _rawData;

	[Token(Token = "0x4019641")]
	[FieldOffset(Offset = "0x3C")]
	private int _currentFieldIndex;

	[Token(Token = "0x4019642")]
	[FieldOffset(Offset = "0x40")]
	private long _currentRecordIndex;

	[Token(Token = "0x4019643")]
	[FieldOffset(Offset = "0x48")]
	private int _currentPosition;

	[Token(Token = "0x17001892")]
	public string RawData
	{
		[Token(Token = "0x6017C81")]
		[Address(RVA = "0x1C69F64", Offset = "0x1C69F64", VA = "0x1C69F64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001893")]
	public int CurrentPosition
	{
		[Token(Token = "0x6017C82")]
		[Address(RVA = "0x1C69F6C", Offset = "0x1C69F6C", VA = "0x1C69F6C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001894")]
	public long CurrentRecordIndex
	{
		[Token(Token = "0x6017C83")]
		[Address(RVA = "0x1C69F74", Offset = "0x1C69F74", VA = "0x1C69F74")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001895")]
	public int CurrentFieldIndex
	{
		[Token(Token = "0x6017C84")]
		[Address(RVA = "0x1C69F7C", Offset = "0x1C69F7C", VA = "0x1C69F7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001896")]
	public override string Message
	{
		[Token(Token = "0x6017C85")]
		[Address(RVA = "0x1C69F84", Offset = "0x1C69F84", VA = "0x1C69F84", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6017C7B")]
	[Address(RVA = "0x1C6981C", Offset = "0x1C6981C", VA = "0x1C6981C")]
	public MalformedCsvException()
	{
	}

	[Token(Token = "0x6017C7C")]
	[Address(RVA = "0x1C6998C", Offset = "0x1C6998C", VA = "0x1C6998C")]
	public MalformedCsvException(string message)
	{
	}

	[Token(Token = "0x6017C7D")]
	[Address(RVA = "0x1C69828", Offset = "0x1C69828", VA = "0x1C69828")]
	public MalformedCsvException(string message, Exception innerException)
	{
	}

	[Token(Token = "0x6017C7E")]
	[Address(RVA = "0x1C67A50", Offset = "0x1C67A50", VA = "0x1C67A50")]
	public MalformedCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex)
	{
	}

	[Token(Token = "0x6017C7F")]
	[Address(RVA = "0x1C69994", Offset = "0x1C69994", VA = "0x1C69994")]
	public MalformedCsvException(string rawData, int currentPosition, long currentRecordIndex, int currentFieldIndex, Exception innerException)
	{
	}

	[Token(Token = "0x6017C80")]
	[Address(RVA = "0x1C69DC0", Offset = "0x1C69DC0", VA = "0x1C69DC0")]
	protected MalformedCsvException(SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6017C86")]
	[Address(RVA = "0x1C69F8C", Offset = "0x1C69F8C", VA = "0x1C69F8C", Slot = "13")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
