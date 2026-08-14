using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D30")]
public class Rampage4BHyperUpdateNtf
{
	[Token(Token = "0x400B84B")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Chyper_003Ek__BackingField;

	[Token(Token = "0x400B84C")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Chyper_level_003Ek__BackingField;

	[Token(Token = "0x400B84D")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cis_upper_limit_003Ek__BackingField;

	[Token(Token = "0x17000C33")]
	public uint hyper
	{
		[Token(Token = "0x60087DF")]
		[Address(RVA = "0x435D08C", Offset = "0x435D08C", VA = "0x435D08C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087E0")]
		[Address(RVA = "0x435D094", Offset = "0x435D094", VA = "0x435D094")]
		set
		{
		}
	}

	[Token(Token = "0x17000C34")]
	public uint hyper_level
	{
		[Token(Token = "0x60087E1")]
		[Address(RVA = "0x435D09C", Offset = "0x435D09C", VA = "0x435D09C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087E2")]
		[Address(RVA = "0x435D0A4", Offset = "0x435D0A4", VA = "0x435D0A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000C35")]
	public bool is_upper_limit
	{
		[Token(Token = "0x60087E3")]
		[Address(RVA = "0x435D0AC", Offset = "0x435D0AC", VA = "0x435D0AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60087E4")]
		[Address(RVA = "0x435D0B4", Offset = "0x435D0B4", VA = "0x435D0B4")]
		set
		{
		}
	}

	[Token(Token = "0x60087DE")]
	[Address(RVA = "0x435D084", Offset = "0x435D084", VA = "0x435D084")]
	public Rampage4BHyperUpdateNtf()
	{
	}
}
