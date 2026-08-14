using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF8")]
internal class InflaterDynHeader
{
	[Token(Token = "0x4019922")]
	private const int LNUM = 0;

	[Token(Token = "0x4019923")]
	private const int DNUM = 1;

	[Token(Token = "0x4019924")]
	private const int BLNUM = 2;

	[Token(Token = "0x4019925")]
	private const int BLLENS = 3;

	[Token(Token = "0x4019926")]
	private const int LENS = 4;

	[Token(Token = "0x4019927")]
	private const int REPS = 5;

	[Token(Token = "0x4019928")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] repMin;

	[Token(Token = "0x4019929")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int[] repBits;

	[Token(Token = "0x401992A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int[] BL_ORDER;

	[Token(Token = "0x401992B")]
	[FieldOffset(Offset = "0x8")]
	private byte[] blLens;

	[Token(Token = "0x401992C")]
	[FieldOffset(Offset = "0xC")]
	private byte[] litdistLens;

	[Token(Token = "0x401992D")]
	[FieldOffset(Offset = "0x10")]
	private InflaterHuffmanTree blTree;

	[Token(Token = "0x401992E")]
	[FieldOffset(Offset = "0x14")]
	private int mode;

	[Token(Token = "0x401992F")]
	[FieldOffset(Offset = "0x18")]
	private int lnum;

	[Token(Token = "0x4019930")]
	[FieldOffset(Offset = "0x1C")]
	private int dnum;

	[Token(Token = "0x4019931")]
	[FieldOffset(Offset = "0x20")]
	private int blnum;

	[Token(Token = "0x4019932")]
	[FieldOffset(Offset = "0x24")]
	private int num;

	[Token(Token = "0x4019933")]
	[FieldOffset(Offset = "0x28")]
	private int repSymbol;

	[Token(Token = "0x4019934")]
	[FieldOffset(Offset = "0x2C")]
	private byte lastLen;

	[Token(Token = "0x4019935")]
	[FieldOffset(Offset = "0x30")]
	private int ptr;

	[Token(Token = "0x6017ECC")]
	[Address(RVA = "0xA20A40", Offset = "0xA20A40", VA = "0xA20A40")]
	public InflaterDynHeader()
	{
	}

	[Token(Token = "0x6017ECD")]
	[Address(RVA = "0xA20B68", Offset = "0xA20B68", VA = "0xA20B68")]
	public bool Decode(StreamManipulator input, bool enable_optimize = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6017ECE")]
	[Address(RVA = "0xA21264", Offset = "0xA21264", VA = "0xA21264")]
	public InflaterHuffmanTree BuildLitLenTree(bool enable_optimize = false)
	{
		return null;
	}

	[Token(Token = "0x6017ECF")]
	[Address(RVA = "0xA21338", Offset = "0xA21338", VA = "0xA21338")]
	public InflaterHuffmanTree BuildDistTree(bool enable_optimize = false)
	{
		return null;
	}

	[Token(Token = "0x6017ED0")]
	[Address(RVA = "0xA22344", Offset = "0xA22344", VA = "0xA22344")]
	public byte[] GetLenTreeLens()
	{
		return null;
	}

	[Token(Token = "0x6017ED1")]
	[Address(RVA = "0xA223D8", Offset = "0xA223D8", VA = "0xA223D8")]
	public byte[] GetDistTreeLens()
	{
		return null;
	}
}
