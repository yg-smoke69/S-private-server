using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021C6")]
public class UIInstallmentMallDepositController : UIInstallmentMallPurchaseController, _Attribute
{
	[Token(Token = "0x400D34B")]
	[FieldOffset(Offset = "0x58")]
	private UIInstallmentMallPurchaseView m_View;

	[Token(Token = "0x600B4BF")]
	[Address(RVA = "0x127B56C", Offset = "0x127B56C", VA = "0x127B56C")]
	public UIInstallmentMallDepositController()
	{
	}

	[Token(Token = "0x600B4C0")]
	[Address(RVA = "0x127B57C", Offset = "0x127B57C", VA = "0x127B57C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4C1")]
	[Address(RVA = "0x127B678", Offset = "0x127B678", VA = "0x127B678", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B4C2")]
	[Address(RVA = "0x127B9C0", Offset = "0x127B9C0", VA = "0x127B9C0", Slot = "46")]
	protected override void RefreshView()
	{
	}

	[Token(Token = "0x600B4C3")]
	[Address(RVA = "0x127C00C", Offset = "0x127C00C", VA = "0x127C00C")]
	public void SetViewData(uint itemID)
	{
	}

	[Token(Token = "0x600B4C4")]
	[Address(RVA = "0x127C0A8", Offset = "0x127C0A8", VA = "0x127C0A8")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B4C5")]
	[Address(RVA = "0x127C160", Offset = "0x127C160", VA = "0x127C160", Slot = "47")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B4C6")]
	[Address(RVA = "0x127C258", Offset = "0x127C258", VA = "0x127C258", Slot = "48")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B4C7")]
	[Address(RVA = "0x127C2D4", Offset = "0x127C2D4", VA = "0x127C2D4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B4C8")]
	[Address(RVA = "0x127C2D8", Offset = "0x127C2D8", VA = "0x127C2D8")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
