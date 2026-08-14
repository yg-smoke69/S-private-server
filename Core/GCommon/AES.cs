using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003F18")]
public static class AES
{
	[Token(Token = "0x2003F19")]
	public class AESOption
	{
		[Token(Token = "0x401A9ED")]
		[FieldOffset(Offset = "0x8")]
		public string Password;

		[Token(Token = "0x401A9EE")]
		[FieldOffset(Offset = "0xC")]
		public string Salt;

		[Token(Token = "0x6019B0B")]
		[Address(RVA = "0x26B1F1C", Offset = "0x26B1F1C", VA = "0x26B1F1C")]
		public AESOption()
		{
		}
	}

	[Token(Token = "0x6019B07")]
	[Address(RVA = "0x26B09E8", Offset = "0x26B09E8", VA = "0x26B09E8")]
	public static string EncryptText(string decoded, AESOption option)
	{
		return null;
	}

	[Token(Token = "0x6019B08")]
	[Address(RVA = "0x26B1494", Offset = "0x26B1494", VA = "0x26B1494")]
	public static string DecryptText(string encoded, AESOption option)
	{
		return null;
	}

	[Token(Token = "0x6019B09")]
	[Address(RVA = "0x26B0AF8", Offset = "0x26B0AF8", VA = "0x26B0AF8")]
	public static byte[] Encrypt(string plainText, AESOption option)
	{
		return null;
	}

	[Token(Token = "0x6019B0A")]
	[Address(RVA = "0x26B15DC", Offset = "0x26B15DC", VA = "0x26B15DC")]
	public static string Decrypt(byte[] cipherText, AESOption option)
	{
		return null;
	}
}
