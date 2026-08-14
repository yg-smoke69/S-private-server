using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D2D")]
public class EMiniGame
{
	[Token(Token = "0x2001D2E")]
	public enum Proto
	{
		[Token(Token = "0x400B847")]
		Proto_NONE = 0,
		[Token(Token = "0x400B848")]
		Proto_RAMPAGE_HYPER_UPDATE_NTF = 2
	}

	[Token(Token = "0x2001D2F")]
	public enum ErrCode
	{
		[Token(Token = "0x400B84A")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60087DD")]
	[Address(RVA = "0x33E9084", Offset = "0x33E9084", VA = "0x33E9084")]
	public EMiniGame()
	{
	}
}
