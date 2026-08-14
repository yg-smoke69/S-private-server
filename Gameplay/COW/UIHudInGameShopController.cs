using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002780")]
internal class UIHudInGameShopController : UIHudInGameShopBaseController
{
	[Token(Token = "0x400F3EC")]
	[FieldOffset(Offset = "0x34")]
	private bool m_ShopItemInited;

	[Token(Token = "0x400F3ED")]
	[FieldOffset(Offset = "0x38")]
	private MCOMKOKDDHE m_ChoosedItemInfo;

	[Token(Token = "0x400F3EE")]
	[FieldOffset(Offset = "0x3C")]
	private int m_CurBagCapacity;

	[Token(Token = "0x400F3EF")]
	[FieldOffset(Offset = "0x40")]
	private int m_MaxBagCapacity;

	[Token(Token = "0x400F3F0")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, UIHudInGameShopCategoryController> m_Categorys;

	[Token(Token = "0x400F3F1")]
	[FieldOffset(Offset = "0x48")]
	private uint m_TipDelayCall;

	[Token(Token = "0x400F3F2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F260")]
	[Address(RVA = "0x229C3C0", Offset = "0x229C3C0", VA = "0x229C3C0")]
	public UIHudInGameShopController()
	{
	}

	[Token(Token = "0x600F261")]
	[Address(RVA = "0x229C450", Offset = "0x229C450", VA = "0x229C450")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F262")]
	[Address(RVA = "0x229C4F8", Offset = "0x229C4F8", VA = "0x229C4F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F263")]
	[Address(RVA = "0x229C98C", Offset = "0x229C98C", VA = "0x229C98C", Slot = "31")]
	protected override void OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600F264")]
	[Address(RVA = "0x229CA84", Offset = "0x229CA84", VA = "0x229CA84", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F265")]
	[Address(RVA = "0x229CDD0", Offset = "0x229CDD0", VA = "0x229CDD0", Slot = "32")]
	protected override void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600F266")]
	[Address(RVA = "0x229CF4C", Offset = "0x229CF4C", VA = "0x229CF4C")]
	private void OnShowHud(object[] data)
	{
	}

	[Token(Token = "0x600F267")]
	[Address(RVA = "0x229D048", Offset = "0x229D048", VA = "0x229D048", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F268")]
	[Address(RVA = "0x229D2C4", Offset = "0x229D2C4", VA = "0x229D2C4")]
	private void InitShopItems()
	{
	}

	[Token(Token = "0x600F269")]
	[Address(RVA = "0x229DCD0", Offset = "0x229DCD0", VA = "0x229DCD0")]
	private JAOADEMOBHH PrecheckForBuy(MCOMKOKDDHE itemInfo)
	{
		return default(JAOADEMOBHH);
	}

	[Token(Token = "0x600F26A")]
	[Address(RVA = "0x229D9C4", Offset = "0x229D9C4", VA = "0x229D9C4")]
	private void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
	{
	}

	[Token(Token = "0x600F26B")]
	[Address(RVA = "0x229DDC8", Offset = "0x229DDC8", VA = "0x229DDC8", Slot = "34")]
	protected override void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600F26C")]
	[Address(RVA = "0x229E3EC", Offset = "0x229E3EC", VA = "0x229E3EC")]
	private void ShowBuyResult(JAOADEMOBHH buyResult)
	{
	}

	[Token(Token = "0x600F26D")]
	[Address(RVA = "0x229EA88", Offset = "0x229EA88", VA = "0x229EA88", Slot = "36")]
	protected override void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F26E")]
	[Address(RVA = "0x229EAF4", Offset = "0x229EAF4", VA = "0x229EAF4")]
	private void OnCoinBtnClick()
	{
	}

	[Token(Token = "0x600F26F")]
	[Address(RVA = "0x229EFE4", Offset = "0x229EFE4", VA = "0x229EFE4")]
	private void OnCapacityBtnClick()
	{
	}

	[Token(Token = "0x600F270")]
	[Address(RVA = "0x229D0E4", Offset = "0x229D0E4", VA = "0x229D0E4")]
	private void ClearSelected()
	{
	}

	[Token(Token = "0x600F271")]
	[Address(RVA = "0x229F4D4", Offset = "0x229F4D4", VA = "0x229F4D4", Slot = "33")]
	protected override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600F272")]
	[Address(RVA = "0x229F7A4", Offset = "0x229F7A4", VA = "0x229F7A4")]
	private void OnLocalPlayerBeHurt(object[] data)
	{
	}

	[Token(Token = "0x600F273")]
	[Address(RVA = "0x229F894", Offset = "0x229F894", VA = "0x229F894")]
	private void OnLocalPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600F274")]
	[Address(RVA = "0x229F908", Offset = "0x229F908", VA = "0x229F908")]
	private void OnBuyResultSync(object[] data)
	{
	}

	[Token(Token = "0x600F275")]
	[Address(RVA = "0x229F9E4", Offset = "0x229F9E4", VA = "0x229F9E4")]
	private void OnBagCapacityChanged(object[] data)
	{
	}

	[Token(Token = "0x600F276")]
	[Address(RVA = "0x229DB94", Offset = "0x229DB94", VA = "0x229DB94")]
	private void UpdateBagCapacityText()
	{
	}

	[Token(Token = "0x600F277")]
	[Address(RVA = "0x229FBB4", Offset = "0x229FBB4", VA = "0x229FBB4")]
	private static int _003CInitShopItems_003Em__0(Transform item1, Transform item2)
	{
		return default(int);
	}

	[Token(Token = "0x600F278")]
	[Address(RVA = "0x229FD6C", Offset = "0x229FD6C", VA = "0x229FD6C")]
	private void _003COnCoinBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x600F279")]
	[Address(RVA = "0x229FE38", Offset = "0x229FE38", VA = "0x229FE38")]
	private void _003COnCapacityBtnClick_003Em__2()
	{
	}

	[Token(Token = "0x600F27A")]
	[Address(RVA = "0x229FF04", Offset = "0x229FF04", VA = "0x229FF04")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F27B")]
	[Address(RVA = "0x229FF08", Offset = "0x229FF08", VA = "0x229FF08")]
	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600F27C")]
	[Address(RVA = "0x229FF0C", Offset = "0x229FF0C", VA = "0x229FF0C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F27D")]
	[Address(RVA = "0x229FF10", Offset = "0x229FF10", VA = "0x229FF10")]
	public void _003C_003EiFixBaseProxy_OnTokenChanged(object[] P0)
	{
	}

	[Token(Token = "0x600F27E")]
	[Address(RVA = "0x229FF14", Offset = "0x229FF14", VA = "0x229FF14")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F27F")]
	[Address(RVA = "0x229FF18", Offset = "0x229FF18", VA = "0x229FF18")]
	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600F280")]
	[Address(RVA = "0x229FF1C", Offset = "0x229FF1C", VA = "0x229FF1C")]
	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F281")]
	[Address(RVA = "0x229FF20", Offset = "0x229FF20", VA = "0x229FF20")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}
}
