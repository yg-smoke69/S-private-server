using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004096")]
internal static class UDPChecksum
{
	[Token(Token = "0x401B23C")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] crc7tab;

	[Token(Token = "0x601A492")]
	[Address(RVA = "0x3242D88", Offset = "0x3242D88", VA = "0x3242D88")]
	public static byte CRC7(byte crcIn, byte v)
	{
		return default(byte);
	}

	[Token(Token = "0x601A493")]
	[Address(RVA = "0x3242E54", Offset = "0x3242E54", VA = "0x3242E54")]
	public static byte CRC7(byte crcIn, ushort v)
	{
		return default(byte);
	}

	[Token(Token = "0x601A494")]
	[Address(RVA = "0x3242EE4", Offset = "0x3242EE4", VA = "0x3242EE4")]
	public static byte CRC7(byte crcIn, byte[] buf)
	{
		return default(byte);
	}

	[Token(Token = "0x601A495")]
	[Address(RVA = "0x3242F8C", Offset = "0x3242F8C", VA = "0x3242F8C")]
	public static byte CRC7(byte crcIn, byte[] buf, int Count, int offset = 0)
	{
		return default(byte);
	}
}
