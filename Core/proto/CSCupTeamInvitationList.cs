using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001586")]
public class CSCupTeamInvitationList
{
	[Token(Token = "0x4009367")]
	[FieldOffset(Offset = "0x8")]
	public List<CupTeamInvitationRes> cup_team_invitation_list;

	[Token(Token = "0x6007BCE")]
	[Address(RVA = "0x317F440", Offset = "0x317F440", VA = "0x317F440")]
	public CSCupTeamInvitationList()
	{
	}
}
