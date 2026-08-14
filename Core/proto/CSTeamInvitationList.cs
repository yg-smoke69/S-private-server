using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001782")]
public class CSTeamInvitationList
{
	[Token(Token = "0x4009A65")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamInvitationRes> team_invitation_list;

	[Token(Token = "0x6007DDC")]
	[Address(RVA = "0x309A208", Offset = "0x309A208", VA = "0x309A208")]
	public CSTeamInvitationList()
	{
	}
}
