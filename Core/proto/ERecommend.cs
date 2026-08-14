using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200148A")]
public class ERecommend
{
	[Token(Token = "0x200148B")]
	public enum Type
	{
		[Token(Token = "0x4008E7E")]
		Type_NONE,
		[Token(Token = "0x4008E7F")]
		Type_PRUCHASE_OFFER
	}

	[Token(Token = "0x200148C")]
	public enum Algorithm
	{
		[Token(Token = "0x4008E81")]
		Algorithm_NONE
	}

	[Token(Token = "0x200148D")]
	public enum Origin
	{
		[Token(Token = "0x4008E83")]
		Origin_CSV,
		[Token(Token = "0x4008E84")]
		Origin_REDIS
	}

	[Token(Token = "0x6007B09")]
	[Address(RVA = "0x309F8D4", Offset = "0x309F8D4", VA = "0x309F8D4")]
	public ERecommend()
	{
	}
}
