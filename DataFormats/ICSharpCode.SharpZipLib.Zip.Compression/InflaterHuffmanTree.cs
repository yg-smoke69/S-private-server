using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF9")]
public class InflaterHuffmanTree
{
	[Token(Token = "0x4019936")]
	private const int MAX_BITLEN = 15;

	[Token(Token = "0x4019937")]
	[FieldOffset(Offset = "0x8")]
	private short[] tree;

	[Token(Token = "0x4019938")]
	[FieldOffset(Offset = "0x0")]
	public static InflaterHuffmanTree defLitLenTree;

	[Token(Token = "0x4019939")]
	[FieldOffset(Offset = "0x4")]
	public static InflaterHuffmanTree defDistTree;

	[Token(Token = "0x401993A")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, short[]> m_HuffmanTreeCache;

	[Token(Token = "0x6017ED3")]
	[Address(RVA = "0xA22574", Offset = "0xA22574", VA = "0xA22574")]
	static InflaterHuffmanTree()
	{
	}

	[Token(Token = "0x6017ED4")]
	[Address(RVA = "0xA22308", Offset = "0xA22308", VA = "0xA22308")]
	public InflaterHuffmanTree(byte[] codeLengths, int index = -1)
	{
	}

	[Token(Token = "0x6017ED5")]
	[Address(RVA = "0xA22944", Offset = "0xA22944", VA = "0xA22944")]
	public void BuildTree(byte[] codeLengths, int index, bool use_same_mem = false)
	{
	}

	[Token(Token = "0x6017ED6")]
	[Address(RVA = "0xA1FC44", Offset = "0xA1FC44", VA = "0xA1FC44")]
	public int GetSymbol(StreamManipulator input)
	{
		return default(int);
	}
}
