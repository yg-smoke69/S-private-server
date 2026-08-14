using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030DC")]
public class UIModelLeaderBoard : UIBaseModel
{
	[Token(Token = "0x20030DD")]
	public class TeamLBIndex
	{
		[Token(Token = "0x401297D")]
		[FieldOffset(Offset = "0x8")]
		public int PropID;

		[Token(Token = "0x401297E")]
		[FieldOffset(Offset = "0xC")]
		public uint ChampionshipType;

		[Token(Token = "0x60147DE")]
		[Address(RVA = "0x32858AC", Offset = "0x32858AC", VA = "0x32858AC")]
		public TeamLBIndex()
		{
		}
	}

	[Token(Token = "0x20030DE")]
	public class DetailedTCStats
	{
		[Token(Token = "0x401297F")]
		[FieldOffset(Offset = "0x8")]
		public uint mvp_count;

		[Token(Token = "0x4012980")]
		[FieldOffset(Offset = "0xC")]
		public uint double_kills;

		[Token(Token = "0x4012981")]
		[FieldOffset(Offset = "0x10")]
		public uint triple_kills;

		[Token(Token = "0x4012982")]
		[FieldOffset(Offset = "0x14")]
		public uint four_kills;

		[Token(Token = "0x4012983")]
		[FieldOffset(Offset = "0x18")]
		public uint damage;

		[Token(Token = "0x4012984")]
		[FieldOffset(Offset = "0x1C")]
		public uint head_shot_kills;

		[Token(Token = "0x4012985")]
		[FieldOffset(Offset = "0x20")]
		public uint knock_downs;

		[Token(Token = "0x4012986")]
		[FieldOffset(Offset = "0x24")]
		public uint revivals;

		[Token(Token = "0x4012987")]
		[FieldOffset(Offset = "0x28")]
		public uint assists;

		[Token(Token = "0x4012988")]
		[FieldOffset(Offset = "0x2C")]
		public uint deaths;

		[Token(Token = "0x60147DF")]
		[Address(RVA = "0x32858A4", Offset = "0x32858A4", VA = "0x32858A4")]
		public DetailedTCStats()
		{
		}
	}

	[Token(Token = "0x20030DF")]
	private enum LeaderBoardProfileType
	{
		[Token(Token = "0x401298A")]
		None,
		[Token(Token = "0x401298B")]
		Account,
		[Token(Token = "0x401298C")]
		Clan,
		[Token(Token = "0x401298D")]
		Championship
	}

	[Token(Token = "0x20030E0")]
	private sealed class _003CUpdateFriendBoard_003Ec__AnonStorey0
	{
		[Token(Token = "0x401298E")]
		[FieldOffset(Offset = "0x8")]
		internal LeaderBoardInfo leaderboard_info;

		[Token(Token = "0x60147E0")]
		[Address(RVA = "0x327E47C", Offset = "0x327E47C", VA = "0x327E47C")]
		public _003CUpdateFriendBoard_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60147E1")]
		[Address(RVA = "0x3285810", Offset = "0x3285810", VA = "0x3285810")]
		internal bool _003C_003Em__0(LeaderBoardInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030E1")]
	private sealed class _003CCacheUpdateEPBadgeCount_003Ec__AnonStorey1
	{
		[Token(Token = "0x401298F")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x60147E2")]
		[Address(RVA = "0x327EFA8", Offset = "0x327EFA8", VA = "0x327EFA8")]
		public _003CCacheUpdateEPBadgeCount_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60147E3")]
		[Address(RVA = "0x3282E68", Offset = "0x3282E68", VA = "0x3282E68")]
		internal bool _003C_003Em__0(LeaderBoardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030E2")]
	private sealed class _003CRequestBigEventLeaderBoard_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012990")]
		[FieldOffset(Offset = "0x8")]
		internal uint propID;

		[Token(Token = "0x4012991")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147E4")]
		[Address(RVA = "0x3280070", Offset = "0x3280070", VA = "0x3280070")]
		public _003CRequestBigEventLeaderBoard_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60147E5")]
		[Address(RVA = "0x3284BE0", Offset = "0x3284BE0", VA = "0x3284BE0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030E3")]
	private sealed class _003CHandleAccountGlobalLeaderBoard_003Ec__AnonStorey3
	{
		[Token(Token = "0x20030E4")]
		private sealed class _003CHandleAccountGlobalLeaderBoard_003Ec__AnonStorey4
		{
			[Token(Token = "0x4012995")]
			[FieldOffset(Offset = "0x8")]
			internal AccountLeaderboardItem localPlayerInfo;

			[Token(Token = "0x4012996")]
			[FieldOffset(Offset = "0xC")]
			internal _003CHandleAccountGlobalLeaderBoard_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

			[Token(Token = "0x60147E8")]
			[Address(RVA = "0x3283594", Offset = "0x3283594", VA = "0x3283594")]
			public _003CHandleAccountGlobalLeaderBoard_003Ec__AnonStorey4()
			{
			}

			[Token(Token = "0x60147E9")]
			[Address(RVA = "0x328359C", Offset = "0x328359C", VA = "0x328359C")]
			internal void _003C_003Em__0(HttpErrorCode errorCode1, object res1)
			{
			}
		}

		[Token(Token = "0x4012992")]
		[FieldOffset(Offset = "0x8")]
		internal uint propID;

		[Token(Token = "0x4012993")]
		[FieldOffset(Offset = "0xC")]
		internal CSLeaderboardReq req;

		[Token(Token = "0x4012994")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147E6")]
		[Address(RVA = "0x3281098", Offset = "0x3281098", VA = "0x3281098")]
		public _003CHandleAccountGlobalLeaderBoard_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60147E7")]
		[Address(RVA = "0x3282EE8", Offset = "0x3282EE8", VA = "0x3282EE8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030E5")]
	private sealed class _003CHandleClanGlobalLeaderBoard_003Ec__AnonStorey5
	{
		[Token(Token = "0x20030E6")]
		private sealed class _003CHandleClanGlobalLeaderBoard_003Ec__AnonStorey6
		{
			[Token(Token = "0x401299A")]
			[FieldOffset(Offset = "0x8")]
			internal ClanLeaderboardItem localPlayerInfo;

			[Token(Token = "0x401299B")]
			[FieldOffset(Offset = "0xC")]
			internal _003CHandleClanGlobalLeaderBoard_003Ec__AnonStorey5 _003C_003Ef__ref_00245;

			[Token(Token = "0x60147EC")]
			[Address(RVA = "0x32845A8", Offset = "0x32845A8", VA = "0x32845A8")]
			public _003CHandleClanGlobalLeaderBoard_003Ec__AnonStorey6()
			{
			}

			[Token(Token = "0x60147ED")]
			[Address(RVA = "0x32845B0", Offset = "0x32845B0", VA = "0x32845B0")]
			internal void _003C_003Em__0(HttpErrorCode errorCode1, object res1)
			{
			}
		}

		[Token(Token = "0x4012997")]
		[FieldOffset(Offset = "0x8")]
		internal uint propID;

		[Token(Token = "0x4012998")]
		[FieldOffset(Offset = "0xC")]
		internal CSLeaderboardReq req;

		[Token(Token = "0x4012999")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147EA")]
		[Address(RVA = "0x32810A0", Offset = "0x32810A0", VA = "0x32810A0")]
		public _003CHandleClanGlobalLeaderBoard_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60147EB")]
		[Address(RVA = "0x3283F14", Offset = "0x3283F14", VA = "0x3283F14")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030E7")]
	private sealed class _003CHandleAccountRegionLeaderBoard_003Ec__AnonStorey7
	{
		[Token(Token = "0x401299C")]
		[FieldOffset(Offset = "0x8")]
		internal uint propID;

		[Token(Token = "0x401299D")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147EE")]
		[Address(RVA = "0x32817D4", Offset = "0x32817D4", VA = "0x32817D4")]
		public _003CHandleAccountRegionLeaderBoard_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60147EF")]
		[Address(RVA = "0x3283804", Offset = "0x3283804", VA = "0x3283804")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030E8")]
	private sealed class _003CHandleClanRegionLeaderBoard_003Ec__AnonStorey8
	{
		[Token(Token = "0x401299E")]
		[FieldOffset(Offset = "0x8")]
		internal uint propID;

		[Token(Token = "0x401299F")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147F0")]
		[Address(RVA = "0x32817DC", Offset = "0x32817DC", VA = "0x32817DC")]
		public _003CHandleClanRegionLeaderBoard_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60147F1")]
		[Address(RVA = "0x3284818", Offset = "0x3284818", VA = "0x3284818")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030E9")]
	private sealed class _003CHandleChampionshipRegionLeaderBoard_003Ec__AnonStorey9
	{
		[Token(Token = "0x40129A0")]
		[FieldOffset(Offset = "0x8")]
		internal uint propID;

		[Token(Token = "0x40129A1")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147F2")]
		[Address(RVA = "0x32817E4", Offset = "0x32817E4", VA = "0x32817E4")]
		public _003CHandleChampionshipRegionLeaderBoard_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60147F3")]
		[Address(RVA = "0x3283B8C", Offset = "0x3283B8C", VA = "0x3283B8C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030EA")]
	private sealed class _003CRequestClanWeekLeaderBoardInfo_003Ec__AnonStoreyA
	{
		[Token(Token = "0x40129A2")]
		[FieldOffset(Offset = "0x8")]
		internal WeakReference nextWeakRef;

		[Token(Token = "0x40129A3")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147F4")]
		[Address(RVA = "0x3281A84", Offset = "0x3281A84", VA = "0x3281A84")]
		public _003CRequestClanWeekLeaderBoardInfo_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x60147F5")]
		[Address(RVA = "0x3284E18", Offset = "0x3284E18", VA = "0x3284E18")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030EB")]
	private sealed class _003CRequestFriendInfo_003Ec__AnonStoreyB
	{
		[Token(Token = "0x40129A4")]
		[FieldOffset(Offset = "0x8")]
		internal bool isPlatform;

		[Token(Token = "0x40129A5")]
		[FieldOffset(Offset = "0x9")]
		internal bool isLadder;

		[Token(Token = "0x40129A6")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLeaderBoard _0024this;

		[Token(Token = "0x60147F6")]
		[Address(RVA = "0x3282308", Offset = "0x3282308", VA = "0x3282308")]
		public _003CRequestFriendInfo_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x60147F7")]
		[Address(RVA = "0x3284FE0", Offset = "0x3284FE0", VA = "0x3284FE0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030EC")]
	private sealed class _003CRemoveFriendByPropID_003Ec__AnonStoreyC
	{
		[Token(Token = "0x40129A7")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountid;

		[Token(Token = "0x60147F8")]
		[Address(RVA = "0x3282660", Offset = "0x3282660", VA = "0x3282660")]
		public _003CRemoveFriendByPropID_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x60147F9")]
		[Address(RVA = "0x3284BA0", Offset = "0x3284BA0", VA = "0x3284BA0")]
		internal bool _003C_003Em__0(LeaderBoardInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030ED")]
	private sealed class _003CUpdateMyLadderInfo_003Ec__AnonStoreyD
	{
		[Token(Token = "0x40129A8")]
		[FieldOffset(Offset = "0x8")]
		internal ulong myAccountID;

		[Token(Token = "0x60147FA")]
		[Address(RVA = "0x3282920", Offset = "0x3282920", VA = "0x3282920")]
		public _003CUpdateMyLadderInfo_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x60147FB")]
		[Address(RVA = "0x3285864", Offset = "0x3285864", VA = "0x3285864")]
		internal bool _003C_003Em__0(LeaderBoardInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20030EE")]
	private sealed class _003CGetBRRank_003Ec__AnonStoreyE
	{
		[Token(Token = "0x40129A9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x60147FC")]
		[Address(RVA = "0x3282E58", Offset = "0x3282E58", VA = "0x3282E58")]
		public _003CGetBRRank_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x60147FD")]
		[Address(RVA = "0x3282EA8", Offset = "0x3282EA8", VA = "0x3282EA8")]
		internal bool _003C_003Em__0(LeaderBoardInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012954")]
	public const int PropID_GetSOLOLeaderBoard = 1;

	[Token(Token = "0x4012955")]
	public const int PropID_GetDUOLeaderBoard = 2;

	[Token(Token = "0x4012956")]
	public const int PropID_GetSQUADLeaderBoard = 4;

	[Token(Token = "0x4012957")]
	public const int PropID_FriendLeaderBoard = 8;

	[Token(Token = "0x4012958")]
	public const int PropID_GlobleLeaderBoard = 16;

	[Token(Token = "0x4012959")]
	public const int PropID_GetRegionData = 32;

	[Token(Token = "0x401295A")]
	public const int PropID_WinsLeaderBoard = 64;

	[Token(Token = "0x401295B")]
	public const int PropID_KillsLeaderBoard = 128;

	[Token(Token = "0x401295C")]
	public const int PropID_CasualWinsLeaderBoard = 256;

	[Token(Token = "0x401295D")]
	public const int PropID_CasualKillsLeaderBoard = 512;

	[Token(Token = "0x401295E")]
	public const int PropID_ScoreLeaderBoard = 1024;

	[Token(Token = "0x401295F")]
	public const int PropID_GetEmptyData = 2048;

	[Token(Token = "0x4012960")]
	public const int PropID_EPBadgeLeaderBoard = 4096;

	[Token(Token = "0x4012961")]
	public const int PropID_GetWeekData = 8192;

	[Token(Token = "0x4012962")]
	public const int PropID_GetTotalData = 16384;

	[Token(Token = "0x4012963")]
	public const int PropID_GetHonor = 32768;

	[Token(Token = "0x4012964")]
	public const int PropID_GuildWeekInfoUpdate = 65536;

	[Token(Token = "0x4012965")]
	public const int PropID_ClanRaceRank = 131072;

	[Token(Token = "0x4012966")]
	public const int PropID_TeamFFC = 262144;

	[Token(Token = "0x4012967")]
	public const int PropID_TeamThirdParty = 524288;

	[Token(Token = "0x4012968")]
	public const int PropID_GetSendGiftLeaderBoard = 1048576;

	[Token(Token = "0x4012969")]
	public const int PropID_GetReceiveGiftLeaderBoard = 2097152;

	[Token(Token = "0x401296A")]
	public const int PropID_CSWinsLeaderBoard = 4194304;

	[Token(Token = "0x401296B")]
	public const int PropID_CSKillSLeaderBoard = 8388608;

	[Token(Token = "0x401296C")]
	public const int PropID_ClanWarLeaderBoard = 16777216;

	[Token(Token = "0x401296D")]
	public const int LEADERBOARD_SIZE = 100;

	[Token(Token = "0x401296E")]
	public const int TEAM_LEADERBOARD_SIZE = 3000;

	[Token(Token = "0x401296F")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, List<LeaderBoardInfo>> m_DicLeaderBoardList;

	[Token(Token = "0x4012970")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, LeaderBoardInfo> m_LocalPlayerInfos;

	[Token(Token = "0x4012971")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, float> m_DicLeaderBoardCD;

	[Token(Token = "0x4012972")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, uint> m_DicLeaderBoardSize;

	[Token(Token = "0x4012973")]
	[FieldOffset(Offset = "0x1C")]
	private HashSet<uint> m_RunningRequestPropIDCache;

	[Token(Token = "0x4012974")]
	[FieldOffset(Offset = "0x20")]
	public CSGetClanWeekLeaderboardInfoRes m_GuildWeekInfo;

	[Token(Token = "0x4012975")]
	[FieldOffset(Offset = "0x24")]
	private float m_LastUpdateFriendLadderTime;

	[Token(Token = "0x4012976")]
	[FieldOffset(Offset = "0x28")]
	private float m_LastUpdateFriendRankingTime;

	[Token(Token = "0x4012977")]
	[FieldOffset(Offset = "0x2C")]
	private float m_FriendLadderInfoCooldown;

	[Token(Token = "0x4012978")]
	[FieldOffset(Offset = "0x30")]
	private float m_FriendStatsInfoCooldown;

	[Token(Token = "0x4012979")]
	[FieldOffset(Offset = "0x34")]
	private bool m_GameFriendLadderDataHasCome;

	[Token(Token = "0x401297A")]
	[FieldOffset(Offset = "0x35")]
	private bool m_FBFriendLadderDataHasCome;

	[Token(Token = "0x401297B")]
	[FieldOffset(Offset = "0x36")]
	private bool m_GameFriendStatsDataHasCome;

	[Token(Token = "0x401297C")]
	[FieldOffset(Offset = "0x37")]
	private bool m_FBFriendStatsDataHasCome;

	[Token(Token = "0x60147B3")]
	[Address(RVA = "0x327C940", Offset = "0x327C940", VA = "0x327C940")]
	public UIModelLeaderBoard()
	{
	}

	[Token(Token = "0x60147B4")]
	[Address(RVA = "0x327CAD8", Offset = "0x327CAD8", VA = "0x327CAD8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60147B5")]
	[Address(RVA = "0x327CB30", Offset = "0x327CB30", VA = "0x327CB30")]
	public LeaderBoardInfo GetLocalPlayerInfo(int propID)
	{
		return null;
	}

	[Token(Token = "0x60147B6")]
	[Address(RVA = "0x327CC20", Offset = "0x327CC20", VA = "0x327CC20")]
	private void SetLocalPlayerInfo(int propID, LeaderBoardInfo info)
	{
	}

	[Token(Token = "0x60147B7")]
	[Address(RVA = "0x3276164", Offset = "0x3276164", VA = "0x3276164")]
	public List<LeaderBoardInfo> GetLeaderBoardList(int propID)
	{
		return null;
	}

	[Token(Token = "0x60147B8")]
	[Address(RVA = "0x327CD08", Offset = "0x327CD08", VA = "0x327CD08", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60147B9")]
	[Address(RVA = "0x327CF00", Offset = "0x327CF00", VA = "0x327CF00")]
	public void ClearFriendRequestWhenFail()
	{
	}

	[Token(Token = "0x60147BA")]
	[Address(RVA = "0x327D0CC", Offset = "0x327D0CC", VA = "0x327D0CC")]
	public void UpdateFriendBoard(List<FriendAccountInfo> friend_list, EAccountAdscription type, bool isLadder = false)
	{
	}

	[Token(Token = "0x60147BB")]
	[Address(RVA = "0x327E8B8", Offset = "0x327E8B8", VA = "0x327E8B8")]
	public void CacheUpdateSelfEPBadge()
	{
	}

	[Token(Token = "0x60147BC")]
	[Address(RVA = "0x327EC54", Offset = "0x327EC54", VA = "0x327EC54")]
	private void CacheUpdateEPBadgeCount(int propID, ulong accountId, uint count)
	{
	}

	[Token(Token = "0x60147BD")]
	[Address(RVA = "0x327E484", Offset = "0x327E484", VA = "0x327E484")]
	public void SortFriendBoardWithPropID(int propID, List<LeaderBoardInfo> board_list)
	{
	}

	[Token(Token = "0x60147BE")]
	[Address(RVA = "0x327EFB0", Offset = "0x327EFB0", VA = "0x327EFB0")]
	public int SortFriendBoardItemWithScore(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60147BF")]
	[Address(RVA = "0x327F0AC", Offset = "0x327F0AC", VA = "0x327F0AC")]
	public int SortFriendBoardItemWithWins(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60147C0")]
	[Address(RVA = "0x327F1A8", Offset = "0x327F1A8", VA = "0x327F1A8")]
	public int SortFriendBoardItemWithKills(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60147C1")]
	[Address(RVA = "0x327F2A4", Offset = "0x327F2A4", VA = "0x327F2A4")]
	public int SortFriendBoardItemWithCSKills(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60147C2")]
	[Address(RVA = "0x327F3A0", Offset = "0x327F3A0", VA = "0x327F3A0")]
	public int SortBoardItemWithEPBadges(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x60147C3")]
	[Address(RVA = "0x327CD80", Offset = "0x327CD80", VA = "0x327CD80")]
	public void ClearLeaderBoardData()
	{
	}

	[Token(Token = "0x60147C4")]
	[Address(RVA = "0x327F49C", Offset = "0x327F49C", VA = "0x327F49C")]
	public void RequestFriendLeaderBoard(uint propID, bool force = false, bool silence = false)
	{
	}

	[Token(Token = "0x60147C5")]
	[Address(RVA = "0x327FAA8", Offset = "0x327FAA8", VA = "0x327FAA8")]
	public void RequestBigEventLeaderBoard(uint propID, int mainType = 0, int subType = 0, ulong mainKey = 0uL, ulong subKey = 0uL, string region = "", uint httpOp = 0u, bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true)
	{
	}

	[Token(Token = "0x60147C6")]
	[Address(RVA = "0x32802CC", Offset = "0x32802CC", VA = "0x32802CC")]
	public void RequestLeaderBoard(uint propID, int mainType = 0, int subType = 0, ulong mainKey = 0uL, ulong subKey = 0uL, string region = "", uint httpOp = 0u, bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true, bool forceRequestIfBoardEmpty = true)
	{
	}

	[Token(Token = "0x60147C7")]
	[Address(RVA = "0x3280920", Offset = "0x3280920", VA = "0x3280920")]
	private void RequestGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	[Token(Token = "0x60147C8")]
	[Address(RVA = "0x3280BA0", Offset = "0x3280BA0", VA = "0x3280BA0")]
	private void HandleAccountGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	[Token(Token = "0x60147C9")]
	[Address(RVA = "0x3280E1C", Offset = "0x3280E1C", VA = "0x3280E1C")]
	private void HandleClanGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	[Token(Token = "0x60147CA")]
	[Address(RVA = "0x32809F0", Offset = "0x32809F0", VA = "0x32809F0")]
	private void RequestRegionLeaderBoard(uint propID, CSLeaderboardReq req, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60147CB")]
	[Address(RVA = "0x32810A8", Offset = "0x32810A8", VA = "0x32810A8")]
	private void HandleAccountRegionLeaderBoard(uint propID, CSLeaderboardReq req, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60147CC")]
	[Address(RVA = "0x3281314", Offset = "0x3281314", VA = "0x3281314")]
	private void HandleClanRegionLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	[Token(Token = "0x60147CD")]
	[Address(RVA = "0x3281574", Offset = "0x3281574", VA = "0x3281574")]
	private void HandleChampionshipRegionLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	[Token(Token = "0x60147CE")]
	[Address(RVA = "0x3280AE0", Offset = "0x3280AE0", VA = "0x3280AE0")]
	private LeaderBoardProfileType GetLeaderBoardProfileType(int mainType)
	{
		return default(LeaderBoardProfileType);
	}

	[Token(Token = "0x60147CF")]
	[Address(RVA = "0x3280078", Offset = "0x3280078", VA = "0x3280078")]
	private bool IsInRequestCD(uint propID)
	{
		return default(bool);
	}

	[Token(Token = "0x60147D0")]
	[Address(RVA = "0x32817EC", Offset = "0x32817EC", VA = "0x32817EC")]
	public void RequestClanWeekLeaderBoardInfo([Optional] Action next)
	{
	}

	[Token(Token = "0x60147D1")]
	[Address(RVA = "0x327F988", Offset = "0x327F988", VA = "0x327F988")]
	private void RefreshAllFriendRankingStats(bool isLadder, bool silence = false)
	{
	}

	[Token(Token = "0x60147D2")]
	[Address(RVA = "0x3281A8C", Offset = "0x3281A8C", VA = "0x3281A8C")]
	private void RefreshGameFriendStats(bool isLadder, bool silence = false)
	{
	}

	[Token(Token = "0x60147D3")]
	[Address(RVA = "0x3281C74", Offset = "0x3281C74", VA = "0x3281C74")]
	public void RefreshPlatformFriendList(bool isLadder)
	{
	}

	[Token(Token = "0x60147D4")]
	[Address(RVA = "0x3281FB4", Offset = "0x3281FB4", VA = "0x3281FB4")]
	private void RequestFriendInfo(object req, bool isPlatform, bool isLadder, bool silence = false)
	{
	}

	[Token(Token = "0x60147D5")]
	[Address(RVA = "0x3282310", Offset = "0x3282310", VA = "0x3282310")]
	public void RemoveFriendByAccountId(ulong friendID)
	{
	}

	[Token(Token = "0x60147D6")]
	[Address(RVA = "0x3282434", Offset = "0x3282434", VA = "0x3282434")]
	private void RemoveFriendByPropID(ulong accountid, int propid)
	{
	}

	[Token(Token = "0x60147D7")]
	[Address(RVA = "0x3282668", Offset = "0x3282668", VA = "0x3282668")]
	public void AddFriendByAccountWithPresense(AccountInfoWithPresence account)
	{
	}

	[Token(Token = "0x60147D8")]
	[Address(RVA = "0x3282738", Offset = "0x3282738", VA = "0x3282738")]
	private void AddFriendByPropID(AccountInfoWithPresence account, int propid)
	{
	}

	[Token(Token = "0x60147D9")]
	[Address(RVA = "0x3275178", Offset = "0x3275178", VA = "0x3275178")]
	public void UpdateMyLadderInfo(LadderRankInfo rankInfo)
	{
	}

	[Token(Token = "0x60147DA")]
	[Address(RVA = "0x3282928", Offset = "0x3282928", VA = "0x3282928")]
	public string GetClanRegionData()
	{
		return null;
	}

	[Token(Token = "0x60147DB")]
	[Address(RVA = "0x3282BDC", Offset = "0x3282BDC", VA = "0x3282BDC")]
	public uint GetLeaderBoardSize(uint propID)
	{
		return default(uint);
	}

	[Token(Token = "0x60147DC")]
	[Address(RVA = "0x3282CC4", Offset = "0x3282CC4", VA = "0x3282CC4")]
	public int GetBRRank(ulong accountID)
	{
		return default(int);
	}

	[Token(Token = "0x60147DD")]
	[Address(RVA = "0x3282E60", Offset = "0x3282E60", VA = "0x3282E60")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
