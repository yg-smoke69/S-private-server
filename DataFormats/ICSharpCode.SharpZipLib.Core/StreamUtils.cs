using System.IO;
using ICSharpCode.SharpZipLib.GZip;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core;

[Token(Token = "0x2003BE2")]
public sealed class StreamUtils
{
	[Token(Token = "0x6017E27")]
	[Address(RVA = "0x3519120", Offset = "0x3519120", VA = "0x3519120")]
	private StreamUtils()
	{
	}

	[Token(Token = "0x6017E28")]
	[Address(RVA = "0x3519128", Offset = "0x3519128", VA = "0x3519128")]
	public static void ReadFully(Stream stream, byte[] buffer)
	{
	}

	[Token(Token = "0x6017E29")]
	[Address(RVA = "0x3519168", Offset = "0x3519168", VA = "0x3519168")]
	public static void ReadFully(Stream stream, byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6017E2A")]
	[Address(RVA = "0x3519394", Offset = "0x3519394", VA = "0x3519394")]
	public static void Copy(Stream source, Stream destination, byte[] buffer)
	{
	}

	[Token(Token = "0x6017E2B")]
	[Address(RVA = "0x35195D8", Offset = "0x35195D8", VA = "0x35195D8")]
	public static void CopyFromGzipInputStream(GZipInputStream source, Stream destination, byte[] buffer, bool enable_optimize = false)
	{
	}
}
