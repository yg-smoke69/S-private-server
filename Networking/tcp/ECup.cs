using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA3")]
public class ECup
{
	[Token(Token = "0x2001CA4")]
	public enum Proto
	{
		[Token(Token = "0x400B55B")]
		Proto_NONE,
		[Token(Token = "0x400B55C")]
		Proto_REQUEST_JOIN_NTF,
		[Token(Token = "0x400B55D")]
		Proto_CONFIRM_ADD_NTF,
		[Token(Token = "0x400B55E")]
		Proto_REMOVE_MEMBER_NTF,
		[Token(Token = "0x400B55F")]
		Proto_INVITE_NTF,
		[Token(Token = "0x400B560")]
		Proto_APPROVE_INVITATION_NTF,
		[Token(Token = "0x400B561")]
		Proto_DISMISS_NTF,
		[Token(Token = "0x400B562")]
		Proto_TEAM_MATCH_END_NTF,
		[Token(Token = "0x400B563")]
		Proto_LOCK_TEAM
	}

	[Token(Token = "0x2001CA5")]
	public enum ErrCode
	{
		[Token(Token = "0x400B565")]
		ErrCode_SUSS
	}

	[Token(Token = "0x600842D")]
	[Address(RVA = "0x33E9014", Offset = "0x33E9014", VA = "0x33E9014")]
	public ECup()
	{
	}
}
