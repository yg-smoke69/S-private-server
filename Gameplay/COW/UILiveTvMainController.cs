using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200290A")]
public class UILiveTvMainController : UINavigationController
{
	[Token(Token = "0x400FCBE")]
	[FieldOffset(Offset = "0x68")]
	private UILiveTvView m_View;

	[Token(Token = "0x400FCBF")]
	[FieldOffset(Offset = "0x6C")]
	private WebView m_WebViewLiveTV;

	[Token(Token = "0x400FCC0")]
	[FieldOffset(Offset = "0x70")]
	private WebView m_WebViewBooyahTv;

	[Token(Token = "0x400FCC1")]
	[FieldOffset(Offset = "0x74")]
	private WebView.Rect m_WebViewRect;

	[Token(Token = "0x6010441")]
	[Address(RVA = "0x255B4A4", Offset = "0x255B4A4", VA = "0x255B4A4")]
	public UILiveTvMainController()
	{
	}

	[Token(Token = "0x6010442")]
	[Address(RVA = "0x255B528", Offset = "0x255B528", VA = "0x255B528")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010443")]
	[Address(RVA = "0x255B5CC", Offset = "0x255B5CC", VA = "0x255B5CC", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6010444")]
	[Address(RVA = "0x255B624", Offset = "0x255B624", VA = "0x255B624", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010445")]
	[Address(RVA = "0x255C01C", Offset = "0x255C01C", VA = "0x255C01C", Slot = "29")]
	public override void OnShare(bool success, int platform)
	{
	}

	[Token(Token = "0x6010446")]
	[Address(RVA = "0x255C0F8", Offset = "0x255C0F8", VA = "0x255C0F8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6010447")]
	[Address(RVA = "0x255C244", Offset = "0x255C244", VA = "0x255C244", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010448")]
	[Address(RVA = "0x255C2D0", Offset = "0x255C2D0", VA = "0x255C2D0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010449")]
	[Address(RVA = "0x255C374", Offset = "0x255C374", VA = "0x255C374")]
	private void OnBooyahTVBtnClick()
	{
	}

	[Token(Token = "0x601044A")]
	[Address(RVA = "0x255C5CC", Offset = "0x255C5CC", VA = "0x255C5CC")]
	private void OnLiveBtnClick()
	{
	}

	[Token(Token = "0x601044B")]
	[Address(RVA = "0x255BDEC", Offset = "0x255BDEC", VA = "0x255BDEC")]
	private WebView.Rect WebViewRect()
	{
		return null;
	}

	[Token(Token = "0x601044C")]
	[Address(RVA = "0x255C824", Offset = "0x255C824", VA = "0x255C824")]
	private void CloseNaviPop()
	{
	}

	[Token(Token = "0x601044D")]
	[Address(RVA = "0x255C930", Offset = "0x255C930", VA = "0x255C930")]
	private void RefreshWebView()
	{
	}

	[Token(Token = "0x601044E")]
	[Address(RVA = "0x255C9B0", Offset = "0x255C9B0", VA = "0x255C9B0", Slot = "33")]
	protected override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x601044F")]
	[Address(RVA = "0x255C1AC", Offset = "0x255C1AC", VA = "0x255C1AC")]
	private WebView CurrentWebView()
	{
		return null;
	}

	[Token(Token = "0x6010450")]
	[Address(RVA = "0x255CB0C", Offset = "0x255CB0C", VA = "0x255CB0C")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6010451")]
	[Address(RVA = "0x255CB14", Offset = "0x255CB14", VA = "0x255CB14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010452")]
	[Address(RVA = "0x255CB1C", Offset = "0x255CB1C", VA = "0x255CB1C")]
	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	[Token(Token = "0x6010453")]
	[Address(RVA = "0x255CB24", Offset = "0x255CB24", VA = "0x255CB24")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010454")]
	[Address(RVA = "0x255CB2C", Offset = "0x255CB2C", VA = "0x255CB2C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010455")]
	[Address(RVA = "0x255CB34", Offset = "0x255CB34", VA = "0x255CB34")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010456")]
	[Address(RVA = "0x255CB3C", Offset = "0x255CB3C", VA = "0x255CB3C")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
