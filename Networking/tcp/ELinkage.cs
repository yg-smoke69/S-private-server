using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D0B")]
public class ELinkage
{
	[Token(Token = "0x2001D0C")]
	public enum Proto
	{
		[Token(Token = "0x400B78E")]
		Proto_NONE,
		[Token(Token = "0x400B78F")]
		Proto_UPDATE_NTF
	}

	[Token(Token = "0x2001D0D")]
	public enum ErrCode
	{
		[Token(Token = "0x400B791")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008701")]
	[Address(RVA = "0x33E905C", Offset = "0x33E905C", VA = "0x33E905C")]
	public ELinkage()
	{
	}
}
