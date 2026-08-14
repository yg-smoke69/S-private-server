using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.GZip;

[Token(Token = "0x2003BEC")]
public class GZipInputStream : InflaterInputStream
{
	[Token(Token = "0x401988E")]
	[FieldOffset(Offset = "0x24")]
	protected Crc32 crc;

	[Token(Token = "0x401988F")]
	[FieldOffset(Offset = "0x28")]
	private bool readGZIPHeader;

	[Token(Token = "0x6017E60")]
	[Address(RVA = "0x351C248", Offset = "0x351C248", VA = "0x351C248")]
	public GZipInputStream(Stream baseInputStream)
	{
	}

	[Token(Token = "0x6017E61")]
	[Address(RVA = "0x351C250", Offset = "0x351C250", VA = "0x351C250")]
	public GZipInputStream(Stream baseInputStream, int size)
	{
	}

	[Token(Token = "0x6017E62")]
	[Address(RVA = "0x351C2EC", Offset = "0x351C2EC", VA = "0x351C2EC")]
	public void Reset(Stream baseInputStream)
	{
	}

	[Token(Token = "0x6017E63")]
	[Address(RVA = "0x351C2F8", Offset = "0x351C2F8", VA = "0x351C2F8", Slot = "17")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6017E64")]
	[Address(RVA = "0x351D3FC", Offset = "0x351D3FC", VA = "0x351D3FC", Slot = "28")]
	public override int OptimizeRead(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6017E65")]
	[Address(RVA = "0x351C3C8", Offset = "0x351C3C8", VA = "0x351C3C8")]
	private bool ReadHeader()
	{
		return default(bool);
	}

	[Token(Token = "0x6017E66")]
	[Address(RVA = "0x351CE34", Offset = "0x351CE34", VA = "0x351CE34")]
	private void ReadFooter()
	{
	}
}
