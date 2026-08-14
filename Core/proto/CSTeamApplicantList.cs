using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001780")]
public class CSTeamApplicantList
{
	[Token(Token = "0x4009A61")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamApplicantRes> team_applicant_list;

	[Token(Token = "0x6007DDA")]
	[Address(RVA = "0x309A03C", Offset = "0x309A03C", VA = "0x309A03C")]
	public CSTeamApplicantList()
	{
	}
}
