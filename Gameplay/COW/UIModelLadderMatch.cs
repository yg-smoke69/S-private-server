using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030CF")]
public class UIModelLadderMatch : UIBaseModel, _Attribute
{
	[Token(Token = "0x20030D0")]
	public delegate void OnFinishedDelegate();

	[Token(Token = "0x20030D1")]
	private sealed class _003CResquestRankMasterLevelInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x401293D")]
		[FieldOffset(Offset = "0x8")]
		internal uint seasonID;

		[Token(Token = "0x401293E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x401293F")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<RankMasterLevel> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601479C")]
		[Address(RVA = "0x3271D10", Offset = "0x3271D10", VA = "0x3271D10")]
		public _003CResquestRankMasterLevelInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601479D")]
		[Address(RVA = "0x327C1B4", Offset = "0x327C1B4", VA = "0x327C1B4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601479E")]
		[Address(RVA = "0x327C3C4", Offset = "0x327C3C4", VA = "0x327C3C4")]
		private static int _003C_003Em__1(RankMasterLevel a, RankMasterLevel b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20030D2")]
	private sealed class _003CGetSeasonInfoConfigFromServer_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012940")]
		[FieldOffset(Offset = "0x8")]
		internal OnFinishedDelegate onFinished;

		[Token(Token = "0x4012941")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x601479F")]
		[Address(RVA = "0x32720B0", Offset = "0x32720B0", VA = "0x32720B0")]
		public _003CGetSeasonInfoConfigFromServer_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x20030D3")]
	private sealed class _003CRefreshRankInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012942")]
		[FieldOffset(Offset = "0x8")]
		internal uint httpOp;

		[Token(Token = "0x4012943")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147A0")]
		[Address(RVA = "0x3272980", Offset = "0x3272980", VA = "0x3272980")]
		public _003CRefreshRankInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60147A1")]
		[Address(RVA = "0x327C0E8", Offset = "0x327C0E8", VA = "0x327C0E8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20030D4")]
	private sealed class _003CSetShowRank_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012944")]
		[FieldOffset(Offset = "0x8")]
		internal bool showRank;

		[Token(Token = "0x4012945")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147A2")]
		[Address(RVA = "0x32733E4", Offset = "0x32733E4", VA = "0x32733E4")]
		public _003CSetShowRank_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60147A3")]
		[Address(RVA = "0x327C40C", Offset = "0x327C40C", VA = "0x327C40C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030D5")]
	private sealed class _003CGetLadderHasFirstWin_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012946")]
		[FieldOffset(Offset = "0x8")]
		internal bool preload;

		[Token(Token = "0x4012947")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147A4")]
		[Address(RVA = "0x3274380", Offset = "0x3274380", VA = "0x3274380")]
		public _003CGetLadderHasFirstWin_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60147A5")]
		[Address(RVA = "0x327BCDC", Offset = "0x327BCDC", VA = "0x327BCDC")]
		internal void _003C_003Em__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	[Token(Token = "0x20030D6")]
	private sealed class _003CCheckIsNeedRankComparePop_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012948")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x4012949")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147A6")]
		[Address(RVA = "0x327615C", Offset = "0x327615C", VA = "0x327615C")]
		public _003CCheckIsNeedRankComparePop_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60147A7")]
		[Address(RVA = "0x327BBB8", Offset = "0x327BBB8", VA = "0x327BBB8")]
		internal bool _003C_003Em__0(LeaderBoardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030D7")]
	private sealed class _003CConstructRankCompareFriendRankList_003Ec__AnonStorey6
	{
		[Token(Token = "0x401294A")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x60147A8")]
		[Address(RVA = "0x327694C", Offset = "0x327694C", VA = "0x327694C")]
		public _003CConstructRankCompareFriendRankList_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60147A9")]
		[Address(RVA = "0x327BC5C", Offset = "0x327BC5C", VA = "0x327BC5C")]
		internal bool _003C_003Em__0(LeaderBoardInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x60147AA")]
		[Address(RVA = "0x327BC9C", Offset = "0x327BC9C", VA = "0x327BC9C")]
		internal bool _003C_003Em__1(LeaderBoardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030D8")]
	private sealed class _003CUpdateCurrentLadderMapOpeningInfo_003Ec__AnonStorey7
	{
		[Token(Token = "0x401294B")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x401294C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147AB")]
		[Address(RVA = "0x32785C0", Offset = "0x32785C0", VA = "0x32785C0")]
		public _003CUpdateCurrentLadderMapOpeningInfo_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60147AC")]
		[Address(RVA = "0x327C660", Offset = "0x327C660", VA = "0x327C660")]
		internal bool _003C_003Em__0(MapOpeningInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030D9")]
	private sealed class _003CRefreshSelectedRankMap_003Ec__AnonStorey8
	{
		[Token(Token = "0x401294D")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x401294E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147AD")]
		[Address(RVA = "0x3278C0C", Offset = "0x3278C0C", VA = "0x3278C0C")]
		public _003CRefreshSelectedRankMap_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60147AE")]
		[Address(RVA = "0x327C11C", Offset = "0x327C11C", VA = "0x327C11C")]
		internal bool _003C_003Em__0(MapOpeningInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030DA")]
	private sealed class _003CGetSelectedRankingMaps_003Ec__AnonStorey9
	{
		[Token(Token = "0x401294F")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4012950")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147AF")]
		[Address(RVA = "0x3279874", Offset = "0x3279874", VA = "0x3279874")]
		public _003CGetSelectedRankingMaps_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60147B0")]
		[Address(RVA = "0x327C050", Offset = "0x327C050", VA = "0x327C050")]
		internal bool _003C_003Em__0(MapOpeningInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030DB")]
	private sealed class _003CGetSeasonData_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012951")]
		[FieldOffset(Offset = "0x8")]
		internal uint season_id;

		[Token(Token = "0x4012952")]
		[FieldOffset(Offset = "0xC")]
		internal uint rank_point;

		[Token(Token = "0x4012953")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelLadderMatch _0024this;

		[Token(Token = "0x60147B1")]
		[Address(RVA = "0x3279A28", Offset = "0x3279A28", VA = "0x3279A28")]
		public _003CGetSeasonData_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x60147B2")]
		[Address(RVA = "0x327BE00", Offset = "0x327BE00", VA = "0x327BE00")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x40128FE")]
	public const string RANK_MAP_SELECT = "rank_map_select";

	[Token(Token = "0x40128FF")]
	public const string FIRST_TIME_ENTER_BR_RANK_KEY = "FirstTimeEnterBRRank";

	[Token(Token = "0x4012900")]
	public const uint PropID_RankInfoRefreshed = 2u;

	[Token(Token = "0x4012901")]
	public const uint PropID_SeasonInfoRefreshed = 4u;

	[Token(Token = "0x4012902")]
	public const uint PropID_SetShowRankSuccess = 8u;

	[Token(Token = "0x4012903")]
	public const uint PropID_FirstWinRefreshed = 16u;

	[Token(Token = "0x4012904")]
	public const uint PropID_SeasonStatsRefresh = 32u;

	[Token(Token = "0x4012905")]
	public const uint PropID_SetChooseRankCardSuccess = 64u;

	[Token(Token = "0x4012906")]
	public const uint PropID_RankActivityRefreshed = 128u;

	[Token(Token = "0x4012907")]
	public const uint PropID_PeakRankPosRefresh = 128u;

	[Token(Token = "0x4012908")]
	public const uint PropID_RankMapSelectConfirmed = 256u;

	[Token(Token = "0x4012909")]
	public const uint PropID_RankingTaskInfoRefreshed = 512u;

	[Token(Token = "0x401290A")]
	public const uint PropID_BRResetMatchRewardClaimSuccess = 1024u;

	[Token(Token = "0x401290B")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<int, string> ERankActivityTypeForLocKeyMap;

	[Token(Token = "0x401290C")]
	[FieldOffset(Offset = "0x10")]
	private LadderRankInfo m_CurrentLadderRankInfo;

	[Token(Token = "0x401290D")]
	[FieldOffset(Offset = "0x14")]
	private float m_NextReqRankInfoTime;

	[Token(Token = "0x401290E")]
	[FieldOffset(Offset = "0x18")]
	private float m_NextReqRankTaskInfoTime;

	[Token(Token = "0x401290F")]
	[FieldOffset(Offset = "0x1C")]
	private float m_NextReqRankStatTime;

	[Token(Token = "0x4012910")]
	[FieldOffset(Offset = "0x20")]
	private List<uint> m_AwardsExhibitIDList;

	[Token(Token = "0x4012911")]
	[FieldOffset(Offset = "0x24")]
	private List<uint> m_ExchangeExhibitIDlist;

	[Token(Token = "0x4012912")]
	[FieldOffset(Offset = "0x28")]
	private int m_ResetMatchTipsCount;

	[Token(Token = "0x4012913")]
	[FieldOffset(Offset = "0x2C")]
	private List<RankingTaskInfo> m_LadderDailyMissionInfoList;

	[Token(Token = "0x4012914")]
	[FieldOffset(Offset = "0x30")]
	private uint m_InitRank;

	[Token(Token = "0x4012915")]
	[FieldOffset(Offset = "0x34")]
	private uint[] m_CurrentLadderUsedMapList;

	[Token(Token = "0x4012916")]
	[FieldOffset(Offset = "0x38")]
	private uint[] m_CurrentLadderSelectedMapList;

	[Token(Token = "0x4012917")]
	[FieldOffset(Offset = "0x3C")]
	public int cachedMaxRank;

	[Token(Token = "0x4012918")]
	[FieldOffset(Offset = "0x40")]
	public bool isMaxRankDirty;

	[Token(Token = "0x4012919")]
	[FieldOffset(Offset = "0x44")]
	public int LastPeakRankPos;

	[Token(Token = "0x401291A")]
	[FieldOffset(Offset = "0x48")]
	private RankingSeasonInfo m_CurrentSeasonInfo;

	[Token(Token = "0x401291B")]
	[FieldOffset(Offset = "0x4C")]
	private RankingInfo m_LastSeasonRankInfo;

	[Token(Token = "0x401291C")]
	[FieldOffset(Offset = "0x50")]
	private RankingSeasonInfo m_LastSeasonInfo;

	[Token(Token = "0x401291D")]
	[FieldOffset(Offset = "0x54")]
	private LadderSeasonStatsInfo m_LadderSeasonInfo;

	[Token(Token = "0x401291E")]
	[FieldOffset(Offset = "0x58")]
	private LadderMatchDaily m_LadderDailyInfo;

	[Token(Token = "0x401291F")]
	[FieldOffset(Offset = "0x5C")]
	private RankCard m_RankCard;

	[Token(Token = "0x4012920")]
	[FieldOffset(Offset = "0x60")]
	private List<int> ladderActivityTypes;

	[Token(Token = "0x4012921")]
	[FieldOffset(Offset = "0x64")]
	private List<RankAwardsDesc> m_CurrentSeasonAwards;

	[Token(Token = "0x4012922")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, RankTopAwardsDesc> m_RankTopAward;

	[Token(Token = "0x4012923")]
	[FieldOffset(Offset = "0x6C")]
	private LadderLevelData m_CurrentLadderLevelData;

	[Token(Token = "0x4012924")]
	[FieldOffset(Offset = "0x70")]
	private LadderLevelData m_NextLadderLevelData;

	[Token(Token = "0x4012925")]
	[FieldOffset(Offset = "0x74")]
	private LadderLevelData m_MaxLadderLevelData;

	[Token(Token = "0x4012926")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<uint, List<RankMasterLevel>> m_RankMasterLevelDic;

	[Token(Token = "0x4012927")]
	[FieldOffset(Offset = "0x7C")]
	public bool isLastReachPeakRank;

	[Token(Token = "0x4012928")]
	[FieldOffset(Offset = "0x80")]
	public double PeakRankThreshold;

	[Token(Token = "0x4012929")]
	[FieldOffset(Offset = "0x88")]
	public double LastPeakRankThreshold;

	[Token(Token = "0x401292A")]
	[FieldOffset(Offset = "0x90")]
	public List<LadderLevelData> RankUpRewardList;

	[Token(Token = "0x401292B")]
	[FieldOffset(Offset = "0x94")]
	private CSPlayerRankingInfoReq m_PendingInfoRequest;

	[Token(Token = "0x401292C")]
	[FieldOffset(Offset = "0x98")]
	private Empty m_PendingSeasonRequest;

	[Token(Token = "0x401292D")]
	[FieldOffset(Offset = "0x9C")]
	private CSSetShowRankReq m_PendingShowRankRequest;

	[Token(Token = "0x401292E")]
	[FieldOffset(Offset = "0xA0")]
	private CSChooseRankingCardsReq m_PendingSetChooseRankingCardRequest;

	[Token(Token = "0x401292F")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_ShowCallsignRank;

	[Token(Token = "0x4012930")]
	[FieldOffset(Offset = "0xA5")]
	private bool m_PreloadLadder;

	[Token(Token = "0x4012931")]
	[FieldOffset(Offset = "0xA8")]
	private LatestRankInfo m_LatestRankInfo;

	[Token(Token = "0x4012932")]
	[FieldOffset(Offset = "0xC8")]
	public List<LeaderBoardInfo> ExceededPlatformFriendList;

	[Token(Token = "0x4012933")]
	[FieldOffset(Offset = "0xCC")]
	public List<LeaderBoardInfo> ExceededFriendList;

	[Token(Token = "0x4012934")]
	[FieldOffset(Offset = "0xD0")]
	public bool NeedRankComparisonPop;

	[Token(Token = "0x4012935")]
	[FieldOffset(Offset = "0xD4")]
	public int SelfIndex;

	[Token(Token = "0x4012936")]
	[FieldOffset(Offset = "0xD8")]
	private List<MapOpeningInfo> m_CurrentLadderMapOpeningInfo;

	[Token(Token = "0x4012937")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<RankMasterLevel> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012938")]
	[FieldOffset(Offset = "0x4")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012939")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<LeaderBoardInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x401293A")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<MapOpeningInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x401293B")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<MapOpeningInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x401293C")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<MapOpeningInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x1700153B")]
	public int ResetMatchTipsCount
	{
		[Token(Token = "0x601471F")]
		[Address(RVA = "0x326E7C4", Offset = "0x326E7C4", VA = "0x326E7C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014720")]
		[Address(RVA = "0x326E81C", Offset = "0x326E81C", VA = "0x326E81C")]
		set
		{
		}
	}

	[Token(Token = "0x1700153C")]
	public bool IsResetMatchRewardClaimable
	{
		[Token(Token = "0x6014723")]
		[Address(RVA = "0x326E94C", Offset = "0x326E94C", VA = "0x326E94C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700153D")]
	public LadderRankInfo CurrentLadderRankInfo
	{
		[Token(Token = "0x6014725")]
		[Address(RVA = "0x326EB0C", Offset = "0x326EB0C", VA = "0x326EB0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700153E")]
	public List<RankingTaskInfo> LadderDailyMissionInfoList
	{
		[Token(Token = "0x6014726")]
		[Address(RVA = "0x326EE64", Offset = "0x326EE64", VA = "0x326EE64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700153F")]
	public uint[] CurrentLadderUsedMapList
	{
		[Token(Token = "0x6014727")]
		[Address(RVA = "0x326EEBC", Offset = "0x326EEBC", VA = "0x326EEBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001540")]
	public uint[] CurrentLadderSelectedMapList
	{
		[Token(Token = "0x6014728")]
		[Address(RVA = "0x326EF14", Offset = "0x326EF14", VA = "0x326EF14")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001541")]
	public int CurrentRank
	{
		[Token(Token = "0x6014729")]
		[Address(RVA = "0x326EF6C", Offset = "0x326EF6C", VA = "0x326EF6C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001542")]
	public int CurrentLadderScore
	{
		[Token(Token = "0x601472C")]
		[Address(RVA = "0x326F27C", Offset = "0x326F27C", VA = "0x326F27C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001543")]
	public int CurrentPeakRankPos
	{
		[Token(Token = "0x601472D")]
		[Address(RVA = "0x326F2F4", Offset = "0x326F2F4", VA = "0x326F2F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001544")]
	public int LastSeasonPeakRankPos
	{
		[Token(Token = "0x601472E")]
		[Address(RVA = "0x326F420", Offset = "0x326F420", VA = "0x326F420")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001545")]
	public RankingSeasonInfo CurrentSeasonInfo
	{
		[Token(Token = "0x6014730")]
		[Address(RVA = "0x326EBD4", Offset = "0x326EBD4", VA = "0x326EBD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001546")]
	public RankingInfo LastSeasonRankInfo
	{
		[Token(Token = "0x6014731")]
		[Address(RVA = "0x326F4E0", Offset = "0x326F4E0", VA = "0x326F4E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014732")]
		[Address(RVA = "0x326F538", Offset = "0x326F538", VA = "0x326F538")]
		set
		{
		}
	}

	[Token(Token = "0x17001547")]
	public RankingSeasonInfo LastSeasonInfo
	{
		[Token(Token = "0x6014733")]
		[Address(RVA = "0x326F598", Offset = "0x326F598", VA = "0x326F598")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014734")]
		[Address(RVA = "0x326F5F0", Offset = "0x326F5F0", VA = "0x326F5F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001548")]
	public LadderSeasonStatsInfo LadderSeasonStatsInfo
	{
		[Token(Token = "0x6014735")]
		[Address(RVA = "0x326F650", Offset = "0x326F650", VA = "0x326F650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001549")]
	public LadderMatchDaily LadderDailyInfo
	{
		[Token(Token = "0x6014736")]
		[Address(RVA = "0x326F718", Offset = "0x326F718", VA = "0x326F718")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154A")]
	public RankCard SelectedRankCardInfo
	{
		[Token(Token = "0x6014737")]
		[Address(RVA = "0x326F7E0", Offset = "0x326F7E0", VA = "0x326F7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154B")]
	public Dictionary<uint, RankTopAwardsDesc> RankTopAward
	{
		[Token(Token = "0x601473B")]
		[Address(RVA = "0x326FAA4", Offset = "0x326FAA4", VA = "0x326FAA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154C")]
	public List<RankAwardsDesc> CurrentSeasonAwards
	{
		[Token(Token = "0x601473C")]
		[Address(RVA = "0x326FAFC", Offset = "0x326FAFC", VA = "0x326FAFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154D")]
	public LadderLevelData CurrentLadderLevelData
	{
		[Token(Token = "0x601473D")]
		[Address(RVA = "0x326FB54", Offset = "0x326FB54", VA = "0x326FB54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154E")]
	public LadderLevelData NextLadderLevelData
	{
		[Token(Token = "0x601473E")]
		[Address(RVA = "0x326FC80", Offset = "0x326FC80", VA = "0x326FC80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700154F")]
	public LadderLevelData MaxLadderLevelData
	{
		[Token(Token = "0x601473F")]
		[Address(RVA = "0x326FDAC", Offset = "0x326FDAC", VA = "0x326FDAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001550")]
	public List<RankMasterLevel> RankMasterLevel
	{
		[Token(Token = "0x6014740")]
		[Address(RVA = "0x326FEE8", Offset = "0x326FEE8", VA = "0x326FEE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001551")]
	public bool HasDailyMissionUncomplete
	{
		[Token(Token = "0x6014742")]
		[Address(RVA = "0x32701B0", Offset = "0x32701B0", VA = "0x32701B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001552")]
	public bool ShowRankUpReward
	{
		[Token(Token = "0x6014743")]
		[Address(RVA = "0x3270350", Offset = "0x3270350", VA = "0x3270350")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001553")]
	public bool IsMaxLadderLevel
	{
		[Token(Token = "0x601474C")]
		[Address(RVA = "0x3270C3C", Offset = "0x3270C3C", VA = "0x3270C3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001554")]
	public bool ShowCallsignRank
	{
		[Token(Token = "0x601474D")]
		[Address(RVA = "0x3270D40", Offset = "0x3270D40", VA = "0x3270D40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601474E")]
		[Address(RVA = "0x3270D98", Offset = "0x3270D98", VA = "0x3270D98")]
		set
		{
		}
	}

	[Token(Token = "0x17001555")]
	public LatestRankInfo RankInfo
	{
		[Token(Token = "0x601476F")]
		[Address(RVA = "0x327593C", Offset = "0x327593C", VA = "0x327593C")]
		get
		{
			return default(LatestRankInfo);
		}
	}

	[Token(Token = "0x17001556")]
	public List<MapOpeningInfo> CurrentLadderMapOpeningInfo
	{
		[Token(Token = "0x6014776")]
		[Address(RVA = "0x3277030", Offset = "0x3277030", VA = "0x3277030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601471D")]
	[Address(RVA = "0x326E358", Offset = "0x326E358", VA = "0x326E358")]
	public UIModelLadderMatch()
	{
	}

	[Token(Token = "0x601471E")]
	[Address(RVA = "0x326E76C", Offset = "0x326E76C", VA = "0x326E76C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014721")]
	[Address(RVA = "0x326E89C", Offset = "0x326E89C", VA = "0x326E89C")]
	public List<uint> GetAwardsExhibitIDList()
	{
		return null;
	}

	[Token(Token = "0x6014722")]
	[Address(RVA = "0x326E8F4", Offset = "0x326E8F4", VA = "0x326E8F4")]
	public List<uint> GetExchangeExhibitIDList()
	{
		return null;
	}

	[Token(Token = "0x6014724")]
	[Address(RVA = "0x326EC9C", Offset = "0x326EC9C", VA = "0x326EC9C")]
	public bool IsResetMatchRewardVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x601472A")]
	[Address(RVA = "0x326EFE4", Offset = "0x326EFE4", VA = "0x326EFE4")]
	public void UpdateGamePlay(uint cnt)
	{
	}

	[Token(Token = "0x601472B")]
	[Address(RVA = "0x326F224", Offset = "0x326F224", VA = "0x326F224")]
	public int GetResetMatchTipsCnt()
	{
		return default(int);
	}

	[Token(Token = "0x601472F")]
	[Address(RVA = "0x326F488", Offset = "0x326F488", VA = "0x326F488")]
	public uint GetNewSeasonInitRank()
	{
		return default(uint);
	}

	[Token(Token = "0x6014738")]
	[Address(RVA = "0x326F8A8", Offset = "0x326F8A8", VA = "0x326F8A8")]
	public List<int> GetAvalibleRankingActivityTypes()
	{
		return null;
	}

	[Token(Token = "0x6014739")]
	[Address(RVA = "0x326F900", Offset = "0x326F900", VA = "0x326F900")]
	public bool isCurrentSeasonOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x601473A")]
	[Address(RVA = "0x326FA34", Offset = "0x326FA34", VA = "0x326FA34")]
	public bool isBonusRewardMode(uint mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014741")]
	[Address(RVA = "0x326FFE8", Offset = "0x326FFE8", VA = "0x326FFE8")]
	public List<RankMasterLevel> GetRankMasterLevelBySeasonID(uint seasonID)
	{
		return null;
	}

	[Token(Token = "0x6014744")]
	[Address(RVA = "0x3270418", Offset = "0x3270418", VA = "0x3270418")]
	public void InitRankUpRewardData(uint rank_before, uint rank_after)
	{
	}

	[Token(Token = "0x6014745")]
	[Address(RVA = "0x32705B4", Offset = "0x32705B4", VA = "0x32705B4", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014746")]
	[Address(RVA = "0x32706E4", Offset = "0x32706E4", VA = "0x32706E4")]
	public bool IsPeakRank(uint peakRankPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6014747")]
	[Address(RVA = "0x3270870", Offset = "0x3270870", VA = "0x3270870")]
	public int GetCurrentPeakRankPos()
	{
		return default(int);
	}

	[Token(Token = "0x6014748")]
	[Address(RVA = "0x3270900", Offset = "0x3270900", VA = "0x3270900")]
	public bool IsCurrentPeakRank()
	{
		return default(bool);
	}

	[Token(Token = "0x6014749")]
	[Address(RVA = "0x327096C", Offset = "0x327096C", VA = "0x327096C")]
	public int PeakRankScore()
	{
		return default(int);
	}

	[Token(Token = "0x601474A")]
	[Address(RVA = "0x3270A8C", Offset = "0x3270A8C", VA = "0x3270A8C")]
	public bool IsLastSeasonPeakRank(uint peakRankPos)
	{
		return default(bool);
	}

	[Token(Token = "0x601474B")]
	[Address(RVA = "0x3270BD0", Offset = "0x3270BD0", VA = "0x3270BD0")]
	public bool IsCurrentUserPeakRank()
	{
		return default(bool);
	}

	[Token(Token = "0x601474F")]
	[Address(RVA = "0x3270DF8", Offset = "0x3270DF8", VA = "0x3270DF8")]
	public ResourceID GetCurrentRankIcon(LadderRankIconType iconType)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014750")]
	[Address(RVA = "0x3271180", Offset = "0x3271180", VA = "0x3271180")]
	public string GetCurrentRankName()
	{
		return null;
	}

	[Token(Token = "0x6014751")]
	[Address(RVA = "0x3270F4C", Offset = "0x3270F4C", VA = "0x3270F4C")]
	public ResourceID GetRankIcon(int rank, uint peakRankPos, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014752")]
	[Address(RVA = "0x32712B8", Offset = "0x32712B8", VA = "0x32712B8")]
	public string GetRankName(int rank, uint peakRankPos)
	{
		return null;
	}

	[Token(Token = "0x6014753")]
	[Address(RVA = "0x3271A60", Offset = "0x3271A60", VA = "0x3271A60")]
	public void ResquestRankMasterLevelInfo(uint seasonID, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014754")]
	[Address(RVA = "0x3271778", Offset = "0x3271778", VA = "0x3271778")]
	public int GetCurrentRankMasterLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6014755")]
	[Address(RVA = "0x32714A8", Offset = "0x32714A8", VA = "0x32714A8")]
	public int GetRankMasterLevel(int position)
	{
		return default(int);
	}

	[Token(Token = "0x6014756")]
	[Address(RVA = "0x3271D18", Offset = "0x3271D18", VA = "0x3271D18")]
	public int GetLastSeasonRankMasterLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6014757")]
	[Address(RVA = "0x3271FB0", Offset = "0x3271FB0", VA = "0x3271FB0")]
	public void GetSeasonInfoConfigFromServer([Optional] OnFinishedDelegate onFinished, uint httpOp = 0u)
	{
	}

	[Token(Token = "0x6014758")]
	[Address(RVA = "0x32720B8", Offset = "0x32720B8", VA = "0x32720B8")]
	public void UpdateSeasonChangeAwardConfig(CSGetCurrentOrRecentRankingSeasonConfigRes season_info_res)
	{
	}

	[Token(Token = "0x6014759")]
	[Address(RVA = "0x32723A4", Offset = "0x32723A4", VA = "0x32723A4")]
	public void ProcessSeasonInfoConfig(CSGetCurrentOrRecentRankingSeasonConfigRes season_info_res)
	{
	}

	[Token(Token = "0x601475A")]
	[Address(RVA = "0x3272400", Offset = "0x3272400", VA = "0x3272400")]
	public void ProcessRankFirstWin(RankingMatchParam _param)
	{
	}

	[Token(Token = "0x601475B")]
	[Address(RVA = "0x32724D4", Offset = "0x32724D4", VA = "0x32724D4")]
	public void ProcessLadderActivityInfo(CSGetRankingActivityConfigRes _res)
	{
	}

	[Token(Token = "0x601475C")]
	[Address(RVA = "0x3272794", Offset = "0x3272794", VA = "0x3272794")]
	public void RefreshRankInfo(uint httpOp = 0u, bool forceRefresh = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601475D")]
	[Address(RVA = "0x3272C20", Offset = "0x3272C20", VA = "0x3272C20")]
	public void RefreshRankTaskInfo(uint httpOp = 0u)
	{
	}

	[Token(Token = "0x601475E")]
	[Address(RVA = "0x3272F60", Offset = "0x3272F60", VA = "0x3272F60")]
	public List<AwardDesc> GetBRRankAwardList(uint rank)
	{
		return null;
	}

	[Token(Token = "0x601475F")]
	[Address(RVA = "0x327299C", Offset = "0x327299C", VA = "0x327299C")]
	public void GetRankInfoFromServer(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014760")]
	[Address(RVA = "0x3272D38", Offset = "0x3272D38", VA = "0x3272D38")]
	public void GetDailyMissionFromServer(uint httpOp = 0u)
	{
	}

	[Token(Token = "0x6014761")]
	[Address(RVA = "0x326F11C", Offset = "0x326F11C", VA = "0x326F11C")]
	public void UpdateUnlockRewardRedTips()
	{
	}

	[Token(Token = "0x6014762")]
	[Address(RVA = "0x32730E0", Offset = "0x32730E0", VA = "0x32730E0")]
	public void SetShowRank(bool showRank)
	{
	}

	[Token(Token = "0x6014763")]
	[Address(RVA = "0x32733EC", Offset = "0x32733EC", VA = "0x32733EC")]
	public void ChooseRankCard(uint cardId)
	{
	}

	[Token(Token = "0x6014764")]
	[Address(RVA = "0x327367C", Offset = "0x327367C", VA = "0x327367C")]
	public void GetPlayerRankingSeasonStats(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014765")]
	[Address(RVA = "0x3273928", Offset = "0x3273928", VA = "0x3273928")]
	public bool HasPlayerEnterBRRankLobbyBefore()
	{
		return default(bool);
	}

	[Token(Token = "0x6014766")]
	[Address(RVA = "0x3273B84", Offset = "0x3273B84", VA = "0x3273B84")]
	public void SetHasPlayerEnterBRRankLobbyKey(bool value)
	{
	}

	[Token(Token = "0x6014767")]
	[Address(RVA = "0x3273D70", Offset = "0x3273D70", VA = "0x3273D70")]
	private void OnGetLadderHasFirstWind()
	{
	}

	[Token(Token = "0x6014768")]
	[Address(RVA = "0x3273E40", Offset = "0x3273E40", VA = "0x3273E40")]
	public void ClaimRankingResetReward()
	{
	}

	[Token(Token = "0x6014769")]
	[Address(RVA = "0x3274064", Offset = "0x3274064", VA = "0x3274064")]
	public void GetLadderHasFirstWin(bool preload = false, bool silence = false)
	{
	}

	[Token(Token = "0x601476A")]
	[Address(RVA = "0x3274388", Offset = "0x3274388", VA = "0x3274388")]
	public void UpdateRankCard(uint[] _cardInfo)
	{
	}

	[Token(Token = "0x601476B")]
	[Address(RVA = "0x32744CC", Offset = "0x32744CC", VA = "0x32744CC")]
	public void RequestError()
	{
	}

	[Token(Token = "0x601476C")]
	[Address(RVA = "0x3274674", Offset = "0x3274674", VA = "0x3274674", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x601476D")]
	[Address(RVA = "0x327544C", Offset = "0x327544C", VA = "0x327544C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601476E")]
	[Address(RVA = "0x3275670", Offset = "0x3275670", VA = "0x3275670")]
	public void SetSeasonChangeInfo(uint season_id)
	{
	}

	[Token(Token = "0x6014770")]
	[Address(RVA = "0x32759B4", Offset = "0x32759B4", VA = "0x32759B4")]
	public void SetLatestRankInfo(bool isRank, uint rankBefore, uint rankAfter, int scoreBefore, int scoreAfter)
	{
	}

	[Token(Token = "0x6014771")]
	[Address(RVA = "0x3275D84", Offset = "0x3275D84", VA = "0x3275D84")]
	private bool CheckIsNeedRankComparePop()
	{
		return default(bool);
	}

	[Token(Token = "0x6014772")]
	[Address(RVA = "0x327631C", Offset = "0x327631C", VA = "0x327631C")]
	public List<LeaderBoardInfo> ConstructRankCompareFriendRankList()
	{
		return null;
	}

	[Token(Token = "0x6014773")]
	[Address(RVA = "0x3276958", Offset = "0x3276958", VA = "0x3276958")]
	public void DebugGenerateFakeLatestRankInfo()
	{
	}

	[Token(Token = "0x6014774")]
	[Address(RVA = "0x3276C5C", Offset = "0x3276C5C", VA = "0x3276C5C", Slot = "14")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6014775")]
	[Address(RVA = "0x3276F9C", Offset = "0x3276F9C", VA = "0x3276F9C", Slot = "15")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6014777")]
	[Address(RVA = "0x3277088", Offset = "0x3277088", VA = "0x3277088")]
	public void SetSelectedLadderMap()
	{
	}

	[Token(Token = "0x6014778")]
	[Address(RVA = "0x32771F0", Offset = "0x32771F0", VA = "0x32771F0")]
	public void UpdateCurrentLadderMapOpeningInfo()
	{
	}

	[Token(Token = "0x6014779")]
	[Address(RVA = "0x3276E54", Offset = "0x3276E54", VA = "0x3276E54")]
	private void RefreshCurrentLadderMapAfterDownload()
	{
	}

	[Token(Token = "0x601477A")]
	[Address(RVA = "0x32785C8", Offset = "0x32785C8", VA = "0x32785C8")]
	public void SaveSelectedRankMaps(Dictionary<uint, bool> mapSelectDictory)
	{
	}

	[Token(Token = "0x601477B")]
	[Address(RVA = "0x3278AC0", Offset = "0x3278AC0", VA = "0x3278AC0")]
	public int GetSelectedMapCount()
	{
		return default(int);
	}

	[Token(Token = "0x601477C")]
	[Address(RVA = "0x3278B30", Offset = "0x3278B30", VA = "0x3278B30")]
	public bool RankMapHasSelected(uint mapID)
	{
		return default(bool);
	}

	[Token(Token = "0x601477D")]
	[Address(RVA = "0x32778B0", Offset = "0x32778B0", VA = "0x32778B0")]
	private void RefreshSelectedRankMap()
	{
	}

	[Token(Token = "0x601477E")]
	[Address(RVA = "0x3278C14", Offset = "0x3278C14", VA = "0x3278C14")]
	public uint[] GetSelectedRankingMaps()
	{
		return null;
	}

	[Token(Token = "0x601477F")]
	[Address(RVA = "0x327987C", Offset = "0x327987C", VA = "0x327987C")]
	public int GetMapsAddRP()
	{
		return default(int);
	}

	[Token(Token = "0x6014780")]
	[Address(RVA = "0x3274E48", Offset = "0x3274E48", VA = "0x3274E48")]
	private void GetSeasonData(uint season_id, uint rank_point)
	{
	}

	[Token(Token = "0x6014781")]
	[Address(RVA = "0x3275108", Offset = "0x3275108", VA = "0x3275108")]
	private void GetRankThresholdScore(uint seasonID, string region)
	{
	}

	[Token(Token = "0x6014782")]
	[Address(RVA = "0x3279A30", Offset = "0x3279A30", VA = "0x3279A30")]
	public void CheckPeakChanged()
	{
	}

	[Token(Token = "0x6014783")]
	[Address(RVA = "0x327A100", Offset = "0x327A100", VA = "0x327A100")]
	public string GetSeasonRewardBGUrl()
	{
		return null;
	}

	[Token(Token = "0x6014784")]
	[Address(RVA = "0x327A20C", Offset = "0x327A20C", VA = "0x327A20C")]
	public string GetCdnUrlSeasonAward()
	{
		return null;
	}

	[Token(Token = "0x6014785")]
	[Address(RVA = "0x327A318", Offset = "0x327A318", VA = "0x327A318")]
	public uint GetSeasonAwardId()
	{
		return default(uint);
	}

	[Token(Token = "0x6014786")]
	[Address(RVA = "0x327A3A8", Offset = "0x327A3A8", VA = "0x327A3A8")]
	public ResourceID GetResIdSpriteAwardRank(bool isPeak = false)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014787")]
	[Address(RVA = "0x327A570", Offset = "0x327A570", VA = "0x327A570")]
	public bool IsReachRankThreshold()
	{
		return default(bool);
	}

	[Token(Token = "0x6014788")]
	[Address(RVA = "0x327A630", Offset = "0x327A630", VA = "0x327A630")]
	public string GetCdnUrlSeasonBg()
	{
		return null;
	}

	[Token(Token = "0x6014789")]
	[Address(RVA = "0x327A73C", Offset = "0x327A73C", VA = "0x327A73C")]
	public void SetSeasonChangeData(uint seasonID, uint lastSeasonRank, uint lastSeasonRankPoint, uint seasonRank, uint seasonRankPoint, int currentPos, int currentThreshod, int lastPos, int lastThreshold)
	{
	}

	[Token(Token = "0x601478A")]
	[Address(RVA = "0x327A9E8", Offset = "0x327A9E8", VA = "0x327A9E8")]
	private static int _003CGetRankMasterLevelBySeasonID_003Em__0(RankMasterLevel a, RankMasterLevel b)
	{
		return default(int);
	}

	[Token(Token = "0x601478B")]
	[Address(RVA = "0x327AA30", Offset = "0x327AA30", VA = "0x327AA30")]
	private void _003CGetRankInfoFromServer_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601478C")]
	[Address(RVA = "0x327B148", Offset = "0x327B148", VA = "0x327B148")]
	private void _003CGetDailyMissionFromServer_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601478D")]
	[Address(RVA = "0x327B38C", Offset = "0x327B38C", VA = "0x327B38C")]
	private void _003CChooseRankCard_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601478E")]
	[Address(RVA = "0x327B680", Offset = "0x327B680", VA = "0x327B680")]
	private void _003CGetPlayerRankingSeasonStats_003Em__4(HttpErrorCode errodCode, object res)
	{
	}

	[Token(Token = "0x601478F")]
	[Address(RVA = "0x327BA18", Offset = "0x327BA18", VA = "0x327BA18")]
	private void _003CClaimRankingResetReward_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014790")]
	[Address(RVA = "0x327BAE0", Offset = "0x327BAE0", VA = "0x327BAE0")]
	private static void _003CSetSeasonChangeInfo_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014791")]
	[Address(RVA = "0x327BAE4", Offset = "0x327BAE4", VA = "0x327BAE4")]
	private static bool _003CCheckIsNeedRankComparePop_003Em__7(LeaderBoardInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x6014792")]
	[Address(RVA = "0x327BB10", Offset = "0x327BB10", VA = "0x327BB10")]
	private static bool _003CUpdateCurrentLadderMapOpeningInfo_003Em__8(MapOpeningInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014793")]
	[Address(RVA = "0x327BB40", Offset = "0x327BB40", VA = "0x327BB40")]
	private static bool _003CRefreshSelectedRankMap_003Em__9(MapOpeningInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014794")]
	[Address(RVA = "0x327BB70", Offset = "0x327BB70", VA = "0x327BB70")]
	private static bool _003CGetSelectedRankingMaps_003Em__A(MapOpeningInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014795")]
	[Address(RVA = "0x327BBA0", Offset = "0x327BBA0", VA = "0x327BBA0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014796")]
	[Address(RVA = "0x327BBA8", Offset = "0x327BBA8", VA = "0x327BBA8")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014797")]
	[Address(RVA = "0x327BBB0", Offset = "0x327BBB0", VA = "0x327BBB0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
