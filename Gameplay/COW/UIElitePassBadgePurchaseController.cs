using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025DE")]
public class UIElitePassBadgePurchaseController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x20025DF")]
	private sealed class _003CUpdateRewardList_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EA18")]
		[FieldOffset(Offset = "0x8")]
		internal uint buyCount;

		[Token(Token = "0x400EA19")]
		[FieldOffset(Offset = "0xC")]
		internal UIElitePassBadgePurchaseController _0024this;

		[Token(Token = "0x600DF08")]
		[Address(RVA = "0x2A3D658", Offset = "0x2A3D658", VA = "0x2A3D658")]
		public _003CUpdateRewardList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DF09")]
		[Address(RVA = "0x2A3F004", Offset = "0x2A3F004", VA = "0x2A3F004")]
		internal bool _003C_003Em__0(EPAwardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EA12")]
	[FieldOffset(Offset = "0x7C")]
	private UIElitePassBadgePurchaseView m_View;

	[Token(Token = "0x400EA13")]
	[FieldOffset(Offset = "0x80")]
	private UIModelElitePass m_EPModel;

	[Token(Token = "0x400EA14")]
	[FieldOffset(Offset = "0x84")]
	private EPBadgePriceData BadgePriceConfig;

	[Token(Token = "0x400EA15")]
	[FieldOffset(Offset = "0x88")]
	private float m_PreviewX;

	[Token(Token = "0x400EA16")]
	private const int MAXBADGE_BUY_CNT = 9999;

	[Token(Token = "0x400EA17")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600DEEB")]
	[Address(RVA = "0x2A3A758", Offset = "0x2A3A758", VA = "0x2A3A758")]
	public UIElitePassBadgePurchaseController()
	{
	}

	[Token(Token = "0x600DEEC")]
	[Address(RVA = "0x2A3A760", Offset = "0x2A3A760", VA = "0x2A3A760")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DEED")]
	[Address(RVA = "0x2A3A808", Offset = "0x2A3A808", VA = "0x2A3A808", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600DEEE")]
	[Address(RVA = "0x2A3B434", Offset = "0x2A3B434", VA = "0x2A3B434", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DEEF")]
	[Address(RVA = "0x2A3BFF4", Offset = "0x2A3BFF4", VA = "0x2A3BFF4")]
	private void OnClickUpgradeBtn()
	{
	}

	[Token(Token = "0x600DEF0")]
	[Address(RVA = "0x2A3C11C", Offset = "0x2A3C11C", VA = "0x2A3C11C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DEF1")]
	[Address(RVA = "0x2A3B188", Offset = "0x2A3B188", VA = "0x2A3B188")]
	private void SetCDN(object[] data)
	{
	}

	[Token(Token = "0x600DEF2")]
	[Address(RVA = "0x2A3AA9C", Offset = "0x2A3AA9C", VA = "0x2A3AA9C")]
	private int CalcDetalBadgeBuyCnt()
	{
		return default(int);
	}

	[Token(Token = "0x600DEF3")]
	[Address(RVA = "0x2A3C388", Offset = "0x2A3C388", VA = "0x2A3C388")]
	private void OnClickMinusButton()
	{
	}

	[Token(Token = "0x600DEF4")]
	[Address(RVA = "0x2A3C4C4", Offset = "0x2A3C4C4", VA = "0x2A3C4C4")]
	private void OnClickPlusButton()
	{
	}

	[Token(Token = "0x600DEF5")]
	[Address(RVA = "0x2A3C5F8", Offset = "0x2A3C5F8", VA = "0x2A3C5F8")]
	private void OnClickFivePlusButton()
	{
	}

	[Token(Token = "0x600DEF6")]
	[Address(RVA = "0x2A3C72C", Offset = "0x2A3C72C", VA = "0x2A3C72C")]
	private void OnClickFiveMinusButton()
	{
	}

	[Token(Token = "0x600DEF7")]
	[Address(RVA = "0x2A3AEEC", Offset = "0x2A3AEEC", VA = "0x2A3AEEC")]
	private void UpdatePriceCost()
	{
	}

	[Token(Token = "0x600DEF8")]
	[Address(RVA = "0x2A3C85C", Offset = "0x2A3C85C", VA = "0x2A3C85C")]
	private void UpdateDiamondAmount()
	{
	}

	[Token(Token = "0x600DEF9")]
	[Address(RVA = "0x2A3CDF0", Offset = "0x2A3CDF0", VA = "0x2A3CDF0")]
	private void UpdateRewardList()
	{
	}

	[Token(Token = "0x600DEFA")]
	[Address(RVA = "0x2A3DCB0", Offset = "0x2A3DCB0", VA = "0x2A3DCB0")]
	private void OnPreviewItem(object[] param)
	{
	}

	[Token(Token = "0x600DEFB")]
	[Address(RVA = "0x2A3E3AC", Offset = "0x2A3E3AC", VA = "0x2A3E3AC")]
	private void OnClickPurchaseBtn()
	{
	}

	[Token(Token = "0x600DEFC")]
	[Address(RVA = "0x2A3E828", Offset = "0x2A3E828", VA = "0x2A3E828")]
	private void PurchaseBadge()
	{
	}

	[Token(Token = "0x600DEFD")]
	[Address(RVA = "0x2A3EA84", Offset = "0x2A3EA84", VA = "0x2A3EA84")]
	private void OnBuyBadgeSuccess(object[] param)
	{
	}

	[Token(Token = "0x600DEFE")]
	[Address(RVA = "0x2A3AF54", Offset = "0x2A3AF54", VA = "0x2A3AF54")]
	private void SetBadgeCount()
	{
	}

	[Token(Token = "0x600DEFF")]
	[Address(RVA = "0x2A3EB58", Offset = "0x2A3EB58", VA = "0x2A3EB58")]
	private void OnClickBadge()
	{
	}

	[Token(Token = "0x600DF00")]
	[Address(RVA = "0x2A3ED80", Offset = "0x2A3ED80", VA = "0x2A3ED80", Slot = "64")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DF01")]
	[Address(RVA = "0x2A3EE78", Offset = "0x2A3EE78", VA = "0x2A3EE78", Slot = "65")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DF02")]
	[Address(RVA = "0x2A3EEF4", Offset = "0x2A3EEF4", VA = "0x2A3EEF4", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600DF03")]
	[Address(RVA = "0x2A3EF64", Offset = "0x2A3EF64", VA = "0x2A3EF64", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600DF04")]
	[Address(RVA = "0x2A3EFBC", Offset = "0x2A3EFBC", VA = "0x2A3EFBC")]
	private static bool _003CSetCDN_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DF05")]
	[Address(RVA = "0x2A3EFEC", Offset = "0x2A3EFEC", VA = "0x2A3EFEC")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600DF06")]
	[Address(RVA = "0x2A3EFF4", Offset = "0x2A3EFF4", VA = "0x2A3EFF4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF07")]
	[Address(RVA = "0x2A3EFFC", Offset = "0x2A3EFFC", VA = "0x2A3EFFC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
