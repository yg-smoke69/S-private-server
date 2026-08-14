using System.Text;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001DDA")]
public static class GameSettingData
{
	[Token(Token = "0x400BD0D")]
	public const string LoclizationSettingKey = "Localization";

	[Token(Token = "0x400BD0E")]
	public const string SensitivitySettingKey = "Sensitivity";

	[Token(Token = "0x400BD0F")]
	public const string AuxAimSensitivitySettingKey = "AuxAimSensitivity";

	[Token(Token = "0x400BD10")]
	public const string SpHudPlayerInfoIsBasicSettingKey = "SpHudPlayerInfoIsBasic";

	[Token(Token = "0x400BD11")]
	public const string MusicSettingKey = "Music";

	[Token(Token = "0x400BD12")]
	public const string SoundEffectSettingKey = "SoundEffect";

	[Token(Token = "0x400BD13")]
	public const string KillSoundEffectSettingKey = "KillSoundEffect";

	[Token(Token = "0x400BD14")]
	public const string GameVoiceSettingKey = "GameVoice";

	[Token(Token = "0x400BD15")]
	public const string MinimapSettingKey = "MiniMap";

	[Token(Token = "0x400BD16")]
	public const string MinimapScaleAssistKey = "MiniMapScaleAssist";

	[Token(Token = "0x400BD17")]
	public const string QualitySettingKey = "Quality";

	[Token(Token = "0x400BD18")]
	public const string QualitySettingRecommendKey = "QualityRecommend";

	[Token(Token = "0x400BD19")]
	public const string HDQualitySettingAdjustKey = "HDQualityAdjust";

	[Token(Token = "0x400BD1A")]
	public const string ScopeSensitivitySettingKeyPrefix = "ScopeSensitivity_";

	[Token(Token = "0x400BD1B")]
	public const string AimAssistKey = "AimAssist";

	[Token(Token = "0x400BD1C")]
	public const string OpenScopeOperateKey = "OpenScopeOperate";

	[Token(Token = "0x400BD1D")]
	public const string LeftFireKey = "LeftFire";

	[Token(Token = "0x400BD1E")]
	public const string ChangeWeaponKey = "ChangeWeapon";

	[Token(Token = "0x400BD1F")]
	public const string ReloadKey = "Reload";

	[Token(Token = "0x400BD20")]
	public const string UseAuxAimKey = "UseAuxAimNew";

	[Token(Token = "0x400BD21")]
	public const string UseAuxAimParachuteKey = "UseAuxAimParachute";

	[Token(Token = "0x400BD22")]
	public const string UseAuxAimDashKey = "UseAuxAimDash";

	[Token(Token = "0x400BD23")]
	public const string UseAuxAimDriveKey = "UseAuxAimDrive";

	[Token(Token = "0x400BD24")]
	public const string SafeZoneInfoModeKey = "IngameTipsMode";

	[Token(Token = "0x400BD25")]
	public const string StackedKillModeKey = "StackedKillMode";

	[Token(Token = "0x400BD26")]
	public const string BrightnessSettingKey = "BrightnessSetting";

	[Token(Token = "0x400BD27")]
	public const string EnemyFireHintKey = "EnemyFireHint";

	[Token(Token = "0x400BD28")]
	public const string LobbyGyroscopeKey = "LobbyGyroscope";

	[Token(Token = "0x400BD29")]
	public const string EnemyFootStepHintKey = "EnemyFootStepHint";

	[Token(Token = "0x400BD2A")]
	public const string CurClanLevel = "CurClanLevel";

	[Token(Token = "0x400BD2B")]
	public const string AutoSlidingKey = "AutoSliding";

	[Token(Token = "0x400BD2C")]
	public const string AutoPickUpKey = "AutoPickup";

	[Token(Token = "0x400BD2D")]
	public const string NotchScreenKey = "NotchScreen";

	[Token(Token = "0x400BD2E")]
	public const string VehicleControlModeKey = "VehicleControlMode";

	[Token(Token = "0x400BD2F")]
	public const string HighFPSKey = "HighFPS";

	[Token(Token = "0x400BD30")]
	public const string ShowShadowKey = "ShowShadow";

	[Token(Token = "0x400BD31")]
	public const string AcceptUnknowPlayerGroupInviteKey = "AcceptUnknowPlayerGroupInvite";

	[Token(Token = "0x400BD32")]
	public const string AcceptReserveInviteKey = "AcceptReserveInvite";

	[Token(Token = "0x400BD33")]
	public const string AcceptGroupInviteKey = "AcceptGroupInviteKey";

	[Token(Token = "0x400BD34")]
	public const string AutoFireKey = "AutoFire";

	[Token(Token = "0x400BD35")]
	public const string AutoSwitchKey = "AutoSwitch";

	[Token(Token = "0x400BD36")]
	public const string HitHint = "HitHint";

	[Token(Token = "0x400BD37")]
	public const string NameClassicEnable = "NameClassicEnable";

	[Token(Token = "0x400BD38")]
	public const string HUDGrenadeDirection = "HUDGrenadeDirection";

	[Token(Token = "0x400BD39")]
	public const string HUDGrenade2Direction = "HUDGrenade2Direction_";

	[Token(Token = "0x400BD3A")]
	public const string HUDSelection = "ConfigSelected";

	[Token(Token = "0x400BD3B")]
	public const string NewUser = "NewUser";

	[Token(Token = "0x400BD3C")]
	public const string EnableQuickChat = "EnableQuickChat";

	[Token(Token = "0x400BD3D")]
	public const string EnableQuickChatSound = "EnableQuickChatSound";

	[Token(Token = "0x400BD3E")]
	public const string DownloadCentreShowKey = "ShowDownloadCentre";

	[Token(Token = "0x400BD3F")]
	public const string ChatBlockListKey = "ChatBlockList";

	[Token(Token = "0x400BD40")]
	public const string MaxLobbyOpenKey = "MaxLobbyOpen";

	[Token(Token = "0x400BD41")]
	public const string SpectatorCamerMoveSpeedKey = "SpectatorCamerMoveSpeed";

	[Token(Token = "0x400BD42")]
	public const string SpectatorCamerRotateSpeedKey = "SpectatorCamerRotateSpeed";

	[Token(Token = "0x400BD43")]
	public const string ReduceResolutionKey = "ReduceResolution";

	[Token(Token = "0x400BD44")]
	public const string RegisteredOnThisDevice = "RegisteredOnThisDevice";

	[Token(Token = "0x400BD45")]
	public const string RecommendFriends = "RecommendFriends_";

	[Token(Token = "0x400BD46")]
	public const string ChatBubble = "ChatBubble_";

	[Token(Token = "0x400BD47")]
	public const string KEY_CUSTOMROOM_ERRORTIPS_ENABLED = "KEY_CUSTOMROOM_ERRORTIPS_ENABLED";

	[Token(Token = "0x400BD48")]
	public const string KEY_CUSTOMROOM_RECORD_REPLAY_ENABLED = "KEY_CUSTOMROOM_RECORD_REPLAY_ENABLED";

	[Token(Token = "0x400BD49")]
	public const string KEY_CUSTOMROOM_MOBILE_RECORD_REPLAY_ENABLED = "KEY_CUSTOMROOM_MOBILE_RECORD_REPLAY_ENABLED";

	[Token(Token = "0x400BD4A")]
	public const string KEY_CUSTOMROOM_RECORD_DELAY_OB_ENABLED = "KEY_CUSTOMROOM_RECORD_DELAY_OB_ENABLED";

	[Token(Token = "0x400BD4B")]
	public const string KEY_CUSTOMROOM_DELAY_OB_SECONDS = "KEY_CUSTOMROOM_DELAY_OB_SECONDS";

	[Token(Token = "0x400BD4C")]
	public const string KEY_CUSTOMROOM_PERSPECTIVE_TYPE = "KEY_CUSTOMROOM_PERSPECTIVE_TYPE";

	[Token(Token = "0x400BD4D")]
	public const string KEY_CUSTOMROOM_PERSPECTIVE_COLOR_TYPE = "KEY_CUSTOMROOM_PERSPECTIVE_COLOR_TYPE";

	[Token(Token = "0x400BD4E")]
	public const string KEY_CUSTOMROOM_FIRE_SOUND = "KEY_CUSTOMROOM_FIRE_SOUND";

	[Token(Token = "0x400BD4F")]
	public const string KEY_CUSTOMROOM_ACHIEVEMENT_SOUND = "KEY_CUSTOMROOM_ACHIEVEMENT_SOUND";

	[Token(Token = "0x400BD50")]
	public const string KEY_CUSTOMROOM_PLAYERSIGHT_ENABLED = "KEY_CUSTOMROOM_PLAYERSIGHT_ENABLED_TEMP";

	[Token(Token = "0x400BD51")]
	public const string KEY_CUSTOMROOM_OPENINGCAM_ENABLED = "KEY_CUSTOMROOM_OPENINGCAM_ENABLED";

	[Token(Token = "0x400BD52")]
	public const string KEY_TEAM_BILLBOARD_ENABLED = "KEY_TEAM_BILLBOARD_ENABLED";

	[Token(Token = "0x400BD53")]
	public const string KEY_CUSTOMROOM_SPMVP_ENABLED = "CSMVP";

	[Token(Token = "0x400BD54")]
	public const string KEY_CUSTOM_GRENADE_SLOT = "GrenadeSlot";

	[Token(Token = "0x400BD55")]
	public const string KEY_MAXSETTING_VIDEODECODER = "KEY_MAXSETTING_VIDEODECODER";

	[Token(Token = "0x400BD56")]
	public const string UseHDAnimation = "UseHDAnimation";

	[Token(Token = "0x400BD57")]
	public const string HDWeaponEffect = "HDWeaponEffect";

	[Token(Token = "0x400BD58")]
	public const string HDTexture = "HDTexture";

	[Token(Token = "0x400BD59")]
	public const string HDVehicleVFX = "HDVehicleVFX";

	[Token(Token = "0x400BD5A")]
	public const string AudioEngineTypeKey = "AudioEngineType";

	[Token(Token = "0x400BD5B")]
	public const string KEY_MAXSETTING_LOGINViDEO_ENABLED = "KEY_MAXSETTING_LOGINViDEO_ENABLED";

	[Token(Token = "0x400BD5C")]
	public const string HDLobbyVehicleAutoRotate = "HDLobbyVehicleAutoRotate";

	[Token(Token = "0x400BD5D")]
	public const string HDLobbyIceWallAutoRotate = "HDLobbyIceWallAutoRotate";

	[Token(Token = "0x400BD5E")]
	public const string HDLobbySkyboardAutoRotate = "HDLobbySkyboardAutoRotate";

	[Token(Token = "0x400BD5F")]
	public const string HDShowMyLobby = "HDShowMyLobby";

	[Token(Token = "0x400BD60")]
	public const string HDShowCaptainLobby = "HDShowCaptainLobby";

	[Token(Token = "0x400BD61")]
	public const string MaxGraphicABTestKey = "MaxGraphicABTestKey";

	[Token(Token = "0x400BD62")]
	public const string UGCCameraMoveSpeedKey = "KEY_UGC_CAMERA_MOVE_SPEED";

	[Token(Token = "0x400BD63")]
	public const string UGC_AcceptFriendGroupInviteKey = "KEY_UGC_ACCEPT_FRIEND_GROUP_INVITE";

	[Token(Token = "0x400BD64")]
	public const string KEY_Auto_Equip_Default_Music = "KEY_AUTO_EQUIP_DEFAULT_MUSIC";

	[Token(Token = "0x400BD65")]
	public const string CupMatchAcceptNotificationKey = "CupMatchAcceptNotificationKey";

	[Token(Token = "0x400BD66")]
	public const string RequestJoinCupTeamNotificationKey = "RequestJoinCupTeamNotificationKey";

	[Token(Token = "0x400BD67")]
	public const string GameResultFriendRecommendNotificationKey = "GameResultFriendRecommendNotificationKey";

	[Token(Token = "0x400BD68")]
	public const string GameResultInviteRecommendNotificationKey = "GameResultInviteRecommendNotificationKey";

	[Token(Token = "0x400BD69")]
	public const string IPMusicPlayKey = "IPMusicPlayKey";

	[Token(Token = "0x400BD6A")]
	public const string SmartIceWallKey = "SmartIceWallKey";

	[Token(Token = "0x400BD6B")]
	public const string InitedSmartIceWallSetting = "InitedSmartIceWallKey";

	[Token(Token = "0x400BD6C")]
	public const string GrenadeSlotBeforeSmarIceWallEnable = "GrenadeSlotBeforeSmarIceWallEnableKey";

	[Token(Token = "0x400BD6D")]
	public const string SpecialCharacterVoiceKey = "SpecialCharacterVoiceKey";

	[Token(Token = "0x400BD6E")]
	public const string EPDiscountKey = "EPDiscountKey";

	[Token(Token = "0x400BD6F")]
	public const float MAX_SENSITIVITY = 1f;

	[Token(Token = "0x400BD70")]
	public const float MAX_MUSICVOLUME = 1f;

	[Token(Token = "0x400BD71")]
	public const float MAX_SOUNDEFFECTVOLUME = 1f;

	[Token(Token = "0x400BD72")]
	public const float MAX_KILLSOUNDEFFECTVOLUME = 1f;

	[Token(Token = "0x400BD73")]
	public const float MAX_GAMEVOICEVVOLUME = 1f;

	[Token(Token = "0x400BD74")]
	public const float DEFAULT_1xSCOPE_SENSE = 0.8f;

	[Token(Token = "0x400BD75")]
	public const float DEFAULT_2xSCOPE_SENSE = 0.7f;

	[Token(Token = "0x400BD76")]
	public const float DEFAULT_4xSCOPE_SENSE = 0.6f;

	[Token(Token = "0x400BD77")]
	public const float DEFAULT_8xSCOPE_SENSE = 0.5f;

	[Token(Token = "0x400BD78")]
	public const int HUDGRENADETOP = 0;

	[Token(Token = "0x400BD79")]
	public const int HUDGRENADEBOTTOM = 1;

	[Token(Token = "0x400BD7A")]
	public const int HUDGRENADELEFT = 2;

	[Token(Token = "0x400BD7B")]
	public const int HUDGRENADERIGHT = 3;

	[Token(Token = "0x400BD7C")]
	[FieldOffset(Offset = "0x0")]
	private static bool? m_AutoFire;

	[Token(Token = "0x400BD7D")]
	[FieldOffset(Offset = "0x4")]
	private static GAGILKKDDMJ m_cacheQuality;

	[Token(Token = "0x400BD7E")]
	[FieldOffset(Offset = "0x8")]
	private static float m_SensitivitySetting;

	[Token(Token = "0x400BD7F")]
	[FieldOffset(Offset = "0xC")]
	private static float m_AuxAimSensitivity;

	[Token(Token = "0x400BD80")]
	[FieldOffset(Offset = "0x10")]
	private static float m_ScopeSensitivity1x;

	[Token(Token = "0x400BD81")]
	[FieldOffset(Offset = "0x14")]
	private static float m_ScopeSensitivity2x;

	[Token(Token = "0x400BD82")]
	[FieldOffset(Offset = "0x18")]
	private static float m_ScopeSensitivity4x;

	[Token(Token = "0x400BD83")]
	[FieldOffset(Offset = "0x1C")]
	private static float m_ScopeSensitivity8x;

	[Token(Token = "0x400BD84")]
	[FieldOffset(Offset = "0x20")]
	private static int m_CurrentMaxLobbyType;

	[Token(Token = "0x400BD85")]
	public const int HD_COMMONLOBBY = 0;

	[Token(Token = "0x400BD86")]
	public const int HD_STANDLOBBY = 10;

	[Token(Token = "0x400BD87")]
	[FieldOffset(Offset = "0x24")]
	private static bool m_HasReadShowMaxLobbyState;

	[Token(Token = "0x400BD88")]
	[FieldOffset(Offset = "0x25")]
	private static bool? m_IsUsingSpHudCsplayerInfo;

	[Token(Token = "0x400BD89")]
	[FieldOffset(Offset = "0x27")]
	private static bool? m_SmartIceWallEnable;

	[Token(Token = "0x400BD8A")]
	[FieldOffset(Offset = "0x2C")]
	private static int m_EnemyFootStepHintVal;

	[Token(Token = "0x400BD8B")]
	[FieldOffset(Offset = "0x30")]
	private static EAudioEngineType m_HDAudio;

	[Token(Token = "0x400BD8C")]
	[FieldOffset(Offset = "0x34")]
	private static bool m_HDLoginVideo;

	[Token(Token = "0x400BD8D")]
	[FieldOffset(Offset = "0x38")]
	private static EHDTexture m_HDTexture;

	[Token(Token = "0x400BD8E")]
	[FieldOffset(Offset = "0x3C")]
	private static EHDVehicleVFX m_HDVehicleVFX;

	[Token(Token = "0x400BD8F")]
	[FieldOffset(Offset = "0x40")]
	private static EHDWeaponEffect m_HDWeaponEffect;

	[Token(Token = "0x400BD90")]
	[FieldOffset(Offset = "0x44")]
	private static EHDShowMyLobby m_HDShowMyLobby;

	[Token(Token = "0x400BD91")]
	[FieldOffset(Offset = "0x48")]
	private static EHDShowCaptainLobby m_HDShowCaptainLobby;

	[Token(Token = "0x400BD92")]
	[FieldOffset(Offset = "0x4C")]
	private static bool m_HDAnimation;

	[Token(Token = "0x400BD93")]
	[FieldOffset(Offset = "0x4D")]
	private static bool _003CAutoPickSettingChanged_003Ek__BackingField;

	[Token(Token = "0x400BD94")]
	[FieldOffset(Offset = "0x50")]
	private static StringBuilder m_StringBuilder;

	[Token(Token = "0x400BD95")]
	[FieldOffset(Offset = "0x54")]
	private static string m_LocalPlayerUserID;

	[Token(Token = "0x400BD96")]
	[FieldOffset(Offset = "0x58")]
	private static string m_LobbySettingTipsKey;

	[Token(Token = "0x400BD97")]
	[FieldOffset(Offset = "0x5C")]
	private static string m_FilterSettingTipsKey;

	[Token(Token = "0x17000F0C")]
	public static string FriendInvitationPush
	{
		[Token(Token = "0x6008E9A")]
		[Address(RVA = "0x26F8B74", Offset = "0x26F8B74", VA = "0x26F8B74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F0D")]
	public static bool AutoPickSettingChanged
	{
		[Token(Token = "0x6008EF4")]
		[Address(RVA = "0x26FF980", Offset = "0x26FF980", VA = "0x26FF980")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008EF5")]
		[Address(RVA = "0x26FFA0C", Offset = "0x26FFA0C", VA = "0x26FFA0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000F0E")]
	public static string LocalPlayerUserID
	{
		[Token(Token = "0x6008F3F")]
		[Address(RVA = "0x2700E78", Offset = "0x2700E78", VA = "0x2700E78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008F40")]
		[Address(RVA = "0x2705078", Offset = "0x2705078", VA = "0x2705078")]
		set
		{
		}
	}

	[Token(Token = "0x17000F0F")]
	public static string LobbySettingTipsKey
	{
		[Token(Token = "0x6008F41")]
		[Address(RVA = "0x2705150", Offset = "0x2705150", VA = "0x2705150")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F10")]
	public static string FilterSettingTipsKey
	{
		[Token(Token = "0x6008F42")]
		[Address(RVA = "0x2705314", Offset = "0x2705314", VA = "0x2705314")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F11")]
	private static string PlayerEverLogIn
	{
		[Token(Token = "0x6008F43")]
		[Address(RVA = "0x27054D8", Offset = "0x27054D8", VA = "0x27054D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F12")]
	public static int CurrentMaxLobbyType
	{
		[Token(Token = "0x6008F4C")]
		[Address(RVA = "0x2705F8C", Offset = "0x2705F8C", VA = "0x2705F8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000F13")]
	public static int CurrentShowMaxLobbyState
	{
		[Token(Token = "0x6008F4D")]
		[Address(RVA = "0x27060E0", Offset = "0x27060E0", VA = "0x27060E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008F4E")]
		[Address(RVA = "0x2706130", Offset = "0x2706130", VA = "0x2706130")]
		set
		{
		}
	}

	[Token(Token = "0x17000F14")]
	public static EAudioEngineType CurrentAudioEngine
	{
		[Token(Token = "0x6008F5C")]
		[Address(RVA = "0x27092EC", Offset = "0x27092EC", VA = "0x27092EC")]
		get
		{
			return default(EAudioEngineType);
		}
		[Token(Token = "0x6008F5D")]
		[Address(RVA = "0x27093BC", Offset = "0x27093BC", VA = "0x27093BC")]
		set
		{
		}
	}

	[Token(Token = "0x6008E9B")]
	[Address(RVA = "0x26F8CE4", Offset = "0x26F8CE4", VA = "0x26F8CE4")]
	public static void SetLoclizationLanguage(LocLang locLang)
	{
	}

	[Token(Token = "0x6008E9C")]
	[Address(RVA = "0x26F8E80", Offset = "0x26F8E80", VA = "0x26F8E80")]
	public static LocLang GetLoclizationLanguage()
	{
		return default(LocLang);
	}

	[Token(Token = "0x6008E9D")]
	[Address(RVA = "0x26F8FEC", Offset = "0x26F8FEC", VA = "0x26F8FEC")]
	public static void SetSensitivity(float sen)
	{
	}

	[Token(Token = "0x6008E9E")]
	[Address(RVA = "0x26F9120", Offset = "0x26F9120", VA = "0x26F9120")]
	public static float GetSensitivity()
	{
		return default(float);
	}

	[Token(Token = "0x6008E9F")]
	[Address(RVA = "0x26F92C0", Offset = "0x26F92C0", VA = "0x26F92C0")]
	public static float GetAndroidSensitivityByType(int type)
	{
		return default(float);
	}

	[Token(Token = "0x6008EA0")]
	[Address(RVA = "0x26F9460", Offset = "0x26F9460", VA = "0x26F9460")]
	public static bool IsUseNewDeathCameraMode(int modeID)
	{
		return default(bool);
	}

	[Token(Token = "0x6008EA1")]
	[Address(RVA = "0x26F9614", Offset = "0x26F9614", VA = "0x26F9614")]
	public static float GetIosSensivivityByType(int type)
	{
		return default(float);
	}

	[Token(Token = "0x6008EA2")]
	[Address(RVA = "0x26F97B4", Offset = "0x26F97B4", VA = "0x26F97B4")]
	public static void SetAuxAimSensitivity(float sen)
	{
	}

	[Token(Token = "0x6008EA3")]
	[Address(RVA = "0x26F98E8", Offset = "0x26F98E8", VA = "0x26F98E8")]
	public static bool IsUsingSpHudCsplayerInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EA4")]
	[Address(RVA = "0x26F9B14", Offset = "0x26F9B14", VA = "0x26F9B14")]
	public static void SetUsingSpHudCsplayerInfo(bool use)
	{
	}

	[Token(Token = "0x6008EA5")]
	[Address(RVA = "0x26E9190", Offset = "0x26E9190", VA = "0x26E9190")]
	public static float GetAuxAimSensitivity()
	{
		return default(float);
	}

	[Token(Token = "0x6008EA6")]
	[Address(RVA = "0x26F9C70", Offset = "0x26F9C70", VA = "0x26F9C70")]
	public static void SetMusicVolume(float volume)
	{
	}

	[Token(Token = "0x6008EA7")]
	[Address(RVA = "0x26F9D50", Offset = "0x26F9D50", VA = "0x26F9D50")]
	public static float GetMusicVolume()
	{
		return default(float);
	}

	[Token(Token = "0x6008EA8")]
	[Address(RVA = "0x26F9E28", Offset = "0x26F9E28", VA = "0x26F9E28")]
	public static void SetSoundEffect(float volume)
	{
	}

	[Token(Token = "0x6008EA9")]
	[Address(RVA = "0x26F9F08", Offset = "0x26F9F08", VA = "0x26F9F08")]
	public static void SetKillSoundEffect(float volume)
	{
	}

	[Token(Token = "0x6008EAA")]
	[Address(RVA = "0x26F9FE8", Offset = "0x26F9FE8", VA = "0x26F9FE8")]
	public static void SetPCFireSound(float volume)
	{
	}

	[Token(Token = "0x6008EAB")]
	[Address(RVA = "0x26FA0C8", Offset = "0x26FA0C8", VA = "0x26FA0C8")]
	public static float GetPCFireSound()
	{
		return default(float);
	}

	[Token(Token = "0x6008EAC")]
	[Address(RVA = "0x26FA1A0", Offset = "0x26FA1A0", VA = "0x26FA1A0")]
	public static void SetPCAchievementSound(float volume)
	{
	}

	[Token(Token = "0x6008EAD")]
	[Address(RVA = "0x26FA280", Offset = "0x26FA280", VA = "0x26FA280")]
	public static float GetPCAchievementSound()
	{
		return default(float);
	}

	[Token(Token = "0x6008EAE")]
	[Address(RVA = "0x26FA358", Offset = "0x26FA358", VA = "0x26FA358")]
	public static bool GetAutoFire()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EAF")]
	[Address(RVA = "0x26FA67C", Offset = "0x26FA67C", VA = "0x26FA67C")]
	public static void SetAutoFire(bool autoFire)
	{
	}

	[Token(Token = "0x6008EB0")]
	[Address(RVA = "0x26FA7D8", Offset = "0x26FA7D8", VA = "0x26FA7D8")]
	public static bool GetAutoSwitchWeapon()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EB1")]
	[Address(RVA = "0x26FA914", Offset = "0x26FA914", VA = "0x26FA914")]
	public static void SetAutoSwitchWeapon(bool flag)
	{
	}

	[Token(Token = "0x6008EB2")]
	[Address(RVA = "0x26FA9F8", Offset = "0x26FA9F8", VA = "0x26FA9F8")]
	public static bool IsAutoFireMode(bool ck = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6008EB3")]
	[Address(RVA = "0x26FAB28", Offset = "0x26FAB28", VA = "0x26FAB28")]
	public static float GetSoundEffect()
	{
		return default(float);
	}

	[Token(Token = "0x6008EB4")]
	[Address(RVA = "0x26FAC00", Offset = "0x26FAC00", VA = "0x26FAC00")]
	public static float GetKillSoundEffect()
	{
		return default(float);
	}

	[Token(Token = "0x6008EB5")]
	[Address(RVA = "0x26FACD8", Offset = "0x26FACD8", VA = "0x26FACD8")]
	public static void SetGameVoiceVolume(float volume)
	{
	}

	[Token(Token = "0x6008EB6")]
	[Address(RVA = "0x26FADB8", Offset = "0x26FADB8", VA = "0x26FADB8")]
	public static float GetGameVoiceVolume()
	{
		return default(float);
	}

	[Token(Token = "0x6008EB7")]
	[Address(RVA = "0x26FAE90", Offset = "0x26FAE90", VA = "0x26FAE90")]
	public static void SetMinimapMode(UIHudMinimapController.JPKDINFPGOD mode)
	{
	}

	[Token(Token = "0x6008EB8")]
	[Address(RVA = "0x26FAF70", Offset = "0x26FAF70", VA = "0x26FAF70")]
	public static UIHudMinimapController.JPKDINFPGOD GetMinimapMode()
	{
		return default(UIHudMinimapController.JPKDINFPGOD);
	}

	[Token(Token = "0x6008EB9")]
	[Address(RVA = "0x26FB048", Offset = "0x26FB048", VA = "0x26FB048")]
	public static void SetMiniMapScaleAssistEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6008EBA")]
	[Address(RVA = "0x26FB12C", Offset = "0x26FB12C", VA = "0x26FB12C")]
	public static bool GetMiniMapScaleAssistEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EBB")]
	[Address(RVA = "0x26FB20C", Offset = "0x26FB20C", VA = "0x26FB20C")]
	public static void SetQuality(GAGILKKDDMJ q, bool resetOthers = true)
	{
	}

	[Token(Token = "0x6008EBC")]
	[Address(RVA = "0x26FB4B8", Offset = "0x26FB4B8", VA = "0x26FB4B8")]
	public static GAGILKKDDMJ GetRecommendedQuality(bool InAfterSystemInited = true)
	{
		return default(GAGILKKDDMJ);
	}

	[Token(Token = "0x6008EBD")]
	[Address(RVA = "0x26EBF6C", Offset = "0x26EBF6C", VA = "0x26EBF6C")]
	public static GAGILKKDDMJ GetQuality(bool InAfterSystemInited = true)
	{
		return default(GAGILKKDDMJ);
	}

	[Token(Token = "0x6008EBE")]
	[Address(RVA = "0x26FB73C", Offset = "0x26FB73C", VA = "0x26FB73C")]
	public static bool CheckEnablePreZByGraphicDevice()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EBF")]
	[Address(RVA = "0x26FBA28", Offset = "0x26FBA28", VA = "0x26FBA28")]
	public static int GetQualityLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6008EC0")]
	[Address(RVA = "0x26FBB1C", Offset = "0x26FBB1C", VA = "0x26FBB1C")]
	public static BJOMPMJHDLC GetGraphicQuality()
	{
		return default(BJOMPMJHDLC);
	}

	[Token(Token = "0x6008EC1")]
	[Address(RVA = "0x26FBD88", Offset = "0x26FBD88", VA = "0x26FBD88")]
	public static bool IsMemoryHighest()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EC2")]
	[Address(RVA = "0x26F8174", Offset = "0x26F8174", VA = "0x26F8174")]
	public static MMAJAKIJNAJ GetMemoryLevel()
	{
		return default(MMAJAKIJNAJ);
	}

	[Token(Token = "0x6008EC3")]
	[Address(RVA = "0x26FBE74", Offset = "0x26FBE74", VA = "0x26FBE74")]
	public static MMAJAKIJNAJ GetMemoryLevel_V2()
	{
		return default(MMAJAKIJNAJ);
	}

	[Token(Token = "0x6008EC4")]
	[Address(RVA = "0x26FBFAC", Offset = "0x26FBFAC", VA = "0x26FBFAC")]
	public static bool IsHighFramerate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EC5")]
	[Address(RVA = "0x26FC36C", Offset = "0x26FC36C", VA = "0x26FC36C")]
	public static bool IsEnemyFootStepHintEnalbed()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EC6")]
	[Address(RVA = "0x26FC590", Offset = "0x26FC590", VA = "0x26FC590")]
	public static void SetEnemyFootStepHintEnalbed(int v)
	{
	}

	[Token(Token = "0x6008EC7")]
	[Address(RVA = "0x26FC6B4", Offset = "0x26FC6B4", VA = "0x26FC6B4")]
	public static bool IsEnemyFireHintEnalbed()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EC8")]
	[Address(RVA = "0x26FC840", Offset = "0x26FC840", VA = "0x26FC840")]
	public static void SetEnemyFireHintEnalbed(int v)
	{
	}

	[Token(Token = "0x6008EC9")]
	[Address(RVA = "0x26FC920", Offset = "0x26FC920", VA = "0x26FC920")]
	public static bool IsLobbyGyroscopeEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ECA")]
	[Address(RVA = "0x26FCAB0", Offset = "0x26FCAB0", VA = "0x26FCAB0")]
	public static void SetLobbyGyroscopeEnabled(bool v)
	{
	}

	[Token(Token = "0x6008ECB")]
	[Address(RVA = "0x26FCBC4", Offset = "0x26FCBC4", VA = "0x26FCBC4")]
	public static bool ShowHighFrameOption()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ECC")]
	[Address(RVA = "0x26FCCBC", Offset = "0x26FCCBC", VA = "0x26FCCBC")]
	public static DevSpecWhitelistData.FramerateType GetHighFramerateDefault()
	{
		return default(DevSpecWhitelistData.FramerateType);
	}

	[Token(Token = "0x6008ECD")]
	[Address(RVA = "0x26FCDB8", Offset = "0x26FCDB8", VA = "0x26FCDB8")]
	public static bool IsLowMemoryIOS()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ECE")]
	[Address(RVA = "0x26FCEBC", Offset = "0x26FCEBC", VA = "0x26FCEBC")]
	public static bool IsForceUseLowResource()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ECF")]
	[Address(RVA = "0x26FCFC0", Offset = "0x26FCFC0", VA = "0x26FCFC0")]
	private static bool CheckShadowSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ED0")]
	[Address(RVA = "0x26FD01C", Offset = "0x26FD01C", VA = "0x26FD01C")]
	public static bool ShowShadowOption()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ED1")]
	[Address(RVA = "0x26FD218", Offset = "0x26FD218", VA = "0x26FD218")]
	public static bool IsHDGraphics()
	{
		return default(bool);
	}

	[Token(Token = "0x6008ED2")]
	[Address(RVA = "0x26FD31C", Offset = "0x26FD31C", VA = "0x26FD31C")]
	public static BJOMPMJHDLC GetMapDesertGraphicQuality()
	{
		return default(BJOMPMJHDLC);
	}

	[Token(Token = "0x6008ED3")]
	[Address(RVA = "0x26FD414", Offset = "0x26FD414", VA = "0x26FD414")]
	public static void SetInGameFilter(EInGameFilterSetting b)
	{
	}

	[Token(Token = "0x6008ED4")]
	[Address(RVA = "0x26FD4F4", Offset = "0x26FD4F4", VA = "0x26FD4F4")]
	public static EInGameFilterSetting GetInGameFilter()
	{
		return default(EInGameFilterSetting);
	}

	[Token(Token = "0x6008ED5")]
	[Address(RVA = "0x26FD5CC", Offset = "0x26FD5CC", VA = "0x26FD5CC")]
	public static void Set1xScopeSensitivity(float sen)
	{
	}

	[Token(Token = "0x6008ED6")]
	[Address(RVA = "0x26FD700", Offset = "0x26FD700", VA = "0x26FD700")]
	public static float Get1xScopeSensitivity()
	{
		return default(float);
	}

	[Token(Token = "0x6008ED7")]
	[Address(RVA = "0x26FDD1C", Offset = "0x26FDD1C", VA = "0x26FDD1C")]
	public static void Set2xScopeSensitivity(float sen)
	{
	}

	[Token(Token = "0x6008ED8")]
	[Address(RVA = "0x26FDE50", Offset = "0x26FDE50", VA = "0x26FDE50")]
	public static float Get2xScopeSensitivity()
	{
		return default(float);
	}

	[Token(Token = "0x6008ED9")]
	[Address(RVA = "0x26FDF10", Offset = "0x26FDF10", VA = "0x26FDF10")]
	public static void Set4xScopeSensitivity(float sen)
	{
	}

	[Token(Token = "0x6008EDA")]
	[Address(RVA = "0x26FE044", Offset = "0x26FE044", VA = "0x26FE044")]
	public static float Get4xScopeSensitivity()
	{
		return default(float);
	}

	[Token(Token = "0x6008EDB")]
	[Address(RVA = "0x26FE104", Offset = "0x26FE104", VA = "0x26FE104")]
	public static void Set8xScopeSensitivity(float sen)
	{
	}

	[Token(Token = "0x6008EDC")]
	[Address(RVA = "0x26FE238", Offset = "0x26FE238", VA = "0x26FE238")]
	public static float Get8xScopeSensitivity()
	{
		return default(float);
	}

	[Token(Token = "0x6008EDD")]
	[Address(RVA = "0x26FD7C0", Offset = "0x26FD7C0", VA = "0x26FD7C0")]
	public static float GetScopeSensitivity(int x)
	{
		return default(float);
	}

	[Token(Token = "0x6008EDE")]
	[Address(RVA = "0x26FE2F8", Offset = "0x26FE2F8", VA = "0x26FE2F8")]
	public static EAimAssist GetAimAssistSetting()
	{
		return default(EAimAssist);
	}

	[Token(Token = "0x6008EDF")]
	[Address(RVA = "0x26FE3D0", Offset = "0x26FE3D0", VA = "0x26FE3D0")]
	public static EOpenScopeOperate GetOpenScopeOperate()
	{
		return default(EOpenScopeOperate);
	}

	[Token(Token = "0x6008EE0")]
	[Address(RVA = "0x26FE4A8", Offset = "0x26FE4A8", VA = "0x26FE4A8")]
	public static void SetOpenScopeOperate(EOpenScopeOperate o)
	{
	}

	[Token(Token = "0x6008EE1")]
	[Address(RVA = "0x26FE588", Offset = "0x26FE588", VA = "0x26FE588")]
	public static ENotchScreen GetNotchScreen()
	{
		return default(ENotchScreen);
	}

	[Token(Token = "0x6008EE2")]
	[Address(RVA = "0x26FE774", Offset = "0x26FE774", VA = "0x26FE774")]
	public static void SetNotchScreen(ENotchScreen o)
	{
	}

	[Token(Token = "0x6008EE3")]
	[Address(RVA = "0x26FE854", Offset = "0x26FE854", VA = "0x26FE854")]
	public static EControlMode GetVehicleControlMode()
	{
		return default(EControlMode);
	}

	[Token(Token = "0x6008EE4")]
	[Address(RVA = "0x26FE92C", Offset = "0x26FE92C", VA = "0x26FE92C")]
	public static void SetVehicleControlMode(EControlMode c)
	{
	}

	[Token(Token = "0x6008EE5")]
	[Address(RVA = "0x26FEA0C", Offset = "0x26FEA0C", VA = "0x26FEA0C")]
	public static ELeftFireSetting GetLeftFireSetting()
	{
		return default(ELeftFireSetting);
	}

	[Token(Token = "0x6008EE6")]
	[Address(RVA = "0x26FEAE4", Offset = "0x26FEAE4", VA = "0x26FEAE4")]
	public static EChangeWeaponSetting GetChangeWeaponSetting()
	{
		return default(EChangeWeaponSetting);
	}

	[Token(Token = "0x6008EE7")]
	[Address(RVA = "0x26FEBBC", Offset = "0x26FEBBC", VA = "0x26FEBBC")]
	public static EReloadSetting GetReloadSetting()
	{
		return default(EReloadSetting);
	}

	[Token(Token = "0x6008EE8")]
	[Address(RVA = "0x26FEC94", Offset = "0x26FEC94", VA = "0x26FEC94")]
	public static bool GetUseAuxAimSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EE9")]
	[Address(RVA = "0x26FED7C", Offset = "0x26FED7C", VA = "0x26FED7C")]
	public static bool GetUseAuxAimParachuteSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EEA")]
	[Address(RVA = "0x26FEF38", Offset = "0x26FEF38", VA = "0x26FEF38")]
	public static bool GetUseAuxAimDashSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EEB")]
	[Address(RVA = "0x26FF0F4", Offset = "0x26FF0F4", VA = "0x26FF0F4")]
	public static bool GetUseAuxAimDriveSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EEC")]
	[Address(RVA = "0x26FF2B0", Offset = "0x26FF2B0", VA = "0x26FF2B0")]
	public static ESafeZoneModeSetting GetSafeZoneInfoMode()
	{
		return default(ESafeZoneModeSetting);
	}

	[Token(Token = "0x6008EED")]
	[Address(RVA = "0x26FF388", Offset = "0x26FF388", VA = "0x26FF388")]
	public static EStackedKillModeSetting GetStackedKillMode()
	{
		return default(EStackedKillModeSetting);
	}

	[Token(Token = "0x6008EEE")]
	[Address(RVA = "0x26FF460", Offset = "0x26FF460", VA = "0x26FF460")]
	public static void SetCurClanLevel(uint level)
	{
	}

	[Token(Token = "0x6008EEF")]
	[Address(RVA = "0x26FF540", Offset = "0x26FF540", VA = "0x26FF540")]
	public static uint GetCurClanLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6008EF0")]
	[Address(RVA = "0x26FF618", Offset = "0x26FF618", VA = "0x26FF618")]
	public static EAutoSlidingSetting GetAutoSlidingSetting()
	{
		return default(EAutoSlidingSetting);
	}

	[Token(Token = "0x6008EF1")]
	[Address(RVA = "0x26FF6F0", Offset = "0x26FF6F0", VA = "0x26FF6F0")]
	public static EAutoPickup GetAutoPickupSetting(string itemType = "AutoPickup")
	{
		return default(EAutoPickup);
	}

	[Token(Token = "0x6008EF2")]
	[Address(RVA = "0x26FF7C4", Offset = "0x26FF7C4", VA = "0x26FF7C4")]
	public static void SetAutoPickupSystemStatus(EAutoPickup autoPickup)
	{
	}

	[Token(Token = "0x6008EF3")]
	[Address(RVA = "0x26FF8A4", Offset = "0x26FF8A4", VA = "0x26FF8A4")]
	public static void SetAutoPickupItemStatus(string itemKey, int autoPickupValue)
	{
	}

	[Token(Token = "0x6008EF6")]
	[Address(RVA = "0x26FFA9C", Offset = "0x26FFA9C", VA = "0x26FFA9C")]
	public static int GetHudSelection()
	{
		return default(int);
	}

	[Token(Token = "0x6008EF7")]
	[Address(RVA = "0x26FFB74", Offset = "0x26FFB74", VA = "0x26FFB74")]
	public static void SetHudSeletion(int selection)
	{
	}

	[Token(Token = "0x6008EF8")]
	[Address(RVA = "0x26FFC54", Offset = "0x26FFC54", VA = "0x26FFC54")]
	public static int GetHudGrenadeDirection()
	{
		return default(int);
	}

	[Token(Token = "0x6008EF9")]
	[Address(RVA = "0x26FFE10", Offset = "0x26FFE10", VA = "0x26FFE10")]
	public static int GetHudGrenade2Direction()
	{
		return default(int);
	}

	[Token(Token = "0x6008EFA")]
	[Address(RVA = "0x26FFFCC", Offset = "0x26FFFCC", VA = "0x26FFFCC")]
	public static int GetHudGrenadeDirection(int selection)
	{
		return default(int);
	}

	[Token(Token = "0x6008EFB")]
	[Address(RVA = "0x270015C", Offset = "0x270015C", VA = "0x270015C")]
	public static int GetHudGrenade2Direction(int selection)
	{
		return default(int);
	}

	[Token(Token = "0x6008EFC")]
	[Address(RVA = "0x27002EC", Offset = "0x27002EC", VA = "0x27002EC")]
	public static void SetHudGrenadeDirection(int direction)
	{
	}

	[Token(Token = "0x6008EFD")]
	[Address(RVA = "0x270046C", Offset = "0x270046C", VA = "0x270046C")]
	public static void SetHudGrenade2Direction(int direction)
	{
	}

	[Token(Token = "0x6008EFE")]
	[Address(RVA = "0x26FC1C0", Offset = "0x26FC1C0", VA = "0x26FC1C0")]
	public static bool HasHighFPSSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008EFF")]
	[Address(RVA = "0x26FC294", Offset = "0x26FC294", VA = "0x26FC294")]
	public static EHighFPS GetHighFPSSetting()
	{
		return default(EHighFPS);
	}

	[Token(Token = "0x6008F00")]
	[Address(RVA = "0x27005EC", Offset = "0x27005EC", VA = "0x27005EC")]
	public static void SetHighFPSSetting(EHighFPS value)
	{
	}

	[Token(Token = "0x6008F01")]
	[Address(RVA = "0x27006C0", Offset = "0x27006C0", VA = "0x27006C0")]
	public static EShowShadow GetShadowSetting()
	{
		return default(EShowShadow);
	}

	[Token(Token = "0x6008F02")]
	[Address(RVA = "0x27008E4", Offset = "0x27008E4", VA = "0x27008E4")]
	public static bool GetDownloadCentreNeedShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F03")]
	[Address(RVA = "0x2700A58", Offset = "0x2700A58", VA = "0x2700A58")]
	public static void SetDownloadCentreNeedShow(bool need_show)
	{
	}

	[Token(Token = "0x6008F04")]
	[Address(RVA = "0x2700C40", Offset = "0x2700C40", VA = "0x2700C40")]
	public static void SetAcceptUnknowPlayerGroupInvite(bool value)
	{
	}

	[Token(Token = "0x6008F05")]
	[Address(RVA = "0x2700D24", Offset = "0x2700D24", VA = "0x2700D24")]
	public static void SetEPHasObtainedDiscountKey(bool value)
	{
	}

	[Token(Token = "0x6008F06")]
	[Address(RVA = "0x2701094", Offset = "0x2701094", VA = "0x2701094")]
	public static bool GetEPHasObtainedDiscountKey()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F07")]
	[Address(RVA = "0x27012E4", Offset = "0x27012E4", VA = "0x27012E4")]
	public static void SetIPMusicPlayKey(bool value)
	{
	}

	[Token(Token = "0x6008F08")]
	[Address(RVA = "0x27013C8", Offset = "0x27013C8", VA = "0x27013C8")]
	public static bool GetIPMusicPlayKey()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F09")]
	[Address(RVA = "0x270153C", Offset = "0x270153C", VA = "0x270153C")]
	public static void SetCupMatchAcceptNotificationKey(bool value)
	{
	}

	[Token(Token = "0x6008F0A")]
	[Address(RVA = "0x2701620", Offset = "0x2701620", VA = "0x2701620")]
	public static bool GetCupMatchAcceptInvitation()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F0B")]
	[Address(RVA = "0x2701794", Offset = "0x2701794", VA = "0x2701794")]
	public static void SetRequestJoinCupTeamNotificationKey(bool value)
	{
	}

	[Token(Token = "0x6008F0C")]
	[Address(RVA = "0x2701878", Offset = "0x2701878", VA = "0x2701878")]
	public static bool GetRequestJoinCupTeamNotification()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F0D")]
	[Address(RVA = "0x27019EC", Offset = "0x27019EC", VA = "0x27019EC")]
	public static void SetGameResultFriendRecommendNotificationKey(bool value)
	{
	}

	[Token(Token = "0x6008F0E")]
	[Address(RVA = "0x2701AD0", Offset = "0x2701AD0", VA = "0x2701AD0")]
	public static bool GetGameResultFriendRecommendNotification()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F0F")]
	[Address(RVA = "0x2701C44", Offset = "0x2701C44", VA = "0x2701C44")]
	public static void SetGameResultInviteRecommendNotificationKey(bool value)
	{
	}

	[Token(Token = "0x6008F10")]
	[Address(RVA = "0x2701D28", Offset = "0x2701D28", VA = "0x2701D28")]
	public static bool GetGameResultInviteRecommendNotification()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F11")]
	[Address(RVA = "0x2701E9C", Offset = "0x2701E9C", VA = "0x2701E9C")]
	public static bool GetAcceptUnknowPlayerGroupInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F12")]
	[Address(RVA = "0x2702010", Offset = "0x2702010", VA = "0x2702010")]
	public static void SetAcceptReserveInvite(bool value)
	{
	}

	[Token(Token = "0x6008F13")]
	[Address(RVA = "0x27020F4", Offset = "0x27020F4", VA = "0x27020F4")]
	public static bool GetAcceptReserveInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F14")]
	[Address(RVA = "0x2702268", Offset = "0x2702268", VA = "0x2702268")]
	public static void SetEnableQuickChat(bool value)
	{
	}

	[Token(Token = "0x6008F15")]
	[Address(RVA = "0x270234C", Offset = "0x270234C", VA = "0x270234C")]
	public static bool GetEnableQuickChat()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F16")]
	[Address(RVA = "0x27024B0", Offset = "0x27024B0", VA = "0x27024B0")]
	public static void SetEnableQuickChatSound(bool value)
	{
	}

	[Token(Token = "0x6008F17")]
	[Address(RVA = "0x2702594", Offset = "0x2702594", VA = "0x2702594")]
	public static bool GetEnableQuickChatSound()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F18")]
	[Address(RVA = "0x27026F8", Offset = "0x27026F8", VA = "0x27026F8")]
	public static void SetAcceptGroupInvite(bool value)
	{
	}

	[Token(Token = "0x6008F19")]
	[Address(RVA = "0x27027DC", Offset = "0x27027DC", VA = "0x27027DC")]
	public static bool GetAcceptGroupInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F1A")]
	[Address(RVA = "0x2702950", Offset = "0x2702950", VA = "0x2702950")]
	public static void SetCustomRoomReplayEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6008F1B")]
	[Address(RVA = "0x2702A34", Offset = "0x2702A34", VA = "0x2702A34")]
	public static bool GetCustomRoomReplayEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F1C")]
	[Address(RVA = "0x2702B14", Offset = "0x2702B14", VA = "0x2702B14")]
	public static void SetCustomRoomDelayOBEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6008F1D")]
	[Address(RVA = "0x2702BF8", Offset = "0x2702BF8", VA = "0x2702BF8")]
	public static bool GetCustomRoomDelayOBEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F1E")]
	[Address(RVA = "0x2702CD8", Offset = "0x2702CD8", VA = "0x2702CD8")]
	public static void SetCustomRoomOpeningCamEnable(bool enabled)
	{
	}

	[Token(Token = "0x6008F1F")]
	[Address(RVA = "0x2702DBC", Offset = "0x2702DBC", VA = "0x2702DBC")]
	public static void SetTeamBillboardEnable(bool enabled)
	{
	}

	[Token(Token = "0x6008F20")]
	[Address(RVA = "0x2702EA0", Offset = "0x2702EA0", VA = "0x2702EA0")]
	public static bool GetCustomRoomOpeningCamEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F21")]
	[Address(RVA = "0x2702F80", Offset = "0x2702F80", VA = "0x2702F80")]
	public static bool GetTeamBillboardEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F22")]
	[Address(RVA = "0x2703060", Offset = "0x2703060", VA = "0x2703060")]
	public static bool GetCustomRoomMVPEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F23")]
	[Address(RVA = "0x2703140", Offset = "0x2703140", VA = "0x2703140")]
	public static bool GetHitHintClassic()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F24")]
	[Address(RVA = "0x2703220", Offset = "0x2703220", VA = "0x2703220")]
	public static void SetHitHintClassic(bool enabled)
	{
	}

	[Token(Token = "0x6008F25")]
	[Address(RVA = "0x2703304", Offset = "0x2703304", VA = "0x2703304")]
	public static bool GetNameClassicEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F26")]
	[Address(RVA = "0x2703424", Offset = "0x2703424", VA = "0x2703424")]
	public static void SetNameClassicEnable(bool enabled)
	{
	}

	[Token(Token = "0x6008F27")]
	[Address(RVA = "0x2703508", Offset = "0x2703508", VA = "0x2703508")]
	public static float GetCustomRoomDelayOBSeconds()
	{
		return default(float);
	}

	[Token(Token = "0x6008F28")]
	[Address(RVA = "0x27035E0", Offset = "0x27035E0", VA = "0x27035E0")]
	public static void SetCustomRoomDelayOBSeconds(float value)
	{
	}

	[Token(Token = "0x6008F29")]
	[Address(RVA = "0x27036C0", Offset = "0x27036C0", VA = "0x27036C0")]
	public static bool GetCustomRoomPerspectiveType()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F2A")]
	[Address(RVA = "0x2703778", Offset = "0x2703778", VA = "0x2703778")]
	public static void SetCustomRoomPerspectiveType(bool left)
	{
	}

	[Token(Token = "0x6008F2B")]
	[Address(RVA = "0x2703828", Offset = "0x2703828", VA = "0x2703828")]
	public static bool GetCustomRoomPerspectiveColorType()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F2C")]
	[Address(RVA = "0x27038D8", Offset = "0x27038D8", VA = "0x27038D8")]
	public static void SetCustomRoomPerspectiveColorType(bool stuffed)
	{
	}

	[Token(Token = "0x6008F2D")]
	[Address(RVA = "0x2703988", Offset = "0x2703988", VA = "0x2703988")]
	public static void SetCustomRoomPlayerSightEnabled(bool enable)
	{
	}

	[Token(Token = "0x6008F2E")]
	[Address(RVA = "0x2703A6C", Offset = "0x2703A6C", VA = "0x2703A6C")]
	public static bool GetCustomRoomPlayerSightEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F2F")]
	[Address(RVA = "0x2703B4C", Offset = "0x2703B4C", VA = "0x2703B4C")]
	public static void SetCustomRoomObTipsEnabled(bool enable)
	{
	}

	[Token(Token = "0x6008F30")]
	[Address(RVA = "0x2703C30", Offset = "0x2703C30", VA = "0x2703C30")]
	public static bool GetCustomRoomObTipsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F31")]
	[Address(RVA = "0x2703D10", Offset = "0x2703D10", VA = "0x2703D10")]
	public static int GetCustomGrenadeSlot()
	{
		return default(int);
	}

	[Token(Token = "0x6008F32")]
	[Address(RVA = "0x2704378", Offset = "0x2704378", VA = "0x2704378")]
	public static void SetCustomGrenadeSlot(int slot)
	{
	}

	[Token(Token = "0x6008F33")]
	[Address(RVA = "0x2704458", Offset = "0x2704458", VA = "0x2704458")]
	public static string GetChatBlockList()
	{
		return null;
	}

	[Token(Token = "0x6008F34")]
	[Address(RVA = "0x2704530", Offset = "0x2704530", VA = "0x2704530")]
	public static void SetChatBlockList(string jsonData)
	{
	}

	[Token(Token = "0x6008F35")]
	[Address(RVA = "0x2703E18", Offset = "0x2703E18", VA = "0x2703E18")]
	public static bool GetSmartIceWallSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F36")]
	[Address(RVA = "0x2704610", Offset = "0x2704610", VA = "0x2704610")]
	public static void SetSmartIceWallSetting(bool enable)
	{
	}

	[Token(Token = "0x6008F37")]
	[Address(RVA = "0x27047E4", Offset = "0x27047E4", VA = "0x27047E4")]
	public static int GetGrenadeSlotBeforeSmartIceWallEnable()
	{
		return default(int);
	}

	[Token(Token = "0x6008F38")]
	[Address(RVA = "0x27048BC", Offset = "0x27048BC", VA = "0x27048BC")]
	public static bool GetSpecialCharacterVoiceSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F39")]
	[Address(RVA = "0x270499C", Offset = "0x270499C", VA = "0x270499C")]
	public static void SetSpecialCharacterVoiceSetting(bool enable)
	{
	}

	[Token(Token = "0x6008F3A")]
	[Address(RVA = "0x2704A80", Offset = "0x2704A80", VA = "0x2704A80")]
	public static float GetResolutionReduceRate()
	{
		return default(float);
	}

	[Token(Token = "0x6008F3B")]
	[Address(RVA = "0x2704BCC", Offset = "0x2704BCC", VA = "0x2704BCC")]
	public static int GetVideoDecoderSupport()
	{
		return default(int);
	}

	[Token(Token = "0x6008F3C")]
	[Address(RVA = "0x2704CA4", Offset = "0x2704CA4", VA = "0x2704CA4")]
	public static void SetVideoDecoderSupport(bool able)
	{
	}

	[Token(Token = "0x6008F3D")]
	[Address(RVA = "0x2704D94", Offset = "0x2704D94", VA = "0x2704D94")]
	public static void InitVibrateSetting(int type, int value)
	{
	}

	[Token(Token = "0x6008F3E")]
	[Address(RVA = "0x2704F2C", Offset = "0x2704F2C", VA = "0x2704F2C")]
	public static int GetVibrateSetting(int type)
	{
		return default(int);
	}

	[Token(Token = "0x6008F44")]
	[Address(RVA = "0x2705674", Offset = "0x2705674", VA = "0x2705674")]
	public static bool GetIsNewUser()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F45")]
	[Address(RVA = "0x270574C", Offset = "0x270574C", VA = "0x270574C")]
	public static void SetNewUser()
	{
	}

	[Token(Token = "0x6008F46")]
	[Address(RVA = "0x2705824", Offset = "0x2705824", VA = "0x2705824")]
	public static bool GetEverLoggedIn()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F47")]
	[Address(RVA = "0x270592C", Offset = "0x270592C", VA = "0x270592C")]
	public static void SetEverLoggedIn()
	{
	}

	[Token(Token = "0x6008F48")]
	[Address(RVA = "0x2705A2C", Offset = "0x2705A2C", VA = "0x2705A2C")]
	public static bool GetFriendRecommendState()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F49")]
	[Address(RVA = "0x2705B88", Offset = "0x2705B88", VA = "0x2705B88")]
	public static void SetFriendRecommendState(bool state)
	{
	}

	[Token(Token = "0x6008F4A")]
	[Address(RVA = "0x2705CDC", Offset = "0x2705CDC", VA = "0x2705CDC")]
	public static bool GetChatBubbleState()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F4B")]
	[Address(RVA = "0x2705E38", Offset = "0x2705E38", VA = "0x2705E38")]
	public static void SetChatBubbleState(bool state)
	{
	}

	[Token(Token = "0x6008F4F")]
	[Address(RVA = "0x27061E0", Offset = "0x27061E0", VA = "0x27061E0")]
	public static void SetSpectatorCameraMoveSpeed(float b)
	{
	}

	[Token(Token = "0x6008F50")]
	[Address(RVA = "0x2706234", Offset = "0x2706234", VA = "0x2706234")]
	public static void SetSpectatorCameraRotateSpeed(float b)
	{
	}

	[Token(Token = "0x6008F51")]
	[Address(RVA = "0x2706288", Offset = "0x2706288", VA = "0x2706288")]
	public static float GetSpectatorCameraMoveSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6008F52")]
	[Address(RVA = "0x27062D8", Offset = "0x27062D8", VA = "0x27062D8")]
	public static float GetSpectatorCameraRotateSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6008F53")]
	[Address(RVA = "0x2706328", Offset = "0x2706328", VA = "0x2706328")]
	public static bool IsMobileReplaySettingEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F54")]
	[Address(RVA = "0x2706488", Offset = "0x2706488", VA = "0x2706488")]
	public static void SetMobileReplaySettingEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6008F55")]
	[Address(RVA = "0x270656C", Offset = "0x270656C", VA = "0x270656C")]
	public static bool IsUnloadEmbeddedSceneObjects()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F56")]
	[Address(RVA = "0x27066AC", Offset = "0x27066AC", VA = "0x27066AC")]
	public static void InitMaxGraphicABTest()
	{
	}

	[Token(Token = "0x6008F57")]
	[Address(RVA = "0x2707224", Offset = "0x2707224", VA = "0x2707224")]
	public static EHDABtestState GetABTestValue()
	{
		return default(EHDABtestState);
	}

	[Token(Token = "0x6008F58")]
	[Address(RVA = "0x27073C4", Offset = "0x27073C4", VA = "0x27073C4")]
	public static void InitMaxSettingBeforeLogin()
	{
	}

	[Token(Token = "0x6008F59")]
	[Address(RVA = "0x2708904", Offset = "0x2708904", VA = "0x2708904")]
	public static void InitMaxSettingAfterLogin()
	{
	}

	[Token(Token = "0x6008F5A")]
	[Address(RVA = "0x27068C0", Offset = "0x27068C0", VA = "0x27068C0")]
	public static void RefreshMaxSetting()
	{
	}

	[Token(Token = "0x6008F5B")]
	[Address(RVA = "0x2707A78", Offset = "0x2707A78", VA = "0x2707A78")]
	private static void InitHDConfig()
	{
	}

	[Token(Token = "0x6008F5E")]
	[Address(RVA = "0x270956C", Offset = "0x270956C", VA = "0x270956C")]
	public static void SetLoginVideoEnabled(bool enable)
	{
	}

	[Token(Token = "0x6008F5F")]
	[Address(RVA = "0x270969C", Offset = "0x270969C", VA = "0x270969C")]
	public static bool GetLoginVideoEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F60")]
	[Address(RVA = "0x27097B8", Offset = "0x27097B8", VA = "0x27097B8")]
	public static bool GetUseHDAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F61")]
	[Address(RVA = "0x2708D1C", Offset = "0x2708D1C", VA = "0x2708D1C")]
	public static void SetUseHDAnimation(bool flag)
	{
	}

	[Token(Token = "0x6008F62")]
	[Address(RVA = "0x2708E4C", Offset = "0x2708E4C", VA = "0x2708E4C")]
	public static void SetHDWeaponEffect(EHDWeaponEffect value)
	{
	}

	[Token(Token = "0x6008F63")]
	[Address(RVA = "0x2709888", Offset = "0x2709888", VA = "0x2709888")]
	public static EHDWeaponEffect GetHDWeaponEffect()
	{
		return default(EHDWeaponEffect);
	}

	[Token(Token = "0x6008F64")]
	[Address(RVA = "0x2708F78", Offset = "0x2708F78", VA = "0x2708F78")]
	public static void SetHDTexture(EHDTexture value)
	{
	}

	[Token(Token = "0x6008F65")]
	[Address(RVA = "0x2709958", Offset = "0x2709958", VA = "0x2709958")]
	public static EHDTexture GetHDTexture()
	{
		return default(EHDTexture);
	}

	[Token(Token = "0x6008F66")]
	[Address(RVA = "0x27091C0", Offset = "0x27091C0", VA = "0x27091C0")]
	public static void SetHDVehicleVFX(EHDVehicleVFX value)
	{
	}

	[Token(Token = "0x6008F67")]
	[Address(RVA = "0x26EBE5C", Offset = "0x26EBE5C", VA = "0x26EBE5C")]
	public static EHDVehicleVFX GetHDVehicleVFX()
	{
		return default(EHDVehicleVFX);
	}

	[Token(Token = "0x6008F68")]
	[Address(RVA = "0x2709A28", Offset = "0x2709A28", VA = "0x2709A28")]
	public static EHDShowMyLobby GetHDShowMyLobby()
	{
		return default(EHDShowMyLobby);
	}

	[Token(Token = "0x6008F69")]
	[Address(RVA = "0x2709BA0", Offset = "0x2709BA0", VA = "0x2709BA0")]
	public static EHDShowCaptainLobby GetHDShowCaptainLobby()
	{
		return default(EHDShowCaptainLobby);
	}

	[Token(Token = "0x6008F6A")]
	[Address(RVA = "0x2709D18", Offset = "0x2709D18", VA = "0x2709D18")]
	public static void SetHDShowMyLobby(EHDShowMyLobby value)
	{
	}

	[Token(Token = "0x6008F6B")]
	[Address(RVA = "0x2709E3C", Offset = "0x2709E3C", VA = "0x2709E3C")]
	public static void SetHDShowCaptainLobby(EHDShowCaptainLobby value)
	{
	}

	[Token(Token = "0x6008F6C")]
	[Address(RVA = "0x27082B4", Offset = "0x27082B4", VA = "0x27082B4")]
	public static bool IsUseHDLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F6D")]
	[Address(RVA = "0x2709F60", Offset = "0x2709F60", VA = "0x2709F60")]
	public static bool IsUseHDLobby()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F6E")]
	[Address(RVA = "0x2708070", Offset = "0x2708070", VA = "0x2708070")]
	public static bool IsUseHDAudio(bool useGraphicsConfig = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6008F6F")]
	[Address(RVA = "0x27090A4", Offset = "0x27090A4", VA = "0x27090A4")]
	public static bool CanUseHDVehicleVFX()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F70")]
	[Address(RVA = "0x2708764", Offset = "0x2708764", VA = "0x2708764")]
	public static bool IsUseHDVehicleVFX(bool useGraphicsConfig = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6008F71")]
	[Address(RVA = "0x2708AD8", Offset = "0x2708AD8", VA = "0x2708AD8")]
	public static bool IsUseHDAnimation(bool useGraphicsConfig = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6008F72")]
	[Address(RVA = "0x27083BC", Offset = "0x27083BC", VA = "0x27083BC")]
	public static bool IsUseHDWeaponEffect(bool useGraphicsConfig = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6008F73")]
	[Address(RVA = "0x2708590", Offset = "0x2708590", VA = "0x2708590")]
	public static bool IsUseHDTexture(bool useGraphicsConfig = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6008F74")]
	[Address(RVA = "0x26FBC90", Offset = "0x26FBC90", VA = "0x26FBC90")]
	public static BJOMPMJHDLC GetHDGraphQuality()
	{
		return default(BJOMPMJHDLC);
	}

	[Token(Token = "0x6008F75")]
	[Address(RVA = "0x270A068", Offset = "0x270A068", VA = "0x270A068")]
	public static void SetHDLobbyVehicleAutoRotate(bool isOn)
	{
	}

	[Token(Token = "0x6008F76")]
	[Address(RVA = "0x270A14C", Offset = "0x270A14C", VA = "0x270A14C")]
	public static bool GetHDLobbyVehicleAutoRotate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F77")]
	[Address(RVA = "0x270A22C", Offset = "0x270A22C", VA = "0x270A22C")]
	public static void SetHDLobbyIceWallAutoRotate(bool isOn)
	{
	}

	[Token(Token = "0x6008F78")]
	[Address(RVA = "0x270A310", Offset = "0x270A310", VA = "0x270A310")]
	public static bool GetHDLobbyIceWallAutoRotate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F79")]
	[Address(RVA = "0x270A3F0", Offset = "0x270A3F0", VA = "0x270A3F0")]
	public static void SetHDLobbySkyboardAutoRotate(bool isOn)
	{
	}

	[Token(Token = "0x6008F7A")]
	[Address(RVA = "0x270A4D4", Offset = "0x270A4D4", VA = "0x270A4D4")]
	public static bool GetHDLobbySkyboardAutoRotate()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F7B")]
	[Address(RVA = "0x270A5B4", Offset = "0x270A5B4", VA = "0x270A5B4")]
	public static bool GetFriendInvitationPush()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F7C")]
	[Address(RVA = "0x270A6C4", Offset = "0x270A6C4", VA = "0x270A6C4")]
	public static void SetFriendInvitationPush(bool isOn)
	{
	}

	[Token(Token = "0x6008F7D")]
	[Address(RVA = "0x270A7CC", Offset = "0x270A7CC", VA = "0x270A7CC")]
	public static float GetUGCCameraMoveSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6008F7E")]
	[Address(RVA = "0x270AA28", Offset = "0x270AA28", VA = "0x270AA28")]
	public static void SetUGCCameraMoveSpeed(float value)
	{
	}

	[Token(Token = "0x6008F7F")]
	[Address(RVA = "0x270AB08", Offset = "0x270AB08", VA = "0x270AB08")]
	public static bool GetUGCAcceptFriendGroupInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6008F80")]
	[Address(RVA = "0x270ABE8", Offset = "0x270ABE8", VA = "0x270ABE8")]
	public static void SetUGCAcceptFriendGroupInvite(bool value)
	{
	}

	[Token(Token = "0x6008F81")]
	[Address(RVA = "0x270ACCC", Offset = "0x270ACCC", VA = "0x270ACCC")]
	public static void SetAutoEquipDefaultMusicVault(bool value)
	{
	}

	[Token(Token = "0x6008F82")]
	[Address(RVA = "0x270ADB0", Offset = "0x270ADB0", VA = "0x270ADB0")]
	public static bool GetAutoEquipDefaultMusicVault()
	{
		return default(bool);
	}
}
