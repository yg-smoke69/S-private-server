using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002E8F")]
public class UIModelActivity : UIBaseModel
{
	[Serializable]
	[Token(Token = "0x2002E90")]
	private class FBInvitedPerActivity
	{
		[Token(Token = "0x4011CB4")]
		[FieldOffset(Offset = "0x8")]
		public uint group_id;

		[Token(Token = "0x4011CB5")]
		[FieldOffset(Offset = "0xC")]
		public ulong[] uids;

		[Token(Token = "0x6013795")]
		[Address(RVA = "0x30AB3A4", Offset = "0x30AB3A4", VA = "0x30AB3A4")]
		public FBInvitedPerActivity()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2002E91")]
	private class FBInvited
	{
		[Token(Token = "0x4011CB6")]
		[FieldOffset(Offset = "0x8")]
		public FBInvitedPerActivity[] Info;

		[Token(Token = "0x6013796")]
		[Address(RVA = "0x30AB39C", Offset = "0x30AB39C", VA = "0x30AB39C")]
		public FBInvited()
		{
		}
	}

	[Token(Token = "0x2002E92")]
	private sealed class _003CRequestActivityAward_003Ec__AnonStorey0
	{
		[Token(Token = "0x2002E93")]
		private sealed class _003CRequestActivityAward_003Ec__AnonStorey1
		{
			[Token(Token = "0x4011CBE")]
			[FieldOffset(Offset = "0x8")]
			internal CSGetActivityRewardsRes res;

			[Token(Token = "0x4011CBF")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestActivityAward_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

			[Token(Token = "0x601379A")]
			[Address(RVA = "0x30AADF0", Offset = "0x30AADF0", VA = "0x30AADF0")]
			public _003CRequestActivityAward_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x601379B")]
			[Address(RVA = "0x30AAE00", Offset = "0x30AAE00", VA = "0x30AAE00")]
			internal void _003C_003Em__0()
			{
			}

			[Token(Token = "0x601379C")]
			[Address(RVA = "0x30AAF94", Offset = "0x30AAF94", VA = "0x30AAF94")]
			internal void _003C_003Em__1()
			{
			}
		}

		[Token(Token = "0x4011CB7")]
		[FieldOffset(Offset = "0x8")]
		internal bool showRewardWindow;

		[Token(Token = "0x4011CB8")]
		[FieldOffset(Offset = "0xC")]
		internal uint[] activityid;

		[Token(Token = "0x4011CB9")]
		[FieldOffset(Offset = "0x10")]
		internal bool bigPriceControlCommonRewardWnd;

		[Token(Token = "0x4011CBA")]
		[FieldOffset(Offset = "0x14")]
		internal UICommonRewardWndController.WndStyleEnum style;

		[Token(Token = "0x4011CBB")]
		[FieldOffset(Offset = "0x18")]
		internal bool childKeepStyle;

		[Token(Token = "0x4011CBC")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelActivity _0024this;

		[Token(Token = "0x4011CBD")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013797")]
		[Address(RVA = "0x30AA71C", Offset = "0x30AA71C", VA = "0x30AA71C")]
		public _003CRequestActivityAward_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013798")]
		[Address(RVA = "0x30AA724", Offset = "0x30AA724", VA = "0x30AA724")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x6013799")]
		[Address(RVA = "0x30AADF8", Offset = "0x30AADF8", VA = "0x30AADF8")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002E94")]
	private sealed class _003CFindActivityInfosByGroupIdAndState_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011CC0")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EActivity.State state;

		[Token(Token = "0x601379D")]
		[Address(RVA = "0x30AA508", Offset = "0x30AA508", VA = "0x30AA508")]
		public _003CFindActivityInfosByGroupIdAndState_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601379E")]
		[Address(RVA = "0x30AA510", Offset = "0x30AA510", VA = "0x30AA510")]
		internal bool _003C_003Em__0(ActivityClientInfo info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E95")]
	private sealed class _003CIsOverviewActivityRedDotValid_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011CC1")]
		[FieldOffset(Offset = "0x8")]
		internal ClientActivityDesc activity;

		[Token(Token = "0x601379F")]
		[Address(RVA = "0x30AA6C8", Offset = "0x30AA6C8", VA = "0x30AA6C8")]
		public _003CIsOverviewActivityRedDotValid_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60137A0")]
		[Address(RVA = "0x30AA6D0", Offset = "0x30AA6D0", VA = "0x30AA6D0")]
		internal bool _003C_003Em__0(AdvertDesc temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E96")]
	private sealed class _003CGetFriendReunionFBInvited_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011CC2")]
		[FieldOffset(Offset = "0x8")]
		internal uint group_id;

		[Token(Token = "0x60137A1")]
		[Address(RVA = "0x30AA65C", Offset = "0x30AA65C", VA = "0x30AA65C")]
		public _003CGetFriendReunionFBInvited_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60137A2")]
		[Address(RVA = "0x30AA664", Offset = "0x30AA664", VA = "0x30AA664")]
		internal bool _003C_003Em__0(FBInvitedPerActivity invited)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E97")]
	private sealed class _003CSetFriendReunionFBInvited_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011CC3")]
		[FieldOffset(Offset = "0x8")]
		internal ActivityGroupDesc desc;

		[Token(Token = "0x60137A3")]
		[Address(RVA = "0x30AB238", Offset = "0x30AB238", VA = "0x30AB238")]
		public _003CSetFriendReunionFBInvited_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60137A4")]
		[Address(RVA = "0x30AB240", Offset = "0x30AB240", VA = "0x30AB240")]
		internal bool _003C_003Em__0(FBInvitedPerActivity info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E98")]
	private sealed class _003CGetFestivalDesc_003Ec__AnonStorey6
	{
		[Token(Token = "0x4011CC4")]
		[FieldOffset(Offset = "0x8")]
		internal EventTabType type;

		[Token(Token = "0x60137A5")]
		[Address(RVA = "0x30AA5C8", Offset = "0x30AA5C8", VA = "0x30AA5C8")]
		public _003CGetFestivalDesc_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60137A6")]
		[Address(RVA = "0x30AA5D0", Offset = "0x30AA5D0", VA = "0x30AA5D0")]
		internal bool _003C_003Em__0(ActivityFestivalDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E99")]
	private sealed class _003CGetFestivalDesc_003Ec__AnonStorey7
	{
		[Token(Token = "0x4011CC5")]
		[FieldOffset(Offset = "0x8")]
		internal uint groupId;

		[Token(Token = "0x4011CC6")]
		[FieldOffset(Offset = "0xC")]
		internal uint affiliateTab;

		[Token(Token = "0x60137A7")]
		[Address(RVA = "0x30AA608", Offset = "0x30AA608", VA = "0x30AA608")]
		public _003CGetFestivalDesc_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60137A8")]
		[Address(RVA = "0x30AA610", Offset = "0x30AA610", VA = "0x30AA610")]
		internal bool _003C_003Em__0(ActivityFestivalDesc item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E9A")]
	private sealed class _003CClaimMegaFestivalItem_003Ec__AnonStorey8
	{
		[Token(Token = "0x4011CC7")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x4011CC8")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelActivity _0024this;

		[Token(Token = "0x4011CC9")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<AwardDesc, AwardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4011CCA")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<AwardItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x60137A9")]
		[Address(RVA = "0x30A9F4C", Offset = "0x30A9F4C", VA = "0x30A9F4C")]
		public _003CClaimMegaFestivalItem_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60137AA")]
		[Address(RVA = "0x30A9F54", Offset = "0x30A9F54", VA = "0x30A9F54")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60137AB")]
		[Address(RVA = "0x30AA4C0", Offset = "0x30AA4C0", VA = "0x30AA4C0")]
		internal bool _003C_003Em__1(FestivalAttendanceItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x60137AC")]
		[Address(RVA = "0x30AA4F8", Offset = "0x30AA4F8", VA = "0x30AA4F8")]
		private static AwardItemInfo _003C_003Em__2(AwardDesc item)
		{
			return null;
		}

		[Token(Token = "0x60137AD")]
		[Address(RVA = "0x30AA500", Offset = "0x30AA500", VA = "0x30AA500")]
		private static CommonRewardItemInfo _003C_003Em__3(AwardItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002E9B")]
	private sealed class _003CStartCountDownHintReset_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4011CCB")]
		[FieldOffset(Offset = "0x8")]
		internal uint groupId;

		[Token(Token = "0x4011CCC")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelActivity _0024this;

		[Token(Token = "0x60137AE")]
		[Address(RVA = "0x30AB394", Offset = "0x30AB394", VA = "0x30AB394")]
		public _003CStartCountDownHintReset_003Ec__AnonStoreyA()
		{
		}
	}

	[Token(Token = "0x2002E9C")]
	private sealed class _003CStartCountDownHintReset_003Ec__AnonStorey9
	{
		[Token(Token = "0x4011CCD")]
		[FieldOffset(Offset = "0x8")]
		internal uint callId;

		[Token(Token = "0x4011CCE")]
		[FieldOffset(Offset = "0xC")]
		internal _003CStartCountDownHintReset_003Ec__AnonStoreyA _003C_003Ef__ref_002410;

		[Token(Token = "0x60137AF")]
		[Address(RVA = "0x30AB28C", Offset = "0x30AB28C", VA = "0x30AB28C")]
		public _003CStartCountDownHintReset_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60137B0")]
		[Address(RVA = "0x30AB294", Offset = "0x30AB294", VA = "0x30AB294")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002E9D")]
	private sealed class _003CGetBigEventActivityDescByTwoType_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4011CCF")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EActivity.SubType subType;

		[Token(Token = "0x60137B1")]
		[Address(RVA = "0x30AA548", Offset = "0x30AA548", VA = "0x30AA548")]
		public _003CGetBigEventActivityDescByTwoType_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x60137B2")]
		[Address(RVA = "0x30AA550", Offset = "0x30AA550", VA = "0x30AA550")]
		internal bool _003C_003Em__0(ClientActivityDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E9E")]
	private sealed class _003CGetBigEventSortedDescListByTwoType_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4011CD0")]
		[FieldOffset(Offset = "0x8")]
		internal proto.EActivity.SubType subType;

		[Token(Token = "0x60137B3")]
		[Address(RVA = "0x30AA588", Offset = "0x30AA588", VA = "0x30AA588")]
		public _003CGetBigEventSortedDescListByTwoType_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x60137B4")]
		[Address(RVA = "0x30AA590", Offset = "0x30AA590", VA = "0x30AA590")]
		internal bool _003C_003Em__0(ClientActivityDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002E9F")]
	private sealed class _003CGetSortedDescList_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4011CD1")]
		[FieldOffset(Offset = "0x8")]
		internal uint activityid;

		[Token(Token = "0x60137B5")]
		[Address(RVA = "0x30AA688", Offset = "0x30AA688", VA = "0x30AA688")]
		public _003CGetSortedDescList_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x60137B6")]
		[Address(RVA = "0x30AA690", Offset = "0x30AA690", VA = "0x30AA690")]
		internal bool _003C_003Em__0(ActivityGroupDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011C66")]
	[FieldOffset(Offset = "0xC")]
	private List<ActivityGroupDesc> m_ActivityGroupDescList;

	[Token(Token = "0x4011C67")]
	[FieldOffset(Offset = "0x10")]
	private List<ActivityFestivalDesc> m_ActivityFestivalDescList;

	[Token(Token = "0x4011C68")]
	[FieldOffset(Offset = "0x14")]
	private LobbyGameEnterStyleDesc m_LobbyGameEnterStyleDesc;

	[Token(Token = "0x4011C69")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, ActivityClientInfo> m_ActivityInfoDic;

	[Token(Token = "0x4011C6A")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, string> m_ActivityInfoUpdateContextCache;

	[Token(Token = "0x4011C6B")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, List<ActivenessReward>> m_ActivenessRewardsDic;

	[Token(Token = "0x4011C6C")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, ClientActivityDesc> m_BigEventTaskDescDict;

	[Token(Token = "0x4011C6D")]
	[FieldOffset(Offset = "0x28")]
	private HashSet<uint> m_BigEventTaskTypeSet;

	[Token(Token = "0x4011C6E")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<ClientActivityDesc>> m_BigEventActivityDict;

	[Token(Token = "0x4011C6F")]
	[FieldOffset(Offset = "0x30")]
	private HashSet<uint> m_BigEventActivityTypeSet;

	[Token(Token = "0x4011C70")]
	private const string ACT_READED_FORMAT = "Activity{0}";

	[Token(Token = "0x4011C71")]
	private const string ACT_GOTO_CLICK_FORMAT = "ActivityGotoClick{0}";

	[Token(Token = "0x4011C72")]
	private const string ACT_EXCHANGE_REDTIPS_FORMAT = "ActivityExchangeRedTips{0}";

	[Token(Token = "0x4011C73")]
	private const string HTTPActivityNoRewardsAvailable = "BR_ACTIVITY_NO_REWARDS_AVAILABLE";

	[Token(Token = "0x4011C74")]
	private const string HTTPActivityGetRewardsFailed = "BR_ACTIVITY_GET_REWARDS_FAILED";

	[Token(Token = "0x4011C75")]
	private const string PREFS_CLOSE_ACTIVITY_EXCHANGE_RED_TIPS = "CLOSE_ACTIVITY_EXCHANGE_RED_TIPS";

	[Token(Token = "0x4011C76")]
	public const string CONFIG_CONSTANT_TIME = "2029-01-01 23:59:59";

	[Token(Token = "0x4011C77")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasFirstRecharge;

	[Token(Token = "0x4011C78")]
	[FieldOffset(Offset = "0x35")]
	private bool m_HasSecondRecharge;

	[Token(Token = "0x4011C79")]
	[FieldOffset(Offset = "0x36")]
	private bool m_HasShareImage;

	[Token(Token = "0x4011C7A")]
	[FieldOffset(Offset = "0x38")]
	private CSGetActivityDescRes m_ActivityDescRes;

	[Token(Token = "0x4011C7B")]
	[FieldOffset(Offset = "0x3C")]
	private CSGetActivityInfoRes m_ActivityInfoRes;

	[Token(Token = "0x4011C7C")]
	[FieldOffset(Offset = "0x40")]
	private ActivenessInfo m_ActivenessInfoRes;

	[Token(Token = "0x4011C7D")]
	[FieldOffset(Offset = "0x44")]
	private WaitingResponseHandler m_WaitingHandler;

	[Token(Token = "0x4011C7E")]
	[FieldOffset(Offset = "0x48")]
	private ulong _003CEasterActivityTodayExpireTime_003Ek__BackingField;

	[Token(Token = "0x4011C7F")]
	public const int PropID_UpdateActivityInfo = 2;

	[Token(Token = "0x4011C80")]
	public const int PropID_GetActivityReward = 4;

	[Token(Token = "0x4011C81")]
	public const int PropID_UpdateActivityDesc = 8;

	[Token(Token = "0x4011C82")]
	public const int PropID_UpdateActivityDescFailed = 16;

	[Token(Token = "0x4011C83")]
	public const int PropID_UpdateActivityInfoFailed = 32;

	[Token(Token = "0x4011C84")]
	public const int PropID_ReunionFBInvited = 64;

	[Token(Token = "0x4011C85")]
	public const int PropID_MegaFestivalSignin = 128;

	[Token(Token = "0x4011C86")]
	public const int PropID_GetMegaFestivalAttendanceInfo = 256;

	[Token(Token = "0x4011C87")]
	public const int PropID_GetMegaFestivalItemInfo = 512;

	[Token(Token = "0x4011C88")]
	public const int PropID_UpdateActivenessInfo = 1024;

	[Token(Token = "0x4011C89")]
	public const int PropID_UpdateActivenessRewardsList = 2048;

	[Token(Token = "0x4011C8A")]
	public const int PropID_GetActivenessTaskReward = 4096;

	[Token(Token = "0x4011C8B")]
	public const int PropID_SingleActivityReaded = 8192;

	[Token(Token = "0x4011C8C")]
	public const int PropID_Hint_Reset = 16384;

	[Token(Token = "0x4011C8D")]
	public const int PropID_FestivalGetRewards = 32768;

	[Token(Token = "0x4011C8E")]
	public const int PropID_GetMegaFestivalAttendanceInfoFailed = 65536;

	[Token(Token = "0x4011C8F")]
	public const int PropID_GetActivityRewardFailed = 131072;

	[Token(Token = "0x4011C90")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, TagConfig> TagConfigDict;

	[Token(Token = "0x4011C91")]
	[FieldOffset(Offset = "0x54")]
	private bool _003CShowFriendReunionInviter_003Ek__BackingField;

	[Token(Token = "0x4011C92")]
	[FieldOffset(Offset = "0x55")]
	private bool _003CShowFriendReunionInvitee_003Ek__BackingField;

	[Token(Token = "0x4011C93")]
	[FieldOffset(Offset = "0x56")]
	private bool m_IsSignedTodayMegaFestival;

	[Token(Token = "0x4011C94")]
	[FieldOffset(Offset = "0x58")]
	private string _003CInviterUIDFromLink_003Ek__BackingField;

	[Token(Token = "0x4011C95")]
	[FieldOffset(Offset = "0x5C")]
	private CSGetFestivalAttendanceInfoRes _003CMegaFestivalAttendanceInfo_003Ek__BackingField;

	[Token(Token = "0x4011C96")]
	[FieldOffset(Offset = "0x60")]
	private List<FestivalAttendanceItem> _003CMegaFestivalSigninAwards_003Ek__BackingField;

	[Token(Token = "0x4011C97")]
	[FieldOffset(Offset = "0x64")]
	private bool _003CHasGetMegaFestivalInfoSinceLogin_003Ek__BackingField;

	[Token(Token = "0x4011C98")]
	[FieldOffset(Offset = "0x65")]
	private bool m_IsShowMegaFestivalRedDot;

	[Token(Token = "0x4011C99")]
	[FieldOffset(Offset = "0x68")]
	private uint _003CReunionPlayerLevelLimit_003Ek__BackingField;

	[Token(Token = "0x4011C9A")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, List<ulong>> m_HintResetDict;

	[Token(Token = "0x4011C9B")]
	[FieldOffset(Offset = "0x70")]
	private List<uint> m_HintResetCalls;

	[Token(Token = "0x4011C9C")]
	[FieldOffset(Offset = "0x74")]
	private bool m_PreloadActiveness;

	[Token(Token = "0x4011C9D")]
	[FieldOffset(Offset = "0x78")]
	private ulong m_ToNextDailyReFreshTime;

	[Token(Token = "0x4011C9E")]
	[FieldOffset(Offset = "0x80")]
	private bool m_PreloadActivenessReward;

	[Token(Token = "0x4011C9F")]
	[FieldOffset(Offset = "0x81")]
	private bool m_HaveRewards;

	[Token(Token = "0x4011CA0")]
	[FieldOffset(Offset = "0x84")]
	private uint m_GroupID;

	[Token(Token = "0x4011CA1")]
	[FieldOffset(Offset = "0x88")]
	private string PLAYER_PREFS_KEY_FRIEND_REUNION_INVITEE_ACTIVITIES;

	[Token(Token = "0x4011CA2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PLAYER_PREFS_KEY_FB_INVITED;

	[Token(Token = "0x4011CA3")]
	[FieldOffset(Offset = "0x8C")]
	private bool _003CWillRewardForVideoAds_003Ek__BackingField;

	[Token(Token = "0x4011CA4")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, Dictionary<uint, int>> m_RedDots;

	[Token(Token = "0x4011CA5")]
	[FieldOffset(Offset = "0x94")]
	private ActivityGroupDesc _003CCurrentDisplayPaymentActivity_003Ek__BackingField;

	[Token(Token = "0x4011CA6")]
	[FieldOffset(Offset = "0x98")]
	private List<ActivityGroupDesc> m_NormalTopUpEventDescList;

	[Token(Token = "0x4011CA7")]
	public const string FIRSTTOPUPEVENTKEY = "FIRSTTOPUPEVENTKEY_{0}";

	[Token(Token = "0x4011CA8")]
	public const string TOPUPEVENTKEY = "TOPUPEVENTKEY_{0}_{1}";

	[Token(Token = "0x4011CA9")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<ActivityGroupDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011CAA")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<ActivityClientInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011CAB")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<ActivityClientInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4011CAC")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<ActivityGroupDesc> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4011CAD")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<ActivityGroupDesc> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4011CAE")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<Item> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4011CAF")]
	[FieldOffset(Offset = "0x1C")]
	private static Converter<string, uint> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4011CB0")]
	[FieldOffset(Offset = "0x20")]
	private static Converter<uint, string> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4011CB1")]
	[FieldOffset(Offset = "0x24")]
	private static Comparison<ActivityGroupDesc> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4011CB2")]
	[FieldOffset(Offset = "0x28")]
	private static Comparison<ClientActivityDesc> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4011CB3")]
	[FieldOffset(Offset = "0x2C")]
	private static Comparison<FestivalAttendanceItem> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x17001429")]
	public ulong EasterActivityTodayExpireTime
	{
		[Token(Token = "0x60136CA")]
		[Address(RVA = "0x131B870", Offset = "0x131B870", VA = "0x131B870")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60136CB")]
		[Address(RVA = "0x131B878", Offset = "0x131B878", VA = "0x131B878")]
		private set
		{
		}
	}

	[Token(Token = "0x1700142A")]
	public bool HasFirstRecharge
	{
		[Token(Token = "0x60136CD")]
		[Address(RVA = "0x131B970", Offset = "0x131B970", VA = "0x131B970")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136CE")]
		[Address(RVA = "0x131B9C8", Offset = "0x131B9C8", VA = "0x131B9C8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700142B")]
	public bool HasSecondRecharge
	{
		[Token(Token = "0x60136CF")]
		[Address(RVA = "0x131BA8C", Offset = "0x131BA8C", VA = "0x131BA8C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136D0")]
		[Address(RVA = "0x131BAE4", Offset = "0x131BAE4", VA = "0x131BAE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700142C")]
	public bool HasShareImage
	{
		[Token(Token = "0x60136D1")]
		[Address(RVA = "0x131BB44", Offset = "0x131BB44", VA = "0x131BB44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136D2")]
		[Address(RVA = "0x131BB9C", Offset = "0x131BB9C", VA = "0x131BB9C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700142D")]
	public bool ShowFriendReunionInviter
	{
		[Token(Token = "0x60136D3")]
		[Address(RVA = "0x131BBFC", Offset = "0x131BBFC", VA = "0x131BBFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136D4")]
		[Address(RVA = "0x131BC04", Offset = "0x131BC04", VA = "0x131BC04")]
		private set
		{
		}
	}

	[Token(Token = "0x1700142E")]
	public bool ShowFriendReunionInvitee
	{
		[Token(Token = "0x60136D5")]
		[Address(RVA = "0x131BC0C", Offset = "0x131BC0C", VA = "0x131BC0C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136D6")]
		[Address(RVA = "0x131BC14", Offset = "0x131BC14", VA = "0x131BC14")]
		private set
		{
		}
	}

	[Token(Token = "0x1700142F")]
	public bool ShowFriendReunion
	{
		[Token(Token = "0x60136D7")]
		[Address(RVA = "0x131BC1C", Offset = "0x131BC1C", VA = "0x131BC1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001430")]
	public string InviterUIDFromLink
	{
		[Token(Token = "0x60136D8")]
		[Address(RVA = "0x131BC84", Offset = "0x131BC84", VA = "0x131BC84")]
		get
		{
			return null;
		}
		[Token(Token = "0x60136D9")]
		[Address(RVA = "0x131BC8C", Offset = "0x131BC8C", VA = "0x131BC8C")]
		set
		{
		}
	}

	[Token(Token = "0x17001431")]
	public CSGetFestivalAttendanceInfoRes MegaFestivalAttendanceInfo
	{
		[Token(Token = "0x60136DA")]
		[Address(RVA = "0x131BC94", Offset = "0x131BC94", VA = "0x131BC94")]
		get
		{
			return null;
		}
		[Token(Token = "0x60136DB")]
		[Address(RVA = "0x131BC9C", Offset = "0x131BC9C", VA = "0x131BC9C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001432")]
	public List<FestivalAttendanceItem> MegaFestivalSigninAwards
	{
		[Token(Token = "0x60136DC")]
		[Address(RVA = "0x131BCA4", Offset = "0x131BCA4", VA = "0x131BCA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60136DD")]
		[Address(RVA = "0x131BCAC", Offset = "0x131BCAC", VA = "0x131BCAC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001433")]
	public bool HasGetMegaFestivalInfoSinceLogin
	{
		[Token(Token = "0x60136DE")]
		[Address(RVA = "0x131BCB4", Offset = "0x131BCB4", VA = "0x131BCB4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136DF")]
		[Address(RVA = "0x131BCBC", Offset = "0x131BCBC", VA = "0x131BCBC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001434")]
	public uint ReunionPlayerLevelLimit
	{
		[Token(Token = "0x60136E0")]
		[Address(RVA = "0x131BCC4", Offset = "0x131BCC4", VA = "0x131BCC4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60136E1")]
		[Address(RVA = "0x131BCCC", Offset = "0x131BCCC", VA = "0x131BCCC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001435")]
	public bool IsShowMegaFestivalRedDot
	{
		[Token(Token = "0x60136E2")]
		[Address(RVA = "0x131BCD4", Offset = "0x131BCD4", VA = "0x131BCD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60136E3")]
		[Address(RVA = "0x131BD2C", Offset = "0x131BD2C", VA = "0x131BD2C")]
		set
		{
		}
	}

	[Token(Token = "0x17001436")]
	public bool WillRewardForVideoAds
	{
		[Token(Token = "0x6013744")]
		[Address(RVA = "0x132C82C", Offset = "0x132C82C", VA = "0x132C82C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013745")]
		[Address(RVA = "0x132C834", Offset = "0x132C834", VA = "0x132C834")]
		private set
		{
		}
	}

	[Token(Token = "0x17001437")]
	public ActivityGroupDesc CurrentDisplayPaymentActivity
	{
		[Token(Token = "0x601374B")]
		[Address(RVA = "0x132CDF4", Offset = "0x132CDF4", VA = "0x132CDF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601374C")]
		[Address(RVA = "0x132CDFC", Offset = "0x132CDFC", VA = "0x132CDFC")]
		private set
		{
		}
	}

	[Token(Token = "0x60136C9")]
	[Address(RVA = "0x131B0D4", Offset = "0x131B0D4", VA = "0x131B0D4")]
	public UIModelActivity()
	{
	}

	[Token(Token = "0x60136CC")]
	[Address(RVA = "0x131B888", Offset = "0x131B888", VA = "0x131B888")]
	public TagConfig GetActivityTagConfigByEvent(EEventTag eEvent)
	{
		return null;
	}

	[Token(Token = "0x60136E4")]
	[Address(RVA = "0x131BEF0", Offset = "0x131BEF0", VA = "0x131BEF0", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60136E5")]
	[Address(RVA = "0x131C368", Offset = "0x131C368", VA = "0x131C368")]
	public void UpdateEasterActivityTodayExpireTime()
	{
	}

	[Token(Token = "0x60136E6")]
	[Address(RVA = "0x131C5B8", Offset = "0x131C5B8", VA = "0x131C5B8")]
	public bool ActivityDescDataFetched()
	{
		return default(bool);
	}

	[Token(Token = "0x60136E7")]
	[Address(RVA = "0x131C61C", Offset = "0x131C61C", VA = "0x131C61C")]
	public bool HasActivityInfoData()
	{
		return default(bool);
	}

	[Token(Token = "0x60136E8")]
	[Address(RVA = "0x131C680", Offset = "0x131C680", VA = "0x131C680")]
	public bool HasMegaAttendanceInfoData()
	{
		return default(bool);
	}

	[Token(Token = "0x60136E9")]
	[Address(RVA = "0x131C6E4", Offset = "0x131C6E4", VA = "0x131C6E4")]
	public HttpRequest RequestActivityDesc(float timeout = 0f)
	{
		return null;
	}

	[Token(Token = "0x60136EA")]
	[Address(RVA = "0x131CA30", Offset = "0x131CA30", VA = "0x131CA30")]
	public static proto.EActivity.Platform ActivityPlatform()
	{
		return default(proto.EActivity.Platform);
	}

	[Token(Token = "0x60136EB")]
	[Address(RVA = "0x131CA80", Offset = "0x131CA80", VA = "0x131CA80")]
	public void ProcessAllActivityDescs()
	{
	}

	[Token(Token = "0x60136EC")]
	[Address(RVA = "0x131E43C", Offset = "0x131E43C", VA = "0x131E43C")]
	public void OnActivityDescResponse(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x60136ED")]
	[Address(RVA = "0x131E5D0", Offset = "0x131E5D0", VA = "0x131E5D0")]
	public bool IsInValidLevel(ClientActivityDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x60136EE")]
	[Address(RVA = "0x131E764", Offset = "0x131E764", VA = "0x131E764")]
	public bool IsValidGroup(uint groupId, bool showTips = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60136EF")]
	[Address(RVA = "0x131ED00", Offset = "0x131ED00", VA = "0x131ED00")]
	public ClientActivityDesc GetActivityByGroup(uint groupId)
	{
		return null;
	}

	[Token(Token = "0x60136F0")]
	[Address(RVA = "0x131EE60", Offset = "0x131EE60", VA = "0x131EE60")]
	public HttpRequest RequestActivityInfo(float timeout = 0f, bool forceUpdate = false)
	{
		return null;
	}

	[Token(Token = "0x60136F1")]
	[Address(RVA = "0x131EFB0", Offset = "0x131EFB0", VA = "0x131EFB0")]
	private void OnGetActivenessInfo()
	{
	}

	[Token(Token = "0x60136F2")]
	[Address(RVA = "0x131F0D0", Offset = "0x131F0D0", VA = "0x131F0D0")]
	public void OnActivityInfoResponse(HttpErrorCode errorCode, CSGetActivityInfoRes obj)
	{
	}

	[Token(Token = "0x60136F3")]
	[Address(RVA = "0x131F584", Offset = "0x131F584", VA = "0x131F584")]
	public void RequestActivityAward(uint activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, bool childKeepStyle = false)
	{
	}

	[Token(Token = "0x60136F4")]
	[Address(RVA = "0x131FA48", Offset = "0x131FA48", VA = "0x131FA48")]
	public void RequestActivityAwardInGameScene(uint activityid)
	{
	}

	[Token(Token = "0x60136F5")]
	[Address(RVA = "0x131F6B8", Offset = "0x131F6B8", VA = "0x131F6B8")]
	public void RequestActivityAward(uint[] activityid, bool bigPriceControlCommonRewardWnd = false, bool showRewardWindow = true, UICommonRewardWndController.WndStyleEnum style = UICommonRewardWndController.WndStyleEnum.COMMON, bool childKeepStyle = false)
	{
	}

	[Token(Token = "0x60136F6")]
	[Address(RVA = "0x131FD44", Offset = "0x131FD44", VA = "0x131FD44")]
	public bool NeedShowActivenessClaimAllBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60136F7")]
	[Address(RVA = "0x13200A8", Offset = "0x13200A8", VA = "0x13200A8")]
	public void NotifyActivityUpdate(List<ActivityUpdateInfo> updateInfos)
	{
	}

	[Token(Token = "0x60136F8")]
	[Address(RVA = "0x132090C", Offset = "0x132090C", VA = "0x132090C")]
	public ClientActivityDesc GetBigEventDescByID(uint activityID)
	{
		return null;
	}

	[Token(Token = "0x60136F9")]
	[Address(RVA = "0x131FF9C", Offset = "0x131FF9C", VA = "0x131FF9C")]
	public ActivityClientInfo GetActicityInfo(uint activityid)
	{
		return null;
	}

	[Token(Token = "0x60136FA")]
	[Address(RVA = "0x1320D60", Offset = "0x1320D60", VA = "0x1320D60")]
	public ActivenessInfo GetActivenessInfo()
	{
		return null;
	}

	[Token(Token = "0x60136FB")]
	[Address(RVA = "0x131C0B0", Offset = "0x131C0B0", VA = "0x131C0B0")]
	public void ResetActivenessTaskAndReward()
	{
	}

	[Token(Token = "0x60136FC")]
	[Address(RVA = "0x1320DB8", Offset = "0x1320DB8", VA = "0x1320DB8")]
	public ulong GetActivenessResetTime(EActivenessRewardType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x60136FD")]
	[Address(RVA = "0x1321108", Offset = "0x1321108", VA = "0x1321108")]
	public List<ActivenessReward> GetActivenessRewardList(EActivenessRewardType type)
	{
		return null;
	}

	[Token(Token = "0x60136FE")]
	[Address(RVA = "0x132122C", Offset = "0x132122C", VA = "0x132122C")]
	public bool HasExchangeActivity()
	{
		return default(bool);
	}

	[Token(Token = "0x60136FF")]
	[Address(RVA = "0x13213E4", Offset = "0x13213E4", VA = "0x13213E4")]
	public bool HasBindActivity()
	{
		return default(bool);
	}

	[Token(Token = "0x6013700")]
	[Address(RVA = "0x132159C", Offset = "0x132159C", VA = "0x132159C")]
	public bool HasBindActivityNow()
	{
		return default(bool);
	}

	[Token(Token = "0x6013701")]
	[Address(RVA = "0x13218C4", Offset = "0x13218C4", VA = "0x13218C4")]
	public bool IsInActivePeriod(ActivityGroupDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x6013702")]
	[Address(RVA = "0x13219F8", Offset = "0x13219F8", VA = "0x13219F8")]
	public bool IsInActivePeriod(ClientActivityDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x6013703")]
	[Address(RVA = "0x1321B10", Offset = "0x1321B10", VA = "0x1321B10")]
	public List<ActivityGroupDesc> GetActivityGroupDescs_Unfinished(EEventType eventType)
	{
		return null;
	}

	[Token(Token = "0x6013704")]
	[Address(RVA = "0x1321C30", Offset = "0x1321C30", VA = "0x1321C30")]
	public List<ActivityGroupDesc> GetActivityGroupDescs_RewardClaimable(EEventType eventType)
	{
		return null;
	}

	[Token(Token = "0x6013705")]
	[Address(RVA = "0x1321D50", Offset = "0x1321D50", VA = "0x1321D50")]
	public bool HasClaimableReward(ActivityGroupDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x6013706")]
	[Address(RVA = "0x132216C", Offset = "0x132216C", VA = "0x132216C")]
	public bool IsUnfinished(ActivityGroupDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x6013707")]
	[Address(RVA = "0x1322330", Offset = "0x1322330", VA = "0x1322330")]
	public List<ActivityClientInfo> FindActivityInfosByGroupIdAndState(uint groupId, proto.EActivity.State state)
	{
		return null;
	}

	[Token(Token = "0x6013708")]
	[Address(RVA = "0x1321F14", Offset = "0x1321F14", VA = "0x1321F14")]
	private bool MatchWithActivityInfo(ActivityGroupDesc activityGroupDesc, Predicate<ActivityClientInfo> predicate)
	{
		return default(bool);
	}

	[Token(Token = "0x6013709")]
	[Address(RVA = "0x132176C", Offset = "0x132176C", VA = "0x132176C")]
	public bool IsInPreviewPeriod(ActivityGroupDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x601370A")]
	[Address(RVA = "0x1322750", Offset = "0x1322750", VA = "0x1322750")]
	public bool IsInPreviewPeriod(ClientActivityDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x601370B")]
	[Address(RVA = "0x13228AC", Offset = "0x13228AC", VA = "0x13228AC")]
	public bool IsInPreLoginPeriod(uint groupid)
	{
		return default(bool);
	}

	[Token(Token = "0x601370C")]
	[Address(RVA = "0x13229F0", Offset = "0x13229F0", VA = "0x13229F0")]
	public ActivityGroupDesc GetActivityGroupDesc(uint groupid)
	{
		return null;
	}

	[Token(Token = "0x601370D")]
	[Address(RVA = "0x131DFB4", Offset = "0x131DFB4", VA = "0x131DFB4")]
	public List<ActivityGroupDesc> GetActivityGroupDescs(EEventType eventType)
	{
		return null;
	}

	[Token(Token = "0x601370E")]
	[Address(RVA = "0x1322B74", Offset = "0x1322B74", VA = "0x1322B74")]
	public List<ActivityGroupDesc> GetActivityGroupDescs(EEventType eventType, proto.EActivity.SubType subType)
	{
		return null;
	}

	[Token(Token = "0x601370F")]
	[Address(RVA = "0x1322DA4", Offset = "0x1322DA4", VA = "0x1322DA4")]
	public List<ActivityGroupDesc> GetActivityFriendReunionGroupDesc()
	{
		return null;
	}

	[Token(Token = "0x6013710")]
	[Address(RVA = "0x1323000", Offset = "0x1323000", VA = "0x1323000")]
	public List<ActivityGroupDesc> GetActivityGroupDescs(EventEntryType entry, EEventType eventType)
	{
		return null;
	}

	[Token(Token = "0x6013711")]
	[Address(RVA = "0x1322660", Offset = "0x1322660", VA = "0x1322660")]
	public List<ClientActivityDesc> GetActivityDescList(uint groupid)
	{
		return null;
	}

	[Token(Token = "0x6013712")]
	[Address(RVA = "0x132249C", Offset = "0x132249C", VA = "0x132249C")]
	public List<ActivityClientInfo> GetActivityInfoList(uint groupid)
	{
		return null;
	}

	[Token(Token = "0x6013713")]
	[Address(RVA = "0x13233FC", Offset = "0x13233FC", VA = "0x13233FC")]
	public bool IsActivityGroupHasState(uint groupID, proto.EActivity.State state)
	{
		return default(bool);
	}

	[Token(Token = "0x6013714")]
	[Address(RVA = "0x13235F8", Offset = "0x13235F8", VA = "0x13235F8")]
	public int GetEasterRedDotNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013715")]
	[Address(RVA = "0x1323F50", Offset = "0x1323F50", VA = "0x1323F50")]
	public int GetOverviewRedDotNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013716")]
	[Address(RVA = "0x13243EC", Offset = "0x13243EC", VA = "0x13243EC")]
	public bool IsOverviewActivityRedDotValid(ClientActivityDesc activity)
	{
		return default(bool);
	}

	[Token(Token = "0x6013717")]
	[Address(RVA = "0x13247B4", Offset = "0x13247B4", VA = "0x13247B4")]
	public int GetExchangeActivityCanExchageNum(ActivityGroupDesc groupDesc)
	{
		return default(int);
	}

	[Token(Token = "0x6013718")]
	[Address(RVA = "0x1323D48", Offset = "0x1323D48", VA = "0x1323D48")]
	public bool ExchangeActivityCanExchange(uint activityId)
	{
		return default(bool);
	}

	[Token(Token = "0x6013719")]
	[Address(RVA = "0x1324B0C", Offset = "0x1324B0C", VA = "0x1324B0C")]
	public bool ExchangeActivityItemCountEnough(ClientActivityDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x601371A")]
	[Address(RVA = "0x132499C", Offset = "0x132499C", VA = "0x132499C")]
	public bool IsActivityInForecastTime(uint activityId)
	{
		return default(bool);
	}

	[Token(Token = "0x601371B")]
	[Address(RVA = "0x131F4C8", Offset = "0x131F4C8", VA = "0x131F4C8")]
	private void UpdateExtraInfo(bool tcpNotify = false)
	{
	}

	[Token(Token = "0x601371C")]
	[Address(RVA = "0x1324D00", Offset = "0x1324D00", VA = "0x1324D00")]
	private void UpdateShowActivityDescGroup()
	{
	}

	[Token(Token = "0x601371D")]
	[Address(RVA = "0x13269AC", Offset = "0x13269AC", VA = "0x13269AC")]
	public bool GroupAwared(ActivityGroupDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x601371E")]
	[Address(RVA = "0x131BD98", Offset = "0x131BD98", VA = "0x131BD98")]
	private void UpdateActivityTipsNum()
	{
	}

	[Token(Token = "0x601371F")]
	[Address(RVA = "0x132732C", Offset = "0x132732C", VA = "0x132732C")]
	public void CloseExchangeRedTips(uint activity_id)
	{
	}

	[Token(Token = "0x6013720")]
	[Address(RVA = "0x1327488", Offset = "0x1327488", VA = "0x1327488")]
	public void OpenExchangeRedTips(uint activity_id)
	{
	}

	[Token(Token = "0x6013721")]
	[Address(RVA = "0x1323BEC", Offset = "0x1323BEC", VA = "0x1323BEC")]
	public bool IsExchangeRedTipsClosed(uint activity_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013722")]
	[Address(RVA = "0x1326BBC", Offset = "0x1326BBC", VA = "0x1326BBC")]
	public int ActivityDailyTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013723")]
	[Address(RVA = "0x1326CCC", Offset = "0x1326CCC", VA = "0x1326CCC")]
	public int ActivityFestival1TipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013724")]
	[Address(RVA = "0x1326DDC", Offset = "0x1326DDC", VA = "0x1326DDC")]
	public int ActivityFestival2TipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013725")]
	[Address(RVA = "0x1326EEC", Offset = "0x1326EEC", VA = "0x1326EEC")]
	public int ActivityFestival3TipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013726")]
	[Address(RVA = "0x1326FFC", Offset = "0x1326FFC", VA = "0x1326FFC")]
	private int UpdateMegaFestivalTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013727")]
	[Address(RVA = "0x13275E4", Offset = "0x13275E4", VA = "0x13275E4")]
	public int ActivityTopTabTipsNum(EventTabType tabType)
	{
		return default(int);
	}

	[Token(Token = "0x6013728")]
	[Address(RVA = "0x132710C", Offset = "0x132710C", VA = "0x132710C")]
	public int ActivityGwTokenTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x6013729")]
	[Address(RVA = "0x132721C", Offset = "0x132721C", VA = "0x132721C")]
	public int ActivityGwCommonTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x601372A")]
	[Address(RVA = "0x1327798", Offset = "0x1327798", VA = "0x1327798")]
	public int MegaFestivalTabTipsNum(EventTabType tabType)
	{
		return default(int);
	}

	[Token(Token = "0x601372B")]
	[Address(RVA = "0x1328C18", Offset = "0x1328C18", VA = "0x1328C18")]
	private int MegaFestivalGroupTipsNum(ActivityGroupDesc group)
	{
		return default(int);
	}

	[Token(Token = "0x601372C")]
	[Address(RVA = "0x1328DF8", Offset = "0x1328DF8", VA = "0x1328DF8")]
	public int GetActivityTipsNumForThirdTab(List<ClientActivityDesc> activityList)
	{
		return default(int);
	}

	[Token(Token = "0x601372D")]
	[Address(RVA = "0x1328670", Offset = "0x1328670", VA = "0x1328670")]
	public int ActivityGroupTipsNum(ActivityGroupDesc group)
	{
		return default(int);
	}

	[Token(Token = "0x601372E")]
	[Address(RVA = "0x1329094", Offset = "0x1329094", VA = "0x1329094")]
	public bool FestivalActivityAvailble(ActivityGroupDesc group)
	{
		return default(bool);
	}

	[Token(Token = "0x601372F")]
	[Address(RVA = "0x1329660", Offset = "0x1329660", VA = "0x1329660")]
	public bool FestivalActivityAvailble(List<ClientActivityDesc> descs)
	{
		return default(bool);
	}

	[Token(Token = "0x6013730")]
	[Address(RVA = "0x1324EB0", Offset = "0x1324EB0", VA = "0x1324EB0")]
	private void UpdateFirstRecharge()
	{
	}

	[Token(Token = "0x6013731")]
	[Address(RVA = "0x13252B8", Offset = "0x13252B8", VA = "0x13252B8")]
	private void UpdateSecondRecharge()
	{
	}

	[Token(Token = "0x6013732")]
	[Address(RVA = "0x132984C", Offset = "0x132984C", VA = "0x132984C")]
	public EQuestState GetActivityGroupState(EEventType eventType)
	{
		return default(EQuestState);
	}

	[Token(Token = "0x6013733")]
	[Address(RVA = "0x13253F4", Offset = "0x13253F4", VA = "0x13253F4")]
	private void UpdateShareImage()
	{
	}

	[Token(Token = "0x6013734")]
	[Address(RVA = "0x1329BD8", Offset = "0x1329BD8", VA = "0x1329BD8")]
	private List<uint> _GetDisplayedFriendReunionInviteeActivities()
	{
		return null;
	}

	[Token(Token = "0x6013735")]
	[Address(RVA = "0x1329EDC", Offset = "0x1329EDC", VA = "0x1329EDC")]
	private void _SetDisplayedFriendReunionInviteeActivities(List<uint> group_ids)
	{
	}

	[Token(Token = "0x6013736")]
	[Address(RVA = "0x132A1A8", Offset = "0x132A1A8", VA = "0x132A1A8")]
	private FBInvited _GetFBInvited()
	{
		return null;
	}

	[Token(Token = "0x6013737")]
	[Address(RVA = "0x132A514", Offset = "0x132A514", VA = "0x132A514")]
	private void _SetFBInvited(FBInvited fbInvited)
	{
	}

	[Token(Token = "0x6013738")]
	[Address(RVA = "0x132A888", Offset = "0x132A888", VA = "0x132A888")]
	public bool GetFriendReunionFBInvited(ulong uid)
	{
		return default(bool);
	}

	[Token(Token = "0x6013739")]
	[Address(RVA = "0x132AA70", Offset = "0x132AA70", VA = "0x132AA70")]
	public bool GetFriendReunionFBInvited(ulong uid, uint group_id)
	{
		return default(bool);
	}

	[Token(Token = "0x601373A")]
	[Address(RVA = "0x132AF28", Offset = "0x132AF28", VA = "0x132AF28")]
	public void SetFriendReunionFBInvited(ulong uid)
	{
	}

	[Token(Token = "0x601373B")]
	[Address(RVA = "0x132B830", Offset = "0x132B830", VA = "0x132B830")]
	public void OnFriendReunionInviteeActivityDisplayed(ActivityGroupDesc desc)
	{
	}

	[Token(Token = "0x601373C")]
	[Address(RVA = "0x132B9B0", Offset = "0x132B9B0", VA = "0x132B9B0")]
	public bool ShowTipsForFriendReunionInviteeActivity(ActivityGroupDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x601373D")]
	[Address(RVA = "0x132BA90", Offset = "0x132BA90", VA = "0x132BA90")]
	public bool ShowInviterInputForFriendReunionInviteeActivity(ActivityGroupDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x601373E")]
	[Address(RVA = "0x132BD44", Offset = "0x132BD44", VA = "0x132BD44")]
	public bool IsFriendReunionInviteeActivityGained(ActivityGroupDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x601373F")]
	[Address(RVA = "0x132BF14", Offset = "0x132BF14", VA = "0x132BF14")]
	public bool ShouldShowFriendReunionFor(FriendAccountInfo friend)
	{
		return default(bool);
	}

	[Token(Token = "0x6013740")]
	[Address(RVA = "0x132C0FC", Offset = "0x132C0FC", VA = "0x132C0FC")]
	public void InspectFriendReunionInviteeActivity(ActivityGroupDesc desc, out bool show, out int tips)
	{
	}

	[Token(Token = "0x6013741")]
	[Address(RVA = "0x132C390", Offset = "0x132C390", VA = "0x132C390")]
	public void InspectFriendReunionInviterActivity(ActivityGroupDesc desc, out bool show, out int tips)
	{
	}

	[Token(Token = "0x6013742")]
	[Address(RVA = "0x1325680", Offset = "0x1325680", VA = "0x1325680")]
	private void UpdateFriendReunion()
	{
	}

	[Token(Token = "0x6013743")]
	[Address(RVA = "0x132C53C", Offset = "0x132C53C", VA = "0x132C53C")]
	public void SendFriendReunion(ulong inviterID, uint activityID, bool isFriend, uint subType)
	{
	}

	[Token(Token = "0x6013746")]
	[Address(RVA = "0x13293E4", Offset = "0x13293E4", VA = "0x13293E4")]
	public int GetRedDot(EEventType eventType, uint group_id)
	{
		return default(int);
	}

	[Token(Token = "0x6013747")]
	[Address(RVA = "0x132C83C", Offset = "0x132C83C", VA = "0x132C83C")]
	private void ClearRedDot(EEventType eventType)
	{
	}

	[Token(Token = "0x6013748")]
	[Address(RVA = "0x132C9D0", Offset = "0x132C9D0", VA = "0x132C9D0")]
	private void SetRedDot(EEventType eventType, uint group_id, int num)
	{
	}

	[Token(Token = "0x6013749")]
	[Address(RVA = "0x132CB8C", Offset = "0x132CB8C", VA = "0x132CB8C")]
	private int CalcRedDots(EEventType eventType)
	{
		return default(int);
	}

	[Token(Token = "0x601374A")]
	[Address(RVA = "0x1325C1C", Offset = "0x1325C1C", VA = "0x1325C1C")]
	private void UpdateRewardedVideo()
	{
	}

	[Token(Token = "0x601374D")]
	[Address(RVA = "0x1325E3C", Offset = "0x1325E3C", VA = "0x1325E3C")]
	private void UpdatePaymentActivity()
	{
	}

	[Token(Token = "0x601374E")]
	[Address(RVA = "0x13260C8", Offset = "0x13260C8", VA = "0x13260C8")]
	private void UpdatePaymentTotal()
	{
	}

	[Token(Token = "0x601374F")]
	[Address(RVA = "0x13261D4", Offset = "0x13261D4", VA = "0x13261D4")]
	private void UpdateOptionalDownloadRewarded(bool tcpNotify = false)
	{
	}

	[Token(Token = "0x6013750")]
	[Address(RVA = "0x1329290", Offset = "0x1329290", VA = "0x1329290")]
	public bool IsNewActivity(uint groupid)
	{
		return default(bool);
	}

	[Token(Token = "0x6013751")]
	[Address(RVA = "0x132CE04", Offset = "0x132CE04", VA = "0x132CE04")]
	public void SetActivityReaded(uint groupid)
	{
	}

	[Token(Token = "0x6013752")]
	[Address(RVA = "0x1324660", Offset = "0x1324660", VA = "0x1324660")]
	public bool IsSingleActivityGotoUnClicked(uint activityId)
	{
		return default(bool);
	}

	[Token(Token = "0x6013753")]
	[Address(RVA = "0x132CF60", Offset = "0x132CF60", VA = "0x132CF60")]
	public void SetSingleActivityGotoClicked(uint activityId)
	{
	}

	[Token(Token = "0x6013754")]
	[Address(RVA = "0x132D174", Offset = "0x132D174", VA = "0x132D174")]
	public bool IsActivityGotoUnClicked(uint groupid)
	{
		return default(bool);
	}

	[Token(Token = "0x6013755")]
	[Address(RVA = "0x132D2C8", Offset = "0x132D2C8", VA = "0x132D2C8")]
	public void SetActivityGotoClicked(uint groupid)
	{
	}

	[Token(Token = "0x6013756")]
	[Address(RVA = "0x132D424", Offset = "0x132D424", VA = "0x132D424")]
	public void ResetActivityGotoClickStatus(uint id)
	{
	}

	[Token(Token = "0x6013757")]
	[Address(RVA = "0x132D648", Offset = "0x132D648", VA = "0x132D648")]
	public ActivityGroupDesc GetGroupDescOfActivity(uint activityid)
	{
		return null;
	}

	[Token(Token = "0x6013758")]
	[Address(RVA = "0x13206F4", Offset = "0x13206F4", VA = "0x13206F4")]
	public ClientActivityDesc GetActivityDesc(uint activityid)
	{
		return null;
	}

	[Token(Token = "0x6013759")]
	[Address(RVA = "0x132D878", Offset = "0x132D878", VA = "0x132D878")]
	public ActivityFestivalDesc GetFestivalDesc(EventTabType type)
	{
		return null;
	}

	[Token(Token = "0x601375A")]
	[Address(RVA = "0x132DB54", Offset = "0x132DB54", VA = "0x132DB54")]
	public ActivityFestivalDesc GetFestivalDesc(uint groupId, uint affiliateTab)
	{
		return null;
	}

	[Token(Token = "0x601375B")]
	[Address(RVA = "0x132DCFC", Offset = "0x132DCFC", VA = "0x132DCFC")]
	public LobbyGameEnterStyleDesc GetLobbyGameEnterStyleDesc()
	{
		return null;
	}

	[Token(Token = "0x601375C")]
	[Address(RVA = "0x1327960", Offset = "0x1327960", VA = "0x1327960")]
	public List<ActivityGroupDesc> GetActivityGroupDescList(EventTabType type)
	{
		return null;
	}

	[Token(Token = "0x601375D")]
	[Address(RVA = "0x132DD54", Offset = "0x132DD54", VA = "0x132DD54")]
	public ulong GetRampageResetTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x601375E")]
	[Address(RVA = "0x132DF44", Offset = "0x132DF44", VA = "0x132DF44")]
	public int GetActivityGroupAWARDEDNum(uint groupid)
	{
		return default(int);
	}

	[Token(Token = "0x601375F")]
	[Address(RVA = "0x132E088", Offset = "0x132E088", VA = "0x132E088")]
	public void RequestBingoRowCloumReward(int row = 0, int colum = 0)
	{
	}

	[Token(Token = "0x6013760")]
	[Address(RVA = "0x132E0F8", Offset = "0x132E0F8", VA = "0x132E0F8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013761")]
	[Address(RVA = "0x132E150", Offset = "0x132E150", VA = "0x132E150")]
	public HttpRequest GetMegaFestivalAttendanceInfo(bool silence = false)
	{
		return null;
	}

	[Token(Token = "0x6013762")]
	[Address(RVA = "0x132E484", Offset = "0x132E484", VA = "0x132E484")]
	public void ClaimMegaFestivalItem(uint id)
	{
	}

	[Token(Token = "0x6013763")]
	[Address(RVA = "0x132E884", Offset = "0x132E884", VA = "0x132E884")]
	public bool CheckIsNeedAutoSignMegaFestival()
	{
		return default(bool);
	}

	[Token(Token = "0x6013764")]
	[Address(RVA = "0x132E96C", Offset = "0x132E96C", VA = "0x132E96C")]
	public void MegaFestivalAutoSignin()
	{
	}

	[Token(Token = "0x6013765")]
	[Address(RVA = "0x132ED08", Offset = "0x132ED08", VA = "0x132ED08")]
	public int GetNowDaysSinceMegaFestivalStartDay()
	{
		return default(int);
	}

	[Token(Token = "0x6013766")]
	[Address(RVA = "0x132EE40", Offset = "0x132EE40", VA = "0x132EE40")]
	public static EventEntryType GetEventEntryType(EventTabType tabType)
	{
		return default(EventEntryType);
	}

	[Token(Token = "0x6013767")]
	[Address(RVA = "0x132326C", Offset = "0x132326C", VA = "0x132326C")]
	public static EventEntryType GetEventEntryType(int tabType)
	{
		return default(EventEntryType);
	}

	[Token(Token = "0x6013768")]
	[Address(RVA = "0x131DC34", Offset = "0x131DC34", VA = "0x131DC34")]
	public void CheckAllHintReset()
	{
	}

	[Token(Token = "0x6013769")]
	[Address(RVA = "0x132F154", Offset = "0x132F154", VA = "0x132F154")]
	private ulong GetSecondsToNearestHintResetTime(uint groupId)
	{
		return default(ulong);
	}

	[Token(Token = "0x601376A")]
	[Address(RVA = "0x132EEE4", Offset = "0x132EEE4", VA = "0x132EEE4")]
	private void StartCountDownHintReset(uint groupId)
	{
	}

	[Token(Token = "0x601376B")]
	[Address(RVA = "0x131C110", Offset = "0x131C110", VA = "0x131C110")]
	private void ClearHintReset()
	{
	}

	[Token(Token = "0x601376C")]
	[Address(RVA = "0x132F3F0", Offset = "0x132F3F0", VA = "0x132F3F0")]
	public void DoHintReset(uint groupId)
	{
	}

	[Token(Token = "0x601376D")]
	[Address(RVA = "0x131E1C8", Offset = "0x131E1C8", VA = "0x131E1C8")]
	public void GetReunionPlayerLevelLimit(bool forceSync = false)
	{
	}

	[Token(Token = "0x601376E")]
	[Address(RVA = "0x132F5D0", Offset = "0x132F5D0", VA = "0x132F5D0")]
	public bool HasBigEventReunionOpened()
	{
		return default(bool);
	}

	[Token(Token = "0x601376F")]
	[Address(RVA = "0x132F950", Offset = "0x132F950", VA = "0x132F950")]
	public bool NavigateActivityByGoPos(uint activityID, UINavigationUtil.UINavigationFrom from)
	{
		return default(bool);
	}

	[Token(Token = "0x6013770")]
	[Address(RVA = "0x132FCB8", Offset = "0x132FCB8", VA = "0x132FCB8")]
	public ClientActivityDesc GetBigEventTaskDescById(uint activityID)
	{
		return null;
	}

	[Token(Token = "0x6013771")]
	[Address(RVA = "0x132FDA0", Offset = "0x132FDA0", VA = "0x132FDA0")]
	public ClientActivityDesc GetBigEventActivityDescByTwoType(EEventType type, proto.EActivity.SubType subType)
	{
		return null;
	}

	[Token(Token = "0x6013772")]
	[Address(RVA = "0x132FF70", Offset = "0x132FF70", VA = "0x132FF70")]
	public List<ClientActivityDesc> GetBigEventSortedDescListByTwoType(EEventType type, proto.EActivity.SubType subType)
	{
		return null;
	}

	[Token(Token = "0x6013773")]
	[Address(RVA = "0x1330278", Offset = "0x1330278", VA = "0x1330278")]
	public List<ClientActivityDesc> GetBigEventActivityDesc(EEventType type)
	{
		return null;
	}

	[Token(Token = "0x6013774")]
	[Address(RVA = "0x1330360", Offset = "0x1330360", VA = "0x1330360")]
	public Dictionary<uint, ClientActivityDesc> GetBigEventTaskDesc()
	{
		return null;
	}

	[Token(Token = "0x6013775")]
	[Address(RVA = "0x13303B8", Offset = "0x13303B8", VA = "0x13303B8")]
	public void ProcesssNormalTopUpEvent()
	{
	}

	[Token(Token = "0x6013776")]
	[Address(RVA = "0x1326554", Offset = "0x1326554", VA = "0x1326554")]
	public void UpdateTopUpEventRedDotTips()
	{
	}

	[Token(Token = "0x6013777")]
	[Address(RVA = "0x13306CC", Offset = "0x13306CC", VA = "0x13306CC")]
	public bool IsNewTopUpEvent(uint groupID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013778")]
	[Address(RVA = "0x13305FC", Offset = "0x13305FC", VA = "0x13305FC")]
	public bool HasNormalTopUpEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x6013779")]
	[Address(RVA = "0x13308E8", Offset = "0x13308E8", VA = "0x13308E8")]
	public List<ActivityGroupDesc> GetNormalTopUpEventDescList()
	{
		return null;
	}

	[Token(Token = "0x601377A")]
	[Address(RVA = "0x1330940", Offset = "0x1330940", VA = "0x1330940")]
	public List<ClientActivityDesc> GetSortedDescList(uint activityid)
	{
		return null;
	}

	[Token(Token = "0x601377B")]
	[Address(RVA = "0x1330BAC", Offset = "0x1330BAC", VA = "0x1330BAC")]
	private int SortNormalTopUpEventGroupDescList(ActivityGroupDesc a, ActivityGroupDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x601377C")]
	[Address(RVA = "0x1330C68", Offset = "0x1330C68", VA = "0x1330C68")]
	public int SortNormalTopUpEventDescList(ClientActivityDesc a, ClientActivityDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x601377D")]
	[Address(RVA = "0x1330D94", Offset = "0x1330D94", VA = "0x1330D94")]
	private int CalculateWeight(proto.EActivity.State state)
	{
		return default(int);
	}

	[Token(Token = "0x601377F")]
	[Address(RVA = "0x1330E90", Offset = "0x1330E90", VA = "0x1330E90")]
	private static int _003CProcessAllActivityDescs_003Em__0(ActivityGroupDesc a, ActivityGroupDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6013780")]
	[Address(RVA = "0x1330ED8", Offset = "0x1330ED8", VA = "0x1330ED8")]
	private void _003CRequestActivityAwardInGameScene_003Em__1(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6013781")]
	[Address(RVA = "0x13312C0", Offset = "0x13312C0", VA = "0x13312C0")]
	private static bool _003CHasClaimableReward_003Em__2(ActivityClientInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013782")]
	[Address(RVA = "0x13312DC", Offset = "0x13312DC", VA = "0x13312DC")]
	private static bool _003CIsUnfinished_003Em__3(ActivityClientInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013783")]
	[Address(RVA = "0x13312FC", Offset = "0x13312FC", VA = "0x13312FC")]
	private static bool _003CGetEasterRedDotNum_003Em__4(ActivityGroupDesc temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6013784")]
	[Address(RVA = "0x133132C", Offset = "0x133132C", VA = "0x133132C")]
	private static bool _003CGetOverviewRedDotNum_003Em__5(ActivityGroupDesc temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6013785")]
	[Address(RVA = "0x133135C", Offset = "0x133135C", VA = "0x133135C")]
	private static bool _003CExchangeActivityItemCountEnough_003Em__6(Item e)
	{
		return default(bool);
	}

	[Token(Token = "0x6013786")]
	[Address(RVA = "0x133146C", Offset = "0x133146C", VA = "0x133146C")]
	private bool _003CGroupAwared_003Em__7(ClientActivityDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6013787")]
	[Address(RVA = "0x13314BC", Offset = "0x13314BC", VA = "0x13314BC")]
	private bool _003CGroupAwared_003Em__8(ClientActivityDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6013788")]
	[Address(RVA = "0x133150C", Offset = "0x133150C", VA = "0x133150C")]
	private static uint _003C_GetDisplayedFriendReunionInviteeActivities_003Em__9(string idString)
	{
		return default(uint);
	}

	[Token(Token = "0x6013789")]
	[Address(RVA = "0x1331540", Offset = "0x1331540", VA = "0x1331540")]
	private static string _003C_SetDisplayedFriendReunionInviteeActivities_003Em__A(uint id)
	{
		return null;
	}

	[Token(Token = "0x601378A")]
	[Address(RVA = "0x1331564", Offset = "0x1331564", VA = "0x1331564")]
	private void _003CSendFriendReunion_003Em__B(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601378B")]
	[Address(RVA = "0x1331E00", Offset = "0x1331E00", VA = "0x1331E00")]
	private bool _003CUpdatePaymentActivity_003Em__C(ActivityGroupDesc g)
	{
		return default(bool);
	}

	[Token(Token = "0x601378C")]
	[Address(RVA = "0x1331E40", Offset = "0x1331E40", VA = "0x1331E40")]
	private bool _003CGetActivityGroupDescList_003Em__D(ActivityGroupDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x601378D")]
	[Address(RVA = "0x1331F34", Offset = "0x1331F34", VA = "0x1331F34")]
	private static int _003CGetActivityGroupDescList_003Em__E(ActivityGroupDesc a, ActivityGroupDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x601378E")]
	[Address(RVA = "0x1331F7C", Offset = "0x1331F7C", VA = "0x1331F7C")]
	private void _003CGetMegaFestivalAttendanceInfo_003Em__F(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601378F")]
	[Address(RVA = "0x1332210", Offset = "0x1332210", VA = "0x1332210")]
	private void _003CMegaFestivalAutoSignin_003Em__10(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013790")]
	[Address(RVA = "0x1332448", Offset = "0x1332448", VA = "0x1332448")]
	private void _003CGetReunionPlayerLevelLimit_003Em__11(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013791")]
	[Address(RVA = "0x133250C", Offset = "0x133250C", VA = "0x133250C")]
	private static int _003CGetBigEventSortedDescListByTwoType_003Em__12(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6013792")]
	[Address(RVA = "0x1332554", Offset = "0x1332554", VA = "0x1332554")]
	private static int _003CGetMegaFestivalAttendanceInfo_003Em__13(FestivalAttendanceItem x, FestivalAttendanceItem y)
	{
		return default(int);
	}

	[Token(Token = "0x6013793")]
	[Address(RVA = "0x1332594", Offset = "0x1332594", VA = "0x1332594")]
	private bool _003CMegaFestivalAutoSignin_003Em__14(FestivalAttendanceItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6013794")]
	[Address(RVA = "0x13325DC", Offset = "0x13325DC", VA = "0x13325DC")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
