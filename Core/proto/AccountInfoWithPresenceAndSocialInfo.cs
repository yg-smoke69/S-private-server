using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D4")]
public class AccountInfoWithPresenceAndSocialInfo
{
	[Token(Token = "0x4008B3A")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoWithPresence account_info_with_presence;

	[Token(Token = "0x4008B3B")]
	[FieldOffset(Offset = "0xC")]
	public SocialBasicInfo social_basic_info;

	[Token(Token = "0x6007AB7")]
	[Address(RVA = "0x3179894", Offset = "0x3179894", VA = "0x3179894")]
	public AccountInfoWithPresenceAndSocialInfo()
	{
	}
}
