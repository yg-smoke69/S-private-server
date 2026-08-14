using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FD7")]
internal class UIModelCSLadderMatch : UIBaseModel
{
	[Token(Token = "0x2002FD8")]
	private sealed class _003CResquestCSRankMasterLevelInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012398")]
		[FieldOffset(Offset = "0x8")]
		internal uint seasonID;

		[Token(Token = "0x4012399")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCSLadderMatch _0024this;

		[Token(Token = "0x401239A")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<RankMasterLevel> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601401B")]
		[Address(RVA = "0x32CC4C8", Offset = "0x32CC4C8", VA = "0x32CC4C8")]
		public _003CResquestCSRankMasterLevelInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601401C")]
		[Address(RVA = "0x32D244C", Offset = "0x32D244C", VA = "0x32D244C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601401D")]
		[Address(RVA = "0x32D265C", Offset = "0x32D265C", VA = "0x32D265C")]
		private static int _003C_003Em__1(RankMasterLevel a, RankMasterLevel b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2002FD9")]
	private sealed class _003CRequestCsRankingInfoById_003Ec__AnonStorey1
	{
		[Token(Token = "0x401239B")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accoutid;

		[Token(Token = "0x401239C")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCSLadderMatch _0024this;

		[Token(Token = "0x601401E")]
		[Address(RVA = "0x32CCC28", Offset = "0x32CCC28", VA = "0x32CCC28")]
		public _003CRequestCsRankingInfoById_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x2002FDA")]
	private sealed class _003CRequestCSRankingStatsById_003Ec__AnonStorey2
	{
		[Token(Token = "0x401239D")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accoutid;

		[Token(Token = "0x401239E")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCSLadderMatch _0024this;

		[Token(Token = "0x601401F")]
		[Address(RVA = "0x32CE998", Offset = "0x32CE998", VA = "0x32CE998")]
		public _003CRequestCSRankingStatsById_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014020")]
		[Address(RVA = "0x32D1F3C", Offset = "0x32D1F3C", VA = "0x32D1F3C")]
		internal void _003C_003Em__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FDB")]
	private sealed class _003CGetCSPlayerStats_003Ec__AnonStorey3
	{
		[Token(Token = "0x401239F")]
		[FieldOffset(Offset = "0x8")]
		internal uint matchmode;

		[Token(Token = "0x40123A0")]
		[FieldOffset(Offset = "0x10")]
		internal ulong accoutid;

		[Token(Token = "0x40123A1")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelCSLadderMatch _0024this;

		[Token(Token = "0x6014021")]
		[Address(RVA = "0x32CEEFC", Offset = "0x32CEEFC", VA = "0x32CEEFC")]
		public _003CGetCSPlayerStats_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014022")]
		[Address(RVA = "0x32D1700", Offset = "0x32D1700", VA = "0x32D1700")]
		internal void _003C_003Em__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FDC")]
	private sealed class _003CGetRankThresholdScore_003Ec__AnonStorey4
	{
		[Token(Token = "0x40123A2")]
		[FieldOffset(Offset = "0x8")]
		internal bool isLastSeason;

		[Token(Token = "0x40123A3")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCSLadderMatch _0024this;

		[Token(Token = "0x6014023")]
		[Address(RVA = "0x32CF938", Offset = "0x32CF938", VA = "0x32CF938")]
		public _003CGetRankThresholdScore_003Ec__AnonStorey4()
		{
		}
	}

	[Token(Token = "0x2002FDD")]
	private sealed class _003CGetCSRank_003Ec__AnonStorey5
	{
		[Token(Token = "0x40123A4")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x6014024")]
		[Address(RVA = "0x32CFB84", Offset = "0x32CFB84", VA = "0x32CFB84")]
		public _003CGetCSRank_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014025")]
		[Address(RVA = "0x32D1EFC", Offset = "0x32D1EFC", VA = "0x32D1EFC")]
		internal bool _003C_003Em__0(LeaderBoardInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401236B")]
	public const string FIRST_TIME_ENTER_CS_RANK_KEY = "FirstTimeEnterCSRank";

	[Token(Token = "0x401236C")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSLadderSeasonInfo;

	[Token(Token = "0x401236D")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSLifeSeasonInfo;

	[Token(Token = "0x401236E")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<ulong, CSLadderSeasonStatsInfo> m_DictCSCommonSeasonInfo;

	[Token(Token = "0x401236F")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<ulong, CDTimeData> m_CSLadderInfoClickDic;

	[Token(Token = "0x4012370")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<ulong, CDTimeData> m_CSLadderCommonInfoClickDic;

	[Token(Token = "0x4012371")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, CDTimeData> m_CSLadderLifeInfoClickDic;

	[Token(Token = "0x4012372")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<ulong, CDTimeData> m_CSLadderRankingProfileClickDic;

	[Token(Token = "0x4012373")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, CSLadderRankInfo> m_CsLadderRankInfo;

	[Token(Token = "0x4012374")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, CSRankTopAwardsDesc> m_CSRankTopAwardDic;

	[Token(Token = "0x4012375")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, List<RankMasterLevel>> m_CSRankMasterLevelDic;

	[Token(Token = "0x4012376")]
	[FieldOffset(Offset = "0x34")]
	private CDTimeData rankinfoclick;

	[Token(Token = "0x4012377")]
	[FieldOffset(Offset = "0x38")]
	private int m_CSPlayerRankingSeasonStatsDelta;

	[Token(Token = "0x4012378")]
	[FieldOffset(Offset = "0x3C")]
	private int m_CSPlayerRankInfoDelat;

	[Token(Token = "0x4012379")]
	[FieldOffset(Offset = "0x40")]
	private CSLadderSeasonStatsInfo m_CSLadderSeasonInfo;

	[Token(Token = "0x401237A")]
	[FieldOffset(Offset = "0x44")]
	private List<uint> m_AwardsExhibitIDList;

	[Token(Token = "0x401237B")]
	[FieldOffset(Offset = "0x48")]
	private List<uint> m_ExchangeExhibitIDlist;

	[Token(Token = "0x401237C")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_InitRank;

	[Token(Token = "0x401237D")]
	[FieldOffset(Offset = "0x50")]
	private CSLadderRankInfo m_CurrentCSRankInfo;

	[Token(Token = "0x401237E")]
	[FieldOffset(Offset = "0x54")]
	public CSRankingInfo LastSeasonRankInfo;

	[Token(Token = "0x401237F")]
	[FieldOffset(Offset = "0x58")]
	public List<CSRankData> CSRankUpRewardList;

	[Token(Token = "0x4012380")]
	[FieldOffset(Offset = "0x5C")]
	public int LastPeakRankPos;

	[Token(Token = "0x4012381")]
	[FieldOffset(Offset = "0x60")]
	private CSGetCurrentOrRecentCSRankingSeasonConfigRes m_CurrentOrRecentCsRankingSeasonConfig;

	[Token(Token = "0x4012382")]
	[FieldOffset(Offset = "0x64")]
	private List<LeaderBoardInfo> m_LeaderBoardRegionList;

	[Token(Token = "0x4012383")]
	[FieldOffset(Offset = "0x68")]
	private List<LeaderBoardInfo> m_LadderBoardFriendList;

	[Token(Token = "0x4012384")]
	[FieldOffset(Offset = "0x6C")]
	private LeaderBoardInfo m_PlayerLeaderBoardRegion;

	[Token(Token = "0x4012385")]
	[FieldOffset(Offset = "0x70")]
	private LeaderBoardInfo m_PlayerLeaderBoardFriend;

	[Token(Token = "0x4012386")]
	[FieldOffset(Offset = "0x74")]
	private float m_NextReqLeadderBoardTime;

	[Token(Token = "0x4012387")]
	[FieldOffset(Offset = "0x78")]
	private float m_NextReqFriendBoardTime;

	[Token(Token = "0x4012388")]
	[FieldOffset(Offset = "0x80")]
	private double m_CSPeakRankThreshold;

	[Token(Token = "0x4012389")]
	[FieldOffset(Offset = "0x88")]
	private double LastPeakRankThreshold;

	[Token(Token = "0x401238A")]
	[FieldOffset(Offset = "0x90")]
	public bool isLastReachPeakRank;

	[Token(Token = "0x401238B")]
	public const uint PropID_CSSeasonStatsRefresh = 2u;

	[Token(Token = "0x401238C")]
	public const uint PropID_CSRankInfoRefreshed = 4u;

	[Token(Token = "0x401238D")]
	public const uint PropID_CSRankSeasonInfoRefreshed = 8u;

	[Token(Token = "0x401238E")]
	public const uint PropID_CSLifeSeasonStatsRefresh = 16u;

	[Token(Token = "0x401238F")]
	public const uint PropID_CSCommonSeasonStatsRefresh = 32u;

	[Token(Token = "0x4012390")]
	public const uint PropID_CSRankingStatsRefresh = 64u;

	[Token(Token = "0x4012391")]
	public const uint PropID_CSLeaderBoardFriend = 128u;

	[Token(Token = "0x4012392")]
	public const uint PropID_CSLeaderBoardScore = 256u;

	[Token(Token = "0x4012393")]
	public const uint PropID_CSPeakRankPosRefresh = 512u;

	[Token(Token = "0x4012394")]
	public const uint PropID_CSResetMatchRewardClaimSuccess = 1024u;

	[Token(Token = "0x4012395")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<LeaderBoardInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012396")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012397")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<LeaderBoardInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x170014B3")]
	public bool IsResetMatchRewardClaimable
	{
		[Token(Token = "0x6013FC7")]
		[Address(RVA = "0x32C9950", Offset = "0x32C9950", VA = "0x32C9950")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014B4")]
	public CSLadderSeasonStatsInfo CSLadderSeasonStatsInfo
	{
		[Token(Token = "0x6013FCC")]
		[Address(RVA = "0x32CA0A4", Offset = "0x32CA0A4", VA = "0x32CA0A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014B5")]
	public CSLadderRankInfo CurrentCsRankInfo
	{
		[Token(Token = "0x6013FCE")]
		[Address(RVA = "0x32CA1C4", Offset = "0x32CA1C4", VA = "0x32CA1C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014B6")]
	public List<RankMasterLevel> CSRankMasterLevel
	{
		[Token(Token = "0x6013FCF")]
		[Address(RVA = "0x32CA28C", Offset = "0x32CA28C", VA = "0x32CA28C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014B7")]
	public Dictionary<uint, CSRankTopAwardsDesc> RankTopAwardDic
	{
		[Token(Token = "0x6013FD0")]
		[Address(RVA = "0x32CA388", Offset = "0x32CA388", VA = "0x32CA388")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014B8")]
	public int CurrentPeakRankPos
	{
		[Token(Token = "0x6013FDF")]
		[Address(RVA = "0x32CB6A4", Offset = "0x32CB6A4", VA = "0x32CB6A4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014B9")]
	public bool ShowCSRankUpReward
	{
		[Token(Token = "0x6013FE0")]
		[Address(RVA = "0x32CB734", Offset = "0x32CB734", VA = "0x32CB734")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6013FC6")]
	[Address(RVA = "0x32C9670", Offset = "0x32C9670", VA = "0x32C9670")]
	public UIModelCSLadderMatch()
	{
	}

	[Token(Token = "0x6013FC8")]
	[Address(RVA = "0x32C9B5C", Offset = "0x32C9B5C", VA = "0x32C9B5C")]
	public bool IsResetMatchRewardVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6013FC9")]
	[Address(RVA = "0x32C9D08", Offset = "0x32C9D08", VA = "0x32C9D08")]
	public List<uint> GetAwardsExhibitIDList()
	{
		return null;
	}

	[Token(Token = "0x6013FCA")]
	[Address(RVA = "0x32C9D60", Offset = "0x32C9D60", VA = "0x32C9D60")]
	public List<uint> GetExchangeExhibitIDList()
	{
		return null;
	}

	[Token(Token = "0x6013FCB")]
	[Address(RVA = "0x32C9DB8", Offset = "0x32C9DB8", VA = "0x32C9DB8")]
	public void UpdateSeasonChangeAwardConfig(CSGetCurrentOrRecentCSRankingSeasonConfigRes season_info_res)
	{
	}

	[Token(Token = "0x6013FCD")]
	[Address(RVA = "0x32CA16C", Offset = "0x32CA16C", VA = "0x32CA16C")]
	public uint GetNewSeasonInitRank()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FD1")]
	[Address(RVA = "0x32CA3E0", Offset = "0x32CA3E0", VA = "0x32CA3E0")]
	public void SetRankTopAwardDic(List<CSRankTopAwardsDesc> desc)
	{
	}

	[Token(Token = "0x6013FD2")]
	[Address(RVA = "0x32CA5D0", Offset = "0x32CA5D0", VA = "0x32CA5D0")]
	public void SetHasPlayerEnterCSRankLobbyKey(bool value)
	{
	}

	[Token(Token = "0x6013FD3")]
	[Address(RVA = "0x32CA828", Offset = "0x32CA828", VA = "0x32CA828")]
	public bool HasPlayerEnterCSRankLobbyBefore()
	{
		return default(bool);
	}

	[Token(Token = "0x6013FD4")]
	[Address(RVA = "0x32CAA74", Offset = "0x32CAA74", VA = "0x32CAA74")]
	public bool IsCurrentSeasonOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6013FD5")]
	[Address(RVA = "0x32C9AF4", Offset = "0x32C9AF4", VA = "0x32C9AF4")]
	public CSRankingSeasonInfoDesc GetCurrentSeasonInfo()
	{
		return null;
	}

	[Token(Token = "0x6013FD6")]
	[Address(RVA = "0x32CABD8", Offset = "0x32CABD8", VA = "0x32CABD8")]
	public string GetSeasonRewardBGUrl()
	{
		return null;
	}

	[Token(Token = "0x6013FD7")]
	[Address(RVA = "0x32CACE4", Offset = "0x32CACE4", VA = "0x32CACE4")]
	public string GetCdnUrlSeasonAward()
	{
		return null;
	}

	[Token(Token = "0x6013FD8")]
	[Address(RVA = "0x32CADD0", Offset = "0x32CADD0", VA = "0x32CADD0")]
	public uint GetSeasonAwardId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FD9")]
	[Address(RVA = "0x32CAE40", Offset = "0x32CAE40", VA = "0x32CAE40")]
	public ResourceID GetResIdSpriteAwardRank(bool isPeak = false)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6013FDA")]
	[Address(RVA = "0x32CAFF0", Offset = "0x32CAFF0", VA = "0x32CAFF0")]
	public bool IsReachRankThreshold()
	{
		return default(bool);
	}

	[Token(Token = "0x6013FDB")]
	[Address(RVA = "0x32CB0A4", Offset = "0x32CB0A4", VA = "0x32CB0A4")]
	public string GetCdnUrlSeasonBg()
	{
		return null;
	}

	[Token(Token = "0x6013FDC")]
	[Address(RVA = "0x32CB190", Offset = "0x32CB190", VA = "0x32CB190")]
	public void UpdateSeasonInfoConfig(CSGetCurrentOrRecentCSRankingSeasonConfigRes season_info_res)
	{
	}

	[Token(Token = "0x6013FDD")]
	[Address(RVA = "0x32CB48C", Offset = "0x32CB48C", VA = "0x32CB48C")]
	public List<AwardDesc> GetCSRankAwardList(uint rank)
	{
		return null;
	}

	[Token(Token = "0x6013FDE")]
	[Address(RVA = "0x32CB614", Offset = "0x32CB614", VA = "0x32CB614")]
	public uint GetCurrentStarProtectPoints()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FE1")]
	[Address(RVA = "0x32CB7FC", Offset = "0x32CB7FC", VA = "0x32CB7FC")]
	public void InitCSRankUpRewardData(uint rank_before, uint rank_after)
	{
	}

	[Token(Token = "0x6013FE2")]
	[Address(RVA = "0x32CB998", Offset = "0x32CB998", VA = "0x32CB998", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FE3")]
	[Address(RVA = "0x32CB9F0", Offset = "0x32CB9F0", VA = "0x32CB9F0", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013FE4")]
	[Address(RVA = "0x32CBBFC", Offset = "0x32CBBFC", VA = "0x32CBBFC")]
	public bool IsLastSeasonPeakRank(uint peakRankPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6013FE5")]
	[Address(RVA = "0x32CBDBC", Offset = "0x32CBDBC", VA = "0x32CBDBC")]
	public bool IsPeakRank(uint peakRankPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6013FE6")]
	[Address(RVA = "0x32CBF48", Offset = "0x32CBF48", VA = "0x32CBF48")]
	public bool IsCurrentPeakRank()
	{
		return default(bool);
	}

	[Token(Token = "0x6013FE7")]
	[Address(RVA = "0x32CBFE0", Offset = "0x32CBFE0", VA = "0x32CBFE0")]
	public int PeakRankScore()
	{
		return default(int);
	}

	[Token(Token = "0x6013FE8")]
	[Address(RVA = "0x32CC13C", Offset = "0x32CC13C", VA = "0x32CC13C")]
	public int GetGamePlayedTimes()
	{
		return default(int);
	}

	[Token(Token = "0x6013FE9")]
	[Address(RVA = "0x32CC1C4", Offset = "0x32CC1C4", VA = "0x32CC1C4")]
	public void GetCurOrRecentCSRankingConfig()
	{
	}

	[Token(Token = "0x6013FEA")]
	[Address(RVA = "0x32CC218", Offset = "0x32CC218", VA = "0x32CC218")]
	private void ResquestCSRankMasterLevelInfo(uint seasonID, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013FEB")]
	[Address(RVA = "0x32CC4D0", Offset = "0x32CC4D0", VA = "0x32CC4D0")]
	public int GetCurrentRankMasterLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6013FEC")]
	[Address(RVA = "0x32CC7FC", Offset = "0x32CC7FC", VA = "0x32CC7FC")]
	public int GetLastRankMasterLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6013FED")]
	[Address(RVA = "0x32CC53C", Offset = "0x32CC53C", VA = "0x32CC53C")]
	private int GetMasterLevelByPeakRankPos(int peakRankPos)
	{
		return default(int);
	}

	[Token(Token = "0x6013FEE")]
	[Address(RVA = "0x32CC860", Offset = "0x32CC860", VA = "0x32CC860")]
	public int GetRankMasterLevel(int position)
	{
		return default(int);
	}

	[Token(Token = "0x6013FEF")]
	[Address(RVA = "0x32CCB20", Offset = "0x32CCB20", VA = "0x32CCB20")]
	public void RequestCsRankingInfoById(ulong accoutid)
	{
	}

	[Token(Token = "0x6013FF0")]
	[Address(RVA = "0x32CCC30", Offset = "0x32CCC30", VA = "0x32CCC30")]
	public CSLadderRankInfo GetCsRankingInfoById(ulong accoutid)
	{
		return null;
	}

	[Token(Token = "0x6013FF1")]
	[Address(RVA = "0x32CCD2C", Offset = "0x32CCD2C", VA = "0x32CCD2C")]
	public CSGetCurrentOrRecentCSRankingSeasonConfigRes GetFromCurOrRecentCSRankingConfig()
	{
		return null;
	}

	[Token(Token = "0x6013FF2")]
	[Address(RVA = "0x32CCD84", Offset = "0x32CCD84", VA = "0x32CCD84")]
	public void SetCurOrRecentCSRankingConfig(CSGetCurrentOrRecentCSRankingSeasonConfigRes res, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013FF3")]
	[Address(RVA = "0x32CD05C", Offset = "0x32CD05C", VA = "0x32CD05C")]
	public void InitPlayerCSRankingInfo(bool silence = false)
	{
	}

	[Token(Token = "0x6013FF4")]
	[Address(RVA = "0x32CD33C", Offset = "0x32CD33C", VA = "0x32CD33C")]
	public void ReRequestCsRankingsInfo()
	{
	}

	[Token(Token = "0x6013FF5")]
	[Address(RVA = "0x32CD3D8", Offset = "0x32CD3D8", VA = "0x32CD3D8")]
	public void GetPlayerCSRankingInfo(bool inmiditely = false)
	{
	}

	[Token(Token = "0x6013FF6")]
	[Address(RVA = "0x32CD434", Offset = "0x32CD434", VA = "0x32CD434")]
	public uint GetCurrentCSRank()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FF7")]
	[Address(RVA = "0x32CD4C4", Offset = "0x32CD4C4", VA = "0x32CD4C4")]
	public uint GetCurrentCSRankingPoints()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FF8")]
	[Address(RVA = "0x32CD554", Offset = "0x32CD554", VA = "0x32CD554")]
	public void UpdateUnlockRewardRedTips()
	{
	}

	[Token(Token = "0x6013FF9")]
	[Address(RVA = "0x32CD65C", Offset = "0x32CD65C", VA = "0x32CD65C")]
	public void UpdateGamePlay(uint cnt)
	{
	}

	[Token(Token = "0x6013FFA")]
	[Address(RVA = "0x32CD7B8", Offset = "0x32CD7B8", VA = "0x32CD7B8")]
	public void ClaimRankingResetReward()
	{
	}

	[Token(Token = "0x6013FFB")]
	[Address(RVA = "0x32CD9DC", Offset = "0x32CD9DC", VA = "0x32CD9DC")]
	private CSRankData GetCurrentCSRankData()
	{
		return null;
	}

	[Token(Token = "0x6013FFC")]
	[Address(RVA = "0x32CDAE0", Offset = "0x32CDAE0", VA = "0x32CDAE0")]
	public uint GetCurrentStars()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FFD")]
	[Address(RVA = "0x32CDB70", Offset = "0x32CDB70", VA = "0x32CDB70")]
	public uint GetCurrentLevelRankUpStar()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FFE")]
	[Address(RVA = "0x32CDBE0", Offset = "0x32CDBE0", VA = "0x32CDBE0")]
	public string GetCurrentLevelRankName()
	{
		return null;
	}

	[Token(Token = "0x6013FFF")]
	[Address(RVA = "0x32CDD60", Offset = "0x32CDD60", VA = "0x32CDD60")]
	public ResourceID GetCurrentLevelRankIcon(LadderRankIconType iconType)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014000")]
	[Address(RVA = "0x32CDEB4", Offset = "0x32CDEB4", VA = "0x32CDEB4")]
	public ResourceID GetCSRankIcon(int rank, int peakRankPos, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014001")]
	[Address(RVA = "0x32CE0F0", Offset = "0x32CE0F0", VA = "0x32CE0F0")]
	public CSLadderSeasonStatsInfo GetPlayerLadderSeasonStats()
	{
		return null;
	}

	[Token(Token = "0x6014002")]
	[Address(RVA = "0x32CE398", Offset = "0x32CE398", VA = "0x32CE398")]
	public void RequestPlayerCSRankingSeasonStats()
	{
	}

	[Token(Token = "0x6014003")]
	[Address(RVA = "0x32CE85C", Offset = "0x32CE85C", VA = "0x32CE85C")]
	public void RequestPlayerCSRankInfo()
	{
	}

	[Token(Token = "0x6014004")]
	[Address(RVA = "0x32CE234", Offset = "0x32CE234", VA = "0x32CE234")]
	public CSLadderSeasonStatsInfo GetCSLadderSeasonInfoData(ulong accoutid, uint matchmode)
	{
		return null;
	}

	[Token(Token = "0x6014005")]
	[Address(RVA = "0x32CE4D4", Offset = "0x32CE4D4", VA = "0x32CE4D4")]
	public void RequestCSRankingStatsById(ulong accoutid)
	{
	}

	[Token(Token = "0x6014006")]
	[Address(RVA = "0x32CE9A0", Offset = "0x32CE9A0", VA = "0x32CE9A0")]
	public void GetCSPlayerStats(ulong accoutid, uint matchmode, bool inmiditely = false)
	{
	}

	[Token(Token = "0x6014007")]
	[Address(RVA = "0x32CEF04", Offset = "0x32CEF04", VA = "0x32CEF04")]
	public List<LeaderBoardInfo> GetFriendBoardScoreList()
	{
		return null;
	}

	[Token(Token = "0x6014008")]
	[Address(RVA = "0x32CEF5C", Offset = "0x32CEF5C", VA = "0x32CEF5C")]
	public LeaderBoardInfo GetLocalPlayerBoardRegion()
	{
		return null;
	}

	[Token(Token = "0x6014009")]
	[Address(RVA = "0x32CEFB4", Offset = "0x32CEFB4", VA = "0x32CEFB4")]
	public List<LeaderBoardInfo> GetRegionBoardScoreList()
	{
		return null;
	}

	[Token(Token = "0x601400A")]
	[Address(RVA = "0x32CF00C", Offset = "0x32CF00C", VA = "0x32CF00C")]
	public LeaderBoardInfo GetLocalPlayerBoardFriend()
	{
		return null;
	}

	[Token(Token = "0x601400B")]
	[Address(RVA = "0x32CF064", Offset = "0x32CF064", VA = "0x32CF064")]
	public void RequestCSLeaderBoardFriend()
	{
	}

	[Token(Token = "0x601400C")]
	[Address(RVA = "0x32CF54C", Offset = "0x32CF54C", VA = "0x32CF54C")]
	public void RequestCSLeaderBoardRegion()
	{
	}

	[Token(Token = "0x601400D")]
	[Address(RVA = "0x32CCF54", Offset = "0x32CCF54", VA = "0x32CCF54")]
	private void GetRankThresholdScore(uint seasonID, string region, bool isLastSeason = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601400E")]
	[Address(RVA = "0x32CF940", Offset = "0x32CF940", VA = "0x32CF940")]
	public float GetKDANum()
	{
		return default(float);
	}

	[Token(Token = "0x601400F")]
	[Address(RVA = "0x32CA7B4", Offset = "0x32CA7B4", VA = "0x32CA7B4")]
	public uint GetRealSeasonID()
	{
		return default(uint);
	}

	[Token(Token = "0x6014010")]
	[Address(RVA = "0x32CF9EC", Offset = "0x32CF9EC", VA = "0x32CF9EC")]
	public int GetCSRank(ulong accountID)
	{
		return default(int);
	}

	[Token(Token = "0x6014011")]
	[Address(RVA = "0x32CFB8C", Offset = "0x32CFB8C", VA = "0x32CFB8C")]
	public void SetSeasonChangeData(uint seasonID, uint lastSeasonRank, uint lastSeasonRankPoint, uint seasonRank, uint seasonRankPoint, int currentPos, int currentThreshod, int lastPos, int lastThreshold)
	{
	}

	[Token(Token = "0x6014012")]
	[Address(RVA = "0x32CFD7C", Offset = "0x32CFD7C", VA = "0x32CFD7C")]
	public void CheckPeakChanged()
	{
	}

	[Token(Token = "0x6014013")]
	[Address(RVA = "0x32D0610", Offset = "0x32D0610", VA = "0x32D0610")]
	private void _003CInitPlayerCSRankingInfo_003Em__0(HttpErrorCode errodCode, object res)
	{
	}

	[Token(Token = "0x6014014")]
	[Address(RVA = "0x32D0A44", Offset = "0x32D0A44", VA = "0x32D0A44")]
	private void _003CClaimRankingResetReward_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014015")]
	[Address(RVA = "0x32D0AEC", Offset = "0x32D0AEC", VA = "0x32D0AEC")]
	private void _003CRequestCSLeaderBoardFriend_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014016")]
	[Address(RVA = "0x32D11C0", Offset = "0x32D11C0", VA = "0x32D11C0")]
	private static int _003CRequestCSLeaderBoardFriend_003Em__3(LeaderBoardInfo x, LeaderBoardInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x6014017")]
	[Address(RVA = "0x32D1240", Offset = "0x32D1240", VA = "0x32D1240")]
	private void _003CRequestCSLeaderBoardRegion_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014018")]
	[Address(RVA = "0x32D154C", Offset = "0x32D154C", VA = "0x32D154C")]
	private static int _003CRequestCSLeaderBoardFriend_003Em__5(FriendAccountInfo x, FriendAccountInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x6014019")]
	[Address(RVA = "0x32D15F4", Offset = "0x32D15F4", VA = "0x32D15F4")]
	private static bool _003CRequestCSLeaderBoardRegion_003Em__6(LeaderBoardInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x601401A")]
	[Address(RVA = "0x32D16F8", Offset = "0x32D16F8", VA = "0x32D16F8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
