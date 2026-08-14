using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021E1")]
public class UIMallDetailBaseController : UIBaseController
{
	[Token(Token = "0x20021E2")]
	protected delegate void SpecialViewHandle();

	[Token(Token = "0x20021E3")]
	private sealed class _003CGetExchangeItemInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D410")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x600B626")]
		[Address(RVA = "0x23B298C", Offset = "0x23B298C", VA = "0x23B298C")]
		public _003CGetExchangeItemInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B627")]
		[Address(RVA = "0x23B4948", Offset = "0x23B4948", VA = "0x23B4948")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc itemDesc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D3E0")]
	[FieldOffset(Offset = "0x28")]
	protected List<SubTabInfo> m_TabClothList;

	[Token(Token = "0x400D3E1")]
	[FieldOffset(Offset = "0x2C")]
	protected List<SubTabInfo> m_TabCallSignList;

	[Token(Token = "0x400D3E2")]
	[FieldOffset(Offset = "0x30")]
	protected List<SubTabInfo> m_TabCharacterList;

	[Token(Token = "0x400D3E3")]
	[FieldOffset(Offset = "0x34")]
	protected List<SubTabInfo> m_TabPetList;

	[Token(Token = "0x400D3E4")]
	[FieldOffset(Offset = "0x38")]
	protected Dictionary<uint, string> m_MallTabName;

	[Token(Token = "0x400D3E5")]
	[FieldOffset(Offset = "0x3C")]
	protected Dictionary<int, Vector3> m_MallScrollViewPosDict;

	[Token(Token = "0x400D3E6")]
	[FieldOffset(Offset = "0x40")]
	protected Dictionary<int, Vector3> m_PurchaseBtnPosDict;

	[Token(Token = "0x400D3E7")]
	[FieldOffset(Offset = "0x44")]
	protected Dictionary<int, BuyBtnStyle> m_OtherChannelToBtnStyle;

	[Token(Token = "0x400D3E8")]
	[FieldOffset(Offset = "0x48")]
	protected UIModelMall m_ModelMall;

	[Token(Token = "0x400D3E9")]
	[FieldOffset(Offset = "0x4C")]
	protected UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x400D3EA")]
	[FieldOffset(Offset = "0x50")]
	protected UIModelGift m_ModelGift;

	[Token(Token = "0x400D3EB")]
	protected const uint CURRENCY_GREY = 2139062271u;

	[Token(Token = "0x400D3EC")]
	protected const uint CLOTHPREVIEW_ICON_GREY = 1650615039u;

	[Token(Token = "0x400D3ED")]
	[FieldOffset(Offset = "0x54")]
	protected Dictionary<int, PreviewTabInfo> m_ClothPreviewToggleDict;

	[Token(Token = "0x400D3EE")]
	[FieldOffset(Offset = "0x58")]
	protected UIMallController m_MallController;

	[Token(Token = "0x400D3EF")]
	[FieldOffset(Offset = "0x5C")]
	protected UINavigationUtil.UINavigationMallType m_MallType;

	[Token(Token = "0x400D3F0")]
	[FieldOffset(Offset = "0x60")]
	protected Dictionary<int, SlotClothInfo> m_SelectedClothDict;

	[Token(Token = "0x400D3F1")]
	[FieldOffset(Offset = "0x64")]
	protected Dictionary<int, SlotClothInfo> m_ViceSelectedClothDict;

	[Token(Token = "0x400D3F2")]
	[FieldOffset(Offset = "0x68")]
	protected bool m_IsSelectedSet;

	[Token(Token = "0x400D3F3")]
	[FieldOffset(Offset = "0x69")]
	protected bool m_IsViceSelectedSet;

	[Token(Token = "0x400D3F4")]
	[FieldOffset(Offset = "0x6C")]
	protected uint m_LastSelectedCloth;

	[Token(Token = "0x400D3F5")]
	[FieldOffset(Offset = "0x70")]
	protected uint m_ViceLastSelectedCloth;

	[Token(Token = "0x400D3F6")]
	[FieldOffset(Offset = "0x74")]
	protected uint m_CurrentSubTab;

	[Token(Token = "0x400D3F7")]
	[FieldOffset(Offset = "0x78")]
	protected uint m_CurrentTab;

	[Token(Token = "0x400D3F8")]
	[FieldOffset(Offset = "0x7C")]
	protected List<UIToggleButton> m_ToggleList;

	[Token(Token = "0x400D3F9")]
	[FieldOffset(Offset = "0x80")]
	protected Dictionary<uint, UIToggleButton> m_ToggleDict;

	[Token(Token = "0x400D3FA")]
	[FieldOffset(Offset = "0x84")]
	protected Dictionary<uint, Callback> m_MallTypeHandleDict;

	[Token(Token = "0x400D3FB")]
	[FieldOffset(Offset = "0x88")]
	protected Dictionary<uint, SpecialViewHandle> m_MallSpecialViewHandleDict;

	[Token(Token = "0x400D3FC")]
	[FieldOffset(Offset = "0x8C")]
	protected bool m_SwitchPreviewSlot;

	[Token(Token = "0x400D3FD")]
	[FieldOffset(Offset = "0x90")]
	protected List<SubTabInfo> m_SubToggleList;

	[Token(Token = "0x400D3FE")]
	[FieldOffset(Offset = "0x94")]
	protected uint m_SelectedItemId;

	[Token(Token = "0x400D3FF")]
	[FieldOffset(Offset = "0x98")]
	protected uint m_SelectedItemStoreId;

	[Token(Token = "0x400D400")]
	[FieldOffset(Offset = "0x0")]
	public static bool m_IsCDNJump;

	[Token(Token = "0x400D401")]
	[FieldOffset(Offset = "0x1")]
	private static bool m_NeedCacheBackMallLog;

	[Token(Token = "0x400D402")]
	protected const string FIRSTENTERINSTALLMENT = "FirstEnterInstallment";

	[Token(Token = "0x400D403")]
	[FieldOffset(Offset = "0x9C")]
	protected Dictionary<int, BuyBtnInfo> m_BuyBtnInfoDict;

	[Token(Token = "0x400D404")]
	[FieldOffset(Offset = "0xA0")]
	protected UIMallDetailView m_View;

	[Token(Token = "0x400D405")]
	[FieldOffset(Offset = "0xA4")]
	private BuyBtnInfo m_BuyBtnInfo;

	[Token(Token = "0x400D406")]
	protected const string BUYBTNICON = "UI_Store_Btn_Buy";

	[Token(Token = "0x400D407")]
	protected const string EXCHANGEBTNICON = "UI_Store_Btn_Exchange";

	[Token(Token = "0x400D408")]
	protected const string GIFTBTNICON = "UI_Store_Btn_Gift";

	[Token(Token = "0x400D409")]
	[FieldOffset(Offset = "0xA8")]
	public bool IsPlayingToggleMoveAnim;

	[Token(Token = "0x400D40A")]
	[FieldOffset(Offset = "0xA9")]
	public bool hasItemNoShowTips;

	[Token(Token = "0x400D40B")]
	[FieldOffset(Offset = "0xAC")]
	protected uint m_CurrentAvatarId;

	[Token(Token = "0x400D40C")]
	[FieldOffset(Offset = "0xB0")]
	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x400D40D")]
	[FieldOffset(Offset = "0xB4")]
	protected UIGrid m_PreviewIconGrid;

	[Token(Token = "0x400D40E")]
	[FieldOffset(Offset = "0x4")]
	private static Func<SubTabInfo, UIToggleButton> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D40F")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<SubTabInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17001030")]
	public bool SwitchPreviewSlot
	{
		[Token(Token = "0x600B5B4")]
		[Address(RVA = "0x239E3F8", Offset = "0x239E3F8", VA = "0x239E3F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001031")]
	public uint CurrentAvatarId
	{
		[Token(Token = "0x600B5B5")]
		[Address(RVA = "0x239E108", Offset = "0x239E108", VA = "0x239E108")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001032")]
	public UINavigationUtil.UINavigationMallType MallType
	{
		[Token(Token = "0x600B5B6")]
		[Address(RVA = "0x239D160", Offset = "0x239D160", VA = "0x239D160")]
		get
		{
			return default(UINavigationUtil.UINavigationMallType);
		}
	}

	[Token(Token = "0x17001033")]
	public uint CurrentTab
	{
		[Token(Token = "0x600B5B7")]
		[Address(RVA = "0x23A0570", Offset = "0x23A0570", VA = "0x23A0570")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001034")]
	public uint CurrentSubTab
	{
		[Token(Token = "0x600B5B8")]
		[Address(RVA = "0x23A05C8", Offset = "0x23A05C8", VA = "0x23A05C8")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x600B5B3")]
	[Address(RVA = "0x23A5FBC", Offset = "0x23A5FBC", VA = "0x23A5FBC")]
	public UIMallDetailBaseController()
	{
	}

	[Token(Token = "0x600B5B9")]
	[Address(RVA = "0x23A7B94", Offset = "0x23A7B94", VA = "0x23A7B94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B5BA")]
	[Address(RVA = "0x23A8094", Offset = "0x23A8094", VA = "0x23A8094", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B5BB")]
	[Address(RVA = "0x23A8368", Offset = "0x23A8368", VA = "0x23A8368")]
	protected void InitClothPreviewToggles()
	{
	}

	[Token(Token = "0x600B5BC")]
	[Address(RVA = "0x23A8A08", Offset = "0x23A8A08", VA = "0x23A8A08", Slot = "31")]
	protected virtual void InitBuyBtnStyle()
	{
	}

	[Token(Token = "0x600B5BD")]
	[Address(RVA = "0x23A8A5C", Offset = "0x23A8A5C", VA = "0x23A8A5C", Slot = "32")]
	protected virtual void OnClothPreviewToggleClick()
	{
	}

	[Token(Token = "0x600B5BE")]
	[Address(RVA = "0x23A8AB0", Offset = "0x23A8AB0", VA = "0x23A8AB0")]
	private void OnUnDressBtnClick()
	{
	}

	[Token(Token = "0x600B5BF")]
	[Address(RVA = "0x23A92A8", Offset = "0x23A92A8", VA = "0x23A92A8", Slot = "33")]
	protected virtual void UnSelectItem(uint itemID)
	{
	}

	[Token(Token = "0x600B5C0")]
	[Address(RVA = "0x239DFD8", Offset = "0x239DFD8", VA = "0x239DFD8")]
	public void ResetAvatarAndSelectedClothData()
	{
	}

	[Token(Token = "0x600B5C1")]
	[Address(RVA = "0x23A93A8", Offset = "0x23A93A8", VA = "0x23A93A8")]
	private void ResetClothPreviewTogglesState()
	{
	}

	[Token(Token = "0x600B5C2")]
	[Address(RVA = "0x23A956C", Offset = "0x23A956C", VA = "0x23A956C")]
	protected void ReSetClothPreviewTabSprite(PreviewTabInfo tabInfo)
	{
	}

	[Token(Token = "0x600B5C3")]
	[Address(RVA = "0x23A9660", Offset = "0x23A9660", VA = "0x23A9660")]
	protected void FadeClothPreviewTabSprite(PreviewTabInfo tabInfo)
	{
	}

	[Token(Token = "0x600B5C4")]
	[Address(RVA = "0x23A97EC", Offset = "0x23A97EC", VA = "0x23A97EC")]
	protected void RefreshClothPreviewToggleState(Dictionary<int, SlotClothInfo> selectedClothDict, bool isSelectedSet = false, [Optional] UIToggleButton tb)
	{
	}

	[Token(Token = "0x600B5C5")]
	[Address(RVA = "0x23AA0D4", Offset = "0x23AA0D4", VA = "0x23AA0D4")]
	protected void CheckSelectedClothState(Dictionary<int, SlotClothInfo> selectedClothDict)
	{
	}

	[Token(Token = "0x600B5C6")]
	[Address(RVA = "0x23A9014", Offset = "0x23A9014", VA = "0x23A9014")]
	private void ResetPreviewTabInfo(PreviewTabInfo tabInfo)
	{
	}

	[Token(Token = "0x600B5C7")]
	[Address(RVA = "0x23A00CC", Offset = "0x23A00CC", VA = "0x23A00CC")]
	public void OnLabelModelHintChange(object[] data)
	{
	}

	[Token(Token = "0x600B5C8")]
	[Address(RVA = "0x23A1658", Offset = "0x23A1658", VA = "0x23A1658")]
	public void RefreshClothPreview(object[] data)
	{
	}

	[Token(Token = "0x600B5C9")]
	[Address(RVA = "0x23AA808", Offset = "0x23AA808", VA = "0x23AA808")]
	private void RefreshClothPreview(uint storeID, uint itemID, Dictionary<int, SlotClothInfo> selectedClothDict, ref bool isSelectedSet)
	{
	}

	[Token(Token = "0x600B5CA")]
	[Address(RVA = "0x23AB654", Offset = "0x23AB654", VA = "0x23AB654", Slot = "34")]
	protected virtual void SetClothPreviewTabInfo(PreviewTabInfo tabInfo, CSSharedItemData itemData)
	{
	}

	[Token(Token = "0x600B5CB")]
	[Address(RVA = "0x23AB7FC", Offset = "0x23AB7FC", VA = "0x23AB7FC")]
	protected void OnSwitchClothPreviewBtnClick()
	{
	}

	[Token(Token = "0x600B5CC")]
	[Address(RVA = "0x23ABCF8", Offset = "0x23ABCF8", VA = "0x23ABCF8")]
	protected void SetClothPreviewTogglesInfo(Dictionary<int, SlotClothInfo> selectedClothDict, bool isSelectedSet)
	{
	}

	[Token(Token = "0x600B5CD")]
	[Address(RVA = "0x23AB498", Offset = "0x23AB498", VA = "0x23AB498")]
	private void RefreshClothPreviewTabOnSwith(bool trySameGender = false)
	{
	}

	[Token(Token = "0x600B5CE")]
	[Address(RVA = "0x23AC484", Offset = "0x23AC484", VA = "0x23AC484")]
	protected void SetSwithClothGenderBtnState(bool isSelfFemale, bool isSwitchPreviewSlot)
	{
	}

	[Token(Token = "0x600B5CF")]
	[Address(RVA = "0x23AC2CC", Offset = "0x23AC2CC", VA = "0x23AC2CC")]
	private bool HasInvalidClothesForHeadAdditive(uint avatarId, Dictionary<int, SlotClothInfo> clothes)
	{
		return default(bool);
	}

	[Token(Token = "0x600B5D0")]
	[Address(RVA = "0x23AC248", Offset = "0x23AC248", VA = "0x23AC248")]
	protected uint FindDefaultAvatarIDByGender(bool female)
	{
		return default(uint);
	}

	[Token(Token = "0x600B5D1")]
	[Address(RVA = "0x23A18B4", Offset = "0x23A18B4", VA = "0x23A18B4")]
	public void OnHideClothesSlot(object[] data)
	{
	}

	[Token(Token = "0x600B5D2")]
	[Address(RVA = "0x23AC558", Offset = "0x23AC558", VA = "0x23AC558")]
	private PreviewTabInfo GetPreviewTab(string slotName)
	{
		return null;
	}

	[Token(Token = "0x600B5D3")]
	[Address(RVA = "0x23AC850", Offset = "0x23AC850", VA = "0x23AC850")]
	protected void SetMallController()
	{
	}

	[Token(Token = "0x600B5D4")]
	[Address(RVA = "0x23ACC90", Offset = "0x23ACC90", VA = "0x23ACC90")]
	protected void SetSwitchClothPreviewBtnGroupVisible(bool visible)
	{
	}

	[Token(Token = "0x600B5D5")]
	[Address(RVA = "0x23A3E68", Offset = "0x23A3E68", VA = "0x23A3E68")]
	public void RefreshMallToInit()
	{
	}

	[Token(Token = "0x600B5D6")]
	[Address(RVA = "0x23A3DD4", Offset = "0x23A3DD4", VA = "0x23A3DD4")]
	public void PlayToggleMoveAnim()
	{
	}

	[Token(Token = "0x600B5D7")]
	[Address(RVA = "0x23A20E0", Offset = "0x23A20E0", VA = "0x23A20E0")]
	public void RefreshMallViewAndSelectItem()
	{
	}

	[Token(Token = "0x600B5D8")]
	[Address(RVA = "0x23ACE5C", Offset = "0x23ACE5C", VA = "0x23ACE5C", Slot = "35")]
	protected virtual bool CanFindStoreItem(uint storeID)
	{
		return default(bool);
	}

	[Token(Token = "0x600B5D9")]
	[Address(RVA = "0x23ACEC0", Offset = "0x23ACEC0", VA = "0x23ACEC0", Slot = "36")]
	public virtual void HighlightCurrent()
	{
	}

	[Token(Token = "0x600B5DA")]
	[Address(RVA = "0x23ACF14", Offset = "0x23ACF14", VA = "0x23ACF14", Slot = "37")]
	public virtual void ResetCurrentMall()
	{
	}

	[Token(Token = "0x600B5DB")]
	[Address(RVA = "0x23ACF68", Offset = "0x23ACF68", VA = "0x23ACF68", Slot = "38")]
	public virtual bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600B5DC")]
	[Address(RVA = "0x23AD0F0", Offset = "0x23AD0F0", VA = "0x23AD0F0")]
	protected bool SelectClothByGender(uint id, EClothGenderType genderType)
	{
		return default(bool);
	}

	[Token(Token = "0x600B5DD")]
	[Address(RVA = "0x23AD26C", Offset = "0x23AD26C", VA = "0x23AD26C")]
	protected void CreateMallTab(List<uint> toggleList, bool needFixationTab = false)
	{
	}

	[Token(Token = "0x600B5DE")]
	[Address(RVA = "0x23ADD00", Offset = "0x23ADD00", VA = "0x23ADD00", Slot = "39")]
	protected virtual void AddMallToggleClickEvent()
	{
	}

	[Token(Token = "0x600B5DF")]
	[Address(RVA = "0x23AE014", Offset = "0x23AE014", VA = "0x23AE014")]
	protected void HighLightItem(int itemIndex, UIEasyList grid, bool needClick = false, bool needScroll = true, bool showTips = false)
	{
	}

	[Token(Token = "0x600B5E0")]
	[Address(RVA = "0x23AE344", Offset = "0x23AE344", VA = "0x23AE344", Slot = "40")]
	protected virtual void OnADToggleSelected()
	{
	}

	[Token(Token = "0x600B5E1")]
	[Address(RVA = "0x23AE4D8", Offset = "0x23AE4D8", VA = "0x23AE4D8", Slot = "41")]
	protected virtual void OnNewsToggleSelected()
	{
	}

	[Token(Token = "0x600B5E2")]
	[Address(RVA = "0x23AE9A8", Offset = "0x23AE9A8", VA = "0x23AE9A8", Slot = "42")]
	protected virtual void OnBundleToggleSelected()
	{
	}

	[Token(Token = "0x600B5E3")]
	[Address(RVA = "0x23AEA7C", Offset = "0x23AEA7C", VA = "0x23AEA7C", Slot = "43")]
	protected virtual void OnAvatarToggleSelected()
	{
	}

	[Token(Token = "0x600B5E4")]
	[Address(RVA = "0x23AEB20", Offset = "0x23AEB20", VA = "0x23AEB20", Slot = "44")]
	protected virtual void OnCustomizeToggleSelected()
	{
	}

	[Token(Token = "0x600B5E5")]
	[Address(RVA = "0x23AEBC4", Offset = "0x23AEBC4", VA = "0x23AEBC4", Slot = "45")]
	protected virtual void OnPropsToggleSelected()
	{
	}

	[Token(Token = "0x600B5E6")]
	[Address(RVA = "0x23AEC98", Offset = "0x23AEC98", VA = "0x23AEC98", Slot = "46")]
	protected virtual void OnCallSignToggleSelected()
	{
	}

	[Token(Token = "0x600B5E7")]
	[Address(RVA = "0x23AED3C", Offset = "0x23AED3C", VA = "0x23AED3C", Slot = "47")]
	protected virtual void OnWeaponToggleSelected()
	{
	}

	[Token(Token = "0x600B5E8")]
	[Address(RVA = "0x23AEF20", Offset = "0x23AEF20", VA = "0x23AEF20", Slot = "48")]
	protected virtual void OnPetToggleSelected()
	{
	}

	[Token(Token = "0x600B5E9")]
	[Address(RVA = "0x23AEFC4", Offset = "0x23AEFC4", VA = "0x23AEFC4", Slot = "49")]
	protected virtual void OnAllToggleSelected()
	{
	}

	[Token(Token = "0x600B5EA")]
	[Address(RVA = "0x23AF1A8", Offset = "0x23AF1A8", VA = "0x23AF1A8", Slot = "50")]
	protected virtual void OnExclusiveToggleSelected()
	{
	}

	[Token(Token = "0x600B5EB")]
	[Address(RVA = "0x23AF38C", Offset = "0x23AF38C", VA = "0x23AF38C", Slot = "51")]
	protected virtual void OnTreasureBoxToggleSelected()
	{
	}

	[Token(Token = "0x600B5EC")]
	[Address(RVA = "0x23AF570", Offset = "0x23AF570", VA = "0x23AF570")]
	protected ulong CalculateDiscountRefreshTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x600B5ED")]
	[Address(RVA = "0x23AE6F0", Offset = "0x23AE6F0", VA = "0x23AE6F0")]
	protected void SetMallWidgetPosByType(EMallScrollViewPosType type)
	{
	}

	[Token(Token = "0x600B5EE")]
	[Address(RVA = "0x23AF8DC", Offset = "0x23AF8DC", VA = "0x23AF8DC", Slot = "52")]
	protected virtual void RefreshCurrentTabView(UINavigationUtil.UINavigationMallTabType mallTabType)
	{
	}

	[Token(Token = "0x600B5EF")]
	[Address(RVA = "0x23AF938", Offset = "0x23AF938", VA = "0x23AF938", Slot = "53")]
	public virtual void HideItemEffect()
	{
	}

	[Token(Token = "0x600B5F0")]
	[Address(RVA = "0x23AF98C", Offset = "0x23AF98C", VA = "0x23AF98C", Slot = "54")]
	protected virtual void CreateSubTab()
	{
	}

	[Token(Token = "0x600B5F1")]
	[Address(RVA = "0x23B05A0", Offset = "0x23B05A0", VA = "0x23B05A0")]
	private void ResetSubToggleScrollView()
	{
	}

	[Token(Token = "0x600B5F2")]
	[Address(RVA = "0x23B0934", Offset = "0x23B0934", VA = "0x23B0934")]
	private void SetSubTabInfo(UIToggleButton tg, SubTabInfo info)
	{
	}

	[Token(Token = "0x600B5F3")]
	[Address(RVA = "0x23B0C98", Offset = "0x23B0C98", VA = "0x23B0C98", Slot = "55")]
	protected virtual void OnSubToggleClick()
	{
	}

	[Token(Token = "0x600B5F4")]
	[Address(RVA = "0x23B0D28", Offset = "0x23B0D28", VA = "0x23B0D28", Slot = "56")]
	protected virtual void ResetUIStateOnToggleSelected()
	{
	}

	[Token(Token = "0x600B5F5")]
	[Address(RVA = "0x23B11E4", Offset = "0x23B11E4", VA = "0x23B11E4", Slot = "57")]
	protected virtual string GetMallTabName(uint type)
	{
		return null;
	}

	[Token(Token = "0x600B5F6")]
	[Address(RVA = "0x23B1310", Offset = "0x23B1310", VA = "0x23B1310", Slot = "58")]
	public virtual void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600B5F7")]
	[Address(RVA = "0x23B1080", Offset = "0x23B1080", VA = "0x23B1080")]
	public void UpdateProp()
	{
	}

	[Token(Token = "0x600B5F8")]
	[Address(RVA = "0x239E450", Offset = "0x239E450", VA = "0x239E450")]
	public void UpdateCloth(uint avatarId, uint selectClothes, uint[] clothes, bool addLobbyClothes, bool playClothesAnim, bool keepHairWhenSameAvatarId)
	{
	}

	[Token(Token = "0x600B5F9")]
	[Address(RVA = "0x23B136C", Offset = "0x23B136C", VA = "0x23B136C", Slot = "59")]
	public virtual void InitMallView()
	{
	}

	[Token(Token = "0x600B5FA")]
	[Address(RVA = "0x23B13C0", Offset = "0x23B13C0", VA = "0x23B13C0", Slot = "60")]
	public virtual void RefreshMallView()
	{
	}

	[Token(Token = "0x600B5FB")]
	[Address(RVA = "0x23B1414", Offset = "0x23B1414", VA = "0x23B1414", Slot = "61")]
	public virtual void NavigationToItem(uint id)
	{
	}

	[Token(Token = "0x600B5FC")]
	[Address(RVA = "0x23B23D8", Offset = "0x23B23D8", VA = "0x23B23D8", Slot = "62")]
	public virtual void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
	{
	}

	[Token(Token = "0x600B5FD")]
	[Address(RVA = "0x239FF98", Offset = "0x239FF98", VA = "0x239FF98")]
	public bool HasItemNoShowTips()
	{
		return default(bool);
	}

	[Token(Token = "0x600B5FE")]
	[Address(RVA = "0x239FFF0", Offset = "0x239FFF0", VA = "0x239FFF0")]
	public void ResetHasItemNoShowTips()
	{
	}

	[Token(Token = "0x600B5FF")]
	[Address(RVA = "0x23B24FC", Offset = "0x23B24FC", VA = "0x23B24FC")]
	protected void ShowSpecialView(UINavigationUtil.UINavigationMallTabType viewType)
	{
	}

	[Token(Token = "0x600B600")]
	[Address(RVA = "0x23A9240", Offset = "0x23A9240", VA = "0x23A9240")]
	public Dictionary<int, SlotClothInfo> GetCurrentClothDict()
	{
		return null;
	}

	[Token(Token = "0x600B601")]
	[Address(RVA = "0x23ACDF4", Offset = "0x23ACDF4", VA = "0x23ACDF4")]
	public uint GetLastSelectedCloth()
	{
		return default(uint);
	}

	[Token(Token = "0x600B602")]
	[Address(RVA = "0x239E160", Offset = "0x239E160", VA = "0x239E160")]
	public List<uint> GetCurrentSelectedClothList(bool ingoreSet = false)
	{
		return null;
	}

	[Token(Token = "0x600B603")]
	[Address(RVA = "0x23B2800", Offset = "0x23B2800", VA = "0x23B2800", Slot = "63")]
	public virtual void RefreshCurrentMallView(bool clickItem = true)
	{
	}

	[Token(Token = "0x600B604")]
	[Address(RVA = "0x23A21AC", Offset = "0x23A21AC", VA = "0x23A21AC")]
	public void RefreshCurrentItemDownloadState()
	{
	}

	[Token(Token = "0x600B605")]
	[Address(RVA = "0x23B285C", Offset = "0x23B285C", VA = "0x23B285C", Slot = "64")]
	public virtual UIEasyList GetCurrentMallEasyList()
	{
		return null;
	}

	[Token(Token = "0x600B606")]
	[Address(RVA = "0x23AB5E4", Offset = "0x23AB5E4", VA = "0x23AB5E4")]
	public bool GetCurrentSelectedSetState()
	{
		return default(bool);
	}

	[Token(Token = "0x600B607")]
	[Address(RVA = "0x23B28B4", Offset = "0x23B28B4", VA = "0x23B28B4", Slot = "65")]
	public virtual void HighLightSelectedItem()
	{
	}

	[Token(Token = "0x600B608")]
	[Address(RVA = "0x23B1D98", Offset = "0x23B1D98", VA = "0x23B1D98")]
	protected void GetItemInfo(uint id, out uint storeID, out UINavigationUtil.UINavigationMallType mallType, out uint mallTabType, out uint subType)
	{
	}

	[Token(Token = "0x600B609")]
	[Address(RVA = "0x23B1BE4", Offset = "0x23B1BE4", VA = "0x23B1BE4")]
	protected void GetExchangeItemInfo(uint id, out uint storeID, out uint subType)
	{
	}

	[Token(Token = "0x600B60A")]
	[Address(RVA = "0x23B2994", Offset = "0x23B2994", VA = "0x23B2994")]
	private void OnBuyClick()
	{
	}

	[Token(Token = "0x600B60B")]
	[Address(RVA = "0x23B2A18", Offset = "0x23B2A18", VA = "0x23B2A18")]
	protected void SetBuyBtnStyle(BuyBtnStyle buyBtnStyle, bool enable)
	{
	}

	[Token(Token = "0x600B60C")]
	[Address(RVA = "0x23B2E90", Offset = "0x23B2E90", VA = "0x23B2E90")]
	private void SetVoucherVisual()
	{
	}

	[Token(Token = "0x600B60D")]
	[Address(RVA = "0x23B1734", Offset = "0x23B1734", VA = "0x23B1734")]
	protected void GetGiftItemInfo(uint id, out uint mallTabType, out uint subType)
	{
	}

	[Token(Token = "0x600B60E")]
	[Address(RVA = "0x23B39C4", Offset = "0x23B39C4", VA = "0x23B39C4", Slot = "66")]
	public virtual void OnHairUpdate(object[] data)
	{
	}

	[Token(Token = "0x600B60F")]
	[Address(RVA = "0x23B3D28", Offset = "0x23B3D28", VA = "0x23B3D28", Slot = "67")]
	public virtual void ShowMall()
	{
	}

	[Token(Token = "0x600B610")]
	[Address(RVA = "0x23B3D94", Offset = "0x23B3D94", VA = "0x23B3D94", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600B611")]
	[Address(RVA = "0x23B3E20", Offset = "0x23B3E20", VA = "0x23B3E20", Slot = "68")]
	protected virtual bool IsCurrentTabHaveSubTab()
	{
		return default(bool);
	}

	[Token(Token = "0x600B612")]
	[Address(RVA = "0x23B3EA4", Offset = "0x23B3EA4", VA = "0x23B3EA4", Slot = "69")]
	protected virtual void OnCommonWndFinish(object[] data)
	{
	}

	[Token(Token = "0x600B613")]
	[Address(RVA = "0x23B3F00", Offset = "0x23B3F00", VA = "0x23B3F00")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600B614")]
	[Address(RVA = "0x23B4124", Offset = "0x23B4124", VA = "0x23B4124")]
	protected void GotoOtherChannel()
	{
	}

	[Token(Token = "0x600B615")]
	[Address(RVA = "0x23B4380", Offset = "0x23B4380", VA = "0x23B4380", Slot = "70")]
	public virtual void OnNavigationClose()
	{
	}

	[Token(Token = "0x600B616")]
	[Address(RVA = "0x23B43D4", Offset = "0x23B43D4", VA = "0x23B43D4")]
	protected void SaveSelectedInfo(uint storeID, uint itemID)
	{
	}

	[Token(Token = "0x600B617")]
	[Address(RVA = "0x23A9348", Offset = "0x23A9348", VA = "0x23A9348")]
	protected void ClearSelectedInfo()
	{
	}

	[Token(Token = "0x600B618")]
	[Address(RVA = "0x23B4454", Offset = "0x23B4454", VA = "0x23B4454")]
	private void OnRefreshAvatarId(object[] data)
	{
	}

	[Token(Token = "0x600B619")]
	[Address(RVA = "0x23B44D8", Offset = "0x23B44D8", VA = "0x23B44D8")]
	private void OnPlayFacialAnim(object[] data)
	{
	}

	[Token(Token = "0x600B61A")]
	[Address(RVA = "0x23B4818", Offset = "0x23B4818", VA = "0x23B4818")]
	public uint GetCurrentSelectedID()
	{
		return default(uint);
	}

	[Token(Token = "0x600B61B")]
	[Address(RVA = "0x23B4870", Offset = "0x23B4870", VA = "0x23B4870")]
	public UIMallController GetMallController()
	{
		return null;
	}

	[Token(Token = "0x600B61D")]
	[Address(RVA = "0x23B48CC", Offset = "0x23B48CC", VA = "0x23B48CC")]
	private static UIToggleButton _003CCreateSubTab_003Em__0(SubTabInfo info)
	{
		return null;
	}

	[Token(Token = "0x600B61E")]
	[Address(RVA = "0x23B48F0", Offset = "0x23B48F0", VA = "0x23B48F0")]
	private static bool _003COnPlayFacialAnim_003Em__1(SubTabInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x600B61F")]
	[Address(RVA = "0x23B4930", Offset = "0x23B4930", VA = "0x23B4930")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B620")]
	[Address(RVA = "0x23B4938", Offset = "0x23B4938", VA = "0x23B4938")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B621")]
	[Address(RVA = "0x23B4940", Offset = "0x23B4940", VA = "0x23B4940")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
