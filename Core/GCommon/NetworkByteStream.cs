using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200405F")]
public class NetworkByteStream
{
	[Token(Token = "0x401B172")]
	[FieldOffset(Offset = "0x8")]
	private byte[] m_RawBytes;

	[Token(Token = "0x401B173")]
	[FieldOffset(Offset = "0xC")]
	private int m_Length;

	[Token(Token = "0x601A348")]
	[Address(RVA = "0x296D1E4", Offset = "0x296D1E4", VA = "0x296D1E4")]
	public NetworkByteStream(int cap)
	{
	}

	[Token(Token = "0x601A349")]
	[Address(RVA = "0x296D25C", Offset = "0x296D25C", VA = "0x296D25C")]
	public void SetValidCount(int n)
	{
	}

	[Token(Token = "0x601A34A")]
	[Address(RVA = "0x296D2AC", Offset = "0x296D2AC", VA = "0x296D2AC")]
	public byte[] GetBytes()
	{
		return null;
	}

	[Token(Token = "0x601A34B")]
	[Address(RVA = "0x296D2B4", Offset = "0x296D2B4", VA = "0x296D2B4")]
	public int GetAvailableLength()
	{
		return default(int);
	}

	[Token(Token = "0x601A34C")]
	[Address(RVA = "0x296D2BC", Offset = "0x296D2BC", VA = "0x296D2BC")]
	public byte[] CopyBytes()
	{
		return null;
	}

	[Token(Token = "0x601A34D")]
	[Address(RVA = "0x296D350", Offset = "0x296D350", VA = "0x296D350")]
	public byte[] CopyBytes(byte[] b)
	{
		return null;
	}
}
