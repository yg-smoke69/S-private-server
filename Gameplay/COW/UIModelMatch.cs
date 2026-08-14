using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003168")]
internal class UIModelMatch : UIBaseModel
{
	[Token(Token = "0x2003169")]
	public class PlayerDeadInfo
	{
		[Token(Token = "0x4012CD1")]
		[FieldOffset(Offset = "0x8")]
		public string KillerName;

		[Token(Token = "0x4012CD2")]
		[FieldOffset(Offset = "0xC")]
		public string WeaponName;

		[Token(Token = "0x4012CD3")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 KillerPos;

		[Token(Token = "0x4012CD4")]
		[FieldOffset(Offset = "0x1C")]
		public bool KillerIsZombie;

		[Token(Token = "0x6014C91")]
		[Address(RVA = "0x1765328", Offset = "0x1765328", VA = "0x1765328")]
		public PlayerDeadInfo()
		{
		}
	}

	[Token(Token = "0x200316A")]
	private sealed class _003CGetExpGuideDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012CD5")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EFresh.GuideMode mode;

		[Token(Token = "0x6014C92")]
		[Address(RVA = "0x1764984", Offset = "0x1764984", VA = "0x1764984")]
		public _003CGetExpGuideDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014C93")]
		[Address(RVA = "0x176498C", Offset = "0x176498C", VA = "0x176498C")]
		internal bool _003C_003Em__0(ExpGuideDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200316B")]
	private sealed class _003CSetLoadingPlayerInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012CD6")]
		[FieldOffset(Offset = "0x8")]
		internal ulong myAccountId;

		[Token(Token = "0x6014C94")]
		[Address(RVA = "0x1765248", Offset = "0x1765248", VA = "0x1765248")]
		public _003CSetLoadingPlayerInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014C95")]
		[Address(RVA = "0x1765250", Offset = "0x1765250", VA = "0x1765250")]
		internal int _003C_003Em__0(MatchPregameInfo x, MatchPregameInfo y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200316C")]
	private sealed class _003COnAddPlayer_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012CD7")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG playerID;

		[Token(Token = "0x6014C96")]
		[Address(RVA = "0x1764DBC", Offset = "0x1764DBC", VA = "0x1764DBC")]
		public _003COnAddPlayer_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014C97")]
		[Address(RVA = "0x1764DC4", Offset = "0x1764DC4", VA = "0x1764DC4")]
		internal bool _003C_003Em__0(PlayerData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6014C98")]
		[Address(RVA = "0x1764EE4", Offset = "0x1764EE4", VA = "0x1764EE4")]
		internal bool _003C_003Em__1(PlayerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200316D")]
	private sealed class _003CGetTeammateData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012CD8")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG pid;

		[Token(Token = "0x6014C99")]
		[Address(RVA = "0x1764BAC", Offset = "0x1764BAC", VA = "0x1764BAC")]
		public _003CGetTeammateData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014C9A")]
		[Address(RVA = "0x1764BB4", Offset = "0x1764BB4", VA = "0x1764BB4")]
		internal bool _003C_003Em__0(PlayerData p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200316E")]
	private sealed class _003CRequestStartMatchMaking_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012CD9")]
		[FieldOffset(Offset = "0x8")]
		internal DGNDKMLMLPM match_mode;

		[Token(Token = "0x4012CDA")]
		[FieldOffset(Offset = "0xC")]
		internal JOKABEAPNPP game_mode;

		[Token(Token = "0x4012CDB")]
		[FieldOffset(Offset = "0x10")]
		internal List<uint> map_ids;

		[Token(Token = "0x4012CDC")]
		[FieldOffset(Offset = "0x14")]
		internal uint map_difficulty;

		[Token(Token = "0x4012CDD")]
		[FieldOffset(Offset = "0x18")]
		internal bool isRandomMap;

		[Token(Token = "0x4012CDE")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelMatch _0024this;

		[Token(Token = "0x6014C9B")]
		[Address(RVA = "0x1765004", Offset = "0x1765004", VA = "0x1765004")]
		public _003CRequestStartMatchMaking_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014C9C")]
		[Address(RVA = "0x176500C", Offset = "0x176500C", VA = "0x176500C")]
		internal void _003C_003Em__0(ResErrorCode error, ResDownloadType download_type)
		{
		}

		[Token(Token = "0x6014C9D")]
		[Address(RVA = "0x1765180", Offset = "0x1765180", VA = "0x1765180")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6014C9E")]
		[Address(RVA = "0x17651E4", Offset = "0x17651E4", VA = "0x17651E4")]
		internal void _003C_003Em__2()
		{
		}
	}

	[Token(Token = "0x200316F")]
	private sealed class _003CCheckIfNeedRequestWorkshopInfo_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012CDF")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelMapOpeningInfo openningInfo;

		[Token(Token = "0x4012CE0")]
		[FieldOffset(Offset = "0xC")]
		internal Action callBack;

		[Token(Token = "0x6014C9F")]
		[Address(RVA = "0x176463C", Offset = "0x176463C", VA = "0x176463C")]
		public _003CCheckIfNeedRequestWorkshopInfo_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014CA0")]
		[Address(RVA = "0x1764644", Offset = "0x1764644", VA = "0x1764644")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003170")]
	private sealed class _003CGetTutorialPlayerDataByPlayerID_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012CE1")]
		[FieldOffset(Offset = "0x8")]
		internal ulong playerId;

		[Token(Token = "0x6014CA1")]
		[Address(RVA = "0x1764CD4", Offset = "0x1764CD4", VA = "0x1764CD4")]
		public _003CGetTutorialPlayerDataByPlayerID_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014CA2")]
		[Address(RVA = "0x1764CDC", Offset = "0x1764CDC", VA = "0x1764CDC")]
		internal bool _003C_003Em__0(PlayerData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003171")]
	private sealed class _003CGetPlayerDataByAccountID_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012CE2")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x6014CA3")]
		[Address(RVA = "0x17649CC", Offset = "0x17649CC", VA = "0x17649CC")]
		public _003CGetPlayerDataByAccountID_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6014CA4")]
		[Address(RVA = "0x17649D4", Offset = "0x17649D4", VA = "0x17649D4")]
		internal bool _003C_003Em__0(PlayerData p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003172")]
	private sealed class _003CGetPlayerDataByPlayerID_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012CE3")]
		[FieldOffset(Offset = "0x8")]
		internal IHAAMHPPLMG playerID;

		[Token(Token = "0x6014CA5")]
		[Address(RVA = "0x1764A68", Offset = "0x1764A68", VA = "0x1764A68")]
		public _003CGetPlayerDataByPlayerID_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6014CA6")]
		[Address(RVA = "0x1764A70", Offset = "0x1764A70", VA = "0x1764A70")]
		internal bool _003C_003Em__0(PlayerData p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003173")]
	private sealed class _003CGetPlayerDataByNickName_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012CE4")]
		[FieldOffset(Offset = "0x8")]
		internal string nickName;

		[Token(Token = "0x6014CA7")]
		[Address(RVA = "0x1764A14", Offset = "0x1764A14", VA = "0x1764A14")]
		public _003CGetPlayerDataByNickName_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6014CA8")]
		[Address(RVA = "0x1764A1C", Offset = "0x1764A1C", VA = "0x1764A1C")]
		internal bool _003C_003Em__0(PlayerData p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003174")]
	private sealed class _003CGetRankByTeamID_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012CE5")]
		[FieldOffset(Offset = "0x8")]
		internal byte teamID;

		[Token(Token = "0x6014CA9")]
		[Address(RVA = "0x1764B90", Offset = "0x1764B90", VA = "0x1764B90")]
		public _003CGetRankByTeamID_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6014CAA")]
		[Address(RVA = "0x1764B98", Offset = "0x1764B98", VA = "0x1764B98")]
		internal bool _003C_003Em__0(byte t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003175")]
	private sealed class _003CGetLastRankByTeamID_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4012CE6")]
		[FieldOffset(Offset = "0x8")]
		internal byte teamID;

		[Token(Token = "0x6014CAB")]
		[Address(RVA = "0x17649B0", Offset = "0x17649B0", VA = "0x17649B0")]
		public _003CGetLastRankByTeamID_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6014CAC")]
		[Address(RVA = "0x17649B8", Offset = "0x17649B8", VA = "0x17649B8")]
		internal bool _003C_003Em__0(byte t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012C2D")]
	public const uint PropID_NewbieGuideDesc = 1u;

	[Token(Token = "0x4012C2E")]
	public const uint PropID_MatchTime = 2u;

	[Token(Token = "0x4012C2F")]
	public const uint PropID_LocalPlayerKillCount = 4u;

	[Token(Token = "0x4012C30")]
	public const uint PropID_RemainingPlayer = 8u;

	[Token(Token = "0x4012C31")]
	public const uint PropID_KillOccurs = 16u;

	[Token(Token = "0x4012C32")]
	public const uint PropID_MedkitCountChanged = 32u;

	[Token(Token = "0x4012C33")]
	public const uint PropID_PickupListChanged = 64u;

	[Token(Token = "0x4012C34")]
	public const uint PropID_SniperOn = 128u;

	[Token(Token = "0x4012C35")]
	public const uint PropID_RefreshMatchResult = 256u;

	[Token(Token = "0x4012C36")]
	public const uint PropID_TeammateAdd = 512u;

	[Token(Token = "0x4012C37")]
	public const uint PropID_TeammateDel = 1024u;

	[Token(Token = "0x4012C38")]
	public const uint PropID_ObservePlayerKillCount = 2048u;

	[Token(Token = "0x4012C39")]
	public const uint PropID_ObserverPlayerChanged = 4096u;

	[Token(Token = "0x4012C3A")]
	public const uint PropID_BattleInfo = 8192u;

	[Token(Token = "0x4012C3B")]
	public const uint PropID_TargetPlayerKillOccurs = 16384u;

	[Token(Token = "0x4012C3C")]
	public const uint PropID_TeamateKnockDown = 32768u;

	[Token(Token = "0x4012C3D")]
	public const uint PropID_ObserverTeammateSwitch = 65536u;

	[Token(Token = "0x4012C3E")]
	public const uint PropID_KnockOtherDown = 131072u;

	[Token(Token = "0x4012C3F")]
	public const uint PropID_EPRankingChange = 262144u;

	[Token(Token = "0x4012C40")]
	public const uint PropID_EPRankingTopChange = 524288u;

	[Token(Token = "0x4012C41")]
	public const uint PropID_RedEnvelopeInfo = 1048576u;

	[Token(Token = "0x4012C42")]
	public const uint PropID_PVEEnemyRemaingCount = 2097152u;

	[Token(Token = "0x4012C43")]
	public const uint PropID_PVEEnemyKillCount = 4194304u;

	[Token(Token = "0x4012C44")]
	public const uint PropID_PVETurnCount = 8388608u;

	[Token(Token = "0x4012C45")]
	public const uint PropID_LocalPlayerDeathCount = 16777216u;

	[Token(Token = "0x4012C46")]
	public const uint PropID_ObservePlayerDeathCount = 33554432u;

	[Token(Token = "0x4012C47")]
	public const uint PropID_BombMatchBombInfoChange = 67108864u;

	[Token(Token = "0x4012C48")]
	public const uint PropID_BanknoteMatchUnlockInfoChange = 134217728u;

	[Token(Token = "0x4012C49")]
	public const uint PropID_AskPurchaseUpdate = 268435456u;

	[Token(Token = "0x4012C4A")]
	public const uint PropID_REVIVEINFO = 536870912u;

	[Token(Token = "0x4012C4B")]
	public const uint PropID_SYSTEMKILL = 1073741824u;

	[Token(Token = "0x4012C4C")]
	public const uint KILL_FLAG_FIRST_BLOOD = 1u;

	[Token(Token = "0x4012C4D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<IHAAMHPPLMG, int> m_MatchKillCount;

	[Token(Token = "0x4012C4E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<IHAAMHPPLMG, int> m_MatchDeathCount;

	[Token(Token = "0x4012C4F")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<IHAAMHPPLMG, string> KilledBySystemPlayerDict;

	[Token(Token = "0x4012C50")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<IHAAMHPPLMG, string> KilledBySystemTeammateDict;

	[Token(Token = "0x4012C51")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsMatchMaking;

	[Token(Token = "0x4012C52")]
	public const int COUNT_DOWN_SECOND = 5;

	[Token(Token = "0x4012C53")]
	[FieldOffset(Offset = "0x20")]
	private int m_MatchTime;

	[Token(Token = "0x4012C54")]
	[FieldOffset(Offset = "0x24")]
	private MapConfigData m_MapConfigData;

	[Token(Token = "0x4012C55")]
	private const int EPBADGE_RANKING_FILTER = 10;

	[Token(Token = "0x4012C56")]
	[FieldOffset(Offset = "0x28")]
	private List<EPPlayerInfo> m_ElitePassRankingList;

	[Token(Token = "0x4012C57")]
	[FieldOffset(Offset = "0x2C")]
	public List<uint> ListOverloadSceneCount;

	[Token(Token = "0x4012C58")]
	[FieldOffset(Offset = "0x30")]
	public bool SaveLocalPlayerTeammates;

	[Token(Token = "0x4012C59")]
	[FieldOffset(Offset = "0x34")]
	public List<PlayerData> LocalPlayerTeammates;

	[Token(Token = "0x4012C5A")]
	[FieldOffset(Offset = "0x38")]
	public int MatchEndRank;

	[Token(Token = "0x4012C5B")]
	[FieldOffset(Offset = "0x3C")]
	public byte LocalTeamId;

	[Token(Token = "0x4012C5C")]
	[FieldOffset(Offset = "0x40")]
	public int Team1Score;

	[Token(Token = "0x4012C5D")]
	[FieldOffset(Offset = "0x44")]
	public int Team2Score;

	[Token(Token = "0x4012C5E")]
	[FieldOffset(Offset = "0x48")]
	private CandidateReporteeData m_KillerData;

	[Token(Token = "0x4012C5F")]
	[FieldOffset(Offset = "0x4C")]
	private CandidateReporteeData m_KnockDownerData;

	[Token(Token = "0x4012C60")]
	[FieldOffset(Offset = "0x50")]
	private uint m_LastTPCount;

	[Token(Token = "0x4012C61")]
	[FieldOffset(Offset = "0x54")]
	private float m_LastTPTime;

	[Token(Token = "0x4012C62")]
	[FieldOffset(Offset = "0x58")]
	public bool BanAvatarActiveSkill;

	[Token(Token = "0x4012C63")]
	[FieldOffset(Offset = "0x59")]
	public bool BanAvatarPassiveSkill;

	[Token(Token = "0x4012C64")]
	[FieldOffset(Offset = "0x5C")]
	public uint CDPercentForAllActiveSkill;

	[Token(Token = "0x4012C65")]
	[FieldOffset(Offset = "0x60")]
	public Dictionary<string, uint> CDPercentPerActiveSkill;

	[Token(Token = "0x4012C66")]
	[FieldOffset(Offset = "0x64")]
	private bool _003CIsChickenPlayerObserver_003Ek__BackingField;

	[Token(Token = "0x4012C67")]
	[FieldOffset(Offset = "0x65")]
	private bool _003CIsCustomRoomSettingHideKillInfo_003Ek__BackingField;

	[Token(Token = "0x4012C68")]
	[FieldOffset(Offset = "0x66")]
	private bool _003CIsCustomRoomSettingNoSkill_003Ek__BackingField;

	[Token(Token = "0x4012C69")]
	[FieldOffset(Offset = "0x67")]
	private bool _003CIsCustomRoomSettingHideCloth_003Ek__BackingField;

	[Token(Token = "0x4012C6A")]
	[FieldOffset(Offset = "0x68")]
	private bool _003CIsCustomRoomSettingUnlimitedAmmo_003Ek__BackingField;

	[Token(Token = "0x4012C6B")]
	[FieldOffset(Offset = "0x69")]
	private bool _003CMapUIShowDeadBoxEnable_003Ek__BackingField;

	[Token(Token = "0x4012C6C")]
	[FieldOffset(Offset = "0x6A")]
	private bool _003CIsNoPowerGun_003Ek__BackingField;

	[Token(Token = "0x4012C6D")]
	[FieldOffset(Offset = "0x6B")]
	private bool _003CIsCustomRoomSettingNoHud_003Ek__BackingField;

	[Token(Token = "0x4012C6E")]
	[FieldOffset(Offset = "0x6C")]
	private bool _003CIsCustomRoomSettingFriendDmg_003Ek__BackingField;

	[Token(Token = "0x4012C6F")]
	[FieldOffset(Offset = "0x6D")]
	private bool _003CIsCustomRoomSettingInGameChatOpen_003Ek__BackingField;

	[Token(Token = "0x4012C70")]
	[FieldOffset(Offset = "0x6E")]
	private bool _003CIsCustomRoomSettingNoAuxAim_003Ek__BackingField;

	[Token(Token = "0x4012C71")]
	[FieldOffset(Offset = "0x6F")]
	private bool _003CIsMobileReplayEnabled_003Ek__BackingField;

	[Token(Token = "0x4012C72")]
	[FieldOffset(Offset = "0x70")]
	private string _003CWorkshopShareCode_003Ek__BackingField;

	[Token(Token = "0x4012C73")]
	[FieldOffset(Offset = "0x74")]
	private string _003CWorkshopMapName_003Ek__BackingField;

	[Token(Token = "0x4012C74")]
	[FieldOffset(Offset = "0x78")]
	private bool _003CShowingHallOverMask_003Ek__BackingField;

	[Token(Token = "0x4012C75")]
	[FieldOffset(Offset = "0x79")]
	private bool _003CUserControlDirty_003Ek__BackingField;

	[Token(Token = "0x4012C76")]
	[FieldOffset(Offset = "0x7A")]
	private bool _003CEnableEPRecoveryOverwrite_003Ek__BackingField;

	[Token(Token = "0x4012C77")]
	[FieldOffset(Offset = "0x80")]
	private ulong _003CMVPPlayerUID_003Ek__BackingField;

	[Token(Token = "0x4012C78")]
	[FieldOffset(Offset = "0x88")]
	private bool _003CHideClientDamageShow_003Ek__BackingField;

	[Token(Token = "0x4012C79")]
	[FieldOffset(Offset = "0x8C")]
	private List<IHAAMHPPLMG> m_LocalTeamPlayerIDs;

	[Token(Token = "0x4012C7A")]
	[FieldOffset(Offset = "0x90")]
	private List<IHAAMHPPLMG> m_OppoTeamPlayerIDs;

	[Token(Token = "0x4012C7B")]
	[FieldOffset(Offset = "0x94")]
	private List<ulong> m_LocalSubTeamIDs;

	[Token(Token = "0x4012C7C")]
	[FieldOffset(Offset = "0x98")]
	private AwardGameLinkNtf m_LinkDataAfterMatch;

	[Token(Token = "0x4012C7D")]
	[FieldOffset(Offset = "0x9C")]
	private Dictionary<byte, List<PlayerData>> m_TeamPlayerDic;

	[Token(Token = "0x4012C7E")]
	[FieldOffset(Offset = "0xA0")]
	private List<ResultTeamData> m_MatchResult;

	[Token(Token = "0x4012C7F")]
	[FieldOffset(Offset = "0xA4")]
	private List<PlayerData> m_PlayerDataList;

	[Token(Token = "0x4012C80")]
	[FieldOffset(Offset = "0xA8")]
	private MatchStatsRes m_PendingMatchResultData;

	[Token(Token = "0x4012C81")]
	[FieldOffset(Offset = "0xAC")]
	private List<TeammateStats> m_ArmsRaceAllPlayerStats;

	[Token(Token = "0x4012C82")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_NeedShowExtraResultBG;

	[Token(Token = "0x4012C83")]
	[FieldOffset(Offset = "0xB8")]
	private ulong m_LastMatchRecordUserID;

	[Token(Token = "0x4012C84")]
	[FieldOffset(Offset = "0xC0")]
	private string m_LastMatchRecordUserName;

	[Token(Token = "0x4012C85")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_RecordedPlayer;

	[Token(Token = "0x4012C86")]
	[FieldOffset(Offset = "0xC5")]
	private bool m_HasLeaveGame;

	[Token(Token = "0x4012C87")]
	[FieldOffset(Offset = "0xC8")]
	private List<ExpGuideDesc> m_ExpGuideDesc;

	[Token(Token = "0x4012C88")]
	[FieldOffset(Offset = "0xCC")]
	private List<ThumbUpTutorialDesc> m_ThumbUpTutorialDesc;

	[Token(Token = "0x4012C89")]
	[FieldOffset(Offset = "0xD0")]
	public bool IsForceTutorialGameFinished;

	[Token(Token = "0x4012C8A")]
	[FieldOffset(Offset = "0xD4")]
	private List<MatchResultRewardInfo> m_MatchResultRewardList;

	[Token(Token = "0x4012C8B")]
	[FieldOffset(Offset = "0xD8")]
	private List<MatchPregameInfo> m_LoadingPlayerInfo;

	[Token(Token = "0x4012C8C")]
	[FieldOffset(Offset = "0xDC")]
	private int m_LocalPlayerKillCount;

	[Token(Token = "0x4012C8D")]
	[FieldOffset(Offset = "0xE0")]
	private int m_LocalPlayerDeathCount;

	[Token(Token = "0x4012C8E")]
	[FieldOffset(Offset = "0xE4")]
	public int LocalPlayerPendingReviveEndTimeMs;

	[Token(Token = "0x4012C8F")]
	[FieldOffset(Offset = "0xE8")]
	private int m_RemainingPlayerCount_max;

	[Token(Token = "0x4012C90")]
	[FieldOffset(Offset = "0xEC")]
	private int m_RemainingPlayerCount;

	[Token(Token = "0x4012C91")]
	[FieldOffset(Offset = "0xF0")]
	private PlayerDeadInfo m_PlayerDeadInfoData;

	[Token(Token = "0x4012C92")]
	[FieldOffset(Offset = "0xF4")]
	private PlayerDeadInfo m_LocalPlayerDeadInfoData;

	[Token(Token = "0x4012C93")]
	[FieldOffset(Offset = "0xF8")]
	private MatchIncome m_LastMatchIncome;

	[Token(Token = "0x4012C94")]
	[FieldOffset(Offset = "0xFC")]
	private MatchStats m_LastMatchStats;

	[Token(Token = "0x4012C95")]
	[FieldOffset(Offset = "0x100")]
	private bool m_IsLowest;

	[Token(Token = "0x4012C96")]
	[FieldOffset(Offset = "0x101")]
	private bool m_HasPendingMatchRequest;

	[Token(Token = "0x4012C97")]
	[FieldOffset(Offset = "0x104")]
	private float m_TimeLastKnockDown;

	[Token(Token = "0x4012C98")]
	[FieldOffset(Offset = "0x108")]
	private float m_TimeLastKill;

	[Token(Token = "0x4012C99")]
	[FieldOffset(Offset = "0x10C")]
	private float m_TimeNoQuickChat;

	[Token(Token = "0x4012C9A")]
	[FieldOffset(Offset = "0x110")]
	private float m_TimeNoOverlapQuickChat;

	[Token(Token = "0x4012C9B")]
	[FieldOffset(Offset = "0x114")]
	private List<IHAAMHPPLMG> m_EmoteLeaderList;

	[Token(Token = "0x4012C9C")]
	[FieldOffset(Offset = "0x118")]
	private IHAAMHPPLMG m_LocalFollowEmoteLeader;

	[Token(Token = "0x4012C9D")]
	[FieldOffset(Offset = "0x130")]
	private uint m_LeadEmoteSimTick;

	[Token(Token = "0x4012C9E")]
	[FieldOffset(Offset = "0x134")]
	private HashSet<IHAAMHPPLMG> m_LikedPlayerSet;

	[Token(Token = "0x4012C9F")]
	[FieldOffset(Offset = "0x138")]
	private HashSet<ulong> m_ReportedPlayerSet;

	[Token(Token = "0x4012CA0")]
	[FieldOffset(Offset = "0x13C")]
	private HashSet<IHAAMHPPLMG> m_FriendlyInteractionPlayerSet;

	[Token(Token = "0x4012CA1")]
	[FieldOffset(Offset = "0x140")]
	private Dictionary<ulong, HashSet<ulong>> m_Match2ReportedPlayer;

	[Token(Token = "0x4012CA2")]
	[FieldOffset(Offset = "0x144")]
	private Dictionary<ulong, byte> m_CacheUserPlatform;

	[Token(Token = "0x4012CA3")]
	[FieldOffset(Offset = "0x148")]
	private HashSet<IHAAMHPPLMG> m_RequestedPlayerSet;

	[Token(Token = "0x4012CA4")]
	[FieldOffset(Offset = "0x14C")]
	private int m_PVERemainingEnemyCount;

	[Token(Token = "0x4012CA5")]
	[FieldOffset(Offset = "0x150")]
	private int m_PVETurnCount;

	[Token(Token = "0x4012CA6")]
	[FieldOffset(Offset = "0x154")]
	private int m_PVEMaxTurnCount;

	[Token(Token = "0x4012CA7")]
	[FieldOffset(Offset = "0x158")]
	public int m_PVEEmemyKillCount;

	[Token(Token = "0x4012CA8")]
	[FieldOffset(Offset = "0x15C")]
	private int m_CSWinTeamIdCurRound;

	[Token(Token = "0x4012CA9")]
	[FieldOffset(Offset = "0x160")]
	private int m_LocalFactionID;

	[Token(Token = "0x4012CAA")]
	[FieldOffset(Offset = "0x164")]
	private FakeSubmitRes m_ClanMatchResult;

	[Token(Token = "0x4012CAB")]
	[FieldOffset(Offset = "0x168")]
	private int m_ODLocalFactionID;

	[Token(Token = "0x4012CAC")]
	[FieldOffset(Offset = "0x16C")]
	private int m_LocalPlayerArmsLevel;

	[Token(Token = "0x4012CAD")]
	[FieldOffset(Offset = "0x170")]
	private int m_OpponentPlayerArmsLevel;

	[Token(Token = "0x4012CAE")]
	[FieldOffset(Offset = "0x174")]
	private int m_UnlockItemIndex;

	[Token(Token = "0x4012CAF")]
	[FieldOffset(Offset = "0x178")]
	private int m_UnlockLevel;

	[Token(Token = "0x4012CB0")]
	[FieldOffset(Offset = "0x17C")]
	private List<uint> m_AllLevelEquipList;

	[Token(Token = "0x4012CB1")]
	[FieldOffset(Offset = "0x180")]
	private int m_OneLevelSetCount;

	[Token(Token = "0x4012CB2")]
	[FieldOffset(Offset = "0x184")]
	private List<byte> m_PlayerSelectedEquipIndexList;

	[Token(Token = "0x4012CB3")]
	[FieldOffset(Offset = "0x188")]
	private uint m_CommonEquipSetGroupBit;

	[Token(Token = "0x4012CB4")]
	[FieldOffset(Offset = "0x18C")]
	private List<uint> m_CommonEquipSetList;

	[Token(Token = "0x4012CB5")]
	[FieldOffset(Offset = "0x190")]
	private List<byte> m_CSSORankList;

	[Token(Token = "0x4012CB6")]
	[FieldOffset(Offset = "0x194")]
	private List<byte> m_CSSOLastRoundRankList;

	[Token(Token = "0x4012CB7")]
	[FieldOffset(Offset = "0x198")]
	private List<byte> m_CSSOTeamsHPList;

	[Token(Token = "0x4012CB8")]
	[FieldOffset(Offset = "0x19C")]
	private List<byte> m_CSSOLastRoundTeamsHPList;

	[Token(Token = "0x4012CB9")]
	[FieldOffset(Offset = "0x1A0")]
	private Dictionary<byte, int> m_CSSOTeamIndexDict;

	[Token(Token = "0x4012CBA")]
	[FieldOffset(Offset = "0x1A4")]
	private Dictionary<IHAAMHPPLMG, uint> m_CSSOPlayerZoneIndexDict;

	[Token(Token = "0x4012CBB")]
	[FieldOffset(Offset = "0x1A8")]
	private Dictionary<byte, bool> m_CSSOBattleResults;

	[Token(Token = "0x4012CBC")]
	[FieldOffset(Offset = "0x1AC")]
	private Dictionary<IHAAMHPPLMG, AFDILJDJCCJ> m_CSSOPlayerKillInfos;

	[Token(Token = "0x4012CBD")]
	[FieldOffset(Offset = "0x1B0")]
	private Dictionary<uint, bool> m_CSSOZoneIndexSpecial;

	[Token(Token = "0x4012CBE")]
	[FieldOffset(Offset = "0x1B4")]
	private Dictionary<byte, byte> m_CSSOTeamEliminateInfo;

	[Token(Token = "0x4012CBF")]
	[FieldOffset(Offset = "0x1B8")]
	private Dictionary<int, uint> m_CSSOTeamColorDict;

	[Token(Token = "0x4012CC0")]
	[FieldOffset(Offset = "0x1BC")]
	private Dictionary<int, uint> m_CSSOTeamNameColorDict;

	[Token(Token = "0x4012CC1")]
	[FieldOffset(Offset = "0x1C0")]
	private Dictionary<int, string> m_CSSOTeamBBCodeColorDict;

	[Token(Token = "0x4012CC2")]
	[FieldOffset(Offset = "0x1C4")]
	private Dictionary<int, string> m_CSSOTeamNameDict;

	[Token(Token = "0x4012CC3")]
	[FieldOffset(Offset = "0x1C8")]
	private Dictionary<int, string> m_CSSORankStringDict;

	[Token(Token = "0x4012CC4")]
	[FieldOffset(Offset = "0x1CC")]
	private Dictionary<int, float> m_TDShowOverEffectTime;

	[Token(Token = "0x4012CC5")]
	[FieldOffset(Offset = "0x1D0")]
	private bool _003CHideArrowOnMinimap_003Ek__BackingField;

	[Token(Token = "0x4012CC6")]
	[FieldOffset(Offset = "0x1D4")]
	private Dictionary<IHAAMHPPLMG, AskCSPurchaseInfo> m_PlayerAskPurchaseDic;

	[Token(Token = "0x4012CC7")]
	[FieldOffset(Offset = "0x1D8")]
	private Dictionary<byte, NBJFOKDNNBK> m_LWSOTeamInfoDict;

	[Token(Token = "0x4012CC8")]
	[FieldOffset(Offset = "0x1DC")]
	private Dictionary<byte, FJCPGEDJJJK> m_LWSOTeamInfoLastRoundResult;

	[Token(Token = "0x4012CC9")]
	[FieldOffset(Offset = "0x1E0")]
	private Dictionary<uint, MDHFBDKMNFK> m_LWSOPlayerKillInfoDict;

	[Token(Token = "0x4012CCA")]
	[FieldOffset(Offset = "0x1E8")]
	private IHAAMHPPLMG m_DeathMatchKillerKingID;

	[Token(Token = "0x4012CCB")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPPlayerInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012CCC")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<MapModeData, uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012CCD")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012CCE")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<ResultTeamData> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4012CCF")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4012CD0")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x1700159C")]
	public int MatchTime
	{
		[Token(Token = "0x6014B78")]
		[Address(RVA = "0xE5FDA0", Offset = "0xE5FDA0", VA = "0xE5FDA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700159D")]
	public MapConfigData MapConfig
	{
		[Token(Token = "0x6014B79")]
		[Address(RVA = "0xE5FDF8", Offset = "0xE5FDF8", VA = "0xE5FDF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159E")]
	public List<EPPlayerInfo> ElitePassRankingList
	{
		[Token(Token = "0x6014B7A")]
		[Address(RVA = "0xE5FF74", Offset = "0xE5FF74", VA = "0xE5FF74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159F")]
	public bool IsChickenPlayerObserver
	{
		[Token(Token = "0x6014B7B")]
		[Address(RVA = "0xE5FFCC", Offset = "0xE5FFCC", VA = "0xE5FFCC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B7C")]
		[Address(RVA = "0xE5FFD4", Offset = "0xE5FFD4", VA = "0xE5FFD4")]
		set
		{
		}
	}

	[Token(Token = "0x170015A0")]
	public bool IsCustomRoomSettingHideKillInfo
	{
		[Token(Token = "0x6014B7D")]
		[Address(RVA = "0xE5FFDC", Offset = "0xE5FFDC", VA = "0xE5FFDC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B7E")]
		[Address(RVA = "0xE5FFE4", Offset = "0xE5FFE4", VA = "0xE5FFE4")]
		set
		{
		}
	}

	[Token(Token = "0x170015A1")]
	public bool IsCustomRoomSettingNoSkill
	{
		[Token(Token = "0x6014B7F")]
		[Address(RVA = "0xE5FFEC", Offset = "0xE5FFEC", VA = "0xE5FFEC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B80")]
		[Address(RVA = "0xE5FFF4", Offset = "0xE5FFF4", VA = "0xE5FFF4")]
		set
		{
		}
	}

	[Token(Token = "0x170015A2")]
	public bool IsCustomRoomSettingHideCloth
	{
		[Token(Token = "0x6014B81")]
		[Address(RVA = "0xE5FFFC", Offset = "0xE5FFFC", VA = "0xE5FFFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B82")]
		[Address(RVA = "0xE60004", Offset = "0xE60004", VA = "0xE60004")]
		set
		{
		}
	}

	[Token(Token = "0x170015A3")]
	public bool IsCustomRoomSettingUnlimitedAmmo
	{
		[Token(Token = "0x6014B83")]
		[Address(RVA = "0xE6000C", Offset = "0xE6000C", VA = "0xE6000C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B84")]
		[Address(RVA = "0xE60014", Offset = "0xE60014", VA = "0xE60014")]
		set
		{
		}
	}

	[Token(Token = "0x170015A4")]
	public bool MapUIShowDeadBoxEnable
	{
		[Token(Token = "0x6014B85")]
		[Address(RVA = "0xE6001C", Offset = "0xE6001C", VA = "0xE6001C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B86")]
		[Address(RVA = "0xE60024", Offset = "0xE60024", VA = "0xE60024")]
		set
		{
		}
	}

	[Token(Token = "0x170015A5")]
	public bool IsNoPowerGun
	{
		[Token(Token = "0x6014B87")]
		[Address(RVA = "0xE6002C", Offset = "0xE6002C", VA = "0xE6002C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B88")]
		[Address(RVA = "0xE60034", Offset = "0xE60034", VA = "0xE60034")]
		set
		{
		}
	}

	[Token(Token = "0x170015A6")]
	public bool IsCustomRoomSettingNoHud
	{
		[Token(Token = "0x6014B89")]
		[Address(RVA = "0xE6003C", Offset = "0xE6003C", VA = "0xE6003C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B8A")]
		[Address(RVA = "0xE60044", Offset = "0xE60044", VA = "0xE60044")]
		set
		{
		}
	}

	[Token(Token = "0x170015A7")]
	public bool IsCustomRoomSettingFriendDmg
	{
		[Token(Token = "0x6014B8B")]
		[Address(RVA = "0xE6004C", Offset = "0xE6004C", VA = "0xE6004C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B8C")]
		[Address(RVA = "0xE60054", Offset = "0xE60054", VA = "0xE60054")]
		set
		{
		}
	}

	[Token(Token = "0x170015A8")]
	public bool IsCustomRoomSettingInGameChatOpen
	{
		[Token(Token = "0x6014B8D")]
		[Address(RVA = "0xE6005C", Offset = "0xE6005C", VA = "0xE6005C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B8E")]
		[Address(RVA = "0xE60064", Offset = "0xE60064", VA = "0xE60064")]
		set
		{
		}
	}

	[Token(Token = "0x170015A9")]
	public bool IsCustomRoomSettingNoAuxAim
	{
		[Token(Token = "0x6014B8F")]
		[Address(RVA = "0xE6006C", Offset = "0xE6006C", VA = "0xE6006C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B90")]
		[Address(RVA = "0xE60074", Offset = "0xE60074", VA = "0xE60074")]
		set
		{
		}
	}

	[Token(Token = "0x170015AA")]
	public bool IsMobileReplayEnabled
	{
		[Token(Token = "0x6014B91")]
		[Address(RVA = "0xE6007C", Offset = "0xE6007C", VA = "0xE6007C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B92")]
		[Address(RVA = "0xE60084", Offset = "0xE60084", VA = "0xE60084")]
		set
		{
		}
	}

	[Token(Token = "0x170015AB")]
	public string WorkshopShareCode
	{
		[Token(Token = "0x6014B93")]
		[Address(RVA = "0xE6008C", Offset = "0xE6008C", VA = "0xE6008C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014B94")]
		[Address(RVA = "0xE60094", Offset = "0xE60094", VA = "0xE60094")]
		set
		{
		}
	}

	[Token(Token = "0x170015AC")]
	public string WorkshopMapName
	{
		[Token(Token = "0x6014B95")]
		[Address(RVA = "0xE6009C", Offset = "0xE6009C", VA = "0xE6009C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014B96")]
		[Address(RVA = "0xE600A4", Offset = "0xE600A4", VA = "0xE600A4")]
		set
		{
		}
	}

	[Token(Token = "0x170015AD")]
	public bool ShowingHallOverMask
	{
		[Token(Token = "0x6014B97")]
		[Address(RVA = "0xE600AC", Offset = "0xE600AC", VA = "0xE600AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B98")]
		[Address(RVA = "0xE600B4", Offset = "0xE600B4", VA = "0xE600B4")]
		set
		{
		}
	}

	[Token(Token = "0x170015AE")]
	public bool UserControlDirty
	{
		[Token(Token = "0x6014B99")]
		[Address(RVA = "0xE600BC", Offset = "0xE600BC", VA = "0xE600BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B9A")]
		[Address(RVA = "0xE600C4", Offset = "0xE600C4", VA = "0xE600C4")]
		set
		{
		}
	}

	[Token(Token = "0x170015AF")]
	public bool EnableEPRecoveryOverwrite
	{
		[Token(Token = "0x6014B9B")]
		[Address(RVA = "0xE600CC", Offset = "0xE600CC", VA = "0xE600CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014B9C")]
		[Address(RVA = "0xE600D4", Offset = "0xE600D4", VA = "0xE600D4")]
		set
		{
		}
	}

	[Token(Token = "0x170015B0")]
	public ulong MVPPlayerUID
	{
		[Token(Token = "0x6014B9D")]
		[Address(RVA = "0xE600DC", Offset = "0xE600DC", VA = "0xE600DC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014B9E")]
		[Address(RVA = "0xE600E4", Offset = "0xE600E4", VA = "0xE600E4")]
		set
		{
		}
	}

	[Token(Token = "0x170015B1")]
	public bool HideClientDamageShow
	{
		[Token(Token = "0x6014B9F")]
		[Address(RVA = "0xE600F4", Offset = "0xE600F4", VA = "0xE600F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014BA0")]
		[Address(RVA = "0xE600FC", Offset = "0xE600FC", VA = "0xE600FC")]
		set
		{
		}
	}

	[Token(Token = "0x170015B2")]
	public List<TeammateStats> ArmsRaceAllPlayerStats
	{
		[Token(Token = "0x6014BA1")]
		[Address(RVA = "0xE60104", Offset = "0xE60104", VA = "0xE60104")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B3")]
	public List<IHAAMHPPLMG> MLocalTeamPlayerIDs
	{
		[Token(Token = "0x6014BA2")]
		[Address(RVA = "0xE6015C", Offset = "0xE6015C", VA = "0xE6015C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B4")]
	public List<IHAAMHPPLMG> MOppoTeamPlayerIDs
	{
		[Token(Token = "0x6014BA4")]
		[Address(RVA = "0xE602EC", Offset = "0xE602EC", VA = "0xE602EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015B5")]
	public bool NeedShowExtraResultBG
	{
		[Token(Token = "0x6014BA5")]
		[Address(RVA = "0xE60344", Offset = "0xE60344", VA = "0xE60344")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014BA6")]
		[Address(RVA = "0xE6039C", Offset = "0xE6039C", VA = "0xE6039C")]
		set
		{
		}
	}

	[Token(Token = "0x170015B6")]
	public ulong LastMatchRecordUserID
	{
		[Token(Token = "0x6014BA7")]
		[Address(RVA = "0xE603FC", Offset = "0xE603FC", VA = "0xE603FC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014BA8")]
		[Address(RVA = "0xE60454", Offset = "0xE60454", VA = "0xE60454")]
		set
		{
		}
	}

	[Token(Token = "0x170015B7")]
	public string LastMatchRecordUserName
	{
		[Token(Token = "0x6014BA9")]
		[Address(RVA = "0xE604D0", Offset = "0xE604D0", VA = "0xE604D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014BAA")]
		[Address(RVA = "0xE60528", Offset = "0xE60528", VA = "0xE60528")]
		set
		{
		}
	}

	[Token(Token = "0x170015B8")]
	public bool HasLeaveGame
	{
		[Token(Token = "0x6014BAB")]
		[Address(RVA = "0xE60588", Offset = "0xE60588", VA = "0xE60588")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170015B9")]
	public List<MatchResultRewardInfo> MatchResultRewardList
	{
		[Token(Token = "0x6014BAF")]
		[Address(RVA = "0xE60FC4", Offset = "0xE60FC4", VA = "0xE60FC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015BA")]
	public int LocalPlayerKillCount
	{
		[Token(Token = "0x6014BB7")]
		[Address(RVA = "0xE640FC", Offset = "0xE640FC", VA = "0xE640FC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015BB")]
	public int LocalPlayerDeathCount
	{
		[Token(Token = "0x6014BB8")]
		[Address(RVA = "0xE644A0", Offset = "0xE644A0", VA = "0xE644A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015BC")]
	public int LocalPlayerAssistCount
	{
		[Token(Token = "0x6014BB9")]
		[Address(RVA = "0xE64844", Offset = "0xE64844", VA = "0xE64844")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015BD")]
	public float LocalPlayerKDA
	{
		[Token(Token = "0x6014BBA")]
		[Address(RVA = "0xE64B44", Offset = "0xE64B44", VA = "0xE64B44")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170015BE")]
	public int RemainingPlayerCountMax
	{
		[Token(Token = "0x6014BBB")]
		[Address(RVA = "0xE64C58", Offset = "0xE64C58", VA = "0xE64C58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015BF")]
	public int RemainingPlayerCount
	{
		[Token(Token = "0x6014BBC")]
		[Address(RVA = "0xE64CB0", Offset = "0xE64CB0", VA = "0xE64CB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015C0")]
	public PlayerDeadInfo PlayerDeadInfoData
	{
		[Token(Token = "0x6014BBD")]
		[Address(RVA = "0xE64D08", Offset = "0xE64D08", VA = "0xE64D08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C1")]
	public PlayerDeadInfo LocalPlayerDeadInfoData
	{
		[Token(Token = "0x6014BBE")]
		[Address(RVA = "0xE64D60", Offset = "0xE64D60", VA = "0xE64D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C2")]
	public MatchIncome LastMatchIncome
	{
		[Token(Token = "0x6014BBF")]
		[Address(RVA = "0xE64DB8", Offset = "0xE64DB8", VA = "0xE64DB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C3")]
	public MatchStats LastMatchStats
	{
		[Token(Token = "0x6014BC0")]
		[Address(RVA = "0xE64E10", Offset = "0xE64E10", VA = "0xE64E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C4")]
	public bool HasPendingMatchRequest
	{
		[Token(Token = "0x6014BC1")]
		[Address(RVA = "0xE64E68", Offset = "0xE64E68", VA = "0xE64E68")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014BC2")]
		[Address(RVA = "0xE64EC0", Offset = "0xE64EC0", VA = "0xE64EC0")]
		set
		{
		}
	}

	[Token(Token = "0x170015C5")]
	public HashSet<IHAAMHPPLMG> LikedPlayerSet
	{
		[Token(Token = "0x6014C0C")]
		[Address(RVA = "0xE78990", Offset = "0xE78990", VA = "0xE78990")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C6")]
	public HashSet<ulong> ReportedPlayerSet
	{
		[Token(Token = "0x6014C0D")]
		[Address(RVA = "0xE789E8", Offset = "0xE789E8", VA = "0xE789E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C7")]
	public HashSet<IHAAMHPPLMG> FriendlyInteractionPlayerSet
	{
		[Token(Token = "0x6014C0E")]
		[Address(RVA = "0xE78A40", Offset = "0xE78A40", VA = "0xE78A40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C8")]
	public Dictionary<ulong, HashSet<ulong>> Match2ReportedPlayer
	{
		[Token(Token = "0x6014C0F")]
		[Address(RVA = "0xE764B4", Offset = "0xE764B4", VA = "0xE764B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015C9")]
	public HashSet<IHAAMHPPLMG> RequestedPlayerSet
	{
		[Token(Token = "0x6014C15")]
		[Address(RVA = "0xE79444", Offset = "0xE79444", VA = "0xE79444")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015CA")]
	public int PVERemainingEnemyCount
	{
		[Token(Token = "0x6014C16")]
		[Address(RVA = "0xE7949C", Offset = "0xE7949C", VA = "0xE7949C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015CB")]
	public int PVETurnCount
	{
		[Token(Token = "0x6014C17")]
		[Address(RVA = "0xE794F4", Offset = "0xE794F4", VA = "0xE794F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015CC")]
	public int PVEMaxTurnCount
	{
		[Token(Token = "0x6014C18")]
		[Address(RVA = "0xE7954C", Offset = "0xE7954C", VA = "0xE7954C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015CD")]
	public int PVEEmemyKillCount
	{
		[Token(Token = "0x6014C19")]
		[Address(RVA = "0xE795A4", Offset = "0xE795A4", VA = "0xE795A4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015CE")]
	public int MCSLocalTeamId
	{
		[Token(Token = "0x6014C1E")]
		[Address(RVA = "0xE79B5C", Offset = "0xE79B5C", VA = "0xE79B5C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015CF")]
	public int CSTeamIdEyesOn
	{
		[Token(Token = "0x6014C1F")]
		[Address(RVA = "0xE79BB4", Offset = "0xE79BB4", VA = "0xE79BB4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D0")]
	public int CSWinTeamIdCurRound
	{
		[Token(Token = "0x6014C22")]
		[Address(RVA = "0xE79DA4", Offset = "0xE79DA4", VA = "0xE79DA4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D1")]
	public int LocalODFaction
	{
		[Token(Token = "0x6014C25")]
		[Address(RVA = "0xE79EBC", Offset = "0xE79EBC", VA = "0xE79EBC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D2")]
	public int LocalFactionID
	{
		[Token(Token = "0x6014C29")]
		[Address(RVA = "0xE7A108", Offset = "0xE7A108", VA = "0xE7A108")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D3")]
	public bool IsLocalFactionInLeft
	{
		[Token(Token = "0x6014C2A")]
		[Address(RVA = "0xE7A160", Offset = "0xE7A160", VA = "0xE7A160")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170015D4")]
	public int LocalPlayerArmsLevel
	{
		[Token(Token = "0x6014C2C")]
		[Address(RVA = "0xE7A37C", Offset = "0xE7A37C", VA = "0xE7A37C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D5")]
	public int OpponentPlayerArmsLevel
	{
		[Token(Token = "0x6014C2E")]
		[Address(RVA = "0xE7A434", Offset = "0xE7A434", VA = "0xE7A434")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D6")]
	public int UnlockItemIndex
	{
		[Token(Token = "0x6014C30")]
		[Address(RVA = "0xE7A4EC", Offset = "0xE7A4EC", VA = "0xE7A4EC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D7")]
	public int UnlockLevel
	{
		[Token(Token = "0x6014C31")]
		[Address(RVA = "0xE7A544", Offset = "0xE7A544", VA = "0xE7A544")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015D8")]
	public List<uint> AllLevelEquipList
	{
		[Token(Token = "0x6014C33")]
		[Address(RVA = "0xE7A68C", Offset = "0xE7A68C", VA = "0xE7A68C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015D9")]
	public int OneLevelSetCount
	{
		[Token(Token = "0x6014C34")]
		[Address(RVA = "0xE7A6E4", Offset = "0xE7A6E4", VA = "0xE7A6E4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015DA")]
	public List<byte> PlayerSelectedEquipIndexList
	{
		[Token(Token = "0x6014C36")]
		[Address(RVA = "0xE7A7BC", Offset = "0xE7A7BC", VA = "0xE7A7BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015DB")]
	public List<uint> CommonEquipSetGroup
	{
		[Token(Token = "0x6014C38")]
		[Address(RVA = "0xE7A874", Offset = "0xE7A874", VA = "0xE7A874")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015DC")]
	public bool HideArrowOnMinimap
	{
		[Token(Token = "0x6014C62")]
		[Address(RVA = "0xE7DE58", Offset = "0xE7DE58", VA = "0xE7DE58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014C61")]
		[Address(RVA = "0xE7DE50", Offset = "0xE7DE50", VA = "0xE7DE50")]
		set
		{
		}
	}

	[Token(Token = "0x170015DD")]
	public IHAAMHPPLMG DeathMatchKillerKing
	{
		[Token(Token = "0x6014C7B")]
		[Address(RVA = "0xE815F4", Offset = "0xE815F4", VA = "0xE815F4")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6014C7A")]
		[Address(RVA = "0xE6348C", Offset = "0xE6348C", VA = "0xE6348C")]
		set
		{
		}
	}

	[Token(Token = "0x6014B76")]
	[Address(RVA = "0xE5E6F8", Offset = "0xE5E6F8", VA = "0xE5E6F8")]
	public UIModelMatch()
	{
	}

	[Token(Token = "0x6014B77")]
	[Address(RVA = "0xE5FD48", Offset = "0xE5FD48", VA = "0xE5FD48", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014BA3")]
	[Address(RVA = "0xE601B4", Offset = "0xE601B4", VA = "0xE601B4")]
	public bool IsSubTeammate(ulong otherId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014BAC")]
	[Address(RVA = "0xE605E0", Offset = "0xE605E0", VA = "0xE605E0")]
	public int GetTutorialFakeThumbUpNumByRank(uint rank)
	{
		return default(int);
	}

	[Token(Token = "0x6014BAD")]
	[Address(RVA = "0xE60B30", Offset = "0xE60B30", VA = "0xE60B30")]
	public ExpGuideDesc GetExpGuideDesc(proto.EFresh.GuideMode mode)
	{
		return null;
	}

	[Token(Token = "0x6014BAE")]
	[Address(RVA = "0xE60C78", Offset = "0xE60C78", VA = "0xE60C78")]
	public void ClaimForceTutorialGameReward()
	{
	}

	[Token(Token = "0x6014BB0")]
	[Address(RVA = "0xE6101C", Offset = "0xE6101C", VA = "0xE6101C")]
	public void SetLoadingPlayerInfo(List<MatchPregameInfo> list, DGNDKMLMLPM matchMode)
	{
	}

	[Token(Token = "0x6014BB1")]
	[Address(RVA = "0xE61458", Offset = "0xE61458", VA = "0xE61458")]
	public List<MatchPregameInfo> GetListLoadingPlayerInfo()
	{
		return null;
	}

	[Token(Token = "0x6014BB2")]
	[Address(RVA = "0xE614B0", Offset = "0xE614B0", VA = "0xE614B0")]
	public void updateLeaveGame(bool flag)
	{
	}

	[Token(Token = "0x6014BB3")]
	[Address(RVA = "0xE61510", Offset = "0xE61510", VA = "0xE61510")]
	public void UpdateMatchTime(int time)
	{
	}

	[Token(Token = "0x6014BB4")]
	[Address(RVA = "0xE61604", Offset = "0xE61604", VA = "0xE61604")]
	public void StartMatch()
	{
	}

	[Token(Token = "0x6014BB5")]
	[Address(RVA = "0xE63BBC", Offset = "0xE63BBC", VA = "0xE63BBC")]
	public void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6014BB6")]
	[Address(RVA = "0xE6403C", Offset = "0xE6403C", VA = "0xE6403C")]
	public void ClearEPRankingList()
	{
	}

	[Token(Token = "0x6014BC3")]
	[Address(RVA = "0xE65188", Offset = "0xE65188", VA = "0xE65188")]
	public void AddKnockDownInfo(string playerName, int weaponDataID, uint skinID, IHAAMHPPLMG beKilledId, IHAAMHPPLMG killerId, bool isHeadShot = false, uint knockDownPlayerRole = 0u)
	{
	}

	[Token(Token = "0x6014BC4")]
	[Address(RVA = "0xE65EB0", Offset = "0xE65EB0", VA = "0xE65EB0")]
	public void OnKnockOtherDown(ESPKillOperateNoti operate = ESPKillOperateNoti.NONE)
	{
	}

	[Token(Token = "0x6014BC5")]
	[Address(RVA = "0xE66010", Offset = "0xE66010", VA = "0xE66010")]
	public void AddInstantKilledInfo(string playerName, IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x6014BC6")]
	[Address(RVA = "0xE664B0", Offset = "0xE664B0", VA = "0xE664B0")]
	public void SyncInstantKilledInfo(List<uint> playerIDs, List<string> playerNames)
	{
	}

	[Token(Token = "0x6014BC7")]
	[Address(RVA = "0xE66A0C", Offset = "0xE66A0C", VA = "0xE66A0C")]
	public void AddBattleInfo(string battleInfo)
	{
	}

	[Token(Token = "0x6014BC8")]
	[Address(RVA = "0xE66B40", Offset = "0xE66B40", VA = "0xE66B40")]
	public void AddRedEnvelopeInfo(string battleInfo)
	{
	}

	[Token(Token = "0x6014BC9")]
	[Address(RVA = "0xE66C74", Offset = "0xE66C74", VA = "0xE66C74")]
	public void UpdateKillInfo(IHAAMHPPLMG killerID, int killCount)
	{
	}

	[Token(Token = "0x6014BCA")]
	[Address(RVA = "0xE671C8", Offset = "0xE671C8", VA = "0xE671C8")]
	public void UpdateLikeCountInfo(IHAAMHPPLMG playerID, uint likeCount)
	{
	}

	[Token(Token = "0x6014BCB")]
	[Address(RVA = "0xE67428", Offset = "0xE67428", VA = "0xE67428")]
	public void UpdateDeathInfo(IHAAMHPPLMG playerId, int deathCount)
	{
	}

	[Token(Token = "0x6014BCC")]
	[Address(RVA = "0xE6797C", Offset = "0xE6797C", VA = "0xE6797C")]
	public void UpdateBombInfo(ACEJDLLPENP infoType, object[] param)
	{
	}

	[Token(Token = "0x6014BCD")]
	[Address(RVA = "0xE680E0", Offset = "0xE680E0", VA = "0xE680E0")]
	public void OnLandmineExplode(Player landmineOwner)
	{
	}

	[Token(Token = "0x6014BCE")]
	[Address(RVA = "0xE683D8", Offset = "0xE683D8", VA = "0xE683D8")]
	private void DispatchKillEvent(int weaponDataID)
	{
	}

	[Token(Token = "0x6014BCF")]
	[Address(RVA = "0xE6886C", Offset = "0xE6886C", VA = "0xE6886C")]
	private void CheckShowTutorial()
	{
	}

	[Token(Token = "0x6014BD0")]
	[Address(RVA = "0xE68B1C", Offset = "0xE68B1C", VA = "0xE68B1C")]
	public void OnRevived(IHAAMHPPLMG killId, IHAAMHPPLMG beKillId)
	{
	}

	[Token(Token = "0x6014BD1")]
	[Address(RVA = "0xE68D94", Offset = "0xE68D94", VA = "0xE68D94")]
	public void OnKill(IHAAMHPPLMG killerID, IHAAMHPPLMG beKilledID, int weaponDataID, uint hitbodyPart, uint skinId, bool isPendingRevive = false, int killStacks = 0, byte flags = 0, int killerScore = 0, int killerTeamScore = 0, int killerHypeLvl = 0, uint assis = 0u, uint hitRate = 0u, uint headShotRate = 0u, uint bekilledKillStack = 0u)
	{
	}

	[Token(Token = "0x6014BD2")]
	[Address(RVA = "0xE6D14C", Offset = "0xE6D14C", VA = "0xE6D14C")]
	public ESPKillOperateNoti GetOperateWhenKill(uint weaponid, IHAAMHPPLMG bekilled)
	{
		return default(ESPKillOperateNoti);
	}

	[Token(Token = "0x6014BD3")]
	[Address(RVA = "0xE6D788", Offset = "0xE6D788", VA = "0xE6D788")]
	public bool NeedReplaceNameWithEllipsis(Player player)
	{
		return default(bool);
	}

	[Token(Token = "0x6014BD4")]
	[Address(RVA = "0xE6C910", Offset = "0xE6C910", VA = "0xE6C910")]
	public void OnKillByZombie(IHAAMHPPLMG killerID, IHAAMHPPLMG beKilledID, int weaponDataID, uint hitbodyPart, uint skinId)
	{
	}

	[Token(Token = "0x6014BD5")]
	[Address(RVA = "0xE65AF4", Offset = "0xE65AF4", VA = "0xE65AF4")]
	public string GetWeaponName(int weaponDataID)
	{
		return null;
	}

	[Token(Token = "0x6014BD6")]
	[Address(RVA = "0xE6D908", Offset = "0xE6D908", VA = "0xE6D908")]
	public void OnPlayerQuit(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x6014BD7")]
	[Address(RVA = "0xE6D374", Offset = "0xE6D374", VA = "0xE6D374")]
	public void OnAlivePlayerCountChanged(int remainingPlayers)
	{
	}

	[Token(Token = "0x6014BD8")]
	[Address(RVA = "0xE6DFA8", Offset = "0xE6DFA8", VA = "0xE6DFA8")]
	public void OnAddPlayer(IHAAMHPPLMG playerID, Player player)
	{
	}

	[Token(Token = "0x6014BD9")]
	[Address(RVA = "0xE6F850", Offset = "0xE6F850", VA = "0xE6F850")]
	private void SaveTeammateInfo(PlayerData playerData)
	{
	}

	[Token(Token = "0x6014BDA")]
	[Address(RVA = "0xE6F474", Offset = "0xE6F474", VA = "0xE6F474")]
	private PlayerData CreatePlayerData(Player player)
	{
		return null;
	}

	[Token(Token = "0x6014BDB")]
	[Address(RVA = "0xE6FF88", Offset = "0xE6FF88", VA = "0xE6FF88")]
	private PlayerData GetTeammateData(IHAAMHPPLMG pid)
	{
		return null;
	}

	[Token(Token = "0x6014BDC")]
	[Address(RVA = "0xE70124", Offset = "0xE70124", VA = "0xE70124")]
	public void OnTeammateHeadScaleChange(IHAAMHPPLMG pid, float scale)
	{
	}

	[Token(Token = "0x6014BDD")]
	[Address(RVA = "0xE702A4", Offset = "0xE702A4", VA = "0xE702A4")]
	public void OnTeammateEpicClothesUpdate(IHAAMHPPLMG pid, uint oldClohtes, uint newClothes)
	{
	}

	[Token(Token = "0x6014BDE")]
	[Address(RVA = "0xE706BC", Offset = "0xE706BC", VA = "0xE706BC")]
	public void OnTeammateHeadAvatarChange(IHAAMHPPLMG pid, uint avatardataID)
	{
	}

	[Token(Token = "0x6014BDF")]
	[Address(RVA = "0xE70780", Offset = "0xE70780", VA = "0xE70780")]
	private void RefreshEPRankingSurroundEffect()
	{
	}

	[Token(Token = "0x6014BE0")]
	[Address(RVA = "0xE70C88", Offset = "0xE70C88", VA = "0xE70C88")]
	public void UpdateEPRankingList(ulong userID, IHAAMHPPLMG pID, bool isAI, object syncInfo)
	{
	}

	[Token(Token = "0x6014BE1")]
	[Address(RVA = "0xE6FB54", Offset = "0xE6FB54", VA = "0xE6FB54")]
	public void OnSwitchObserver(IHAAMHPPLMG trackingTargetID)
	{
	}

	[Token(Token = "0x6014BE2")]
	[Address(RVA = "0xE71828", Offset = "0xE71828", VA = "0xE71828")]
	public void OnDelPlayer(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x6014BE3")]
	[Address(RVA = "0xE71B6C", Offset = "0xE71B6C", VA = "0xE71B6C")]
	public void OnRemoveTeam(byte teamID)
	{
	}

	[Token(Token = "0x6014BE4")]
	[Address(RVA = "0xE71BC8", Offset = "0xE71BC8", VA = "0xE71BC8")]
	public void SniperOn(bool v)
	{
	}

	[Token(Token = "0x6014BE5")]
	[Address(RVA = "0xE71D28", Offset = "0xE71D28", VA = "0xE71D28")]
	public void RecordPlayerForDriftBottle()
	{
	}

	[Token(Token = "0x6014BE6")]
	[Address(RVA = "0xE72590", Offset = "0xE72590", VA = "0xE72590")]
	public void RequestNewbieGuideDescRes(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014BE7")]
	[Address(RVA = "0xE727C4", Offset = "0xE727C4", VA = "0xE727C4")]
	public void RequestStartMatchMaking(uint map_id, JOKABEAPNPP game_mode = JOKABEAPNPP.EGAMEMODE_BattleRoyale, DGNDKMLMLPM match_mode = DGNDKMLMLPM.EMATCHMODE_CASUAL, uint map_difficulty = 0u, bool isRandomMap = false)
	{
	}

	[Token(Token = "0x6014BE8")]
	[Address(RVA = "0xE72908", Offset = "0xE72908", VA = "0xE72908")]
	public void RequestStartMatchMaking(List<uint> map_ids, JOKABEAPNPP game_mode = JOKABEAPNPP.EGAMEMODE_BattleRoyale, DGNDKMLMLPM match_mode = DGNDKMLMLPM.EMATCHMODE_CASUAL, uint map_difficulty = 0u, bool isRandomMap = false)
	{
	}

	[Token(Token = "0x6014BE9")]
	[Address(RVA = "0xE73464", Offset = "0xE73464", VA = "0xE73464")]
	private bool RequestStartMatchMakingInternal(List<uint> map_ids, JOKABEAPNPP game_mode = JOKABEAPNPP.EGAMEMODE_BattleRoyale, DGNDKMLMLPM match_mode = DGNDKMLMLPM.EMATCHMODE_CASUAL, uint map_difficulty = 0u, bool isRandomMap = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6014BEA")]
	[Address(RVA = "0xE72C20", Offset = "0xE72C20", VA = "0xE72C20")]
	public void CheckIfNeedRequestWorkshopInfo(uint match_mode, uint game_mode, Action callBack)
	{
	}

	[Token(Token = "0x6014BEB")]
	[Address(RVA = "0xE74C04", Offset = "0xE74C04", VA = "0xE74C04")]
	public void RequestCancelMatchMaking()
	{
	}

	[Token(Token = "0x6014BEC")]
	[Address(RVA = "0xE74D18", Offset = "0xE74D18", VA = "0xE74D18")]
	public void RequestDropMatch()
	{
	}

	[Token(Token = "0x6014BED")]
	[Address(RVA = "0xE74F78", Offset = "0xE74F78", VA = "0xE74F78")]
	public void RequestClearReconnectInfo()
	{
	}

	[Token(Token = "0x6014BEE")]
	[Address(RVA = "0xE7508C", Offset = "0xE7508C", VA = "0xE7508C")]
	public void PendingMatchResult(MatchStatsRes data)
	{
	}

	[Token(Token = "0x6014BEF")]
	[Address(RVA = "0xE757C0", Offset = "0xE757C0", VA = "0xE757C0")]
	public void UpdateLadderMatchPlayCnt(uint matchMode, uint cnt = 1u)
	{
	}

	[Token(Token = "0x6014BF0")]
	[Address(RVA = "0xE75A4C", Offset = "0xE75A4C", VA = "0xE75A4C")]
	public void RequestMatchResultViaHTTP()
	{
	}

	[Token(Token = "0x6014BF1")]
	[Address(RVA = "0xE75D40", Offset = "0xE75D40", VA = "0xE75D40")]
	public bool HasPendingReviveTeammates()
	{
		return default(bool);
	}

	[Token(Token = "0x6014BF2")]
	[Address(RVA = "0xE750F8", Offset = "0xE750F8", VA = "0xE750F8")]
	public bool UnpackMatchResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6014BF3")]
	[Address(RVA = "0xE75FB4", Offset = "0xE75FB4", VA = "0xE75FB4")]
	public bool HasPendingMatchResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6014BF4")]
	[Address(RVA = "0xE76018", Offset = "0xE76018", VA = "0xE76018")]
	public void SetArmsRaceAllPlayerStats(MatchStats stats)
	{
	}

	[Token(Token = "0x6014BF5")]
	[Address(RVA = "0xE761C8", Offset = "0xE761C8", VA = "0xE761C8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014BF6")]
	[Address(RVA = "0xE76320", Offset = "0xE76320", VA = "0xE76320")]
	public bool CheckReportByMatchID(ulong matchID, ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014BF7")]
	[Address(RVA = "0xE7650C", Offset = "0xE7650C", VA = "0xE7650C")]
	public void AddReportRecordByMatchID(ulong matchID, ulong userID)
	{
	}

	[Token(Token = "0x6014BF8")]
	[Address(RVA = "0xE767DC", Offset = "0xE767DC", VA = "0xE767DC")]
	public bool CanUseQuickChat()
	{
		return default(bool);
	}

	[Token(Token = "0x6014BF9")]
	[Address(RVA = "0xE76A48", Offset = "0xE76A48", VA = "0xE76A48")]
	public Player GetNearestEmoteLeader(uint emoteID, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6014BFA")]
	[Address(RVA = "0xE76E74", Offset = "0xE76E74", VA = "0xE76E74")]
	public bool IsEmoteLeader(IHAAMHPPLMG pid)
	{
		return default(bool);
	}

	[Token(Token = "0x6014BFB")]
	[Address(RVA = "0xE76F8C", Offset = "0xE76F8C", VA = "0xE76F8C")]
	public void SetEmoteLeader(IHAAMHPPLMG pid)
	{
	}

	[Token(Token = "0x6014BFC")]
	[Address(RVA = "0xE77290", Offset = "0xE77290", VA = "0xE77290")]
	public void RemoveEmoteLeader(IHAAMHPPLMG pid)
	{
	}

	[Token(Token = "0x6014BFD")]
	[Address(RVA = "0xE775A4", Offset = "0xE775A4", VA = "0xE775A4")]
	public void FollowEmoteLeader(IHAAMHPPLMG leaderPid)
	{
	}

	[Token(Token = "0x6014BFE")]
	[Address(RVA = "0xE771A4", Offset = "0xE771A4", VA = "0xE771A4")]
	public void UnFollowEmoteLeader()
	{
	}

	[Token(Token = "0x6014BFF")]
	[Address(RVA = "0xE77738", Offset = "0xE77738", VA = "0xE77738")]
	public IHAAMHPPLMG GetFollowEmotePlayerID()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x6014C00")]
	[Address(RVA = "0xE777AC", Offset = "0xE777AC", VA = "0xE777AC")]
	public void UpdateLeadEmoteSimTick(uint simTick)
	{
	}

	[Token(Token = "0x6014C01")]
	[Address(RVA = "0xE7780C", Offset = "0xE7780C", VA = "0xE7780C")]
	public uint GetLeadEmoteSimTick()
	{
		return default(uint);
	}

	[Token(Token = "0x6014C02")]
	[Address(RVA = "0xE77864", Offset = "0xE77864", VA = "0xE77864")]
	public void UpdateFollowerEmote(IHAAMHPPLMG leaderPid, uint emoteID)
	{
	}

	[Token(Token = "0x6014C03")]
	[Address(RVA = "0xE77AFC", Offset = "0xE77AFC", VA = "0xE77AFC")]
	public void GenerateMatchResult(GFPPNNIBNHL msg)
	{
	}

	[Token(Token = "0x6014C04")]
	[Address(RVA = "0xE78138", Offset = "0xE78138", VA = "0xE78138")]
	public List<ResultTeamData> GenerateMatchResult()
	{
		return null;
	}

	[Token(Token = "0x6014C05")]
	[Address(RVA = "0xE78190", Offset = "0xE78190", VA = "0xE78190")]
	public List<PlayerData> GetPlayerDataListByTeamId(byte teamId)
	{
		return null;
	}

	[Token(Token = "0x6014C06")]
	[Address(RVA = "0xE78278", Offset = "0xE78278", VA = "0xE78278")]
	public PlayerData GetTutorialPlayerDataByPlayerID(ulong playerId)
	{
		return null;
	}

	[Token(Token = "0x6014C07")]
	[Address(RVA = "0xE78434", Offset = "0xE78434", VA = "0xE78434")]
	public PlayerData GetPlayerDataByAccountID(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6014C08")]
	[Address(RVA = "0xE6728C", Offset = "0xE6728C", VA = "0xE6728C")]
	public PlayerData GetPlayerDataByPlayerID(IHAAMHPPLMG playerID)
	{
		return null;
	}

	[Token(Token = "0x6014C09")]
	[Address(RVA = "0xE78598", Offset = "0xE78598", VA = "0xE78598")]
	public PlayerData GetPlayerDataByNickName(string nickName)
	{
		return null;
	}

	[Token(Token = "0x6014C0A")]
	[Address(RVA = "0xE78738", Offset = "0xE78738", VA = "0xE78738")]
	public void SetTeamScore(int idx, int score)
	{
	}

	[Token(Token = "0x6014C0B")]
	[Address(RVA = "0xE787C4", Offset = "0xE787C4", VA = "0xE787C4")]
	public void UpdateTeamScore(int score)
	{
	}

	[Token(Token = "0x6014C10")]
	[Address(RVA = "0xE78A98", Offset = "0xE78A98", VA = "0xE78A98")]
	public void CacheUserPlatform(ulong user_id, byte platform)
	{
	}

	[Token(Token = "0x6014C11")]
	[Address(RVA = "0xE78B8C", Offset = "0xE78B8C", VA = "0xE78B8C")]
	public byte GetUserPlatform(ulong user_id)
	{
		return default(byte);
	}

	[Token(Token = "0x6014C12")]
	[Address(RVA = "0xE78CA0", Offset = "0xE78CA0", VA = "0xE78CA0")]
	public List<ulong> GetAllUserPlayerIDs()
	{
		return null;
	}

	[Token(Token = "0x6014C13")]
	[Address(RVA = "0xE78F6C", Offset = "0xE78F6C", VA = "0xE78F6C")]
	public List<ulong> GetSameTeamPlayerIds()
	{
		return null;
	}

	[Token(Token = "0x6014C14")]
	[Address(RVA = "0xE79258", Offset = "0xE79258", VA = "0xE79258")]
	public void RequestLikePlayer(IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x6014C1A")]
	[Address(RVA = "0xE795FC", Offset = "0xE795FC", VA = "0xE795FC")]
	public void UpdatePVERemainingEnemyCount(uint count)
	{
	}

	[Token(Token = "0x6014C1B")]
	[Address(RVA = "0xE796D0", Offset = "0xE796D0", VA = "0xE796D0")]
	public void UpdatePVETurnCount(int count)
	{
	}

	[Token(Token = "0x6014C1C")]
	[Address(RVA = "0xE798AC", Offset = "0xE798AC", VA = "0xE798AC")]
	public void UpdatePVEMaxTurnCount(int count)
	{
	}

	[Token(Token = "0x6014C1D")]
	[Address(RVA = "0xE79A88", Offset = "0xE79A88", VA = "0xE79A88")]
	public void UpdatePVEEmemyKillCount(int count)
	{
	}

	[Token(Token = "0x6014C20")]
	[Address(RVA = "0xE79C0C", Offset = "0xE79C0C", VA = "0xE79C0C")]
	public bool IsCSPlayerOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C21")]
	[Address(RVA = "0xE79D2C", Offset = "0xE79D2C", VA = "0xE79D2C")]
	public bool IsCSTeamOnLeft(int teamId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C23")]
	[Address(RVA = "0xE79DFC", Offset = "0xE79DFC", VA = "0xE79DFC")]
	public void UpdateWinTeamIdCurRound(int teamId)
	{
	}

	[Token(Token = "0x6014C24")]
	[Address(RVA = "0xE79E5C", Offset = "0xE79E5C", VA = "0xE79E5C")]
	public void UpdateLocalFactionID(int factionID)
	{
	}

	[Token(Token = "0x6014C26")]
	[Address(RVA = "0xE79F14", Offset = "0xE79F14", VA = "0xE79F14")]
	public void UpdateLocalODFaction(int factionID)
	{
	}

	[Token(Token = "0x6014C27")]
	[Address(RVA = "0xE7A050", Offset = "0xE7A050", VA = "0xE7A050")]
	public void SetClanMatchResult(FakeSubmitRes tcpClanMatchResult)
	{
	}

	[Token(Token = "0x6014C28")]
	[Address(RVA = "0xE7A0B0", Offset = "0xE7A0B0", VA = "0xE7A0B0")]
	public FakeSubmitRes GetClanMatchResult()
	{
		return null;
	}

	[Token(Token = "0x6014C2B")]
	[Address(RVA = "0xE7A1CC", Offset = "0xE7A1CC", VA = "0xE7A1CC")]
	public bool IsFactionInLeft(int factionID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C2D")]
	[Address(RVA = "0xE7A3D4", Offset = "0xE7A3D4", VA = "0xE7A3D4")]
	public void UpdateLocalPlayerArmsLevel(int level)
	{
	}

	[Token(Token = "0x6014C2F")]
	[Address(RVA = "0xE7A48C", Offset = "0xE7A48C", VA = "0xE7A48C")]
	public void UpdateOpponentPlayerArmsLevel(int level)
	{
	}

	[Token(Token = "0x6014C32")]
	[Address(RVA = "0xE7A59C", Offset = "0xE7A59C", VA = "0xE7A59C")]
	public void UpdateEquipUnlockInfo(int unlockItemIndex, int unlockLevel)
	{
	}

	[Token(Token = "0x6014C35")]
	[Address(RVA = "0xE7A73C", Offset = "0xE7A73C", VA = "0xE7A73C")]
	public void UpdateAllLevelEquipListInfo(List<uint> list, int oneLevelSetCount)
	{
	}

	[Token(Token = "0x6014C37")]
	[Address(RVA = "0xE7A814", Offset = "0xE7A814", VA = "0xE7A814")]
	public void UpdatePlayerSelectedEquipIndexList(List<byte> list)
	{
	}

	[Token(Token = "0x6014C39")]
	[Address(RVA = "0xE7A8CC", Offset = "0xE7A8CC", VA = "0xE7A8CC")]
	public void UpdateEquipGroup(uint groupID)
	{
	}

	[Token(Token = "0x6014C3A")]
	[Address(RVA = "0xE62FB0", Offset = "0xE62FB0", VA = "0xE62FB0")]
	public void ClearCSSOData()
	{
	}

	[Token(Token = "0x6014C3B")]
	[Address(RVA = "0xE7AA68", Offset = "0xE7AA68", VA = "0xE7AA68")]
	public void RefreshCSSOLastRoundRankList(List<byte> list)
	{
	}

	[Token(Token = "0x6014C3C")]
	[Address(RVA = "0xE7AB60", Offset = "0xE7AB60", VA = "0xE7AB60")]
	public void RefreshCSSORankList(List<byte> list)
	{
	}

	[Token(Token = "0x6014C3D")]
	[Address(RVA = "0xE7AC58", Offset = "0xE7AC58", VA = "0xE7AC58")]
	public void RefreshCSSOLastRoundTeamsHPList()
	{
	}

	[Token(Token = "0x6014C3E")]
	[Address(RVA = "0xE7AD4C", Offset = "0xE7AD4C", VA = "0xE7AD4C")]
	public void RefreshCSSOTeamsHPList(List<byte> list)
	{
	}

	[Token(Token = "0x6014C3F")]
	[Address(RVA = "0xE7AEB4", Offset = "0xE7AEB4", VA = "0xE7AEB4")]
	public List<byte> GetCSSORankList()
	{
		return null;
	}

	[Token(Token = "0x6014C40")]
	[Address(RVA = "0xE7AF0C", Offset = "0xE7AF0C", VA = "0xE7AF0C")]
	public List<byte> GetCSSOLastRoundRankList()
	{
		return null;
	}

	[Token(Token = "0x6014C41")]
	[Address(RVA = "0xE7AF64", Offset = "0xE7AF64", VA = "0xE7AF64")]
	public int GetRankByTeamID(byte teamID)
	{
		return default(int);
	}

	[Token(Token = "0x6014C42")]
	[Address(RVA = "0xE7B0AC", Offset = "0xE7B0AC", VA = "0xE7B0AC")]
	public int GetLastRankByTeamID(byte teamID)
	{
		return default(int);
	}

	[Token(Token = "0x6014C43")]
	[Address(RVA = "0xE7B1F4", Offset = "0xE7B1F4", VA = "0xE7B1F4")]
	public byte GetTeamHPByTeamID(byte teamID)
	{
		return default(byte);
	}

	[Token(Token = "0x6014C44")]
	[Address(RVA = "0xE7B408", Offset = "0xE7B408", VA = "0xE7B408")]
	public byte GetLastRoundTeamHPByTeamID(byte teamID)
	{
		return default(byte);
	}

	[Token(Token = "0x6014C45")]
	[Address(RVA = "0xE7B528", Offset = "0xE7B528", VA = "0xE7B528")]
	public byte GetOppoTeamID(IHAAMHPPLMG playerID)
	{
		return default(byte);
	}

	[Token(Token = "0x6014C46")]
	[Address(RVA = "0xE7B9D4", Offset = "0xE7B9D4", VA = "0xE7B9D4")]
	public void SetCSSOTeamIndex(byte teamID, int teamIndex)
	{
	}

	[Token(Token = "0x6014C47")]
	[Address(RVA = "0xE7BABC", Offset = "0xE7BABC", VA = "0xE7BABC")]
	public void ClearCSSOPlayerZoneIndex()
	{
	}

	[Token(Token = "0x6014C48")]
	[Address(RVA = "0xE7BB7C", Offset = "0xE7BB7C", VA = "0xE7BB7C")]
	public bool IsCSSOSameZone(Player p)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C49")]
	[Address(RVA = "0xE7BDAC", Offset = "0xE7BDAC", VA = "0xE7BDAC")]
	public bool IsCSSOSameZone(IHAAMHPPLMG p)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C4A")]
	[Address(RVA = "0xE7BFAC", Offset = "0xE7BFAC", VA = "0xE7BFAC")]
	public void SetCSSOPlayerZoneIndex(IHAAMHPPLMG playerID, uint zoneIndex)
	{
	}

	[Token(Token = "0x6014C4B")]
	[Address(RVA = "0xE7C0D4", Offset = "0xE7C0D4", VA = "0xE7C0D4")]
	public void SetZoneIndexSpecial(uint zoneIndex, bool special)
	{
	}

	[Token(Token = "0x6014C4C")]
	[Address(RVA = "0xE7C1BC", Offset = "0xE7C1BC", VA = "0xE7C1BC")]
	public bool IsZoneIndexSpecial(uint zoneIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C4D")]
	[Address(RVA = "0xE7B30C", Offset = "0xE7B30C", VA = "0xE7B30C")]
	public int GetCSSOTeamIndex(byte teamID)
	{
		return default(int);
	}

	[Token(Token = "0x6014C4E")]
	[Address(RVA = "0xE7B894", Offset = "0xE7B894", VA = "0xE7B894")]
	public uint GetCSSOPlayerZoneIndex(IHAAMHPPLMG playerID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014C4F")]
	[Address(RVA = "0xE7C2A8", Offset = "0xE7C2A8", VA = "0xE7C2A8")]
	public void ResetPlayerIds(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x6014C50")]
	[Address(RVA = "0xE7C970", Offset = "0xE7C970", VA = "0xE7C970")]
	public string GetCSSOTeamName(byte teamID)
	{
		return null;
	}

	[Token(Token = "0x6014C51")]
	[Address(RVA = "0xE7CAAC", Offset = "0xE7CAAC", VA = "0xE7CAAC")]
	public uint GetCSSOTeamColor(byte teamID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014C52")]
	[Address(RVA = "0xE7CBA8", Offset = "0xE7CBA8", VA = "0xE7CBA8")]
	public uint GetCSSOTeamNameColor(byte teamID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014C53")]
	[Address(RVA = "0xE7CCA4", Offset = "0xE7CCA4", VA = "0xE7CCA4")]
	public string GetCSSOBBCodeTeamColor(byte teamID)
	{
		return null;
	}

	[Token(Token = "0x6014C54")]
	[Address(RVA = "0xE7CDAC", Offset = "0xE7CDAC", VA = "0xE7CDAC")]
	public void SetRoundBattleResults(List<BFMCLOANCEP> battleResult)
	{
	}

	[Token(Token = "0x6014C55")]
	[Address(RVA = "0xE7CF7C", Offset = "0xE7CF7C", VA = "0xE7CF7C")]
	public bool GetBattleResultByTeamID(byte teamID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C56")]
	[Address(RVA = "0xE7D06C", Offset = "0xE7D06C", VA = "0xE7D06C")]
	public void ClearCSSOBattleResult()
	{
	}

	[Token(Token = "0x6014C57")]
	[Address(RVA = "0xE7D12C", Offset = "0xE7D12C", VA = "0xE7D12C")]
	public void SetCSSOPlayerKillInfos(HLIMPCDCKKP msg)
	{
	}

	[Token(Token = "0x6014C58")]
	[Address(RVA = "0xE7D3C8", Offset = "0xE7D3C8", VA = "0xE7D3C8")]
	public AFDILJDJCCJ GetCSSOPlayerKillInfo(IHAAMHPPLMG playerID)
	{
		return null;
	}

	[Token(Token = "0x6014C59")]
	[Address(RVA = "0xE7D4F0", Offset = "0xE7D4F0", VA = "0xE7D4F0")]
	public void SetCSSOTeamEliminateInfo(BAEKNKGFHCG msg)
	{
	}

	[Token(Token = "0x6014C5A")]
	[Address(RVA = "0xE7D720", Offset = "0xE7D720", VA = "0xE7D720")]
	public byte GetCSSOTeamEliminateRound(byte teamID)
	{
		return default(byte);
	}

	[Token(Token = "0x6014C5B")]
	[Address(RVA = "0xE7D808", Offset = "0xE7D808", VA = "0xE7D808")]
	public bool IsCSSOTeamEliminate(byte teamID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C5C")]
	[Address(RVA = "0xE7D87C", Offset = "0xE7D87C", VA = "0xE7D87C")]
	public string GetCSSORankString(byte teamID)
	{
		return null;
	}

	[Token(Token = "0x6014C5D")]
	[Address(RVA = "0xE7D9B8", Offset = "0xE7D9B8", VA = "0xE7D9B8")]
	public int GetCSSOAliveTeamCnt()
	{
		return default(int);
	}

	[Token(Token = "0x6014C5E")]
	[Address(RVA = "0xE7DB54", Offset = "0xE7DB54", VA = "0xE7DB54")]
	public void RecordTDShowOverEffectTime(EFNHBHILCNJ type, float time)
	{
	}

	[Token(Token = "0x6014C5F")]
	[Address(RVA = "0xE7DC3C", Offset = "0xE7DC3C", VA = "0xE7DC3C")]
	public float GetTDShowOverEffectTime(EFNHBHILCNJ type)
	{
		return default(float);
	}

	[Token(Token = "0x6014C60")]
	[Address(RVA = "0xE7DD4C", Offset = "0xE7DD4C", VA = "0xE7DD4C")]
	public void RemoveTDShowOverEffectTime(EFNHBHILCNJ type)
	{
	}

	[Token(Token = "0x6014C63")]
	[Address(RVA = "0xE632F0", Offset = "0xE632F0", VA = "0xE632F0")]
	public void ClearAskPurchaseInfo()
	{
	}

	[Token(Token = "0x6014C64")]
	[Address(RVA = "0xE7DE60", Offset = "0xE7DE60", VA = "0xE7DE60")]
	public bool HasAskRequest(IHAAMHPPLMG pid)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C65")]
	[Address(RVA = "0xE7DF78", Offset = "0xE7DF78", VA = "0xE7DF78")]
	public void OnOtherAskPurchase(JANDNALHJJH res)
	{
	}

	[Token(Token = "0x6014C66")]
	[Address(RVA = "0xE7E808", Offset = "0xE7E808", VA = "0xE7E808")]
	public void OnPlayerPurchaseForOther(BNCMBMEFNLK res)
	{
	}

	[Token(Token = "0x6014C67")]
	[Address(RVA = "0xE7F3FC", Offset = "0xE7F3FC", VA = "0xE7F3FC")]
	public void AskCSPurchase(List<uint> itemids)
	{
	}

	[Token(Token = "0x6014C68")]
	[Address(RVA = "0xE7F684", Offset = "0xE7F684", VA = "0xE7F684")]
	public bool PayForOther(IHAAMHPPLMG sender)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C69")]
	[Address(RVA = "0xE631FC", Offset = "0xE631FC", VA = "0xE631FC")]
	private void ClearLWSOData()
	{
	}

	[Token(Token = "0x6014C6A")]
	[Address(RVA = "0xE7FF48", Offset = "0xE7FF48", VA = "0xE7FF48")]
	public List<NBJFOKDNNBK> GetLWSOTeamInfoList()
	{
		return null;
	}

	[Token(Token = "0x6014C6B")]
	[Address(RVA = "0xE80168", Offset = "0xE80168", VA = "0xE80168")]
	public void SetLWSOPlayerKillInfo(NJPOAHAAELJ msg)
	{
	}

	[Token(Token = "0x6014C6C")]
	[Address(RVA = "0xE80380", Offset = "0xE80380", VA = "0xE80380")]
	public MDHFBDKMNFK GetLWSOPlayerKillInfo(IHAAMHPPLMG playerID)
	{
		return null;
	}

	[Token(Token = "0x6014C6D")]
	[Address(RVA = "0xE804D8", Offset = "0xE804D8", VA = "0xE804D8")]
	public void RefreshLWSOTeamInfo(List<NBJFOKDNNBK> teamInfos)
	{
	}

	[Token(Token = "0x6014C6E")]
	[Address(RVA = "0xE806AC", Offset = "0xE806AC", VA = "0xE806AC")]
	public NBJFOKDNNBK GetLWSOTeamInfoByTeamID(byte teamID)
	{
		return null;
	}

	[Token(Token = "0x6014C6F")]
	[Address(RVA = "0xE80794", Offset = "0xE80794", VA = "0xE80794")]
	public void RefreshLWSOTeamLastRoundResult(List<AEDDCAMDPHM> results)
	{
	}

	[Token(Token = "0x6014C70")]
	[Address(RVA = "0xE7FE88", Offset = "0xE7FE88", VA = "0xE7FE88")]
	public void ClearLWSOTeamLastRoundResult()
	{
	}

	[Token(Token = "0x6014C71")]
	[Address(RVA = "0xE8098C", Offset = "0xE8098C", VA = "0xE8098C")]
	public FJCPGEDJJJK GetLWSOTeamLastRoundResult(byte teamID)
	{
		return default(FJCPGEDJJJK);
	}

	[Token(Token = "0x6014C72")]
	[Address(RVA = "0xE80A74", Offset = "0xE80A74", VA = "0xE80A74")]
	public NBJFOKDNNBK GetLWSOEnemyTeamInfo(byte teamID)
	{
		return null;
	}

	[Token(Token = "0x6014C73")]
	[Address(RVA = "0xE80D00", Offset = "0xE80D00", VA = "0xE80D00")]
	public bool LWSOTeamIsEliminate(byte teamID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C74")]
	[Address(RVA = "0xE80D78", Offset = "0xE80D78", VA = "0xE80D78")]
	public bool LWSOTeamIsEliminate(NBJFOKDNNBK teamInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C75")]
	[Address(RVA = "0xE80EE4", Offset = "0xE80EE4", VA = "0xE80EE4")]
	public bool LWSOTeamIsLastRoundEliminate(NBJFOKDNNBK teamInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C76")]
	[Address(RVA = "0xE81054", Offset = "0xE81054", VA = "0xE81054")]
	public string GetLWSOTeamRankString(byte rank)
	{
		return null;
	}

	[Token(Token = "0x6014C77")]
	[Address(RVA = "0xE811EC", Offset = "0xE811EC", VA = "0xE811EC")]
	public bool IsLWSOSameFightZone(Player p)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C78")]
	[Address(RVA = "0xE81328", Offset = "0xE81328", VA = "0xE81328")]
	public bool IsLWSOSameFightZone(IHAAMHPPLMG pID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C79")]
	[Address(RVA = "0xE81528", Offset = "0xE81528", VA = "0xE81528")]
	public byte GetLWSOPlayerFightZoneIndex(IHAAMHPPLMG playerID)
	{
		return default(byte);
	}

	[Token(Token = "0x6014C7C")]
	[Address(RVA = "0xE81668", Offset = "0xE81668", VA = "0xE81668")]
	public bool IsDeathMatchKillerKing(IHAAMHPPLMG playerID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C7D")]
	[Address(RVA = "0xE817B8", Offset = "0xE817B8", VA = "0xE817B8")]
	public bool IsShowMatchResultRewardWnd()
	{
		return default(bool);
	}

	[Token(Token = "0x6014C7E")]
	[Address(RVA = "0xE83140", Offset = "0xE83140", VA = "0xE83140")]
	public bool IsLastGameSignersB()
	{
		return default(bool);
	}

	[Token(Token = "0x6014C7F")]
	[Address(RVA = "0xE82EA8", Offset = "0xE82EA8", VA = "0xE82EA8")]
	private uint GetAvatarDebrisLockCout(uint avatarid, uint level)
	{
		return default(uint);
	}

	[Token(Token = "0x6014C80")]
	[Address(RVA = "0xE831BC", Offset = "0xE831BC", VA = "0xE831BC")]
	public void GetLinkValueAfterMatch(AwardGameLinkNtf data)
	{
	}

	[Token(Token = "0x6014C81")]
	[Address(RVA = "0xE8321C", Offset = "0xE8321C", VA = "0xE8321C")]
	public uint GetBuffValueAndRemainTime(out float value, out float nextValue)
	{
		return default(uint);
	}

	[Token(Token = "0x6014C82")]
	[Address(RVA = "0xE83318", Offset = "0xE83318", VA = "0xE83318")]
	public void OnKillerUpdate(EKBIOEEAMAK msg)
	{
	}

	[Token(Token = "0x6014C83")]
	[Address(RVA = "0xE83544", Offset = "0xE83544", VA = "0xE83544")]
	public void OnKnockDownerUpdate(NPNCGKEEJOL msg)
	{
	}

	[Token(Token = "0x6014C84")]
	[Address(RVA = "0xE8377C", Offset = "0xE8377C", VA = "0xE8377C")]
	public List<CandidateReporteeData> GetCandiateReportees()
	{
		return null;
	}

	[Token(Token = "0x6014C85")]
	[Address(RVA = "0xE84058", Offset = "0xE84058", VA = "0xE84058")]
	public void SetSKillCDMatchSetting(PLPOJKGPFDL generalData)
	{
	}

	[Token(Token = "0x6014C86")]
	[Address(RVA = "0xE84AC0", Offset = "0xE84AC0", VA = "0xE84AC0")]
	public bool IsKilledBySystem(IHAAMHPPLMG id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014C87")]
	[Address(RVA = "0xE84BD8", Offset = "0xE84BD8", VA = "0xE84BD8")]
	private void _003CClaimForceTutorialGameReward_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014C88")]
	[Address(RVA = "0xE84EC4", Offset = "0xE84EC4", VA = "0xE84EC4")]
	private static int _003CUpdateEPRankingList_003Em__1(EPPlayerInfo a, EPPlayerInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6014C89")]
	[Address(RVA = "0xE84F3C", Offset = "0xE84F3C", VA = "0xE84F3C")]
	private void _003CRequestNewbieGuideDescRes_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014C8A")]
	[Address(RVA = "0xE85194", Offset = "0xE85194", VA = "0xE85194")]
	private static uint _003CRequestStartMatchMakingInternal_003Em__3(MapModeData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014C8B")]
	[Address(RVA = "0xE851B8", Offset = "0xE851B8", VA = "0xE851B8")]
	private void _003CRequestMatchResultViaHTTP_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014C8C")]
	[Address(RVA = "0xE85968", Offset = "0xE85968", VA = "0xE85968")]
	private static int _003CSetArmsRaceAllPlayerStats_003Em__5(TeammateStats a, TeammateStats b)
	{
		return default(int);
	}

	[Token(Token = "0x6014C8D")]
	[Address(RVA = "0xE859B0", Offset = "0xE859B0", VA = "0xE859B0")]
	private static int _003CGenerateMatchResult_003Em__6(ResultTeamData a, ResultTeamData b)
	{
		return default(int);
	}

	[Token(Token = "0x6014C8E")]
	[Address(RVA = "0xE859F8", Offset = "0xE859F8", VA = "0xE859F8")]
	private static BaseItemInfo _003CClaimForceTutorialGameReward_003Em__7(AwardDesc item)
	{
		return null;
	}

	[Token(Token = "0x6014C8F")]
	[Address(RVA = "0xE85A7C", Offset = "0xE85A7C", VA = "0xE85A7C")]
	private static CommonRewardItemInfo _003CClaimForceTutorialGameReward_003Em__8(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6014C90")]
	[Address(RVA = "0xE85A84", Offset = "0xE85A84", VA = "0xE85A84")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
