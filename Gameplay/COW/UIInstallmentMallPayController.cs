using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20021C8")]
public class UIInstallmentMallPayController : UIInstallmentMallPurchaseController, _Attribute
{
	[Token(Token = "0x400D350")]
	[FieldOffset(Offset = "0x58")]
	private UIInstallmentMallPurchaseView m_View;

	[Token(Token = "0x600B4DB")]
	[Address(RVA = "0x127D238", Offset = "0x127D238", VA = "0x127D238")]
	public UIInstallmentMallPayController()
	{
	}

	[Token(Token = "0x600B4DC")]
	[Address(RVA = "0x127D240", Offset = "0x127D240", VA = "0x127D240")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4DD")]
	[Address(RVA = "0x127D294", Offset = "0x127D294", VA = "0x127D294", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B4DE")]
	[Address(RVA = "0x127D458", Offset = "0x127D458", VA = "0x127D458", Slot = "46")]
	protected override void RefreshView()
	{
	}

	[Token(Token = "0x600B4DF")]
	[Address(RVA = "0x127D7B8", Offset = "0x127D7B8", VA = "0x127D7B8")]
	public void SetViewData(uint itemID)
	{
	}

	[Token(Token = "0x600B4E0")]
	[Address(RVA = "0x127D854", Offset = "0x127D854", VA = "0x127D854")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B4E1")]
	[Address(RVA = "0x127D90C", Offset = "0x127D90C", VA = "0x127D90C", Slot = "47")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B4E2")]
	[Address(RVA = "0x127DA04", Offset = "0x127DA04", VA = "0x127DA04", Slot = "48")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B4E3")]
	[Address(RVA = "0x127DA80", Offset = "0x127DA80", VA = "0x127DA80")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B4E4")]
	[Address(RVA = "0x127DA84", Offset = "0x127DA84", VA = "0x127DA84")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
