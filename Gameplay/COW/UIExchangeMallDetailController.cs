using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021B3")]
public class UIExchangeMallDetailController : UIMallDetailBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20021B4")]
	private sealed class _003CUnSelectItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D304")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x600B3C5")]
		[Address(RVA = "0x19E2AA8", Offset = "0x19E2AA8", VA = "0x19E2AA8")]
		public _003CUnSelectItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B3C6")]
		[Address(RVA = "0x19E6230", Offset = "0x19E6230", VA = "0x19E6230")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20021B5")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D305")]
		[FieldOffset(Offset = "0x8")]
		internal uint storeID;

		[Token(Token = "0x600B3C7")]
		[Address(RVA = "0x19E48E8", Offset = "0x19E48E8", VA = "0x19E48E8")]
		public _003CNavigationToItem_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B3C8")]
		[Address(RVA = "0x19E61C0", Offset = "0x19E61C0", VA = "0x19E61C0")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc item)
		{
			return default(bool);
		}

		[Token(Token = "0x600B3C9")]
		[Address(RVA = "0x19E61F8", Offset = "0x19E61F8", VA = "0x19E61F8")]
		internal bool _003C_003Em__1(ExchangeStoreItemDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D2FE")]
	[FieldOffset(Offset = "0xB8")]
	private List<ExchangeStoreItemDesc> m_CurrentDataList;

	[Token(Token = "0x400D2FF")]
	[FieldOffset(Offset = "0xBC")]
	private uint m_BuyRankLevel;

	[Token(Token = "0x400D300")]
	[FieldOffset(Offset = "0xC0")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x400D301")]
	[FieldOffset(Offset = "0xC4")]
	private UITopButtonGroupController m_UITopButtonGroupController;

	[Token(Token = "0x400D302")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_ClanTokenGuideSwitch;

	[Token(Token = "0x400D303")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B388")]
	[Address(RVA = "0x19DF6F0", Offset = "0x19DF6F0", VA = "0x19DF6F0")]
	public UIExchangeMallDetailController()
	{
	}

	[Token(Token = "0x600B389")]
	[Address(RVA = "0x19DF7A8", Offset = "0x19DF7A8", VA = "0x19DF7A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B38A")]
	[Address(RVA = "0x19DF84C", Offset = "0x19DF84C", VA = "0x19DF84C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B38B")]
	[Address(RVA = "0x19DFC14", Offset = "0x19DFC14", VA = "0x19DFC14", Slot = "31")]
	protected override void InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B38C")]
	[Address(RVA = "0x19DFE24", Offset = "0x19DFE24", VA = "0x19DFE24", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B38D")]
	[Address(RVA = "0x19E004C", Offset = "0x19E004C", VA = "0x19E004C")]
	private void Update()
	{
	}

	[Token(Token = "0x600B38E")]
	[Address(RVA = "0x19E0370", Offset = "0x19E0370", VA = "0x19E0370")]
	private void OnExchangeCurrencyBtnClick(object[] data)
	{
	}

	[Token(Token = "0x600B38F")]
	[Address(RVA = "0x19E05C4", Offset = "0x19E05C4", VA = "0x19E05C4")]
	private void OnExchangeBuyBtnClick()
	{
	}

	[Token(Token = "0x600B390")]
	[Address(RVA = "0x19E0624", Offset = "0x19E0624", VA = "0x19E0624")]
	private void ExchangeItem()
	{
	}

	[Token(Token = "0x600B391")]
	[Address(RVA = "0x19E1354", Offset = "0x19E1354", VA = "0x19E1354", Slot = "35")]
	protected override bool CanFindStoreItem(uint storeID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B392")]
	[Address(RVA = "0x19E10E4", Offset = "0x19E10E4", VA = "0x19E10E4")]
	private void ShowExchangePurchasePopupWnd(ExchangeStoreItemDesc itemDesc)
	{
	}

	[Token(Token = "0x600B393")]
	[Address(RVA = "0x19E13E0", Offset = "0x19E13E0", VA = "0x19E13E0")]
	private bool IsReachRankMallBuyCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x600B394")]
	[Address(RVA = "0x19E0CB4", Offset = "0x19E0CB4", VA = "0x19E0CB4")]
	private bool IsReachClanMallBuyCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x600B395")]
	[Address(RVA = "0x19E19C4", Offset = "0x19E19C4", VA = "0x19E19C4", Slot = "32")]
	protected override void OnClothPreviewToggleClick()
	{
	}

	[Token(Token = "0x600B396")]
	[Address(RVA = "0x19E2098", Offset = "0x19E2098", VA = "0x19E2098", Slot = "58")]
	public override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B397")]
	[Address(RVA = "0x19E28FC", Offset = "0x19E28FC", VA = "0x19E28FC", Slot = "33")]
	protected override void UnSelectItem(uint itemID)
	{
	}

	[Token(Token = "0x600B398")]
	[Address(RVA = "0x19E21D8", Offset = "0x19E21D8", VA = "0x19E21D8")]
	private void RefreshItemView(uint commodityID)
	{
	}

	[Token(Token = "0x600B399")]
	[Address(RVA = "0x19E2C88", Offset = "0x19E2C88", VA = "0x19E2C88")]
	private void RefreshViewData(List<ExchangeStoreItemDesc> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x600B39A")]
	[Address(RVA = "0x19E2AB0", Offset = "0x19E2AB0", VA = "0x19E2AB0")]
	public void CheckRankLevel(uint itemID)
	{
	}

	[Token(Token = "0x600B39B")]
	[Address(RVA = "0x19E1758", Offset = "0x19E1758", VA = "0x19E1758")]
	private bool IsReachClanLevel(uint commodityID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B39C")]
	[Address(RVA = "0x19E3138", Offset = "0x19E3138", VA = "0x19E3138", Slot = "72")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B39D")]
	[Address(RVA = "0x19E31F0", Offset = "0x19E31F0", VA = "0x19E31F0", Slot = "71")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B39E")]
	[Address(RVA = "0x19E3534", Offset = "0x19E3534", VA = "0x19E3534", Slot = "69")]
	protected override void OnCommonWndFinish(object[] data)
	{
	}

	[Token(Token = "0x600B39F")]
	[Address(RVA = "0x19E3610", Offset = "0x19E3610", VA = "0x19E3610", Slot = "36")]
	public override void HighlightCurrent()
	{
	}

	[Token(Token = "0x600B3A0")]
	[Address(RVA = "0x19E3884", Offset = "0x19E3884", VA = "0x19E3884", Slot = "59")]
	public override void InitMallView()
	{
	}

	[Token(Token = "0x600B3A1")]
	[Address(RVA = "0x19E3DD0", Offset = "0x19E3DD0", VA = "0x19E3DD0", Slot = "60")]
	public override void RefreshMallView()
	{
	}

	[Token(Token = "0x600B3A2")]
	[Address(RVA = "0x19E391C", Offset = "0x19E391C", VA = "0x19E391C")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x600B3A3")]
	[Address(RVA = "0x19E3E5C", Offset = "0x19E3E5C", VA = "0x19E3E5C", Slot = "73")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B3A4")]
	[Address(RVA = "0x19E4084", Offset = "0x19E4084", VA = "0x19E4084", Slot = "74")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B3A5")]
	[Address(RVA = "0x19E3350", Offset = "0x19E3350", VA = "0x19E3350")]
	private void RefreshExchangeNum()
	{
	}

	[Token(Token = "0x600B3A6")]
	[Address(RVA = "0x19E4100", Offset = "0x19E4100", VA = "0x19E4100", Slot = "62")]
	public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
	{
	}

	[Token(Token = "0x600B3A7")]
	[Address(RVA = "0x19E48F0", Offset = "0x19E48F0", VA = "0x19E48F0")]
	private void OnExchangeTabSelected()
	{
	}

	[Token(Token = "0x600B3A8")]
	[Address(RVA = "0x19E55C8", Offset = "0x19E55C8", VA = "0x19E55C8", Slot = "56")]
	protected override void ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B3A9")]
	[Address(RVA = "0x19E56EC", Offset = "0x19E56EC", VA = "0x19E56EC", Slot = "34")]
	protected override void SetClothPreviewTabInfo(PreviewTabInfo tabInfo, CSSharedItemData itemData)
	{
	}

	[Token(Token = "0x600B3AA")]
	[Address(RVA = "0x19E5778", Offset = "0x19E5778", VA = "0x19E5778", Slot = "39")]
	protected override void AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B3AB")]
	[Address(RVA = "0x19E59E4", Offset = "0x19E59E4", VA = "0x19E59E4", Slot = "57")]
	protected override string GetMallTabName(uint type)
	{
		return null;
	}

	[Token(Token = "0x600B3AC")]
	[Address(RVA = "0x19E5B6C", Offset = "0x19E5B6C", VA = "0x19E5B6C", Slot = "63")]
	public override void RefreshCurrentMallView(bool clickItem)
	{
	}

	[Token(Token = "0x600B3AD")]
	[Address(RVA = "0x19E5CC4", Offset = "0x19E5CC4", VA = "0x19E5CC4", Slot = "64")]
	public override UIEasyList GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B3AE")]
	[Address(RVA = "0x19E5DF8", Offset = "0x19E5DF8", VA = "0x19E5DF8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B3AF")]
	[Address(RVA = "0x19E5F28", Offset = "0x19E5F28", VA = "0x19E5F28")]
	public void SetTopBtnGroupCtrl(UITopButtonGroupController uITopButtonGroupController)
	{
	}

	[Token(Token = "0x600B3B0")]
	[Address(RVA = "0x19E5F88", Offset = "0x19E5F88", VA = "0x19E5F88")]
	private bool _003CHighlightCurrent_003Em__0(ExchangeStoreItemDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B3B1")]
	[Address(RVA = "0x19E5FC0", Offset = "0x19E5FC0", VA = "0x19E5FC0")]
	private static bool _003CUpdateTabs_003Em__1(uint t)
	{
		return default(bool);
	}

	[Token(Token = "0x600B3B2")]
	[Address(RVA = "0x19E5FEC", Offset = "0x19E5FEC", VA = "0x19E5FEC")]
	private void _003COnExchangeTabSelected_003Em__2()
	{
	}

	[Token(Token = "0x600B3B3")]
	[Address(RVA = "0x19E6118", Offset = "0x19E6118", VA = "0x19E6118")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B3B4")]
	[Address(RVA = "0x19E6120", Offset = "0x19E6120", VA = "0x19E6120")]
	public void _003C_003EiFixBaseProxy_InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B3B5")]
	[Address(RVA = "0x19E6128", Offset = "0x19E6128", VA = "0x19E6128")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B3B6")]
	[Address(RVA = "0x19E6130", Offset = "0x19E6130", VA = "0x19E6130")]
	public bool _003C_003EiFixBaseProxy_CanFindStoreItem(uint P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600B3B7")]
	[Address(RVA = "0x19E6138", Offset = "0x19E6138", VA = "0x19E6138")]
	public void _003C_003EiFixBaseProxy_OnClothPreviewToggleClick()
	{
	}

	[Token(Token = "0x600B3B8")]
	[Address(RVA = "0x19E6140", Offset = "0x19E6140", VA = "0x19E6140")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	[Token(Token = "0x600B3B9")]
	[Address(RVA = "0x19E6148", Offset = "0x19E6148", VA = "0x19E6148")]
	public void _003C_003EiFixBaseProxy_UnSelectItem(uint P0)
	{
	}

	[Token(Token = "0x600B3BA")]
	[Address(RVA = "0x19E6150", Offset = "0x19E6150", VA = "0x19E6150")]
	public void _003C_003EiFixBaseProxy_OnCommonWndFinish(object[] P0)
	{
	}

	[Token(Token = "0x600B3BB")]
	[Address(RVA = "0x19E6158", Offset = "0x19E6158", VA = "0x19E6158")]
	public void _003C_003EiFixBaseProxy_HighlightCurrent()
	{
	}

	[Token(Token = "0x600B3BC")]
	[Address(RVA = "0x19E6160", Offset = "0x19E6160", VA = "0x19E6160")]
	public void _003C_003EiFixBaseProxy_InitMallView()
	{
	}

	[Token(Token = "0x600B3BD")]
	[Address(RVA = "0x19E6168", Offset = "0x19E6168", VA = "0x19E6168")]
	public void _003C_003EiFixBaseProxy_RefreshMallView()
	{
	}

	[Token(Token = "0x600B3BE")]
	[Address(RVA = "0x19E6170", Offset = "0x19E6170", VA = "0x19E6170")]
	public void _003C_003EiFixBaseProxy_NavigationToItem(uint P0, uint P1, uint P2)
	{
	}

	[Token(Token = "0x600B3BF")]
	[Address(RVA = "0x19E6190", Offset = "0x19E6190", VA = "0x19E6190")]
	public void _003C_003EiFixBaseProxy_ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B3C0")]
	[Address(RVA = "0x19E6198", Offset = "0x19E6198", VA = "0x19E6198")]
	public void _003C_003EiFixBaseProxy_SetClothPreviewTabInfo(PreviewTabInfo P0, CSSharedItemData P1)
	{
	}

	[Token(Token = "0x600B3C1")]
	[Address(RVA = "0x19E61A0", Offset = "0x19E61A0", VA = "0x19E61A0")]
	public void _003C_003EiFixBaseProxy_AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B3C2")]
	[Address(RVA = "0x19E61A8", Offset = "0x19E61A8", VA = "0x19E61A8")]
	public string _003C_003EiFixBaseProxy_GetMallTabName(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600B3C3")]
	[Address(RVA = "0x19E61B0", Offset = "0x19E61B0", VA = "0x19E61B0")]
	public UIEasyList _003C_003EiFixBaseProxy_GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B3C4")]
	[Address(RVA = "0x19E61B8", Offset = "0x19E61B8", VA = "0x19E61B8")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
