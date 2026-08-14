using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C44")]
public class EAccount
{
	[Token(Token = "0x2001C45")]
	public enum Proto
	{
		[Token(Token = "0x400B424")]
		Proto_NONE,
		[Token(Token = "0x400B425")]
		Proto_MULTILOGIN_NTF,
		[Token(Token = "0x400B426")]
		Proto_INVALID_CLIENT_VERSION_NTF,
		[Token(Token = "0x400B427")]
		Proto_ACCOUNT_IN_BLACKLIST_NTF,
		[Token(Token = "0x400B428")]
		Proto_ACCOUNT_LEVEL_UP_NTF,
		[Token(Token = "0x400B429")]
		Proto_ACCOUNT_ROLE_CHANGED_NTF,
		[Token(Token = "0x400B42A")]
		Proto_ACCOUNT_DELETED_NTF
	}

	[Token(Token = "0x2001C46")]
	public enum ErrCode
	{
		[Token(Token = "0x400B42C")]
		ErrCode_SUSS
	}

	[Token(Token = "0x600829B")]
	[Address(RVA = "0x33E8FBC", Offset = "0x33E8FBC", VA = "0x33E8FBC")]
	public EAccount()
	{
	}
}
