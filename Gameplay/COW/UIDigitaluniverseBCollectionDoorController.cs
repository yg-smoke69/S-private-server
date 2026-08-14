using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001EB2")]
internal class UIDigitaluniverseBCollectionDoorController : UIBigEventNaviPopBaseController, _Attribute
{
	[Token(Token = "0x2001EB3")]
	private sealed class _003CPlayAudioCoroutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C145")]
		[FieldOffset(Offset = "0x8")]
		internal object _0024current;

		[Token(Token = "0x400C146")]
		[FieldOffset(Offset = "0xC")]
		internal bool _0024disposing;

		[Token(Token = "0x400C147")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x17000F3A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60094F4")]
			[Address(RVA = "0x2AD58E8", Offset = "0x2AD58E8", VA = "0x2AD58E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F3B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60094F5")]
			[Address(RVA = "0x2AD58F0", Offset = "0x2AD58F0", VA = "0x2AD58F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60094F2")]
		[Address(RVA = "0x2AD505C", Offset = "0x2AD505C", VA = "0x2AD505C")]
		public _003CPlayAudioCoroutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60094F3")]
		[Address(RVA = "0x2AD56C4", Offset = "0x2AD56C4", VA = "0x2AD56C4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60094F6")]
		[Address(RVA = "0x2AD58F8", Offset = "0x2AD58F8", VA = "0x2AD58F8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60094F7")]
		[Address(RVA = "0x2AD590C", Offset = "0x2AD590C", VA = "0x2AD590C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C11A")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBCollectionDoorView m_View;

	[Token(Token = "0x400C11B")]
	[FieldOffset(Offset = "0x74")]
	private UIModelDigitaluniverseB m_ModelDigitaluniverseB;

	[Token(Token = "0x400C11C")]
	[FieldOffset(Offset = "0x78")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C11D")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C11E")]
	[FieldOffset(Offset = "0x80")]
	private UIDigitaluniverseBTopBtnController m_TopBtnCtrl;

	[Token(Token = "0x400C11F")]
	[FieldOffset(Offset = "0x84")]
	private List<Transform> m_ListAwardItemPos;

	[Token(Token = "0x400C120")]
	[FieldOffset(Offset = "0x88")]
	private readonly List<UIDigitaluniverseBCollectionMissionItemController> m_PageMissionCtrlList;

	[Token(Token = "0x400C121")]
	[FieldOffset(Offset = "0x8C")]
	private readonly List<UIDigitaluniverseBCollectionDoorTabItemController> m_PageTabCtrlList;

	[Token(Token = "0x400C122")]
	[FieldOffset(Offset = "0x90")]
	private readonly List<UIDigitaluniverseBNormalAwardItemController> m_ListNormalAwardItem;

	[Token(Token = "0x400C123")]
	[FieldOffset(Offset = "0x94")]
	private readonly Queue<UIModelDigitaluniverseB.UICommonGuideData> m_GuideDataQueue;

	[Token(Token = "0x400C124")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine m_DelayPlayAudioCoroutine;

	[Token(Token = "0x400C125")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 m_BGTexturePos;

	[Token(Token = "0x400C126")]
	[FieldOffset(Offset = "0xA8")]
	private ulong m_AccountID;

	[Token(Token = "0x400C127")]
	[FieldOffset(Offset = "0xB0")]
	private int m_Index;

	[Token(Token = "0x400C128")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_IsGunDetailShow;

	[Token(Token = "0x400C129")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_DelayCallGuide;

	[Token(Token = "0x400C12A")]
	[FieldOffset(Offset = "0xBC")]
	private uint m_DelayCallFinishUnlockAni;

	[Token(Token = "0x400C12B")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsMissionClaimBtnClicked;

	[Token(Token = "0x400C12C")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_IsUpdateProgress;

	[Token(Token = "0x400C12D")]
	[FieldOffset(Offset = "0xC4")]
	private uint m_GuideShowDelayCall;

	[Token(Token = "0x400C12E")]
	private const int MISSIONCOUNT = 3;

	[Token(Token = "0x400C12F")]
	private const int AWARDCOUNT = 7;

	[Token(Token = "0x400C130")]
	private const int TABCOUNT = 7;

	[Token(Token = "0x400C131")]
	private const int MAX_INDEX_ONEPAGE = 5;

	[Token(Token = "0x400C132")]
	private const float FIRST_AWARD_PROGRESS_RATE = 1f / 13f;

	[Token(Token = "0x400C133")]
	private const int BG_MOVETO_CENTER_OFFSET = 438;

	[Token(Token = "0x400C134")]
	private const float GLASS_BREAK_AUDIO_DELAY = 5.12f;

	[Token(Token = "0x400C135")]
	private const float LIGHT_FLY_AUDIO_DELAY = 1.15f;

	[Token(Token = "0x400C136")]
	private const float GUIDESHOWDELAY = 0.97f;

	[Token(Token = "0x400C137")]
	private const string MISSION_LOCK_ICON_NAME = "FF_UI_DigitaluniverseB_07_LockIcon02";

	[Token(Token = "0x400C138")]
	private const string MISSION_FINISH_ICON_NAME = "FF_UI_DigitaluniverseB_07_ChagneIcon";

	[Token(Token = "0x400C139")]
	private const string KEY_MISSION_LOCK_TIME = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYCOND1";

	[Token(Token = "0x400C13A")]
	private const string KEY_MISSION_LOCK_PRE = "T_35_LQ_DIGITALUNIVERSEB_ACTIVITYCOND2";

	[Token(Token = "0x400C13B")]
	private const string GUIDE_KEY_STEP1 = "T_35_FH_BATTLECAPSULE_GUIDE1";

	[Token(Token = "0x400C13C")]
	private const string GUIDE_KEY_STEP2 = "T_35_FH_BATTLECAPSULE_GUIDE2";

	[Token(Token = "0x400C13D")]
	private const string GUIDE_PLAYERPREFS_STEP1 = "CollectionDoor_Guide1";

	[Token(Token = "0x400C13E")]
	private const string GUIDE_PLAYERPREFS_STEP2 = "CollectionDoor_Guide2";

	[Token(Token = "0x400C13F")]
	private const string REWARD_BYSHOW_SPRITE_NOTCLAIMED = "FF_UI_DigitaluniverseB_02_Task_Box_2_01";

	[Token(Token = "0x400C140")]
	private const string REWARD_BYSHOW_SPRITE_CLAIMED = "FF_UI_DigitaluniverseB_02_Task_Box_1_03";

	[Token(Token = "0x400C141")]
	private const string REWARD_BYSHOW_SPRITE_FINISHED = "FF_UI_DigitaluniverseB_02_Task_Box_2_02";

	[Token(Token = "0x400C142")]
	private const string BIG_REWARD_BYSHOW_SPRITE_NOTCLAIMED = "FF_UI_DigitaluniverseB_02_Task_Box_1_01";

	[Token(Token = "0x400C143")]
	private const string BIG_REWARD_BYSHOW_SPRITE_CLAIMED = "FF_UI_DigitaluniverseB_02_Task_Box_2_03";

	[Token(Token = "0x400C144")]
	private const string BIG_REWARD_BYSHOW_SPRITE_FINISHED = "FF_UI_DigitaluniverseB_02_Task_Box_1_02";

	[Token(Token = "0x60094B7")]
	[Address(RVA = "0x2ACE668", Offset = "0x2ACE668", VA = "0x2ACE668")]
	public UIDigitaluniverseBCollectionDoorController()
	{
	}

	[Token(Token = "0x60094B8")]
	[Address(RVA = "0x2ACE7DC", Offset = "0x2ACE7DC", VA = "0x2ACE7DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60094B9")]
	[Address(RVA = "0x2ACE884", Offset = "0x2ACE884", VA = "0x2ACE884")]
	public static void Push()
	{
	}

	[Token(Token = "0x60094BA")]
	[Address(RVA = "0x2ACEA28", Offset = "0x2ACEA28", VA = "0x2ACEA28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60094BB")]
	[Address(RVA = "0x2AD0484", Offset = "0x2AD0484", VA = "0x2AD0484", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60094BC")]
	[Address(RVA = "0x2AD0740", Offset = "0x2AD0740", VA = "0x2AD0740", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60094BD")]
	[Address(RVA = "0x2AD0AE4", Offset = "0x2AD0AE4", VA = "0x2AD0AE4", Slot = "43")]
	public override ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60094BE")]
	[Address(RVA = "0x2AD0B3C", Offset = "0x2AD0B3C", VA = "0x2AD0B3C", Slot = "45")]
	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x60094BF")]
	[Address(RVA = "0x2AD0B94", Offset = "0x2AD0B94", VA = "0x2AD0B94", Slot = "44")]
	public override EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60094C0")]
	[Address(RVA = "0x2AD0BEC", Offset = "0x2AD0BEC", VA = "0x2AD0BEC")]
	private new void SetCdnTextureView(UINetworkTextureExt cdnTexture, int cndType)
	{
	}

	[Token(Token = "0x60094C1")]
	[Address(RVA = "0x2AD0D80", Offset = "0x2AD0D80", VA = "0x2AD0D80")]
	private ELimitedEvent.DigitaluniverseBGateType GetGateType()
	{
		return default(ELimitedEvent.DigitaluniverseBGateType);
	}

	[Token(Token = "0x60094C2")]
	[Address(RVA = "0x2ACFAB0", Offset = "0x2ACFAB0", VA = "0x2ACFAB0")]
	private void SetupDefaultStateOnInit()
	{
	}

	[Token(Token = "0x60094C3")]
	[Address(RVA = "0x2ACF108", Offset = "0x2ACF108", VA = "0x2ACF108")]
	private void SetTopRightView()
	{
	}

	[Token(Token = "0x60094C4")]
	[Address(RVA = "0x2ACEF9C", Offset = "0x2ACEF9C", VA = "0x2ACEF9C")]
	private void SetTopLeftView()
	{
	}

	[Token(Token = "0x60094C5")]
	[Address(RVA = "0x2ACF37C", Offset = "0x2ACF37C", VA = "0x2ACF37C")]
	private void PrepareCtrl()
	{
	}

	[Token(Token = "0x60094C6")]
	[Address(RVA = "0x2AD0DD8", Offset = "0x2AD0DD8", VA = "0x2AD0DD8")]
	private void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x60094C7")]
	[Address(RVA = "0x2AD0F2C", Offset = "0x2AD0F2C", VA = "0x2AD0F2C")]
	private void OnItemControllerNotify(object[] data)
	{
	}

	[Token(Token = "0x60094C8")]
	[Address(RVA = "0x2AD1124", Offset = "0x2AD1124", VA = "0x2AD1124")]
	private void OnSwitchBtn()
	{
	}

	[Token(Token = "0x60094C9")]
	[Address(RVA = "0x2AD1830", Offset = "0x2AD1830", VA = "0x2AD1830")]
	private void OnShareBtn()
	{
	}

	[Token(Token = "0x60094CA")]
	[Address(RVA = "0x2AD1B54", Offset = "0x2AD1B54", VA = "0x2AD1B54")]
	private void OnUnlockAniShow(object[] data)
	{
	}

	[Token(Token = "0x60094CB")]
	[Address(RVA = "0x2AD1F48", Offset = "0x2AD1F48", VA = "0x2AD1F48")]
	private void OnMissionAwardBtnClick(object[] data)
	{
	}

	[Token(Token = "0x60094CC")]
	[Address(RVA = "0x2AD07DC", Offset = "0x2AD07DC", VA = "0x2AD07DC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60094CD")]
	[Address(RVA = "0x2AD107C", Offset = "0x2AD107C", VA = "0x2AD107C")]
	private void RefreshPageContentByIndex(int index)
	{
	}

	[Token(Token = "0x60094CE")]
	[Address(RVA = "0x2AD1FB0", Offset = "0x2AD1FB0", VA = "0x2AD1FB0")]
	private void RefreshTabScrollView()
	{
	}

	[Token(Token = "0x60094CF")]
	[Address(RVA = "0x2AD221C", Offset = "0x2AD221C", VA = "0x2AD221C")]
	private void RefreshAwardProgress()
	{
	}

	[Token(Token = "0x60094D0")]
	[Address(RVA = "0x2AD274C", Offset = "0x2AD274C", VA = "0x2AD274C")]
	private void RefreshMission(int index)
	{
	}

	[Token(Token = "0x60094D1")]
	[Address(RVA = "0x2AD3974", Offset = "0x2AD3974", VA = "0x2AD3974")]
	private void OnMissionItemStateChanged()
	{
	}

	[Token(Token = "0x60094D2")]
	[Address(RVA = "0x2AD3A68", Offset = "0x2AD3A68", VA = "0x2AD3A68")]
	private void OnTabItemStateChanged()
	{
	}

	[Token(Token = "0x60094D3")]
	[Address(RVA = "0x2AD2AE0", Offset = "0x2AD2AE0", VA = "0x2AD2AE0")]
	private void RefreshPageItemSelectState(int index)
	{
	}

	[Token(Token = "0x60094D4")]
	[Address(RVA = "0x2AD2CB0", Offset = "0x2AD2CB0", VA = "0x2AD2CB0")]
	private void RefreshMissionTitle(int index)
	{
	}

	[Token(Token = "0x60094D5")]
	[Address(RVA = "0x2AD336C", Offset = "0x2AD336C", VA = "0x2AD336C")]
	private void RefreshRewardByShow(int index)
	{
	}

	[Token(Token = "0x60094D6")]
	[Address(RVA = "0x2AD1390", Offset = "0x2AD1390", VA = "0x2AD1390")]
	private void RefreshGunDetailData()
	{
	}

	[Token(Token = "0x60094D7")]
	[Address(RVA = "0x2AD3C34", Offset = "0x2AD3C34", VA = "0x2AD3C34")]
	private void RefreshRedPoint()
	{
	}

	[Token(Token = "0x60094D8")]
	[Address(RVA = "0x2AD37F8", Offset = "0x2AD37F8", VA = "0x2AD37F8")]
	private void RefreshCDN(int index)
	{
	}

	[Token(Token = "0x60094D9")]
	[Address(RVA = "0x2AD3D60", Offset = "0x2AD3D60", VA = "0x2AD3D60")]
	private void RefreshTopBtn()
	{
	}

	[Token(Token = "0x60094DA")]
	[Address(RVA = "0x2AD3E94", Offset = "0x2AD3E94", VA = "0x2AD3E94", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x60094DB")]
	[Address(RVA = "0x2AD4404", Offset = "0x2AD4404", VA = "0x2AD4404", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x60094DC")]
	[Address(RVA = "0x2AD45A0", Offset = "0x2AD45A0", VA = "0x2AD45A0", Slot = "28")]
	public override void AfterSharePreview()
	{
	}

	[Token(Token = "0x60094DD")]
	[Address(RVA = "0x2ACFED4", Offset = "0x2ACFED4", VA = "0x2ACFED4")]
	private void SetGuideSetting()
	{
	}

	[Token(Token = "0x60094DE")]
	[Address(RVA = "0x2AD4728", Offset = "0x2AD4728", VA = "0x2AD4728")]
	private void StartGuide()
	{
	}

	[Token(Token = "0x60094DF")]
	[Address(RVA = "0x2AD4868", Offset = "0x2AD4868", VA = "0x2AD4868")]
	private void DelayCallExcuteGuide()
	{
	}

	[Token(Token = "0x60094E0")]
	[Address(RVA = "0x2AD4A34", Offset = "0x2AD4A34", VA = "0x2AD4A34")]
	private void ExcuteGuide()
	{
	}

	[Token(Token = "0x60094E1")]
	[Address(RVA = "0x2AD4CB8", Offset = "0x2AD4CB8", VA = "0x2AD4CB8")]
	private void ExcuteNext()
	{
	}

	[Token(Token = "0x60094E2")]
	[Address(RVA = "0x2AD08C0", Offset = "0x2AD08C0", VA = "0x2AD08C0")]
	private void PlayAniIn()
	{
	}

	[Token(Token = "0x60094E3")]
	[Address(RVA = "0x2AD1EB4", Offset = "0x2AD1EB4", VA = "0x2AD1EB4")]
	private void DelayPlayAudio()
	{
	}

	[Token(Token = "0x60094E4")]
	[Address(RVA = "0x2AD4FA4", Offset = "0x2AD4FA4", VA = "0x2AD4FA4")]
	private IEnumerator PlayAudioCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60094E5")]
	[Address(RVA = "0x2AD5064", Offset = "0x2AD5064", VA = "0x2AD5064", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60094E6")]
	[Address(RVA = "0x2AD5400", Offset = "0x2AD5400", VA = "0x2AD5400", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60094E7")]
	[Address(RVA = "0x2AD54E0", Offset = "0x2AD54E0", VA = "0x2AD54E0")]
	private void _003COnUnlockAniShow_003Em__0()
	{
	}

	[Token(Token = "0x60094E8")]
	[Address(RVA = "0x2AD560C", Offset = "0x2AD560C", VA = "0x2AD560C")]
	private void _003CPlayAniIn_003Em__1()
	{
	}

	[Token(Token = "0x60094E9")]
	[Address(RVA = "0x2AD567C", Offset = "0x2AD567C", VA = "0x2AD567C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60094EA")]
	[Address(RVA = "0x2AD5684", Offset = "0x2AD5684", VA = "0x2AD5684")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x60094EB")]
	[Address(RVA = "0x2AD568C", Offset = "0x2AD568C", VA = "0x2AD568C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60094EC")]
	[Address(RVA = "0x2AD5694", Offset = "0x2AD5694", VA = "0x2AD5694")]
	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60094ED")]
	[Address(RVA = "0x2AD569C", Offset = "0x2AD569C", VA = "0x2AD569C")]
	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return default(UIModelBigEvent.EBigEventEntranceID);
	}

	[Token(Token = "0x60094EE")]
	[Address(RVA = "0x2AD56A4", Offset = "0x2AD56A4", VA = "0x2AD56A4")]
	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x60094EF")]
	[Address(RVA = "0x2AD56AC", Offset = "0x2AD56AC", VA = "0x2AD56AC")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x60094F0")]
	[Address(RVA = "0x2AD56B4", Offset = "0x2AD56B4", VA = "0x2AD56B4")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x60094F1")]
	[Address(RVA = "0x2AD56BC", Offset = "0x2AD56BC", VA = "0x2AD56BC")]
	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}
}
