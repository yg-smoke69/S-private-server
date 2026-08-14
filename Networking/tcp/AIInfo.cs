using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DA0")]
public class AIInfo
{
	[Token(Token = "0x400BBCB")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cai_index_003Ek__BackingField;

	[Token(Token = "0x400BBCC")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cai_num_003Ek__BackingField;

	[Token(Token = "0x17000E77")]
	public string ai_index
	{
		[Token(Token = "0x6008CBA")]
		[Address(RVA = "0x33E6E3C", Offset = "0x33E6E3C", VA = "0x33E6E3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008CBB")]
		[Address(RVA = "0x33E6E34", Offset = "0x33E6E34", VA = "0x33E6E34")]
		set
		{
		}
	}

	[Token(Token = "0x17000E78")]
	public uint ai_num
	{
		[Token(Token = "0x6008CBC")]
		[Address(RVA = "0x33E6E44", Offset = "0x33E6E44", VA = "0x33E6E44")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008CBD")]
		[Address(RVA = "0x33E6E4C", Offset = "0x33E6E4C", VA = "0x33E6E4C")]
		set
		{
		}
	}

	[Token(Token = "0x6008CB9")]
	[Address(RVA = "0x33E6D94", Offset = "0x33E6D94", VA = "0x33E6D94")]
	public AIInfo()
	{
	}
}
