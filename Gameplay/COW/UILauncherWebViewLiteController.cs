using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028F1")]
internal class UILauncherWebViewLiteController : UIBaseController
{
	[Token(Token = "0x400FBC9")]
	[FieldOffset(Offset = "0x28")]
	private UIWebViewWindowLiteView m_View;

	[Token(Token = "0x400FBCA")]
	[FieldOffset(Offset = "0x2C")]
	private WebView m_WebView;

	[Token(Token = "0x60102DD")]
	[Address(RVA = "0x1A889D4", Offset = "0x1A889D4", VA = "0x1A889D4")]
	public UILauncherWebViewLiteController()
	{
	}

	[Token(Token = "0x60102DE")]
	[Address(RVA = "0x1A88A58", Offset = "0x1A88A58", VA = "0x1A88A58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60102DF")]
	[Address(RVA = "0x1A88B00", Offset = "0x1A88B00", VA = "0x1A88B00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102E0")]
	[Address(RVA = "0x1A88C84", Offset = "0x1A88C84", VA = "0x1A88C84", Slot = "29")]
	public override void OnShare(bool success, int platform)
	{
	}

	[Token(Token = "0x60102E1")]
	[Address(RVA = "0x1A88D38", Offset = "0x1A88D38", VA = "0x1A88D38", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60102E2")]
	[Address(RVA = "0x1A88DBC", Offset = "0x1A88DBC", VA = "0x1A88DBC")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x60102E3")]
	[Address(RVA = "0x1A88EFC", Offset = "0x1A88EFC", VA = "0x1A88EFC")]
	private void Update()
	{
	}

	[Token(Token = "0x60102E4")]
	[Address(RVA = "0x1A83ECC", Offset = "0x1A83ECC", VA = "0x1A83ECC")]
	public void SetURL(string url)
	{
	}

	[Token(Token = "0x60102E5")]
	[Address(RVA = "0x1A88F7C", Offset = "0x1A88F7C", VA = "0x1A88F7C")]
	private void UpdateProgressBar()
	{
	}

	[Token(Token = "0x60102E6")]
	[Address(RVA = "0x1A89230", Offset = "0x1A89230", VA = "0x1A89230")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60102E7")]
	[Address(RVA = "0x1A89238", Offset = "0x1A89238", VA = "0x1A89238")]
	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	[Token(Token = "0x60102E8")]
	[Address(RVA = "0x1A89240", Offset = "0x1A89240", VA = "0x1A89240")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
