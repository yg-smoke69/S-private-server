using System.Security.Cryptography;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B2")]
public class ResDecryption
{
	[Token(Token = "0x401B2D5")]
	[FieldOffset(Offset = "0x0")]
	private static SHA1CryptoServiceProvider m_SHA1;

	[Token(Token = "0x601A53E")]
	[Address(RVA = "0x33331BC", Offset = "0x33331BC", VA = "0x33331BC")]
	public ResDecryption()
	{
	}

	[Token(Token = "0x601A53F")]
	[Address(RVA = "0x33331C4", Offset = "0x33331C4", VA = "0x33331C4")]
	public static string GetFileHash(string filePath)
	{
		return null;
	}

	[Token(Token = "0x601A540")]
	[Address(RVA = "0x3331490", Offset = "0x3331490", VA = "0x3331490")]
	public static void HashBlock(SHA1CryptoServiceProvider worker, byte[] data, int offset, int size)
	{
	}

	[Token(Token = "0x601A541")]
	[Address(RVA = "0x3331654", Offset = "0x3331654", VA = "0x3331654")]
	public static string HashFinalBlock(SHA1CryptoServiceProvider worker, byte[] data, int offset)
	{
		return null;
	}

	[Token(Token = "0x601A542")]
	[Address(RVA = "0x3333620", Offset = "0x3333620", VA = "0x3333620")]
	public static string ComputeHash(SHA1CryptoServiceProvider worker, byte[] data, int offset = 0)
	{
		return null;
	}

	[Token(Token = "0x601A543")]
	[Address(RVA = "0x3333878", Offset = "0x3333878", VA = "0x3333878")]
	public static void Decryption(byte[] fileBytes, out byte[] decryptionBytes)
	{
	}

	[Token(Token = "0x601A544")]
	[Address(RVA = "0x3333EBC", Offset = "0x3333EBC", VA = "0x3333EBC")]
	public static ICryptoTransform CreateDecryptor(out int blockSize)
	{
		return null;
	}

	[Token(Token = "0x601A545")]
	[Address(RVA = "0x3333FD4", Offset = "0x3333FD4", VA = "0x3333FD4")]
	public static int Decryption(ICryptoTransform decryptor, int blockSize, byte[] fileBytes, ref byte[] decryptionBytes)
	{
		return default(int);
	}
}
