using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200158C")]
public class CSGetCupTeamApplicantListRes
{
	[Token(Token = "0x4009377")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasicBundleRes members_info;

	[Token(Token = "0x4009378")]
	[FieldOffset(Offset = "0xC")]
	public CSCupTeamApplicantList members_cup_info;

	[Token(Token = "0x6007BD4")]
	[Address(RVA = "0x318369C", Offset = "0x318369C", VA = "0x318369C")]
	public CSGetCupTeamApplicantListRes()
	{
	}
}
