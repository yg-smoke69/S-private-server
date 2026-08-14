using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003020")]
internal class UIModelElitePass : UIBaseModel
{
	[Token(Token = "0x2003021")]
	private class ElitePassSubscriptionDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4012583")]
		[FieldOffset(Offset = "0x0")]
		private static ElitePassSubscriptionDelegate _I;

		[Token(Token = "0x4012584")]
		[FieldOffset(Offset = "0x1C")]
		private string LastSubscribedProductIdentifier;

		[Token(Token = "0x170014FA")]
		public static ElitePassSubscriptionDelegate I
		{
			[Token(Token = "0x60142A7")]
			[Address(RVA = "0xFBE7DC", Offset = "0xFBE7DC", VA = "0xFBE7DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170014FB")]
		public override string Name
		{
			[Token(Token = "0x60142A8")]
			[Address(RVA = "0xFC41EC", Offset = "0xFC41EC", VA = "0xFC41EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60142A6")]
		[Address(RVA = "0xFC41E4", Offset = "0xFC41E4", VA = "0xFC41E4")]
		public ElitePassSubscriptionDelegate()
		{
		}

		[Token(Token = "0x60142A9")]
		[Address(RVA = "0xFC4290", Offset = "0xFC4290", VA = "0xFC4290", Slot = "13")]
		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x60142AA")]
		[Address(RVA = "0xFC449C", Offset = "0xFC449C", VA = "0xFC449C", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x60142AB")]
		[Address(RVA = "0xFC4810", Offset = "0xFC4810", VA = "0xFC4810")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x60142AC")]
		[Address(RVA = "0xFC4830", Offset = "0xFC4830", VA = "0xFC4830")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}
	}

	[Token(Token = "0x2003022")]
	private sealed class _003CGetDailyQuestRewards_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012585")]
		[FieldOffset(Offset = "0x8")]
		internal uint processId;

		[Token(Token = "0x4012586")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x60142AD")]
		[Address(RVA = "0xFB9BE4", Offset = "0xFB9BE4", VA = "0xFB9BE4")]
		public _003CGetDailyQuestRewards_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60142AE")]
		[Address(RVA = "0xFC3A4C", Offset = "0xFC3A4C", VA = "0xFC3A4C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003023")]
	private sealed class _003CClaimReward_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012587")]
		[FieldOffset(Offset = "0x8")]
		internal List<unlock> claimList;

		[Token(Token = "0x4012588")]
		[FieldOffset(Offset = "0xC")]
		internal bool isAutoClaim;

		[Token(Token = "0x4012589")]
		[FieldOffset(Offset = "0xD")]
		internal bool isMaxReward;

		[Token(Token = "0x401258A")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x60142AF")]
		[Address(RVA = "0xFBA0B0", Offset = "0xFBA0B0", VA = "0xFBA0B0")]
		public _003CClaimReward_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60142B0")]
		[Address(RVA = "0xFC377C", Offset = "0xFC377C", VA = "0xFC377C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003024")]
	private sealed class _003CPurchaseEP_003Ec__AnonStorey2
	{
		[Token(Token = "0x401258B")]
		[FieldOffset(Offset = "0x8")]
		internal bool isBundle;

		[Token(Token = "0x401258C")]
		[FieldOffset(Offset = "0xC")]
		internal uint before;

		[Token(Token = "0x401258D")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x60142B1")]
		[Address(RVA = "0xFBA6DC", Offset = "0xFBA6DC", VA = "0xFBA6DC")]
		public _003CPurchaseEP_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60142B2")]
		[Address(RVA = "0xFC402C", Offset = "0xFC402C", VA = "0xFC402C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003025")]
	private sealed class _003CPurchaseBadge_003Ec__AnonStorey3
	{
		[Token(Token = "0x401258E")]
		[FieldOffset(Offset = "0x8")]
		internal int count;

		[Token(Token = "0x401258F")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x4012590")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60142B3")]
		[Address(RVA = "0xFBB3E4", Offset = "0xFBB3E4", VA = "0xFBB3E4")]
		public _003CPurchaseBadge_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60142B4")]
		[Address(RVA = "0xFC3C38", Offset = "0xFC3C38", VA = "0xFC3C38")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60142B5")]
		[Address(RVA = "0xFC4024", Offset = "0xFC4024", VA = "0xFC4024")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003026")]
	private sealed class _003CClaimChallengeReward_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012591")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> challengeIDs;

		[Token(Token = "0x4012592")]
		[FieldOffset(Offset = "0xC")]
		internal ChallengeType challengeType;

		[Token(Token = "0x4012593")]
		[FieldOffset(Offset = "0x10")]
		internal uint challengeGroup;

		[Token(Token = "0x4012594")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x60142B6")]
		[Address(RVA = "0xFBB6F0", Offset = "0xFBB6F0", VA = "0xFBB6F0")]
		public _003CClaimChallengeReward_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60142B7")]
		[Address(RVA = "0xFC2FA4", Offset = "0xFC2FA4", VA = "0xFC2FA4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003027")]
	private sealed class _003CClaimQuestReward_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012595")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> questIDs;

		[Token(Token = "0x4012596")]
		[FieldOffset(Offset = "0xC")]
		internal EPQuestType type;

		[Token(Token = "0x4012597")]
		[FieldOffset(Offset = "0x10")]
		internal uint groupID;

		[Token(Token = "0x4012598")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x60142B8")]
		[Address(RVA = "0xFBB9FC", Offset = "0xFBB9FC", VA = "0xFBB9FC")]
		public _003CClaimQuestReward_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60142B9")]
		[Address(RVA = "0xFC3584", Offset = "0xFC3584", VA = "0xFC3584")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003028")]
	private sealed class _003CClaimEPWeeklyQuestReward_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012599")]
		[FieldOffset(Offset = "0x8")]
		internal uint weekId;

		[Token(Token = "0x401259A")]
		[FieldOffset(Offset = "0xC")]
		internal uint boxId;

		[Token(Token = "0x401259B")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelElitePass _0024this;

		[Token(Token = "0x401259C")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60142BA")]
		[Address(RVA = "0xFBBCE4", Offset = "0xFBBCE4", VA = "0xFBBCE4")]
		public _003CClaimEPWeeklyQuestReward_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60142BB")]
		[Address(RVA = "0xFC319C", Offset = "0xFC319C", VA = "0xFC319C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x60142BC")]
		[Address(RVA = "0xFC357C", Offset = "0xFC357C", VA = "0xFC357C")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003029")]
	private sealed class _003CGetCurChallengeChangeInfo_003Ec__AnonStorey7
	{
		[Token(Token = "0x401259D")]
		[FieldOffset(Offset = "0x8")]
		internal EPChallengesUpdateInfo item;

		[Token(Token = "0x60142BD")]
		[Address(RVA = "0xFC15AC", Offset = "0xFC15AC", VA = "0xFC15AC")]
		public _003CGetCurChallengeChangeInfo_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60142BE")]
		[Address(RVA = "0xFC3974", Offset = "0xFC3974", VA = "0xFC3974")]
		internal bool _003C_003Em__0(EPChallengeInfo d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200302A")]
	private sealed class _003CGetCurChallengeChangeInfo_003Ec__AnonStorey8
	{
		[Token(Token = "0x401259E")]
		[FieldOffset(Offset = "0x8")]
		internal EPChallengesUpdateInfo item;

		[Token(Token = "0x60142BF")]
		[Address(RVA = "0xFC17DC", Offset = "0xFC17DC", VA = "0xFC17DC")]
		public _003CGetCurChallengeChangeInfo_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60142C0")]
		[Address(RVA = "0xFC39E0", Offset = "0xFC39E0", VA = "0xFC39E0")]
		internal bool _003C_003Em__0(EPWeeklyQuestInfo d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401254A")]
	public const uint PropID_ElitePassInfoChange = 1u;

	[Token(Token = "0x401254B")]
	public const uint PropID_ElitePassUnlock = 2u;

	[Token(Token = "0x401254C")]
	public const uint PropID_ElitePassClaimedReward = 4u;

	[Token(Token = "0x401254D")]
	public const uint PropID_ElitePassClaimedBadge = 8u;

	[Token(Token = "0x401254E")]
	public const uint PropID_ElitePassVideo = 16u;

	[Token(Token = "0x401254F")]
	public const uint PropID_ElitePassSubscriptionUpdate = 32u;

	[Token(Token = "0x4012550")]
	public const uint PropID_ElitePassSubscribed = 64u;

	[Token(Token = "0x4012551")]
	public const uint PropID_ElitePassSpecialChallengeChange = 128u;

	[Token(Token = "0x4012552")]
	public const uint PropID_ElitePassSubscriptionBonusUpdate = 256u;

	[Token(Token = "0x4012553")]
	public const uint PropID_ElitePassClaimedDailyReward = 512u;

	[Token(Token = "0x4012554")]
	public const uint PropID_ElitePassClaimedQuestReward = 1024u;

	[Token(Token = "0x4012555")]
	public const uint PropID_ElitePassDocument = 2048u;

	[Token(Token = "0x4012556")]
	public const uint PropID_ElitePassWeeklyRewardClaimed = 4096u;

	[Token(Token = "0x4012557")]
	public const uint PropID_ElitePassDailyRewardClaimed = 8192u;

	[Token(Token = "0x4012558")]
	[FieldOffset(Offset = "0xC")]
	private uint m_CurEPEventID;

	[Token(Token = "0x4012559")]
	[FieldOffset(Offset = "0x10")]
	private uint m_CurEPEventBadgeItemID;

	[Token(Token = "0x401255A")]
	[FieldOffset(Offset = "0x14")]
	private uint _003CEPBadgeCount_003Ek__BackingField;

	[Token(Token = "0x401255B")]
	[FieldOffset(Offset = "0x18")]
	private uint m_EPDebrisCnt;

	[Token(Token = "0x401255C")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003CLastGameGotEPDebrisCache_003Ek__BackingField;

	[Token(Token = "0x401255D")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsEP;

	[Token(Token = "0x401255E")]
	[FieldOffset(Offset = "0x21")]
	private bool m_IsFPChallenge;

	[Token(Token = "0x401255F")]
	[FieldOffset(Offset = "0x24")]
	private uint m_CurFPChallengeItem;

	[Token(Token = "0x4012560")]
	[FieldOffset(Offset = "0x28")]
	private uint m_PurchaseBadgeCountToday;

	[Token(Token = "0x4012561")]
	[FieldOffset(Offset = "0x30")]
	private ulong m_CurEventEndTime;

	[Token(Token = "0x4012562")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_CustomizedDiscountStartTimeStamp;

	[Token(Token = "0x4012563")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_CustomizedDiscountEndTimeStamp;

	[Token(Token = "0x4012564")]
	[FieldOffset(Offset = "0x48")]
	private uint m_CustomizedDiscount;

	[Token(Token = "0x4012565")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_DailyResetTime;

	[Token(Token = "0x4012566")]
	[FieldOffset(Offset = "0x58")]
	private bool m_NeedShowChallengeInLobby;

	[Token(Token = "0x4012567")]
	[FieldOffset(Offset = "0x5C")]
	private uint _003CPreorderedEPID_003Ek__BackingField;

	[Token(Token = "0x4012568")]
	[FieldOffset(Offset = "0x60")]
	private ulong _003CPreorderStartTime_003Ek__BackingField;

	[Token(Token = "0x4012569")]
	[FieldOffset(Offset = "0x68")]
	private ulong _003CPreorderEndTime_003Ek__BackingField;

	[Token(Token = "0x401256A")]
	[FieldOffset(Offset = "0x70")]
	private uint _003CChallengeDate_003Ek__BackingField;

	[Token(Token = "0x401256B")]
	[FieldOffset(Offset = "0x74")]
	private string m_VideoUrlStr;

	[Token(Token = "0x401256C")]
	[FieldOffset(Offset = "0x78")]
	private uint _003CDailyChallengeCompleteCnt_003Ek__BackingField;

	[Token(Token = "0x401256D")]
	[FieldOffset(Offset = "0x7C")]
	private uint _003CEliteChallengeCompleteCnt_003Ek__BackingField;

	[Token(Token = "0x401256E")]
	[FieldOffset(Offset = "0x80")]
	private uint _003CVeteranChallengeCompleteCnt_003Ek__BackingField;

	[Token(Token = "0x401256F")]
	[FieldOffset(Offset = "0x84")]
	private bool _003CisPurchasedByBundle_003Ek__BackingField;

	[Token(Token = "0x4012570")]
	[FieldOffset(Offset = "0x85")]
	private bool _003CisEPPurchased_003Ek__BackingField;

	[Token(Token = "0x4012571")]
	[FieldOffset(Offset = "0x86")]
	private bool _003CisPurchasedBySubscribe_003Ek__BackingField;

	[Token(Token = "0x4012572")]
	[FieldOffset(Offset = "0x88")]
	private uint _003CMyPurchasedEPSeasonCount_003Ek__BackingField;

	[Token(Token = "0x4012573")]
	[FieldOffset(Offset = "0x8C")]
	private uint _003CMaxRewardClaimedBadge_003Ek__BackingField;

	[Token(Token = "0x4012574")]
	[FieldOffset(Offset = "0x90")]
	public uint HasFininshedDailyProcessNum;

	[Token(Token = "0x4012575")]
	[FieldOffset(Offset = "0x94")]
	public EPProcess_Status DailyProcessStatus;

	[Token(Token = "0x4012576")]
	[FieldOffset(Offset = "0x98")]
	public Dictionary<uint, uint> DailyProcessInfoDict;

	[Token(Token = "0x4012577")]
	[FieldOffset(Offset = "0x9C")]
	public List<EPDailyProcessRewardDesc> DailyProcessDescList;

	[Token(Token = "0x4012578")]
	[FieldOffset(Offset = "0xA0")]
	public List<ChallengesUpdateInfo> CurFinishChallengeInfoList;

	[Token(Token = "0x4012579")]
	[FieldOffset(Offset = "0xA4")]
	public List<ChallengesUpdateInfo> CurGoingChallengeInfoList;

	[Token(Token = "0x401257A")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_HasShowCurEPCG;

	[Token(Token = "0x401257B")]
	[FieldOffset(Offset = "0xAC")]
	private CSGetWeeklyProcessRewardsReq m_PendingGetWeeklyProcessRewardsReq;

	[Token(Token = "0x401257C")]
	[FieldOffset(Offset = "0xB0")]
	private ulong m_SubscribeStartTime;

	[Token(Token = "0x401257D")]
	[FieldOffset(Offset = "0xB8")]
	private ulong m_SubscribeEndTime;

	[Token(Token = "0x401257E")]
	private const string DEFAULT_REGION = "default";

	[Token(Token = "0x401257F")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_ProcessingSubscription;

	[Token(Token = "0x4012580")]
	[FieldOffset(Offset = "0xC1")]
	private bool? _003CSubscriptionBonusAvailable_003Ek__BackingField;

	[Token(Token = "0x4012581")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<EPDailyProcessRewardDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012582")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170014D8")]
	public uint CurEPEventID
	{
		[Token(Token = "0x6014234")]
		[Address(RVA = "0xFB86A4", Offset = "0xFB86A4", VA = "0xFB86A4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170014D9")]
	public uint CurEPEventBadgeItemID
	{
		[Token(Token = "0x6014235")]
		[Address(RVA = "0xFB86FC", Offset = "0xFB86FC", VA = "0xFB86FC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170014DA")]
	public uint EPBadgeCount
	{
		[Token(Token = "0x6014236")]
		[Address(RVA = "0xFB8754", Offset = "0xFB8754", VA = "0xFB8754")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014237")]
		[Address(RVA = "0xFB875C", Offset = "0xFB875C", VA = "0xFB875C")]
		set
		{
		}
	}

	[Token(Token = "0x170014DB")]
	public uint EPDebrisCnt
	{
		[Token(Token = "0x6014238")]
		[Address(RVA = "0xFB8764", Offset = "0xFB8764", VA = "0xFB8764")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014239")]
		[Address(RVA = "0xFB87BC", Offset = "0xFB87BC", VA = "0xFB87BC")]
		set
		{
		}
	}

	[Token(Token = "0x170014DC")]
	public uint LastGameGotEPDebrisCache
	{
		[Token(Token = "0x601423A")]
		[Address(RVA = "0xFB881C", Offset = "0xFB881C", VA = "0xFB881C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601423B")]
		[Address(RVA = "0xFB8824", Offset = "0xFB8824", VA = "0xFB8824")]
		set
		{
		}
	}

	[Token(Token = "0x170014DD")]
	public bool IsEP
	{
		[Token(Token = "0x601423C")]
		[Address(RVA = "0xFB882C", Offset = "0xFB882C", VA = "0xFB882C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014DE")]
	public bool IsFPChallenge
	{
		[Token(Token = "0x601423D")]
		[Address(RVA = "0xFB8884", Offset = "0xFB8884", VA = "0xFB8884")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014DF")]
	public uint CurFPChallengeItem
	{
		[Token(Token = "0x601423E")]
		[Address(RVA = "0xFB88DC", Offset = "0xFB88DC", VA = "0xFB88DC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170014E0")]
	public uint PurchaseBadgeCountToday
	{
		[Token(Token = "0x601423F")]
		[Address(RVA = "0xFB8934", Offset = "0xFB8934", VA = "0xFB8934")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170014E1")]
	public ulong CurEventEndTime
	{
		[Token(Token = "0x6014240")]
		[Address(RVA = "0xFB898C", Offset = "0xFB898C", VA = "0xFB898C")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170014E2")]
	public ulong CustomizedDiscountStartTimeStamp
	{
		[Token(Token = "0x6014241")]
		[Address(RVA = "0xFB89E4", Offset = "0xFB89E4", VA = "0xFB89E4")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170014E3")]
	public ulong CustomizedDiscountEndTimeStamp
	{
		[Token(Token = "0x6014242")]
		[Address(RVA = "0xFB8A3C", Offset = "0xFB8A3C", VA = "0xFB8A3C")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170014E4")]
	public uint CustomizedDiscount
	{
		[Token(Token = "0x6014243")]
		[Address(RVA = "0xFB8A94", Offset = "0xFB8A94", VA = "0xFB8A94")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170014E5")]
	public ulong DailyResetTime
	{
		[Token(Token = "0x6014244")]
		[Address(RVA = "0xFB8AEC", Offset = "0xFB8AEC", VA = "0xFB8AEC")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170014E6")]
	public bool NeedShowChallengeInLobby
	{
		[Token(Token = "0x6014245")]
		[Address(RVA = "0xFB8B44", Offset = "0xFB8B44", VA = "0xFB8B44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014246")]
		[Address(RVA = "0xFB8B9C", Offset = "0xFB8B9C", VA = "0xFB8B9C")]
		set
		{
		}
	}

	[Token(Token = "0x170014E7")]
	public uint PreorderedEPID
	{
		[Token(Token = "0x6014247")]
		[Address(RVA = "0xFB8BFC", Offset = "0xFB8BFC", VA = "0xFB8BFC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014248")]
		[Address(RVA = "0xFB8C04", Offset = "0xFB8C04", VA = "0xFB8C04")]
		private set
		{
		}
	}

	[Token(Token = "0x170014E8")]
	public ulong PreorderStartTime
	{
		[Token(Token = "0x6014249")]
		[Address(RVA = "0xFB8C0C", Offset = "0xFB8C0C", VA = "0xFB8C0C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601424A")]
		[Address(RVA = "0xFB8C14", Offset = "0xFB8C14", VA = "0xFB8C14")]
		private set
		{
		}
	}

	[Token(Token = "0x170014E9")]
	public ulong PreorderEndTime
	{
		[Token(Token = "0x601424B")]
		[Address(RVA = "0xFB8C24", Offset = "0xFB8C24", VA = "0xFB8C24")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601424C")]
		[Address(RVA = "0xFB8C2C", Offset = "0xFB8C2C", VA = "0xFB8C2C")]
		private set
		{
		}
	}

	[Token(Token = "0x170014EA")]
	public uint ChallengeDate
	{
		[Token(Token = "0x601424D")]
		[Address(RVA = "0xFB8C3C", Offset = "0xFB8C3C", VA = "0xFB8C3C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601424E")]
		[Address(RVA = "0xFB8C44", Offset = "0xFB8C44", VA = "0xFB8C44")]
		private set
		{
		}
	}

	[Token(Token = "0x170014EB")]
	public string VideoUrlStr
	{
		[Token(Token = "0x601424F")]
		[Address(RVA = "0xFB8C4C", Offset = "0xFB8C4C", VA = "0xFB8C4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170014EC")]
	public uint DailyChallengeCompleteCnt
	{
		[Token(Token = "0x6014250")]
		[Address(RVA = "0xFB8CA4", Offset = "0xFB8CA4", VA = "0xFB8CA4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014251")]
		[Address(RVA = "0xFB8CAC", Offset = "0xFB8CAC", VA = "0xFB8CAC")]
		private set
		{
		}
	}

	[Token(Token = "0x170014ED")]
	public uint EliteChallengeCompleteCnt
	{
		[Token(Token = "0x6014252")]
		[Address(RVA = "0xFB8CB4", Offset = "0xFB8CB4", VA = "0xFB8CB4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014253")]
		[Address(RVA = "0xFB8CBC", Offset = "0xFB8CBC", VA = "0xFB8CBC")]
		private set
		{
		}
	}

	[Token(Token = "0x170014EE")]
	public uint VeteranChallengeCompleteCnt
	{
		[Token(Token = "0x6014254")]
		[Address(RVA = "0xFB8CC4", Offset = "0xFB8CC4", VA = "0xFB8CC4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014255")]
		[Address(RVA = "0xFB8CCC", Offset = "0xFB8CCC", VA = "0xFB8CCC")]
		private set
		{
		}
	}

	[Token(Token = "0x170014EF")]
	public bool isPurchasedByBundle
	{
		[Token(Token = "0x6014256")]
		[Address(RVA = "0xFB8CD4", Offset = "0xFB8CD4", VA = "0xFB8CD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014257")]
		[Address(RVA = "0xFB8CDC", Offset = "0xFB8CDC", VA = "0xFB8CDC")]
		private set
		{
		}
	}

	[Token(Token = "0x170014F0")]
	public bool isEPPurchased
	{
		[Token(Token = "0x6014258")]
		[Address(RVA = "0xFB8CE4", Offset = "0xFB8CE4", VA = "0xFB8CE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014259")]
		[Address(RVA = "0xFB8CEC", Offset = "0xFB8CEC", VA = "0xFB8CEC")]
		set
		{
		}
	}

	[Token(Token = "0x170014F1")]
	public bool isPurchasedBySubscribe
	{
		[Token(Token = "0x601425A")]
		[Address(RVA = "0xFB8CF4", Offset = "0xFB8CF4", VA = "0xFB8CF4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601425B")]
		[Address(RVA = "0xFB8CFC", Offset = "0xFB8CFC", VA = "0xFB8CFC")]
		set
		{
		}
	}

	[Token(Token = "0x170014F2")]
	public uint MyPurchasedEPSeasonCount
	{
		[Token(Token = "0x601425C")]
		[Address(RVA = "0xFB8D04", Offset = "0xFB8D04", VA = "0xFB8D04")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601425D")]
		[Address(RVA = "0xFB8D0C", Offset = "0xFB8D0C", VA = "0xFB8D0C")]
		set
		{
		}
	}

	[Token(Token = "0x170014F3")]
	public uint MaxRewardClaimedBadge
	{
		[Token(Token = "0x601425E")]
		[Address(RVA = "0xFB8D14", Offset = "0xFB8D14", VA = "0xFB8D14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601425F")]
		[Address(RVA = "0xFB8D1C", Offset = "0xFB8D1C", VA = "0xFB8D1C")]
		set
		{
		}
	}

	[Token(Token = "0x170014F4")]
	public bool IsFirstOpenCurEP
	{
		[Token(Token = "0x6014263")]
		[Address(RVA = "0xFB9230", Offset = "0xFB9230", VA = "0xFB9230")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014264")]
		[Address(RVA = "0xFB9288", Offset = "0xFB9288", VA = "0xFB9288")]
		set
		{
		}
	}

	[Token(Token = "0x170014F5")]
	public bool PreorderSubscriptionEnabled
	{
		[Token(Token = "0x601427B")]
		[Address(RVA = "0xFBCBF4", Offset = "0xFBCBF4", VA = "0xFBCBF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014F6")]
	public bool PlayerCanSubscribeForPreorder
	{
		[Token(Token = "0x601427C")]
		[Address(RVA = "0xFBCF3C", Offset = "0xFBCF3C", VA = "0xFBCF3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170014F7")]
	public ulong SubscribeStartTime
	{
		[Token(Token = "0x601427D")]
		[Address(RVA = "0xFBD454", Offset = "0xFBD454", VA = "0xFBD454")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601427E")]
		[Address(RVA = "0xFBD560", Offset = "0xFBD560", VA = "0xFBD560")]
		private set
		{
		}
	}

	[Token(Token = "0x170014F8")]
	public ulong SubscribeEndTime
	{
		[Token(Token = "0x601427F")]
		[Address(RVA = "0xFBD5DC", Offset = "0xFBD5DC", VA = "0xFBD5DC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014280")]
		[Address(RVA = "0xFBD6E8", Offset = "0xFBD6E8", VA = "0xFBD6E8")]
		private set
		{
		}
	}

	[Token(Token = "0x170014F9")]
	public bool? SubscriptionBonusAvailable
	{
		[Token(Token = "0x601428D")]
		[Address(RVA = "0xFBF06C", Offset = "0xFBF06C", VA = "0xFBF06C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601428E")]
		[Address(RVA = "0xFBCBEC", Offset = "0xFBCBEC", VA = "0xFBCBEC")]
		private set
		{
		}
	}

	[Token(Token = "0x6014233")]
	[Address(RVA = "0xFB8524", Offset = "0xFB8524", VA = "0xFB8524")]
	public UIModelElitePass()
	{
	}

	[Token(Token = "0x6014260")]
	[Address(RVA = "0xFB8D24", Offset = "0xFB8D24", VA = "0xFB8D24", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014261")]
	[Address(RVA = "0xFB8D7C", Offset = "0xFB8D7C", VA = "0xFB8D7C")]
	public void GetEPEventInfoFromServer(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014262")]
	[Address(RVA = "0xFB8FB0", Offset = "0xFB8FB0", VA = "0xFB8FB0")]
	public void ClaimDailyProcessRewardByNodeID(uint nodeID)
	{
	}

	[Token(Token = "0x6014265")]
	[Address(RVA = "0xFB92E8", Offset = "0xFB92E8", VA = "0xFB92E8")]
	public bool IsEntranceOpen(EEpEntrance type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014266")]
	[Address(RVA = "0xFB9478", Offset = "0xFB9478", VA = "0xFB9478")]
	public void ActiveEpCard()
	{
	}

	[Token(Token = "0x6014267")]
	[Address(RVA = "0xFB94E4", Offset = "0xFB94E4", VA = "0xFB94E4")]
	public void GetEPDebrisRewardLastMatch()
	{
	}

	[Token(Token = "0x6014268")]
	[Address(RVA = "0xFB9538", Offset = "0xFB9538", VA = "0xFB9538")]
	public void GetEPVideoUrlFromServer()
	{
	}

	[Token(Token = "0x6014269")]
	[Address(RVA = "0xFB982C", Offset = "0xFB982C", VA = "0xFB982C")]
	public bool IsNextEPPreorder()
	{
		return default(bool);
	}

	[Token(Token = "0x601426A")]
	[Address(RVA = "0xFB9944", Offset = "0xFB9944", VA = "0xFB9944")]
	public void GetDailyQuestRewards(uint processId)
	{
	}

	[Token(Token = "0x601426B")]
	[Address(RVA = "0xFB9BEC", Offset = "0xFB9BEC", VA = "0xFB9BEC")]
	public void ClaimReward(uint unlockID, bool isEP, bool isMaxReward = false)
	{
	}

	[Token(Token = "0x601426C")]
	[Address(RVA = "0xFB9D60", Offset = "0xFB9D60", VA = "0xFB9D60")]
	public void ClaimReward(List<unlock> claimList, bool isAutoClaim = false, bool isMaxReward = false)
	{
	}

	[Token(Token = "0x601426D")]
	[Address(RVA = "0xFBA0B8", Offset = "0xFBA0B8", VA = "0xFBA0B8")]
	public void PurchaseEP(bool isBundle)
	{
	}

	[Token(Token = "0x601426E")]
	[Address(RVA = "0xFBABE8", Offset = "0xFBABE8", VA = "0xFBABE8")]
	public void TryAutoClaimUpgradeReward(uint badgeCount)
	{
	}

	[Token(Token = "0x601426F")]
	[Address(RVA = "0xFBAFC8", Offset = "0xFBAFC8", VA = "0xFBAFC8")]
	public void PurchaseBadge(int count, uint price)
	{
	}

	[Token(Token = "0x6014270")]
	[Address(RVA = "0xFBA6E4", Offset = "0xFBA6E4", VA = "0xFBA6E4")]
	private void ShowCoinsNotEnoughPopup()
	{
	}

	[Token(Token = "0x6014271")]
	[Address(RVA = "0xFBA9B8", Offset = "0xFBA9B8", VA = "0xFBA9B8")]
	private void ShowGemsNotEnoughPopup()
	{
	}

	[Token(Token = "0x6014272")]
	[Address(RVA = "0xFBB3EC", Offset = "0xFBB3EC", VA = "0xFBB3EC")]
	public void ClaimChallengeReward(List<uint> challengeIDs, ChallengeType challengeType, uint challengeGroup)
	{
	}

	[Token(Token = "0x6014273")]
	[Address(RVA = "0xFBB6F8", Offset = "0xFBB6F8", VA = "0xFBB6F8")]
	public void ClaimQuestReward(List<uint> questIDs, EPQuestType type, uint groupID = 0u)
	{
	}

	[Token(Token = "0x6014274")]
	[Address(RVA = "0xFBBA04", Offset = "0xFBBA04", VA = "0xFBBA04")]
	public void ClaimEPWeeklyQuestReward(uint weekId, uint boxId)
	{
	}

	[Token(Token = "0x6014275")]
	[Address(RVA = "0xFBBCEC", Offset = "0xFBBCEC", VA = "0xFBBCEC")]
	public void PreorderNextEP()
	{
	}

	[Token(Token = "0x6014276")]
	[Address(RVA = "0xFBBF10", Offset = "0xFBBF10", VA = "0xFBBF10")]
	public bool NeedShowClaimAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6014277")]
	[Address(RVA = "0xFBC26C", Offset = "0xFBC26C", VA = "0xFBC26C")]
	public void ClaimAll()
	{
	}

	[Token(Token = "0x6014278")]
	[Address(RVA = "0xFBC928", Offset = "0xFBC928", VA = "0xFBC928")]
	public void UpdateSpecialChallengesUnlocked(ChallengeIDs msg)
	{
	}

	[Token(Token = "0x6014279")]
	[Address(RVA = "0xFBCA4C", Offset = "0xFBCA4C", VA = "0xFBCA4C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x601427A")]
	[Address(RVA = "0xFBCAA8", Offset = "0xFBCAA8", VA = "0xFBCAA8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014281")]
	[Address(RVA = "0xFBD078", Offset = "0xFBD078", VA = "0xFBD078")]
	public bool WithinSubscribablePeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x6014282")]
	[Address(RVA = "0xFBCFD0", Offset = "0xFBCFD0", VA = "0xFBCFD0")]
	public bool WithinOverdueSubscribablePeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x6014283")]
	[Address(RVA = "0xFBD764", Offset = "0xFBD764", VA = "0xFBD764")]
	public EPSubscriptions GetPreorderSubscriptionConfig()
	{
		return null;
	}

	[Token(Token = "0x6014284")]
	[Address(RVA = "0xFBDB78", Offset = "0xFBDB78", VA = "0xFBDB78")]
	private string GetPreorderSubscriptionProductIdentifier()
	{
		return null;
	}

	[Token(Token = "0x6014285")]
	[Address(RVA = "0xFBDDA8", Offset = "0xFBDDA8", VA = "0xFBDDA8")]
	public PayItemData GetPreorderSubscriptionProduct_CSV()
	{
		return null;
	}

	[Token(Token = "0x6014286")]
	[Address(RVA = "0xFBE034", Offset = "0xFBE034", VA = "0xFBE034")]
	public PayItemData GetPreorderSubscriptionProduct_SDK()
	{
		return null;
	}

	[Token(Token = "0x6014287")]
	[Address(RVA = "0xFBE218", Offset = "0xFBE218", VA = "0xFBE218")]
	public long GetPreorderSubscriptionCountdown_Seconds()
	{
		return default(long);
	}

	[Token(Token = "0x6014288")]
	[Address(RVA = "0xFBE2F8", Offset = "0xFBE2F8", VA = "0xFBE2F8")]
	public void SubscribeForPreorder()
	{
	}

	[Token(Token = "0x6014289")]
	[Address(RVA = "0xFBE8C0", Offset = "0xFBE8C0", VA = "0xFBE8C0")]
	private void OnSubscribeForPreorder(bool success, string productIdentifier, long rebateId)
	{
	}

	[Token(Token = "0x601428A")]
	[Address(RVA = "0xFBE9BC", Offset = "0xFBE9BC", VA = "0xFBE9BC")]
	private void OnGetSubscriptionProduct()
	{
	}

	[Token(Token = "0x601428B")]
	[Address(RVA = "0xFBEA94", Offset = "0xFBEA94", VA = "0xFBEA94")]
	public void OnSubscribed(string subscriptionProductIdentifier)
	{
	}

	[Token(Token = "0x601428C")]
	[Address(RVA = "0xFBEED4", Offset = "0xFBEED4", VA = "0xFBEED4")]
	public void ShowSubscriptionHint(Vector3 position)
	{
	}

	[Token(Token = "0x601428F")]
	[Address(RVA = "0xFBF074", Offset = "0xFBF074", VA = "0xFBF074")]
	public void FetchSubscriptionBonusStatus(bool silence = false)
	{
	}

	[Token(Token = "0x6014290")]
	[Address(RVA = "0xFBF384", Offset = "0xFBF384", VA = "0xFBF384")]
	public int UpdateEPRelatedRedDot()
	{
		return default(int);
	}

	[Token(Token = "0x6014291")]
	[Address(RVA = "0xFBF5B4", Offset = "0xFBF5B4", VA = "0xFBF5B4")]
	public void RequestGetEPDocumentInfo()
	{
	}

	[Token(Token = "0x6014292")]
	[Address(RVA = "0xFBF7D8", Offset = "0xFBF7D8", VA = "0xFBF7D8")]
	public void DebugLogError(string errorMsg)
	{
	}

	[Token(Token = "0x6014293")]
	[Address(RVA = "0xFBF8F8", Offset = "0xFBF8F8", VA = "0xFBF8F8")]
	public void ClickLog(EventLogger.ClickType clickType, string logMsg)
	{
	}

	[Token(Token = "0x6014294")]
	[Address(RVA = "0xFBFBDC", Offset = "0xFBFBDC", VA = "0xFBFBDC")]
	private bool IsCustomizedDiscountNotOverDue()
	{
		return default(bool);
	}

	[Token(Token = "0x6014295")]
	[Address(RVA = "0xFBAAE4", Offset = "0xFBAAE4", VA = "0xFBAAE4")]
	public bool IsCustomizedDiscountObtained()
	{
		return default(bool);
	}

	[Token(Token = "0x6014296")]
	[Address(RVA = "0xFBFD04", Offset = "0xFBFD04", VA = "0xFBFD04")]
	public bool IsCustomizedDiscountActivated()
	{
		return default(bool);
	}

	[Token(Token = "0x6014297")]
	[Address(RVA = "0xFBFE08", Offset = "0xFBFE08", VA = "0xFBFE08")]
	public bool IsShowMatchResultChallengeWnd()
	{
		return default(bool);
	}

	[Token(Token = "0x6014298")]
	[Address(RVA = "0xFBFF04", Offset = "0xFBFF04", VA = "0xFBFF04")]
	public void ClearCurChallengeInfo()
	{
	}

	[Token(Token = "0x6014299")]
	[Address(RVA = "0xFBFFD8", Offset = "0xFBFFD8", VA = "0xFBFFD8")]
	public void GetCurChallengeChangeInfo(EPChallengesUpdateNtf updateInfo)
	{
	}

	[Token(Token = "0x601429A")]
	[Address(RVA = "0xFC15B4", Offset = "0xFC15B4", VA = "0xFC15B4")]
	private void GetWeeklyDescByWeekID(bool weekLock, uint weekId, ref List<EPWeeklyQuestInfo> weeklyDesc)
	{
	}

	[Token(Token = "0x601429B")]
	[Address(RVA = "0xFC17E4", Offset = "0xFC17E4", VA = "0xFC17E4")]
	private void _003CGetEPEventInfoFromServer_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601429C")]
	[Address(RVA = "0xFC266C", Offset = "0xFC266C", VA = "0xFC266C")]
	private void _003CClaimDailyProcessRewardByNodeID_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601429D")]
	[Address(RVA = "0xFC2A28", Offset = "0xFC2A28", VA = "0xFC2A28")]
	private void _003CGetEPVideoUrlFromServer_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601429E")]
	[Address(RVA = "0xFC2B60", Offset = "0xFC2B60", VA = "0xFC2B60")]
	private void _003CPreorderNextEP_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601429F")]
	[Address(RVA = "0xFC2C40", Offset = "0xFC2C40", VA = "0xFC2C40")]
	private void _003CSubscribeForPreorder_003Em__4(bool purchasing, string product, long rebateId)
	{
	}

	[Token(Token = "0x60142A0")]
	[Address(RVA = "0xFC2C48", Offset = "0xFC2C48", VA = "0xFC2C48")]
	private void _003CFetchSubscriptionBonusStatus_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60142A1")]
	[Address(RVA = "0xFC2DB0", Offset = "0xFC2DB0", VA = "0xFC2DB0")]
	private void _003CRequestGetEPDocumentInfo_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60142A2")]
	[Address(RVA = "0xFC2F44", Offset = "0xFC2F44", VA = "0xFC2F44")]
	private static int _003CGetEPEventInfoFromServer_003Em__7(EPDailyProcessRewardDesc a, EPDailyProcessRewardDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x60142A3")]
	[Address(RVA = "0xFC2F8C", Offset = "0xFC2F8C", VA = "0xFC2F8C")]
	private static CommonRewardItemInfo _003CClaimDailyProcessRewardByNodeID_003Em__8(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x60142A4")]
	[Address(RVA = "0xFC2F94", Offset = "0xFC2F94", VA = "0xFC2F94")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60142A5")]
	[Address(RVA = "0xFC2F9C", Offset = "0xFC2F9C", VA = "0xFC2F9C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
