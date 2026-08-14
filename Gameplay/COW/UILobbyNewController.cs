using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200292E")]
public class UILobbyNewController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x200292F")]
	private sealed class _003COnPetShowActionClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FDD9")]
		[FieldOffset(Offset = "0x8")]
		internal PetActionData data;

		[Token(Token = "0x6010653")]
		[Address(RVA = "0x1F8C500", Offset = "0x1F8C500", VA = "0x1F8C500")]
		public _003COnPetShowActionClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010654")]
		[Address(RVA = "0x1F8C508", Offset = "0x1F8C508", VA = "0x1F8C508")]
		internal bool _003C_003Em__0(PetActionInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002930")]
	private sealed class _003CCoroutineScrollingBgCamera_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400FDDA")]
		[FieldOffset(Offset = "0x8")]
		internal Camera _003Ccam_003E__0;

		[Token(Token = "0x400FDDB")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CcurrentSize_003E__0;

		[Token(Token = "0x400FDDC")]
		[FieldOffset(Offset = "0x10")]
		internal float needSize;

		[Token(Token = "0x400FDDD")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CplusMinus_003E__1;

		[Token(Token = "0x400FDDE")]
		[FieldOffset(Offset = "0x18")]
		internal UILobbyNewController _0024this;

		[Token(Token = "0x400FDDF")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x400FDE0")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x400FDE1")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x1700121D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010657")]
			[Address(RVA = "0x1F8C454", Offset = "0x1F8C454", VA = "0x1F8C454", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700121E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010658")]
			[Address(RVA = "0x1F8C45C", Offset = "0x1F8C45C", VA = "0x1F8C45C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010655")]
		[Address(RVA = "0x1F8C068", Offset = "0x1F8C068", VA = "0x1F8C068")]
		public _003CCoroutineScrollingBgCamera_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010656")]
		[Address(RVA = "0x1F8C070", Offset = "0x1F8C070", VA = "0x1F8C070", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010659")]
		[Address(RVA = "0x1F8C464", Offset = "0x1F8C464", VA = "0x1F8C464", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601065A")]
		[Address(RVA = "0x1F8C478", Offset = "0x1F8C478", VA = "0x1F8C478", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002931")]
	private sealed class _003CStartCertainMode_003Ec__AnonStorey2
	{
		[Token(Token = "0x400FDE2")]
		[FieldOffset(Offset = "0x8")]
		internal uint mode;

		[Token(Token = "0x601065B")]
		[Address(RVA = "0x1F8C554", Offset = "0x1F8C554", VA = "0x1F8C554")]
		public _003CStartCertainMode_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601065C")]
		[Address(RVA = "0x1F8C55C", Offset = "0x1F8C55C", VA = "0x1F8C55C")]
		internal bool _003C_003Em__0(MapModeData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FD98")]
	[FieldOffset(Offset = "0x68")]
	private UILobbyViewExt2 m_View;

	[Token(Token = "0x400FD99")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelGroup m_ModelGroup;

	[Token(Token = "0x400FD9A")]
	[FieldOffset(Offset = "0x70")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400FD9B")]
	[FieldOffset(Offset = "0x74")]
	private UIModelCustomRoom m_ModelCustomRoom;

	[Token(Token = "0x400FD9C")]
	[FieldOffset(Offset = "0x78")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400FD9D")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelNewVault m_ModelNewVault;

	[Token(Token = "0x400FD9E")]
	[FieldOffset(Offset = "0x80")]
	private UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	[Token(Token = "0x400FD9F")]
	[FieldOffset(Offset = "0x84")]
	private UIHudPetAnimLobbyController m_petAnimCtrl;

	[Token(Token = "0x400FDA0")]
	[FieldOffset(Offset = "0x88")]
	private UILobbyAdsController m_LobbyAdCtrl;

	[Token(Token = "0x400FDA1")]
	[FieldOffset(Offset = "0x8C")]
	private UICountDownController m_PaymentCountCtrl;

	[Token(Token = "0x400FDA2")]
	[FieldOffset(Offset = "0x90")]
	private UILobbyNewEventController m_EventController;

	[Token(Token = "0x400FDA3")]
	[FieldOffset(Offset = "0x94")]
	private UILobbyIAPBundleController m_LobbyIAPBundleController;

	[Token(Token = "0x400FDA4")]
	[FieldOffset(Offset = "0x98")]
	private UILobbyNewLeftBtnGroupController m_LeftBtnGroupController;

	[Token(Token = "0x400FDA5")]
	[FieldOffset(Offset = "0x9C")]
	private UILobbyNewRightBtnPanelController m_RightBtnPanelController;

	[Token(Token = "0x400FDA6")]
	[FieldOffset(Offset = "0xA0")]
	public UILobbyNewRightBottomController m_RightBottomController;

	[Token(Token = "0x400FDA7")]
	[FieldOffset(Offset = "0xA4")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400FDA8")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<GameObject, bool[]> m_ButtonGroupSetting;

	[Token(Token = "0x400FDA9")]
	[FieldOffset(Offset = "0x0")]
	private static List<string> UI3DOBJECT_NAMES;

	[Token(Token = "0x400FDAA")]
	private const string GAME_GUIDE_TIPS = "GAME_GUIDE_TIPS";

	[Token(Token = "0x400FDAB")]
	private const string MANUAL_TIPS = "MANUAL_TIPS";

	[Token(Token = "0x400FDAC")]
	public const string PET_ACTION_GUIDE = "PET_ACTION_GUIDE";

	[Token(Token = "0x400FDAD")]
	public const string AVATAR_EMOTESHOW_GUIDE = "AVATAR_EMOTESHOW_GUIDE";

	[Token(Token = "0x400FDAE")]
	public const string RANK_UNLOCK_TIPS = "rank_unlock_tips";

	[Token(Token = "0x400FDAF")]
	public const string EP_PREORDER_TIPS = "EP_PREORDER_TIPS";

	[Token(Token = "0x400FDB0")]
	[FieldOffset(Offset = "0xAC")]
	private uint m_LobbyLabGuideDelayCall;

	[Token(Token = "0x400FDB1")]
	[FieldOffset(Offset = "0xB0")]
	public uint UserRegisteOnMax;

	[Token(Token = "0x400FDB2")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_ClearBackpack;

	[Token(Token = "0x400FDB3")]
	[FieldOffset(Offset = "0xB8")]
	private UIElitePassLobbyIconController m_EPIconController;

	[Token(Token = "0x400FDB4")]
	[FieldOffset(Offset = "0xBC")]
	private UIEPTaskEntryController m_EPTaskEntry;

	[Token(Token = "0x400FDB5")]
	[FieldOffset(Offset = "0xC0")]
	private UIModelElitePass m_ModelEP;

	[Token(Token = "0x400FDB6")]
	[FieldOffset(Offset = "0xC4")]
	private UIEmoteShowPanelController m_EmotePanelController;

	[Token(Token = "0x400FDB7")]
	public const string SECOND_RECHARGE = "SecondRecharge";

	[Token(Token = "0x400FDB8")]
	[FieldOffset(Offset = "0xC8")]
	private UICommonGuideController m_CommonGuideCtrl;

	[Token(Token = "0x400FDB9")]
	[FieldOffset(Offset = "0xCC")]
	private uint m_DelayCallGuideId;

	[Token(Token = "0x400FDBA")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject[] m_LevelEntranceArray;

	[Token(Token = "0x400FDBB")]
	[FieldOffset(Offset = "0xD4")]
	private GameObject m_FFWSEnterAnim;

	[Token(Token = "0x400FDBC")]
	[FieldOffset(Offset = "0xD8")]
	private Coroutine m_CoroutineScrollingBgCamera;

	[Token(Token = "0x400FDBD")]
	[FieldOffset(Offset = "0xDC")]
	private float m_OriginalBgCamOrthographicSize;

	[Token(Token = "0x400FDBE")]
	private const string LOBBY_NEW_SCREEN_VFX_NAME = "UIFX_Screen";

	[Token(Token = "0x400FDBF")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_lobbyNewVfx;

	[Token(Token = "0x400FDC0")]
	[FieldOffset(Offset = "0xE4")]
	private Transform m_LobbyFaultScreenTrans;

	[Token(Token = "0x400FDC1")]
	[FieldOffset(Offset = "0xE8")]
	private UIModelPayment.PaymentButtonStyle m_PaymentButtonStyle;

	[Token(Token = "0x400FDC2")]
	[FieldOffset(Offset = "0xEC")]
	private bool m_LateShowAvatarLimitExpireWnd;

	[Token(Token = "0x400FDC3")]
	[FieldOffset(Offset = "0xED")]
	private bool m_NeedAutoEnterGacha;

	[Token(Token = "0x400FDC4")]
	[FieldOffset(Offset = "0xEE")]
	private bool m_IsStartDownloadEquipedOrOwnedOptionalDownload;

	[Token(Token = "0x400FDC5")]
	[FieldOffset(Offset = "0xF0")]
	private UILobbyIAPWeekCardController m_LobbyIAPWeekCardController;

	[Token(Token = "0x400FDC6")]
	[FieldOffset(Offset = "0xF4")]
	private UIHDLobbyIAPBundleController m_HDLobbyIAPBundleController;

	[Token(Token = "0x400FDC7")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_ShouldShowPaymentButton;

	[Token(Token = "0x400FDC8")]
	[FieldOffset(Offset = "0xF9")]
	private bool m_bIsShowingCSGuide;

	[Token(Token = "0x400FDC9")]
	[FieldOffset(Offset = "0xFC")]
	private readonly int BEFORE_STARTGAME_GUIDE_TIME;

	[Token(Token = "0x400FDCA")]
	[FieldOffset(Offset = "0x100")]
	private uint m_StartGameGuideCall;

	[Token(Token = "0x400FDCB")]
	[FieldOffset(Offset = "0x104")]
	private uint m_DelayShowMask;

	[Token(Token = "0x400FDCC")]
	[FieldOffset(Offset = "0x108")]
	private Queue<Action> m_GuideQueue;

	[Token(Token = "0x400FDCD")]
	[FieldOffset(Offset = "0x10C")]
	private bool m_NewbieGuideTriggered;

	[Token(Token = "0x400FDCE")]
	[FieldOffset(Offset = "0x4")]
	private static bool m_startToLeave;

	[Token(Token = "0x400FDCF")]
	[FieldOffset(Offset = "0x10D")]
	private bool m_IsShowHDGuide;

	[Token(Token = "0x400FDD0")]
	[FieldOffset(Offset = "0x110")]
	private UIHDStandLobbyManager m_StandLobbyManager;

	[Token(Token = "0x400FDD1")]
	[FieldOffset(Offset = "0x114")]
	private UIHDLobbyYardGuideController m_lobbyYardGuideController;

	[Token(Token = "0x400FDD2")]
	[FieldOffset(Offset = "0x8")]
	private static Callback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FDD3")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<int> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400FDD4")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400FDD5")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400FDD6")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400FDD7")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x400FDD8")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<MapModeData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x1700121C")]
	private MapModeData m_SelectedMapData
	{
		[Token(Token = "0x60105CB")]
		[Address(RVA = "0xDBF890", Offset = "0xDBF890", VA = "0xDBF890")]
		get
		{
			return null;
		}
		[Token(Token = "0x60105CC")]
		[Address(RVA = "0xDBF98C", Offset = "0xDBF98C", VA = "0xDBF98C")]
		set
		{
		}
	}

	[Token(Token = "0x60105CA")]
	[Address(RVA = "0xDBF7B0", Offset = "0xDBF7B0", VA = "0xDBF7B0")]
	public UILobbyNewController()
	{
	}

	[Token(Token = "0x60105CD")]
	[Address(RVA = "0xDBFA88", Offset = "0xDBFA88", VA = "0xDBFA88")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60105CE")]
	[Address(RVA = "0xDBFB2C", Offset = "0xDBFB2C", VA = "0xDBFB2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60105CF")]
	[Address(RVA = "0xDC4998", Offset = "0xDC4998", VA = "0xDC4998")]
	private void ShowAgeLogo()
	{
	}

	[Token(Token = "0x60105D0")]
	[Address(RVA = "0xDC5154", Offset = "0xDC5154", VA = "0xDC5154")]
	private void ShowFirstGuideMatchGuide(object[] data)
	{
	}

	[Token(Token = "0x60105D1")]
	[Address(RVA = "0xDC56A4", Offset = "0xDC56A4", VA = "0xDC56A4")]
	public void OnInviteClick(object[] data)
	{
	}

	[Token(Token = "0x60105D2")]
	[Address(RVA = "0xDC581C", Offset = "0xDC581C", VA = "0xDC581C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60105D3")]
	[Address(RVA = "0xDC5B60", Offset = "0xDC5B60", VA = "0xDC5B60", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60105D4")]
	[Address(RVA = "0xDC5DF8", Offset = "0xDC5DF8", VA = "0xDC5DF8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x60105D5")]
	[Address(RVA = "0xDC61FC", Offset = "0xDC61FC", VA = "0xDC61FC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60105D6")]
	[Address(RVA = "0xDC9B78", Offset = "0xDC9B78", VA = "0xDC9B78")]
	private void UpdateLobbyMusicFromBtn()
	{
	}

	[Token(Token = "0x60105D7")]
	[Address(RVA = "0xDCA0A8", Offset = "0xDCA0A8", VA = "0xDCA0A8")]
	private void UpdateLobbyMusic()
	{
	}

	[Token(Token = "0x60105D8")]
	[Address(RVA = "0xDC4CC0", Offset = "0xDC4CC0", VA = "0xDC4CC0")]
	private void InitIPMusicBtn()
	{
	}

	[Token(Token = "0x60105D9")]
	[Address(RVA = "0xDCA2AC", Offset = "0xDCA2AC", VA = "0xDCA2AC")]
	private void OnIPMusicBtnClick()
	{
	}

	[Token(Token = "0x60105DA")]
	[Address(RVA = "0xDCA45C", Offset = "0xDCA45C", VA = "0xDCA45C")]
	private void ActivateIPMusicAniAndVFX(bool value)
	{
	}

	[Token(Token = "0x60105DB")]
	[Address(RVA = "0xDCA888", Offset = "0xDCA888", VA = "0xDCA888")]
	private void ShowIPMusicContainer(bool value)
	{
	}

	[Token(Token = "0x60105DC")]
	[Address(RVA = "0xDC81F0", Offset = "0xDC81F0", VA = "0xDC81F0")]
	private void RefreshIPMusicBtnState(object[] param)
	{
	}

	[Token(Token = "0x60105DD")]
	[Address(RVA = "0xDCAAC4", Offset = "0xDCAAC4", VA = "0xDCAAC4")]
	private static bool IsFaultVFXAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60105DE")]
	[Address(RVA = "0xDCABAC", Offset = "0xDCABAC", VA = "0xDCABAC")]
	private static bool IsFaultVFXNeeded(Type preNavigationType)
	{
		return default(bool);
	}

	[Token(Token = "0x60105DF")]
	[Address(RVA = "0xDCB06C", Offset = "0xDCB06C", VA = "0xDCB06C")]
	private static bool PlayTransferTweenAlphaIfCleanAssets()
	{
		return default(bool);
	}

	[Token(Token = "0x60105E0")]
	[Address(RVA = "0xDC3E10", Offset = "0xDC3E10", VA = "0xDC3E10")]
	private void FindLobbyVFXChild()
	{
	}

	[Token(Token = "0x60105E1")]
	[Address(RVA = "0xDCB208", Offset = "0xDCB208", VA = "0xDCB208")]
	private void ShowLobbyVFX(object[] data)
	{
	}

	[Token(Token = "0x60105E2")]
	[Address(RVA = "0xDCB424", Offset = "0xDCB424", VA = "0xDCB424")]
	private bool RefreshLobbyFaultVFX()
	{
		return default(bool);
	}

	[Token(Token = "0x60105E3")]
	[Address(RVA = "0xDC99CC", Offset = "0xDC99CC", VA = "0xDC99CC")]
	private void RefreshReturnVFX()
	{
	}

	[Token(Token = "0x60105E4")]
	[Address(RVA = "0xDC7D88", Offset = "0xDC7D88", VA = "0xDC7D88")]
	private void RefreshLobbyGachaTips()
	{
	}

	[Token(Token = "0x60105E5")]
	[Address(RVA = "0xDCB68C", Offset = "0xDCB68C", VA = "0xDCB68C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x60105E6")]
	[Address(RVA = "0xDC7B9C", Offset = "0xDC7B9C", VA = "0xDC7B9C")]
	private void CheckPetLobbyAction()
	{
	}

	[Token(Token = "0x60105E7")]
	[Address(RVA = "0xDC7960", Offset = "0xDC7960", VA = "0xDC7960")]
	private void CheckLobbyExtraAdsTips()
	{
	}

	[Token(Token = "0x60105E8")]
	[Address(RVA = "0xDC76E4", Offset = "0xDC76E4", VA = "0xDC76E4")]
	public void ShowLabGuide(object[] data)
	{
	}

	[Token(Token = "0x60105E9")]
	[Address(RVA = "0xDC7A7C", Offset = "0xDC7A7C", VA = "0xDC7A7C")]
	private void CheckPetNewTips()
	{
	}

	[Token(Token = "0x60105EA")]
	[Address(RVA = "0xDCBEE0", Offset = "0xDCBEE0", VA = "0xDCBEE0", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x60105EB")]
	[Address(RVA = "0xDC43EC", Offset = "0xDC43EC", VA = "0xDC43EC")]
	public void RefreshGroupModeUI(object[] data)
	{
	}

	[Token(Token = "0x60105EC")]
	[Address(RVA = "0xDCC6BC", Offset = "0xDCC6BC", VA = "0xDCC6BC")]
	public MapModeData GetSelectedMapData()
	{
		return null;
	}

	[Token(Token = "0x60105ED")]
	[Address(RVA = "0xDCC500", Offset = "0xDCC500", VA = "0xDCC500")]
	private void RefreshLoadoutContainer(object[] data)
	{
	}

	[Token(Token = "0x60105EE")]
	[Address(RVA = "0xDCC9AC", Offset = "0xDCC9AC", VA = "0xDCC9AC")]
	private void OnAvatarNewUpdated(object[] param)
	{
	}

	[Token(Token = "0x60105EF")]
	[Address(RVA = "0xDCCAB0", Offset = "0xDCCAB0", VA = "0xDCCAB0")]
	private void OnReplayClick()
	{
	}

	[Token(Token = "0x60105F0")]
	[Address(RVA = "0xDCCBBC", Offset = "0xDCCBBC", VA = "0xDCCBBC")]
	private void OnReportReplayClick()
	{
	}

	[Token(Token = "0x60105F1")]
	[Address(RVA = "0xDCCCC8", Offset = "0xDCCCC8", VA = "0xDCCCC8")]
	private void OnAdsSelected(object[] data)
	{
	}

	[Token(Token = "0x60105F2")]
	[Address(RVA = "0xDCCED4", Offset = "0xDCCED4", VA = "0xDCCED4")]
	private void OnOpenSetting(object[] data)
	{
	}

	[Token(Token = "0x60105F3")]
	[Address(RVA = "0xDCD010", Offset = "0xDCD010", VA = "0xDCD010")]
	public Vector3 GetLivTvPosForSplash()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60105F4")]
	[Address(RVA = "0xDCD0E4", Offset = "0xDCD0E4", VA = "0xDCD0E4")]
	private void CheckAutoDownloadOptionalDownloadOwneOrEquipedClothes()
	{
	}

	[Token(Token = "0x60105F5")]
	[Address(RVA = "0xDCD218", Offset = "0xDCD218", VA = "0xDCD218", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60105F6")]
	[Address(RVA = "0xDC98AC", Offset = "0xDC98AC", VA = "0xDC98AC")]
	private void UpdateHyperBookEntranceRedPointByUnlockOrDraw()
	{
	}

	[Token(Token = "0x60105F7")]
	[Address(RVA = "0xDCBFB8", Offset = "0xDCBFB8", VA = "0xDCBFB8")]
	private void UpdateAllLevelEntranceStatus()
	{
	}

	[Token(Token = "0x60105F8")]
	[Address(RVA = "0xDCC71C", Offset = "0xDCC71C", VA = "0xDCC71C")]
	private void UpdateLevelEntrance(int entranceIndex, uint LockStatus)
	{
	}

	[Token(Token = "0x60105F9")]
	[Address(RVA = "0xDCEEA0", Offset = "0xDCEEA0", VA = "0xDCEEA0")]
	private void UpdateAvatarCloth()
	{
	}

	[Token(Token = "0x60105FA")]
	[Address(RVA = "0xDC7740", Offset = "0xDC7740", VA = "0xDC7740")]
	private void CheckGachaFreeTips([Optional] object[] data)
	{
	}

	[Token(Token = "0x60105FB")]
	[Address(RVA = "0xDCF698", Offset = "0xDCF698", VA = "0xDCF698")]
	private void CheckManualShakeTips()
	{
	}

	[Token(Token = "0x60105FC")]
	[Address(RVA = "0xDCF9EC", Offset = "0xDCF9EC", VA = "0xDCF9EC")]
	private void ProcessTopupNotifications()
	{
	}

	[Token(Token = "0x60105FD")]
	[Address(RVA = "0xDCFCE0", Offset = "0xDCFCE0", VA = "0xDCFCE0", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60105FE")]
	[Address(RVA = "0xDCFFB4", Offset = "0xDCFFB4", VA = "0xDCFFB4")]
	private void OnEPDataChange(object[] param)
	{
	}

	[Token(Token = "0x60105FF")]
	[Address(RVA = "0xDD0010", Offset = "0xDD0010", VA = "0xDD0010")]
	private void OnEPEntranceChange(object[] param)
	{
	}

	[Token(Token = "0x6010600")]
	[Address(RVA = "0xDC4170", Offset = "0xDC4170", VA = "0xDC4170")]
	private void UpdateLobbyRewardedVideo()
	{
	}

	[Token(Token = "0x6010601")]
	[Address(RVA = "0xDD006C", Offset = "0xDD006C", VA = "0xDD006C")]
	private void OnRewardedVideoBtnClick()
	{
	}

	[Token(Token = "0x6010602")]
	[Address(RVA = "0xDD0228", Offset = "0xDD0228", VA = "0xDD0228")]
	private void OnOpenManual(object[] data)
	{
	}

	[Token(Token = "0x6010603")]
	[Address(RVA = "0xDD0290", Offset = "0xDD0290", VA = "0xDD0290")]
	private void OnManualBtnClick()
	{
	}

	[Token(Token = "0x6010604")]
	[Address(RVA = "0xDD06FC", Offset = "0xDD06FC", VA = "0xDD06FC")]
	private void OnEPTaskButtonClick()
	{
	}

	[Token(Token = "0x6010605")]
	[Address(RVA = "0xDD08B8", Offset = "0xDD08B8", VA = "0xDD08B8")]
	private void OnShowAvatarEmotePanel(object[] data)
	{
	}

	[Token(Token = "0x6010606")]
	[Address(RVA = "0xDD0F60", Offset = "0xDD0F60", VA = "0xDD0F60")]
	private void OnCloseEmotePanel(object[] data)
	{
	}

	[Token(Token = "0x6010607")]
	[Address(RVA = "0xDD1064", Offset = "0xDD1064", VA = "0xDD1064")]
	private void OnPetShowActionClick(object[] param)
	{
	}

	[Token(Token = "0x6010608")]
	[Address(RVA = "0xDD1E7C", Offset = "0xDD1E7C", VA = "0xDD1E7C")]
	private void OnPetHideActionPanel(object[] data)
	{
	}

	[Token(Token = "0x6010609")]
	[Address(RVA = "0xDD1F88", Offset = "0xDD1F88", VA = "0xDD1F88")]
	private void SetPaymentButtonShow(bool isShow)
	{
	}

	[Token(Token = "0x601060A")]
	[Address(RVA = "0xDCE4EC", Offset = "0xDCE4EC", VA = "0xDCE4EC")]
	private void UpdatePaymentButton()
	{
	}

	[Token(Token = "0x601060B")]
	[Address(RVA = "0xDD1FF4", Offset = "0xDD1FF4", VA = "0xDD1FF4")]
	private bool IsPayAcitivityOpen(UIModelPayment.PaymentButtonStyle paymentType)
	{
		return default(bool);
	}

	[Token(Token = "0x601060C")]
	[Address(RVA = "0xDD2F1C", Offset = "0xDD2F1C", VA = "0xDD2F1C")]
	private void OnPaymentButtonClick()
	{
	}

	[Token(Token = "0x601060D")]
	[Address(RVA = "0xDD3D60", Offset = "0xDD3D60", VA = "0xDD3D60")]
	private void OnShowLobbyAvatarGuide(object[] data)
	{
	}

	[Token(Token = "0x601060E")]
	[Address(RVA = "0xDD4B9C", Offset = "0xDD4B9C", VA = "0xDD4B9C")]
	private void OnShowLobbyStartGameGuide(object[] data)
	{
	}

	[Token(Token = "0x601060F")]
	[Address(RVA = "0xDD50C0", Offset = "0xDD50C0", VA = "0xDD50C0")]
	private void OnClickCSGameGuide()
	{
	}

	[Token(Token = "0x6010610")]
	[Address(RVA = "0xDD52D8", Offset = "0xDD52D8", VA = "0xDD52D8")]
	public void OnShowCSGameGuide(object[] data)
	{
	}

	[Token(Token = "0x6010611")]
	[Address(RVA = "0xDD58D8", Offset = "0xDD58D8", VA = "0xDD58D8")]
	private void RefreshIAPBundle(object[] data)
	{
	}

	[Token(Token = "0x6010612")]
	[Address(RVA = "0xDD5998", Offset = "0xDD5998", VA = "0xDD5998")]
	private void OnShowLobbyManualGuide(object[] data)
	{
	}

	[Token(Token = "0x6010613")]
	[Address(RVA = "0xDD5DB8", Offset = "0xDD5DB8", VA = "0xDD5DB8")]
	private void OnSHowLobbyClanGuide(object[] data)
	{
	}

	[Token(Token = "0x6010614")]
	[Address(RVA = "0xDD624C", Offset = "0xDD624C", VA = "0xDD624C")]
	private void OnCloseCommonGuide(object[] data)
	{
	}

	[Token(Token = "0x6010615")]
	[Address(RVA = "0xDD63E4", Offset = "0xDD63E4", VA = "0xDD63E4")]
	public void OnTouchLocalAvatar(object[] param)
	{
	}

	[Token(Token = "0x6010616")]
	[Address(RVA = "0xDD6728", Offset = "0xDD6728", VA = "0xDD6728")]
	private void PlayGroupTween(object[] data)
	{
	}

	[Token(Token = "0x6010617")]
	[Address(RVA = "0xDD6858", Offset = "0xDD6858", VA = "0xDD6858")]
	private void OnLobbyGroupEnter(object[] data)
	{
	}

	[Token(Token = "0x6010618")]
	[Address(RVA = "0xDD699C", Offset = "0xDD699C", VA = "0xDD699C")]
	private void OnLobbyGroupQuit(object[] data)
	{
	}

	[Token(Token = "0x6010619")]
	[Address(RVA = "0xDD6A7C", Offset = "0xDD6A7C", VA = "0xDD6A7C")]
	private void UpdateLobbyIAPBundle()
	{
	}

	[Token(Token = "0x601061A")]
	[Address(RVA = "0xDC4044", Offset = "0xDC4044", VA = "0xDC4044")]
	private void RefreshIAPBundleActivityState(object[] data)
	{
	}

	[Token(Token = "0x601061B")]
	[Address(RVA = "0xDD7750", Offset = "0xDD7750", VA = "0xDD7750")]
	private void ScrollBgCameraSize(object[] data)
	{
	}

	[Token(Token = "0x601061C")]
	[Address(RVA = "0xDD7A34", Offset = "0xDD7A34", VA = "0xDD7A34")]
	private IEnumerator CoroutineScrollingBgCamera(float needSize)
	{
		return null;
	}

	[Token(Token = "0x601061D")]
	[Address(RVA = "0xDD7B30", Offset = "0xDD7B30", VA = "0xDD7B30")]
	private void StartCertainMode(object[] args)
	{
	}

	[Token(Token = "0x601061E")]
	[Address(RVA = "0xDD7EA0", Offset = "0xDD7EA0", VA = "0xDD7EA0")]
	private void StartNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x601061F")]
	[Address(RVA = "0xDCBE78", Offset = "0xDCBE78", VA = "0xDCBE78")]
	private void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x6010620")]
	[Address(RVA = "0xDDB0CC", Offset = "0xDDB0CC", VA = "0xDDB0CC")]
	private void NewbiePathGuideProgressUpdate(object[] args)
	{
	}

	[Token(Token = "0x6010621")]
	[Address(RVA = "0xDDAE94", Offset = "0xDDAE94", VA = "0xDDAE94")]
	private void OnStopLobbyGuide()
	{
	}

	[Token(Token = "0x6010622")]
	[Address(RVA = "0xDDB290", Offset = "0xDDB290", VA = "0xDDB290")]
	public static void PrepareStartGuide()
	{
	}

	[Token(Token = "0x6010623")]
	[Address(RVA = "0xDDB3A4", Offset = "0xDDB3A4", VA = "0xDDB3A4")]
	public void PrepareStopGuide(object[] data)
	{
	}

	[Token(Token = "0x6010624")]
	[Address(RVA = "0xDD81DC", Offset = "0xDD81DC", VA = "0xDD81DC")]
	private void NewbieRankGameGuide()
	{
	}

	[Token(Token = "0x6010625")]
	[Address(RVA = "0xDD8D48", Offset = "0xDD8D48", VA = "0xDD8D48")]
	private void NewbieMiguelGuide(int avatarId)
	{
	}

	[Token(Token = "0x6010626")]
	[Address(RVA = "0xDD907C", Offset = "0xDD907C", VA = "0xDD907C")]
	private void NewbieRoleGuide()
	{
	}

	[Token(Token = "0x6010627")]
	[Address(RVA = "0xDD86C4", Offset = "0xDD86C4", VA = "0xDD86C4")]
	private void NewbieNonPVEGuide()
	{
	}

	[Token(Token = "0x6010628")]
	[Address(RVA = "0xDD946C", Offset = "0xDD946C", VA = "0xDD946C")]
	private void NewbieGachaGuide()
	{
	}

	[Token(Token = "0x6010629")]
	[Address(RVA = "0xDD988C", Offset = "0xDD988C", VA = "0xDD988C")]
	private void NewbieLoadoutGuide()
	{
	}

	[Token(Token = "0x601062A")]
	[Address(RVA = "0xDD9D20", Offset = "0xDD9D20", VA = "0xDD9D20")]
	private void NewbieNonMatchAndNonRankGuide()
	{
	}

	[Token(Token = "0x601062B")]
	[Address(RVA = "0xDDA234", Offset = "0xDDA234", VA = "0xDDA234")]
	private void NewbieEPEntryGuide()
	{
	}

	[Token(Token = "0x601062C")]
	[Address(RVA = "0xDDA288", Offset = "0xDDA288", VA = "0xDDA288")]
	private void NewbieEPTaskGuide()
	{
	}

	[Token(Token = "0x601062D")]
	[Address(RVA = "0xDDA2DC", Offset = "0xDDA2DC", VA = "0xDDA2DC")]
	private void NewbieSetMapModeGameGuide(ENewbieGuideType guideType)
	{
	}

	[Token(Token = "0x601062E")]
	[Address(RVA = "0xDDB608", Offset = "0xDDB608", VA = "0xDDB608", Slot = "44")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x601062F")]
	[Address(RVA = "0xDDB8CC", Offset = "0xDDB8CC", VA = "0xDDB8CC")]
	private void OnBtnEPClick()
	{
	}

	[Token(Token = "0x6010630")]
	[Address(RVA = "0xDDBA88", Offset = "0xDDBA88", VA = "0xDDBA88")]
	private void OnEPContainerClicked(object[] data)
	{
	}

	[Token(Token = "0x6010631")]
	[Address(RVA = "0xDDBB68", Offset = "0xDDBB68", VA = "0xDDBB68")]
	private void OnBeginToGotoYard(object[] data)
	{
	}

	[Token(Token = "0x6010632")]
	[Address(RVA = "0xDDBFC8", Offset = "0xDDBFC8", VA = "0xDDBFC8")]
	private void ResetPanels()
	{
	}

	[Token(Token = "0x6010633")]
	[Address(RVA = "0xDC824C", Offset = "0xDC824C", VA = "0xDC824C")]
	private void ShowHDLobbyGuide(object[] data)
	{
	}

	[Token(Token = "0x6010634")]
	[Address(RVA = "0xDDC32C", Offset = "0xDDC32C", VA = "0xDDC32C")]
	private void UpdateFullHD()
	{
	}

	[Token(Token = "0x6010635")]
	[Address(RVA = "0xDDD1F4", Offset = "0xDDD1F4", VA = "0xDDD1F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6010636")]
	[Address(RVA = "0xDC93B8", Offset = "0xDC93B8", VA = "0xDC93B8")]
	private void OpenAvatarLimitExpireWindow()
	{
	}

	[Token(Token = "0x6010637")]
	[Address(RVA = "0xDDD2F0", Offset = "0xDDD2F0", VA = "0xDDD2F0")]
	private void SetOpenEnterGacha(object[] param)
	{
	}

	[Token(Token = "0x6010638")]
	[Address(RVA = "0xDC9660", Offset = "0xDC9660", VA = "0xDC9660")]
	private void BackFromPaymentShowSecondRecharge()
	{
	}

	[Token(Token = "0x6010639")]
	[Address(RVA = "0xDDD358", Offset = "0xDDD358", VA = "0xDDD358")]
	public void StartLoginAutoTask()
	{
	}

	[Token(Token = "0x601063A")]
	[Address(RVA = "0xDDDD68", Offset = "0xDDDD68", VA = "0xDDDD68")]
	public void StartReturnFromInGameAutoTask()
	{
	}

	[Token(Token = "0x601063B")]
	[Address(RVA = "0xDDE934", Offset = "0xDDE934", VA = "0xDDE934")]
	public void OnInGameReturnToLobby()
	{
	}

	[Token(Token = "0x601063C")]
	[Address(RVA = "0xDDE7C0", Offset = "0xDDE7C0", VA = "0xDDE7C0")]
	private bool NeedStartReturnFromInGameAutoTask()
	{
		return default(bool);
	}

	[Token(Token = "0x601063D")]
	[Address(RVA = "0xDDEA30", Offset = "0xDDEA30", VA = "0xDDEA30", Slot = "33")]
	protected override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x601063F")]
	[Address(RVA = "0xDDEFD0", Offset = "0xDDEFD0", VA = "0xDDEFD0")]
	private static void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6010640")]
	[Address(RVA = "0xDDF094", Offset = "0xDDF094", VA = "0xDDF094")]
	private static bool _003COnDataChanged_003Em__1(int i)
	{
		return default(bool);
	}

	[Token(Token = "0x6010641")]
	[Address(RVA = "0xDDF0A8", Offset = "0xDDF0A8", VA = "0xDDF0A8")]
	private void _003CNewbieRankGameGuide_003Em__2()
	{
	}

	[Token(Token = "0x6010642")]
	[Address(RVA = "0xDDF2E0", Offset = "0xDDF2E0", VA = "0xDDF2E0")]
	private static bool _003CNewbieNonPVEGuide_003Em__3(MapModeData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010643")]
	[Address(RVA = "0xDDF310", Offset = "0xDDF310", VA = "0xDDF310")]
	private void _003CNewbieNonMatchAndNonRankGuide_003Em__4()
	{
	}

	[Token(Token = "0x6010644")]
	[Address(RVA = "0xDDF548", Offset = "0xDDF548", VA = "0xDDF548")]
	private static bool _003CNewbieSetMapModeGameGuide_003Em__5(MapModeData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010645")]
	[Address(RVA = "0xDDF584", Offset = "0xDDF584", VA = "0xDDF584")]
	private static bool _003CNewbieSetMapModeGameGuide_003Em__6(MapModeData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010646")]
	[Address(RVA = "0xDDF5C0", Offset = "0xDDF5C0", VA = "0xDDF5C0")]
	private static bool _003CNewbieSetMapModeGameGuide_003Em__7(MapModeData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010647")]
	[Address(RVA = "0xDDF5F0", Offset = "0xDDF5F0", VA = "0xDDF5F0")]
	private static bool _003CNewbieSetMapModeGameGuide_003Em__8(MapModeData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010648")]
	[Address(RVA = "0xDDF620", Offset = "0xDDF620", VA = "0xDDF620")]
	private void _003COnBeginToGotoYard_003Em__9()
	{
	}

	[Token(Token = "0x6010649")]
	[Address(RVA = "0xDDF754", Offset = "0xDDF754", VA = "0xDDF754")]
	private void _003CNewbieRankGameGuide_003Em__A()
	{
	}

	[Token(Token = "0x601064A")]
	[Address(RVA = "0xDDF8B4", Offset = "0xDDF8B4", VA = "0xDDF8B4")]
	private void _003CNewbieNonMatchAndNonRankGuide_003Em__B()
	{
	}

	[Token(Token = "0x601064B")]
	[Address(RVA = "0xDDFA14", Offset = "0xDDFA14", VA = "0xDDFA14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601064C")]
	[Address(RVA = "0xDDFA1C", Offset = "0xDDFA1C", VA = "0xDDFA1C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x601064D")]
	[Address(RVA = "0xDDFA24", Offset = "0xDDFA24", VA = "0xDDFA24")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601064E")]
	[Address(RVA = "0xDDFA2C", Offset = "0xDDFA2C", VA = "0xDDFA2C")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601064F")]
	[Address(RVA = "0xDDFA34", Offset = "0xDDFA34", VA = "0xDDFA34")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010650")]
	[Address(RVA = "0xDDFA3C", Offset = "0xDDFA3C", VA = "0xDDFA3C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6010651")]
	[Address(RVA = "0xDDFA44", Offset = "0xDDFA44", VA = "0xDDFA44")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x6010652")]
	[Address(RVA = "0xDDFA4C", Offset = "0xDDFA4C", VA = "0xDDFA4C")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
