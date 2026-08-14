using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E6")]
public class EDrawClanLuckyBagResultType
{
	[Token(Token = "0x20014E7")]
	public enum ResultType
	{
		[Token(Token = "0x4009028")]
		ResultType_NONE,
		[Token(Token = "0x4009029")]
		ResultType_SUCCESS,
		[Token(Token = "0x400902A")]
		ResultType_TOO_EARLY,
		[Token(Token = "0x400902B")]
		ResultType_MAX_NUM_PER_DAY,
		[Token(Token = "0x400902C")]
		ResultType_EXPIRED,
		[Token(Token = "0x400902D")]
		ResultType_ALL_TAKEN,
		[Token(Token = "0x400902E")]
		ResultType_ALREADY_DRAWN,
		[Token(Token = "0x400902F")]
		ResultType_BAG_NOT_FOUND
	}

	[Token(Token = "0x6007B3B")]
	[Address(RVA = "0x309F2C0", Offset = "0x309F2C0", VA = "0x309F2C0")]
	public EDrawClanLuckyBagResultType()
	{
	}
}
