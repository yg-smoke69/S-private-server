using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C65")]
public class EChampionship
{
	[Token(Token = "0x2001C66")]
	public enum Proto
	{
		[Token(Token = "0x400B481")]
		Proto_NONE,
		[Token(Token = "0x400B482")]
		Proto_REQUEST_JOIN_NTF,
		[Token(Token = "0x400B483")]
		Proto_CONFIRM_ADD_NTF,
		[Token(Token = "0x400B484")]
		Proto_REMOVE_MEMBER_NTF,
		[Token(Token = "0x400B485")]
		Proto_INVITE_NTF,
		[Token(Token = "0x400B486")]
		Proto_APPROVE_INVITATION_NTF,
		[Token(Token = "0x400B487")]
		Proto_DISMISS_NTF,
		[Token(Token = "0x400B488")]
		Proto_MATCH_END_NTF,
		[Token(Token = "0x400B489")]
		Proto_FAKE_SUBMIT_NTF,
		[Token(Token = "0x400B48A")]
		Proto_DECLINE_INVITATION_NTF
	}

	[Token(Token = "0x2001C67")]
	public enum ErrCode
	{
		[Token(Token = "0x400B48C")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008316")]
	[Address(RVA = "0x33E8FDC", Offset = "0x33E8FDC", VA = "0x33E8FDC")]
	public EChampionship()
	{
	}
}
