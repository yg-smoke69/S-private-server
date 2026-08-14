using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001588")]
public class CSCupTeamApplicantList
{
	[Token(Token = "0x400936F")]
	[FieldOffset(Offset = "0x8")]
	public List<CupTeamApplicantRes> cup_team_applicant_list;

	[Token(Token = "0x6007BD0")]
	[Address(RVA = "0x317F3A4", Offset = "0x317F3A4", VA = "0x317F3A4")]
	public CSCupTeamApplicantList()
	{
	}
}
