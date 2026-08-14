using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF4")]
public class DeflaterHuffman
{
	[Token(Token = "0x2003BF5")]
	private class Tree
	{
		[Token(Token = "0x40198F9")]
		[FieldOffset(Offset = "0x8")]
		public short[] freqs;

		[Token(Token = "0x40198FA")]
		[FieldOffset(Offset = "0xC")]
		public byte[] length;

		[Token(Token = "0x40198FB")]
		[FieldOffset(Offset = "0x10")]
		public int minNumCodes;

		[Token(Token = "0x40198FC")]
		[FieldOffset(Offset = "0x14")]
		public int numCodes;

		[Token(Token = "0x40198FD")]
		[FieldOffset(Offset = "0x18")]
		private short[] codes;

		[Token(Token = "0x40198FE")]
		[FieldOffset(Offset = "0x1C")]
		private int[] bl_counts;

		[Token(Token = "0x40198FF")]
		[FieldOffset(Offset = "0x20")]
		private int maxLength;

		[Token(Token = "0x4019900")]
		[FieldOffset(Offset = "0x24")]
		private DeflaterHuffman dh;

		[Token(Token = "0x6017EAA")]
		[Address(RVA = "0xA1D048", Offset = "0xA1D048", VA = "0xA1D048")]
		public Tree(DeflaterHuffman dh, int elems, int minCodes, int maxLength)
		{
		}

		[Token(Token = "0x6017EAB")]
		[Address(RVA = "0xA1D0F4", Offset = "0xA1D0F4", VA = "0xA1D0F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6017EAC")]
		[Address(RVA = "0xA1D180", Offset = "0xA1D180", VA = "0xA1D180")]
		public void WriteSymbol(int code)
		{
		}

		[Token(Token = "0x6017EAD")]
		[Address(RVA = "0xA1D314", Offset = "0xA1D314", VA = "0xA1D314")]
		public void CheckEmpty()
		{
		}

		[Token(Token = "0x6017EAE")]
		[Address(RVA = "0xA1D43C", Offset = "0xA1D43C", VA = "0xA1D43C")]
		public void SetStaticCodes(short[] staticCodes, byte[] staticLengths)
		{
		}

		[Token(Token = "0x6017EAF")]
		[Address(RVA = "0xA1D448", Offset = "0xA1D448", VA = "0xA1D448")]
		public void BuildCodes()
		{
		}

		[Token(Token = "0x6017EB0")]
		[Address(RVA = "0xA1D704", Offset = "0xA1D704", VA = "0xA1D704")]
		public void BuildTree()
		{
		}

		[Token(Token = "0x6017EB1")]
		[Address(RVA = "0xA1E8D4", Offset = "0xA1E8D4", VA = "0xA1E8D4")]
		public int GetEncodedLength()
		{
			return default(int);
		}

		[Token(Token = "0x6017EB2")]
		[Address(RVA = "0xA1E99C", Offset = "0xA1E99C", VA = "0xA1E99C")]
		public void CalcBLFreq(Tree blTree)
		{
		}

		[Token(Token = "0x6017EB3")]
		[Address(RVA = "0xA1EC1C", Offset = "0xA1EC1C", VA = "0xA1EC1C")]
		public void WriteTree(Tree blTree)
		{
		}

		[Token(Token = "0x6017EB4")]
		[Address(RVA = "0xA1E214", Offset = "0xA1E214", VA = "0xA1E214")]
		private void BuildLength(int[] childs)
		{
		}
	}

	[Token(Token = "0x40198E3")]
	private const int BUFSIZE = 16384;

	[Token(Token = "0x40198E4")]
	private const int LITERAL_NUM = 286;

	[Token(Token = "0x40198E5")]
	private const int DIST_NUM = 30;

	[Token(Token = "0x40198E6")]
	private const int BITLEN_NUM = 19;

	[Token(Token = "0x40198E7")]
	private const int REP_3_6 = 16;

	[Token(Token = "0x40198E8")]
	private const int REP_3_10 = 17;

	[Token(Token = "0x40198E9")]
	private const int REP_11_138 = 18;

	[Token(Token = "0x40198EA")]
	private const int EOF_SYMBOL = 256;

	[Token(Token = "0x40198EB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] BL_ORDER;

	[Token(Token = "0x40198EC")]
	[FieldOffset(Offset = "0x4")]
	private static readonly byte[] bit4Reverse;

	[Token(Token = "0x40198ED")]
	[FieldOffset(Offset = "0x8")]
	private static short[] staticLCodes;

	[Token(Token = "0x40198EE")]
	[FieldOffset(Offset = "0xC")]
	private static byte[] staticLLength;

	[Token(Token = "0x40198EF")]
	[FieldOffset(Offset = "0x10")]
	private static short[] staticDCodes;

	[Token(Token = "0x40198F0")]
	[FieldOffset(Offset = "0x14")]
	private static byte[] staticDLength;

	[Token(Token = "0x40198F1")]
	[FieldOffset(Offset = "0x8")]
	public DeflaterPending pending;

	[Token(Token = "0x40198F2")]
	[FieldOffset(Offset = "0xC")]
	private Tree literalTree;

	[Token(Token = "0x40198F3")]
	[FieldOffset(Offset = "0x10")]
	private Tree distTree;

	[Token(Token = "0x40198F4")]
	[FieldOffset(Offset = "0x14")]
	private Tree blTree;

	[Token(Token = "0x40198F5")]
	[FieldOffset(Offset = "0x18")]
	private short[] d_buf;

	[Token(Token = "0x40198F6")]
	[FieldOffset(Offset = "0x1C")]
	private byte[] l_buf;

	[Token(Token = "0x40198F7")]
	[FieldOffset(Offset = "0x20")]
	private int last_lit;

	[Token(Token = "0x40198F8")]
	[FieldOffset(Offset = "0x24")]
	private int extra_bits;

	[Token(Token = "0x6017E9D")]
	[Address(RVA = "0x3521500", Offset = "0x3521500", VA = "0x3521500")]
	static DeflaterHuffman()
	{
	}

	[Token(Token = "0x6017E9E")]
	[Address(RVA = "0x351F2E8", Offset = "0x351F2E8", VA = "0x351F2E8")]
	public DeflaterHuffman(DeflaterPending pending)
	{
	}

	[Token(Token = "0x6017E9F")]
	[Address(RVA = "0x351FEF0", Offset = "0x351FEF0", VA = "0x351FEF0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017EA0")]
	[Address(RVA = "0x3521C48", Offset = "0x3521C48", VA = "0x3521C48")]
	public void SendAllTrees(int blTreeCodes)
	{
	}

	[Token(Token = "0x6017EA1")]
	[Address(RVA = "0x3521F10", Offset = "0x3521F10", VA = "0x3521F10")]
	public void CompressBlock()
	{
	}

	[Token(Token = "0x6017EA2")]
	[Address(RVA = "0x351FF74", Offset = "0x351FF74", VA = "0x351FF74")]
	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
	{
	}

	[Token(Token = "0x6017EA3")]
	[Address(RVA = "0x3520064", Offset = "0x3520064", VA = "0x3520064")]
	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
	{
	}

	[Token(Token = "0x6017EA4")]
	[Address(RVA = "0x35214EC", Offset = "0x35214EC", VA = "0x35214EC")]
	public bool IsFull()
	{
		return default(bool);
	}

	[Token(Token = "0x6017EA5")]
	[Address(RVA = "0x35206C4", Offset = "0x35206C4", VA = "0x35206C4")]
	public bool TallyLit(int literal)
	{
		return default(bool);
	}

	[Token(Token = "0x6017EA6")]
	[Address(RVA = "0x352126C", Offset = "0x352126C", VA = "0x352126C")]
	public bool TallyDist(int distance, int length)
	{
		return default(bool);
	}

	[Token(Token = "0x6017EA7")]
	[Address(RVA = "0x3521A7C", Offset = "0x3521A7C", VA = "0x3521A7C")]
	public static short BitReverse(int toReverse)
	{
		return default(short);
	}

	[Token(Token = "0x6017EA8")]
	[Address(RVA = "0x3522218", Offset = "0x3522218", VA = "0x3522218")]
	private static int Lcode(int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017EA9")]
	[Address(RVA = "0x3522250", Offset = "0x3522250", VA = "0x3522250")]
	private static int Dcode(int distance)
	{
		return default(int);
	}
}
