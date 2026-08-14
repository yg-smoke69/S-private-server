using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20028DB")]
public class UIIAPBundleWeekCardPopWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400FB4B")]
	[FieldOffset(Offset = "0x48")]
	private UIIAPBundleWeekCardPopWndView m_View;

	[Token(Token = "0x400FB4C")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelIAPBundle m_Model;

	[Token(Token = "0x400FB4D")]
	[FieldOffset(Offset = "0x50")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400FB4E")]
	[FieldOffset(Offset = "0x54")]
	private UIModelMemberShip m_ModelMembership;

	[Token(Token = "0x400FB4F")]
	[FieldOffset(Offset = "0x58")]
	private IAPBundleStoreData m_Data;

	[Token(Token = "0x400FB50")]
	[FieldOffset(Offset = "0x5C")]
	private ClientMemberShipCardData m_ClientMemberShipCardData;

	[Token(Token = "0x400FB51")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, int> m_EStoreTypeToMembershipTypeDic;

	[Token(Token = "0x400FB52")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60101E4")]
	[Address(RVA = "0xD43484", Offset = "0xD43484", VA = "0xD43484")]
	public UIIAPBundleWeekCardPopWndController()
	{
	}

	[Token(Token = "0x60101E5")]
	[Address(RVA = "0xD43540", Offset = "0xD43540", VA = "0xD43540")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60101E6")]
	[Address(RVA = "0xD435E8", Offset = "0xD435E8", VA = "0xD435E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60101E7")]
	[Address(RVA = "0xD43A04", Offset = "0xD43A04", VA = "0xD43A04")]
	private void UpdateData()
	{
	}

	[Token(Token = "0x60101E8")]
	[Address(RVA = "0xD44A94", Offset = "0xD44A94", VA = "0xD44A94")]
	private void SetCardData(ClientMemberShipCardData data)
	{
	}

	[Token(Token = "0x60101E9")]
	[Address(RVA = "0xD4492C", Offset = "0xD4492C", VA = "0xD4492C")]
	private void ToggleUI(bool show)
	{
	}

	[Token(Token = "0x60101EA")]
	[Address(RVA = "0xD44E30", Offset = "0xD44E30", VA = "0xD44E30")]
	public void OnPurchaseButtonClick()
	{
	}

	[Token(Token = "0x60101EB")]
	[Address(RVA = "0xD45158", Offset = "0xD45158", VA = "0xD45158")]
	private void OnCheckInBtnClick()
	{
	}

	[Token(Token = "0x60101EC")]
	[Address(RVA = "0xD4528C", Offset = "0xD4528C", VA = "0xD4528C")]
	private void OnTotalValueTipBtnClick()
	{
	}

	[Token(Token = "0x60101ED")]
	[Address(RVA = "0xD455F4", Offset = "0xD455F4", VA = "0xD455F4", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60101EE")]
	[Address(RVA = "0xD456AC", Offset = "0xD456AC", VA = "0xD456AC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60101EF")]
	[Address(RVA = "0xD4585C", Offset = "0xD4585C", VA = "0xD4585C", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60101F0")]
	[Address(RVA = "0xD4597C", Offset = "0xD4597C", VA = "0xD4597C", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60101F1")]
	[Address(RVA = "0xD459F8", Offset = "0xD459F8", VA = "0xD459F8")]
	private void _003CUpdateData_003Em__0()
	{
	}

	[Token(Token = "0x60101F2")]
	[Address(RVA = "0xD45AC8", Offset = "0xD45AC8", VA = "0xD45AC8")]
	private static BaseItemInfo _003CSetCardData_003Em__1(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x60101F3")]
	[Address(RVA = "0xD45B4C", Offset = "0xD45B4C", VA = "0xD45B4C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
