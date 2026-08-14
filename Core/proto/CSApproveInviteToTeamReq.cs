using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200178F")]
public class CSApproveInviteToTeamReq
{
	[Token(Token = "0x4009A92")]
	[FieldOffset(Offset = "0x8")]
	public ulong inviter_id;

	[Token(Token = "0x4009A93")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007DE9")]
	[Address(RVA = "0x317DC8C", Offset = "0x317DC8C", VA = "0x317DC8C")]
	public CSApproveInviteToTeamReq()
	{
	}
}
