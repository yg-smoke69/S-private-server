using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002EFD")]
public class UIModelChampionship : UIBaseModel, _Attribute
{
	[Token(Token = "0x2002EFE")]
	public enum MemberType
	{
		[Token(Token = "0x4011FA7")]
		Normal = 1,
		[Token(Token = "0x4011FA8")]
		Captain
	}

	[Token(Token = "0x2002EFF")]
	public class NotifyArgs
	{
		[Token(Token = "0x4011FA9")]
		[FieldOffset(Offset = "0x8")]
		public bool success;

		[Token(Token = "0x6013B67")]
		[Address(RVA = "0x27BC0EC", Offset = "0x27BC0EC", VA = "0x27BC0EC")]
		public NotifyArgs()
		{
		}
	}

	[Token(Token = "0x2002F00")]
	public class NotifyArgsRemove : NotifyArgs
	{
		[Token(Token = "0x4011FAA")]
		[FieldOffset(Offset = "0x9")]
		public bool removeSelf;

		[Token(Token = "0x6013B68")]
		[Address(RVA = "0x27BFA98", Offset = "0x27BFA98", VA = "0x27BFA98")]
		public NotifyArgsRemove()
		{
		}
	}

	[Token(Token = "0x2002F01")]
	public class NotifyArgsJoin : NotifyArgs
	{
		[Token(Token = "0x4011FAB")]
		[FieldOffset(Offset = "0x10")]
		public ulong friendID;

		[Token(Token = "0x4011FAC")]
		[FieldOffset(Offset = "0x18")]
		public bool teamIsFull;

		[Token(Token = "0x6013B69")]
		[Address(RVA = "0x27BDE14", Offset = "0x27BDE14", VA = "0x27BDE14")]
		public NotifyArgsJoin()
		{
		}
	}

	[Token(Token = "0x2002F02")]
	public class NotifyArgsInvite : NotifyArgs
	{
		[Token(Token = "0x4011FAD")]
		[FieldOffset(Offset = "0x10")]
		public ulong invitee;

		[Token(Token = "0x4011FAE")]
		[FieldOffset(Offset = "0x18")]
		public bool sameRequest;

		[Token(Token = "0x6013B6A")]
		[Address(RVA = "0x27BD948", Offset = "0x27BD948", VA = "0x27BD948")]
		public NotifyArgsInvite()
		{
		}
	}

	[Token(Token = "0x2002F03")]
	public class NotifyArgsQuit : NotifyArgs
	{
		[Token(Token = "0x4011FAF")]
		[FieldOffset(Offset = "0x9")]
		public bool toNewTeam;

		[Token(Token = "0x6013B6B")]
		[Address(RVA = "0x27BE750", Offset = "0x27BE750", VA = "0x27BE750")]
		public NotifyArgsQuit()
		{
		}
	}

	[Token(Token = "0x2002F04")]
	public class NotifyArgsDismiss : NotifyArgs
	{
		[Token(Token = "0x4011FB0")]
		[FieldOffset(Offset = "0x9")]
		public bool toNewTeam;

		[Token(Token = "0x6013B6C")]
		[Address(RVA = "0x27BD008", Offset = "0x27BD008", VA = "0x27BD008")]
		public NotifyArgsDismiss()
		{
		}
	}

	[Token(Token = "0x2002F05")]
	public class NotifyArgsStats : NotifyArgs
	{
		[Token(Token = "0x4011FB1")]
		[FieldOffset(Offset = "0xC")]
		public CSTeamChampionshipSeasonStatsRes stats;

		[Token(Token = "0x6013B6D")]
		[Address(RVA = "0x27BFAA0", Offset = "0x27BFAA0", VA = "0x27BFAA0")]
		public NotifyArgsStats()
		{
		}
	}

	[Token(Token = "0x2002F06")]
	public class NotifyArgsAccountLifeSeasonStats : NotifyArgs
	{
		[Token(Token = "0x4011FB2")]
		[FieldOffset(Offset = "0xC")]
		public List<AccountSeasonStats> statsList;

		[Token(Token = "0x6013B6E")]
		[Address(RVA = "0x27BFA90", Offset = "0x27BFA90", VA = "0x27BFA90")]
		public NotifyArgsAccountLifeSeasonStats()
		{
		}
	}

	[Token(Token = "0x2002F07")]
	public class NotifyArgsTeamMatchStatsHistory : NotifyArgs
	{
		[Token(Token = "0x4011FB3")]
		[FieldOffset(Offset = "0xC")]
		public CSTeamMatchStatsHistoryRes matchStatsHistory;

		[Token(Token = "0x6013B6F")]
		[Address(RVA = "0x27BF290", Offset = "0x27BF290", VA = "0x27BF290")]
		public NotifyArgsTeamMatchStatsHistory()
		{
		}
	}

	[Token(Token = "0x2002F08")]
	public class NotifyArgsTeamInfo : NotifyArgs
	{
		[Token(Token = "0x4011FB4")]
		[FieldOffset(Offset = "0xC")]
		public TeamInfo teamInfo;

		[Token(Token = "0x6013B70")]
		[Address(RVA = "0x27BEBA4", Offset = "0x27BEBA4", VA = "0x27BEBA4")]
		public NotifyArgsTeamInfo()
		{
		}
	}

	[Token(Token = "0x2002F09")]
	public class NotifyArgsTeamMemberInfo : NotifyArgs
	{
		[Token(Token = "0x4011FB5")]
		[FieldOffset(Offset = "0xC")]
		public TeamMemberListWithAccountInfo teamMemberInfo;

		[Token(Token = "0x4011FB6")]
		[FieldOffset(Offset = "0x10")]
		public bool requestedPresence;

		[Token(Token = "0x6013B71")]
		[Address(RVA = "0x27BEBAC", Offset = "0x27BEBAC", VA = "0x27BEBAC")]
		public NotifyArgsTeamMemberInfo()
		{
		}
	}

	[Token(Token = "0x2002F0A")]
	public struct StateViewInfo
	{
		[Token(Token = "0x4011FB7")]
		[FieldOffset(Offset = "0x0")]
		public string stateText;

		[Token(Token = "0x4011FB8")]
		[FieldOffset(Offset = "0x4")]
		public string stateDescText;
	}

	[Token(Token = "0x2002F0B")]
	public enum ChampionshipEntranceState
	{
		[Token(Token = "0x4011FBA")]
		Closed,
		[Token(Token = "0x4011FBB")]
		Paused,
		[Token(Token = "0x4011FBC")]
		WarmUp,
		[Token(Token = "0x4011FBD")]
		Opened
	}

	[Token(Token = "0x2002F0C")]
	public enum ChampionshipOpenState
	{
		[Token(Token = "0x4011FBF")]
		UnOpen,
		[Token(Token = "0x4011FC0")]
		EntranceOpen,
		[Token(Token = "0x4011FC1")]
		SeasonOpen,
		[Token(Token = "0x4011FC2")]
		TodayOpen,
		[Token(Token = "0x4011FC3")]
		TodayUnOpen,
		[Token(Token = "0x4011FC4")]
		Result,
		[Token(Token = "0x4011FC5")]
		TrialClose,
		[Token(Token = "0x4011FC6")]
		SeasonClose
	}

	[Token(Token = "0x2002F0D")]
	private sealed class _003CTeamSetting_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011FC7")]
		[FieldOffset(Offset = "0x8")]
		internal ChampionshipSettingDesc cpSetting;

		[Token(Token = "0x6013B72")]
		[Address(RVA = "0x27BFA3C", Offset = "0x27BFA3C", VA = "0x27BFA3C")]
		public _003CTeamSetting_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013B73")]
		[Address(RVA = "0x27BFA44", Offset = "0x27BFA44", VA = "0x27BFA44")]
		internal bool _003C_003Em__0(ChampionshipTeamDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F0E")]
	private sealed class _003CSelfTeamMembers_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011FC8")]
		[FieldOffset(Offset = "0x8")]
		internal ulong selfAccountID;

		[Token(Token = "0x6013B74")]
		[Address(RVA = "0x27BF6E8", Offset = "0x27BF6E8", VA = "0x27BF6E8")]
		public _003CSelfTeamMembers_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013B75")]
		[Address(RVA = "0x27BF6F0", Offset = "0x27BF6F0", VA = "0x27BF6F0")]
		internal bool _003C_003Em__0(TeamMemberWithAccountInfo m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F0F")]
	private sealed class _003CGetTeamRank_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011FC9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong teamID;

		[Token(Token = "0x6013B76")]
		[Address(RVA = "0x32D5144", Offset = "0x32D5144", VA = "0x32D5144")]
		public _003CGetTeamRank_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013B77")]
		[Address(RVA = "0x32E460C", Offset = "0x32E460C", VA = "0x32E460C")]
		internal bool _003C_003Em__0(LeaderBoardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F10")]
	private sealed class _003CGetChampionshipOpenInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011FCA")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x4011FCB")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipID;

		[Token(Token = "0x6013B78")]
		[Address(RVA = "0x32D5970", Offset = "0x32D5970", VA = "0x32D5970")]
		public _003CGetChampionshipOpenInfo_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6013B79")]
		[Address(RVA = "0x32E4210", Offset = "0x32E4210", VA = "0x32E4210")]
		internal bool _003C_003Em__0(ChampionshipOpenInfoDesc basicInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F11")]
	private sealed class _003CGetChampionshipSetting_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011FCC")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x6013B7A")]
		[Address(RVA = "0x32D5DAC", Offset = "0x32D5DAC", VA = "0x32D5DAC")]
		public _003CGetChampionshipSetting_003Ec__AnonStorey4()
		{
		}
	}

	[Token(Token = "0x2002F12")]
	private sealed class _003CGetChampionshipSetting_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011FCD")]
		[FieldOffset(Offset = "0x8")]
		internal uint cpID;

		[Token(Token = "0x4011FCE")]
		[FieldOffset(Offset = "0xC")]
		internal _003CGetChampionshipSetting_003Ec__AnonStorey4 _003C_003Ef__ref_00244;

		[Token(Token = "0x6013B7B")]
		[Address(RVA = "0x32D5DB4", Offset = "0x32D5DB4", VA = "0x32D5DB4")]
		public _003CGetChampionshipSetting_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6013B7C")]
		[Address(RVA = "0x32E4448", Offset = "0x32E4448", VA = "0x32E4448")]
		internal bool _003C_003Em__0(ChampionshipSettingDesc basicInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F13")]
	private sealed class _003CGetChampionshipScoreBaseInfoByType_003Ec__AnonStorey6
	{
		[Token(Token = "0x4011FCF")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x6013B7D")]
		[Address(RVA = "0x32D5F0C", Offset = "0x32D5F0C", VA = "0x32D5F0C")]
		public _003CGetChampionshipScoreBaseInfoByType_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6013B7E")]
		[Address(RVA = "0x32E42F4", Offset = "0x32E42F4", VA = "0x32E42F4")]
		internal bool _003C_003Em__0(ChampionshipScoreBaseDesc basicInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F14")]
	private sealed class _003CGetChampionshipRewardListByPos_003Ec__AnonStorey7
	{
		[Token(Token = "0x4011FD0")]
		[FieldOffset(Offset = "0x8")]
		internal uint realPos;

		[Token(Token = "0x6013B7F")]
		[Address(RVA = "0x32D62B4", Offset = "0x32D62B4", VA = "0x32D62B4")]
		public _003CGetChampionshipRewardListByPos_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6013B80")]
		[Address(RVA = "0x32E42A8", Offset = "0x32E42A8", VA = "0x32E42A8")]
		internal bool _003C_003Em__0(ChampionshipScoreRewardDesc r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F15")]
	private sealed class _003CGetChampionshipRewardIndexByPos_003Ec__AnonStorey8
	{
		[Token(Token = "0x4011FD1")]
		[FieldOffset(Offset = "0x8")]
		internal uint realPos;

		[Token(Token = "0x6013B81")]
		[Address(RVA = "0x32D64EC", Offset = "0x32D64EC", VA = "0x32D64EC")]
		public _003CGetChampionshipRewardIndexByPos_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6013B82")]
		[Address(RVA = "0x32E425C", Offset = "0x32E425C", VA = "0x32E425C")]
		internal bool _003C_003Em__0(ChampionshipScoreRewardDesc r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F16")]
	private sealed class _003CGetRankPosRange_003Ec__AnonStorey9
	{
		[Token(Token = "0x4011FD2")]
		[FieldOffset(Offset = "0x8")]
		internal uint realPos;

		[Token(Token = "0x6013B83")]
		[Address(RVA = "0x32D6CCC", Offset = "0x32D6CCC", VA = "0x32D6CCC")]
		public _003CGetRankPosRange_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6013B84")]
		[Address(RVA = "0x32E45C4", Offset = "0x32E45C4", VA = "0x32E45C4")]
		internal bool _003C_003Em__0(ChampionshipScoreRewardDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F17")]
	private sealed class _003CRequestJoinTeam_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4011FD3")]
		[FieldOffset(Offset = "0x8")]
		internal ulong friendID;

		[Token(Token = "0x4011FD4")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B85")]
		[Address(RVA = "0x27BD950", Offset = "0x27BD950", VA = "0x27BD950")]
		public _003CRequestJoinTeam_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6013B86")]
		[Address(RVA = "0x27BD958", Offset = "0x27BD958", VA = "0x27BD958")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F18")]
	private sealed class _003CRequestTeamInfoByTeamID_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4011FD5")]
		[FieldOffset(Offset = "0x8")]
		internal ulong teamID;

		[Token(Token = "0x4011FD6")]
		[FieldOffset(Offset = "0x10")]
		internal bool requestTeamApplication;

		[Token(Token = "0x4011FD7")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B87")]
		[Address(RVA = "0x27BEBB4", Offset = "0x27BEBB4", VA = "0x27BEBB4")]
		public _003CRequestTeamInfoByTeamID_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6013B88")]
		[Address(RVA = "0x27BEBBC", Offset = "0x27BEBBC", VA = "0x27BEBBC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F19")]
	private sealed class _003CRequestTeamMembers_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4011FD8")]
		[FieldOffset(Offset = "0x8")]
		internal TeamIDReq req;

		[Token(Token = "0x4011FD9")]
		[FieldOffset(Offset = "0xC")]
		internal bool requestTeamMemberPresence;

		[Token(Token = "0x4011FDA")]
		[FieldOffset(Offset = "0xD")]
		internal bool forcePresence;

		[Token(Token = "0x4011FDB")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B89")]
		[Address(RVA = "0x27BF298", Offset = "0x27BF298", VA = "0x27BF298")]
		public _003CRequestTeamMembers_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6013B8A")]
		[Address(RVA = "0x27BF2A0", Offset = "0x27BF2A0", VA = "0x27BF2A0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F1A")]
	private sealed class _003CRequestTeamMatchStatsHistory_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4011FDC")]
		[FieldOffset(Offset = "0x8")]
		internal ulong teamID;

		[Token(Token = "0x4011FDD")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B8B")]
		[Address(RVA = "0x27BEED8", Offset = "0x27BEED8", VA = "0x27BEED8")]
		public _003CRequestTeamMatchStatsHistory_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6013B8C")]
		[Address(RVA = "0x27BEEE0", Offset = "0x27BEEE0", VA = "0x27BEEE0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F1B")]
	private sealed class _003CRequestQuitTeam_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4011FDE")]
		[FieldOffset(Offset = "0x8")]
		internal bool toNewTeam;

		[Token(Token = "0x4011FDF")]
		[FieldOffset(Offset = "0x9")]
		internal bool requestApproveJoinTeamInvitation;

		[Token(Token = "0x4011FE0")]
		[FieldOffset(Offset = "0x10")]
		internal ulong inviter;

		[Token(Token = "0x4011FE1")]
		[FieldOffset(Offset = "0x18")]
		internal ulong inviterTeam;

		[Token(Token = "0x4011FE2")]
		[FieldOffset(Offset = "0x20")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B8D")]
		[Address(RVA = "0x27BDE1C", Offset = "0x27BDE1C", VA = "0x27BDE1C")]
		public _003CRequestQuitTeam_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6013B8E")]
		[Address(RVA = "0x27BDE28", Offset = "0x27BDE28", VA = "0x27BDE28")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F1C")]
	private sealed class _003CRequestDismissTeam_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4011FE3")]
		[FieldOffset(Offset = "0x8")]
		internal bool toNewTeam;

		[Token(Token = "0x4011FE4")]
		[FieldOffset(Offset = "0x9")]
		internal bool requestApproveJoinTeamInvitation;

		[Token(Token = "0x4011FE5")]
		[FieldOffset(Offset = "0x10")]
		internal ulong inviter;

		[Token(Token = "0x4011FE6")]
		[FieldOffset(Offset = "0x18")]
		internal ulong inviterTeam;

		[Token(Token = "0x4011FE7")]
		[FieldOffset(Offset = "0x20")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B8F")]
		[Address(RVA = "0x27BC6CC", Offset = "0x27BC6CC", VA = "0x27BC6CC")]
		public _003CRequestDismissTeam_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6013B90")]
		[Address(RVA = "0x27BC6D8", Offset = "0x27BC6D8", VA = "0x27BC6D8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F1D")]
	private sealed class _003CRequestApproveApplication_003Ec__AnonStorey10
	{
		[Token(Token = "0x4011FE8")]
		[FieldOffset(Offset = "0x8")]
		internal CSApproveJoinApplicationReq req;

		[Token(Token = "0x4011FE9")]
		[FieldOffset(Offset = "0xC")]
		internal AccountInfoBasic basicInfo;

		[Token(Token = "0x4011FEA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B91")]
		[Address(RVA = "0x32DAB1C", Offset = "0x32DAB1C", VA = "0x32DAB1C")]
		public _003CRequestApproveApplication_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6013B92")]
		[Address(RVA = "0x32E46E8", Offset = "0x32E46E8", VA = "0x32E46E8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F1E")]
	private sealed class _003CRequestDeclineApplication_003Ec__AnonStorey11
	{
		[Token(Token = "0x4011FEB")]
		[FieldOffset(Offset = "0x8")]
		internal ulong[] applicantIDs;

		[Token(Token = "0x4011FEC")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B93")]
		[Address(RVA = "0x27BC0F4", Offset = "0x27BC0F4", VA = "0x27BC0F4")]
		public _003CRequestDeclineApplication_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6013B94")]
		[Address(RVA = "0x27BC0FC", Offset = "0x27BC0FC", VA = "0x27BC0FC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013B95")]
		[Address(RVA = "0x27BC354", Offset = "0x27BC354", VA = "0x27BC354")]
		internal bool _003C_003Em__1(AccountInfoBasic e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F1F")]
	private sealed class _003CRequestInvite_003Ec__AnonStorey12
	{
		[Token(Token = "0x4011FED")]
		[FieldOffset(Offset = "0x8")]
		internal ulong inviteeID;

		[Token(Token = "0x4011FEE")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B96")]
		[Address(RVA = "0x27BD618", Offset = "0x27BD618", VA = "0x27BD618")]
		public _003CRequestInvite_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6013B97")]
		[Address(RVA = "0x27BD620", Offset = "0x27BD620", VA = "0x27BD620")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F20")]
	private sealed class _003CRequestApproveJoinTeamInvitation_003Ec__AnonStorey13
	{
		[Token(Token = "0x4011FEF")]
		[FieldOffset(Offset = "0x8")]
		internal ulong inviterTeam;

		[Token(Token = "0x4011FF0")]
		[FieldOffset(Offset = "0x10")]
		internal ulong inviter;

		[Token(Token = "0x4011FF1")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B98")]
		[Address(RVA = "0x27BB7E8", Offset = "0x27BB7E8", VA = "0x27BB7E8")]
		public _003CRequestApproveJoinTeamInvitation_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6013B99")]
		[Address(RVA = "0x27BB7F0", Offset = "0x27BB7F0", VA = "0x27BB7F0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013B9A")]
		[Address(RVA = "0x27BBD14", Offset = "0x27BBD14", VA = "0x27BBD14")]
		internal bool _003C_003Em__1(AccountInfoBasic e)
		{
			return default(bool);
		}

		[Token(Token = "0x6013B9B")]
		[Address(RVA = "0x27BBD54", Offset = "0x27BBD54", VA = "0x27BBD54")]
		internal bool _003C_003Em__2(AccountInfoBasic e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F21")]
	private sealed class _003CRequestDeclineJoinTeamInvitation_003Ec__AnonStorey14
	{
		[Token(Token = "0x4011FF2")]
		[FieldOffset(Offset = "0x8")]
		internal ulong[] inviterIDs;

		[Token(Token = "0x4011FF3")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B9C")]
		[Address(RVA = "0x27BC3E0", Offset = "0x27BC3E0", VA = "0x27BC3E0")]
		public _003CRequestDeclineJoinTeamInvitation_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6013B9D")]
		[Address(RVA = "0x27BC3E8", Offset = "0x27BC3E8", VA = "0x27BC3E8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013B9E")]
		[Address(RVA = "0x27BC640", Offset = "0x27BC640", VA = "0x27BC640")]
		internal bool _003C_003Em__1(AccountInfoBasic e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F22")]
	private sealed class _003CRequestRemoveTeamMember_003Ec__AnonStorey15
	{
		[Token(Token = "0x4011FF4")]
		[FieldOffset(Offset = "0x8")]
		internal ulong removeeID;

		[Token(Token = "0x4011FF5")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013B9F")]
		[Address(RVA = "0x27BE758", Offset = "0x27BE758", VA = "0x27BE758")]
		public _003CRequestRemoveTeamMember_003Ec__AnonStorey15()
		{
		}

		[Token(Token = "0x6013BA0")]
		[Address(RVA = "0x27BE760", Offset = "0x27BE760", VA = "0x27BE760")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F23")]
	private sealed class _003CRequestGetTeamChampionshipInfo_003Ec__AnonStorey16
	{
		[Token(Token = "0x4011FF6")]
		[FieldOffset(Offset = "0x8")]
		internal uint championshipType;

		[Token(Token = "0x4011FF7")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013BA1")]
		[Address(RVA = "0x27BD010", Offset = "0x27BD010", VA = "0x27BD010")]
		public _003CRequestGetTeamChampionshipInfo_003Ec__AnonStorey16()
		{
		}

		[Token(Token = "0x6013BA2")]
		[Address(RVA = "0x27BD018", Offset = "0x27BD018", VA = "0x27BD018")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F24")]
	private sealed class _003CRequestChampionshipConfig_003Ec__AnonStorey17
	{
		[Token(Token = "0x4011FF8")]
		[FieldOffset(Offset = "0x8")]
		internal uint championshipType;

		[Token(Token = "0x4011FF9")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipID;

		[Token(Token = "0x4011FFA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013BA3")]
		[Address(RVA = "0x27BBD94", Offset = "0x27BBD94", VA = "0x27BBD94")]
		public _003CRequestChampionshipConfig_003Ec__AnonStorey17()
		{
		}

		[Token(Token = "0x6013BA4")]
		[Address(RVA = "0x27BBD9C", Offset = "0x27BBD9C", VA = "0x27BBD9C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F25")]
	private sealed class _003CSortTeamMember_003Ec__AnonStorey18
	{
		[Token(Token = "0x4011FFB")]
		[FieldOffset(Offset = "0x8")]
		internal bool sortPresence;

		[Token(Token = "0x4011FFC")]
		[FieldOffset(Offset = "0xC")]
		internal TeamInfo teamInfo;

		[Token(Token = "0x4011FFD")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelChampionship _0024this;

		[Token(Token = "0x6013BA5")]
		[Address(RVA = "0x27BF740", Offset = "0x27BF740", VA = "0x27BF740")]
		public _003CSortTeamMember_003Ec__AnonStorey18()
		{
		}

		[Token(Token = "0x6013BA6")]
		[Address(RVA = "0x27BF748", Offset = "0x27BF748", VA = "0x27BF748")]
		internal int _003C_003Em__0(TeamMemberWithAccountInfo e, TeamMemberWithAccountInfo o)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2002F26")]
	private sealed class _003CGetChampionshipNameoverwriteDesc_003Ec__AnonStorey19
	{
		[Token(Token = "0x4011FFE")]
		[FieldOffset(Offset = "0x8")]
		internal uint championshipType;

		[Token(Token = "0x4011FFF")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipID;

		[Token(Token = "0x4012000")]
		[FieldOffset(Offset = "0x10")]
		internal uint nameType;

		[Token(Token = "0x4012001")]
		[FieldOffset(Offset = "0x14")]
		internal string language;

		[Token(Token = "0x6013BA7")]
		[Address(RVA = "0x32DDE28", Offset = "0x32DDE28", VA = "0x32DDE28")]
		public _003CGetChampionshipNameoverwriteDesc_003Ec__AnonStorey19()
		{
		}

		[Token(Token = "0x6013BA8")]
		[Address(RVA = "0x32E40EC", Offset = "0x32E40EC", VA = "0x32E40EC")]
		internal bool _003C_003Em__0(ChampionshipNameOverwriteDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F27")]
	private sealed class _003CGetChampionshipTrialMatchName_003Ec__AnonStorey1A
	{
		[Token(Token = "0x4012002")]
		[FieldOffset(Offset = "0x8")]
		internal uint championshipType;

		[Token(Token = "0x4012003")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipID;

		[Token(Token = "0x4012004")]
		[FieldOffset(Offset = "0x10")]
		internal string language;

		[Token(Token = "0x6013BA9")]
		[Address(RVA = "0x32DEBE4", Offset = "0x32DEBE4", VA = "0x32DEBE4")]
		public _003CGetChampionshipTrialMatchName_003Ec__AnonStorey1A()
		{
		}

		[Token(Token = "0x6013BAA")]
		[Address(RVA = "0x32E44A8", Offset = "0x32E44A8", VA = "0x32E44A8")]
		internal bool _003C_003Em__0(ChampionshipNameOverwriteDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F28")]
	private sealed class _003CGetChampionshipModeName_003Ec__AnonStorey1B
	{
		[Token(Token = "0x4012005")]
		[FieldOffset(Offset = "0x8")]
		internal uint championshipType;

		[Token(Token = "0x4012006")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipID;

		[Token(Token = "0x4012007")]
		[FieldOffset(Offset = "0x10")]
		internal string language;

		[Token(Token = "0x6013BAB")]
		[Address(RVA = "0x32DEF4C", Offset = "0x32DEF4C", VA = "0x32DEF4C")]
		public _003CGetChampionshipModeName_003Ec__AnonStorey1B()
		{
		}

		[Token(Token = "0x6013BAC")]
		[Address(RVA = "0x32E3FD0", Offset = "0x32E3FD0", VA = "0x32E3FD0")]
		internal bool _003C_003Em__0(ChampionshipNameOverwriteDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F29")]
	private sealed class _003CGetChampionshipSeasonNameWithIDOverwrite_003Ec__AnonStorey1C
	{
		[Token(Token = "0x4012008")]
		[FieldOffset(Offset = "0x8")]
		internal uint championshipType;

		[Token(Token = "0x4012009")]
		[FieldOffset(Offset = "0xC")]
		internal uint championshipID;

		[Token(Token = "0x401200A")]
		[FieldOffset(Offset = "0x10")]
		internal string language;

		[Token(Token = "0x6013BAD")]
		[Address(RVA = "0x32DF440", Offset = "0x32DF440", VA = "0x32DF440")]
		public _003CGetChampionshipSeasonNameWithIDOverwrite_003Ec__AnonStorey1C()
		{
		}

		[Token(Token = "0x6013BAE")]
		[Address(RVA = "0x32E432C", Offset = "0x32E432C", VA = "0x32E432C")]
		internal bool _003C_003Em__0(ChampionshipNameOverwriteDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F2A")]
	private sealed class _003CHasUnTeamMemberPlayerInGroup_003Ec__AnonStorey1D
	{
		[Token(Token = "0x401200B")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo member;

		[Token(Token = "0x6013BAF")]
		[Address(RVA = "0x32DFE24", Offset = "0x32DFE24", VA = "0x32DFE24")]
		public _003CHasUnTeamMemberPlayerInGroup_003Ec__AnonStorey1D()
		{
		}

		[Token(Token = "0x6013BB0")]
		[Address(RVA = "0x32E4674", Offset = "0x32E4674", VA = "0x32E4674")]
		internal bool _003C_003Em__0(TeamMemberWithAccountInfo m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011F68")]
	[FieldOffset(Offset = "0xC")]
	private TeamInfo m_SelfTeamInfo;

	[Token(Token = "0x4011F69")]
	[FieldOffset(Offset = "0x10")]
	private TeamMemberListWithAccountInfo m_SelfTeamMemberInfo;

	[Token(Token = "0x4011F6A")]
	[FieldOffset(Offset = "0x18")]
	private ulong m_SelfTeamMatchStatsHistoryRequestTime;

	[Token(Token = "0x4011F6B")]
	[FieldOffset(Offset = "0x20")]
	private CSTeamMatchStatsHistoryRes m_SelfTeamMatchStatsHistoryRes;

	[Token(Token = "0x4011F6C")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<ulong, PresenceInfo> m_MemberPresenceCache;

	[Token(Token = "0x4011F6D")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, proto.ChampionshipInfo> m_ChampionshipInfoCache;

	[Token(Token = "0x4011F6E")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<ChampionshipScoreRewardDesc>> m_ChampionshipRewardInfoCache;

	[Token(Token = "0x4011F6F")]
	[FieldOffset(Offset = "0x30")]
	private List<AccountInfoBasic> m_TeamApplicantList;

	[Token(Token = "0x4011F70")]
	[FieldOffset(Offset = "0x34")]
	private List<AccountInfoBasic> m_TeamInvitationList;

	[Token(Token = "0x4011F71")]
	[FieldOffset(Offset = "0x38")]
	private List<ulong> m_TeamInvitedIdList;

	[Token(Token = "0x4011F72")]
	[FieldOffset(Offset = "0x3C")]
	private CSChampionshipBasicInfoRes m_ChampionshipBasicInfoRes;

	[Token(Token = "0x4011F73")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_SelfTeamID;

	[Token(Token = "0x4011F74")]
	private const string m_PrefTeamInfoEditCD = "CSTeamInfoEditCD";

	[Token(Token = "0x4011F75")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_TeamInfoEditCoolDownTime;

	[Token(Token = "0x4011F76")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, uint> m_CurrentChampionshipID;

	[Token(Token = "0x4011F77")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, uint> m_TicketCntDict;

	[Token(Token = "0x4011F78")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, uint> m_GamesPlayedDict;

	[Token(Token = "0x4011F79")]
	[FieldOffset(Offset = "0x5C")]
	private List<int> m_requestQueue;

	[Token(Token = "0x4011F7A")]
	public const uint PropID_CreateTeam = 2u;

	[Token(Token = "0x4011F7B")]
	public const uint PropID_TeamInfoUpdate = 4u;

	[Token(Token = "0x4011F7C")]
	public const uint PropID_TeamMembersUpdate = 8u;

	[Token(Token = "0x4011F7D")]
	public const uint PropID_QuitTeam = 16u;

	[Token(Token = "0x4011F7E")]
	public const uint PropID_TeamApplicantsUpdate = 32u;

	[Token(Token = "0x4011F7F")]
	public const uint PropID_DismissTeam = 64u;

	[Token(Token = "0x4011F80")]
	public const uint PropID_DismissTeamNotify = 128u;

	[Token(Token = "0x4011F81")]
	public const uint PropID_RemoveNotify = 256u;

	[Token(Token = "0x4011F82")]
	public const uint PropID_Invite = 512u;

	[Token(Token = "0x4011F83")]
	public const uint PropID_TeamInvitationUpdate = 1024u;

	[Token(Token = "0x4011F84")]
	public const uint PropID_ApproveTeamInvitation = 2048u;

	[Token(Token = "0x4011F85")]
	public const uint PropID_JoinTeam = 4096u;

	[Token(Token = "0x4011F86")]
	public const uint PropID_EditContact = 8192u;

	[Token(Token = "0x4011F87")]
	public const uint PropID_MemberPresenceUpdate = 16384u;

	[Token(Token = "0x4011F88")]
	public const uint PropID_ConfirmAddNotify = 32768u;

	[Token(Token = "0x4011F89")]
	public const uint PropID_ChampionshipInfoUpdate = 65536u;

	[Token(Token = "0x4011F8A")]
	public const uint PropID_ChampionshipConfigInfoUpdate = 131072u;

	[Token(Token = "0x4011F8B")]
	public const uint PropID_ModifyTeamInfo = 262144u;

	[Token(Token = "0x4011F8C")]
	public const uint PropID_ChampionshipGameStatsUpdate = 524288u;

	[Token(Token = "0x4011F8D")]
	public const uint PropID_AccountListSeasonStats = 1048576u;

	[Token(Token = "0x4011F8E")]
	public const uint PropID_TeamMatchStatsHistoryNotify = 2097152u;

	[Token(Token = "0x4011F8F")]
	public const uint PropID_TeamIDChange = 4194304u;

	[Token(Token = "0x4011F90")]
	public const uint PropID_GetInvitedIdListUpdate = 8388608u;

	[Token(Token = "0x4011F91")]
	public const uint PARTICIPATIONFLAG = 100000000u;

	[Token(Token = "0x4011F92")]
	public const string NEWSEASONANIM = "CSNewSeasonAnim,Type{0},Season{1}";

	[Token(Token = "0x4011F93")]
	public const string TEAMCLICKLOG = "TeamClickLog,Type{0},Season{1}";

	[Token(Token = "0x4011F94")]
	public const string ENTRANCECLICKLOG = "EntranceClickLog,Type{0},Season{1}";

	[Token(Token = "0x4011F95")]
	public const string NEWSEASONANOTICE = "CSNewSeasonNotice,Type{0},Season{1}";

	[Token(Token = "0x4011F96")]
	[FieldOffset(Offset = "0x60")]
	public Dictionary<uint, bool> m_ChampionshipMatchEnd;

	[Token(Token = "0x4011F97")]
	[FieldOffset(Offset = "0x64")]
	private ChampionshipEntranceState m_HighestPriorityState;

	[Token(Token = "0x4011F98")]
	[FieldOffset(Offset = "0x68")]
	private uint m_HighestPriorityType;

	[Token(Token = "0x4011F99")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_EntranceStateChecked;

	[Token(Token = "0x4011F9A")]
	[FieldOffset(Offset = "0x6D")]
	public bool championshipInfoReady;

	[Token(Token = "0x4011F9B")]
	[FieldOffset(Offset = "0x6E")]
	public bool teamInfoReady;

	[Token(Token = "0x4011F9C")]
	[FieldOffset(Offset = "0x6F")]
	public bool mapInfoReady;

	[Token(Token = "0x4011F9D")]
	[FieldOffset(Offset = "0x70")]
	private bool _003CTeamMemberInitialized_003Ek__BackingField;

	[Token(Token = "0x4011F9E")]
	[FieldOffset(Offset = "0x74")]
	private readonly Dictionary<int, StateViewInfo> m_StateViewInfoDict;

	[Token(Token = "0x4011F9F")]
	private const uint NameOverwriteType_TrialMatchName = 1u;

	[Token(Token = "0x4011FA0")]
	private const uint NameOverwriteType_ModeName = 2u;

	[Token(Token = "0x4011FA1")]
	private const uint NameOverwriteType_SeasonName = 3u;

	[Token(Token = "0x4011FA2")]
	private const uint NameOverwriteType_TimeContent = 4u;

	[Token(Token = "0x4011FA3")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ChampionshipScoreRewardDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011FA4")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<ChampionshipScoreRewardDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011FA5")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<TeamMemberWithAccountInfo, ulong> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x1700146F")]
	public bool TeamMemberInitialized
	{
		[Token(Token = "0x6013AC6")]
		[Address(RVA = "0x32D2FA8", Offset = "0x32D2FA8", VA = "0x32D2FA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013AC7")]
		[Address(RVA = "0x32D2FB0", Offset = "0x32D2FB0", VA = "0x32D2FB0")]
		set
		{
		}
	}

	[Token(Token = "0x6013AC5")]
	[Address(RVA = "0x32D26A4", Offset = "0x32D26A4", VA = "0x32D26A4")]
	public UIModelChampionship()
	{
	}

	[Token(Token = "0x6013AC8")]
	[Address(RVA = "0x32D2FB8", Offset = "0x32D2FB8", VA = "0x32D2FB8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013AC9")]
	[Address(RVA = "0x32D3010", Offset = "0x32D3010", VA = "0x32D3010", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6013ACA")]
	[Address(RVA = "0x32D307C", Offset = "0x32D307C", VA = "0x32D307C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013ACB")]
	[Address(RVA = "0x32D317C", Offset = "0x32D317C", VA = "0x32D317C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013ACC")]
	[Address(RVA = "0x32D34C8", Offset = "0x32D34C8", VA = "0x32D34C8")]
	public bool SelfHasTeam()
	{
		return default(bool);
	}

	[Token(Token = "0x6013ACD")]
	[Address(RVA = "0x32D3588", Offset = "0x32D3588", VA = "0x32D3588")]
	public TeamInfo SelfTeamInfo()
	{
		return null;
	}

	[Token(Token = "0x6013ACE")]
	[Address(RVA = "0x32D3530", Offset = "0x32D3530", VA = "0x32D3530")]
	public ulong SelfTeamID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6013ACF")]
	[Address(RVA = "0x32D35E0", Offset = "0x32D35E0", VA = "0x32D35E0")]
	public bool SelfIsCaptain()
	{
		return default(bool);
	}

	[Token(Token = "0x6013AD0")]
	[Address(RVA = "0x32D3754", Offset = "0x32D3754", VA = "0x32D3754")]
	public uint PlayerNumberLimit(uint cptype)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD1")]
	[Address(RVA = "0x32D3950", Offset = "0x32D3950", VA = "0x32D3950")]
	public uint PlayerNumberLowerLimit(uint cptype)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD2")]
	[Address(RVA = "0x32D38B8", Offset = "0x32D38B8", VA = "0x32D38B8")]
	private uint PlayerNumberLimit(uint cptype, uint cpid)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD3")]
	[Address(RVA = "0x32D39CC", Offset = "0x32D39CC", VA = "0x32D39CC")]
	private uint PlayerNumberLowerLimit(uint cptype, uint cpid)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD4")]
	[Address(RVA = "0x32D3C20", Offset = "0x32D3C20", VA = "0x32D3C20")]
	public ChampionshipTeamDesc TeamSetting(uint cptype)
	{
		return null;
	}

	[Token(Token = "0x6013AD5")]
	[Address(RVA = "0x32D3A64", Offset = "0x32D3A64", VA = "0x32D3A64")]
	public ChampionshipTeamDesc TeamSetting(uint cptype, uint cpid)
	{
		return null;
	}

	[Token(Token = "0x6013AD6")]
	[Address(RVA = "0x32D3E7C", Offset = "0x32D3E7C", VA = "0x32D3E7C")]
	public uint GetLevelLowerLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD7")]
	[Address(RVA = "0x32D3EF4", Offset = "0x32D3EF4", VA = "0x32D3EF4")]
	public uint GetLevelUpperLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD8")]
	[Address(RVA = "0x32D3F6C", Offset = "0x32D3F6C", VA = "0x32D3F6C")]
	public uint GetLadderScoreLowerLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6013AD9")]
	[Address(RVA = "0x32D3FD4", Offset = "0x32D3FD4", VA = "0x32D3FD4")]
	public uint GetLadderScoreUpperLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6013ADA")]
	[Address(RVA = "0x32D404C", Offset = "0x32D404C", VA = "0x32D404C")]
	public List<TeamMemberWithAccountInfo> SelfTeamMembers(bool includeSelf = true)
	{
		return null;
	}

	[Token(Token = "0x6013ADB")]
	[Address(RVA = "0x32D4260", Offset = "0x32D4260", VA = "0x32D4260")]
	public bool IsFriendInTeam(FriendAccountInfo friendInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6013ADC")]
	[Address(RVA = "0x32D4460", Offset = "0x32D4460", VA = "0x32D4460")]
	public List<TeamMemberWithAccountInfo> SelfTeamOnlineMembers(bool includeSelf = true)
	{
		return null;
	}

	[Token(Token = "0x6013ADD")]
	[Address(RVA = "0x32D460C", Offset = "0x32D460C", VA = "0x32D460C")]
	public proto.EPresence.AccountPresence TeamMemberPresence(ulong id)
	{
		return default(proto.EPresence.AccountPresence);
	}

	[Token(Token = "0x6013ADE")]
	[Address(RVA = "0x32D4734", Offset = "0x32D4734", VA = "0x32D4734")]
	public ulong TeamMemberGroupID(ulong id)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013ADF")]
	[Address(RVA = "0x32D4860", Offset = "0x32D4860", VA = "0x32D4860")]
	public string TeamMemberPresenceString(ulong id)
	{
		return null;
	}

	[Token(Token = "0x6013AE0")]
	[Address(RVA = "0x32D4C64", Offset = "0x32D4C64", VA = "0x32D4C64")]
	public List<AccountInfoBasic> TeamApplicants()
	{
		return null;
	}

	[Token(Token = "0x6013AE1")]
	[Address(RVA = "0x32D4CBC", Offset = "0x32D4CBC", VA = "0x32D4CBC")]
	public List<AccountInfoBasic> TeamInvitations()
	{
		return null;
	}

	[Token(Token = "0x6013AE2")]
	[Address(RVA = "0x32D4D14", Offset = "0x32D4D14", VA = "0x32D4D14")]
	public uint GetTeamRank(uint cpType, ulong teamID, out string formatRank)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AE3")]
	[Address(RVA = "0x32D51D4", Offset = "0x32D51D4", VA = "0x32D51D4")]
	public bool CheckJoinCreateTimeSatisfy(out string error)
	{
		return default(bool);
	}

	[Token(Token = "0x6013AE4")]
	[Address(RVA = "0x32D5410", Offset = "0x32D5410", VA = "0x32D5410")]
	public bool CheckLevelSatisfy()
	{
		return default(bool);
	}

	[Token(Token = "0x6013AE5")]
	[Address(RVA = "0x32D5590", Offset = "0x32D5590", VA = "0x32D5590")]
	public bool CheckLadderScoreSatisfy()
	{
		return default(bool);
	}

	[Token(Token = "0x6013AE6")]
	[Address(RVA = "0x32D5718", Offset = "0x32D5718", VA = "0x32D5718")]
	public proto.ChampionshipInfo GetChampionshipInfoByType(uint type)
	{
		return null;
	}

	[Token(Token = "0x6013AE7")]
	[Address(RVA = "0x32D57FC", Offset = "0x32D57FC", VA = "0x32D57FC")]
	public ChampionshipOpenInfoDesc GetChampionshipOpenInfo(uint type, uint championshipID)
	{
		return null;
	}

	[Token(Token = "0x6013AE8")]
	[Address(RVA = "0x32D5978", Offset = "0x32D5978", VA = "0x32D5978")]
	public uint[] GetChampionshipMaps(uint type)
	{
		return null;
	}

	[Token(Token = "0x6013AE9")]
	[Address(RVA = "0x32D5B84", Offset = "0x32D5B84", VA = "0x32D5B84")]
	public bool IsInBlackList()
	{
		return default(bool);
	}

	[Token(Token = "0x6013AEA")]
	[Address(RVA = "0x32D5BFC", Offset = "0x32D5BFC", VA = "0x32D5BFC")]
	public uint GetCurMembersNum()
	{
		return default(uint);
	}

	[Token(Token = "0x6013AEB")]
	[Address(RVA = "0x32D5CC0", Offset = "0x32D5CC0", VA = "0x32D5CC0")]
	public uint GetTeamScale(uint cpType)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AEC")]
	[Address(RVA = "0x32D5D2C", Offset = "0x32D5D2C", VA = "0x32D5D2C")]
	public proto.EChampionship.TeamScaleType GetTeamScaleType(uint cpType)
	{
		return default(proto.EChampionship.TeamScaleType);
	}

	[Token(Token = "0x6013AED")]
	[Address(RVA = "0x32D3C9C", Offset = "0x32D3C9C", VA = "0x32D3C9C")]
	public ChampionshipSettingDesc GetChampionshipSetting(uint type, uint championshipID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6013AEE")]
	[Address(RVA = "0x32D5DBC", Offset = "0x32D5DBC", VA = "0x32D5DBC")]
	public ChampionshipScoreBaseDesc GetChampionshipScoreBaseInfoByType(uint type)
	{
		return null;
	}

	[Token(Token = "0x6013AEF")]
	[Address(RVA = "0x32D37D0", Offset = "0x32D37D0", VA = "0x32D37D0")]
	public uint GetCurrentChampionshipIDByType(uint type)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AF0")]
	[Address(RVA = "0x32D5F14", Offset = "0x32D5F14", VA = "0x32D5F14")]
	public float GetChampionshipExtraBonusByType(uint type, uint bonusType)
	{
		return default(float);
	}

	[Token(Token = "0x6013AF1")]
	[Address(RVA = "0x32D5FBC", Offset = "0x32D5FBC", VA = "0x32D5FBC")]
	public List<AwardDesc> GetChampionshipRewardListByPos(uint championshipType, uint championshipId, int pos)
	{
		return null;
	}

	[Token(Token = "0x6013AF2")]
	[Address(RVA = "0x32D635C", Offset = "0x32D635C", VA = "0x32D635C")]
	public int GetChampionshipRewardIndexByPos(uint championshipType, uint championshipId, int pos)
	{
		return default(int);
	}

	[Token(Token = "0x6013AF3")]
	[Address(RVA = "0x32D64F4", Offset = "0x32D64F4", VA = "0x32D64F4")]
	public ChampionshipScoreRewardDesc GetLowestChampionshipRewardDesc(uint championshipType, uint championshipId)
	{
		return null;
	}

	[Token(Token = "0x6013AF4")]
	[Address(RVA = "0x32D6670", Offset = "0x32D6670", VA = "0x32D6670")]
	public ChampionshipScoreRewardDesc GetFirstChampionshipRewardDesc(uint championshipType, uint championshipId)
	{
		return null;
	}

	[Token(Token = "0x6013AF5")]
	[Address(RVA = "0x32D617C", Offset = "0x32D617C", VA = "0x32D617C")]
	public List<ChampionshipScoreRewardDesc> GetChampionshipAllRewardDesc(uint championshipType, uint championshipId)
	{
		return null;
	}

	[Token(Token = "0x6013AF6")]
	[Address(RVA = "0x32D67E8", Offset = "0x32D67E8", VA = "0x32D67E8")]
	private uint GenerateAwardsListKey(uint championshipType, uint championshipID)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AF7")]
	[Address(RVA = "0x32D6868", Offset = "0x32D6868", VA = "0x32D6868")]
	public string GetRankPosRange(uint championshipType, uint championshipId, int pos)
	{
		return null;
	}

	[Token(Token = "0x6013AF8")]
	[Address(RVA = "0x32D6E34", Offset = "0x32D6E34", VA = "0x32D6E34")]
	public StateViewInfo GetStateViewInfo(ChampionshipOpenState curState)
	{
		return default(StateViewInfo);
	}

	[Token(Token = "0x6013AF9")]
	[Address(RVA = "0x32D62BC", Offset = "0x32D62BC", VA = "0x32D62BC")]
	public uint FixRankPos(uint championshipType, uint championshipID, int rank)
	{
		return default(uint);
	}

	[Token(Token = "0x6013AFA")]
	[Address(RVA = "0x32D6FA0", Offset = "0x32D6FA0", VA = "0x32D6FA0")]
	public void UpdateTeamInfoEditCD()
	{
	}

	[Token(Token = "0x6013AFB")]
	[Address(RVA = "0x32D7130", Offset = "0x32D7130", VA = "0x32D7130")]
	public ulong TeamInfoEditCD()
	{
		return default(ulong);
	}

	[Token(Token = "0x6013AFC")]
	[Address(RVA = "0x32D7188", Offset = "0x32D7188", VA = "0x32D7188")]
	public bool ChampionshipIsOpen(uint type, uint championshipID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013AFD")]
	[Address(RVA = "0x32D7308", Offset = "0x32D7308", VA = "0x32D7308")]
	public bool ChampionshipIsSeniorTeamOnly(uint type, uint championshipID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013AFE")]
	[Address(RVA = "0x32D73AC", Offset = "0x32D73AC", VA = "0x32D73AC")]
	public void ProcessChampionshipInfo(CSChampionshipBasicInfoRes championshipInfoRes)
	{
	}

	[Token(Token = "0x6013AFF")]
	[Address(RVA = "0x32D7AD0", Offset = "0x32D7AD0", VA = "0x32D7AD0")]
	private void PreDownload()
	{
	}

	[Token(Token = "0x6013B00")]
	[Address(RVA = "0x32D78E0", Offset = "0x32D78E0", VA = "0x32D78E0")]
	private void InitCurrentChampionshipID(List<ChampionshipOpenInfoDesc> openInfoList)
	{
	}

	[Token(Token = "0x6013B01")]
	[Address(RVA = "0x32D7454", Offset = "0x32D7454", VA = "0x32D7454")]
	private void ProcessChampionshipRewardInfo(List<ChampionshipScoreRewardDesc> rewardsDescList)
	{
	}

	[Token(Token = "0x6013B02")]
	[Address(RVA = "0x32D7EBC", Offset = "0x32D7EBC", VA = "0x32D7EBC")]
	public void RequestCreateTeam(string name, string contactInfo, string countryOrArea, uint clanAvatar, uint clanBanner, proto.EChampionship.TeamScaleType scaleType)
	{
	}

	[Token(Token = "0x6013B03")]
	[Address(RVA = "0x32D81FC", Offset = "0x32D81FC", VA = "0x32D81FC")]
	public void RequestJoinTeam(ulong friendID, ulong teamID)
	{
	}

	[Token(Token = "0x6013B04")]
	[Address(RVA = "0x32D851C", Offset = "0x32D851C", VA = "0x32D851C")]
	public void RequestModifyTeamInfo(string teamName, string countryOrArea, uint clanAvatar, uint clanBanner)
	{
	}

	[Token(Token = "0x6013B05")]
	[Address(RVA = "0x32D8854", Offset = "0x32D8854", VA = "0x32D8854")]
	public void RequestEditTeamContactInfo(string contact)
	{
	}

	[Token(Token = "0x6013B06")]
	[Address(RVA = "0x32D8AC0", Offset = "0x32D8AC0", VA = "0x32D8AC0")]
	public void RequestTeamInfoByTeamID(ulong teamID, bool requestTeamApplication = false)
	{
	}

	[Token(Token = "0x6013B07")]
	[Address(RVA = "0x32D8E88", Offset = "0x32D8E88", VA = "0x32D8E88")]
	public void RequestSelfTeamMembers()
	{
	}

	[Token(Token = "0x6013B08")]
	[Address(RVA = "0x32D8F10", Offset = "0x32D8F10", VA = "0x32D8F10")]
	public void RequestTeamMembers(ulong teamID, bool requestTeamMemberPresence = false, bool forcePresence = false)
	{
	}

	[Token(Token = "0x6013B09")]
	[Address(RVA = "0x32D91D0", Offset = "0x32D91D0", VA = "0x32D91D0")]
	public void RequestTeamMatchStatsHistory(ulong teamID)
	{
	}

	[Token(Token = "0x6013B0A")]
	[Address(RVA = "0x32D9884", Offset = "0x32D9884", VA = "0x32D9884")]
	public void RequestQuitTeam(bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	[Token(Token = "0x6013B0B")]
	[Address(RVA = "0x32D9C58", Offset = "0x32D9C58", VA = "0x32D9C58")]
	public void RequestDismissTeam(bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	[Token(Token = "0x6013B0C")]
	[Address(RVA = "0x32DA010", Offset = "0x32DA010", VA = "0x32DA010")]
	public void RequestTeamApplicantList()
	{
	}

	[Token(Token = "0x6013B0D")]
	[Address(RVA = "0x32DA274", Offset = "0x32DA274", VA = "0x32DA274")]
	public void RequestInvitationList()
	{
	}

	[Token(Token = "0x6013B0E")]
	[Address(RVA = "0x32DA498", Offset = "0x32DA498", VA = "0x32DA498")]
	public void RequestInvitedIdList()
	{
	}

	[Token(Token = "0x6013B0F")]
	[Address(RVA = "0x32DA6EC", Offset = "0x32DA6EC", VA = "0x32DA6EC")]
	public bool IsInvitedAccount(FriendAccountInfo accountInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B10")]
	[Address(RVA = "0x32DA7E0", Offset = "0x32DA7E0", VA = "0x32DA7E0")]
	public void RequestApproveApplication(AccountInfoBasic basicInfo)
	{
	}

	[Token(Token = "0x6013B11")]
	[Address(RVA = "0x32DAB24", Offset = "0x32DAB24", VA = "0x32DAB24")]
	public void RequestDeclineApplication(ulong[] applicantIDs)
	{
	}

	[Token(Token = "0x6013B12")]
	[Address(RVA = "0x32DAE70", Offset = "0x32DAE70", VA = "0x32DAE70")]
	public void RequestInvite(ulong inviteeID)
	{
	}

	[Token(Token = "0x6013B13")]
	[Address(RVA = "0x32DB170", Offset = "0x32DB170", VA = "0x32DB170")]
	public void RequestApproveJoinTeamInvitation(ulong inviter, ulong inviterTeam)
	{
	}

	[Token(Token = "0x6013B14")]
	[Address(RVA = "0x32DB4E4", Offset = "0x32DB4E4", VA = "0x32DB4E4")]
	public void RequestDeclineJoinTeamInvitation(ulong[] inviterIDs)
	{
	}

	[Token(Token = "0x6013B15")]
	[Address(RVA = "0x32DB81C", Offset = "0x32DB81C", VA = "0x32DB81C")]
	public void RequestTeamMemberPresence(bool force = false)
	{
	}

	[Token(Token = "0x6013B16")]
	[Address(RVA = "0x32DBA64", Offset = "0x32DBA64", VA = "0x32DBA64")]
	public void RequestRemoveTeamMember(ulong removeeID)
	{
	}

	[Token(Token = "0x6013B17")]
	[Address(RVA = "0x32DBDB0", Offset = "0x32DBDB0", VA = "0x32DBDB0")]
	public void RequestGetTeamChampionshipInfo(uint championshipID, uint championshipType)
	{
	}

	[Token(Token = "0x6013B18")]
	[Address(RVA = "0x32DC0B8", Offset = "0x32DC0B8", VA = "0x32DC0B8")]
	public void RequestInitTeamChampionshipInfo(uint championshipType, uint httpOption = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013B19")]
	[Address(RVA = "0x32DC378", Offset = "0x32DC378", VA = "0x32DC378")]
	public void RequestChampionshipConfig(uint championshipID, uint championshipType = 1u, uint httpOption = 0u)
	{
	}

	[Token(Token = "0x6013B1A")]
	[Address(RVA = "0x32DC6DC", Offset = "0x32DC6DC", VA = "0x32DC6DC")]
	public void RequestChampionshipStatsInfo(ulong teamID, uint championshipType, uint championshipID, bool needTeamMembersInfo = false)
	{
	}

	[Token(Token = "0x6013B1B")]
	[Address(RVA = "0x32DC994", Offset = "0x32DC994", VA = "0x32DC994")]
	public void RequestAccountLifeSeasonStats(ulong accountID, uint championshipType)
	{
	}

	[Token(Token = "0x6013B1C")]
	[Address(RVA = "0x32DCBF8", Offset = "0x32DCBF8", VA = "0x32DCBF8")]
	public void OnJoinApplicantNotify()
	{
	}

	[Token(Token = "0x6013B1D")]
	[Address(RVA = "0x32DCC58", Offset = "0x32DCC58", VA = "0x32DCC58")]
	public void OnConfrimAddNotify(ConfirmAddChampionshipTeamReq ntf)
	{
	}

	[Token(Token = "0x6013B1E")]
	[Address(RVA = "0x32DD090", Offset = "0x32DD090", VA = "0x32DD090")]
	public void OnDismissNotify(ulong teamID)
	{
	}

	[Token(Token = "0x6013B1F")]
	[Address(RVA = "0x32DD1A4", Offset = "0x32DD1A4", VA = "0x32DD1A4")]
	public void OnRemoveNotify(ulong teamID, ulong removeeID)
	{
	}

	[Token(Token = "0x6013B20")]
	[Address(RVA = "0x32DD590", Offset = "0x32DD590", VA = "0x32DD590")]
	public void OnInviteNotify()
	{
	}

	[Token(Token = "0x6013B21")]
	[Address(RVA = "0x32DD5F0", Offset = "0x32DD5F0", VA = "0x32DD5F0")]
	public void OnApproveInviteNotify()
	{
	}

	[Token(Token = "0x6013B22")]
	[Address(RVA = "0x32DD694", Offset = "0x32DD694", VA = "0x32DD694")]
	public void OnTeamMemeberPresenceNotify(PresenceListRes presenceData)
	{
	}

	[Token(Token = "0x6013B23")]
	[Address(RVA = "0x32DCD60", Offset = "0x32DCD60", VA = "0x32DCD60")]
	private void UpdateTeamID(ulong teamID)
	{
	}

	[Token(Token = "0x6013B24")]
	[Address(RVA = "0x32DDA44", Offset = "0x32DDA44", VA = "0x32DDA44")]
	public void SortTeamMember(List<TeamMemberWithAccountInfo> members, bool sortPresence, TeamInfo teamInfo)
	{
	}

	[Token(Token = "0x6013B25")]
	[Address(RVA = "0x32DDBC8", Offset = "0x32DDBC8", VA = "0x32DDBC8")]
	public ChampionshipNameOverwriteDesc GetChampionshipNameoverwriteDesc(uint championshipType, uint championshipID = 0u, uint nameType = 0u)
	{
		return null;
	}

	[Token(Token = "0x6013B26")]
	[Address(RVA = "0x32DDE30", Offset = "0x32DDE30", VA = "0x32DDE30")]
	public string GetSeasonStartEndTimeString(ChampionshipOpenInfoDesc championshipOpenInfo, bool showYear = true)
	{
		return null;
	}

	[Token(Token = "0x6013B27")]
	[Address(RVA = "0x32DE260", Offset = "0x32DE260", VA = "0x32DE260")]
	public string GetSeasonEndTimeString(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
		return null;
	}

	[Token(Token = "0x6013B28")]
	[Address(RVA = "0x32DE3CC", Offset = "0x32DE3CC", VA = "0x32DE3CC")]
	public uint GetChampionshipID(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B29")]
	[Address(RVA = "0x32DE43C", Offset = "0x32DE43C", VA = "0x32DE43C")]
	public int GetRankPos(uint championshipType)
	{
		return default(int);
	}

	[Token(Token = "0x6013B2A")]
	[Address(RVA = "0x32D514C", Offset = "0x32D514C", VA = "0x32D514C")]
	public int GetPropIDByChampionshipType(uint championshipType)
	{
		return default(int);
	}

	[Token(Token = "0x6013B2B")]
	[Address(RVA = "0x32DE5F8", Offset = "0x32DE5F8", VA = "0x32DE5F8")]
	public uint GetValidScore(proto.ChampionshipInfo championshipInfo)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B2C")]
	[Address(RVA = "0x32DE674", Offset = "0x32DE674", VA = "0x32DE674")]
	public uint GetTotalScore(proto.ChampionshipInfo championshipInfo)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B2D")]
	[Address(RVA = "0x32DE6F0", Offset = "0x32DE6F0", VA = "0x32DE6F0")]
	public uint GetMatchTotalNum(ChampionshipSettingDesc championshipSettingInfo)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B2E")]
	[Address(RVA = "0x32DE760", Offset = "0x32DE760", VA = "0x32DE760")]
	public string GetChampionshipTrialMatchName(uint championshipType, uint championshipID = 0u, string originNameKey = "")
	{
		return null;
	}

	[Token(Token = "0x6013B2F")]
	[Address(RVA = "0x32DEBEC", Offset = "0x32DEBEC", VA = "0x32DEBEC")]
	public string GetChampionshipModeName(uint championshipType, uint championshipID)
	{
		return null;
	}

	[Token(Token = "0x6013B30")]
	[Address(RVA = "0x32DEF54", Offset = "0x32DEF54", VA = "0x32DEF54")]
	public string GetChampionshipSeasonNameWithIDOverwrite(uint championshipType, uint championshipID)
	{
		return null;
	}

	[Token(Token = "0x6013B31")]
	[Address(RVA = "0x32DF448", Offset = "0x32DF448", VA = "0x32DF448")]
	private void SetTicketsNum(uint type, uint ticketInfoCnt)
	{
	}

	[Token(Token = "0x6013B32")]
	[Address(RVA = "0x32DF5B0", Offset = "0x32DF5B0", VA = "0x32DF5B0")]
	private void SetPlayedTimes(uint type, uint playedNum)
	{
	}

	[Token(Token = "0x6013B33")]
	[Address(RVA = "0x32DF718", Offset = "0x32DF718", VA = "0x32DF718")]
	public uint GetTicketsNum(uint type)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B34")]
	[Address(RVA = "0x32DF800", Offset = "0x32DF800", VA = "0x32DF800")]
	public uint GetPlayedTimes(uint type)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B35")]
	[Address(RVA = "0x32DF8E8", Offset = "0x32DF8E8", VA = "0x32DF8E8")]
	public void AddPlayedTimes(uint type, uint num = 1u)
	{
	}

	[Token(Token = "0x6013B36")]
	[Address(RVA = "0x32DFA20", Offset = "0x32DFA20", VA = "0x32DFA20")]
	public void DeductTicket(uint type, uint cnt = 1u)
	{
	}

	[Token(Token = "0x6013B37")]
	[Address(RVA = "0x32DFB58", Offset = "0x32DFB58", VA = "0x32DFB58")]
	public bool HasUnTeamMemberPlayerInGroup(List<GroupMemberInfo> members)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B38")]
	[Address(RVA = "0x32DFE2C", Offset = "0x32DFE2C", VA = "0x32DFE2C")]
	public List<uint> GetOpenChampionshipTypeList()
	{
		return null;
	}

	[Token(Token = "0x6013B39")]
	[Address(RVA = "0x32DFF68", Offset = "0x32DFF68", VA = "0x32DFF68")]
	public ChampionshipOpenState GetChampionshipOpenState(ChampionshipOpenInfoDesc championshipOpenInfo)
	{
		return default(ChampionshipOpenState);
	}

	[Token(Token = "0x6013B3A")]
	[Address(RVA = "0x32E0758", Offset = "0x32E0758", VA = "0x32E0758")]
	public ulong GetMapCloseTime(uint championshipType)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013B3B")]
	[Address(RVA = "0x32E099C", Offset = "0x32E099C", VA = "0x32E099C")]
	public ulong GetNextOpenTime(ChampionshipOpenInfoDesc championshipOpenInfo, ChampionshipOpenState championshipState)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013B3C")]
	[Address(RVA = "0x32E02D8", Offset = "0x32E02D8", VA = "0x32E02D8")]
	private void SetTipsIfDifferentOpenDay(MapOpeningInfo mapInfo)
	{
	}

	[Token(Token = "0x6013B3D")]
	[Address(RVA = "0x32E0C10", Offset = "0x32E0C10", VA = "0x32E0C10")]
	public bool IsTrialStart(ChampionshipOpenState state)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B3E")]
	[Address(RVA = "0x32DE584", Offset = "0x32DE584", VA = "0x32DE584")]
	public bool IsFFCCUP(uint cptype)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B3F")]
	[Address(RVA = "0x32D961C", Offset = "0x32D961C", VA = "0x32D961C")]
	public uint GetCurrentOpenChampionshipType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013B40")]
	[Address(RVA = "0x32E0C80", Offset = "0x32E0C80", VA = "0x32E0C80")]
	public uint GetLastChampionshipType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013B41")]
	[Address(RVA = "0x32E0E90", Offset = "0x32E0E90", VA = "0x32E0E90")]
	public uint GetLastThirdPartyChampionshipType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013B42")]
	[Address(RVA = "0x32E10BC", Offset = "0x32E10BC", VA = "0x32E10BC")]
	public uint GetLastFFCCupChampionshipType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013B43")]
	[Address(RVA = "0x32E12E8", Offset = "0x32E12E8", VA = "0x32E12E8", Slot = "16")]
	public bool AllProtocalReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6013B44")]
	[Address(RVA = "0x32E1368", Offset = "0x32E1368", VA = "0x32E1368", Slot = "18")]
	public bool CanShowEntranceCountDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6013B45")]
	[Address(RVA = "0x32E1508", Offset = "0x32E1508", VA = "0x32E1508", Slot = "22")]
	public DateTime MatchStartTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x6013B46")]
	[Address(RVA = "0x32E1698", Offset = "0x32E1698", VA = "0x32E1698", Slot = "19")]
	public ulong GetCountDownTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x6013B47")]
	[Address(RVA = "0x32E1704", Offset = "0x32E1704", VA = "0x32E1704", Slot = "23")]
	public int LobbyEntrancePriority()
	{
		return default(int);
	}

	[Token(Token = "0x6013B48")]
	[Address(RVA = "0x32E175C", Offset = "0x32E175C", VA = "0x32E175C")]
	public bool IsLeaderBoardOpen(uint cpType, uint cpID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B49")]
	[Address(RVA = "0x32E18D0", Offset = "0x32E18D0", VA = "0x32E18D0")]
	private bool IsLeaderBoardOpenPublic(uint cpType, uint cpID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B4A")]
	[Address(RVA = "0x32E1800", Offset = "0x32E1800", VA = "0x32E1800")]
	public bool HasPlayedOneGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6013B4B")]
	[Address(RVA = "0x32E1A4C", Offset = "0x32E1A4C", VA = "0x32E1A4C")]
	public bool IsReplayEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6013B4C")]
	[Address(RVA = "0x32E1C00", Offset = "0x32E1C00", VA = "0x32E1C00")]
	public bool IsDisableWeaponSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x6013B4D")]
	[Address(RVA = "0x32E1C8C", Offset = "0x32E1C8C", VA = "0x32E1C8C", Slot = "17")]
	public bool SetEntranceBtnState()
	{
		return default(bool);
	}

	[Token(Token = "0x6013B4E")]
	[Address(RVA = "0x32E149C", Offset = "0x32E149C", VA = "0x32E149C", Slot = "14")]
	public OnlineMatchEntranceState GetEntranceBtnState()
	{
		return default(OnlineMatchEntranceState);
	}

	[Token(Token = "0x6013B4F")]
	[Address(RVA = "0x32E1DE8", Offset = "0x32E1DE8", VA = "0x32E1DE8", Slot = "15")]
	public void SetEntranceWarmUpState()
	{
	}

	[Token(Token = "0x6013B50")]
	[Address(RVA = "0x32E1430", Offset = "0x32E1430", VA = "0x32E1430")]
	public uint GetHightestPriorityMatchType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013B51")]
	[Address(RVA = "0x32E21C0", Offset = "0x32E21C0", VA = "0x32E21C0", Slot = "20")]
	public void SetLobbyEntranceWarmUpPlayerPrefs()
	{
	}

	[Token(Token = "0x6013B52")]
	[Address(RVA = "0x32E2528", Offset = "0x32E2528", VA = "0x32E2528", Slot = "21")]
	public void SetLobbyEntranceMatchOpenPlayerPrefs()
	{
	}

	[Token(Token = "0x6013B53")]
	[Address(RVA = "0x32E2780", Offset = "0x32E2780", VA = "0x32E2780")]
	public void SetTeamInfoFlag()
	{
	}

	[Token(Token = "0x6013B54")]
	[Address(RVA = "0x32D7D84", Offset = "0x32D7D84", VA = "0x32D7D84")]
	public void SetChampionshipInfoFlag()
	{
	}

	[Token(Token = "0x6013B55")]
	[Address(RVA = "0x32E28B8", Offset = "0x32E28B8", VA = "0x32E28B8")]
	public void SetMapInfoFlag()
	{
	}

	[Token(Token = "0x6013B56")]
	[Address(RVA = "0x32D6CD4", Offset = "0x32D6CD4", VA = "0x32D6CD4")]
	public uint GetRewardPercent(uint bound)
	{
		return default(uint);
	}

	[Token(Token = "0x6013B57")]
	[Address(RVA = "0x32E29F0", Offset = "0x32E29F0", VA = "0x32E29F0")]
	private bool _003CSelfTeamOnlineMembers_003Em__0(TeamMemberWithAccountInfo member)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B58")]
	[Address(RVA = "0x32E2A44", Offset = "0x32E2A44", VA = "0x32E2A44")]
	private static bool _003CGetLowestChampionshipRewardDesc_003Em__1(ChampionshipScoreRewardDesc r)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B59")]
	[Address(RVA = "0x32E2A7C", Offset = "0x32E2A7C", VA = "0x32E2A7C")]
	private static bool _003CGetFirstChampionshipRewardDesc_003Em__2(ChampionshipScoreRewardDesc r)
	{
		return default(bool);
	}

	[Token(Token = "0x6013B5A")]
	[Address(RVA = "0x32E2AA8", Offset = "0x32E2AA8", VA = "0x32E2AA8")]
	private void _003CRequestCreateTeam_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B5B")]
	[Address(RVA = "0x32E2C9C", Offset = "0x32E2C9C", VA = "0x32E2C9C")]
	private void _003CRequestModifyTeamInfo_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B5C")]
	[Address(RVA = "0x32E2DBC", Offset = "0x32E2DBC", VA = "0x32E2DBC")]
	private void _003CRequestEditTeamContactInfo_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B5D")]
	[Address(RVA = "0x32E2EF8", Offset = "0x32E2EF8", VA = "0x32E2EF8")]
	private void _003CRequestTeamApplicantList_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B5E")]
	[Address(RVA = "0x32E32CC", Offset = "0x32E32CC", VA = "0x32E32CC")]
	private void _003CRequestInvitationList_003Em__7(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B5F")]
	[Address(RVA = "0x32E3618", Offset = "0x32E3618", VA = "0x32E3618")]
	private void _003CRequestInvitedIdList_003Em__8(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B60")]
	[Address(RVA = "0x32E39C8", Offset = "0x32E39C8", VA = "0x32E39C8")]
	private static ulong _003CRequestTeamMemberPresence_003Em__9(TeamMemberWithAccountInfo e)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013B61")]
	[Address(RVA = "0x32E3A00", Offset = "0x32E3A00", VA = "0x32E3A00")]
	private void _003CRequestInitTeamChampionshipInfo_003Em__A(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B62")]
	[Address(RVA = "0x32E3C2C", Offset = "0x32E3C2C", VA = "0x32E3C2C")]
	private void _003CRequestChampionshipStatsInfo_003Em__B(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B63")]
	[Address(RVA = "0x32E3DEC", Offset = "0x32E3DEC", VA = "0x32E3DEC")]
	private void _003CRequestAccountLifeSeasonStats_003Em__C(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013B64")]
	[Address(RVA = "0x32E3FB8", Offset = "0x32E3FB8", VA = "0x32E3FB8")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6013B65")]
	[Address(RVA = "0x32E3FC0", Offset = "0x32E3FC0", VA = "0x32E3FC0")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013B66")]
	[Address(RVA = "0x32E3FC8", Offset = "0x32E3FC8", VA = "0x32E3FC8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
