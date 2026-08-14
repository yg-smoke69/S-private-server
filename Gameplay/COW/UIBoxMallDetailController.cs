using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021AD")]
public class UIBoxMallDetailController : UIMallDetailBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20021AE")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D2F2")]
		[FieldOffset(Offset = "0x8")]
		internal uint mallSubType;

		[Token(Token = "0x400D2F3")]
		[FieldOffset(Offset = "0xC")]
		internal uint storeID;

		[Token(Token = "0x600B34C")]
		[Address(RVA = "0x10DC330", Offset = "0x10DC330", VA = "0x10DC330")]
		public _003CNavigationToItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B34D")]
		[Address(RVA = "0x10DE45C", Offset = "0x10DE45C", VA = "0x10DE45C")]
		internal bool _003C_003Em__0(SubTabInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x600B34E")]
		[Address(RVA = "0x10DE494", Offset = "0x10DE494", VA = "0x10DE494")]
		internal bool _003C_003Em__1(StoreDesc item)
		{
			return default(bool);
		}

		[Token(Token = "0x600B34F")]
		[Address(RVA = "0x10DE4CC", Offset = "0x10DE4CC", VA = "0x10DE4CC")]
		internal bool _003C_003Em__2(StoreDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D2EF")]
	[FieldOffset(Offset = "0xB8")]
	private UICommonGuideController m_GoExchangeGuide;

	[Token(Token = "0x400D2F0")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_PurchaseSuccess;

	[Token(Token = "0x400D2F1")]
	[FieldOffset(Offset = "0xC0")]
	private List<StoreDesc> m_CurrentDataList;

	[Token(Token = "0x600B31E")]
	[Address(RVA = "0x10D9C28", Offset = "0x10D9C28", VA = "0x10D9C28")]
	public UIBoxMallDetailController()
	{
	}

	[Token(Token = "0x600B31F")]
	[Address(RVA = "0x10D9CE0", Offset = "0x10D9CE0", VA = "0x10D9CE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B320")]
	[Address(RVA = "0x10D9D84", Offset = "0x10D9D84", VA = "0x10D9D84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B321")]
	[Address(RVA = "0x10DA23C", Offset = "0x10DA23C", VA = "0x10DA23C", Slot = "31")]
	protected override void InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B322")]
	[Address(RVA = "0x10DAEE0", Offset = "0x10DAEE0", VA = "0x10DAEE0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B323")]
	[Address(RVA = "0x10DB010", Offset = "0x10DB010", VA = "0x10DB010")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x600B324")]
	[Address(RVA = "0x10DB4A0", Offset = "0x10DB4A0", VA = "0x10DB4A0")]
	private void RefreshViewData(List<StoreDesc> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x600B325")]
	[Address(RVA = "0x10DB5E4", Offset = "0x10DB5E4", VA = "0x10DB5E4", Slot = "59")]
	public override void InitMallView()
	{
	}

	[Token(Token = "0x600B326")]
	[Address(RVA = "0x10DB7D0", Offset = "0x10DB7D0", VA = "0x10DB7D0", Slot = "60")]
	public override void RefreshMallView()
	{
	}

	[Token(Token = "0x600B327")]
	[Address(RVA = "0x10DB650", Offset = "0x10DB650", VA = "0x10DB650")]
	private void UpdateTabs()
	{
	}

	[Token(Token = "0x600B328")]
	[Address(RVA = "0x10DB83C", Offset = "0x10DB83C", VA = "0x10DB83C", Slot = "35")]
	protected override bool CanFindStoreItem(uint storeID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B329")]
	[Address(RVA = "0x10DB8C8", Offset = "0x10DB8C8", VA = "0x10DB8C8", Slot = "71")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B32A")]
	[Address(RVA = "0x10DB9C0", Offset = "0x10DB9C0", VA = "0x10DB9C0", Slot = "36")]
	public override void HighlightCurrent()
	{
	}

	[Token(Token = "0x600B32B")]
	[Address(RVA = "0x10DBB8C", Offset = "0x10DBB8C", VA = "0x10DBB8C", Slot = "72")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B32C")]
	[Address(RVA = "0x10DBC08", Offset = "0x10DBC08", VA = "0x10DBC08", Slot = "62")]
	public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
	{
	}

	[Token(Token = "0x600B32D")]
	[Address(RVA = "0x10DC338", Offset = "0x10DC338", VA = "0x10DC338")]
	private void OnBoxToggleSelected()
	{
	}

	[Token(Token = "0x600B32E")]
	[Address(RVA = "0x10DC6E4", Offset = "0x10DC6E4", VA = "0x10DC6E4", Slot = "39")]
	protected override void AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B32F")]
	[Address(RVA = "0x10DC950", Offset = "0x10DC950", VA = "0x10DC950", Slot = "57")]
	protected override string GetMallTabName(uint type)
	{
		return null;
	}

	[Token(Token = "0x600B330")]
	[Address(RVA = "0x10DC9D8", Offset = "0x10DC9D8", VA = "0x10DC9D8", Slot = "56")]
	protected override void ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B331")]
	[Address(RVA = "0x10DCA94", Offset = "0x10DCA94", VA = "0x10DCA94", Slot = "74")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B332")]
	[Address(RVA = "0x10DCB28", Offset = "0x10DCB28", VA = "0x10DCB28", Slot = "73")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B333")]
	[Address(RVA = "0x10DCC1C", Offset = "0x10DCC1C", VA = "0x10DCC1C", Slot = "58")]
	public override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B334")]
	[Address(RVA = "0x10DCD64", Offset = "0x10DCD64", VA = "0x10DCD64")]
	private void RefreshItemView(uint storeID)
	{
	}

	[Token(Token = "0x600B335")]
	[Address(RVA = "0x10DDA24", Offset = "0x10DDA24", VA = "0x10DDA24", Slot = "53")]
	public override void HideItemEffect()
	{
	}

	[Token(Token = "0x600B336")]
	[Address(RVA = "0x10DD49C", Offset = "0x10DD49C", VA = "0x10DD49C")]
	private void RefreshBtnGoExchangeState()
	{
	}

	[Token(Token = "0x600B337")]
	[Address(RVA = "0x10DDBE0", Offset = "0x10DDBE0", VA = "0x10DDBE0")]
	private void OnGoToDiscountBtnClick()
	{
	}

	[Token(Token = "0x600B338")]
	[Address(RVA = "0x10DDC7C", Offset = "0x10DDC7C", VA = "0x10DDC7C", Slot = "69")]
	protected override void OnCommonWndFinish(object[] data)
	{
	}

	[Token(Token = "0x600B339")]
	[Address(RVA = "0x10DDEF0", Offset = "0x10DDEF0", VA = "0x10DDEF0", Slot = "63")]
	public override void RefreshCurrentMallView(bool clickItem)
	{
	}

	[Token(Token = "0x600B33A")]
	[Address(RVA = "0x10DDD60", Offset = "0x10DDD60", VA = "0x10DDD60")]
	private void ShowOfferPurchase()
	{
	}

	[Token(Token = "0x600B33B")]
	[Address(RVA = "0x10DDF7C", Offset = "0x10DDF7C", VA = "0x10DDF7C")]
	public void OnBtnGoExchangeClick()
	{
	}

	[Token(Token = "0x600B33C")]
	[Address(RVA = "0x10DE364", Offset = "0x10DE364", VA = "0x10DE364")]
	private bool _003CHighlightCurrent_003Em__0(StoreDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B33D")]
	[Address(RVA = "0x10DE39C", Offset = "0x10DE39C", VA = "0x10DE39C")]
	private bool _003CHighlightCurrent_003Em__1(StoreDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x600B33E")]
	[Address(RVA = "0x10DE3D4", Offset = "0x10DE3D4", VA = "0x10DE3D4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B33F")]
	[Address(RVA = "0x10DE3DC", Offset = "0x10DE3DC", VA = "0x10DE3DC")]
	public void _003C_003EiFixBaseProxy_InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B340")]
	[Address(RVA = "0x10DE3E4", Offset = "0x10DE3E4", VA = "0x10DE3E4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B341")]
	[Address(RVA = "0x10DE3EC", Offset = "0x10DE3EC", VA = "0x10DE3EC")]
	public void _003C_003EiFixBaseProxy_InitMallView()
	{
	}

	[Token(Token = "0x600B342")]
	[Address(RVA = "0x10DE3F4", Offset = "0x10DE3F4", VA = "0x10DE3F4")]
	public void _003C_003EiFixBaseProxy_RefreshMallView()
	{
	}

	[Token(Token = "0x600B343")]
	[Address(RVA = "0x10DE3FC", Offset = "0x10DE3FC", VA = "0x10DE3FC")]
	public bool _003C_003EiFixBaseProxy_CanFindStoreItem(uint P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600B344")]
	[Address(RVA = "0x10DE404", Offset = "0x10DE404", VA = "0x10DE404")]
	public void _003C_003EiFixBaseProxy_HighlightCurrent()
	{
	}

	[Token(Token = "0x600B345")]
	[Address(RVA = "0x10DE40C", Offset = "0x10DE40C", VA = "0x10DE40C")]
	public void _003C_003EiFixBaseProxy_NavigationToItem(uint P0, uint P1, uint P2)
	{
	}

	[Token(Token = "0x600B346")]
	[Address(RVA = "0x10DE42C", Offset = "0x10DE42C", VA = "0x10DE42C")]
	public void _003C_003EiFixBaseProxy_AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B347")]
	[Address(RVA = "0x10DE434", Offset = "0x10DE434", VA = "0x10DE434")]
	public string _003C_003EiFixBaseProxy_GetMallTabName(uint P0)
	{
		return null;
	}

	[Token(Token = "0x600B348")]
	[Address(RVA = "0x10DE43C", Offset = "0x10DE43C", VA = "0x10DE43C")]
	public void _003C_003EiFixBaseProxy_ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B349")]
	[Address(RVA = "0x10DE444", Offset = "0x10DE444", VA = "0x10DE444")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}

	[Token(Token = "0x600B34A")]
	[Address(RVA = "0x10DE44C", Offset = "0x10DE44C", VA = "0x10DE44C")]
	public void _003C_003EiFixBaseProxy_HideItemEffect()
	{
	}

	[Token(Token = "0x600B34B")]
	[Address(RVA = "0x10DE454", Offset = "0x10DE454", VA = "0x10DE454")]
	public void _003C_003EiFixBaseProxy_OnCommonWndFinish(object[] P0)
	{
	}
}
