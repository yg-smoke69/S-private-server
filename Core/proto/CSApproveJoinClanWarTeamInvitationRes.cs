using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001665")]
public class CSApproveJoinClanWarTeamInvitationRes
{
	[Token(Token = "0x4009617")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanWarTeamMemberInfo> members_info;

	[Token(Token = "0x6007CAF")]
	[Address(RVA = "0x317DC9C", Offset = "0x317DC9C", VA = "0x317DC9C")]
	public CSApproveJoinClanWarTeamInvitationRes()
	{
	}
}
