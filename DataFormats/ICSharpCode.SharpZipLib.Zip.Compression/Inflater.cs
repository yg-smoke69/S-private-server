using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF7")]
public class Inflater
{
	[Token(Token = "0x4019901")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] CPLENS;

	[Token(Token = "0x4019902")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int[] CPLEXT;

	[Token(Token = "0x4019903")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int[] CPDIST;

	[Token(Token = "0x4019904")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int[] CPDEXT;

	[Token(Token = "0x4019905")]
	private const int DECODE_HEADER = 0;

	[Token(Token = "0x4019906")]
	private const int DECODE_DICT = 1;

	[Token(Token = "0x4019907")]
	private const int DECODE_BLOCKS = 2;

	[Token(Token = "0x4019908")]
	private const int DECODE_STORED_LEN1 = 3;

	[Token(Token = "0x4019909")]
	private const int DECODE_STORED_LEN2 = 4;

	[Token(Token = "0x401990A")]
	private const int DECODE_STORED = 5;

	[Token(Token = "0x401990B")]
	private const int DECODE_DYN_HEADER = 6;

	[Token(Token = "0x401990C")]
	private const int DECODE_HUFFMAN = 7;

	[Token(Token = "0x401990D")]
	private const int DECODE_HUFFMAN_LENBITS = 8;

	[Token(Token = "0x401990E")]
	private const int DECODE_HUFFMAN_DIST = 9;

	[Token(Token = "0x401990F")]
	private const int DECODE_HUFFMAN_DISTBITS = 10;

	[Token(Token = "0x4019910")]
	private const int DECODE_CHKSUM = 11;

	[Token(Token = "0x4019911")]
	private const int FINISHED = 12;

	[Token(Token = "0x4019912")]
	[FieldOffset(Offset = "0x8")]
	private int mode;

	[Token(Token = "0x4019913")]
	[FieldOffset(Offset = "0xC")]
	private int readAdler;

	[Token(Token = "0x4019914")]
	[FieldOffset(Offset = "0x10")]
	private int neededBits;

	[Token(Token = "0x4019915")]
	[FieldOffset(Offset = "0x14")]
	private int repLength;

	[Token(Token = "0x4019916")]
	[FieldOffset(Offset = "0x18")]
	private int repDist;

	[Token(Token = "0x4019917")]
	[FieldOffset(Offset = "0x1C")]
	private int uncomprLen;

	[Token(Token = "0x4019918")]
	[FieldOffset(Offset = "0x20")]
	private bool isLastBlock;

	[Token(Token = "0x4019919")]
	[FieldOffset(Offset = "0x28")]
	private long totalOut;

	[Token(Token = "0x401991A")]
	[FieldOffset(Offset = "0x30")]
	private long totalIn;

	[Token(Token = "0x401991B")]
	[FieldOffset(Offset = "0x38")]
	private bool noHeader;

	[Token(Token = "0x401991C")]
	[FieldOffset(Offset = "0x3C")]
	private StreamManipulator input;

	[Token(Token = "0x401991D")]
	[FieldOffset(Offset = "0x40")]
	private OutputWindow outputWindow;

	[Token(Token = "0x401991E")]
	[FieldOffset(Offset = "0x44")]
	private InflaterDynHeader dynHeader;

	[Token(Token = "0x401991F")]
	[FieldOffset(Offset = "0x48")]
	private InflaterHuffmanTree litlenTree;

	[Token(Token = "0x4019920")]
	[FieldOffset(Offset = "0x4C")]
	private InflaterHuffmanTree distTree;

	[Token(Token = "0x4019921")]
	[FieldOffset(Offset = "0x50")]
	private Adler32 adler;

	[Token(Token = "0x17001918")]
	public bool IsNeedingInput
	{
		[Token(Token = "0x6017EC4")]
		[Address(RVA = "0xA220BC", Offset = "0xA220BC", VA = "0xA220BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001919")]
	public bool IsNeedingDictionary
	{
		[Token(Token = "0x6017EC5")]
		[Address(RVA = "0xA216EC", Offset = "0xA216EC", VA = "0xA216EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700191A")]
	public bool IsFinished
	{
		[Token(Token = "0x6017EC6")]
		[Address(RVA = "0xA21F38", Offset = "0xA21F38", VA = "0xA21F38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700191B")]
	public int Adler
	{
		[Token(Token = "0x6017EC7")]
		[Address(RVA = "0xA220F0", Offset = "0xA220F0", VA = "0xA220F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700191C")]
	public long TotalOut
	{
		[Token(Token = "0x6017EC8")]
		[Address(RVA = "0xA22134", Offset = "0xA22134", VA = "0xA22134")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700191D")]
	public long TotalIn
	{
		[Token(Token = "0x6017EC9")]
		[Address(RVA = "0xA2213C", Offset = "0xA2213C", VA = "0xA2213C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700191E")]
	public int RemainingInput
	{
		[Token(Token = "0x6017ECA")]
		[Address(RVA = "0xA2217C", Offset = "0xA2217C", VA = "0xA2217C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6017EB6")]
	[Address(RVA = "0xA1EEFC", Offset = "0xA1EEFC", VA = "0xA1EEFC")]
	public Inflater()
	{
	}

	[Token(Token = "0x6017EB7")]
	[Address(RVA = "0xA1EF04", Offset = "0xA1EF04", VA = "0xA1EF04")]
	public Inflater(bool noHeader)
	{
	}

	[Token(Token = "0x6017EB8")]
	[Address(RVA = "0xA1F064", Offset = "0xA1F064", VA = "0xA1F064")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017EB9")]
	[Address(RVA = "0xA1F134", Offset = "0xA1F134", VA = "0xA1F134")]
	private bool DecodeHeader()
	{
		return default(bool);
	}

	[Token(Token = "0x6017EBA")]
	[Address(RVA = "0xA1F400", Offset = "0xA1F400", VA = "0xA1F400")]
	private bool DecodeDict()
	{
		return default(bool);
	}

	[Token(Token = "0x6017EBB")]
	[Address(RVA = "0xA1F498", Offset = "0xA1F498", VA = "0xA1F498")]
	private bool DecodeHuffman()
	{
		return default(bool);
	}

	[Token(Token = "0x6017EBC")]
	[Address(RVA = "0xA200B4", Offset = "0xA200B4", VA = "0xA200B4")]
	private bool DecodeChksum()
	{
		return default(bool);
	}

	[Token(Token = "0x6017EBD")]
	[Address(RVA = "0xA20454", Offset = "0xA20454", VA = "0xA20454")]
	private bool Decode(bool enable_optimize = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6017EBE")]
	[Address(RVA = "0xA2140C", Offset = "0xA2140C", VA = "0xA2140C")]
	public void SetDictionary(byte[] buffer)
	{
	}

	[Token(Token = "0x6017EBF")]
	[Address(RVA = "0xA2144C", Offset = "0xA2144C", VA = "0xA2144C")]
	public void SetDictionary(byte[] buffer, int index, int count)
	{
	}

	[Token(Token = "0x6017EC0")]
	[Address(RVA = "0xA21848", Offset = "0xA21848", VA = "0xA21848")]
	public void SetInput(byte[] buffer)
	{
	}

	[Token(Token = "0x6017EC1")]
	[Address(RVA = "0xA21888", Offset = "0xA21888", VA = "0xA21888")]
	public void SetInput(byte[] buffer, int index, int count)
	{
	}

	[Token(Token = "0x6017EC2")]
	[Address(RVA = "0xA21B60", Offset = "0xA21B60", VA = "0xA21B60")]
	public int Inflate(byte[] buffer)
	{
		return default(int);
	}

	[Token(Token = "0x6017EC3")]
	[Address(RVA = "0xA21C34", Offset = "0xA21C34", VA = "0xA21C34")]
	public int Inflate(byte[] buffer, int offset, int count, bool enable_optimize = false)
	{
		return default(int);
	}
}
