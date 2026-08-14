using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C20")]
internal class UIWebViewWindowLiteController : UIWebViewWindowBaseController
{
	[Token(Token = "0x4010D7A")]
	[FieldOffset(Offset = "0x50")]
	private UIWebViewWindowLiteView m_View;

	[Token(Token = "0x4010D7B")]
	[FieldOffset(Offset = "0x54")]
	private uint m_UpdateDelayCallId;

	[Token(Token = "0x60125D4")]
	[Address(RVA = "0x1B7FA2C", Offset = "0x1B7FA2C", VA = "0x1B7FA2C")]
	public UIWebViewWindowLiteController()
	{
	}

	[Token(Token = "0x60125D5")]
	[Address(RVA = "0x1B7FA34", Offset = "0x1B7FA34", VA = "0x1B7FA34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60125D6")]
	[Address(RVA = "0x1B7FADC", Offset = "0x1B7FADC", VA = "0x1B7FADC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60125D7")]
	[Address(RVA = "0x1B7FCF0", Offset = "0x1B7FCF0", VA = "0x1B7FCF0", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x60125D8")]
	[Address(RVA = "0x1B7FD48", Offset = "0x1B7FD48", VA = "0x1B7FD48")]
	public void SetData(string url)
	{
	}

	[Token(Token = "0x60125D9")]
	[Address(RVA = "0x1B7FE40", Offset = "0x1B7FE40", VA = "0x1B7FE40", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60125DA")]
	[Address(RVA = "0x1B7FF54", Offset = "0x1B7FF54", VA = "0x1B7FF54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60125DB")]
	[Address(RVA = "0x1B8006C", Offset = "0x1B8006C", VA = "0x1B8006C")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x60125DC")]
	[Address(RVA = "0x1B801AC", Offset = "0x1B801AC", VA = "0x1B801AC")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60125DD")]
	[Address(RVA = "0x1B80418", Offset = "0x1B80418", VA = "0x1B80418")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60125DE")]
	[Address(RVA = "0x1B8041C", Offset = "0x1B8041C", VA = "0x1B8041C")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x60125DF")]
	[Address(RVA = "0x1B80424", Offset = "0x1B80424", VA = "0x1B80424")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60125E0")]
	[Address(RVA = "0x1B80428", Offset = "0x1B80428", VA = "0x1B80428")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
