using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20029CA")]
public class UIMemberShipSVIPPrivilegePopWndController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x4010107")]
	private const string PRICE_TEMPLATE = "${0}";

	[Token(Token = "0x4010108")]
	[FieldOffset(Offset = "0x48")]
	private UIMemberShipSVIPPrivilegePopWndView m_View;

	[Token(Token = "0x4010109")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMemberShip m_Model;

	[Token(Token = "0x401010A")]
	[FieldOffset(Offset = "0x50")]
	private List<UIStandardItemMiniController> m_ItemsList;

	[Token(Token = "0x401010B")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6010CEF")]
	[Address(RVA = "0x12FFE50", Offset = "0x12FFE50", VA = "0x12FFE50")]
	public UIMemberShipSVIPPrivilegePopWndController()
	{
	}

	[Token(Token = "0x6010CF0")]
	[Address(RVA = "0x12FFEDC", Offset = "0x12FFEDC", VA = "0x12FFEDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010CF1")]
	[Address(RVA = "0x12FFF80", Offset = "0x12FFF80", VA = "0x12FFF80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010CF2")]
	[Address(RVA = "0x13012C8", Offset = "0x13012C8", VA = "0x13012C8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010CF3")]
	[Address(RVA = "0x1300C90", Offset = "0x1300C90", VA = "0x1300C90")]
	private void RefreshPurchaseBtnByPackageType()
	{
	}

	[Token(Token = "0x6010CF4")]
	[Address(RVA = "0x1300D98", Offset = "0x1300D98", VA = "0x1300D98")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x6010CF5")]
	[Address(RVA = "0x1301350", Offset = "0x1301350", VA = "0x1301350")]
	private void RefreshPrice()
	{
	}

	[Token(Token = "0x6010CF6")]
	[Address(RVA = "0x130186C", Offset = "0x130186C", VA = "0x130186C")]
	private void OnCheckInBtnClick()
	{
	}

	[Token(Token = "0x6010CF7")]
	[Address(RVA = "0x1301A40", Offset = "0x1301A40", VA = "0x1301A40")]
	private void OnUnlockBtnClick()
	{
	}

	[Token(Token = "0x6010CF8")]
	[Address(RVA = "0x1302014", Offset = "0x1302014", VA = "0x1302014")]
	private void OnMshopUnlockBtnClick()
	{
	}

	[Token(Token = "0x6010CF9")]
	[Address(RVA = "0x13021BC", Offset = "0x13021BC", VA = "0x13021BC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6010CFA")]
	[Address(RVA = "0x130228C", Offset = "0x130228C", VA = "0x130228C", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010CFB")]
	[Address(RVA = "0x13023F8", Offset = "0x13023F8", VA = "0x13023F8", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010CFC")]
	[Address(RVA = "0x1302474", Offset = "0x1302474", VA = "0x1302474")]
	private void OnDiscountEnd(object[] obj)
	{
	}

	[Token(Token = "0x6010CFD")]
	[Address(RVA = "0x13024DC", Offset = "0x13024DC", VA = "0x13024DC", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010CFE")]
	[Address(RVA = "0x1302570", Offset = "0x1302570", VA = "0x1302570", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010CFF")]
	[Address(RVA = "0x1302664", Offset = "0x1302664", VA = "0x1302664")]
	private static BaseItemInfo _003CRefreshViewData_003Em__0(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x6010D00")]
	[Address(RVA = "0x13026E8", Offset = "0x13026E8", VA = "0x13026E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D01")]
	[Address(RVA = "0x13026F0", Offset = "0x13026F0", VA = "0x13026F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
