using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C1E")]
internal class UIWebViewWindowBaseController : UIPopupSpecialWindowController
{
	[Token(Token = "0x4010D71")]
	[FieldOffset(Offset = "0x48")]
	public Action CloseCallBack;

	[Token(Token = "0x4010D72")]
	[FieldOffset(Offset = "0x4C")]
	protected WebView m_WebView;

	[Token(Token = "0x60125B3")]
	[Address(RVA = "0x1B7CBB0", Offset = "0x1B7CBB0", VA = "0x1B7CBB0")]
	public UIWebViewWindowBaseController()
	{
	}

	[Token(Token = "0x60125B4")]
	[Address(RVA = "0x1B7D508", Offset = "0x1B7D508", VA = "0x1B7D508")]
	protected void OpenNativeWebView(string url, WebView.Rect rect, bool forcePlay = false)
	{
	}

	[Token(Token = "0x60125B5")]
	[Address(RVA = "0x1B7CDC4", Offset = "0x1B7CDC4", VA = "0x1B7CDC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60125B6")]
	[Address(RVA = "0x1B7DD64", Offset = "0x1B7DD64", VA = "0x1B7DD64", Slot = "29")]
	public override void OnShare(bool success, int platform)
	{
	}

	[Token(Token = "0x60125B7")]
	[Address(RVA = "0x1B7D0F0", Offset = "0x1B7D0F0", VA = "0x1B7D0F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60125B8")]
	[Address(RVA = "0x1B7DE18", Offset = "0x1B7DE18", VA = "0x1B7DE18", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60125B9")]
	[Address(RVA = "0x1B7D7FC", Offset = "0x1B7D7FC", VA = "0x1B7D7FC", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60125BA")]
	[Address(RVA = "0x1B7DE7C", Offset = "0x1B7DE7C", VA = "0x1B7DE7C", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x60125BB")]
	[Address(RVA = "0x1B7E118", Offset = "0x1B7E118", VA = "0x1B7E118")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60125BC")]
	[Address(RVA = "0x1B7E120", Offset = "0x1B7E120", VA = "0x1B7E120")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x60125BD")]
	[Address(RVA = "0x1B7E128", Offset = "0x1B7E128", VA = "0x1B7E128")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60125BE")]
	[Address(RVA = "0x1B7E130", Offset = "0x1B7E130", VA = "0x1B7E130")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60125BF")]
	[Address(RVA = "0x1B7E138", Offset = "0x1B7E138", VA = "0x1B7E138")]
	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	[Token(Token = "0x60125C0")]
	[Address(RVA = "0x1B7E140", Offset = "0x1B7E140", VA = "0x1B7E140")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
