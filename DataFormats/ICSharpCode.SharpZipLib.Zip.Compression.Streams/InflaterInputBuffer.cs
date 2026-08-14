using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

[Token(Token = "0x2003BFC")]
public class InflaterInputBuffer
{
	[Token(Token = "0x4019949")]
	[FieldOffset(Offset = "0x8")]
	private int rawLength;

	[Token(Token = "0x401994A")]
	[FieldOffset(Offset = "0xC")]
	private byte[] rawData;

	[Token(Token = "0x401994B")]
	[FieldOffset(Offset = "0x10")]
	private int clearTextLength;

	[Token(Token = "0x401994C")]
	[FieldOffset(Offset = "0x14")]
	private byte[] clearText;

	[Token(Token = "0x401994D")]
	[FieldOffset(Offset = "0x18")]
	private byte[] internalClearText;

	[Token(Token = "0x401994E")]
	[FieldOffset(Offset = "0x1C")]
	private int available;

	[Token(Token = "0x401994F")]
	[FieldOffset(Offset = "0x20")]
	private ICryptoTransform cryptoTransform;

	[Token(Token = "0x4019950")]
	[FieldOffset(Offset = "0x24")]
	private Stream inputStream;

	[Token(Token = "0x17001929")]
	public int RawLength
	{
		[Token(Token = "0x6017F06")]
		[Address(RVA = "0xA24EF0", Offset = "0xA24EF0", VA = "0xA24EF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700192A")]
	public byte[] RawData
	{
		[Token(Token = "0x6017F07")]
		[Address(RVA = "0xA24EF8", Offset = "0xA24EF8", VA = "0xA24EF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192B")]
	public int ClearTextLength
	{
		[Token(Token = "0x6017F08")]
		[Address(RVA = "0xA24F00", Offset = "0xA24F00", VA = "0xA24F00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700192C")]
	public byte[] ClearText
	{
		[Token(Token = "0x6017F09")]
		[Address(RVA = "0xA24F08", Offset = "0xA24F08", VA = "0xA24F08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700192D")]
	public int Available
	{
		[Token(Token = "0x6017F0A")]
		[Address(RVA = "0xA24F10", Offset = "0xA24F10", VA = "0xA24F10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017F0B")]
		[Address(RVA = "0xA24F18", Offset = "0xA24F18", VA = "0xA24F18")]
		set
		{
		}
	}

	[Token(Token = "0x1700192E")]
	public ICryptoTransform CryptoTransform
	{
		[Token(Token = "0x6017F15")]
		[Address(RVA = "0xA25584", Offset = "0xA25584", VA = "0xA25584")]
		set
		{
		}
	}

	[Token(Token = "0x6017F03")]
	[Address(RVA = "0xA24DFC", Offset = "0xA24DFC", VA = "0xA24DFC")]
	public InflaterInputBuffer(Stream stream)
	{
	}

	[Token(Token = "0x6017F04")]
	[Address(RVA = "0xA24E28", Offset = "0xA24E28", VA = "0xA24E28")]
	public InflaterInputBuffer(Stream stream, int bufferSize)
	{
	}

	[Token(Token = "0x6017F05")]
	[Address(RVA = "0xA24E58", Offset = "0xA24E58", VA = "0xA24E58")]
	public void Reset(Stream stream, int bufferSize)
	{
	}

	[Token(Token = "0x6017F0C")]
	[Address(RVA = "0xA24F20", Offset = "0xA24F20", VA = "0xA24F20")]
	public void SetInflaterInput(Inflater inflater)
	{
	}

	[Token(Token = "0x6017F0D")]
	[Address(RVA = "0xA24F7C", Offset = "0xA24F7C", VA = "0xA24F7C")]
	public void Fill()
	{
	}

	[Token(Token = "0x6017F0E")]
	[Address(RVA = "0xA25114", Offset = "0xA25114", VA = "0xA25114")]
	public int ReadRawBuffer(byte[] buffer)
	{
		return default(int);
	}

	[Token(Token = "0x6017F0F")]
	[Address(RVA = "0xA25154", Offset = "0xA25154", VA = "0xA25154")]
	public int ReadRawBuffer(byte[] outBuffer, int offset, int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017F10")]
	[Address(RVA = "0xA25298", Offset = "0xA25298", VA = "0xA25298")]
	public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017F11")]
	[Address(RVA = "0xA253DC", Offset = "0xA253DC", VA = "0xA253DC")]
	public int ReadLeByte()
	{
		return default(int);
	}

	[Token(Token = "0x6017F12")]
	[Address(RVA = "0xA254F4", Offset = "0xA254F4", VA = "0xA254F4")]
	public int ReadLeShort()
	{
		return default(int);
	}

	[Token(Token = "0x6017F13")]
	[Address(RVA = "0xA25518", Offset = "0xA25518", VA = "0xA25518")]
	public int ReadLeInt()
	{
		return default(int);
	}

	[Token(Token = "0x6017F14")]
	[Address(RVA = "0xA2555C", Offset = "0xA2555C", VA = "0xA2555C")]
	public long ReadLeLong()
	{
		return default(long);
	}
}
