using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029DD")]
public class UINewAutoPickUpSettingController : UISettingContentBase
{
	[Token(Token = "0x20029DE")]
	private struct UICommonGuideData
	{
		[Token(Token = "0x4010184")]
		[FieldOffset(Offset = "0x0")]
		public string PlayerPrefKey;

		[Token(Token = "0x4010185")]
		[FieldOffset(Offset = "0x4")]
		public CommonGuideSetting Setting;

		[Token(Token = "0x4010186")]
		[FieldOffset(Offset = "0x8")]
		public UIButton FinishGuideBtn;

		[Token(Token = "0x4010187")]
		[FieldOffset(Offset = "0xC")]
		public UIWidget GuidingWidget;

		[Token(Token = "0x4010188")]
		[FieldOffset(Offset = "0x10")]
		public Side Side;
	}

	[Token(Token = "0x20029DF")]
	private enum EAutoPickupTabType
	{
		[Token(Token = "0x401018A")]
		None,
		[Token(Token = "0x401018B")]
		State,
		[Token(Token = "0x401018C")]
		Priority
	}

	[Token(Token = "0x20029E0")]
	private sealed class _003CCreateAutoPickupSpeedSetBtnGroup_003Ec__AnonStorey3
	{
		[Token(Token = "0x401018D")]
		[FieldOffset(Offset = "0x8")]
		internal AutoPickupConfigData configData;

		[Token(Token = "0x6010DCC")]
		[Address(RVA = "0x279AF98", Offset = "0x279AF98", VA = "0x279AF98")]
		public _003CCreateAutoPickupSpeedSetBtnGroup_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6010DCD")]
		[Address(RVA = "0x279E2F4", Offset = "0x279E2F4", VA = "0x279E2F4")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010DCE")]
		[Address(RVA = "0x279E324", Offset = "0x279E324", VA = "0x279E324")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6010DCF")]
		[Address(RVA = "0x279E354", Offset = "0x279E354", VA = "0x279E354")]
		internal int _003C_003Em__2()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20029E1")]
	private sealed class _003CCreateAutoPickupItemToggleBtnGroup_003Ec__AnonStorey4
	{
		[Token(Token = "0x401018E")]
		[FieldOffset(Offset = "0x8")]
		internal AutoPickupConfigData configData;

		[Token(Token = "0x6010DD0")]
		[Address(RVA = "0x279AFA0", Offset = "0x279AFA0", VA = "0x279AFA0")]
		public _003CCreateAutoPickupItemToggleBtnGroup_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6010DD1")]
		[Address(RVA = "0x279E260", Offset = "0x279E260", VA = "0x279E260")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010DD2")]
		[Address(RVA = "0x279E290", Offset = "0x279E290", VA = "0x279E290")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6010DD3")]
		[Address(RVA = "0x279E2C0", Offset = "0x279E2C0", VA = "0x279E2C0")]
		internal int _003C_003Em__2()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20029E2")]
	private sealed class _003CDelayRefreshScrollView_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401018F")]
		[FieldOffset(Offset = "0x8")]
		internal UINewAutoPickUpSettingController _0024this;

		[Token(Token = "0x4010190")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010191")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010192")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700126D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010DD6")]
			[Address(RVA = "0x279E494", Offset = "0x279E494", VA = "0x279E494", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700126E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010DD7")]
			[Address(RVA = "0x279E49C", Offset = "0x279E49C", VA = "0x279E49C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010DD4")]
		[Address(RVA = "0x279BDCC", Offset = "0x279BDCC", VA = "0x279BDCC")]
		public _003CDelayRefreshScrollView_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010DD5")]
		[Address(RVA = "0x279E390", Offset = "0x279E390", VA = "0x279E390", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010DD8")]
		[Address(RVA = "0x279E4A4", Offset = "0x279E4A4", VA = "0x279E4A4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010DD9")]
		[Address(RVA = "0x279E4B8", Offset = "0x279E4B8", VA = "0x279E4B8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20029E3")]
	private sealed class _003CRepositionMenuLayout_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010193")]
		[FieldOffset(Offset = "0x8")]
		internal UINewAutoPickUpSettingController _0024this;

		[Token(Token = "0x4010194")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010195")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010196")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700126F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010DDC")]
			[Address(RVA = "0x279E98C", Offset = "0x279E98C", VA = "0x279E98C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001270")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010DDD")]
			[Address(RVA = "0x279E994", Offset = "0x279E994", VA = "0x279E994", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010DDA")]
		[Address(RVA = "0x279CF14", Offset = "0x279CF14", VA = "0x279CF14")]
		public _003CRepositionMenuLayout_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6010DDB")]
		[Address(RVA = "0x279E7D0", Offset = "0x279E7D0", VA = "0x279E7D0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010DDE")]
		[Address(RVA = "0x279E99C", Offset = "0x279E99C", VA = "0x279E99C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010DDF")]
		[Address(RVA = "0x279E9B0", Offset = "0x279E9B0", VA = "0x279E9B0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20029E4")]
	private sealed class _003CExchangePriorityAndRefresh_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010197")]
		[FieldOffset(Offset = "0x8")]
		internal UIBaseController priorityController;

		[Token(Token = "0x4010198")]
		[FieldOffset(Offset = "0xC")]
		internal bool up;

		[Token(Token = "0x4010199")]
		[FieldOffset(Offset = "0x10")]
		internal UINewAutoPickUpSettingController _0024this;

		[Token(Token = "0x401019A")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x401019B")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x401019C")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001271")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010DE2")]
			[Address(RVA = "0x279E724", Offset = "0x279E724", VA = "0x279E724", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001272")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010DE3")]
			[Address(RVA = "0x279E72C", Offset = "0x279E72C", VA = "0x279E72C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010DE0")]
		[Address(RVA = "0x279D0F0", Offset = "0x279D0F0", VA = "0x279D0F0")]
		public _003CExchangePriorityAndRefresh_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x6010DE1")]
		[Address(RVA = "0x279E540", Offset = "0x279E540", VA = "0x279E540", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010DE4")]
		[Address(RVA = "0x279E734", Offset = "0x279E734", VA = "0x279E734", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010DE5")]
		[Address(RVA = "0x279E748", Offset = "0x279E748", VA = "0x279E748", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401016B")]
	private const string FAST_AUTO_PICKUP_KEY = "T_21_C_AUTOPICKUP_FAST";

	[Token(Token = "0x401016C")]
	private const string DEFAULT_AUTO_PICKUP_KEY = "T_21_C_AUTOPICKUP_AVERAGE";

	[Token(Token = "0x401016D")]
	private const string AUTO_PICKUP_ITEM_CLOSE_LABEL_KEY = "TXT_SETTING_CLOSE";

	[Token(Token = "0x401016E")]
	private const string AUTO_PICKUP_ITEM_OPEN_LABEL_KEY = "TXT_SETTING_OPEN";

	[Token(Token = "0x401016F")]
	private const string GUIDE_LIST_KEY_STEP1_KEY = "UINewAutoPickupSetting_Step1";

	[Token(Token = "0x4010170")]
	private const string GUIDE_LIST_KEY_STEP2_KEY = "UINewAutoPickupSetting_Step2";

	[Token(Token = "0x4010171")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<string> ShowTipsParam;

	[Token(Token = "0x4010172")]
	[FieldOffset(Offset = "0x4")]
	private static bool m_TransferVersionOnce;

	[Token(Token = "0x4010173")]
	[FieldOffset(Offset = "0x2C")]
	private int m_CurrentTypeID;

	[Token(Token = "0x4010174")]
	[FieldOffset(Offset = "0x30")]
	private EAutoPickupTabType m_CurrentTab;

	[Token(Token = "0x4010175")]
	[FieldOffset(Offset = "0x34")]
	private int m_PreviousTypeID;

	[Token(Token = "0x4010176")]
	[FieldOffset(Offset = "0x38")]
	private EAutoPickupTabType m_PreviousTab;

	[Token(Token = "0x4010177")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_DelayExecuteGuidance;

	[Token(Token = "0x4010178")]
	[FieldOffset(Offset = "0x40")]
	private uint m_DelayDisableGuideCoverBtn;

	[Token(Token = "0x4010179")]
	[FieldOffset(Offset = "0x44")]
	private Coroutine m_RefreshScrollViewCoroutine;

	[Token(Token = "0x401017A")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine m_RefreshMenuLayoutCoroutine;

	[Token(Token = "0x401017B")]
	[FieldOffset(Offset = "0x4C")]
	private Coroutine m_ExchangePriorityAndRefreshCoroutine;

	[Token(Token = "0x401017C")]
	[FieldOffset(Offset = "0x50")]
	private UINewAutoPickUpSettingView m_View;

	[Token(Token = "0x401017D")]
	[FieldOffset(Offset = "0x54")]
	private UICommonSettingContentController m_CommonSettingContentController;

	[Token(Token = "0x401017E")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<UIBaseController> m_PriorityActiveItemControllers;

	[Token(Token = "0x401017F")]
	[FieldOffset(Offset = "0x5C")]
	private readonly List<UIBaseController> m_PriorityFreezeItemControllers;

	[Token(Token = "0x4010180")]
	[FieldOffset(Offset = "0x60")]
	private UIHudPopupController m_SelfManagedPopupController;

	[Token(Token = "0x4010181")]
	[FieldOffset(Offset = "0x64")]
	private readonly Dictionary<UIToggleButton, int> m_ToggleTypeIDMap;

	[Token(Token = "0x4010182")]
	[FieldOffset(Offset = "0x68")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x4010183")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<CSVBaseData, AutoPickupMappingConfigData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700126C")]
	private bool IsInGame
	{
		[Token(Token = "0x6010DA1")]
		[Address(RVA = "0x2798630", Offset = "0x2798630", VA = "0x2798630")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6010D9F")]
	[Address(RVA = "0x2798470", Offset = "0x2798470", VA = "0x2798470")]
	public UINewAutoPickUpSettingController()
	{
	}

	[Token(Token = "0x6010DA0")]
	[Address(RVA = "0x2798588", Offset = "0x2798588", VA = "0x2798588")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010DA2")]
	[Address(RVA = "0x279875C", Offset = "0x279875C", VA = "0x279875C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010DA3")]
	[Address(RVA = "0x27991FC", Offset = "0x27991FC", VA = "0x27991FC", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010DA4")]
	[Address(RVA = "0x2799450", Offset = "0x2799450", VA = "0x2799450", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x6010DA5")]
	[Address(RVA = "0x27995D4", Offset = "0x27995D4", VA = "0x27995D4")]
	private void OnPlayerGuideFinished()
	{
	}

	[Token(Token = "0x6010DA6")]
	[Address(RVA = "0x2799704", Offset = "0x2799704", VA = "0x2799704")]
	private void PopAndExecuteNext()
	{
	}

	[Token(Token = "0x6010DA7")]
	[Address(RVA = "0x2799AB0", Offset = "0x2799AB0", VA = "0x2799AB0")]
	private void ExecuteGuideQueuePeek()
	{
	}

	[Token(Token = "0x6010DA8")]
	[Address(RVA = "0x27998E4", Offset = "0x27998E4", VA = "0x27998E4")]
	private void DelayCallExecuteGuidePeek()
	{
	}

	[Token(Token = "0x6010DA9")]
	[Address(RVA = "0x2799D08", Offset = "0x2799D08", VA = "0x2799D08")]
	private void DelayCallDisableGuideCoverBtn()
	{
	}

	[Token(Token = "0x6010DAA")]
	[Address(RVA = "0x2799ED4", Offset = "0x2799ED4", VA = "0x2799ED4")]
	private void PrepareGuideQueue()
	{
	}

	[Token(Token = "0x6010DAB")]
	[Address(RVA = "0x279A660", Offset = "0x279A660", VA = "0x279A660")]
	private CommonSettingContentData CreateAutoPickupContentData()
	{
		return null;
	}

	[Token(Token = "0x6010DAC")]
	[Address(RVA = "0x279A990", Offset = "0x279A990", VA = "0x279A990")]
	private static CommonSettingItemDataToggleBtns CreateAutoPickupSpeedSetBtnGroup(AutoPickupConfigData configData)
	{
		return null;
	}

	[Token(Token = "0x6010DAD")]
	[Address(RVA = "0x279AC94", Offset = "0x279AC94", VA = "0x279AC94")]
	private static CommonSettingItemDataToggleBtns CreateAutoPickupItemToggleBtnGroup(AutoPickupConfigData configData)
	{
		return null;
	}

	[Token(Token = "0x6010DAE")]
	[Address(RVA = "0x279AFA8", Offset = "0x279AFA8", VA = "0x279AFA8")]
	private static void TransferPlayerPrefsVersion()
	{
	}

	[Token(Token = "0x6010DAF")]
	[Address(RVA = "0x279B264", Offset = "0x279B264", VA = "0x279B264")]
	private static void SetTitleToggleBtnText(UIToggleButton toggleButton, string text)
	{
	}

	[Token(Token = "0x6010DB0")]
	[Address(RVA = "0x279B3B0", Offset = "0x279B3B0", VA = "0x279B3B0")]
	private bool BuildInGameSettingGroupTitleGrid()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DB1")]
	[Address(RVA = "0x279B7BC", Offset = "0x279B7BC", VA = "0x279B7BC")]
	private bool BuildNotInGameSettingGroupTitleGrid()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DB2")]
	[Address(RVA = "0x2798E8C", Offset = "0x2798E8C", VA = "0x2798E8C")]
	private bool BuildSettingGroupTitleGrid()
	{
		return default(bool);
	}

	[Token(Token = "0x6010DB3")]
	[Address(RVA = "0x2798D64", Offset = "0x2798D64", VA = "0x2798D64")]
	private void PrepareTabContainer()
	{
	}

	[Token(Token = "0x6010DB4")]
	[Address(RVA = "0x279BC6C", Offset = "0x279BC6C", VA = "0x279BC6C")]
	private void ResetScrollViewState()
	{
	}

	[Token(Token = "0x6010DB5")]
	[Address(RVA = "0x279BD00", Offset = "0x279BD00", VA = "0x279BD00")]
	private IEnumerator DelayRefreshScrollView()
	{
		return null;
	}

	[Token(Token = "0x6010DB6")]
	[Address(RVA = "0x279BDD4", Offset = "0x279BDD4", VA = "0x279BDD4")]
	private void OnDisplayContentChanged()
	{
	}

	[Token(Token = "0x6010DB7")]
	[Address(RVA = "0x279C2A0", Offset = "0x279C2A0", VA = "0x279C2A0")]
	private void CloseAllContent()
	{
	}

	[Token(Token = "0x6010DB8")]
	[Address(RVA = "0x279C610", Offset = "0x279C610", VA = "0x279C610")]
	private void DisplayAutoPickupStateContent()
	{
	}

	[Token(Token = "0x6010DB9")]
	[Address(RVA = "0x279C78C", Offset = "0x279C78C", VA = "0x279C78C")]
	private int DisplayPriorityActiveSettingContent()
	{
		return default(int);
	}

	[Token(Token = "0x6010DBA")]
	[Address(RVA = "0x279CAA0", Offset = "0x279CAA0", VA = "0x279CAA0")]
	private int DisplayPriorityFreezeSettingContent()
	{
		return default(int);
	}

	[Token(Token = "0x6010DBB")]
	[Address(RVA = "0x279BF50", Offset = "0x279BF50", VA = "0x279BF50")]
	private void DisplaySettingContent()
	{
	}

	[Token(Token = "0x6010DBC")]
	[Address(RVA = "0x279CDB4", Offset = "0x279CDB4", VA = "0x279CDB4")]
	public void OnMenuItemLayoutChanged()
	{
	}

	[Token(Token = "0x6010DBD")]
	[Address(RVA = "0x279CE48", Offset = "0x279CE48", VA = "0x279CE48")]
	private IEnumerator RepositionMenuLayout()
	{
		return null;
	}

	[Token(Token = "0x6010DBE")]
	[Address(RVA = "0x279CF1C", Offset = "0x279CF1C", VA = "0x279CF1C")]
	private void ExchangePriorityAfterClosingAllMenu(UIBaseController priorityController, bool up)
	{
	}

	[Token(Token = "0x6010DBF")]
	[Address(RVA = "0x279CFD8", Offset = "0x279CFD8", VA = "0x279CFD8")]
	private IEnumerator ExchangePriorityAndRefresh(UIBaseController priorityController, bool up)
	{
		return null;
	}

	[Token(Token = "0x6010DC0")]
	[Address(RVA = "0x279D0F8", Offset = "0x279D0F8", VA = "0x279D0F8")]
	public void OnPrioritySettingItemMoved(UIBaseController priorityController, int pickupItemID, bool up)
	{
	}

	[Token(Token = "0x6010DC1")]
	[Address(RVA = "0x2798AF4", Offset = "0x2798AF4", VA = "0x2798AF4")]
	private void AddEventDelegates()
	{
	}

	[Token(Token = "0x6010DC2")]
	[Address(RVA = "0x279D3DC", Offset = "0x279D3DC", VA = "0x279D3DC")]
	private void OnSettingTypeTitleSelect(UIToggleButton button)
	{
	}

	[Token(Token = "0x6010DC3")]
	[Address(RVA = "0x279D55C", Offset = "0x279D55C", VA = "0x279D55C")]
	private void OnSettingTabSelect(UIToggleButton button)
	{
	}

	[Token(Token = "0x6010DC4")]
	[Address(RVA = "0x279D944", Offset = "0x279D944", VA = "0x279D944")]
	private void OnResetConfirmed()
	{
	}

	[Token(Token = "0x6010DC5")]
	[Address(RVA = "0x279DA1C", Offset = "0x279DA1C", VA = "0x279DA1C")]
	private void OnResetBtn()
	{
	}

	[Token(Token = "0x6010DC6")]
	[Address(RVA = "0x279DC9C", Offset = "0x279DC9C", VA = "0x279DC9C")]
	private void OnSettingTypeHelpBtn()
	{
	}

	[Token(Token = "0x6010DC8")]
	[Address(RVA = "0x279E1B4", Offset = "0x279E1B4", VA = "0x279E1B4")]
	private static AutoPickupMappingConfigData _003CBuildNotInGameSettingGroupTitleGrid_003Em__0(CSVBaseData data)
	{
		return null;
	}

	[Token(Token = "0x6010DC9")]
	[Address(RVA = "0x279E248", Offset = "0x279E248", VA = "0x279E248")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010DCA")]
	[Address(RVA = "0x279E250", Offset = "0x279E250", VA = "0x279E250")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6010DCB")]
	[Address(RVA = "0x279E258", Offset = "0x279E258", VA = "0x279E258")]
	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}
}
