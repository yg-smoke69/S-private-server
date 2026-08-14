using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DD2")]
internal class ElitePassDataManager : SingletonModule<ElitePassDataManager>, _Attribute
{
	[Token(Token = "0x2002DD3")]
	private sealed class _003COnDataChanged_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011995")]
		[FieldOffset(Offset = "0x8")]
		internal List<BaseItemInfo> awardList;

		[Token(Token = "0x601339A")]
		[Address(RVA = "0x25270A8", Offset = "0x25270A8", VA = "0x25270A8")]
		public _003COnDataChanged_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601339B")]
		[Address(RVA = "0x252F5EC", Offset = "0x252F5EC", VA = "0x252F5EC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002DD4")]
	private sealed class _003COnDataChanged_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011996")]
		[FieldOffset(Offset = "0x8")]
		internal uint questId;

		[Token(Token = "0x601339C")]
		[Address(RVA = "0x25270B0", Offset = "0x25270B0", VA = "0x25270B0")]
		public _003COnDataChanged_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601339D")]
		[Address(RVA = "0x252F714", Offset = "0x252F714", VA = "0x252F714")]
		internal bool _003C_003Em__0(EPWeeklyQuestInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x601339E")]
		[Address(RVA = "0x252F760", Offset = "0x252F760", VA = "0x252F760")]
		internal bool _003C_003Em__1(EPMonthlyQuestInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DD5")]
	private sealed class _003COnDataChanged_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011997")]
		[FieldOffset(Offset = "0x8")]
		internal uint boxId;

		[Token(Token = "0x601339F")]
		[Address(RVA = "0x25270B8", Offset = "0x25270B8", VA = "0x25270B8")]
		public _003COnDataChanged_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60133A0")]
		[Address(RVA = "0x252F7AC", Offset = "0x252F7AC", VA = "0x252F7AC")]
		internal bool _003C_003Em__0(EPWeeklyRewardInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DD6")]
	private sealed class _003CUpdateEPWeeklyRewardStatus_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011998")]
		[FieldOffset(Offset = "0x8")]
		internal List<EPWeeklyQuestRewardData> dataLst;

		[Token(Token = "0x60133A1")]
		[Address(RVA = "0x252AEA8", Offset = "0x252AEA8", VA = "0x252AEA8")]
		public _003CUpdateEPWeeklyRewardStatus_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x2002DD7")]
	private sealed class _003CUpdateEPWeeklyRewardStatus_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011999")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x401199A")]
		[FieldOffset(Offset = "0xC")]
		internal _003CUpdateEPWeeklyRewardStatus_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x60133A2")]
		[Address(RVA = "0x252AEB0", Offset = "0x252AEB0", VA = "0x252AEB0")]
		public _003CUpdateEPWeeklyRewardStatus_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60133A3")]
		[Address(RVA = "0x252F7F8", Offset = "0x252F7F8", VA = "0x252F7F8")]
		internal bool _003C_003Em__0(WeeklyProcessStatus e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DD8")]
	private sealed class _003CAwardInfoByUnlockID_003Ec__AnonStorey5
	{
		[Token(Token = "0x401199B")]
		[FieldOffset(Offset = "0x8")]
		internal uint unlockID;

		[Token(Token = "0x60133A4")]
		[Address(RVA = "0x252CD68", Offset = "0x252CD68", VA = "0x252CD68")]
		public _003CAwardInfoByUnlockID_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60133A5")]
		[Address(RVA = "0x252F4BC", Offset = "0x252F4BC", VA = "0x252F4BC")]
		internal bool _003C_003Em__0(EPAwardInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DD9")]
	private sealed class _003CGetEPPlayerEffect_003Ec__AnonStorey6
	{
		[Token(Token = "0x401199C")]
		[FieldOffset(Offset = "0x8")]
		internal string region;

		[Token(Token = "0x60133A6")]
		[Address(RVA = "0x252E81C", Offset = "0x252E81C", VA = "0x252E81C")]
		public _003CGetEPPlayerEffect_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60133A7")]
		[Address(RVA = "0x252F508", Offset = "0x252F508", VA = "0x252F508")]
		internal bool _003C_003Em__0(EPInGameEffectConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011973")]
	[FieldOffset(Offset = "0xC")]
	private EPEventSettingData m_CurEPSettingInfo;

	[Token(Token = "0x4011974")]
	[FieldOffset(Offset = "0x10")]
	private EPUpdateData m_EPUpdateEntrance;

	[Token(Token = "0x4011975")]
	public const int EPDebrisExchangeRate = 10000;

	[Token(Token = "0x4011976")]
	[FieldOffset(Offset = "0x14")]
	public List<EPAwardInfo> AwardInfoList;

	[Token(Token = "0x4011977")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<byte, List<EPChallengeInfo>> ChallengeList;

	[Token(Token = "0x4011978")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<byte, List<EPChallengeInfo>> SpecialChallengeList;

	[Token(Token = "0x4011979")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, ChallengeStatus> ChallengeStatusChache;

	[Token(Token = "0x401197A")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<byte, List<uint>> newUnlockedSpecialChallengeIds;

	[Token(Token = "0x401197B")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<uint, EPDailyRewardInfo> EPDailyRewardDic;

	[Token(Token = "0x401197C")]
	[FieldOffset(Offset = "0x2C")]
	public List<EPDailyQuestInfo> EPDailyQuestLst;

	[Token(Token = "0x401197D")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<uint, List<EPWeeklyQuestInfo>> EPWeeklyQuestDic;

	[Token(Token = "0x401197E")]
	[FieldOffset(Offset = "0x34")]
	public Dictionary<int, int> EPWeeklyQuestTipsCntDic;

	[Token(Token = "0x401197F")]
	[FieldOffset(Offset = "0x38")]
	public List<EPMonthlyQuestInfo> EPMonthlyQuestLst;

	[Token(Token = "0x4011980")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, uint> EPDailyTaskFinishCntCache;

	[Token(Token = "0x4011981")]
	[FieldOffset(Offset = "0x40")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x4011982")]
	[FieldOffset(Offset = "0x44")]
	private UIModelElitePass m_ModelElitePass;

	[Token(Token = "0x4011983")]
	[FieldOffset(Offset = "0x48")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x4011984")]
	[FieldOffset(Offset = "0x4C")]
	private uint LastClaimedRewardID;

	[Token(Token = "0x4011985")]
	[FieldOffset(Offset = "0x50")]
	public string SHOW_NEWEP_GUIDE;

	[Token(Token = "0x4011986")]
	public const string NEW_EP_CHALLENGE_TAB_REDDOT = "NEW_EP_CHALLENGE_TAB_REDDOT";

	[Token(Token = "0x4011987")]
	public const string EP_WEEK_TAB_GUIDE = "EP_WEEK_TAB_GUIDE";

	[Token(Token = "0x4011988")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, List<EPWeeklyRewardInfo>> EPWeeklyRewardDic;

	[Token(Token = "0x4011989")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, bool> EPWeeklyTablockDic;

	[Token(Token = "0x401198A")]
	[FieldOffset(Offset = "0x5C")]
	private string HAS_AUTO_SHOW_SUBSCRIBEWINDOW;

	[Token(Token = "0x401198B")]
	[FieldOffset(Offset = "0x60")]
	private uint m_CacheRewardCnt;

	[Token(Token = "0x401198C")]
	[FieldOffset(Offset = "0x64")]
	public Dictionary<uint, uint> EPDailyTaskLastGameFinishCntCache;

	[Token(Token = "0x401198D")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401198E")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x401198F")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4011990")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<EPAwardInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4011991")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<EPChallengeInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4011992")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<EPAwardInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4011993")]
	[FieldOffset(Offset = "0x18")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4011994")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<EPInGameEffectConfigData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x170013F0")]
	public EPEventSettingData CurEPSettingInfo
	{
		[Token(Token = "0x6013357")]
		[Address(RVA = "0x2522444", Offset = "0x2522444", VA = "0x2522444")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F1")]
	public EPUpdateData EPUpdateEntrance
	{
		[Token(Token = "0x6013358")]
		[Address(RVA = "0x252249C", Offset = "0x252249C", VA = "0x252249C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F2")]
	public bool ElitePassEnabled
	{
		[Token(Token = "0x6013359")]
		[Address(RVA = "0x25224F4", Offset = "0x25224F4", VA = "0x25224F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6013356")]
	[Address(RVA = "0x2522120", Offset = "0x2522120", VA = "0x2522120")]
	public ElitePassDataManager()
	{
	}

	[Token(Token = "0x601335A")]
	[Address(RVA = "0x252254C", Offset = "0x252254C", VA = "0x252254C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601335B")]
	[Address(RVA = "0x2522D4C", Offset = "0x2522D4C", VA = "0x2522D4C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601335C")]
	[Address(RVA = "0x2522DA0", Offset = "0x2522DA0", VA = "0x2522DA0", Slot = "10")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601335D")]
	[Address(RVA = "0x2526228", Offset = "0x2526228", VA = "0x2526228")]
	private void UpdateBadgeItemCount(bool isTcpNoti = false)
	{
	}

	[Token(Token = "0x601335E")]
	[Address(RVA = "0x2526910", Offset = "0x2526910", VA = "0x2526910")]
	private void UpdateFromServerEPInfo(Dictionary<uint, List<RewardStatus>> RewardStatus, Dictionary<uint, ChallengeStatus> ChallengeStatus, Dictionary<uint, DailyQuestRewardsStatus> DailyQuestRewardStatus, Dictionary<uint, List<WeeklyProcessStatus>> WeeklyQuestRewardStatus)
	{
	}

	[Token(Token = "0x601335F")]
	[Address(RVA = "0x25282B4", Offset = "0x25282B4", VA = "0x25282B4")]
	private void UpdateEPUnlockStatus(Dictionary<uint, List<RewardStatus>> RewardStatus)
	{
	}

	[Token(Token = "0x6013360")]
	[Address(RVA = "0x2528658", Offset = "0x2528658", VA = "0x2528658")]
	private void UpdateEPChallengeStatus()
	{
	}

	[Token(Token = "0x6013361")]
	[Address(RVA = "0x2528A84", Offset = "0x2528A84", VA = "0x2528A84")]
	private void UpdateEPDailyRewardStatus(Dictionary<uint, DailyQuestRewardsStatus> DailyQuestRewardStatus)
	{
	}

	[Token(Token = "0x6013362")]
	[Address(RVA = "0x252A5A4", Offset = "0x252A5A4", VA = "0x252A5A4")]
	private void UpdateEPWeeklyRewardStatus(Dictionary<uint, List<WeeklyProcessStatus>> WeeklyQuestRewardStatus)
	{
	}

	[Token(Token = "0x6013363")]
	[Address(RVA = "0x252AEB8", Offset = "0x252AEB8", VA = "0x252AEB8")]
	public List<EPWeeklyRewardInfo> GetEPWeeklyRewardByWeekId(uint weekid)
	{
		return null;
	}

	[Token(Token = "0x6013364")]
	[Address(RVA = "0x2529100", Offset = "0x2529100", VA = "0x2529100")]
	private void UpdateEPDailyQuestStatus()
	{
	}

	[Token(Token = "0x6013365")]
	[Address(RVA = "0x2529C74", Offset = "0x2529C74", VA = "0x2529C74")]
	private void UpdateEPMonthlyQuestStatus()
	{
	}

	[Token(Token = "0x6013366")]
	[Address(RVA = "0x25293E0", Offset = "0x25293E0", VA = "0x25293E0")]
	private void UpdateEPWeeklyQuestStatus()
	{
	}

	[Token(Token = "0x6013367")]
	[Address(RVA = "0x252A00C", Offset = "0x252A00C", VA = "0x252A00C")]
	private void UpdateEPWeeklyQuestlockStatus()
	{
	}

	[Token(Token = "0x6013368")]
	[Address(RVA = "0x252B5C4", Offset = "0x252B5C4", VA = "0x252B5C4")]
	public bool HasWeekChallengeAward(int week)
	{
		return default(bool);
	}

	[Token(Token = "0x6013369")]
	[Address(RVA = "0x252B7F8", Offset = "0x252B7F8", VA = "0x252B7F8")]
	public bool HasWeeklyBoxReward(uint weekId)
	{
		return default(bool);
	}

	[Token(Token = "0x601336A")]
	[Address(RVA = "0x252B44C", Offset = "0x252B44C", VA = "0x252B44C")]
	private EPWeeklyQuestInfo CreateWeeklyQuestInfo(EPWeeklyQuestData data)
	{
		return null;
	}

	[Token(Token = "0x601336B")]
	[Address(RVA = "0x252AFAC", Offset = "0x252AFAC", VA = "0x252AFAC")]
	private EPDailyQuestInfo CreateDailyQuestInfo(EPDailyQuestData data)
	{
		return null;
	}

	[Token(Token = "0x601336C")]
	[Address(RVA = "0x252B2D4", Offset = "0x252B2D4", VA = "0x252B2D4")]
	private EPMonthlyQuestInfo CreateMonthlyQuestInfo(EPMonthlyQuestData data)
	{
		return null;
	}

	[Token(Token = "0x601336D")]
	[Address(RVA = "0x252C140", Offset = "0x252C140", VA = "0x252C140")]
	private EPChallengeInfo CreateChallengeInfo(EPChallengeData data)
	{
		return null;
	}

	[Token(Token = "0x601336E")]
	[Address(RVA = "0x252ACD8", Offset = "0x252ACD8", VA = "0x252ACD8")]
	private void ProcessChallengeInfo(EPChallengeData data, Dictionary<int, uint> completedCountDic)
	{
	}

	[Token(Token = "0x601336F")]
	[Address(RVA = "0x252C2B8", Offset = "0x252C2B8", VA = "0x252C2B8")]
	public bool NeedShowNewVersionEPGuide()
	{
		return default(bool);
	}

	[Token(Token = "0x6013370")]
	[Address(RVA = "0x2527E18", Offset = "0x2527E18", VA = "0x2527E18")]
	private void UpdateAwardInfoLocal()
	{
	}

	[Token(Token = "0x6013371")]
	[Address(RVA = "0x252C4D4", Offset = "0x252C4D4", VA = "0x252C4D4", Slot = "11")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6013372")]
	[Address(RVA = "0x2526F7C", Offset = "0x2526F7C", VA = "0x2526F7C")]
	public List<EPChallengeInfo> ChallengeListByType(ChallengeType type)
	{
		return null;
	}

	[Token(Token = "0x6013373")]
	[Address(RVA = "0x252C58C", Offset = "0x252C58C", VA = "0x252C58C")]
	public bool HasChallengeToAwardByType(ChallengeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6013374")]
	[Address(RVA = "0x252C624", Offset = "0x252C624", VA = "0x252C624")]
	private bool CheckAwardForChallengeList(List<EPChallengeInfo> infoList)
	{
		return default(bool);
	}

	[Token(Token = "0x6013375")]
	[Address(RVA = "0x25278F8", Offset = "0x25278F8", VA = "0x25278F8")]
	public bool HasNewTipsReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6013376")]
	[Address(RVA = "0x252C8E4", Offset = "0x252C8E4", VA = "0x252C8E4")]
	public bool HasUnclaimedMaxReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6013377")]
	[Address(RVA = "0x2527A54", Offset = "0x2527A54", VA = "0x2527A54")]
	public bool HasNewTipsChallenge()
	{
		return default(bool);
	}

	[Token(Token = "0x6013378")]
	[Address(RVA = "0x2527CA4", Offset = "0x2527CA4", VA = "0x2527CA4")]
	public bool HasNewUnlockedTipsChallenge()
	{
		return default(bool);
	}

	[Token(Token = "0x6013379")]
	[Address(RVA = "0x252CC30", Offset = "0x252CC30", VA = "0x252CC30")]
	public bool HasNewUnlockedTipsChallengeForType(ChallengeType cType)
	{
		return default(bool);
	}

	[Token(Token = "0x601337A")]
	[Address(RVA = "0x2526AC4", Offset = "0x2526AC4", VA = "0x2526AC4")]
	public EPAwardInfo AwardInfoByUnlockID(uint unlockID)
	{
		return null;
	}

	[Token(Token = "0x601337B")]
	[Address(RVA = "0x252CD70", Offset = "0x252CD70", VA = "0x252CD70")]
	public void UpdateChallengeStatus(ulong[] completeList)
	{
	}

	[Token(Token = "0x601337C")]
	[Address(RVA = "0x252D0D8", Offset = "0x252D0D8", VA = "0x252D0D8")]
	public List<EPChallengeInfo> UnlockedSpecialChallengeList(ChallengeType cType)
	{
		return null;
	}

	[Token(Token = "0x601337D")]
	[Address(RVA = "0x252C7B4", Offset = "0x252C7B4", VA = "0x252C7B4")]
	public List<EPChallengeInfo> AllSpecialChallengeList(ChallengeType cType)
	{
		return null;
	}

	[Token(Token = "0x601337E")]
	[Address(RVA = "0x25270C0", Offset = "0x25270C0", VA = "0x25270C0")]
	public bool UpdateNewUnlockedSpecialChallengeList()
	{
		return default(bool);
	}

	[Token(Token = "0x601337F")]
	[Address(RVA = "0x252D354", Offset = "0x252D354", VA = "0x252D354")]
	public void ClearNewUnlockedSpecialChallengeIds(ChallengeType cType)
	{
	}

	[Token(Token = "0x6013380")]
	[Address(RVA = "0x252D4E4", Offset = "0x252D4E4", VA = "0x252D4E4")]
	private void CheckAndAskToUpgrade()
	{
	}

	[Token(Token = "0x6013381")]
	[Address(RVA = "0x252CAE8", Offset = "0x252CAE8", VA = "0x252CAE8")]
	public EPMaxRewardData CurMaxRewardData()
	{
		return null;
	}

	[Token(Token = "0x6013382")]
	[Address(RVA = "0x2526C08", Offset = "0x2526C08", VA = "0x2526C08")]
	public EPAwardInfo LastAwardInfo()
	{
		return null;
	}

	[Token(Token = "0x6013383")]
	[Address(RVA = "0x252DD58", Offset = "0x252DD58", VA = "0x252DD58")]
	public uint MaxRewardClaimedBadge()
	{
		return default(uint);
	}

	[Token(Token = "0x6013384")]
	[Address(RVA = "0x252DE30", Offset = "0x252DE30", VA = "0x252DE30")]
	public uint NextMaxRewardBadgeCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6013385")]
	[Address(RVA = "0x252DEA0", Offset = "0x252DEA0", VA = "0x252DEA0")]
	public uint NextMaxRewardToClaimBadgeNeeded()
	{
		return default(uint);
	}

	[Token(Token = "0x6013386")]
	[Address(RVA = "0x2526D40", Offset = "0x2526D40", VA = "0x2526D40")]
	public int MaxRewardBadgeStep()
	{
		return default(int);
	}

	[Token(Token = "0x6013387")]
	[Address(RVA = "0x2526DD4", Offset = "0x2526DD4", VA = "0x2526DD4")]
	public int ClaimedMaxRewardCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013388")]
	[Address(RVA = "0x2526EA4", Offset = "0x2526EA4", VA = "0x2526EA4")]
	public int CanClaimMaxRewardCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013389")]
	[Address(RVA = "0x252DF58", Offset = "0x252DF58", VA = "0x252DF58")]
	public int GetMaxRewardShouldShowCount(int BadgeAfter)
	{
		return default(int);
	}

	[Token(Token = "0x601338A")]
	[Address(RVA = "0x252E16C", Offset = "0x252E16C", VA = "0x252E16C")]
	public bool CanBadgeCntClaimAllBaseEPReward(uint badgeCnt)
	{
		return default(bool);
	}

	[Token(Token = "0x601338B")]
	[Address(RVA = "0x252E228", Offset = "0x252E228", VA = "0x252E228")]
	public ResourceID GetEPPlayerEffect()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601338C")]
	[Address(RVA = "0x252E824", Offset = "0x252E824", VA = "0x252E824")]
	public string GetAutoShowEPPreorderPrefKey()
	{
		return null;
	}

	[Token(Token = "0x601338D")]
	[Address(RVA = "0x252EA7C", Offset = "0x252EA7C", VA = "0x252EA7C")]
	public void GetEPWeekTabLockState(ref bool w1, ref bool w2, ref bool w3, ref bool w4)
	{
	}

	[Token(Token = "0x601338E")]
	[Address(RVA = "0x252EC08", Offset = "0x252EC08", VA = "0x252EC08")]
	public EEPTaskTab GetShouldShowGuideEPWeekTab()
	{
		return default(EEPTaskTab);
	}

	[Token(Token = "0x601338F")]
	[Address(RVA = "0x252EE6C", Offset = "0x252EE6C", VA = "0x252EE6C")]
	public void SetEPWeekTabGuide(int weekId)
	{
	}

	[Token(Token = "0x6013390")]
	[Address(RVA = "0x252EFF0", Offset = "0x252EFF0", VA = "0x252EFF0")]
	public bool HasNewEPTabKey()
	{
		return default(bool);
	}

	[Token(Token = "0x6013391")]
	[Address(RVA = "0x252F0D8", Offset = "0x252F0D8", VA = "0x252F0D8")]
	public int GetEPWeekChallengeClaimedCnt(uint weekId)
	{
		return default(int);
	}

	[Token(Token = "0x6013392")]
	[Address(RVA = "0x252F2C8", Offset = "0x252F2C8", VA = "0x252F2C8")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013393")]
	[Address(RVA = "0x252F2D0", Offset = "0x252F2D0", VA = "0x252F2D0")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__1(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013394")]
	[Address(RVA = "0x252F2D8", Offset = "0x252F2D8", VA = "0x252F2D8")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__2(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013395")]
	[Address(RVA = "0x252F2E0", Offset = "0x252F2E0", VA = "0x252F2E0")]
	private static bool _003CHasNewTipsReward_003Em__3(EPAwardInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013396")]
	[Address(RVA = "0x252F30C", Offset = "0x252F30C", VA = "0x252F30C")]
	private static int _003CUnlockedSpecialChallengeList_003Em__4(EPChallengeInfo a, EPChallengeInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013397")]
	[Address(RVA = "0x252F37C", Offset = "0x252F37C", VA = "0x252F37C")]
	private static int _003CCheckAndAskToUpgrade_003Em__5(EPAwardInfo a, EPAwardInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6013398")]
	[Address(RVA = "0x252F3EC", Offset = "0x252F3EC", VA = "0x252F3EC")]
	private static CommonRewardItemInfo _003CCheckAndAskToUpgrade_003Em__6(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013399")]
	[Address(RVA = "0x252F3F4", Offset = "0x252F3F4", VA = "0x252F3F4")]
	private static bool _003CGetEPPlayerEffect_003Em__7(EPInGameEffectConfigData e)
	{
		return default(bool);
	}
}
