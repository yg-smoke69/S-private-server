using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001663")]
public class CSGetClanWarTeamMemberStatusRes
{
	[Token(Token = "0x4009615")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanWarMemberStatus> clan_war_member_status;

	[Token(Token = "0x6007CAD")]
	[Address(RVA = "0x3183294", Offset = "0x3183294", VA = "0x3183294")]
	public CSGetClanWarTeamMemberStatusRes()
	{
	}
}
