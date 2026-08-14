using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200156B")]
public class CSGetAllCupConfigRes
{
	[Token(Token = "0x4009312")]
	[FieldOffset(Offset = "0x8")]
	public List<CSGetCupConfigRes> settings;

	[Token(Token = "0x4009313")]
	[FieldOffset(Offset = "0xC")]
	public CupTeamDesc team_setting;

	[Token(Token = "0x4009314")]
	[FieldOffset(Offset = "0x10")]
	public CupRuleDesc rule;

	[Token(Token = "0x6007BB3")]
	[Address(RVA = "0x3181728", Offset = "0x3181728", VA = "0x3181728")]
	public CSGetAllCupConfigRes()
	{
	}
}
