using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E46")]
public class AutoPopupSplashBannerTask : AutoPopupTask
{
	[Token(Token = "0x400BF22")]
	[FieldOffset(Offset = "0x8")]
	private SplashBannerInfo m_NextBannerInfo;

	[Token(Token = "0x400BF23")]
	[FieldOffset(Offset = "0xC")]
	private bool m_AllSplashUIClose;

	[Token(Token = "0x600917C")]
	[Address(RVA = "0x10E7748", Offset = "0x10E7748", VA = "0x10E7748")]
	public AutoPopupSplashBannerTask()
	{
	}

	[Token(Token = "0x600917D")]
	[Address(RVA = "0x10E7758", Offset = "0x10E7758", VA = "0x10E7758", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600917E")]
	[Address(RVA = "0x10E7840", Offset = "0x10E7840", VA = "0x10E7840", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600917F")]
	[Address(RVA = "0x10E7F64", Offset = "0x10E7F64", VA = "0x10E7F64", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009180")]
	[Address(RVA = "0x10E83B4", Offset = "0x10E83B4", VA = "0x10E83B4")]
	private void OnSplashBannerItemClose(bool lateShow = false)
	{
	}

	[Token(Token = "0x6009181")]
	[Address(RVA = "0x10E798C", Offset = "0x10E798C", VA = "0x10E798C")]
	private void ShowSplashBannerItem(SplashBannerInfo info)
	{
	}
}
