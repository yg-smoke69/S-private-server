using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002997")]
internal class UIManualWebViewController : UIWebViewWindowBaseController
{
	[Token(Token = "0x4010002")]
	[FieldOffset(Offset = "0x50")]
	private UIManualWebViewView m_View;

	[Token(Token = "0x4010003")]
	[FieldOffset(Offset = "0x54")]
	private uint m_UpdateDelayCallId;

	[Token(Token = "0x6010B42")]
	[Address(RVA = "0x12397BC", Offset = "0x12397BC", VA = "0x12397BC")]
	public UIManualWebViewController()
	{
	}

	[Token(Token = "0x6010B43")]
	[Address(RVA = "0x12397C4", Offset = "0x12397C4", VA = "0x12397C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B44")]
	[Address(RVA = "0x123986C", Offset = "0x123986C", VA = "0x123986C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B45")]
	[Address(RVA = "0x1239A84", Offset = "0x1239A84", VA = "0x1239A84", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010B46")]
	[Address(RVA = "0x1239BA0", Offset = "0x1239BA0", VA = "0x1239BA0")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x6010B47")]
	[Address(RVA = "0x1239D58", Offset = "0x1239D58", VA = "0x1239D58")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6010B48")]
	[Address(RVA = "0x1239FC4", Offset = "0x1239FC4", VA = "0x1239FC4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B49")]
	[Address(RVA = "0x1239FCC", Offset = "0x1239FCC", VA = "0x1239FCC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
