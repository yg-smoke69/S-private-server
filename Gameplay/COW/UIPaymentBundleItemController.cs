using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A18")]
public class UIPaymentBundleItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x40102D8")]
	[FieldOffset(Offset = "0x38")]
	private UIPaymentBundleItemView m_View;

	[Token(Token = "0x40102D9")]
	[FieldOffset(Offset = "0x3C")]
	protected PayBundleWindowDesc m_Data;

	[Token(Token = "0x40102DA")]
	[FieldOffset(Offset = "0x40")]
	protected UICountDownController m_Countdown;

	[Token(Token = "0x40102DB")]
	[FieldOffset(Offset = "0x44")]
	private List<UIStandardItemMiniController> m_ContentItems;

	[Token(Token = "0x40102DC")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011060")]
	[Address(RVA = "0x286E8F4", Offset = "0x286E8F4", VA = "0x286E8F4")]
	public UIPaymentBundleItemController()
	{
	}

	[Token(Token = "0x6011061")]
	[Address(RVA = "0x286E980", Offset = "0x286E980", VA = "0x286E980")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011062")]
	[Address(RVA = "0x286EA28", Offset = "0x286EA28", VA = "0x286EA28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011063")]
	[Address(RVA = "0x286ECA8", Offset = "0x286ECA8", VA = "0x286ECA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011064")]
	[Address(RVA = "0x286E35C", Offset = "0x286E35C", VA = "0x286E35C")]
	public void SetData(PayBundleWindowDesc data)
	{
	}

	[Token(Token = "0x6011065")]
	[Address(RVA = "0x286EE6C", Offset = "0x286EE6C", VA = "0x286EE6C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011066")]
	[Address(RVA = "0x286EFD0", Offset = "0x286EFD0", VA = "0x286EFD0", Slot = "39")]
	protected virtual void UpdateContents()
	{
	}

	[Token(Token = "0x6011067")]
	[Address(RVA = "0x2871E9C", Offset = "0x2871E9C", VA = "0x2871E9C")]
	private void OnPurchaseButtonClick()
	{
	}

	[Token(Token = "0x6011068")]
	[Address(RVA = "0x287285C", Offset = "0x287285C", VA = "0x287285C")]
	private void OnPaidFailed(object[] data)
	{
	}

	[Token(Token = "0x6011069")]
	[Address(RVA = "0x287298C", Offset = "0x287298C", VA = "0x287298C", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601106A")]
	[Address(RVA = "0x2872AF8", Offset = "0x2872AF8", VA = "0x2872AF8", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601106B")]
	[Address(RVA = "0x2872B5C", Offset = "0x2872B5C", VA = "0x2872B5C")]
	private static void _003COnPurchaseButtonClick_003Em__0()
	{
	}

	[Token(Token = "0x601106C")]
	[Address(RVA = "0x2872BF4", Offset = "0x2872BF4", VA = "0x2872BF4")]
	private bool _003COnPurchaseButtonClick_003Em__1(SpecialStoreDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x601106D")]
	[Address(RVA = "0x2872C40", Offset = "0x2872C40", VA = "0x2872C40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601106E")]
	[Address(RVA = "0x2872C48", Offset = "0x2872C48", VA = "0x2872C48")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
