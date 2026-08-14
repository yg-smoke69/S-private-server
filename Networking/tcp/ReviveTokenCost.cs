using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D93")]
public class ReviveTokenCost
{
	[Token(Token = "0x400BAAA")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cgem_cost_self_003Ek__BackingField;

	[Token(Token = "0x400BAAB")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cgem_cost_teammate_003Ek__BackingField;

	[Token(Token = "0x400BAAC")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cgem_cost_wiped_003Ek__BackingField;

	[Token(Token = "0x17000D56")]
	public uint gem_cost_self
	{
		[Token(Token = "0x6008A6B")]
		[Address(RVA = "0x435D620", Offset = "0x435D620", VA = "0x435D620")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A6C")]
		[Address(RVA = "0x435D628", Offset = "0x435D628", VA = "0x435D628")]
		set
		{
		}
	}

	[Token(Token = "0x17000D57")]
	public uint gem_cost_teammate
	{
		[Token(Token = "0x6008A6D")]
		[Address(RVA = "0x435D630", Offset = "0x435D630", VA = "0x435D630")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A6E")]
		[Address(RVA = "0x435D638", Offset = "0x435D638", VA = "0x435D638")]
		set
		{
		}
	}

	[Token(Token = "0x17000D58")]
	public uint gem_cost_wiped
	{
		[Token(Token = "0x6008A6F")]
		[Address(RVA = "0x435D640", Offset = "0x435D640", VA = "0x435D640")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A70")]
		[Address(RVA = "0x435D648", Offset = "0x435D648", VA = "0x435D648")]
		set
		{
		}
	}

	[Token(Token = "0x6008A6A")]
	[Address(RVA = "0x435D618", Offset = "0x435D618", VA = "0x435D618")]
	public ReviveTokenCost()
	{
	}
}
