using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200028A")]
internal class GameModeSetting : _Attribute
{
	[Token(Token = "0x400172E")]
	[FieldOffset(Offset = "0x8")]
	public readonly int PlayerMaxHP;

	[Token(Token = "0x400172F")]
	[FieldOffset(Offset = "0xC")]
	public readonly int VehicleMaxHP;

	[Token(Token = "0x4001730")]
	[FieldOffset(Offset = "0x10")]
	public readonly bool RandomAirLineEndJump;

	[Token(Token = "0x4001731")]
	[FieldOffset(Offset = "0x11")]
	public readonly bool EnableInventory;

	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x12")]
	public readonly bool EnableVehicleChangeSeat;

	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x13")]
	public readonly bool EnableVehicleBoost;

	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x14")]
	public readonly bool EnableVehicleJump;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x15")]
	public readonly bool LimitCsPickItem;

	[Token(Token = "0x4001736")]
	[FieldOffset(Offset = "0x16")]
	public readonly bool EnableVehicleRepairKit;

	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0x17")]
	public readonly bool EnableVehicleFire;

	[Token(Token = "0x4001738")]
	[FieldOffset(Offset = "0x18")]
	public readonly bool EnableInGameQuit;

	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0x19")]
	public readonly bool EnableReplaceEPWithVehicleHp;

	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0x1A")]
	public readonly bool EnableSkySurfing;

	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0x1B")]
	public readonly bool DriverFreeCamera;

	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x1C")]
	public readonly bool EnableStrop;

	[Token(Token = "0x400173D")]
	[FieldOffset(Offset = "0x1D")]
	public readonly bool EnableCatapult;

	[Token(Token = "0x400173E")]
	[FieldOffset(Offset = "0x1E")]
	public readonly bool EnableCannon;

	[Token(Token = "0x400173F")]
	[FieldOffset(Offset = "0x1F")]
	public readonly bool EnableOilDrum;

	[Token(Token = "0x4001740")]
	[FieldOffset(Offset = "0x20")]
	public readonly float SkyDivingForceToOpenParachuteHeight;

	[Token(Token = "0x4001741")]
	[FieldOffset(Offset = "0x24")]
	public readonly bool SkyDivingInVehilceCanFire;

	[Token(Token = "0x4001742")]
	[FieldOffset(Offset = "0x25")]
	public readonly bool ShowAutoSlidingBtn;

	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x26")]
	public readonly bool EnableVehicleInvincible;

	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x27")]
	public readonly bool UnlimitedAmmo;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x28")]
	public readonly bool UnlimitBagCapacity;

	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x29")]
	public readonly bool BanAimAssist;

	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x2A")]
	public readonly bool AutoFireAvailable;

	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x2B")]
	public readonly bool EnableBigHead;

	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x2C")]
	public readonly bool EnableFireColliderScale;

	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x30")]
	public readonly float FireColliderRadiusScale;

	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0x34")]
	public readonly float FireColliderHeightScale;

	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x38")]
	public readonly int ScoreToWin;

	[Token(Token = "0x400174D")]
	[FieldOffset(Offset = "0x3C")]
	public readonly int ScoreToWinEndTime;

	[Token(Token = "0x400174E")]
	[FieldOffset(Offset = "0x40")]
	public readonly float MatchStartPrepareTime;

	[Token(Token = "0x400174F")]
	[FieldOffset(Offset = "0x44")]
	public readonly int DoubleScoreStartTime;

	[Token(Token = "0x4001750")]
	[FieldOffset(Offset = "0x48")]
	public readonly int ResultShowEmoteId;

	[Token(Token = "0x4001751")]
	[FieldOffset(Offset = "0x4C")]
	public readonly int ResultShowEmoteId_SnowManWin;

	[Token(Token = "0x4001752")]
	[FieldOffset(Offset = "0x50")]
	public readonly int ResultShowEmoteId_SnowManLose;

	[Token(Token = "0x4001753")]
	[FieldOffset(Offset = "0x54")]
	public readonly bool NeedResultShowData;

	[Token(Token = "0x4001754")]
	[FieldOffset(Offset = "0x55")]
	public readonly bool BanAvatarSkill;

	[Token(Token = "0x4001755")]
	[FieldOffset(Offset = "0x56")]
	public readonly bool EnableShowBag;

	[Token(Token = "0x4001756")]
	[FieldOffset(Offset = "0x58")]
	public readonly float MatchExpireTime;

	[Token(Token = "0x4001757")]
	[FieldOffset(Offset = "0x5C")]
	public readonly bool EnableAssistantTips;

	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x5D")]
	public readonly bool EnableAssistantTriggerTips;

	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0x5E")]
	public readonly bool EnableAssistantMarkItemTips;

	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x60")]
	public readonly int MaxPumpkinOnHead;

	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x64")]
	public readonly int GameIntroDelayTime;

	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x68")]
	public readonly int GameIntroTime;

	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x6C")]
	public readonly bool SafeZoneIgnoreFirstOne;

	[Token(Token = "0x400175E")]
	[FieldOffset(Offset = "0x70")]
	public readonly float MinimapScale;

	[Token(Token = "0x400175F")]
	[FieldOffset(Offset = "0x74")]
	public readonly bool MinimapEnableDynamicScaling;

	[Token(Token = "0x4001760")]
	[FieldOffset(Offset = "0x75")]
	public readonly bool MinimapEnableFirstScale;

	[Token(Token = "0x4001761")]
	[FieldOffset(Offset = "0x76")]
	public readonly bool MinimapEnableSafezoneScale;

	[Token(Token = "0x4001762")]
	[FieldOffset(Offset = "0x77")]
	public readonly bool MinimapNeverScale;

	[Token(Token = "0x4001763")]
	[FieldOffset(Offset = "0x78")]
	public readonly bool MinimapEnableVehicleScale;

	[Token(Token = "0x4001764")]
	[FieldOffset(Offset = "0x7C")]
	public readonly float MinimapFirstScaleStableDuration;

	[Token(Token = "0x4001765")]
	[FieldOffset(Offset = "0x80")]
	public readonly float MinimapFirstScaleDuration;

	[Token(Token = "0x4001766")]
	[FieldOffset(Offset = "0x84")]
	public readonly float MinimapSafezoneMaxHalfWidth;

	[Token(Token = "0x4001767")]
	[FieldOffset(Offset = "0x88")]
	public readonly float MinimapSafezoneMinHalfWidth;

	[Token(Token = "0x4001768")]
	[FieldOffset(Offset = "0x8C")]
	public readonly float MinimapVehicleHalfWidth;

	[Token(Token = "0x4001769")]
	[FieldOffset(Offset = "0x90")]
	public readonly bool BuffIconOpen;

	[Token(Token = "0x400176A")]
	[FieldOffset(Offset = "0x91")]
	public readonly bool EnableTrainingChat;

	[Token(Token = "0x400176B")]
	[FieldOffset(Offset = "0x94")]
	public readonly float ChatBoxCloseDelay;

	[Token(Token = "0x400176C")]
	[FieldOffset(Offset = "0x98")]
	public readonly int ChatMsgLengthLimit;

	[Token(Token = "0x400176D")]
	[FieldOffset(Offset = "0x9C")]
	public readonly float ChatMsgCD;

	[Token(Token = "0x400176E")]
	[FieldOffset(Offset = "0xA0")]
	public readonly float AddFriendInfoCloseDelay;

	[Token(Token = "0x400176F")]
	[FieldOffset(Offset = "0xA4")]
	public readonly float InviteDisagreeDelay;

	[Token(Token = "0x4001770")]
	[FieldOffset(Offset = "0xA8")]
	public readonly float HangeUpExpireTime;

	[Token(Token = "0x4001771")]
	[FieldOffset(Offset = "0xAC")]
	public readonly int KillNotificationTeamColor;

	[Token(Token = "0x4001772")]
	[FieldOffset(Offset = "0xB0")]
	public readonly bool KillNotificationTeamSound;

	[Token(Token = "0x4001773")]
	[FieldOffset(Offset = "0xB4")]
	public readonly float PVE_LightTowerPrepareTime;

	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0xB8")]
	public readonly bool IsEventZomibieFootballLanucher;

	[Token(Token = "0x4001775")]
	[FieldOffset(Offset = "0xBC")]
	public readonly int SafeZoneIndexToObsoleteExtraLife;

	[Token(Token = "0x4001776")]
	[FieldOffset(Offset = "0xC0")]
	public readonly int ArmsInfoListDelayTime;

	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0xC4")]
	public readonly bool IsStackedKillOnlyLocalShow;

	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0xC5")]
	public readonly bool ShowAdditionalKillNotifyIfDead;

	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0xC6")]
	public readonly bool IsKillOnlyLocalShow;

	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0xC7")]
	public readonly bool BigMapShowIconToggleBtn;

	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0xC8")]
	public readonly bool IsNeedGoldenAttachmentsShow;

	[Token(Token = "0x400177C")]
	[FieldOffset(Offset = "0xCC")]
	public readonly float MinimapScaleToGameZone;

	[Token(Token = "0x400177D")]
	[FieldOffset(Offset = "0xD0")]
	public readonly int GameShowLoserAudioRank;

	[Token(Token = "0x400177E")]
	[FieldOffset(Offset = "0xD4")]
	public readonly float EscortMatchBoss_MaxHP;

	[Token(Token = "0x400177F")]
	[FieldOffset(Offset = "0xD8")]
	public readonly float EscortMatchBoss_HPReviveRate;

	[Token(Token = "0x4001780")]
	[FieldOffset(Offset = "0xDC")]
	public readonly float EscortMatchBoss_PlayerAddHPRate;

	[Token(Token = "0x4001781")]
	[FieldOffset(Offset = "0xE0")]
	public readonly bool NeedIntroCutscene;

	[Token(Token = "0x4001782")]
	[FieldOffset(Offset = "0xE4")]
	public readonly float TransformPawnCameraOffset;

	[Token(Token = "0x4001783")]
	[FieldOffset(Offset = "0xE8")]
	public readonly bool HumanTireOpen;

	[Token(Token = "0x4001784")]
	[FieldOffset(Offset = "0xE9")]
	public readonly bool HumanTireTeammateOpen;

	[Token(Token = "0x4001785")]
	[FieldOffset(Offset = "0xEA")]
	public readonly bool HumanTireOppomentOpen;

	[Token(Token = "0x4001786")]
	[FieldOffset(Offset = "0xEB")]
	public readonly bool IsShowEquipNotificationTip;

	[Token(Token = "0x4001787")]
	[FieldOffset(Offset = "0xEC")]
	public readonly bool IsShowAttachmentNotificationTip;

	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0xF0")]
	public readonly float TrainingWaitingPortalTime;

	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0xF4")]
	public readonly int WeatherNightStart;

	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0xF8")]
	public readonly int WeatherNightEnd;

	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0xFC")]
	public readonly int weatherTwilightStart;

	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0x100")]
	public readonly int weatherTwilightEnd;

	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x104")]
	public readonly int MeteorDuration;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x108")]
	public readonly string MeteorSpecificTime;

	[Token(Token = "0x400178F")]
	[FieldOffset(Offset = "0x10C")]
	public readonly int EnableMVPShow;

	[Token(Token = "0x4001790")]
	[FieldOffset(Offset = "0x110")]
	public readonly bool EnableMatchResultAvatarForLowMemory;

	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0x111")]
	public readonly bool EnableMatchResultMultiAvatarForLowMemory;

	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x114")]
	public readonly float AimAssistKnockDownParam;

	[Token(Token = "0x4001793")]
	[FieldOffset(Offset = "0x118")]
	public readonly bool DisableAimAssistReviveParachutingTarget;

	[Token(Token = "0x4001794")]
	[FieldOffset(Offset = "0x119")]
	public readonly bool HumanTireRankModeOpen;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x11A")]
	public readonly bool PlayerReadyNeedDelay;

	[Token(Token = "0x4001796")]
	[FieldOffset(Offset = "0x11B")]
	public readonly bool NeedPreloadPlayerAnimators;

	[Token(Token = "0x4001797")]
	[FieldOffset(Offset = "0x11C")]
	public readonly bool NeedPreloadVestHelmetBackpack;

	[Token(Token = "0x4001798")]
	[FieldOffset(Offset = "0x11D")]
	public readonly bool ShowBulletHole;

	[Token(Token = "0x4001799")]
	[FieldOffset(Offset = "0x120")]
	public readonly float GuildWarWarehouseStoreTime;

	[Token(Token = "0x400179A")]
	[FieldOffset(Offset = "0x124")]
	public readonly float GuilWar_NormalTime;

	[Token(Token = "0x400179B")]
	[FieldOffset(Offset = "0x128")]
	public readonly bool EnableModeChat;

	[Token(Token = "0x400179C")]
	[FieldOffset(Offset = "0x12C")]
	public readonly int ModeChatMaxMsgCnt;

	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x130")]
	public readonly float CSBotAgentTimeoutReconHintDelay;

	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x134")]
	public readonly float CSBotAgentTimeoutReconHintDuration;

	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x138")]
	public readonly float ADS1v1PrepareCountdownDuration;

	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x13C")]
	public readonly float ADS1v1PrepareTransportDuration;

	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x140")]
	public readonly float ADS1v1TransportAnimDuration;

	[Token(Token = "0x40017A2")]
	[FieldOffset(Offset = "0x144")]
	public readonly float ADS1v1EndCountdownDuration;

	[Token(Token = "0x40017A3")]
	[FieldOffset(Offset = "0x148")]
	public readonly float ADSNormalDuration;

	[Token(Token = "0x40017A4")]
	[FieldOffset(Offset = "0x14C")]
	public readonly float ADSNormalBonusDuration;

	[Token(Token = "0x40017A5")]
	[FieldOffset(Offset = "0x150")]
	public readonly float ADS1v1Duration;

	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x154")]
	public readonly bool CenterSafeZoneOnBigMap;

	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x155")]
	public readonly bool CenterSafeZoneOnMiniMap;

	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x156")]
	public readonly bool CenterSafeZoneOnSideMap;

	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x157")]
	public readonly bool OBCenterSafeZoneOnBigMap;

	[Token(Token = "0x40017AA")]
	[FieldOffset(Offset = "0x158")]
	public readonly bool OBCenterSafeZoneOnSideMap;

	[Token(Token = "0x40017AB")]
	[FieldOffset(Offset = "0x15C")]
	public readonly int OBCenterSafeZoneStartStage;

	[Token(Token = "0x40017AC")]
	[FieldOffset(Offset = "0x160")]
	public readonly int OBCenterSafeZoneEndStage;

	[Token(Token = "0x40017AD")]
	[FieldOffset(Offset = "0x164")]
	public readonly int OBCenterSafeZoneEndBaseRadius;

	[Token(Token = "0x40017AE")]
	[FieldOffset(Offset = "0x168")]
	public readonly bool UseNewDeathCamera;

	[Token(Token = "0x40017AF")]
	[FieldOffset(Offset = "0x169")]
	public readonly bool EnableShowMapMarkInHud;

	[Token(Token = "0x40017B0")]
	[FieldOffset(Offset = "0x16A")]
	public readonly bool UseFullAttachment;

	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0x16B")]
	public readonly bool TeamBarStrikeDownIconShowMode;

	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0x16C")]
	public readonly float Pregame_Duration;

	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0x170")]
	public readonly float Preset_Duration;

	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x174")]
	public readonly int RP_GameObjective;

	[Token(Token = "0x40017B5")]
	[FieldOffset(Offset = "0x178")]
	public readonly int RP_SoulPerPhase;

	[Token(Token = "0x40017B6")]
	[FieldOffset(Offset = "0x17C")]
	public readonly int RP_SoulDrainRadius;

	[Token(Token = "0x40017B7")]
	[FieldOffset(Offset = "0x180")]
	public readonly float RP_GameTime;

	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x184")]
	public readonly int RP_HP;

	[Token(Token = "0x40017B9")]
	[FieldOffset(Offset = "0x188")]
	public readonly float Control_ControlPointActivatingTime;

	[Token(Token = "0x40017BA")]
	[FieldOffset(Offset = "0x18C")]
	public readonly float Control_ChangeActivateControlPointInterval;

	[Token(Token = "0x40017BB")]
	[FieldOffset(Offset = "0x190")]
	public readonly float Control_StartActivateControlPointInterval;

	[Token(Token = "0x40017BC")]
	[FieldOffset(Offset = "0x194")]
	public readonly float Control_ZoneCloseTips;

	[Token(Token = "0x40017BD")]
	[FieldOffset(Offset = "0x198")]
	public readonly float Control_ZoneActivateTips;

	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0x19C")]
	public readonly float Control_TryingControlDelay;

	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x1A0")]
	public readonly int ForceTutorial_BotWeapon1;

	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0x1A4")]
	public readonly int ForceTutorial_BotWeapon2;

	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0x1A8")]
	public readonly int ForceTutorial_BotWeapon3;

	[Token(Token = "0x40017C2")]
	[FieldOffset(Offset = "0x1AC")]
	public readonly int ForceTutorial_BotWeapon4;

	[Token(Token = "0x40017C3")]
	[FieldOffset(Offset = "0x1B0")]
	public readonly int ForceTutorial_BotWeapon5;

	[Token(Token = "0x40017C4")]
	[FieldOffset(Offset = "0x1B4")]
	public readonly int ForceTutorial_BotWeapon6;

	[Token(Token = "0x40017C5")]
	[FieldOffset(Offset = "0x1B8")]
	public readonly int ForceTutorial_BotWeapon7;

	[Token(Token = "0x40017C6")]
	[FieldOffset(Offset = "0x1BC")]
	public readonly int ForceTutorial_BotWeapon8;

	[Token(Token = "0x40017C7")]
	[FieldOffset(Offset = "0x1C0")]
	public readonly string ForceTutorial_LootItem;

	[Token(Token = "0x40017C8")]
	[FieldOffset(Offset = "0x1C4")]
	public readonly string ForceTutorial_LootBoxItem;

	[Token(Token = "0x40017C9")]
	[FieldOffset(Offset = "0x1C8")]
	public readonly float ForceTutorial_BotShootTime;

	[Token(Token = "0x40017CA")]
	[FieldOffset(Offset = "0x1CC")]
	public readonly float ForceTutorial_BotShootGap;

	[Token(Token = "0x40017CB")]
	[FieldOffset(Offset = "0x1D0")]
	public readonly int ForceTutorial_BotDamageToTeammate;

	[Token(Token = "0x40017CC")]
	[FieldOffset(Offset = "0x1D4")]
	public readonly int ForceTutorial_BotDamageToPlayer;

	[Token(Token = "0x40017CD")]
	[FieldOffset(Offset = "0x1D8")]
	public readonly int ForceTutorial_BotEnemyModel;

	[Token(Token = "0x40017CE")]
	[FieldOffset(Offset = "0x1DC")]
	public readonly int ForceTutorial_BotTeammateModel;

	[Token(Token = "0x40017CF")]
	[FieldOffset(Offset = "0x1E0")]
	public readonly string ForceTutorial_KellyClothes;

	[Token(Token = "0x40017D0")]
	[FieldOffset(Offset = "0x1E4")]
	public readonly float Banknote_ScoreChangeDelay;

	[Token(Token = "0x40017D1")]
	[FieldOffset(Offset = "0x1E8")]
	public readonly float SPPlayLastSafeZoneBGMRadius;

	[Token(Token = "0x40017D2")]
	[FieldOffset(Offset = "0x1EC")]
	public readonly float BountyRepairPoint;

	[Token(Token = "0x40017D3")]
	[FieldOffset(Offset = "0x1F0")]
	public readonly int TrapCatchDurationMS;

	[Token(Token = "0x40017D4")]
	[FieldOffset(Offset = "0x1F4")]
	public readonly int TrapDelayActiveTimeMS;

	[Token(Token = "0x40017D5")]
	[FieldOffset(Offset = "0x1F8")]
	public readonly int TrapRescureTimeMS;

	[Token(Token = "0x40017D6")]
	[FieldOffset(Offset = "0x1FC")]
	public readonly bool EnableQuickChat;

	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x1FD")]
	public readonly bool BR_CanRevive;

	[Token(Token = "0x40017D8")]
	[FieldOffset(Offset = "0x1FE")]
	public readonly bool EnableAskPurchaseCSItem;

	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x1FF")]
	public readonly bool EnableRequestHelpPurchaseQuickChat;

	[Token(Token = "0x40017DA")]
	[FieldOffset(Offset = "0x200")]
	public readonly bool EnableResponseHelpPurchaseQuickChat;

	[Token(Token = "0x40017DB")]
	[FieldOffset(Offset = "0x201")]
	public readonly bool LastRoundMatchPointTransition;

	[Token(Token = "0x40017DC")]
	[FieldOffset(Offset = "0x202")]
	public readonly bool ShowMusicBeatCombo;

	[Token(Token = "0x40017DD")]
	[FieldOffset(Offset = "0x203")]
	public readonly bool EnableAceShow;

	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x204")]
	public readonly int GroupMode3AceKillStreak;

	[Token(Token = "0x40017DF")]
	[FieldOffset(Offset = "0x208")]
	public readonly int GroupMode4AceKillStreak;

	[Token(Token = "0x40017E0")]
	[FieldOffset(Offset = "0x20C")]
	public readonly int GroupMode5AceKillStreak;

	[Token(Token = "0x40017E1")]
	[FieldOffset(Offset = "0x210")]
	public readonly bool ShowDeadPopMsg;

	[Token(Token = "0x40017E2")]
	[FieldOffset(Offset = "0x211")]
	public readonly bool NeedCheckIsSmallSafeZone;

	[Token(Token = "0x40017E3")]
	[FieldOffset(Offset = "0x212")]
	public readonly bool InGameTokenShow;

	[Token(Token = "0x40017E4")]
	[FieldOffset(Offset = "0x214")]
	public readonly int ScoreToShowEffect;

	[Token(Token = "0x40017E5")]
	[FieldOffset(Offset = "0x218")]
	public readonly float EnergyStoneBoxActiveTime;

	[Token(Token = "0x40017E6")]
	[FieldOffset(Offset = "0x21C")]
	public readonly float AllEnergyStoneScoreBonus;

	[Token(Token = "0x40017E7")]
	[FieldOffset(Offset = "0x220")]
	public readonly int ChokePointBuffDuration;

	[Token(Token = "0x40017E8")]
	[FieldOffset(Offset = "0x224")]
	public readonly float ChokePointBuffScourBonus;

	[Token(Token = "0x40017E9")]
	[FieldOffset(Offset = "0x228")]
	public readonly bool OpenFootStepAndFireUIHint;

	[Token(Token = "0x40017EA")]
	[FieldOffset(Offset = "0x229")]
	public readonly bool IsCollectionTransformDisable;

	[Token(Token = "0x40017EB")]
	[FieldOffset(Offset = "0x22A")]
	public readonly bool TDMLikeShopEnablePurchaseDuringDeath;

	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0x22B")]
	public readonly bool TDMLikeShopEnableEndSelectionManuallyAfterRevival;

	[Token(Token = "0x40017ED")]
	[FieldOffset(Offset = "0x22C")]
	public readonly float LowBloodLine;

	[Token(Token = "0x40017EE")]
	[FieldOffset(Offset = "0x230")]
	public readonly string LowBloodLineEffect;

	[Token(Token = "0x40017EF")]
	[FieldOffset(Offset = "0x234")]
	public readonly uint LuckyDrawBoxRerollCost;

	[Token(Token = "0x40017F0")]
	[FieldOffset(Offset = "0x238")]
	public readonly uint LuckyDrawBoxFirstDropCost;

	[Token(Token = "0x40017F1")]
	[FieldOffset(Offset = "0x23C")]
	public readonly uint LuckyDrawBoxDropCost;

	[Token(Token = "0x40017F2")]
	[FieldOffset(Offset = "0x240")]
	public readonly uint GameTimeRedLabelSeconds;

	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x244")]
	public readonly uint DeathMatchTargetRestCnt;

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x1DD6720", Offset = "0x1DD6720", VA = "0x1DD6720")]
	public GameModeSetting()
	{
	}

	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x1DD6B44", Offset = "0x1DD6B44", VA = "0x1DD6B44", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
