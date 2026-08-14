using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200157E")]
public class CSInviteToCupTeamReq
{
	[Token(Token = "0x4009354")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009355")]
	[FieldOffset(Offset = "0x10")]
	public ulong invitee_id;

	[Token(Token = "0x4009356")]
	[FieldOffset(Offset = "0x18")]
	public CupGroupMemberInfo group_member_info;

	[Token(Token = "0x6007BC6")]
	[Address(RVA = "0x3097438", Offset = "0x3097438", VA = "0x3097438")]
	public CSInviteToCupTeamReq()
	{
	}
}
