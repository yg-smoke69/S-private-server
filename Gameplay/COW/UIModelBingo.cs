using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EEC")]
public class UIModelBingo : UIBaseModel
{
	[Token(Token = "0x2002EED")]
	public enum BingoDifficulty
	{
		[Token(Token = "0x4011EEE")]
		None,
		[Token(Token = "0x4011EEF")]
		Low,
		[Token(Token = "0x4011EF0")]
		Middle,
		[Token(Token = "0x4011EF1")]
		High
	}

	[Token(Token = "0x2002EEE")]
	public enum BingoCardState
	{
		[Token(Token = "0x4011EF3")]
		Lock,
		[Token(Token = "0x4011EF4")]
		UnDone,
		[Token(Token = "0x4011EF5")]
		DoneNoFlip,
		[Token(Token = "0x4011EF6")]
		Fliped
	}

	[Token(Token = "0x2002EEF")]
	public enum RewardState
	{
		[Token(Token = "0x4011EF8")]
		UnReceive,
		[Token(Token = "0x4011EF9")]
		Receive
	}

	[Token(Token = "0x2002EF0")]
	public class BingoCard
	{
		[Token(Token = "0x4011EFA")]
		[FieldOffset(Offset = "0x8")]
		public int uniqueID;

		[Token(Token = "0x4011EFB")]
		[FieldOffset(Offset = "0xC")]
		public int row;

		[Token(Token = "0x4011EFC")]
		[FieldOffset(Offset = "0x10")]
		public int colum;

		[Token(Token = "0x4011EFD")]
		[FieldOffset(Offset = "0x14")]
		public BingoDifficulty difficulty;

		[Token(Token = "0x4011EFE")]
		[FieldOffset(Offset = "0x18")]
		public BingoCard NextCard;

		[Token(Token = "0x4011EFF")]
		[FieldOffset(Offset = "0x1C")]
		private BingoCardState state;

		[Token(Token = "0x4011F00")]
		[FieldOffset(Offset = "0x20")]
		public uint taskID;

		[Token(Token = "0x1700146B")]
		public BingoCardState State
		{
			[Token(Token = "0x6013A90")]
			[Address(RVA = "0x32C629C", Offset = "0x32C629C", VA = "0x32C629C")]
			get
			{
				return default(BingoCardState);
			}
			[Token(Token = "0x6013A91")]
			[Address(RVA = "0x32C5FB4", Offset = "0x32C5FB4", VA = "0x32C5FB4")]
			set
			{
			}
		}

		[Token(Token = "0x6013A8F")]
		[Address(RVA = "0x32C628C", Offset = "0x32C628C", VA = "0x32C628C")]
		public BingoCard()
		{
		}

		[Token(Token = "0x6013A92")]
		[Address(RVA = "0x32C64CC", Offset = "0x32C64CC", VA = "0x32C64CC")]
		public bool IsCurrentTaskDone()
		{
			return default(bool);
		}

		[Token(Token = "0x6013A93")]
		[Address(RVA = "0x32C6614", Offset = "0x32C6614", VA = "0x32C6614")]
		public void Init()
		{
		}
	}

	[Token(Token = "0x2002EF1")]
	private sealed class _003CRequestFlipCard_003Ec__AnonStorey0
	{
		[Token(Token = "0x2002EF2")]
		private sealed class _003CRequestFlipCard_003Ec__AnonStorey1
		{
			[Token(Token = "0x4011F05")]
			[FieldOffset(Offset = "0x8")]
			internal List<BaseItemInfo> awardList;

			[Token(Token = "0x4011F06")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestFlipCard_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

			[Token(Token = "0x6013A98")]
			[Address(RVA = "0x32C5FAC", Offset = "0x32C5FAC", VA = "0x32C5FAC")]
			public _003CRequestFlipCard_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x6013A99")]
			[Address(RVA = "0x32C6064", Offset = "0x32C6064", VA = "0x32C6064")]
			internal void _003C_003Em__0(AwardDesc e)
			{
			}
		}

		[Token(Token = "0x4011F01")]
		[FieldOffset(Offset = "0x8")]
		internal BingoCard card;

		[Token(Token = "0x4011F02")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBingo _0024this;

		[Token(Token = "0x4011F03")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<ActivityBingoRewardsInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4011F04")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6013A94")]
		[Address(RVA = "0x32C551C", Offset = "0x32C551C", VA = "0x32C551C")]
		public _003CRequestFlipCard_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013A95")]
		[Address(RVA = "0x32C5524", Offset = "0x32C5524", VA = "0x32C5524")]
		internal void _003C_003Em__0(HttpErrorCode err, object res)
		{
		}

		[Token(Token = "0x6013A96")]
		[Address(RVA = "0x32C6014", Offset = "0x32C6014", VA = "0x32C6014")]
		private static int _003C_003Em__1(ActivityBingoRewardsInfo x, ActivityBingoRewardsInfo y)
		{
			return default(int);
		}

		[Token(Token = "0x6013A97")]
		[Address(RVA = "0x32C605C", Offset = "0x32C605C", VA = "0x32C605C")]
		private static CommonRewardItemInfo _003C_003Em__2(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002EF3")]
	private sealed class _003CRequestBingoReward_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011F07")]
		[FieldOffset(Offset = "0x8")]
		internal uint bingoID;

		[Token(Token = "0x4011F08")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBingo _0024this;

		[Token(Token = "0x4011F09")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013A9A")]
		[Address(RVA = "0x32C5130", Offset = "0x32C5130", VA = "0x32C5130")]
		public _003CRequestBingoReward_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013A9B")]
		[Address(RVA = "0x32C5138", Offset = "0x32C5138", VA = "0x32C5138")]
		internal void _003C_003Em__0(HttpErrorCode err, object res)
		{
		}

		[Token(Token = "0x6013A9C")]
		[Address(RVA = "0x32C5514", Offset = "0x32C5514", VA = "0x32C5514")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002EF4")]
	private sealed class _003CRequestQuickFinishTask_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011F0A")]
		[FieldOffset(Offset = "0x8")]
		internal CSFinishBingoActivityReq req;

		[Token(Token = "0x4011F0B")]
		[FieldOffset(Offset = "0xC")]
		internal BingoCard card;

		[Token(Token = "0x4011F0C")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelBingo _0024this;

		[Token(Token = "0x6013A9D")]
		[Address(RVA = "0x32C6120", Offset = "0x32C6120", VA = "0x32C6120")]
		public _003CRequestQuickFinishTask_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6013A9E")]
		[Address(RVA = "0x32C6128", Offset = "0x32C6128", VA = "0x32C6128")]
		internal void _003C_003Em__0(HttpErrorCode err, object res)
		{
		}
	}

	[Token(Token = "0x4011EDB")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, ActivityBingoRewardsDesc> m_BingoDesc;

	[Token(Token = "0x4011EDC")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, ActivityBingoRewardsInfo> m_BingoInfo;

	[Token(Token = "0x4011EDD")]
	[FieldOffset(Offset = "0x14")]
	private CSGetBingoRewardsInfoRes m_BingoInfoRes;

	[Token(Token = "0x4011EDE")]
	[FieldOffset(Offset = "0x18")]
	private bool m_BingoInfoDataInited;

	[Token(Token = "0x4011EDF")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, BingoCard> m_BingoCards;

	[Token(Token = "0x4011EE0")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, BingoCard> m_ActiveBingoCards;

	[Token(Token = "0x4011EE1")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, ActivityBingoRewardsDesc> m_ActiveBingoDesc;

	[Token(Token = "0x4011EE2")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, ClientActivityBingoInfoDesc> m_BingoDifficultyLevelInfo;

	[Token(Token = "0x4011EE3")]
	[FieldOffset(Offset = "0x2C")]
	private List<uint> m_Tasks;

	[Token(Token = "0x4011EE4")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, int> m_RewardIDLineIDMap;

	[Token(Token = "0x4011EE5")]
	[FieldOffset(Offset = "0x34")]
	private List<uint> m_QuickCompletedTasks;

	[Token(Token = "0x4011EE6")]
	public const int PropID_GetActivityBingoInfo = 2;

	[Token(Token = "0x4011EE7")]
	public const int PropID_FlipBingoCard = 4;

	[Token(Token = "0x4011EE8")]
	public const int PropID_BingoRewardGot = 8;

	[Token(Token = "0x4011EE9")]
	public const int PropID_QuickFinishTask = 16;

	[Token(Token = "0x4011EEA")]
	[FieldOffset(Offset = "0x38")]
	private List<int> m_RequestQueue;

	[Token(Token = "0x4011EEB")]
	[FieldOffset(Offset = "0x3C")]
	private int m_OpeningDifficultyLevelCountWhenRequestInfo;

	[Token(Token = "0x4011EEC")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700146A")]
	private int OpeningDifficultyLevelCount
	{
		[Token(Token = "0x6013A69")]
		[Address(RVA = "0x260FA10", Offset = "0x260FA10", VA = "0x260FA10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6013A68")]
	[Address(RVA = "0x260F424", Offset = "0x260F424", VA = "0x260F424")]
	public UIModelBingo()
	{
	}

	[Token(Token = "0x6013A6A")]
	[Address(RVA = "0x260FC4C", Offset = "0x260FC4C", VA = "0x260FC4C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013A6B")]
	[Address(RVA = "0x260FCA4", Offset = "0x260FCA4", VA = "0x260FCA4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013A6C")]
	[Address(RVA = "0x260FEF0", Offset = "0x260FEF0", VA = "0x260FEF0")]
	public bool HasDescCacheData()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A6D")]
	[Address(RVA = "0x260FFC0", Offset = "0x260FFC0", VA = "0x260FFC0")]
	public bool IsBingoInfoDataInited()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A6E")]
	[Address(RVA = "0x2610018", Offset = "0x2610018", VA = "0x2610018")]
	public bool IsInOpenPeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A6F")]
	[Address(RVA = "0x2610210", Offset = "0x2610210", VA = "0x2610210")]
	public CSSharedItemData Bingokey(BingoDifficulty difficulty)
	{
		return null;
	}

	[Token(Token = "0x6013A70")]
	[Address(RVA = "0x2610398", Offset = "0x2610398", VA = "0x2610398")]
	public int BingoKeyCount(BingoDifficulty difficulty)
	{
		return default(int);
	}

	[Token(Token = "0x6013A71")]
	[Address(RVA = "0x261054C", Offset = "0x261054C", VA = "0x261054C")]
	public void OnActivityBingoDesc(List<ClientActivityBingoInfoDesc> bingoDifficulyLevelDesc, List<ActivityBingoRewardsDesc> bingoDesc)
	{
	}

	[Token(Token = "0x6013A72")]
	[Address(RVA = "0x2610914", Offset = "0x2610914", VA = "0x2610914")]
	public void RequestBingoInfo(uint httpOption = 0u, bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013A73")]
	[Address(RVA = "0x2610BE4", Offset = "0x2610BE4", VA = "0x2610BE4")]
	private void BingoInfoDataProcess(CSGetBingoRewardsInfoRes bingoInfoRes)
	{
	}

	[Token(Token = "0x6013A74")]
	[Address(RVA = "0x26119F8", Offset = "0x26119F8", VA = "0x26119F8")]
	public void RequestFlipCard(BingoCard card)
	{
	}

	[Token(Token = "0x6013A75")]
	[Address(RVA = "0x2611D20", Offset = "0x2611D20", VA = "0x2611D20")]
	public void RequestBingoReward(uint bingoID)
	{
	}

	[Token(Token = "0x6013A76")]
	[Address(RVA = "0x2611FC0", Offset = "0x2611FC0", VA = "0x2611FC0")]
	public void RequestQuickFinishTask(BingoCard card, bool useDiamond = false)
	{
	}

	[Token(Token = "0x6013A77")]
	[Address(RVA = "0x26123D4", Offset = "0x26123D4", VA = "0x26123D4")]
	public void UpdateRedTips()
	{
	}

	[Token(Token = "0x6013A78")]
	[Address(RVA = "0x2611688", Offset = "0x2611688", VA = "0x2611688")]
	private uint GetBingoTask(uint bingoID, int index)
	{
		return default(uint);
	}

	[Token(Token = "0x6013A79")]
	[Address(RVA = "0x26125B8", Offset = "0x26125B8", VA = "0x26125B8")]
	public ActivityBingoRewardsDesc BingoDescOfLine(int line)
	{
		return null;
	}

	[Token(Token = "0x6013A7A")]
	[Address(RVA = "0x26126A0", Offset = "0x26126A0", VA = "0x26126A0")]
	public ActivityBingoRewardsDesc BingoDescOfDifficultyLevel(BingoDifficulty difficulty)
	{
		return null;
	}

	[Token(Token = "0x6013A7B")]
	[Address(RVA = "0x26127E0", Offset = "0x26127E0", VA = "0x26127E0")]
	public bool IsBingoRewardTaskFinished(ActivityBingoRewardsDesc bingoReward)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A7C")]
	[Address(RVA = "0x2612984", Offset = "0x2612984", VA = "0x2612984")]
	public BingoDifficulty DifficultyOfBingoReward(uint bingoRewardId)
	{
		return default(BingoDifficulty);
	}

	[Token(Token = "0x6013A7D")]
	[Address(RVA = "0x2612A08", Offset = "0x2612A08", VA = "0x2612A08")]
	public static int RowColumID(int row, int colum)
	{
		return default(int);
	}

	[Token(Token = "0x6013A7E")]
	[Address(RVA = "0x2612A70", Offset = "0x2612A70", VA = "0x2612A70")]
	public BingoCard GetDefaultCard(int row, int colum)
	{
		return null;
	}

	[Token(Token = "0x6013A7F")]
	[Address(RVA = "0x2612B74", Offset = "0x2612B74", VA = "0x2612B74")]
	public BingoCard FirstUnFinishCard()
	{
		return null;
	}

	[Token(Token = "0x6013A80")]
	[Address(RVA = "0x2612E3C", Offset = "0x2612E3C", VA = "0x2612E3C")]
	public bool AllCardCanFlip()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A81")]
	[Address(RVA = "0x261012C", Offset = "0x261012C", VA = "0x261012C")]
	public ClientActivityBingoInfoDesc BingoDifficultyLevelInfo(BingoDifficulty difficulty)
	{
		return null;
	}

	[Token(Token = "0x6013A82")]
	[Address(RVA = "0x2611910", Offset = "0x2611910", VA = "0x2611910")]
	public ActivityBingoRewardsInfo BingoRewardInfo(uint bingoID)
	{
		return null;
	}

	[Token(Token = "0x6013A83")]
	[Address(RVA = "0x261305C", Offset = "0x261305C", VA = "0x261305C")]
	public ActivityBingoRewardsDesc NextDifficultyBingoRewardDesc(uint bingoID)
	{
		return null;
	}

	[Token(Token = "0x6013A84")]
	[Address(RVA = "0x2613144", Offset = "0x2613144", VA = "0x2613144")]
	public void UpdateLineReward(int line, ActivityBingoRewardsDesc rewardDesc)
	{
	}

	[Token(Token = "0x6013A85")]
	[Address(RVA = "0x2611804", Offset = "0x2611804", VA = "0x2611804")]
	public int LineIDOfBingoReward(uint bingoId)
	{
		return default(int);
	}

	[Token(Token = "0x6013A86")]
	[Address(RVA = "0x261322C", Offset = "0x261322C", VA = "0x261322C")]
	public bool IsQuickCompleteKeyEnough(BingoCard card)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A87")]
	[Address(RVA = "0x26132E0", Offset = "0x26132E0", VA = "0x26132E0")]
	public bool IsTaskQuickCompleted(uint taskID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A88")]
	[Address(RVA = "0x26133AC", Offset = "0x26133AC", VA = "0x26133AC")]
	public bool IsAllDifficultyFliped()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A89")]
	[Address(RVA = "0x26135B0", Offset = "0x26135B0", VA = "0x26135B0")]
	public AwardData GetInitReceivedKeyData()
	{
		return null;
	}

	[Token(Token = "0x6013A8A")]
	[Address(RVA = "0x261361C", Offset = "0x261361C", VA = "0x261361C")]
	public void RemoveInitReceivedkeyData()
	{
	}

	[Token(Token = "0x6013A8B")]
	[Address(RVA = "0x2613684", Offset = "0x2613684", VA = "0x2613684")]
	public bool IsNeedRequestInfoForce()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A8C")]
	[Address(RVA = "0x26136F8", Offset = "0x26136F8", VA = "0x26136F8")]
	private void _003CRequestBingoInfo_003Em__0(HttpErrorCode err, object res)
	{
	}

	[Token(Token = "0x6013A8D")]
	[Address(RVA = "0x26138A4", Offset = "0x26138A4", VA = "0x26138A4")]
	private static bool _003CUpdateRedTips_003Em__1(uint e)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A8E")]
	[Address(RVA = "0x261399C", Offset = "0x261399C", VA = "0x261399C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
