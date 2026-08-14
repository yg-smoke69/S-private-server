using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20020F4")]
public class UIFlashStoreActivityNavigationController : UINavigationController, _Attribute
{
	[Token(Token = "0x20020F5")]
	public class FlashStoreActivityNavigationData
	{
		[Token(Token = "0x400CE14")]
		[FieldOffset(Offset = "0x8")]
		public uint FlashStoreActivityID;

		[Token(Token = "0x400CE15")]
		[FieldOffset(Offset = "0xC")]
		public string From;

		[Token(Token = "0x400CE16")]
		[FieldOffset(Offset = "0x10")]
		public uint SelectGroupID;

		[Token(Token = "0x400CE17")]
		[FieldOffset(Offset = "0x14")]
		public uint SelectActivityID;

		[Token(Token = "0x600AB03")]
		[Address(RVA = "0x1DC9330", Offset = "0x1DC9330", VA = "0x1DC9330")]
		public FlashStoreActivityNavigationData()
		{
		}
	}

	[Token(Token = "0x20020F6")]
	private sealed class _003CResetScrollViewShowGuideCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CE18")]
		[FieldOffset(Offset = "0x8")]
		internal int selectedSubGroupIdx;

		[Token(Token = "0x400CE19")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CstartIdx_003E__0;

		[Token(Token = "0x400CE1A")]
		[FieldOffset(Offset = "0x10")]
		internal int _003CendIdx_003E__0;

		[Token(Token = "0x400CE1B")]
		[FieldOffset(Offset = "0x14")]
		internal Transform[] _003Ctargets_003E__0;

		[Token(Token = "0x400CE1C")]
		[FieldOffset(Offset = "0x18")]
		internal UIBaseController _003CfirstController_003E__0;

		[Token(Token = "0x400CE1D")]
		[FieldOffset(Offset = "0x1C")]
		internal float _003Cprotection_003E__0;

		[Token(Token = "0x400CE1E")]
		[FieldOffset(Offset = "0x20")]
		internal Bounds _003Cbounds_003E__1;

		[Token(Token = "0x400CE1F")]
		[FieldOffset(Offset = "0x38")]
		internal Vector3 _003Coffset_003E__1;

		[Token(Token = "0x400CE20")]
		[FieldOffset(Offset = "0x44")]
		internal int _003CwaitCount_003E__0;

		[Token(Token = "0x400CE21")]
		[FieldOffset(Offset = "0x48")]
		internal WaitForSeconds _003CwaitForSeconds_003E__0;

		[Token(Token = "0x400CE22")]
		[FieldOffset(Offset = "0x4C")]
		internal UIBaseController[] _003CcacheCtrlList_003E__0;

		[Token(Token = "0x400CE23")]
		[FieldOffset(Offset = "0x50")]
		internal int _003Ci_003E__2;

		[Token(Token = "0x400CE24")]
		[FieldOffset(Offset = "0x54")]
		internal UIFlashStoreActivityItemController _003CitemController_003E__3;

		[Token(Token = "0x400CE25")]
		[FieldOffset(Offset = "0x58")]
		internal UIFlashStoreActivityNavigationController _0024this;

		[Token(Token = "0x400CE26")]
		[FieldOffset(Offset = "0x5C")]
		internal object _0024current;

		[Token(Token = "0x400CE27")]
		[FieldOffset(Offset = "0x60")]
		internal bool _0024disposing;

		[Token(Token = "0x400CE28")]
		[FieldOffset(Offset = "0x64")]
		internal int _0024PC;

		[Token(Token = "0x17000FEB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AB06")]
			[Address(RVA = "0x1DCE7C8", Offset = "0x1DCE7C8", VA = "0x1DCE7C8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FEC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AB07")]
			[Address(RVA = "0x1DCE7D0", Offset = "0x1DCE7D0", VA = "0x1DCE7D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AB04")]
		[Address(RVA = "0x1DCB058", Offset = "0x1DCB058", VA = "0x1DCB058")]
		public _003CResetScrollViewShowGuideCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AB05")]
		[Address(RVA = "0x1DCDA04", Offset = "0x1DCDA04", VA = "0x1DCDA04", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AB08")]
		[Address(RVA = "0x1DCE7D8", Offset = "0x1DCE7D8", VA = "0x1DCE7D8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AB09")]
		[Address(RVA = "0x1DCE7EC", Offset = "0x1DCE7EC", VA = "0x1DCE7EC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CE01")]
	public const string LOG_IDENTIFIER = "FlashStoreActivityNavigation";

	[Token(Token = "0x400CE02")]
	private const string TITLE_DESC_KEY = "T_35_LC_FLASHSTORE_HINT1";

	[Token(Token = "0x400CE03")]
	private const string RULE_POPUP_TITLE_KEY = "TXT_CLAN_GENERAL";

	[Token(Token = "0x400CE04")]
	private const string ACTIVITIES_PANEL_DESC_KEY = "T_35_LC_FLASHSTORE_NUMBER";

	[Token(Token = "0x400CE05")]
	private const string GUIDE_STEP1_KEY = "FlashStoreActivity_Step1_Account{0}";

	[Token(Token = "0x400CE06")]
	private const string GUIDE_STEP2_KEY = "FlashStoreActivity_Step2_Account{0}";

	[Token(Token = "0x400CE07")]
	private const string GUIDE_STEP3_KEY = "FlashStoreActivity_Step3_Account{0}";

	[Token(Token = "0x400CE08")]
	private const string FLASH_GEM_SPRITE_NAME = "FF_UI_FlashStore_PurpleDiamond";

	[Token(Token = "0x400CE09")]
	private const string NORMAL_GEM_SPRITE_NAME = "FF_UI_FlashStore_Diamond";

	[Token(Token = "0x400CE0A")]
	[FieldOffset(Offset = "0x68")]
	private uint m_FlashStoreActivityID;

	[Token(Token = "0x400CE0B")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_SelectedActivityGroupID;

	[Token(Token = "0x400CE0C")]
	[FieldOffset(Offset = "0x70")]
	private uint m_DelayExecuteGuidePeek;

	[Token(Token = "0x400CE0D")]
	[FieldOffset(Offset = "0x74")]
	private UIFlashStoreActivityNavigationView m_View;

	[Token(Token = "0x400CE0E")]
	[FieldOffset(Offset = "0x78")]
	private Coroutine m_ResetScrollViewShowGuideCoroutine;

	[Token(Token = "0x400CE0F")]
	[FieldOffset(Offset = "0x7C")]
	private readonly List<int> m_ActivitySubGroupStartIndexList;

	[Token(Token = "0x400CE10")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<UIBaseController> m_ActivityPanelCtrlList;

	[Token(Token = "0x400CE11")]
	[FieldOffset(Offset = "0x84")]
	private readonly List<UIFlashStoreActivityPhaseNodeController> m_PhaseNodeCtrlList;

	[Token(Token = "0x400CE12")]
	[FieldOffset(Offset = "0x88")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400CE13")]
	[FieldOffset(Offset = "0x0")]
	private static Callback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x600AAD5")]
	[Address(RVA = "0x1DC5D5C", Offset = "0x1DC5D5C", VA = "0x1DC5D5C")]
	public UIFlashStoreActivityNavigationController()
	{
	}

	[Token(Token = "0x600AAD6")]
	[Address(RVA = "0x1DC5EB0", Offset = "0x1DC5EB0", VA = "0x1DC5EB0")]
	public static void Push([Optional] List<object> data)
	{
	}

	[Token(Token = "0x600AAD7")]
	[Address(RVA = "0x1DC68A0", Offset = "0x1DC68A0", VA = "0x1DC68A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AAD8")]
	[Address(RVA = "0x1DC6948", Offset = "0x1DC6948", VA = "0x1DC6948", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AAD9")]
	[Address(RVA = "0x1DC6EE4", Offset = "0x1DC6EE4", VA = "0x1DC6EE4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600AADA")]
	[Address(RVA = "0x1DC7160", Offset = "0x1DC7160", VA = "0x1DC7160", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AADB")]
	[Address(RVA = "0x1DC8A3C", Offset = "0x1DC8A3C", VA = "0x1DC8A3C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600AADC")]
	[Address(RVA = "0x1DC929C", Offset = "0x1DC929C", VA = "0x1DC929C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600AADD")]
	[Address(RVA = "0x1DC6758", Offset = "0x1DC6758", VA = "0x1DC6758")]
	private static FlashStoreActivityNavigationData GetNavigationData(List<object> rawData)
	{
		return null;
	}

	[Token(Token = "0x600AADE")]
	[Address(RVA = "0x1DC93E0", Offset = "0x1DC93E0", VA = "0x1DC93E0")]
	private int GetFlashStoreActivityTypeScore(ClientActivityDesc activityDesc)
	{
		return default(int);
	}

	[Token(Token = "0x600AADF")]
	[Address(RVA = "0x1DC9570", Offset = "0x1DC9570", VA = "0x1DC9570")]
	private int GetFlashStoreActivityStateScore(uint activityID)
	{
		return default(int);
	}

	[Token(Token = "0x600AAE0")]
	[Address(RVA = "0x1DC9710", Offset = "0x1DC9710", VA = "0x1DC9710")]
	private List<ClientActivityDesc> GetSortedActivityDescList()
	{
		return null;
	}

	[Token(Token = "0x600AAE1")]
	[Address(RVA = "0x1DC8070", Offset = "0x1DC8070", VA = "0x1DC8070")]
	private uint GetPhaseNodeToSelect(uint[] activityGroupIDArray, uint assignedSelectGroupID)
	{
		return default(uint);
	}

	[Token(Token = "0x600AAE2")]
	[Address(RVA = "0x1DC99F8", Offset = "0x1DC99F8", VA = "0x1DC99F8")]
	private int GetSubGroupIdxToSelect(List<ClientActivityDesc> sortedActivityDescList, uint assignedSelectActivityID = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x600AAE3")]
	[Address(RVA = "0x1DC8468", Offset = "0x1DC8468", VA = "0x1DC8468")]
	private void SelectPhaseNode(uint activityGroupID)
	{
	}

	[Token(Token = "0x600AAE4")]
	[Address(RVA = "0x1DCA748", Offset = "0x1DCA748", VA = "0x1DCA748")]
	private int FlashStoreActivityComparison(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x600AAE5")]
	[Address(RVA = "0x1DC87D8", Offset = "0x1DC87D8", VA = "0x1DC87D8")]
	private void AfterPhaseNodeSelected(uint assignedSelectActivityID = 0u)
	{
	}

	[Token(Token = "0x600AAE6")]
	[Address(RVA = "0x1DCAECC", Offset = "0x1DCAECC", VA = "0x1DCAECC")]
	private void StartResetScrollViewShowGuideCoroutine(int selectedSubGroupIdx)
	{
	}

	[Token(Token = "0x600AAE7")]
	[Address(RVA = "0x1DCAF6C", Offset = "0x1DCAF6C", VA = "0x1DCAF6C")]
	private IEnumerator ResetScrollViewShowGuideCoroutine(int selectedSubGroupIdx)
	{
		return null;
	}

	[Token(Token = "0x600AAE8")]
	[Address(RVA = "0x1DC6CA0", Offset = "0x1DC6CA0", VA = "0x1DC6CA0")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x600AAE9")]
	[Address(RVA = "0x1DCB060", Offset = "0x1DCB060", VA = "0x1DCB060")]
	private void OnTitleImageDownloadFinished()
	{
	}

	[Token(Token = "0x600AAEA")]
	[Address(RVA = "0x1DC7394", Offset = "0x1DC7394", VA = "0x1DC7394")]
	private void PrepareTopBarTokens()
	{
	}

	[Token(Token = "0x600AAEB")]
	[Address(RVA = "0x1DC7AE8", Offset = "0x1DC7AE8", VA = "0x1DC7AE8")]
	private void RefreshAllPhaseNodesAndSliderValue(uint[] activityGroupArray)
	{
	}

	[Token(Token = "0x600AAEC")]
	[Address(RVA = "0x1DCB1F0", Offset = "0x1DCB1F0", VA = "0x1DCB1F0")]
	private void AdjustSliderHeightOnReposition()
	{
	}

	[Token(Token = "0x600AAED")]
	[Address(RVA = "0x1DC7600", Offset = "0x1DC7600", VA = "0x1DC7600")]
	private void RefreshTitleImage()
	{
	}

	[Token(Token = "0x600AAEE")]
	[Address(RVA = "0x1DC7864", Offset = "0x1DC7864", VA = "0x1DC7864")]
	private void RefreshTitleDescription()
	{
	}

	[Token(Token = "0x600AAEF")]
	[Address(RVA = "0x1DCA87C", Offset = "0x1DCA87C", VA = "0x1DCA87C")]
	private void RefreshActivitiesPanel(List<ClientActivityDesc> shallowCopiedList)
	{
	}

	[Token(Token = "0x600AAF0")]
	[Address(RVA = "0x1DC8F4C", Offset = "0x1DC8F4C", VA = "0x1DC8F4C")]
	private void RefreshActivitiesPanelTitle()
	{
	}

	[Token(Token = "0x600AAF1")]
	[Address(RVA = "0x1DC8B10", Offset = "0x1DC8B10", VA = "0x1DC8B10")]
	private void RefreshActivitiesPanelContent()
	{
	}

	[Token(Token = "0x600AAF2")]
	[Address(RVA = "0x1DC8D94", Offset = "0x1DC8D94", VA = "0x1DC8D94")]
	private void RefreshActivitiesPanelReceiveAllBtn()
	{
	}

	[Token(Token = "0x600AAF3")]
	[Address(RVA = "0x1DCB668", Offset = "0x1DCB668", VA = "0x1DCB668")]
	private static void OnTopBarGemsTokenClick()
	{
	}

	[Token(Token = "0x600AAF4")]
	[Address(RVA = "0x1DC6A94", Offset = "0x1DC6A94", VA = "0x1DC6A94")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AAF5")]
	[Address(RVA = "0x1DCB888", Offset = "0x1DCB888", VA = "0x1DCB888")]
	private void OnReceiveAllBtnClick()
	{
	}

	[Token(Token = "0x600AAF6")]
	[Address(RVA = "0x1DCBBB4", Offset = "0x1DCBBB4", VA = "0x1DCBBB4")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x600AAF7")]
	[Address(RVA = "0x1DCBF40", Offset = "0x1DCBF40", VA = "0x1DCBF40")]
	private void OnPhaseNodeSelect(uint activityGroupID)
	{
	}

	[Token(Token = "0x600AAF8")]
	[Address(RVA = "0x1DCC0B8", Offset = "0x1DCC0B8", VA = "0x1DCC0B8")]
	private bool TryGetGuideStep1Widget(out UIWidget widget)
	{
		return default(bool);
	}

	[Token(Token = "0x600AAF9")]
	[Address(RVA = "0x1DCC4A0", Offset = "0x1DCC4A0", VA = "0x1DCC4A0")]
	private bool TryGetGuideStep2Widget(out UIWidget widget)
	{
		return default(bool);
	}

	[Token(Token = "0x600AAFA")]
	[Address(RVA = "0x1DCC888", Offset = "0x1DCC888", VA = "0x1DCC888")]
	private bool TryGetGuideStep3Widget(out UIWidget widget)
	{
		return default(bool);
	}

	[Token(Token = "0x600AAFB")]
	[Address(RVA = "0x1DC7024", Offset = "0x1DC7024", VA = "0x1DC7024")]
	private void StopGuideQueue()
	{
	}

	[Token(Token = "0x600AAFC")]
	[Address(RVA = "0x1DCCB8C", Offset = "0x1DCCB8C", VA = "0x1DCCB8C")]
	private void PrepareGuideDataQueue()
	{
	}

	[Token(Token = "0x600AAFD")]
	[Address(RVA = "0x1DCD160", Offset = "0x1DCD160", VA = "0x1DCD160")]
	private void StartDelayExecuteGuidePeek()
	{
	}

	[Token(Token = "0x600AAFE")]
	[Address(RVA = "0x1DCD32C", Offset = "0x1DCD32C", VA = "0x1DCD32C")]
	private void DelayExecuteGuidePeek()
	{
	}

	[Token(Token = "0x600AAFF")]
	[Address(RVA = "0x1DCD71C", Offset = "0x1DCD71C", VA = "0x1DCD71C")]
	private void PopAndExecuteNext()
	{
	}

	[Token(Token = "0x600AB00")]
	[Address(RVA = "0x1DCD9EC", Offset = "0x1DCD9EC", VA = "0x1DCD9EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AB01")]
	[Address(RVA = "0x1DCD9F4", Offset = "0x1DCD9F4", VA = "0x1DCD9F4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600AB02")]
	[Address(RVA = "0x1DCD9FC", Offset = "0x1DCD9FC", VA = "0x1DCD9FC")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
