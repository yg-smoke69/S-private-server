using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A46")]
internal class UIPayResultPopupWindowController : UIPopupMessageBoxController
{
	[Token(Token = "0x40103DF")]
	[FieldOffset(Offset = "0x0")]
	private static UIPayResultPopupWindowController _Current;

	[Token(Token = "0x40103E0")]
	[FieldOffset(Offset = "0x78")]
	private UIPayResultPopupWindowView m_View;

	[Token(Token = "0x6011277")]
	[Address(RVA = "0x15B747C", Offset = "0x15B747C", VA = "0x15B747C")]
	public UIPayResultPopupWindowController()
	{
	}

	[Token(Token = "0x6011278")]
	[Address(RVA = "0x15B7484", Offset = "0x15B7484", VA = "0x15B7484")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011279")]
	[Address(RVA = "0x15B7528", Offset = "0x15B7528", VA = "0x15B7528", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601127A")]
	[Address(RVA = "0x15B76E4", Offset = "0x15B76E4", VA = "0x15B76E4")]
	public void SetNote(string note)
	{
	}

	[Token(Token = "0x601127B")]
	[Address(RVA = "0x15B784C", Offset = "0x15B784C", VA = "0x15B784C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601127C")]
	[Address(RVA = "0x15B7908", Offset = "0x15B7908", VA = "0x15B7908", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x601127D")]
	[Address(RVA = "0x15B7960", Offset = "0x15B7960", VA = "0x15B7960")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601127E")]
	[Address(RVA = "0x15B7968", Offset = "0x15B7968", VA = "0x15B7968")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601127F")]
	[Address(RVA = "0x15B7970", Offset = "0x15B7970", VA = "0x15B7970")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
