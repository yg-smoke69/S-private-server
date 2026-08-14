using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001726")]
public class LoginSplashRes
{
	[Token(Token = "0x4009928")]
	[FieldOffset(Offset = "0x8")]
	public CSAnnouncementRes accouncement_res;

	[Token(Token = "0x4009929")]
	[FieldOffset(Offset = "0xC")]
	public SplashBannerDescList splash_res;

	[Token(Token = "0x400992A")]
	[FieldOffset(Offset = "0x10")]
	public CSGetActivityInfoRes activity_info_res;

	[Token(Token = "0x6007D80")]
	[Address(RVA = "0x30A6E18", Offset = "0x30A6E18", VA = "0x30A6E18")]
	public LoginSplashRes()
	{
	}
}
