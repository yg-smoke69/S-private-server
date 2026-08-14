using System.Security.Cryptography;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Encryption;

[Token(Token = "0x2003BE7")]
public sealed class PkzipClassicManaged : PkzipClassic
{
	[Token(Token = "0x4019873")]
	[FieldOffset(Offset = "0x30")]
	private byte[] key_;

	[Token(Token = "0x17001907")]
	public override int BlockSize
	{
		[Token(Token = "0x6017E44")]
		[Address(RVA = "0x351AA34", Offset = "0x351AA34", VA = "0x351AA34", Slot = "6")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6017E45")]
		[Address(RVA = "0x351AA3C", Offset = "0x351AA3C", VA = "0x351AA3C", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17001908")]
	public override KeySizes[] LegalKeySizes
	{
		[Token(Token = "0x6017E46")]
		[Address(RVA = "0x351AAE4", Offset = "0x351AAE4", VA = "0x351AAE4", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001909")]
	public override KeySizes[] LegalBlockSizes
	{
		[Token(Token = "0x6017E48")]
		[Address(RVA = "0x351ABEC", Offset = "0x351ABEC", VA = "0x351ABEC", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700190A")]
	public override byte[] Key
	{
		[Token(Token = "0x6017E49")]
		[Address(RVA = "0x351ACF0", Offset = "0x351ACF0", VA = "0x351ACF0", Slot = "12")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017E4A")]
		[Address(RVA = "0x351AE18", Offset = "0x351AE18", VA = "0x351AE18", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x6017E43")]
	[Address(RVA = "0x351AA2C", Offset = "0x351AA2C", VA = "0x351AA2C")]
	public PkzipClassicManaged()
	{
	}

	[Token(Token = "0x6017E47")]
	[Address(RVA = "0x351ABE8", Offset = "0x351ABE8", VA = "0x351ABE8", Slot = "26")]
	public override void GenerateIV()
	{
	}

	[Token(Token = "0x6017E4B")]
	[Address(RVA = "0x351AFC0", Offset = "0x351AFC0", VA = "0x351AFC0", Slot = "27")]
	public override void GenerateKey()
	{
	}

	[Token(Token = "0x6017E4C")]
	[Address(RVA = "0x351B074", Offset = "0x351B074", VA = "0x351B074", Slot = "25")]
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return null;
	}

	[Token(Token = "0x6017E4D")]
	[Address(RVA = "0x351B110", Offset = "0x351B110", VA = "0x351B110", Slot = "23")]
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return null;
	}
}
