using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.GZip;

[Token(Token = "0x2003BED")]
public class GZipOutputStream : DeflaterOutputStream
{
	[Token(Token = "0x2003BEE")]
	private enum OutputState
	{
		[Token(Token = "0x4019893")]
		Header,
		[Token(Token = "0x4019894")]
		Footer,
		[Token(Token = "0x4019895")]
		Finished,
		[Token(Token = "0x4019896")]
		Closed
	}

	[Token(Token = "0x4019890")]
	[FieldOffset(Offset = "0x24")]
	protected Crc32 crc;

	[Token(Token = "0x4019891")]
	[FieldOffset(Offset = "0x28")]
	private OutputState state_;

	[Token(Token = "0x6017E67")]
	[Address(RVA = "0x351D4CC", Offset = "0x351D4CC", VA = "0x351D4CC")]
	public GZipOutputStream(Stream baseOutputStream)
	{
	}

	[Token(Token = "0x6017E68")]
	[Address(RVA = "0x351D4D4", Offset = "0x351D4D4", VA = "0x351D4D4")]
	public GZipOutputStream(Stream baseOutputStream, int size)
	{
	}

	[Token(Token = "0x6017E69")]
	[Address(RVA = "0x351D6D8", Offset = "0x351D6D8", VA = "0x351D6D8")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x6017E6A")]
	[Address(RVA = "0x351D894", Offset = "0x351D894", VA = "0x351D894")]
	public int GetLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6017E6B")]
	[Address(RVA = "0x351D8C0", Offset = "0x351D8C0", VA = "0x351D8C0", Slot = "21")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6017E6C")]
	[Address(RVA = "0x351DAC4", Offset = "0x351DAC4", VA = "0x351DAC4", Slot = "13")]
	public override void Close()
	{
	}

	[Token(Token = "0x6017E6D")]
	[Address(RVA = "0x351DB90", Offset = "0x351DB90", VA = "0x351DB90", Slot = "27")]
	public override void Finish()
	{
	}

	[Token(Token = "0x6017E6E")]
	[Address(RVA = "0x351D9DC", Offset = "0x351D9DC", VA = "0x351D9DC")]
	private void WriteHeader()
	{
	}
}
