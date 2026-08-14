using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200158E")]
public class CupTeamMemberWithAccountInfo
{
	[Token(Token = "0x400937A")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic basic_info;

	[Token(Token = "0x400937B")]
	[FieldOffset(Offset = "0xC")]
	public CSAccountCupInfoRes cup_info;

	[Token(Token = "0x6007BD6")]
	[Address(RVA = "0x309DF98", Offset = "0x309DF98", VA = "0x309DF98")]
	public CupTeamMemberWithAccountInfo()
	{
	}
}
