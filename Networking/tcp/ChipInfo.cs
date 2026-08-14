using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D8F")]
public class ChipInfo
{
	[Token(Token = "0x400BAA0")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400BAA1")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccnt_003Ek__BackingField;

	[Token(Token = "0x400BAA2")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cexpire_time_003Ek__BackingField;

	[Token(Token = "0x17000D4C")]
	public uint id
	{
		[Token(Token = "0x6008A53")]
		[Address(RVA = "0x33E84B4", Offset = "0x33E84B4", VA = "0x33E84B4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A54")]
		[Address(RVA = "0x33E84BC", Offset = "0x33E84BC", VA = "0x33E84BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000D4D")]
	public uint cnt
	{
		[Token(Token = "0x6008A55")]
		[Address(RVA = "0x33E84C4", Offset = "0x33E84C4", VA = "0x33E84C4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A56")]
		[Address(RVA = "0x33E84CC", Offset = "0x33E84CC", VA = "0x33E84CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000D4E")]
	public uint expire_time
	{
		[Token(Token = "0x6008A57")]
		[Address(RVA = "0x33E84D4", Offset = "0x33E84D4", VA = "0x33E84D4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A58")]
		[Address(RVA = "0x33E84DC", Offset = "0x33E84DC", VA = "0x33E84DC")]
		set
		{
		}
	}

	[Token(Token = "0x6008A52")]
	[Address(RVA = "0x33E84AC", Offset = "0x33E84AC", VA = "0x33E84AC")]
	public ChipInfo()
	{
	}
}
