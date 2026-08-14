using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002150")]
public class UILabNavigationController : UINavigationController
{
	[Token(Token = "0x2002151")]
	private struct UICommonGuideData
	{
		[Token(Token = "0x400D141")]
		[FieldOffset(Offset = "0x0")]
		public string PlayerPrefKey;

		[Token(Token = "0x400D142")]
		[FieldOffset(Offset = "0x4")]
		public CommonGuideSetting Setting;

		[Token(Token = "0x400D143")]
		[FieldOffset(Offset = "0x8")]
		public UIButton FinishGuideBtn;

		[Token(Token = "0x400D144")]
		[FieldOffset(Offset = "0xC")]
		public UIWidget GuidingWidget;

		[Token(Token = "0x400D145")]
		[FieldOffset(Offset = "0x10")]
		public Side Side;
	}

	[Token(Token = "0x2002152")]
	private sealed class _003CDelayScrollViewResetPosition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D146")]
		[FieldOffset(Offset = "0x8")]
		internal UIScrollView _003Csw_003E__0;

		[Token(Token = "0x400D147")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CextendWidth_003E__0;

		[Token(Token = "0x400D148")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CclipWidth_003E__0;

		[Token(Token = "0x400D149")]
		[FieldOffset(Offset = "0x14")]
		internal UILabNavigationController _0024this;

		[Token(Token = "0x400D14A")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x400D14B")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x400D14C")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x1700101B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AFE5")]
			[Address(RVA = "0x1AE4774", Offset = "0x1AE4774", VA = "0x1AE4774", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700101C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AFE6")]
			[Address(RVA = "0x1AE477C", Offset = "0x1AE477C", VA = "0x1AE477C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AFE3")]
		[Address(RVA = "0x1AE31C0", Offset = "0x1AE31C0", VA = "0x1AE31C0")]
		public _003CDelayScrollViewResetPosition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AFE4")]
		[Address(RVA = "0x1AE44BC", Offset = "0x1AE44BC", VA = "0x1AE44BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AFE7")]
		[Address(RVA = "0x1AE4784", Offset = "0x1AE4784", VA = "0x1AE4784", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AFE8")]
		[Address(RVA = "0x1AE4798", Offset = "0x1AE4798", VA = "0x1AE4798", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D131")]
	private const string OPEN_UI_PLAYER_PREF_KEY = "UILABNAVIGATION_OPENUI";

	[Token(Token = "0x400D132")]
	private const string NAVIGATION_TITLE_KEY = "T_34_XY_LAB_SYS";

	[Token(Token = "0x400D133")]
	private const string NAVIGATION_HELP_TIPS_KEY = "T_34_XY_LAB_HELP";

	[Token(Token = "0x400D134")]
	private const string GUIDE_LENGENDARY_KEY = "T_34_XY_HYPERBOOK_GUIDE6";

	[Token(Token = "0x400D135")]
	private const string GUIDE_HYPERBOOK_KEY1 = "T_34_XY_HYPERBOOK_OPENTIME";

	[Token(Token = "0x400D136")]
	private const string GUIDE_HYPERBOOK_KEY2 = "T_34_XY_HYPERBOOK_OPENDEC";

	[Token(Token = "0x400D137")]
	private const string GUIDE_KEY_STEP1 = "LabGuideLangendary";

	[Token(Token = "0x400D138")]
	private const string GUIDE_KEY_STEP2 = "LabGuideHyperBook";

	[Token(Token = "0x400D139")]
	private const uint LEGEND_CLOTH_SYSTEM_ID = 1u;

	[Token(Token = "0x400D13A")]
	private const uint HYPER_BOOK_SYSTEM_ID = 2u;

	[Token(Token = "0x400D13B")]
	private const float DELAYCALL_GAP = 0.1f;

	[Token(Token = "0x400D13C")]
	[FieldOffset(Offset = "0x68")]
	private UILabNavigationView m_View;

	[Token(Token = "0x400D13D")]
	[FieldOffset(Offset = "0x6C")]
	private Coroutine m_ScrollViewResetPositionCoroutine;

	[Token(Token = "0x400D13E")]
	[FieldOffset(Offset = "0x70")]
	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400D13F")]
	[FieldOffset(Offset = "0x74")]
	private uint m_DelayCallGuide;

	[Token(Token = "0x400D140")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_AccountID;

	[Token(Token = "0x600AFC9")]
	[Address(RVA = "0x1AE11D4", Offset = "0x1AE11D4", VA = "0x1AE11D4")]
	public UILabNavigationController()
	{
	}

	[Token(Token = "0x600AFCA")]
	[Address(RVA = "0x1AE128C", Offset = "0x1AE128C", VA = "0x1AE128C")]
	public static void PushLabNavigation(object[] data)
	{
	}

	[Token(Token = "0x600AFCB")]
	[Address(RVA = "0x1AE17A0", Offset = "0x1AE17A0", VA = "0x1AE17A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AFCC")]
	[Address(RVA = "0x1AE1848", Offset = "0x1AE1848", VA = "0x1AE1848", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AFCD")]
	[Address(RVA = "0x1AE26B0", Offset = "0x1AE26B0", VA = "0x1AE26B0", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600AFCE")]
	[Address(RVA = "0x1AE2884", Offset = "0x1AE2884", VA = "0x1AE2884", Slot = "41")]
	protected override void OnHelpButtonClick(object[] param)
	{
	}

	[Token(Token = "0x600AFCF")]
	[Address(RVA = "0x1AE2AE8", Offset = "0x1AE2AE8", VA = "0x1AE2AE8")]
	private void RefreshLabNavigationEntranceState(uint systemID, GameObject entrance, UILabel footnoteLabel, GameObject openState, GameObject notOpenState)
	{
	}

	[Token(Token = "0x600AFD0")]
	[Address(RVA = "0x1AE304C", Offset = "0x1AE304C", VA = "0x1AE304C")]
	private void RefreshHyperBookTips()
	{
	}

	[Token(Token = "0x600AFD1")]
	[Address(RVA = "0x1AE30A0", Offset = "0x1AE30A0", VA = "0x1AE30A0")]
	private void RefreshLegendClothTips()
	{
	}

	[Token(Token = "0x600AFD2")]
	[Address(RVA = "0x1AE1B90", Offset = "0x1AE1B90", VA = "0x1AE1B90")]
	private void PrepareLabEntrances()
	{
	}

	[Token(Token = "0x600AFD3")]
	[Address(RVA = "0x1AE1DC0", Offset = "0x1AE1DC0", VA = "0x1AE1DC0")]
	private void StartDelayScrollViewResetPosition()
	{
	}

	[Token(Token = "0x600AFD4")]
	[Address(RVA = "0x1AE30F4", Offset = "0x1AE30F4", VA = "0x1AE30F4")]
	private IEnumerator DelayScrollViewResetPosition()
	{
		return null;
	}

	[Token(Token = "0x600AFD5")]
	[Address(RVA = "0x1AE31C8", Offset = "0x1AE31C8", VA = "0x1AE31C8")]
	private void OnBookEntranceBtnClick()
	{
	}

	[Token(Token = "0x600AFD6")]
	[Address(RVA = "0x1AE38DC", Offset = "0x1AE38DC", VA = "0x1AE38DC")]
	private void OnLegendClothEntranceBtnClick()
	{
	}

	[Token(Token = "0x600AFD7")]
	[Address(RVA = "0x1AE19E8", Offset = "0x1AE19E8", VA = "0x1AE19E8")]
	private void AddEventDelegate()
	{
	}

	[Token(Token = "0x600AFD8")]
	[Address(RVA = "0x1AE35BC", Offset = "0x1AE35BC", VA = "0x1AE35BC")]
	private static bool OnEntranceBtnClickCheck(uint systemID)
	{
		return default(bool);
	}

	[Token(Token = "0x600AFD9")]
	[Address(RVA = "0x1AE1E54", Offset = "0x1AE1E54", VA = "0x1AE1E54")]
	private static void WriteOpenUIPlayerPref()
	{
	}

	[Token(Token = "0x600AFDA")]
	[Address(RVA = "0x1AE207C", Offset = "0x1AE207C", VA = "0x1AE207C")]
	private void SetGuideSetting()
	{
	}

	[Token(Token = "0x600AFDB")]
	[Address(RVA = "0x1AE2744", Offset = "0x1AE2744", VA = "0x1AE2744")]
	private void StartGuide()
	{
	}

	[Token(Token = "0x600AFDC")]
	[Address(RVA = "0x1AE3BD8", Offset = "0x1AE3BD8", VA = "0x1AE3BD8")]
	private void DelayCallExcuteGuide()
	{
	}

	[Token(Token = "0x600AFDD")]
	[Address(RVA = "0x1AE3DA4", Offset = "0x1AE3DA4", VA = "0x1AE3DA4")]
	private void ExcuteGuide()
	{
	}

	[Token(Token = "0x600AFDE")]
	[Address(RVA = "0x1AE3FB0", Offset = "0x1AE3FB0", VA = "0x1AE3FB0")]
	private void ExcuteNext()
	{
	}

	[Token(Token = "0x600AFDF")]
	[Address(RVA = "0x1AE4240", Offset = "0x1AE4240", VA = "0x1AE4240")]
	public static ulong ReadOpenUIPlayerPref()
	{
		return default(ulong);
	}

	[Token(Token = "0x600AFE0")]
	[Address(RVA = "0x1AE44A4", Offset = "0x1AE44A4", VA = "0x1AE44A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AFE1")]
	[Address(RVA = "0x1AE44AC", Offset = "0x1AE44AC", VA = "0x1AE44AC")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600AFE2")]
	[Address(RVA = "0x1AE44B4", Offset = "0x1AE44B4", VA = "0x1AE44B4")]
	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
