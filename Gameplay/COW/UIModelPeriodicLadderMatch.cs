using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031CA")]
public class UIModelPeriodicLadderMatch : UIBaseModel, _Attribute
{
	[Token(Token = "0x20031CB")]
	private sealed class _003CRequestRankingInfoById_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012F58")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accoutid;

		[Token(Token = "0x4012F59")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelPeriodicLadderMatch _0024this;

		[Token(Token = "0x6015020")]
		[Address(RVA = "0x31C8F8C", Offset = "0x31C8F8C", VA = "0x31C8F8C")]
		public _003CRequestRankingInfoById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015021")]
		[Address(RVA = "0x31CACC8", Offset = "0x31CACC8", VA = "0x31CACC8")]
		internal void _003C_003Em__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	[Token(Token = "0x4012F3E")]
	public const string FIRST_TIME_ENTER_LW_RANK_KEY = "FirstTimeEnterLWRank";

	[Token(Token = "0x4012F3F")]
	[FieldOffset(Offset = "0xC")]
	private CSGetCurOrRecentPeriodicRankingConfigRes CurOrRecentRankingSeasonConfig;

	[Token(Token = "0x4012F40")]
	[FieldOffset(Offset = "0x10")]
	public CSPlayerPeriodicRankingInfoRes CurrentRankInfo;

	[Token(Token = "0x4012F41")]
	[FieldOffset(Offset = "0x14")]
	private CDTimeData m_CdTimeData;

	[Token(Token = "0x4012F42")]
	[FieldOffset(Offset = "0x18")]
	private int m_CdOfReqRankInfo;

	[Token(Token = "0x4012F43")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<ulong, CDTimeData> m_LadderRankingProfileClickDic;

	[Token(Token = "0x4012F44")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, CSPlayerPeriodicRankingInfoRes> m_DictRankInfo;

	[Token(Token = "0x4012F45")]
	[FieldOffset(Offset = "0x24")]
	private float m_NextReqFriendBoardTime;

	[Token(Token = "0x4012F46")]
	[FieldOffset(Offset = "0x28")]
	private float m_NextReqRegionBoardTime;

	[Token(Token = "0x4012F47")]
	[FieldOffset(Offset = "0x2C")]
	private List<LeaderBoardInfo> m_LadderBoardFriendList;

	[Token(Token = "0x4012F48")]
	[FieldOffset(Offset = "0x30")]
	private List<LeaderBoardInfo> m_LadderBoardRegionList;

	[Token(Token = "0x4012F49")]
	[FieldOffset(Offset = "0x34")]
	private LeaderBoardInfo m_PlayerLeaderBoardFriend;

	[Token(Token = "0x4012F4A")]
	[FieldOffset(Offset = "0x38")]
	private LeaderBoardInfo m_PlayerLeaderBoardRegion;

	[Token(Token = "0x4012F4B")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_ReRequestedSeasonConfig;

	[Token(Token = "0x4012F4C")]
	public const string PERIODIC_RANK_MAP_SELECT = "periodic_rank_map_select";

	[Token(Token = "0x4012F4D")]
	[FieldOffset(Offset = "0x40")]
	private List<uint> m_CurrentAvailableSelectedMapIDList;

	[Token(Token = "0x4012F4E")]
	[FieldOffset(Offset = "0x44")]
	public List<PeriodicRankData> PeriodicRankUpRewardList;

	[Token(Token = "0x4012F4F")]
	public const uint PropID_RankInfoRefreshed = 4u;

	[Token(Token = "0x4012F50")]
	public const uint PropID_SeasonInfoRefreshed = 8u;

	[Token(Token = "0x4012F51")]
	public const uint PropID_RefreshLeaderBoardFriend = 128u;

	[Token(Token = "0x4012F52")]
	public const uint PropID_RefreshLeaderBoardRegion = 256u;

	[Token(Token = "0x4012F53")]
	public const uint PropID_PeriodicRankMapSelectConfirmed = 1024u;

	[Token(Token = "0x4012F54")]
	public const uint PropID_PeriodicResetMatchRewardClaimSuccess = 2048u;

	[Token(Token = "0x4012F55")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<LeaderBoardInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012F56")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<LeaderBoardInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012F57")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x17001626")]
	public bool IsResetMatchRewardClaimable
	{
		[Token(Token = "0x6014FD9")]
		[Address(RVA = "0x31C4704", Offset = "0x31C4704", VA = "0x31C4704")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001627")]
	public List<uint> CurrentAvailableSelectedMapIDList
	{
		[Token(Token = "0x6014FDB")]
		[Address(RVA = "0x31C4ABC", Offset = "0x31C4ABC", VA = "0x31C4ABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001628")]
	public bool ShowPeriodicRankUpReward
	{
		[Token(Token = "0x6014FDC")]
		[Address(RVA = "0x31C4B14", Offset = "0x31C4B14", VA = "0x31C4B14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6014FD8")]
	[Address(RVA = "0x31C455C", Offset = "0x31C455C", VA = "0x31C455C")]
	public UIModelPeriodicLadderMatch()
	{
	}

	[Token(Token = "0x6014FDA")]
	[Address(RVA = "0x31C4910", Offset = "0x31C4910", VA = "0x31C4910")]
	public bool IsResetMatchRewardVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6014FDD")]
	[Address(RVA = "0x31C4BDC", Offset = "0x31C4BDC", VA = "0x31C4BDC")]
	public bool IsPeriodicRankMapSelected(uint mapID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014FDE")]
	[Address(RVA = "0x31C4D04", Offset = "0x31C4D04", VA = "0x31C4D04")]
	private void RefreshCurrentPeriodicLadderMapAfterDownload()
	{
	}

	[Token(Token = "0x6014FDF")]
	[Address(RVA = "0x31C56E4", Offset = "0x31C56E4", VA = "0x31C56E4")]
	public void UpdateGamePlay(uint cnt)
	{
	}

	[Token(Token = "0x6014FE0")]
	[Address(RVA = "0x31C5948", Offset = "0x31C5948", VA = "0x31C5948")]
	public void SaveSelectedRankMaps(Dictionary<uint, bool> mapSelectDictory)
	{
	}

	[Token(Token = "0x6014FE1")]
	[Address(RVA = "0x31C5E40", Offset = "0x31C5E40", VA = "0x31C5E40")]
	public void AddTemporaryMapIDToSelectedMapIDList(uint id)
	{
	}

	[Token(Token = "0x6014FE2")]
	[Address(RVA = "0x31C4E4C", Offset = "0x31C4E4C", VA = "0x31C4E4C")]
	public void UpdateCurrentAvailableSelectedMapIDList()
	{
	}

	[Token(Token = "0x6014FE3")]
	[Address(RVA = "0x31C5F38", Offset = "0x31C5F38", VA = "0x31C5F38", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FE4")]
	[Address(RVA = "0x31C5F90", Offset = "0x31C5F90", VA = "0x31C5F90", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014FE5")]
	[Address(RVA = "0x31C6144", Offset = "0x31C6144", VA = "0x31C6144")]
	public bool HasPlayerEnterPeriodicRankLobbyBefore()
	{
		return default(bool);
	}

	[Token(Token = "0x6014FE6")]
	[Address(RVA = "0x31C638C", Offset = "0x31C638C", VA = "0x31C638C")]
	public void SetHasPlayerEnterPeriodicRankLobbyKey(bool value)
	{
	}

	[Token(Token = "0x6014FE7")]
	[Address(RVA = "0x31C656C", Offset = "0x31C656C", VA = "0x31C656C")]
	public void InitCSRankUpRewardData(uint rank_before, uint rank_after)
	{
	}

	[Token(Token = "0x6014FE8")]
	[Address(RVA = "0x31C48A8", Offset = "0x31C48A8", VA = "0x31C48A8")]
	public PeriodicRankingSeasonInfoDesc GetCurrentSeasonInfo()
	{
		return null;
	}

	[Token(Token = "0x6014FE9")]
	[Address(RVA = "0x31C6708", Offset = "0x31C6708", VA = "0x31C6708")]
	private PeriodicRankData GetCurrentRankData()
	{
		return null;
	}

	[Token(Token = "0x6014FEA")]
	[Address(RVA = "0x31C6878", Offset = "0x31C6878", VA = "0x31C6878")]
	public PeriodicRankingInfo GetLastSeasonRankInfo()
	{
		return null;
	}

	[Token(Token = "0x6014FEB")]
	[Address(RVA = "0x31C680C", Offset = "0x31C680C", VA = "0x31C680C")]
	public uint GetCurrentRank()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FEC")]
	[Address(RVA = "0x31C68E4", Offset = "0x31C68E4", VA = "0x31C68E4")]
	public string GetCurrentLevelRankName()
	{
		return null;
	}

	[Token(Token = "0x6014FED")]
	[Address(RVA = "0x31C69D0", Offset = "0x31C69D0", VA = "0x31C69D0")]
	public uint GetCurrentLevelRankUpStar()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FEE")]
	[Address(RVA = "0x31C5840", Offset = "0x31C5840", VA = "0x31C5840")]
	public void UpdateUnlockRewardRedTips()
	{
	}

	[Token(Token = "0x6014FEF")]
	[Address(RVA = "0x31C6A40", Offset = "0x31C6A40", VA = "0x31C6A40")]
	public uint GetCurrentRankingPoints()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FF0")]
	[Address(RVA = "0x31C6AAC", Offset = "0x31C6AAC", VA = "0x31C6AAC")]
	public void ClaimRankingResetReward()
	{
	}

	[Token(Token = "0x6014FF1")]
	[Address(RVA = "0x31C6CD0", Offset = "0x31C6CD0", VA = "0x31C6CD0")]
	public uint GetCurrentLevelDeltaRankingPoints()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FF2")]
	[Address(RVA = "0x31C6D54", Offset = "0x31C6D54", VA = "0x31C6D54")]
	public uint GetCurrentStarProtectPoints()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FF3")]
	[Address(RVA = "0x31C6DC0", Offset = "0x31C6DC0", VA = "0x31C6DC0")]
	public uint GetCurrentStars()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FF4")]
	[Address(RVA = "0x31C6E2C", Offset = "0x31C6E2C", VA = "0x31C6E2C")]
	public uint GetRealSeasonID()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FF5")]
	[Address(RVA = "0x31C6EA0", Offset = "0x31C6EA0", VA = "0x31C6EA0")]
	public ResourceID GetCurrentLevelRankIcon(LadderRankIconType iconType)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014FF6")]
	[Address(RVA = "0x31C6FA0", Offset = "0x31C6FA0", VA = "0x31C6FA0")]
	public ResourceID GetRankIcon(int rank, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014FF7")]
	[Address(RVA = "0x31C7124", Offset = "0x31C7124", VA = "0x31C7124")]
	public bool IsDuringSeasonOpenTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6014FF8")]
	[Address(RVA = "0x31C723C", Offset = "0x31C723C", VA = "0x31C723C")]
	public bool IsDuringPerdictTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6014FF9")]
	[Address(RVA = "0x31C7354", Offset = "0x31C7354", VA = "0x31C7354")]
	public uint GetCurrentSeasonGameMode()
	{
		return default(uint);
	}

	[Token(Token = "0x6014FFA")]
	[Address(RVA = "0x31C73C4", Offset = "0x31C73C4", VA = "0x31C73C4")]
	public int GetUnlockLevel(bool isMember = false, bool isMemberGuest = false)
	{
		return default(int);
	}

	[Token(Token = "0x6014FFB")]
	[Address(RVA = "0x31C75BC", Offset = "0x31C75BC", VA = "0x31C75BC")]
	public bool IsLevelEnough()
	{
		return default(bool);
	}

	[Token(Token = "0x6014FFC")]
	[Address(RVA = "0x31C7718", Offset = "0x31C7718", VA = "0x31C7718")]
	public string GetSeasonRewardBGUrl()
	{
		return null;
	}

	[Token(Token = "0x6014FFD")]
	[Address(RVA = "0x31C7824", Offset = "0x31C7824", VA = "0x31C7824")]
	public string GetCdnUrlSeasonAward()
	{
		return null;
	}

	[Token(Token = "0x6014FFE")]
	[Address(RVA = "0x31C7910", Offset = "0x31C7910", VA = "0x31C7910")]
	public ResourceID GetResIdSpriteAwardRank(bool isPeak = false)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014FFF")]
	[Address(RVA = "0x31C7AC0", Offset = "0x31C7AC0", VA = "0x31C7AC0")]
	public bool IsReachRankThreshold()
	{
		return default(bool);
	}

	[Token(Token = "0x6015000")]
	[Address(RVA = "0x31C7B4C", Offset = "0x31C7B4C", VA = "0x31C7B4C")]
	public CSPlayerPeriodicRankingInfoRes GetRankingInfoById(ulong accountId)
	{
		return null;
	}

	[Token(Token = "0x6015001")]
	[Address(RVA = "0x31C7C58", Offset = "0x31C7C58", VA = "0x31C7C58")]
	public float GetKDANum()
	{
		return default(float);
	}

	[Token(Token = "0x6015002")]
	[Address(RVA = "0x31C7CF4", Offset = "0x31C7CF4", VA = "0x31C7CF4")]
	public List<PeriodicRankAwardsDesc> GetRankAllAwardsList()
	{
		return null;
	}

	[Token(Token = "0x6015003")]
	[Address(RVA = "0x31C7D60", Offset = "0x31C7D60", VA = "0x31C7D60")]
	public bool GetOpeningState()
	{
		return default(bool);
	}

	[Token(Token = "0x6015004")]
	[Address(RVA = "0x31C7DD8", Offset = "0x31C7DD8", VA = "0x31C7DD8")]
	public List<AwardDesc> GetRankAwardList(uint rank)
	{
		return null;
	}

	[Token(Token = "0x6015005")]
	[Address(RVA = "0x31C7F60", Offset = "0x31C7F60", VA = "0x31C7F60")]
	public List<LeaderBoardInfo> GetFriendBoardScoreList()
	{
		return null;
	}

	[Token(Token = "0x6015006")]
	[Address(RVA = "0x31C7FB8", Offset = "0x31C7FB8", VA = "0x31C7FB8")]
	public LeaderBoardInfo GetLocalPlayerBoardFriend()
	{
		return null;
	}

	[Token(Token = "0x6015007")]
	[Address(RVA = "0x31C8010", Offset = "0x31C8010", VA = "0x31C8010")]
	public LeaderBoardInfo GetLocalPlayerBoardRegion()
	{
		return null;
	}

	[Token(Token = "0x6015008")]
	[Address(RVA = "0x31C8068", Offset = "0x31C8068", VA = "0x31C8068")]
	public uint GetSeasonAwardId()
	{
		return default(uint);
	}

	[Token(Token = "0x6015009")]
	[Address(RVA = "0x31C80D8", Offset = "0x31C80D8", VA = "0x31C80D8")]
	public string GetCdnUrlSeasonBg()
	{
		return null;
	}

	[Token(Token = "0x601500A")]
	[Address(RVA = "0x31C81C4", Offset = "0x31C81C4", VA = "0x31C81C4", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601500B")]
	[Address(RVA = "0x31C82F4", Offset = "0x31C82F4", VA = "0x31C82F4")]
	public void RequestInitPlayerRankingInfo(bool silence = false)
	{
	}

	[Token(Token = "0x601500C")]
	[Address(RVA = "0x31C85A0", Offset = "0x31C85A0", VA = "0x31C85A0")]
	public void RequestGetRankingsInfo(bool immediately = false)
	{
	}

	[Token(Token = "0x601500D")]
	[Address(RVA = "0x31C87F0", Offset = "0x31C87F0", VA = "0x31C87F0")]
	public void RequestGetCurOrRecentPeriodicRankingConfig(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601500E")]
	[Address(RVA = "0x31C8AC8", Offset = "0x31C8AC8", VA = "0x31C8AC8")]
	public void RequestPlayerRankInfo()
	{
	}

	[Token(Token = "0x601500F")]
	[Address(RVA = "0x31C8C04", Offset = "0x31C8C04", VA = "0x31C8C04")]
	public void RequestRankingInfoById(ulong accoutid)
	{
	}

	[Token(Token = "0x6015010")]
	[Address(RVA = "0x31C8F94", Offset = "0x31C8F94", VA = "0x31C8F94")]
	public List<LeaderBoardInfo> GetRegionBoardScoreList()
	{
		return null;
	}

	[Token(Token = "0x6015011")]
	[Address(RVA = "0x31C8FEC", Offset = "0x31C8FEC", VA = "0x31C8FEC")]
	public void RequestLeaderBoardRegion()
	{
	}

	[Token(Token = "0x6015012")]
	[Address(RVA = "0x31C93AC", Offset = "0x31C93AC", VA = "0x31C93AC")]
	public void RequestLeaderBoardFriend()
	{
	}

	[Token(Token = "0x6015013")]
	[Address(RVA = "0x31C9858", Offset = "0x31C9858", VA = "0x31C9858", Slot = "14")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6015014")]
	[Address(RVA = "0x31C9A50", Offset = "0x31C9A50", VA = "0x31C9A50", Slot = "15")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6015015")]
	[Address(RVA = "0x31C9AE4", Offset = "0x31C9AE4", VA = "0x31C9AE4")]
	private void _003CClaimRankingResetReward_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015016")]
	[Address(RVA = "0x31C9B8C", Offset = "0x31C9B8C", VA = "0x31C9B8C")]
	private void _003CRequestInitPlayerRankingInfo_003Em__1(HttpErrorCode errodCode, object res)
	{
	}

	[Token(Token = "0x6015017")]
	[Address(RVA = "0x31C9CD4", Offset = "0x31C9CD4", VA = "0x31C9CD4")]
	private void _003CRequestGetRankingsInfo_003Em__2(HttpErrorCode errodCode, object res)
	{
	}

	[Token(Token = "0x6015018")]
	[Address(RVA = "0x31C9E80", Offset = "0x31C9E80", VA = "0x31C9E80")]
	private void _003CRequestGetCurOrRecentPeriodicRankingConfig_003Em__3(HttpErrorCode errodCode, object res)
	{
	}

	[Token(Token = "0x6015019")]
	[Address(RVA = "0x31CA154", Offset = "0x31CA154", VA = "0x31CA154")]
	private void _003CRequestLeaderBoardRegion_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601501A")]
	[Address(RVA = "0x31CA460", Offset = "0x31CA460", VA = "0x31CA460")]
	private void _003CRequestLeaderBoardFriend_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601501B")]
	[Address(RVA = "0x31CAB34", Offset = "0x31CAB34", VA = "0x31CAB34")]
	private static int _003CRequestLeaderBoardFriend_003Em__6(LeaderBoardInfo x, LeaderBoardInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x601501C")]
	[Address(RVA = "0x31CAB74", Offset = "0x31CAB74", VA = "0x31CAB74")]
	private static bool _003CRequestLeaderBoardRegion_003Em__7(LeaderBoardInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x601501D")]
	[Address(RVA = "0x31CAC78", Offset = "0x31CAC78", VA = "0x31CAC78")]
	private static int _003CRequestLeaderBoardFriend_003Em__8(FriendAccountInfo x, FriendAccountInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x601501E")]
	[Address(RVA = "0x31CACB8", Offset = "0x31CACB8", VA = "0x31CACB8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x601501F")]
	[Address(RVA = "0x31CACC0", Offset = "0x31CACC0", VA = "0x31CACC0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
