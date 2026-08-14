using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B58")]
internal class UISplashBannerItemLiveTVController : UIWebViewWindowBaseController
{
	[Token(Token = "0x40109A7")]
	[FieldOffset(Offset = "0x50")]
	private UISplashBannerItemLiveTVView m_View;

	[Token(Token = "0x40109A8")]
	[FieldOffset(Offset = "0x54")]
	private SplashBannerInfo m_SplashBannerInfo;

	[Token(Token = "0x40109A9")]
	[FieldOffset(Offset = "0x58")]
	public Action<bool> m_UICloseCallBack;

	[Token(Token = "0x40109AA")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_WillGotoNavigation;

	[Token(Token = "0x40109AB")]
	[FieldOffset(Offset = "0x60")]
	public ulong m_StartShowTime;

	[Token(Token = "0x6011DAE")]
	[Address(RVA = "0x205CFFC", Offset = "0x205CFFC", VA = "0x205CFFC")]
	public UISplashBannerItemLiveTVController()
	{
	}

	[Token(Token = "0x6011DAF")]
	[Address(RVA = "0x205D004", Offset = "0x205D004", VA = "0x205D004")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011DB0")]
	[Address(RVA = "0x205D0A8", Offset = "0x205D0A8", VA = "0x205D0A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011DB1")]
	[Address(RVA = "0x205D66C", Offset = "0x205D66C", VA = "0x205D66C")]
	public void SetData(SplashBannerInfo info)
	{
	}

	[Token(Token = "0x6011DB2")]
	[Address(RVA = "0x205D9F8", Offset = "0x205D9F8", VA = "0x205D9F8")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6011DB3")]
	[Address(RVA = "0x205DF68", Offset = "0x205DF68", VA = "0x205DF68")]
	private void OnScaleTweenFinish()
	{
	}

	[Token(Token = "0x6011DB4")]
	[Address(RVA = "0x205DFCC", Offset = "0x205DFCC", VA = "0x205DFCC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011DB5")]
	[Address(RVA = "0x205E18C", Offset = "0x205E18C", VA = "0x205E18C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011DB6")]
	[Address(RVA = "0x205E1F0", Offset = "0x205E1F0", VA = "0x205E1F0", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011DB7")]
	[Address(RVA = "0x205E248", Offset = "0x205E248", VA = "0x205E248")]
	private void OnGotoNavigation()
	{
	}

	[Token(Token = "0x6011DB8")]
	[Address(RVA = "0x205E464", Offset = "0x205E464", VA = "0x205E464")]
	private void OnPlayFullScreen()
	{
	}

	[Token(Token = "0x6011DB9")]
	[Address(RVA = "0x205E5E4", Offset = "0x205E5E4", VA = "0x205E5E4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011DBA")]
	[Address(RVA = "0x205E5EC", Offset = "0x205E5EC", VA = "0x205E5EC")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011DBB")]
	[Address(RVA = "0x205E5F4", Offset = "0x205E5F4", VA = "0x205E5F4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011DBC")]
	[Address(RVA = "0x205E5FC", Offset = "0x205E5FC", VA = "0x205E5FC")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
