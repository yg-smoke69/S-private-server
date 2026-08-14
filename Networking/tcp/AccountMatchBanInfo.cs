using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D9A")]
public class AccountMatchBanInfo
{
	[Token(Token = "0x400BABE")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cban_type_003Ek__BackingField;

	[Token(Token = "0x400BABF")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cexpire_time_003Ek__BackingField;

	[Token(Token = "0x17000D6A")]
	public uint ban_type
	{
		[Token(Token = "0x6008A9A")]
		[Address(RVA = "0x33E7054", Offset = "0x33E7054", VA = "0x33E7054")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A9B")]
		[Address(RVA = "0x33E705C", Offset = "0x33E705C", VA = "0x33E705C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D6B")]
	public uint expire_time
	{
		[Token(Token = "0x6008A9C")]
		[Address(RVA = "0x33E7064", Offset = "0x33E7064", VA = "0x33E7064")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A9D")]
		[Address(RVA = "0x33E706C", Offset = "0x33E706C", VA = "0x33E706C")]
		set
		{
		}
	}

	[Token(Token = "0x6008A99")]
	[Address(RVA = "0x33E704C", Offset = "0x33E704C", VA = "0x33E704C")]
	public AccountMatchBanInfo()
	{
	}
}
