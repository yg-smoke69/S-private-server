using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EAE")]
internal class UIDigitaluniverseBClothesDoorController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001EAF")]
	private sealed class _003CPlayAniIn_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C116")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x400C117")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBClothesDoorController _0024this;

		[Token(Token = "0x60094A2")]
		[Address(RVA = "0x2ACAFAC", Offset = "0x2ACAFAC", VA = "0x2ACAFAC")]
		public _003CPlayAniIn_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60094A3")]
		[Address(RVA = "0x2ACCEA4", Offset = "0x2ACCEA4", VA = "0x2ACCEA4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C0F0")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBClothesDoorView m_View;

	[Token(Token = "0x400C0F1")]
	[FieldOffset(Offset = "0x74")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C0F2")]
	[FieldOffset(Offset = "0x78")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C0F3")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C0F4")]
	[FieldOffset(Offset = "0x80")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C0F5")]
	[FieldOffset(Offset = "0x84")]
	private Action m_GuideAction;

	[Token(Token = "0x400C0F6")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<UIDigitaluniverseBClothesMissionItemController> m_PageMissionCtrlList;

	[Token(Token = "0x400C0F7")]
	[FieldOffset(Offset = "0x8C")]
	private readonly List<UIDigitaluniverseBClothesDoorTabItemController> m_PageTabCtrlList;

	[Token(Token = "0x400C0F8")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<UIDigitaluniverseBNormalAwardItemController> m_ListNormalAwardItem;

	[Token(Token = "0x400C0F9")]
	[FieldOffset(Offset = "0x94")]
	private readonly Queue<UIModelDigitaluniverseB.UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400C0FA")]
	[FieldOffset(Offset = "0x98")]
	private UIModelDigitaluniverseB.UICommonGuideData m_ThirdGuideDate;

	[Token(Token = "0x400C0FB")]
	[FieldOffset(Offset = "0x9C")]
	private UICommonGuideController m_FisrtGuideCtrl;

	[Token(Token = "0x400C0FC")]
	[FieldOffset(Offset = "0xA0")]
	private int m_Index;

	[Token(Token = "0x400C0FD")]
	[FieldOffset(Offset = "0xA8")]
	private ulong m_AccountID;

	[Token(Token = "0x400C0FE")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_IsMissionClaimBtnClicked;

	[Token(Token = "0x400C0FF")]
	[FieldOffset(Offset = "0xB1")]
	private bool m_IsGunDetailShow;

	[Token(Token = "0x400C100")]
	[FieldOffset(Offset = "0xB2")]
	private bool m_PalyInAni;

	[Token(Token = "0x400C101")]
	[FieldOffset(Offset = "0xB4")]
	private uint m_DelayCallGuide;

	[Token(Token = "0x400C102")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_DelayCallShowUnlock;

	[Token(Token = "0x400C103")]
	[FieldOffset(Offset = "0xBC")]
	private uint m_GuideShowDelayCall;

	[Token(Token = "0x400C104")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<uint> m_BundleItemDelayCallList;

	[Token(Token = "0x400C105")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_IsUpdateProgress;

	[Token(Token = "0x400C106")]
	private const int MISSIONCOUNT = 3;

	[Token(Token = "0x400C107")]
	private const int TABCOUNT = 5;

	[Token(Token = "0x400C108")]
	private const float UNLOCKTIMEGAP = 0.7f;

	[Token(Token = "0x400C109")]
	private const float TABITEMGAP = 0.1f;

	[Token(Token = "0x400C10A")]
	private const float GUIDESHOWDELAY = 1f;

	[Token(Token = "0x400C10B")]
	private const float FIRSTITEMSHOWDELAY = 0.4f;

	[Token(Token = "0x400C10C")]
	private const string MISSION_LOCK_ICON_NAME = "FF_UI_DigitaluniverseB_07_LockIcon02";

	[Token(Token = "0x400C10D")]
	private const string MISSION_FINISH_ICON_NAME = "FF_UI_DigitaluniverseB_07_ChagneIcon";

	[Token(Token = "0x400C10E")]
	private const string KEY_MISSION_LOCK_TIME = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYCOND1";

	[Token(Token = "0x400C10F")]
	private const string KEY_MISSION_LOCK_PRE = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYCOND2";

	[Token(Token = "0x400C110")]
	private const string GUIDE_KEY_STEP1 = "T_35_FH_STYLECAPSULE_GUIDE1";

	[Token(Token = "0x400C111")]
	private const string GUIDE_KEY_STEP2 = "T_35_FH_STYLECAPSULE_GUIDE2";

	[Token(Token = "0x400C112")]
	private const string GUIDE_KEY_STEP3 = "T_35_FH_STYLECAPSULE_GUIDE3";

	[Token(Token = "0x400C113")]
	private const string GUIDE_PLAYERPREFS_STEP1 = "ClothesDoor_Guide1";

	[Token(Token = "0x400C114")]
	private const string GUIDE_PLAYERPREFS_STEP2 = "ClothesDoor_Guide2";

	[Token(Token = "0x400C115")]
	private const string GUIDE_PLAYERPREFS_STEP3 = "ClothesDoor_Guide3";

	[Token(Token = "0x6009467")]
	[Address(RVA = "0x2AC54CC", Offset = "0x2AC54CC", VA = "0x2AC54CC")]
	public UIDigitaluniverseBClothesDoorController()
	{
	}

	[Token(Token = "0x6009468")]
	[Address(RVA = "0x2AC5628", Offset = "0x2AC5628", VA = "0x2AC5628")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009469")]
	[Address(RVA = "0x2AC56D0", Offset = "0x2AC56D0", VA = "0x2AC56D0")]
	public static void Push()
	{
	}

	[Token(Token = "0x600946A")]
	[Address(RVA = "0x2AC5874", Offset = "0x2AC5874", VA = "0x2AC5874", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600946B")]
	[Address(RVA = "0x2AC6888", Offset = "0x2AC6888", VA = "0x2AC6888", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600946C")]
	[Address(RVA = "0x2AC6C38", Offset = "0x2AC6C38", VA = "0x2AC6C38", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600946D")]
	[Address(RVA = "0x2AC72D8", Offset = "0x2AC72D8", VA = "0x2AC72D8", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600946E")]
	[Address(RVA = "0x2AC7330", Offset = "0x2AC7330", VA = "0x2AC7330", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x600946F")]
	[Address(RVA = "0x2AC7388", Offset = "0x2AC7388", VA = "0x2AC7388", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6009470")]
	[Address(RVA = "0x2AC73E0", Offset = "0x2AC73E0", VA = "0x2AC73E0")]
	private ELimitedEvent.DigitaluniverseBGateType GetGateType()
	{
		return default(ELimitedEvent.DigitaluniverseBGateType);
	}

	[Token(Token = "0x6009471")]
	[Address(RVA = "0x2AC7438", Offset = "0x2AC7438", VA = "0x2AC7438")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x6009472")]
	[Address(RVA = "0x2AC758C", Offset = "0x2AC758C", VA = "0x2AC758C")]
	private void OnShareBtn()
	{
	}

	[Token(Token = "0x6009473")]
	[Address(RVA = "0x2AC7808", Offset = "0x2AC7808", VA = "0x2AC7808")]
	private void OnUnlockMaskShow(object[] data)
	{
	}

	[Token(Token = "0x6009474")]
	[Address(RVA = "0x2AC7BA0", Offset = "0x2AC7BA0", VA = "0x2AC7BA0")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x6009475")]
	[Address(RVA = "0x2AC7D48", Offset = "0x2AC7D48", VA = "0x2AC7D48")]
	private void OnItemControllerNotify(object[] data)
	{
	}

	[Token(Token = "0x6009476")]
	[Address(RVA = "0x2AC8344", Offset = "0x2AC8344", VA = "0x2AC8344")]
	private void OnMissionAwardBtnClick(object[] data)
	{
	}

	[Token(Token = "0x6009477")]
	[Address(RVA = "0x2AC5EFC", Offset = "0x2AC5EFC", VA = "0x2AC5EFC")]
	private void SetTopRightView()
	{
	}

	[Token(Token = "0x6009478")]
	[Address(RVA = "0x2AC5D8C", Offset = "0x2AC5D8C", VA = "0x2AC5D8C")]
	private void SetTopLeftView()
	{
	}

	[Token(Token = "0x6009479")]
	[Address(RVA = "0x2AC6190", Offset = "0x2AC6190", VA = "0x2AC6190")]
	private void PrepareCtrl()
	{
	}

	[Token(Token = "0x600947A")]
	[Address(RVA = "0x2AC65E0", Offset = "0x2AC65E0", VA = "0x2AC65E0")]
	private void SetupDefaultStateOnInit()
	{
	}

	[Token(Token = "0x600947B")]
	[Address(RVA = "0x2AC8630", Offset = "0x2AC8630", VA = "0x2AC8630", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600947C")]
	[Address(RVA = "0x2AC8750", Offset = "0x2AC8750", VA = "0x2AC8750", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600947D")]
	[Address(RVA = "0x2AC8870", Offset = "0x2AC8870", VA = "0x2AC8870", Slot = "28")]
	public override void AfterSharePreview()
	{
	}

	[Token(Token = "0x600947E")]
	[Address(RVA = "0x2AC6CD4", Offset = "0x2AC6CD4", VA = "0x2AC6CD4")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600947F")]
	[Address(RVA = "0x2AC89F8", Offset = "0x2AC89F8", VA = "0x2AC89F8")]
	private void RefreshTabScrollView()
	{
	}

	[Token(Token = "0x6009480")]
	[Address(RVA = "0x2AC7EA4", Offset = "0x2AC7EA4", VA = "0x2AC7EA4")]
	private void RefreshPageContentByIndex(int index)
	{
	}

	[Token(Token = "0x6009481")]
	[Address(RVA = "0x2AC9378", Offset = "0x2AC9378", VA = "0x2AC9378")]
	private void RefreshMission(int index)
	{
	}

	[Token(Token = "0x6009482")]
	[Address(RVA = "0x2AC970C", Offset = "0x2AC970C", VA = "0x2AC970C")]
	private void RefreshPageItemSelectState(int index)
	{
	}

	[Token(Token = "0x6009483")]
	[Address(RVA = "0x2AC98DC", Offset = "0x2AC98DC", VA = "0x2AC98DC")]
	private void RefreshMissionTitle(int index)
	{
	}

	[Token(Token = "0x6009484")]
	[Address(RVA = "0x2AC8E94", Offset = "0x2AC8E94", VA = "0x2AC8E94")]
	private void RefreshAwardState()
	{
	}

	[Token(Token = "0x6009485")]
	[Address(RVA = "0x2AC9F98", Offset = "0x2AC9F98", VA = "0x2AC9F98")]
	private void OnMissionItemStateChanged()
	{
	}

	[Token(Token = "0x6009486")]
	[Address(RVA = "0x2ACA08C", Offset = "0x2ACA08C", VA = "0x2ACA08C")]
	private void OnTabItemStateChanged()
	{
	}

	[Token(Token = "0x6009487")]
	[Address(RVA = "0x2AC9140", Offset = "0x2AC9140", VA = "0x2AC9140")]
	public void RefreshShareBubble()
	{
	}

	[Token(Token = "0x6009488")]
	[Address(RVA = "0x2ACA258", Offset = "0x2ACA258", VA = "0x2ACA258")]
	private void RefreshRedPoint()
	{
	}

	[Token(Token = "0x6009489")]
	[Address(RVA = "0x2ACA384", Offset = "0x2ACA384", VA = "0x2ACA384")]
	private void RefreshTopBtn()
	{
	}

	[Token(Token = "0x600948A")]
	[Address(RVA = "0x2ACA4B8", Offset = "0x2ACA4B8", VA = "0x2ACA4B8")]
	private void RefreshShareCon()
	{
	}

	[Token(Token = "0x600948B")]
	[Address(RVA = "0x2AC6D84", Offset = "0x2AC6D84", VA = "0x2AC6D84")]
	private void PlayAniIn()
	{
	}

	[Token(Token = "0x600948C")]
	[Address(RVA = "0x2ACAFB4", Offset = "0x2ACAFB4", VA = "0x2ACAFB4")]
	private void SetGuideSetting()
	{
	}

	[Token(Token = "0x600948D")]
	[Address(RVA = "0x2ACB864", Offset = "0x2ACB864", VA = "0x2ACB864")]
	private void StartGuide()
	{
	}

	[Token(Token = "0x600948E")]
	[Address(RVA = "0x2ACB9A4", Offset = "0x2ACB9A4", VA = "0x2ACB9A4")]
	private void DelayCallExcuteGuide()
	{
	}

	[Token(Token = "0x600948F")]
	[Address(RVA = "0x2ACBB70", Offset = "0x2ACBB70", VA = "0x2ACBB70")]
	private void ExcuteGuide()
	{
	}

	[Token(Token = "0x6009490")]
	[Address(RVA = "0x2ACC1A8", Offset = "0x2ACC1A8", VA = "0x2ACC1A8")]
	private void ExcuteNext()
	{
	}

	[Token(Token = "0x6009491")]
	[Address(RVA = "0x2AC7F2C", Offset = "0x2AC7F2C", VA = "0x2AC7F2C")]
	private void ShowGuide3(int index)
	{
	}

	[Token(Token = "0x6009492")]
	[Address(RVA = "0x2ACC5D4", Offset = "0x2ACC5D4", VA = "0x2ACC5D4")]
	public UICommonGuideController GetFirstGuideCtrl()
	{
		return null;
	}

	[Token(Token = "0x6009493")]
	[Address(RVA = "0x2ACC62C", Offset = "0x2ACC62C", VA = "0x2ACC62C")]
	public void SetFirstGuideAction()
	{
	}

	[Token(Token = "0x6009494")]
	[Address(RVA = "0x2ACC6FC", Offset = "0x2ACC6FC", VA = "0x2ACC6FC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009495")]
	[Address(RVA = "0x2ACCA44", Offset = "0x2ACCA44", VA = "0x2ACCA44", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009496")]
	[Address(RVA = "0x2ACCB24", Offset = "0x2ACCB24", VA = "0x2ACCB24")]
	private void _003COnMaskClick_003Em__0()
	{
	}

	[Token(Token = "0x6009497")]
	[Address(RVA = "0x2ACCD88", Offset = "0x2ACCD88", VA = "0x2ACCD88")]
	private void _003CPlayAniIn_003Em__1()
	{
	}

	[Token(Token = "0x6009498")]
	[Address(RVA = "0x2ACCDF8", Offset = "0x2ACCDF8", VA = "0x2ACCDF8")]
	private void _003CShowGuide3_003Em__2()
	{
	}

	[Token(Token = "0x6009499")]
	[Address(RVA = "0x2ACCE5C", Offset = "0x2ACCE5C", VA = "0x2ACCE5C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600949A")]
	[Address(RVA = "0x2ACCE64", Offset = "0x2ACCE64", VA = "0x2ACCE64")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600949B")]
	[Address(RVA = "0x2ACCE6C", Offset = "0x2ACCE6C", VA = "0x2ACCE6C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600949C")]
	[Address(RVA = "0x2ACCE74", Offset = "0x2ACCE74", VA = "0x2ACCE74")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x600949D")]
	[Address(RVA = "0x2ACCE7C", Offset = "0x2ACCE7C", VA = "0x2ACCE7C")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x600949E")]
	[Address(RVA = "0x2ACCE84", Offset = "0x2ACCE84", VA = "0x2ACCE84")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x600949F")]
	[Address(RVA = "0x2ACCE8C", Offset = "0x2ACCE8C", VA = "0x2ACCE8C")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x60094A0")]
	[Address(RVA = "0x2ACCE94", Offset = "0x2ACCE94", VA = "0x2ACCE94")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x60094A1")]
	[Address(RVA = "0x2ACCE9C", Offset = "0x2ACCE9C", VA = "0x2ACCE9C")]
	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}
}
