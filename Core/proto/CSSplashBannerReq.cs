using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016BD")]
public class CSSplashBannerReq
{
	[Token(Token = "0x40096DA")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x40096DB")]
	[FieldOffset(Offset = "0xC")]
	public EAnnouncement.Os os;

	[Token(Token = "0x40096DC")]
	[FieldOffset(Offset = "0x10")]
	public EAnnouncement.AndroidChannel android_channel;

	[Token(Token = "0x6007D1E")]
	[Address(RVA = "0x3099DF4", Offset = "0x3099DF4", VA = "0x3099DF4")]
	public CSSplashBannerReq()
	{
	}
}
