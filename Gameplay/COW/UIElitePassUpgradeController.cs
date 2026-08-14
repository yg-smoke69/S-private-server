using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025FC")]
public class UIElitePassUpgradeController : UINavigationController
{
	[Token(Token = "0x400EAAA")]
	[FieldOffset(Offset = "0x68")]
	private UIElitePassUpgradeView m_View;

	[Token(Token = "0x400EAAB")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400EAAC")]
	[FieldOffset(Offset = "0x70")]
	private uint totalRewardNum;

	[Token(Token = "0x400EAAD")]
	[FieldOffset(Offset = "0x74")]
	private EPPriceData m_Data;

	[Token(Token = "0x400EAAE")]
	[FieldOffset(Offset = "0x78")]
	private uint m_DelayCallTid;

	[Token(Token = "0x400EAAF")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_EPDiscountPrice;

	[Token(Token = "0x400EAB0")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EAB1")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<BaseItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400EAB2")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400EAB3")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x600E070")]
	[Address(RVA = "0x306A6BC", Offset = "0x306A6BC", VA = "0x306A6BC")]
	public UIElitePassUpgradeController()
	{
	}

	[Token(Token = "0x600E071")]
	[Address(RVA = "0x306A748", Offset = "0x306A748", VA = "0x306A748")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E072")]
	[Address(RVA = "0x306A7F0", Offset = "0x306A7F0", VA = "0x306A7F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E073")]
	[Address(RVA = "0x306C524", Offset = "0x306C524", VA = "0x306C524", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600E074")]
	[Address(RVA = "0x306C5B0", Offset = "0x306C5B0", VA = "0x306C5B0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E075")]
	[Address(RVA = "0x306C7C0", Offset = "0x306C7C0", VA = "0x306C7C0")]
	private void OnRefreshPriceLabel(object[] data)
	{
	}

	[Token(Token = "0x600E076")]
	[Address(RVA = "0x306C828", Offset = "0x306C828", VA = "0x306C828")]
	private void UpdateDiscountPriceView()
	{
	}

	[Token(Token = "0x600E077")]
	[Address(RVA = "0x306B110", Offset = "0x306B110", VA = "0x306B110")]
	private void InitRewards()
	{
	}

	[Token(Token = "0x600E078")]
	[Address(RVA = "0x306C36C", Offset = "0x306C36C", VA = "0x306C36C")]
	private void ShowDiscountPopWndIfNeed()
	{
	}

	[Token(Token = "0x600E079")]
	[Address(RVA = "0x306CD24", Offset = "0x306CD24", VA = "0x306CD24")]
	private void OnUpgradeClick()
	{
	}

	[Token(Token = "0x600E07A")]
	[Address(RVA = "0x306D140", Offset = "0x306D140", VA = "0x306D140")]
	private void Purchase()
	{
	}

	[Token(Token = "0x600E07B")]
	[Address(RVA = "0x306D2CC", Offset = "0x306D2CC", VA = "0x306D2CC")]
	private void OnBundleUpgrageClick()
	{
	}

	[Token(Token = "0x600E07C")]
	[Address(RVA = "0x306D6E0", Offset = "0x306D6E0", VA = "0x306D6E0")]
	private void PurchaseBundle()
	{
	}

	[Token(Token = "0x600E07D")]
	[Address(RVA = "0x306ACFC", Offset = "0x306ACFC", VA = "0x306ACFC")]
	private void SetCDNTexture(object[] data)
	{
	}

	[Token(Token = "0x600E07E")]
	[Address(RVA = "0x306D86C", Offset = "0x306D86C", VA = "0x306D86C")]
	private void OnAnimEvtOccur(object[] data)
	{
	}

	[Token(Token = "0x600E07F")]
	[Address(RVA = "0x306DA40", Offset = "0x306DA40", VA = "0x306DA40")]
	private void OnRewardListCenter(GameObject centeredObject)
	{
	}

	[Token(Token = "0x600E080")]
	[Address(RVA = "0x306DCB4", Offset = "0x306DCB4", VA = "0x306DCB4")]
	private static void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600E081")]
	[Address(RVA = "0x306DD80", Offset = "0x306DD80", VA = "0x306DD80")]
	private static int _003CInitRewards_003Em__1(BaseItemInfo x, BaseItemInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x600E082")]
	[Address(RVA = "0x306DDC8", Offset = "0x306DDC8", VA = "0x306DDC8")]
	private static bool _003CSetCDNTexture_003Em__2(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E083")]
	[Address(RVA = "0x306DDF8", Offset = "0x306DDF8", VA = "0x306DDF8")]
	private static bool _003CSetCDNTexture_003Em__3(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E084")]
	[Address(RVA = "0x306DE24", Offset = "0x306DE24", VA = "0x306DE24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E085")]
	[Address(RVA = "0x306DE2C", Offset = "0x306DE2C", VA = "0x306DE2C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600E086")]
	[Address(RVA = "0x306DE34", Offset = "0x306DE34", VA = "0x306DE34")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
