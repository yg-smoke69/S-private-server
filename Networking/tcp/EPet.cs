using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D31")]
public class EPet
{
	[Token(Token = "0x2001D32")]
	public enum Proto
	{
		[Token(Token = "0x400B84F")]
		Proto_NONE,
		[Token(Token = "0x400B850")]
		Proto_LEVEL_UP_NTF
	}

	[Token(Token = "0x2001D33")]
	public enum ErrCode
	{
		[Token(Token = "0x400B852")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60087E5")]
	[Address(RVA = "0x33E91F8", Offset = "0x33E91F8", VA = "0x33E91F8")]
	public EPet()
	{
	}
}
