using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004063")]
public static class NetworkCryptologyUtil
{
	[Token(Token = "0x401B17F")]
	[FieldOffset(Offset = "0x0")]
	public static byte[] TestKey;

	[Token(Token = "0x401B180")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int SALT_LEN;

	[Token(Token = "0x401B181")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int ZERO_LEN;

	[Token(Token = "0x401B182")]
	[FieldOffset(Offset = "0xC")]
	private static readonly uint DELTA;

	[Token(Token = "0x401B183")]
	[FieldOffset(Offset = "0x10")]
	private static readonly int ROUNDS;

	[Token(Token = "0x401B184")]
	[FieldOffset(Offset = "0x14")]
	private static readonly int LOG_ROUNDS;

	[Token(Token = "0x601A358")]
	[Address(RVA = "0x296D8F0", Offset = "0x296D8F0", VA = "0x296D8F0")]
	public static bool TeaDecrypt(TeaDecTempBuffer decTempBuffer, byte[] pInBuf, int nInBufLen, byte[] pKey, byte[] pOutBuf, ref int pOutBufLen)
	{
		return default(bool);
	}

	[Token(Token = "0x601A359")]
	[Address(RVA = "0x296E548", Offset = "0x296E548", VA = "0x296E548")]
	private static int rand()
	{
		return default(int);
	}

	[Token(Token = "0x601A35A")]
	[Address(RVA = "0x296E550", Offset = "0x296E550", VA = "0x296E550")]
	public static int TeaEncrypt_Len(int nInBufLen)
	{
		return default(int);
	}

	[Token(Token = "0x601A35B")]
	[Address(RVA = "0x296E608", Offset = "0x296E608", VA = "0x296E608")]
	public static void TeaEncrypt(TeaEncTempBuffer encTempBuffer, byte[] pInBuf, int nInBufLen, byte[] pKey, byte[] pOutBuf, ref int pOutBufLen)
	{
	}

	[Token(Token = "0x601A35C")]
	[Address(RVA = "0x296F448", Offset = "0x296F448", VA = "0x296F448")]
	private static string bytesToString(byte[] p)
	{
		return null;
	}

	[Token(Token = "0x601A35D")]
	[Address(RVA = "0x296F140", Offset = "0x296F140", VA = "0x296F140")]
	private static void TeaEncryptECB(TeaEncTempBuffer encTempBuffer, byte[] pInBuf, int inBufPos, byte[] pKey, byte[] pOutBuf, int outBufIndex)
	{
	}

	[Token(Token = "0x601A35E")]
	[Address(RVA = "0x296E1F4", Offset = "0x296E1F4", VA = "0x296E1F4")]
	private static void TeaDecryptECB(TeaDecTempBuffer decTempBuffer, byte[] pInBuf, int inBufIndex, byte[] pKey, byte[] pOutBuf, int outBufIndex)
	{
	}

	[Token(Token = "0x601A35F")]
	[Address(RVA = "0x296F5A4", Offset = "0x296F5A4", VA = "0x296F5A4")]
	private static void IntToBytes(int value, byte[] array, int offset)
	{
	}
}
