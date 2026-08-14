using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002117")]
internal class UIHudTxtOnlyNotificationController : UIBaseController
{
	[Token(Token = "0x400CF58")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTxtOnlyNotificationView m_View;

	[Token(Token = "0x400CF59")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x600AD27")]
	[Address(RVA = "0x1594870", Offset = "0x1594870", VA = "0x1594870")]
	public UIHudTxtOnlyNotificationController()
	{
	}

	[Token(Token = "0x600AD28")]
	[Address(RVA = "0x15948F4", Offset = "0x15948F4", VA = "0x15948F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD29")]
	[Address(RVA = "0x1594998", Offset = "0x1594998", VA = "0x1594998", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AD2A")]
	[Address(RVA = "0x1594AE8", Offset = "0x1594AE8", VA = "0x1594AE8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AD2B")]
	[Address(RVA = "0x1594C90", Offset = "0x1594C90", VA = "0x1594C90", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600AD2C")]
	[Address(RVA = "0x1594D2C", Offset = "0x1594D2C", VA = "0x1594D2C")]
	private void ShowMessage(object[] data)
	{
	}

	[Token(Token = "0x600AD2D")]
	[Address(RVA = "0x1594E5C", Offset = "0x1594E5C", VA = "0x1594E5C")]
	protected void Show(float secs)
	{
	}

	[Token(Token = "0x600AD2E")]
	[Address(RVA = "0x159505C", Offset = "0x159505C", VA = "0x159505C")]
	protected void WaitAndHide()
	{
	}

	[Token(Token = "0x600AD2F")]
	[Address(RVA = "0x15950F4", Offset = "0x15950F4", VA = "0x15950F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AD30")]
	[Address(RVA = "0x15950FC", Offset = "0x15950FC", VA = "0x15950FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600AD31")]
	[Address(RVA = "0x1595104", Offset = "0x1595104", VA = "0x1595104")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
