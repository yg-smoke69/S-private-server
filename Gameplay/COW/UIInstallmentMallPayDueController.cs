using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021C9")]
public class UIInstallmentMallPayDueController : UIInstallmentMallPurchaseController, _Attribute
{
	[Token(Token = "0x400D351")]
	[FieldOffset(Offset = "0x58")]
	private UIInstallmentMallPurchaseView m_View;

	[Token(Token = "0x600B4E5")]
	[Address(RVA = "0x127DA88", Offset = "0x127DA88", VA = "0x127DA88")]
	public UIInstallmentMallPayDueController()
	{
	}

	[Token(Token = "0x600B4E6")]
	[Address(RVA = "0x127DA90", Offset = "0x127DA90", VA = "0x127DA90")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4E7")]
	[Address(RVA = "0x127DAE4", Offset = "0x127DAE4", VA = "0x127DAE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B4E8")]
	[Address(RVA = "0x127DCA8", Offset = "0x127DCA8", VA = "0x127DCA8", Slot = "46")]
	protected override void RefreshView()
	{
	}

	[Token(Token = "0x600B4E9")]
	[Address(RVA = "0x127E008", Offset = "0x127E008", VA = "0x127E008")]
	public void SetViewData(uint itemID)
	{
	}

	[Token(Token = "0x600B4EA")]
	[Address(RVA = "0x127E0A4", Offset = "0x127E0A4", VA = "0x127E0A4")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B4EB")]
	[Address(RVA = "0x127E15C", Offset = "0x127E15C", VA = "0x127E15C", Slot = "47")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B4EC")]
	[Address(RVA = "0x127E254", Offset = "0x127E254", VA = "0x127E254", Slot = "48")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B4ED")]
	[Address(RVA = "0x127E2D0", Offset = "0x127E2D0", VA = "0x127E2D0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B4EE")]
	[Address(RVA = "0x127E2D4", Offset = "0x127E2D4", VA = "0x127E2D4")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
