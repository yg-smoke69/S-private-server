using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D3C")]
public class EProfile
{
	[Token(Token = "0x2001D3D")]
	public enum Proto
	{
		[Token(Token = "0x400B870")]
		Proto_NONE,
		[Token(Token = "0x400B871")]
		Proto_NEW_PROFILE_NTF,
		[Token(Token = "0x400B872")]
		Proto_NEW_SKILL_NTF,
		[Token(Token = "0x400B873")]
		Proto_PROFILE_CHANGE_NTF,
		[Token(Token = "0x400B874")]
		Proto_AWAKEN_TASK_CHANGE_NTF,
		[Token(Token = "0x400B875")]
		Proto_AWARD_GAME_LINK_NTF
	}

	[Token(Token = "0x2001D3E")]
	public enum ErrCode
	{
		[Token(Token = "0x400B877")]
		ErrCode_SUSS
	}

	[Token(Token = "0x6008811")]
	[Address(RVA = "0x33E9208", Offset = "0x33E9208", VA = "0x33E9208")]
	public EProfile()
	{
	}
}
