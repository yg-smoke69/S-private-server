using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200331E")]
internal class UIInGameScene : UICOWBaseScene
{
	[Token(Token = "0x200331F")]
	public enum EMapStateType
	{
		[Token(Token = "0x40137A8")]
		MiniMap,
		[Token(Token = "0x40137A9")]
		BigMap,
		[Token(Token = "0x40137AA")]
		SideMap
	}

	[Token(Token = "0x2003320")]
	public enum EUIGroup : ulong
	{
		[Token(Token = "0x40137AC")]
		UIGroup_InGameNormal = 1uL,
		[Token(Token = "0x40137AD")]
		UIGroup_Inventory = 2uL,
		[Token(Token = "0x40137AE")]
		UIGroup_Driver = 4uL,
		[Token(Token = "0x40137AF")]
		UIGroup_Passenger = 8uL,
		[Token(Token = "0x40137B0")]
		UIGroup_Skydiving = 0x10uL,
		[Token(Token = "0x40137B1")]
		UIGroup_Sighting = 0x20uL,
		[Token(Token = "0x40137B2")]
		UIGroup_MatchEnd = 0x40uL,
		[Token(Token = "0x40137B3")]
		UIGroup_HideAll = 0x80uL,
		[Token(Token = "0x40137B4")]
		UIGroup_BIGMAP = 0x100uL,
		[Token(Token = "0x40137B5")]
		UIGroup_Observer = 0x200uL,
		[Token(Token = "0x40137B6")]
		UIGroup_KnockDown = 0x400uL,
		[Token(Token = "0x40137B7")]
		UIGroup_SpectatorFixed = 0x800uL,
		[Token(Token = "0x40137B8")]
		UIGroup_SpectatorFree = 0x1000uL,
		[Token(Token = "0x40137B9")]
		UIGroup_OnStrop = 0x2000uL,
		[Token(Token = "0x40137BA")]
		UIGroup_RoomObserver = 0x4000uL,
		[Token(Token = "0x40137BB")]
		UIGroup_InJetFly = 0x8000uL,
		[Token(Token = "0x40137BC")]
		UIGroup_ActiveSkill = 0x10000uL,
		[Token(Token = "0x40137BD")]
		UIGroup_PendingRevive = 0x20000uL,
		[Token(Token = "0x40137BE")]
		UIGroup_OnSeat = 0x40000uL,
		[Token(Token = "0x40137BF")]
		UIGroup_OnCatapult = 0x80000uL,
		[Token(Token = "0x40137C0")]
		UIGroup_CatapultFalling = 0x100000uL,
		[Token(Token = "0x40137C1")]
		UIGroup_PendingReviveReborn = 0x200000uL,
		[Token(Token = "0x40137C2")]
		UIGroup_InFoldWing = 0x400000uL,
		[Token(Token = "0x40137C3")]
		UIGroup_Skateboarding = 0x800000uL,
		[Token(Token = "0x40137C4")]
		UIGroup_SnowMan = 0x1000000uL,
		[Token(Token = "0x40137C5")]
		UIGroup_Cutscene = 0x2000000uL,
		[Token(Token = "0x40137C6")]
		UIGroup_ReaperMode = 0x4000000uL,
		[Token(Token = "0x40137C7")]
		UIGroup_ObserverMatchEndShow = 0x8000000uL,
		[Token(Token = "0x40137C8")]
		UIGroup_Photograph = 0x10000000uL,
		[Token(Token = "0x40137C9")]
		UIGroup_NewDeath = 0x20000000uL,
		[Token(Token = "0x40137CA")]
		UIGroup_OnFerrisWheel = 0x40000000uL,
		[Token(Token = "0x40137CB")]
		UIGroup_WereWolves = 0x80000000uL,
		[Token(Token = "0x40137CC")]
		UIGroup_SceneEditFree = 0x100000000uL,
		[Token(Token = "0x40137CD")]
		UIGroup_SceneEditLook = 0x200000000uL,
		[Token(Token = "0x40137CE")]
		UIGroup_PartyGame = 0x400000000uL,
		[Token(Token = "0x40137CF")]
		UIGroup_SceneEditLock = 0x800000000uL,
		[Token(Token = "0x40137D0")]
		UIGroup_SceneEditPreviewLock = 0x1000000000uL,
		[Token(Token = "0x40137D1")]
		UIGroup_SceneEditPreviewFree = 0x2000000000uL,
		[Token(Token = "0x40137D2")]
		UIGroup_DuringSoloDance = 0x4000000000uL,
		[Token(Token = "0x40137D3")]
		UIGroup_ReplayObserver = 0x8000000000uL,
		[Token(Token = "0x40137D4")]
		UIGroup_FlightRoam = 0x10000000000uL,
		[Token(Token = "0x40137D5")]
		UIGroup_UGCPhotograph = 0x20000000000uL,
		[Token(Token = "0x40137D6")]
		UIGroup_SceneEditFreeEntityGetter = 0x40000000000uL,
		[Token(Token = "0x40137D7")]
		UIGroup_SceneEditLockEntityGetter = 0x80000000000uL,
		[Token(Token = "0x40137D8")]
		UIGroup_GrapplingHookGunOnStrop = 0x100000000000uL,
		[Token(Token = "0x40137D9")]
		UIGroup_InGamePlatform = 0x200000000000uL
	}

	[Token(Token = "0x2003321")]
	private sealed class _003CReleaseMemoryAndOpenMatchResult_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40137DA")]
		[FieldOffset(Offset = "0x8")]
		internal NFJPHMKKEBF _003Cmatch_003E__0;

		[Token(Token = "0x40137DB")]
		[FieldOffset(Offset = "0xC")]
		internal bool _003CreleaseLocalPlayer_003E__0;

		[Token(Token = "0x40137DC")]
		[FieldOffset(Offset = "0xD")]
		internal bool keepScene;

		[Token(Token = "0x40137DD")]
		[FieldOffset(Offset = "0xE")]
		internal bool createAvatar;

		[Token(Token = "0x40137DE")]
		[FieldOffset(Offset = "0x10")]
		internal float _003CwaitEndTime_003E__1;

		[Token(Token = "0x40137DF")]
		[FieldOffset(Offset = "0x14")]
		internal AsyncOperation _003CcleanupState_003E__0;

		[Token(Token = "0x40137E0")]
		[FieldOffset(Offset = "0x18")]
		internal Type type;

		[Token(Token = "0x40137E1")]
		[FieldOffset(Offset = "0x1C")]
		internal UIInGameScene _0024this;

		[Token(Token = "0x40137E2")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x40137E3")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x40137E4")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x170016CC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6015A8D")]
			[Address(RVA = "0x127AB8C", Offset = "0x127AB8C", VA = "0x127AB8C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170016CD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6015A8E")]
			[Address(RVA = "0x127AB94", Offset = "0x127AB94", VA = "0x127AB94", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6015A8B")]
		[Address(RVA = "0x127A0F0", Offset = "0x127A0F0", VA = "0x127A0F0")]
		public _003CReleaseMemoryAndOpenMatchResult_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6015A8C")]
		[Address(RVA = "0x127A0F8", Offset = "0x127A0F8", VA = "0x127A0F8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6015A8F")]
		[Address(RVA = "0x127AB9C", Offset = "0x127AB9C", VA = "0x127AB9C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6015A90")]
		[Address(RVA = "0x127ABB0", Offset = "0x127ABB0", VA = "0x127ABB0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003322")]
	private sealed class _003CAdjustHudApperance_003Ec__AnonStorey1
	{
		[Token(Token = "0x40137E5")]
		[FieldOffset(Offset = "0x8")]
		internal Type t;

		[Token(Token = "0x6015A91")]
		[Address(RVA = "0x1279A18", Offset = "0x1279A18", VA = "0x1279A18")]
		public _003CAdjustHudApperance_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6015A92")]
		[Address(RVA = "0x1279A20", Offset = "0x1279A20", VA = "0x1279A20")]
		internal bool _003C_003Em__0(UIBaseController c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003323")]
	private sealed class _003CRoomSpectatorRequestQuitMatch_003Ec__AnonStorey2
	{
		[Token(Token = "0x40137E6")]
		[FieldOffset(Offset = "0x8")]
		internal MatchGame game;

		[Token(Token = "0x40137E7")]
		[FieldOffset(Offset = "0xC")]
		internal UIInGameScene _0024this;

		[Token(Token = "0x6015A93")]
		[Address(RVA = "0x127AC9C", Offset = "0x127AC9C", VA = "0x127AC9C")]
		public _003CRoomSpectatorRequestQuitMatch_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6015A94")]
		[Address(RVA = "0x127ACA4", Offset = "0x127ACA4", VA = "0x127ACA4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003324")]
	private sealed class _003CNormalPlayerRequestQuitMatch_003Ec__AnonStorey4
	{
		[Token(Token = "0x40137E8")]
		[FieldOffset(Offset = "0x8")]
		internal MatchGame game;

		[Token(Token = "0x6015A95")]
		[Address(RVA = "0x127A0E8", Offset = "0x127A0E8", VA = "0x127A0E8")]
		public _003CNormalPlayerRequestQuitMatch_003Ec__AnonStorey4()
		{
		}
	}

	[Token(Token = "0x2003325")]
	private sealed class _003CNormalPlayerRequestQuitMatch_003Ec__AnonStorey3
	{
		[Token(Token = "0x40137E9")]
		[FieldOffset(Offset = "0x8")]
		internal bool isCurrentGameDelayExitActivated;

		[Token(Token = "0x40137EA")]
		[FieldOffset(Offset = "0xC")]
		internal _003CNormalPlayerRequestQuitMatch_003Ec__AnonStorey4 _003C_003Ef__ref_00244;

		[Token(Token = "0x6015A96")]
		[Address(RVA = "0x1279A64", Offset = "0x1279A64", VA = "0x1279A64")]
		public _003CNormalPlayerRequestQuitMatch_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015A97")]
		[Address(RVA = "0x1279A6C", Offset = "0x1279A6C", VA = "0x1279A6C")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6015A98")]
		[Address(RVA = "0x1279E6C", Offset = "0x1279E6C", VA = "0x1279E6C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2003326")]
	private sealed class _003CRemoveNameHud_003Ec__AnonStorey5
	{
		[Token(Token = "0x40137EB")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG id;

		[Token(Token = "0x40137EC")]
		[FieldOffset(Offset = "0x20")]
		internal UIInGameScene _0024this;

		[Token(Token = "0x6015A99")]
		[Address(RVA = "0x127AC38", Offset = "0x127AC38", VA = "0x127AC38")]
		public _003CRemoveNameHud_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6015A9A")]
		[Address(RVA = "0x127AC40", Offset = "0x127AC40", VA = "0x127AC40")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4013700")]
	[FieldOffset(Offset = "0x60")]
	private UIHudPopupController m_LastPopupController;

	[Token(Token = "0x4013701")]
	[FieldOffset(Offset = "0x64")]
	private UIHudPopupController m_LastLowPopupController;

	[Token(Token = "0x4013702")]
	[FieldOffset(Offset = "0x68")]
	private UIHudCreditBehaviorPopupController m_LastCreditBeahviorPopupController;

	[Token(Token = "0x4013703")]
	[FieldOffset(Offset = "0x6C")]
	private UIHudTweenTipsController m_TweenTipsController;

	[Token(Token = "0x4013704")]
	[FieldOffset(Offset = "0x70")]
	private UIHudBannerTweenTipsController m_BannerTweenTipsController;

	[Token(Token = "0x4013705")]
	[FieldOffset(Offset = "0x74")]
	private UIHudSpecialPopupController m_LastSpecialPopupController;

	[Token(Token = "0x4013706")]
	[FieldOffset(Offset = "0x78")]
	private UIHudDynamicInfoPopupController m_LastDynamicPopupController;

	[Token(Token = "0x4013707")]
	[FieldOffset(Offset = "0x7C")]
	protected UIHudTeammatesInfoController m_TeamInfoUI;

	[Token(Token = "0x4013708")]
	[FieldOffset(Offset = "0x80")]
	private UIHudSpeedRoyaleTeammatesInfoController m_SpeedRoyalTeamInfoUI;

	[Token(Token = "0x4013709")]
	[FieldOffset(Offset = "0x84")]
	protected UIHudEmotionController m_EmotionCtrl;

	[Token(Token = "0x401370A")]
	[FieldOffset(Offset = "0x88")]
	private UIHudMessageController m_MessageCtrl;

	[Token(Token = "0x401370B")]
	[FieldOffset(Offset = "0x8C")]
	private UIHudRouletteChatController m_RouletteChatCtrl;

	[Token(Token = "0x401370C")]
	[FieldOffset(Offset = "0x90")]
	private UIHudRouletteMedkitController m_RouletteMedkitCtrl;

	[Token(Token = "0x401370D")]
	[FieldOffset(Offset = "0x94")]
	private UIHudRouletteGrenadeController m_RouletteGrenadeCtrl;

	[Token(Token = "0x401370E")]
	[FieldOffset(Offset = "0x98")]
	protected Dictionary<IHAAMHPPLMG, UIBaseController> m_PlayerNames;

	[Token(Token = "0x401370F")]
	[FieldOffset(Offset = "0x9C")]
	private Dictionary<IHAAMHPPLMG, UIBaseController> m_EnemyNames;

	[Token(Token = "0x4013710")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<IHAAMHPPLMG, UIBaseController> m_FriendNames;

	[Token(Token = "0x4013711")]
	[FieldOffset(Offset = "0xA4")]
	private Dictionary<IHAAMHPPLMG, UIHudChatBoxController> m_PlayerChats;

	[Token(Token = "0x4013712")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<uint, UIBaseController> m_ObjectNames;

	[Token(Token = "0x4013713")]
	[FieldOffset(Offset = "0xAC")]
	private Dictionary<IHAAMHPPLMG, UIHudNameRedEnvelopeOwnerController> m_RedEnvelopeOwners;

	[Token(Token = "0x4013714")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<IHAAMHPPLMG, UIHudEnermyPointController> m_EnermyPoints;

	[Token(Token = "0x4013715")]
	[FieldOffset(Offset = "0xB4")]
	private Dictionary<IHAAMHPPLMG, UIHudEnermyPointController> m_BanActiveSkillPoints;

	[Token(Token = "0x4013716")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<IHAAMHPPLMG, UIHudEnermyPointController> m_DeliveryMarkEnemyPoints;

	[Token(Token = "0x4013717")]
	[FieldOffset(Offset = "0xBC")]
	private Dictionary<IHAAMHPPLMG, UIHudEnermyPointController> m_CuringEnemyPoints;

	[Token(Token = "0x4013718")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<IHAAMHPPLMG, UIHudEnermyPointController> m_MarkIceWallNearbyEnemyPoints;

	[Token(Token = "0x4013719")]
	[FieldOffset(Offset = "0xC4")]
	private Dictionary<IHAAMHPPLMG, UIHudRevengeInfoPointController> m_RevengeInfoPoints;

	[Token(Token = "0x401371A")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<IHAAMHPPLMG, UIHudItemMarkShowController> m_AssistantItemMarks;

	[Token(Token = "0x401371B")]
	[FieldOffset(Offset = "0xCC")]
	private Dictionary<IHAAMHPPLMG, UIHudItemMarkShowController> m_AssistantPosItemMarks;

	[Token(Token = "0x401371C")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<uint, UIHudRevivePointPosMarkController> m_RevivePointMarks;

	[Token(Token = "0x401371D")]
	[FieldOffset(Offset = "0xD4")]
	protected UIHudPVEAutoReviveController m_HudPVEReviveInfoCtrl;

	[Token(Token = "0x401371E")]
	[FieldOffset(Offset = "0xD8")]
	protected UIHUDPlayerGodBarController m_HUDPlayerGodInfoCtrl;

	[Token(Token = "0x401371F")]
	[FieldOffset(Offset = "0xDC")]
	private UIHudWhiteScreenController m_WhiteScreenCtrl;

	[Token(Token = "0x4013720")]
	[FieldOffset(Offset = "0xE0")]
	private UIHudEnemyHypeLevelController m_HudEnemyHypeLevel;

	[Token(Token = "0x4013721")]
	[FieldOffset(Offset = "0xE4")]
	protected UIHudMinimapController m_MiniMapController;

	[Token(Token = "0x4013722")]
	[FieldOffset(Offset = "0xE8")]
	protected UIHudMatchEndShowTimeControllerBase m_MatchEndShowTimeController;

	[Token(Token = "0x4013723")]
	[FieldOffset(Offset = "0xEC")]
	private UIHudManualTipsController m_ManualTipsController;

	[Token(Token = "0x4013724")]
	[FieldOffset(Offset = "0xF0")]
	protected UIBaseController m_LeaderboardController;

	[Token(Token = "0x4013725")]
	[FieldOffset(Offset = "0xF4")]
	private UIHudGamePauseController m_GamePauseCtrl;

	[Token(Token = "0x4013726")]
	[FieldOffset(Offset = "0xF8")]
	protected UIHudCSShopController m_CSShopController;

	[Token(Token = "0x4013727")]
	[FieldOffset(Offset = "0xFC")]
	private UIHudCSShopMysteryBoxOpenController m_MysteryBoxOpenController;

	[Token(Token = "0x4013728")]
	[FieldOffset(Offset = "0x100")]
	protected UIHudBaseCSRoundResultController m_CSRoundResultController;

	[Token(Token = "0x4013729")]
	[FieldOffset(Offset = "0x104")]
	protected UIHudRoundTransitionController m_RoundTransitionController;

	[Token(Token = "0x401372A")]
	[FieldOffset(Offset = "0x108")]
	protected UIHudCSFactionController m_CSFactionController;

	[Token(Token = "0x401372B")]
	[FieldOffset(Offset = "0x10C")]
	protected UIHudCSShopEntryController m_CSShopEntryCtrl;

	[Token(Token = "0x401372C")]
	[FieldOffset(Offset = "0x110")]
	protected UIHudCupMatchIntroController m_CupMatchEntryCtrl;

	[Token(Token = "0x401372D")]
	[FieldOffset(Offset = "0x114")]
	protected UIBigMapController m_BigMapCtrl;

	[Token(Token = "0x401372E")]
	[FieldOffset(Offset = "0x118")]
	protected UIHudKillNotificationController m_KillNotiCtrl;

	[Token(Token = "0x401372F")]
	[FieldOffset(Offset = "0x11C")]
	protected UIHudSafeZoneInfoController m_SafeZoneInfoCtrl;

	[Token(Token = "0x4013730")]
	[FieldOffset(Offset = "0x120")]
	protected UIHudDirectionRulerController m_DirRulerCtrl;

	[Token(Token = "0x4013731")]
	[FieldOffset(Offset = "0x124")]
	protected UIHudCrouchController m_CrounchCtrl;

	[Token(Token = "0x4013732")]
	[FieldOffset(Offset = "0x128")]
	protected UIHudCreepController m_CreepCtrl;

	[Token(Token = "0x4013733")]
	[FieldOffset(Offset = "0x12C")]
	protected UIHudJumpController m_JumpBtnCtrl;

	[Token(Token = "0x4013734")]
	[FieldOffset(Offset = "0x130")]
	protected UIHudObEventEntryController m_ObEventEntryCtrl;

	[Token(Token = "0x4013735")]
	[FieldOffset(Offset = "0x134")]
	protected UIHudObGlobalEventPollEntryController m_ObEventGlobalPollEntryCtrl;

	[Token(Token = "0x4013736")]
	[FieldOffset(Offset = "0x138")]
	protected UIHudObGlobalEventPanelController m_ObEventGlobalPanelCtrl;

	[Token(Token = "0x4013737")]
	[FieldOffset(Offset = "0x13C")]
	protected UIHudObLocallEventPanelController m_ObEventLocalPanelCtrl;

	[Token(Token = "0x4013738")]
	[FieldOffset(Offset = "0x140")]
	protected UIHudObGlobalEventPollController m_ObEventGlobalPollCtrl;

	[Token(Token = "0x4013739")]
	[FieldOffset(Offset = "0x144")]
	protected UIHudObGlobalEventActiveController m_ObEventGlobalActiveCtrl;

	[Token(Token = "0x401373A")]
	[FieldOffset(Offset = "0x148")]
	private UIHudTriggerDetailPopUpController m_EsportInfoCtrl;

	[Token(Token = "0x401373B")]
	[FieldOffset(Offset = "0x14C")]
	public UIHudQuitController m_TestHudQuitController;

	[Token(Token = "0x401373C")]
	[FieldOffset(Offset = "0x150")]
	protected bool mLoadingMaskClosed;

	[Token(Token = "0x401373D")]
	[FieldOffset(Offset = "0x151")]
	private bool m_IngameShopVisble;

	[Token(Token = "0x401373E")]
	[FieldOffset(Offset = "0x152")]
	private bool m_IngameAirDropShopVisble;

	[Token(Token = "0x401373F")]
	[FieldOffset(Offset = "0x154")]
	private GameObject m_VFXTeleportDoorBlackMask;

	[Token(Token = "0x4013740")]
	[FieldOffset(Offset = "0x158")]
	private UIHudTestRecipeController m_TestRecipeController;

	[Token(Token = "0x4013741")]
	[FieldOffset(Offset = "0x15C")]
	private UIHudTestSkateboardController m_TestSkateboardController;

	[Token(Token = "0x4013742")]
	[FieldOffset(Offset = "0x160")]
	protected UIHudWeaponInfoController m_HudWeaponInfoController;

	[Token(Token = "0x4013743")]
	[FieldOffset(Offset = "0x164")]
	private UIHudAssistantTextController m_HudAssistantTextController;

	[Token(Token = "0x4013744")]
	[FieldOffset(Offset = "0x168")]
	protected UIHudPickupListController m_HudPickUpListController;

	[Token(Token = "0x4013745")]
	[FieldOffset(Offset = "0x16C")]
	protected UIEquipSetSelectionController m_UIEquipSetSelectionController;

	[Token(Token = "0x4013746")]
	[FieldOffset(Offset = "0x170")]
	private UIHudItemMarkGridWndController m_HudItemMarkGridWndController;

	[Token(Token = "0x4013747")]
	[FieldOffset(Offset = "0x174")]
	private UIHudRangeShopController m_HudRangeShopController;

	[Token(Token = "0x4013748")]
	[FieldOffset(Offset = "0x178")]
	private UIHudCatagoryRangeShopController m_HudCatagoryRangeShopController;

	[Token(Token = "0x4013749")]
	[FieldOffset(Offset = "0x17C")]
	private UIHudPortalMaskController m_HudPortalMaskController;

	[Token(Token = "0x401374A")]
	[FieldOffset(Offset = "0x180")]
	private UIHudFriendAddController m_HudFriendAddController;

	[Token(Token = "0x401374B")]
	[FieldOffset(Offset = "0x184")]
	private UIHudFriendInviteController m_HudFriendInviteController;

	[Token(Token = "0x401374C")]
	[FieldOffset(Offset = "0x188")]
	private UIHudDriftBottleAddFriendController m_HudDriftBottleAddFriend;

	[Token(Token = "0x401374D")]
	[FieldOffset(Offset = "0x18C")]
	private UIHudTrainingConfirmController m_TrainingConfirmCtrl;

	[Token(Token = "0x401374E")]
	[FieldOffset(Offset = "0x190")]
	private UIHudAuxFireController m_AuxfireCtrl;

	[Token(Token = "0x401374F")]
	[FieldOffset(Offset = "0x194")]
	private UIHudSwapWeaponQuickController m_SweapWeaponQuickController;

	[Token(Token = "0x4013750")]
	[FieldOffset(Offset = "0x198")]
	private UIHudReloadBtnController m_ReloadBtnController;

	[Token(Token = "0x4013751")]
	[FieldOffset(Offset = "0x19C")]
	private UIHudTriggerGrenadeController m_TriggerGrenadeCtrl;

	[Token(Token = "0x4013752")]
	[FieldOffset(Offset = "0x1A0")]
	protected UIHudPreparationTimerController m_PrepareCtrl;

	[Token(Token = "0x4013753")]
	[FieldOffset(Offset = "0x1A4")]
	protected UIHudCrosshairsController m_CrossHairCtrl;

	[Token(Token = "0x4013754")]
	[FieldOffset(Offset = "0x1A8")]
	protected UIHudFireController m_FireController;

	[Token(Token = "0x4013755")]
	[FieldOffset(Offset = "0x1AC")]
	protected UIHudPlayerRemainingInfoController m_PlayerRemainingInfoCtrl;

	[Token(Token = "0x4013756")]
	[FieldOffset(Offset = "0x1B0")]
	protected UIHud2TeamsTimeScoreController m_UIHud2TeamsTimeScoreController;

	[Token(Token = "0x4013757")]
	[FieldOffset(Offset = "0x1B4")]
	public bool HasOpenMatchResultUI;

	[Token(Token = "0x4013758")]
	[FieldOffset(Offset = "0x1B8")]
	private UIHudInGameChatController m_UIHudInGameChatController;

	[Token(Token = "0x4013759")]
	[FieldOffset(Offset = "0x1BC")]
	private UIHudCSMatchInfoController m_CSMatchInfoInfoCtrl;

	[Token(Token = "0x401375A")]
	[FieldOffset(Offset = "0x1C0")]
	protected UIHudInGameShopController m_InGameShopCtrl;

	[Token(Token = "0x401375B")]
	[FieldOffset(Offset = "0x1C4")]
	protected UIHudInGameAirDropShopController m_InGameAirDropShopCtrl;

	[Token(Token = "0x401375C")]
	[FieldOffset(Offset = "0x1C8")]
	protected UIHudReviveSelectController m_ReviveSelectController;

	[Token(Token = "0x401375D")]
	[FieldOffset(Offset = "0x1CC")]
	protected UIHudChatBtnController m_ChatBtnController;

	[Token(Token = "0x401375E")]
	[FieldOffset(Offset = "0x1D0")]
	private bool m_IsMatchEendShow;

	[Token(Token = "0x401375F")]
	[FieldOffset(Offset = "0x1D4")]
	private UIHudUseRescureZoneProcessController m_UseRescureZoneProcess;

	[Token(Token = "0x4013760")]
	[FieldOffset(Offset = "0x1D8")]
	private UIHudFullScreenEffectController m_FullScreenEffect;

	[Token(Token = "0x4013761")]
	[FieldOffset(Offset = "0x1DC")]
	private UIHudGameMissionMiniInfoPanelController m_GameMissionMiniInfoPanel;

	[Token(Token = "0x4013762")]
	[FieldOffset(Offset = "0x1E0")]
	private EMapStateType m_MapState;

	[Token(Token = "0x4013763")]
	[FieldOffset(Offset = "0x1E4")]
	public readonly Vector3 fixedAuxFireButtonPox;

	[Token(Token = "0x4013764")]
	[FieldOffset(Offset = "0x1F0")]
	protected Transform m_UiHudPanelDynamic;

	[Token(Token = "0x4013765")]
	[FieldOffset(Offset = "0x1F4")]
	protected Transform m_UiHudPanelStatic;

	[Token(Token = "0x4013766")]
	[FieldOffset(Offset = "0x1F8")]
	private UIElitePassTopPlayerLeftWingController m_LeftWingCtrl;

	[Token(Token = "0x4013767")]
	[FieldOffset(Offset = "0x1FC")]
	private UIElitePassTopPlayerRightWingController m_RightWingCtrl;

	[Token(Token = "0x4013768")]
	[FieldOffset(Offset = "0x200")]
	private UIElitePassIngameHudRankingController m_EPHudRankingCtrl;

	[Token(Token = "0x4013769")]
	[FieldOffset(Offset = "0x204")]
	private UIHudJetFlyController m_JetFlyCtrl;

	[Token(Token = "0x401376A")]
	[FieldOffset(Offset = "0x208")]
	private UIHudJetFlyUpController m_JetFlyUpCtrl;

	[Token(Token = "0x401376B")]
	[FieldOffset(Offset = "0x20C")]
	private UIHudJetFlyDownController m_JetFlyDownCtrl;

	[Token(Token = "0x401376C")]
	[FieldOffset(Offset = "0x210")]
	protected UIHudSpeedupAreaController m_SpeedUpCtrl;

	[Token(Token = "0x401376D")]
	[FieldOffset(Offset = "0x214")]
	protected UIHudGameVoiceController m_GameVoiceCtrl;

	[Token(Token = "0x401376E")]
	[FieldOffset(Offset = "0x218")]
	private Coroutine m_OpenMatchResultCor;

	[Token(Token = "0x401376F")]
	[FieldOffset(Offset = "0x21C")]
	protected UIHudMovingJoystickController m_MoveJoyStickCtrl;

	[Token(Token = "0x4013770")]
	[FieldOffset(Offset = "0x220")]
	private UIHudBeHintedController m_HintedCtrl;

	[Token(Token = "0x4013771")]
	[FieldOffset(Offset = "0x224")]
	protected UIHudPlayerStatsController m_PlayerStatsCtrl;

	[Token(Token = "0x4013772")]
	[FieldOffset(Offset = "0x228")]
	private UIHudShowCaseIntroductionController m_ShowCaseIntroductionCtrl;

	[Token(Token = "0x4013773")]
	[FieldOffset(Offset = "0x22C")]
	private UIHUDPVEGameCountdownController m_TrainingEndCountDownCtrl;

	[Token(Token = "0x4013774")]
	[FieldOffset(Offset = "0x230")]
	private UIHudCommonPregameTimeTipController m_UIHudCommonPregameTimeTipController;

	[Token(Token = "0x4013775")]
	[FieldOffset(Offset = "0x234")]
	private UIHudGameMissionEffectController m_GameMissionEffectController;

	[Token(Token = "0x4013776")]
	[FieldOffset(Offset = "0x238")]
	private UGCInfectionChangePanelController m_UGCInfectionChangePanelController;

	[Token(Token = "0x4013777")]
	[FieldOffset(Offset = "0x23C")]
	private UIHUDUGC_IdentityGuideController m_UGCInfectionStrongerGuideController;

	[Token(Token = "0x4013778")]
	private const string InfectionStrongerToturial = "InfectionStronggerToturial_";

	[Token(Token = "0x4013779")]
	[FieldOffset(Offset = "0x240")]
	private GameObject m_UGCInfectionZombieShowVFX;

	[Token(Token = "0x401377A")]
	[FieldOffset(Offset = "0x244")]
	private uint m_InfectionVFXDelayCall;

	[Token(Token = "0x401377B")]
	[FieldOffset(Offset = "0x248")]
	private GameObject m_HudNoobPopup;

	[Token(Token = "0x401377C")]
	[FieldOffset(Offset = "0x24C")]
	private bool m_HadBasicPopShow;

	[Token(Token = "0x401377D")]
	[FieldOffset(Offset = "0x24D")]
	private bool m_LocalPlayerAdded;

	[Token(Token = "0x401377E")]
	[FieldOffset(Offset = "0x24E")]
	private bool m_PreloadLoaded;

	[Token(Token = "0x401377F")]
	[FieldOffset(Offset = "0x250")]
	private ResourceID m_CurPlayingOpeningSound;

	[Token(Token = "0x4013780")]
	[FieldOffset(Offset = "0x254")]
	private bool m_PauseUIOpened;

	[Token(Token = "0x4013781")]
	[FieldOffset(Offset = "0x255")]
	private bool _003CIsUsingStackKillNotification_003Ek__BackingField;

	[Token(Token = "0x4013782")]
	[FieldOffset(Offset = "0x256")]
	private bool m_DirverFireHudOpened;

	[Token(Token = "0x4013783")]
	[FieldOffset(Offset = "0x257")]
	private bool m_PassengerSkillHudOpened;

	[Token(Token = "0x4013784")]
	[FieldOffset(Offset = "0x258")]
	private float mLastLagHintPopupTime;

	[Token(Token = "0x4013785")]
	[FieldOffset(Offset = "0x25C")]
	private Dictionary<Vehicle, UIHudVehiclePosController> m_VehiclePositions;

	[Token(Token = "0x4013786")]
	[FieldOffset(Offset = "0x260")]
	private Dictionary<Entity, UIHudVehicleAsMissileTargetControllerBase> m_VehicleTargets;

	[Token(Token = "0x4013787")]
	[FieldOffset(Offset = "0x264")]
	private UIHudLockedWarningController m_LockedWarningController;

	[Token(Token = "0x4013788")]
	[FieldOffset(Offset = "0x268")]
	private Dictionary<IHAAMHPPLMG, UIBaseController> m_IdentityHud;

	[Token(Token = "0x4013789")]
	[FieldOffset(Offset = "0x26C")]
	private Dictionary<IHAAMHPPLMG, UIBaseController> m_InfectionHPHud;

	[Token(Token = "0x401378A")]
	[FieldOffset(Offset = "0x270")]
	private uint m_HideCSShopDelayCallID;

	[Token(Token = "0x401378B")]
	[FieldOffset(Offset = "0x274")]
	private Dictionary<Type, Queue<UIBaseController>> m_InGameUIPoolDic;

	[Token(Token = "0x401378C")]
	[FieldOffset(Offset = "0x278")]
	private UIHUDCommonEquipSetSelectionController m_CommonEquipSetSelectionCtrl;

	[Token(Token = "0x401378D")]
	[FieldOffset(Offset = "0x27C")]
	private UIHUDEquipUnlockLevelController m_EquipUnlockLevelController;

	[Token(Token = "0x401378E")]
	[FieldOffset(Offset = "0x280")]
	private UIHUDTeamKillController m_TeamKillController;

	[Token(Token = "0x401378F")]
	[FieldOffset(Offset = "0x284")]
	public UIHUDPlayerAttributeUpController m_AttributeUpController;

	[Token(Token = "0x4013790")]
	[FieldOffset(Offset = "0x288")]
	private bool m_HasOpenHudBeginFight;

	[Token(Token = "0x4013791")]
	[FieldOffset(Offset = "0x28C")]
	private EnterPhotographModeController m_EnterPhotographModeController;

	[Token(Token = "0x4013792")]
	[FieldOffset(Offset = "0x290")]
	private PhotographModeController m_PhotographModeController;

	[Token(Token = "0x4013793")]
	[FieldOffset(Offset = "0x294")]
	private UIHUDPhotographEmoteController m_PhotographEmoteController;

	[Token(Token = "0x4013794")]
	[FieldOffset(Offset = "0x298")]
	public LevelPhotograph CurrentLevelPhoto;

	[Token(Token = "0x4013795")]
	[FieldOffset(Offset = "0x2A0")]
	private ulong preEnterPhotographModeUIGroup;

	[Token(Token = "0x4013796")]
	[FieldOffset(Offset = "0x2A8")]
	private BountyBossHPController m_BountyBossHPController;

	[Token(Token = "0x4013797")]
	[FieldOffset(Offset = "0x2AC")]
	public bool m_TeamParachuteShowState;

	[Token(Token = "0x4013798")]
	[FieldOffset(Offset = "0x2B0")]
	private UIHUDTeamParachuteActionController m_TeamParachuteController;

	[Token(Token = "0x4013799")]
	[FieldOffset(Offset = "0x2B4")]
	private UIHUDCenterUpTitleController m_CenterUpTitleController;

	[Token(Token = "0x401379A")]
	[FieldOffset(Offset = "0x2B8")]
	private UIHudSafezonePosMarkController m_SafezonePosMarkCtrl;

	[Token(Token = "0x401379B")]
	[FieldOffset(Offset = "0x2BC")]
	private UIHudPresetController m_PresetCtrl;

	[Token(Token = "0x401379C")]
	[FieldOffset(Offset = "0x2C0")]
	private UIHudPresetEntryController m_PresetEntryCtrl;

	[Token(Token = "0x401379D")]
	public const int UIGroup_Num = 46;

	[Token(Token = "0x401379E")]
	[FieldOffset(Offset = "0x2C4")]
	protected Dictionary<Type, uint[]> GROUP_SETTING;

	[Token(Token = "0x401379F")]
	[FieldOffset(Offset = "0x0")]
	protected static Dictionary<Type, string> IngameHudConfigMapping;

	[Token(Token = "0x40137A0")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40137A1")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40137A2")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<UIBaseController> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40137A3")]
	[FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40137A4")]
	[FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40137A5")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40137A6")]
	[FieldOffset(Offset = "0x1C")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x170016BF")]
	public bool LoadingMaskClosed
	{
		[Token(Token = "0x6015946")]
		[Address(RVA = "0xD5D044", Offset = "0xD5D044", VA = "0xD5D044")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016C0")]
	public UIHudTestRecipeController TestRecipeController
	{
		[Token(Token = "0x6015947")]
		[Address(RVA = "0xD5D09C", Offset = "0xD5D09C", VA = "0xD5D09C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C1")]
	public UIHudTestSkateboardController TestSkateboardController
	{
		[Token(Token = "0x6015948")]
		[Address(RVA = "0xD5D0F4", Offset = "0xD5D0F4", VA = "0xD5D0F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C2")]
	public UIHudWeaponInfoController WeaponInfoController
	{
		[Token(Token = "0x6015949")]
		[Address(RVA = "0xD5D14C", Offset = "0xD5D14C", VA = "0xD5D14C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C3")]
	public UIHudAuxFireController AuxfireCtrl
	{
		[Token(Token = "0x601594A")]
		[Address(RVA = "0xD5D1A4", Offset = "0xD5D1A4", VA = "0xD5D1A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C4")]
	public UIHudSwapWeaponQuickController SweapWeaponQuickController
	{
		[Token(Token = "0x601594B")]
		[Address(RVA = "0xD5D1FC", Offset = "0xD5D1FC", VA = "0xD5D1FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C5")]
	public UIHudReloadBtnController ReloadBtnController
	{
		[Token(Token = "0x601594C")]
		[Address(RVA = "0xD5D254", Offset = "0xD5D254", VA = "0xD5D254")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C6")]
	public UIHudCrosshairsController CrossHairCtrl
	{
		[Token(Token = "0x601594D")]
		[Address(RVA = "0xD5D2AC", Offset = "0xD5D2AC", VA = "0xD5D2AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C7")]
	public UIHudFireController FireController
	{
		[Token(Token = "0x601594E")]
		[Address(RVA = "0xD5D304", Offset = "0xD5D304", VA = "0xD5D304")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C8")]
	public EMapStateType MapState
	{
		[Token(Token = "0x601594F")]
		[Address(RVA = "0xD5D35C", Offset = "0xD5D35C", VA = "0xD5D35C")]
		get
		{
			return default(EMapStateType);
		}
		[Token(Token = "0x6015950")]
		[Address(RVA = "0xD5D3B4", Offset = "0xD5D3B4", VA = "0xD5D3B4")]
		set
		{
		}
	}

	[Token(Token = "0x170016C9")]
	public Transform UiHudPanelDynamic
	{
		[Token(Token = "0x6015951")]
		[Address(RVA = "0xD5D414", Offset = "0xD5D414", VA = "0xD5D414")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016CA")]
	public Transform UiHudPanelStatic
	{
		[Token(Token = "0x6015952")]
		[Address(RVA = "0xD5D46C", Offset = "0xD5D46C", VA = "0xD5D46C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016CB")]
	public bool IsUsingStackKillNotification
	{
		[Token(Token = "0x6015953")]
		[Address(RVA = "0xD5D4C4", Offset = "0xD5D4C4", VA = "0xD5D4C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6015954")]
		[Address(RVA = "0xD5D4CC", Offset = "0xD5D4CC", VA = "0xD5D4CC")]
		set
		{
		}
	}

	[Token(Token = "0x6015945")]
	[Address(RVA = "0xD4F17C", Offset = "0xD4F17C", VA = "0xD4F17C")]
	public UIInGameScene()
	{
	}

	[Token(Token = "0x6015955")]
	[Address(RVA = "0xD5D4D4", Offset = "0xD5D4D4", VA = "0xD5D4D4", Slot = "15")]
	public virtual void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015956")]
	[Address(RVA = "0xD609E0", Offset = "0xD609E0", VA = "0xD609E0", Slot = "4")]
	public override void Destory()
	{
	}

	[Token(Token = "0x6015957")]
	[Address(RVA = "0xD60B5C", Offset = "0xD60B5C", VA = "0xD60B5C")]
	public void CloseMask(bool removeFakeLoading)
	{
	}

	[Token(Token = "0x6015958")]
	[Address(RVA = "0xD61320", Offset = "0xD61320", VA = "0xD61320")]
	private void OnEnterOrLeaveTriggerDetail(object[] data)
	{
	}

	[Token(Token = "0x6015959")]
	[Address(RVA = "0xD60DE8", Offset = "0xD60DE8", VA = "0xD60DE8")]
	private void CloseMaskInternal(object[] data)
	{
	}

	[Token(Token = "0x601595A")]
	[Address(RVA = "0xD6160C", Offset = "0xD6160C", VA = "0xD6160C", Slot = "16")]
	protected virtual void OnMaskClosed()
	{
	}

	[Token(Token = "0x601595B")]
	[Address(RVA = "0xD61668", Offset = "0xD61668", VA = "0xD61668")]
	private void SetAnchor(EUIAnchor anchor, Transform childTrans, Transform parentTrans)
	{
	}

	[Token(Token = "0x601595C")]
	[Address(RVA = "0xD61B44", Offset = "0xD61B44", VA = "0xD61B44")]
	public void InitHud()
	{
	}

	[Token(Token = "0x601595D")]
	[Address(RVA = "0xD62474", Offset = "0xD62474", VA = "0xD62474")]
	public void ShowOrHidePartyShoot(bool flag)
	{
	}

	[Token(Token = "0x601595E")]
	[Address(RVA = "0xD6269C", Offset = "0xD6269C", VA = "0xD6269C", Slot = "17")]
	public virtual void OpenHud()
	{
	}

	[Token(Token = "0x601595F")]
	[Address(RVA = "0xD65674", Offset = "0xD65674", VA = "0xD65674")]
	private void OpenReplayMatchIDUI(bool isMobileReplay)
	{
	}

	[Token(Token = "0x6015960")]
	[Address(RVA = "0xD65984", Offset = "0xD65984", VA = "0xD65984")]
	private void InitUIState()
	{
	}

	[Token(Token = "0x6015961")]
	[Address(RVA = "0xD65D20", Offset = "0xD65D20", VA = "0xD65D20", Slot = "18")]
	protected virtual void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015962")]
	[Address(RVA = "0xD6A2E8", Offset = "0xD6A2E8", VA = "0xD6A2E8")]
	public void OpenSafeZoneInfoCtrl()
	{
	}

	[Token(Token = "0x6015963")]
	[Address(RVA = "0xD6A634", Offset = "0xD6A634", VA = "0xD6A634")]
	public void OpenGameTokenUI()
	{
	}

	[Token(Token = "0x6015964")]
	[Address(RVA = "0xD6A738", Offset = "0xD6A738", VA = "0xD6A738")]
	public void OpenDriverFireHudInNeed()
	{
	}

	[Token(Token = "0x6015965")]
	[Address(RVA = "0xD6A898", Offset = "0xD6A898", VA = "0xD6A898")]
	public void OpenPassengerSkillHudInNeed()
	{
	}

	[Token(Token = "0x6015966")]
	[Address(RVA = "0xD6AA98", Offset = "0xD6AA98", VA = "0xD6AA98")]
	public bool CheckTriggerGrenadeShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6015967")]
	[Address(RVA = "0xD6AC24", Offset = "0xD6AC24", VA = "0xD6AC24")]
	public bool CheckAuxFireShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x6015968")]
	[Address(RVA = "0xD6ADB0", Offset = "0xD6ADB0", VA = "0xD6ADB0")]
	private UIBaseController OpenUI(Type uiBaseControllerType, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6015969")]
	[Address(RVA = "0xD65B34", Offset = "0xD65B34", VA = "0xD65B34")]
	public void RefreshJetFlyHudVisibility(object[] data)
	{
	}

	[Token(Token = "0x601596A")]
	[Address(RVA = "0xD6B380", Offset = "0xD6B380", VA = "0xD6B380", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601596B")]
	[Address(RVA = "0xD6BD8C", Offset = "0xD6BD8C", VA = "0xD6BD8C", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x601596C")]
	[Address(RVA = "0xD6F178", Offset = "0xD6F178", VA = "0xD6F178", Slot = "9")]
	protected override Transform FindUIRoot()
	{
		return null;
	}

	[Token(Token = "0x601596D")]
	[Address(RVA = "0xD6B628", Offset = "0xD6B628", VA = "0xD6B628")]
	protected Transform FindEPRoot()
	{
		return null;
	}

	[Token(Token = "0x601596E")]
	[Address(RVA = "0xD6F244", Offset = "0xD6F244", VA = "0xD6F244")]
	public void SetManualTips(string content)
	{
	}

	[Token(Token = "0x601596F")]
	[Address(RVA = "0xD6B73C", Offset = "0xD6B73C", VA = "0xD6B73C")]
	private void OpenWaitingRoomEPRanking(Transform EPRoot)
	{
	}

	[Token(Token = "0x6015970")]
	[Address(RVA = "0xD6B798", Offset = "0xD6B798", VA = "0xD6B798")]
	private void OpenMapOpenCountDown(Transform EPRoot)
	{
	}

	[Token(Token = "0x6015971")]
	[Address(RVA = "0xD6F500", Offset = "0xD6F500", VA = "0xD6F500")]
	public void ShowDynamicPopupMessage(string message, float duration = 5f)
	{
	}

	[Token(Token = "0x6015972")]
	[Address(RVA = "0xD6F698", Offset = "0xD6F698", VA = "0xD6F698")]
	public void ShowPopupMessage(string message, float duration = 2f)
	{
	}

	[Token(Token = "0x6015973")]
	[Address(RVA = "0xD6F830", Offset = "0xD6F830", VA = "0xD6F830")]
	public void ShowLagHintPopupMessage()
	{
	}

	[Token(Token = "0x6015974")]
	[Address(RVA = "0xD4DD18", Offset = "0xD4DD18", VA = "0xD4DD18")]
	public void ShowPopupMessageByDepth(string message, int depth, float duration = 2f)
	{
	}

	[Token(Token = "0x6015975")]
	[Address(RVA = "0xD6FA78", Offset = "0xD6FA78", VA = "0xD6FA78")]
	public void ShowSpecialPopupMessage(GameBannerInfo info, IHJOFJKFIBB z)
	{
	}

	[Token(Token = "0x6015976")]
	[Address(RVA = "0xD6FC10", Offset = "0xD6FC10", VA = "0xD6FC10")]
	public UIHudPopupController ShowPopupMessageWithoutAutoHide(string message)
	{
		return null;
	}

	[Token(Token = "0x6015977")]
	[Address(RVA = "0xD6FD4C", Offset = "0xD6FD4C", VA = "0xD6FD4C")]
	public void ShowLowPopupMessage(string message, float duration = 2f)
	{
	}

	[Token(Token = "0x6015978")]
	[Address(RVA = "0xD6FEE4", Offset = "0xD6FEE4", VA = "0xD6FEE4")]
	public void ShowCreditBehaviorPopupMessage(string message)
	{
	}

	[Token(Token = "0x6015979")]
	[Address(RVA = "0xD7006C", Offset = "0xD7006C", VA = "0xD7006C")]
	public void ClosePopup()
	{
	}

	[Token(Token = "0x601597A")]
	[Address(RVA = "0xD701E0", Offset = "0xD701E0", VA = "0xD701E0")]
	public void ClosePopupOnly()
	{
	}

	[Token(Token = "0x601597B")]
	[Address(RVA = "0xD702E4", Offset = "0xD702E4", VA = "0xD702E4")]
	private void OnShowCaseIntroductionVisbility(object[] data)
	{
	}

	[Token(Token = "0x601597C")]
	[Address(RVA = "0xD705E8", Offset = "0xD705E8", VA = "0xD705E8")]
	private bool CheckCanShowNoobPopup()
	{
		return default(bool);
	}

	[Token(Token = "0x601597D")]
	[Address(RVA = "0xD70640", Offset = "0xD70640", VA = "0xD70640")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x601597E")]
	[Address(RVA = "0xD72374", Offset = "0xD72374", VA = "0xD72374")]
	public bool ShowTutorialFightWithTeammate()
	{
		return default(bool);
	}

	[Token(Token = "0x601597F")]
	[Address(RVA = "0xD7255C", Offset = "0xD7255C", VA = "0xD7255C")]
	public void ShowChickenShowTimeUI([Optional] Action OnNormalMatchEnd, int rank = 0)
	{
	}

	[Token(Token = "0x6015980")]
	[Address(RVA = "0xD72850", Offset = "0xD72850", VA = "0xD72850")]
	private bool CanShowLoserAudio(int rank)
	{
		return default(bool);
	}

	[Token(Token = "0x6015981")]
	[Address(RVA = "0xD729E0", Offset = "0xD729E0", VA = "0xD729E0")]
	public void CloseChickenShowTimeUI()
	{
	}

	[Token(Token = "0x6015982")]
	[Address(RVA = "0xD72AE4", Offset = "0xD72AE4", VA = "0xD72AE4")]
	private void OnSwitchObserver(object[] param)
	{
	}

	[Token(Token = "0x6015983")]
	[Address(RVA = "0xD755C8", Offset = "0xD755C8", VA = "0xD755C8")]
	private void CheckStreamReady()
	{
	}

	[Token(Token = "0x6015984")]
	[Address(RVA = "0xD7575C", Offset = "0xD7575C", VA = "0xD7575C", Slot = "19")]
	protected virtual void CloseHUDMask()
	{
	}

	[Token(Token = "0x6015985")]
	[Address(RVA = "0xD75984", Offset = "0xD75984", VA = "0xD75984")]
	private void OnAddSpectator(object[] data)
	{
	}

	[Token(Token = "0x6015986")]
	[Address(RVA = "0xD759F0", Offset = "0xD759F0", VA = "0xD759F0")]
	private void OnAddObserver(object[] data)
	{
	}

	[Token(Token = "0x6015987")]
	[Address(RVA = "0xD75C38", Offset = "0xD75C38", VA = "0xD75C38")]
	private void OnRemovePlayer(object[] data)
	{
	}

	[Token(Token = "0x6015988")]
	[Address(RVA = "0xD76670", Offset = "0xD76670", VA = "0xD76670")]
	private void OnLocalPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x6015989")]
	[Address(RVA = "0xD775E8", Offset = "0xD775E8", VA = "0xD775E8")]
	private void OnMatchEnd(object[] data)
	{
	}

	[Token(Token = "0x601598A")]
	[Address(RVA = "0xD7675C", Offset = "0xD7675C", VA = "0xD7675C")]
	private void OnShowMatchResult(object[] data)
	{
	}

	[Token(Token = "0x601598B")]
	[Address(RVA = "0xD776D4", Offset = "0xD776D4", VA = "0xD776D4")]
	private bool NeedReleaseMemory(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x601598C")]
	[Address(RVA = "0xD77B9C", Offset = "0xD77B9C", VA = "0xD77B9C", Slot = "20")]
	protected virtual Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x601598D")]
	[Address(RVA = "0xD77920", Offset = "0xD77920", VA = "0xD77920")]
	private void OpenMatchResultUI(bool closeAll, bool releaseMemory, Type type, bool keepScene, bool createAvatar)
	{
	}

	[Token(Token = "0x601598E")]
	[Address(RVA = "0xD60A4C", Offset = "0xD60A4C", VA = "0xD60A4C")]
	private void StopOpenMatchResultCorInNeed()
	{
	}

	[Token(Token = "0x601598F")]
	[Address(RVA = "0xD77DA0", Offset = "0xD77DA0", VA = "0xD77DA0")]
	protected void RequestUnpackMatchResult()
	{
	}

	[Token(Token = "0x6015990")]
	[Address(RVA = "0xD77C78", Offset = "0xD77C78", VA = "0xD77C78")]
	private IEnumerator ReleaseMemoryAndOpenMatchResult(Type type, bool keepScene, bool createAvatar)
	{
		return null;
	}

	[Token(Token = "0x6015991")]
	[Address(RVA = "0xD77FCC", Offset = "0xD77FCC", VA = "0xD77FCC")]
	private static void PrintMemory(string label)
	{
	}

	[Token(Token = "0x6015992")]
	[Address(RVA = "0xD78448", Offset = "0xD78448", VA = "0xD78448", Slot = "21")]
	protected virtual void CloseAllUIs()
	{
	}

	[Token(Token = "0x6015993")]
	[Address(RVA = "0xD78850", Offset = "0xD78850", VA = "0xD78850", Slot = "22")]
	protected virtual void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x6015994")]
	[Address(RVA = "0xD78A10", Offset = "0xD78A10", VA = "0xD78A10")]
	private void AdjustHudApperance(Type t, Transform parent)
	{
	}

	[Token(Token = "0x6015995")]
	[Address(RVA = "0xD79574", Offset = "0xD79574", VA = "0xD79574")]
	public void ShowSpeedCtrl(bool flag)
	{
	}

	[Token(Token = "0x6015996")]
	[Address(RVA = "0xD79694", Offset = "0xD79694", VA = "0xD79694")]
	private void OnHudNormalSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x6015997")]
	[Address(RVA = "0xD79CB8", Offset = "0xD79CB8", VA = "0xD79CB8")]
	private void OnReportCheatClick(object[] param)
	{
	}

	[Token(Token = "0x6015998")]
	[Address(RVA = "0xD7A440", Offset = "0xD7A440", VA = "0xD7A440")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6015999")]
	[Address(RVA = "0xD7A53C", Offset = "0xD7A53C", VA = "0xD7A53C")]
	private void ShowBackToLobbyDialog()
	{
	}

	[Token(Token = "0x601599A")]
	[Address(RVA = "0xD7AAA0", Offset = "0xD7AAA0", VA = "0xD7AAA0")]
	private void OnUIQuitGameRequest(object[] param)
	{
	}

	[Token(Token = "0x601599B")]
	[Address(RVA = "0xD7A7E4", Offset = "0xD7A7E4", VA = "0xD7A7E4")]
	private void RequestQuitMatch(bool skipConfirm = false)
	{
	}

	[Token(Token = "0x601599C")]
	[Address(RVA = "0xD7BFE4", Offset = "0xD7BFE4", VA = "0xD7BFE4")]
	private void SpectaoQuitMatch(MatchGame game)
	{
	}

	[Token(Token = "0x601599D")]
	[Address(RVA = "0xD7AE34", Offset = "0xD7AE34", VA = "0xD7AE34")]
	private void RoomSpectatorRequestQuitMatch(MatchGame game, bool skipConfirm = false)
	{
	}

	[Token(Token = "0x601599E")]
	[Address(RVA = "0xD7AB84", Offset = "0xD7AB84", VA = "0xD7AB84")]
	private void ReplayQuitMatch(bool skipConfirm = false)
	{
	}

	[Token(Token = "0x601599F")]
	[Address(RVA = "0xD7C124", Offset = "0xD7C124", VA = "0xD7C124")]
	private bool IsCurrentGameDelayExitActivated()
	{
		return default(bool);
	}

	[Token(Token = "0x60159A0")]
	[Address(RVA = "0xD7B078", Offset = "0xD7B078", VA = "0xD7B078")]
	private void NormalPlayerRequestQuitMatch(MatchGame game, bool skipConfirm = false)
	{
	}

	[Token(Token = "0x60159A1")]
	[Address(RVA = "0xD7C478", Offset = "0xD7C478", VA = "0xD7C478")]
	private void OnAddDetector(object[] data)
	{
	}

	[Token(Token = "0x60159A2")]
	[Address(RVA = "0xD7C588", Offset = "0xD7C588", VA = "0xD7C588")]
	public void OnOpenTweenTips(object[] data)
	{
	}

	[Token(Token = "0x60159A3")]
	[Address(RVA = "0xD7C814", Offset = "0xD7C814", VA = "0xD7C814")]
	public void OnOpenBannerTweenTips(object[] data)
	{
	}

	[Token(Token = "0x60159A4")]
	[Address(RVA = "0xD7CB58", Offset = "0xD7CB58", VA = "0xD7CB58")]
	private void OnOpenTweenTipsWithIcon(object[] data)
	{
	}

	[Token(Token = "0x60159A5")]
	[Address(RVA = "0xD7CF64", Offset = "0xD7CF64", VA = "0xD7CF64")]
	public void OnLocalTeamFinishGame(object[] data)
	{
	}

	[Token(Token = "0x60159A6")]
	[Address(RVA = "0xD7D070", Offset = "0xD7D070", VA = "0xD7D070", Slot = "23")]
	protected virtual void SetEmotionPanelVisible(object[] param)
	{
	}

	[Token(Token = "0x60159A7")]
	[Address(RVA = "0xD7D270", Offset = "0xD7D270", VA = "0xD7D270")]
	private void CloseEmotionPanel(object[] param)
	{
	}

	[Token(Token = "0x60159A8")]
	[Address(RVA = "0xD7D4D8", Offset = "0xD7D4D8", VA = "0xD7D4D8")]
	private void SetMessagePanelVisible(object[] param)
	{
	}

	[Token(Token = "0x60159A9")]
	[Address(RVA = "0xD7D948", Offset = "0xD7D948", VA = "0xD7D948")]
	private void CloseMessagePanel(object[] param)
	{
	}

	[Token(Token = "0x60159AA")]
	[Address(RVA = "0xD7DA54", Offset = "0xD7DA54", VA = "0xD7DA54")]
	private void SetRouletteChatPanelVisible(object[] param)
	{
	}

	[Token(Token = "0x60159AB")]
	[Address(RVA = "0xD7DDEC", Offset = "0xD7DDEC", VA = "0xD7DDEC")]
	private void SetRouletteMedkitPanelVisible(object[] param)
	{
	}

	[Token(Token = "0x60159AC")]
	[Address(RVA = "0xD7E184", Offset = "0xD7E184", VA = "0xD7E184")]
	private void SetRouletteGrenadePanelVisible(object[] param)
	{
	}

	[Token(Token = "0x60159AD")]
	[Address(RVA = "0xD7E51C", Offset = "0xD7E51C", VA = "0xD7E51C")]
	private UIHudVehicleAsMissileTargetControllerBase OpenVehicleTargetUIInNeed(Entity e)
	{
		return null;
	}

	[Token(Token = "0x60159AE")]
	private T OpenVehicleUIInNeed<TKEY, T>(TKEY v, ref Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
	{
		return null;
	}

	[Token(Token = "0x60159AF")]
	private _00212 OpenVehicleUIInNeed<TKEY, T, TB>(TKEY v, ref Dictionary<TKEY, _00212> uis) where TKEY : Entity where T : _00212 where TB : UIHudVehiclePosControllerBase
	{
		return (_00212)null;
	}

	[Token(Token = "0x60159B0")]
	private T GetVehicleUI<TKEY, T>(TKEY v, Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
	{
		return null;
	}

	[Token(Token = "0x60159B1")]
	private void RecycleVehicleUI<TKEY, T>(TKEY v, T ui, Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
	{
	}

	[Token(Token = "0x60159B2")]
	[Address(RVA = "0xD7E624", Offset = "0xD7E624", VA = "0xD7E624")]
	private void OnPlayerGetOnVehicle(object[] data)
	{
	}

	[Token(Token = "0x60159B3")]
	[Address(RVA = "0xD7E7A0", Offset = "0xD7E7A0", VA = "0xD7E7A0")]
	private void CheckAndAddVehiclePosUIForPlayer(Player player)
	{
	}

	[Token(Token = "0x60159B4")]
	[Address(RVA = "0xD7EB3C", Offset = "0xD7EB3C", VA = "0xD7EB3C")]
	public void RecycleVehiclePosUI(Vehicle v, UIHudVehiclePosController ui)
	{
	}

	[Token(Token = "0x60159B5")]
	[Address(RVA = "0xD7EC18", Offset = "0xD7EC18", VA = "0xD7EC18")]
	private void OnMissileTargetChange(object[] data)
	{
	}

	[Token(Token = "0x60159B6")]
	[Address(RVA = "0xD7F38C", Offset = "0xD7F38C", VA = "0xD7F38C")]
	private void OnMissileAimingTargetChange(object[] data)
	{
	}

	[Token(Token = "0x60159B7")]
	[Address(RVA = "0xD7F750", Offset = "0xD7F750", VA = "0xD7F750")]
	public void RecycleMissileTargetUI(Entity v, UIHudVehicleAsMissileTargetControllerBase ui)
	{
	}

	[Token(Token = "0x60159B8")]
	[Address(RVA = "0xD7F82C", Offset = "0xD7F82C", VA = "0xD7F82C")]
	public void ShowInGameMovingStick(bool flag)
	{
	}

	[Token(Token = "0x60159B9")]
	[Address(RVA = "0xD7F94C", Offset = "0xD7F94C", VA = "0xD7F94C")]
	public void OnMatchResultScreenshotRequest(object[] data)
	{
	}

	[Token(Token = "0x60159BA")]
	[Address(RVA = "0xD7FCBC", Offset = "0xD7FCBC", VA = "0xD7FCBC")]
	private void OnLocalPlayerHitOthers(object[] data)
	{
	}

	[Token(Token = "0x60159BB")]
	[Address(RVA = "0xD807E4", Offset = "0xD807E4", VA = "0xD807E4")]
	private void OnLocalPlayerHitObjects(object[] data)
	{
	}

	[Token(Token = "0x60159BC")]
	[Address(RVA = "0xD80A40", Offset = "0xD80A40", VA = "0xD80A40")]
	private void OnLocalPlayerHitPosition(object[] data)
	{
	}

	[Token(Token = "0x60159BD")]
	[Address(RVA = "0xD80CEC", Offset = "0xD80CEC", VA = "0xD80CEC")]
	public void RecycleEnemyHudName(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159BE")]
	[Address(RVA = "0xD80F84", Offset = "0xD80F84", VA = "0xD80F84", Slot = "24")]
	protected virtual void AddTeammateHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159BF")]
	[Address(RVA = "0xD81290", Offset = "0xD81290", VA = "0xD81290")]
	public void RefreshFriendHudName(List<IHAAMHPPLMG> friends)
	{
	}

	[Token(Token = "0x60159C0")]
	[Address(RVA = "0xD819C4", Offset = "0xD819C4", VA = "0xD819C4")]
	public UIHudNameController GetTeamHudByPlayerID(IHAAMHPPLMG id)
	{
		return null;
	}

	[Token(Token = "0x60159C1")]
	[Address(RVA = "0xD81728", Offset = "0xD81728", VA = "0xD81728")]
	private void AddFriendHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159C2")]
	[Address(RVA = "0xD73DF4", Offset = "0xD73DF4", VA = "0xD73DF4")]
	private void RefreshTeammateHud(Dictionary<IHAAMHPPLMG, Player> teammates)
	{
	}

	[Token(Token = "0x60159C3")]
	[Address(RVA = "0xD81B6C", Offset = "0xD81B6C", VA = "0xD81B6C")]
	public void RecycleTeammateHudName(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159C4")]
	[Address(RVA = "0xD81E04", Offset = "0xD81E04", VA = "0xD81E04")]
	private void OnPlayerFactionChanged(object[] param)
	{
	}

	[Token(Token = "0x60159C5")]
	[Address(RVA = "0xD7196C", Offset = "0xD7196C", VA = "0xD7196C")]
	private void OnPlayerIdentityChanged(object[] param)
	{
	}

	[Token(Token = "0x60159C6")]
	[Address(RVA = "0xD74C5C", Offset = "0xD74C5C", VA = "0xD74C5C")]
	public void RefreshIdentityHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159C7")]
	[Address(RVA = "0xD81E60", Offset = "0xD81E60", VA = "0xD81E60")]
	private void BindIdentityHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159C8")]
	[Address(RVA = "0xD760B0", Offset = "0xD760B0", VA = "0xD760B0")]
	public void RecycleIdentiyHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159C9")]
	[Address(RVA = "0xD753D8", Offset = "0xD753D8", VA = "0xD753D8")]
	public void RefreshInfectionHPHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159CA")]
	[Address(RVA = "0xD71650", Offset = "0xD71650", VA = "0xD71650")]
	private void BindInfectionHPHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159CB")]
	[Address(RVA = "0xD76390", Offset = "0xD76390", VA = "0xD76390")]
	public void RecycleInfectionHPHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159CC")]
	[Address(RVA = "0xD82290", Offset = "0xD82290", VA = "0xD82290")]
	public void RecyleFriendHudName(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159CD")]
	[Address(RVA = "0xD82528", Offset = "0xD82528", VA = "0xD82528")]
	private void RefreshEnermyPoint(object[] data)
	{
	}

	[Token(Token = "0x60159CE")]
	[Address(RVA = "0xD82C78", Offset = "0xD82C78", VA = "0xD82C78")]
	private void RefreshIceWallNearbyEnemyPoint(object[] data)
	{
	}

	[Token(Token = "0x60159CF")]
	[Address(RVA = "0xD830B4", Offset = "0xD830B4", VA = "0xD830B4")]
	private void RefreshCuringEnemyPoint(object[] data)
	{
	}

	[Token(Token = "0x60159D0")]
	[Address(RVA = "0xD8373C", Offset = "0xD8373C", VA = "0xD8373C")]
	public void RefreshBanAvtiveSkillPoint(object[] data)
	{
	}

	[Token(Token = "0x60159D1")]
	[Address(RVA = "0xD83F50", Offset = "0xD83F50", VA = "0xD83F50")]
	public void RecycleBanAvtiveSkillPoint(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159D2")]
	[Address(RVA = "0xD84144", Offset = "0xD84144", VA = "0xD84144")]
	public void ClearAllMarkIceWallNearbyEnemyPoint(object[] data)
	{
	}

	[Token(Token = "0x60159D3")]
	[Address(RVA = "0xD8455C", Offset = "0xD8455C", VA = "0xD8455C")]
	public void RefreshDeliverySkillMarkEnemyPoint(object[] data)
	{
	}

	[Token(Token = "0x60159D4")]
	[Address(RVA = "0xD84840", Offset = "0xD84840", VA = "0xD84840")]
	public void ShowDeliveryMarkEnemyPoint(object[] data)
	{
	}

	[Token(Token = "0x60159D5")]
	[Address(RVA = "0xD84D20", Offset = "0xD84D20", VA = "0xD84D20")]
	public void RecycleDeliveryMarkEnemyPoint(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159D6")]
	[Address(RVA = "0xD84368", Offset = "0xD84368", VA = "0xD84368")]
	public void RecycleIceWallNearbyEnemyPoint(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159D7")]
	[Address(RVA = "0xD84F14", Offset = "0xD84F14", VA = "0xD84F14")]
	public void RecycleEnermyPoint(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159D8")]
	[Address(RVA = "0xD85108", Offset = "0xD85108", VA = "0xD85108")]
	public void RecycleCuringEnemyPoint(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159D9")]
	[Address(RVA = "0xD852FC", Offset = "0xD852FC", VA = "0xD852FC")]
	public void RefreshRevengeInfoPoint(IHAAMHPPLMG playerID, bool visible)
	{
	}

	[Token(Token = "0x60159DA")]
	[Address(RVA = "0xD855F8", Offset = "0xD855F8", VA = "0xD855F8")]
	public void RecycleRevengeInfoPoint(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159DB")]
	[Address(RVA = "0xD75D7C", Offset = "0xD75D7C", VA = "0xD75D7C")]
	internal void RemoveNameHud(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x60159DC")]
	[Address(RVA = "0xD857EC", Offset = "0xD857EC", VA = "0xD857EC")]
	private void ShowAirEPTopPlayer(object[] param)
	{
	}

	[Token(Token = "0x60159DD")]
	[Address(RVA = "0xD85B1C", Offset = "0xD85B1C", VA = "0xD85B1C")]
	private void HideEPRanking(object[] param)
	{
	}

	[Token(Token = "0x60159DE")]
	[Address(RVA = "0xD85D08", Offset = "0xD85D08", VA = "0xD85D08")]
	private void ShowHudElitePass(object[] param)
	{
	}

	[Token(Token = "0x60159DF")]
	[Address(RVA = "0xD85E64", Offset = "0xD85E64", VA = "0xD85E64")]
	public void OnRedEnvelopeUsed(object[] param)
	{
	}

	[Token(Token = "0x60159E0")]
	[Address(RVA = "0xD8615C", Offset = "0xD8615C", VA = "0xD8615C")]
	public void OnRedEnvelopeReceived(object[] param)
	{
	}

	[Token(Token = "0x60159E1")]
	[Address(RVA = "0xD865A8", Offset = "0xD865A8", VA = "0xD865A8")]
	public void OnRedEnvelopeReceiveHudDismiss(object[] param)
	{
	}

	[Token(Token = "0x60159E2")]
	[Address(RVA = "0xD8033C", Offset = "0xD8033C", VA = "0xD8033C")]
	public void OnHypeRelatedPlayerHit(IHAAMHPPLMG pID, int level)
	{
	}

	[Token(Token = "0x60159E3")]
	[Address(RVA = "0xD86710", Offset = "0xD86710", VA = "0xD86710")]
	private void OnAddPet(object[] data)
	{
	}

	[Token(Token = "0x60159E4")]
	[Address(RVA = "0xD86A24", Offset = "0xD86A24", VA = "0xD86A24")]
	private void OnPreloadLoaded(object[] data)
	{
	}

	[Token(Token = "0x60159E5")]
	[Address(RVA = "0xD718E8", Offset = "0xD718E8", VA = "0xD718E8")]
	private void CheckToCloseHUDMask()
	{
	}

	[Token(Token = "0x60159E6")]
	[Address(RVA = "0xD86B34", Offset = "0xD86B34", VA = "0xD86B34")]
	private void OnJoinedVoiceRoom(object[] data)
	{
	}

	[Token(Token = "0x60159E7")]
	[Address(RVA = "0xD86D58", Offset = "0xD86D58", VA = "0xD86D58")]
	private void OnNotifyBeHinted(object[] data)
	{
	}

	[Token(Token = "0x60159E8")]
	[Address(RVA = "0xD86FC8", Offset = "0xD86FC8", VA = "0xD86FC8")]
	private void OnPVEBuyReviveSuccess(object[] param)
	{
	}

	[Token(Token = "0x60159E9")]
	[Address(RVA = "0xD871F8", Offset = "0xD871F8", VA = "0xD871F8")]
	private void OnPlayerLanding(object[] param)
	{
	}

	[Token(Token = "0x60159EA")]
	[Address(RVA = "0xD87254", Offset = "0xD87254", VA = "0xD87254")]
	private void ShowCommonRewardWnd(object[] data)
	{
	}

	[Token(Token = "0x60159EB")]
	[Address(RVA = "0xD873DC", Offset = "0xD873DC", VA = "0xD873DC")]
	private void HidePVEReviveUI(object[] param)
	{
	}

	[Token(Token = "0x60159EC")]
	[Address(RVA = "0xD874E8", Offset = "0xD874E8", VA = "0xD874E8", Slot = "25")]
	protected virtual void OnPlayerGodBegin(object[] param)
	{
	}

	[Token(Token = "0x60159ED")]
	[Address(RVA = "0xD876C4", Offset = "0xD876C4", VA = "0xD876C4")]
	public void DisableMask()
	{
	}

	[Token(Token = "0x60159EE")]
	[Address(RVA = "0xD877C4", Offset = "0xD877C4", VA = "0xD877C4")]
	private void ShowBlackMaskAnim(object[] param)
	{
	}

	[Token(Token = "0x60159EF")]
	[Address(RVA = "0xD87ACC", Offset = "0xD87ACC", VA = "0xD87ACC")]
	protected void ShowLeaderboard(object[] data)
	{
	}

	[Token(Token = "0x60159F0")]
	[Address(RVA = "0xD87BD8", Offset = "0xD87BD8", VA = "0xD87BD8", Slot = "26")]
	protected virtual void ShowCSShop(object[] data)
	{
	}

	[Token(Token = "0x60159F1")]
	[Address(RVA = "0xD87F1C", Offset = "0xD87F1C", VA = "0xD87F1C", Slot = "27")]
	protected virtual void ShowCSShopProcess()
	{
	}

	[Token(Token = "0x60159F2")]
	[Address(RVA = "0xD880C0", Offset = "0xD880C0", VA = "0xD880C0")]
	private void OnMysteryBoxOpen(object[] data)
	{
	}

	[Token(Token = "0x60159F3")]
	[Address(RVA = "0xD88760", Offset = "0xD88760", VA = "0xD88760")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x60159F4")]
	[Address(RVA = "0xD88E00", Offset = "0xD88E00", VA = "0xD88E00")]
	private void OnInGameShopItemsReady(object[] data)
	{
	}

	[Token(Token = "0x60159F5")]
	[Address(RVA = "0xD88F80", Offset = "0xD88F80", VA = "0xD88F80")]
	private void OnInGameAidDropShopItemsReady(object[] data)
	{
	}

	[Token(Token = "0x60159F6")]
	[Address(RVA = "0xD89100", Offset = "0xD89100", VA = "0xD89100")]
	private void OnRangeShopShowed(object[] data)
	{
	}

	[Token(Token = "0x60159F7")]
	[Address(RVA = "0xD893BC", Offset = "0xD893BC", VA = "0xD893BC")]
	private void OnCatagoryRangeShopShowed(object[] data)
	{
	}

	[Token(Token = "0x60159F8")]
	[Address(RVA = "0xD89B28", Offset = "0xD89B28", VA = "0xD89B28")]
	private void OnCatagoryRangeShopHided(object[] data)
	{
	}

	[Token(Token = "0x60159F9")]
	[Address(RVA = "0xD89C34", Offset = "0xD89C34", VA = "0xD89C34")]
	public bool TryOpenCacheShop(uint ShopID)
	{
		return default(bool);
	}

	[Token(Token = "0x60159FA")]
	[Address(RVA = "0xD89E44", Offset = "0xD89E44", VA = "0xD89E44")]
	protected void OnShowPortalMask(object[] data)
	{
	}

	[Token(Token = "0x60159FB")]
	[Address(RVA = "0xD8A2CC", Offset = "0xD8A2CC", VA = "0xD8A2CC")]
	private void OnShowWarningZone(object[] data)
	{
	}

	[Token(Token = "0x60159FC")]
	[Address(RVA = "0xD8A6F0", Offset = "0xD8A6F0", VA = "0xD8A6F0")]
	private void OnResetInGameShopUI(object[] data)
	{
	}

	[Token(Token = "0x60159FD")]
	[Address(RVA = "0xD8A89C", Offset = "0xD8A89C", VA = "0xD8A89C")]
	private void OnShowReviveSelect(object[] data)
	{
	}

	[Token(Token = "0x60159FE")]
	[Address(RVA = "0xD8AFC8", Offset = "0xD8AFC8", VA = "0xD8AFC8")]
	private void OnShowRevivePoint(object[] param)
	{
	}

	[Token(Token = "0x60159FF")]
	[Address(RVA = "0xD8B368", Offset = "0xD8B368", VA = "0xD8B368")]
	private void OnRevivePointStateChanged(object[] param)
	{
	}

	[Token(Token = "0x6015A00")]
	[Address(RVA = "0xD8B4EC", Offset = "0xD8B4EC", VA = "0xD8B4EC")]
	private void OnRevivePointTimeChanged(object[] param)
	{
	}

	[Token(Token = "0x6015A01")]
	[Address(RVA = "0xD8B670", Offset = "0xD8B670", VA = "0xD8B670")]
	private void OnShowInGameChat(object[] data)
	{
	}

	[Token(Token = "0x6015A02")]
	[Address(RVA = "0xD8BD50", Offset = "0xD8BD50", VA = "0xD8BD50")]
	private void OnShowAddFriendInfo(object[] data)
	{
	}

	[Token(Token = "0x6015A03")]
	[Address(RVA = "0xD8BF6C", Offset = "0xD8BF6C", VA = "0xD8BF6C")]
	public bool FriendInviteIsShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A04")]
	[Address(RVA = "0xD8C074", Offset = "0xD8C074", VA = "0xD8C074")]
	public void ShowInviteFriendInfo(ulong user_id)
	{
	}

	[Token(Token = "0x6015A05")]
	[Address(RVA = "0xD8C300", Offset = "0xD8C300", VA = "0xD8C300")]
	public void OnShowDriftBottleAddFriend(object[] param)
	{
	}

	[Token(Token = "0x6015A06")]
	[Address(RVA = "0xD8C668", Offset = "0xD8C668", VA = "0xD8C668")]
	private void OnTrainingZoneChanged(object[] data)
	{
	}

	[Token(Token = "0x6015A07")]
	[Address(RVA = "0xD8D3A0", Offset = "0xD8D3A0", VA = "0xD8D3A0")]
	private void RefreshTeammateNameVisible(Player lp)
	{
	}

	[Token(Token = "0x6015A08")]
	[Address(RVA = "0xD8D030", Offset = "0xD8D030", VA = "0xD8D030")]
	private void RefreshPlayerRemainingVisble(IHJOFJKFIBB z)
	{
	}

	[Token(Token = "0x6015A09")]
	[Address(RVA = "0xD8CA20", Offset = "0xD8CA20", VA = "0xD8CA20")]
	private void ShowEnterTrainingZoneTip(IHJOFJKFIBB z)
	{
	}

	[Token(Token = "0x6015A0A")]
	[Address(RVA = "0xD8DAF8", Offset = "0xD8DAF8", VA = "0xD8DAF8")]
	private void OnTrainingShopBuySucess(object[] data)
	{
	}

	[Token(Token = "0x6015A0B")]
	[Address(RVA = "0xD8DD9C", Offset = "0xD8DD9C", VA = "0xD8DD9C")]
	private void OnTrainingShowCountDown(object[] data)
	{
	}

	[Token(Token = "0x6015A0C")]
	[Address(RVA = "0xD8E0D4", Offset = "0xD8E0D4", VA = "0xD8E0D4")]
	private void OnGameOpeningStart(object[] data)
	{
	}

	[Token(Token = "0x6015A0D")]
	[Address(RVA = "0xD8E630", Offset = "0xD8E630", VA = "0xD8E630")]
	private void OnGameOpeningEnd(object[] data)
	{
	}

	[Token(Token = "0x6015A0E")]
	[Address(RVA = "0xD8EDA0", Offset = "0xD8EDA0", VA = "0xD8EDA0")]
	private void OnGameOpeningPlaySound(object[] data)
	{
	}

	[Token(Token = "0x6015A0F")]
	[Address(RVA = "0xD8EDFC", Offset = "0xD8EDFC", VA = "0xD8EDFC")]
	private void OnUnloadUnusedAudios(object[] data)
	{
	}

	[Token(Token = "0x6015A10")]
	[Address(RVA = "0xD8EF40", Offset = "0xD8EF40", VA = "0xD8EF40")]
	public void ShowEventTriggerUIWithPlayer(IHAAMHPPLMG id, InGameTriggerMaskData data)
	{
	}

	[Token(Token = "0x6015A11")]
	[Address(RVA = "0xD8F128", Offset = "0xD8F128", VA = "0xD8F128")]
	public void ClearEventTriggerUIWithPlayer(IHAAMHPPLMG id, InGameTriggerMaskData data)
	{
	}

	[Token(Token = "0x6015A12")]
	[Address(RVA = "0xD8F3DC", Offset = "0xD8F3DC", VA = "0xD8F3DC")]
	public bool CheckPrepareIsIng()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A13")]
	[Address(RVA = "0xD8F4FC", Offset = "0xD8F4FC", VA = "0xD8F4FC")]
	public EPreparationTimerType GetPrepareContextType()
	{
		return default(EPreparationTimerType);
	}

	[Token(Token = "0x6015A14")]
	[Address(RVA = "0xD8F5FC", Offset = "0xD8F5FC", VA = "0xD8F5FC")]
	private Dictionary<IHAAMHPPLMG, UIHudItemMarkShowController> GetMarkDic(DLPJLPIHNCL itemMarkType)
	{
		return null;
	}

	[Token(Token = "0x6015A15")]
	[Address(RVA = "0xD8F668", Offset = "0xD8F668", VA = "0xD8F668")]
	public void ShowMarkItemUIWithWorldPosition(IHAAMHPPLMG id, DLPJLPIHNCL itemMarkType, string markName, uint itemMarkId, uint levelObjectId, Vector3 itemPosition)
	{
	}

	[Token(Token = "0x6015A16")]
	[Address(RVA = "0xD8F9BC", Offset = "0xD8F9BC", VA = "0xD8F9BC")]
	public void RemoveMarkItemShow(IHAAMHPPLMG id, DLPJLPIHNCL itemMarkType, uint itemMarkId, uint levelObjectId)
	{
	}

	[Token(Token = "0x6015A17")]
	[Address(RVA = "0xD8FBA8", Offset = "0xD8FBA8", VA = "0xD8FBA8")]
	public void ForceRemoveMarkItemShow(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x6015A18")]
	[Address(RVA = "0xD8FF34", Offset = "0xD8FF34", VA = "0xD8FF34")]
	public void ShowMarkItemChooseListWindow(LevelContainerBase container)
	{
	}

	[Token(Token = "0x6015A19")]
	[Address(RVA = "0xD900BC", Offset = "0xD900BC", VA = "0xD900BC")]
	public void ShowAssistantText(string playerName, string line)
	{
	}

	[Token(Token = "0x6015A1A")]
	[Address(RVA = "0xD90254", Offset = "0xD90254", VA = "0xD90254")]
	public void ShowEventTriggerUIWithWorldPosition(Vector3 followObjectPosition, InGameTriggerMaskData data)
	{
	}

	[Token(Token = "0x6015A1B")]
	[Address(RVA = "0xD903BC", Offset = "0xD903BC", VA = "0xD903BC")]
	public GameObject GetSpeedUpCollider()
	{
		return null;
	}

	[Token(Token = "0x6015A1C")]
	[Address(RVA = "0xD87D20", Offset = "0xD87D20", VA = "0xD87D20")]
	public void HideCSShop()
	{
	}

	[Token(Token = "0x6015A1D")]
	[Address(RVA = "0xD65564", Offset = "0xD65564", VA = "0xD65564")]
	private bool NeedUseNewRoundTransition()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A1E")]
	[Address(RVA = "0xD904BC", Offset = "0xD904BC", VA = "0xD904BC")]
	protected void ShowCSRoundResult(object[] data)
	{
	}

	[Token(Token = "0x6015A1F")]
	[Address(RVA = "0xD90990", Offset = "0xD90990", VA = "0xD90990")]
	protected void ShowCSRoundSpectatorResult(object[] data)
	{
	}

	[Token(Token = "0x6015A20")]
	[Address(RVA = "0xD909EC", Offset = "0xD909EC", VA = "0xD909EC")]
	private void OnSpectatorPlayerFlashed(object[] data)
	{
	}

	[Token(Token = "0x6015A21")]
	[Address(RVA = "0xD90C2C", Offset = "0xD90C2C", VA = "0xD90C2C")]
	private void OnRefreshKokPlayer(object[] data)
	{
	}

	[Token(Token = "0x6015A22")]
	[Address(RVA = "0xD90F74", Offset = "0xD90F74", VA = "0xD90F74")]
	private void OnShowKokPlayer(object[] data)
	{
	}

	[Token(Token = "0x6015A23")]
	[Address(RVA = "0xD911BC", Offset = "0xD911BC", VA = "0xD911BC")]
	private void OnShowWhiteScreen(object[] ps)
	{
	}

	[Token(Token = "0x6015A24")]
	public T GetUIControllerFromPool<T>(EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015A25")]
	public T GetUIControllerFromPoolNoCreate<T>() where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015A26")]
	public void RecycleUIController<T>(T uicontroller) where T : UIBaseController
	{
	}

	[Token(Token = "0x6015A27")]
	[Address(RVA = "0xD913CC", Offset = "0xD913CC", VA = "0xD913CC")]
	protected void ShowEquipSetSelection(object[] param)
	{
	}

	[Token(Token = "0x6015A28")]
	[Address(RVA = "0xD917FC", Offset = "0xD917FC", VA = "0xD917FC")]
	protected void ShowEquipSetSelectionBtn(object[] param)
	{
	}

	[Token(Token = "0x6015A29")]
	[Address(RVA = "0xD91958", Offset = "0xD91958", VA = "0xD91958")]
	protected void OnSelectEquipSet(object[] param)
	{
	}

	[Token(Token = "0x6015A2A")]
	[Address(RVA = "0xD91AAC", Offset = "0xD91AAC", VA = "0xD91AAC")]
	private void ShowOrHideAllUI(object[] param)
	{
	}

	[Token(Token = "0x6015A2B")]
	[Address(RVA = "0xD91DFC", Offset = "0xD91DFC", VA = "0xD91DFC")]
	private void OnSecondConfirmShowed(object[] param)
	{
	}

	[Token(Token = "0x6015A2C")]
	[Address(RVA = "0xD91F98", Offset = "0xD91F98", VA = "0xD91F98")]
	private void OnShowUseRescureZoneProcess(object[] data)
	{
	}

	[Token(Token = "0x6015A2D")]
	[Address(RVA = "0xD9211C", Offset = "0xD9211C", VA = "0xD9211C")]
	private void OnShowHealingGunScreenEffect(object[] data)
	{
	}

	[Token(Token = "0x6015A2E")]
	[Address(RVA = "0xD922F8", Offset = "0xD922F8", VA = "0xD922F8")]
	private void OnShowInfectionChangePanel(object[] data)
	{
	}

	[Token(Token = "0x6015A2F")]
	[Address(RVA = "0xD924EC", Offset = "0xD924EC", VA = "0xD924EC")]
	private void OnCloseInfectionChangePanel(object[] data)
	{
	}

	[Token(Token = "0x6015A30")]
	[Address(RVA = "0xD925F0", Offset = "0xD925F0", VA = "0xD925F0")]
	private void OnShowInfectionStrongerToturial(object[] data)
	{
	}

	[Token(Token = "0x6015A31")]
	[Address(RVA = "0xD92ACC", Offset = "0xD92ACC", VA = "0xD92ACC")]
	private void OnSelfIdentityChanged(object[] data)
	{
	}

	[Token(Token = "0x6015A32")]
	[Address(RVA = "0xD92E88", Offset = "0xD92E88", VA = "0xD92E88")]
	private void OpenLocalEventPanel(object[] data)
	{
	}

	[Token(Token = "0x6015A33")]
	[Address(RVA = "0xD93214", Offset = "0xD93214", VA = "0xD93214")]
	private void OpenGlobalEventPanel(object[] data)
	{
	}

	[Token(Token = "0x6015A34")]
	[Address(RVA = "0xD93594", Offset = "0xD93594", VA = "0xD93594")]
	private void ShowPollEntry(object[] data)
	{
	}

	[Token(Token = "0x6015A35")]
	[Address(RVA = "0xD937B4", Offset = "0xD937B4", VA = "0xD937B4")]
	private void OpenGlobalEventPoll(object[] data)
	{
	}

	[Token(Token = "0x6015A36")]
	[Address(RVA = "0xD9398C", Offset = "0xD9398C", VA = "0xD9398C")]
	private void OnDebugBeforeShowEnemy(object[] param)
	{
	}

	[Token(Token = "0x6015A37")]
	[Address(RVA = "0xD93CC4", Offset = "0xD93CC4", VA = "0xD93CC4")]
	public ResourceID GetDamageNumResId()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015A38")]
	[Address(RVA = "0xD93E04", Offset = "0xD93E04", VA = "0xD93E04")]
	public GameObject GetDamageNumObject([Optional] Transform root)
	{
		return null;
	}

	[Token(Token = "0x6015A39")]
	[Address(RVA = "0xD93FCC", Offset = "0xD93FCC", VA = "0xD93FCC")]
	public void RecycleDamageNumObject(GameObject numObject)
	{
	}

	[Token(Token = "0x6015A3A")]
	[Address(RVA = "0xD6BA40", Offset = "0xD6BA40", VA = "0xD6BA40")]
	private void PreLoadDamageNumObject()
	{
	}

	[Token(Token = "0x6015A3B")]
	[Address(RVA = "0xD6BB20", Offset = "0xD6BB20", VA = "0xD6BB20")]
	private void PreInstantHudName()
	{
	}

	[Token(Token = "0x6015A3C")]
	[Address(RVA = "0xD94264", Offset = "0xD94264", VA = "0xD94264")]
	public bool GetPickUpInScroll()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A3D")]
	[Address(RVA = "0xD94364", Offset = "0xD94364", VA = "0xD94364")]
	public int GetPickUpListGridDepth()
	{
		return default(int);
	}

	[Token(Token = "0x6015A3E")]
	[Address(RVA = "0xD943DC", Offset = "0xD943DC", VA = "0xD943DC", Slot = "28")]
	protected virtual UIHudWeaponInfoController OpenCommonWeaponPanel()
	{
		return null;
	}

	[Token(Token = "0x6015A3F")]
	[Address(RVA = "0xD9448C", Offset = "0xD9448C", VA = "0xD9448C", Slot = "29")]
	protected virtual bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A40")]
	[Address(RVA = "0xD9495C", Offset = "0xD9495C", VA = "0xD9495C", Slot = "30")]
	protected virtual bool IsNeedQuickSwitchHUD()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A41")]
	[Address(RVA = "0xD94A28", Offset = "0xD94A28", VA = "0xD94A28", Slot = "31")]
	protected virtual bool IsNeedMedkitController()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A42")]
	[Address(RVA = "0xD94B78", Offset = "0xD94B78", VA = "0xD94B78", Slot = "32")]
	protected virtual bool IsNeedSideWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A43")]
	[Address(RVA = "0xD94C44", Offset = "0xD94C44", VA = "0xD94C44", Slot = "33")]
	protected virtual bool IsNeedPlayerStats()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A44")]
	[Address(RVA = "0xD94D10", Offset = "0xD94D10", VA = "0xD94D10", Slot = "34")]
	protected virtual bool IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A45")]
	[Address(RVA = "0xD6A438", Offset = "0xD6A438", VA = "0xD6A438")]
	private bool IsNeedShowGamePhaseCountdownUI()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A46")]
	[Address(RVA = "0xD95120", Offset = "0xD95120", VA = "0xD95120", Slot = "35")]
	public virtual void ShowCommonEquipSelectionController(bool show, int defaultSelectIndex, float showTime)
	{
	}

	[Token(Token = "0x6015A47")]
	[Address(RVA = "0xD952F8", Offset = "0xD952F8", VA = "0xD952F8", Slot = "36")]
	public virtual void ShowEquipUnlockLevelController(bool show, float showTime)
	{
	}

	[Token(Token = "0x6015A48")]
	[Address(RVA = "0xD95488", Offset = "0xD95488", VA = "0xD95488")]
	public void ShowTeamKill(float showTime)
	{
	}

	[Token(Token = "0x6015A49")]
	[Address(RVA = "0xD95614", Offset = "0xD95614", VA = "0xD95614")]
	public void ShowPlayerAttributeUP(string msg)
	{
	}

	[Token(Token = "0x6015A4A")]
	[Address(RVA = "0xD957A4", Offset = "0xD957A4", VA = "0xD957A4")]
	public void GamePhaseChange(uint curPhase, float leftTime, bool isExitPregame)
	{
	}

	[Token(Token = "0x6015A4B")]
	[Address(RVA = "0xD95AB4", Offset = "0xD95AB4", VA = "0xD95AB4", Slot = "37")]
	protected virtual void OnGamePhaseChange(uint curPhase, float leftTime)
	{
	}

	[Token(Token = "0x6015A4C")]
	[Address(RVA = "0xD95888", Offset = "0xD95888", VA = "0xD95888")]
	private void OpenHudInPregame()
	{
	}

	[Token(Token = "0x6015A4D")]
	[Address(RVA = "0xD959A4", Offset = "0xD959A4", VA = "0xD959A4")]
	private void CloseHudInPregame()
	{
	}

	[Token(Token = "0x6015A4E")]
	[Address(RVA = "0xD95B24", Offset = "0xD95B24", VA = "0xD95B24", Slot = "38")]
	protected virtual void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015A4F")]
	[Address(RVA = "0xD95B78", Offset = "0xD95B78", VA = "0xD95B78", Slot = "39")]
	protected virtual void OnClosePregameHud()
	{
	}

	[Token(Token = "0x6015A50")]
	[Address(RVA = "0xD95BCC", Offset = "0xD95BCC", VA = "0xD95BCC", Slot = "40")]
	protected virtual void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015A51")]
	[Address(RVA = "0xD95C20", Offset = "0xD95C20", VA = "0xD95C20", Slot = "41")]
	protected virtual Type GetMatchEndShowHUD()
	{
		return null;
	}

	[Token(Token = "0x6015A52")]
	[Address(RVA = "0xD95CFC", Offset = "0xD95CFC", VA = "0xD95CFC")]
	public void AdjustChatHudByCustomRoomSetting(bool show)
	{
	}

	[Token(Token = "0x6015A53")]
	[Address(RVA = "0xD95E18", Offset = "0xD95E18", VA = "0xD95E18", Slot = "42")]
	protected virtual bool ShowChatBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A54")]
	[Address(RVA = "0xD95E70", Offset = "0xD95E70", VA = "0xD95E70", Slot = "43")]
	protected virtual bool ShowItemMarkBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A55")]
	[Address(RVA = "0xD95EC8", Offset = "0xD95EC8", VA = "0xD95EC8")]
	public void AdjustHudByCustomRoomSetting(bool visibility)
	{
	}

	[Token(Token = "0x6015A56")]
	[Address(RVA = "0xD95FD0", Offset = "0xD95FD0", VA = "0xD95FD0")]
	public void ShowOrHideEnterPhotographModeController(bool isShow)
	{
	}

	[Token(Token = "0x6015A57")]
	[Address(RVA = "0xD79388", Offset = "0xD79388", VA = "0xD79388")]
	private void UpdateEnterPhotographModeControllerPosition()
	{
	}

	[Token(Token = "0x6015A58")]
	[Address(RVA = "0xD961F0", Offset = "0xD961F0", VA = "0xD961F0")]
	public void ShowOrHidePhotographModeController(bool isShow)
	{
	}

	[Token(Token = "0x6015A59")]
	[Address(RVA = "0xD965B8", Offset = "0xD965B8", VA = "0xD965B8", Slot = "10")]
	public override void SetActiveGroup(ulong InActiveGroup)
	{
	}

	[Token(Token = "0x6015A5A")]
	[Address(RVA = "0xD967B4", Offset = "0xD967B4", VA = "0xD967B4")]
	public void ShowOrHidePhotographEmotePanel(bool isShow)
	{
	}

	[Token(Token = "0x6015A5B")]
	[Address(RVA = "0xD969B0", Offset = "0xD969B0", VA = "0xD969B0", Slot = "44")]
	public virtual ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015A5C")]
	[Address(RVA = "0xD96A88", Offset = "0xD96A88", VA = "0xD96A88")]
	public void ShowOrHideBountyWaitingBossHP(bool isShow)
	{
	}

	[Token(Token = "0x6015A5D")]
	[Address(RVA = "0xD96C84", Offset = "0xD96C84", VA = "0xD96C84")]
	public void OpenBountyBossInfoController()
	{
	}

	[Token(Token = "0x6015A5E")]
	[Address(RVA = "0xD96D9C", Offset = "0xD96D9C", VA = "0xD96D9C")]
	private void OnTeamParachuteStateChange(object[] param)
	{
	}

	[Token(Token = "0x6015A5F")]
	[Address(RVA = "0xD96F6C", Offset = "0xD96F6C", VA = "0xD96F6C")]
	private void OnTeamParachuteModeChange(object[] param)
	{
	}

	[Token(Token = "0x6015A60")]
	[Address(RVA = "0xD97D78", Offset = "0xD97D78", VA = "0xD97D78")]
	private void OnTutorialCSGamePaused(object[] param)
	{
	}

	[Token(Token = "0x6015A61")]
	[Address(RVA = "0xD97FD4", Offset = "0xD97FD4", VA = "0xD97FD4")]
	private void OnGamePaused(object[] param)
	{
	}

	[Token(Token = "0x6015A62")]
	[Address(RVA = "0xD98268", Offset = "0xD98268", VA = "0xD98268")]
	private void OnRequestGameResumeConfirm(object[] param)
	{
	}

	[Token(Token = "0x6015A63")]
	[Address(RVA = "0xD97B00", Offset = "0xD97B00", VA = "0xD97B00")]
	private string GetLocalTeamParachuteLeaderName()
	{
		return null;
	}

	[Token(Token = "0x6015A64")]
	[Address(RVA = "0xD9867C", Offset = "0xD9867C", VA = "0xD9867C")]
	private void OnSafezoneCheckDamageChanged(object[] data)
	{
	}

	[Token(Token = "0x6015A65")]
	[Address(RVA = "0xD98AD4", Offset = "0xD98AD4", VA = "0xD98AD4")]
	private void OnShowSafezonePosMark(bool show)
	{
	}

	[Token(Token = "0x6015A66")]
	[Address(RVA = "0xD98CA8", Offset = "0xD98CA8", VA = "0xD98CA8")]
	private void OnShowPreset(object[] data)
	{
	}

	[Token(Token = "0x6015A67")]
	[Address(RVA = "0xD98F9C", Offset = "0xD98F9C", VA = "0xD98F9C")]
	private void OnShowPresetEntry(object[] data)
	{
	}

	[Token(Token = "0x6015A68")]
	[Address(RVA = "0xD99164", Offset = "0xD99164", VA = "0xD99164", Slot = "45")]
	protected virtual bool ShowTeammateInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6015A69")]
	[Address(RVA = "0xD991BC", Offset = "0xD991BC", VA = "0xD991BC", Slot = "46")]
	protected virtual void OnGameVoiceHudCreated()
	{
	}

	[Token(Token = "0x6015A6A")]
	public T OpenUIInternal<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015A6B")]
	protected T OpenUIFromConfig<T>(Transform parent) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x6015A6C")]
	protected Vector3 GetPositionFromConfig<T>() where T : UIBaseController
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6015A6D")]
	protected Vector3 GetScaleFromConfig<T>() where T : UIBaseController
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6015A6E")]
	public double GetAlphaFromConfig<T>() where T : UIBaseController
	{
		return default(double);
	}

	[Token(Token = "0x6015A6F")]
	protected void OverrideGroupSettings<T>(uint[] bs)
	{
	}

	[Token(Token = "0x6015A71")]
	[Address(RVA = "0xD9A984", Offset = "0xD9A984", VA = "0xD9A984")]
	private static bool _003COpenHud_003Em__0(string x)
	{
		return default(bool);
	}

	[Token(Token = "0x6015A72")]
	[Address(RVA = "0xD9AA5C", Offset = "0xD9AA5C", VA = "0xD9AA5C")]
	private void _003COpenCommonHud_003Em__1()
	{
	}

	[Token(Token = "0x6015A73")]
	[Address(RVA = "0xD9AB10", Offset = "0xD9AB10", VA = "0xD9AB10")]
	private void _003COpenCommonHud_003Em__2()
	{
	}

	[Token(Token = "0x6015A74")]
	[Address(RVA = "0xD9ABC4", Offset = "0xD9ABC4", VA = "0xD9ABC4")]
	private void _003COpenCommonHud_003Em__3()
	{
	}

	[Token(Token = "0x6015A75")]
	[Address(RVA = "0xD9AC78", Offset = "0xD9AC78", VA = "0xD9AC78")]
	private void _003COpenCommonHud_003Em__4()
	{
	}

	[Token(Token = "0x6015A76")]
	[Address(RVA = "0xD9AD2C", Offset = "0xD9AD2C", VA = "0xD9AD2C")]
	private void _003COpenCommonHud_003Em__5()
	{
	}

	[Token(Token = "0x6015A77")]
	[Address(RVA = "0xD9AEAC", Offset = "0xD9AEAC", VA = "0xD9AEAC")]
	private void _003COnAddPlayer_003Em__6()
	{
	}

	[Token(Token = "0x6015A78")]
	[Address(RVA = "0xD9AF64", Offset = "0xD9AF64", VA = "0xD9AF64")]
	private static void _003COnAddPlayer_003Em__7()
	{
	}

	[Token(Token = "0x6015A79")]
	[Address(RVA = "0xD9B090", Offset = "0xD9B090", VA = "0xD9B090")]
	private void _003CCheckStreamReady_003Em__8()
	{
	}

	[Token(Token = "0x6015A7A")]
	[Address(RVA = "0xD9B2FC", Offset = "0xD9B2FC", VA = "0xD9B2FC")]
	private void _003COnShowMatchResult_003Em__9()
	{
	}

	[Token(Token = "0x6015A7B")]
	[Address(RVA = "0xD9B478", Offset = "0xD9B478", VA = "0xD9B478")]
	private static bool _003COnHudNormalSettingChanged_003Em__A(UIBaseController c)
	{
		return default(bool);
	}

	[Token(Token = "0x6015A7C")]
	[Address(RVA = "0xD9B53C", Offset = "0xD9B53C", VA = "0xD9B53C")]
	private static void _003CShowBackToLobbyDialog_003Em__B()
	{
	}

	[Token(Token = "0x6015A7D")]
	[Address(RVA = "0xD9B634", Offset = "0xD9B634", VA = "0xD9B634")]
	private static void _003CReplayQuitMatch_003Em__C()
	{
	}

	[Token(Token = "0x6015A7E")]
	[Address(RVA = "0xD9B888", Offset = "0xD9B888", VA = "0xD9B888")]
	private static void _003COnGameOpeningStart_003Em__D()
	{
	}

	[Token(Token = "0x6015A7F")]
	[Address(RVA = "0xD9B948", Offset = "0xD9B948", VA = "0xD9B948")]
	private void _003COnGameOpeningEnd_003Em__E()
	{
	}

	[Token(Token = "0x6015A80")]
	[Address(RVA = "0xD9BA00", Offset = "0xD9BA00", VA = "0xD9BA00")]
	private static void _003COnGameOpeningEnd_003Em__F()
	{
	}

	[Token(Token = "0x6015A81")]
	[Address(RVA = "0xD9BB2C", Offset = "0xD9BB2C", VA = "0xD9BB2C")]
	private void _003COnSelfIdentityChanged_003Em__10()
	{
	}

	[Token(Token = "0x6015A82")]
	[Address(RVA = "0xD9BC14", Offset = "0xD9BC14", VA = "0xD9BC14")]
	private void _003COnRequestGameResumeConfirm_003Em__11()
	{
	}

	[Token(Token = "0x6015A83")]
	[Address(RVA = "0xD9BD30", Offset = "0xD9BD30", VA = "0xD9BD30")]
	private void _003COnRequestGameResumeConfirm_003Em__12()
	{
	}

	[Token(Token = "0x6015A84")]
	[Address(RVA = "0xD9BE84", Offset = "0xD9BE84", VA = "0xD9BE84")]
	private void _003COnRequestGameResumeConfirm_003Em__13()
	{
	}

	[Token(Token = "0x6015A85")]
	[Address(RVA = "0xD9BFDC", Offset = "0xD9BFDC", VA = "0xD9BFDC")]
	private void _003COpenCommonHud_003Em__14()
	{
	}

	[Token(Token = "0x6015A86")]
	[Address(RVA = "0xD9C104", Offset = "0xD9C104", VA = "0xD9C104")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015A87")]
	[Address(RVA = "0xD9C10C", Offset = "0xD9C10C", VA = "0xD9C10C")]
	public void _003C_003EiFixBaseProxy_Destory()
	{
	}

	[Token(Token = "0x6015A88")]
	[Address(RVA = "0xD9C114", Offset = "0xD9C114", VA = "0xD9C114")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x6015A89")]
	[Address(RVA = "0xD9C11C", Offset = "0xD9C11C", VA = "0xD9C11C")]
	public Transform _003C_003EiFixBaseProxy_FindUIRoot()
	{
		return null;
	}

	[Token(Token = "0x6015A8A")]
	[Address(RVA = "0xD9C124", Offset = "0xD9C124", VA = "0xD9C124")]
	public void _003C_003EiFixBaseProxy_SetActiveGroup(ulong P0)
	{
	}
}
