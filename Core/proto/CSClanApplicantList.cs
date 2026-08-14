using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001623")]
public class CSClanApplicantList
{
	[Token(Token = "0x400953D")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanApplicantRes> clan_applicant_list;

	[Token(Token = "0x6007C6D")]
	[Address(RVA = "0x317EA34", Offset = "0x317EA34", VA = "0x317EA34")]
	public CSClanApplicantList()
	{
	}
}
