using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001429")]
public class ECup
{
	[Token(Token = "0x200142A")]
	public enum MemberType
	{
		[Token(Token = "0x4008C77")]
		MemberType_NONE,
		[Token(Token = "0x4008C78")]
		MemberType_NORMAL_MEMBER,
		[Token(Token = "0x4008C79")]
		MemberType_CAPTAIN
	}

	[Token(Token = "0x200142B")]
	public enum TeamUserChangeType
	{
		[Token(Token = "0x4008C7B")]
		TeamUserChangeType_NONE,
		[Token(Token = "0x4008C7C")]
		TeamUserChangeType_REQUEST,
		[Token(Token = "0x4008C7D")]
		TeamUserChangeType_APPROVE_APPLICATION,
		[Token(Token = "0x4008C7E")]
		TeamUserChangeType_INVITE,
		[Token(Token = "0x4008C7F")]
		TeamUserChangeType_APPROVE_INVITATION,
		[Token(Token = "0x4008C80")]
		TeamUserChangeType_REMOVE,
		[Token(Token = "0x4008C81")]
		TeamUserChangeType_QUIT,
		[Token(Token = "0x4008C82")]
		TeamUserChangeType_WORLD_INVITATION
	}

	[Token(Token = "0x6007AE6")]
	[Address(RVA = "0x309F2B0", Offset = "0x309F2B0", VA = "0x309F2B0")]
	public ECup()
	{
	}
}
