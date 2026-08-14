using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

[Token(Token = "0x2003BFF")]
public class StreamManipulator
{
	[Token(Token = "0x401995C")]
	[FieldOffset(Offset = "0x8")]
	private byte[] window_;

	[Token(Token = "0x401995D")]
	[FieldOffset(Offset = "0xC")]
	private int windowStart_;

	[Token(Token = "0x401995E")]
	[FieldOffset(Offset = "0x10")]
	private int windowEnd_;

	[Token(Token = "0x401995F")]
	[FieldOffset(Offset = "0x14")]
	private uint buffer_;

	[Token(Token = "0x4019960")]
	[FieldOffset(Offset = "0x18")]
	private int bitsInBuffer_;

	[Token(Token = "0x17001936")]
	public int AvailableBits
	{
		[Token(Token = "0x6017F3D")]
		[Address(RVA = "0xA23074", Offset = "0xA23074", VA = "0xA23074")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001937")]
	public int AvailableBytes
	{
		[Token(Token = "0x6017F3E")]
		[Address(RVA = "0xA221B0", Offset = "0xA221B0", VA = "0xA221B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001938")]
	public bool IsNeedingInput
	{
		[Token(Token = "0x6017F40")]
		[Address(RVA = "0xA20B50", Offset = "0xA20B50", VA = "0xA20B50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017F39")]
	[Address(RVA = "0xA1EFE8", Offset = "0xA1EFE8", VA = "0xA1EFE8")]
	public StreamManipulator()
	{
	}

	[Token(Token = "0x6017F3A")]
	[Address(RVA = "0xA1F2E4", Offset = "0xA1F2E4", VA = "0xA1F2E4")]
	public int PeekBits(int bitCount)
	{
		return default(int);
	}

	[Token(Token = "0x6017F3B")]
	[Address(RVA = "0xA1F3E0", Offset = "0xA1F3E0", VA = "0xA1F3E0")]
	public void DropBits(int bitCount)
	{
	}

	[Token(Token = "0x6017F3C")]
	[Address(RVA = "0xA269F8", Offset = "0xA269F8", VA = "0xA269F8")]
	public int GetBits(int bitCount)
	{
		return default(int);
	}

	[Token(Token = "0x6017F3F")]
	[Address(RVA = "0xA20A20", Offset = "0xA20A20", VA = "0xA20A20")]
	public void SkipToByteBoundary()
	{
	}

	[Token(Token = "0x6017F41")]
	[Address(RVA = "0xA267B0", Offset = "0xA267B0", VA = "0xA267B0")]
	public int CopyBytes(byte[] output, int offset, int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017F42")]
	[Address(RVA = "0xA1F114", Offset = "0xA1F114", VA = "0xA1F114")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017F43")]
	[Address(RVA = "0xA218E4", Offset = "0xA218E4", VA = "0xA218E4")]
	public void SetInput(byte[] buffer, int offset, int count)
	{
	}
}
