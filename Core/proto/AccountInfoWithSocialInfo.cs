using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D3")]
public class AccountInfoWithSocialInfo
{
	[Token(Token = "0x4008B38")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic account_info_basic;

	[Token(Token = "0x4008B39")]
	[FieldOffset(Offset = "0xC")]
	public SocialBasicInfo social_basic_info;

	[Token(Token = "0x6007AB6")]
	[Address(RVA = "0x317989C", Offset = "0x317989C", VA = "0x317989C")]
	public AccountInfoWithSocialInfo()
	{
	}
}
