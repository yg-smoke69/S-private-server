using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001585")]
public class CSApproveInviteToCupTeamReq
{
	[Token(Token = "0x4009365")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009366")]
	[FieldOffset(Offset = "0x10")]
	public ulong inviter_id;

	[Token(Token = "0x6007BCD")]
	[Address(RVA = "0x317DC84", Offset = "0x317DC84", VA = "0x317DC84")]
	public CSApproveInviteToCupTeamReq()
	{
	}
}
