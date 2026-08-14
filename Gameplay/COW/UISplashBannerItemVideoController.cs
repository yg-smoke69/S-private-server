using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B59")]
internal class UISplashBannerItemVideoController : UIWebViewWindowBaseController
{
	[Token(Token = "0x40109AC")]
	[FieldOffset(Offset = "0x50")]
	private UISplashBannerItemVideoView m_View;

	[Token(Token = "0x40109AD")]
	[FieldOffset(Offset = "0x54")]
	private SplashBannerInfo m_SplashBannerInfo;

	[Token(Token = "0x40109AE")]
	[FieldOffset(Offset = "0x58")]
	public Action<bool> m_UICloseCallBack;

	[Token(Token = "0x40109AF")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_WillGotoNavigation;

	[Token(Token = "0x40109B0")]
	[FieldOffset(Offset = "0x60")]
	public ulong m_StartShowTime;

	[Token(Token = "0x6011DBD")]
	[Address(RVA = "0x205ED44", Offset = "0x205ED44", VA = "0x205ED44")]
	public UISplashBannerItemVideoController()
	{
	}

	[Token(Token = "0x6011DBE")]
	[Address(RVA = "0x205ED4C", Offset = "0x205ED4C", VA = "0x205ED4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011DBF")]
	[Address(RVA = "0x205EDF0", Offset = "0x205EDF0", VA = "0x205EDF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011DC0")]
	[Address(RVA = "0x205F0D8", Offset = "0x205F0D8", VA = "0x205F0D8")]
	public void SetData(SplashBannerInfo info)
	{
	}

	[Token(Token = "0x6011DC1")]
	[Address(RVA = "0x205F21C", Offset = "0x205F21C", VA = "0x205F21C")]
	public void OnTweenFinish()
	{
	}

	[Token(Token = "0x6011DC2")]
	[Address(RVA = "0x205F32C", Offset = "0x205F32C", VA = "0x205F32C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011DC3")]
	[Address(RVA = "0x205F4EC", Offset = "0x205F4EC", VA = "0x205F4EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011DC4")]
	[Address(RVA = "0x205F550", Offset = "0x205F550", VA = "0x205F550", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011DC5")]
	[Address(RVA = "0x205F5A8", Offset = "0x205F5A8", VA = "0x205F5A8")]
	private void OnGotoNavigation()
	{
	}

	[Token(Token = "0x6011DC6")]
	[Address(RVA = "0x205F7C4", Offset = "0x205F7C4", VA = "0x205F7C4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011DC7")]
	[Address(RVA = "0x205F7CC", Offset = "0x205F7CC", VA = "0x205F7CC")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011DC8")]
	[Address(RVA = "0x205F7D4", Offset = "0x205F7D4", VA = "0x205F7D4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011DC9")]
	[Address(RVA = "0x205F7DC", Offset = "0x205F7DC", VA = "0x205F7DC")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
