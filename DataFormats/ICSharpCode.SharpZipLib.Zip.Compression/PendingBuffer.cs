using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BFA")]
public class PendingBuffer
{
	[Token(Token = "0x401993B")]
	[FieldOffset(Offset = "0x8")]
	private byte[] buffer_;

	[Token(Token = "0x401993C")]
	[FieldOffset(Offset = "0xC")]
	private int start;

	[Token(Token = "0x401993D")]
	[FieldOffset(Offset = "0x10")]
	private int end;

	[Token(Token = "0x401993E")]
	[FieldOffset(Offset = "0x14")]
	private uint bits;

	[Token(Token = "0x401993F")]
	[FieldOffset(Offset = "0x18")]
	private int bitCount;

	[Token(Token = "0x1700191F")]
	public int BitCount
	{
		[Token(Token = "0x6017EDE")]
		[Address(RVA = "0xA23308", Offset = "0xA23308", VA = "0xA23308")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001920")]
	public bool IsFlushed
	{
		[Token(Token = "0x6017EE2")]
		[Address(RVA = "0xA23484", Offset = "0xA23484", VA = "0xA23484")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017ED7")]
	[Address(RVA = "0xA2307C", Offset = "0xA2307C", VA = "0xA2307C")]
	public PendingBuffer()
	{
	}

	[Token(Token = "0x6017ED8")]
	[Address(RVA = "0xA1EE84", Offset = "0xA1EE84", VA = "0xA1EE84")]
	public PendingBuffer(int bufferSize)
	{
	}

	[Token(Token = "0x6017ED9")]
	[Address(RVA = "0xA23084", Offset = "0xA23084", VA = "0xA23084")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017EDA")]
	[Address(RVA = "0xA23098", Offset = "0xA23098", VA = "0xA23098")]
	public void WriteByte(int value)
	{
	}

	[Token(Token = "0x6017EDB")]
	[Address(RVA = "0xA230EC", Offset = "0xA230EC", VA = "0xA230EC")]
	public void WriteShort(int value)
	{
	}

	[Token(Token = "0x6017EDC")]
	[Address(RVA = "0xA2318C", Offset = "0xA2318C", VA = "0xA2318C")]
	public void WriteInt(int value)
	{
	}

	[Token(Token = "0x6017EDD")]
	[Address(RVA = "0xA232BC", Offset = "0xA232BC", VA = "0xA232BC")]
	public void WriteBlock(byte[] block, int offset, int length)
	{
	}

	[Token(Token = "0x6017EDF")]
	[Address(RVA = "0xA23310", Offset = "0xA23310", VA = "0xA23310")]
	public void AlignToByte()
	{
	}

	[Token(Token = "0x6017EE0")]
	[Address(RVA = "0xA1D23C", Offset = "0xA1D23C", VA = "0xA1D23C")]
	public void WriteBits(int b, int count)
	{
	}

	[Token(Token = "0x6017EE1")]
	[Address(RVA = "0xA233E4", Offset = "0xA233E4", VA = "0xA233E4")]
	public void WriteShortMSB(int s)
	{
	}

	[Token(Token = "0x6017EE3")]
	[Address(RVA = "0xA23498", Offset = "0xA23498", VA = "0xA23498")]
	public int Flush(byte[] output, int offset, int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017EE4")]
	[Address(RVA = "0xA23588", Offset = "0xA23588", VA = "0xA23588")]
	public byte[] ToByteArray()
	{
		return null;
	}
}
