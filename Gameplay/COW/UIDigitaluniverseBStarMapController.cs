using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EFA")]
internal class UIDigitaluniverseBStarMapController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001EFB")]
	private sealed class _003CSetViewData_003Ec__AnonStorey3
	{
		[Token(Token = "0x400C309")]
		[FieldOffset(Offset = "0x8")]
		internal string lastAssistanceTime;

		[Token(Token = "0x6009796")]
		[Address(RVA = "0x2F12D48", Offset = "0x2F12D48", VA = "0x2F12D48")]
		public _003CSetViewData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6009797")]
		[Address(RVA = "0x2F16A9C", Offset = "0x2F16A9C", VA = "0x2F16A9C")]
		internal bool _003C_003Em__0(CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2001EFC")]
	private sealed class _003CPlayEnterAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C30A")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBStarMapController _0024this;

		[Token(Token = "0x400C30B")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C30C")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C30D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F70")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600979A")]
			[Address(RVA = "0x2F160B4", Offset = "0x2F160B4", VA = "0x2F160B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F71")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600979B")]
			[Address(RVA = "0x2F160BC", Offset = "0x2F160BC", VA = "0x2F160BC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009798")]
		[Address(RVA = "0x2F1375C", Offset = "0x2F1375C", VA = "0x2F1375C")]
		public _003CPlayEnterAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009799")]
		[Address(RVA = "0x2F15F70", Offset = "0x2F15F70", VA = "0x2F15F70", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600979C")]
		[Address(RVA = "0x2F160C4", Offset = "0x2F160C4", VA = "0x2F160C4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600979D")]
		[Address(RVA = "0x2F160D8", Offset = "0x2F160D8", VA = "0x2F160D8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EFD")]
	private sealed class _003CPlayTargetCompleteAnim_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C30E")]
		[FieldOffset(Offset = "0x8")]
		internal DigitaluniverseBStarCraftTargetDesc target;

		[Token(Token = "0x400C30F")]
		[FieldOffset(Offset = "0xC")]
		internal CSClaimDigitalUniverseBStarCraftProgressAwardRes award;

		[Token(Token = "0x400C310")]
		[FieldOffset(Offset = "0x10")]
		internal List<BaseItemInfo> _003Citems_003E__0;

		[Token(Token = "0x400C311")]
		[FieldOffset(Offset = "0x14")]
		internal RewardWndCfg _003Ccfg_003E__0;

		[Token(Token = "0x400C312")]
		[FieldOffset(Offset = "0x18")]
		internal UIDigitaluniverseBStarMapController _0024this;

		[Token(Token = "0x400C313")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400C314")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400C315")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x400C316")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x17000F72")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60097A0")]
			[Address(RVA = "0x2F169E8", Offset = "0x2F169E8", VA = "0x2F169E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F73")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60097A1")]
			[Address(RVA = "0x2F169F0", Offset = "0x2F169F0", VA = "0x2F169F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600979E")]
		[Address(RVA = "0x2F1387C", Offset = "0x2F1387C", VA = "0x2F1387C")]
		public _003CPlayTargetCompleteAnim_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600979F")]
		[Address(RVA = "0x2F16160", Offset = "0x2F16160", VA = "0x2F16160", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60097A2")]
		[Address(RVA = "0x2F169F8", Offset = "0x2F169F8", VA = "0x2F169F8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60097A3")]
		[Address(RVA = "0x2F16A0C", Offset = "0x2F16A0C", VA = "0x2F16A0C", Slot = "6")]
		public void Reset()
		{
		}

		[Token(Token = "0x60097A4")]
		[Address(RVA = "0x2F16A94", Offset = "0x2F16A94", VA = "0x2F16A94")]
		private static CommonRewardItemInfo _003C_003Em__0(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2001EFE")]
	private sealed class _003CPlayAssistHistoryNoticeBarrage_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C317")]
		[FieldOffset(Offset = "0x8")]
		internal int _003CnoticeIndex_003E__0;

		[Token(Token = "0x400C318")]
		[FieldOffset(Offset = "0xC")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400C319")]
		[FieldOffset(Offset = "0x10")]
		internal int barrageNum;

		[Token(Token = "0x400C31A")]
		[FieldOffset(Offset = "0x14")]
		internal List<CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo> assistHistory;

		[Token(Token = "0x400C31B")]
		[FieldOffset(Offset = "0x18")]
		internal UIDigitaluniverseBStarMapController _0024this;

		[Token(Token = "0x400C31C")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400C31D")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400C31E")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17000F74")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60097A7")]
			[Address(RVA = "0x2F15EC4", Offset = "0x2F15EC4", VA = "0x2F15EC4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F75")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60097A8")]
			[Address(RVA = "0x2F15ECC", Offset = "0x2F15ECC", VA = "0x2F15ECC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60097A5")]
		[Address(RVA = "0x2F13E00", Offset = "0x2F13E00", VA = "0x2F13E00")]
		public _003CPlayAssistHistoryNoticeBarrage_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x60097A6")]
		[Address(RVA = "0x2F15B54", Offset = "0x2F15B54", VA = "0x2F15B54", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60097A9")]
		[Address(RVA = "0x2F15ED4", Offset = "0x2F15ED4", VA = "0x2F15ED4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60097AA")]
		[Address(RVA = "0x2F15EE8", Offset = "0x2F15EE8", VA = "0x2F15EE8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C2F6")]
	[FieldOffset(Offset = "0x70")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C2F7")]
	[FieldOffset(Offset = "0x74")]
	private UIDigitaluniverseBStarMapView m_View;

	[Token(Token = "0x400C2F8")]
	[FieldOffset(Offset = "0x78")]
	private UIDigitaluniverseBStarMapAssistHistoryController m_AssistHistoryCtrl;

	[Token(Token = "0x400C2F9")]
	[FieldOffset(Offset = "0x7C")]
	private UIDigitaluniverseBGalaxyCanvasController m_GalaxyCanvasCtrl;

	[Token(Token = "0x400C2FA")]
	[FieldOffset(Offset = "0x80")]
	private UIDigitaluniverseBStarMapNewBieGuideController m_GuideController;

	[Token(Token = "0x400C2FB")]
	[FieldOffset(Offset = "0x84")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C2FC")]
	[FieldOffset(Offset = "0x88")]
	private UIDigitaluniverseBStarMapTargetCompleteController m_TargetCompleteCtrl;

	[Token(Token = "0x400C2FD")]
	private const int MAX_ASSIST_NOTICE_NUM = 3;

	[Token(Token = "0x400C2FE")]
	[FieldOffset(Offset = "0x8C")]
	private UIDigitaluniverseBStarMapTargetItemController[] m_TargetItemArray;

	[Token(Token = "0x400C2FF")]
	[FieldOffset(Offset = "0x90")]
	private UIDigitaluniverseBStarMapAssistNoticeController[] m_NoticeItemArray;

	[Token(Token = "0x400C300")]
	[FieldOffset(Offset = "0x94")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400C301")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsEnlarged;

	[Token(Token = "0x400C302")]
	[FieldOffset(Offset = "0xA0")]
	private ulong m_AccountId;

	[Token(Token = "0x400C303")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsFirstEnter;

	[Token(Token = "0x400C304")]
	[FieldOffset(Offset = "0xA9")]
	private bool m_IsFirstEnterHasFriendCache;

	[Token(Token = "0x400C305")]
	[FieldOffset(Offset = "0xAA")]
	private bool m_StarMapEnterAnimationDone;

	[Token(Token = "0x400C306")]
	[FieldOffset(Offset = "0xAB")]
	private bool m_IsInitInfoSuccess;

	[Token(Token = "0x400C307")]
	[FieldOffset(Offset = "0xB0")]
	private ulong m_LastRreshCountDownTime;

	[Token(Token = "0x400C308")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600976E")]
	[Address(RVA = "0x2F10398", Offset = "0x2F10398", VA = "0x2F10398")]
	public UIDigitaluniverseBStarMapController()
	{
	}

	[Token(Token = "0x600976F")]
	[Address(RVA = "0x2F10488", Offset = "0x2F10488", VA = "0x2F10488")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009770")]
	[Address(RVA = "0x2F10530", Offset = "0x2F10530", VA = "0x2F10530", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009771")]
	[Address(RVA = "0x2F1187C", Offset = "0x2F1187C", VA = "0x2F1187C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6009772")]
	[Address(RVA = "0x2F11AE4", Offset = "0x2F11AE4", VA = "0x2F11AE4", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6009773")]
	[Address(RVA = "0x2F11BEC", Offset = "0x2F11BEC", VA = "0x2F11BEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6009774")]
	[Address(RVA = "0x2F1156C", Offset = "0x2F1156C", VA = "0x2F1156C")]
	private void SetTokenNum()
	{
	}

	[Token(Token = "0x6009775")]
	[Address(RVA = "0x2F11C80", Offset = "0x2F11C80", VA = "0x2F11C80", Slot = "42")]
	protected override void OnClickClose()
	{
	}

	[Token(Token = "0x6009776")]
	[Address(RVA = "0x2F12114", Offset = "0x2F12114", VA = "0x2F12114")]
	private void RefreshCountDown()
	{
	}

	[Token(Token = "0x6009777")]
	[Address(RVA = "0x2F12554", Offset = "0x2F12554", VA = "0x2F12554")]
	private void CountDownFinish()
	{
	}

	[Token(Token = "0x6009778")]
	[Address(RVA = "0x2F1286C", Offset = "0x2F1286C", VA = "0x2F1286C")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x6009779")]
	[Address(RVA = "0x2F12E68", Offset = "0x2F12E68", VA = "0x2F12E68")]
	private void RefreshTargetMenu()
	{
	}

	[Token(Token = "0x600977A")]
	[Address(RVA = "0x2F126B0", Offset = "0x2F126B0", VA = "0x2F126B0")]
	private void RefreshAssistPanel()
	{
	}

	[Token(Token = "0x600977B")]
	[Address(RVA = "0x2F11A18", Offset = "0x2F11A18", VA = "0x2F11A18")]
	private IEnumerator PlayEnterAnimation()
	{
		return null;
	}

	[Token(Token = "0x600977C")]
	[Address(RVA = "0x2F13764", Offset = "0x2F13764", VA = "0x2F13764")]
	private IEnumerator PlayTargetCompleteAnim(DigitaluniverseBStarCraftTargetDesc target, CSClaimDigitalUniverseBStarCraftProgressAwardRes award)
	{
		return null;
	}

	[Token(Token = "0x600977D")]
	[Address(RVA = "0x2F13884", Offset = "0x2F13884", VA = "0x2F13884", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600977E")]
	[Address(RVA = "0x2F13C58", Offset = "0x2F13C58", VA = "0x2F13C58", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600977F")]
	[Address(RVA = "0x2F13CC8", Offset = "0x2F13CC8", VA = "0x2F13CC8", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009780")]
	[Address(RVA = "0x2F138F4", Offset = "0x2F138F4", VA = "0x2F138F4")]
	private void HideUIWhenScreenshot(bool isBeforeScreenshot)
	{
	}

	[Token(Token = "0x6009781")]
	[Address(RVA = "0x2F13D20", Offset = "0x2F13D20", VA = "0x2F13D20")]
	private void ShowOrHideAssistHistoryAction(bool isShow)
	{
	}

	[Token(Token = "0x6009782")]
	[Address(RVA = "0x2F11698", Offset = "0x2F11698", VA = "0x2F11698")]
	private void ShowTargetMenu(bool isShow)
	{
	}

	[Token(Token = "0x6009783")]
	[Address(RVA = "0x2F12D50", Offset = "0x2F12D50", VA = "0x2F12D50")]
	private IEnumerator PlayAssistHistoryNoticeBarrage(List<CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo> assistHistory, int barrageNum)
	{
		return null;
	}

	[Token(Token = "0x6009784")]
	[Address(RVA = "0x2F13E08", Offset = "0x2F13E08", VA = "0x2F13E08")]
	public UIWidget GetGuideWdiget()
	{
		return null;
	}

	[Token(Token = "0x6009785")]
	[Address(RVA = "0x2F13F04", Offset = "0x2F13F04", VA = "0x2F13F04")]
	public Transform GetGuideTransform()
	{
		return null;
	}

	[Token(Token = "0x6009786")]
	[Address(RVA = "0x2F14000", Offset = "0x2F14000", VA = "0x2F14000")]
	public void HideUIShowCollider(bool isShow, bool setDrag = true)
	{
	}

	[Token(Token = "0x6009787")]
	[Address(RVA = "0x2F1433C", Offset = "0x2F1433C", VA = "0x2F1433C")]
	private void OnBtnTipsClick()
	{
	}

	[Token(Token = "0x6009788")]
	[Address(RVA = "0x2F14694", Offset = "0x2F14694", VA = "0x2F14694")]
	private void OnBtnTargetClick()
	{
	}

	[Token(Token = "0x6009789")]
	[Address(RVA = "0x2F11CFC", Offset = "0x2F11CFC", VA = "0x2F11CFC")]
	private void OnBtnScaleClick()
	{
	}

	[Token(Token = "0x600978A")]
	[Address(RVA = "0x2F14988", Offset = "0x2F14988", VA = "0x2F14988")]
	private void OnBtnShareClick()
	{
	}

	[Token(Token = "0x600978B")]
	[Address(RVA = "0x2F14CF4", Offset = "0x2F14CF4", VA = "0x2F14CF4")]
	private void OnBtnHistoryClick()
	{
	}

	[Token(Token = "0x600978C")]
	[Address(RVA = "0x2F1501C", Offset = "0x2F1501C", VA = "0x2F1501C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600978D")]
	[Address(RVA = "0x2F150B4", Offset = "0x2F150B4", VA = "0x2F150B4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600978E")]
	[Address(RVA = "0x2F15AC4", Offset = "0x2F15AC4", VA = "0x2F15AC4")]
	private static int _003CSetViewData_003Em__0(CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo a, CSDigitalUniverseBStarCraftInfoRes.AssistanceInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x600978F")]
	[Address(RVA = "0x2F15B1C", Offset = "0x2F15B1C", VA = "0x2F15B1C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009790")]
	[Address(RVA = "0x2F15B24", Offset = "0x2F15B24", VA = "0x2F15B24")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009791")]
	[Address(RVA = "0x2F15B2C", Offset = "0x2F15B2C", VA = "0x2F15B2C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6009792")]
	[Address(RVA = "0x2F15B34", Offset = "0x2F15B34", VA = "0x2F15B34")]
	public void _003C_003EiFixBaseProxy_OnClickClose()
	{
	}

	[Token(Token = "0x6009793")]
	[Address(RVA = "0x2F15B3C", Offset = "0x2F15B3C", VA = "0x2F15B3C")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6009794")]
	[Address(RVA = "0x2F15B44", Offset = "0x2F15B44", VA = "0x2F15B44")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6009795")]
	[Address(RVA = "0x2F15B4C", Offset = "0x2F15B4C", VA = "0x2F15B4C")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}
}
