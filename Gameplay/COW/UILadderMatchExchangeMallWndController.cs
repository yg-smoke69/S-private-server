using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002158")]
public class UILadderMatchExchangeMallWndController : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002159")]
	public enum EMallDisplayType
	{
		[Token(Token = "0x400D176")]
		HIDESEASONTOGGLE,
		[Token(Token = "0x400D177")]
		CURRENTSEASON,
		[Token(Token = "0x400D178")]
		PERVIOUSSEASON
	}

	[Token(Token = "0x200215A")]
	public enum EExchangeItemState
	{
		[Token(Token = "0x400D17A")]
		OWNITEM_CAN_PURCHASE,
		[Token(Token = "0x400D17B")]
		OWNITEM_NO_PURCHASE,
		[Token(Token = "0x400D17C")]
		NO_OWNITEM_NO_PURCHASE,
		[Token(Token = "0x400D17D")]
		NO_REACH_CS_RANKLIMIT,
		[Token(Token = "0x400D17E")]
		NO_REACH_BR_RANKLIMIT,
		[Token(Token = "0x400D17F")]
		NO_REACH_BR_CS_RANKLIMIT,
		[Token(Token = "0x400D180")]
		NO_OWNITEM_CAN_PURCHASE,
		[Token(Token = "0x400D181")]
		NO_ITEM_SELECT
	}

	[Token(Token = "0x200215B")]
	private sealed class _003COnDataChanged_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D182")]
		[FieldOffset(Offset = "0x8")]
		internal uint selectItemID;

		[Token(Token = "0x600B03B")]
		[Address(RVA = "0x1AECF78", Offset = "0x1AECF78", VA = "0x1AECF78")]
		public _003COnDataChanged_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B03C")]
		[Address(RVA = "0x1AED134", Offset = "0x1AED134", VA = "0x1AED134")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc t)
		{
			return default(bool);
		}

		[Token(Token = "0x600B03D")]
		[Address(RVA = "0x1AED168", Offset = "0x1AED168", VA = "0x1AED168")]
		internal bool _003C_003Em__1(ExchangeStoreItemDesc t)
		{
			return default(bool);
		}

		[Token(Token = "0x600B03E")]
		[Address(RVA = "0x1AED19C", Offset = "0x1AED19C", VA = "0x1AED19C")]
		internal bool _003C_003Em__2(ExchangeStoreItemDesc t)
		{
			return default(bool);
		}

		[Token(Token = "0x600B03F")]
		[Address(RVA = "0x1AED1D0", Offset = "0x1AED1D0", VA = "0x1AED1D0")]
		internal bool _003C_003Em__3(ExchangeStoreItemDesc t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D164")]
	[FieldOffset(Offset = "0x7C")]
	private UILadderMatchExchangeMallView m_View;

	[Token(Token = "0x400D165")]
	[FieldOffset(Offset = "0x80")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400D166")]
	[FieldOffset(Offset = "0x84")]
	private UIModelLadderMatch m_ModelLadderMatchBR;

	[Token(Token = "0x400D167")]
	[FieldOffset(Offset = "0x88")]
	private UIModelCSLadderMatch m_ModelLadderMatchCS;

	[Token(Token = "0x400D168")]
	[FieldOffset(Offset = "0x8C")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D169")]
	[FieldOffset(Offset = "0x90")]
	private int m_DisplayListColumnCnt;

	[Token(Token = "0x400D16A")]
	[FieldOffset(Offset = "0x94")]
	private uint m_CurrentItemCSRankLimit;

	[Token(Token = "0x400D16B")]
	[FieldOffset(Offset = "0x98")]
	private uint m_CurrentItemBRRankLimit;

	[Token(Token = "0x400D16C")]
	[FieldOffset(Offset = "0x9C")]
	private List<ExchangeStoreItemDesc> m_CurrentSeasonItemList;

	[Token(Token = "0x400D16D")]
	[FieldOffset(Offset = "0xA0")]
	private List<ExchangeStoreItemDesc> m_PreviousSeasonItemList;

	[Token(Token = "0x400D16E")]
	[FieldOffset(Offset = "0xA4")]
	private ExchangeStoreItemDesc m_CurrentSelectItemDesc;

	[Token(Token = "0x400D16F")]
	[FieldOffset(Offset = "0xA8")]
	private ExchangeStoreItemDesc m_NullStoreItem;

	[Token(Token = "0x400D170")]
	[FieldOffset(Offset = "0xAC")]
	private RankExchangeDisplayDesc m_ExchangeStoreDisplayItem;

	[Token(Token = "0x400D171")]
	private const string RANK_PREFIX = "Rank_";

	[Token(Token = "0x400D172")]
	[FieldOffset(Offset = "0xB0")]
	private EMallDisplayType m_CurrentDisplayMode;

	[Token(Token = "0x400D173")]
	[FieldOffset(Offset = "0xB4")]
	private EExchangeItemState m_CurrentSelectItemState;

	[Token(Token = "0x400D174")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_HasSelectItemBefore;

	[Token(Token = "0x600B015")]
	[Address(RVA = "0x1AE7AA4", Offset = "0x1AE7AA4", VA = "0x1AE7AA4")]
	public UILadderMatchExchangeMallWndController()
	{
	}

	[Token(Token = "0x600B016")]
	[Address(RVA = "0x1AE7B8C", Offset = "0x1AE7B8C", VA = "0x1AE7B8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B017")]
	[Address(RVA = "0x1AE7C34", Offset = "0x1AE7C34", VA = "0x1AE7C34", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B018")]
	[Address(RVA = "0x1AE80E4", Offset = "0x1AE80E4", VA = "0x1AE80E4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600B019")]
	[Address(RVA = "0x1AE83B0", Offset = "0x1AE83B0", VA = "0x1AE83B0", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600B01A")]
	[Address(RVA = "0x1AE8414", Offset = "0x1AE8414", VA = "0x1AE8414", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600B01B")]
	[Address(RVA = "0x1AE8484", Offset = "0x1AE8484", VA = "0x1AE8484", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600B01C")]
	[Address(RVA = "0x1AE84DC", Offset = "0x1AE84DC", VA = "0x1AE84DC")]
	private void RefreshStoreItemEasyList(List<ExchangeStoreItemDesc> dataList, EMallDisplayType displayType)
	{
	}

	[Token(Token = "0x600B01D")]
	[Address(RVA = "0x1AE8D68", Offset = "0x1AE8D68", VA = "0x1AE8D68")]
	private void RefreshCurrencyCount()
	{
	}

	[Token(Token = "0x600B01E")]
	[Address(RVA = "0x1AE82B0", Offset = "0x1AE82B0", VA = "0x1AE82B0")]
	public void InitDataAndUI()
	{
	}

	[Token(Token = "0x600B01F")]
	[Address(RVA = "0x1AE968C", Offset = "0x1AE968C", VA = "0x1AE968C")]
	public void InitBigPrizePreviewItemCDN()
	{
	}

	[Token(Token = "0x600B020")]
	[Address(RVA = "0x1AE952C", Offset = "0x1AE952C", VA = "0x1AE952C")]
	public void InitSeasonBGCDN()
	{
	}

	[Token(Token = "0x600B021")]
	[Address(RVA = "0x1AE8E54", Offset = "0x1AE8E54", VA = "0x1AE8E54")]
	public void UpdateLatestExchangeItemData()
	{
	}

	[Token(Token = "0x600B022")]
	[Address(RVA = "0x1AE937C", Offset = "0x1AE937C", VA = "0x1AE937C")]
	public void InitNullStoreItem()
	{
	}

	[Token(Token = "0x600B023")]
	[Address(RVA = "0x1AE8C78", Offset = "0x1AE8C78", VA = "0x1AE8C78")]
	public void AddNullDataToRankExchangeStoreList(int num, List<ExchangeStoreItemDesc> list)
	{
	}

	[Token(Token = "0x600B024")]
	[Address(RVA = "0x1AE9458", Offset = "0x1AE9458", VA = "0x1AE9458")]
	private void InitStoreDisplayMode()
	{
	}

	[Token(Token = "0x600B025")]
	[Address(RVA = "0x1AE9D24", Offset = "0x1AE9D24", VA = "0x1AE9D24")]
	private void RefreshToggleView()
	{
	}

	[Token(Token = "0x600B026")]
	[Address(RVA = "0x1AEA020", Offset = "0x1AEA020", VA = "0x1AEA020")]
	private void OnSelectNormalToggle()
	{
	}

	[Token(Token = "0x600B027")]
	[Address(RVA = "0x1AEA11C", Offset = "0x1AEA11C", VA = "0x1AEA11C")]
	private void OnSelectPreviousSeasonToggle()
	{
	}

	[Token(Token = "0x600B028")]
	[Address(RVA = "0x1AEA218", Offset = "0x1AEA218", VA = "0x1AEA218")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600B029")]
	[Address(RVA = "0x1AEA324", Offset = "0x1AEA324", VA = "0x1AEA324")]
	private void OnExchangeItemClickEventReceive(object[] data)
	{
	}

	[Token(Token = "0x600B02A")]
	[Address(RVA = "0x1AE9B68", Offset = "0x1AE9B68", VA = "0x1AE9B68")]
	private void RefreshCurrentItemView(ExchangeStoreItemDesc desc)
	{
	}

	[Token(Token = "0x600B02B")]
	[Address(RVA = "0x1AEB438", Offset = "0x1AEB438", VA = "0x1AEB438")]
	private bool IsUniqueItem(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B02C")]
	[Address(RVA = "0x1AEB554", Offset = "0x1AEB554", VA = "0x1AEB554")]
	private bool IsItemOwn(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B02D")]
	[Address(RVA = "0x1AEB6BC", Offset = "0x1AEB6BC", VA = "0x1AEB6BC")]
	private bool IsReachRankLimit(ExchangeStoreItemDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x600B02E")]
	[Address(RVA = "0x1AEA48C", Offset = "0x1AEA48C", VA = "0x1AEA48C")]
	private void UpdateCurrentSelectItemState(ExchangeStoreItemDesc desc)
	{
	}

	[Token(Token = "0x600B02F")]
	[Address(RVA = "0x1AEB928", Offset = "0x1AEB928", VA = "0x1AEB928")]
	private void ShowNormalPurchaseBG(bool value)
	{
	}

	[Token(Token = "0x600B030")]
	[Address(RVA = "0x1AEA6AC", Offset = "0x1AEA6AC", VA = "0x1AEA6AC")]
	private void UpdateLimitedCountLabel(ExchangeStoreItemDesc exchangeItemDesc)
	{
	}

	[Token(Token = "0x600B031")]
	[Address(RVA = "0x1AEAA4C", Offset = "0x1AEAA4C", VA = "0x1AEAA4C")]
	private void UpdateExchangeBtnView(EExchangeItemState state)
	{
	}

	[Token(Token = "0x600B032")]
	[Address(RVA = "0x1AEBABC", Offset = "0x1AEBABC", VA = "0x1AEBABC")]
	private void OnExchangeBtnClick()
	{
	}

	[Token(Token = "0x600B033")]
	[Address(RVA = "0x1AEC960", Offset = "0x1AEC960", VA = "0x1AEC960")]
	private void ShowExchangePurchasePopupWnd(ExchangeStoreItemDesc itemDesc)
	{
	}

	[Token(Token = "0x600B034")]
	[Address(RVA = "0x1AECAA8", Offset = "0x1AECAA8", VA = "0x1AECAA8", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B035")]
	[Address(RVA = "0x1AECB3C", Offset = "0x1AECB3C", VA = "0x1AECB3C", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B036")]
	[Address(RVA = "0x1AECF80", Offset = "0x1AECF80", VA = "0x1AECF80", Slot = "67")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B037")]
	[Address(RVA = "0x1AECFFC", Offset = "0x1AECFFC", VA = "0x1AECFFC", Slot = "66")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B038")]
	[Address(RVA = "0x1AED11C", Offset = "0x1AED11C", VA = "0x1AED11C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B039")]
	[Address(RVA = "0x1AED124", Offset = "0x1AED124", VA = "0x1AED124")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600B03A")]
	[Address(RVA = "0x1AED12C", Offset = "0x1AED12C", VA = "0x1AED12C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
