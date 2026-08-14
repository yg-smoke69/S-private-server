using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C07")]
public class CreditReduceRateDesc
{
	[Token(Token = "0x400B053")]
	[FieldOffset(Offset = "0x8")]
	public uint credit_reduce_rate_min;

	[Token(Token = "0x400B054")]
	[FieldOffset(Offset = "0xC")]
	public uint credit_reduce_rate_max;

	[Token(Token = "0x400B055")]
	[FieldOffset(Offset = "0x10")]
	public float ex_credit_reduce;

	[Token(Token = "0x6008262")]
	[Address(RVA = "0x309D908", Offset = "0x309D908", VA = "0x309D908")]
	public CreditReduceRateDesc()
	{
	}
}
