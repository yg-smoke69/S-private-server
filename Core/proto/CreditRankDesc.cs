using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C03")]
public class CreditRankDesc
{
	[Token(Token = "0x400B044")]
	[FieldOffset(Offset = "0x8")]
	public uint credit_score;

	[Token(Token = "0x400B045")]
	[FieldOffset(Offset = "0xC")]
	public uint credit_recover;

	[Token(Token = "0x600825E")]
	[Address(RVA = "0x309D8F8", Offset = "0x309D8F8", VA = "0x309D8F8")]
	public CreditRankDesc()
	{
	}
}
