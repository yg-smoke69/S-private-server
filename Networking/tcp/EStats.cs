using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D74")]
public class EStats
{
	[Token(Token = "0x2001D75")]
	public enum Proto
	{
		[Token(Token = "0x400B9F3")]
		Proto_NONE,
		[Token(Token = "0x400B9F4")]
		Proto_MATCHSTATS_NTF
	}

	[Token(Token = "0x2001D76")]
	public enum ErrCode
	{
		[Token(Token = "0x400B9F6")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008A0F")]
	[Address(RVA = "0x33E9228", Offset = "0x33E9228", VA = "0x33E9228")]
	public EStats()
	{
	}
}
