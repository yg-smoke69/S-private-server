using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.Gameplay;
using COW.SingerBTimeLine;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x20003BA")]
internal class GameFacade
{
	[Token(Token = "0x20003BB")]
	public enum EMPConnectionType
	{
		[Token(Token = "0x4003854")]
		CREATE_NEW_CONN,
		[Token(Token = "0x4003855")]
		REUSE_OLD_CONN
	}

	[Token(Token = "0x20003BC")]
	private sealed class _003CSendServerRequest_003Ec__AnonStorey0<TRes>
	{
		[Token(Token = "0x4003856")]
		[FieldOffset(Offset = "0x0")]
		internal Action<HttpErrorCode, object> onFinished;

		[Token(Token = "0x6001058")]
		public _003CSendServerRequest_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6001059")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x40037FE")]
	[FieldOffset(Offset = "0x0")]
	public static BaseGame CurrentGame;

	[Token(Token = "0x40037FF")]
	[FieldOffset(Offset = "0x4")]
	private static readonly string KEY_IS_BLACK_BLOOD;

	[Token(Token = "0x4003800")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string KEY_CUSTOMROOM_IS_BLOOD_SHOW;

	[Token(Token = "0x4003801")]
	[FieldOffset(Offset = "0xC")]
	private static readonly string KEY_CUSTOMROOM_IS_SAFEZONE_DAMAGE_EFFECT_SHOW;

	[Token(Token = "0x4003802")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string KEY_DEMAGE_LABELTYPE;

	[Token(Token = "0x4003803")]
	[FieldOffset(Offset = "0x14")]
	public static readonly string UILOADING;

	[Token(Token = "0x4003804")]
	[FieldOffset(Offset = "0x18")]
	private static BloodType m_bloodType;

	[Token(Token = "0x4003805")]
	[FieldOffset(Offset = "0x1C")]
	private static BloodConfigType m_BloodConfigType;

	[Token(Token = "0x4003806")]
	[FieldOffset(Offset = "0x20")]
	public static readonly bool IsPCClient;

	[Token(Token = "0x4003807")]
	[FieldOffset(Offset = "0x28")]
	public static ulong LocalPlayerUserID;

	[Token(Token = "0x4003808")]
	[FieldOffset(Offset = "0x30")]
	public static byte RegionID;

	[Token(Token = "0x4003809")]
	[FieldOffset(Offset = "0x34")]
	public static string RegionName;

	[Token(Token = "0x400380A")]
	[FieldOffset(Offset = "0x38")]
	public static string NotiRegionName;

	[Token(Token = "0x400380B")]
	[FieldOffset(Offset = "0x3C")]
	public static bool OfflineMode;

	[Token(Token = "0x400380C")]
	[FieldOffset(Offset = "0x40")]
	public static string GameServerAddr;

	[Token(Token = "0x400380D")]
	[FieldOffset(Offset = "0x44")]
	public static int GameServerPort;

	[Token(Token = "0x400380E")]
	[FieldOffset(Offset = "0x48")]
	public static ulong GameServerMatchID;

	[Token(Token = "0x400380F")]
	[FieldOffset(Offset = "0x50")]
	public static ulong GameServerServiceMatchID;

	[Token(Token = "0x4003810")]
	[FieldOffset(Offset = "0x58")]
	public static string GameServerToken;

	[Token(Token = "0x4003811")]
	[FieldOffset(Offset = "0x5C")]
	public static string GameServerSecretKey;

	[Token(Token = "0x4003812")]
	[FieldOffset(Offset = "0x60")]
	private static MapConfigData m_GameServerMapConfigData;

	[Token(Token = "0x4003813")]
	[FieldOffset(Offset = "0x64")]
	private static uint m_GameServerMapID;

	[Token(Token = "0x4003814")]
	[FieldOffset(Offset = "0x68")]
	private static uint m_GameServerGameMode;

	[Token(Token = "0x4003815")]
	[FieldOffset(Offset = "0x6C")]
	public static uint GameServerMatchMode;

	[Token(Token = "0x4003816")]
	[FieldOffset(Offset = "0x70")]
	public static uint GameServerGroupMode;

	[Token(Token = "0x4003817")]
	[FieldOffset(Offset = "0x74")]
	public static uint GameServerRoomRole;

	[Token(Token = "0x4003818")]
	[FieldOffset(Offset = "0x78")]
	public static uint GameServerRoomType;

	[Token(Token = "0x4003819")]
	[FieldOffset(Offset = "0x7C")]
	public static uint GameServerDifficult;

	[Token(Token = "0x400381A")]
	[FieldOffset(Offset = "0x80")]
	public static int LastGameReturnToLobbyReason;

	[Token(Token = "0x400381B")]
	[FieldOffset(Offset = "0x84")]
	public static bool IsReconnect;

	[Token(Token = "0x400381C")]
	[FieldOffset(Offset = "0x85")]
	public static bool NeedClearReconnectInfo;

	[Token(Token = "0x400381D")]
	[FieldOffset(Offset = "0x86")]
	public static bool IsObserver;

	[Token(Token = "0x400381E")]
	[FieldOffset(Offset = "0x87")]
	public static bool LastGameNeedReconnect;

	[Token(Token = "0x400381F")]
	[FieldOffset(Offset = "0x88")]
	public static bool LastGameNeedReconnectIsWaitingIsland;

	[Token(Token = "0x4003820")]
	[FieldOffset(Offset = "0x8C")]
	public static string LastGameReturnToLobbyReasonTxt;

	[Token(Token = "0x4003821")]
	[FieldOffset(Offset = "0x90")]
	public static ulong LastGameNeedReconnectServiceMatchID;

	[Token(Token = "0x4003822")]
	[FieldOffset(Offset = "0x98")]
	public static uint LastGameReconnectTimes;

	[Token(Token = "0x4003823")]
	[FieldOffset(Offset = "0xA0")]
	public static ulong LastGameReconnectStartMoment;

	[Token(Token = "0x4003824")]
	[FieldOffset(Offset = "0xA8")]
	public static uint LobbyCustomRoomIndex;

	[Token(Token = "0x4003825")]
	[FieldOffset(Offset = "0xAC")]
	public static uint InGameCustomRoomIndex;

	[Token(Token = "0x4003826")]
	[FieldOffset(Offset = "0xB0")]
	public static bool IsROGPhone;

	[Token(Token = "0x4003827")]
	[FieldOffset(Offset = "0xB1")]
	public static bool IsSpecialPool;

	[Token(Token = "0x4003828")]
	[FieldOffset(Offset = "0xB2")]
	public static bool IsEmulatorPool;

	[Token(Token = "0x4003829")]
	[FieldOffset(Offset = "0xB3")]
	public static bool GameMainSceneLoadedByAb;

	[Token(Token = "0x400382A")]
	[FieldOffset(Offset = "0xB4")]
	public static byte[] GameServerUGCLevelDataBytes;

	[Token(Token = "0x400382B")]
	[FieldOffset(Offset = "0xB8")]
	public static byte[] GameServerWorkshopSettings;

	[Token(Token = "0x400382C")]
	[FieldOffset(Offset = "0xBC")]
	public static byte[] GameServerWorkshopModeSettings;

	[Token(Token = "0x400382D")]
	[FieldOffset(Offset = "0xC0")]
	public static FEIGJAGLKLM GameServerWorkshopModeSettingsDeserialized;

	[Token(Token = "0x400382E")]
	[FieldOffset(Offset = "0xC4")]
	public static byte[] GameServerWorkshopObjectAttributeSettings;

	[Token(Token = "0x400382F")]
	[FieldOffset(Offset = "0xC8")]
	public static string GameServerWorkshopShareCode;

	[Token(Token = "0x4003830")]
	[FieldOffset(Offset = "0xCC")]
	public static string GameServerWorkshopMapName;

	[Token(Token = "0x4003831")]
	[FieldOffset(Offset = "0xD0")]
	public static bool IsWaitingRoom;

	[Token(Token = "0x4003832")]
	[FieldOffset(Offset = "0xD1")]
	public static bool IsMatchStarted;

	[Token(Token = "0x4003833")]
	[FieldOffset(Offset = "0xD4")]
	public static uint LevelVisualStyle;

	[Token(Token = "0x4003834")]
	[FieldOffset(Offset = "0xD8")]
	private static bool _IsAddicticUser;

	[Token(Token = "0x4003835")]
	[FieldOffset(Offset = "0xD9")]
	private static bool _IsAddictMatchUser;

	[Token(Token = "0x4003836")]
	[FieldOffset(Offset = "0xDC")]
	public static string AddicticFloating;

	[Token(Token = "0x4003837")]
	[FieldOffset(Offset = "0xE0")]
	public static ulong AddictAllTime;

	[Token(Token = "0x4003838")]
	[FieldOffset(Offset = "0xE8")]
	public static ulong AddictMatchTime;

	[Token(Token = "0x4003839")]
	[FieldOffset(Offset = "0xF0")]
	public static ulong StartTvTime;

	[Token(Token = "0x400383A")]
	[FieldOffset(Offset = "0xF8")]
	public static ulong FinishTvTime;

	[Token(Token = "0x400383B")]
	[FieldOffset(Offset = "0x100")]
	public static ulong LastTvTime;

	[Token(Token = "0x400383C")]
	[FieldOffset(Offset = "0x108")]
	public static bool _DeviceMaxConfirm;

	[Token(Token = "0x400383D")]
	[FieldOffset(Offset = "0x10C")]
	public static uint chessType;

	[Token(Token = "0x400383E")]
	[FieldOffset(Offset = "0x110")]
	public static bool UseBountyWaitingIsland;

	[Token(Token = "0x400383F")]
	[FieldOffset(Offset = "0x114")]
	public static uint booyahtimes;

	[Token(Token = "0x4003840")]
	[FieldOffset(Offset = "0x118")]
	public static bool EnableAutoTestScene;

	[Token(Token = "0x4003841")]
	[FieldOffset(Offset = "0x119")]
	public static bool ReleaseLightmapMemoryOnUnloading;

	[Token(Token = "0x4003842")]
	[FieldOffset(Offset = "0x11A")]
	public static bool UnloadEmbeddedSceneObjects;

	[Token(Token = "0x4003843")]
	[FieldOffset(Offset = "0x11C")]
	private static List<uint> m_FootstepEnableMaps;

	[Token(Token = "0x4003844")]
	[FieldOffset(Offset = "0x120")]
	public static bool IsUGCUserEventlogSended;

	[Token(Token = "0x4003845")]
	[FieldOffset(Offset = "0x124")]
	public static string[] m_WeaponDecreaseBackType;

	[Token(Token = "0x4003846")]
	[FieldOffset(Offset = "0x128")]
	public static bool IsUnLoadCSVDataFromMemory;

	[Token(Token = "0x4003847")]
	[FieldOffset(Offset = "0x129")]
	private static bool _003CPopEvents_003Ek__BackingField;

	[Token(Token = "0x4003848")]
	[FieldOffset(Offset = "0x12A")]
	public static bool IsGroupUIOpen;

	[Token(Token = "0x4003849")]
	[FieldOffset(Offset = "0x12C")]
	private static Dictionary<uint, string> m_GameModeIDToNameDic;

	[Token(Token = "0x400384A")]
	public const float DEFAULT_TIME_SCALE = 1f;

	[Token(Token = "0x400384B")]
	[FieldOffset(Offset = "0x130")]
	private static uint _003CResourceLoadCount_003Ek__BackingField;

	[Token(Token = "0x400384C")]
	[FieldOffset(Offset = "0x134")]
	private static bool openingMovieRegionEnable;

	[Token(Token = "0x400384D")]
	[FieldOffset(Offset = "0x138")]
	public static double SingersBSeverTimeLineBeginTime;

	[Token(Token = "0x400384E")]
	[FieldOffset(Offset = "0x140")]
	public static double SingerBMainTimeLineCurTime;

	[Token(Token = "0x400384F")]
	[FieldOffset(Offset = "0x148")]
	public static bool IsMainTimeLineStuckByPlayAsycnLoadSubTimeLine;

	[Token(Token = "0x4003850")]
	[FieldOffset(Offset = "0x149")]
	public static bool IsCurSingerBUseEventUIMatchMaking;

	[Token(Token = "0x4003851")]
	[FieldOffset(Offset = "0x14A")]
	private static bool m_EmulatorChecked;

	[Token(Token = "0x4003852")]
	[FieldOffset(Offset = "0x14B")]
	private static bool m_IsEmulator;

	[Token(Token = "0x17000184")]
	public static MapConfigData GameServerMapConfigData
	{
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x1069000", Offset = "0x1069000", VA = "0x1069000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000185")]
	public static uint GameServerMapID
	{
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x1069250", Offset = "0x1069250", VA = "0x1069250")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x10693F0", Offset = "0x10693F0", VA = "0x10693F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000186")]
	public static uint GameServerGameMode
	{
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x1069320", Offset = "0x1069320", VA = "0x1069320")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x10694CC", Offset = "0x10694CC", VA = "0x10694CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000187")]
	public static byte OptionalBuff
	{
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x10695A8", Offset = "0x10695A8", VA = "0x10695A8")]
		get
		{
			return default(byte);
		}
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x1069688", Offset = "0x1069688", VA = "0x1069688")]
		set
		{
		}
	}

	[Token(Token = "0x17000188")]
	public static int UseNewRunning
	{
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x106A3C0", Offset = "0x106A3C0", VA = "0x106A3C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x106A498", Offset = "0x106A498", VA = "0x106A498")]
		set
		{
		}
	}

	[Token(Token = "0x17000189")]
	public static bool UseBooyahEmote
	{
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x106A578", Offset = "0x106A578", VA = "0x106A578")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x106A660", Offset = "0x106A660", VA = "0x106A660")]
		set
		{
		}
	}

	[Token(Token = "0x1700018A")]
	public static bool IsDebtUser
	{
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x106A778", Offset = "0x106A778", VA = "0x106A778")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700018B")]
	public static bool IsAddicticUser
	{
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x106A894", Offset = "0x106A894", VA = "0x106A894")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x106A964", Offset = "0x106A964", VA = "0x106A964")]
		set
		{
		}
	}

	[Token(Token = "0x1700018C")]
	public static bool DeviceMaxConfirm
	{
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x106AA3C", Offset = "0x106AA3C", VA = "0x106AA3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x106AB0C", Offset = "0x106AB0C", VA = "0x106AB0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700018D")]
	public static bool IsAddicticMatchUser
	{
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x106ABE4", Offset = "0x106ABE4", VA = "0x106ABE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x106ACB4", Offset = "0x106ACB4", VA = "0x106ACB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700018E")]
	public static bool PopEvents
	{
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x106AD8C", Offset = "0x106AD8C", VA = "0x106AD8C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x106AE18", Offset = "0x106AE18", VA = "0x106AE18")]
		private set
		{
		}
	}

	[Token(Token = "0x1700018F")]
	public static bool IsUsePCWaitingRoomRankUI
	{
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x106AEA8", Offset = "0x106AEA8", VA = "0x106AEA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000190")]
	public static uint ResourceLoadCount
	{
		[Token(Token = "0x600101B")]
		[Address(RVA = "0x107B604", Offset = "0x107B604", VA = "0x107B604")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600101C")]
		[Address(RVA = "0x107B690", Offset = "0x107B690", VA = "0x107B690")]
		set
		{
		}
	}

	[Token(Token = "0x17000191")]
	public static bool IsFriendDamage
	{
		[Token(Token = "0x600101D")]
		[Address(RVA = "0x107B720", Offset = "0x107B720", VA = "0x107B720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x1068FF8", Offset = "0x1068FF8", VA = "0x1068FF8")]
	public GameFacade()
	{
	}

	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x10690D0", Offset = "0x10690D0", VA = "0x10690D0")]
	private static void RefreshMapConfig()
	{
	}

	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x106976C", Offset = "0x106976C", VA = "0x106976C")]
	public static void ToggleAllCameraUI()
	{
	}

	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x1069CF8", Offset = "0x1069CF8", VA = "0x1069CF8")]
	public static bool IsBackDecreaseWeaponType(int WeaponType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x1069F60", Offset = "0x1069F60", VA = "0x1069F60")]
	public static bool IsFootstepEnableInCurrentMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x106AF78", Offset = "0x106AF78", VA = "0x106AF78")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x106B0C0", Offset = "0x106B0C0", VA = "0x106B0C0")]
	public static void SetCurrentGame(BaseGame game)
	{
	}

	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x106B270", Offset = "0x106B270", VA = "0x106B270")]
	public static UICOWBaseScene CurrentUIScene()
	{
		return null;
	}

	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x106B3F0", Offset = "0x106B3F0", VA = "0x106B3F0")]
	public static UIInGameScene CurrentInGameUIScene()
	{
		return null;
	}

	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x106B4F8", Offset = "0x106B4F8", VA = "0x106B4F8")]
	public static UIForceTutorialGameScene ForceTutorialGameUIScene()
	{
		return null;
	}

	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x106B600", Offset = "0x106B600", VA = "0x106B600")]
	public static UITutorialCSGameScene TutorialCSGameUIScene()
	{
		return null;
	}

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x106B708", Offset = "0x106B708", VA = "0x106B708")]
	public static TimeService CurrentGameTimer()
	{
		return null;
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x106B7F4", Offset = "0x106B7F4", VA = "0x106B7F4")]
	public static void SetTimeScale(float scale = 1f)
	{
	}

	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x106B858", Offset = "0x106B858", VA = "0x106B858")]
	public static void ResetTimeScale()
	{
	}

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x10488B8", Offset = "0x10488B8", VA = "0x10488B8")]
	public static EventDispatcher CurrentGameEventDispatcher()
	{
		return null;
	}

	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x106B8B4", Offset = "0x106B8B4", VA = "0x106B8B4")]
	public static TimeService CurrentGameSimulationTimer()
	{
		return null;
	}

	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x106B9A0", Offset = "0x106B9A0", VA = "0x106B9A0")]
	public static float CurrentGameFixedDeltaTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x106BAAC", Offset = "0x106BAAC", VA = "0x106BAAC")]
	public static GNNJIHNFAEJ CurrentLudoManager()
	{
		return null;
	}

	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x106BC9C", Offset = "0x106BC9C", VA = "0x106BC9C")]
	public static IFNFNDJLKIF CurrentLevelObjectManager()
	{
		return null;
	}

	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x106BE8C", Offset = "0x106BE8C", VA = "0x106BE8C")]
	public static ADMPIKLECJF CurrentMetaManager()
	{
		return null;
	}

	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x106C07C", Offset = "0x106C07C", VA = "0x106C07C")]
	public static GameModeSetting CurrentGameModeSetting()
	{
		return null;
	}

	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x106C250", Offset = "0x106C250", VA = "0x106C250")]
	public static bool IsGamePaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x106C424", Offset = "0x106C424", VA = "0x106C424")]
	public static bool IsFrontEndGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x106C53C", Offset = "0x106C53C", VA = "0x106C53C")]
	public static NFJPHMKKEBF CurrentMatch()
	{
		return null;
	}

	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x106C72C", Offset = "0x106C72C", VA = "0x106C72C")]
	public static ulong GetLocalPlayerUserID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x106C7FC", Offset = "0x106C7FC", VA = "0x106C7FC")]
	public static AEPAPLNNAHF CurrentLocalPawn()
	{
		return null;
	}

	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x106D22C", Offset = "0x106D22C", VA = "0x106D22C")]
	public static Player GetLocalPlayerOrObServer()
	{
		return null;
	}

	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x106C92C", Offset = "0x106C92C", VA = "0x106C92C")]
	public static Player CurrentLocalPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x106DA7C", Offset = "0x106DA7C", VA = "0x106DA7C")]
	public static PlayerWereWolves CurrentLocalWereWolvesPlayer()
	{
		return null;
	}

	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x106DB84", Offset = "0x106DB84", VA = "0x106DB84")]
	public static Player CurrentLocalPlayerWithPending()
	{
		return null;
	}

	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x106DEC4", Offset = "0x106DEC4", VA = "0x106DEC4")]
	public static IHAAMHPPLMG CurrentLocalPlayerID()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x106E21C", Offset = "0x106E21C", VA = "0x106E21C")]
	public static uint CurrentLocalPlayerTeamIndex()
	{
		return default(uint);
	}

	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x106CC2C", Offset = "0x106CC2C", VA = "0x106CC2C")]
	public static FNCMBMMKLLI CurrentLocalObserver()
	{
		return null;
	}

	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x106CF2C", Offset = "0x106CF2C", VA = "0x106CF2C")]
	public static FOFJEMOKAOH CurrentLocalSpectator()
	{
		return null;
	}

	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x106E51C", Offset = "0x106E51C", VA = "0x106E51C")]
	public static Player GetLocalPlayerOrObserverTarget()
	{
		return null;
	}

	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x106E6DC", Offset = "0x106E6DC", VA = "0x106E6DC")]
	public static SceneEditAgent CurrentSceneEditAgent()
	{
		return null;
	}

	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x106E92C", Offset = "0x106E92C", VA = "0x106E92C")]
	public static JPPGAJBAAKK CurrentSceneEditGame()
	{
		return null;
	}

	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x106EABC", Offset = "0x106EABC", VA = "0x106EABC")]
	public static bool IsCurrentSceneEditGameInEditMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x106ECB8", Offset = "0x106ECB8", VA = "0x106ECB8")]
	public static bool IsCurrentSceneEditGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x106EDBC", Offset = "0x106EDBC", VA = "0x106EDBC")]
	public static KEMMDGJBJNO CurrentSceneBuilder()
	{
		return null;
	}

	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x106F13C", Offset = "0x106F13C", VA = "0x106F13C")]
	public static bool IsSameFaction(Player p1, Player p2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x106F2DC", Offset = "0x106F2DC", VA = "0x106F2DC")]
	public static bool IsSameTeam(Player p1, Player p2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x106F614", Offset = "0x106F614", VA = "0x106F614")]
	public static bool IsSameTeam(IHAAMHPPLMG p1, IHAAMHPPLMG p2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x106F8C4", Offset = "0x106F8C4", VA = "0x106F8C4")]
	public static bool CheckSameTeam(Player p1, Player p2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x106D434", Offset = "0x106D434", VA = "0x106D434")]
	public static NOEJJKNAKNC CurrentLocalFixedObserverEntity()
	{
		return null;
	}

	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x106FBDC", Offset = "0x106FBDC", VA = "0x106FBDC")]
	public static float GetRevisedValueByFPS(float v, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x106FC58", Offset = "0x106FC58", VA = "0x106FC58")]
	public static float GetRevisedValueBySystemFPS(float v)
	{
		return default(float);
	}

	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x106FD30", Offset = "0x106FD30", VA = "0x106FD30")]
	public static bool IsOnlineGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x106FF04", Offset = "0x106FF04", VA = "0x106FF04")]
	public static bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x1070040", Offset = "0x1070040", VA = "0x1070040")]
	private static MatchGameClient CurretOnlineMatchClient()
	{
		return null;
	}

	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x1070228", Offset = "0x1070228", VA = "0x1070228")]
	public static float CurrentServerTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x1070454", Offset = "0x1070454", VA = "0x1070454")]
	public static uint CurrentServerTick()
	{
		return default(uint);
	}

	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x1070680", Offset = "0x1070680", VA = "0x1070680")]
	public static CameraControllerManager CurrentCameraControllerManager()
	{
		return null;
	}

	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x1070870", Offset = "0x1070870", VA = "0x1070870")]
	public static void EventsPopupDone()
	{
	}

	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x1070930", Offset = "0x1070930", VA = "0x1070930")]
	public static bool CanShowLobbyTaskEntry()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x1070E1C", Offset = "0x1070E1C", VA = "0x1070E1C")]
	public static void SyncBloodOptionConfig()
	{
	}

	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x10715DC", Offset = "0x10715DC", VA = "0x10715DC")]
	public static BloodConfigType GetCurrentBloodConfigType()
	{
		return default(BloodConfigType);
	}

	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x10716AC", Offset = "0x10716AC", VA = "0x10716AC")]
	public static bool NeedShowBloodOption()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x1071770", Offset = "0x1071770", VA = "0x1071770")]
	public static BloodType GetCurrentBloodType(bool pcIgnoreBloodSwitch = false)
	{
		return default(BloodType);
	}

	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x10717C8", Offset = "0x10717C8", VA = "0x10717C8")]
	public static BloodType GetCurrentSafeZoneDmgEffectType(bool pcIgnoreBloodSwitch = false)
	{
		return default(BloodType);
	}

	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x107147C", Offset = "0x107147C", VA = "0x107147C")]
	public static void SetCurrentBloodType(BloodType bloodType)
	{
	}

	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x1071820", Offset = "0x1071820", VA = "0x1071820")]
	public static bool GetBloodVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x1071940", Offset = "0x1071940", VA = "0x1071940")]
	public static bool GetSafeZoneDmgEffectVisibility()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x1071A60", Offset = "0x1071A60", VA = "0x1071A60")]
	public static void SetBloodVisibility(bool visibility)
	{
	}

	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x1071BEC", Offset = "0x1071BEC", VA = "0x1071BEC")]
	public static void SetDamageLabelType(int type)
	{
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x1071D04", Offset = "0x1071D04", VA = "0x1071D04")]
	public static int GetDamageLabelType()
	{
		return default(int);
	}

	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x1071E14", Offset = "0x1071E14", VA = "0x1071E14")]
	public static void SetSafeZoneDmgEffectVisibility(bool visibility)
	{
	}

	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x1071FA0", Offset = "0x1071FA0", VA = "0x1071FA0")]
	public static void LoadMPBattleGame(EMPConnectionType connType)
	{
	}

	[Token(Token = "0x6000FC1")]
	[Address(RVA = "0x1075420", Offset = "0x1075420", VA = "0x1075420")]
	public static void LoadMPWaitingGame()
	{
	}

	[Token(Token = "0x6000FC2")]
	public static HttpRequest SendServerRequest<TRes>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0u, bool encrypt = true, LoadingType loadingType = LoadingType.CircleLoading)
	{
		return null;
	}

	[Token(Token = "0x6000FC3")]
	[Address(RVA = "0x10755E4", Offset = "0x10755E4", VA = "0x10755E4")]
	public static void ReportNetworkMetricEvent(NetworkMetricEvent networkMetricEvent, string network_detail = "")
	{
	}

	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x10758AC", Offset = "0x10758AC", VA = "0x10758AC")]
	public static bool IsCurrentGameMode(uint gamemode, bool gamemodeNoneFilter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x10759B0", Offset = "0x10759B0", VA = "0x10759B0")]
	public static bool IsCasualMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x1075A88", Offset = "0x1075A88", VA = "0x1075A88")]
	public static bool IsCSRanking()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x1075B64", Offset = "0x1075B64", VA = "0x1075B64")]
	public static bool IsFuncAliveLoadingShowPlayerInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x1075C58", Offset = "0x1075C58", VA = "0x1075C58")]
	public static bool DoesLoadingShowPlayerInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x1075D34", Offset = "0x1075D34", VA = "0x1075D34")]
	public static bool IsPeriodicRanking()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x1075E10", Offset = "0x1075E10", VA = "0x1075E10")]
	public static bool IsCustomRoom()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x1075EEC", Offset = "0x1075EEC", VA = "0x1075EEC")]
	public static bool IsCustomRoomCasual()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x1076004", Offset = "0x1076004", VA = "0x1076004")]
	public static bool IsCustomRoomLeague()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x107615C", Offset = "0x107615C", VA = "0x107615C")]
	public static bool IsCustomRoomWorkshop()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCE")]
	[Address(RVA = "0x1076278", Offset = "0x1076278", VA = "0x1076278")]
	public static bool IsSpectatorOrCreator()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FCF")]
	[Address(RVA = "0x10763D4", Offset = "0x10763D4", VA = "0x10763D4")]
	public static bool IsWorkShopShowFeedBackQuit()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD0")]
	[Address(RVA = "0x1076718", Offset = "0x1076718", VA = "0x1076718")]
	public static bool IsWaitingRoomType()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x1076864", Offset = "0x1076864", VA = "0x1076864")]
	public static bool IsBattleRoyale()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0x1076928", Offset = "0x1076928", VA = "0x1076928")]
	public static bool IsTutorialBR()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x10769F4", Offset = "0x10769F4", VA = "0x10769F4")]
	public static bool IsTutorialCS()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x1076AC0", Offset = "0x1076AC0", VA = "0x1076AC0")]
	public static bool IsSpeedMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD5")]
	[Address(RVA = "0x1076BCC", Offset = "0x1076BCC", VA = "0x1076BCC")]
	public static bool IsHyakkiMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD6")]
	[Address(RVA = "0x1076C98", Offset = "0x1076C98", VA = "0x1076C98")]
	public static bool EnableOnBoardFlight()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x1076F54", Offset = "0x1076F54", VA = "0x1076F54")]
	public static bool IsGameAllowFlight()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x1077128", Offset = "0x1077128", VA = "0x1077128")]
	public static bool UseNewDeathCamera()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD9")]
	[Address(RVA = "0x1077324", Offset = "0x1077324", VA = "0x1077324")]
	public static bool IsRebornMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x10773F0", Offset = "0x10773F0", VA = "0x10773F0")]
	public static bool IsCSMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0x1077530", Offset = "0x1077530", VA = "0x1077530")]
	public static bool IsFateRandomMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0x10775FC", Offset = "0x10775FC", VA = "0x10775FC")]
	public static bool IsFightClubMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0x10776C8", Offset = "0x10776C8", VA = "0x10776C8")]
	public static bool IsFateRoyaleMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x1077794", Offset = "0x1077794", VA = "0x1077794")]
	public static bool IsFateRoyaleFastMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x1077860", Offset = "0x1077860", VA = "0x1077860")]
	public static bool IsTKMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x107792C", Offset = "0x107792C", VA = "0x107792C")]
	public static bool IsTDMMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x10779F8", Offset = "0x10779F8", VA = "0x10779F8")]
	public static bool IsGuildWarMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x1077AC4", Offset = "0x1077AC4", VA = "0x1077AC4")]
	public static bool IsTokenMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0x1077B90", Offset = "0x1077B90", VA = "0x1077B90")]
	public static bool IsGiantMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x1077C5C", Offset = "0x1077C5C", VA = "0x1077C5C")]
	public static bool IsArmsRaceMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x1077D28", Offset = "0x1077D28", VA = "0x1077D28")]
	public static bool IsHappyFridayMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE6")]
	[Address(RVA = "0x1077DF4", Offset = "0x1077DF4", VA = "0x1077DF4")]
	public static bool IsArmsRaceTeamMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x1077EC0", Offset = "0x1077EC0", VA = "0x1077EC0")]
	public static bool IsReaperMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE8")]
	[Address(RVA = "0x1077F8C", Offset = "0x1077F8C", VA = "0x1077F8C")]
	public static bool IsBombMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE9")]
	[Address(RVA = "0x1078058", Offset = "0x1078058", VA = "0x1078058")]
	public static bool IsKJPMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FEA")]
	[Address(RVA = "0x106FB10", Offset = "0x106FB10", VA = "0x106FB10")]
	public static bool IsTrainingMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FEB")]
	[Address(RVA = "0x1078124", Offset = "0x1078124", VA = "0x1078124")]
	public static bool IsNoPlayDeadGameMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0x107821C", Offset = "0x107821C", VA = "0x107821C")]
	public static bool IsPartyMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FED")]
	[Address(RVA = "0x10783B4", Offset = "0x10783B4", VA = "0x10783B4")]
	public static bool IsWinnerTakeAllMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0x1078480", Offset = "0x1078480", VA = "0x1078480")]
	public static bool IsHypeRelatedMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FEF")]
	[Address(RVA = "0x107891C", Offset = "0x107891C", VA = "0x107891C")]
	public static bool IsZombiePlusMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0x10785EC", Offset = "0x10785EC", VA = "0x10785EC")]
	public static bool IsHypeMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0x10786B8", Offset = "0x10786B8", VA = "0x10786B8")]
	public static bool IsSnowManMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x1078784", Offset = "0x1078784", VA = "0x1078784")]
	public static bool IsFourSymbolsMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0x10789E8", Offset = "0x10789E8", VA = "0x10789E8")]
	public static bool IsSnowManModeBattleGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x1078B2C", Offset = "0x1078B2C", VA = "0x1078B2C")]
	public static bool IsBigHeadMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x1078BF8", Offset = "0x1078BF8", VA = "0x1078BF8")]
	public static bool IsAttackOnHeadMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x1078CC4", Offset = "0x1078CC4", VA = "0x1078CC4")]
	public static bool IsDGGMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x1078D90", Offset = "0x1078D90", VA = "0x1078D90")]
	public static bool IsControlMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x1078E5C", Offset = "0x1078E5C", VA = "0x1078E5C")]
	public static bool IsCSStrikeOutMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x1078F28", Offset = "0x1078F28", VA = "0x1078F28")]
	public static bool IsTeamCsMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FFA")]
	[Address(RVA = "0x10790A0", Offset = "0x10790A0", VA = "0x10790A0")]
	public static bool IsBanknoteMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x107916C", Offset = "0x107916C", VA = "0x107916C")]
	public static bool IsADSMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x1079238", Offset = "0x1079238", VA = "0x1079238")]
	public static bool IsWereWolvesMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x1079304", Offset = "0x1079304", VA = "0x1079304")]
	public static bool IsLudoMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x10793D0", Offset = "0x10793D0", VA = "0x10793D0")]
	public static bool IsRushingPetsMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x1076578", Offset = "0x1076578", VA = "0x1076578")]
	public static bool IsWorkshopMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6001000")]
	[Address(RVA = "0x107949C", Offset = "0x107949C", VA = "0x107949C")]
	public static bool IsWorkshopMap(uint mapID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001001")]
	[Address(RVA = "0x1079510", Offset = "0x1079510", VA = "0x1079510")]
	public static bool IsUGCPartyMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6001002")]
	[Address(RVA = "0x10795DC", Offset = "0x10795DC", VA = "0x10795DC")]
	public static bool IsLWSOMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6001003")]
	[Address(RVA = "0x1078850", Offset = "0x1078850", VA = "0x1078850")]
	public static bool IsFlagBattleMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6001004")]
	[Address(RVA = "0x10796A8", Offset = "0x10796A8", VA = "0x10796A8")]
	public static bool IsUGCCommonMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6001005")]
	[Address(RVA = "0x10797B4", Offset = "0x10797B4", VA = "0x10797B4")]
	public static bool IsUGCCommonMode(uint gameMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6001006")]
	[Address(RVA = "0x1079820", Offset = "0x1079820", VA = "0x1079820")]
	public static bool IsUGCPVETtemplate(int gsModeTemplateID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001007")]
	[Address(RVA = "0x107988C", Offset = "0x107988C", VA = "0x107988C")]
	public static bool IsPDMMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6001008")]
	[Address(RVA = "0x1079958", Offset = "0x1079958", VA = "0x1079958")]
	public static bool IsUGCInfectionMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6001009")]
	[Address(RVA = "0x106F558", Offset = "0x106F558", VA = "0x106F558")]
	public static bool IsTeammateOfSameFaction()
	{
		return default(bool);
	}

	[Token(Token = "0x600100A")]
	[Address(RVA = "0x1079A24", Offset = "0x1079A24", VA = "0x1079A24")]
	public static bool IsSkyDivingRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x600100B")]
	[Address(RVA = "0x1079B58", Offset = "0x1079B58", VA = "0x1079B58")]
	public static bool IsLowFallingRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x600100C")]
	[Address(RVA = "0x1079C14", Offset = "0x1079C14", VA = "0x1079C14")]
	public static bool IsPlayerReadyNeedDelay()
	{
		return default(bool);
	}

	[Token(Token = "0x600100D")]
	[Address(RVA = "0x1079F00", Offset = "0x1079F00", VA = "0x1079F00")]
	public static bool GameModeSupportRevive()
	{
		return default(bool);
	}

	[Token(Token = "0x600100E")]
	[Address(RVA = "0x107A0DC", Offset = "0x107A0DC", VA = "0x107A0DC")]
	public static void SetFrameRate(bool isHighFrameRate)
	{
	}

	[Token(Token = "0x600100F")]
	[Address(RVA = "0x107A1C8", Offset = "0x107A1C8", VA = "0x107A1C8")]
	public static int GetFrameRate()
	{
		return default(int);
	}

	[Token(Token = "0x6001010")]
	[Address(RVA = "0x107A220", Offset = "0x107A220", VA = "0x107A220")]
	public static bool IsNoWaitingRoomGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6001011")]
	[Address(RVA = "0x107A3B4", Offset = "0x107A3B4", VA = "0x107A3B4")]
	public static bool IsNoSafeZone()
	{
		return default(bool);
	}

	[Token(Token = "0x6001012")]
	[Address(RVA = "0x107A4E8", Offset = "0x107A4E8", VA = "0x107A4E8")]
	public static bool IsNoJumping()
	{
		return default(bool);
	}

	[Token(Token = "0x6001013")]
	[Address(RVA = "0x107A61C", Offset = "0x107A61C", VA = "0x107A61C")]
	public static bool IsGameSafeZoneIgnoreFirstOne()
	{
		return default(bool);
	}

	[Token(Token = "0x6001014")]
	[Address(RVA = "0x107A8BC", Offset = "0x107A8BC", VA = "0x107A8BC")]
	public static bool UseMobileHardwardInput()
	{
		return default(bool);
	}

	[Token(Token = "0x6001015")]
	[Address(RVA = "0x107A90C", Offset = "0x107A90C", VA = "0x107A90C")]
	public static bool ShowGuideToSafeZone()
	{
		return default(bool);
	}

	[Token(Token = "0x6001016")]
	[Address(RVA = "0x107AC3C", Offset = "0x107AC3C", VA = "0x107AC3C")]
	public static InGameCutsceneManager CurrentInGameCutsceneManager()
	{
		return null;
	}

	[Token(Token = "0x6001017")]
	[Address(RVA = "0x107AE2C", Offset = "0x107AE2C", VA = "0x107AE2C")]
	public static void RegisterInGameCutsceneManager(InGameCutsceneManager manager)
	{
	}

	[Token(Token = "0x6001018")]
	[Address(RVA = "0x107B024", Offset = "0x107B024", VA = "0x107B024")]
	public static void PlayUIBlackMaskAnim(EMaskAnimType animType, float fadeDuration, float lightDuration, float stableDuration, bool disableMaskAfterFinished = true)
	{
	}

	[Token(Token = "0x6001019")]
	[Address(RVA = "0x107B3A8", Offset = "0x107B3A8", VA = "0x107B3A8")]
	public static bool IsBossByType(LAKANBFBEOK aiType)
	{
		return default(bool);
	}

	[Token(Token = "0x600101A")]
	[Address(RVA = "0x107B420", Offset = "0x107B420", VA = "0x107B420")]
	public static bool IsUnlimitedAmmo()
	{
		return default(bool);
	}

	[Token(Token = "0x600101E")]
	[Address(RVA = "0x107B874", Offset = "0x107B874", VA = "0x107B874")]
	public static bool IsFateRoyalMode(uint mode)
	{
		return default(bool);
	}

	[Token(Token = "0x600101F")]
	[Address(RVA = "0x107B8F8", Offset = "0x107B8F8", VA = "0x107B8F8")]
	public static bool HasPlayedFirstGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6001020")]
	[Address(RVA = "0x107BAE4", Offset = "0x107BAE4", VA = "0x107BAE4")]
	public static bool HasPlayedMaxFirstGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6001021")]
	[Address(RVA = "0x107BC54", Offset = "0x107BC54", VA = "0x107BC54")]
	public static void PlayFirstGame()
	{
	}

	[Token(Token = "0x6001022")]
	[Address(RVA = "0x107BFAC", Offset = "0x107BFAC", VA = "0x107BFAC")]
	public static bool HasFirstGameLand()
	{
		return default(bool);
	}

	[Token(Token = "0x6001023")]
	[Address(RVA = "0x107C198", Offset = "0x107C198", VA = "0x107C198")]
	public static void FirstGameLand()
	{
	}

	[Token(Token = "0x6001024")]
	[Address(RVA = "0x107C37C", Offset = "0x107C37C", VA = "0x107C37C")]
	public static void UpdateOpeningMovieRegion()
	{
	}

	[Token(Token = "0x6001025")]
	[Address(RVA = "0x107C534", Offset = "0x107C534", VA = "0x107C534")]
	public static bool IsOpeningMovieRegionEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6001026")]
	[Address(RVA = "0x107C604", Offset = "0x107C604", VA = "0x107C604")]
	public static float GetFakePingInRegion()
	{
		return default(float);
	}

	[Token(Token = "0x6001027")]
	[Address(RVA = "0x107CAD4", Offset = "0x107CAD4", VA = "0x107CAD4")]
	public static bool IsSonoranMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6001028")]
	[Address(RVA = "0x107CBA0", Offset = "0x107CBA0", VA = "0x107CBA0")]
	public static bool IsParadiseNeoMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0x107CC6C", Offset = "0x107CC6C", VA = "0x107CC6C")]
	public static bool IsRushBBombMap()
	{
		return default(bool);
	}

	[Token(Token = "0x600102A")]
	[Address(RVA = "0x107CD38", Offset = "0x107CD38", VA = "0x107CD38")]
	public static List<COW.GamePlay.IJKEMPEMMDN> GetArmsRaceInfo()
	{
		return null;
	}

	[Token(Token = "0x600102B")]
	[Address(RVA = "0x107CE94", Offset = "0x107CE94", VA = "0x107CE94")]
	public static ResourceID GetWeaponIconByArmsLevel(int armsLevel)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600102C")]
	[Address(RVA = "0x107D104", Offset = "0x107D104", VA = "0x107D104")]
	public static bool NeedSyncInfoInTrainingMode(IHAAMHPPLMG fromPlayerID)
	{
		return default(bool);
	}

	[Token(Token = "0x600102D")]
	[Address(RVA = "0x107D41C", Offset = "0x107D41C", VA = "0x107D41C")]
	public static bool NeedSyncInfoInTrainingMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600102E")]
	[Address(RVA = "0x107D5B8", Offset = "0x107D5B8", VA = "0x107D5B8")]
	public static bool IsTrainingSubZone(IHJOFJKFIBB z)
	{
		return default(bool);
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0x107D630", Offset = "0x107D630", VA = "0x107D630")]
	public static void SetUIRootOnAwake(Action<UIRoot> onAwake)
	{
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0x107D708", Offset = "0x107D708", VA = "0x107D708")]
	public static HLOONAALFOE GetSingleBountyWaitingGame()
	{
		return null;
	}

	[Token(Token = "0x6001031")]
	[Address(RVA = "0x107D820", Offset = "0x107D820", VA = "0x107D820")]
	public static bool IsSingleBountyWaitingGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6001032")]
	[Address(RVA = "0x107D938", Offset = "0x107D938", VA = "0x107D938")]
	public static LOCIDJPIMLO GetSinglePlayerForceTutorialGame()
	{
		return null;
	}

	[Token(Token = "0x6001033")]
	[Address(RVA = "0x107BE94", Offset = "0x107BE94", VA = "0x107BE94")]
	public static bool IsSinglePlayerForceTutorialGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6001034")]
	[Address(RVA = "0x107DA50", Offset = "0x107DA50", VA = "0x107DA50")]
	public static bool IsSinglBountyLowMemory()
	{
		return default(bool);
	}

	[Token(Token = "0x6001035")]
	[Address(RVA = "0x107DB68", Offset = "0x107DB68", VA = "0x107DB68")]
	public static void SetSingleBountyWaitingPlayPre()
	{
	}

	[Token(Token = "0x6001036")]
	[Address(RVA = "0x107DC10", Offset = "0x107DC10", VA = "0x107DC10")]
	public static bool IsPlayedSingleBountyWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x6001037")]
	[Address(RVA = "0x107DCBC", Offset = "0x107DCBC", VA = "0x107DCBC")]
	public static bool IsBountGameIgnoreOneShotSound()
	{
		return default(bool);
	}

	[Token(Token = "0x6001038")]
	[Address(RVA = "0x107DDD8", Offset = "0x107DDD8", VA = "0x107DDD8")]
	public static bool IsMultipleBountyWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x6001039")]
	[Address(RVA = "0x107DEF0", Offset = "0x107DEF0", VA = "0x107DEF0")]
	public static IAFEPLMFPCC GetMultipleBountyWaiting()
	{
		return null;
	}

	[Token(Token = "0x600103A")]
	[Address(RVA = "0x107E008", Offset = "0x107E008", VA = "0x107E008")]
	public static void LoadAndRunSinglePlayerGameBountyWaiting()
	{
	}

	[Token(Token = "0x600103B")]
	[Address(RVA = "0x107E054", Offset = "0x107E054", VA = "0x107E054")]
	public static UIRushingPetsGameScene GetRushingPetsGameUIScene()
	{
		return null;
	}

	[Token(Token = "0x600103C")]
	[Address(RVA = "0x107E15C", Offset = "0x107E15C", VA = "0x107E15C")]
	public static MultiplePlayerWereWolvesGame GetWereWolvesGame()
	{
		return null;
	}

	[Token(Token = "0x600103D")]
	[Address(RVA = "0x107E274", Offset = "0x107E274", VA = "0x107E274")]
	public static UIWereWolvesGameScene GetWereWolvesGameUIScene()
	{
		return null;
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0x107E37C", Offset = "0x107E37C", VA = "0x107E37C")]
	public static PlayerWereWolves GetLocalWereWolvesPlayer()
	{
		return null;
	}

	[Token(Token = "0x600103F")]
	[Address(RVA = "0x107E484", Offset = "0x107E484", VA = "0x107E484")]
	public static WereWolvesBodyManager GetWereWolvesBodyManager()
	{
		return null;
	}

	[Token(Token = "0x6001040")]
	[Address(RVA = "0x107E558", Offset = "0x107E558", VA = "0x107E558")]
	public static Color GetWereWolveColorByIndex(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6001041")]
	[Address(RVA = "0x107E6B4", Offset = "0x107E6B4", VA = "0x107E6B4")]
	public static WereWolvesRoleData GetWereWolveRoleInfoByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6001042")]
	[Address(RVA = "0x107E85C", Offset = "0x107E85C", VA = "0x107E85C")]
	public static MMOHBDPIKLC GetWereWolvesGameOverState()
	{
		return default(MMOHBDPIKLC);
	}

	[Token(Token = "0x6001043")]
	[Address(RVA = "0x107E930", Offset = "0x107E930", VA = "0x107E930")]
	public static OOFDPCCNDJO GetWereWolvesGameMatchEndInfo()
	{
		return null;
	}

	[Token(Token = "0x6001044")]
	[Address(RVA = "0x107EA04", Offset = "0x107EA04", VA = "0x107EA04")]
	public static WolfTrapManager CurrentWolfTrapManager()
	{
		return null;
	}

	[Token(Token = "0x6001045")]
	[Address(RVA = "0x107EBF4", Offset = "0x107EBF4", VA = "0x107EBF4")]
	public static int GetWereWolveVoteCenterCDEndTimeMS()
	{
		return default(int);
	}

	[Token(Token = "0x6001046")]
	[Address(RVA = "0x107ECC8", Offset = "0x107ECC8", VA = "0x107ECC8")]
	public static SingerBTimeLineManager GetSingerBGameTimeLineManager()
	{
		return null;
	}

	[Token(Token = "0x6001047")]
	[Address(RVA = "0x107EED4", Offset = "0x107EED4", VA = "0x107EED4")]
	public static SingerBScenePointManager GetSingerBGameScenePointManager()
	{
		return null;
	}

	[Token(Token = "0x6001048")]
	[Address(RVA = "0x107F0E0", Offset = "0x107F0E0", VA = "0x107F0E0")]
	public static LKFKIOAOKKM GetMultipSingerBGame()
	{
		return null;
	}

	[Token(Token = "0x6001049")]
	[Address(RVA = "0x10782E8", Offset = "0x10782E8", VA = "0x10782E8")]
	public static bool IsSingersBMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600104A")]
	[Address(RVA = "0x107F1F8", Offset = "0x107F1F8", VA = "0x107F1F8")]
	public static bool IsShowPlayerDeadPopMsg()
	{
		return default(bool);
	}

	[Token(Token = "0x600104B")]
	[Address(RVA = "0x107F380", Offset = "0x107F380", VA = "0x107F380")]
	public static bool IsPlayerEnterPendingReviveNeedHideModel()
	{
		return default(bool);
	}

	[Token(Token = "0x600104C")]
	[Address(RVA = "0x107F524", Offset = "0x107F524", VA = "0x107F524")]
	public static bool IsShowGodUI()
	{
		return default(bool);
	}

	[Token(Token = "0x600104D")]
	[Address(RVA = "0x107F704", Offset = "0x107F704", VA = "0x107F704")]
	public static string GetModeName(int modeID)
	{
		return null;
	}

	[Token(Token = "0x600104E")]
	[Address(RVA = "0x107F8EC", Offset = "0x107F8EC", VA = "0x107F8EC")]
	public static bool IsEmulator()
	{
		return default(bool);
	}

	[Token(Token = "0x600104F")]
	[Address(RVA = "0x107FB48", Offset = "0x107FB48", VA = "0x107FB48")]
	public static bool IsGameNeedCheckObserverMatchEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x6001050")]
	[Address(RVA = "0x107FC84", Offset = "0x107FC84", VA = "0x107FC84")]
	public static ResourceID GetUGCMoveTemplateCSVResID(uint mapID)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001051")]
	[Address(RVA = "0x107FE4C", Offset = "0x107FE4C", VA = "0x107FE4C")]
	public static UILoadingController GetLoadingController()
	{
		return null;
	}

	[Token(Token = "0x6001052")]
	[Address(RVA = "0x107FFE8", Offset = "0x107FFE8", VA = "0x107FFE8")]
	public static UGCCustomizeRepDataSyncManager GetUGCRepDataSyncManager()
	{
		return null;
	}

	[Token(Token = "0x6001053")]
	[Address(RVA = "0x1080118", Offset = "0x1080118", VA = "0x1080118")]
	public static ResourceID GetHealEffectResourceId(Player p)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6001054")]
	public static T GetWorkshopModeData<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6001055")]
	[Address(RVA = "0x1080214", Offset = "0x1080214", VA = "0x1080214")]
	public static PLPOJKGPFDL GetWorkshopGerneralData()
	{
		return null;
	}

	[Token(Token = "0x6001056")]
	[Address(RVA = "0x1080348", Offset = "0x1080348", VA = "0x1080348")]
	public static EAuth.ClientUsingVersion ClientUsingVersion()
	{
		return default(EAuth.ClientUsingVersion);
	}
}
