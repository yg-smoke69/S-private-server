using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C7B")]
public class EChat
{
	[Token(Token = "0x2001C7C")]
	public enum Proto
	{
		[Token(Token = "0x400B4EC")]
		Proto_NONE,
		[Token(Token = "0x400B4ED")]
		Proto_REPORT_CHAT,
		[Token(Token = "0x400B4EE")]
		Proto_LIKE_MSG
	}

	[Token(Token = "0x2001C7D")]
	public enum ErrCode
	{
		[Token(Token = "0x400B4F0")]
		ErrCode_NONE,
		[Token(Token = "0x400B4F1")]
		ErrCode_ALREADY_MUTED,
		[Token(Token = "0x400B4F2")]
		ErrCode_LIKEMSGLIMIT
	}

	[Token(Token = "0x6008387")]
	[Address(RVA = "0x33E8FEC", Offset = "0x33E8FEC", VA = "0x33E8FEC")]
	public EChat()
	{
	}
}
