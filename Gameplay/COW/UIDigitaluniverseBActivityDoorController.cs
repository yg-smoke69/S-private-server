using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EA7")]
internal class UIDigitaluniverseBActivityDoorController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x400C0BF")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBActivityDoorView m_View;

	[Token(Token = "0x400C0C0")]
	[FieldOffset(Offset = "0x74")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C0C1")]
	[FieldOffset(Offset = "0x78")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C0C2")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C0C3")]
	[FieldOffset(Offset = "0x80")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C0C4")]
	[FieldOffset(Offset = "0x84")]
	private bool m_IsMissionClaimBtnClicked;

	[Token(Token = "0x400C0C5")]
	[FieldOffset(Offset = "0x88")]
	private ulong m_AccountID;

	[Token(Token = "0x400C0C6")]
	[FieldOffset(Offset = "0x90")]
	private int m_Index;

	[Token(Token = "0x400C0C7")]
	[FieldOffset(Offset = "0x94")]
	private uint m_DelayCallGuide;

	[Token(Token = "0x400C0C8")]
	[FieldOffset(Offset = "0x98")]
	private uint m_DelayCallShowThirdGuide;

	[Token(Token = "0x400C0C9")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_DelayCallPlayLoop;

	[Token(Token = "0x400C0CA")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_GuideShowDelayCall;

	[Token(Token = "0x400C0CB")]
	[FieldOffset(Offset = "0xA4")]
	private Action m_GuideAction;

	[Token(Token = "0x400C0CC")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_NeedWaitPreviousGuide;

	[Token(Token = "0x400C0CD")]
	[FieldOffset(Offset = "0xA9")]
	private bool m_NeedShowThirdGuide;

	[Token(Token = "0x400C0CE")]
	private const int MISSIONCOUNT = 3;

	[Token(Token = "0x400C0CF")]
	private const int AWARDCOUNT = 7;

	[Token(Token = "0x400C0D0")]
	private const int TABCOUNT = 7;

	[Token(Token = "0x400C0D1")]
	private const int MAX_INDEX_ONEPAGE = 5;

	[Token(Token = "0x400C0D2")]
	private const float FIRST_AWARD_PROGRESS_RATE = 1f / 13f;

	[Token(Token = "0x400C0D3")]
	private const float SHOW_UNLOCK_ANI_TIME_INTERVAL = 1f;

	[Token(Token = "0x400C0D4")]
	private const float GUIDESHOWDELAY = 0.27f;

	[Token(Token = "0x400C0D5")]
	[FieldOffset(Offset = "0xAC")]
	private List<Transform> m_ListAwardItemPos;

	[Token(Token = "0x400C0D6")]
	[FieldOffset(Offset = "0xB0")]
	private readonly List<UIDigitaluniverseBActivityMissionItemController> m_PageMissionCtrlList;

	[Token(Token = "0x400C0D7")]
	[FieldOffset(Offset = "0xB4")]
	private readonly List<UIDigitaluniverseBActivityDoorTabItemController> m_PageTabCtrlList;

	[Token(Token = "0x400C0D8")]
	[FieldOffset(Offset = "0xB8")]
	private readonly List<UIDigitaluniverseBNormalAwardItemController> m_ListNormalAwardItem;

	[Token(Token = "0x400C0D9")]
	[FieldOffset(Offset = "0xBC")]
	private readonly Queue<UIModelDigitaluniverseB.UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400C0DA")]
	[FieldOffset(Offset = "0xC0")]
	private UICommonGuideController m_FisrtGuideCtrl;

	[Token(Token = "0x400C0DB")]
	private const string KEY_MISSION_LOCK_TIME = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYCOND1";

	[Token(Token = "0x400C0DC")]
	private const string KEY_MISSION_LOCK_PRE = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYCOND2";

	[Token(Token = "0x400C0DD")]
	private const string MISSION_LOCK_ICON_NAME = "FF_UI_DigitaluniverseB_06_icon02";

	[Token(Token = "0x400C0DE")]
	private const string MISSION_FINISH_ICON_NAME = "FF_UI_DigitaluniverseB_06_icon01";

	[Token(Token = "0x400C0DF")]
	private const string GUIDE_KEY_STEP1 = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYGUIDE1";

	[Token(Token = "0x400C0E0")]
	private const string GUIDE_KEY_STEP2 = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYGUIDE2";

	[Token(Token = "0x400C0E1")]
	private const string GUIDE_PLAYERPREFS_STEP1 = "ActivityDoor_Guide1";

	[Token(Token = "0x400C0E2")]
	private const string GUIDE_PLAYERPREFS_STEP2 = "ActivityDoor_Guide2";

	[Token(Token = "0x400C0E3")]
	private const string GUIDE_PLAYERPREFS_STEP3 = "ActivityDoor_Guide3";

	[Token(Token = "0x600941B")]
	[Address(RVA = "0x2D90FCC", Offset = "0x2D90FCC", VA = "0x2D90FCC")]
	public UIDigitaluniverseBActivityDoorController()
	{
	}

	[Token(Token = "0x600941C")]
	[Address(RVA = "0x2D910F4", Offset = "0x2D910F4", VA = "0x2D910F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600941D")]
	[Address(RVA = "0x2D9119C", Offset = "0x2D9119C", VA = "0x2D9119C")]
	public static void Push()
	{
	}

	[Token(Token = "0x600941E")]
	[Address(RVA = "0x2D91340", Offset = "0x2D91340", VA = "0x2D91340", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600941F")]
	[Address(RVA = "0x2D92854", Offset = "0x2D92854", VA = "0x2D92854", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009420")]
	[Address(RVA = "0x2D92AE4", Offset = "0x2D92AE4", VA = "0x2D92AE4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6009421")]
	[Address(RVA = "0x2D92E88", Offset = "0x2D92E88", VA = "0x2D92E88", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009422")]
	[Address(RVA = "0x2D92EE0", Offset = "0x2D92EE0", VA = "0x2D92EE0", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009423")]
	[Address(RVA = "0x2D92F38", Offset = "0x2D92F38", VA = "0x2D92F38", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009424")]
	[Address(RVA = "0x2D92F90", Offset = "0x2D92F90", VA = "0x2D92F90")]
	private ELimitedEvent.DigitaluniverseBGateType GetGateType()
	{
		return default(ELimitedEvent.DigitaluniverseBGateType);
	}

	[Token(Token = "0x6009425")]
	[Address(RVA = "0x2D92FE8", Offset = "0x2D92FE8", VA = "0x2D92FE8")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x6009426")]
	[Address(RVA = "0x2D9313C", Offset = "0x2D9313C", VA = "0x2D9313C")]
	private void OnCardClick()
	{
	}

	[Token(Token = "0x6009427")]
	[Address(RVA = "0x2D93E6C", Offset = "0x2D93E6C", VA = "0x2D93E6C")]
	private void OnMaskBtnClick()
	{
	}

	[Token(Token = "0x6009428")]
	[Address(RVA = "0x2D9426C", Offset = "0x2D9426C", VA = "0x2D9426C")]
	private void OnMissionAwardBtnClick(object[] data)
	{
	}

	[Token(Token = "0x6009429")]
	[Address(RVA = "0x2D942D4", Offset = "0x2D942D4", VA = "0x2D942D4")]
	private void OnItemControllerNotify(object[] data)
	{
	}

	[Token(Token = "0x600942A")]
	[Address(RVA = "0x2D94544", Offset = "0x2D94544", VA = "0x2D94544")]
	private void OnMissionAwardClaimed(object[] data)
	{
	}

	[Token(Token = "0x600942B")]
	[Address(RVA = "0x2D94D7C", Offset = "0x2D94D7C", VA = "0x2D94D7C")]
	private void OnMissionAwardBtnClick()
	{
	}

	[Token(Token = "0x600942C")]
	[Address(RVA = "0x2D9232C", Offset = "0x2D9232C", VA = "0x2D9232C")]
	private void SetupDefaultStateOnInit()
	{
	}

	[Token(Token = "0x600942D")]
	[Address(RVA = "0x2D91A64", Offset = "0x2D91A64", VA = "0x2D91A64")]
	private void SetTopRightView()
	{
	}

	[Token(Token = "0x600942E")]
	[Address(RVA = "0x2D9196C", Offset = "0x2D9196C", VA = "0x2D9196C")]
	private void SetTopLeftView()
	{
	}

	[Token(Token = "0x600942F")]
	[Address(RVA = "0x2D91CD8", Offset = "0x2D91CD8", VA = "0x2D91CD8")]
	private void PrepareCtrl()
	{
	}

	[Token(Token = "0x6009430")]
	[Address(RVA = "0x2D92B80", Offset = "0x2D92B80", VA = "0x2D92B80")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009431")]
	[Address(RVA = "0x2D94DD0", Offset = "0x2D94DD0", VA = "0x2D94DD0")]
	private void RefreshTabScrollView()
	{
	}

	[Token(Token = "0x6009432")]
	[Address(RVA = "0x2D951E0", Offset = "0x2D951E0", VA = "0x2D951E0")]
	private void RefreshCard(int index)
	{
	}

	[Token(Token = "0x6009433")]
	[Address(RVA = "0x2D95598", Offset = "0x2D95598", VA = "0x2D95598")]
	private void RefreshMission(int index)
	{
	}

	[Token(Token = "0x6009434")]
	[Address(RVA = "0x2D9393C", Offset = "0x2D9393C", VA = "0x2D9393C")]
	private void RefreshAwardProgress()
	{
	}

	[Token(Token = "0x6009435")]
	[Address(RVA = "0x2D95AA4", Offset = "0x2D95AA4", VA = "0x2D95AA4")]
	private void RefreshPageItemSelectState(int index)
	{
	}

	[Token(Token = "0x6009436")]
	[Address(RVA = "0x2D95C74", Offset = "0x2D95C74", VA = "0x2D95C74")]
	private void OnMissionItemStateChanged()
	{
	}

	[Token(Token = "0x6009437")]
	[Address(RVA = "0x2D93770", Offset = "0x2D93770", VA = "0x2D93770")]
	private void OnTabItemStateChanged()
	{
	}

	[Token(Token = "0x6009438")]
	[Address(RVA = "0x2D944A4", Offset = "0x2D944A4", VA = "0x2D944A4")]
	private void RefreshPageContentByIndex(int index)
	{
	}

	[Token(Token = "0x6009439")]
	[Address(RVA = "0x2D95ED8", Offset = "0x2D95ED8", VA = "0x2D95ED8")]
	private void RefreshMissionTitle(int index)
	{
	}

	[Token(Token = "0x600943A")]
	[Address(RVA = "0x2D96888", Offset = "0x2D96888", VA = "0x2D96888")]
	private void RefreshRedPoint()
	{
	}

	[Token(Token = "0x600943B")]
	[Address(RVA = "0x2D969B4", Offset = "0x2D969B4", VA = "0x2D969B4")]
	private void RefreshTopBtn()
	{
	}

	[Token(Token = "0x600943C")]
	[Address(RVA = "0x2D9667C", Offset = "0x2D9667C", VA = "0x2D9667C")]
	private void RefreshCardTitle(int index)
	{
	}

	[Token(Token = "0x600943D")]
	[Address(RVA = "0x2D96AE8", Offset = "0x2D96AE8", VA = "0x2D96AE8")]
	private void SetGuideSetting()
	{
	}

	[Token(Token = "0x600943E")]
	[Address(RVA = "0x2D970E8", Offset = "0x2D970E8", VA = "0x2D970E8")]
	private void StartGuide()
	{
	}

	[Token(Token = "0x600943F")]
	[Address(RVA = "0x2D97210", Offset = "0x2D97210", VA = "0x2D97210")]
	private void DelayCallExcuteGuide()
	{
	}

	[Token(Token = "0x6009440")]
	[Address(RVA = "0x2D973DC", Offset = "0x2D973DC", VA = "0x2D973DC")]
	private void ExcuteGuide()
	{
	}

	[Token(Token = "0x6009441")]
	[Address(RVA = "0x2D979F0", Offset = "0x2D979F0", VA = "0x2D979F0")]
	private void ExcuteNext()
	{
	}

	[Token(Token = "0x6009442")]
	[Address(RVA = "0x2D98050", Offset = "0x2D98050", VA = "0x2D98050")]
	private void ShowThirdGuide()
	{
	}

	[Token(Token = "0x6009443")]
	[Address(RVA = "0x2D9816C", Offset = "0x2D9816C", VA = "0x2D9816C")]
	public UICommonGuideController GetFirstGuideCtrl()
	{
		return null;
	}

	[Token(Token = "0x6009444")]
	[Address(RVA = "0x2D981C4", Offset = "0x2D981C4", VA = "0x2D981C4")]
	public void SetFirstGuideAction()
	{
	}

	[Token(Token = "0x6009445")]
	[Address(RVA = "0x2D94A18", Offset = "0x2D94A18", VA = "0x2D94A18")]
	private float PlayCardUnlockVFX()
	{
		return default(float);
	}

	[Token(Token = "0x6009446")]
	[Address(RVA = "0x2D92C64", Offset = "0x2D92C64", VA = "0x2D92C64")]
	private void PlayAniIn()
	{
	}

	[Token(Token = "0x6009447")]
	[Address(RVA = "0x2D98294", Offset = "0x2D98294", VA = "0x2D98294")]
	private void SetLightenStatePlayerPref()
	{
	}

	[Token(Token = "0x6009448")]
	[Address(RVA = "0x2D986A8", Offset = "0x2D986A8", VA = "0x2D986A8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009449")]
	[Address(RVA = "0x2D98950", Offset = "0x2D98950", VA = "0x2D98950", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600944A")]
	[Address(RVA = "0x2D98A2C", Offset = "0x2D98A2C", VA = "0x2D98A2C")]
	private void _003CPlayCardUnlockVFX_003Em__0()
	{
	}

	[Token(Token = "0x600944B")]
	[Address(RVA = "0x2D98AC0", Offset = "0x2D98AC0", VA = "0x2D98AC0")]
	private void _003CPlayAniIn_003Em__1()
	{
	}

	[Token(Token = "0x600944C")]
	[Address(RVA = "0x2D98B30", Offset = "0x2D98B30", VA = "0x2D98B30")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600944D")]
	[Address(RVA = "0x2D98B38", Offset = "0x2D98B38", VA = "0x2D98B38")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600944E")]
	[Address(RVA = "0x2D98B40", Offset = "0x2D98B40", VA = "0x2D98B40")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600944F")]
	[Address(RVA = "0x2D98B48", Offset = "0x2D98B48", VA = "0x2D98B48")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6009450")]
	[Address(RVA = "0x2D98B50", Offset = "0x2D98B50", VA = "0x2D98B50")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x6009451")]
	[Address(RVA = "0x2D98B58", Offset = "0x2D98B58", VA = "0x2D98B58")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}
}
