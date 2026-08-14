using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CAF")]
public class EElitePass
{
	[Token(Token = "0x2001CB0")]
	public enum Proto
	{
		[Token(Token = "0x400B592")]
		Proto_NONE,
		[Token(Token = "0x400B593")]
		Proto_CHALLENGE_COMPLETE_NTF,
		[Token(Token = "0x400B594")]
		Proto_ACCOUNT_EP_LEVEL_UP,
		[Token(Token = "0x400B595")]
		Proto_QUEST_COMPLETE_NTF,
		[Token(Token = "0x400B596")]
		Proto_CHALLENGE_UPDATE_NTF
	}

	[Token(Token = "0x2001CB1")]
	public enum ErrCode
	{
		[Token(Token = "0x400B598")]
		ErrCode_SUSS
	}

	[Token(Token = "0x600848D")]
	[Address(RVA = "0x33E901C", Offset = "0x33E901C", VA = "0x33E901C")]
	public EElitePass()
	{
	}
}
