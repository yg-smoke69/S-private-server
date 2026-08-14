using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF0")]
public class Deflater
{
	[Token(Token = "0x4019897")]
	public const int BEST_COMPRESSION = 9;

	[Token(Token = "0x4019898")]
	public const int BEST_SPEED = 1;

	[Token(Token = "0x4019899")]
	public const int DEFAULT_COMPRESSION = -1;

	[Token(Token = "0x401989A")]
	public const int NO_COMPRESSION = 0;

	[Token(Token = "0x401989B")]
	public const int DEFLATED = 8;

	[Token(Token = "0x401989C")]
	private const int IS_SETDICT = 1;

	[Token(Token = "0x401989D")]
	private const int IS_FLUSHING = 4;

	[Token(Token = "0x401989E")]
	private const int IS_FINISHING = 8;

	[Token(Token = "0x401989F")]
	private const int INIT_STATE = 0;

	[Token(Token = "0x40198A0")]
	private const int SETDICT_STATE = 1;

	[Token(Token = "0x40198A1")]
	private const int BUSY_STATE = 16;

	[Token(Token = "0x40198A2")]
	private const int FLUSHING_STATE = 20;

	[Token(Token = "0x40198A3")]
	private const int FINISHING_STATE = 28;

	[Token(Token = "0x40198A4")]
	private const int FINISHED_STATE = 30;

	[Token(Token = "0x40198A5")]
	private const int CLOSED_STATE = 127;

	[Token(Token = "0x40198A6")]
	[FieldOffset(Offset = "0x8")]
	private int level;

	[Token(Token = "0x40198A7")]
	[FieldOffset(Offset = "0xC")]
	private bool noZlibHeaderOrFooter;

	[Token(Token = "0x40198A8")]
	[FieldOffset(Offset = "0x10")]
	private int state;

	[Token(Token = "0x40198A9")]
	[FieldOffset(Offset = "0x18")]
	private long totalOut;

	[Token(Token = "0x40198AA")]
	[FieldOffset(Offset = "0x20")]
	private DeflaterPending pending;

	[Token(Token = "0x40198AB")]
	[FieldOffset(Offset = "0x24")]
	private DeflaterEngine engine;

	[Token(Token = "0x17001910")]
	public int Adler
	{
		[Token(Token = "0x6017E77")]
		[Address(RVA = "0x351E0EC", Offset = "0x351E0EC", VA = "0x351E0EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001911")]
	public long TotalIn
	{
		[Token(Token = "0x6017E78")]
		[Address(RVA = "0x351DDD8", Offset = "0x351DDD8", VA = "0x351DDD8")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001912")]
	public long TotalOut
	{
		[Token(Token = "0x6017E79")]
		[Address(RVA = "0x351E150", Offset = "0x351E150", VA = "0x351E150")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001913")]
	public bool IsFinished
	{
		[Token(Token = "0x6017E7C")]
		[Address(RVA = "0x351E178", Offset = "0x351E178", VA = "0x351E178")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001914")]
	public bool IsNeedingInput
	{
		[Token(Token = "0x6017E7D")]
		[Address(RVA = "0x351E1B4", Offset = "0x351E1B4", VA = "0x351E1B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6017E73")]
	[Address(RVA = "0x351DDFC", Offset = "0x351DDFC", VA = "0x351DDFC")]
	public Deflater()
	{
	}

	[Token(Token = "0x6017E74")]
	[Address(RVA = "0x351DE08", Offset = "0x351DE08", VA = "0x351DE08")]
	public Deflater(int level)
	{
	}

	[Token(Token = "0x6017E75")]
	[Address(RVA = "0x351D594", Offset = "0x351D594", VA = "0x351D594")]
	public Deflater(int level, bool noZlibHeaderOrFooter)
	{
	}

	[Token(Token = "0x6017E76")]
	[Address(RVA = "0x351DF64", Offset = "0x351DF64", VA = "0x351DF64")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017E7A")]
	[Address(RVA = "0x351E158", Offset = "0x351E158", VA = "0x351E158")]
	public void Flush()
	{
	}

	[Token(Token = "0x6017E7B")]
	[Address(RVA = "0x351E168", Offset = "0x351E168", VA = "0x351E168")]
	public void Finish()
	{
	}

	[Token(Token = "0x6017E7E")]
	[Address(RVA = "0x351E1F8", Offset = "0x351E1F8", VA = "0x351E1F8")]
	public void SetInput(byte[] input)
	{
	}

	[Token(Token = "0x6017E7F")]
	[Address(RVA = "0x351E238", Offset = "0x351E238", VA = "0x351E238")]
	public void SetInput(byte[] input, int offset, int count)
	{
	}

	[Token(Token = "0x6017E80")]
	[Address(RVA = "0x351D7A8", Offset = "0x351D7A8", VA = "0x351D7A8")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x6017E81")]
	[Address(RVA = "0x351D8B8", Offset = "0x351D8B8", VA = "0x351D8B8")]
	public int GetLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6017E82")]
	[Address(RVA = "0x351DF3C", Offset = "0x351DF3C", VA = "0x351DF3C")]
	public void SetStrategy(DeflateStrategy strategy)
	{
	}

	[Token(Token = "0x6017E83")]
	[Address(RVA = "0x351E9A0", Offset = "0x351E9A0", VA = "0x351E9A0")]
	public int Deflate(byte[] output)
	{
		return default(int);
	}

	[Token(Token = "0x6017E84")]
	[Address(RVA = "0x351E9E0", Offset = "0x351E9E0", VA = "0x351E9E0")]
	public int Deflate(byte[] output, int offset, int length)
	{
		return default(int);
	}

	[Token(Token = "0x6017E85")]
	[Address(RVA = "0x351EF5C", Offset = "0x351EF5C", VA = "0x351EF5C")]
	public void SetDictionary(byte[] dictionary)
	{
	}

	[Token(Token = "0x6017E86")]
	[Address(RVA = "0x351EF9C", Offset = "0x351EF9C", VA = "0x351EF9C")]
	public void SetDictionary(byte[] dictionary, int index, int count)
	{
	}
}
