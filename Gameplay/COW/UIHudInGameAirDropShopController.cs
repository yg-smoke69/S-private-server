using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200277C")]
internal class UIHudInGameAirDropShopController : UIHudInGameShopBaseController
{
	[Token(Token = "0x400F3C6")]
	[FieldOffset(Offset = "0x34")]
	private bool m_ShopItemInited;

	[Token(Token = "0x400F3C7")]
	[FieldOffset(Offset = "0x38")]
	private MCOMKOKDDHE m_ChoosedItemInfo;

	[Token(Token = "0x400F3C8")]
	[FieldOffset(Offset = "0x3C")]
	private int m_CurBagCapacity;

	[Token(Token = "0x400F3C9")]
	[FieldOffset(Offset = "0x40")]
	private int m_MaxBagCapacity;

	[Token(Token = "0x400F3CA")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, UIHudInGameShopCategoryController> m_Categorys;

	[Token(Token = "0x400F3CB")]
	[FieldOffset(Offset = "0x48")]
	private uint m_TipDelayCall;

	[Token(Token = "0x400F3CC")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F1FF")]
	[Address(RVA = "0x134FFA8", Offset = "0x134FFA8", VA = "0x134FFA8")]
	public UIHudInGameAirDropShopController()
	{
	}

	[Token(Token = "0x600F200")]
	[Address(RVA = "0x135003C", Offset = "0x135003C", VA = "0x135003C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F201")]
	[Address(RVA = "0x13500E4", Offset = "0x13500E4", VA = "0x13500E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F202")]
	[Address(RVA = "0x135057C", Offset = "0x135057C", VA = "0x135057C", Slot = "32")]
	protected override void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600F203")]
	[Address(RVA = "0x13506F8", Offset = "0x13506F8", VA = "0x13506F8", Slot = "31")]
	protected override void OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600F204")]
	[Address(RVA = "0x13507F4", Offset = "0x13507F4", VA = "0x13507F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F205")]
	[Address(RVA = "0x1350B44", Offset = "0x1350B44", VA = "0x1350B44")]
	protected void OnShowHud(object[] data)
	{
	}

	[Token(Token = "0x600F206")]
	[Address(RVA = "0x1350C40", Offset = "0x1350C40", VA = "0x1350C40", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F207")]
	[Address(RVA = "0x1350FB8", Offset = "0x1350FB8", VA = "0x1350FB8")]
	private void InitShopItems()
	{
	}

	[Token(Token = "0x600F208")]
	[Address(RVA = "0x13519C8", Offset = "0x13519C8", VA = "0x13519C8")]
	private JAOADEMOBHH PrecheckForBuy(MCOMKOKDDHE itemInfo)
	{
		return default(JAOADEMOBHH);
	}

	[Token(Token = "0x600F209")]
	[Address(RVA = "0x13516BC", Offset = "0x13516BC", VA = "0x13516BC")]
	private void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
	{
	}

	[Token(Token = "0x600F20A")]
	[Address(RVA = "0x1351AAC", Offset = "0x1351AAC", VA = "0x1351AAC", Slot = "34")]
	protected override void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600F20B")]
	[Address(RVA = "0x1352450", Offset = "0x1352450", VA = "0x1352450")]
	private void ShowBuyResult(JAOADEMOBHH buyResult)
	{
	}

	[Token(Token = "0x600F20C")]
	[Address(RVA = "0x1352AEC", Offset = "0x1352AEC", VA = "0x1352AEC", Slot = "36")]
	protected override void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F20D")]
	[Address(RVA = "0x1352B58", Offset = "0x1352B58", VA = "0x1352B58")]
	private void OnCoinBtnClick()
	{
	}

	[Token(Token = "0x600F20E")]
	[Address(RVA = "0x1353048", Offset = "0x1353048", VA = "0x1353048")]
	private void OnCapacityBtnClick()
	{
	}

	[Token(Token = "0x600F20F")]
	[Address(RVA = "0x1350DD8", Offset = "0x1350DD8", VA = "0x1350DD8")]
	private void ClearSelected()
	{
	}

	[Token(Token = "0x600F210")]
	[Address(RVA = "0x1353538", Offset = "0x1353538", VA = "0x1353538", Slot = "33")]
	protected override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600F211")]
	[Address(RVA = "0x1353808", Offset = "0x1353808", VA = "0x1353808")]
	private void OnLocalPlayerBeHurt(object[] data)
	{
	}

	[Token(Token = "0x600F212")]
	[Address(RVA = "0x13538F8", Offset = "0x13538F8", VA = "0x13538F8")]
	private void OnLocalPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x600F213")]
	[Address(RVA = "0x135396C", Offset = "0x135396C", VA = "0x135396C")]
	private void OnBuyResultSync(object[] data)
	{
	}

	[Token(Token = "0x600F214")]
	[Address(RVA = "0x1353A48", Offset = "0x1353A48", VA = "0x1353A48")]
	private void OnBagCapacityChanged(object[] data)
	{
	}

	[Token(Token = "0x600F215")]
	[Address(RVA = "0x135188C", Offset = "0x135188C", VA = "0x135188C")]
	private void UpdateBagCapacityText()
	{
	}

	[Token(Token = "0x600F216")]
	[Address(RVA = "0x1353C18", Offset = "0x1353C18", VA = "0x1353C18")]
	private static int _003CInitShopItems_003Em__0(Transform item1, Transform item2)
	{
		return default(int);
	}

	[Token(Token = "0x600F217")]
	[Address(RVA = "0x1353DD8", Offset = "0x1353DD8", VA = "0x1353DD8")]
	private void _003COnCoinBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x600F218")]
	[Address(RVA = "0x1353EA4", Offset = "0x1353EA4", VA = "0x1353EA4")]
	private void _003COnCapacityBtnClick_003Em__2()
	{
	}

	[Token(Token = "0x600F219")]
	[Address(RVA = "0x1353F70", Offset = "0x1353F70", VA = "0x1353F70")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F21A")]
	[Address(RVA = "0x1353F78", Offset = "0x1353F78", VA = "0x1353F78")]
	public void _003C_003EiFixBaseProxy_OnTokenChanged(object[] P0)
	{
	}

	[Token(Token = "0x600F21B")]
	[Address(RVA = "0x1353F80", Offset = "0x1353F80", VA = "0x1353F80")]
	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600F21C")]
	[Address(RVA = "0x1353F88", Offset = "0x1353F88", VA = "0x1353F88")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F21D")]
	[Address(RVA = "0x1353F90", Offset = "0x1353F90", VA = "0x1353F90")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F21E")]
	[Address(RVA = "0x1353F98", Offset = "0x1353F98", VA = "0x1353F98")]
	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600F21F")]
	[Address(RVA = "0x1353FA0", Offset = "0x1353FA0", VA = "0x1353FA0")]
	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F220")]
	[Address(RVA = "0x1353FA8", Offset = "0x1353FA8", VA = "0x1353FA8")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}
}
