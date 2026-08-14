using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002F64")]
public class UIModelClan : UIBaseModel
{
	[Token(Token = "0x2002F65")]
	public enum BoxStatus
	{
		[Token(Token = "0x40121C2")]
		None,
		[Token(Token = "0x40121C3")]
		Unavailable,
		[Token(Token = "0x40121C4")]
		Available,
		[Token(Token = "0x40121C5")]
		Claimed
	}

	[Token(Token = "0x2002F66")]
	private sealed class _003CGetClanTotalBadgeInfoList_003Ec__AnonStorey0
	{
		[Token(Token = "0x40121C6")]
		[FieldOffset(Offset = "0x8")]
		internal UnlockedClanBadgeInfo unlockBadge;

		[Token(Token = "0x6013DEA")]
		[Address(RVA = "0x334C1B8", Offset = "0x334C1B8", VA = "0x334C1B8")]
		public _003CGetClanTotalBadgeInfoList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013DEB")]
		[Address(RVA = "0x3369B6C", Offset = "0x3369B6C", VA = "0x3369B6C")]
		internal bool _003C_003Em__0(ClanBadgeItemInfo a)
		{
			return default(bool);
		}

		[Token(Token = "0x6013DEC")]
		[Address(RVA = "0x3369BB8", Offset = "0x3369BB8", VA = "0x3369BB8")]
		internal bool _003C_003Em__1(ClanBadgeItemInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F67")]
	private sealed class _003CRequestClanInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x40121C7")]
		[FieldOffset(Offset = "0x8")]
		internal Action suc;

		[Token(Token = "0x40121C8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DED")]
		[Address(RVA = "0x340A3B8", Offset = "0x340A3B8", VA = "0x340A3B8")]
		public _003CRequestClanInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013DEE")]
		[Address(RVA = "0x340A3C0", Offset = "0x340A3C0", VA = "0x340A3C0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F68")]
	private sealed class _003CRequestApplyForJoinClan_003Ec__AnonStorey3
	{
		[Token(Token = "0x40121C9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong clanid;

		[Token(Token = "0x40121CA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DEF")]
		[Address(RVA = "0x3409A94", Offset = "0x3409A94", VA = "0x3409A94")]
		public _003CRequestApplyForJoinClan_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6013DF0")]
		[Address(RVA = "0x3409A9C", Offset = "0x3409A9C", VA = "0x3409A9C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F69")]
	private sealed class _003CRequestCreateClan_003Ec__AnonStorey4
	{
		[Token(Token = "0x40121CB")]
		[FieldOffset(Offset = "0x8")]
		internal bool sendRecruitToWorld;

		[Token(Token = "0x40121CC")]
		[FieldOffset(Offset = "0xC")]
		internal string name;

		[Token(Token = "0x40121CD")]
		[FieldOffset(Offset = "0x10")]
		internal string slogan;

		[Token(Token = "0x40121CE")]
		[FieldOffset(Offset = "0x14")]
		internal uint entry_type;

		[Token(Token = "0x40121CF")]
		[FieldOffset(Offset = "0x18")]
		internal uint entry_level;

		[Token(Token = "0x40121D0")]
		[FieldOffset(Offset = "0x1C")]
		internal uint entry_rank;

		[Token(Token = "0x40121D1")]
		[FieldOffset(Offset = "0x20")]
		internal uint entry_csrank;

		[Token(Token = "0x40121D2")]
		[FieldOffset(Offset = "0x24")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DF1")]
		[Address(RVA = "0x340B114", Offset = "0x340B114", VA = "0x340B114")]
		public _003CRequestCreateClan_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6013DF2")]
		[Address(RVA = "0x340B11C", Offset = "0x340B11C", VA = "0x340B11C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F6A")]
	private sealed class _003CSendClanGroupInvite_003Ec__AnonStorey5
	{
		[Token(Token = "0x40121D3")]
		[FieldOffset(Offset = "0x8")]
		internal uint CSRankLimit;

		[Token(Token = "0x40121D4")]
		[FieldOffset(Offset = "0xC")]
		internal uint BRRankLimit;

		[Token(Token = "0x40121D5")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DF3")]
		[Address(RVA = "0x340FB48", Offset = "0x340FB48", VA = "0x340FB48")]
		public _003CSendClanGroupInvite_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6013DF4")]
		[Address(RVA = "0x340FB50", Offset = "0x340FB50", VA = "0x340FB50")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F6B")]
	private sealed class _003COperateClan_003Ec__AnonStorey6
	{
		[Token(Token = "0x40121D6")]
		[FieldOffset(Offset = "0x8")]
		internal ulong playerid;

		[Token(Token = "0x40121D7")]
		[FieldOffset(Offset = "0x10")]
		internal EClanOperation operate;

		[Token(Token = "0x40121D8")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DF5")]
		[Address(RVA = "0x34078C4", Offset = "0x34078C4", VA = "0x34078C4")]
		public _003COperateClan_003Ec__AnonStorey6()
		{
		}
	}

	[Token(Token = "0x2002F6C")]
	private sealed class _003COperateClan_003Ec__AnonStorey7
	{
		[Token(Token = "0x40121D9")]
		[FieldOffset(Offset = "0x8")]
		internal CSChangeMemberTypeReq req;

		[Token(Token = "0x40121DA")]
		[FieldOffset(Offset = "0xC")]
		internal _003COperateClan_003Ec__AnonStorey6 _003C_003Ef__ref_00246;

		[Token(Token = "0x6013DF6")]
		[Address(RVA = "0x34078CC", Offset = "0x34078CC", VA = "0x34078CC")]
		public _003COperateClan_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6013DF7")]
		[Address(RVA = "0x34078D4", Offset = "0x34078D4", VA = "0x34078D4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x6013DF8")]
		[Address(RVA = "0x3407EF4", Offset = "0x3407EF4", VA = "0x3407EF4")]
		internal void _003C_003Em__1(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x6013DF9")]
		[Address(RVA = "0x3408668", Offset = "0x3408668", VA = "0x3408668")]
		internal void _003C_003Em__2(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F6D")]
	private sealed class _003CRequestMemberList_003Ec__AnonStorey8
	{
		[Token(Token = "0x40121DB")]
		[FieldOffset(Offset = "0x8")]
		internal bool refreshPresent;

		[Token(Token = "0x40121DC")]
		[FieldOffset(Offset = "0x9")]
		internal bool forcePresence;

		[Token(Token = "0x40121DD")]
		[FieldOffset(Offset = "0xC")]
		internal object[] inviteData;

		[Token(Token = "0x40121DE")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DFA")]
		[Address(RVA = "0x340F358", Offset = "0x340F358", VA = "0x340F358")]
		public _003CRequestMemberList_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6013DFB")]
		[Address(RVA = "0x340F360", Offset = "0x340F360", VA = "0x340F360")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F6E")]
	private sealed class _003CModifyClanInfo_003Ec__AnonStorey9
	{
		[Token(Token = "0x40121DF")]
		[FieldOffset(Offset = "0x8")]
		internal string announcement;

		[Token(Token = "0x40121E0")]
		[FieldOffset(Offset = "0xC")]
		internal string slogan;

		[Token(Token = "0x40121E1")]
		[FieldOffset(Offset = "0x10")]
		internal uint entryType;

		[Token(Token = "0x40121E2")]
		[FieldOffset(Offset = "0x14")]
		internal uint areaId;

		[Token(Token = "0x40121E3")]
		[FieldOffset(Offset = "0x18")]
		internal uint playStyle;

		[Token(Token = "0x40121E4")]
		[FieldOffset(Offset = "0x1C")]
		internal uint entry_level;

		[Token(Token = "0x40121E5")]
		[FieldOffset(Offset = "0x20")]
		internal uint entry_rank;

		[Token(Token = "0x40121E6")]
		[FieldOffset(Offset = "0x24")]
		internal uint entry_cs_rank;

		[Token(Token = "0x40121E7")]
		[FieldOffset(Offset = "0x28")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DFC")]
		[Address(RVA = "0x3353360", Offset = "0x3353360", VA = "0x3353360")]
		public _003CModifyClanInfo_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6013DFD")]
		[Address(RVA = "0x3369FFC", Offset = "0x3369FFC", VA = "0x3369FFC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F6F")]
	private sealed class _003CModifyClanInfo_003Ec__AnonStoreyA
	{
		[Token(Token = "0x40121E8")]
		[FieldOffset(Offset = "0x8")]
		internal uint clan_badge_ID;

		[Token(Token = "0x40121E9")]
		[FieldOffset(Offset = "0xC")]
		internal bool CloseWindow;

		[Token(Token = "0x40121EA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013DFE")]
		[Address(RVA = "0x3407398", Offset = "0x3407398", VA = "0x3407398")]
		public _003CModifyClanInfo_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6013DFF")]
		[Address(RVA = "0x34073A0", Offset = "0x34073A0", VA = "0x34073A0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F70")]
	private sealed class _003CModifyClanName_003Ec__AnonStoreyB
	{
		[Token(Token = "0x40121EB")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x40121EC")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E00")]
		[Address(RVA = "0x340759C", Offset = "0x340759C", VA = "0x340759C")]
		public _003CModifyClanName_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6013E01")]
		[Address(RVA = "0x34075A4", Offset = "0x34075A4", VA = "0x34075A4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F71")]
	private sealed class _003CProcessClanApplication_003Ec__AnonStoreyC
	{
		[Token(Token = "0x40121ED")]
		[FieldOffset(Offset = "0x8")]
		internal ulong playerid;

		[Token(Token = "0x40121EE")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E02")]
		[Address(RVA = "0x3408D68", Offset = "0x3408D68", VA = "0x3408D68")]
		public _003CProcessClanApplication_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6013E03")]
		[Address(RVA = "0x3408D70", Offset = "0x3408D70", VA = "0x3408D70")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F72")]
	private sealed class _003CProcessClanInvitation_003Ec__AnonStoreyD
	{
		[Token(Token = "0x40121EF")]
		[FieldOffset(Offset = "0x8")]
		internal bool fromWorldChannel;

		[Token(Token = "0x40121F0")]
		[FieldOffset(Offset = "0x10")]
		internal ulong clanid;

		[Token(Token = "0x40121F1")]
		[FieldOffset(Offset = "0x18")]
		internal bool isClanWarRecruit;

		[Token(Token = "0x40121F2")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelClan _0024this;

		[Token(Token = "0x40121F3")]
		[FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013E04")]
		[Address(RVA = "0x34091D0", Offset = "0x34091D0", VA = "0x34091D0")]
		public _003CProcessClanInvitation_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6013E05")]
		[Address(RVA = "0x34091D8", Offset = "0x34091D8", VA = "0x34091D8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x6013E06")]
		[Address(RVA = "0x3409998", Offset = "0x3409998", VA = "0x3409998")]
		private static void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002F73")]
	private sealed class _003CExitClan_003Ec__AnonStoreyE
	{
		[Token(Token = "0x40121F4")]
		[FieldOffset(Offset = "0x8")]
		internal Action suc;

		[Token(Token = "0x40121F5")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E07")]
		[Address(RVA = "0x3354D38", Offset = "0x3354D38", VA = "0x3354D38")]
		public _003CExitClan_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6013E08")]
		[Address(RVA = "0x3369854", Offset = "0x3369854", VA = "0x3369854")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F74")]
	private sealed class _003CHasSignInToday_003Ec__AnonStoreyF
	{
		[Token(Token = "0x40121F6")]
		[FieldOffset(Offset = "0x8")]
		internal uint originDay;

		[Token(Token = "0x6013E09")]
		[Address(RVA = "0x3355A20", Offset = "0x3355A20", VA = "0x3355A20")]
		public _003CHasSignInToday_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6013E0A")]
		[Address(RVA = "0x3369EF0", Offset = "0x3369EF0", VA = "0x3369EF0")]
		internal bool _003C_003Em__0(ClanSignInRewardItem temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F75")]
	private sealed class _003CSinginClaim_003Ec__AnonStorey10
	{
		[Token(Token = "0x2002F76")]
		private sealed class _003CSinginClaim_003Ec__AnonStorey11
		{
			[Token(Token = "0x40121F9")]
			[FieldOffset(Offset = "0x8")]
			internal uint originDay;

			[Token(Token = "0x40121FA")]
			[FieldOffset(Offset = "0xC")]
			internal _003CSinginClaim_003Ec__AnonStorey10 _003C_003Ef__ref_002416;

			[Token(Token = "0x6013E0D")]
			[Address(RVA = "0x340FEE0", Offset = "0x340FEE0", VA = "0x340FEE0")]
			public _003CSinginClaim_003Ec__AnonStorey11()
			{
			}

			[Token(Token = "0x6013E0E")]
			[Address(RVA = "0x340FEE8", Offset = "0x340FEE8", VA = "0x340FEE8")]
			internal bool _003C_003Em__0(ClanSignInRewardItem temp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40121F7")]
		[FieldOffset(Offset = "0x8")]
		internal DayOfWeek day;

		[Token(Token = "0x40121F8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E0B")]
		[Address(RVA = "0x340FC28", Offset = "0x340FC28", VA = "0x340FC28")]
		public _003CSinginClaim_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6013E0C")]
		[Address(RVA = "0x340FC30", Offset = "0x340FC30", VA = "0x340FC30")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F77")]
	private sealed class _003CRequestClanLuckyBagsInfo_003Ec__AnonStorey12
	{
		[Token(Token = "0x40121FB")]
		[FieldOffset(Offset = "0x8")]
		internal bool isRefreshRequest;

		[Token(Token = "0x40121FC")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E0F")]
		[Address(RVA = "0x340A5BC", Offset = "0x340A5BC", VA = "0x340A5BC")]
		public _003CRequestClanLuckyBagsInfo_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6013E10")]
		[Address(RVA = "0x340A5C4", Offset = "0x340A5C4", VA = "0x340A5C4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x2002F78")]
	private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13
	{
		[Token(Token = "0x2002F79")]
		private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey14
		{
			[Token(Token = "0x4012203")]
			[FieldOffset(Offset = "0x8")]
			internal List<DrawClanLuckyBagResultInfo> luckyBagResultInfoList;

			[Token(Token = "0x4012204")]
			[FieldOffset(Offset = "0xC")]
			internal bool updateScoreProgressImmediately;

			[Token(Token = "0x6013E14")]
			[Address(RVA = "0x340D52C", Offset = "0x340D52C", VA = "0x340D52C")]
			public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey14()
			{
			}
		}

		[Token(Token = "0x2002F7A")]
		private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey19
		{
			[Token(Token = "0x4012205")]
			[FieldOffset(Offset = "0x8")]
			internal CSBatchDrawClanLuckyBagRes data;

			[Token(Token = "0x4012206")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13 _003C_003Ef__ref_002419;

			[Token(Token = "0x6013E15")]
			[Address(RVA = "0x340D534", Offset = "0x340D534", VA = "0x340D534")]
			public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey19()
			{
			}
		}

		[Token(Token = "0x2002F7B")]
		private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey17
		{
			[Token(Token = "0x4012207")]
			[FieldOffset(Offset = "0x8")]
			internal List<ulong> curDisposeSuccessLuckyBag;

			[Token(Token = "0x4012208")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13 _003C_003Ef__ref_002419;

			[Token(Token = "0x4012209")]
			[FieldOffset(Offset = "0x10")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey14 _003C_003Ef__ref_002420;

			[Token(Token = "0x401220A")]
			[FieldOffset(Offset = "0x14")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey19 _003C_003Ef__ref_002425;

			[Token(Token = "0x6013E16")]
			[Address(RVA = "0x340D53C", Offset = "0x340D53C", VA = "0x340D53C")]
			public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey17()
			{
			}

			[Token(Token = "0x6013E17")]
			[Address(RVA = "0x340D688", Offset = "0x340D688", VA = "0x340D688")]
			internal void _003C_003Em__0()
			{
			}

			[Token(Token = "0x6013E18")]
			[Address(RVA = "0x340D724", Offset = "0x340D724", VA = "0x340D724")]
			internal void _003C_003Em__1()
			{
			}
		}

		[Token(Token = "0x2002F7C")]
		private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey15
		{
			[Token(Token = "0x401220B")]
			[FieldOffset(Offset = "0x8")]
			internal int i;

			[Token(Token = "0x401220C")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13 _003C_003Ef__ref_002419;

			[Token(Token = "0x6013E19")]
			[Address(RVA = "0x340D544", Offset = "0x340D544", VA = "0x340D544")]
			public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey15()
			{
			}
		}

		[Token(Token = "0x2002F7D")]
		private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey16
		{
			[Token(Token = "0x401220D")]
			[FieldOffset(Offset = "0x8")]
			internal int j;

			[Token(Token = "0x401220E")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13 _003C_003Ef__ref_002419;

			[Token(Token = "0x401220F")]
			[FieldOffset(Offset = "0x10")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey14 _003C_003Ef__ref_002420;

			[Token(Token = "0x4012210")]
			[FieldOffset(Offset = "0x14")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey15 _003C_003Ef__ref_002421;

			[Token(Token = "0x6013E1A")]
			[Address(RVA = "0x340D54C", Offset = "0x340D54C", VA = "0x340D54C")]
			public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey16()
			{
			}

			[Token(Token = "0x6013E1B")]
			[Address(RVA = "0x340D564", Offset = "0x340D564", VA = "0x340D564")]
			internal bool _003C_003Em__0(ClanLuckyBag bag)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2002F7E")]
		private sealed class _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey18
		{
			[Token(Token = "0x4012211")]
			[FieldOffset(Offset = "0x8")]
			internal int i;

			[Token(Token = "0x4012212")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13 _003C_003Ef__ref_002419;

			[Token(Token = "0x4012213")]
			[FieldOffset(Offset = "0x10")]
			internal _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey17 _003C_003Ef__ref_002423;

			[Token(Token = "0x6013E1C")]
			[Address(RVA = "0x340D554", Offset = "0x340D554", VA = "0x340D554")]
			public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey18()
			{
			}

			[Token(Token = "0x6013E1D")]
			[Address(RVA = "0x340DA98", Offset = "0x340DA98", VA = "0x340DA98")]
			internal bool _003C_003Em__0(ClanLuckyBag a)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40121FD")]
		[FieldOffset(Offset = "0x8")]
		internal bool needResend;

		[Token(Token = "0x40121FE")]
		[FieldOffset(Offset = "0xC")]
		internal List<ulong> alreadyDisposeExistLuckyBag;

		[Token(Token = "0x40121FF")]
		[FieldOffset(Offset = "0x10")]
		internal List<ulong> alreadyDisposeSuccessLuckyBag;

		[Token(Token = "0x4012200")]
		[FieldOffset(Offset = "0x14")]
		internal int originSuccessLuckyBag;

		[Token(Token = "0x4012201")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelClan _0024this;

		[Token(Token = "0x4012202")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013E11")]
		[Address(RVA = "0x340B710", Offset = "0x340B710", VA = "0x340B710")]
		public _003CRequestDrawAllClanLuckyBag_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6013E12")]
		[Address(RVA = "0x340B718", Offset = "0x340B718", VA = "0x340B718")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013E13")]
		[Address(RVA = "0x340D55C", Offset = "0x340D55C", VA = "0x340D55C")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002F7F")]
	private sealed class _003CRequestDrawClanLuckyBag_003Ec__AnonStorey1A
	{
		[Token(Token = "0x4012214")]
		[FieldOffset(Offset = "0x8")]
		internal ulong bag_id;

		[Token(Token = "0x4012215")]
		[FieldOffset(Offset = "0x10")]
		internal ClanLuckyBag luckyBag;

		[Token(Token = "0x4012216")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelClan _0024this;

		[Token(Token = "0x4012217")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013E1E")]
		[Address(RVA = "0x340DB58", Offset = "0x340DB58", VA = "0x340DB58")]
		public _003CRequestDrawClanLuckyBag_003Ec__AnonStorey1A()
		{
		}

		[Token(Token = "0x6013E1F")]
		[Address(RVA = "0x340DB60", Offset = "0x340DB60", VA = "0x340DB60")]
		internal bool _003C_003Em__0(ClanLuckyBag item)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E20")]
		[Address(RVA = "0x340DBA0", Offset = "0x340DBA0", VA = "0x340DBA0")]
		internal bool _003C_003Em__1(ClanLuckyBag item)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E21")]
		[Address(RVA = "0x340DBE0", Offset = "0x340DBE0", VA = "0x340DBE0")]
		internal void _003C_003Em__2(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x6013E22")]
		[Address(RVA = "0x340EF64", Offset = "0x340EF64", VA = "0x340EF64")]
		private static CommonRewardItemInfo _003C_003Em__3(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6013E23")]
		[Address(RVA = "0x340EF6C", Offset = "0x340EF6C", VA = "0x340EF6C")]
		internal void _003C_003Em__4()
		{
		}
	}

	[Token(Token = "0x2002F80")]
	private sealed class _003CIsDrawedLuckyBag_003Ec__AnonStorey1B
	{
		[Token(Token = "0x4012218")]
		[FieldOffset(Offset = "0x8")]
		internal ulong bag_id;

		[Token(Token = "0x6013E24")]
		[Address(RVA = "0x3357BF4", Offset = "0x3357BF4", VA = "0x3357BF4")]
		public _003CIsDrawedLuckyBag_003Ec__AnonStorey1B()
		{
		}

		[Token(Token = "0x6013E25")]
		[Address(RVA = "0x3369F3C", Offset = "0x3369F3C", VA = "0x3369F3C")]
		internal bool _003C_003Em__0(LuckyBagDraw item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F81")]
	private sealed class _003CGetNewsStringFromNewsType_003Ec__AnonStorey1C
	{
		[Token(Token = "0x4012219")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountId;

		[Token(Token = "0x6013E26")]
		[Address(RVA = "0x3358FAC", Offset = "0x3358FAC", VA = "0x3358FAC")]
		public _003CGetNewsStringFromNewsType_003Ec__AnonStorey1C()
		{
		}

		[Token(Token = "0x6013E27")]
		[Address(RVA = "0x3369C60", Offset = "0x3369C60", VA = "0x3369C60")]
		internal bool _003C_003Em__0(ClanMember m)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F82")]
	private sealed class _003CFindClanMemberByID_003Ec__AnonStorey1D
	{
		[Token(Token = "0x401221A")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x6013E28")]
		[Address(RVA = "0x3359C44", Offset = "0x3359C44", VA = "0x3359C44")]
		public _003CFindClanMemberByID_003Ec__AnonStorey1D()
		{
		}

		[Token(Token = "0x6013E29")]
		[Address(RVA = "0x3369AE0", Offset = "0x3369AE0", VA = "0x3369AE0")]
		internal bool _003C_003Em__0(ClanMember member)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F83")]
	private sealed class _003CGetClanWarInviteList_003Ec__AnonStorey1E
	{
		[Token(Token = "0x401221B")]
		[FieldOffset(Offset = "0x8")]
		internal ClanMember member;

		[Token(Token = "0x6013E2A")]
		[Address(RVA = "0x335B128", Offset = "0x335B128", VA = "0x335B128")]
		public _003CGetClanWarInviteList_003Ec__AnonStorey1E()
		{
		}

		[Token(Token = "0x6013E2B")]
		[Address(RVA = "0x3369C04", Offset = "0x3369C04", VA = "0x3369C04")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F84")]
	private sealed class _003CGetNotifyInfo_003Ec__AnonStorey1F
	{
		[Token(Token = "0x401221C")]
		[FieldOffset(Offset = "0x8")]
		internal ClanWarInfoDesc desc;

		[Token(Token = "0x6013E2C")]
		[Address(RVA = "0x335C554", Offset = "0x335C554", VA = "0x335C554")]
		public _003CGetNotifyInfo_003Ec__AnonStorey1F()
		{
		}

		[Token(Token = "0x6013E2D")]
		[Address(RVA = "0x3369CB4", Offset = "0x3369CB4", VA = "0x3369CB4")]
		internal string _003C_003Em__0()
		{
			return null;
		}

		[Token(Token = "0x6013E2E")]
		[Address(RVA = "0x3369D9C", Offset = "0x3369D9C", VA = "0x3369D9C")]
		internal string _003C_003Em__1()
		{
			return null;
		}
	}

	[Token(Token = "0x2002F85")]
	private sealed class _003CGetBigLuckyBagByLevel_003Ec__AnonStorey20
	{
		[Token(Token = "0x401221D")]
		[FieldOffset(Offset = "0x8")]
		internal uint level;

		[Token(Token = "0x6013E2F")]
		[Address(RVA = "0x335D4C8", Offset = "0x335D4C8", VA = "0x335D4C8")]
		public _003CGetBigLuckyBagByLevel_003Ec__AnonStorey20()
		{
		}

		[Token(Token = "0x6013E30")]
		[Address(RVA = "0x3369B34", Offset = "0x3369B34", VA = "0x3369B34")]
		internal bool _003C_003Em__0(ClanLuckyBag b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F86")]
	private sealed class _003CGetStageStartTime_003Ec__AnonStorey21
	{
		[Token(Token = "0x401221E")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EClan.ClanWarPhaseType stage;

		[Token(Token = "0x6013E31")]
		[Address(RVA = "0x335DBFC", Offset = "0x335DBFC", VA = "0x335DBFC")]
		public _003CGetStageStartTime_003Ec__AnonStorey21()
		{
		}

		[Token(Token = "0x6013E32")]
		[Address(RVA = "0x3369EA8", Offset = "0x3369EA8", VA = "0x3369EA8")]
		internal bool _003C_003Em__0(ClanWarOpeningInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F87")]
	private sealed class _003CGetStageEndTime_003Ec__AnonStorey22
	{
		[Token(Token = "0x401221F")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EClan.ClanWarPhaseType stage;

		[Token(Token = "0x6013E33")]
		[Address(RVA = "0x335DD64", Offset = "0x335DD64", VA = "0x335DD64")]
		public _003CGetStageEndTime_003Ec__AnonStorey22()
		{
		}

		[Token(Token = "0x6013E34")]
		[Address(RVA = "0x3369E84", Offset = "0x3369E84", VA = "0x3369E84")]
		internal bool _003C_003Em__0(ClanWarOpeningInfoDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F88")]
	private sealed class _003CGetTeamAwardByLevel_003Ec__AnonStorey23
	{
		[Token(Token = "0x4012220")]
		[FieldOffset(Offset = "0x8")]
		internal uint level;

		[Token(Token = "0x6013E35")]
		[Address(RVA = "0x335E600", Offset = "0x335E600", VA = "0x335E600")]
		public _003CGetTeamAwardByLevel_003Ec__AnonStorey23()
		{
		}

		[Token(Token = "0x6013E36")]
		[Address(RVA = "0x3369ECC", Offset = "0x3369ECC", VA = "0x3369ECC")]
		internal bool _003C_003Em__0(ClanWarAwardDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F89")]
	private sealed class _003CIsInClanWarTeam_003Ec__AnonStorey24
	{
		[Token(Token = "0x4012221")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013E37")]
		[Address(RVA = "0x335E6C0", Offset = "0x335E6C0", VA = "0x335E6C0")]
		public _003CIsInClanWarTeam_003Ec__AnonStorey24()
		{
		}

		[Token(Token = "0x6013E38")]
		[Address(RVA = "0x3369F7C", Offset = "0x3369F7C", VA = "0x3369F7C")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F8A")]
	private sealed class _003CIsPrepareForClanWar_003Ec__AnonStorey25
	{
		[Token(Token = "0x4012222")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013E39")]
		[Address(RVA = "0x335E83C", Offset = "0x335E83C", VA = "0x335E83C")]
		public _003CIsPrepareForClanWar_003Ec__AnonStorey25()
		{
		}

		[Token(Token = "0x6013E3A")]
		[Address(RVA = "0x3369FB0", Offset = "0x3369FB0", VA = "0x3369FB0")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F8B")]
	private sealed class _003CTransferClanWarCaptain_003Ec__AnonStorey26
	{
		[Token(Token = "0x4012223")]
		[FieldOffset(Offset = "0x8")]
		internal ulong oldId;

		[Token(Token = "0x4012224")]
		[FieldOffset(Offset = "0x10")]
		internal ulong newId;

		[Token(Token = "0x6013E3B")]
		[Address(RVA = "0x340FF34", Offset = "0x340FF34", VA = "0x340FF34")]
		public _003CTransferClanWarCaptain_003Ec__AnonStorey26()
		{
		}

		[Token(Token = "0x6013E3C")]
		[Address(RVA = "0x340FF3C", Offset = "0x340FF3C", VA = "0x340FF3C")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E3D")]
		[Address(RVA = "0x340FF88", Offset = "0x340FF88", VA = "0x340FF88")]
		internal bool _003C_003Em__1(ClanWarTeamMemberInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F8C")]
	private sealed class _003CAddClanWarMember_003Ec__AnonStorey27
	{
		[Token(Token = "0x4012225")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013E3E")]
		[Address(RVA = "0x335F93C", Offset = "0x335F93C", VA = "0x335F93C")]
		public _003CAddClanWarMember_003Ec__AnonStorey27()
		{
		}

		[Token(Token = "0x6013E3F")]
		[Address(RVA = "0x3369820", Offset = "0x3369820", VA = "0x3369820")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F8D")]
	private sealed class _003CRemoveClanWarMember_003Ec__AnonStorey28
	{
		[Token(Token = "0x4012226")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013E40")]
		[Address(RVA = "0x3409A58", Offset = "0x3409A58", VA = "0x3409A58")]
		public _003CRemoveClanWarMember_003Ec__AnonStorey28()
		{
		}

		[Token(Token = "0x6013E41")]
		[Address(RVA = "0x3409A60", Offset = "0x3409A60", VA = "0x3409A60")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F8E")]
	private sealed class _003CSetClanWarMemberReady_003Ec__AnonStorey29
	{
		[Token(Token = "0x4012227")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6013E42")]
		[Address(RVA = "0x340FBEC", Offset = "0x340FBEC", VA = "0x340FBEC")]
		public _003CSetClanWarMemberReady_003Ec__AnonStorey29()
		{
		}

		[Token(Token = "0x6013E43")]
		[Address(RVA = "0x340FBF4", Offset = "0x340FBF4", VA = "0x340FBF4")]
		internal bool _003C_003Em__0(ClanWarTeamMemberInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F8F")]
	private sealed class _003CRequestLeaveClanWarTeam_003Ec__AnonStorey2A
	{
		[Token(Token = "0x4012228")]
		[FieldOffset(Offset = "0x8")]
		internal Action finished;

		[Token(Token = "0x4012229")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E44")]
		[Address(RVA = "0x340F170", Offset = "0x340F170", VA = "0x340F170")]
		public _003CRequestLeaveClanWarTeam_003Ec__AnonStorey2A()
		{
		}

		[Token(Token = "0x6013E45")]
		[Address(RVA = "0x340F178", Offset = "0x340F178", VA = "0x340F178")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F90")]
	private sealed class _003CRequestPrepareForClanWar_003Ec__AnonStorey2B
	{
		[Token(Token = "0x401222A")]
		[FieldOffset(Offset = "0x8")]
		internal bool isReady;

		[Token(Token = "0x401222B")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E46")]
		[Address(RVA = "0x340F9C4", Offset = "0x340F9C4", VA = "0x340F9C4")]
		public _003CRequestPrepareForClanWar_003Ec__AnonStorey2B()
		{
		}

		[Token(Token = "0x6013E47")]
		[Address(RVA = "0x340F9CC", Offset = "0x340F9CC", VA = "0x340F9CC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F91")]
	private sealed class _003CRequestClaimTeamAward_003Ec__AnonStorey2C
	{
		[Token(Token = "0x401222C")]
		[FieldOffset(Offset = "0x8")]
		internal uint level;

		[Token(Token = "0x401222D")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClan _0024this;

		[Token(Token = "0x401222E")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<AwardDesc, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013E48")]
		[Address(RVA = "0x3409FB4", Offset = "0x3409FB4", VA = "0x3409FB4")]
		public _003CRequestClaimTeamAward_003Ec__AnonStorey2C()
		{
		}

		[Token(Token = "0x6013E49")]
		[Address(RVA = "0x3409FBC", Offset = "0x3409FBC", VA = "0x3409FBC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013E4A")]
		[Address(RVA = "0x340A378", Offset = "0x340A378", VA = "0x340A378")]
		internal bool _003C_003Em__1(ClanWarAwardDesc item)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E4B")]
		[Address(RVA = "0x340A39C", Offset = "0x340A39C", VA = "0x340A39C")]
		private static CommonRewardItemInfo _003C_003Em__2(AwardDesc item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002F92")]
	private sealed class _003COperateClanWar_003Ec__AnonStorey2D
	{
		[Token(Token = "0x401222F")]
		[FieldOffset(Offset = "0x8")]
		internal ulong playerid;

		[Token(Token = "0x4012230")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelClan _0024this;

		[Token(Token = "0x6013E4C")]
		[Address(RVA = "0x3408B40", Offset = "0x3408B40", VA = "0x3408B40")]
		public _003COperateClanWar_003Ec__AnonStorey2D()
		{
		}

		[Token(Token = "0x6013E4D")]
		[Address(RVA = "0x3408B48", Offset = "0x3408B48", VA = "0x3408B48")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013E4E")]
		[Address(RVA = "0x3408C30", Offset = "0x3408C30", VA = "0x3408C30")]
		internal void _003C_003Em__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F93")]
	private sealed class _003CRequestExchangeClanBadge_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012231")]
		[FieldOffset(Offset = "0x8")]
		internal CSExchangeClanBadgeRes data;

		[Token(Token = "0x6013E4F")]
		[Address(RVA = "0x340F0D0", Offset = "0x340F0D0", VA = "0x340F0D0")]
		public _003CRequestExchangeClanBadge_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013E50")]
		[Address(RVA = "0x340F0D8", Offset = "0x340F0D8", VA = "0x340F0D8")]
		internal bool _003C_003Em__0(ClanBadgeItemInfo item)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E51")]
		[Address(RVA = "0x340F124", Offset = "0x340F124", VA = "0x340F124")]
		internal bool _003C_003Em__1(ClanBadgeItemInfo item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012131")]
	[FieldOffset(Offset = "0xC")]
	private ClanInfo m_MyClanInfo;

	[Token(Token = "0x4012132")]
	[FieldOffset(Offset = "0x10")]
	private List<ClanMember> m_ClanMemberList;

	[Token(Token = "0x4012133")]
	[FieldOffset(Offset = "0x14")]
	private List<ClanMember> m_OnlineClanMemberList;

	[Token(Token = "0x4012134")]
	[FieldOffset(Offset = "0x18")]
	private List<ClanInfo> m_ClanList;

	[Token(Token = "0x4012135")]
	[FieldOffset(Offset = "0x1C")]
	private List<BaseProfileInfo> m_ClanApplicationList;

	[Token(Token = "0x4012136")]
	[FieldOffset(Offset = "0x20")]
	private EClanRole m_MyClanRole;

	[Token(Token = "0x4012137")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<ulong, bool> m_ClanApplyStatus;

	[Token(Token = "0x4012138")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsWarMarchWaiting;

	[Token(Token = "0x4012139")]
	[FieldOffset(Offset = "0x2C")]
	public List<ulong> m_PlayerIdsInvitedToClan;

	[Token(Token = "0x401213A")]
	[FieldOffset(Offset = "0x30")]
	public List<ClanSignInRewardItem> m_SignInRewardItems;

	[Token(Token = "0x401213B")]
	[FieldOffset(Offset = "0x34")]
	public List<ClanSignInRewardItem> m_NextLevelSignInRewardItems;

	[Token(Token = "0x401213C")]
	[FieldOffset(Offset = "0x38")]
	public List<ClanWarMemberStatus> m_ClanWarTeamMemberStatusList;

	[Token(Token = "0x401213D")]
	[FieldOffset(Offset = "0x3C")]
	public List<ClanLuckyBag> m_ClanLuckyBagsList;

	[Token(Token = "0x401213E")]
	[FieldOffset(Offset = "0x40")]
	public List<LuckyBagDraw> m_LuckyBagDrawList;

	[Token(Token = "0x401213F")]
	[FieldOffset(Offset = "0x44")]
	public List<ClanLuckyBag> m_ClanBigLuckyBagsList;

	[Token(Token = "0x4012140")]
	[FieldOffset(Offset = "0x48")]
	public List<LuckyBagDraw> m_BigLuckyBagDrawList;

	[Token(Token = "0x4012141")]
	[FieldOffset(Offset = "0x4C")]
	public List<ClanLuckyBag> m_CurrentClanBigLuckyBagAvailableList;

	[Token(Token = "0x4012142")]
	[FieldOffset(Offset = "0x50")]
	public Dictionary<ulong, PresenceInfo> m_CachePresence;

	[Token(Token = "0x4012143")]
	[FieldOffset(Offset = "0x54")]
	private List<ClanBadgeItemInfo> m_ClanTotalBadgeItemList;

	[Token(Token = "0x4012144")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, ClanBadgeItemInfo> m_ClanTotalBadgeItemDic;

	[Token(Token = "0x4012145")]
	[FieldOffset(Offset = "0x5C")]
	private uint create_gold_cost;

	[Token(Token = "0x4012146")]
	[FieldOffset(Offset = "0x60")]
	private uint create_diamond_cost;

	[Token(Token = "0x4012147")]
	[FieldOffset(Offset = "0x64")]
	public EClanJoinState ClanJoinState;

	[Token(Token = "0x4012148")]
	public const int MinClanLevel = 1;

	[Token(Token = "0x4012149")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasInvitationToShow;

	[Token(Token = "0x401214A")]
	[FieldOffset(Offset = "0x6C")]
	private InviteToClanReq m_Inivtation;

	[Token(Token = "0x401214B")]
	[FieldOffset(Offset = "0x70")]
	private bool m_HasRequestClanLuckyBagInfo;

	[Token(Token = "0x401214C")]
	[FieldOffset(Offset = "0x74")]
	private float m_LastRequestRefreshLuckyBagInfoTime;

	[Token(Token = "0x401214D")]
	[FieldOffset(Offset = "0x78")]
	private List<ClanNews> m_MyClanNews;

	[Token(Token = "0x401214E")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_HasReadApplyDeputyCaptainRedDot;

	[Token(Token = "0x401214F")]
	[FieldOffset(Offset = "0x80")]
	public string ClanChanelSecret;

	[Token(Token = "0x4012150")]
	[FieldOffset(Offset = "0x88")]
	public ulong m_ClanGroupRecruitLastSendTime;

	[Token(Token = "0x4012151")]
	[FieldOffset(Offset = "0x90")]
	private bool m_CanApplyDeputyCaptain;

	[Token(Token = "0x4012152")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<uint, string> newsTypeDict;

	[Token(Token = "0x4012153")]
	public const uint PropID_ClanListUpdate = 2u;

	[Token(Token = "0x4012154")]
	public const uint PropID_GetClanInfo = 4u;

	[Token(Token = "0x4012155")]
	public const uint PropID_MemberListUpdate = 8u;

	[Token(Token = "0x4012156")]
	public const uint PropID_ClanApplicationUpdate = 16u;

	[Token(Token = "0x4012157")]
	public const uint PropID_CreateClanSuccess = 32u;

	[Token(Token = "0x4012158")]
	public const uint PropID_ClanJoinError = 64u;

	[Token(Token = "0x4012159")]
	public const uint PropID_QuitClan = 128u;

	[Token(Token = "0x401215A")]
	public const uint PropID_DismissClan = 256u;

	[Token(Token = "0x401215B")]
	public const uint PropID_AcceptJoinClanSuccess = 512u;

	[Token(Token = "0x401215C")]
	public const uint PropID_ClanInfoUpdate = 1024u;

	[Token(Token = "0x401215D")]
	public const uint PropID_ApplyDeputyCaptainSuccess = 2048u;

	[Token(Token = "0x401215E")]
	public const uint PropID_CanApplyDeputyCaptain = 4096u;

	[Token(Token = "0x401215F")]
	public const uint PropID_DeputyCaptainFailed = 8192u;

	[Token(Token = "0x4012160")]
	public const uint PropID_ClanWarTeamInfoUpdate = 16384u;

	[Token(Token = "0x4012161")]
	public const uint PropID_ClanWarTeamMemberStatus = 32768u;

	[Token(Token = "0x4012162")]
	public const uint PropID_ClanWarAwardUpdate = 65536u;

	[Token(Token = "0x4012163")]
	public const uint PropID_ClanWarBasicInfoUpdate = 131072u;

	[Token(Token = "0x4012164")]
	public const uint PropID_ClanBadgeUpdate = 262144u;

	[Token(Token = "0x4012165")]
	public const uint PropID_ClanUnlockBadge = 524288u;

	[Token(Token = "0x4012166")]
	public const uint PropID_NotifyErrorMessage = 1048576u;

	[Token(Token = "0x4012167")]
	public const uint PropID_NotifyNormalMessage = 2097152u;

	[Token(Token = "0x4012168")]
	public const uint PropID_Details = 4194304u;

	[Token(Token = "0x4012169")]
	public const uint PropID_ExtendScale = 8388608u;

	[Token(Token = "0x401216A")]
	public const uint PropID_GetSigninData = 16777216u;

	[Token(Token = "0x401216B")]
	public const uint PropID_SigninClaim = 33554432u;

	[Token(Token = "0x401216C")]
	public const uint PropID_GetLuckyBagsInfo = 67108864u;

	[Token(Token = "0x401216D")]
	public const uint PropID_DrawClanLuckyBag = 134217728u;

	[Token(Token = "0x401216E")]
	public const uint PropID_GetClanNews = 268435456u;

	[Token(Token = "0x401216F")]
	public const uint PropID_NotifyLuckyBag = 536870912u;

	[Token(Token = "0x4012170")]
	public const uint PropID_ClanInfoUpdated = 1073741824u;

	[Token(Token = "0x4012171")]
	public const uint PropID_ClanWarRecruitInfoUpdate = 2147483648u;

	[Token(Token = "0x4012172")]
	[FieldOffset(Offset = "0x0")]
	public static readonly uint INVALUED_CLANID;

	[Token(Token = "0x4012173")]
	[FieldOffset(Offset = "0x4")]
	public static readonly uint DEFAULT_CLAN_BADGE_ID;

	[Token(Token = "0x4012174")]
	[FieldOffset(Offset = "0x98")]
	private DayOfWeek m_CurrentDayWhenReceivedData;

	[Token(Token = "0x4012175")]
	[FieldOffset(Offset = "0x9C")]
	public bool m_HasGetCurrentSigninDataSinceLogin;

	[Token(Token = "0x4012176")]
	[FieldOffset(Offset = "0x9D")]
	public bool m_HasGetNextSigninDataSinceLogin;

	[Token(Token = "0x4012177")]
	[FieldOffset(Offset = "0x9E")]
	private bool _003CHasGetMembersSinceLogin_003Ek__BackingField;

	[Token(Token = "0x4012178")]
	[FieldOffset(Offset = "0x9F")]
	private bool m_HasActivityTriggerSinceLogin;

	[Token(Token = "0x4012179")]
	[FieldOffset(Offset = "0xA0")]
	private List<ulong> m_InRequestListBagID;

	[Token(Token = "0x401217A")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_InRequestCliamAllLuckyBag;

	[Token(Token = "0x401217B")]
	[FieldOffset(Offset = "0xA8")]
	public ulong m_FilterEndTimeStamp;

	[Token(Token = "0x401217C")]
	public const string DEFAULT_LABELSTRING = "TXT_BANNER_NAME_DEFAULT";

	[Token(Token = "0x401217D")]
	public const string CLAN_SETTING_NEW = "CLAN_SETTING_NEW";

	[Token(Token = "0x401217E")]
	[FieldOffset(Offset = "0xB0")]
	public bool AutoShowedLuckyBag;

	[Token(Token = "0x401217F")]
	[FieldOffset(Offset = "0xB4")]
	private int m_NewLuckyBagCnt;

	[Token(Token = "0x4012180")]
	[FieldOffset(Offset = "0xB8")]
	private List<ClanMember> m_SelfTopClanMemberList;

	[Token(Token = "0x4012181")]
	[FieldOffset(Offset = "0xBC")]
	private uint _003CClanTotalBigLuckyBagPoints_003Ek__BackingField;

	[Token(Token = "0x4012182")]
	[FieldOffset(Offset = "0xC0")]
	private uint m_BatchDrawLuckyBagMaxCounts;

	[Token(Token = "0x4012183")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_ReachBatchDrawLuckyBagMaxCounts;

	[Token(Token = "0x4012184")]
	[FieldOffset(Offset = "0xC8")]
	private uint _003CMyLuckyBagPoints_003Ek__BackingField;

	[Token(Token = "0x4012185")]
	[FieldOffset(Offset = "0xCC")]
	private uint m_NextLuckyBagLevel;

	[Token(Token = "0x4012186")]
	[FieldOffset(Offset = "0xD0")]
	private uint _003CMaxBigLuckyBagLevel_003Ek__BackingField;

	[Token(Token = "0x4012187")]
	[FieldOffset(Offset = "0xD4")]
	private uint _003CBigLuckyBagCountToClaim_003Ek__BackingField;

	[Token(Token = "0x4012188")]
	[FieldOffset(Offset = "0xD8")]
	private bool _003CReachSmallLuckBagDrewCountToday_003Ek__BackingField;

	[Token(Token = "0x4012189")]
	[FieldOffset(Offset = "0xE0")]
	private long _003CCountDownToThisCycle_003Ek__BackingField;

	[Token(Token = "0x401218A")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<string, string> m_ErrorMsgDic;

	[Token(Token = "0x401218B")]
	[FieldOffset(Offset = "0x8")]
	public static readonly uint MAX_CLAN_WAR_MEMBER_CNT;

	[Token(Token = "0x401218C")]
	[FieldOffset(Offset = "0x10")]
	public static readonly ulong LEAVE_JOIN_CLAN_WAR_INTERVAL;

	[Token(Token = "0x401218D")]
	[FieldOffset(Offset = "0x18")]
	public static readonly float CLAN_WAR_LOBBY_NOTICE_CD;

	[Token(Token = "0x401218E")]
	[FieldOffset(Offset = "0x20")]
	public static readonly ulong CLAN_WAR_INVITE_INTERVAL;

	[Token(Token = "0x401218F")]
	[FieldOffset(Offset = "0x28")]
	public static readonly ulong CLAN_WAR_TRANSFER_INTERVAL;

	[Token(Token = "0x4012190")]
	[FieldOffset(Offset = "0x30")]
	public static readonly ulong CLAN_WAR_KICK_INTERVAL;

	[Token(Token = "0x4012191")]
	[FieldOffset(Offset = "0x38")]
	public static readonly ulong CLAN_LUCKY_BAG_NOTICE_CD;

	[Token(Token = "0x4012192")]
	[FieldOffset(Offset = "0xEC")]
	private ClanWarInfoDesc m_ClanWarDesc;

	[Token(Token = "0x4012193")]
	[FieldOffset(Offset = "0xF0")]
	private List<ClanWarOpeningInfoDesc> m_ClanWarOpenInfoList;

	[Token(Token = "0x4012194")]
	[FieldOffset(Offset = "0xF4")]
	private List<ClanWarAwardDesc> m_ClanWarAwardList;

	[Token(Token = "0x4012195")]
	[FieldOffset(Offset = "0xF8")]
	private ClanWarPersonalAwardDesc m_ClanWarPersonalAward;

	[Token(Token = "0x4012196")]
	[FieldOffset(Offset = "0xFC")]
	private Dictionary<uint, ClanLuckyBagInfoDesc> m_DictClanBigLuckyBagInfo;

	[Token(Token = "0x4012197")]
	[FieldOffset(Offset = "0x100")]
	private List<ClanWarTeamMemberInfo> m_ClanWarTeamInfoList;

	[Token(Token = "0x4012198")]
	[FieldOffset(Offset = "0x104")]
	private List<uint> m_ClanWarTeamAwardedLevel;

	[Token(Token = "0x4012199")]
	[FieldOffset(Offset = "0x108")]
	private CSGetClanWarRecruitInfoRes m_ClanWarRecruitInfo;

	[Token(Token = "0x401219A")]
	[FieldOffset(Offset = "0x10C")]
	private uint m_ClanWarCacheTag1;

	[Token(Token = "0x401219B")]
	[FieldOffset(Offset = "0x110")]
	private uint m_ClanWarCacheTag2;

	[Token(Token = "0x401219C")]
	[FieldOffset(Offset = "0x114")]
	private ClanWarMemberAwardStatus m_MemberAwardStatus;

	[Token(Token = "0x401219D")]
	[FieldOffset(Offset = "0x118")]
	private ClanWarTeamAward m_TeamAward;

	[Token(Token = "0x401219E")]
	[FieldOffset(Offset = "0x120")]
	private ulong m_ClanWarTeamId;

	[Token(Token = "0x401219F")]
	[FieldOffset(Offset = "0x128")]
	private bool m_IsClanWarTeamExists;

	[Token(Token = "0x40121A0")]
	[FieldOffset(Offset = "0x129")]
	private bool m_IsInClanWarTeam;

	[Token(Token = "0x40121A1")]
	[FieldOffset(Offset = "0x130")]
	private ulong m_ClanWarCaptainId;

	[Token(Token = "0x40121A2")]
	[FieldOffset(Offset = "0x138")]
	private bool m_IsInClanNavigation;

	[Token(Token = "0x40121A3")]
	[FieldOffset(Offset = "0x139")]
	private bool m_IsDuringReadyStatus;

	[Token(Token = "0x40121A4")]
	[FieldOffset(Offset = "0x13A")]
	private bool m_IsDuringClanWarMatch;

	[Token(Token = "0x40121A5")]
	[FieldOffset(Offset = "0x140")]
	private ulong m_NewMemberId;

	[Token(Token = "0x40121A6")]
	[FieldOffset(Offset = "0x148")]
	private ulong m_TimeLeaveClanWarTeam;

	[Token(Token = "0x40121A7")]
	[FieldOffset(Offset = "0x150")]
	private bool m_ShouldSingleRewardTagVfxShow;

	[Token(Token = "0x40121A8")]
	[FieldOffset(Offset = "0x158")]
	private ulong m_NextClanWarTime;

	[Token(Token = "0x40121A9")]
	[FieldOffset(Offset = "0x160")]
	private bool m_IsDuringClanWarMatchMaking;

	[Token(Token = "0x40121AA")]
	[FieldOffset(Offset = "0x164")]
	private Dictionary<ulong, ulong> m_ClanWarInviteTimeDic;

	[Token(Token = "0x40121AB")]
	[FieldOffset(Offset = "0x168")]
	private ulong m_ClanWarTransferCptTime;

	[Token(Token = "0x40121AC")]
	[FieldOffset(Offset = "0x170")]
	private ulong m_ClanWarKickTime;

	[Token(Token = "0x40121AD")]
	[FieldOffset(Offset = "0x178")]
	private bool m_IsJoinRequested;

	[Token(Token = "0x40121AE")]
	[FieldOffset(Offset = "0x40")]
	private static Predicate<ClanMember> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40121AF")]
	[FieldOffset(Offset = "0x44")]
	private static Comparison<ClanBadgeItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40121B0")]
	[FieldOffset(Offset = "0x48")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40121B1")]
	[FieldOffset(Offset = "0x4C")]
	private static Func<PresenceInfo, ulong> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40121B2")]
	[FieldOffset(Offset = "0x50")]
	private static Func<ClanMember, bool> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40121B3")]
	[FieldOffset(Offset = "0x54")]
	private static Predicate<ClanMember> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40121B4")]
	[FieldOffset(Offset = "0x58")]
	private static Predicate<ClanMember> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x40121B5")]
	[FieldOffset(Offset = "0x5C")]
	private static Func<int> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x40121B6")]
	[FieldOffset(Offset = "0x60")]
	private static Comparison<LuckyBagDraw> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x40121B7")]
	[FieldOffset(Offset = "0x64")]
	private static Comparison<ClanLuckyBag> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x40121B8")]
	[FieldOffset(Offset = "0x68")]
	private static Comparison<ClanLuckyBag> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x40121B9")]
	[FieldOffset(Offset = "0x6C")]
	private static Predicate<ClanWarTeamMemberInfo> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x40121BA")]
	[FieldOffset(Offset = "0x70")]
	private static Predicate<ClanWarTeamMemberInfo> _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x40121BB")]
	[FieldOffset(Offset = "0x74")]
	private static Predicate<ClanWarTeamMemberInfo> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x40121BC")]
	[FieldOffset(Offset = "0x78")]
	private static Predicate<ClanWarTeamMemberInfo> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x40121BD")]
	[FieldOffset(Offset = "0x7C")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x40121BE")]
	[FieldOffset(Offset = "0x80")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache10;

	[Token(Token = "0x40121BF")]
	[FieldOffset(Offset = "0x84")]
	private static Predicate<ClanMember> _003C_003Ef__am_0024cache11;

	[Token(Token = "0x40121C0")]
	[FieldOffset(Offset = "0x88")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache12;

	[Token(Token = "0x17001480")]
	public List<ClanNews> MyClanNews
	{
		[Token(Token = "0x6013CD7")]
		[Address(RVA = "0x334A20C", Offset = "0x334A20C", VA = "0x334A20C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001481")]
	public bool HasReadApplyDeputyCaptainRedDot
	{
		[Token(Token = "0x6013CD9")]
		[Address(RVA = "0x334A374", Offset = "0x334A374", VA = "0x334A374")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013CD8")]
		[Address(RVA = "0x334A264", Offset = "0x334A264", VA = "0x334A264")]
		set
		{
		}
	}

	[Token(Token = "0x17001482")]
	public bool CanApplyDeputyCaptain
	{
		[Token(Token = "0x6013CDA")]
		[Address(RVA = "0x334A3CC", Offset = "0x334A3CC", VA = "0x334A3CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013CDB")]
		[Address(RVA = "0x334A424", Offset = "0x334A424", VA = "0x334A424")]
		set
		{
		}
	}

	[Token(Token = "0x17001483")]
	public bool HasGetMembersSinceLogin
	{
		[Token(Token = "0x6013CDD")]
		[Address(RVA = "0x334A580", Offset = "0x334A580", VA = "0x334A580")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013CDC")]
		[Address(RVA = "0x334A578", Offset = "0x334A578", VA = "0x334A578")]
		private set
		{
		}
	}

	[Token(Token = "0x17001484")]
	public int NewLuckyBagCnt
	{
		[Token(Token = "0x6013CDE")]
		[Address(RVA = "0x334A588", Offset = "0x334A588", VA = "0x334A588")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6013CDF")]
		[Address(RVA = "0x334A5E0", Offset = "0x334A5E0", VA = "0x334A5E0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001485")]
	public ulong MyClanID
	{
		[Token(Token = "0x6013CE0")]
		[Address(RVA = "0x334A7D4", Offset = "0x334A7D4", VA = "0x334A7D4")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001486")]
	public bool HasInvitationToShow
	{
		[Token(Token = "0x6013CE1")]
		[Address(RVA = "0x334A844", Offset = "0x334A844", VA = "0x334A844")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001487")]
	public InviteToClanReq Invitation
	{
		[Token(Token = "0x6013CE2")]
		[Address(RVA = "0x334A89C", Offset = "0x334A89C", VA = "0x334A89C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001488")]
	public EClanRole MyClanRole
	{
		[Token(Token = "0x6013CE3")]
		[Address(RVA = "0x334A8F4", Offset = "0x334A8F4", VA = "0x334A8F4")]
		get
		{
			return default(EClanRole);
		}
	}

	[Token(Token = "0x17001489")]
	public string ClanName
	{
		[Token(Token = "0x6013CE4")]
		[Address(RVA = "0x334ACC8", Offset = "0x334ACC8", VA = "0x334ACC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700148A")]
	public ClanInfo MyClanInfo
	{
		[Token(Token = "0x6013CE5")]
		[Address(RVA = "0x334AD38", Offset = "0x334AD38", VA = "0x334AD38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700148B")]
	public List<ClanMember> ClanMemberList
	{
		[Token(Token = "0x6013CE6")]
		[Address(RVA = "0x334AD90", Offset = "0x334AD90", VA = "0x334AD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700148C")]
	public List<ClanMember> SelfTopClanMemberList
	{
		[Token(Token = "0x6013CE7")]
		[Address(RVA = "0x334ADE8", Offset = "0x334ADE8", VA = "0x334ADE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700148D")]
	public List<ClanMember> OnlineClanMemberList
	{
		[Token(Token = "0x6013CE8")]
		[Address(RVA = "0x334B088", Offset = "0x334B088", VA = "0x334B088")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700148E")]
	public int ClanMemberNum
	{
		[Token(Token = "0x6013CE9")]
		[Address(RVA = "0x334B0E0", Offset = "0x334B0E0", VA = "0x334B0E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700148F")]
	public List<ClanInfo> ClanList
	{
		[Token(Token = "0x6013CEA")]
		[Address(RVA = "0x334B19C", Offset = "0x334B19C", VA = "0x334B19C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001490")]
	public List<UnlockedClanBadgeInfo> UnLockClanBadgeInfo
	{
		[Token(Token = "0x6013CEB")]
		[Address(RVA = "0x334B1F4", Offset = "0x334B1F4", VA = "0x334B1F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001491")]
	public uint ClanBadgeID
	{
		[Token(Token = "0x6013CEC")]
		[Address(RVA = "0x334B26C", Offset = "0x334B26C", VA = "0x334B26C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001492")]
	public List<BaseProfileInfo> ClanApplicationList
	{
		[Token(Token = "0x6013CF4")]
		[Address(RVA = "0x334C38C", Offset = "0x334C38C", VA = "0x334C38C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001493")]
	public Dictionary<ulong, bool> ClanApplyStatus
	{
		[Token(Token = "0x6013CF5")]
		[Address(RVA = "0x334C3E4", Offset = "0x334C3E4", VA = "0x334C3E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001494")]
	public uint GoldCost
	{
		[Token(Token = "0x6013CF8")]
		[Address(RVA = "0x334C528", Offset = "0x334C528", VA = "0x334C528")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001495")]
	public uint DiamondCost
	{
		[Token(Token = "0x6013CF9")]
		[Address(RVA = "0x334C69C", Offset = "0x334C69C", VA = "0x334C69C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001496")]
	public uint ClanTotalBigLuckyBagPoints
	{
		[Token(Token = "0x6013D29")]
		[Address(RVA = "0x3356038", Offset = "0x3356038", VA = "0x3356038")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013D2A")]
		[Address(RVA = "0x3356040", Offset = "0x3356040", VA = "0x3356040")]
		private set
		{
		}
	}

	[Token(Token = "0x17001497")]
	public uint MyLuckyBagPoints
	{
		[Token(Token = "0x6013D2B")]
		[Address(RVA = "0x3356048", Offset = "0x3356048", VA = "0x3356048")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013D2C")]
		[Address(RVA = "0x3356050", Offset = "0x3356050", VA = "0x3356050")]
		private set
		{
		}
	}

	[Token(Token = "0x17001498")]
	public uint NextLuckyBagLevel
	{
		[Token(Token = "0x6013D2D")]
		[Address(RVA = "0x3356058", Offset = "0x3356058", VA = "0x3356058")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013D2E")]
		[Address(RVA = "0x335615C", Offset = "0x335615C", VA = "0x335615C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001499")]
	public uint MaxBigLuckyBagLevel
	{
		[Token(Token = "0x6013D2F")]
		[Address(RVA = "0x3356154", Offset = "0x3356154", VA = "0x3356154")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013D30")]
		[Address(RVA = "0x33561BC", Offset = "0x33561BC", VA = "0x33561BC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700149A")]
	public uint BigLuckyBagCountToClaim
	{
		[Token(Token = "0x6013D31")]
		[Address(RVA = "0x33561C4", Offset = "0x33561C4", VA = "0x33561C4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013D32")]
		[Address(RVA = "0x334D0B4", Offset = "0x334D0B4", VA = "0x334D0B4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700149B")]
	public bool ReachSmallLuckBagDrewCountToday
	{
		[Token(Token = "0x6013D33")]
		[Address(RVA = "0x33561CC", Offset = "0x33561CC", VA = "0x33561CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013D34")]
		[Address(RVA = "0x33561D4", Offset = "0x33561D4", VA = "0x33561D4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700149C")]
	public long CountDownToThisCycle
	{
		[Token(Token = "0x6013D35")]
		[Address(RVA = "0x33561DC", Offset = "0x33561DC", VA = "0x33561DC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6013D36")]
		[Address(RVA = "0x33561E4", Offset = "0x33561E4", VA = "0x33561E4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700149D")]
	public Dictionary<ulong, ulong> ClanWarInviteTimeDic
	{
		[Token(Token = "0x6013D60")]
		[Address(RVA = "0x335B190", Offset = "0x335B190", VA = "0x335B190")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013D5F")]
		[Address(RVA = "0x335B130", Offset = "0x335B130", VA = "0x335B130")]
		set
		{
		}
	}

	[Token(Token = "0x1700149E")]
	public List<ClanLuckyBagInfoDesc> ClanLuckyBagInfoDescList
	{
		[Token(Token = "0x6013D61")]
		[Address(RVA = "0x335B1E8", Offset = "0x335B1E8", VA = "0x335B1E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700149F")]
	public bool IsDuringClanWarMatchMaking
	{
		[Token(Token = "0x6013D62")]
		[Address(RVA = "0x335B2F8", Offset = "0x335B2F8", VA = "0x335B2F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014A0")]
	public bool ShouldSingleRewardTagVfxShow
	{
		[Token(Token = "0x6013D64")]
		[Address(RVA = "0x335B3B0", Offset = "0x335B3B0", VA = "0x335B3B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013D63")]
		[Address(RVA = "0x335B350", Offset = "0x335B350", VA = "0x335B350")]
		set
		{
		}
	}

	[Token(Token = "0x170014A1")]
	public ulong NextClanWarTime
	{
		[Token(Token = "0x6013D65")]
		[Address(RVA = "0x335B408", Offset = "0x335B408", VA = "0x335B408")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170014A2")]
	public ulong TimeLeaveClanWarTeam
	{
		[Token(Token = "0x6013D66")]
		[Address(RVA = "0x335B468", Offset = "0x335B468", VA = "0x335B468")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170014A3")]
	public ulong NewMemberId
	{
		[Token(Token = "0x6013D67")]
		[Address(RVA = "0x335B4C8", Offset = "0x335B4C8", VA = "0x335B4C8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6013D68")]
		[Address(RVA = "0x335B528", Offset = "0x335B528", VA = "0x335B528")]
		set
		{
		}
	}

	[Token(Token = "0x170014A4")]
	public ClanWarMemberAwardStatus MemberAwardStatus
	{
		[Token(Token = "0x6013D69")]
		[Address(RVA = "0x335B5A8", Offset = "0x335B5A8", VA = "0x335B5A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014A5")]
	public bool IsInClanNavigation
	{
		[Token(Token = "0x6013D6B")]
		[Address(RVA = "0x335B660", Offset = "0x335B660", VA = "0x335B660")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013D6A")]
		[Address(RVA = "0x335B600", Offset = "0x335B600", VA = "0x335B600")]
		set
		{
		}
	}

	[Token(Token = "0x170014A6")]
	public bool IsDuringClanWarMatch
	{
		[Token(Token = "0x6013D6D")]
		[Address(RVA = "0x335B6B8", Offset = "0x335B6B8", VA = "0x335B6B8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013D6C")]
		[Address(RVA = "0x3352800", Offset = "0x3352800", VA = "0x3352800")]
		set
		{
		}
	}

	[Token(Token = "0x170014A7")]
	public bool IsDuringReadyStatus
	{
		[Token(Token = "0x6013D6F")]
		[Address(RVA = "0x335B770", Offset = "0x335B770", VA = "0x335B770")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013D6E")]
		[Address(RVA = "0x335B710", Offset = "0x335B710", VA = "0x335B710")]
		set
		{
		}
	}

	[Token(Token = "0x170014A8")]
	public ClanWarTeamAward TeamAward
	{
		[Token(Token = "0x6013D70")]
		[Address(RVA = "0x335B7C8", Offset = "0x335B7C8", VA = "0x335B7C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014A9")]
	public List<uint> ClanWarTeamAwardedLevel
	{
		[Token(Token = "0x6013D71")]
		[Address(RVA = "0x335B820", Offset = "0x335B820", VA = "0x335B820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014AA")]
	public ulong ClanWarCaptainId
	{
		[Token(Token = "0x6013D7F")]
		[Address(RVA = "0x3352860", Offset = "0x3352860", VA = "0x3352860")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6013D80")]
		[Address(RVA = "0x335D8AC", Offset = "0x335D8AC", VA = "0x335D8AC")]
		set
		{
		}
	}

	[Token(Token = "0x170014AB")]
	public List<ClanWarAwardDesc> ClanWarTeamAwardList
	{
		[Token(Token = "0x6013D81")]
		[Address(RVA = "0x335D92C", Offset = "0x335D92C", VA = "0x335D92C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014AC")]
	public List<ClanWarTeamMemberInfo> ClanWarTeamInfo
	{
		[Token(Token = "0x6013D93")]
		[Address(RVA = "0x335E608", Offset = "0x335E608", VA = "0x335E608")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013CD6")]
	[Address(RVA = "0x3348FD8", Offset = "0x3348FD8", VA = "0x3348FD8")]
	public UIModelClan()
	{
	}

	[Token(Token = "0x6013CED")]
	[Address(RVA = "0x334B2FC", Offset = "0x334B2FC", VA = "0x334B2FC")]
	public ClanBadgeItemInfo GetBadgeItemInfoByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6013CEE")]
	[Address(RVA = "0x334B400", Offset = "0x334B400", VA = "0x334B400")]
	public string GetSpriteNameByBadgeID(uint badgeID)
	{
		return null;
	}

	[Token(Token = "0x6013CEF")]
	[Address(RVA = "0x334B548", Offset = "0x334B548", VA = "0x334B548")]
	public void ProcessClanBadgeItemDic(List<ClanBadgeInfoData> clanBadgeInfoList)
	{
	}

	[Token(Token = "0x6013CF0")]
	[Address(RVA = "0x334B78C", Offset = "0x334B78C", VA = "0x334B78C")]
	public void ProcessClanBadgeItemList(List<ClanBadgeInfoData> clanBadgeInfoList)
	{
	}

	[Token(Token = "0x6013CF1")]
	[Address(RVA = "0x334B9C0", Offset = "0x334B9C0", VA = "0x334B9C0")]
	public Dictionary<uint, ClanBadgeItemInfo> GetClanTotalBadgeItemDic()
	{
		return null;
	}

	[Token(Token = "0x6013CF2")]
	[Address(RVA = "0x334BDE4", Offset = "0x334BDE4", VA = "0x334BDE4")]
	public List<ClanBadgeItemInfo> GetClanTotalBadgeInfoList()
	{
		return null;
	}

	[Token(Token = "0x6013CF3")]
	[Address(RVA = "0x334C1C0", Offset = "0x334C1C0", VA = "0x334C1C0")]
	private void SortTotalBagdeInfoList()
	{
	}

	[Token(Token = "0x6013CF6")]
	[Address(RVA = "0x334C43C", Offset = "0x334C43C", VA = "0x334C43C")]
	public bool IsManager()
	{
		return default(bool);
	}

	[Token(Token = "0x6013CF7")]
	[Address(RVA = "0x334C4D0", Offset = "0x334C4D0", VA = "0x334C4D0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013CFA")]
	[Address(RVA = "0x334C810", Offset = "0x334C810", VA = "0x334C810", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013CFB")]
	[Address(RVA = "0x334C990", Offset = "0x334C990", VA = "0x334C990", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013CFC")]
	[Address(RVA = "0x334CB3C", Offset = "0x334CB3C", VA = "0x334CB3C")]
	public void ClearSigninData()
	{
	}

	[Token(Token = "0x6013CFD")]
	[Address(RVA = "0x334CE1C", Offset = "0x334CE1C", VA = "0x334CE1C")]
	public void ClearSigninStatus()
	{
	}

	[Token(Token = "0x6013CFE")]
	[Address(RVA = "0x334CF20", Offset = "0x334CF20", VA = "0x334CF20")]
	public void ClearLuckyBagData()
	{
	}

	[Token(Token = "0x6013CFF")]
	[Address(RVA = "0x334D0BC", Offset = "0x334D0BC", VA = "0x334D0BC")]
	public string GetKeyByDayOfWeek(DayOfWeek day)
	{
		return null;
	}

	[Token(Token = "0x6013D00")]
	[Address(RVA = "0x334D240", Offset = "0x334D240", VA = "0x334D240")]
	public void RequestExchangeClanBadge(uint exchangeItemID)
	{
	}

	[Token(Token = "0x6013D01")]
	[Address(RVA = "0x334D4BC", Offset = "0x334D4BC", VA = "0x334D4BC")]
	public void RequestApplyDeputyCaptain()
	{
	}

	[Token(Token = "0x6013D02")]
	[Address(RVA = "0x334DBFC", Offset = "0x334DBFC", VA = "0x334DBFC")]
	public void RequestClanList(proto.EClan.ClanMainType mainType = proto.EClan.ClanMainType.ClanMainType_REGION, uint areaId = 0u, uint playStyle = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013D03")]
	[Address(RVA = "0x334DED0", Offset = "0x334DED0", VA = "0x334DED0")]
	public void SetClaimClanRaceAwardTime()
	{
	}

	[Token(Token = "0x6013D04")]
	[Address(RVA = "0x334DFA8", Offset = "0x334DFA8", VA = "0x334DFA8")]
	public void SearchClanList(ulong clanid)
	{
	}

	[Token(Token = "0x6013D05")]
	[Address(RVA = "0x334E250", Offset = "0x334E250", VA = "0x334E250")]
	public void SearchClanList(string keyword)
	{
	}

	[Token(Token = "0x6013D06")]
	[Address(RVA = "0x334E4C8", Offset = "0x334E4C8", VA = "0x334E4C8")]
	public void RequestMyClanInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013D07")]
	[Address(RVA = "0x334E678", Offset = "0x334E678", VA = "0x334E678")]
	public void RequestClanInfo(ulong clanid, uint httpOp = 0u, [Optional] Action suc, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013D08")]
	[Address(RVA = "0x334E98C", Offset = "0x334E98C", VA = "0x334E98C")]
	public void RequestApplyForJoinClan(ClanInfo clanInfo)
	{
	}

	[Token(Token = "0x6013D09")]
	[Address(RVA = "0x334EA94", Offset = "0x334EA94", VA = "0x334EA94")]
	public void RequestApplyForJoinClan(ulong clanid)
	{
	}

	[Token(Token = "0x6013D0A")]
	[Address(RVA = "0x334EE2C", Offset = "0x334EE2C", VA = "0x334EE2C")]
	public void RequestCreateClan(string name, string slogan, proto.EInventory.CurrencyType currency_type, uint entry_type, uint areaId, uint playStyle, bool sendRecruitToWorld = false, uint entry_level = 0u, uint entry_rank = 0u, uint entry_csrank = 0u, uint clan_badge_id = 1u)
	{
	}

	[Token(Token = "0x6013D0B")]
	[Address(RVA = "0x334F304", Offset = "0x334F304", VA = "0x334F304")]
	public bool SendClanGroupInvite(uint BRRankLimit, uint CSRankLimit, uint tag1, uint tag2)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D0C")]
	[Address(RVA = "0x334FD40", Offset = "0x334FD40", VA = "0x334FD40")]
	public void OperateClan(EClanOperation operate, ulong playerid)
	{
	}

	[Token(Token = "0x6013D0D")]
	[Address(RVA = "0x33509C8", Offset = "0x33509C8", VA = "0x33509C8")]
	public void DismissClan()
	{
	}

	[Token(Token = "0x6013D0E")]
	[Address(RVA = "0x3350CD4", Offset = "0x3350CD4", VA = "0x3350CD4")]
	public void ClanDismissNtf()
	{
	}

	[Token(Token = "0x6013D0F")]
	[Address(RVA = "0x3350D9C", Offset = "0x3350D9C", VA = "0x3350D9C")]
	public void InviteToClan(ulong playerid)
	{
	}

	[Token(Token = "0x6013D10")]
	[Address(RVA = "0x335135C", Offset = "0x335135C", VA = "0x335135C")]
	public void RequestDetails()
	{
	}

	[Token(Token = "0x6013D11")]
	[Address(RVA = "0x33516D8", Offset = "0x33516D8", VA = "0x33516D8")]
	public void RequestMemberList(bool forceUpdate = true, [Optional] object[] inviteData, bool refreshPresent = true, bool forcePresence = false)
	{
	}

	[Token(Token = "0x6013D12")]
	[Address(RVA = "0x3351EA8", Offset = "0x3351EA8", VA = "0x3351EA8")]
	public void RequestActivityTrigger()
	{
	}

	[Token(Token = "0x6013D13")]
	[Address(RVA = "0x3351C2C", Offset = "0x3351C2C", VA = "0x3351C2C")]
	public void RequesetClanmemberPresence(bool force = false)
	{
	}

	[Token(Token = "0x6013D14")]
	[Address(RVA = "0x33520F4", Offset = "0x33520F4", VA = "0x33520F4")]
	internal void RefreshMemberPresences(PresenceListRes resData)
	{
	}

	[Token(Token = "0x6013D15")]
	[Address(RVA = "0x3352E40", Offset = "0x3352E40", VA = "0x3352E40")]
	public void ModifyClanInfo(string announcement, string slogan, uint entryType, uint areaId, uint playStyle, uint entry_level = 0u, uint entry_rank = 0u, uint entry_cs_rank = 0u)
	{
	}

	[Token(Token = "0x6013D16")]
	[Address(RVA = "0x3353368", Offset = "0x3353368", VA = "0x3353368")]
	public void ModifyClanInfo(uint clan_badge_ID, bool CloseWindow)
	{
	}

	[Token(Token = "0x6013D17")]
	[Address(RVA = "0x335376C", Offset = "0x335376C", VA = "0x335376C")]
	public void ModifyClanName(string name)
	{
	}

	[Token(Token = "0x6013D18")]
	[Address(RVA = "0x3353A34", Offset = "0x3353A34", VA = "0x3353A34")]
	public void ExtendClanScale()
	{
	}

	[Token(Token = "0x6013D19")]
	[Address(RVA = "0x3353D58", Offset = "0x3353D58", VA = "0x3353D58")]
	public void RequestClanApplication()
	{
	}

	[Token(Token = "0x6013D1A")]
	[Address(RVA = "0x3354054", Offset = "0x3354054", VA = "0x3354054")]
	public void ProcessClanApplication(bool isAccept, ulong playerid)
	{
	}

	[Token(Token = "0x6013D1B")]
	[Address(RVA = "0x335448C", Offset = "0x335448C", VA = "0x335448C")]
	private void SetApplyRedDotCount()
	{
	}

	[Token(Token = "0x6013D1C")]
	[Address(RVA = "0x33545CC", Offset = "0x33545CC", VA = "0x33545CC")]
	public void ProcessClanInvitation(bool isAccept, ulong inviterid, ulong clanid, bool isClanWarRecruit = false, bool fromWorldChannel = false)
	{
	}

	[Token(Token = "0x6013D1D")]
	[Address(RVA = "0x3354938", Offset = "0x3354938", VA = "0x3354938")]
	public void ExitClan(bool fromRecruit = false, [Optional] Action suc)
	{
	}

	[Token(Token = "0x6013D1E")]
	[Address(RVA = "0x3354D40", Offset = "0x3354D40", VA = "0x3354D40")]
	public void RequestSigninData()
	{
	}

	[Token(Token = "0x6013D1F")]
	[Address(RVA = "0x3354F64", Offset = "0x3354F64", VA = "0x3354F64")]
	public void OnResponseGetSinginData(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013D20")]
	[Address(RVA = "0x3355334", Offset = "0x3355334", VA = "0x3355334")]
	private int GetCanClaimCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013D21")]
	[Address(RVA = "0x33555AC", Offset = "0x33555AC", VA = "0x33555AC")]
	public bool PermitClaim()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D22")]
	[Address(RVA = "0x33552A4", Offset = "0x33552A4", VA = "0x33552A4")]
	public int GetGuildSigninRedDotCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013D23")]
	[Address(RVA = "0x33558E0", Offset = "0x33558E0", VA = "0x33558E0")]
	public bool HasItemToClaim(proto.EClan.ClanSignInRewardStatus signinStatus, DayOfWeek day)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D24")]
	[Address(RVA = "0x33556CC", Offset = "0x33556CC", VA = "0x33556CC")]
	public bool HasSignInToday()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D25")]
	[Address(RVA = "0x3355A94", Offset = "0x3355A94", VA = "0x3355A94")]
	public List<ClanSignInRewardItem> GetClanSignInData()
	{
		return null;
	}

	[Token(Token = "0x6013D26")]
	[Address(RVA = "0x3355AEC", Offset = "0x3355AEC", VA = "0x3355AEC")]
	public void RequestNextLevelSigninData()
	{
	}

	[Token(Token = "0x6013D27")]
	[Address(RVA = "0x3355D68", Offset = "0x3355D68", VA = "0x3355D68")]
	public List<ClanSignInRewardItem> GetNextLevelClanSignInData()
	{
		return null;
	}

	[Token(Token = "0x6013D28")]
	[Address(RVA = "0x3355DC0", Offset = "0x3355DC0", VA = "0x3355DC0")]
	public void SinginClaim(DayOfWeek day)
	{
	}

	[Token(Token = "0x6013D37")]
	[Address(RVA = "0x33561F4", Offset = "0x33561F4", VA = "0x33561F4")]
	public void RequestClanLuckyBagsInfo(ulong clan_id, bool isRefreshRequest = false)
	{
	}

	[Token(Token = "0x6013D38")]
	[Address(RVA = "0x3356590", Offset = "0x3356590", VA = "0x3356590")]
	public bool CanRequestClanLuckyBagInfo(bool isRefreshRequest = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D39")]
	[Address(RVA = "0x3356748", Offset = "0x3356748", VA = "0x3356748")]
	public void RequestDrawAllClanLuckyBag(List<ulong> alreadyDisposeSuccessLuckyBag, List<ulong> alreadyDisposeExistLuckyBag, bool needResend = false)
	{
	}

	[Token(Token = "0x6013D3A")]
	[Address(RVA = "0x3356F8C", Offset = "0x3356F8C", VA = "0x3356F8C")]
	public bool NeedShowClaimAllBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D3B")]
	[Address(RVA = "0x3357584", Offset = "0x3357584", VA = "0x3357584")]
	public void RequestDrawClanLuckyBag(ClanLuckyBag bag, proto.EClan.LuckyBagType bagType)
	{
	}

	[Token(Token = "0x6013D3C")]
	[Address(RVA = "0x3357A8C", Offset = "0x3357A8C", VA = "0x3357A8C")]
	public bool IsDrawedLuckyBag(ulong bag_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D3D")]
	[Address(RVA = "0x3357BFC", Offset = "0x3357BFC", VA = "0x3357BFC")]
	public void SortLuckyBagList()
	{
	}

	[Token(Token = "0x6013D3E")]
	[Address(RVA = "0x3357D04", Offset = "0x3357D04", VA = "0x3357D04")]
	private int SortLuckyBagList(ClanLuckyBag x, ClanLuckyBag y)
	{
		return default(int);
	}

	[Token(Token = "0x6013D3F")]
	[Address(RVA = "0x3357DB4", Offset = "0x3357DB4", VA = "0x3357DB4")]
	public void FilterLuckyBagList()
	{
	}

	[Token(Token = "0x6013D40")]
	[Address(RVA = "0x3358020", Offset = "0x3358020", VA = "0x3358020")]
	public bool HasUnClamiedLucykBag()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D41")]
	[Address(RVA = "0x3358094", Offset = "0x3358094", VA = "0x3358094")]
	private void AddNewSmallLuckyBag(ClanLuckyBag luckyBag)
	{
	}

	[Token(Token = "0x6013D42")]
	[Address(RVA = "0x33582E4", Offset = "0x33582E4", VA = "0x33582E4")]
	public void AddNewLuckyBag(NewLuckyBagList luckyBagList)
	{
	}

	[Token(Token = "0x6013D43")]
	[Address(RVA = "0x3358740", Offset = "0x3358740", VA = "0x3358740")]
	public void RequestMyClanNews()
	{
	}

	[Token(Token = "0x6013D44")]
	[Address(RVA = "0x3358984", Offset = "0x3358984", VA = "0x3358984")]
	public string GetNewsStringFromNewsType(proto.EClan.NewsType type, ulong accountId, EClanRole memberType, uint level)
	{
		return null;
	}

	[Token(Token = "0x6013D45")]
	[Address(RVA = "0x3358FB4", Offset = "0x3358FB4", VA = "0x3358FB4")]
	public void UpdateClanMallTipsNum()
	{
	}

	[Token(Token = "0x6013D46")]
	[Address(RVA = "0x334A64C", Offset = "0x334A64C", VA = "0x334A64C")]
	public void UpdateLuckyBagTipsNum()
	{
	}

	[Token(Token = "0x6013D47")]
	[Address(RVA = "0x33570E8", Offset = "0x33570E8", VA = "0x33570E8")]
	public bool IsFreezedTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D48")]
	[Address(RVA = "0x3359100", Offset = "0x3359100", VA = "0x3359100")]
	public bool IsLuckyBagSwitchOn()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D49")]
	[Address(RVA = "0x3357FB0", Offset = "0x3357FB0", VA = "0x3357FB0")]
	private bool IsShowLuckyBag(ClanLuckyBag luckyBag)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D4A")]
	[Address(RVA = "0x33591FC", Offset = "0x33591FC", VA = "0x33591FC")]
	private bool IsExpiredLuckyBag(ClanLuckyBag luckyBag)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D4B")]
	[Address(RVA = "0x3359398", Offset = "0x3359398", VA = "0x3359398")]
	public ulong CalculateLucykBagExpirationTime(ClanLuckyBag lucykBag)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013D4C")]
	[Address(RVA = "0x335553C", Offset = "0x335553C", VA = "0x335553C")]
	public DayOfWeek IntegerToDayOfWeek(uint weekday)
	{
		return default(DayOfWeek);
	}

	[Token(Token = "0x6013D4D")]
	[Address(RVA = "0x3355A28", Offset = "0x3355A28", VA = "0x3355A28")]
	public uint DayOfWeekToInteger(DayOfWeek weekday)
	{
		return default(uint);
	}

	[Token(Token = "0x6013D4E")]
	[Address(RVA = "0x3359518", Offset = "0x3359518", VA = "0x3359518")]
	public bool IsClanApplied(ulong clanID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D4F")]
	[Address(RVA = "0x335961C", Offset = "0x335961C", VA = "0x335961C")]
	public void SetHasInvitationToShow(bool hasInvitation, [Optional] InviteToClanReq ntf)
	{
	}

	[Token(Token = "0x6013D50")]
	[Address(RVA = "0x335969C", Offset = "0x335969C", VA = "0x335969C")]
	public int GetOnlineNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013D51")]
	[Address(RVA = "0x33597D0", Offset = "0x33597D0", VA = "0x33597D0")]
	public void TriggerVisitNewSetting()
	{
	}

	[Token(Token = "0x6013D52")]
	[Address(RVA = "0x3359918", Offset = "0x3359918", VA = "0x3359918")]
	public bool CheckHasShowNewSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D53")]
	[Address(RVA = "0x3359AE4", Offset = "0x3359AE4", VA = "0x3359AE4")]
	public ClanMember FindClanMemberByID(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6013D54")]
	[Address(RVA = "0x334CC30", Offset = "0x334CC30", VA = "0x334CC30")]
	public void ClearClanData()
	{
	}

	[Token(Token = "0x6013D55")]
	[Address(RVA = "0x3359C4C", Offset = "0x3359C4C", VA = "0x3359C4C")]
	private void ResetBagdeDataInfo()
	{
	}

	[Token(Token = "0x6013D56")]
	[Address(RVA = "0x3359FD0", Offset = "0x3359FD0", VA = "0x3359FD0")]
	public void ClearClanWarData()
	{
	}

	[Token(Token = "0x6013D57")]
	[Address(RVA = "0x335A100", Offset = "0x335A100", VA = "0x335A100")]
	public void ClearAll()
	{
	}

	[Token(Token = "0x6013D58")]
	[Address(RVA = "0x335A1D0", Offset = "0x335A1D0", VA = "0x335A1D0")]
	public void RefreshClanInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013D59")]
	[Address(RVA = "0x335A37C", Offset = "0x335A37C", VA = "0x335A37C")]
	private void NotifyErrorMessage(object[] param)
	{
	}

	[Token(Token = "0x6013D5A")]
	[Address(RVA = "0x335A6D0", Offset = "0x335A6D0", VA = "0x335A6D0")]
	private string GetErrorMsgKey(string errormsgS)
	{
		return null;
	}

	[Token(Token = "0x6013D5B")]
	[Address(RVA = "0x334D9A8", Offset = "0x334D9A8", VA = "0x334D9A8")]
	public ClanMember GetMyClanMemeberInfo()
	{
		return null;
	}

	[Token(Token = "0x6013D5C")]
	[Address(RVA = "0x335A978", Offset = "0x335A978", VA = "0x335A978")]
	public ClanMember FindDeputyCaptain()
	{
		return null;
	}

	[Token(Token = "0x6013D5D")]
	[Address(RVA = "0x335AB4C", Offset = "0x335AB4C", VA = "0x335AB4C")]
	public void SetDeputyCaptain(ulong deputyCaptainId)
	{
	}

	[Token(Token = "0x6013D5E")]
	[Address(RVA = "0x335AD8C", Offset = "0x335AD8C", VA = "0x335AD8C")]
	public List<ClanMember> GetClanWarInviteList()
	{
		return null;
	}

	[Token(Token = "0x6013D72")]
	[Address(RVA = "0x335B878", Offset = "0x335B878", VA = "0x335B878")]
	public void ProcessClanWarBasicInfo(CSClanWarBasicInfoRes res)
	{
	}

	[Token(Token = "0x6013D73")]
	[Address(RVA = "0x335BE18", Offset = "0x335BE18", VA = "0x335BE18")]
	private void UpdateNotify()
	{
	}

	[Token(Token = "0x6013D74")]
	[Address(RVA = "0x335C110", Offset = "0x335C110", VA = "0x335C110")]
	private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, ClanWarInfoDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6013D75")]
	[Address(RVA = "0x335C55C", Offset = "0x335C55C", VA = "0x335C55C")]
	private string _NotifyUrl(object[] parameters)
	{
		return null;
	}

	[Token(Token = "0x6013D76")]
	[Address(RVA = "0x334FC60", Offset = "0x334FC60", VA = "0x334FC60")]
	public bool IsClanWarPrepareOrMatching()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D77")]
	[Address(RVA = "0x335C62C", Offset = "0x335C62C", VA = "0x335C62C")]
	public void ProcessClanLuckyBagInfo(CSClanLuckyBagInfoDescRes res)
	{
	}

	[Token(Token = "0x6013D78")]
	[Address(RVA = "0x335C8B8", Offset = "0x335C8B8", VA = "0x335C8B8")]
	private void CalcMyLuckyBagPoints()
	{
	}

	[Token(Token = "0x6013D79")]
	[Address(RVA = "0x335D210", Offset = "0x335D210", VA = "0x335D210")]
	public uint GetFinishPointsOfBigLuckyBagByLevel(uint level)
	{
		return default(uint);
	}

	[Token(Token = "0x6013D7A")]
	[Address(RVA = "0x335D2A0", Offset = "0x335D2A0", VA = "0x335D2A0")]
	public ClanLuckyBagInfoDesc GetLuckyBagInfoDescByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x6013D7B")]
	[Address(RVA = "0x335D384", Offset = "0x335D384", VA = "0x335D384")]
	public ClanLuckyBag GetBigLuckyBagByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x6013D7C")]
	[Address(RVA = "0x335D4D0", Offset = "0x335D4D0", VA = "0x335D4D0")]
	public bool HasBigLuckyBagToClaim()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D7D")]
	[Address(RVA = "0x335D534", Offset = "0x335D534", VA = "0x335D534")]
	public bool AllBigLuckyBagClaimed()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D7E")]
	[Address(RVA = "0x335D5B4", Offset = "0x335D5B4", VA = "0x335D5B4")]
	public void HandleReturnToLobby()
	{
	}

	[Token(Token = "0x6013D82")]
	[Address(RVA = "0x335D764", Offset = "0x335D764", VA = "0x335D764")]
	public bool IsClanWarCaptain()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D83")]
	[Address(RVA = "0x335D984", Offset = "0x335D984", VA = "0x335D984")]
	public bool GetClanWarOpenState()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D84")]
	[Address(RVA = "0x33507B4", Offset = "0x33507B4", VA = "0x33507B4")]
	public proto.EClan.ClanWarPhaseType GetClanWarStage()
	{
		return default(proto.EClan.ClanWarPhaseType);
	}

	[Token(Token = "0x6013D85")]
	[Address(RVA = "0x335DA9C", Offset = "0x335DA9C", VA = "0x335DA9C")]
	public ulong GetStageStartTime(proto.EClan.ClanWarPhaseType stage)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013D86")]
	[Address(RVA = "0x335DC04", Offset = "0x335DC04", VA = "0x335DC04")]
	public ulong GetStageEndTime(proto.EClan.ClanWarPhaseType stage)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013D87")]
	[Address(RVA = "0x335DD6C", Offset = "0x335DD6C", VA = "0x335DD6C")]
	public uint GetClanWarSeasonId()
	{
		return default(uint);
	}

	[Token(Token = "0x6013D88")]
	[Address(RVA = "0x335DDD8", Offset = "0x335DDD8", VA = "0x335DDD8")]
	public List<AwardDesc> GetPersonalAwardIdList()
	{
		return null;
	}

	[Token(Token = "0x6013D89")]
	[Address(RVA = "0x334FCD4", Offset = "0x334FCD4", VA = "0x334FCD4")]
	public uint GetMaxPlayer()
	{
		return default(uint);
	}

	[Token(Token = "0x6013D8A")]
	[Address(RVA = "0x335DE44", Offset = "0x335DE44", VA = "0x335DE44")]
	public uint GetMinPlayer()
	{
		return default(uint);
	}

	[Token(Token = "0x6013D8B")]
	[Address(RVA = "0x335DEB0", Offset = "0x335DEB0", VA = "0x335DEB0")]
	public long GetClanWarStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x6013D8C")]
	[Address(RVA = "0x335DF24", Offset = "0x335DF24", VA = "0x335DF24")]
	public long GetClanWarEndTime()
	{
		return default(long);
	}

	[Token(Token = "0x6013D8D")]
	[Address(RVA = "0x335DF98", Offset = "0x335DF98", VA = "0x335DF98")]
	public string GetClanWarMapName()
	{
		return null;
	}

	[Token(Token = "0x6013D8E")]
	[Address(RVA = "0x335E07C", Offset = "0x335E07C", VA = "0x335E07C")]
	public uint GetClanWarLimitLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6013D8F")]
	[Address(RVA = "0x335E0E8", Offset = "0x335E0E8", VA = "0x335E0E8")]
	public string[] GetClanWarMapUrls()
	{
		return null;
	}

	[Token(Token = "0x6013D90")]
	[Address(RVA = "0x335E28C", Offset = "0x335E28C", VA = "0x335E28C")]
	public string GetClanWarReadyWndUrl()
	{
		return null;
	}

	[Token(Token = "0x6013D91")]
	[Address(RVA = "0x335E370", Offset = "0x335E370", VA = "0x335E370")]
	public string GetClanWarRule(uint index)
	{
		return null;
	}

	[Token(Token = "0x6013D92")]
	[Address(RVA = "0x335E4B8", Offset = "0x335E4B8", VA = "0x335E4B8")]
	public ClanWarAwardDesc GetTeamAwardByLevel(uint level)
	{
		return null;
	}

	[Token(Token = "0x6013D94")]
	[Address(RVA = "0x335D70C", Offset = "0x335D70C", VA = "0x335D70C")]
	public bool IsInClanWarTeam()
	{
		return default(bool);
	}

	[Token(Token = "0x6013D95")]
	[Address(RVA = "0x335E660", Offset = "0x335E660", VA = "0x335E660")]
	public void SetIsInClanWarTeam(bool value)
	{
	}

	[Token(Token = "0x6013D96")]
	[Address(RVA = "0x33528C0", Offset = "0x33528C0", VA = "0x33528C0")]
	public bool IsInClanWarTeam(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D97")]
	[Address(RVA = "0x335E6C8", Offset = "0x335E6C8", VA = "0x335E6C8")]
	public bool IsPrepareForClanWar(ulong id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013D98")]
	[Address(RVA = "0x335E844", Offset = "0x335E844", VA = "0x335E844")]
	public int GetPreparedNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013D99")]
	[Address(RVA = "0x335E9F0", Offset = "0x335E9F0", VA = "0x335E9F0")]
	public ulong[] GetClanWarMemberArray()
	{
		return null;
	}

	[Token(Token = "0x6013D9A")]
	[Address(RVA = "0x335EC28", Offset = "0x335EC28", VA = "0x335EC28")]
	public void RefreshClanWarTeam()
	{
	}

	[Token(Token = "0x6013D9B")]
	[Address(RVA = "0x335F06C", Offset = "0x335F06C", VA = "0x335F06C")]
	public void TransferClanWarCaptain(ulong newId, ulong oldId = 0uL)
	{
	}

	[Token(Token = "0x6013D9C")]
	[Address(RVA = "0x335F5F8", Offset = "0x335F5F8", VA = "0x335F5F8")]
	public void AddClanWarMember(ulong id, proto.EClan.ClanWarMemberType role)
	{
	}

	[Token(Token = "0x6013D9D")]
	[Address(RVA = "0x335F944", Offset = "0x335F944", VA = "0x335F944")]
	public void RemoveClanWarMember(ulong id)
	{
	}

	[Token(Token = "0x6013D9E")]
	[Address(RVA = "0x335FC00", Offset = "0x335FC00", VA = "0x335FC00")]
	public void SetClanWarMemberReady(ulong id, bool isReady)
	{
	}

	[Token(Token = "0x6013D9F")]
	[Address(RVA = "0x335FD60", Offset = "0x335FD60", VA = "0x335FD60")]
	public bool IsClanWarAllReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6013DA0")]
	[Address(RVA = "0x335FF38", Offset = "0x335FF38", VA = "0x335FF38")]
	public void RequestClanWarTeamMemberStatus(bool force = false)
	{
	}

	[Token(Token = "0x6013DA1")]
	[Address(RVA = "0x3360260", Offset = "0x3360260", VA = "0x3360260")]
	public void RequestClanWarRecruitInfo()
	{
	}

	[Token(Token = "0x6013DA2")]
	[Address(RVA = "0x33606BC", Offset = "0x33606BC", VA = "0x33606BC")]
	public void RequestClanWarTeamInfo()
	{
	}

	[Token(Token = "0x6013DA3")]
	[Address(RVA = "0x33609C8", Offset = "0x33609C8", VA = "0x33609C8")]
	public void BeforeRequestJoinClanWarTeam()
	{
	}

	[Token(Token = "0x6013DA4")]
	[Address(RVA = "0x3360AA0", Offset = "0x3360AA0", VA = "0x3360AA0")]
	public void RequestJoinClanWarTeam()
	{
	}

	[Token(Token = "0x6013DA5")]
	[Address(RVA = "0x33613D8", Offset = "0x33613D8", VA = "0x33613D8")]
	public void RequestLeaveClanWarTeam([Optional] Action finished)
	{
	}

	[Token(Token = "0x6013DA6")]
	[Address(RVA = "0x33616B4", Offset = "0x33616B4", VA = "0x33616B4")]
	public void RequestInviteToClanWarTeam(ulong id)
	{
	}

	[Token(Token = "0x6013DA7")]
	[Address(RVA = "0x3361A38", Offset = "0x3361A38", VA = "0x3361A38")]
	public void RequestClanWarStaticData()
	{
	}

	[Token(Token = "0x6013DA8")]
	[Address(RVA = "0x335BA74", Offset = "0x335BA74", VA = "0x335BA74")]
	public void RequestCheckIsMemberOfClanWarTeam()
	{
	}

	[Token(Token = "0x6013DA9")]
	[Address(RVA = "0x3362308", Offset = "0x3362308", VA = "0x3362308")]
	public void RequestPrepareForClanWar()
	{
	}

	[Token(Token = "0x6013DAA")]
	[Address(RVA = "0x3352A28", Offset = "0x3352A28", VA = "0x3352A28")]
	private void OnTeamMemberPresenceStatusUpdate()
	{
	}

	[Token(Token = "0x6013DAB")]
	[Address(RVA = "0x3362BC4", Offset = "0x3362BC4", VA = "0x3362BC4")]
	public void RequestStartClanWar()
	{
	}

	[Token(Token = "0x6013DAC")]
	[Address(RVA = "0x33626B4", Offset = "0x33626B4", VA = "0x33626B4")]
	public void RequestStartClanWarMatchMaking()
	{
	}

	[Token(Token = "0x6013DAD")]
	[Address(RVA = "0x3363730", Offset = "0x3363730", VA = "0x3363730")]
	public void RequestCancelClanWarMatchMaking()
	{
	}

	[Token(Token = "0x6013DAE")]
	[Address(RVA = "0x3363930", Offset = "0x3363930", VA = "0x3363930")]
	public void StopClanWarMatchMakingNtf()
	{
	}

	[Token(Token = "0x6013DAF")]
	[Address(RVA = "0x3363650", Offset = "0x3363650", VA = "0x3363650")]
	public void StartClanWarMatchMakingNtf()
	{
	}

	[Token(Token = "0x6013DB0")]
	[Address(RVA = "0x3363A10", Offset = "0x3363A10", VA = "0x3363A10")]
	public void RequestApproveJoinClanWarTeam(ulong id, ulong clanId)
	{
	}

	[Token(Token = "0x6013DB1")]
	[Address(RVA = "0x3362C4C", Offset = "0x3362C4C", VA = "0x3362C4C")]
	public void RequestCheckAllMembersPrepareStatus()
	{
	}

	[Token(Token = "0x6013DB2")]
	[Address(RVA = "0x3364224", Offset = "0x3364224", VA = "0x3364224")]
	public void RequestClaimTeamAward(uint level)
	{
	}

	[Token(Token = "0x6013DB3")]
	[Address(RVA = "0x3364890", Offset = "0x3364890", VA = "0x3364890")]
	public void RequestClaimPersonalAward()
	{
	}

	[Token(Token = "0x6013DB4")]
	[Address(RVA = "0x3364B18", Offset = "0x3364B18", VA = "0x3364B18")]
	public void OperateClanWar(EClanWarOperation operate, ulong playerid)
	{
	}

	[Token(Token = "0x6013DB5")]
	[Address(RVA = "0x3361CFC", Offset = "0x3361CFC", VA = "0x3361CFC")]
	private uint GetSystemPlatform()
	{
		return default(uint);
	}

	[Token(Token = "0x6013DB6")]
	[Address(RVA = "0x3361D60", Offset = "0x3361D60", VA = "0x3361D60")]
	private proto.MatchClientInfo GetMatchClientInfo()
	{
		return null;
	}

	[Token(Token = "0x6013DB7")]
	[Address(RVA = "0x3362F9C", Offset = "0x3362F9C", VA = "0x3362F9C")]
	private tcp.MatchClientInfo GetTCPMatchClientInfo()
	{
		return null;
	}

	[Token(Token = "0x6013DB8")]
	[Address(RVA = "0x33653A4", Offset = "0x33653A4", VA = "0x33653A4")]
	public void JoinClanWarTeamNtf(ulong id)
	{
	}

	[Token(Token = "0x6013DB9")]
	[Address(RVA = "0x33654D0", Offset = "0x33654D0", VA = "0x33654D0")]
	public void QuitClanWarTeamNtf(ulong quitId, ulong cptId)
	{
	}

	[Token(Token = "0x6013DBA")]
	[Address(RVA = "0x3365628", Offset = "0x3365628", VA = "0x3365628")]
	public void RemoveClanWarTeamNtf(ulong quitId, ulong cptId)
	{
	}

	[Token(Token = "0x6013DBB")]
	[Address(RVA = "0x3365790", Offset = "0x3365790", VA = "0x3365790")]
	public void AppointClanWarNewCaptainNtf(ulong oldId, ulong newId)
	{
	}

	[Token(Token = "0x6013DBC")]
	[Address(RVA = "0x3365898", Offset = "0x3365898", VA = "0x3365898")]
	public void PrepareClanWarNtf(ulong id, bool isPrepare)
	{
	}

	[Token(Token = "0x6013DBD")]
	[Address(RVA = "0x3365998", Offset = "0x3365998", VA = "0x3365998")]
	public void ClanWarMemberPrepareNtf()
	{
	}

	[Token(Token = "0x6013DBF")]
	[Address(RVA = "0x3365B64", Offset = "0x3365B64", VA = "0x3365B64")]
	private static bool _003Cget_SelfTopClanMemberList_003Em__0(ClanMember temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DC0")]
	[Address(RVA = "0x3365C7C", Offset = "0x3365C7C", VA = "0x3365C7C")]
	private static int _003CSortTotalBagdeInfoList_003Em__1(ClanBadgeItemInfo a, ClanBadgeItemInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013DC1")]
	[Address(RVA = "0x3365DB8", Offset = "0x3365DB8", VA = "0x3365DB8")]
	private void _003CRequestExchangeClanBadge_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DC2")]
	[Address(RVA = "0x3366260", Offset = "0x3366260", VA = "0x3366260")]
	private void _003CRequestApplyDeputyCaptain_003Em__3(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC3")]
	[Address(RVA = "0x336658C", Offset = "0x336658C", VA = "0x336658C")]
	private void _003CRequestClanList_003Em__4(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC4")]
	[Address(RVA = "0x3366750", Offset = "0x3366750", VA = "0x3366750")]
	private void _003CSearchClanList_003Em__5(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC5")]
	[Address(RVA = "0x3366A14", Offset = "0x3366A14", VA = "0x3366A14")]
	private void _003CSearchClanList_003Em__6(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC6")]
	[Address(RVA = "0x3366D48", Offset = "0x3366D48", VA = "0x3366D48")]
	private void _003CDismissClan_003Em__7(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC7")]
	[Address(RVA = "0x3366E80", Offset = "0x3366E80", VA = "0x3366E80")]
	private static void _003CInviteToClan_003Em__8(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC8")]
	[Address(RVA = "0x3367040", Offset = "0x3367040", VA = "0x3367040")]
	private void _003CRequestDetails_003Em__9(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DC9")]
	[Address(RVA = "0x3367138", Offset = "0x3367138", VA = "0x3367138")]
	private void _003CRequestActivityTrigger_003Em__A(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DCA")]
	[Address(RVA = "0x3367148", Offset = "0x3367148", VA = "0x3367148")]
	private static ulong _003CRefreshMemberPresences_003Em__B(PresenceInfo e)
	{
		return default(ulong);
	}

	[Token(Token = "0x6013DCB")]
	[Address(RVA = "0x3367174", Offset = "0x3367174", VA = "0x3367174")]
	private static bool _003CRefreshMemberPresences_003Em__C(ClanMember a)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DCC")]
	[Address(RVA = "0x3367294", Offset = "0x3367294", VA = "0x3367294")]
	private void _003CExtendClanScale_003Em__D(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DCD")]
	[Address(RVA = "0x33676F4", Offset = "0x33676F4", VA = "0x33676F4")]
	private void _003CRequestClanApplication_003Em__E(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DCE")]
	[Address(RVA = "0x33679E0", Offset = "0x33679E0", VA = "0x33679E0")]
	private void _003CRequestSigninData_003Em__F(HttpErrorCode code, object obj)
	{
	}

	[Token(Token = "0x6013DCF")]
	[Address(RVA = "0x33679F0", Offset = "0x33679F0", VA = "0x33679F0")]
	private void _003CRequestNextLevelSigninData_003Em__10(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DD0")]
	[Address(RVA = "0x3367B98", Offset = "0x3367B98", VA = "0x3367B98")]
	private void _003CRequestMyClanNews_003Em__11(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DD1")]
	[Address(RVA = "0x3367D20", Offset = "0x3367D20", VA = "0x3367D20")]
	private static bool _003CGetMyClanMemeberInfo_003Em__12(ClanMember m)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DD2")]
	[Address(RVA = "0x3367E38", Offset = "0x3367E38", VA = "0x3367E38")]
	private static bool _003CFindDeputyCaptain_003Em__13(ClanMember m)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DD3")]
	[Address(RVA = "0x3367E68", Offset = "0x3367E68", VA = "0x3367E68")]
	private static int _003CGetNotifyInfo_003Em__14()
	{
		return default(int);
	}

	[Token(Token = "0x6013DD4")]
	[Address(RVA = "0x3367EFC", Offset = "0x3367EFC", VA = "0x3367EFC")]
	private static int _003CCalcMyLuckyBagPoints_003Em__15(LuckyBagDraw a, LuckyBagDraw b)
	{
		return default(int);
	}

	[Token(Token = "0x6013DD5")]
	[Address(RVA = "0x3367F44", Offset = "0x3367F44", VA = "0x3367F44")]
	private static int _003CCalcMyLuckyBagPoints_003Em__16(ClanLuckyBag a, ClanLuckyBag b)
	{
		return default(int);
	}

	[Token(Token = "0x6013DD6")]
	[Address(RVA = "0x3367F8C", Offset = "0x3367F8C", VA = "0x3367F8C")]
	private static int _003CCalcMyLuckyBagPoints_003Em__17(ClanLuckyBag a, ClanLuckyBag b)
	{
		return default(int);
	}

	[Token(Token = "0x6013DD7")]
	[Address(RVA = "0x3367FD4", Offset = "0x3367FD4", VA = "0x3367FD4")]
	private static bool _003CRefreshClanWarTeam_003Em__18(ClanWarTeamMemberInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DD8")]
	[Address(RVA = "0x33680D8", Offset = "0x33680D8", VA = "0x33680D8")]
	private static bool _003CRefreshClanWarTeam_003Em__19(ClanWarTeamMemberInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DD9")]
	[Address(RVA = "0x33680F8", Offset = "0x33680F8", VA = "0x33680F8")]
	private static bool _003CTransferClanWarCaptain_003Em__1A(ClanWarTeamMemberInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DDA")]
	[Address(RVA = "0x3368134", Offset = "0x3368134", VA = "0x3368134")]
	private static bool _003CIsClanWarAllReady_003Em__1B(ClanWarTeamMemberInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DDB")]
	[Address(RVA = "0x3368164", Offset = "0x3368164", VA = "0x3368164")]
	private void _003CRequestClanWarTeamMemberStatus_003Em__1C(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013DDC")]
	[Address(RVA = "0x33682FC", Offset = "0x33682FC", VA = "0x33682FC")]
	private void _003CRequestClanWarRecruitInfo_003Em__1D(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DDD")]
	[Address(RVA = "0x336856C", Offset = "0x336856C", VA = "0x336856C")]
	private void _003CRequestClanWarTeamInfo_003Em__1E(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DDE")]
	[Address(RVA = "0x3368740", Offset = "0x3368740", VA = "0x3368740")]
	private void _003CRequestJoinClanWarTeam_003Em__1F(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DDF")]
	[Address(RVA = "0x3368948", Offset = "0x3368948", VA = "0x3368948")]
	private void _003CRequestJoinClanWarTeam_003Em__20(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE0")]
	[Address(RVA = "0x3368B20", Offset = "0x3368B20", VA = "0x3368B20")]
	private static void _003CRequestInviteToClanWarTeam_003Em__21(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE1")]
	[Address(RVA = "0x3368B24", Offset = "0x3368B24", VA = "0x3368B24")]
	private void _003CRequestClanWarStaticData_003Em__22(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE2")]
	[Address(RVA = "0x3368C70", Offset = "0x3368C70", VA = "0x3368C70")]
	private void _003CRequestCheckIsMemberOfClanWarTeam_003Em__23(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE3")]
	[Address(RVA = "0x3369198", Offset = "0x3369198", VA = "0x3369198")]
	private void _003CRequestApproveJoinClanWarTeam_003Em__24(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE4")]
	[Address(RVA = "0x3369370", Offset = "0x3369370", VA = "0x3369370")]
	private static void _003CRequestCheckAllMembersPrepareStatus_003Em__25(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE5")]
	[Address(RVA = "0x3369374", Offset = "0x3369374", VA = "0x3369374")]
	private static bool _003CRequestClaimTeamAward_003Em__26(ClanMember item)
	{
		return default(bool);
	}

	[Token(Token = "0x6013DE6")]
	[Address(RVA = "0x336947C", Offset = "0x336947C", VA = "0x336947C")]
	private void _003CRequestClaimPersonalAward_003Em__27(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013DE7")]
	[Address(RVA = "0x3369808", Offset = "0x3369808", VA = "0x3369808")]
	private static CommonRewardItemInfo _003CRequestClaimPersonalAward_003Em__28(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013DE8")]
	[Address(RVA = "0x3369810", Offset = "0x3369810", VA = "0x3369810")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013DE9")]
	[Address(RVA = "0x3369818", Offset = "0x3369818", VA = "0x3369818")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
