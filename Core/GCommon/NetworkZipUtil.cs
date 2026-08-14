using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200407E")]
internal static class NetworkZipUtil
{
	[Token(Token = "0x601A3B4")]
	[Address(RVA = "0x297AB5C", Offset = "0x297AB5C", VA = "0x297AB5C")]
	public static void ZipXORHeader(byte[] data, int dataLen, byte[] secretKey)
	{
	}

	[Token(Token = "0x601A3B5")]
	[Address(RVA = "0x297AC10", Offset = "0x297AC10", VA = "0x297AC10")]
	public static long Unzip(GZipInputStream gzipStream, byte[] data, int dataLen, byte[] secretKey, byte[] outputData, byte[] tmpBuffer)
	{
		return default(long);
	}
}
