using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EEA")]
internal class UIDigitaluniverseBRoleDoorController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001EEB")]
	private sealed class _003CRefreshMissionView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C2BF")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetDigitaluniverseBInfoRes info;

		[Token(Token = "0x400C2C0")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBRoleDoorController _0024this;

		[Token(Token = "0x6009705")]
		[Address(RVA = "0x2F0490C", Offset = "0x2F0490C", VA = "0x2F0490C")]
		public _003CRefreshMissionView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009706")]
		[Address(RVA = "0x2F05A98", Offset = "0x2F05A98", VA = "0x2F05A98")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C2A4")]
	private const uint OUTTIMEAWARDID = 1u;

	[Token(Token = "0x400C2A5")]
	private const uint MAXROLECOUNT = 5u;

	[Token(Token = "0x400C2A6")]
	private const uint m_BgWidth = 824u;

	[Token(Token = "0x400C2A7")]
	private const uint m_ScrollWidth = 810u;

	[Token(Token = "0x400C2A8")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBRoleDoorView m_View;

	[Token(Token = "0x400C2A9")]
	[FieldOffset(Offset = "0x74")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C2AA")]
	[FieldOffset(Offset = "0x78")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C2AB")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C2AC")]
	[FieldOffset(Offset = "0x80")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C2AD")]
	[FieldOffset(Offset = "0x84")]
	private List<UIDigitaluniverseBNormalAwardItemController> m_ListNormalAwardItem;

	[Token(Token = "0x400C2AE")]
	[FieldOffset(Offset = "0x88")]
	private List<UIDigitaluniverseBDailyMissionController> m_ListDailMission;

	[Token(Token = "0x400C2AF")]
	[FieldOffset(Offset = "0x8C")]
	private List<UIStandardItemMiniController> m_ListCountDownMissionOnTimeAward;

	[Token(Token = "0x400C2B0")]
	[FieldOffset(Offset = "0x90")]
	private List<UIStandardItemMiniController> m_ListCountDownMissionOutTimeAward;

	[Token(Token = "0x400C2B1")]
	[FieldOffset(Offset = "0x94")]
	private List<SkeletonAnimation> m_ListSpineIdle;

	[Token(Token = "0x400C2B2")]
	private const string EntranceId = "RoleDoor";

	[Token(Token = "0x400C2B3")]
	[FieldOffset(Offset = "0x98")]
	private bool m_DelayRefresh;

	[Token(Token = "0x400C2B4")]
	[FieldOffset(Offset = "0x99")]
	private bool m_ShowVfxApproach;

	[Token(Token = "0x400C2B5")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_MillionCountDownTime;

	[Token(Token = "0x400C2B6")]
	[FieldOffset(Offset = "0xA0")]
	private float m_FirstAwardProgressValue;

	[Token(Token = "0x400C2B7")]
	[FieldOffset(Offset = "0xA4")]
	private List<Transform> m_ListAwardItemPos;

	[Token(Token = "0x400C2B8")]
	[FieldOffset(Offset = "0xA8")]
	private string m_RolePlayAnim;

	[Token(Token = "0x400C2B9")]
	private const string ANIMATION_IDLE = "_Idle";

	[Token(Token = "0x400C2BA")]
	private const string ANIMATION_TALK = "_Talk";

	[Token(Token = "0x400C2BB")]
	[FieldOffset(Offset = "0xAC")]
	private List<string> m_ListRoleName;

	[Token(Token = "0x400C2BC")]
	[FieldOffset(Offset = "0xB0")]
	private UINavigationUtil.UINavigationFrom m_From;

	[Token(Token = "0x400C2BD")]
	[FieldOffset(Offset = "0xB4")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400C2BE")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_OnlyFirstTimeSkipToDialog;

	[Token(Token = "0x60096EB")]
	[Address(RVA = "0x2F002AC", Offset = "0x2F002AC", VA = "0x2F002AC")]
	public UIDigitaluniverseBRoleDoorController()
	{
	}

	[Token(Token = "0x60096EC")]
	[Address(RVA = "0x2F003D8", Offset = "0x2F003D8", VA = "0x2F003D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60096ED")]
	[Address(RVA = "0x2F00480", Offset = "0x2F00480", VA = "0x2F00480", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60096EE")]
	[Address(RVA = "0x2F004D8", Offset = "0x2F004D8", VA = "0x2F004D8", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60096EF")]
	[Address(RVA = "0x2F00530", Offset = "0x2F00530", VA = "0x2F00530", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x60096F0")]
	[Address(RVA = "0x2F00588", Offset = "0x2F00588", VA = "0x2F00588", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60096F1")]
	[Address(RVA = "0x2F00F38", Offset = "0x2F00F38", VA = "0x2F00F38", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60096F2")]
	[Address(RVA = "0x2F0147C", Offset = "0x2F0147C", VA = "0x2F0147C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60096F3")]
	[Address(RVA = "0x2F01CD0", Offset = "0x2F01CD0", VA = "0x2F01CD0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60096F4")]
	[Address(RVA = "0x2F01510", Offset = "0x2F01510", VA = "0x2F01510")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60096F5")]
	[Address(RVA = "0x2F01D34", Offset = "0x2F01D34", VA = "0x2F01D34")]
	private void RefreshMissionView()
	{
	}

	[Token(Token = "0x60096F6")]
	[Address(RVA = "0x2F04914", Offset = "0x2F04914", VA = "0x2F04914")]
	private void ShowVFXApproach()
	{
	}

	[Token(Token = "0x60096F7")]
	[Address(RVA = "0x2F049DC", Offset = "0x2F049DC", VA = "0x2F049DC")]
	private void OnBtnCountDownMissionClick()
	{
	}

	[Token(Token = "0x60096F8")]
	[Address(RVA = "0x2F04B88", Offset = "0x2F04B88", VA = "0x2F04B88")]
	private void OnBtnCliamClick()
	{
	}

	[Token(Token = "0x60096F9")]
	[Address(RVA = "0x2F04D40", Offset = "0x2F04D40", VA = "0x2F04D40")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x60096FA")]
	[Address(RVA = "0x2F04E94", Offset = "0x2F04E94", VA = "0x2F04E94")]
	private void OnClickBtnConcertMode()
	{
	}

	[Token(Token = "0x60096FB")]
	[Address(RVA = "0x2F052C4", Offset = "0x2F052C4", VA = "0x2F052C4")]
	private void showClaimAwardVFX(object[] data)
	{
	}

	[Token(Token = "0x60096FC")]
	[Address(RVA = "0x2F056C8", Offset = "0x2F056C8", VA = "0x2F056C8", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60096FD")]
	[Address(RVA = "0x2F057A4", Offset = "0x2F057A4", VA = "0x2F057A4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60096FE")]
	[Address(RVA = "0x2F05A60", Offset = "0x2F05A60", VA = "0x2F05A60")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60096FF")]
	[Address(RVA = "0x2F05A68", Offset = "0x2F05A68", VA = "0x2F05A68")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009700")]
	[Address(RVA = "0x2F05A70", Offset = "0x2F05A70", VA = "0x2F05A70")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009701")]
	[Address(RVA = "0x2F05A78", Offset = "0x2F05A78", VA = "0x2F05A78")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009702")]
	[Address(RVA = "0x2F05A80", Offset = "0x2F05A80", VA = "0x2F05A80")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009703")]
	[Address(RVA = "0x2F05A88", Offset = "0x2F05A88", VA = "0x2F05A88")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009704")]
	[Address(RVA = "0x2F05A90", Offset = "0x2F05A90", VA = "0x2F05A90")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
