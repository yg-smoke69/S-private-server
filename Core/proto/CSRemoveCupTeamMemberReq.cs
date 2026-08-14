using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001580")]
public class CSRemoveCupTeamMemberReq
{
	[Token(Token = "0x4009359")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400935A")]
	[FieldOffset(Offset = "0x10")]
	public ulong removee_id;

	[Token(Token = "0x6007BC8")]
	[Address(RVA = "0x3099100", Offset = "0x3099100", VA = "0x3099100")]
	public CSRemoveCupTeamMemberReq()
	{
	}
}
