using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x200303D")]
public class UIModelFriends : UIBaseModel
{
	[Token(Token = "0x200303E")]
	public enum EFriendRequestOption
	{
		[Token(Token = "0x401269F")]
		None = 0,
		[Token(Token = "0x40126A0")]
		OnlyID = 2,
		[Token(Token = "0x40126A1")]
		FriendInfo = 6,
		[Token(Token = "0x40126A2")]
		FriendPresence = 14,
		[Token(Token = "0x40126A3")]
		FriendStats = 30
	}

	[Token(Token = "0x200303F")]
	public class TeamMateSocialInfo
	{
		[Token(Token = "0x40126A4")]
		[FieldOffset(Offset = "0x8")]
		public ulong accountID;

		[Token(Token = "0x40126A5")]
		[FieldOffset(Offset = "0x10")]
		public ESocial.Gender Gender;

		[Token(Token = "0x40126A6")]
		[FieldOffset(Offset = "0x14")]
		public int friendCount;

		[Token(Token = "0x601439C")]
		[Address(RVA = "0x319050C", Offset = "0x319050C", VA = "0x319050C")]
		public TeamMateSocialInfo()
		{
		}
	}

	[Token(Token = "0x2003040")]
	private sealed class _003C_003Ec__AnonStorey0
	{
		[Token(Token = "0x40126A7")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40126A8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x601439D")]
		[Address(RVA = "0x3188A14", Offset = "0x3188A14", VA = "0x3188A14")]
		public _003C_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601439E")]
		[Address(RVA = "0x3188A1C", Offset = "0x3188A1C", VA = "0x3188A1C")]
		internal bool _003C_003Em__0(FriendAccountInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003041")]
	private sealed class _003CRequestSetFriendAlias_003Ec__AnonStorey1
	{
		[Token(Token = "0x40126A9")]
		[FieldOffset(Offset = "0x8")]
		internal string alias;

		[Token(Token = "0x40126AA")]
		[FieldOffset(Offset = "0x10")]
		internal ulong account_ID;

		[Token(Token = "0x40126AB")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x601439F")]
		[Address(RVA = "0x318F8E4", Offset = "0x318F8E4", VA = "0x318F8E4")]
		public _003CRequestSetFriendAlias_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60143A0")]
		[Address(RVA = "0x318F8EC", Offset = "0x318F8EC", VA = "0x318F8EC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003042")]
	private sealed class _003CRequestDelFriendAlias_003Ec__AnonStorey2
	{
		[Token(Token = "0x40126AC")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_ID;

		[Token(Token = "0x40126AD")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143A1")]
		[Address(RVA = "0x318E010", Offset = "0x318E010", VA = "0x318E010")]
		public _003CRequestDelFriendAlias_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60143A2")]
		[Address(RVA = "0x318E018", Offset = "0x318E018", VA = "0x318E018")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003043")]
	private sealed class _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey5
	{
		[Token(Token = "0x40126AE")]
		[FieldOffset(Offset = "0x8")]
		internal ERecentPlayerType type;

		[Token(Token = "0x40126AF")]
		[FieldOffset(Offset = "0x10")]
		internal ulong now;

		[Token(Token = "0x40126B0")]
		[FieldOffset(Offset = "0x18")]
		internal List<ulong> checkList;

		[Token(Token = "0x40126B1")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143A3")]
		[Address(RVA = "0x3188C70", Offset = "0x3188C70", VA = "0x3188C70")]
		public _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey5()
		{
		}
	}

	[Token(Token = "0x2003044")]
	private sealed class _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey3
	{
		[Token(Token = "0x40126B2")]
		[FieldOffset(Offset = "0x8")]
		internal FriendAccountInfo info;

		[Token(Token = "0x60143A4")]
		[Address(RVA = "0x3188C00", Offset = "0x3188C00", VA = "0x3188C00")]
		public _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60143A5")]
		[Address(RVA = "0x3188C08", Offset = "0x3188C08", VA = "0x3188C08")]
		internal bool _003C_003Em__0(RecentPlayerInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003045")]
	private sealed class _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey6
	{
		[Token(Token = "0x2003046")]
		private sealed class _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey4
		{
			[Token(Token = "0x40126B5")]
			[FieldOffset(Offset = "0x8")]
			internal AccountInfoBasic info;

			[Token(Token = "0x40126B6")]
			[FieldOffset(Offset = "0xC")]
			internal _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey5 _003C_003Ef__ref_00245;

			[Token(Token = "0x40126B7")]
			[FieldOffset(Offset = "0x10")]
			internal _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey6 _003C_003Ef__ref_00246;

			[Token(Token = "0x60143A8")]
			[Address(RVA = "0x3188FE8", Offset = "0x3188FE8", VA = "0x3188FE8")]
			public _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey4()
			{
			}

			[Token(Token = "0x60143A9")]
			[Address(RVA = "0x3188FF0", Offset = "0x3188FF0", VA = "0x3188FF0")]
			internal bool _003C_003Em__0(RecentPlayerInfo temp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40126B3")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x40126B4")]
		[FieldOffset(Offset = "0x10")]
		internal _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey5 _003C_003Ef__ref_00245;

		[Token(Token = "0x60143A6")]
		[Address(RVA = "0x3188C78", Offset = "0x3188C78", VA = "0x3188C78")]
		public _003CAddRecentPlayersFrontEnd_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60143A7")]
		[Address(RVA = "0x3188C80", Offset = "0x3188C80", VA = "0x3188C80")]
		internal void _003C_003Em__0(AccountInfoBasic info)
		{
		}
	}

	[Token(Token = "0x2003047")]
	private sealed class _003CRefreshAllFriendList_003Ec__AnonStorey7
	{
		[Token(Token = "0x40126B8")]
		[FieldOffset(Offset = "0x8")]
		internal bool isSilence;

		[Token(Token = "0x40126B9")]
		[FieldOffset(Offset = "0xC")]
		internal EFriendRequestOption requestOption;

		[Token(Token = "0x40126BA")]
		[FieldOffset(Offset = "0x10")]
		internal bool forcePresence;

		[Token(Token = "0x40126BB")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143AA")]
		[Address(RVA = "0x318BE30", Offset = "0x318BE30", VA = "0x318BE30")]
		public _003CRefreshAllFriendList_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60143AB")]
		[Address(RVA = "0x318BE38", Offset = "0x318BE38", VA = "0x318BE38")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x60143AC")]
		[Address(RVA = "0x318BE74", Offset = "0x318BE74", VA = "0x318BE74")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2003048")]
	private sealed class _003CRefreshRecentPlayersPresence_003Ec__AnonStorey8
	{
		[Token(Token = "0x40126BC")]
		[FieldOffset(Offset = "0x8")]
		internal PresenceListRes presenceRes;

		[Token(Token = "0x60143AD")]
		[Address(RVA = "0x318D928", Offset = "0x318D928", VA = "0x318D928")]
		public _003CRefreshRecentPlayersPresence_003Ec__AnonStorey8()
		{
		}
	}

	[Token(Token = "0x2003049")]
	private sealed class _003CRefreshRecentPlayersPresence_003Ec__AnonStorey9
	{
		[Token(Token = "0x40126BD")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40126BE")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshRecentPlayersPresence_003Ec__AnonStorey8 _003C_003Ef__ref_00248;

		[Token(Token = "0x60143AE")]
		[Address(RVA = "0x318D930", Offset = "0x318D930", VA = "0x318D930")]
		public _003CRefreshRecentPlayersPresence_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60143AF")]
		[Address(RVA = "0x318D938", Offset = "0x318D938", VA = "0x318D938")]
		internal bool _003C_003Em__0(RecentPlayerInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200304A")]
	private sealed class _003CRefreshFriendPresences_003Ec__AnonStoreyA
	{
		[Token(Token = "0x40126BF")]
		[FieldOffset(Offset = "0x8")]
		internal PresenceListRes presenceRes;

		[Token(Token = "0x60143B0")]
		[Address(RVA = "0x318C444", Offset = "0x318C444", VA = "0x318C444")]
		public _003CRefreshFriendPresences_003Ec__AnonStoreyA()
		{
		}
	}

	[Token(Token = "0x200304B")]
	private sealed class _003CRefreshFriendPresences_003Ec__AnonStoreyB
	{
		[Token(Token = "0x40126C0")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40126C1")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshFriendPresences_003Ec__AnonStoreyA _003C_003Ef__ref_002410;

		[Token(Token = "0x60143B1")]
		[Address(RVA = "0x318C44C", Offset = "0x318C44C", VA = "0x318C44C")]
		public _003CRefreshFriendPresences_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x60143B2")]
		[Address(RVA = "0x318C454", Offset = "0x318C454", VA = "0x318C454")]
		internal bool _003C_003Em__0(FriendAccountInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60143B3")]
		[Address(RVA = "0x318C558", Offset = "0x318C558", VA = "0x318C558")]
		internal bool _003C_003Em__1(FriendAccountInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200304C")]
	private sealed class _003CRefreshAddFriendPresence_003Ec__AnonStoreyC
	{
		[Token(Token = "0x40126C2")]
		[FieldOffset(Offset = "0x8")]
		internal PresenceListRes presenceRes;

		[Token(Token = "0x60143B4")]
		[Address(RVA = "0x318BC18", Offset = "0x318BC18", VA = "0x318BC18")]
		public _003CRefreshAddFriendPresence_003Ec__AnonStoreyC()
		{
		}
	}

	[Token(Token = "0x200304D")]
	private sealed class _003CRefreshAddFriendPresence_003Ec__AnonStoreyD
	{
		[Token(Token = "0x40126C3")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40126C4")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshAddFriendPresence_003Ec__AnonStoreyC _003C_003Ef__ref_002412;

		[Token(Token = "0x60143B5")]
		[Address(RVA = "0x318BC20", Offset = "0x318BC20", VA = "0x318BC20")]
		public _003CRefreshAddFriendPresence_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x60143B6")]
		[Address(RVA = "0x318BC28", Offset = "0x318BC28", VA = "0x318BC28")]
		internal bool _003C_003Em__0(FriendAccountInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60143B7")]
		[Address(RVA = "0x318BD2C", Offset = "0x318BD2C", VA = "0x318BD2C")]
		internal bool _003C_003Em__1(FriendAccountInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200304E")]
	private sealed class _003CRefreshSearchedPlayersPresences_003Ec__AnonStoreyE
	{
		[Token(Token = "0x40126C5")]
		[FieldOffset(Offset = "0x8")]
		internal PresenceListRes presenceRes;

		[Token(Token = "0x60143B8")]
		[Address(RVA = "0x318DB2C", Offset = "0x318DB2C", VA = "0x318DB2C")]
		public _003CRefreshSearchedPlayersPresences_003Ec__AnonStoreyE()
		{
		}
	}

	[Token(Token = "0x200304F")]
	private sealed class _003CRefreshSearchedPlayersPresences_003Ec__AnonStoreyF
	{
		[Token(Token = "0x40126C6")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40126C7")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshSearchedPlayersPresences_003Ec__AnonStoreyE _003C_003Ef__ref_002414;

		[Token(Token = "0x60143B9")]
		[Address(RVA = "0x318DB34", Offset = "0x318DB34", VA = "0x318DB34")]
		public _003CRefreshSearchedPlayersPresences_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x60143BA")]
		[Address(RVA = "0x318DB3C", Offset = "0x318DB3C", VA = "0x318DB3C")]
		internal bool _003C_003Em__0(FriendAccountInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003050")]
	private sealed class _003CRequestGameFriendIDList_003Ec__AnonStorey10
	{
		[Token(Token = "0x40126C8")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetFriendIDsReq req;

		[Token(Token = "0x40126C9")]
		[FieldOffset(Offset = "0xC")]
		internal Action afterRefreshAction;

		[Token(Token = "0x40126CA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x40126CB")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<FriendAccountInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60143BB")]
		[Address(RVA = "0x318E198", Offset = "0x318E198", VA = "0x318E198")]
		public _003CRequestGameFriendIDList_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x60143BC")]
		[Address(RVA = "0x318E1A0", Offset = "0x318E1A0", VA = "0x318E1A0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60143BD")]
		[Address(RVA = "0x318E6F8", Offset = "0x318E6F8", VA = "0x318E6F8")]
		private static bool _003C_003Em__1(FriendAccountInfo i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003051")]
	private sealed class _003CRequestPlatformFriendIDList_003Ec__AnonStorey11
	{
		[Token(Token = "0x40126CC")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetPlatformFriendListReq req;

		[Token(Token = "0x40126CD")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143BE")]
		[Address(RVA = "0x318E7FC", Offset = "0x318E7FC", VA = "0x318E7FC")]
		public _003CRequestPlatformFriendIDList_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x60143BF")]
		[Address(RVA = "0x318E804", Offset = "0x318E804", VA = "0x318E804")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003052")]
	private sealed class _003CRefreshGameFriendList_003Ec__AnonStorey12
	{
		[Token(Token = "0x40126CE")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetFriendListReq req;

		[Token(Token = "0x40126CF")]
		[FieldOffset(Offset = "0xC")]
		internal Action afterRefreshAction;

		[Token(Token = "0x40126D0")]
		[FieldOffset(Offset = "0x10")]
		internal uint requestFlag;

		[Token(Token = "0x40126D1")]
		[FieldOffset(Offset = "0x14")]
		internal bool forcePresence;

		[Token(Token = "0x40126D2")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x40126D3")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<FriendAccountInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60143C0")]
		[Address(RVA = "0x318C65C", Offset = "0x318C65C", VA = "0x318C65C")]
		public _003CRefreshGameFriendList_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x60143C1")]
		[Address(RVA = "0x318C664", Offset = "0x318C664", VA = "0x318C664")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60143C2")]
		[Address(RVA = "0x318D144", Offset = "0x318D144", VA = "0x318D144")]
		private static bool _003C_003Em__1(FriendAccountInfo i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003053")]
	private sealed class _003CRefreshPlatformFriendList_003Ec__AnonStorey13
	{
		[Token(Token = "0x40126D4")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetPlatformFriendListReq req;

		[Token(Token = "0x40126D5")]
		[FieldOffset(Offset = "0xC")]
		internal uint requestFlag;

		[Token(Token = "0x40126D6")]
		[FieldOffset(Offset = "0x10")]
		internal bool forcePresence;

		[Token(Token = "0x40126D7")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143C3")]
		[Address(RVA = "0x318D248", Offset = "0x318D248", VA = "0x318D248")]
		public _003CRefreshPlatformFriendList_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x60143C4")]
		[Address(RVA = "0x318D250", Offset = "0x318D250", VA = "0x318D250")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003054")]
	private sealed class _003CRefreshTotalFriendList_003Ec__AnonStorey14
	{
		[Token(Token = "0x40126D8")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x40126D9")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143C5")]
		[Address(RVA = "0x318DC9C", Offset = "0x318DC9C", VA = "0x318DC9C")]
		public _003CRefreshTotalFriendList_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x60143C6")]
		[Address(RVA = "0x318DCA4", Offset = "0x318DCA4", VA = "0x318DCA4")]
		internal bool _003C_003Em__0(FriendAccountInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003055")]
	private sealed class _003CRefreshBlackList_003Ec__AnonStorey15
	{
		[Token(Token = "0x40126DA")]
		[FieldOffset(Offset = "0x8")]
		internal bool needDispatch;

		[Token(Token = "0x40126DB")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143C7")]
		[Address(RVA = "0x318BED4", Offset = "0x318BED4", VA = "0x318BED4")]
		public _003CRefreshBlackList_003Ec__AnonStorey15()
		{
		}

		[Token(Token = "0x60143C8")]
		[Address(RVA = "0x318BEDC", Offset = "0x318BEDC", VA = "0x318BEDC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003056")]
	private sealed class _003CSearchAccount_003Ec__AnonStorey16
	{
		[Token(Token = "0x40126DC")]
		[FieldOffset(Offset = "0x8")]
		internal uint propId;

		[Token(Token = "0x40126DD")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143C9")]
		[Address(RVA = "0x318FA74", Offset = "0x318FA74", VA = "0x318FA74")]
		public _003CSearchAccount_003Ec__AnonStorey16()
		{
		}

		[Token(Token = "0x60143CA")]
		[Address(RVA = "0x318FA7C", Offset = "0x318FA7C", VA = "0x318FA7C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003057")]
	private sealed class _003CSearchAccount_003Ec__AnonStorey17
	{
		[Token(Token = "0x40126DE")]
		[FieldOffset(Offset = "0x8")]
		internal uint propId;

		[Token(Token = "0x40126DF")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143CB")]
		[Address(RVA = "0x3190034", Offset = "0x3190034", VA = "0x3190034")]
		public _003CSearchAccount_003Ec__AnonStorey17()
		{
		}

		[Token(Token = "0x60143CC")]
		[Address(RVA = "0x319003C", Offset = "0x319003C", VA = "0x319003C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003058")]
	private sealed class _003CRequestAccountInfo_003Ec__AnonStorey18
	{
		[Token(Token = "0x40126E0")]
		[FieldOffset(Offset = "0x8")]
		internal Action<AccountInfoBasic> onFinished;

		[Token(Token = "0x60143CD")]
		[Address(RVA = "0x318DF18", Offset = "0x318DF18", VA = "0x318DF18")]
		public _003CRequestAccountInfo_003Ec__AnonStorey18()
		{
		}

		[Token(Token = "0x60143CE")]
		[Address(RVA = "0x318DF20", Offset = "0x318DF20", VA = "0x318DF20")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003059")]
	private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey20
	{
		[Token(Token = "0x200305A")]
		private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey1B
		{
			[Token(Token = "0x40126E3")]
			[FieldOffset(Offset = "0x8")]
			internal FriendAccountInfo item;

			[Token(Token = "0x40126E4")]
			[FieldOffset(Offset = "0xC")]
			internal _003CGetRecommendedFriend_003Ec__AnonStorey20 _003C_003Ef__ref_002432;

			[Token(Token = "0x60143D1")]
			[Address(RVA = "0x318B7FC", Offset = "0x318B7FC", VA = "0x318B7FC")]
			public _003CGetRecommendedFriend_003Ec__AnonStorey1B()
			{
			}

			[Token(Token = "0x60143D2")]
			[Address(RVA = "0x318B824", Offset = "0x318B824", VA = "0x318B824")]
			internal bool _003C_003Em__0(FriendAccountInfo tmp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200305B")]
		private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey1C
		{
			[Token(Token = "0x40126E5")]
			[FieldOffset(Offset = "0x8")]
			internal FriendAccountInfo recentTeammate;

			[Token(Token = "0x40126E6")]
			[FieldOffset(Offset = "0xC")]
			internal _003CGetRecommendedFriend_003Ec__AnonStorey20 _003C_003Ef__ref_002432;

			[Token(Token = "0x60143D3")]
			[Address(RVA = "0x318B804", Offset = "0x318B804", VA = "0x318B804")]
			public _003CGetRecommendedFriend_003Ec__AnonStorey1C()
			{
			}

			[Token(Token = "0x60143D4")]
			[Address(RVA = "0x318B878", Offset = "0x318B878", VA = "0x318B878")]
			internal bool _003C_003Em__0(FriendAccountInfo item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200305C")]
		private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey1D
		{
			[Token(Token = "0x40126E7")]
			[FieldOffset(Offset = "0x8")]
			internal FriendAccountInfo clanMember;

			[Token(Token = "0x40126E8")]
			[FieldOffset(Offset = "0xC")]
			internal _003CGetRecommendedFriend_003Ec__AnonStorey20 _003C_003Ef__ref_002432;

			[Token(Token = "0x60143D5")]
			[Address(RVA = "0x318B80C", Offset = "0x318B80C", VA = "0x318B80C")]
			public _003CGetRecommendedFriend_003Ec__AnonStorey1D()
			{
			}

			[Token(Token = "0x60143D6")]
			[Address(RVA = "0x318B8CC", Offset = "0x318B8CC", VA = "0x318B8CC")]
			internal bool _003C_003Em__0(FriendAccountInfo item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200305D")]
		private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey1E
		{
			[Token(Token = "0x40126E9")]
			[FieldOffset(Offset = "0x8")]
			internal FriendAccountInfo commonFriend;

			[Token(Token = "0x40126EA")]
			[FieldOffset(Offset = "0xC")]
			internal _003CGetRecommendedFriend_003Ec__AnonStorey20 _003C_003Ef__ref_002432;

			[Token(Token = "0x60143D7")]
			[Address(RVA = "0x318B814", Offset = "0x318B814", VA = "0x318B814")]
			public _003CGetRecommendedFriend_003Ec__AnonStorey1E()
			{
			}

			[Token(Token = "0x60143D8")]
			[Address(RVA = "0x318B920", Offset = "0x318B920", VA = "0x318B920")]
			internal bool _003C_003Em__0(FriendAccountInfo item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200305E")]
		private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey1F
		{
			[Token(Token = "0x40126EB")]
			[FieldOffset(Offset = "0x8")]
			internal FriendAccountInfo item;

			[Token(Token = "0x40126EC")]
			[FieldOffset(Offset = "0xC")]
			internal _003CGetRecommendedFriend_003Ec__AnonStorey20 _003C_003Ef__ref_002432;

			[Token(Token = "0x60143D9")]
			[Address(RVA = "0x318B81C", Offset = "0x318B81C", VA = "0x318B81C")]
			public _003CGetRecommendedFriend_003Ec__AnonStorey1F()
			{
			}

			[Token(Token = "0x60143DA")]
			[Address(RVA = "0x318B974", Offset = "0x318B974", VA = "0x318B974")]
			internal bool _003C_003Em__0(FriendAccountInfo tmp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40126E1")]
		[FieldOffset(Offset = "0x8")]
		internal Action callBack;

		[Token(Token = "0x40126E2")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143CF")]
		[Address(RVA = "0x3189C20", Offset = "0x3189C20", VA = "0x3189C20")]
		public _003CGetRecommendedFriend_003Ec__AnonStorey20()
		{
		}

		[Token(Token = "0x60143D0")]
		[Address(RVA = "0x3189C28", Offset = "0x3189C28", VA = "0x3189C28")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200305F")]
	private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey19
	{
		[Token(Token = "0x40126ED")]
		[FieldOffset(Offset = "0x8")]
		internal FriendAccountInfo friendInfo;

		[Token(Token = "0x60143DB")]
		[Address(RVA = "0x3189B54", Offset = "0x3189B54", VA = "0x3189B54")]
		public _003CGetRecommendedFriend_003Ec__AnonStorey19()
		{
		}

		[Token(Token = "0x60143DC")]
		[Address(RVA = "0x3189B5C", Offset = "0x3189B5C", VA = "0x3189B5C")]
		internal bool _003C_003Em__0(FriendAccountInfo tmp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003060")]
	private sealed class _003CGetRecommendedFriend_003Ec__AnonStorey1A
	{
		[Token(Token = "0x40126EE")]
		[FieldOffset(Offset = "0x8")]
		internal RecentPlayerInfo recentPlayer;

		[Token(Token = "0x60143DD")]
		[Address(RVA = "0x3189BB0", Offset = "0x3189BB0", VA = "0x3189BB0")]
		public _003CGetRecommendedFriend_003Ec__AnonStorey1A()
		{
		}

		[Token(Token = "0x60143DE")]
		[Address(RVA = "0x3189BB8", Offset = "0x3189BB8", VA = "0x3189BB8")]
		internal bool _003C_003Em__0(FriendAccountInfo tmp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003061")]
	private sealed class _003CRemoveFriendRequest_003Ec__AnonStorey21
	{
		[Token(Token = "0x40126EF")]
		[FieldOffset(Offset = "0x8")]
		internal ulong removee;

		[Token(Token = "0x40126F0")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143DF")]
		[Address(RVA = "0x318DEC4", Offset = "0x318DEC4", VA = "0x318DEC4")]
		public _003CRemoveFriendRequest_003Ec__AnonStorey21()
		{
		}

		[Token(Token = "0x60143E0")]
		[Address(RVA = "0x318DECC", Offset = "0x318DECC", VA = "0x318DECC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003062")]
	private sealed class _003CAddFriendRequest_003Ec__AnonStorey22
	{
		[Token(Token = "0x40126F1")]
		[FieldOffset(Offset = "0x8")]
		internal ulong addee;

		[Token(Token = "0x60143E1")]
		[Address(RVA = "0x3188B08", Offset = "0x3188B08", VA = "0x3188B08")]
		public _003CAddFriendRequest_003Ec__AnonStorey22()
		{
		}

		[Token(Token = "0x60143E2")]
		[Address(RVA = "0x3188B10", Offset = "0x3188B10", VA = "0x3188B10")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003063")]
	private sealed class _003CRequestSetFavorFriendState_003Ec__AnonStorey23
	{
		[Token(Token = "0x40126F2")]
		[FieldOffset(Offset = "0x8")]
		internal ulong addee;

		[Token(Token = "0x40126F3")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143E3")]
		[Address(RVA = "0x318EC0C", Offset = "0x318EC0C", VA = "0x318EC0C")]
		public _003CRequestSetFavorFriendState_003Ec__AnonStorey23()
		{
		}

		[Token(Token = "0x60143E4")]
		[Address(RVA = "0x318EC14", Offset = "0x318EC14", VA = "0x318EC14")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60143E5")]
		[Address(RVA = "0x318F27C", Offset = "0x318F27C", VA = "0x318F27C")]
		internal void _003C_003Em__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003064")]
	private sealed class _003CConfirmFriendRequest_003Ec__AnonStorey24
	{
		[Token(Token = "0x40126F4")]
		[FieldOffset(Offset = "0x8")]
		internal bool need_slience;

		[Token(Token = "0x40126F5")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143E6")]
		[Address(RVA = "0x3189178", Offset = "0x3189178", VA = "0x3189178")]
		public _003CConfirmFriendRequest_003Ec__AnonStorey24()
		{
		}

		[Token(Token = "0x60143E7")]
		[Address(RVA = "0x3189180", Offset = "0x3189180", VA = "0x3189180")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003065")]
	private sealed class _003CDeclineFriendRequest_003Ec__AnonStorey25
	{
		[Token(Token = "0x40126F6")]
		[FieldOffset(Offset = "0x8")]
		internal bool need_slience;

		[Token(Token = "0x40126F7")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143E8")]
		[Address(RVA = "0x3189A74", Offset = "0x3189A74", VA = "0x3189A74")]
		public _003CDeclineFriendRequest_003Ec__AnonStorey25()
		{
		}

		[Token(Token = "0x60143E9")]
		[Address(RVA = "0x3189A7C", Offset = "0x3189A7C", VA = "0x3189A7C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003066")]
	private sealed class _003CBlockPlayerRequest_003Ec__AnonStorey26
	{
		[Token(Token = "0x40126F8")]
		[FieldOffset(Offset = "0x8")]
		internal bool need_slience;

		[Token(Token = "0x40126F9")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143EA")]
		[Address(RVA = "0x3189058", Offset = "0x3189058", VA = "0x3189058")]
		public _003CBlockPlayerRequest_003Ec__AnonStorey26()
		{
		}

		[Token(Token = "0x60143EB")]
		[Address(RVA = "0x3189060", Offset = "0x3189060", VA = "0x3189060")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003067")]
	private sealed class _003CCancelBlockRequest_003Ec__AnonStorey27
	{
		[Token(Token = "0x40126FA")]
		[FieldOffset(Offset = "0x8")]
		internal bool need_slience;

		[Token(Token = "0x40126FB")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelFriends _0024this;

		[Token(Token = "0x60143EC")]
		[Address(RVA = "0x31890E0", Offset = "0x31890E0", VA = "0x31890E0")]
		public _003CCancelBlockRequest_003Ec__AnonStorey27()
		{
		}

		[Token(Token = "0x60143ED")]
		[Address(RVA = "0x31890E8", Offset = "0x31890E8", VA = "0x31890E8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003068")]
	private sealed class _003CGetFriendInfo_003Ec__AnonStorey28
	{
		[Token(Token = "0x40126FC")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x60143EE")]
		[Address(RVA = "0x3189AC4", Offset = "0x3189AC4", VA = "0x3189AC4")]
		public _003CGetFriendInfo_003Ec__AnonStorey28()
		{
		}

		[Token(Token = "0x60143EF")]
		[Address(RVA = "0x3189ACC", Offset = "0x3189ACC", VA = "0x3189ACC")]
		internal bool _003C_003Em__0(FriendAccountInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003069")]
	private sealed class _003CGetPlatformFriendInfo_003Ec__AnonStorey29
	{
		[Token(Token = "0x40126FD")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x60143F0")]
		[Address(RVA = "0x3189B0C", Offset = "0x3189B0C", VA = "0x3189B0C")]
		public _003CGetPlatformFriendInfo_003Ec__AnonStorey29()
		{
		}

		[Token(Token = "0x60143F1")]
		[Address(RVA = "0x3189B14", Offset = "0x3189B14", VA = "0x3189B14")]
		internal bool _003C_003Em__0(FriendAccountInfo friendInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200306A")]
	private sealed class _003CRemoveFriendByAccountID_003Ec__AnonStorey2A
	{
		[Token(Token = "0x40126FE")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x60143F2")]
		[Address(RVA = "0x318DD7C", Offset = "0x318DD7C", VA = "0x318DD7C")]
		public _003CRemoveFriendByAccountID_003Ec__AnonStorey2A()
		{
		}

		[Token(Token = "0x60143F3")]
		[Address(RVA = "0x318DD84", Offset = "0x318DD84", VA = "0x318DD84")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x60143F4")]
		[Address(RVA = "0x318DDC4", Offset = "0x318DDC4", VA = "0x318DDC4")]
		internal bool _003C_003Em__1(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x60143F5")]
		[Address(RVA = "0x318DE04", Offset = "0x318DE04", VA = "0x318DE04")]
		internal bool _003C_003Em__2(FriendAccountInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60143F6")]
		[Address(RVA = "0x318DE44", Offset = "0x318DE44", VA = "0x318DE44")]
		internal bool _003C_003Em__3(FriendAccountInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x60143F7")]
		[Address(RVA = "0x318DE84", Offset = "0x318DE84", VA = "0x318DE84")]
		internal bool _003C_003Em__4(FriendAccountInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200306B")]
	private sealed class _003CAddFriendWithPresence_003Ec__AnonStorey2B
	{
		[Token(Token = "0x40126FF")]
		[FieldOffset(Offset = "0x8")]
		internal FriendAccountInfo info;

		[Token(Token = "0x60143F8")]
		[Address(RVA = "0x3188B50", Offset = "0x3188B50", VA = "0x3188B50")]
		public _003CAddFriendWithPresence_003Ec__AnonStorey2B()
		{
		}

		[Token(Token = "0x60143F9")]
		[Address(RVA = "0x3188B58", Offset = "0x3188B58", VA = "0x3188B58")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x60143FA")]
		[Address(RVA = "0x3188BAC", Offset = "0x3188BAC", VA = "0x3188BAC")]
		internal bool _003C_003Em__1(FriendAccountInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200306C")]
	private sealed class _003CRefreshRecentTeamPlayers_003Ec__AnonStorey2C
	{
		[Token(Token = "0x4012700")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo member;

		[Token(Token = "0x60143FB")]
		[Address(RVA = "0x318DA50", Offset = "0x318DA50", VA = "0x318DA50")]
		public _003CRefreshRecentTeamPlayers_003Ec__AnonStorey2C()
		{
		}

		[Token(Token = "0x60143FC")]
		[Address(RVA = "0x318DA58", Offset = "0x318DA58", VA = "0x318DA58")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x60143FD")]
		[Address(RVA = "0x318DAB8", Offset = "0x318DAB8", VA = "0x318DAB8")]
		internal bool _003C_003Em__1(ClanMember x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200306D")]
	private sealed class _003CRefreshTeamPlayersWhileClanMemberChange_003Ec__AnonStorey2D
	{
		[Token(Token = "0x4012701")]
		[FieldOffset(Offset = "0x8")]
		internal ulong accountID;

		[Token(Token = "0x60143FE")]
		[Address(RVA = "0x318DC40", Offset = "0x318DC40", VA = "0x318DC40")]
		public _003CRefreshTeamPlayersWhileClanMemberChange_003Ec__AnonStorey2D()
		{
		}

		[Token(Token = "0x60143FF")]
		[Address(RVA = "0x318DC48", Offset = "0x318DC48", VA = "0x318DC48")]
		internal bool _003C_003Em__0(ClanMember x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200306E")]
	private sealed class _003CRecommendFriendWhileInTeam_003Ec__AnonStorey2E
	{
		[Token(Token = "0x4012702")]
		[FieldOffset(Offset = "0x8")]
		internal GroupMemberInfo member;

		[Token(Token = "0x6014400")]
		[Address(RVA = "0x318BA34", Offset = "0x318BA34", VA = "0x318BA34")]
		public _003CRecommendFriendWhileInTeam_003Ec__AnonStorey2E()
		{
		}

		[Token(Token = "0x6014401")]
		[Address(RVA = "0x318BA3C", Offset = "0x318BA3C", VA = "0x318BA3C")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x6014402")]
		[Address(RVA = "0x318BA9C", Offset = "0x318BA9C", VA = "0x318BA9C")]
		internal bool _003C_003Em__1(ClanMember x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200306F")]
	private sealed class _003CRecommendFriendWhileInTeam_003Ec__AnonStorey2F
	{
		[Token(Token = "0x4012703")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x6014403")]
		[Address(RVA = "0x318BB10", Offset = "0x318BB10", VA = "0x318BB10")]
		public _003CRecommendFriendWhileInTeam_003Ec__AnonStorey2F()
		{
		}

		[Token(Token = "0x6014404")]
		[Address(RVA = "0x318BB18", Offset = "0x318BB18", VA = "0x318BB18")]
		internal bool _003C_003Em__0(GroupMemberInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003070")]
	private sealed class _003CRecommendFriendAfterMatch_003Ec__AnonStorey30
	{
		[Token(Token = "0x4012704")]
		[FieldOffset(Offset = "0x8")]
		internal ulong teamMate;

		[Token(Token = "0x6014405")]
		[Address(RVA = "0x318B9EC", Offset = "0x318B9EC", VA = "0x318B9EC")]
		public _003CRecommendFriendAfterMatch_003Ec__AnonStorey30()
		{
		}

		[Token(Token = "0x6014406")]
		[Address(RVA = "0x318B9F4", Offset = "0x318B9F4", VA = "0x318B9F4")]
		internal bool _003C_003Em__0(FriendAccountInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003071")]
	private sealed class _003CRecommendMVPGroupAfterMatch_003Ec__AnonStorey31
	{
		[Token(Token = "0x4012705")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelMatch modelMatch;

		[Token(Token = "0x6014407")]
		[Address(RVA = "0x318BB64", Offset = "0x318BB64", VA = "0x318BB64")]
		public _003CRecommendMVPGroupAfterMatch_003Ec__AnonStorey31()
		{
		}

		[Token(Token = "0x6014408")]
		[Address(RVA = "0x318BB6C", Offset = "0x318BB6C", VA = "0x318BB6C")]
		internal bool _003C_003Em__0(ulong item)
		{
			return default(bool);
		}

		[Token(Token = "0x6014409")]
		[Address(RVA = "0x318BBB8", Offset = "0x318BBB8", VA = "0x318BBB8")]
		internal bool _003C_003Em__1(TeammateStats item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003072")]
	private sealed class _003CIgnorePlayerAddRequest_003Ec__AnonStorey32
	{
		[Token(Token = "0x4012706")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x601440A")]
		[Address(RVA = "0x318B9C8", Offset = "0x318B9C8", VA = "0x318B9C8")]
		public _003CIgnorePlayerAddRequest_003Ec__AnonStorey32()
		{
		}

		[Token(Token = "0x601440B")]
		[Address(RVA = "0x318B9D0", Offset = "0x318B9D0", VA = "0x318B9D0")]
		internal bool _003C_003Em__0(ulong a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012649")]
	public const string NEW_VERSION_AFTER_OB20 = "NEW_ACCOUNT_AFTER_OB20";

	[Token(Token = "0x401264A")]
	private const string GUIDE_FRIEND_RELATIONSHIP_GRAPH = "OpenFriendRelationshipGraph";

	[Token(Token = "0x401264B")]
	[FieldOffset(Offset = "0xC")]
	private bool m_HasOpenFriendRelationshipGraph;

	[Token(Token = "0x401264C")]
	[FieldOffset(Offset = "0x10")]
	private int m_CurRecentPlayersMatchTimes;

	[Token(Token = "0x401264D")]
	[FieldOffset(Offset = "0x14")]
	private List<FriendAccountInfo> m_FriendAccountInfoList;

	[Token(Token = "0x401264E")]
	[FieldOffset(Offset = "0x18")]
	private List<FriendAccountInfo> m_GameFriendAccountInfoList;

	[Token(Token = "0x401264F")]
	[FieldOffset(Offset = "0x1C")]
	private List<FriendAccountInfo> m_PlatformFriendAccountInfoList;

	[Token(Token = "0x4012650")]
	[FieldOffset(Offset = "0x20")]
	private List<FriendAccountInfo> m_FriendRequestAccountInfoList;

	[Token(Token = "0x4012651")]
	[FieldOffset(Offset = "0x24")]
	private List<FriendAccountInfo> m_blackListAccountInfo;

	[Token(Token = "0x4012652")]
	[FieldOffset(Offset = "0x28")]
	private List<FriendAccountInfo> m_OnlineFriendAccountInfoList;

	[Token(Token = "0x4012653")]
	[FieldOffset(Offset = "0x2C")]
	private List<FriendAccountInfo> m_SearchAccountResultList;

	[Token(Token = "0x4012654")]
	[FieldOffset(Offset = "0x30")]
	private List<ulong> m_RequestedAndBlockedList;

	[Token(Token = "0x4012655")]
	[FieldOffset(Offset = "0x34")]
	private List<FriendAccountInfo> m_FollowAccountInfoList;

	[Token(Token = "0x4012656")]
	[FieldOffset(Offset = "0x38")]
	private List<ulong> m_FavorAccountIDs;

	[Token(Token = "0x4012657")]
	[FieldOffset(Offset = "0x3C")]
	private HashSet<ulong> m_InGameNewFriendList;

	[Token(Token = "0x4012658")]
	[FieldOffset(Offset = "0x40")]
	private HashSet<ulong> m_GameFriendExcludePlatform;

	[Token(Token = "0x4012659")]
	[FieldOffset(Offset = "0x44")]
	private HashSet<ulong> m_InGameIgnoreAdder;

	[Token(Token = "0x401265A")]
	[FieldOffset(Offset = "0x48")]
	private List<ulong> m_InGameFriendAdderList;

	[Token(Token = "0x401265B")]
	[FieldOffset(Offset = "0x4C")]
	private List<FriendAccountInfo> m_RecommendedFriendRecentTeammates;

	[Token(Token = "0x401265C")]
	[FieldOffset(Offset = "0x50")]
	private List<FriendAccountInfo> m_RecommendedFriendClanMember;

	[Token(Token = "0x401265D")]
	[FieldOffset(Offset = "0x54")]
	private List<FriendAccountInfo> m_RecommendedFriendCommon;

	[Token(Token = "0x401265E")]
	[FieldOffset(Offset = "0x58")]
	private List<FriendAccountInfo> m_RecommendedFriendNoTag;

	[Token(Token = "0x401265F")]
	[FieldOffset(Offset = "0x5C")]
	public Dictionary<ulong, string> m_FriendAliasDict;

	[Token(Token = "0x4012660")]
	[FieldOffset(Offset = "0x60")]
	private bool m_HasRequestClanMemberList;

	[Token(Token = "0x4012661")]
	private const int recommendedFriendAmount = 10;

	[Token(Token = "0x4012662")]
	private const int recommendedFriendWithTagAmount = 5;

	[Token(Token = "0x4012663")]
	[FieldOffset(Offset = "0x61")]
	private bool NeedRequestedRecommendedFriendInitData;

	[Token(Token = "0x4012664")]
	public const uint MAXFAVORFRIENDSCNT = 20u;

	[Token(Token = "0x4012665")]
	public const uint PropID_FriendListUpdate = 2u;

	[Token(Token = "0x4012666")]
	public const uint PropID_FriendRequestListUpdate = 4u;

	[Token(Token = "0x4012667")]
	public const uint PropID_SearchResultListUpdate = 8u;

	[Token(Token = "0x4012668")]
	public const uint PropID_BlackListUpdate = 16u;

	[Token(Token = "0x4012669")]
	public const uint PropID_RecentPlayers = 32u;

	[Token(Token = "0x401266A")]
	public const uint PropID_SearchByConditionUpdate = 64u;

	[Token(Token = "0x401266B")]
	public const uint PropID_FriendListUpdatePresence = 128u;

	[Token(Token = "0x401266C")]
	public const uint PropID_AddFriendCachedUpdate = 256u;

	[Token(Token = "0x401266D")]
	public const uint PropID_FriendAliasUpdate = 512u;

	[Token(Token = "0x401266E")]
	public const uint PropID_FriendAliasSuccess = 1024u;

	[Token(Token = "0x401266F")]
	public const uint PropID_SearchResultListUpdateForTrainingCamp = 2048u;

	[Token(Token = "0x4012670")]
	private const uint FriendRequestFlag_ID = 2u;

	[Token(Token = "0x4012671")]
	private const uint FriendRequestFlag_Info = 4u;

	[Token(Token = "0x4012672")]
	private const uint FriendRequestFlag_Presence = 8u;

	[Token(Token = "0x4012673")]
	private const uint FriendRequestFlag_Stats = 16u;

	[Token(Token = "0x4012674")]
	public const uint FriendAddTag_Team = 2u;

	[Token(Token = "0x4012675")]
	public const uint FriendAddTag_Clan = 4u;

	[Token(Token = "0x4012676")]
	public const uint FriendAddTag_Friend = 8u;

	[Token(Token = "0x4012677")]
	private const string RECOMMENDFRIENDMATCHCOUNT = "RECOMMENDFRIENDMATCHCOUNT_";

	[Token(Token = "0x4012678")]
	[FieldOffset(Offset = "0x64")]
	private int m_MatchCount;

	[Token(Token = "0x4012679")]
	[FieldOffset(Offset = "0x68")]
	private List<ulong> m_LastTeamMember;

	[Token(Token = "0x401267A")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_EnterGame;

	[Token(Token = "0x401267B")]
	[FieldOffset(Offset = "0x70")]
	private uint m_SearchPropID;

	[Token(Token = "0x401267C")]
	[FieldOffset(Offset = "0x74")]
	private int m_blackListCount;

	[Token(Token = "0x401267D")]
	[FieldOffset(Offset = "0x78")]
	public readonly Dictionary<int, List<ulong>> m_RecentPlayerIDDict;

	[Token(Token = "0x401267E")]
	[FieldOffset(Offset = "0x7C")]
	private List<RecentPlayerInfo> m_RecentPlayerInfoList;

	[Token(Token = "0x401267F")]
	[FieldOffset(Offset = "0x80")]
	private List<FriendAccountInfo> m_TempRecentAccountInfoList;

	[Token(Token = "0x4012680")]
	[FieldOffset(Offset = "0x84")]
	private readonly List<ulong> m_TempRecentPlayerIDs;

	[Token(Token = "0x4012681")]
	[FieldOffset(Offset = "0x88")]
	private uint m_RequestedFriendFlags;

	[Token(Token = "0x4012682")]
	[FieldOffset(Offset = "0x8C")]
	private string m_SearchedStringCache;

	[Token(Token = "0x4012683")]
	[FieldOffset(Offset = "0x90")]
	private ulong m_SearchedIDCache;

	[Token(Token = "0x4012684")]
	[FieldOffset(Offset = "0x98")]
	private HashSet<object> m_PendingRequest;

	[Token(Token = "0x4012685")]
	[FieldOffset(Offset = "0x9C")]
	private HashSet<ulong> m_AddFriendCachedID;

	[Token(Token = "0x4012686")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<ulong, ulong> m_AFKFriendNextInviteableTimestamp;

	[Token(Token = "0x4012687")]
	[FieldOffset(Offset = "0xA4")]
	private Dictionary<ulong, TeamMateSocialInfo> m_teamMateSocialInfo;

	[Token(Token = "0x4012688")]
	[FieldOffset(Offset = "0xA8")]
	private ulong m_showInvitePlayerID;

	[Token(Token = "0x4012689")]
	[FieldOffset(Offset = "0x0")]
	public static string Friend_Request_Tips;

	[Token(Token = "0x401268A")]
	[FieldOffset(Offset = "0x4")]
	public static string Friend_Lobby_Request_Tips;

	[Token(Token = "0x401268B")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x401268C")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x401268D")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x401268E")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x401268F")]
	[FieldOffset(Offset = "0x18")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012690")]
	[FieldOffset(Offset = "0x1C")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x4012691")]
	[FieldOffset(Offset = "0x20")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache5;

	[Token(Token = "0x4012692")]
	[FieldOffset(Offset = "0x24")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache6;

	[Token(Token = "0x4012693")]
	[FieldOffset(Offset = "0x28")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache7;

	[Token(Token = "0x4012694")]
	[FieldOffset(Offset = "0x2C")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache8;

	[Token(Token = "0x4012695")]
	[FieldOffset(Offset = "0x30")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cache9;

	[Token(Token = "0x4012696")]
	[FieldOffset(Offset = "0x34")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cacheA;

	[Token(Token = "0x4012697")]
	[FieldOffset(Offset = "0x38")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cacheB;

	[Token(Token = "0x4012698")]
	[FieldOffset(Offset = "0x3C")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cacheC;

	[Token(Token = "0x4012699")]
	[FieldOffset(Offset = "0x40")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cacheD;

	[Token(Token = "0x401269A")]
	[FieldOffset(Offset = "0x44")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__mg_0024cacheE;

	[Token(Token = "0x401269B")]
	[FieldOffset(Offset = "0x48")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x401269C")]
	[FieldOffset(Offset = "0x4C")]
	private static Predicate<uint> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x401269D")]
	[FieldOffset(Offset = "0x50")]
	private static Predicate<uint> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x170014FE")]
	public bool HasOpenFriendRelationshipGraph
	{
		[Token(Token = "0x601431F")]
		[Address(RVA = "0xFCD77C", Offset = "0xFCD77C", VA = "0xFCD77C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014320")]
		[Address(RVA = "0xFCD7D4", Offset = "0xFCD7D4", VA = "0xFCD7D4")]
		set
		{
		}
	}

	[Token(Token = "0x170014FF")]
	public int CurRecentPlayersMatchTimes
	{
		[Token(Token = "0x6014321")]
		[Address(RVA = "0xFCD8D0", Offset = "0xFCD8D0", VA = "0xFCD8D0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014322")]
		[Address(RVA = "0xFCD928", Offset = "0xFCD928", VA = "0xFCD928")]
		set
		{
		}
	}

	[Token(Token = "0x17001500")]
	public List<FriendAccountInfo> FriendAccountInfoList
	{
		[Token(Token = "0x6014323")]
		[Address(RVA = "0xFCD988", Offset = "0xFCD988", VA = "0xFCD988")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001501")]
	public List<FriendAccountInfo> GameAccountInfoList
	{
		[Token(Token = "0x6014324")]
		[Address(RVA = "0xFCD9E0", Offset = "0xFCD9E0", VA = "0xFCD9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001502")]
	public List<FriendAccountInfo> FaceBookFriendAccoutInfoList
	{
		[Token(Token = "0x6014325")]
		[Address(RVA = "0xFCDA38", Offset = "0xFCDA38", VA = "0xFCDA38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001503")]
	public List<FriendAccountInfo> FriendRequestAccountInfoList
	{
		[Token(Token = "0x6014326")]
		[Address(RVA = "0xFCDA90", Offset = "0xFCDA90", VA = "0xFCDA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001504")]
	public List<FriendAccountInfo> BlackListAccountInfo
	{
		[Token(Token = "0x6014327")]
		[Address(RVA = "0xFCDAE8", Offset = "0xFCDAE8", VA = "0xFCDAE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001505")]
	public List<FriendAccountInfo> OnlineFriendAccountInfoList
	{
		[Token(Token = "0x6014328")]
		[Address(RVA = "0xFCDB40", Offset = "0xFCDB40", VA = "0xFCDB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001506")]
	public List<FriendAccountInfo> SearchAccountResultList
	{
		[Token(Token = "0x6014329")]
		[Address(RVA = "0xFAD080", Offset = "0xFAD080", VA = "0xFAD080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001507")]
	public List<ulong> RequestedAndBlockedList
	{
		[Token(Token = "0x601432A")]
		[Address(RVA = "0xFCDB98", Offset = "0xFCDB98", VA = "0xFCDB98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001508")]
	public List<FriendAccountInfo> FollowAccoutInfoList
	{
		[Token(Token = "0x601432B")]
		[Address(RVA = "0xFCDBF0", Offset = "0xFCDBF0", VA = "0xFCDBF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001509")]
	public List<ulong> FavorAccountIDs
	{
		[Token(Token = "0x601432C")]
		[Address(RVA = "0xFCDC48", Offset = "0xFCDC48", VA = "0xFCDC48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700150A")]
	public int BlackListCount
	{
		[Token(Token = "0x601432E")]
		[Address(RVA = "0xFCDD8C", Offset = "0xFCDD8C", VA = "0xFCDD8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700150B")]
	public List<RecentPlayerInfo> RecentPlayerInfoList
	{
		[Token(Token = "0x601432F")]
		[Address(RVA = "0xFCDDE4", Offset = "0xFCDDE4", VA = "0xFCDDE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601431E")]
	[Address(RVA = "0xFCD134", Offset = "0xFCD134", VA = "0xFCD134")]
	public UIModelFriends()
	{
	}

	[Token(Token = "0x601432D")]
	[Address(RVA = "0xFCDCA0", Offset = "0xFCDCA0", VA = "0xFCDCA0")]
	public bool IsFavorFriend(ulong accountID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014330")]
	[Address(RVA = "0xFCE064", Offset = "0xFCE064", VA = "0xFCE064")]
	public bool CheckFriendSetAliasCD(ulong friendId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014331")]
	[Address(RVA = "0xFCE1F8", Offset = "0xFCE1F8", VA = "0xFCE1F8")]
	public ulong GetFriendSetAliasCDSeconds(ulong friendId)
	{
		return default(ulong);
	}

	[Token(Token = "0x6014332")]
	[Address(RVA = "0xFCE304", Offset = "0xFCE304", VA = "0xFCE304")]
	public void SetAFKFriendInviteCD(ulong friendId)
	{
	}

	[Token(Token = "0x6014333")]
	[Address(RVA = "0xFCE480", Offset = "0xFCE480", VA = "0xFCE480")]
	public string GetFriendAlias(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6014334")]
	[Address(RVA = "0xFCE644", Offset = "0xFCE644", VA = "0xFCE644")]
	public string GetFriendAliasWithOutSymbol(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6014335")]
	[Address(RVA = "0xFCE7B4", Offset = "0xFCE7B4", VA = "0xFCE7B4")]
	public void RequestSetFriendAlias(ulong account_ID, string alias)
	{
	}

	[Token(Token = "0x6014336")]
	[Address(RVA = "0xFCEB6C", Offset = "0xFCEB6C", VA = "0xFCEB6C")]
	public void RequestDelFriendAlias(ulong account_ID)
	{
	}

	[Token(Token = "0x6014337")]
	[Address(RVA = "0xFCEEA0", Offset = "0xFCEEA0", VA = "0xFCEEA0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014338")]
	[Address(RVA = "0xFCEEF8", Offset = "0xFCEEF8", VA = "0xFCEEF8", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014339")]
	[Address(RVA = "0xFCF174", Offset = "0xFCF174", VA = "0xFCF174", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601433A")]
	[Address(RVA = "0xFCF6FC", Offset = "0xFCF6FC", VA = "0xFCF6FC")]
	public static bool CheckIsFriendByRelationshipMask(uint mask)
	{
		return default(bool);
	}

	[Token(Token = "0x601433B")]
	[Address(RVA = "0xFCF764", Offset = "0xFCF764", VA = "0xFCF764")]
	public void SendInviteToGameLink(PlatformType platformType)
	{
	}

	[Token(Token = "0x601433C")]
	[Address(RVA = "0xFCFC34", Offset = "0xFCFC34", VA = "0xFCFC34")]
	public int LastInGameAddedRecentPlayersCount()
	{
		return default(int);
	}

	[Token(Token = "0x601433D")]
	[Address(RVA = "0xFCFE30", Offset = "0xFCFE30", VA = "0xFCFE30")]
	public void AddRecentPlayersFrontEnd()
	{
	}

	[Token(Token = "0x601433E")]
	[Address(RVA = "0xFD0AF4", Offset = "0xFD0AF4", VA = "0xFD0AF4")]
	public List<FriendAccountInfo> GetRecentAccoutInfoList()
	{
		return null;
	}

	[Token(Token = "0x601433F")]
	[Address(RVA = "0xFD0D9C", Offset = "0xFD0D9C", VA = "0xFD0D9C")]
	public void RefreshRecentPlayersPresence(bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6014340")]
	[Address(RVA = "0xFD1250", Offset = "0xFD1250", VA = "0xFD1250")]
	public void AddRecentPlayers(ERecentPlayerType type, List<ulong> ids)
	{
	}

	[Token(Token = "0x6014341")]
	[Address(RVA = "0xFD133C", Offset = "0xFD133C", VA = "0xFD133C")]
	public void AddRecentPlayers(ERecentPlayerType type, ulong[] ids)
	{
	}

	[Token(Token = "0x6014342")]
	[Address(RVA = "0xFD013C", Offset = "0xFD013C", VA = "0xFD013C")]
	public void AddRecentPlayersFrontEnd(ERecentPlayerType type, ulong[] ids)
	{
	}

	[Token(Token = "0x6014343")]
	[Address(RVA = "0xFD174C", Offset = "0xFD174C", VA = "0xFD174C")]
	public void RefreshAllFriendList(bool forceRefresh = false, bool isSilence = false, EFriendRequestOption requestOption = EFriendRequestOption.OnlyID, bool forcePresence = false, bool needPlatformFriend = true)
	{
	}

	[Token(Token = "0x6014344")]
	[Address(RVA = "0xFD109C", Offset = "0xFD109C", VA = "0xFD109C")]
	public void RequestFriendInfosPresence(EPresenceListType type, ulong[] ids, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6014345")]
	[Address(RVA = "0xFD2420", Offset = "0xFD2420", VA = "0xFD2420")]
	private void RequestRefreshFriendPresences(bool force = false)
	{
	}

	[Token(Token = "0x6014346")]
	[Address(RVA = "0xFD2734", Offset = "0xFD2734", VA = "0xFD2734")]
	public void RefreshRecentPlayersPresence(PresenceListRes presenceRes)
	{
	}

	[Token(Token = "0x6014347")]
	[Address(RVA = "0xFD3258", Offset = "0xFD3258", VA = "0xFD3258")]
	public void RefreshFriendPresences(PresenceListRes presenceRes)
	{
	}

	[Token(Token = "0x6014348")]
	[Address(RVA = "0xFD4340", Offset = "0xFD4340", VA = "0xFD4340")]
	public void RefreshAddFriendPresence(PresenceListRes presenceRes)
	{
	}

	[Token(Token = "0x6014349")]
	[Address(RVA = "0xFD4FC8", Offset = "0xFD4FC8", VA = "0xFD4FC8")]
	public void RefreshSearchedPlayersPresences(PresenceListRes presenceRes)
	{
	}

	[Token(Token = "0x601434A")]
	[Address(RVA = "0xFD59CC", Offset = "0xFD59CC", VA = "0xFD59CC")]
	public void RefreshSearchedPlayersPresencesWithoutCondition(PresenceListRes presenceRes)
	{
	}

	[Token(Token = "0x601434B")]
	[Address(RVA = "0xFD5AAC", Offset = "0xFD5AAC", VA = "0xFD5AAC")]
	public void RefreshSearchedPlayersPresencesWithCondition(PresenceListRes presenceRes)
	{
	}

	[Token(Token = "0x601434C")]
	[Address(RVA = "0xFD1B44", Offset = "0xFD1B44", VA = "0xFD1B44")]
	public void RequestGameFriendIDList(bool isSilence = false, [Optional] Action afterRefreshAction)
	{
	}

	[Token(Token = "0x601434D")]
	[Address(RVA = "0xFD5B8C", Offset = "0xFD5B8C", VA = "0xFD5B8C")]
	public void RequestPlatformFriendIDList(bool isSilence = false)
	{
	}

	[Token(Token = "0x601434E")]
	[Address(RVA = "0xFD1F40", Offset = "0xFD1F40", VA = "0xFD1F40")]
	public void RefreshGameFriendList([Optional] Action afterRefreshAction, bool isSilence = false, uint requestFlag = 8u, bool forcePresence = false)
	{
	}

	[Token(Token = "0x601434F")]
	[Address(RVA = "0xFD68F0", Offset = "0xFD68F0", VA = "0xFD68F0")]
	public void RefreshPlatformFriendList(bool isSilence = false, uint requestFlag = 8u, bool forcePresence = false)
	{
	}

	[Token(Token = "0x6014350")]
	[Address(RVA = "0xFD6170", Offset = "0xFD6170", VA = "0xFD6170")]
	private void RefreshTotalFriendList(uint requestFlag, bool forcePresence = false, bool FriendsHttpOk = false)
	{
	}

	[Token(Token = "0x6014351")]
	[Address(RVA = "0xFD704C", Offset = "0xFD704C", VA = "0xFD704C")]
	public List<FriendAccountInfo> FriendsHasChampionshipTeam()
	{
		return null;
	}

	[Token(Token = "0x6014352")]
	[Address(RVA = "0xFD7554", Offset = "0xFD7554", VA = "0xFD7554")]
	public static int SortFriendAccountInfo(FriendAccountInfo a, FriendAccountInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6014353")]
	[Address(RVA = "0xFD75D4", Offset = "0xFD75D4", VA = "0xFD75D4")]
	public void RefreshFriendRequestList(bool forceRefresh = false, bool isSilence = false)
	{
	}

	[Token(Token = "0x6014354")]
	[Address(RVA = "0xFD79CC", Offset = "0xFD79CC", VA = "0xFD79CC")]
	public void RefreshBlackList(bool forceRefresh = false, bool isSilence = false, bool needDispatch = true)
	{
	}

	[Token(Token = "0x6014355")]
	[Address(RVA = "0xFD7E14", Offset = "0xFD7E14", VA = "0xFD7E14")]
	public void SearchAccount(string searchName, bool forceRefresh = false, uint propId = 8u)
	{
	}

	[Token(Token = "0x6014356")]
	[Address(RVA = "0xFD82EC", Offset = "0xFD82EC", VA = "0xFD82EC")]
	private void RefreshSearchAccountInfoPresence(EPresenceListType type = EPresenceListType.SearchedPlayer)
	{
	}

	[Token(Token = "0x6014357")]
	[Address(RVA = "0xFD84BC", Offset = "0xFD84BC", VA = "0xFD84BC")]
	public void SearchAccount(ulong searchID, bool forceRefresh = false, uint propId = 8u)
	{
	}

	[Token(Token = "0x6014358")]
	[Address(RVA = "0xFD8970", Offset = "0xFD8970", VA = "0xFD8970")]
	public void SearchByConditions(ESocial.Language language = ESocial.Language.Language_UNLIMITED, ESocial.Gender gender = ESocial.Gender.Gender_NONE, ESocial.TimeActive activeTime = ESocial.TimeActive.TimeActive_NONE, ESocial.ModePrefer modePrefer = ESocial.ModePrefer.ModePrefer_NONE, bool forceRefresh = false)
	{
	}

	[Token(Token = "0x6014359")]
	[Address(RVA = "0xFD1490", Offset = "0xFD1490", VA = "0xFD1490")]
	public void RequestAccountInfo(ulong accountId, Action<AccountInfoBasic> onFinished)
	{
	}

	[Token(Token = "0x601435A")]
	[Address(RVA = "0xFD9018", Offset = "0xFD9018", VA = "0xFD9018")]
	public void RequestedRecommendedFriendInitData()
	{
	}

	[Token(Token = "0x601435B")]
	[Address(RVA = "0xFD92C0", Offset = "0xFD92C0", VA = "0xFD92C0")]
	public void GetRecommendedFriend(bool forceRefresh = false, [Optional] Action callBack)
	{
	}

	[Token(Token = "0x601435C")]
	[Address(RVA = "0xFDA6B4", Offset = "0xFDA6B4", VA = "0xFDA6B4")]
	public void RemoveFriendRequest(ulong remover, ulong removee)
	{
	}

	[Token(Token = "0x601435D")]
	[Address(RVA = "0xFDA998", Offset = "0xFDA998", VA = "0xFDA998")]
	public void AddFriendRequest(ulong adder, ulong addee, EFriendAddFrom add_from, uint friend_tag = 0u, bool need_slience = false)
	{
	}

	[Token(Token = "0x601435E")]
	[Address(RVA = "0xFDB2F0", Offset = "0xFDB2F0", VA = "0xFDB2F0")]
	public void RequestSetFavorFriendState(ulong adder, ulong addee, bool isMark)
	{
	}

	[Token(Token = "0x601435F")]
	[Address(RVA = "0xFDB728", Offset = "0xFDB728", VA = "0xFDB728")]
	public bool CanDoFavorFriend()
	{
		return default(bool);
	}

	[Token(Token = "0x6014360")]
	[Address(RVA = "0xFDAF90", Offset = "0xFDAF90", VA = "0xFDAF90")]
	public void ConfirmFriendRequest(ulong adder, ulong addee, bool need_slience = false)
	{
	}

	[Token(Token = "0x6014361")]
	[Address(RVA = "0xFDB7F8", Offset = "0xFDB7F8", VA = "0xFDB7F8")]
	public void DeclineFriendRequest(ulong adder, ulong addee, bool need_slience = false)
	{
	}

	[Token(Token = "0x6014362")]
	[Address(RVA = "0xFDBB28", Offset = "0xFDBB28", VA = "0xFDBB28")]
	public void BlockPlayerRequest(ulong blockID, bool need_slience = false)
	{
	}

	[Token(Token = "0x6014363")]
	[Address(RVA = "0xFDBE84", Offset = "0xFDBE84", VA = "0xFDBE84")]
	public void CancelBlockRequest(ulong blockID, bool need_slience = false)
	{
	}

	[Token(Token = "0x6014364")]
	[Address(RVA = "0xFDC1AC", Offset = "0xFDC1AC", VA = "0xFDC1AC")]
	public void RefuseAllFriendRequest(bool need_slience = false)
	{
	}

	[Token(Token = "0x6014365")]
	[Address(RVA = "0xFDC4DC", Offset = "0xFDC4DC", VA = "0xFDC4DC")]
	public static string GetFriendStatus(proto.EPresence.AccountPresence presence, DGNDKMLMLPM matchMode = DGNDKMLMLPM.EMATCHMODE_NONE, JOKABEAPNPP gameMode = JOKABEAPNPP.EGAMEMODE_NONE, uint mapID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6014366")]
	[Address(RVA = "0xFDC9E8", Offset = "0xFDC9E8", VA = "0xFDC9E8")]
	public string GetLastLoginTime(long lastLoginAt)
	{
		return null;
	}

	[Token(Token = "0x6014367")]
	[Address(RVA = "0xFDD01C", Offset = "0xFDD01C", VA = "0xFDD01C")]
	public bool IsFriend(ulong accountID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014368")]
	[Address(RVA = "0xFDD3A4", Offset = "0xFDD3A4", VA = "0xFDD3A4")]
	public bool IsGameFriend(ulong accountID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014369")]
	[Address(RVA = "0xFDD4F4", Offset = "0xFDD4F4", VA = "0xFDD4F4")]
	public bool IsGameFriendExcludePlatformFriend(ulong account_id)
	{
		return default(bool);
	}

	[Token(Token = "0x601436A")]
	[Address(RVA = "0xFDD644", Offset = "0xFDD644", VA = "0xFDD644")]
	public bool IsUnknowPlayer(ulong accountId)
	{
		return default(bool);
	}

	[Token(Token = "0x601436B")]
	[Address(RVA = "0xFDD6DC", Offset = "0xFDD6DC", VA = "0xFDD6DC")]
	public EFriendType GetFriendType(ulong accountId)
	{
		return default(EFriendType);
	}

	[Token(Token = "0x601436C")]
	[Address(RVA = "0xFDD970", Offset = "0xFDD970", VA = "0xFDD970")]
	public string GetFriendTypeString(ulong accountId)
	{
		return null;
	}

	[Token(Token = "0x601436D")]
	[Address(RVA = "0xFDDBD4", Offset = "0xFDDBD4", VA = "0xFDDBD4")]
	public Color GetFriendTypeColor(ulong accountId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601436E")]
	[Address(RVA = "0xFDDC88", Offset = "0xFDDC88", VA = "0xFDDC88")]
	public bool IsIDInCache(ulong accoutID)
	{
		return default(bool);
	}

	[Token(Token = "0x601436F")]
	[Address(RVA = "0xFDDD74", Offset = "0xFDDD74", VA = "0xFDDD74")]
	public void ResetRequestCooldown()
	{
	}

	[Token(Token = "0x6014370")]
	[Address(RVA = "0xFDDE78", Offset = "0xFDDE78", VA = "0xFDDE78")]
	public FriendAccountInfo GetFriendInfo(ulong account_id)
	{
		return null;
	}

	[Token(Token = "0x6014371")]
	[Address(RVA = "0xFDDFD8", Offset = "0xFDDFD8", VA = "0xFDDFD8")]
	public FriendAccountInfo GetPlatformFriendInfo(ulong accountID)
	{
		return null;
	}

	[Token(Token = "0x6014372")]
	[Address(RVA = "0xFDE138", Offset = "0xFDE138", VA = "0xFDE138")]
	public void RemoveFriendByAccountID(ulong account_id)
	{
	}

	[Token(Token = "0x6014373")]
	[Address(RVA = "0xFDEA0C", Offset = "0xFDEA0C", VA = "0xFDEA0C")]
	public void AddFriendWithPresence(AccountInfoWithPresence account_info)
	{
	}

	[Token(Token = "0x6014374")]
	[Address(RVA = "0xFDF594", Offset = "0xFDF594", VA = "0xFDF594")]
	public bool CanInviteFriendToGroup(FriendAccountInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6014375")]
	[Address(RVA = "0xFDF610", Offset = "0xFDF610", VA = "0xFDF610")]
	public bool CanJoinFriendGroup(FriendAccountInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6014376")]
	[Address(RVA = "0xFDF67C", Offset = "0xFDF67C", VA = "0xFDF67C")]
	private void SetListAmountLimit(List<FriendAccountInfo> friendList, int pickNum)
	{
	}

	[Token(Token = "0x6014377")]
	[Address(RVA = "0xFDF7C4", Offset = "0xFDF7C4", VA = "0xFDF7C4")]
	private void SetListAmountLimit(List<RecentPlayerInfo> friendList, int pickNum)
	{
	}

	[Token(Token = "0x6014378")]
	[Address(RVA = "0xFDF90C", Offset = "0xFDF90C", VA = "0xFDF90C")]
	private void SetListAmountLimit(List<ClanMember> friendList, int pickNum)
	{
	}

	[Token(Token = "0x6014379")]
	[Address(RVA = "0xFDA4A4", Offset = "0xFDA4A4", VA = "0xFDA4A4")]
	private List<RecentPlayerInfo> RandomPick(List<RecentPlayerInfo> friendList, int pickNum)
	{
		return null;
	}

	[Token(Token = "0x601437A")]
	[Address(RVA = "0xFDA294", Offset = "0xFDA294", VA = "0xFDA294")]
	private List<ClanMember> RandomPick(List<ClanMember> friendList, int pickNum)
	{
		return null;
	}

	[Token(Token = "0x601437B")]
	[Address(RVA = "0xFDFA54", Offset = "0xFDFA54", VA = "0xFDFA54")]
	public bool IsCelebrity(uint role)
	{
		return default(bool);
	}

	[Token(Token = "0x601437C")]
	[Address(RVA = "0xFDFAC0", Offset = "0xFDFAC0", VA = "0xFDFAC0")]
	public bool IsCelebrity(proto.EAccount.Role role)
	{
		return default(bool);
	}

	[Token(Token = "0x601437D")]
	[Address(RVA = "0xFDFB28", Offset = "0xFDFB28", VA = "0xFDFB28")]
	public string GetNameAfterCelebrityCheck(uint role, string name)
	{
		return null;
	}

	[Token(Token = "0x601437E")]
	[Address(RVA = "0xFDFBB0", Offset = "0xFDFBB0", VA = "0xFDFBB0")]
	public string GetNameAfterCelebrityCheck(proto.EAccount.Role role, string name)
	{
		return null;
	}

	[Token(Token = "0x601437F")]
	[Address(RVA = "0xFDFD40", Offset = "0xFDFD40", VA = "0xFDFD40")]
	public void AddMatchCount()
	{
	}

	[Token(Token = "0x6014380")]
	[Address(RVA = "0xFDFF2C", Offset = "0xFDFF2C", VA = "0xFDFF2C")]
	private bool CheckRecommendFriendCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x6014381")]
	[Address(RVA = "0xFE0380", Offset = "0xFE0380", VA = "0xFE0380")]
	public void RefreshRecentTeamPlayers()
	{
	}

	[Token(Token = "0x6014382")]
	[Address(RVA = "0xFE0CDC", Offset = "0xFE0CDC", VA = "0xFE0CDC")]
	public void RefreshTeamPlayersWhileClanMemberChange()
	{
	}

	[Token(Token = "0x6014383")]
	[Address(RVA = "0xFE117C", Offset = "0xFE117C", VA = "0xFE117C")]
	public void RecommendFriendWhileInTeam()
	{
	}

	[Token(Token = "0x6014384")]
	[Address(RVA = "0xFE2B48", Offset = "0xFE2B48", VA = "0xFE2B48")]
	public bool CheckEnteredGame()
	{
		return default(bool);
	}

	[Token(Token = "0x6014385")]
	[Address(RVA = "0xFE2BBC", Offset = "0xFE2BBC", VA = "0xFE2BBC")]
	public void RecommendFriendAfterMatch()
	{
	}

	[Token(Token = "0x6014386")]
	[Address(RVA = "0xFE3928", Offset = "0xFE3928", VA = "0xFE3928")]
	public void RecommendMVPGroupAfterMatch()
	{
	}

	[Token(Token = "0x6014387")]
	[Address(RVA = "0xFE4664", Offset = "0xFE4664", VA = "0xFE4664")]
	public List<FriendAccountInfo> SearchFriendInClienData(string info, [Optional] List<FriendAccountInfo> tarFriendInfos)
	{
		return null;
	}

	[Token(Token = "0x6014388")]
	[Address(RVA = "0xFE4B6C", Offset = "0xFE4B6C", VA = "0xFE4B6C")]
	public void SetTeamMateSocialInfo(ulong accountID, byte gender, ushort friendCount)
	{
	}

	[Token(Token = "0x6014389")]
	[Address(RVA = "0xFE4DB8", Offset = "0xFE4DB8", VA = "0xFE4DB8")]
	public void UpdataAccountInfoPin(ulong accountID, uint pinID)
	{
	}

	[Token(Token = "0x601438A")]
	[Address(RVA = "0xFE4F74", Offset = "0xFE4F74", VA = "0xFE4F74")]
	public bool IsFriendInGame(ulong account_id)
	{
		return default(bool);
	}

	[Token(Token = "0x601438B")]
	[Address(RVA = "0xFE5060", Offset = "0xFE5060", VA = "0xFE5060")]
	public void CheckFriendInGame(ulong account_id)
	{
	}

	[Token(Token = "0x601438C")]
	[Address(RVA = "0xFE51A0", Offset = "0xFE51A0", VA = "0xFE51A0")]
	public void ClearInGameFriendData()
	{
	}

	[Token(Token = "0x601438D")]
	[Address(RVA = "0xFE52B8", Offset = "0xFE52B8", VA = "0xFE52B8")]
	public void CacheAdderInGame(byte[] data)
	{
	}

	[Token(Token = "0x601438E")]
	[Address(RVA = "0xFE5460", Offset = "0xFE5460", VA = "0xFE5460")]
	public void IgnorePlayerAddRequest(ulong account_id)
	{
	}

	[Token(Token = "0x601438F")]
	[Address(RVA = "0xFE5644", Offset = "0xFE5644", VA = "0xFE5644")]
	public ulong GetFirstFriendAdder()
	{
		return default(ulong);
	}

	[Token(Token = "0x6014390")]
	[Address(RVA = "0xFE5780", Offset = "0xFE5780", VA = "0xFE5780")]
	public void CacheNewInviteID(byte[] data)
	{
	}

	[Token(Token = "0x6014392")]
	[Address(RVA = "0xFE5A28", Offset = "0xFE5A28", VA = "0xFE5A28")]
	private void _003CRefreshFriendRequestList_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014393")]
	[Address(RVA = "0xFE635C", Offset = "0xFE635C", VA = "0xFE635C")]
	private void _003CSearchByConditions_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014394")]
	[Address(RVA = "0xFE6B50", Offset = "0xFE6B50", VA = "0xFE6B50")]
	private void _003CRequestedRecommendedFriendInitData_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014395")]
	[Address(RVA = "0xFE6E2C", Offset = "0xFE6E2C", VA = "0xFE6E2C")]
	private static void _003CAddFriendRequest_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014396")]
	[Address(RVA = "0xFE7698", Offset = "0xFE7698", VA = "0xFE7698")]
	private void _003CRefuseAllFriendRequest_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014397")]
	[Address(RVA = "0xFE77B4", Offset = "0xFE77B4", VA = "0xFE77B4")]
	private static int _003CRecommendFriendAfterMatch_003Em__5(TeammateStats a, TeammateStats b)
	{
		return default(int);
	}

	[Token(Token = "0x6014398")]
	[Address(RVA = "0xFE7838", Offset = "0xFE7838", VA = "0xFE7838")]
	private static bool _003CRecommendMVPGroupAfterMatch_003Em__6(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014399")]
	[Address(RVA = "0xFE784C", Offset = "0xFE784C", VA = "0xFE784C")]
	private static bool _003CRecommendMVPGroupAfterMatch_003Em__7(uint type)
	{
		return default(bool);
	}

	[Token(Token = "0x601439A")]
	[Address(RVA = "0xFE7858", Offset = "0xFE7858", VA = "0xFE7858")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x601439B")]
	[Address(RVA = "0xFE7860", Offset = "0xFE7860", VA = "0xFE7860")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
