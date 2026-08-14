using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003198")]
public class UIModelNewPlayer : UIBaseModel
{
	[Token(Token = "0x2003199")]
	private sealed class _003CRequestClaimFreshReward_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012DB2")]
		[FieldOffset(Offset = "0x8")]
		internal uint day;

		[Token(Token = "0x4012DB3")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelNewPlayer _0024this;

		[Token(Token = "0x6014D96")]
		[Address(RVA = "0x1781B18", Offset = "0x1781B18", VA = "0x1781B18")]
		public _003CRequestClaimFreshReward_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014D97")]
		[Address(RVA = "0x1782320", Offset = "0x1782320", VA = "0x1782320")]
		internal void _003C_003Em__0(HttpErrorCode err, object res)
		{
		}
	}

	[Token(Token = "0x200319A")]
	private sealed class _003CRequestClaimFreshActivityRewards_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012DB4")]
		[FieldOffset(Offset = "0x8")]
		internal uint activityId;

		[Token(Token = "0x4012DB5")]
		[FieldOffset(Offset = "0xC")]
		internal bool is_daily;

		[Token(Token = "0x4012DB6")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelNewPlayer _0024this;

		[Token(Token = "0x6014D98")]
		[Address(RVA = "0x1781B20", Offset = "0x1781B20", VA = "0x1781B20")]
		public _003CRequestClaimFreshActivityRewards_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014D99")]
		[Address(RVA = "0x17820BC", Offset = "0x17820BC", VA = "0x17820BC")]
		internal void _003C_003Em__0(HttpErrorCode err, object res)
		{
		}
	}

	[Token(Token = "0x4012D9F")]
	public const uint PropID_GetAttendanceReward = 2u;

	[Token(Token = "0x4012DA0")]
	public const uint PropID_GetMissionTodayReward = 4u;

	[Token(Token = "0x4012DA1")]
	public const uint PropID_GetMissionReward = 8u;

	[Token(Token = "0x4012DA2")]
	public const uint PropID_ActivityUpdate = 16u;

	[Token(Token = "0x4012DA3")]
	public const uint PropID_FreshInfo = 32u;

	[Token(Token = "0x4012DA4")]
	public const uint PropID_ShowBubble = 64u;

	[Token(Token = "0x4012DA5")]
	public const uint PropID_MissionUpdate = 128u;

	[Token(Token = "0x4012DA6")]
	private const int TOTAL_MISSIONS = 5;

	[Token(Token = "0x4012DA7")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, ActivityInfo> m_DictActivityInfo;

	[Token(Token = "0x4012DA8")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, FreshRewardItem> m_DictFreshAwardItem;

	[Token(Token = "0x4012DA9")]
	[FieldOffset(Offset = "0x14")]
	private int[] _003CRestAward_003Ek__BackingField;

	[Token(Token = "0x4012DAA")]
	[FieldOffset(Offset = "0x18")]
	private int[] _003CRestMissions_003Ek__BackingField;

	[Token(Token = "0x4012DAB")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003CUnlockDay_003Ek__BackingField;

	[Token(Token = "0x4012DAC")]
	[FieldOffset(Offset = "0x20")]
	private ulong _003CExpireTimestamp_003Ek__BackingField;

	[Token(Token = "0x4012DAD")]
	[FieldOffset(Offset = "0x28")]
	private bool _003CIsNewPlayer_003Ek__BackingField;

	[Token(Token = "0x4012DAE")]
	[FieldOffset(Offset = "0x2C")]
	private int _003CTotalDays_003Ek__BackingField;

	[Token(Token = "0x4012DAF")]
	[FieldOffset(Offset = "0x30")]
	private bool _003CHasFreshInfo_003Ek__BackingField;

	[Token(Token = "0x4012DB0")]
	[FieldOffset(Offset = "0x34")]
	private bool[] _003CGuideRewardClaimed_003Ek__BackingField;

	[Token(Token = "0x4012DB1")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastReward;

	[Token(Token = "0x170015EA")]
	public int[] RestAward
	{
		[Token(Token = "0x6014D70")]
		[Address(RVA = "0x177F704", Offset = "0x177F704", VA = "0x177F704")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014D71")]
		[Address(RVA = "0x177F70C", Offset = "0x177F70C", VA = "0x177F70C")]
		private set
		{
		}
	}

	[Token(Token = "0x170015EB")]
	public int[] RestMissions
	{
		[Token(Token = "0x6014D72")]
		[Address(RVA = "0x177F714", Offset = "0x177F714", VA = "0x177F714")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014D73")]
		[Address(RVA = "0x177F71C", Offset = "0x177F71C", VA = "0x177F71C")]
		private set
		{
		}
	}

	[Token(Token = "0x170015EC")]
	public uint UnlockDay
	{
		[Token(Token = "0x6014D74")]
		[Address(RVA = "0x177F724", Offset = "0x177F724", VA = "0x177F724")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014D75")]
		[Address(RVA = "0x177F72C", Offset = "0x177F72C", VA = "0x177F72C")]
		private set
		{
		}
	}

	[Token(Token = "0x170015ED")]
	public ulong ExpireTimestamp
	{
		[Token(Token = "0x6014D76")]
		[Address(RVA = "0x177F734", Offset = "0x177F734", VA = "0x177F734")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014D77")]
		[Address(RVA = "0x177F73C", Offset = "0x177F73C", VA = "0x177F73C")]
		private set
		{
		}
	}

	[Token(Token = "0x170015EE")]
	public bool IsNewPlayer
	{
		[Token(Token = "0x6014D78")]
		[Address(RVA = "0x177F74C", Offset = "0x177F74C", VA = "0x177F74C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014D79")]
		[Address(RVA = "0x177F754", Offset = "0x177F754", VA = "0x177F754")]
		private set
		{
		}
	}

	[Token(Token = "0x170015EF")]
	public int TotalDays
	{
		[Token(Token = "0x6014D7A")]
		[Address(RVA = "0x177F75C", Offset = "0x177F75C", VA = "0x177F75C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014D7B")]
		[Address(RVA = "0x177F764", Offset = "0x177F764", VA = "0x177F764")]
		private set
		{
		}
	}

	[Token(Token = "0x170015F0")]
	public bool HasFreshInfo
	{
		[Token(Token = "0x6014D7C")]
		[Address(RVA = "0x177F76C", Offset = "0x177F76C", VA = "0x177F76C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014D7D")]
		[Address(RVA = "0x177F774", Offset = "0x177F774", VA = "0x177F774")]
		private set
		{
		}
	}

	[Token(Token = "0x170015F1")]
	public bool[] GuideRewardClaimed
	{
		[Token(Token = "0x6014D7E")]
		[Address(RVA = "0x177F77C", Offset = "0x177F77C", VA = "0x177F77C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014D7F")]
		[Address(RVA = "0x177F784", Offset = "0x177F784", VA = "0x177F784")]
		private set
		{
		}
	}

	[Token(Token = "0x170015F2")]
	public bool AwardedAllSevenDays
	{
		[Token(Token = "0x6014D80")]
		[Address(RVA = "0x177F78C", Offset = "0x177F78C", VA = "0x177F78C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6014D6E")]
	[Address(RVA = "0x177F5C0", Offset = "0x177F5C0", VA = "0x177F5C0")]
	public UIModelNewPlayer()
	{
	}

	[Token(Token = "0x6014D6F")]
	[Address(RVA = "0x177F6AC", Offset = "0x177F6AC", VA = "0x177F6AC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014D81")]
	[Address(RVA = "0x177F944", Offset = "0x177F944", VA = "0x177F944", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014D82")]
	[Address(RVA = "0x177F9B4", Offset = "0x177F9B4", VA = "0x177F9B4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014D83")]
	[Address(RVA = "0x177FAD4", Offset = "0x177FAD4", VA = "0x177FAD4")]
	public void UpdateActivities(List<FreshActivityUpdateInfo> infos)
	{
	}

	[Token(Token = "0x6014D84")]
	[Address(RVA = "0x17809CC", Offset = "0x17809CC", VA = "0x17809CC")]
	public string[] GetAllTabName()
	{
		return null;
	}

	[Token(Token = "0x6014D85")]
	[Address(RVA = "0x177FFE4", Offset = "0x177FFE4", VA = "0x177FFE4")]
	private void SetRestAwardsAndMissions()
	{
	}

	[Token(Token = "0x6014D86")]
	[Address(RVA = "0x177F7EC", Offset = "0x177F7EC", VA = "0x177F7EC")]
	private bool IsAwardedAllSevenDays()
	{
		return default(bool);
	}

	[Token(Token = "0x6014D87")]
	[Address(RVA = "0x17805AC", Offset = "0x17805AC", VA = "0x17805AC")]
	private bool CheckUnlockDayAwardedNum()
	{
		return default(bool);
	}

	[Token(Token = "0x6014D88")]
	[Address(RVA = "0x1780C7C", Offset = "0x1780C7C", VA = "0x1780C7C")]
	public int GetDefaultSelectIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6014D89")]
	[Address(RVA = "0x1780CDC", Offset = "0x1780CDC", VA = "0x1780CDC")]
	public uint GetAttendanceItemByIndex(int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6014D8A")]
	[Address(RVA = "0x1780EB8", Offset = "0x1780EB8", VA = "0x1780EB8")]
	public uint GetMissionTodayItemByIndex(int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6014D8B")]
	[Address(RVA = "0x1781054", Offset = "0x1781054", VA = "0x1781054")]
	public ActivityInfo GetMissionById(uint activityId)
	{
		return null;
	}

	[Token(Token = "0x6014D8C")]
	[Address(RVA = "0x1781138", Offset = "0x1781138", VA = "0x1781138")]
	public FreshRewardItem GetAttendanceConfigByDay(uint day)
	{
		return null;
	}

	[Token(Token = "0x6014D8D")]
	[Address(RVA = "0x178121C", Offset = "0x178121C", VA = "0x178121C")]
	public void ClaimAttendanceReward(uint day)
	{
	}

	[Token(Token = "0x6014D8E")]
	[Address(RVA = "0x1781528", Offset = "0x1781528", VA = "0x1781528")]
	public void ClaimMissionTodayReward(uint activityId)
	{
	}

	[Token(Token = "0x6014D8F")]
	[Address(RVA = "0x1781874", Offset = "0x1781874", VA = "0x1781874")]
	public void ClaimMissionReward(uint activityId)
	{
	}

	[Token(Token = "0x6014D90")]
	[Address(RVA = "0x17818E4", Offset = "0x17818E4", VA = "0x17818E4")]
	public void RequestAccountFreshInfo(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014D91")]
	[Address(RVA = "0x1781288", Offset = "0x1781288", VA = "0x1781288")]
	public void RequestClaimFreshReward(uint day)
	{
	}

	[Token(Token = "0x6014D92")]
	[Address(RVA = "0x1781598", Offset = "0x1781598", VA = "0x1781598")]
	public void RequestClaimFreshActivityRewards(uint activityId, bool is_daily = false)
	{
	}

	[Token(Token = "0x6014D93")]
	[Address(RVA = "0x1781B28", Offset = "0x1781B28", VA = "0x1781B28")]
	private void _003CRequestAccountFreshInfo_003Em__0(HttpErrorCode err, object res)
	{
	}

	[Token(Token = "0x6014D94")]
	[Address(RVA = "0x17820AC", Offset = "0x17820AC", VA = "0x17820AC")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014D95")]
	[Address(RVA = "0x17820B4", Offset = "0x17820B4", VA = "0x17820B4")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
