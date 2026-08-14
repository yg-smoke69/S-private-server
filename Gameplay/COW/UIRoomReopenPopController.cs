using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B01")]
public class UIRoomReopenPopController : UIPopupWindowController
{
	[Token(Token = "0x40107FB")]
	[FieldOffset(Offset = "0x48")]
	private UIRoomReopenPopView m_View;

	[Token(Token = "0x40107FC")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_OnOK;

	[Token(Token = "0x6011A8B")]
	[Address(RVA = "0x2BEAE44", Offset = "0x2BEAE44", VA = "0x2BEAE44")]
	public UIRoomReopenPopController()
	{
	}

	[Token(Token = "0x6011A8C")]
	[Address(RVA = "0x2BEAE4C", Offset = "0x2BEAE4C", VA = "0x2BEAE4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A8D")]
	[Address(RVA = "0x2BEAEF0", Offset = "0x2BEAEF0", VA = "0x2BEAEF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A8E")]
	[Address(RVA = "0x2BEB0D8", Offset = "0x2BEB0D8", VA = "0x2BEB0D8")]
	public void SetUIData(Action onOk)
	{
	}

	[Token(Token = "0x6011A8F")]
	[Address(RVA = "0x2BEB138", Offset = "0x2BEB138", VA = "0x2BEB138")]
	private void OnBtnConfirm()
	{
	}

	[Token(Token = "0x6011A90")]
	[Address(RVA = "0x2BEB4A8", Offset = "0x2BEB4A8", VA = "0x2BEB4A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
