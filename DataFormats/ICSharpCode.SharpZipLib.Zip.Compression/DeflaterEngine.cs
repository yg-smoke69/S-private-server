using ICSharpCode.SharpZipLib.Checksums;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression;

[Token(Token = "0x2003BF3")]
public class DeflaterEngine : DeflaterConstants
{
	[Token(Token = "0x40198CB")]
	private const int TooFar = 4096;

	[Token(Token = "0x40198CC")]
	[FieldOffset(Offset = "0x8")]
	private int ins_h;

	[Token(Token = "0x40198CD")]
	[FieldOffset(Offset = "0xC")]
	private short[] head;

	[Token(Token = "0x40198CE")]
	[FieldOffset(Offset = "0x10")]
	private short[] prev;

	[Token(Token = "0x40198CF")]
	[FieldOffset(Offset = "0x14")]
	private int matchStart;

	[Token(Token = "0x40198D0")]
	[FieldOffset(Offset = "0x18")]
	private int matchLen;

	[Token(Token = "0x40198D1")]
	[FieldOffset(Offset = "0x1C")]
	private bool prevAvailable;

	[Token(Token = "0x40198D2")]
	[FieldOffset(Offset = "0x20")]
	private int blockStart;

	[Token(Token = "0x40198D3")]
	[FieldOffset(Offset = "0x24")]
	private int strstart;

	[Token(Token = "0x40198D4")]
	[FieldOffset(Offset = "0x28")]
	private int lookahead;

	[Token(Token = "0x40198D5")]
	[FieldOffset(Offset = "0x2C")]
	private byte[] window;

	[Token(Token = "0x40198D6")]
	[FieldOffset(Offset = "0x30")]
	private DeflateStrategy strategy;

	[Token(Token = "0x40198D7")]
	[FieldOffset(Offset = "0x34")]
	private int max_chain;

	[Token(Token = "0x40198D8")]
	[FieldOffset(Offset = "0x38")]
	private int max_lazy;

	[Token(Token = "0x40198D9")]
	[FieldOffset(Offset = "0x3C")]
	private int niceLength;

	[Token(Token = "0x40198DA")]
	[FieldOffset(Offset = "0x40")]
	private int goodLength;

	[Token(Token = "0x40198DB")]
	[FieldOffset(Offset = "0x44")]
	private int compressionFunction;

	[Token(Token = "0x40198DC")]
	[FieldOffset(Offset = "0x48")]
	private byte[] inputBuf;

	[Token(Token = "0x40198DD")]
	[FieldOffset(Offset = "0x50")]
	private long totalIn;

	[Token(Token = "0x40198DE")]
	[FieldOffset(Offset = "0x58")]
	private int inputOff;

	[Token(Token = "0x40198DF")]
	[FieldOffset(Offset = "0x5C")]
	private int inputEnd;

	[Token(Token = "0x40198E0")]
	[FieldOffset(Offset = "0x60")]
	private DeflaterPending pending;

	[Token(Token = "0x40198E1")]
	[FieldOffset(Offset = "0x64")]
	private DeflaterHuffman huffman;

	[Token(Token = "0x40198E2")]
	[FieldOffset(Offset = "0x68")]
	private Adler32 adler;

	[Token(Token = "0x17001915")]
	public int Adler
	{
		[Token(Token = "0x6017E90")]
		[Address(RVA = "0x351E124", Offset = "0x351E124", VA = "0x351E124")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001916")]
	public long TotalIn
	{
		[Token(Token = "0x6017E91")]
		[Address(RVA = "0x351E148", Offset = "0x351E148", VA = "0x351E148")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001917")]
	public DeflateStrategy Strategy
	{
		[Token(Token = "0x6017E92")]
		[Address(RVA = "0x351FF6C", Offset = "0x351FF6C", VA = "0x351FF6C")]
		get
		{
			return default(DeflateStrategy);
		}
		[Token(Token = "0x6017E93")]
		[Address(RVA = "0x351E998", Offset = "0x351E998", VA = "0x351E998")]
		set
		{
		}
	}

	[Token(Token = "0x6017E89")]
	[Address(RVA = "0x351DE10", Offset = "0x351DE10", VA = "0x351DE10")]
	public DeflaterEngine(DeflaterPending pending)
	{
	}

	[Token(Token = "0x6017E8A")]
	[Address(RVA = "0x351EE14", Offset = "0x351EE14", VA = "0x351EE14")]
	public bool Deflate(bool flush, bool finish)
	{
		return default(bool);
	}

	[Token(Token = "0x6017E8B")]
	[Address(RVA = "0x351E324", Offset = "0x351E324", VA = "0x351E324")]
	public void SetInput(byte[] buffer, int offset, int count)
	{
	}

	[Token(Token = "0x6017E8C")]
	[Address(RVA = "0x351E1E4", Offset = "0x351E1E4", VA = "0x351E1E4")]
	public bool NeedsInput()
	{
		return default(bool);
	}

	[Token(Token = "0x6017E8D")]
	[Address(RVA = "0x351F07C", Offset = "0x351F07C", VA = "0x351F07C")]
	public void SetDictionary(byte[] buffer, int offset, int length)
	{
	}

	[Token(Token = "0x6017E8E")]
	[Address(RVA = "0x351DFDC", Offset = "0x351DFDC", VA = "0x351DFDC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017E8F")]
	[Address(RVA = "0x351EDEC", Offset = "0x351EDEC", VA = "0x351EDEC")]
	public void ResetAdler()
	{
	}

	[Token(Token = "0x6017E94")]
	[Address(RVA = "0x351E524", Offset = "0x351E524", VA = "0x351E524")]
	public void SetLevel(int level)
	{
	}

	[Token(Token = "0x6017E95")]
	[Address(RVA = "0x351F410", Offset = "0x351F410", VA = "0x351F410")]
	public void FillWindow()
	{
	}

	[Token(Token = "0x6017E96")]
	[Address(RVA = "0x351FD40", Offset = "0x351FD40", VA = "0x351FD40")]
	private void UpdateHash()
	{
	}

	[Token(Token = "0x6017E97")]
	[Address(RVA = "0x351FDD4", Offset = "0x351FDD4", VA = "0x351FDD4")]
	private int InsertString()
	{
		return default(int);
	}

	[Token(Token = "0x6017E98")]
	[Address(RVA = "0x35207C0", Offset = "0x35207C0", VA = "0x35207C0")]
	private void SlideWindow()
	{
	}

	[Token(Token = "0x6017E99")]
	[Address(RVA = "0x3520944", Offset = "0x3520944", VA = "0x3520944")]
	private bool FindLongestMatch(int curMatch)
	{
		return default(bool);
	}

	[Token(Token = "0x6017E9A")]
	[Address(RVA = "0x351F510", Offset = "0x351F510", VA = "0x351F510")]
	private bool DeflateStored(bool flush, bool finish)
	{
		return default(bool);
	}

	[Token(Token = "0x6017E9B")]
	[Address(RVA = "0x351F6DC", Offset = "0x351F6DC", VA = "0x351F6DC")]
	private bool DeflateFast(bool flush, bool finish)
	{
		return default(bool);
	}

	[Token(Token = "0x6017E9C")]
	[Address(RVA = "0x351F9A0", Offset = "0x351F9A0", VA = "0x351F9A0")]
	private bool DeflateSlow(bool flush, bool finish)
	{
		return default(bool);
	}
}
