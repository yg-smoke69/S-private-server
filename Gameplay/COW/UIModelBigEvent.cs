using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002ECB")]
public class UIModelBigEvent : UIBaseModel
{
	[Token(Token = "0x2002ECC")]
	public class TokenTipsData
	{
		[Token(Token = "0x4011E16")]
		[FieldOffset(Offset = "0x8")]
		public uint id;

		[Token(Token = "0x4011E17")]
		[FieldOffset(Offset = "0xC")]
		public uint go_pos;

		[Token(Token = "0x4011E18")]
		[FieldOffset(Offset = "0x10")]
		public string sub_go_pos;

		[Token(Token = "0x4011E19")]
		[FieldOffset(Offset = "0x14")]
		public string way;

		[Token(Token = "0x60139BD")]
		[Address(RVA = "0x25FAD64", Offset = "0x25FAD64", VA = "0x25FAD64")]
		public TokenTipsData(uint id, uint go_pos, string sub_go_pos, string way)
		{
		}
	}

	[Token(Token = "0x2002ECD")]
	public enum EBigEventEntranceState
	{
		[Token(Token = "0x4011E1B")]
		Hide = 1,
		[Token(Token = "0x4011E1C")]
		GrayPre,
		[Token(Token = "0x4011E1D")]
		GrayOnGoing,
		[Token(Token = "0x4011E1E")]
		GrayOverDue,
		[Token(Token = "0x4011E1F")]
		Open
	}

	[Token(Token = "0x2002ECE")]
	public enum EBigEventEntranceID
	{
		[Token(Token = "0x4011E21")]
		Main = 0,
		[Token(Token = "0x4011E22")]
		Puzzle = 101,
		[Token(Token = "0x4011E23")]
		DailyMission = 102,
		[Token(Token = "0x4011E24")]
		Gacha = 103,
		[Token(Token = "0x4011E25")]
		Album = 104,
		[Token(Token = "0x4011E26")]
		Revenue = 105,
		[Token(Token = "0x4011E27")]
		WebActivity = 106,
		[Token(Token = "0x4011E28")]
		Revenue2 = 107,
		[Token(Token = "0x4011E29")]
		InGameGoPos = 108,
		[Token(Token = "0x4011E2A")]
		SubBigEvent = 109,
		[Token(Token = "0x4011E2B")]
		SignIn = 110,
		[Token(Token = "0x4011E2C")]
		DiceGame = 111,
		[Token(Token = "0x4011E2D")]
		ExchangeStore = 112,
		[Token(Token = "0x4011E2E")]
		GameFFManager = 113,
		[Token(Token = "0x4011E2F")]
		GameLive = 114,
		[Token(Token = "0x4011E30")]
		TeamShow = 115,
		[Token(Token = "0x4011E31")]
		GameGuess = 116,
		[Token(Token = "0x4011E32")]
		InviteFriend = 117,
		[Token(Token = "0x4011E33")]
		HelpFriend = 118,
		[Token(Token = "0x4011E34")]
		WebActivity2 = 119,
		[Token(Token = "0x4011E35")]
		WebActivity3 = 120,
		[Token(Token = "0x4011E36")]
		LeaderBoard = 121,
		[Token(Token = "0x4011E37")]
		ElitePass = 122,
		[Token(Token = "0x4011E38")]
		TeamPlay = 123,
		[Token(Token = "0x4011E39")]
		LudoGame = 124,
		[Token(Token = "0x4011E3A")]
		MiniGame = 125,
		[Token(Token = "0x4011E3B")]
		ExchangeCloth = 126,
		[Token(Token = "0x4011E3C")]
		UseSupport = 127,
		[Token(Token = "0x4011E3D")]
		TokenGain1 = 128,
		[Token(Token = "0x4011E3E")]
		TokenGain2 = 129,
		[Token(Token = "0x4011E3F")]
		TokenGain3 = 130,
		[Token(Token = "0x4011E40")]
		TokenGain4 = 131,
		[Token(Token = "0x4011E41")]
		TokenGain5 = 132,
		[Token(Token = "0x4011E42")]
		TokenGain6 = 133,
		[Token(Token = "0x4011E43")]
		ExchangeCard = 134,
		[Token(Token = "0x4011E44")]
		Revenue3 = 135,
		[Token(Token = "0x4011E45")]
		Revenue4 = 136,
		[Token(Token = "0x4011E46")]
		RoleDoor = 137,
		[Token(Token = "0x4011E47")]
		RolrDoorDialog = 138,
		[Token(Token = "0x4011E48")]
		ClothesDoor = 139,
		[Token(Token = "0x4011E49")]
		GunDoor = 140,
		[Token(Token = "0x4011E4A")]
		MapDoor = 141,
		[Token(Token = "0x4011E4B")]
		ActivityDoor = 142,
		[Token(Token = "0x4011E4C")]
		Revenue5 = 143,
		[Token(Token = "0x4011E4D")]
		Revenue6 = 144,
		[Token(Token = "0x4011E4E")]
		StarMap = 145
	}

	[Token(Token = "0x2002ECF")]
	public enum EPeakDayState
	{
		[Token(Token = "0x4011E50")]
		Invalid,
		[Token(Token = "0x4011E51")]
		UnClaimable,
		[Token(Token = "0x4011E52")]
		Claimable,
		[Token(Token = "0x4011E53")]
		Claimed,
		[Token(Token = "0x4011E54")]
		Expired,
		[Token(Token = "0x4011E55")]
		ClaimedAndExpired
	}

	[Token(Token = "0x2002ED0")]
	private sealed class _003CRequestEventInventorySetting_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011E56")]
		[FieldOffset(Offset = "0x8")]
		internal uint bigEventID;

		[Token(Token = "0x4011E57")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x4011E58")]
		[FieldOffset(Offset = "0x0")]
		private static Func<BigEventBadgeDesc, uint> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4011E59")]
		[FieldOffset(Offset = "0x4")]
		private static Func<BigEventBadgeDesc, BigEventBadgeDesc> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x60139BE")]
		[Address(RVA = "0x25F4FF8", Offset = "0x25F4FF8", VA = "0x25F4FF8")]
		public _003CRequestEventInventorySetting_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60139BF")]
		[Address(RVA = "0x2601D9C", Offset = "0x2601D9C", VA = "0x2601D9C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60139C0")]
		[Address(RVA = "0x2601FFC", Offset = "0x2601FFC", VA = "0x2601FFC")]
		private static uint _003C_003Em__1(BigEventBadgeDesc item)
		{
			return default(uint);
		}

		[Token(Token = "0x60139C1")]
		[Address(RVA = "0x2602020", Offset = "0x2602020", VA = "0x2602020")]
		private static BigEventBadgeDesc _003C_003Em__2(BigEventBadgeDesc Item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002ED1")]
	private sealed class _003CRequestEventInventoryInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011E5A")]
		[FieldOffset(Offset = "0x8")]
		internal uint bigEventID;

		[Token(Token = "0x4011E5B")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x60139C2")]
		[Address(RVA = "0x25F52A0", Offset = "0x25F52A0", VA = "0x25F52A0")]
		public _003CRequestEventInventoryInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60139C3")]
		[Address(RVA = "0x2601C54", Offset = "0x2601C54", VA = "0x2601C54")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002ED2")]
	private sealed class _003CRequestClaimLimitedEventSettleReward_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011E5C")]
		[FieldOffset(Offset = "0x8")]
		internal string key;

		[Token(Token = "0x60139C4")]
		[Address(RVA = "0x25F80E8", Offset = "0x25F80E8", VA = "0x25F80E8")]
		public _003CRequestClaimLimitedEventSettleReward_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60139C5")]
		[Address(RVA = "0x2601A98", Offset = "0x2601A98", VA = "0x2601A98")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002ED3")]
	private sealed class _003CGetBigEventEntranceStateByTwoType_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011E5D")]
		[FieldOffset(Offset = "0x8")]
		internal EBigEventEntranceID entrance_id;

		[Token(Token = "0x60139C6")]
		[Address(RVA = "0x25F8404", Offset = "0x25F8404", VA = "0x25F8404")]
		public _003CGetBigEventEntranceStateByTwoType_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60139C7")]
		[Address(RVA = "0x260137C", Offset = "0x260137C", VA = "0x260137C")]
		internal bool _003C_003Em__0(BigEventEntranceSettingDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002ED4")]
	private sealed class _003CGetBigEventEntranceDescByTwoType_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011E5E")]
		[FieldOffset(Offset = "0x8")]
		internal EBigEventEntranceID entrance_id;

		[Token(Token = "0x60139C8")]
		[Address(RVA = "0x25F85DC", Offset = "0x25F85DC", VA = "0x25F85DC")]
		public _003CGetBigEventEntranceDescByTwoType_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60139C9")]
		[Address(RVA = "0x2601344", Offset = "0x2601344", VA = "0x2601344")]
		internal bool _003C_003Em__0(BigEventEntranceSettingDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002ED5")]
	private sealed class _003CGetEventCDNUrlByEventIDAndType_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011E5F")]
		[FieldOffset(Offset = "0x8")]
		internal int type;

		[Token(Token = "0x60139CA")]
		[Address(RVA = "0x25F8AB8", Offset = "0x25F8AB8", VA = "0x25F8AB8")]
		public _003CGetEventCDNUrlByEventIDAndType_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60139CB")]
		[Address(RVA = "0x26013B4", Offset = "0x26013B4", VA = "0x26013B4")]
		internal bool _003C_003Em__0(BigEventCDNDesc info)
		{
			return default(bool);
		}

		[Token(Token = "0x60139CC")]
		[Address(RVA = "0x26014E4", Offset = "0x26014E4", VA = "0x26014E4")]
		internal bool _003C_003Em__1(BigEventCDNDesc info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002ED6")]
	private sealed class _003CGetEventOpenInfoByIdAndState_003Ec__AnonStorey6
	{
		[Token(Token = "0x4011E60")]
		[FieldOffset(Offset = "0x8")]
		internal ELimitedEvent.EventState state;

		[Token(Token = "0x60139CD")]
		[Address(RVA = "0x25F8AC0", Offset = "0x25F8AC0", VA = "0x25F8AC0")]
		public _003CGetEventOpenInfoByIdAndState_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60139CE")]
		[Address(RVA = "0x26015E4", Offset = "0x26015E4", VA = "0x26015E4")]
		internal bool _003C_003Em__0(BigEventOpenInfoDesc info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002ED7")]
	private sealed class _003CGetNotifyInfo_003Ec__AnonStorey7
	{
		[Token(Token = "0x4011E61")]
		[FieldOffset(Offset = "0x8")]
		internal uint GoPos;

		[Token(Token = "0x4011E62")]
		[FieldOffset(Offset = "0xC")]
		internal string content;

		[Token(Token = "0x60139CF")]
		[Address(RVA = "0x25FA198", Offset = "0x25FA198", VA = "0x25FA198")]
		public _003CGetNotifyInfo_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60139D0")]
		[Address(RVA = "0x2601668", Offset = "0x2601668", VA = "0x2601668")]
		internal string _003C_003Em__0(object[] parameters)
		{
			return null;
		}

		[Token(Token = "0x60139D1")]
		[Address(RVA = "0x2601748", Offset = "0x2601748", VA = "0x2601748")]
		internal string _003C_003Em__1()
		{
			return null;
		}
	}

	[Token(Token = "0x2002ED8")]
	private sealed class _003CRequestTokenTipsDesc_003Ec__AnonStorey8
	{
		[Token(Token = "0x4011E63")]
		[FieldOffset(Offset = "0x8")]
		internal ELimitedEvent.EventID eventID;

		[Token(Token = "0x4011E64")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x60139D2")]
		[Address(RVA = "0x25FA42C", Offset = "0x25FA42C", VA = "0x25FA42C")]
		public _003CRequestTokenTipsDesc_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60139D3")]
		[Address(RVA = "0x2603A60", Offset = "0x2603A60", VA = "0x2603A60")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002ED9")]
	private sealed class _003CRequestExchangeStoreData_003Ec__AnonStorey9
	{
		[Token(Token = "0x4011E65")]
		[FieldOffset(Offset = "0x8")]
		internal ELimitedEvent.EventID eventID;

		[Token(Token = "0x4011E66")]
		[FieldOffset(Offset = "0xC")]
		internal ELimitedEvent.StoreType storeType;

		[Token(Token = "0x4011E67")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x4011E68")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<LimitedEventStore> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60139D4")]
		[Address(RVA = "0x25FB1F4", Offset = "0x25FB1F4", VA = "0x25FB1F4")]
		public _003CRequestExchangeStoreData_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60139D5")]
		[Address(RVA = "0x2602024", Offset = "0x2602024", VA = "0x2602024")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60139D6")]
		[Address(RVA = "0x26027F0", Offset = "0x26027F0", VA = "0x26027F0")]
		private static int _003C_003Em__1(LimitedEventStore a, LimitedEventStore b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2002EDA")]
	private sealed class _003CGetExchangeStoreDataById_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4011E69")]
		[FieldOffset(Offset = "0x8")]
		internal uint storeId;

		[Token(Token = "0x60139D7")]
		[Address(RVA = "0x25FC390", Offset = "0x25FC390", VA = "0x25FC390")]
		public _003CGetExchangeStoreDataById_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x60139D8")]
		[Address(RVA = "0x260161C", Offset = "0x260161C", VA = "0x260161C")]
		internal bool _003C_003Em__0(LimitedEventStore item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002EDB")]
	private sealed class _003CRequestExchangeStorePurchase_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4011E6A")]
		[FieldOffset(Offset = "0x8")]
		internal BigEventStoreCommodityDesc desc;

		[Token(Token = "0x4011E6B")]
		[FieldOffset(Offset = "0xC")]
		internal uint cnt;

		[Token(Token = "0x4011E6C")]
		[FieldOffset(Offset = "0x10")]
		internal ELimitedEvent.EventID eventID;

		[Token(Token = "0x4011E6D")]
		[FieldOffset(Offset = "0x14")]
		internal bool useCommonReward;

		[Token(Token = "0x4011E6E")]
		[FieldOffset(Offset = "0x18")]
		internal ELimitedEvent.StoreType storeType;

		[Token(Token = "0x4011E6F")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x60139D9")]
		[Address(RVA = "0x25FCA5C", Offset = "0x25FCA5C", VA = "0x25FCA5C")]
		public _003CRequestExchangeStorePurchase_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x60139DA")]
		[Address(RVA = "0x2602860", Offset = "0x2602860", VA = "0x2602860")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60139DB")]
		[Address(RVA = "0x26032DC", Offset = "0x26032DC", VA = "0x26032DC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002EDC")]
	private sealed class _003CRequestAFKGroupInfo_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4011E70")]
		[FieldOffset(Offset = "0x8")]
		internal bool filter;

		[Token(Token = "0x4011E71")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x60139DC")]
		[Address(RVA = "0x25FD030", Offset = "0x25FD030", VA = "0x25FD030")]
		public _003CRequestAFKGroupInfo_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x60139DD")]
		[Address(RVA = "0x260181C", Offset = "0x260181C", VA = "0x260181C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EDD")]
	private sealed class _003CRequestJoinAFKGroup_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4011E72")]
		[FieldOffset(Offset = "0x8")]
		internal bool isInvitedByShare;

		[Token(Token = "0x4011E73")]
		[FieldOffset(Offset = "0x10")]
		internal ulong groupID;

		[Token(Token = "0x4011E74")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x60139DE")]
		[Address(RVA = "0x25FD558", Offset = "0x25FD558", VA = "0x25FD558")]
		public _003CRequestJoinAFKGroup_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x60139DF")]
		[Address(RVA = "0x2603314", Offset = "0x2603314", VA = "0x2603314")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EDE")]
	private sealed class _003CClaimAFKGroupAwards_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4011E75")]
		[FieldOffset(Offset = "0x8")]
		internal ulong groupID;

		[Token(Token = "0x4011E76")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelBigEvent _0024this;

		[Token(Token = "0x4011E77")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60139E0")]
		[Address(RVA = "0x25FDAD4", Offset = "0x25FDAD4", VA = "0x25FDAD4")]
		public _003CClaimAFKGroupAwards_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x60139E1")]
		[Address(RVA = "0x2600E2C", Offset = "0x2600E2C", VA = "0x2600E2C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60139E2")]
		[Address(RVA = "0x260133C", Offset = "0x260133C", VA = "0x260133C")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002EDF")]
	private sealed class _003CGetEventInventoryInfoByID_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4011E78")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x60139E3")]
		[Address(RVA = "0x25FFA44", Offset = "0x25FFA44", VA = "0x25FFA44")]
		public _003CGetEventInventoryInfoByID_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x60139E4")]
		[Address(RVA = "0x26015AC", Offset = "0x26015AC", VA = "0x26015AC")]
		internal bool _003C_003Em__0(LimitedEventBadge item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011DE5")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, List<BigEventEntryDesc>> m_EventAutoEntryDesc;

	[Token(Token = "0x4011DE6")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, IBigEventModel> m_BigEventModelDict;

	[Token(Token = "0x4011DE7")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<int, List<BigEventOpenInfoDesc>> m_BigEventOpenInfoDict;

	[Token(Token = "0x4011DE8")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<int, List<BigEventCDNDesc>> m_BigEventCDNSettingDict;

	[Token(Token = "0x4011DE9")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, List<LimitedEventStore>> m_BigEventExchangeStoreDict;

	[Token(Token = "0x4011DEA")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, BigEventMovieDesc> m_BigEventMovieDict;

	[Token(Token = "0x4011DEB")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, List<BigEventEntranceSettingDesc>> m_BigEventEntrancesSettingDict;

	[Token(Token = "0x4011DEC")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, Dictionary<uint, BigEventBadgeDesc>> m_BigEventBadgeDescDic;

	[Token(Token = "0x4011DED")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<LimitedEventBadge>> m_BigEventBadgeInfoDic;

	[Token(Token = "0x4011DEE")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, List<BigEventTokenTipsDesc>> m_BigEventTokenTipsDescDict;

	[Token(Token = "0x4011DEF")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, List<ExchangeCurrencyLocalDesc>> m_ExchangeCurrencyLocalEdscDict;

	[Token(Token = "0x4011DF0")]
	[FieldOffset(Offset = "0x38")]
	private HashSet<uint> m_BigEventTokenTipsRequestedEventId;

	[Token(Token = "0x4011DF1")]
	public const string NOTIFY_ANNIVERSARY_ACTIVITY_START = "NOTIFY_ANNIVERSARY_ACTIVITY_START_";

	[Token(Token = "0x4011DF2")]
	public const string DEFAULT = "default";

	[Token(Token = "0x4011DF3")]
	[FieldOffset(Offset = "0x3C")]
	private ELimitedEvent.EventID m_EventAutoEntryId;

	[Token(Token = "0x4011DF4")]
	[FieldOffset(Offset = "0x40")]
	public Queue<LocalNotificationManager.NotifyType> m_CanUseNotifyTypes;

	[Token(Token = "0x4011DF5")]
	[FieldOffset(Offset = "0x44")]
	public Dictionary<uint, LocalNotificationManager.NotifyType> m_UsingNotifyTypes;

	[Token(Token = "0x4011DF6")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<ulong, GoliathAFKGroupInfo> m_AFKGroupInfoDict;

	[Token(Token = "0x4011DF7")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<ulong, uint> m_GroupMemberCnt;

	[Token(Token = "0x4011DF8")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<ulong, ulong> m_FuzzyStartTimeInAdvance;

	[Token(Token = "0x4011DF9")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<ulong, ulong> m_AFKFriendNextInviteableTimestamp;

	[Token(Token = "0x4011DFA")]
	private const ulong AFK_INVITE_FRIEND_CD = 4uL;

	[Token(Token = "0x4011DFB")]
	public const int AFK_MAX_GROUP_NUM = 3;

	[Token(Token = "0x4011DFC")]
	public const uint AFK_GROUP_MAX_MEMBER_NUM = 4u;

	[Token(Token = "0x4011DFD")]
	[FieldOffset(Offset = "0x58")]
	public bool IsAFKGroupInfoChanged;

	[Token(Token = "0x4011DFE")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_CaptaionActivityID;

	[Token(Token = "0x4011DFF")]
	public const int PropID_RefreshAllBigEventEntrance = 2;

	[Token(Token = "0x4011E00")]
	public const int PropID_ExchangeStoreDataUpdate = 4;

	[Token(Token = "0x4011E01")]
	public const int PropID_AFKGroupInfoUpdate = 16;

	[Token(Token = "0x4011E02")]
	public const int PropID_AFKGroupActivityUpdate = 32;

	[Token(Token = "0x4011E03")]
	public const int PropID_SearchAFKGroupInfoReceived = 64;

	[Token(Token = "0x4011E04")]
	public const int PropID_AFKGroupStateChanged = 128;

	[Token(Token = "0x4011E05")]
	public const int PropID_AFKJoinGroupSucceed = 256;

	[Token(Token = "0x4011E06")]
	public const int PropID_AFKJoinGroupFailed = 512;

	[Token(Token = "0x4011E07")]
	public const int PropID_AFKCreateGroupSucceed = 1024;

	[Token(Token = "0x4011E08")]
	public const int PropID_RefreshAllLimitedEventEntrances = 2048;

	[Token(Token = "0x4011E09")]
	public const uint TipType_PeakDay = 2u;

	[Token(Token = "0x4011E0A")]
	public const uint TipType_DailyTask = 4u;

	[Token(Token = "0x4011E0B")]
	public const uint TipType_SignIn = 8u;

	[Token(Token = "0x4011E0C")]
	public const uint TipType_ExchangeStoreOpen = 16u;

	[Token(Token = "0x4011E0D")]
	public const uint TipType_ExchangeStoreCanPurchase = 32u;

	[Token(Token = "0x4011E0E")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<uint, uint> m_StoreRedPointThresholdDict;

	[Token(Token = "0x4011E0F")]
	private const string ExchangeStoreRedPointSwitchKey = "ExchangeStoreRedPointSwitch";

	[Token(Token = "0x4011E10")]
	public const string HasBigEventReunionOpened = "HasBigEventReunionOpened_";

	[Token(Token = "0x4011E11")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<BigEventEntryDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011E12")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<BigEventOpenInfoDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011E13")]
	[FieldOffset(Offset = "0x8")]
	private static Func<string> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4011E14")]
	[FieldOffset(Offset = "0xC")]
	private static Func<int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4011E15")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<BigEventStoreCommodityDesc> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x6013968")]
	[Address(RVA = "0x25F3DB8", Offset = "0x25F3DB8", VA = "0x25F3DB8")]
	public UIModelBigEvent()
	{
	}

	[Token(Token = "0x6013969")]
	[Address(RVA = "0x25F41C8", Offset = "0x25F41C8", VA = "0x25F41C8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601396A")]
	[Address(RVA = "0x25F4220", Offset = "0x25F4220", VA = "0x25F4220")]
	public List<BigEventEntryDesc> GetEventAutoEntryDesc()
	{
		return null;
	}

	[Token(Token = "0x601396B")]
	[Address(RVA = "0x25F436C", Offset = "0x25F436C", VA = "0x25F436C")]
	public void ProcessExchangeTipsDesc(CSGetExchangeCurrencyLocalRes res)
	{
	}

	[Token(Token = "0x601396C")]
	[Address(RVA = "0x25F4758", Offset = "0x25F4758", VA = "0x25F4758", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601396D")]
	[Address(RVA = "0x25F4910", Offset = "0x25F4910", VA = "0x25F4910", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x601396E")]
	[Address(RVA = "0x25F4A64", Offset = "0x25F4A64", VA = "0x25F4A64", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601396F")]
	[Address(RVA = "0x25F4D3C", Offset = "0x25F4D3C", VA = "0x25F4D3C")]
	public void RequestEventInventorySetting(uint bigEventID)
	{
	}

	[Token(Token = "0x6013970")]
	[Address(RVA = "0x25F5000", Offset = "0x25F5000", VA = "0x25F5000")]
	public void RequestEventInventoryInfo(uint bigEventID)
	{
	}

	[Token(Token = "0x6013971")]
	[Address(RVA = "0x25F52A8", Offset = "0x25F52A8", VA = "0x25F52A8")]
	public void RequestGetBigEventOpenInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013972")]
	[Address(RVA = "0x25F5514", Offset = "0x25F5514", VA = "0x25F5514")]
	public List<int> GetAllValidBigEventId()
	{
		return null;
	}

	[Token(Token = "0x6013973")]
	[Address(RVA = "0x25F5654", Offset = "0x25F5654", VA = "0x25F5654")]
	private void ProcessAllEventOpenInfo(CSGetLimitedEventOpenInfoRes eventOpenInfo)
	{
	}

	[Token(Token = "0x6013974")]
	[Address(RVA = "0x25F76BC", Offset = "0x25F76BC", VA = "0x25F76BC")]
	private void PrecessAllEventCDNSetting(CSGetLimitedEventOpenInfoRes eventOpenInfo)
	{
	}

	[Token(Token = "0x6013975")]
	[Address(RVA = "0x25F79D0", Offset = "0x25F79D0", VA = "0x25F79D0")]
	private void ProcessAllEventMovies(List<BigEventMovieDesc> eventMovieDescList)
	{
	}

	[Token(Token = "0x6013976")]
	[Address(RVA = "0x25F6964", Offset = "0x25F6964", VA = "0x25F6964")]
	private void ProcessAllEventEntrances(List<BigEventEntranceSettingDesc> eventEntrances)
	{
	}

	[Token(Token = "0x6013977")]
	[Address(RVA = "0x25F6E28", Offset = "0x25F6E28", VA = "0x25F6E28")]
	public IBigEventModel GetBigEventModelById(int eventId)
	{
		return null;
	}

	[Token(Token = "0x6013978")]
	[Address(RVA = "0x25F6F10", Offset = "0x25F6F10", VA = "0x25F6F10")]
	private void TraveseOpenInfoDic()
	{
	}

	[Token(Token = "0x6013979")]
	[Address(RVA = "0x25F7E28", Offset = "0x25F7E28", VA = "0x25F7E28")]
	public void RequestClaimLimitedEventSettleReward(uint eventID, string key)
	{
	}

	[Token(Token = "0x601397A")]
	[Address(RVA = "0x25F80F0", Offset = "0x25F80F0", VA = "0x25F80F0")]
	public EBigEventEntranceState GetBigEventEntranceStateByTwoType(ELimitedEvent.EventID event_id, EBigEventEntranceID entrance_id)
	{
		return default(EBigEventEntranceState);
	}

	[Token(Token = "0x601397B")]
	[Address(RVA = "0x25F840C", Offset = "0x25F840C", VA = "0x25F840C")]
	public BigEventEntranceSettingDesc GetBigEventEntranceDescByTwoType(ELimitedEvent.EventID event_id, EBigEventEntranceID entrance_id)
	{
		return null;
	}

	[Token(Token = "0x601397C")]
	[Address(RVA = "0x25F85E4", Offset = "0x25F85E4", VA = "0x25F85E4")]
	public List<BigEventOpenInfoDesc> GetEventOpenInfoListById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	[Token(Token = "0x601397D")]
	[Address(RVA = "0x25F86CC", Offset = "0x25F86CC", VA = "0x25F86CC")]
	public List<BigEventCDNDesc> GetCDNSettingListById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	[Token(Token = "0x601397E")]
	[Address(RVA = "0x25F4284", Offset = "0x25F4284", VA = "0x25F4284")]
	public List<BigEventEntryDesc> GetBigEventEntryDescsById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	[Token(Token = "0x601397F")]
	[Address(RVA = "0x25F87B4", Offset = "0x25F87B4", VA = "0x25F87B4")]
	public BigEventMovieDesc GetBigEventMovieUrlById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	[Token(Token = "0x6013980")]
	[Address(RVA = "0x25F8898", Offset = "0x25F8898", VA = "0x25F8898")]
	public string GetEventCDNUrlByEventIDAndType(ELimitedEvent.EventID id, int type)
	{
		return null;
	}

	[Token(Token = "0x6013981")]
	[Address(RVA = "0x25F7BF4", Offset = "0x25F7BF4", VA = "0x25F7BF4")]
	public ELimitedEvent.EventState GetBigEventStateById(ELimitedEvent.EventID eventID)
	{
		return default(ELimitedEvent.EventState);
	}

	[Token(Token = "0x6013982")]
	[Address(RVA = "0x25F6CBC", Offset = "0x25F6CBC", VA = "0x25F6CBC")]
	public BigEventOpenInfoDesc GetEventOpenInfoByIdAndState(ELimitedEvent.EventID eventID, ELimitedEvent.EventState state)
	{
		return null;
	}

	[Token(Token = "0x6013983")]
	[Address(RVA = "0x25F8AC8", Offset = "0x25F8AC8", VA = "0x25F8AC8")]
	public string GetBigEventEntryDataTitle(BigEventEntryDesc DescData)
	{
		return null;
	}

	[Token(Token = "0x6013984")]
	[Address(RVA = "0x25F8E94", Offset = "0x25F8E94", VA = "0x25F8E94")]
	public BigEventOpenInfoDesc GetEventAutoEntryOpenInfo()
	{
		return null;
	}

	[Token(Token = "0x6013985")]
	[Address(RVA = "0x25F8EFC", Offset = "0x25F8EFC", VA = "0x25F8EFC")]
	public BigEventOpenInfoDesc GetEventProcessOpenInfo()
	{
		return null;
	}

	[Token(Token = "0x6013986")]
	[Address(RVA = "0x25F8F64", Offset = "0x25F8F64", VA = "0x25F8F64")]
	public ELimitedEvent.EventID GetEventAutoEntryId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x6013987")]
	[Address(RVA = "0x25F8FBC", Offset = "0x25F8FBC", VA = "0x25F8FBC")]
	public string GetBigEventEntrancePeriod(ELimitedEvent.EventID eventID, EBigEventEntranceID entranceID)
	{
		return null;
	}

	[Token(Token = "0x6013988")]
	[Address(RVA = "0x25F91E8", Offset = "0x25F91E8", VA = "0x25F91E8")]
	public string GetBigEventOpenPeriod(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	[Token(Token = "0x6013989")]
	[Address(RVA = "0x25F9514", Offset = "0x25F9514", VA = "0x25F9514")]
	public void ChangeNotify(BigEventEntryDesc entryDesc, bool state)
	{
	}

	[Token(Token = "0x601398A")]
	[Address(RVA = "0x25F9D38", Offset = "0x25F9D38", VA = "0x25F9D38")]
	private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, BigEventEntryDesc entryDesc)
	{
		return null;
	}

	[Token(Token = "0x601398B")]
	[Address(RVA = "0x25F4988", Offset = "0x25F4988", VA = "0x25F4988")]
	private void ResetScheduleNotifications()
	{
	}

	[Token(Token = "0x601398C")]
	[Address(RVA = "0x25FA1A0", Offset = "0x25FA1A0", VA = "0x25FA1A0")]
	public uint GetTokenCount(uint tokenId)
	{
		return default(uint);
	}

	[Token(Token = "0x601398D")]
	[Address(RVA = "0x25FA2DC", Offset = "0x25FA2DC", VA = "0x25FA2DC")]
	public ResourceID GetTokenIconRes(uint tokenId)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601398E")]
	[Address(RVA = "0x25F6674", Offset = "0x25F6674", VA = "0x25F6674")]
	public void RequestTokenTipsDesc(ELimitedEvent.EventID eventID)
	{
	}

	[Token(Token = "0x601398F")]
	[Address(RVA = "0x25FA434", Offset = "0x25FA434", VA = "0x25FA434")]
	public List<BigEventTokenTipsDesc> GetTokenTipsDescs(uint tokenId)
	{
		return null;
	}

	[Token(Token = "0x6013990")]
	[Address(RVA = "0x25FA518", Offset = "0x25FA518", VA = "0x25FA518")]
	public List<TokenTipsData> GetTokenTipsDataList(uint Id)
	{
		return null;
	}

	[Token(Token = "0x6013991")]
	[Address(RVA = "0x25FAD9C", Offset = "0x25FAD9C", VA = "0x25FAD9C")]
	public void RequestExchangeStoreData(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType)
	{
	}

	[Token(Token = "0x6013992")]
	[Address(RVA = "0x25FB2E4", Offset = "0x25FB2E4", VA = "0x25FB2E4")]
	public void SortExchangeStoreItemList(List<BigEventStoreCommodityDesc> storeItemList)
	{
	}

	[Token(Token = "0x6013993")]
	[Address(RVA = "0x25FB430", Offset = "0x25FB430", VA = "0x25FB430")]
	public bool IsExchangeStoreHasRedPoint(ELimitedEvent.EventID eventID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013994")]
	[Address(RVA = "0x25FB62C", Offset = "0x25FB62C", VA = "0x25FB62C")]
	public bool IsExchangeStoreHasRedPoint(ELimitedEvent.EventID eventID, uint storeId)
	{
		return default(bool);
	}

	[Token(Token = "0x6013995")]
	[Address(RVA = "0x25FBAC4", Offset = "0x25FBAC4", VA = "0x25FBAC4")]
	public void SetExchangeStoreRedPointSwitch(ELimitedEvent.EventID eventID, int value)
	{
	}

	[Token(Token = "0x6013996")]
	[Address(RVA = "0x25FBC24", Offset = "0x25FBC24", VA = "0x25FBC24")]
	public bool IsExchangeStoreRedPointSwitchOpen(ELimitedEvent.EventID eventID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013997")]
	[Address(RVA = "0x25FBD88", Offset = "0x25FBD88", VA = "0x25FBD88")]
	public void UpdateExchangeStoreOpenValue(ELimitedEvent.EventID eventID, uint storeId)
	{
	}

	[Token(Token = "0x6013998")]
	[Address(RVA = "0x25FC018", Offset = "0x25FC018", VA = "0x25FC018")]
	public bool IsExchangeStoreNewOpen(ELimitedEvent.EventID eventID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013999")]
	[Address(RVA = "0x25FB1FC", Offset = "0x25FB1FC", VA = "0x25FB1FC")]
	public List<LimitedEventStore> GetExchangeStoreDataListById(ELimitedEvent.EventID eventID)
	{
		return null;
	}

	[Token(Token = "0x601399A")]
	[Address(RVA = "0x25FB928", Offset = "0x25FB928", VA = "0x25FB928")]
	public LimitedEventStore GetExchangeStoreDataById(ELimitedEvent.EventID eventID, uint storeId)
	{
		return null;
	}

	[Token(Token = "0x601399B")]
	[Address(RVA = "0x25FC398", Offset = "0x25FC398", VA = "0x25FC398")]
	public void RequestExchangeStorePurchase(ELimitedEvent.EventID eventID, ELimitedEvent.StoreType storeType, BigEventStoreCommodityDesc desc, bool useCommonReward = true, uint cnt = 1u)
	{
	}

	[Token(Token = "0x601399C")]
	[Address(RVA = "0x25FCA64", Offset = "0x25FCA64", VA = "0x25FCA64")]
	public void RequestAccountAFKGroupInfo(bool force = false)
	{
	}

	[Token(Token = "0x601399D")]
	[Address(RVA = "0x25FCD64", Offset = "0x25FCD64", VA = "0x25FCD64")]
	public void RequestAFKGroupInfo(ulong groupID, bool filter = true)
	{
	}

	[Token(Token = "0x601399E")]
	[Address(RVA = "0x25FD038", Offset = "0x25FD038", VA = "0x25FD038")]
	public void RequestCreateAFKGroup()
	{
	}

	[Token(Token = "0x601399F")]
	[Address(RVA = "0x25FD25C", Offset = "0x25FD25C", VA = "0x25FD25C")]
	public void RequestJoinAFKGroup(ulong groupID, ELimitedEvent.GoliathGroupJoinSource source, bool isInvitedByShare = false)
	{
	}

	[Token(Token = "0x60139A0")]
	[Address(RVA = "0x25FD560", Offset = "0x25FD560", VA = "0x25FD560")]
	public void RequestCaptainActivity()
	{
	}

	[Token(Token = "0x60139A1")]
	[Address(RVA = "0x25FD808", Offset = "0x25FD808", VA = "0x25FD808")]
	public void ClaimAFKGroupAwards(ulong groupID, ulong captainID)
	{
	}

	[Token(Token = "0x60139A2")]
	[Address(RVA = "0x25FDADC", Offset = "0x25FDADC", VA = "0x25FDADC")]
	public Dictionary<ulong, GoliathAFKGroupInfo> GetAllAFKGroupInfo()
	{
		return null;
	}

	[Token(Token = "0x60139A3")]
	[Address(RVA = "0x25FDB34", Offset = "0x25FDB34", VA = "0x25FDB34")]
	public ulong GetAFKGroupInAdvanceStartTime(ulong groupID)
	{
		return default(ulong);
	}

	[Token(Token = "0x60139A4")]
	[Address(RVA = "0x25FDC70", Offset = "0x25FDC70", VA = "0x25FDC70")]
	public void NotifyAFKGroupInfoUpdate(ulong groupID)
	{
	}

	[Token(Token = "0x60139A5")]
	[Address(RVA = "0x25FDF84", Offset = "0x25FDF84", VA = "0x25FDF84")]
	public uint GetCaptainActivityID()
	{
		return default(uint);
	}

	[Token(Token = "0x60139A6")]
	[Address(RVA = "0x25FDFDC", Offset = "0x25FDFDC", VA = "0x25FDFDC")]
	public EActivity.State GetCaptainActivityState()
	{
		return default(EActivity.State);
	}

	[Token(Token = "0x60139A7")]
	[Address(RVA = "0x25FE110", Offset = "0x25FE110", VA = "0x25FE110")]
	public bool CheckAFKFriendInviteable(ulong friendId)
	{
		return default(bool);
	}

	[Token(Token = "0x60139A8")]
	[Address(RVA = "0x25FE2A4", Offset = "0x25FE2A4", VA = "0x25FE2A4")]
	public void SetAFKFriendInviteCD(ulong friendId)
	{
	}

	[Token(Token = "0x60139A9")]
	[Address(RVA = "0x25FE3D8", Offset = "0x25FE3D8", VA = "0x25FE3D8")]
	public string GetBigEventPeakDayPeriod(EActivity.SubType subType)
	{
		return null;
	}

	[Token(Token = "0x60139AA")]
	[Address(RVA = "0x25FE908", Offset = "0x25FE908", VA = "0x25FE908")]
	public EPeakDayState GetBigEventPeakDayState(EActivity.SubType subType)
	{
		return default(EPeakDayState);
	}

	[Token(Token = "0x60139AB")]
	[Address(RVA = "0x25FEA44", Offset = "0x25FEA44", VA = "0x25FEA44")]
	public EPeakDayState GetBigEventPeakDayState(ClientActivityDesc desc)
	{
		return default(EPeakDayState);
	}

	[Token(Token = "0x60139AC")]
	[Address(RVA = "0x25FECA4", Offset = "0x25FECA4", VA = "0x25FECA4")]
	public bool IsBigEventActivityFinished(EEventType activityType, EActivity.SubType subType)
	{
		return default(bool);
	}

	[Token(Token = "0x60139AD")]
	[Address(RVA = "0x25FEFD0", Offset = "0x25FEFD0", VA = "0x25FEFD0")]
	public bool HasBigEventReunionOpenedThisVersion()
	{
		return default(bool);
	}

	[Token(Token = "0x60139AE")]
	[Address(RVA = "0x25FF348", Offset = "0x25FF348", VA = "0x25FF348")]
	public void OpenBigEventReunionThisVersion()
	{
	}

	[Token(Token = "0x60139AF")]
	[Address(RVA = "0x25FF6C4", Offset = "0x25FF6C4", VA = "0x25FF6C4")]
	public BigEventBadgeDesc GetEventInventorySettingByID(uint bigEventID, uint itemID)
	{
		return null;
	}

	[Token(Token = "0x60139B0")]
	[Address(RVA = "0x25FF848", Offset = "0x25FF848", VA = "0x25FF848")]
	public LimitedEventBadge GetEventInventoryInfoByID(uint bigEventID, uint itemID)
	{
		return null;
	}

	[Token(Token = "0x60139B1")]
	[Address(RVA = "0x25FFA4C", Offset = "0x25FFA4C", VA = "0x25FFA4C")]
	private void _003CRequestGetBigEventOpenInfo_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60139B2")]
	[Address(RVA = "0x2600008", Offset = "0x2600008", VA = "0x2600008")]
	private static int _003CProcessAllEventOpenInfo_003Em__1(BigEventEntryDesc a, BigEventEntryDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x60139B3")]
	[Address(RVA = "0x2600080", Offset = "0x2600080", VA = "0x2600080")]
	private static bool _003CGetBigEventOpenPeriod_003Em__2(BigEventOpenInfoDesc item)
	{
		return default(bool);
	}

	[Token(Token = "0x60139B4")]
	[Address(RVA = "0x26000B0", Offset = "0x26000B0", VA = "0x26000B0")]
	private static string _003CGetNotifyInfo_003Em__3()
	{
		return null;
	}

	[Token(Token = "0x60139B5")]
	[Address(RVA = "0x2600188", Offset = "0x2600188", VA = "0x2600188")]
	private static int _003CGetNotifyInfo_003Em__4()
	{
		return default(int);
	}

	[Token(Token = "0x60139B6")]
	[Address(RVA = "0x260021C", Offset = "0x260021C", VA = "0x260021C")]
	private static int _003CSortExchangeStoreItemList_003Em__5(BigEventStoreCommodityDesc x, BigEventStoreCommodityDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60139B7")]
	[Address(RVA = "0x260051C", Offset = "0x260051C", VA = "0x260051C")]
	private void _003CRequestAccountAFKGroupInfo_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60139B8")]
	[Address(RVA = "0x2600938", Offset = "0x2600938", VA = "0x2600938")]
	private void _003CRequestCreateAFKGroup_003Em__7(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60139B9")]
	[Address(RVA = "0x2600CE4", Offset = "0x2600CE4", VA = "0x2600CE4")]
	private void _003CRequestCaptainActivity_003Em__8(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60139BA")]
	[Address(RVA = "0x2600E14", Offset = "0x2600E14", VA = "0x2600E14")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60139BB")]
	[Address(RVA = "0x2600E1C", Offset = "0x2600E1C", VA = "0x2600E1C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60139BC")]
	[Address(RVA = "0x2600E24", Offset = "0x2600E24", VA = "0x2600E24")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
