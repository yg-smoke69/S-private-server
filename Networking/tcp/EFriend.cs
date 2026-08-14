using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CBB")]
public class EFriend
{
	[Token(Token = "0x2001CBC")]
	public enum Proto
	{
		[Token(Token = "0x400B5B3")]
		Proto_NONE,
		[Token(Token = "0x400B5B4")]
		Proto_REQUEST_NTF,
		[Token(Token = "0x400B5B5")]
		Proto_CONFIRM_NTF,
		[Token(Token = "0x400B5B6")]
		Proto_REMOVE_NTF,
		[Token(Token = "0x400B5B7")]
		Proto_RELATED_FRIEND_ONLINE,
		[Token(Token = "0x400B5B8")]
		Proto_RELATED_FRIEND_REQUEST_NTF,
		[Token(Token = "0x400B5B9")]
		Proto_RELATED_FRIEND_CONFIRM_NTF,
		[Token(Token = "0x400B5BA")]
		Proto_RELATED_FRIEND_DECLINE_NTF,
		[Token(Token = "0x400B5BB")]
		Proto_RELATED_FRIEND_REQUEST_EXPIRE_NTF,
		[Token(Token = "0x400B5BC")]
		Proto_INTIMACY_CHANGE_NTF
	}

	[Token(Token = "0x2001CBD")]
	public enum ErrCode
	{
		[Token(Token = "0x400B5BE")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60084BD")]
	[Address(RVA = "0x33E902C", Offset = "0x33E902C", VA = "0x33E902C")]
	public EFriend()
	{
	}
}
