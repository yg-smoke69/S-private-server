using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

[Token(Token = "0x2003BFD")]
public class InflaterInputStream : Stream
{
	[Token(Token = "0x4019951")]
	[FieldOffset(Offset = "0x8")]
	protected Inflater inf;

	[Token(Token = "0x4019952")]
	[FieldOffset(Offset = "0xC")]
	protected InflaterInputBuffer inputBuffer;

	[Token(Token = "0x4019953")]
	[FieldOffset(Offset = "0x10")]
	private Stream baseInputStream;

	[Token(Token = "0x4019954")]
	[FieldOffset(Offset = "0x18")]
	protected long csize;

	[Token(Token = "0x4019955")]
	[FieldOffset(Offset = "0x20")]
	private bool isClosed;

	[Token(Token = "0x4019956")]
	[FieldOffset(Offset = "0x21")]
	private bool isStreamOwner;

	[Token(Token = "0x1700192F")]
	public bool IsStreamOwner
	{
		[Token(Token = "0x6017F1A")]
		[Address(RVA = "0xA25A50", Offset = "0xA25A50", VA = "0xA25A50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017F1B")]
		[Address(RVA = "0xA25A58", Offset = "0xA25A58", VA = "0xA25A58")]
		set
		{
		}
	}

	[Token(Token = "0x17001930")]
	public virtual int Available
	{
		[Token(Token = "0x6017F1E")]
		[Address(RVA = "0xA25CB8", Offset = "0xA25CB8", VA = "0xA25CB8", Slot = "27")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001931")]
	public override bool CanRead
	{
		[Token(Token = "0x6017F20")]
		[Address(RVA = "0xA25E28", Offset = "0xA25E28", VA = "0xA25E28", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001932")]
	public override bool CanSeek
	{
		[Token(Token = "0x6017F21")]
		[Address(RVA = "0xA25E5C", Offset = "0xA25E5C", VA = "0xA25E5C", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001933")]
	public override bool CanWrite
	{
		[Token(Token = "0x6017F22")]
		[Address(RVA = "0xA25E64", Offset = "0xA25E64", VA = "0xA25E64", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001934")]
	public override long Length
	{
		[Token(Token = "0x6017F23")]
		[Address(RVA = "0xA25E6C", Offset = "0xA25E6C", VA = "0xA25E6C", Slot = "9")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001935")]
	public override long Position
	{
		[Token(Token = "0x6017F24")]
		[Address(RVA = "0xA25E94", Offset = "0xA25E94", VA = "0xA25E94", Slot = "10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017F25")]
		[Address(RVA = "0xA25EC8", Offset = "0xA25EC8", VA = "0xA25EC8", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x6017F16")]
	[Address(RVA = "0xA25708", Offset = "0xA25708", VA = "0xA25708")]
	public InflaterInputStream(Stream baseInputStream)
	{
	}

	[Token(Token = "0x6017F17")]
	[Address(RVA = "0xA258A0", Offset = "0xA258A0", VA = "0xA258A0")]
	public InflaterInputStream(Stream baseInputStream, Inflater inf)
	{
	}

	[Token(Token = "0x6017F18")]
	[Address(RVA = "0xA25794", Offset = "0xA25794", VA = "0xA25794")]
	public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize)
	{
	}

	[Token(Token = "0x6017F19")]
	[Address(RVA = "0xA258BC", Offset = "0xA258BC", VA = "0xA258BC")]
	public void Reset(Stream baseInputStream, int bufferSize)
	{
	}

	[Token(Token = "0x6017F1C")]
	[Address(RVA = "0xA25A60", Offset = "0xA25A60", VA = "0xA25A60")]
	public long Skip(long count)
	{
		return default(long);
	}

	[Token(Token = "0x6017F1D")]
	[Address(RVA = "0xA25C44", Offset = "0xA25C44", VA = "0xA25C44")]
	protected void StopDecrypting()
	{
	}

	[Token(Token = "0x6017F1F")]
	[Address(RVA = "0xA25D08", Offset = "0xA25D08", VA = "0xA25D08")]
	protected void Fill()
	{
	}

	[Token(Token = "0x6017F26")]
	[Address(RVA = "0xA25F64", Offset = "0xA25F64", VA = "0xA25F64", Slot = "16")]
	public override void Flush()
	{
	}

	[Token(Token = "0x6017F27")]
	[Address(RVA = "0xA25F98", Offset = "0xA25F98", VA = "0xA25F98", Slot = "19")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6017F28")]
	[Address(RVA = "0xA26034", Offset = "0xA26034", VA = "0xA26034", Slot = "20")]
	public override void SetLength(long value)
	{
	}

	[Token(Token = "0x6017F29")]
	[Address(RVA = "0xA260D0", Offset = "0xA260D0", VA = "0xA260D0", Slot = "21")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6017F2A")]
	[Address(RVA = "0xA2616C", Offset = "0xA2616C", VA = "0xA2616C", Slot = "22")]
	public override void WriteByte(byte value)
	{
	}

	[Token(Token = "0x6017F2B")]
	[Address(RVA = "0xA26208", Offset = "0xA26208", VA = "0xA26208", Slot = "24")]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	[Token(Token = "0x6017F2C")]
	[Address(RVA = "0xA262A4", Offset = "0xA262A4", VA = "0xA262A4", Slot = "13")]
	public override void Close()
	{
	}

	[Token(Token = "0x6017F2D")]
	[Address(RVA = "0xA262FC", Offset = "0xA262FC", VA = "0xA262FC", Slot = "17")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6017F2E")]
	[Address(RVA = "0xA26500", Offset = "0xA26500", VA = "0xA26500", Slot = "28")]
	public virtual int OptimizeRead(byte[] buffer, int offset, int count)
	{
		return default(int);
	}
}
