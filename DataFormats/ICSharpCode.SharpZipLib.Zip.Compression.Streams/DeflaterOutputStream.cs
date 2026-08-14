using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams;

[Token(Token = "0x2003BFB")]
public class DeflaterOutputStream : Stream
{
	[Token(Token = "0x4019940")]
	[FieldOffset(Offset = "0x8")]
	private string password;

	[Token(Token = "0x4019941")]
	[FieldOffset(Offset = "0xC")]
	private ICryptoTransform cryptoTransform_;

	[Token(Token = "0x4019942")]
	[FieldOffset(Offset = "0x10")]
	protected byte[] AESAuthCode;

	[Token(Token = "0x4019943")]
	[FieldOffset(Offset = "0x14")]
	private byte[] buffer_;

	[Token(Token = "0x4019944")]
	[FieldOffset(Offset = "0x18")]
	protected Deflater deflater_;

	[Token(Token = "0x4019945")]
	[FieldOffset(Offset = "0x1C")]
	protected Stream baseOutputStream_;

	[Token(Token = "0x4019946")]
	[FieldOffset(Offset = "0x20")]
	private bool isClosed_;

	[Token(Token = "0x4019947")]
	[FieldOffset(Offset = "0x21")]
	private bool isStreamOwner_;

	[Token(Token = "0x4019948")]
	[FieldOffset(Offset = "0x0")]
	private static RNGCryptoServiceProvider _aesRnd;

	[Token(Token = "0x17001921")]
	public bool IsStreamOwner
	{
		[Token(Token = "0x6017EE9")]
		[Address(RVA = "0xA23D24", Offset = "0xA23D24", VA = "0xA23D24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017EEA")]
		[Address(RVA = "0xA23D2C", Offset = "0xA23D2C", VA = "0xA23D2C")]
		set
		{
		}
	}

	[Token(Token = "0x17001922")]
	public bool CanPatchEntries
	{
		[Token(Token = "0x6017EEB")]
		[Address(RVA = "0xA23D34", Offset = "0xA23D34", VA = "0xA23D34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001923")]
	public string Password
	{
		[Token(Token = "0x6017EEC")]
		[Address(RVA = "0xA23D68", Offset = "0xA23D68", VA = "0xA23D68")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017EED")]
		[Address(RVA = "0xA23D70", Offset = "0xA23D70", VA = "0xA23D70")]
		set
		{
		}
	}

	[Token(Token = "0x17001924")]
	public override bool CanRead
	{
		[Token(Token = "0x6017EF2")]
		[Address(RVA = "0xA2453C", Offset = "0xA2453C", VA = "0xA2453C", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001925")]
	public override bool CanSeek
	{
		[Token(Token = "0x6017EF3")]
		[Address(RVA = "0xA24544", Offset = "0xA24544", VA = "0xA24544", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001926")]
	public override bool CanWrite
	{
		[Token(Token = "0x6017EF4")]
		[Address(RVA = "0xA2454C", Offset = "0xA2454C", VA = "0xA2454C", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001927")]
	public override long Length
	{
		[Token(Token = "0x6017EF5")]
		[Address(RVA = "0xA24580", Offset = "0xA24580", VA = "0xA24580", Slot = "9")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001928")]
	public override long Position
	{
		[Token(Token = "0x6017EF6")]
		[Address(RVA = "0xA245B4", Offset = "0xA245B4", VA = "0xA245B4", Slot = "10")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017EF7")]
		[Address(RVA = "0xA245E8", Offset = "0xA245E8", VA = "0xA245E8", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x6017EE5")]
	[Address(RVA = "0xA23644", Offset = "0xA23644", VA = "0xA23644")]
	public DeflaterOutputStream(Stream baseOutputStream)
	{
	}

	[Token(Token = "0x6017EE6")]
	[Address(RVA = "0xA23920", Offset = "0xA23920", VA = "0xA23920")]
	public DeflaterOutputStream(Stream baseOutputStream, Deflater deflater)
	{
	}

	[Token(Token = "0x6017EE7")]
	[Address(RVA = "0xA236D0", Offset = "0xA236D0", VA = "0xA236D0")]
	public DeflaterOutputStream(Stream baseOutputStream, Deflater deflater, int bufferSize)
	{
	}

	[Token(Token = "0x6017EE8")]
	[Address(RVA = "0xA2393C", Offset = "0xA2393C", VA = "0xA2393C", Slot = "27")]
	public virtual void Finish()
	{
	}

	[Token(Token = "0x6017EEE")]
	[Address(RVA = "0xA23C20", Offset = "0xA23C20", VA = "0xA23C20")]
	protected void EncryptBlock(byte[] buffer, int offset, int length)
	{
	}

	[Token(Token = "0x6017EEF")]
	[Address(RVA = "0xA23DAC", Offset = "0xA23DAC", VA = "0xA23DAC")]
	protected void InitializePassword(string password)
	{
	}

	[Token(Token = "0x6017EF0")]
	[Address(RVA = "0xA23F94", Offset = "0xA23F94", VA = "0xA23F94")]
	protected void InitializeAESPassword(ZipEntry entry, string rawPassword, out byte[] salt, out byte[] pwdVerifier)
	{
	}

	[Token(Token = "0x6017EF1")]
	[Address(RVA = "0xA24398", Offset = "0xA24398", VA = "0xA24398")]
	protected void Deflate()
	{
	}

	[Token(Token = "0x6017EF8")]
	[Address(RVA = "0xA24684", Offset = "0xA24684", VA = "0xA24684", Slot = "19")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return default(long);
	}

	[Token(Token = "0x6017EF9")]
	[Address(RVA = "0xA24720", Offset = "0xA24720", VA = "0xA24720", Slot = "20")]
	public override void SetLength(long value)
	{
	}

	[Token(Token = "0x6017EFA")]
	[Address(RVA = "0xA247BC", Offset = "0xA247BC", VA = "0xA247BC", Slot = "18")]
	public override int ReadByte()
	{
		return default(int);
	}

	[Token(Token = "0x6017EFB")]
	[Address(RVA = "0xA24858", Offset = "0xA24858", VA = "0xA24858", Slot = "17")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return default(int);
	}

	[Token(Token = "0x6017EFC")]
	[Address(RVA = "0xA248F4", Offset = "0xA248F4", VA = "0xA248F4", Slot = "23")]
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	[Token(Token = "0x6017EFD")]
	[Address(RVA = "0xA24990", Offset = "0xA24990", VA = "0xA24990", Slot = "24")]
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		return null;
	}

	[Token(Token = "0x6017EFE")]
	[Address(RVA = "0xA24A2C", Offset = "0xA24A2C", VA = "0xA24A2C", Slot = "16")]
	public override void Flush()
	{
	}

	[Token(Token = "0x6017EFF")]
	[Address(RVA = "0xA24A8C", Offset = "0xA24A8C", VA = "0xA24A8C", Slot = "13")]
	public override void Close()
	{
	}

	[Token(Token = "0x6017F00")]
	[Address(RVA = "0xA24C3C", Offset = "0xA24C3C", VA = "0xA24C3C")]
	private void GetAuthCodeIfAES()
	{
	}

	[Token(Token = "0x6017F01")]
	[Address(RVA = "0xA24CD8", Offset = "0xA24CD8", VA = "0xA24CD8", Slot = "22")]
	public override void WriteByte(byte value)
	{
	}

	[Token(Token = "0x6017F02")]
	[Address(RVA = "0xA24DA0", Offset = "0xA24DA0", VA = "0xA24DA0", Slot = "21")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}
}
