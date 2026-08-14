using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002FDE")]
public class UIModelCupMatch : UIBaseModel, _Attribute
{
	[Token(Token = "0x2002FDF")]
	public enum MemberType
	{
		[Token(Token = "0x40123F5")]
		Normal = 1,
		[Token(Token = "0x40123F6")]
		Captain
	}

	[Token(Token = "0x2002FE0")]
	public class NotifyArgs
	{
		[Token(Token = "0x40123F7")]
		[FieldOffset(Offset = "0x8")]
		public bool success;

		[Token(Token = "0x40123F8")]
		[FieldOffset(Offset = "0xC")]
		public int key;

		[Token(Token = "0x40123F9")]
		[FieldOffset(Offset = "0x10")]
		public bool needCheckKey;

		[Token(Token = "0x60140E4")]
		[Address(RVA = "0x15C1660", Offset = "0x15C1660", VA = "0x15C1660")]
		public NotifyArgs()
		{
		}
	}

	[Token(Token = "0x2002FE1")]
	public class NotifyArgsRemove : NotifyArgs
	{
		[Token(Token = "0x40123FA")]
		[FieldOffset(Offset = "0x11")]
		public bool removeSelf;

		[Token(Token = "0x60140E5")]
		[Address(RVA = "0x15C7F50", Offset = "0x15C7F50", VA = "0x15C7F50")]
		public NotifyArgsRemove()
		{
		}
	}

	[Token(Token = "0x2002FE2")]
	public class NotifyArgsJoin : NotifyArgs
	{
		[Token(Token = "0x40123FB")]
		[FieldOffset(Offset = "0x18")]
		public ulong friendID;

		[Token(Token = "0x40123FC")]
		[FieldOffset(Offset = "0x20")]
		public bool teamIsFull;

		[Token(Token = "0x40123FD")]
		[FieldOffset(Offset = "0x21")]
		public bool sameTeamRequest;

		[Token(Token = "0x60140E6")]
		[Address(RVA = "0x15C54E8", Offset = "0x15C54E8", VA = "0x15C54E8")]
		public NotifyArgsJoin()
		{
		}
	}

	[Token(Token = "0x2002FE3")]
	public class NotifyArgsInvite : NotifyArgs
	{
		[Token(Token = "0x40123FE")]
		[FieldOffset(Offset = "0x18")]
		public ulong invitee;

		[Token(Token = "0x40123FF")]
		[FieldOffset(Offset = "0x20")]
		public bool sameRequest;

		[Token(Token = "0x60140E7")]
		[Address(RVA = "0x15C4A48", Offset = "0x15C4A48", VA = "0x15C4A48")]
		public NotifyArgsInvite()
		{
		}
	}

	[Token(Token = "0x2002FE4")]
	public class NotifyArgsQuit : NotifyArgs
	{
		[Token(Token = "0x4012400")]
		[FieldOffset(Offset = "0x11")]
		public bool toNewTeam;

		[Token(Token = "0x60140E8")]
		[Address(RVA = "0x15C5F10", Offset = "0x15C5F10", VA = "0x15C5F10")]
		public NotifyArgsQuit()
		{
		}
	}

	[Token(Token = "0x2002FE5")]
	public class NotifyArgsDismiss : NotifyArgs
	{
		[Token(Token = "0x4012401")]
		[FieldOffset(Offset = "0x11")]
		public bool toNewTeam;

		[Token(Token = "0x60140E9")]
		[Address(RVA = "0x15C3E68", Offset = "0x15C3E68", VA = "0x15C3E68")]
		public NotifyArgsDismiss()
		{
		}
	}

	[Token(Token = "0x2002FE6")]
	public class NotifyArgsTeamInfo : NotifyArgs
	{
		[Token(Token = "0x4012402")]
		[FieldOffset(Offset = "0x14")]
		public CupTeamInfo teamInfo;

		[Token(Token = "0x60140EA")]
		[Address(RVA = "0x15C1670", Offset = "0x15C1670", VA = "0x15C1670")]
		public NotifyArgsTeamInfo()
		{
		}
	}

	[Token(Token = "0x2002FE7")]
	public class NotifyArgsTeamMemberInfo : NotifyArgs
	{
		[Token(Token = "0x4012403")]
		[FieldOffset(Offset = "0x14")]
		public List<AccountInfoBasicWithCupInfo> teamMemberInfo;

		[Token(Token = "0x4012404")]
		[FieldOffset(Offset = "0x18")]
		public bool requestedPresence;

		[Token(Token = "0x60140EB")]
		[Address(RVA = "0x15C1FCC", Offset = "0x15C1FCC", VA = "0x15C1FCC")]
		public NotifyArgsTeamMemberInfo()
		{
		}
	}

	[Token(Token = "0x2002FE8")]
	public class NotifyArgsAccountCupInfoBundle : NotifyArgs
	{
		[Token(Token = "0x4012405")]
		[FieldOffset(Offset = "0x11")]
		public bool isSearch;

		[Token(Token = "0x60140EC")]
		[Address(RVA = "0x15C7F40", Offset = "0x15C7F40", VA = "0x15C7F40")]
		public NotifyArgsAccountCupInfoBundle()
		{
		}
	}

	[Token(Token = "0x2002FE9")]
	public struct StateViewInfo
	{
		[Token(Token = "0x4012406")]
		[FieldOffset(Offset = "0x0")]
		public string stateText;

		[Token(Token = "0x4012407")]
		[FieldOffset(Offset = "0x4")]
		public string stateDescText;
	}

	[Token(Token = "0x2002FEA")]
	public enum CupMatchOpenState
	{
		[Token(Token = "0x4012409")]
		UnOpen,
		[Token(Token = "0x401240A")]
		EntranceOpen,
		[Token(Token = "0x401240B")]
		SeasonOpen,
		[Token(Token = "0x401240C")]
		TodayOpen,
		[Token(Token = "0x401240D")]
		TodayUnOpen,
		[Token(Token = "0x401240E")]
		Result,
		[Token(Token = "0x401240F")]
		MatchClose,
		[Token(Token = "0x4012410")]
		SeasonClose
	}

	[Token(Token = "0x2002FEB")]
	public enum CupMatchResult
	{
		[Token(Token = "0x4012412")]
		Win,
		[Token(Token = "0x4012413")]
		Lose,
		[Token(Token = "0x4012414")]
		UnKnow
	}

	[Token(Token = "0x2002FEC")]
	public enum CupMatchEntranceState
	{
		[Token(Token = "0x4012416")]
		Closed,
		[Token(Token = "0x4012417")]
		Paused,
		[Token(Token = "0x4012418")]
		WarmUp,
		[Token(Token = "0x4012419")]
		Opened
	}

	[Token(Token = "0x2002FED")]
	public class AccountInfoBasicWithCupInfo
	{
		[Token(Token = "0x401241A")]
		[FieldOffset(Offset = "0x8")]
		public AccountInfoBasic AccountInfoBasic;

		[Token(Token = "0x401241B")]
		[FieldOffset(Offset = "0xC")]
		public uint Tier;

		[Token(Token = "0x401241C")]
		[FieldOffset(Offset = "0x10")]
		public ulong TeamID;

		[Token(Token = "0x401241D")]
		[FieldOffset(Offset = "0x18")]
		public bool UseTicket;

		[Token(Token = "0x401241E")]
		[FieldOffset(Offset = "0x1C")]
		public uint MemberType;

		[Token(Token = "0x60140ED")]
		[Address(RVA = "0x15C466C", Offset = "0x15C466C", VA = "0x15C466C")]
		public AccountInfoBasicWithCupInfo()
		{
		}
	}

	[Token(Token = "0x2002FEE")]
	private sealed class _003CGetCupChestList_003Ec__AnonStorey0
	{
		[Token(Token = "0x401241F")]
		[FieldOffset(Offset = "0x8")]
		internal uint tier;

		[Token(Token = "0x4012420")]
		[FieldOffset(Offset = "0xC")]
		internal bool isTicket;

		[Token(Token = "0x60140EE")]
		[Address(RVA = "0x31E65E4", Offset = "0x31E65E4", VA = "0x31E65E4")]
		public _003CGetCupChestList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60140EF")]
		[Address(RVA = "0x31F7BD8", Offset = "0x31F7BD8", VA = "0x31F7BD8")]
		internal bool _003C_003Em__0(CupChestDesc c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002FEF")]
	private sealed class _003CGetCupMatchRewardDescByWins_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012421")]
		[FieldOffset(Offset = "0x8")]
		internal int wins;

		[Token(Token = "0x60140F0")]
		[Address(RVA = "0x31E68B0", Offset = "0x31E68B0", VA = "0x31E68B0")]
		public _003CGetCupMatchRewardDescByWins_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60140F1")]
		[Address(RVA = "0x31F7C94", Offset = "0x31F7C94", VA = "0x31F7C94")]
		internal bool _003C_003Em__0(CupChestDesc r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002FF0")]
	private sealed class _003CGetSelfTeamMembers_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012422")]
		[FieldOffset(Offset = "0x8")]
		internal ulong selfAccountID;

		[Token(Token = "0x60140F2")]
		[Address(RVA = "0x31EB648", Offset = "0x31EB648", VA = "0x31EB648")]
		public _003CGetSelfTeamMembers_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60140F3")]
		[Address(RVA = "0x31F7CD4", Offset = "0x31F7CD4", VA = "0x31F7CD4")]
		internal bool _003C_003Em__0(AccountInfoBasicWithCupInfo m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002FF1")]
	private sealed class _003CSortTeamMember_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012423")]
		[FieldOffset(Offset = "0x8")]
		internal CupTeamInfo teamInfo;

		[Token(Token = "0x4012424")]
		[FieldOffset(Offset = "0xC")]
		internal bool sortPresence;

		[Token(Token = "0x4012425")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x60140F4")]
		[Address(RVA = "0x15C7C04", Offset = "0x15C7C04", VA = "0x15C7C04")]
		public _003CSortTeamMember_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60140F5")]
		[Address(RVA = "0x15C7C0C", Offset = "0x15C7C0C", VA = "0x15C7C0C")]
		internal int _003C_003Em__0(AccountInfoBasicWithCupInfo e, AccountInfoBasicWithCupInfo o)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2002FF2")]
	private sealed class _003CHasNonTeamMemberPlayerInGroup_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012426")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo member;

		[Token(Token = "0x60140F6")]
		[Address(RVA = "0x31ED2B4", Offset = "0x31ED2B4", VA = "0x31ED2B4")]
		public _003CHasNonTeamMemberPlayerInGroup_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60140F7")]
		[Address(RVA = "0x31F7D24", Offset = "0x31F7D24", VA = "0x31F7D24")]
		internal bool _003C_003Em__0(AccountInfoBasicWithCupInfo m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002FF3")]
	private sealed class _003CRequestCreateTeam_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012427")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012428")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x60140F8")]
		[Address(RVA = "0x15C2C68", Offset = "0x15C2C68", VA = "0x15C2C68")]
		public _003CRequestCreateTeam_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60140F9")]
		[Address(RVA = "0x15C2C70", Offset = "0x15C2C70", VA = "0x15C2C70")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FF4")]
	private sealed class _003CRequestJoinTeam_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012429")]
		[FieldOffset(Offset = "0x8")]
		internal ulong friendID;

		[Token(Token = "0x401242A")]
		[FieldOffset(Offset = "0x10")]
		internal int key;

		[Token(Token = "0x401242B")]
		[FieldOffset(Offset = "0x18")]
		internal ulong teamID;

		[Token(Token = "0x401242C")]
		[FieldOffset(Offset = "0x20")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x60140FA")]
		[Address(RVA = "0x15C4F74", Offset = "0x15C4F74", VA = "0x15C4F74")]
		public _003CRequestJoinTeam_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60140FB")]
		[Address(RVA = "0x15C4F7C", Offset = "0x15C4F7C", VA = "0x15C4F7C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FF5")]
	private sealed class _003CRequestModifyTeamInfo_003Ec__AnonStorey7
	{
		[Token(Token = "0x401242D")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x401242E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x60140FC")]
		[Address(RVA = "0x15C54F8", Offset = "0x15C54F8", VA = "0x15C54F8")]
		public _003CRequestModifyTeamInfo_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60140FD")]
		[Address(RVA = "0x15C5500", Offset = "0x15C5500", VA = "0x15C5500")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FF6")]
	private sealed class _003CRequestTeamInfoByTeamID_003Ec__AnonStorey8
	{
		[Token(Token = "0x401242F")]
		[FieldOffset(Offset = "0x8")]
		internal ulong teamID;

		[Token(Token = "0x4012430")]
		[FieldOffset(Offset = "0x10")]
		internal int key;

		[Token(Token = "0x4012431")]
		[FieldOffset(Offset = "0x14")]
		internal bool requestTeamApplication;

		[Token(Token = "0x4012432")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x60140FE")]
		[Address(RVA = "0x15C6B9C", Offset = "0x15C6B9C", VA = "0x15C6B9C")]
		public _003CRequestTeamInfoByTeamID_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60140FF")]
		[Address(RVA = "0x15C6BA4", Offset = "0x15C6BA4", VA = "0x15C6BA4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FF7")]
	private sealed class _003CRequestTeamMembers_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012433")]
		[FieldOffset(Offset = "0x8")]
		internal ulong teamID;

		[Token(Token = "0x4012434")]
		[FieldOffset(Offset = "0x10")]
		internal CSCupTeamIDReq req;

		[Token(Token = "0x4012435")]
		[FieldOffset(Offset = "0x14")]
		internal int key;

		[Token(Token = "0x4012436")]
		[FieldOffset(Offset = "0x18")]
		internal bool requestTeamMemberPresence;

		[Token(Token = "0x4012437")]
		[FieldOffset(Offset = "0x19")]
		internal bool forcePresence;

		[Token(Token = "0x4012438")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014100")]
		[Address(RVA = "0x15C6FC8", Offset = "0x15C6FC8", VA = "0x15C6FC8")]
		public _003CRequestTeamMembers_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6014101")]
		[Address(RVA = "0x15C6FD0", Offset = "0x15C6FD0", VA = "0x15C6FD0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FF8")]
	private sealed class _003CRequestQuitTeam_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012439")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x401243A")]
		[FieldOffset(Offset = "0xC")]
		internal bool toNewTeam;

		[Token(Token = "0x401243B")]
		[FieldOffset(Offset = "0xD")]
		internal bool requestApproveJoinTeamInvitation;

		[Token(Token = "0x401243C")]
		[FieldOffset(Offset = "0x10")]
		internal ulong inviter;

		[Token(Token = "0x401243D")]
		[FieldOffset(Offset = "0x18")]
		internal ulong inviterTeam;

		[Token(Token = "0x401243E")]
		[FieldOffset(Offset = "0x20")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014102")]
		[Address(RVA = "0x15C5654", Offset = "0x15C5654", VA = "0x15C5654")]
		public _003CRequestQuitTeam_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6014103")]
		[Address(RVA = "0x15C5660", Offset = "0x15C5660", VA = "0x15C5660")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FF9")]
	private sealed class _003CRequestDismissTeam_003Ec__AnonStoreyB
	{
		[Token(Token = "0x401243F")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012440")]
		[FieldOffset(Offset = "0xC")]
		internal bool toNewTeam;

		[Token(Token = "0x4012441")]
		[FieldOffset(Offset = "0xD")]
		internal bool requestApproveJoinTeamInvitation;

		[Token(Token = "0x4012442")]
		[FieldOffset(Offset = "0x10")]
		internal ulong inviter;

		[Token(Token = "0x4012443")]
		[FieldOffset(Offset = "0x18")]
		internal ulong inviterTeam;

		[Token(Token = "0x4012444")]
		[FieldOffset(Offset = "0x20")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014104")]
		[Address(RVA = "0x15C35A4", Offset = "0x15C35A4", VA = "0x15C35A4")]
		public _003CRequestDismissTeam_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6014105")]
		[Address(RVA = "0x15C35B0", Offset = "0x15C35B0", VA = "0x15C35B0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FFA")]
	private sealed class _003CRequestTeamApplicantList_003Ec__AnonStoreyD
	{
		[Token(Token = "0x2002FFB")]
		private sealed class _003CRequestTeamApplicantList_003Ec__AnonStoreyC
		{
			[Token(Token = "0x4012447")]
			[FieldOffset(Offset = "0x8")]
			internal AccountInfoBasicWithCupInfo info;

			[Token(Token = "0x6014108")]
			[Address(RVA = "0x15C6B2C", Offset = "0x15C6B2C", VA = "0x15C6B2C")]
			public _003CRequestTeamApplicantList_003Ec__AnonStoreyC()
			{
			}

			[Token(Token = "0x6014109")]
			[Address(RVA = "0x15C6B34", Offset = "0x15C6B34", VA = "0x15C6B34")]
			internal bool _003C_003Em__0(CupTeamApplicantRes member)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4012445")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012446")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014106")]
		[Address(RVA = "0x15C6344", Offset = "0x15C6344", VA = "0x15C6344")]
		public _003CRequestTeamApplicantList_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6014107")]
		[Address(RVA = "0x15C634C", Offset = "0x15C634C", VA = "0x15C634C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FFC")]
	private sealed class _003CRequestInvitationList_003Ec__AnonStoreyF
	{
		[Token(Token = "0x2002FFD")]
		private sealed class _003CRequestInvitationList_003Ec__AnonStoreyE
		{
			[Token(Token = "0x401244B")]
			[FieldOffset(Offset = "0x8")]
			internal AccountInfoBasicWithCupInfo info;

			[Token(Token = "0x601410C")]
			[Address(RVA = "0x15C4664", Offset = "0x15C4664", VA = "0x15C4664")]
			public _003CRequestInvitationList_003Ec__AnonStoreyE()
			{
			}

			[Token(Token = "0x601410D")]
			[Address(RVA = "0x15C4674", Offset = "0x15C4674", VA = "0x15C4674")]
			internal bool _003C_003Em__0(CupTeamInvitationRes member)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4012448")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x4012449")]
		[FieldOffset(Offset = "0xC")]
		internal uint id;

		[Token(Token = "0x401244A")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x601410A")]
		[Address(RVA = "0x15C3E78", Offset = "0x15C3E78", VA = "0x15C3E78")]
		public _003CRequestInvitationList_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x601410B")]
		[Address(RVA = "0x15C3E80", Offset = "0x15C3E80", VA = "0x15C3E80")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FFE")]
	private sealed class _003CRequestInvitedIdList_003Ec__AnonStorey10
	{
		[Token(Token = "0x401244C")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x401244D")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x601410E")]
		[Address(RVA = "0x15C4A58", Offset = "0x15C4A58", VA = "0x15C4A58")]
		public _003CRequestInvitedIdList_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x601410F")]
		[Address(RVA = "0x15C4A60", Offset = "0x15C4A60", VA = "0x15C4A60")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002FFF")]
	private sealed class _003CRequestApproveApplication_003Ec__AnonStorey11
	{
		[Token(Token = "0x401244E")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x401244F")]
		[FieldOffset(Offset = "0x10")]
		internal ulong teamID;

		[Token(Token = "0x4012450")]
		[FieldOffset(Offset = "0x18")]
		internal CSApproveJoinCupTeamApplicationReq req;

		[Token(Token = "0x4012451")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014110")]
		[Address(RVA = "0x15C0F60", Offset = "0x15C0F60", VA = "0x15C0F60")]
		public _003CRequestApproveApplication_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6014111")]
		[Address(RVA = "0x15C0F68", Offset = "0x15C0F68", VA = "0x15C0F68")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003000")]
	private sealed class _003CRequestApproveApplication_003Ec__AnonStorey12
	{
		[Token(Token = "0x4012452")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012453")]
		[FieldOffset(Offset = "0xC")]
		internal CSApproveJoinCupTeamApplicationReq req;

		[Token(Token = "0x4012454")]
		[FieldOffset(Offset = "0x10")]
		internal AccountInfoBasicWithCupInfo basicInfoWithCupTier;

		[Token(Token = "0x4012455")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014112")]
		[Address(RVA = "0x15C1680", Offset = "0x15C1680", VA = "0x15C1680")]
		public _003CRequestApproveApplication_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6014113")]
		[Address(RVA = "0x15C1688", Offset = "0x15C1688", VA = "0x15C1688")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003001")]
	private sealed class _003CRequestDeclineApplication_003Ec__AnonStorey13
	{
		[Token(Token = "0x4012456")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012457")]
		[FieldOffset(Offset = "0xC")]
		internal ulong[] applicantIDs;

		[Token(Token = "0x4012458")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014114")]
		[Address(RVA = "0x15C2EEC", Offset = "0x15C2EEC", VA = "0x15C2EEC")]
		public _003CRequestDeclineApplication_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6014115")]
		[Address(RVA = "0x15C2EF4", Offset = "0x15C2EF4", VA = "0x15C2EF4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014116")]
		[Address(RVA = "0x15C3194", Offset = "0x15C3194", VA = "0x15C3194")]
		internal bool _003C_003Em__1(AccountInfoBasicWithCupInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003002")]
	private sealed class _003CRequestInvite_003Ec__AnonStorey14
	{
		[Token(Token = "0x4012459")]
		[FieldOffset(Offset = "0x8")]
		internal ulong inviteeID;

		[Token(Token = "0x401245A")]
		[FieldOffset(Offset = "0x10")]
		internal int key;

		[Token(Token = "0x401245B")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014117")]
		[Address(RVA = "0x15C46DC", Offset = "0x15C46DC", VA = "0x15C46DC")]
		public _003CRequestInvite_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6014118")]
		[Address(RVA = "0x15C46E4", Offset = "0x15C46E4", VA = "0x15C46E4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003003")]
	private sealed class _003CRequestApproveJoinTeamInvitation_003Ec__AnonStorey15
	{
		[Token(Token = "0x401245C")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x401245D")]
		[FieldOffset(Offset = "0x10")]
		internal ulong inviterTeam;

		[Token(Token = "0x401245E")]
		[FieldOffset(Offset = "0x18")]
		internal ulong inviter;

		[Token(Token = "0x401245F")]
		[FieldOffset(Offset = "0x20")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014119")]
		[Address(RVA = "0x15C1FDC", Offset = "0x15C1FDC", VA = "0x15C1FDC")]
		public _003CRequestApproveJoinTeamInvitation_003Ec__AnonStorey15()
		{
		}

		[Token(Token = "0x601411A")]
		[Address(RVA = "0x15C1FE4", Offset = "0x15C1FE4", VA = "0x15C1FE4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601411B")]
		[Address(RVA = "0x15C25F0", Offset = "0x15C25F0", VA = "0x15C25F0")]
		internal bool _003C_003Em__1(AccountInfoBasicWithCupInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x601411C")]
		[Address(RVA = "0x15C2644", Offset = "0x15C2644", VA = "0x15C2644")]
		internal bool _003C_003Em__2(AccountInfoBasicWithCupInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003004")]
	private sealed class _003CRequestDeclineJoinTeamInvitation_003Ec__AnonStorey16
	{
		[Token(Token = "0x4012460")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012461")]
		[FieldOffset(Offset = "0xC")]
		internal ulong[] inviterIDs;

		[Token(Token = "0x4012462")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x601411D")]
		[Address(RVA = "0x15C3234", Offset = "0x15C3234", VA = "0x15C3234")]
		public _003CRequestDeclineJoinTeamInvitation_003Ec__AnonStorey16()
		{
		}

		[Token(Token = "0x601411E")]
		[Address(RVA = "0x15C323C", Offset = "0x15C323C", VA = "0x15C323C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601411F")]
		[Address(RVA = "0x15C3504", Offset = "0x15C3504", VA = "0x15C3504")]
		internal bool _003C_003Em__1(AccountInfoBasicWithCupInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003005")]
	private sealed class _003CRequestRemoveTeamMember_003Ec__AnonStorey17
	{
		[Token(Token = "0x4012463")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012464")]
		[FieldOffset(Offset = "0x10")]
		internal ulong removeeID;

		[Token(Token = "0x4012465")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014120")]
		[Address(RVA = "0x15C5F20", Offset = "0x15C5F20", VA = "0x15C5F20")]
		public _003CRequestRemoveTeamMember_003Ec__AnonStorey17()
		{
		}

		[Token(Token = "0x6014121")]
		[Address(RVA = "0x15C5F28", Offset = "0x15C5F28", VA = "0x15C5F28")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003006")]
	private sealed class _003CRequestAccountCupInfoBundleByAccountIDsOrderly_003Ec__AnonStorey18
	{
		[Token(Token = "0x4012466")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x4012467")]
		[FieldOffset(Offset = "0xC")]
		internal uint id;

		[Token(Token = "0x4012468")]
		[FieldOffset(Offset = "0x10")]
		internal bool isSearch;

		[Token(Token = "0x4012469")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x6014122")]
		[Address(RVA = "0x31F41AC", Offset = "0x31F41AC", VA = "0x31F41AC")]
		public _003CRequestAccountCupInfoBundleByAccountIDsOrderly_003Ec__AnonStorey18()
		{
		}

		[Token(Token = "0x6014123")]
		[Address(RVA = "0x31F7D98", Offset = "0x31F7D98", VA = "0x31F7D98")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003007")]
	private sealed class _003CRequestClaimCupReward_003Ec__AnonStorey19
	{
		[Token(Token = "0x401246A")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x401246B")]
		[FieldOffset(Offset = "0xC")]
		internal uint id;

		[Token(Token = "0x401246C")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x401246D")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014124")]
		[Address(RVA = "0x15C2698", Offset = "0x15C2698", VA = "0x15C2698")]
		public _003CRequestClaimCupReward_003Ec__AnonStorey19()
		{
		}

		[Token(Token = "0x6014125")]
		[Address(RVA = "0x15C26A0", Offset = "0x15C26A0", VA = "0x15C26A0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014126")]
		[Address(RVA = "0x15C2C60", Offset = "0x15C2C60", VA = "0x15C2C60")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003008")]
	private sealed class _003CRequestUseTicket_003Ec__AnonStorey1A
	{
		[Token(Token = "0x401246E")]
		[FieldOffset(Offset = "0x8")]
		internal uint type;

		[Token(Token = "0x401246F")]
		[FieldOffset(Offset = "0xC")]
		internal uint id;

		[Token(Token = "0x4012470")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x4012471")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<AccountInfoBasicWithCupInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014127")]
		[Address(RVA = "0x15C76E0", Offset = "0x15C76E0", VA = "0x15C76E0")]
		public _003CRequestUseTicket_003Ec__AnonStorey1A()
		{
		}

		[Token(Token = "0x6014128")]
		[Address(RVA = "0x15C76E8", Offset = "0x15C76E8", VA = "0x15C76E8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014129")]
		[Address(RVA = "0x15C794C", Offset = "0x15C794C", VA = "0x15C794C")]
		private static bool _003C_003Em__1(AccountInfoBasicWithCupInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003009")]
	private sealed class _003CRequestVerifyAndLockCupTeam_003Ec__AnonStorey1B
	{
		[Token(Token = "0x4012472")]
		[FieldOffset(Offset = "0x8")]
		internal int key;

		[Token(Token = "0x4012473")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelCupMatch _0024this;

		[Token(Token = "0x601412A")]
		[Address(RVA = "0x15C7A64", Offset = "0x15C7A64", VA = "0x15C7A64")]
		public _003CRequestVerifyAndLockCupTeam_003Ec__AnonStorey1B()
		{
		}

		[Token(Token = "0x601412B")]
		[Address(RVA = "0x15C7A6C", Offset = "0x15C7A6C", VA = "0x15C7A6C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x40123A5")]
	private const uint NameOverwriteType_TrialMatchName = 1u;

	[Token(Token = "0x40123A6")]
	private const uint NameOverwriteType_ModeName = 2u;

	[Token(Token = "0x40123A7")]
	private const uint NameOverwriteType_SeasonName = 3u;

	[Token(Token = "0x40123A8")]
	private const uint NameOverwriteType_TimeContent = 4u;

	[Token(Token = "0x40123A9")]
	[FieldOffset(Offset = "0xC")]
	private readonly Dictionary<int, StateViewInfo> m_StateViewInfoDict;

	[Token(Token = "0x40123AA")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, CupTeamInfo> m_SelfTeamInfoDict;

	[Token(Token = "0x40123AB")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<int, ulong> m_SelfTeamIDDict;

	[Token(Token = "0x40123AC")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, List<AccountInfoBasicWithCupInfo>> m_SelfTeamMemberInfoDict;

	[Token(Token = "0x40123AD")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, List<AccountInfoBasicWithCupInfo>> m_TeamApplicantDict;

	[Token(Token = "0x40123AE")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, List<AccountInfoBasicWithCupInfo>> m_TeamInvitationDict;

	[Token(Token = "0x40123AF")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, CSAccountCupInfoRes> m_SelfCupInfoDict;

	[Token(Token = "0x40123B0")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, List<ulong>> m_TeamInvitedIdDict;

	[Token(Token = "0x40123B1")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<ulong, Dictionary<ulong, PresenceInfo>> m_MemberPresenceCache;

	[Token(Token = "0x40123B2")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, ulong> m_TeamInfoEditCoolDownTimeDict;

	[Token(Token = "0x40123B3")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, CSGetCupConfigRes> m_CupConfigDict;

	[Token(Token = "0x40123B4")]
	[FieldOffset(Offset = "0x38")]
	private CupRuleDesc m_CupRuleDesc;

	[Token(Token = "0x40123B5")]
	[FieldOffset(Offset = "0x3C")]
	private CupTeamDesc m_CupTeamDesc;

	[Token(Token = "0x40123B6")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, List<ulong>> m_RequestedJoinTeamIDDict;

	[Token(Token = "0x40123B7")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, List<CSAccountCupInfoRes>> m_CacheAccountCupInfo;

	[Token(Token = "0x40123B8")]
	[FieldOffset(Offset = "0x48")]
	private List<int> m_requestQueue;

	[Token(Token = "0x40123B9")]
	private const string m_PrefTeamInfoEditCD = "CupMatchTeamInfoEditCD";

	[Token(Token = "0x40123BA")]
	public const string NEWSEASONANOTICE = "CupMatchNewSeasonNotice";

	[Token(Token = "0x40123BB")]
	[FieldOffset(Offset = "0x4C")]
	private bool _003CTeamMemberInitialized_003Ek__BackingField;

	[Token(Token = "0x40123BC")]
	[FieldOffset(Offset = "0x50")]
	private float m_LastRequestUseTicketTime;

	[Token(Token = "0x40123BD")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsMatchResultNotified;

	[Token(Token = "0x40123BE")]
	private const string CUPMATCHKEY = "CupMatchKey_{0}_{1}";

	[Token(Token = "0x40123BF")]
	[FieldOffset(Offset = "0x55")]
	private bool m_IsInvalidMatch;

	[Token(Token = "0x40123C0")]
	[FieldOffset(Offset = "0x56")]
	public bool MatchRecordUpdate;

	[Token(Token = "0x40123C1")]
	[FieldOffset(Offset = "0x58")]
	public uint OppoTeamIcon;

	[Token(Token = "0x40123C2")]
	[FieldOffset(Offset = "0x5C")]
	public string OppoTeamName;

	[Token(Token = "0x40123C3")]
	[FieldOffset(Offset = "0x60")]
	private bool m_NeedRequestApplicationList;

	[Token(Token = "0x40123C4")]
	[FieldOffset(Offset = "0x61")]
	private bool m_NeedRequestInvitationList;

	[Token(Token = "0x40123C5")]
	[FieldOffset(Offset = "0x68")]
	private ulong _003CApplicationListRequestCDEndTime_003Ek__BackingField;

	[Token(Token = "0x40123C6")]
	[FieldOffset(Offset = "0x70")]
	private ulong _003CInvitationListRequestCDEndTime_003Ek__BackingField;

	[Token(Token = "0x40123C7")]
	[FieldOffset(Offset = "0x78")]
	private ulong _003CFriendCupTeamInfoRequestCDEndTime_003Ek__BackingField;

	[Token(Token = "0x40123C8")]
	public const uint PropID_CreateTeam = 2u;

	[Token(Token = "0x40123C9")]
	public const uint PropID_TeamInfoUpdate = 4u;

	[Token(Token = "0x40123CA")]
	public const uint PropID_TeamMembersUpdate = 8u;

	[Token(Token = "0x40123CB")]
	public const uint PropID_QuitTeam = 16u;

	[Token(Token = "0x40123CC")]
	public const uint PropID_TeamApplicantsUpdate = 32u;

	[Token(Token = "0x40123CD")]
	public const uint PropID_DismissTeam = 64u;

	[Token(Token = "0x40123CE")]
	public const uint PropID_DismissTeamNotify = 128u;

	[Token(Token = "0x40123CF")]
	public const uint PropID_RemoveNotify = 256u;

	[Token(Token = "0x40123D0")]
	public const uint PropID_Invite = 512u;

	[Token(Token = "0x40123D1")]
	public const uint PropID_TeamInvitationUpdate = 1024u;

	[Token(Token = "0x40123D2")]
	public const uint PropID_ApproveTeamInvitation = 2048u;

	[Token(Token = "0x40123D3")]
	public const uint PropID_JoinTeam = 4096u;

	[Token(Token = "0x40123D4")]
	public const uint PropID_MemberPresenceUpdate = 8192u;

	[Token(Token = "0x40123D5")]
	public const uint PropID_ConfirmAddNotify = 16384u;

	[Token(Token = "0x40123D6")]
	public const uint PropID_ModifyTeamInfo = 32768u;

	[Token(Token = "0x40123D7")]
	public const uint PropID_TeamIDChange = 65536u;

	[Token(Token = "0x40123D8")]
	public const uint PropID_GetInvitedIdListUpdate = 131072u;

	[Token(Token = "0x40123D9")]
	public const uint PropID_UseCupTicket = 262144u;

	[Token(Token = "0x40123DA")]
	public const uint PropID_AccountCupInfoBundleNotify = 524288u;

	[Token(Token = "0x40123DB")]
	public const uint PropID_ClaimReward = 1048576u;

	[Token(Token = "0x40123DC")]
	public const uint PropID_TeamTabRedTipsUpdate = 2097152u;

	[Token(Token = "0x40123DD")]
	public const uint PropID_TeamApplicationRedTipsUpdate = 4194304u;

	[Token(Token = "0x40123DE")]
	public const uint PropID_TeamInvitationRedTipsUpdate = 8388608u;

	[Token(Token = "0x40123DF")]
	public const uint PropID_NoTeamRedTipsUpdate = 16777216u;

	[Token(Token = "0x40123E0")]
	public const uint PropID_ClaimRewardTipsUpdate = 33554432u;

	[Token(Token = "0x40123E1")]
	public const uint PropID_TeamLockNotify = 67108864u;

	[Token(Token = "0x40123E2")]
	public const uint PropID_FirstTimeEnterCupUINotify = 134217728u;

	[Token(Token = "0x40123E3")]
	[FieldOffset(Offset = "0x80")]
	private CupMatchEntranceState m_HighestPriorityState;

	[Token(Token = "0x40123E4")]
	[FieldOffset(Offset = "0x84")]
	private int m_HighestPriorityKey;

	[Token(Token = "0x40123E5")]
	[FieldOffset(Offset = "0x88")]
	private bool m_EntranceStateChecked;

	[Token(Token = "0x40123E6")]
	[FieldOffset(Offset = "0x89")]
	public bool cupMatchInfoReady;

	[Token(Token = "0x40123E7")]
	[FieldOffset(Offset = "0x8A")]
	public bool teamInfoReady;

	[Token(Token = "0x40123E8")]
	[FieldOffset(Offset = "0x8B")]
	public bool mapInfoReady;

	[Token(Token = "0x40123E9")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<int, int> m_CupMatchEntranceTrailOpenTipsDict;

	[Token(Token = "0x40123EA")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, int> m_CupMatchTeamApplicationTipsDict;

	[Token(Token = "0x40123EB")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<int, int> m_CupMatchTeamInvitationTipsDict;

	[Token(Token = "0x40123EC")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<int, int> m_CupMatchTeamTabTipsDict;

	[Token(Token = "0x40123ED")]
	[FieldOffset(Offset = "0x9C")]
	private Dictionary<int, int> m_CupMatchNoTeamTipsDict;

	[Token(Token = "0x40123EE")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<int, int> m_CupMatchTeamNotFullTipsDict;

	[Token(Token = "0x40123EF")]
	[FieldOffset(Offset = "0xA4")]
	private Dictionary<int, int> m_CupMatchClaimRewardTipsDict;

	[Token(Token = "0x40123F0")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40123F1")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<AccountInfoBasicWithCupInfo, ulong> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40123F2")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<AccountInfoBasicWithCupInfo, ulong> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40123F3")]
	[FieldOffset(Offset = "0xC")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x170014BA")]
	public bool TeamMemberInitialized
	{
		[Token(Token = "0x6014027")]
		[Address(RVA = "0x31E48A0", Offset = "0x31E48A0", VA = "0x31E48A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014028")]
		[Address(RVA = "0x31E48A8", Offset = "0x31E48A8", VA = "0x31E48A8")]
		set
		{
		}
	}

	[Token(Token = "0x170014BB")]
	public bool IsMatchResultNotified
	{
		[Token(Token = "0x6014029")]
		[Address(RVA = "0x31E48B0", Offset = "0x31E48B0", VA = "0x31E48B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601402A")]
		[Address(RVA = "0x31E4908", Offset = "0x31E4908", VA = "0x31E4908")]
		set
		{
		}
	}

	[Token(Token = "0x170014BC")]
	public bool IsInvalidMatch
	{
		[Token(Token = "0x601402B")]
		[Address(RVA = "0x31E4968", Offset = "0x31E4968", VA = "0x31E4968")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601402C")]
		[Address(RVA = "0x31E49C0", Offset = "0x31E49C0", VA = "0x31E49C0")]
		set
		{
		}
	}

	[Token(Token = "0x170014BD")]
	public bool NeedRequestApplicationList
	{
		[Token(Token = "0x601402D")]
		[Address(RVA = "0x31E4A20", Offset = "0x31E4A20", VA = "0x31E4A20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601402E")]
		[Address(RVA = "0x31E4A78", Offset = "0x31E4A78", VA = "0x31E4A78")]
		set
		{
		}
	}

	[Token(Token = "0x170014BE")]
	public bool NeedRequestInvitationList
	{
		[Token(Token = "0x601402F")]
		[Address(RVA = "0x31E4AD8", Offset = "0x31E4AD8", VA = "0x31E4AD8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014030")]
		[Address(RVA = "0x31E4B30", Offset = "0x31E4B30", VA = "0x31E4B30")]
		set
		{
		}
	}

	[Token(Token = "0x170014BF")]
	public ulong ApplicationListRequestCDEndTime
	{
		[Token(Token = "0x6014031")]
		[Address(RVA = "0x31E4B90", Offset = "0x31E4B90", VA = "0x31E4B90")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014032")]
		[Address(RVA = "0x31E4B98", Offset = "0x31E4B98", VA = "0x31E4B98")]
		set
		{
		}
	}

	[Token(Token = "0x170014C0")]
	public ulong InvitationListRequestCDEndTime
	{
		[Token(Token = "0x6014033")]
		[Address(RVA = "0x31E4BA8", Offset = "0x31E4BA8", VA = "0x31E4BA8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014034")]
		[Address(RVA = "0x31E4BB0", Offset = "0x31E4BB0", VA = "0x31E4BB0")]
		set
		{
		}
	}

	[Token(Token = "0x170014C1")]
	public ulong FriendCupTeamInfoRequestCDEndTime
	{
		[Token(Token = "0x6014035")]
		[Address(RVA = "0x31E4BC0", Offset = "0x31E4BC0", VA = "0x31E4BC0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014036")]
		[Address(RVA = "0x31E4BC8", Offset = "0x31E4BC8", VA = "0x31E4BC8")]
		set
		{
		}
	}

	[Token(Token = "0x6014026")]
	[Address(RVA = "0x31E3E84", Offset = "0x31E3E84", VA = "0x31E3E84")]
	public UIModelCupMatch()
	{
	}

	[Token(Token = "0x6014037")]
	[Address(RVA = "0x31E4BD8", Offset = "0x31E4BD8", VA = "0x31E4BD8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014038")]
	[Address(RVA = "0x31E4C30", Offset = "0x31E4C30", VA = "0x31E4C30", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014039")]
	[Address(RVA = "0x31E4C9C", Offset = "0x31E4C9C", VA = "0x31E4C9C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x601403A")]
	[Address(RVA = "0x31E4D0C", Offset = "0x31E4D0C", VA = "0x31E4D0C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601403B")]
	[Address(RVA = "0x31E51B4", Offset = "0x31E51B4", VA = "0x31E51B4")]
	public void OnStartMatch()
	{
	}

	[Token(Token = "0x601403C")]
	[Address(RVA = "0x31E529C", Offset = "0x31E529C", VA = "0x31E529C")]
	public uint GetLevelLowerLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x601403D")]
	[Address(RVA = "0x31E5314", Offset = "0x31E5314", VA = "0x31E5314")]
	public uint GetLevelUpperLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x601403E")]
	[Address(RVA = "0x31E538C", Offset = "0x31E538C", VA = "0x31E538C")]
	public uint GetLadderScoreLowerLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x601403F")]
	[Address(RVA = "0x31E53F4", Offset = "0x31E53F4", VA = "0x31E53F4")]
	public uint GetLadderScoreUpperLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6014040")]
	[Address(RVA = "0x31E546C", Offset = "0x31E546C", VA = "0x31E546C")]
	public bool CheckJoinCreateTimeSatisfy(out string error)
	{
		return default(bool);
	}

	[Token(Token = "0x6014041")]
	[Address(RVA = "0x31E56A8", Offset = "0x31E56A8", VA = "0x31E56A8")]
	public bool CheckLevelSatisfy()
	{
		return default(bool);
	}

	[Token(Token = "0x6014042")]
	[Address(RVA = "0x31E5828", Offset = "0x31E5828", VA = "0x31E5828")]
	public bool CheckLadderScoreSatisfy()
	{
		return default(bool);
	}

	[Token(Token = "0x6014043")]
	[Address(RVA = "0x31E59B0", Offset = "0x31E59B0", VA = "0x31E59B0")]
	public CupOpenInfoDesc GetCupMatchOpenInfo(int key)
	{
		return null;
	}

	[Token(Token = "0x6014044")]
	[Address(RVA = "0x31E5B20", Offset = "0x31E5B20", VA = "0x31E5B20")]
	public CupRuleDesc GetCupRuleInfo()
	{
		return null;
	}

	[Token(Token = "0x6014045")]
	[Address(RVA = "0x31E5B78", Offset = "0x31E5B78", VA = "0x31E5B78")]
	public uint GetMaxTier(int key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014046")]
	[Address(RVA = "0x31E5D8C", Offset = "0x31E5D8C", VA = "0x31E5D8C")]
	public bool HasBlockCupMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x6014047")]
	[Address(RVA = "0x31E5F88", Offset = "0x31E5F88", VA = "0x31E5F88")]
	public bool IsInBlackList(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014048")]
	[Address(RVA = "0x31E601C", Offset = "0x31E601C", VA = "0x31E601C")]
	public CupSettingDesc GetCupMatchSetting(int key)
	{
		return null;
	}

	[Token(Token = "0x6014049")]
	[Address(RVA = "0x31E60A4", Offset = "0x31E60A4", VA = "0x31E60A4")]
	public CupCDNSettingDesc GetCupCDNSetting(int key)
	{
		return null;
	}

	[Token(Token = "0x601404A")]
	[Address(RVA = "0x31E612C", Offset = "0x31E612C", VA = "0x31E612C")]
	public CupNameOverwriteDesc GetCupNameOverwriteDesc(int key, uint nameType)
	{
		return null;
	}

	[Token(Token = "0x601404B")]
	[Address(RVA = "0x31E6440", Offset = "0x31E6440", VA = "0x31E6440")]
	public List<CupChestDesc> GetCupChestList(int key, uint tier, bool isTicket)
	{
		return null;
	}

	[Token(Token = "0x601404C")]
	[Address(RVA = "0x31E5A38", Offset = "0x31E5A38", VA = "0x31E5A38")]
	public CSGetCupConfigRes GetCupConfig(int key)
	{
		return null;
	}

	[Token(Token = "0x601404D")]
	[Address(RVA = "0x31E65EC", Offset = "0x31E65EC", VA = "0x31E65EC")]
	public CupChestDesc GetFirstCupMatchRewardDesc(int key, uint tier, bool ticket)
	{
		return null;
	}

	[Token(Token = "0x601404E")]
	[Address(RVA = "0x31E6730", Offset = "0x31E6730", VA = "0x31E6730")]
	public CupChestDesc GetCupMatchRewardDescByWins(int key, uint tier, bool ticket, int wins)
	{
		return null;
	}

	[Token(Token = "0x601404F")]
	[Address(RVA = "0x31E68B8", Offset = "0x31E68B8", VA = "0x31E68B8")]
	public CupChestDesc GetCupMatchRewardDescByBattleRecord(int key, uint tier, bool ticket)
	{
		return null;
	}

	[Token(Token = "0x6014050")]
	[Address(RVA = "0x31E6A4C", Offset = "0x31E6A4C", VA = "0x31E6A4C")]
	public uint GetTeamScale()
	{
		return default(uint);
	}

	[Token(Token = "0x6014051")]
	[Address(RVA = "0x31E6B04", Offset = "0x31E6B04", VA = "0x31E6B04")]
	public void SetPrefsCupKey(int key, bool value)
	{
	}

	[Token(Token = "0x6014052")]
	[Address(RVA = "0x31E6CD0", Offset = "0x31E6CD0", VA = "0x31E6CD0")]
	public bool IsNotYetEnterredCupMatchExist()
	{
		return default(bool);
	}

	[Token(Token = "0x6014053")]
	[Address(RVA = "0x31E6F78", Offset = "0x31E6F78", VA = "0x31E6F78")]
	public bool GetPrefsCupKey(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014054")]
	[Address(RVA = "0x31E71A4", Offset = "0x31E71A4", VA = "0x31E71A4")]
	public bool IsNotYetParticipatedCupMatchesExists()
	{
		return default(bool);
	}

	[Token(Token = "0x6014055")]
	[Address(RVA = "0x31E7490", Offset = "0x31E7490", VA = "0x31E7490")]
	public bool IsFirstReward(CupChestDesc cupChest)
	{
		return default(bool);
	}

	[Token(Token = "0x6014056")]
	[Address(RVA = "0x31E7574", Offset = "0x31E7574", VA = "0x31E7574")]
	public int GetCupMatchWinsBeforeLose(int key)
	{
		return default(int);
	}

	[Token(Token = "0x6014057")]
	[Address(RVA = "0x31E6958", Offset = "0x31E6958", VA = "0x31E6958")]
	public int GetCupMatchWins(int key)
	{
		return default(int);
	}

	[Token(Token = "0x6014058")]
	[Address(RVA = "0x31E751C", Offset = "0x31E751C", VA = "0x31E751C")]
	public uint GetMatchTotalNum()
	{
		return default(uint);
	}

	[Token(Token = "0x6014059")]
	[Address(RVA = "0x31E7750", Offset = "0x31E7750", VA = "0x31E7750")]
	public string GetCupMatchName(int key, string originNameKey = "")
	{
		return null;
	}

	[Token(Token = "0x601405A")]
	[Address(RVA = "0x31E7A80", Offset = "0x31E7A80", VA = "0x31E7A80")]
	public string GetCupMatchModeName(int key)
	{
		return null;
	}

	[Token(Token = "0x601405B")]
	[Address(RVA = "0x31E7C94", Offset = "0x31E7C94", VA = "0x31E7C94")]
	public string GetCupMatchSeasonNameWithIDOverwrite(int key)
	{
		return null;
	}

	[Token(Token = "0x601405C")]
	[Address(RVA = "0x31E7F2C", Offset = "0x31E7F2C", VA = "0x31E7F2C")]
	public bool IsDisableWeaponSkin(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601405D")]
	[Address(RVA = "0x31E7FB4", Offset = "0x31E7FB4", VA = "0x31E7FB4")]
	public StateViewInfo GetStateViewInfo(CupMatchOpenState curState)
	{
		return default(StateViewInfo);
	}

	[Token(Token = "0x601405E")]
	[Address(RVA = "0x31E6AAC", Offset = "0x31E6AAC", VA = "0x31E6AAC")]
	public uint PlayerNumberLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x601405F")]
	[Address(RVA = "0x31E8120", Offset = "0x31E8120", VA = "0x31E8120")]
	public bool CupMatchIsOpen(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014060")]
	[Address(RVA = "0x31E8244", Offset = "0x31E8244", VA = "0x31E8244")]
	public CupMatchOpenState GetCupMatchOpenState(CupOpenInfoDesc cupOpenInfo)
	{
		return default(CupMatchOpenState);
	}

	[Token(Token = "0x6014061")]
	[Address(RVA = "0x31E8A60", Offset = "0x31E8A60", VA = "0x31E8A60")]
	public ulong GetMapCloseTime(int key)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014062")]
	[Address(RVA = "0x31E8CA4", Offset = "0x31E8CA4", VA = "0x31E8CA4")]
	public ulong GetNextOpenTime(CupOpenInfoDesc cupOpenInfo, CupMatchOpenState cupMatchState)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014063")]
	[Address(RVA = "0x31E8628", Offset = "0x31E8628", VA = "0x31E8628")]
	private void SetTipsIfDifferentOpenDay(int key, MapOpeningInfo mapInfo)
	{
	}

	[Token(Token = "0x6014064")]
	[Address(RVA = "0x31E9024", Offset = "0x31E9024", VA = "0x31E9024")]
	public uint GetCupMatchTypeByGameMode(uint gameMode)
	{
		return default(uint);
	}

	[Token(Token = "0x6014065")]
	[Address(RVA = "0x31E9270", Offset = "0x31E9270", VA = "0x31E9270")]
	public bool CupMatchCanUseTicket(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014066")]
	[Address(RVA = "0x31E9400", Offset = "0x31E9400", VA = "0x31E9400")]
	public uint GetCupMatchIDByType(uint type)
	{
		return default(uint);
	}

	[Token(Token = "0x6014067")]
	[Address(RVA = "0x31E9690", Offset = "0x31E9690", VA = "0x31E9690")]
	public string GetSeasonStartEndTimeString(CupOpenInfoDesc cupOpenInfo, bool showYear = true)
	{
		return null;
	}

	[Token(Token = "0x6014068")]
	[Address(RVA = "0x31E6EA8", Offset = "0x31E6EA8", VA = "0x31E6EA8")]
	public List<int> GetOpenCupMatchList()
	{
		return null;
	}

	[Token(Token = "0x6014069")]
	[Address(RVA = "0x31E9AC0", Offset = "0x31E9AC0", VA = "0x31E9AC0")]
	public string GetCupMatchPhaseStringByWins(int key)
	{
		return null;
	}

	[Token(Token = "0x601406A")]
	[Address(RVA = "0x31E9E20", Offset = "0x31E9E20", VA = "0x31E9E20")]
	public string GetCupMatchPhaseString(int key)
	{
		return null;
	}

	[Token(Token = "0x601406B")]
	[Address(RVA = "0x31EA3E0", Offset = "0x31EA3E0", VA = "0x31EA3E0")]
	public string GetCupMatchChallengePhaseString(int key)
	{
		return null;
	}

	[Token(Token = "0x601406C")]
	[Address(RVA = "0x31EA6DC", Offset = "0x31EA6DC", VA = "0x31EA6DC")]
	public bool HasLoseMatch(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601406D")]
	[Address(RVA = "0x31EA9D4", Offset = "0x31EA9D4", VA = "0x31EA9D4")]
	public bool HasClaimedReward(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601406E")]
	[Address(RVA = "0x31EAB44", Offset = "0x31EAB44", VA = "0x31EAB44")]
	public bool CanClaimReward(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601406F")]
	[Address(RVA = "0x31EACF8", Offset = "0x31EACF8", VA = "0x31EACF8")]
	public bool IsInCanJoinTeamTime(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014070")]
	[Address(RVA = "0x31EAE48", Offset = "0x31EAE48", VA = "0x31EAE48")]
	public bool SelfHasTeam(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014071")]
	[Address(RVA = "0x31E7668", Offset = "0x31E7668", VA = "0x31E7668")]
	public CupTeamInfo GetSelfTeamInfo(int key)
	{
		return null;
	}

	[Token(Token = "0x6014072")]
	[Address(RVA = "0x31EAEBC", Offset = "0x31EAEBC", VA = "0x31EAEBC")]
	public ulong GetSelfTeamID(int key)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014073")]
	[Address(RVA = "0x31EAFAC", Offset = "0x31EAFAC", VA = "0x31EAFAC")]
	public bool SelfIsCaptain(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014074")]
	[Address(RVA = "0x31EB130", Offset = "0x31EB130", VA = "0x31EB130")]
	public List<ulong> GetRequestedTeamIDList(int key)
	{
		return null;
	}

	[Token(Token = "0x6014075")]
	[Address(RVA = "0x31EB218", Offset = "0x31EB218", VA = "0x31EB218")]
	public void ClearRequestedTeamIDList(int key)
	{
	}

	[Token(Token = "0x6014076")]
	[Address(RVA = "0x31EB31C", Offset = "0x31EB31C", VA = "0x31EB31C")]
	public List<CSAccountCupInfoRes> GetCacheAccountCupInfoList(int key)
	{
		return null;
	}

	[Token(Token = "0x6014077")]
	[Address(RVA = "0x31EB404", Offset = "0x31EB404", VA = "0x31EB404")]
	public List<AccountInfoBasicWithCupInfo> GetSelfTeamMembers(int key, bool includeSelf = true)
	{
		return null;
	}

	[Token(Token = "0x6014078")]
	[Address(RVA = "0x31EB650", Offset = "0x31EB650", VA = "0x31EB650")]
	public bool IsFriendInTeam(int key, FriendAccountInfo friendInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6014079")]
	[Address(RVA = "0x31EB860", Offset = "0x31EB860", VA = "0x31EB860")]
	public proto.EPresence.AccountPresence TeamMemberPresence(ulong id, ulong teamID)
	{
		return default(proto.EPresence.AccountPresence);
	}

	[Token(Token = "0x601407A")]
	[Address(RVA = "0x31EB9EC", Offset = "0x31EB9EC", VA = "0x31EB9EC")]
	public ulong TeamMemberGroupID(ulong id, ulong teamID)
	{
		return default(ulong);
	}

	[Token(Token = "0x601407B")]
	[Address(RVA = "0x31EBB80", Offset = "0x31EBB80", VA = "0x31EBB80")]
	public string TeamMemberPresenceString(ulong id, ulong teamID)
	{
		return null;
	}

	[Token(Token = "0x601407C")]
	[Address(RVA = "0x31EBF98", Offset = "0x31EBF98", VA = "0x31EBF98")]
	public AccountInfoBasicWithCupInfo GetApplicantBasicAccountInfo(int cupKey, ulong applicantID)
	{
		return null;
	}

	[Token(Token = "0x601407D")]
	[Address(RVA = "0x31EC18C", Offset = "0x31EC18C", VA = "0x31EC18C")]
	public List<AccountInfoBasicWithCupInfo> GetTeamApplicants(int key)
	{
		return null;
	}

	[Token(Token = "0x601407E")]
	[Address(RVA = "0x31EC274", Offset = "0x31EC274", VA = "0x31EC274")]
	public List<AccountInfoBasicWithCupInfo> GetTeamInvitations(int key)
	{
		return null;
	}

	[Token(Token = "0x601407F")]
	[Address(RVA = "0x31EC35C", Offset = "0x31EC35C", VA = "0x31EC35C")]
	public uint GetSelfMembersNum(int key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014080")]
	[Address(RVA = "0x31EC460", Offset = "0x31EC460", VA = "0x31EC460")]
	public void UpdateTeamInfoEditCD(int key)
	{
	}

	[Token(Token = "0x6014081")]
	[Address(RVA = "0x31EC69C", Offset = "0x31EC69C", VA = "0x31EC69C")]
	public ulong GetTeamInfoEditCD(int key)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014082")]
	[Address(RVA = "0x31EC78C", Offset = "0x31EC78C", VA = "0x31EC78C")]
	private void UpdateTeamID(int key, ulong teamID)
	{
	}

	[Token(Token = "0x6014083")]
	[Address(RVA = "0x31ECDD8", Offset = "0x31ECDD8", VA = "0x31ECDD8")]
	public void SortTeamMember(List<AccountInfoBasicWithCupInfo> members, bool sortPresence, CupTeamInfo teamInfo)
	{
	}

	[Token(Token = "0x6014084")]
	[Address(RVA = "0x31EA208", Offset = "0x31EA208", VA = "0x31EA208")]
	public uint GetRemainMatchTimes(int key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014085")]
	[Address(RVA = "0x31ECF5C", Offset = "0x31ECF5C", VA = "0x31ECF5C")]
	public bool IsFinishAllGame(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014086")]
	[Address(RVA = "0x31ECFD8", Offset = "0x31ECFD8", VA = "0x31ECFD8")]
	public bool HasNonTeamMemberPlayerInGroup(int key, List<GroupMemberInfo> members)
	{
		return default(bool);
	}

	[Token(Token = "0x6014087")]
	[Address(RVA = "0x31ED2BC", Offset = "0x31ED2BC", VA = "0x31ED2BC")]
	public bool UsedTicket(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014088")]
	[Address(RVA = "0x31EAA5C", Offset = "0x31EAA5C", VA = "0x31EAA5C")]
	public CSAccountCupInfoRes GetSelfCupInfo(int key)
	{
		return null;
	}

	[Token(Token = "0x6014089")]
	[Address(RVA = "0x31ED344", Offset = "0x31ED344", VA = "0x31ED344")]
	public bool IsTeamLocked(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601408A")]
	[Address(RVA = "0x31ED3CC", Offset = "0x31ED3CC", VA = "0x31ED3CC")]
	public CupTeamInfo GetTeamInfoByTeamID(ulong teamID)
	{
		return null;
	}

	[Token(Token = "0x601408B")]
	[Address(RVA = "0x31EA7B4", Offset = "0x31EA7B4", VA = "0x31EA7B4")]
	public List<int> GetHistoryResult(int key)
	{
		return null;
	}

	[Token(Token = "0x601408C")]
	[Address(RVA = "0x31EA2C8", Offset = "0x31EA2C8", VA = "0x31EA2C8")]
	public bool IsCupMatchChampion(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601408D")]
	[Address(RVA = "0x31ED630", Offset = "0x31ED630", VA = "0x31ED630")]
	public bool IsFirstLoseMatch(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x601408E")]
	[Address(RVA = "0x31ED74C", Offset = "0x31ED74C", VA = "0x31ED74C")]
	public CupMatchResult GetLastMatchResult(int key)
	{
		return default(CupMatchResult);
	}

	[Token(Token = "0x601408F")]
	[Address(RVA = "0x31ED7FC", Offset = "0x31ED7FC", VA = "0x31ED7FC")]
	public int GetSelfMatchIndexByMatchCnt(int matchCnt)
	{
		return default(int);
	}

	[Token(Token = "0x6014090")]
	[Address(RVA = "0x31ED888", Offset = "0x31ED888", VA = "0x31ED888")]
	public bool IsSelfTeamBattleIndex(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6014091")]
	[Address(RVA = "0x31ED908", Offset = "0x31ED908", VA = "0x31ED908")]
	public void FakeBattleRecord(int key)
	{
	}

	[Token(Token = "0x6014092")]
	[Address(RVA = "0x31EDE6C", Offset = "0x31EDE6C", VA = "0x31EDE6C")]
	public uint GetSelfTeamTier(int key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014093")]
	[Address(RVA = "0x31EAC64", Offset = "0x31EAC64", VA = "0x31EAC64")]
	public bool HasPlayedOneGame(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x6014094")]
	[Address(RVA = "0x31EDF00", Offset = "0x31EDF00", VA = "0x31EDF00")]
	public bool IsInvitedAccount(int key, FriendAccountInfo accountInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6014095")]
	[Address(RVA = "0x31EE008", Offset = "0x31EE008", VA = "0x31EE008")]
	public List<ulong> GetInvitedIdList(int key)
	{
		return null;
	}

	[Token(Token = "0x6014096")]
	[Address(RVA = "0x31E85C0", Offset = "0x31E85C0", VA = "0x31E85C0")]
	public static int GenerateKey(uint type, uint id)
	{
		return default(int);
	}

	[Token(Token = "0x6014097")]
	[Address(RVA = "0x31E9204", Offset = "0x31E9204", VA = "0x31E9204")]
	public static uint GetCupMatchTypeByKey(int key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014098")]
	[Address(RVA = "0x31E961C", Offset = "0x31E961C", VA = "0x31E961C")]
	public static uint GetCupMatchIDByKey(int key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014099")]
	[Address(RVA = "0x31EE0F0", Offset = "0x31EE0F0", VA = "0x31EE0F0", Slot = "16")]
	public bool AllProtocalReady()
	{
		return default(bool);
	}

	[Token(Token = "0x601409A")]
	[Address(RVA = "0x31EE170", Offset = "0x31EE170", VA = "0x31EE170", Slot = "17")]
	public bool SetEntranceBtnState()
	{
		return default(bool);
	}

	[Token(Token = "0x601409B")]
	[Address(RVA = "0x31EE4F0", Offset = "0x31EE4F0", VA = "0x31EE4F0", Slot = "14")]
	public OnlineMatchEntranceState GetEntranceBtnState()
	{
		return default(OnlineMatchEntranceState);
	}

	[Token(Token = "0x601409C")]
	[Address(RVA = "0x31EE55C", Offset = "0x31EE55C", VA = "0x31EE55C")]
	public int GetHightestPriorityMatchType()
	{
		return default(int);
	}

	[Token(Token = "0x601409D")]
	[Address(RVA = "0x31EE5C8", Offset = "0x31EE5C8", VA = "0x31EE5C8", Slot = "15")]
	public void SetEntranceWarmUpState()
	{
	}

	[Token(Token = "0x601409E")]
	[Address(RVA = "0x31EE804", Offset = "0x31EE804", VA = "0x31EE804", Slot = "20")]
	public void SetLobbyEntranceWarmUpPlayerPrefs()
	{
	}

	[Token(Token = "0x601409F")]
	[Address(RVA = "0x31EE9D0", Offset = "0x31EE9D0", VA = "0x31EE9D0", Slot = "21")]
	public void SetLobbyEntranceMatchOpenPlayerPrefs()
	{
	}

	[Token(Token = "0x60140A0")]
	[Address(RVA = "0x31EEC28", Offset = "0x31EEC28", VA = "0x31EEC28", Slot = "22")]
	public DateTime MatchStartTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x60140A1")]
	[Address(RVA = "0x31EEDB8", Offset = "0x31EEDB8", VA = "0x31EEDB8")]
	public static int GetLobbyEntrancePriority()
	{
		return default(int);
	}

	[Token(Token = "0x60140A2")]
	[Address(RVA = "0x31EEE08", Offset = "0x31EEE08", VA = "0x31EEE08", Slot = "23")]
	public int LobbyEntrancePriority()
	{
		return default(int);
	}

	[Token(Token = "0x60140A3")]
	[Address(RVA = "0x31EEE60", Offset = "0x31EEE60", VA = "0x31EEE60", Slot = "18")]
	public bool CanShowEntranceCountDown()
	{
		return default(bool);
	}

	[Token(Token = "0x60140A4")]
	[Address(RVA = "0x31EEF20", Offset = "0x31EEF20", VA = "0x31EEF20", Slot = "19")]
	public ulong GetCountDownTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x60140A5")]
	[Address(RVA = "0x31EEF8C", Offset = "0x31EEF8C", VA = "0x31EEF8C")]
	public void SetTeamInfoFlag()
	{
	}

	[Token(Token = "0x60140A6")]
	[Address(RVA = "0x31EF0C4", Offset = "0x31EF0C4", VA = "0x31EF0C4")]
	public void SetCupMatchInfoFlag()
	{
	}

	[Token(Token = "0x60140A7")]
	[Address(RVA = "0x31EF1FC", Offset = "0x31EF1FC", VA = "0x31EF1FC")]
	public void SetMapInfoFlag()
	{
	}

	[Token(Token = "0x60140A8")]
	[Address(RVA = "0x31EF334", Offset = "0x31EF334", VA = "0x31EF334")]
	public void RequestAllCupConfigReq(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60140A9")]
	[Address(RVA = "0x31EF698", Offset = "0x31EF698", VA = "0x31EF698")]
	public void RequestCreateTeam(uint type, uint id, string name, string countryOrArea, uint clanAvatar, uint clanBanner)
	{
	}

	[Token(Token = "0x60140AA")]
	[Address(RVA = "0x31EFA24", Offset = "0x31EFA24", VA = "0x31EFA24")]
	public void RequestJoinTeam(int key, ulong friendID, ulong teamID, bool byChat)
	{
	}

	[Token(Token = "0x60140AB")]
	[Address(RVA = "0x31EFFB0", Offset = "0x31EFFB0", VA = "0x31EFFB0")]
	private void CacheRequestedJoinTeamID(int key, ulong teamID)
	{
	}

	[Token(Token = "0x60140AC")]
	[Address(RVA = "0x31F016C", Offset = "0x31F016C", VA = "0x31F016C")]
	public void RequestModifyTeamInfo(int key, string teamName, string countryOrArea, uint clanAvatar, uint clanBanner)
	{
	}

	[Token(Token = "0x60140AD")]
	[Address(RVA = "0x31F0568", Offset = "0x31F0568", VA = "0x31F0568")]
	public void RequestTeamInfoByTeamID(int key, ulong teamID, bool requestTeamApplication = false)
	{
	}

	[Token(Token = "0x60140AE")]
	[Address(RVA = "0x31F0970", Offset = "0x31F0970", VA = "0x31F0970")]
	public void RequestSelfTeamMembers(uint type, uint id)
	{
	}

	[Token(Token = "0x60140AF")]
	[Address(RVA = "0x31F0D9C", Offset = "0x31F0D9C", VA = "0x31F0D9C")]
	public void RequestTeamMemberByMemberID(uint type, uint id)
	{
	}

	[Token(Token = "0x60140B0")]
	[Address(RVA = "0x31F0A24", Offset = "0x31F0A24", VA = "0x31F0A24")]
	public void RequestTeamMembers(int key, ulong teamID, bool requestTeamMemberPresence = false, bool forcePresence = false)
	{
	}

	[Token(Token = "0x60140B1")]
	[Address(RVA = "0x31F1040", Offset = "0x31F1040", VA = "0x31F1040")]
	public void RequestQuitTeam(int key, bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	[Token(Token = "0x60140B2")]
	[Address(RVA = "0x31F144C", Offset = "0x31F144C", VA = "0x31F144C")]
	public void RequestDismissTeam(int key, bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0uL, ulong inviterTeam = 0uL)
	{
	}

	[Token(Token = "0x60140B3")]
	[Address(RVA = "0x31F1844", Offset = "0x31F1844", VA = "0x31F1844")]
	public void RequestTeamApplicantList(int key, bool force = false)
	{
	}

	[Token(Token = "0x60140B4")]
	[Address(RVA = "0x31F1C3C", Offset = "0x31F1C3C", VA = "0x31F1C3C")]
	public void RequestInvitationList(uint type, uint id, bool force = false)
	{
	}

	[Token(Token = "0x60140B5")]
	[Address(RVA = "0x31F2000", Offset = "0x31F2000", VA = "0x31F2000")]
	public void RequestInvitedIdList(int key)
	{
	}

	[Token(Token = "0x60140B6")]
	[Address(RVA = "0x31F22D8", Offset = "0x31F22D8", VA = "0x31F22D8")]
	public void RequestApproveApplication(int key, ulong applicantID)
	{
	}

	[Token(Token = "0x60140B7")]
	[Address(RVA = "0x31F2620", Offset = "0x31F2620", VA = "0x31F2620")]
	public void RequestApproveApplication(int key, AccountInfoBasicWithCupInfo basicInfoWithCupTier)
	{
	}

	[Token(Token = "0x60140B8")]
	[Address(RVA = "0x31F299C", Offset = "0x31F299C", VA = "0x31F299C")]
	public void RequestDeclineApplication(int key, ulong[] applicantIDs)
	{
	}

	[Token(Token = "0x60140B9")]
	[Address(RVA = "0x31F2D20", Offset = "0x31F2D20", VA = "0x31F2D20")]
	public void RequestInvite(int key, ulong inviteeID)
	{
	}

	[Token(Token = "0x60140BA")]
	[Address(RVA = "0x31F31B0", Offset = "0x31F31B0", VA = "0x31F31B0")]
	public void RequestApproveJoinTeamInvitation(int key, ulong inviter, ulong inviterTeam)
	{
	}

	[Token(Token = "0x60140BB")]
	[Address(RVA = "0x31F353C", Offset = "0x31F353C", VA = "0x31F353C")]
	public void RequestDeclineJoinTeamInvitation(int key, ulong[] inviterIDs)
	{
	}

	[Token(Token = "0x60140BC")]
	[Address(RVA = "0x31F38D8", Offset = "0x31F38D8", VA = "0x31F38D8")]
	public void RequestTeamMemberPresence(int key, bool force = false)
	{
	}

	[Token(Token = "0x60140BD")]
	[Address(RVA = "0x31F3B2C", Offset = "0x31F3B2C", VA = "0x31F3B2C")]
	public void RequestRemoveTeamMember(int key, ulong removeeID)
	{
	}

	[Token(Token = "0x60140BE")]
	[Address(RVA = "0x31F3E94", Offset = "0x31F3E94", VA = "0x31F3E94")]
	public void RequestAccountCupInfoBundleByAccountIDsOrderly(uint type, uint id, ulong[] accountIDs, bool needTeamInfo, bool isSearch = false)
	{
	}

	[Token(Token = "0x60140BF")]
	[Address(RVA = "0x31F41B4", Offset = "0x31F41B4", VA = "0x31F41B4")]
	public void RequestClaimCupReward(uint type, uint id)
	{
	}

	[Token(Token = "0x60140C0")]
	[Address(RVA = "0x31F4490", Offset = "0x31F4490", VA = "0x31F4490")]
	public bool IsInRequestTicketCD()
	{
		return default(bool);
	}

	[Token(Token = "0x60140C1")]
	[Address(RVA = "0x31F4620", Offset = "0x31F4620", VA = "0x31F4620")]
	public void RequestUseTicket(uint type, uint id)
	{
	}

	[Token(Token = "0x60140C2")]
	[Address(RVA = "0x31F4988", Offset = "0x31F4988", VA = "0x31F4988")]
	public void RequestVerifyAndLockCupTeam(uint type, uint id)
	{
	}

	[Token(Token = "0x60140C3")]
	[Address(RVA = "0x31F4D90", Offset = "0x31F4D90", VA = "0x31F4D90")]
	public void InitAccountCupInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60140C4")]
	[Address(RVA = "0x31F506C", Offset = "0x31F506C", VA = "0x31F506C")]
	public void GetAccountCupInfo(uint type, uint id)
	{
	}

	[Token(Token = "0x60140C5")]
	[Address(RVA = "0x31F530C", Offset = "0x31F530C", VA = "0x31F530C")]
	public void OnJoinApplicantNotify(uint type, uint id)
	{
	}

	[Token(Token = "0x60140C6")]
	[Address(RVA = "0x31F54A0", Offset = "0x31F54A0", VA = "0x31F54A0")]
	public void OnConfrimAddNotify(ConfirmAddCupTeamReq ntf)
	{
	}

	[Token(Token = "0x60140C7")]
	[Address(RVA = "0x31F5694", Offset = "0x31F5694", VA = "0x31F5694")]
	public void OnDismissNotify(uint type, uint id, ulong teamID)
	{
	}

	[Token(Token = "0x60140C8")]
	[Address(RVA = "0x31F5858", Offset = "0x31F5858", VA = "0x31F5858")]
	public void OnRemoveNotify(uint type, uint id, ulong teamID, ulong removeeID)
	{
	}

	[Token(Token = "0x60140C9")]
	[Address(RVA = "0x31F5CB0", Offset = "0x31F5CB0", VA = "0x31F5CB0")]
	public void OnInviteNotify(uint type, uint id)
	{
	}

	[Token(Token = "0x60140CA")]
	[Address(RVA = "0x31F60C4", Offset = "0x31F60C4", VA = "0x31F60C4")]
	public void OnApproveInviteNotify(uint type, uint id)
	{
	}

	[Token(Token = "0x60140CB")]
	[Address(RVA = "0x31F6198", Offset = "0x31F6198", VA = "0x31F6198")]
	public void OnTeamMemeberPresenceNotify(PresenceListRes presenceData, int cupKey)
	{
	}

	[Token(Token = "0x60140CC")]
	[Address(RVA = "0x31F66C4", Offset = "0x31F66C4", VA = "0x31F66C4")]
	public int GetEntranceTrailOpenTipsCnt(int key)
	{
		return default(int);
	}

	[Token(Token = "0x60140CD")]
	[Address(RVA = "0x31E8F3C", Offset = "0x31E8F3C", VA = "0x31E8F3C")]
	public void SetEntranceTrailOpenTipsCnt(int key, int cnt)
	{
	}

	[Token(Token = "0x60140CE")]
	[Address(RVA = "0x31F53B8", Offset = "0x31F53B8", VA = "0x31F53B8")]
	public int GetCupMatchTeamApplicationTipsCnt(int key)
	{
		return default(int);
	}

	[Token(Token = "0x60140CF")]
	[Address(RVA = "0x31ECB58", Offset = "0x31ECB58", VA = "0x31ECB58")]
	public void SetCupMatchTeamApplicationTipsCnt(int key, int cnt)
	{
	}

	[Token(Token = "0x60140D0")]
	[Address(RVA = "0x31F5D5C", Offset = "0x31F5D5C", VA = "0x31F5D5C")]
	public int GetCupMatchTeamInvitationTipsCnt(int key)
	{
		return default(int);
	}

	[Token(Token = "0x60140D1")]
	[Address(RVA = "0x31F5E44", Offset = "0x31F5E44", VA = "0x31F5E44")]
	public void SetCupMatchTeamInvitationTipsCnt(int key, int cnt)
	{
	}

	[Token(Token = "0x60140D2")]
	[Address(RVA = "0x31F6980", Offset = "0x31F6980", VA = "0x31F6980")]
	public int GetTeamApplyTipsCnt(int key)
	{
		return default(int);
	}

	[Token(Token = "0x60140D3")]
	[Address(RVA = "0x31F6A00", Offset = "0x31F6A00", VA = "0x31F6A00")]
	public int GetTeamApplyAndInvitationTipsCnt()
	{
		return default(int);
	}

	[Token(Token = "0x60140D4")]
	[Address(RVA = "0x31F6BCC", Offset = "0x31F6BCC", VA = "0x31F6BCC")]
	public int GetAllLobbyTipsCnt()
	{
		return default(int);
	}

	[Token(Token = "0x60140D5")]
	[Address(RVA = "0x31F6F5C", Offset = "0x31F6F5C", VA = "0x31F6F5C")]
	public int GetCupMatchTeamTabTipsCnt(int key)
	{
		return default(int);
	}

	[Token(Token = "0x60140D6")]
	[Address(RVA = "0x31F67AC", Offset = "0x31F67AC", VA = "0x31F67AC")]
	public void UpdateCupMatchTeamTabTipsCnt(int key)
	{
	}

	[Token(Token = "0x60140D7")]
	[Address(RVA = "0x31F7044", Offset = "0x31F7044", VA = "0x31F7044")]
	public void ClearCupMatchTeamTabTipsCnt(int key)
	{
	}

	[Token(Token = "0x60140D8")]
	[Address(RVA = "0x31F71F0", Offset = "0x31F71F0", VA = "0x31F71F0")]
	public void SetClaimRewardTipsCnt(int key, int cnt)
	{
	}

	[Token(Token = "0x60140D9")]
	[Address(RVA = "0x31F6E74", Offset = "0x31F6E74", VA = "0x31F6E74")]
	public int GetClaimRewardTipsCnt(int key)
	{
		return default(int);
	}

	[Token(Token = "0x60140DA")]
	[Address(RVA = "0x31F7464", Offset = "0x31F7464", VA = "0x31F7464")]
	private bool _003CGetFirstCupMatchRewardDesc_003Em__0(CupChestDesc r)
	{
		return default(bool);
	}

	[Token(Token = "0x60140DB")]
	[Address(RVA = "0x31F7468", Offset = "0x31F7468", VA = "0x31F7468")]
	private void _003CRequestAllCupConfigReq_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60140DC")]
	[Address(RVA = "0x31F78CC", Offset = "0x31F78CC", VA = "0x31F78CC")]
	private static void _003CRequestTeamMemberByMemberID_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60140DD")]
	[Address(RVA = "0x31F78D0", Offset = "0x31F78D0", VA = "0x31F78D0")]
	private static ulong _003CRequestTeamMemberPresence_003Em__3(AccountInfoBasicWithCupInfo e)
	{
		return default(ulong);
	}

	[Token(Token = "0x60140DE")]
	[Address(RVA = "0x31F7908", Offset = "0x31F7908", VA = "0x31F7908")]
	private static ulong _003CRequestVerifyAndLockCupTeam_003Em__4(AccountInfoBasicWithCupInfo e)
	{
		return default(ulong);
	}

	[Token(Token = "0x60140DF")]
	[Address(RVA = "0x31F7940", Offset = "0x31F7940", VA = "0x31F7940")]
	private void _003CInitAccountCupInfo_003Em__5(HttpErrorCode errorcode, object res)
	{
	}

	[Token(Token = "0x60140E0")]
	[Address(RVA = "0x31F7BBC", Offset = "0x31F7BBC", VA = "0x31F7BBC")]
	private static void _003CGetAccountCupInfo_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60140E1")]
	[Address(RVA = "0x31F7BC0", Offset = "0x31F7BC0", VA = "0x31F7BC0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60140E2")]
	[Address(RVA = "0x31F7BC8", Offset = "0x31F7BC8", VA = "0x31F7BC8")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60140E3")]
	[Address(RVA = "0x31F7BD0", Offset = "0x31F7BD0", VA = "0x31F7BD0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
