using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C37")]
public class UIVoucherListController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010DD7")]
	[FieldOffset(Offset = "0x48")]
	private UIVoucherListView m_View;

	[Token(Token = "0x4010DD8")]
	[FieldOffset(Offset = "0x4C")]
	private List<VoucherData> m_VoucherDataList;

	[Token(Token = "0x4010DD9")]
	[FieldOffset(Offset = "0x50")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x4010DDA")]
	[FieldOffset(Offset = "0x54")]
	private int m_TotalGemsPrice;

	[Token(Token = "0x4010DDB")]
	[FieldOffset(Offset = "0x58")]
	private int m_TotalCoinsPrice;

	[Token(Token = "0x4010DDC")]
	[FieldOffset(Offset = "0x5C")]
	private VoucherData m_VoucherData;

	[Token(Token = "0x4010DDD")]
	[FieldOffset(Offset = "0x60")]
	private Func<Transform, UIVoucherItemController> m_CustomItemCreator;

	[Token(Token = "0x4010DDE")]
	[FieldOffset(Offset = "0x64")]
	private int[] m_VoucherBorderSize;

	[Token(Token = "0x4010DDF")]
	private const int m_VoucherItemSize = 50;

	[Token(Token = "0x60126CF")]
	[Address(RVA = "0x101A580", Offset = "0x101A580", VA = "0x101A580")]
	public UIVoucherListController()
	{
	}

	[Token(Token = "0x60126D0")]
	[Address(RVA = "0x101A648", Offset = "0x101A648", VA = "0x101A648")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60126D1")]
	[Address(RVA = "0x101A6F0", Offset = "0x101A6F0", VA = "0x101A6F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60126D2")]
	[Address(RVA = "0x101A87C", Offset = "0x101A87C", VA = "0x101A87C")]
	private void OnVoucherItemClick(object[] data)
	{
	}

	[Token(Token = "0x60126D3")]
	[Address(RVA = "0x101A988", Offset = "0x101A988", VA = "0x101A988", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60126D4")]
	[Address(RVA = "0x101AAA0", Offset = "0x101AAA0", VA = "0x101AAA0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60126D5")]
	[Address(RVA = "0x101ABE8", Offset = "0x101ABE8", VA = "0x101ABE8")]
	public void SetData(int totalGemsPrice, int totalCoinsPrice, VoucherData selectedVoucher, Func<Transform, UIVoucherItemController> customItemCreator)
	{
	}

	[Token(Token = "0x60126D6")]
	[Address(RVA = "0x101B400", Offset = "0x101B400", VA = "0x101B400", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60126D7")]
	[Address(RVA = "0x101B530", Offset = "0x101B530", VA = "0x101B530")]
	public UIVoucherItemController SwitchVoucherItemCtrl(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60126D8")]
	[Address(RVA = "0x101B650", Offset = "0x101B650", VA = "0x101B650", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x60126D9")]
	[Address(RVA = "0x101B6CC", Offset = "0x101B6CC", VA = "0x101B6CC")]
	private int _003CSetData_003Em__0(VoucherData a, VoucherData b)
	{
		return default(int);
	}

	[Token(Token = "0x60126DA")]
	[Address(RVA = "0x101B814", Offset = "0x101B814", VA = "0x101B814")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60126DB")]
	[Address(RVA = "0x101B81C", Offset = "0x101B81C", VA = "0x101B81C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60126DC")]
	[Address(RVA = "0x101B824", Offset = "0x101B824", VA = "0x101B824")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
