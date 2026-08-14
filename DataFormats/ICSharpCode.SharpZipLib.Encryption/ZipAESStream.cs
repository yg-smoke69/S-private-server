using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE8")]
internal class ZipAESStream : CryptoStream
{
	[Token(Token = "0x4019874")]
	private const int AUTH_CODE_LENGTH = 10;

	[Token(Token = "0x4019875")]
	[FieldOffset(Offset = "0x40")]
	private Stream _stream;

	[Token(Token = "0x4019876")]
	[FieldOffset(Offset = "0x44")]
	private ZipAESTransform _transform;

	[Token(Token = "0x4019877")]
	[FieldOffset(Offset = "0x48")]
	private byte[] _slideBuffer;

	[Token(Token = "0x4019878")]
	[FieldOffset(Offset = "0x4C")]
	private int _slideBufStartPos;

	[Token(Token = "0x4019879")]
	[FieldOffset(Offset = "0x50")]
	private int _slideBufFreePos;

	[Token(Token = "0x401987A")]
	private const int CRYPTO_BLOCK_SIZE = 16;

	[Token(Token = "0x401987B")]
	[FieldOffset(Offset = "0x54")]
	private int _blockAndAuth;

	[Token(Token = "0x6017E4E")]
	[Address(RVA = "0x351B1AC", Offset = "0x351B1AC", VA = "0x351B1AC")]
	public ZipAESStream(Stream stream, ZipAESTransform transform, CryptoStreamMode mode)
	{
	}

	[Token(Token = "0x6017E4F")]
	[Address(RVA = "0x351B2B0", Offset = "0x351B2B0", VA = "0x351B2B0", Slot = "17")]
	public override int Read(byte[] outBuffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6017E50")]
	[Address(RVA = "0x351BA60", Offset = "0x351BA60", VA = "0x351BA60", Slot = "21")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}
}
