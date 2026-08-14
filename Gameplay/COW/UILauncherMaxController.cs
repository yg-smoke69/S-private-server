using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028EC")]
public class UILauncherMaxController : UIPopupSpecialWindowController
{
	[Token(Token = "0x400FBA3")]
	[FieldOffset(Offset = "0x48")]
	private UILauncherMaxView m_View;

	[Token(Token = "0x400FBA4")]
	[FieldOffset(Offset = "0x4C")]
	private string m_MaxStore;

	[Token(Token = "0x400FBA5")]
	[FieldOffset(Offset = "0x50")]
	private string m_MaxWebsite;

	[Token(Token = "0x400FBA6")]
	[FieldOffset(Offset = "0x54")]
	private string m_MaxVideo;

	[Token(Token = "0x400FBA7")]
	[FieldOffset(Offset = "0x58")]
	protected Action m_OnClose;

	[Token(Token = "0x400FBA8")]
	private const string BG_CDN_URL = "https://freefiremobile-a.akamaihd.net/common/OB23/version/Patch_Max_Bg_<FF_LANGUAGE>.png";

	[Token(Token = "0x60102B5")]
	[Address(RVA = "0x1A83744", Offset = "0x1A83744", VA = "0x1A83744")]
	public UILauncherMaxController()
	{
	}

	[Token(Token = "0x60102B6")]
	[Address(RVA = "0x1A8374C", Offset = "0x1A8374C", VA = "0x1A8374C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102B7")]
	[Address(RVA = "0x1A83A78", Offset = "0x1A83A78", VA = "0x1A83A78")]
	private void OnGotoVideoBtnClick()
	{
	}

	[Token(Token = "0x60102B8")]
	[Address(RVA = "0x1A83FEC", Offset = "0x1A83FEC", VA = "0x1A83FEC")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x60102B9")]
	[Address(RVA = "0x1A8406C", Offset = "0x1A8406C", VA = "0x1A8406C")]
	public void SetOnClose(Action onclose)
	{
	}

	[Token(Token = "0x60102BA")]
	[Address(RVA = "0x1A840CC", Offset = "0x1A840CC", VA = "0x1A840CC")]
	public void SetInfo(string max_store, string max_web, string max_video)
	{
	}

	[Token(Token = "0x60102BB")]
	[Address(RVA = "0x1A8434C", Offset = "0x1A8434C", VA = "0x1A8434C")]
	private void OnGotoWebsiteBtnClick()
	{
	}

	[Token(Token = "0x60102BC")]
	[Address(RVA = "0x1A843B0", Offset = "0x1A843B0", VA = "0x1A843B0")]
	private void OnNormalUpdateBtnClick()
	{
	}

	[Token(Token = "0x60102BD")]
	[Address(RVA = "0x1A84478", Offset = "0x1A84478", VA = "0x1A84478")]
	private void OnMaxDownloadBtnClick()
	{
	}

	[Token(Token = "0x60102BE")]
	[Address(RVA = "0x1A83AFC", Offset = "0x1A83AFC", VA = "0x1A83AFC")]
	private UILauncherWebViewLiteController CreateVideoWebView()
	{
		return null;
	}

	[Token(Token = "0x60102BF")]
	[Address(RVA = "0x1A844DC", Offset = "0x1A844DC", VA = "0x1A844DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
