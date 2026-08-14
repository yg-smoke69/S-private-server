using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20028DE")]
internal class UIImageSharePreviewWindowController : UIPopupWindowController
{
	[Token(Token = "0x400FB57")]
	[FieldOffset(Offset = "0x48")]
	public Action OnClose;

	[Token(Token = "0x400FB58")]
	[FieldOffset(Offset = "0x4C")]
	private UIImageSharePreviewWindowView m_View;

	[Token(Token = "0x400FB59")]
	[FieldOffset(Offset = "0x50")]
	private ShareSettingDesc m_ShareSetting;

	[Token(Token = "0x400FB5A")]
	[FieldOffset(Offset = "0x54")]
	private UIBaseController m_Target;

	[Token(Token = "0x400FB5B")]
	private const uint HEIGHTOFFSETINPORTRAIT = 24u;

	[Token(Token = "0x400FB5C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] _PhotoPermissions;

	[Token(Token = "0x400FB5D")]
	[FieldOffset(Offset = "0x58")]
	private ShareImageData m_Data;

	[Token(Token = "0x400FB5E")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_ShareUrl;

	[Token(Token = "0x400FB5F")]
	[FieldOffset(Offset = "0x4")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010201")]
	[Address(RVA = "0xD48DC8", Offset = "0xD48DC8", VA = "0xD48DC8")]
	public UIImageSharePreviewWindowController()
	{
	}

	[Token(Token = "0x6010202")]
	[Address(RVA = "0xD48E44", Offset = "0xD48E44", VA = "0xD48E44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010203")]
	[Address(RVA = "0xD48EE8", Offset = "0xD48EE8", VA = "0xD48EE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010204")]
	[Address(RVA = "0xD4A0F0", Offset = "0xD4A0F0", VA = "0xD4A0F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010205")]
	[Address(RVA = "0xD4A2E8", Offset = "0xD4A2E8", VA = "0xD4A2E8")]
	public void OnCloseClick()
	{
	}

	[Token(Token = "0x6010206")]
	[Address(RVA = "0xD4A34C", Offset = "0xD4A34C", VA = "0xD4A34C")]
	public void ShareImage(UIBaseController target, ShareImageData data, bool shareUrl = false)
	{
	}

	[Token(Token = "0x6010207")]
	[Address(RVA = "0xD4A63C", Offset = "0xD4A63C", VA = "0xD4A63C")]
	private void UpdateShareImage()
	{
	}

	[Token(Token = "0x6010208")]
	[Address(RVA = "0xD4AFB8", Offset = "0xD4AFB8", VA = "0xD4AFB8")]
	public void UpdateSharePreview(int width, int height)
	{
	}

	[Token(Token = "0x6010209")]
	[Address(RVA = "0xD49630", Offset = "0xD49630", VA = "0xD49630")]
	private void UpdateUI()
	{
	}

	[Token(Token = "0x601020A")]
	[Address(RVA = "0xD4B0A0", Offset = "0xD4B0A0", VA = "0xD4B0A0")]
	private void OnShareClick(EventLogger.SharePlatform platform)
	{
	}

	[Token(Token = "0x601020B")]
	[Address(RVA = "0xD4CBC4", Offset = "0xD4CBC4", VA = "0xD4CBC4")]
	private void SendLimitedEventShareLog(uint id, uint platform, uint pageId)
	{
	}

	[Token(Token = "0x601020C")]
	[Address(RVA = "0xD4CE14", Offset = "0xD4CE14", VA = "0xD4CE14")]
	private void SendPortraitCloseupShareLog(uint platform)
	{
	}

	[Token(Token = "0x601020D")]
	[Address(RVA = "0xD4B428", Offset = "0xD4B428", VA = "0xD4B428")]
	private bool OnShareLineBtnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x601020E")]
	[Address(RVA = "0xD4C448", Offset = "0xD4C448", VA = "0xD4C448")]
	private bool OnShareVKBtnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x601020F")]
	[Address(RVA = "0xD4C724", Offset = "0xD4C724", VA = "0xD4C724")]
	private bool OnOtherShareBtnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6010210")]
	[Address(RVA = "0xD4B9EC", Offset = "0xD4B9EC", VA = "0xD4B9EC")]
	private bool OnShareFBBtnClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6010211")]
	[Address(RVA = "0xD4D448", Offset = "0xD4D448", VA = "0xD4D448")]
	public void OnDownloadToAlbumBtnClick()
	{
	}

	[Token(Token = "0x6010212")]
	[Address(RVA = "0xD4D838", Offset = "0xD4D838", VA = "0xD4D838")]
	private void OnImageSaveToAlbumDone(string error)
	{
	}

	[Token(Token = "0x6010213")]
	[Address(RVA = "0xD4DEEC", Offset = "0xD4DEEC", VA = "0xD4DEEC")]
	private void OnCopyLink()
	{
	}

	[Token(Token = "0x6010214")]
	[Address(RVA = "0xD4D01C", Offset = "0xD4D01C", VA = "0xD4D01C")]
	private void DoneShare(bool success, EventLogger.SharePlatform sharePlatform)
	{
	}

	[Token(Token = "0x6010216")]
	[Address(RVA = "0xD4E534", Offset = "0xD4E534", VA = "0xD4E534")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6010217")]
	[Address(RVA = "0xD4E53C", Offset = "0xD4E53C", VA = "0xD4E53C")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x6010218")]
	[Address(RVA = "0xD4E544", Offset = "0xD4E544", VA = "0xD4E544")]
	private void _003COnUIInit_003Em__2()
	{
	}

	[Token(Token = "0x6010219")]
	[Address(RVA = "0xD4E54C", Offset = "0xD4E54C", VA = "0xD4E54C")]
	private void _003COnUIInit_003Em__3()
	{
	}

	[Token(Token = "0x601021A")]
	[Address(RVA = "0xD4E554", Offset = "0xD4E554", VA = "0xD4E554")]
	private void _003COnUIInit_003Em__4()
	{
	}

	[Token(Token = "0x601021B")]
	[Address(RVA = "0xD4E55C", Offset = "0xD4E55C", VA = "0xD4E55C")]
	private void _003COnUIInit_003Em__5()
	{
	}

	[Token(Token = "0x601021C")]
	[Address(RVA = "0xD4E564", Offset = "0xD4E564", VA = "0xD4E564")]
	private void _003COnUIInit_003Em__6()
	{
	}

	[Token(Token = "0x601021D")]
	[Address(RVA = "0xD4E56C", Offset = "0xD4E56C", VA = "0xD4E56C")]
	private void _003COnUIInit_003Em__7()
	{
	}

	[Token(Token = "0x601021E")]
	[Address(RVA = "0xD4E574", Offset = "0xD4E574", VA = "0xD4E574")]
	private static void _003CDoneShare_003Em__8(HttpErrorCode errCode, object obj)
	{
	}

	[Token(Token = "0x601021F")]
	[Address(RVA = "0xD4E578", Offset = "0xD4E578", VA = "0xD4E578")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010220")]
	[Address(RVA = "0xD4E580", Offset = "0xD4E580", VA = "0xD4E580")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
