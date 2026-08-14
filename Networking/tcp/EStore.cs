using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D78")]
public class EStore
{
	[Token(Token = "0x2001D79")]
	public enum Proto
	{
		[Token(Token = "0x400B9FF")]
		Proto_NONE,
		[Token(Token = "0x400BA00")]
		Proto_IAP_PURCHASE_DONE,
		[Token(Token = "0x400BA01")]
		Proto_PBW_PURCHASE_DONE,
		[Token(Token = "0x400BA02")]
		Proto_IAP_INFO_CHANGE
	}

	[Token(Token = "0x2001D7A")]
	public enum ErrCode
	{
		[Token(Token = "0x400BA04")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008A1F")]
	[Address(RVA = "0x33E9230", Offset = "0x33E9230", VA = "0x33E9230")]
	public EStore()
	{
	}
}
