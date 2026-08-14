using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CEB")]
public class AccountEmoteRandomID
{
	[Token(Token = "0x400B733")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B734")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Crandom_id_003Ek__BackingField;

	[Token(Token = "0x17000B9A")]
	public ulong account_id
	{
		[Token(Token = "0x600867A")]
		[Address(RVA = "0x33E6ED4", Offset = "0x33E6ED4", VA = "0x33E6ED4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600867B")]
		[Address(RVA = "0x33E6EDC", Offset = "0x33E6EDC", VA = "0x33E6EDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B9B")]
	public uint random_id
	{
		[Token(Token = "0x600867C")]
		[Address(RVA = "0x33E6EEC", Offset = "0x33E6EEC", VA = "0x33E6EEC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600867D")]
		[Address(RVA = "0x33E6EF4", Offset = "0x33E6EF4", VA = "0x33E6EF4")]
		set
		{
		}
	}

	[Token(Token = "0x6008679")]
	[Address(RVA = "0x33E6ECC", Offset = "0x33E6ECC", VA = "0x33E6ECC")]
	public AccountEmoteRandomID()
	{
	}
}
