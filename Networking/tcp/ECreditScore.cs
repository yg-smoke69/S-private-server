using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C9E")]
public class ECreditScore
{
	[Token(Token = "0x2001C9F")]
	public enum Proto
	{
		[Token(Token = "0x400B54E")]
		Proto_NONE,
		[Token(Token = "0x400B54F")]
		Proto_CREDIT_SCORE_CHANGE_NTF,
		[Token(Token = "0x400B550")]
		Proto_TEAMMATE_MUTED_NTF
	}

	[Token(Token = "0x2001CA0")]
	public enum ErrCode
	{
		[Token(Token = "0x400B552")]
		ErrCode_SUSS
	}

	[Token(Token = "0x600841C")]
	[Address(RVA = "0x33E900C", Offset = "0x33E900C", VA = "0x33E900C")]
	public ECreditScore()
	{
	}
}
