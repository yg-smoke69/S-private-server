using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001925")]
public class CSHelpJumpsuitFriendReq
{
	[Token(Token = "0x4009EE1")]
	[FieldOffset(Offset = "0x8")]
	public ulong helpee_id;

	[Token(Token = "0x4009EE2")]
	[FieldOffset(Offset = "0x10")]
	public string helper_name;

	[Token(Token = "0x4009EE3")]
	[FieldOffset(Offset = "0x14")]
	public ELimitedEvent.JumpsuitJoinType join_type;

	[Token(Token = "0x6007F7E")]
	[Address(RVA = "0x3097058", Offset = "0x3097058", VA = "0x3097058")]
	public CSHelpJumpsuitFriendReq()
	{
	}
}
