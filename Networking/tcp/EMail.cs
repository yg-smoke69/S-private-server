using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D10")]
public class EMail
{
	[Token(Token = "0x2001D11")]
	public enum Proto
	{
		[Token(Token = "0x400B798")]
		Proto_NONE,
		[Token(Token = "0x400B799")]
		Proto_PUSH_NTF,
		[Token(Token = "0x400B79A")]
		Proto_PUSH_REPORT_NTF
	}

	[Token(Token = "0x2001D12")]
	public enum ErrCode
	{
		[Token(Token = "0x400B79C")]
		ErrCode_SUSS
	}

	[Token(Token = "0x600870E")]
	[Address(RVA = "0x33E9064", Offset = "0x33E9064", VA = "0x33E9064")]
	public EMail()
	{
	}
}
