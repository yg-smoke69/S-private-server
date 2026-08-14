using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

[Token(Token = "0x2003BFE")]
public class OutputWindow
{
	[Token(Token = "0x4019957")]
	private const int WindowSize = 32768;

	[Token(Token = "0x4019958")]
	private const int WindowMask = 32767;

	[Token(Token = "0x4019959")]
	[FieldOffset(Offset = "0x8")]
	private byte[] window;

	[Token(Token = "0x401995A")]
	[FieldOffset(Offset = "0xC")]
	private int windowEnd;

	[Token(Token = "0x401995B")]
	[FieldOffset(Offset = "0x10")]
	private int windowFilled;

	[Token(Token = "0x6017F2F")]
	[Address(RVA = "0xA1EFF0", Offset = "0xA1EFF0", VA = "0xA1EFF0")]
	public OutputWindow()
	{
	}

	[Token(Token = "0x6017F30")]
	[Address(RVA = "0xA1FB38", Offset = "0xA1FB38", VA = "0xA1FB38")]
	public void Write(int value)
	{
	}

	[Token(Token = "0x6017F31")]
	[Address(RVA = "0xA26704", Offset = "0xA26704", VA = "0xA26704")]
	private void SlowRepeat(int repStart, int length, int distance)
	{
	}

	[Token(Token = "0x6017F32")]
	[Address(RVA = "0xA1FEFC", Offset = "0xA1FEFC", VA = "0xA1FEFC")]
	public void Repeat(int length, int distance)
	{
	}

	[Token(Token = "0x6017F33")]
	[Address(RVA = "0xA20A48", Offset = "0xA20A48", VA = "0xA20A48")]
	public int CopyStored(StreamManipulator input, int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017F34")]
	[Address(RVA = "0xA21714", Offset = "0xA21714", VA = "0xA21714")]
	public void CopyDict(byte[] dictionary, int offset, int length)
	{
	}

	[Token(Token = "0x6017F35")]
	[Address(RVA = "0xA1FB2C", Offset = "0xA1FB2C", VA = "0xA1FB2C")]
	public int GetFreeSpace()
	{
		return default(int);
	}

	[Token(Token = "0x6017F36")]
	[Address(RVA = "0xA220B4", Offset = "0xA220B4", VA = "0xA220B4")]
	public int GetAvailable()
	{
		return default(int);
	}

	[Token(Token = "0x6017F37")]
	[Address(RVA = "0xA21F80", Offset = "0xA21F80", VA = "0xA21F80")]
	public int CopyOutput(byte[] output, int offset, int len)
	{
		return default(int);
	}

	[Token(Token = "0x6017F38")]
	[Address(RVA = "0xA1F124", Offset = "0xA1F124", VA = "0xA1F124")]
	public void Reset()
	{
	}
}
