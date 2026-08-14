using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200158B")]
public class CSGetCupTeamInvitationListRes
{
	[Token(Token = "0x4009375")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasicBundleRes members_info;

	[Token(Token = "0x4009376")]
	[FieldOffset(Offset = "0xC")]
	public CSCupTeamInvitationList members_cup_info;

	[Token(Token = "0x6007BD3")]
	[Address(RVA = "0x3183740", Offset = "0x3183740", VA = "0x3183740")]
	public CSGetCupTeamInvitationListRes()
	{
	}
}
