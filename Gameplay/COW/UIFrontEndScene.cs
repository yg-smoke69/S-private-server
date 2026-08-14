using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F15")]
internal class UIFrontEndScene : UICOWBaseScene
{
	[Token(Token = "0x2001F16")]
	public static class BatteryWatcher
	{
		[Token(Token = "0x400C3BF")]
		[FieldOffset(Offset = "0x0")]
		private static bool? _IsBatteryCharging;

		[Token(Token = "0x400C3C0")]
		[FieldOffset(Offset = "0x4")]
		private static float _BatteryLevel;

		[Token(Token = "0x400C3C1")]
		private const float BATTERY_LEVEL_UPDATE_THRESHOLD = 0.05f;

		[Token(Token = "0x400C3C2")]
		[FieldOffset(Offset = "0x8")]
		private static PlatformUtility.BatteryLevelChangedCallback _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x400C3C3")]
		[FieldOffset(Offset = "0xC")]
		private static PlatformUtility.BatteryChargingChangedCallback _003C_003Ef__mg_0024cache1;

		[Token(Token = "0x17000F7F")]
		public static bool IsBatteryCharging
		{
			[Token(Token = "0x600991D")]
			[Address(RVA = "0x26576C0", Offset = "0x26576C0", VA = "0x26576C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000F80")]
		public static float BatteryLevel
		{
			[Token(Token = "0x600991E")]
			[Address(RVA = "0x2657800", Offset = "0x2657800", VA = "0x2657800")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600991F")]
		[Address(RVA = "0x2657914", Offset = "0x2657914", VA = "0x2657914")]
		internal static void Begin()
		{
		}

		[Token(Token = "0x6009920")]
		[Address(RVA = "0x2657C84", Offset = "0x2657C84", VA = "0x2657C84")]
		internal static void End()
		{
		}

		[Token(Token = "0x6009921")]
		[Address(RVA = "0x2657D40", Offset = "0x2657D40", VA = "0x2657D40")]
		public static void OnBatteryChanged(bool charging, float batteryLevel)
		{
		}

		[Token(Token = "0x6009922")]
		[Address(RVA = "0x2658068", Offset = "0x2658068", VA = "0x2658068")]
		private static void OnBatteryChargingChanged(bool charging)
		{
		}

		[Token(Token = "0x6009923")]
		[Address(RVA = "0x26582A8", Offset = "0x26582A8", VA = "0x26582A8")]
		private static void OnBatteryLevelChanged(float batteryLevel)
		{
		}
	}

	[Token(Token = "0x2001F17")]
	private enum EInviteTipsType
	{
		[Token(Token = "0x400C3C5")]
		None,
		[Token(Token = "0x400C3C6")]
		GroupInvite,
		[Token(Token = "0x400C3C7")]
		Friend,
		[Token(Token = "0x400C3C8")]
		JoinGroupRequest
	}

	[Token(Token = "0x2001F18")]
	private sealed class _003COnShowSpeDownloadPopup_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C3C9")]
		[FieldOffset(Offset = "0x8")]
		internal object[] data;

		[Token(Token = "0x400C3CA")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelOptionalDownload modelOptionalDownload;

		[Token(Token = "0x400C3CB")]
		[FieldOffset(Offset = "0x10")]
		internal List<ResourceID> target_id;

		[Token(Token = "0x6009925")]
		[Address(RVA = "0x2656AF8", Offset = "0x2656AF8", VA = "0x2656AF8")]
		public _003COnShowSpeDownloadPopup_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009926")]
		[Address(RVA = "0x2656B00", Offset = "0x2656B00", VA = "0x2656B00")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F19")]
	private sealed class _003COnShowTagDownloadPopup_003Ec__AnonStorey1
	{
		[Token(Token = "0x400C3CC")]
		[FieldOffset(Offset = "0x8")]
		internal object[] data;

		[Token(Token = "0x400C3CD")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelOptionalDownload model;

		[Token(Token = "0x400C3CE")]
		[FieldOffset(Offset = "0x10")]
		internal List<uint> tagList;

		[Token(Token = "0x6009927")]
		[Address(RVA = "0x2656DE8", Offset = "0x2656DE8", VA = "0x2656DE8")]
		public _003COnShowTagDownloadPopup_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6009928")]
		[Address(RVA = "0x2656DF0", Offset = "0x2656DF0", VA = "0x2656DF0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F1A")]
	private sealed class _003COnShowNewDownloadPopup_003Ec__AnonStorey2
	{
		[Token(Token = "0x400C3CF")]
		[FieldOffset(Offset = "0x8")]
		internal object[] data;

		[Token(Token = "0x400C3D0")]
		[FieldOffset(Offset = "0xC")]
		internal ResDownloadType type;

		[Token(Token = "0x6009929")]
		[Address(RVA = "0x265679C", Offset = "0x265679C", VA = "0x265679C")]
		public _003COnShowNewDownloadPopup_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600992A")]
		[Address(RVA = "0x26567A4", Offset = "0x26567A4", VA = "0x26567A4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F1B")]
	private sealed class _003COnShowDownloadPopup_003Ec__AnonStorey3
	{
		[Token(Token = "0x400C3D1")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelOptionalDownload modelOptionalDwonload;

		[Token(Token = "0x400C3D2")]
		[FieldOffset(Offset = "0xC")]
		internal List<ResourceID> target_id;

		[Token(Token = "0x400C3D3")]
		[FieldOffset(Offset = "0x10")]
		internal object[] data;

		[Token(Token = "0x600992B")]
		[Address(RVA = "0x26558A0", Offset = "0x26558A0", VA = "0x26558A0")]
		public _003COnShowDownloadPopup_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x2001F1C")]
	private sealed class _003COnShowDownloadPopup_003Ec__AnonStorey4
	{
		[Token(Token = "0x400C3D4")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelMapOpeningInfo modelMap;

		[Token(Token = "0x400C3D5")]
		[FieldOffset(Offset = "0xC")]
		internal _003COnShowDownloadPopup_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x600992C")]
		[Address(RVA = "0x26558A8", Offset = "0x26558A8", VA = "0x26558A8")]
		public _003COnShowDownloadPopup_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x600992D")]
		[Address(RVA = "0x26558B0", Offset = "0x26558B0", VA = "0x26558B0")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600992E")]
		[Address(RVA = "0x2656178", Offset = "0x2656178", VA = "0x2656178")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2001F1D")]
	private sealed class _003CSetBackground_003Ec__AnonStorey5
	{
		[Token(Token = "0x400C3D6")]
		[FieldOffset(Offset = "0x8")]
		internal int width;

		[Token(Token = "0x400C3D7")]
		[FieldOffset(Offset = "0xC")]
		internal int height;

		[Token(Token = "0x400C3D8")]
		[FieldOffset(Offset = "0x10")]
		internal bool needResetLocalScale;

		[Token(Token = "0x400C3D9")]
		[FieldOffset(Offset = "0x14")]
		internal UIFrontEndScene _0024this;

		[Token(Token = "0x600992F")]
		[Address(RVA = "0x2657398", Offset = "0x2657398", VA = "0x2657398")]
		public _003CSetBackground_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6009930")]
		[Address(RVA = "0x26573A0", Offset = "0x26573A0", VA = "0x26573A0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2001F1E")]
	private sealed class _003CShowGroupMessageBox_003Ec__AnonStorey6
	{
		[Token(Token = "0x400C3DA")]
		[FieldOffset(Offset = "0x8")]
		internal Action cb;

		[Token(Token = "0x6009931")]
		[Address(RVA = "0x26576A4", Offset = "0x26576A4", VA = "0x26576A4")]
		public _003CShowGroupMessageBox_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6009932")]
		[Address(RVA = "0x26576AC", Offset = "0x26576AC", VA = "0x26576AC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C380")]
	[FieldOffset(Offset = "0x60")]
	public Camera DigitaluniverseBCamera;

	[Token(Token = "0x400C381")]
	[FieldOffset(Offset = "0x64")]
	public UIDigitaluniverseBCameraController DigitaluniverseBCameraCtrl;

	[Token(Token = "0x400C382")]
	[FieldOffset(Offset = "0x68")]
	public Transform OverMaskPanel;

	[Token(Token = "0x400C383")]
	[FieldOffset(Offset = "0x6C")]
	public Transform OverMaskTexture;

	[Token(Token = "0x400C384")]
	[FieldOffset(Offset = "0x70")]
	public Transform UIBGRoot;

	[Token(Token = "0x400C385")]
	[FieldOffset(Offset = "0x74")]
	public UITexture BgTexture;

	[Token(Token = "0x400C386")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BgDarkMask;

	[Token(Token = "0x400C387")]
	[FieldOffset(Offset = "0x7C")]
	public Transform Bg2DObjects;

	[Token(Token = "0x400C388")]
	[FieldOffset(Offset = "0x80")]
	public UI3DObjectHelper UI3DRootHelper;

	[Token(Token = "0x400C389")]
	[FieldOffset(Offset = "0x84")]
	public Camera UI3DCamera;

	[Token(Token = "0x400C38A")]
	[FieldOffset(Offset = "0x88")]
	public Camera BgCamera;

	[Token(Token = "0x400C38B")]
	[FieldOffset(Offset = "0x8C")]
	public UIPopupMessageBoxController m_MessageBox;

	[Token(Token = "0x400C38C")]
	[FieldOffset(Offset = "0x90")]
	private UICommonPopMenuController m_PopMenuController;

	[Token(Token = "0x400C38D")]
	[FieldOffset(Offset = "0x94")]
	private UICommonTipsController m_TipsController;

	[Token(Token = "0x400C38E")]
	[FieldOffset(Offset = "0x98")]
	private UIAvatarWindowController m_AvatarWindowController;

	[Token(Token = "0x400C38F")]
	[FieldOffset(Offset = "0x9C")]
	private UIGameModeMainController m_GameModeMainController;

	[Token(Token = "0x400C390")]
	[FieldOffset(Offset = "0xA0")]
	private uint mDelayShowReconnect;

	[Token(Token = "0x400C391")]
	[FieldOffset(Offset = "0xA4")]
	private GameObject m_SpecificOverMask;

	[Token(Token = "0x400C392")]
	[FieldOffset(Offset = "0xA8")]
	private ResourceID m_bgUsedResID;

	[Token(Token = "0x400C393")]
	[FieldOffset(Offset = "0xAC")]
	private ResourceID m_LobbyBGSpine1;

	[Token(Token = "0x400C394")]
	[FieldOffset(Offset = "0xB0")]
	private ResourceID m_LobbyBGSpine2;

	[Token(Token = "0x400C395")]
	[FieldOffset(Offset = "0xB4")]
	private GameObject m_LobbyBG;

	[Token(Token = "0x400C396")]
	[FieldOffset(Offset = "0xB8")]
	private ResourceID m_CurrentSpineBGResID;

	[Token(Token = "0x400C397")]
	[FieldOffset(Offset = "0xBC")]
	private Material mainShadowMat;

	[Token(Token = "0x400C398")]
	[FieldOffset(Offset = "0xC0")]
	private Material vehicleShadowMat;

	[Token(Token = "0x400C399")]
	[FieldOffset(Offset = "0xC4")]
	private Material weaponShadowMat;

	[Token(Token = "0x400C39A")]
	[FieldOffset(Offset = "0xC8")]
	public Transform vehiclePlatform;

	[Token(Token = "0x400C39B")]
	[FieldOffset(Offset = "0xCC")]
	public Transform weaponShadowPanel;

	[Token(Token = "0x400C39C")]
	[FieldOffset(Offset = "0xD0")]
	private int centerPoint;

	[Token(Token = "0x400C39D")]
	[FieldOffset(Offset = "0xD4")]
	private int planeNormal;

	[Token(Token = "0x400C39E")]
	[FieldOffset(Offset = "0xD8")]
	private bool isInitPlanarShadowMats;

	[Token(Token = "0x400C39F")]
	[FieldOffset(Offset = "0xDC")]
	private ShadowResolution originalShadowResolution;

	[Token(Token = "0x400C3A0")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_DrawPlannarShadow;

	[Token(Token = "0x400C3A1")]
	[FieldOffset(Offset = "0xE4")]
	private HashSet<PlannarShadowRenderer> psRenderers;

	[Token(Token = "0x400C3A2")]
	[FieldOffset(Offset = "0xE8")]
	private Camera m_CurPlannarCamera;

	[Token(Token = "0x400C3A3")]
	[FieldOffset(Offset = "0xEC")]
	private Transform receiveShadowPlane;

	[Token(Token = "0x400C3A4")]
	[FieldOffset(Offset = "0xF0")]
	private UIModelInventory m_UIModelInventory;

	[Token(Token = "0x400C3A5")]
	[FieldOffset(Offset = "0xF4")]
	private EFrontendBGMType m_CurrentBGMType;

	[Token(Token = "0x400C3A6")]
	[FieldOffset(Offset = "0xF8")]
	private EFrontendBGMType m_LastBGMType;

	[Token(Token = "0x400C3A7")]
	[FieldOffset(Offset = "0xFC")]
	private float m_LastBGMPlaybackTime;

	[Token(Token = "0x400C3A8")]
	[FieldOffset(Offset = "0x100")]
	private float m_LastBGMStartTime;

	[Token(Token = "0x400C3A9")]
	private const float CHANGE_NAVIGATION_TIME_WINDOW = 15f;

	[Token(Token = "0x400C3AA")]
	[FieldOffset(Offset = "0x104")]
	private List<int> m_NeedContinuousPlayBGMLst;

	[Token(Token = "0x400C3AB")]
	[FieldOffset(Offset = "0x108")]
	private UIDebugConsoleCommandItem DebugBtnCtrl;

	[Token(Token = "0x400C3AC")]
	[FieldOffset(Offset = "0x10C")]
	private PlanarReflection m_PlannerReflection;

	[Token(Token = "0x400C3AD")]
	[FieldOffset(Offset = "0x0")]
	private static uint _DelayCallId_ProcessOpenedByUrl;

	[Token(Token = "0x400C3AE")]
	private const float _Delay_ProcessOpenedByUrl = 0.5f;

	[Token(Token = "0x400C3AF")]
	[FieldOffset(Offset = "0x110")]
	private UIMatchMakingWatingController m_MatchmakingWaiting;

	[Token(Token = "0x400C3B0")]
	[FieldOffset(Offset = "0x114")]
	private UIMatchMakingWaitingOptimizedController m_MatchmakingWaitingOptimized;

	[Token(Token = "0x400C3B1")]
	[FieldOffset(Offset = "0x118")]
	private UIClanWarInTeamController m_ClanWarInTeam;

	[Token(Token = "0x400C3B2")]
	[FieldOffset(Offset = "0x11C")]
	private uint m_AutoMatchGroupingTime;

	[Token(Token = "0x400C3B3")]
	[FieldOffset(Offset = "0x120")]
	private uint m_AutoMatchMakingTime;

	[Token(Token = "0x400C3B4")]
	[FieldOffset(Offset = "0x124")]
	private bool m_IsCancelMatchMakingBanned;

	[Token(Token = "0x400C3B5")]
	[FieldOffset(Offset = "0x125")]
	private bool m_IsClanWarMatchMaking;

	[Token(Token = "0x400C3B6")]
	[FieldOffset(Offset = "0x128")]
	private ProxyInfoController m_ProxyInfoController;

	[Token(Token = "0x400C3B7")]
	[FieldOffset(Offset = "0x12C")]
	private bool m_ProxyOldState;

	[Token(Token = "0x400C3B8")]
	[FieldOffset(Offset = "0x4")]
	private static EventDispatcher.EventHandler _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400C3B9")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400C3BA")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapA;

	[Token(Token = "0x400C3BB")]
	[FieldOffset(Offset = "0x10")]
	private static EventDispatcher.EventHandler _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x400C3BC")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400C3BD")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400C3BE")]
	[FieldOffset(Offset = "0x1C")]
	private static UIDebugConsoleCommandItem.OnRunCmd _003C_003Ef__am_0024cache3;

	[Token(Token = "0x17000F7E")]
	public Camera CurPlannarCamera
	{
		[Token(Token = "0x6009865")]
		[Address(RVA = "0xE98D14", Offset = "0xE98D14", VA = "0xE98D14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6009864")]
		[Address(RVA = "0xE98CB4", Offset = "0xE98CB4", VA = "0xE98CB4")]
		set
		{
		}
	}

	[Token(Token = "0x6009861")]
	[Address(RVA = "0xE98710", Offset = "0xE98710", VA = "0xE98710")]
	public UIFrontEndScene()
	{
	}

	[Token(Token = "0x6009862")]
	[Address(RVA = "0xE988EC", Offset = "0xE988EC", VA = "0xE988EC")]
	public Camera GetCamera()
	{
		return null;
	}

	[Token(Token = "0x6009863")]
	[Address(RVA = "0xE98BB8", Offset = "0xE98BB8", VA = "0xE98BB8")]
	public void CheckCloseCamera()
	{
	}

	[Token(Token = "0x6009866")]
	[Address(RVA = "0xE98D6C", Offset = "0xE98D6C", VA = "0xE98D6C")]
	public bool Is3DCameraFocusBehindScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6009867")]
	[Address(RVA = "0xE98EC0", Offset = "0xE98EC0", VA = "0xE98EC0")]
	public void DisableBgCamera()
	{
	}

	[Token(Token = "0x6009868")]
	[Address(RVA = "0xE98FC0", Offset = "0xE98FC0", VA = "0xE98FC0")]
	public void SetBackCamerasVisible(bool bVisible)
	{
	}

	[Token(Token = "0x6009869")]
	[Address(RVA = "0xE9926C", Offset = "0xE9926C", VA = "0xE9926C")]
	public void Show()
	{
	}

	[Token(Token = "0x600986A")]
	[Address(RVA = "0xE9E31C", Offset = "0xE9E31C", VA = "0xE9E31C")]
	private void OpenNewVault(object[] data)
	{
	}

	[Token(Token = "0x600986B")]
	[Address(RVA = "0xE9E4F8", Offset = "0xE9E4F8", VA = "0xE9E4F8")]
	public void UpdateLobbyBGMByNewVault(ResourceID res)
	{
	}

	[Token(Token = "0x600986C")]
	[Address(RVA = "0xE9E5D4", Offset = "0xE9E5D4", VA = "0xE9E5D4")]
	public EFrontendBGMType GetCurrentBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600986D")]
	[Address(RVA = "0xE9D1D8", Offset = "0xE9D1D8", VA = "0xE9D1D8")]
	public void UpdateLobbyBGMResource(string region)
	{
	}

	[Token(Token = "0x600986E")]
	[Address(RVA = "0xE9D938", Offset = "0xE9D938", VA = "0xE9D938")]
	private void RequestEmote()
	{
	}

	[Token(Token = "0x600986F")]
	[Address(RVA = "0xE9E62C", Offset = "0xE9E62C", VA = "0xE9E62C")]
	private void OnApplicationPauseEvent(object[] parameters)
	{
	}

	[Token(Token = "0x6009870")]
	[Address(RVA = "0xE9E914", Offset = "0xE9E914", VA = "0xE9E914")]
	public static void ProcessOpenedByUrl()
	{
	}

	[Token(Token = "0x6009871")]
	private T GetParam<T>(object[] param, int index)
	{
		return (T)null;
	}

	[Token(Token = "0x6009872")]
	[Address(RVA = "0xE9EE20", Offset = "0xE9EE20", VA = "0xE9EE20")]
	private void OnDeepLink(object[] param)
	{
	}

	[Token(Token = "0x6009873")]
	[Address(RVA = "0xE9FBD0", Offset = "0xE9FBD0", VA = "0xE9FBD0")]
	private void OnDeepLink_GroupInvite(string group_id, string region, string secret_code)
	{
	}

	[Token(Token = "0x6009874")]
	[Address(RVA = "0xEA0240", Offset = "0xEA0240", VA = "0xEA0240")]
	private void OnDeepLink_Lobby()
	{
	}

	[Token(Token = "0x6009875")]
	[Address(RVA = "0xEA0630", Offset = "0xEA0630", VA = "0xEA0630")]
	private void OnDeepLink_Reunion(string uid)
	{
	}

	[Token(Token = "0x6009876")]
	[Address(RVA = "0xEA0BDC", Offset = "0xEA0BDC", VA = "0xEA0BDC")]
	private void OnDeepLink_LocateClan(string clanId)
	{
	}

	[Token(Token = "0x6009877")]
	[Address(RVA = "0xEA0D80", Offset = "0xEA0D80", VA = "0xEA0D80")]
	private void OnDeepLink_LocateRoom(uint roomType, string roomId)
	{
	}

	[Token(Token = "0x6009878")]
	[Address(RVA = "0xE9F90C", Offset = "0xE9F90C", VA = "0xE9F90C")]
	private void OnDeepLink_Gacha()
	{
	}

	[Token(Token = "0x6009879")]
	[Address(RVA = "0xE9FA48", Offset = "0xE9FA48", VA = "0xE9FA48")]
	private void OnDeepLink_ClanWarRecruit()
	{
	}

	[Token(Token = "0x600987A")]
	[Address(RVA = "0xE9F7D0", Offset = "0xE9F7D0", VA = "0xE9F7D0")]
	private void OnDeepLink_ElitePass()
	{
	}

	[Token(Token = "0x600987B")]
	[Address(RVA = "0xE9F648", Offset = "0xE9F648", VA = "0xE9F648")]
	private void OnDeepLink_CharactersNew()
	{
	}

	[Token(Token = "0x600987C")]
	[Address(RVA = "0xEA04F4", Offset = "0xEA04F4", VA = "0xEA04F4")]
	private void OnDeepLink_RebateCard()
	{
	}

	[Token(Token = "0x600987D")]
	[Address(RVA = "0xEA0038", Offset = "0xEA0038", VA = "0xEA0038")]
	private void OnDeepLink_IAPBundle()
	{
	}

	[Token(Token = "0x600987E")]
	[Address(RVA = "0xEA0158", Offset = "0xEA0158", VA = "0xEA0158")]
	private void OnDeepLink_Mail()
	{
	}

	[Token(Token = "0x600987F")]
	[Address(RVA = "0xEA035C", Offset = "0xEA035C", VA = "0xEA035C")]
	private void OnDeeplink_Navigate(uint pos, string param)
	{
	}

	[Token(Token = "0x6009880")]
	[Address(RVA = "0xEA11C4", Offset = "0xEA11C4", VA = "0xEA11C4")]
	private void ShowMessageBox(object[] data)
	{
	}

	[Token(Token = "0x6009881")]
	[Address(RVA = "0xEA14A8", Offset = "0xEA14A8", VA = "0xEA14A8")]
	private void ShowIAPMessageBox(object[] data)
	{
	}

	[Token(Token = "0x6009882")]
	[Address(RVA = "0xEA1850", Offset = "0xEA1850", VA = "0xEA1850")]
	private void OnShowSpeDownloadPopup(object[] data)
	{
	}

	[Token(Token = "0x6009883")]
	[Address(RVA = "0xEA2030", Offset = "0xEA2030", VA = "0xEA2030")]
	private void OnShowTagDownloadPopup(object[] data)
	{
	}

	[Token(Token = "0x6009884")]
	[Address(RVA = "0xEA29A4", Offset = "0xEA29A4", VA = "0xEA29A4")]
	private void OnCancelDownload()
	{
	}

	[Token(Token = "0x6009885")]
	[Address(RVA = "0xEA2AC8", Offset = "0xEA2AC8", VA = "0xEA2AC8")]
	private void OnShowNewDownloadPopup(object[] data)
	{
	}

	[Token(Token = "0x6009886")]
	[Address(RVA = "0xEA322C", Offset = "0xEA322C", VA = "0xEA322C")]
	private void OnShowDownloadNavigation(object[] data)
	{
	}

	[Token(Token = "0x6009887")]
	[Address(RVA = "0xEA3394", Offset = "0xEA3394", VA = "0xEA3394")]
	private void OnShowDownloadPopup(object[] data)
	{
	}

	[Token(Token = "0x6009888")]
	[Address(RVA = "0xEA3B84", Offset = "0xEA3B84", VA = "0xEA3B84")]
	private void OnShowDownloadPopupOnLogin(object[] data)
	{
	}

	[Token(Token = "0x6009889")]
	[Address(RVA = "0xEA3CA0", Offset = "0xEA3CA0", VA = "0xEA3CA0")]
	private void ShowCommonRewardWnd(object[] data)
	{
	}

	[Token(Token = "0x600988A")]
	[Address(RVA = "0xE9D62C", Offset = "0xE9D62C", VA = "0xE9D62C")]
	private Transform FindBGUIRoot()
	{
		return null;
	}

	[Token(Token = "0x600988B")]
	[Address(RVA = "0xEA3E7C", Offset = "0xEA3E7C", VA = "0xEA3E7C")]
	private GameObject FindUI3DRoot()
	{
		return null;
	}

	[Token(Token = "0x600988C")]
	[Address(RVA = "0xEA3F28", Offset = "0xEA3F28", VA = "0xEA3F28", Slot = "9")]
	protected override Transform FindUIRoot()
	{
		return null;
	}

	[Token(Token = "0x600988D")]
	[Address(RVA = "0xE9D6F8", Offset = "0xE9D6F8", VA = "0xE9D6F8")]
	private UI3DObjectHelper FindUI3DRootHelper()
	{
		return null;
	}

	[Token(Token = "0x600988E")]
	[Address(RVA = "0xE9D810", Offset = "0xE9D810", VA = "0xE9D810")]
	private Camera FindUI3DCamera()
	{
		return null;
	}

	[Token(Token = "0x600988F")]
	[Address(RVA = "0xEA4154", Offset = "0xEA4154", VA = "0xEA4154", Slot = "4")]
	public override void Destory()
	{
	}

	[Token(Token = "0x6009890")]
	[Address(RVA = "0xEA4280", Offset = "0xEA4280", VA = "0xEA4280", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6009891")]
	[Address(RVA = "0xE9DD48", Offset = "0xE9DD48", VA = "0xE9DD48")]
	private void CheckReconnectInfo()
	{
	}

	[Token(Token = "0x6009892")]
	[Address(RVA = "0xEA72D0", Offset = "0xEA72D0", VA = "0xEA72D0")]
	private void ClearReconnectInfo()
	{
	}

	[Token(Token = "0x6009893")]
	[Address(RVA = "0xEA7428", Offset = "0xEA7428", VA = "0xEA7428")]
	private void OnLastBattleTimeOut()
	{
	}

	[Token(Token = "0x6009894")]
	[Address(RVA = "0xEA7638", Offset = "0xEA7638", VA = "0xEA7638")]
	private void OnLastBattleNotify(object[] data)
	{
	}

	[Token(Token = "0x6009895")]
	[Address(RVA = "0xEA7898", Offset = "0xEA7898", VA = "0xEA7898")]
	private void StartReconnectToGame()
	{
	}

	[Token(Token = "0x6009896")]
	[Address(RVA = "0xEA79D0", Offset = "0xEA79D0", VA = "0xEA79D0")]
	private void OnOpenRoomList(object[] data)
	{
	}

	[Token(Token = "0x6009897")]
	[Address(RVA = "0xEA7B80", Offset = "0xEA7B80", VA = "0xEA7B80")]
	private void OnOpenCustomRoom(object[] data)
	{
	}

	[Token(Token = "0x6009898")]
	[Address(RVA = "0xEA865C", Offset = "0xEA865C", VA = "0xEA865C")]
	private void OnCloseCustomRoom(object[] data)
	{
	}

	[Token(Token = "0x6009899")]
	[Address(RVA = "0xEA8924", Offset = "0xEA8924", VA = "0xEA8924")]
	private void OnClanWarMarchTeamReadyNotify(object[] data)
	{
	}

	[Token(Token = "0x600989A")]
	[Address(RVA = "0xEA89F4", Offset = "0xEA89F4", VA = "0xEA89F4")]
	private void OnEnterClanWarTeam(object[] data)
	{
	}

	[Token(Token = "0x600989B")]
	[Address(RVA = "0xEA8E18", Offset = "0xEA8E18", VA = "0xEA8E18")]
	private void OnExitClanWarTeam(object[] data)
	{
	}

	[Token(Token = "0x600989C")]
	[Address(RVA = "0xEA903C", Offset = "0xEA903C", VA = "0xEA903C")]
	private void OnClanWarInTeamChanged(object[] data)
	{
	}

	[Token(Token = "0x600989D")]
	[Address(RVA = "0xEA9140", Offset = "0xEA9140", VA = "0xEA9140")]
	private void StopMatchMaking()
	{
	}

	[Token(Token = "0x600989E")]
	[Address(RVA = "0xEA92B8", Offset = "0xEA92B8", VA = "0xEA92B8")]
	private void OnStartMatchMaking(object[] data)
	{
	}

	[Token(Token = "0x600989F")]
	[Address(RVA = "0xEA989C", Offset = "0xEA989C", VA = "0xEA989C")]
	private void ClearEstimateTime()
	{
	}

	[Token(Token = "0x60098A0")]
	[Address(RVA = "0xEA98FC", Offset = "0xEA98FC", VA = "0xEA98FC")]
	public void OnOpenPopMenu(object[] data)
	{
	}

	[Token(Token = "0x60098A1")]
	[Address(RVA = "0xEA9BD0", Offset = "0xEA9BD0", VA = "0xEA9BD0")]
	public void OnOpenClanWarPopMenu(object[] data)
	{
	}

	[Token(Token = "0x60098A2")]
	[Address(RVA = "0xEA9DEC", Offset = "0xEA9DEC", VA = "0xEA9DEC")]
	public void OnOpenBriefBox(object[] data)
	{
	}

	[Token(Token = "0x60098A3")]
	[Address(RVA = "0xEAA010", Offset = "0xEAA010", VA = "0xEAA010")]
	public void OnOpenTips(object[] data)
	{
	}

	[Token(Token = "0x60098A4")]
	[Address(RVA = "0xEAA7AC", Offset = "0xEAA7AC", VA = "0xEAA7AC")]
	public void OnOpenTweenTips(object[] data)
	{
	}

	[Token(Token = "0x60098A5")]
	[Address(RVA = "0xEAA90C", Offset = "0xEAA90C", VA = "0xEAA90C")]
	private void OnGroupStartNtf(object[] data)
	{
	}

	[Token(Token = "0x60098A6")]
	[Address(RVA = "0xEAAD40", Offset = "0xEAAD40", VA = "0xEAAD40")]
	private void OnEndMatchMaking(object[] data)
	{
	}

	[Token(Token = "0x60098A7")]
	[Address(RVA = "0xEAB1D0", Offset = "0xEAB1D0", VA = "0xEAB1D0")]
	private void OnStopGroupMatchMaking(object[] data)
	{
	}

	[Token(Token = "0x60098A8")]
	[Address(RVA = "0xEAB238", Offset = "0xEAB238", VA = "0xEAB238")]
	private void OnLobbyTCPDisconnected(object[] data)
	{
	}

	[Token(Token = "0x60098A9")]
	[Address(RVA = "0xEAAFD8", Offset = "0xEAAFD8", VA = "0xEAAFD8")]
	private void CloseMatchmaking()
	{
	}

	[Token(Token = "0x60098AA")]
	[Address(RVA = "0xEABBE0", Offset = "0xEABBE0", VA = "0xEABBE0")]
	private void OpenFriendWindow(object[] data)
	{
	}

	[Token(Token = "0x60098AB")]
	[Address(RVA = "0xEABE88", Offset = "0xEABE88", VA = "0xEABE88")]
	private void OpenFriendRequestWindow(object[] data)
	{
	}

	[Token(Token = "0x60098AC")]
	[Address(RVA = "0xEABF58", Offset = "0xEABF58", VA = "0xEABF58")]
	private void OpenFriendCallbackWindow(object[] data)
	{
	}

	[Token(Token = "0x60098AD")]
	[Address(RVA = "0xEAC028", Offset = "0xEAC028", VA = "0xEAC028")]
	private void OpenFriendCallbackAddFriendWindow(object[] data)
	{
	}

	[Token(Token = "0x60098AE")]
	[Address(RVA = "0xEAC1D4", Offset = "0xEAC1D4", VA = "0xEAC1D4")]
	private void OpenBigEventFriendCallbackWindow(object[] data)
	{
	}

	[Token(Token = "0x60098AF")]
	[Address(RVA = "0xEAC2A4", Offset = "0xEAC2A4", VA = "0xEAC2A4")]
	private void OpenBigEventFriendCallbackAddFriendWindow(object[] data)
	{
	}

	[Token(Token = "0x60098B0")]
	[Address(RVA = "0xEAC450", Offset = "0xEAC450", VA = "0xEAC450")]
	private void OpenFriendWindow_Relationship(object[] data)
	{
	}

	[Token(Token = "0x60098B1")]
	[Address(RVA = "0xEAC5A4", Offset = "0xEAC5A4", VA = "0xEAC5A4")]
	private void OpenFriendWindow_TrainingCamp(object[] data)
	{
	}

	[Token(Token = "0x60098B2")]
	[Address(RVA = "0xEAC6F8", Offset = "0xEAC6F8", VA = "0xEAC6F8")]
	private void OpenFriendWindow_Search(object[] data)
	{
	}

	[Token(Token = "0x60098B3")]
	[Address(RVA = "0xEAC84C", Offset = "0xEAC84C", VA = "0xEAC84C")]
	private void OnServiceOff(object[] data)
	{
	}

	[Token(Token = "0x60098B4")]
	[Address(RVA = "0xEAC934", Offset = "0xEAC934", VA = "0xEAC934")]
	private void OpenMallWindow(object[] data)
	{
	}

	[Token(Token = "0x60098B5")]
	[Address(RVA = "0xEAD00C", Offset = "0xEAD00C", VA = "0xEAD00C")]
	private void OpenPetWindow(object[] data)
	{
	}

	[Token(Token = "0x60098B6")]
	[Address(RVA = "0xEAD1E8", Offset = "0xEAD1E8", VA = "0xEAD1E8")]
	private void OpenLiveTvWindow(object[] data)
	{
	}

	[Token(Token = "0x60098B7")]
	[Address(RVA = "0xEAD4EC", Offset = "0xEAD4EC", VA = "0xEAD4EC")]
	private void OpenLeaderBoard(object[] data)
	{
	}

	[Token(Token = "0x60098B8")]
	[Address(RVA = "0xEAD724", Offset = "0xEAD724", VA = "0xEAD724")]
	private void OpenAvatarProfile(object[] data)
	{
	}

	[Token(Token = "0x60098B9")]
	[Address(RVA = "0xEAD9C0", Offset = "0xEAD9C0", VA = "0xEAD9C0")]
	private void OpenAvatarAwaken(object[] data)
	{
	}

	[Token(Token = "0x60098BA")]
	[Address(RVA = "0xEADE28", Offset = "0xEADE28", VA = "0xEADE28")]
	private void OpenGacha(object[] data)
	{
	}

	[Token(Token = "0x60098BB")]
	[Address(RVA = "0xEAE0D4", Offset = "0xEAE0D4", VA = "0xEAE0D4")]
	private void OpenForge(object[] data)
	{
	}

	[Token(Token = "0x60098BC")]
	[Address(RVA = "0xEAE414", Offset = "0xEAE414", VA = "0xEAE414")]
	private void OpenPaymentBundleDialog(object[] data)
	{
	}

	[Token(Token = "0x60098BD")]
	[Address(RVA = "0xEAE600", Offset = "0xEAE600", VA = "0xEAE600")]
	private void PopupNextGiftRewards(object[] data)
	{
	}

	[Token(Token = "0x60098BE")]
	[Address(RVA = "0xEAE700", Offset = "0xEAE700", VA = "0xEAE700")]
	private void OnUILobbyBGSwitch(object[] data)
	{
	}

	[Token(Token = "0x60098BF")]
	[Address(RVA = "0xEAED5C", Offset = "0xEAED5C", VA = "0xEAED5C")]
	public bool IsReconnecting()
	{
		return default(bool);
	}

	[Token(Token = "0x60098C0")]
	[Address(RVA = "0xEAEDC0", Offset = "0xEAEDC0", VA = "0xEAEDC0")]
	public bool IsMatchMakingLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60098C1")]
	[Address(RVA = "0xEAEF28", Offset = "0xEAEF28", VA = "0xEAEF28")]
	private void OnGroupErr(object[] data)
	{
	}

	[Token(Token = "0x60098C2")]
	[Address(RVA = "0xEAEF90", Offset = "0xEAEF90", VA = "0xEAEF90")]
	public void SetBackground(ResourceID bg, int width, int height, bool isFliphHorizontally, bool needResetLocalScale)
	{
	}

	[Token(Token = "0x60098C3")]
	[Address(RVA = "0xEAF56C", Offset = "0xEAF56C", VA = "0xEAF56C")]
	public void SetBackground(string url, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true)
	{
	}

	[Token(Token = "0x60098C4")]
	[Address(RVA = "0xEAF7C8", Offset = "0xEAF7C8", VA = "0xEAF7C8")]
	public void SetBackgroundActive(bool active)
	{
	}

	[Token(Token = "0x60098C5")]
	[Address(RVA = "0xEAF34C", Offset = "0xEAF34C", VA = "0xEAF34C")]
	private void SetBackgroundSize(int width, int height, bool needResetLocalScale)
	{
	}

	[Token(Token = "0x60098C6")]
	[Address(RVA = "0xEAF8F0", Offset = "0xEAF8F0", VA = "0xEAF8F0")]
	public void SetBackGroundMask(bool is_show)
	{
	}

	[Token(Token = "0x60098C7")]
	[Address(RVA = "0xEAF994", Offset = "0xEAF994", VA = "0xEAF994")]
	private void OnOpenProfile(object[] data)
	{
	}

	[Token(Token = "0x60098C8")]
	[Address(RVA = "0xEB01A0", Offset = "0xEB01A0", VA = "0xEB01A0")]
	private void OnOpenAvatarWindow(object[] data)
	{
	}

	[Token(Token = "0x60098C9")]
	[Address(RVA = "0xEB0408", Offset = "0xEB0408", VA = "0xEB0408")]
	public UIAvatarWindowController AvatarWindow()
	{
		return null;
	}

	[Token(Token = "0x60098CA")]
	[Address(RVA = "0xEB0460", Offset = "0xEB0460", VA = "0xEB0460")]
	private void OnOpenMapPanel(object[] data)
	{
	}

	[Token(Token = "0x60098CB")]
	[Address(RVA = "0xEB092C", Offset = "0xEB092C", VA = "0xEB092C")]
	private void OnOpenGroup(object[] data)
	{
	}

	[Token(Token = "0x60098CC")]
	[Address(RVA = "0xEB1290", Offset = "0xEB1290", VA = "0xEB1290")]
	private void OnGroupCreateSuccess(object[] param)
	{
	}

	[Token(Token = "0x60098CD")]
	[Address(RVA = "0xEB12F8", Offset = "0xEB12F8", VA = "0xEB12F8")]
	private void OpenGroupUI()
	{
	}

	[Token(Token = "0x60098CE")]
	[Address(RVA = "0xEB134C", Offset = "0xEB134C", VA = "0xEB134C")]
	private void OnJoinNtf(object[] data)
	{
	}

	[Token(Token = "0x60098CF")]
	[Address(RVA = "0xEB13A8", Offset = "0xEB13A8", VA = "0xEB13A8")]
	private void OnLeaveNtf(object[] data)
	{
	}

	[Token(Token = "0x60098D0")]
	[Address(RVA = "0xEB19A4", Offset = "0xEB19A4", VA = "0xEB19A4")]
	public void OnLeaveGroup()
	{
	}

	[Token(Token = "0x60098D1")]
	[Address(RVA = "0xEB1AC0", Offset = "0xEB1AC0", VA = "0xEB1AC0")]
	private void OnDismissNtf(object[] data)
	{
	}

	[Token(Token = "0x60098D2")]
	[Address(RVA = "0xEB24B8", Offset = "0xEB24B8", VA = "0xEB24B8")]
	private void OnJoinRequestNtf(object[] data)
	{
	}

	[Token(Token = "0x60098D3")]
	[Address(RVA = "0xEB25A0", Offset = "0xEB25A0", VA = "0xEB25A0")]
	private uint GetInviteTipsType(object arg)
	{
		return default(uint);
	}

	[Token(Token = "0x60098D4")]
	[Address(RVA = "0xEB219C", Offset = "0xEB219C", VA = "0xEB219C")]
	private void ShowGroupMessageBox(string details = "", string title = "", [Optional] Action cb)
	{
	}

	[Token(Token = "0x60098D5")]
	[Address(RVA = "0xEB2728", Offset = "0xEB2728", VA = "0xEB2728")]
	private void OnOpenClanSearchById(object[] param)
	{
	}

	[Token(Token = "0x60098D6")]
	[Address(RVA = "0xEB2BC4", Offset = "0xEB2BC4", VA = "0xEB2BC4")]
	private void OnOpenClan(object[] param)
	{
	}

	[Token(Token = "0x60098D7")]
	[Address(RVA = "0xEB32BC", Offset = "0xEB32BC", VA = "0xEB32BC")]
	private void OnOpenDebtWindow(object[] dat)
	{
	}

	[Token(Token = "0x60098D8")]
	[Address(RVA = "0xEB3454", Offset = "0xEB3454", VA = "0xEB3454")]
	private void OnOpenConnectionReport(object[] param)
	{
	}

	[Token(Token = "0x60098D9")]
	[Address(RVA = "0xEB3674", Offset = "0xEB3674", VA = "0xEB3674")]
	private void OnClanCreated(object[] param)
	{
	}

	[Token(Token = "0x60098DA")]
	[Address(RVA = "0xEB3964", Offset = "0xEB3964", VA = "0xEB3964")]
	private void ShowHttpRequestErrorMessage(object[] param)
	{
	}

	[Token(Token = "0x60098DB")]
	[Address(RVA = "0xEB3BB0", Offset = "0xEB3BB0", VA = "0xEB3BB0")]
	private void OnLobby3DObjectVisibleChange(object[] data)
	{
	}

	[Token(Token = "0x60098DC")]
	[Address(RVA = "0xEB43C8", Offset = "0xEB43C8", VA = "0xEB43C8")]
	public ResourceID GetCurrentLobbyBGMResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60098DD")]
	[Address(RVA = "0xEB44E0", Offset = "0xEB44E0", VA = "0xEB44E0")]
	private void PlayBGM(object[] data)
	{
	}

	[Token(Token = "0x60098DE")]
	[Address(RVA = "0xEB4F04", Offset = "0xEB4F04", VA = "0xEB4F04")]
	private void EnterCustomRoom(object[] data)
	{
	}

	[Token(Token = "0x60098DF")]
	[Address(RVA = "0xEB5008", Offset = "0xEB5008", VA = "0xEB5008")]
	public bool IsAvatarWindowCreated()
	{
		return default(bool);
	}

	[Token(Token = "0x60098E0")]
	[Address(RVA = "0xEB50DC", Offset = "0xEB50DC", VA = "0xEB50DC")]
	private void OnAvatarInitReady(object[] data)
	{
	}

	[Token(Token = "0x60098E1")]
	[Address(RVA = "0xEB51A8", Offset = "0xEB51A8", VA = "0xEB51A8")]
	private void OnEpCardActive(object[] data)
	{
	}

	[Token(Token = "0x60098E2")]
	[Address(RVA = "0xEB5370", Offset = "0xEB5370", VA = "0xEB5370")]
	private void OpenInstallmentRepayWnd(object[] data)
	{
	}

	[Token(Token = "0x60098E3")]
	[Address(RVA = "0xEB5594", Offset = "0xEB5594", VA = "0xEB5594")]
	private void OnLobby2DObjectVisibleChange(object[] data)
	{
	}

	[Token(Token = "0x60098E4")]
	[Address(RVA = "0xEB5754", Offset = "0xEB5754", VA = "0xEB5754")]
	public void InitBackground2D()
	{
	}

	[Token(Token = "0x60098E5")]
	[Address(RVA = "0xEAE910", Offset = "0xEAE910", VA = "0xEAE910")]
	private void LoadBackground2DObjects(ResourceID spineBGResID)
	{
	}

	[Token(Token = "0x60098E6")]
	[Address(RVA = "0xEB5B04", Offset = "0xEB5B04", VA = "0xEB5B04")]
	private void OnHudNormalSettingChanged(object[] data)
	{
	}

	[Token(Token = "0x60098E7")]
	[Address(RVA = "0xEB5BF4", Offset = "0xEB5BF4", VA = "0xEB5BF4")]
	private void OnOpenReplay(object[] data)
	{
	}

	[Token(Token = "0x60098E8")]
	[Address(RVA = "0xEB5DA4", Offset = "0xEB5DA4", VA = "0xEB5DA4")]
	private void OnOpenReportReplay(object[] data)
	{
	}

	[Token(Token = "0x60098E9")]
	[Address(RVA = "0xEB5E00", Offset = "0xEB5E00", VA = "0xEB5E00")]
	private void OnChampionshipMatchEnd(object[] data)
	{
	}

	[Token(Token = "0x60098EA")]
	[Address(RVA = "0xEB5FB8", Offset = "0xEB5FB8", VA = "0xEB5FB8")]
	private void OnShowLevelUpWindow(object[] data)
	{
	}

	[Token(Token = "0x60098EB")]
	[Address(RVA = "0xEB6208", Offset = "0xEB6208", VA = "0xEB6208")]
	private void OnEPLevelProcessUpdate(object[] data)
	{
	}

	[Token(Token = "0x60098EC")]
	[Address(RVA = "0xEABA28", Offset = "0xEABA28", VA = "0xEABA28")]
	public void SetOverMaskShow(bool isShow)
	{
	}

	[Token(Token = "0x60098ED")]
	[Address(RVA = "0xEB647C", Offset = "0xEB647C", VA = "0xEB647C")]
	public void OnEPUnlock(object[] data)
	{
	}

	[Token(Token = "0x60098EE")]
	[Address(RVA = "0xEB6704", Offset = "0xEB6704", VA = "0xEB6704")]
	private void ShowEmulatorErrorWnd(object[] data)
	{
	}

	[Token(Token = "0x60098EF")]
	[Address(RVA = "0xEB6C70", Offset = "0xEB6C70", VA = "0xEB6C70")]
	private void ShowCommonErrorPopupWnd(object[] data)
	{
	}

	[Token(Token = "0x60098F0")]
	[Address(RVA = "0xEB6994", Offset = "0xEB6994", VA = "0xEB6994")]
	private void ShowAutoTaskCommonError(string message, string title, Action callback)
	{
	}

	[Token(Token = "0x60098F1")]
	[Address(RVA = "0xEB6E80", Offset = "0xEB6E80", VA = "0xEB6E80")]
	private void ShowDigitaluniverseBEggVFX(object[] data)
	{
	}

	[Token(Token = "0x60098F2")]
	[Address(RVA = "0xEB7104", Offset = "0xEB7104", VA = "0xEB7104")]
	private void ShowFullScreenPreview(object[] data)
	{
	}

	[Token(Token = "0x60098F3")]
	[Address(RVA = "0xEB72C0", Offset = "0xEB72C0", VA = "0xEB72C0")]
	public bool IsPortraitShow()
	{
		return default(bool);
	}

	[Token(Token = "0x60098F4")]
	[Address(RVA = "0xEB7404", Offset = "0xEB7404", VA = "0xEB7404")]
	private void OnLobbyWeaponRackOpen(object[] data)
	{
	}

	[Token(Token = "0x60098F5")]
	[Address(RVA = "0xEB78B0", Offset = "0xEB78B0", VA = "0xEB78B0")]
	private void OnHDLobbyYardOpen(object[] data)
	{
	}

	[Token(Token = "0x60098F6")]
	[Address(RVA = "0xEB7CA4", Offset = "0xEB7CA4", VA = "0xEB7CA4")]
	private void OnLobbyIceDisplayOpen(object[] data)
	{
	}

	[Token(Token = "0x60098F7")]
	[Address(RVA = "0xEB8224", Offset = "0xEB8224", VA = "0xEB8224")]
	private void OnLobbyVehicleDisplayOpen(object[] data)
	{
	}

	[Token(Token = "0x60098F8")]
	[Address(RVA = "0xEB86D0", Offset = "0xEB86D0", VA = "0xEB86D0")]
	private void OnLobbySkyboardDisplayOpen(object[] data)
	{
	}

	[Token(Token = "0x60098F9")]
	[Address(RVA = "0xEB8B80", Offset = "0xEB8B80", VA = "0xEB8B80")]
	private void ShowDebugBtn(object[] param)
	{
	}

	[Token(Token = "0x60098FA")]
	[Address(RVA = "0xEB9094", Offset = "0xEB9094", VA = "0xEB9094")]
	public bool ProxyBtnState()
	{
		return default(bool);
	}

	[Token(Token = "0x60098FB")]
	[Address(RVA = "0xEB919C", Offset = "0xEB919C", VA = "0xEB919C")]
	private void ShowProxyInfoList(object[] param)
	{
	}

	[Token(Token = "0x60098FC")]
	[Address(RVA = "0xEB951C", Offset = "0xEB951C", VA = "0xEB951C")]
	public bool DebugBtnState()
	{
		return default(bool);
	}

	[Token(Token = "0x60098FD")]
	[Address(RVA = "0xEB9624", Offset = "0xEB9624", VA = "0xEB9624")]
	private bool NeedHide2DObjectNavigation()
	{
		return default(bool);
	}

	[Token(Token = "0x60098FE")]
	[Address(RVA = "0xEB97A8", Offset = "0xEB97A8", VA = "0xEB97A8", Slot = "14")]
	protected override bool OnCheckInviteNtf()
	{
		return default(bool);
	}

	[Token(Token = "0x60098FF")]
	[Address(RVA = "0xEB9930", Offset = "0xEB9930", VA = "0xEB9930")]
	private void OnShowBigEventFriendReunionDialog(object[] data)
	{
	}

	[Token(Token = "0x6009900")]
	[Address(RVA = "0xEB9ADC", Offset = "0xEB9ADC", VA = "0xEB9ADC")]
	private void OnOpenLadderMatchMasterRankUpPopup(object[] data)
	{
	}

	[Token(Token = "0x6009901")]
	[Address(RVA = "0xE9DEF4", Offset = "0xE9DEF4", VA = "0xE9DEF4")]
	private void InitPlannarShadowMaterials()
	{
	}

	[Token(Token = "0x6009902")]
	[Address(RVA = "0xEB9D58", Offset = "0xEB9D58", VA = "0xEB9D58")]
	private void OnQualityChanged(object[] data)
	{
	}

	[Token(Token = "0x6009903")]
	[Address(RVA = "0xEBA12C", Offset = "0xEBA12C", VA = "0xEBA12C")]
	public void SwitchCamera(Camera camera)
	{
	}

	[Token(Token = "0x6009904")]
	[Address(RVA = "0xEBA4C4", Offset = "0xEBA4C4", VA = "0xEBA4C4")]
	private void AddPSCommandBuffer(PlannarShadowRenderer psRenderer)
	{
	}

	[Token(Token = "0x6009905")]
	[Address(RVA = "0xEBA620", Offset = "0xEBA620", VA = "0xEBA620")]
	public void UpdatePlannarShadowMaterials(Transform planeTrans, bool isGreenUp = true, EFrontendPlannarShadowType eFrontendPlannarShadowType = EFrontendPlannarShadowType.Main)
	{
	}

	[Token(Token = "0x6009906")]
	[Address(RVA = "0xE9E1D8", Offset = "0xE9E1D8", VA = "0xE9E1D8")]
	public void AdjustShadowQuality(bool cameraActive)
	{
	}

	[Token(Token = "0x6009907")]
	[Address(RVA = "0xEBA8A4", Offset = "0xEBA8A4", VA = "0xEBA8A4")]
	public void OnCommandBuffersChanged(PlannarShadowRenderer psRenderer, bool isAddPSRenderer)
	{
	}

	[Token(Token = "0x6009908")]
	[Address(RVA = "0xEBAA2C", Offset = "0xEBAA2C", VA = "0xEBAA2C")]
	public void RemovePlannarCommandBuffer(Renderer renderer)
	{
	}

	[Token(Token = "0x6009909")]
	[Address(RVA = "0xEBAB90", Offset = "0xEBAB90", VA = "0xEBAB90")]
	public void CreatePlannarComandBuffer(Renderer renderer, EFrontendPlannarShadowType ePlannarShadowType, bool forceUpdateShadow = false)
	{
	}

	[Token(Token = "0x600990A")]
	[Address(RVA = "0xEBB610", Offset = "0xEBB610", VA = "0xEBB610", Slot = "13")]
	public override bool UseUIPreInstancePool()
	{
		return default(bool);
	}

	[Token(Token = "0x600990C")]
	[Address(RVA = "0xEBB6F0", Offset = "0xEBB6F0", VA = "0xEBB6F0")]
	private static void _003CProcessOpenedByUrl_003Em__0()
	{
	}

	[Token(Token = "0x600990D")]
	[Address(RVA = "0xEBB7F0", Offset = "0xEBB7F0", VA = "0xEBB7F0")]
	private void _003COnLastBattleTimeOut_003Em__1()
	{
	}

	[Token(Token = "0x600990E")]
	[Address(RVA = "0xEBB7F4", Offset = "0xEBB7F4", VA = "0xEBB7F4")]
	private void _003COnLastBattleTimeOut_003Em__2()
	{
	}

	[Token(Token = "0x600990F")]
	[Address(RVA = "0xEBB7F8", Offset = "0xEBB7F8", VA = "0xEBB7F8")]
	private void _003COnStartMatchMaking_003Em__3()
	{
	}

	[Token(Token = "0x6009910")]
	[Address(RVA = "0xEBB8E0", Offset = "0xEBB8E0", VA = "0xEBB8E0")]
	private void _003COnStartMatchMaking_003Em__4()
	{
	}

	[Token(Token = "0x6009911")]
	[Address(RVA = "0xEBB9C8", Offset = "0xEBB9C8", VA = "0xEBB9C8")]
	private void _003COnStartMatchMaking_003Em__5()
	{
	}

	[Token(Token = "0x6009912")]
	[Address(RVA = "0xEBBAA8", Offset = "0xEBBAA8", VA = "0xEBBAA8")]
	private void _003COnGroupStartNtf_003Em__6()
	{
	}

	[Token(Token = "0x6009913")]
	[Address(RVA = "0xEBBC34", Offset = "0xEBBC34", VA = "0xEBBC34")]
	private void _003COnGroupStartNtf_003Em__7()
	{
	}

	[Token(Token = "0x6009914")]
	[Address(RVA = "0xEBBDB8", Offset = "0xEBBDB8", VA = "0xEBBDB8")]
	private static uint _003COnOpenGroup_003Em__8(MapModeData x)
	{
		return default(uint);
	}

	[Token(Token = "0x6009915")]
	[Address(RVA = "0xEBBDDC", Offset = "0xEBBDDC", VA = "0xEBBDDC")]
	private void _003CPlayBGM_003Em__9(bool endByCancle, ResourceID resourceID)
	{
	}

	[Token(Token = "0x6009916")]
	[Address(RVA = "0xEBBEF4", Offset = "0xEBBEF4", VA = "0xEBBEF4")]
	private static void _003CShowEmulatorErrorWnd_003Em__A()
	{
	}

	[Token(Token = "0x6009917")]
	[Address(RVA = "0xEBBFD0", Offset = "0xEBBFD0", VA = "0xEBBFD0")]
	private static void _003CShowDebugBtn_003Em__B(string cmd)
	{
	}

	[Token(Token = "0x6009918")]
	[Address(RVA = "0xEBC094", Offset = "0xEBC094", VA = "0xEBC094")]
	public Transform _003C_003EiFixBaseProxy_FindUIRoot()
	{
		return null;
	}

	[Token(Token = "0x6009919")]
	[Address(RVA = "0xEBC09C", Offset = "0xEBC09C", VA = "0xEBC09C")]
	public void _003C_003EiFixBaseProxy_Destory()
	{
	}

	[Token(Token = "0x600991A")]
	[Address(RVA = "0xEBC0A4", Offset = "0xEBC0A4", VA = "0xEBC0A4")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x600991B")]
	[Address(RVA = "0xEBC0AC", Offset = "0xEBC0AC", VA = "0xEBC0AC")]
	public bool _003C_003EiFixBaseProxy_OnCheckInviteNtf()
	{
		return default(bool);
	}

	[Token(Token = "0x600991C")]
	[Address(RVA = "0xEBC0B4", Offset = "0xEBC0B4", VA = "0xEBC0B4")]
	public bool _003C_003EiFixBaseProxy_UseUIPreInstancePool()
	{
		return default(bool);
	}
}
