using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001391")]
public class AccountBriefInfo
{
	[Token(Token = "0x40089FE")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic basic_info;

	[Token(Token = "0x40089FF")]
	[FieldOffset(Offset = "0xC")]
	public SocialBasicInfo social_info;

	[Token(Token = "0x6007A8D")]
	[Address(RVA = "0x3179428", Offset = "0x3179428", VA = "0x3179428")]
	public AccountBriefInfo()
	{
	}
}
