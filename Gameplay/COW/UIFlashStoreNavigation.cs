using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20020FD")]
public class UIFlashStoreNavigation : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x20020FE")]
	public enum NavigationType
	{
		[Token(Token = "0x400CE74")]
		NotSpecific,
		[Token(Token = "0x400CE75")]
		ToStore,
		[Token(Token = "0x400CE76")]
		ToActivity
	}

	[Token(Token = "0x20020FF")]
	public class FlashStoreNavigationData
	{
		[Token(Token = "0x400CE77")]
		[FieldOffset(Offset = "0x8")]
		public uint FlashStoreActivityID;

		[Token(Token = "0x400CE78")]
		[FieldOffset(Offset = "0xC")]
		public NavigationType NavType;

		[Token(Token = "0x400CE79")]
		[FieldOffset(Offset = "0x10")]
		public string From;

		[Token(Token = "0x400CE7A")]
		[FieldOffset(Offset = "0x14")]
		public uint SelectIemID;

		[Token(Token = "0x400CE7B")]
		[FieldOffset(Offset = "0x18")]
		public uint SelectGroupID;

		[Token(Token = "0x400CE7C")]
		[FieldOffset(Offset = "0x1C")]
		public uint SelectActivityID;

		[Token(Token = "0x600AB92")]
		[Address(RVA = "0x1B4F3F8", Offset = "0x1B4F3F8", VA = "0x1B4F3F8")]
		public FlashStoreNavigationData()
		{
		}
	}

	[Token(Token = "0x2002100")]
	public class EventNaviTabViewTime : EventLogger.EventLoggerBase
	{
		[Token(Token = "0x400CE7D")]
		[FieldOffset(Offset = "0x18")]
		public string page_name;

		[Token(Token = "0x400CE7E")]
		[FieldOffset(Offset = "0x1C")]
		public List<TabViewInfo> tab_view_infos;

		[Token(Token = "0x600AB93")]
		[Address(RVA = "0x1B55D80", Offset = "0x1B55D80", VA = "0x1B55D80")]
		public EventNaviTabViewTime()
		{
		}
	}

	[Token(Token = "0x2002101")]
	public class TabViewInfo : EventLogger.EventLoggerBase
	{
		[Token(Token = "0x400CE7F")]
		[FieldOffset(Offset = "0x18")]
		public string tab_name;

		[Token(Token = "0x400CE80")]
		[FieldOffset(Offset = "0x1C")]
		public uint tab_view_time;

		[Token(Token = "0x600AB94")]
		[Address(RVA = "0x1B55D88", Offset = "0x1B55D88", VA = "0x1B55D88")]
		public TabViewInfo()
		{
		}
	}

	[Token(Token = "0x2002102")]
	private struct UICommonGuideData
	{
		[Token(Token = "0x400CE81")]
		[FieldOffset(Offset = "0x0")]
		public string PlayerPrefKey;

		[Token(Token = "0x400CE82")]
		[FieldOffset(Offset = "0x4")]
		public CommonGuideSetting Setting;

		[Token(Token = "0x400CE83")]
		[FieldOffset(Offset = "0x8")]
		public UIButton FinishGuideBtn;

		[Token(Token = "0x400CE84")]
		[FieldOffset(Offset = "0xC")]
		public UIWidget GuideWidget;

		[Token(Token = "0x400CE85")]
		[FieldOffset(Offset = "0x10")]
		public Side Side;

		[Token(Token = "0x400CE86")]
		[FieldOffset(Offset = "0x14")]
		public Action OnInitAction;

		[Token(Token = "0x400CE87")]
		[FieldOffset(Offset = "0x18")]
		public Action OnCloseAction;
	}

	[Token(Token = "0x2002103")]
	private sealed class _003CNavigationToItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x400CE88")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x600AB95")]
		[Address(RVA = "0x1B586A0", Offset = "0x1B586A0", VA = "0x1B586A0")]
		public _003CNavigationToItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600AB96")]
		[Address(RVA = "0x1B59648", Offset = "0x1B59648", VA = "0x1B59648")]
		internal bool _003C_003Em__0(FlashStoreGoodsDesc t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400CE4F")]
	public const string FLASH_STORE_FREE_ACCESS_GUIDE = "FLASH_STORE_FREE_ACCESS_GUIDE_{0}";

	[Token(Token = "0x400CE50")]
	public const string FLASH_STORE_FLASH_GEMS_ITEM_LIST_GUIDE = "FLASH_STORE_FLASH_GEMS_ITEM_LIST_GUIDE_{0}";

	[Token(Token = "0x400CE51")]
	private const string FLASH_GEM_SPRITE_NAME = "FF_UI_FlashStore_PurpleDiamond";

	[Token(Token = "0x400CE52")]
	private const string NORMAL_GEM_SPRITE_NAME = "FF_UI_FlashStore_Diamond";

	[Token(Token = "0x400CE53")]
	private const string RULE_POPUP_TITLE_KEY = "TXT_CLAN_GENERAL";

	[Token(Token = "0x400CE54")]
	private const float GET_STORE_RES_COOLDOWN = 3600f;

	[Token(Token = "0x400CE55")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelFlashStore m_ModelFlashStore;

	[Token(Token = "0x400CE56")]
	[FieldOffset(Offset = "0x80")]
	private UIFlashStoreNavigationView m_View;

	[Token(Token = "0x400CE57")]
	[FieldOffset(Offset = "0x84")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400CE58")]
	[FieldOffset(Offset = "0x88")]
	private EventNaviTabViewTime m_EventTypeFlashStoreTabInfo;

	[Token(Token = "0x400CE59")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_FlashStoreActivityID;

	[Token(Token = "0x400CE5A")]
	[FieldOffset(Offset = "0x90")]
	private uint m_GuideDelayCallTid;

	[Token(Token = "0x400CE5B")]
	[FieldOffset(Offset = "0x94")]
	private UIWidget m_FlashGemsOnlyItemWidget;

	[Token(Token = "0x400CE5C")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget m_FlashGemsAndGemsItemWidget;

	[Token(Token = "0x400CE5D")]
	[FieldOffset(Offset = "0x9C")]
	private int m_FlashGemsOnlyItemIndex;

	[Token(Token = "0x400CE5E")]
	[FieldOffset(Offset = "0xA0")]
	private int m_FlashGemsAndGemsItemIndex;

	[Token(Token = "0x400CE5F")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_CanGuideShow;

	[Token(Token = "0x400CE60")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<uint, UIToggleButton> m_ToggleButtonDict;

	[Token(Token = "0x400CE61")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<uint, Callback> m_MallTabClickDelegateDict;

	[Token(Token = "0x400CE62")]
	[FieldOffset(Offset = "0xB0")]
	private List<UIToggleButton> m_TabToggleList;

	[Token(Token = "0x400CE63")]
	[FieldOffset(Offset = "0xB4")]
	private UIToggleButtonGroup m_UIToggleButtonGroup;

	[Token(Token = "0x400CE64")]
	[FieldOffset(Offset = "0xB8")]
	private UIModelFlashStore.UILimitedStoreTabType m_CurrentSelectedTab;

	[Token(Token = "0x400CE65")]
	[FieldOffset(Offset = "0xBC")]
	private UIModelFlashStore.UILimitedStoreTabType m_PreviousSelectedTab;

	[Token(Token = "0x400CE66")]
	[FieldOffset(Offset = "0xC0")]
	private uint[] m_TabViewTimeArr;

	[Token(Token = "0x400CE67")]
	[FieldOffset(Offset = "0xC8")]
	private ulong m_TabStartShowTime;

	[Token(Token = "0x400CE68")]
	[FieldOffset(Offset = "0xD0")]
	private ulong m_TabEndShowTime;

	[Token(Token = "0x400CE69")]
	[FieldOffset(Offset = "0xD8")]
	private Dictionary<uint, int> m_TabOrderDict;

	[Token(Token = "0x400CE6A")]
	[FieldOffset(Offset = "0xDC")]
	private Dictionary<uint, string> m_MallTabNameDict;

	[Token(Token = "0x400CE6B")]
	[FieldOffset(Offset = "0xE0")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400CE6C")]
	[FieldOffset(Offset = "0xE4")]
	private List<FlashStoreGoodsDesc> m_CurrentTabItemList;

	[Token(Token = "0x400CE6D")]
	[FieldOffset(Offset = "0xE8")]
	private FlashStoreGoodsDesc m_CurrentSelectItem;

	[Token(Token = "0x400CE6E")]
	[FieldOffset(Offset = "0xEC")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400CE6F")]
	[FieldOffset(Offset = "0xF0")]
	private UIModelFlashStore.ECurrentSelectItemAvailableState m_CurrentSelectItemAvailableState;

	[Token(Token = "0x400CE70")]
	[FieldOffset(Offset = "0xF4")]
	private UIModelFlashStore.EFlashStoreItemPriceState m_CurrentSelectItemGemsPriceState;

	[Token(Token = "0x400CE71")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<FlashStoreGoodsDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CE72")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<FlashStoreGoodsDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17000FF0")]
	public UIModelFlashStore.UILimitedStoreTabType CurrentSelectedTab
	{
		[Token(Token = "0x600AB47")]
		[Address(RVA = "0x1B509E0", Offset = "0x1B509E0", VA = "0x1B509E0")]
		get
		{
			return default(UIModelFlashStore.UILimitedStoreTabType);
		}
		[Token(Token = "0x600AB48")]
		[Address(RVA = "0x1B50A38", Offset = "0x1B50A38", VA = "0x1B50A38")]
		set
		{
		}
	}

	[Token(Token = "0x600AB46")]
	[Address(RVA = "0x1B50210", Offset = "0x1B50210", VA = "0x1B50210")]
	public UIFlashStoreNavigation()
	{
	}

	[Token(Token = "0x600AB49")]
	[Address(RVA = "0x1B50C0C", Offset = "0x1B50C0C", VA = "0x1B50C0C")]
	private void InitMallTabClickDelegateDict()
	{
	}

	[Token(Token = "0x600AB4A")]
	[Address(RVA = "0x1B50FAC", Offset = "0x1B50FAC", VA = "0x1B50FAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AB4B")]
	[Address(RVA = "0x1B51054", Offset = "0x1B51054", VA = "0x1B51054", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AB4C")]
	[Address(RVA = "0x1B515D4", Offset = "0x1B515D4", VA = "0x1B515D4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AB4D")]
	[Address(RVA = "0x1B53134", Offset = "0x1B53134", VA = "0x1B53134", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AB4E")]
	[Address(RVA = "0x1B53268", Offset = "0x1B53268", VA = "0x1B53268", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AB4F")]
	[Address(RVA = "0x1B532CC", Offset = "0x1B532CC", VA = "0x1B532CC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AB50")]
	[Address(RVA = "0x1B53718", Offset = "0x1B53718", VA = "0x1B53718", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600AB51")]
	[Address(RVA = "0x1B53788", Offset = "0x1B53788", VA = "0x1B53788", Slot = "63")]
	protected override void SetBgByCameraType(object[] param)
	{
	}

	[Token(Token = "0x600AB52")]
	[Address(RVA = "0x1B53998", Offset = "0x1B53998", VA = "0x1B53998", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600AB53")]
	[Address(RVA = "0x1B539F0", Offset = "0x1B539F0", VA = "0x1B539F0")]
	private void OnFlashStoreItemClickEventReceive(object[] data)
	{
	}

	[Token(Token = "0x600AB54")]
	[Address(RVA = "0x1B53DB8", Offset = "0x1B53DB8", VA = "0x1B53DB8")]
	private void BindTabTogglesDelegate()
	{
	}

	[Token(Token = "0x600AB55")]
	[Address(RVA = "0x1B540CC", Offset = "0x1B540CC", VA = "0x1B540CC")]
	private void OnTopBarFlashGemsTokenClick()
	{
	}

	[Token(Token = "0x600AB56")]
	[Address(RVA = "0x1B543C0", Offset = "0x1B543C0", VA = "0x1B543C0")]
	private void OnTopBarGemsTokenClick()
	{
	}

	[Token(Token = "0x600AB57")]
	[Address(RVA = "0x1B545E8", Offset = "0x1B545E8", VA = "0x1B545E8")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x600AB58")]
	[Address(RVA = "0x1B550B8", Offset = "0x1B550B8", VA = "0x1B550B8")]
	private void OnFreeAccessBtnClick()
	{
	}

	[Token(Token = "0x600AB59")]
	[Address(RVA = "0x1B55438", Offset = "0x1B55438", VA = "0x1B55438")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x600AB5A")]
	[Address(RVA = "0x1B55714", Offset = "0x1B55714", VA = "0x1B55714")]
	private void OnRecommendToggleSelected()
	{
	}

	[Token(Token = "0x600AB5B")]
	[Address(RVA = "0x1B55AB0", Offset = "0x1B55AB0", VA = "0x1B55AB0")]
	private void OnOtherToggleSelected()
	{
	}

	[Token(Token = "0x600AB5C")]
	[Address(RVA = "0x1B55B28", Offset = "0x1B55B28", VA = "0x1B55B28")]
	private void OnWeaponToggleSelected()
	{
	}

	[Token(Token = "0x600AB5D")]
	[Address(RVA = "0x1B55BA0", Offset = "0x1B55BA0", VA = "0x1B55BA0")]
	private void OnPetToggleSelected()
	{
	}

	[Token(Token = "0x600AB5E")]
	[Address(RVA = "0x1B55C18", Offset = "0x1B55C18", VA = "0x1B55C18")]
	private void OnCollectionToggleSelected()
	{
	}

	[Token(Token = "0x600AB5F")]
	[Address(RVA = "0x1B55C90", Offset = "0x1B55C90", VA = "0x1B55C90")]
	private void OnCharacterToggleSelected()
	{
	}

	[Token(Token = "0x600AB60")]
	[Address(RVA = "0x1B55D08", Offset = "0x1B55D08", VA = "0x1B55D08")]
	private void OnFashionToggleSelected()
	{
	}

	[Token(Token = "0x600AB61")]
	[Address(RVA = "0x1B53B74", Offset = "0x1B53B74", VA = "0x1B53B74")]
	private int GetCurrentSelectItemIndex(FlashStoreGoodsDesc item)
	{
		return default(int);
	}

	[Token(Token = "0x600AB62")]
	[Address(RVA = "0x1B51F58", Offset = "0x1B51F58", VA = "0x1B51F58")]
	private bool IsNavigateToActivityNecessary()
	{
		return default(bool);
	}

	[Token(Token = "0x600AB63")]
	[Address(RVA = "0x1B534DC", Offset = "0x1B534DC", VA = "0x1B534DC")]
	private void AddFlashStoreTabInfoToList(string tabName, uint viewTime)
	{
	}

	[Token(Token = "0x600AB64")]
	[Address(RVA = "0x1B50AB4", Offset = "0x1B50AB4", VA = "0x1B50AB4")]
	private void UpdateLastSelectTabViewTime(UIModelFlashStore.UILimitedStoreTabType lastSelectTab)
	{
	}

	[Token(Token = "0x600AB65")]
	[Address(RVA = "0x1B519F4", Offset = "0x1B519F4", VA = "0x1B519F4")]
	private static FlashStoreNavigationData GetNavigationData(List<object> rawData)
	{
		return null;
	}

	[Token(Token = "0x600AB66")]
	[Address(RVA = "0x1B55D90", Offset = "0x1B55D90", VA = "0x1B55D90")]
	private string GetMallTabName(uint type)
	{
		return null;
	}

	[Token(Token = "0x600AB67")]
	[Address(RVA = "0x1B55EBC", Offset = "0x1B55EBC", VA = "0x1B55EBC")]
	private void UpdateMallTab()
	{
	}

	[Token(Token = "0x600AB68")]
	[Address(RVA = "0x1B5578C", Offset = "0x1B5578C", VA = "0x1B5578C")]
	private void RefreshCurrentTabView(UIModelFlashStore.UILimitedStoreTabType mallTabType, bool isFromClick = true, int defaultSelectItemIndex = 0)
	{
	}

	[Token(Token = "0x600AB69")]
	[Address(RVA = "0x1B52D68", Offset = "0x1B52D68", VA = "0x1B52D68")]
	private void PrepareTopBarTokens()
	{
	}

	[Token(Token = "0x600AB6A")]
	[Address(RVA = "0x1B51B3C", Offset = "0x1B51B3C", VA = "0x1B51B3C")]
	private void InitDataAndUI()
	{
	}

	[Token(Token = "0x600AB6B")]
	[Address(RVA = "0x1B56FA0", Offset = "0x1B56FA0", VA = "0x1B56FA0")]
	private void InitPeriodAndTitleViewData()
	{
	}

	[Token(Token = "0x600AB6C")]
	[Address(RVA = "0x1B53CC4", Offset = "0x1B53CC4", VA = "0x1B53CC4")]
	private void RefreshCurrentViewData(FlashStoreGoodsDesc desc)
	{
	}

	[Token(Token = "0x600AB6D")]
	[Address(RVA = "0x1B56A08", Offset = "0x1B56A08", VA = "0x1B56A08")]
	private void UpdateActivityEntranceCountdown()
	{
	}

	[Token(Token = "0x600AB6E")]
	[Address(RVA = "0x1B56DF4", Offset = "0x1B56DF4", VA = "0x1B56DF4")]
	private void UpdateActivityTips()
	{
	}

	[Token(Token = "0x600AB6F")]
	[Address(RVA = "0x1B575C0", Offset = "0x1B575C0", VA = "0x1B575C0")]
	private void UpdateLimitedCountLabel(FlashStoreGoodsDesc exchangeItemDesc)
	{
	}

	[Token(Token = "0x600AB70")]
	[Address(RVA = "0x1B57514", Offset = "0x1B57514", VA = "0x1B57514")]
	private void UpdateItemAvailableState(FlashStoreGoodsDesc desc)
	{
	}

	[Token(Token = "0x600AB71")]
	[Address(RVA = "0x1B57988", Offset = "0x1B57988", VA = "0x1B57988")]
	private void UpdatePurchaseBtnView(FlashStoreGoodsDesc desc)
	{
	}

	[Token(Token = "0x600AB72")]
	[Address(RVA = "0x1B52F58", Offset = "0x1B52F58", VA = "0x1B52F58")]
	private void GotoFlashStoreActivity(FlashStoreNavigationData navData)
	{
	}

	[Token(Token = "0x600AB73")]
	[Address(RVA = "0x1B52708", Offset = "0x1B52708", VA = "0x1B52708")]
	private bool IsShowFlashStoreGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x600AB74")]
	[Address(RVA = "0x1B57CA4", Offset = "0x1B57CA4", VA = "0x1B57CA4")]
	private void PopGuideDataFromQueueAndExecute()
	{
	}

	[Token(Token = "0x600AB75")]
	[Address(RVA = "0x1B529C0", Offset = "0x1B529C0", VA = "0x1B529C0")]
	private void UpdateGuideDataAndEnqueue()
	{
	}

	[Token(Token = "0x600AB76")]
	[Address(RVA = "0x1B58484", Offset = "0x1B58484", VA = "0x1B58484")]
	private void UpdateGuideItemIndex(List<FlashStoreGoodsDesc> itemShowList)
	{
	}

	[Token(Token = "0x600AB77")]
	[Address(RVA = "0x1B5823C", Offset = "0x1B5823C", VA = "0x1B5823C")]
	private UICommonGuideData CreateFreeAccessGuideData()
	{
		return default(UICommonGuideData);
	}

	[Token(Token = "0x600AB78")]
	[Address(RVA = "0x1B5800C", Offset = "0x1B5800C", VA = "0x1B5800C")]
	private UICommonGuideData CreateItemListGuideData(UIWidget itemListWidget)
	{
		return default(UICommonGuideData);
	}

	[Token(Token = "0x600AB79")]
	[Address(RVA = "0x1B51FF8", Offset = "0x1B51FF8", VA = "0x1B51FF8")]
	public void NavigationToItem(uint itemID)
	{
	}

	[Token(Token = "0x600AB7A")]
	[Address(RVA = "0x1B4F4B0", Offset = "0x1B4F4B0", VA = "0x1B4F4B0")]
	public static void Push([Optional] List<object> data)
	{
	}

	[Token(Token = "0x600AB7B")]
	[Address(RVA = "0x1B586A8", Offset = "0x1B586A8", VA = "0x1B586A8")]
	protected void RefreshCurrentTabItemsDownloadState()
	{
	}

	[Token(Token = "0x600AB7C")]
	[Address(RVA = "0x1B588B8", Offset = "0x1B588B8", VA = "0x1B588B8", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AB7D")]
	[Address(RVA = "0x1B58970", Offset = "0x1B58970", VA = "0x1B58970", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AB7E")]
	[Address(RVA = "0x1B58B48", Offset = "0x1B58B48", VA = "0x1B58B48", Slot = "67")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600AB7F")]
	[Address(RVA = "0x1B56864", Offset = "0x1B56864", VA = "0x1B56864")]
	private void RefreshStoreItemEasyList(List<FlashStoreGoodsDesc> dataList, int defaultSelectItemIndex = 0)
	{
	}

	[Token(Token = "0x600AB80")]
	[Address(RVA = "0x1B58BC4", Offset = "0x1B58BC4", VA = "0x1B58BC4", Slot = "66")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600AB81")]
	[Address(RVA = "0x1B58CE4", Offset = "0x1B58CE4", VA = "0x1B58CE4")]
	private bool _003CGetCurrentSelectItemIndex_003Em__0(FlashStoreGoodsDesc t)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB82")]
	[Address(RVA = "0x1B58D30", Offset = "0x1B58D30", VA = "0x1B58D30")]
	private bool _003CUpdateMallTab_003Em__1(uint t)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB83")]
	[Address(RVA = "0x1B58D64", Offset = "0x1B58D64", VA = "0x1B58D64")]
	private int _003CUpdateMallTab_003Em__2(uint x, uint y)
	{
		return default(int);
	}

	[Token(Token = "0x600AB84")]
	[Address(RVA = "0x1B58E44", Offset = "0x1B58E44", VA = "0x1B58E44")]
	private void _003CInitPeriodAndTitleViewData_003Em__3()
	{
	}

	[Token(Token = "0x600AB85")]
	[Address(RVA = "0x1B58EE8", Offset = "0x1B58EE8", VA = "0x1B58EE8")]
	private void _003CUpdateActivityEntranceCountdown_003Em__4()
	{
	}

	[Token(Token = "0x600AB86")]
	[Address(RVA = "0x1B58F8C", Offset = "0x1B58F8C", VA = "0x1B58F8C")]
	private static bool _003CUpdateGuideItemIndex_003Em__5(FlashStoreGoodsDesc t)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB87")]
	[Address(RVA = "0x1B58FC8", Offset = "0x1B58FC8", VA = "0x1B58FC8")]
	private static bool _003CUpdateGuideItemIndex_003Em__6(FlashStoreGoodsDesc t)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB88")]
	[Address(RVA = "0x1B59008", Offset = "0x1B59008", VA = "0x1B59008")]
	private void _003CCreateFreeAccessGuideData_003Em__7()
	{
	}

	[Token(Token = "0x600AB89")]
	[Address(RVA = "0x1B590CC", Offset = "0x1B590CC", VA = "0x1B590CC")]
	private void _003CCreateFreeAccessGuideData_003Em__8()
	{
	}

	[Token(Token = "0x600AB8A")]
	[Address(RVA = "0x1B59310", Offset = "0x1B59310", VA = "0x1B59310")]
	private void _003CCreateItemListGuideData_003Em__9()
	{
	}

	[Token(Token = "0x600AB8B")]
	[Address(RVA = "0x1B593D4", Offset = "0x1B593D4", VA = "0x1B593D4")]
	private void _003CCreateItemListGuideData_003Em__A()
	{
	}

	[Token(Token = "0x600AB8C")]
	[Address(RVA = "0x1B59618", Offset = "0x1B59618", VA = "0x1B59618")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AB8D")]
	[Address(RVA = "0x1B59620", Offset = "0x1B59620", VA = "0x1B59620")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AB8E")]
	[Address(RVA = "0x1B59628", Offset = "0x1B59628", VA = "0x1B59628")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AB8F")]
	[Address(RVA = "0x1B59630", Offset = "0x1B59630", VA = "0x1B59630")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600AB90")]
	[Address(RVA = "0x1B59638", Offset = "0x1B59638", VA = "0x1B59638")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600AB91")]
	[Address(RVA = "0x1B59640", Offset = "0x1B59640", VA = "0x1B59640")]
	public void _003C_003EiFixBaseProxy_SetBgByCameraType(object[] P0)
	{
	}
}
