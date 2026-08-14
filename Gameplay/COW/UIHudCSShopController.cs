using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200204C")]
internal class UIHudCSShopController : UIHudInGameShopBaseController, _Attribute
{
	[Token(Token = "0x400CA67")]
	[FieldOffset(Offset = "0x34")]
	private List<uint> m_ChoosedItemList;

	[Token(Token = "0x400CA68")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, UIHudCSEquipCategoryController> m_CategroyMap;

	[Token(Token = "0x400CA69")]
	[FieldOffset(Offset = "0x3C")]
	private uint MYSTERYBOX_FILTER;

	[Token(Token = "0x400CA6A")]
	[FieldOffset(Offset = "0x40")]
	private uint m_FirstCategoryFilter;

	[Token(Token = "0x400CA6B")]
	[FieldOffset(Offset = "0x44")]
	private UIHudAskPurchaseListController m_AskListCtrl;

	[Token(Token = "0x400CA6C")]
	[FieldOffset(Offset = "0x48")]
	private List<UIPanel> m_Panels;

	[Token(Token = "0x400CA6D")]
	[FieldOffset(Offset = "0x4C")]
	private bool _003CIsInShowPhase_003Ek__BackingField;

	[Token(Token = "0x400CA6E")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_MysteryBoxDataDirty;

	[Token(Token = "0x400CA6F")]
	[FieldOffset(Offset = "0x50")]
	private TweenPosition m_ShopTweenPosition;

	[Token(Token = "0x400CA70")]
	[FieldOffset(Offset = "0x54")]
	private uint m_ItemIndex;

	[Token(Token = "0x400CA71")]
	[FieldOffset(Offset = "0x58")]
	private bool isRequestFilled;

	[Token(Token = "0x400CA72")]
	[FieldOffset(Offset = "0x59")]
	private bool m_IsResetToTop;

	[Token(Token = "0x400CA73")]
	[FieldOffset(Offset = "0x5A")]
	private bool m_HideByPanel;

	[Token(Token = "0x17000FD8")]
	public bool IsInShowPhase
	{
		[Token(Token = "0x600A458")]
		[Address(RVA = "0x2137950", Offset = "0x2137950", VA = "0x2137950")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A459")]
		[Address(RVA = "0x2137958", Offset = "0x2137958", VA = "0x2137958")]
		set
		{
		}
	}

	[Token(Token = "0x17000FD9")]
	protected bool IsShowHideByPanelEnabled
	{
		[Token(Token = "0x600A46F")]
		[Address(RVA = "0x213B77C", Offset = "0x213B77C", VA = "0x213B77C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A457")]
	[Address(RVA = "0x2137880", Offset = "0x2137880", VA = "0x2137880")]
	public UIHudCSShopController()
	{
	}

	[Token(Token = "0x600A45A")]
	[Address(RVA = "0x2137960", Offset = "0x2137960", VA = "0x2137960")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A45B")]
	[Address(RVA = "0x2137A08", Offset = "0x2137A08", VA = "0x2137A08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A45C")]
	[Address(RVA = "0x2138898", Offset = "0x2138898", VA = "0x2138898")]
	private void OnShowCSGuideSecondWeaponBuy(object[] data)
	{
	}

	[Token(Token = "0x600A45D")]
	[Address(RVA = "0x2138A94", Offset = "0x2138A94", VA = "0x2138A94")]
	private void OnShowCSGuideStoreGold(object[] data)
	{
	}

	[Token(Token = "0x600A45E")]
	[Address(RVA = "0x2138BB4", Offset = "0x2138BB4", VA = "0x2138BB4")]
	private void OnShowCSGuideStoreArmorBuy(object[] data)
	{
	}

	[Token(Token = "0x600A45F")]
	[Address(RVA = "0x2138DB0", Offset = "0x2138DB0", VA = "0x2138DB0")]
	private void OnAniFinishedShowGoldGuide()
	{
	}

	[Token(Token = "0x600A460")]
	[Address(RVA = "0x2138F18", Offset = "0x2138F18", VA = "0x2138F18")]
	private void OnShowCSGuideStoreArmorItem(object[] data)
	{
	}

	[Token(Token = "0x600A461")]
	[Address(RVA = "0x213928C", Offset = "0x213928C", VA = "0x213928C")]
	private void OnShowCSGuideStoreWeaponClose(object[] data)
	{
	}

	[Token(Token = "0x600A462")]
	[Address(RVA = "0x2139444", Offset = "0x2139444", VA = "0x2139444")]
	private void OnShowCSGuideStoreWeaponBuy(object[] data)
	{
	}

	[Token(Token = "0x600A463")]
	[Address(RVA = "0x2139640", Offset = "0x2139640", VA = "0x2139640")]
	private void OnAniFinishedShowWeaponGuide()
	{
	}

	[Token(Token = "0x600A464")]
	[Address(RVA = "0x2139938", Offset = "0x2139938", VA = "0x2139938")]
	private void OnAniFinishedShowSecondWeaponGuide()
	{
	}

	[Token(Token = "0x600A465")]
	[Address(RVA = "0x2139C30", Offset = "0x2139C30", VA = "0x2139C30")]
	private void OnShowCSGuideSecondWeaponItem(object[] data)
	{
	}

	[Token(Token = "0x600A466")]
	[Address(RVA = "0x2139D48", Offset = "0x2139D48", VA = "0x2139D48")]
	private void OnShowCSGuideStoreWeaponItem(object[] data)
	{
	}

	[Token(Token = "0x600A467")]
	[Address(RVA = "0x2139E60", Offset = "0x2139E60", VA = "0x2139E60", Slot = "31")]
	protected override void OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600A468")]
	[Address(RVA = "0x213A45C", Offset = "0x213A45C", VA = "0x213A45C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A469")]
	[Address(RVA = "0x213A94C", Offset = "0x213A94C", VA = "0x213A94C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A46A")]
	[Address(RVA = "0x213B7E0", Offset = "0x213B7E0", VA = "0x213B7E0", Slot = "40")]
	protected virtual void SetUIData()
	{
	}

	[Token(Token = "0x600A46B")]
	[Address(RVA = "0x213C080", Offset = "0x213C080", VA = "0x213C080", Slot = "41")]
	protected virtual void RefreshUIData(bool isPurchaseRefresh = false)
	{
	}

	[Token(Token = "0x600A46C")]
	[Address(RVA = "0x213C498", Offset = "0x213C498", VA = "0x213C498", Slot = "42")]
	protected virtual UIHudCSEquipCategoryController CreateCategory(Transform container)
	{
		return null;
	}

	[Token(Token = "0x600A46D")]
	[Address(RVA = "0x213C590", Offset = "0x213C590", VA = "0x213C590", Slot = "34")]
	protected override void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600A46E")]
	[Address(RVA = "0x213D178", Offset = "0x213D178", VA = "0x213D178", Slot = "36")]
	protected override void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600A470")]
	[Address(RVA = "0x213D1E4", Offset = "0x213D1E4", VA = "0x213D1E4", Slot = "23")]
	public override bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600A471")]
	[Address(RVA = "0x213D364", Offset = "0x213D364", VA = "0x213D364", Slot = "24")]
	protected override void RefreshVisibility()
	{
	}

	[Token(Token = "0x600A472")]
	[Address(RVA = "0x213D688", Offset = "0x213D688", VA = "0x213D688")]
	private void OnAskPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600A473")]
	[Address(RVA = "0x213AC68", Offset = "0x213AC68", VA = "0x213AC68")]
	private void ClearUIData()
	{
	}

	[Token(Token = "0x600A474")]
	[Address(RVA = "0x213D984", Offset = "0x213D984", VA = "0x213D984", Slot = "33")]
	protected override void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600A475")]
	[Address(RVA = "0x213AE38", Offset = "0x213AE38", VA = "0x213AE38")]
	private void RefreshPrices(uint purchaseCnt = 0u)
	{
	}

	[Token(Token = "0x600A476")]
	[Address(RVA = "0x213E348", Offset = "0x213E348", VA = "0x213E348", Slot = "43")]
	protected virtual bool CheckCanPurchase()
	{
		return default(bool);
	}

	[Token(Token = "0x600A477")]
	[Address(RVA = "0x213DDE8", Offset = "0x213DDE8", VA = "0x213DDE8")]
	private void RefreshAskBtn(uint cost, bool isItemValid)
	{
	}

	[Token(Token = "0x600A478")]
	[Address(RVA = "0x213E3A0", Offset = "0x213E3A0", VA = "0x213E3A0")]
	private void OnMysteryBoxChanged(object[] data)
	{
	}

	[Token(Token = "0x600A479")]
	[Address(RVA = "0x213B630", Offset = "0x213B630", VA = "0x213B630")]
	private void UpdateMysteryBoxUI()
	{
	}

	[Token(Token = "0x600A47A")]
	[Address(RVA = "0x213E434", Offset = "0x213E434", VA = "0x213E434")]
	private void OnFreeCardCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600A47B")]
	[Address(RVA = "0x213E4A0", Offset = "0x213E4A0", VA = "0x213E4A0")]
	private void OnMysteryBoxOpen(object[] data)
	{
	}

	[Token(Token = "0x600A47C")]
	[Address(RVA = "0x213E650", Offset = "0x213E650", VA = "0x213E650")]
	private void OnMysteryBoxClose(object[] data)
	{
	}

	[Token(Token = "0x600A47D")]
	[Address(RVA = "0x213B5AC", Offset = "0x213B5AC", VA = "0x213B5AC")]
	private void ResetAnim()
	{
	}

	[Token(Token = "0x600A47E")]
	[Address(RVA = "0x213E6B8", Offset = "0x213E6B8", VA = "0x213E6B8")]
	private void OnTeammateCoinChange(object[] data)
	{
	}

	[Token(Token = "0x600A47F")]
	[Address(RVA = "0x213E724", Offset = "0x213E724", VA = "0x213E724")]
	private void ClearData()
	{
	}

	[Token(Token = "0x600A480")]
	[Address(RVA = "0x213E780", Offset = "0x213E780", VA = "0x213E780", Slot = "38")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A481")]
	[Address(RVA = "0x213EDB0", Offset = "0x213EDB0", VA = "0x213EDB0", Slot = "39")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A482")]
	[Address(RVA = "0x213EE44", Offset = "0x213EE44", VA = "0x213EE44")]
	private void OnAddLocalTeammates(object[] data)
	{
	}

	[Token(Token = "0x600A483")]
	[Address(RVA = "0x213F1A4", Offset = "0x213F1A4", VA = "0x213F1A4")]
	private void OnItemCountChanged(object[] data)
	{
	}

	[Token(Token = "0x600A484")]
	[Address(RVA = "0x213F3C0", Offset = "0x213F3C0", VA = "0x213F3C0")]
	private void OnPurchaseSuccess(object[] data)
	{
	}

	[Token(Token = "0x600A485")]
	[Address(RVA = "0x213F6DC", Offset = "0x213F6DC", VA = "0x213F6DC")]
	public void SetFreeShowView()
	{
	}

	[Token(Token = "0x600A486")]
	[Address(RVA = "0x21382EC", Offset = "0x21382EC", VA = "0x21382EC")]
	private void RefreshCSShopTipsValue()
	{
	}

	[Token(Token = "0x600A487")]
	[Address(RVA = "0x213F914", Offset = "0x213F914", VA = "0x213F914")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A488")]
	[Address(RVA = "0x213F91C", Offset = "0x213F91C", VA = "0x213F91C")]
	public void _003C_003EiFixBaseProxy_OnInitSpecialUIElement()
	{
	}

	[Token(Token = "0x600A489")]
	[Address(RVA = "0x213F924", Offset = "0x213F924", VA = "0x213F924")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A48A")]
	[Address(RVA = "0x213F92C", Offset = "0x213F92C", VA = "0x213F92C")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A48B")]
	[Address(RVA = "0x213F934", Offset = "0x213F934", VA = "0x213F934")]
	public void _003C_003EiFixBaseProxy_OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600A48C")]
	[Address(RVA = "0x213F93C", Offset = "0x213F93C", VA = "0x213F93C")]
	public void _003C_003EiFixBaseProxy_OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600A48D")]
	[Address(RVA = "0x213F944", Offset = "0x213F944", VA = "0x213F944")]
	public bool _003C_003EiFixBaseProxy_IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x600A48E")]
	[Address(RVA = "0x213F94C", Offset = "0x213F94C", VA = "0x213F94C")]
	public void _003C_003EiFixBaseProxy_RefreshVisibility()
	{
	}

	[Token(Token = "0x600A48F")]
	[Address(RVA = "0x213F954", Offset = "0x213F954", VA = "0x213F954")]
	public void _003C_003EiFixBaseProxy_OnItemSelected(object[] P0)
	{
	}
}
