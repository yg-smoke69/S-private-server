using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF1")]
public class DeflaterConstants
{
	[Token(Token = "0x40198AC")]
	public const bool DEBUGGING = false;

	[Token(Token = "0x40198AD")]
	public const int STORED_BLOCK = 0;

	[Token(Token = "0x40198AE")]
	public const int STATIC_TREES = 1;

	[Token(Token = "0x40198AF")]
	public const int DYN_TREES = 2;

	[Token(Token = "0x40198B0")]
	public const int PRESET_DICT = 32;

	[Token(Token = "0x40198B1")]
	public const int DEFAULT_MEM_LEVEL = 8;

	[Token(Token = "0x40198B2")]
	public const int MAX_MATCH = 258;

	[Token(Token = "0x40198B3")]
	public const int MIN_MATCH = 3;

	[Token(Token = "0x40198B4")]
	public const int MAX_WBITS = 15;

	[Token(Token = "0x40198B5")]
	public const int WSIZE = 32768;

	[Token(Token = "0x40198B6")]
	public const int WMASK = 32767;

	[Token(Token = "0x40198B7")]
	public const int HASH_BITS = 15;

	[Token(Token = "0x40198B8")]
	public const int HASH_SIZE = 32768;

	[Token(Token = "0x40198B9")]
	public const int HASH_MASK = 32767;

	[Token(Token = "0x40198BA")]
	public const int HASH_SHIFT = 5;

	[Token(Token = "0x40198BB")]
	public const int MIN_LOOKAHEAD = 262;

	[Token(Token = "0x40198BC")]
	public const int MAX_DIST = 32506;

	[Token(Token = "0x40198BD")]
	public const int PENDING_BUF_SIZE = 65536;

	[Token(Token = "0x40198BE")]
	[FieldOffset(Offset = "0x0")]
	public static int MAX_BLOCK_SIZE;

	[Token(Token = "0x40198BF")]
	public const int DEFLATE_STORED = 0;

	[Token(Token = "0x40198C0")]
	public const int DEFLATE_FAST = 1;

	[Token(Token = "0x40198C1")]
	public const int DEFLATE_SLOW = 2;

	[Token(Token = "0x40198C2")]
	[FieldOffset(Offset = "0x4")]
	public static int[] GOOD_LENGTH;

	[Token(Token = "0x40198C3")]
	[FieldOffset(Offset = "0x8")]
	public static int[] MAX_LAZY;

	[Token(Token = "0x40198C4")]
	[FieldOffset(Offset = "0xC")]
	public static int[] NICE_LENGTH;

	[Token(Token = "0x40198C5")]
	[FieldOffset(Offset = "0x10")]
	public static int[] MAX_CHAIN;

	[Token(Token = "0x40198C6")]
	[FieldOffset(Offset = "0x14")]
	public static int[] COMPR_FUNC;

	[Token(Token = "0x6017E87")]
	[Address(RVA = "0x351F14C", Offset = "0x351F14C", VA = "0x351F14C")]
	public DeflaterConstants()
	{
	}
}
