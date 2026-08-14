using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CB6")]
public class EFresh
{
	[Token(Token = "0x2001CB7")]
	public enum Proto
	{
		[Token(Token = "0x400B5AA")]
		Proto_NONE,
		[Token(Token = "0x400B5AB")]
		Proto_UPDATE_NTF
	}

	[Token(Token = "0x2001CB8")]
	public enum ErrCode
	{
		[Token(Token = "0x400B5AD")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60084B2")]
	[Address(RVA = "0x33E9024", Offset = "0x33E9024", VA = "0x33E9024")]
	public EFresh()
	{
	}
}
