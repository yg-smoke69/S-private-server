using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002EBC")]
public class UIModelAvatarProfile : UIBaseModel
{
	[Token(Token = "0x2002EBD")]
	private sealed class _003CChangeSimpleSelectedAvatar_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011DC4")]
		[FieldOffset(Offset = "0x8")]
		internal uint selectedAvatarID;

		[Token(Token = "0x4011DC5")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x6013946")]
		[Address(RVA = "0x25F1168", Offset = "0x25F1168", VA = "0x25F1168")]
		public _003CChangeSimpleSelectedAvatar_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013947")]
		[Address(RVA = "0x25F1170", Offset = "0x25F1170", VA = "0x25F1170")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EBE")]
	private sealed class _003CChangeSelectedAvatar_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011DC6")]
		[FieldOffset(Offset = "0x8")]
		internal uint selectedAvatarID;

		[Token(Token = "0x4011DC7")]
		[FieldOffset(Offset = "0xC")]
		internal CSSelectProfileReq req;

		[Token(Token = "0x4011DC8")]
		[FieldOffset(Offset = "0x10")]
		internal bool callFromAvatarList;

		[Token(Token = "0x4011DC9")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x6013948")]
		[Address(RVA = "0x25F06BC", Offset = "0x25F06BC", VA = "0x25F06BC")]
		public _003CChangeSelectedAvatar_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013949")]
		[Address(RVA = "0x25F06C4", Offset = "0x25F06C4", VA = "0x25F06C4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EBF")]
	private sealed class _003CRequestUnlockProfile_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011DCA")]
		[FieldOffset(Offset = "0x8")]
		internal AvatarProfile profile;

		[Token(Token = "0x4011DCB")]
		[FieldOffset(Offset = "0xC")]
		internal uint avatarID;

		[Token(Token = "0x4011DCC")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x601394A")]
		[Address(RVA = "0x25F30CC", Offset = "0x25F30CC", VA = "0x25F30CC")]
		public _003CRequestUnlockProfile_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601394B")]
		[Address(RVA = "0x25F30D4", Offset = "0x25F30D4", VA = "0x25F30D4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EC0")]
	private sealed class _003CShowRewardList_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011DCD")]
		[FieldOffset(Offset = "0x8")]
		internal BaseItemInfo awardItemInfo;

		[Token(Token = "0x601394C")]
		[Address(RVA = "0x25F3BC0", Offset = "0x25F3BC0", VA = "0x25F3BC0")]
		public _003CShowRewardList_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601394D")]
		[Address(RVA = "0x25F3BC8", Offset = "0x25F3BC8", VA = "0x25F3BC8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x601394E")]
		[Address(RVA = "0x25F3CC0", Offset = "0x25F3CC0", VA = "0x25F3CC0")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x2002EC1")]
	private sealed class _003CFindGoPosByTime_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011DCE")]
		[FieldOffset(Offset = "0x8")]
		internal ulong now;

		[Token(Token = "0x601394F")]
		[Address(RVA = "0x25F1454", Offset = "0x25F1454", VA = "0x25F1454")]
		public _003CFindGoPosByTime_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6013950")]
		[Address(RVA = "0x25F145C", Offset = "0x25F145C", VA = "0x25F145C")]
		internal bool _003C_003Em__0(GoPos pos)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002EC2")]
	private sealed class _003CRequestUnLockSkillSlot_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011DCF")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x4011DD0")]
		[FieldOffset(Offset = "0xC")]
		internal int slotIndex;

		[Token(Token = "0x4011DD1")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x4011DD2")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013951")]
		[Address(RVA = "0x25F23E0", Offset = "0x25F23E0", VA = "0x25F23E0")]
		public _003CRequestUnLockSkillSlot_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6013952")]
		[Address(RVA = "0x25F23E8", Offset = "0x25F23E8", VA = "0x25F23E8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013953")]
		[Address(RVA = "0x25F29F4", Offset = "0x25F29F4", VA = "0x25F29F4")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6013954")]
		[Address(RVA = "0x25F29FC", Offset = "0x25F29FC", VA = "0x25F29FC")]
		internal void _003C_003Em__2()
		{
		}
	}

	[Token(Token = "0x2002EC3")]
	private sealed class _003CRequestRefreshAvatarAwakenTaskInfo_003Ec__AnonStorey6
	{
		[Token(Token = "0x4011DD3")]
		[FieldOffset(Offset = "0x8")]
		internal uint origionalID;

		[Token(Token = "0x4011DD4")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x6013955")]
		[Address(RVA = "0x25F2220", Offset = "0x25F2220", VA = "0x25F2220")]
		public _003CRequestRefreshAvatarAwakenTaskInfo_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6013956")]
		[Address(RVA = "0x25F2228", Offset = "0x25F2228", VA = "0x25F2228")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EC4")]
	private sealed class _003CRequestUnlockAvatarAwakenComic_003Ec__AnonStorey7
	{
		[Token(Token = "0x4011DD5")]
		[FieldOffset(Offset = "0x8")]
		internal uint origionalID;

		[Token(Token = "0x4011DD6")]
		[FieldOffset(Offset = "0xC")]
		internal uint comicID;

		[Token(Token = "0x4011DD7")]
		[FieldOffset(Offset = "0x10")]
		internal uint unlockNum;

		[Token(Token = "0x4011DD8")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x6013957")]
		[Address(RVA = "0x25F2C90", Offset = "0x25F2C90", VA = "0x25F2C90")]
		public _003CRequestUnlockAvatarAwakenComic_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6013958")]
		[Address(RVA = "0x25F2C98", Offset = "0x25F2C98", VA = "0x25F2C98")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EC5")]
	private sealed class _003CAwakenIdToOriId_003Ec__AnonStorey8
	{
		[Token(Token = "0x4011DD9")]
		[FieldOffset(Offset = "0x8")]
		internal uint awakenAvatarID;

		[Token(Token = "0x6013959")]
		[Address(RVA = "0x25F062C", Offset = "0x25F062C", VA = "0x25F062C")]
		public _003CAwakenIdToOriId_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x601395A")]
		[Address(RVA = "0x25F0634", Offset = "0x25F0634", VA = "0x25F0634")]
		internal bool _003C_003Em__0(KeyValuePair<uint, uint> e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002EC6")]
	private sealed class _003CAutoOpenBundle_003Ec__AnonStorey9
	{
		[Token(Token = "0x4011DDA")]
		[FieldOffset(Offset = "0x8")]
		internal Action callback;

		[Token(Token = "0x4011DDB")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601395B")]
		[Address(RVA = "0x25EFC94", Offset = "0x25EFC94", VA = "0x25EFC94")]
		public _003CAutoOpenBundle_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x601395C")]
		[Address(RVA = "0x25EFC9C", Offset = "0x25EFC9C", VA = "0x25EFC9C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601395D")]
		[Address(RVA = "0x25F0624", Offset = "0x25F0624", VA = "0x25F0624")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2002EC7")]
	private sealed class _003CRequestClaimAwakenTaskReward_003Ec__AnonStoreyA
	{
		[Token(Token = "0x2002EC8")]
		private sealed class _003CRequestClaimAwakenTaskReward_003Ec__AnonStoreyB
		{
			[Token(Token = "0x4011DE1")]
			[FieldOffset(Offset = "0x8")]
			internal List<CommonRewardItemInfo> normalItems;

			[Token(Token = "0x4011DE2")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestClaimAwakenTaskReward_003Ec__AnonStoreyA _003C_003Ef__ref_002410;

			[Token(Token = "0x6013962")]
			[Address(RVA = "0x25F1A50", Offset = "0x25F1A50", VA = "0x25F1A50")]
			public _003CRequestClaimAwakenTaskReward_003Ec__AnonStoreyB()
			{
			}

			[Token(Token = "0x6013963")]
			[Address(RVA = "0x25F1AC0", Offset = "0x25F1AC0", VA = "0x25F1AC0")]
			internal void _003C_003Em__0()
			{
			}
		}

		[Token(Token = "0x4011DDC")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x4011DDD")]
		[FieldOffset(Offset = "0xC")]
		internal uint taskID;

		[Token(Token = "0x4011DDE")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x4011DDF")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4011DE0")]
		[FieldOffset(Offset = "0x4")]
		private static Predicate<CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x601395E")]
		[Address(RVA = "0x25F14E4", Offset = "0x25F14E4", VA = "0x25F14E4")]
		public _003CRequestClaimAwakenTaskReward_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x601395F")]
		[Address(RVA = "0x25F14EC", Offset = "0x25F14EC", VA = "0x25F14EC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013960")]
		[Address(RVA = "0x25F1A58", Offset = "0x25F1A58", VA = "0x25F1A58")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6013961")]
		[Address(RVA = "0x25F1A60", Offset = "0x25F1A60", VA = "0x25F1A60")]
		private static bool _003C_003Em__2(CommonRewardItemInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002EC9")]
	private sealed class _003CRequestGeAvatarProfileBatch_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4011DE3")]
		[FieldOffset(Offset = "0x8")]
		internal List<ulong> accountIdList;

		[Token(Token = "0x4011DE4")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelAvatarProfile _0024this;

		[Token(Token = "0x6013964")]
		[Address(RVA = "0x25F1D54", Offset = "0x25F1D54", VA = "0x25F1D54")]
		public _003CRequestGeAvatarProfileBatch_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6013965")]
		[Address(RVA = "0x25F1D5C", Offset = "0x25F1D5C", VA = "0x25F1D5C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4011D84")]
	public const uint PropID_AvatarListUpdate = 2u;

	[Token(Token = "0x4011D85")]
	public const uint PropID_ProfileUpdate = 4u;

	[Token(Token = "0x4011D86")]
	public const uint PropID_SkillUpdate = 8u;

	[Token(Token = "0x4011D87")]
	public const uint PropID_UnlockProfile = 16u;

	[Token(Token = "0x4011D88")]
	public const uint PropID_UnlockAvatar = 32u;

	[Token(Token = "0x4011D89")]
	public const uint PropID_SkillSlotChange = 64u;

	[Token(Token = "0x4011D8A")]
	public const uint PropID_AvatarSelectionChanged = 128u;

	[Token(Token = "0x4011D8B")]
	public const uint PropID_UnLockSkillSlot = 256u;

	[Token(Token = "0x4011D8C")]
	public const uint PropID_UpgradeProfile = 512u;

	[Token(Token = "0x4011D8D")]
	public const uint PropID_AwakenTaskUpdate = 1024u;

	[Token(Token = "0x4011D8E")]
	public const uint PropID_AwakenRewardClaim = 2048u;

	[Token(Token = "0x4011D8F")]
	public const uint PropID_ExchangeDebrisSuccess = 4096u;

	[Token(Token = "0x4011D90")]
	public const uint PropID_LimitAvatarInfoChange = 8192u;

	[Token(Token = "0x4011D91")]
	public const uint PropID_LimitAvatarExpire = 16384u;

	[Token(Token = "0x4011D92")]
	public const uint PropID_GetAvatarProfileBatch = 32768u;

	[Token(Token = "0x4011D93")]
	public const uint PropID_AwakenComicUpdate = 65536u;

	[Token(Token = "0x4011D94")]
	public const uint PropID_AvatarAwakenUpdate = 131072u;

	[Token(Token = "0x4011D95")]
	public const string UPGRADECARDPREFIX = "UPGRADECARDPREFIX";

	[Token(Token = "0x4011D96")]
	public const string UPGRADECARDREDDOT = "UPGRADECARDREDDOT";

	[Token(Token = "0x4011D97")]
	public const string AWAKENCOMICHASNEW = "AWAKENCOMICHASNEW";

	[Token(Token = "0x4011D98")]
	public const uint AVATARAWAKEN_FINISH = uint.MaxValue;

	[Token(Token = "0x4011D99")]
	private const uint UNIVERSAL_DEBRIS_ID = 817000001u;

	[Token(Token = "0x4011D9A")]
	private const uint DEFAULT_SELECT_AVATARID = 102000004u;

	[Token(Token = "0x4011D9B")]
	[FieldOffset(Offset = "0xC")]
	public uint m_CurrentUnlockAvatarID;

	[Token(Token = "0x4011D9C")]
	[FieldOffset(Offset = "0x10")]
	private Action accallback;

	[Token(Token = "0x4011D9D")]
	[FieldOffset(Offset = "0x14")]
	private List<uint> m_NewAvatarList;

	[Token(Token = "0x4011D9E")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, AvatarProfile> m_AvatarProfileMap;

	[Token(Token = "0x4011D9F")]
	[FieldOffset(Offset = "0x1C")]
	private readonly Dictionary<uint, AvatarProfile> m_HiddenAvatarProfileDict;

	[Token(Token = "0x4011DA0")]
	[FieldOffset(Offset = "0x20")]
	private List<uint> m_AvailableSkills;

	[Token(Token = "0x4011DA1")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<uint, AvatarSkill> AvatarSkillDataMap;

	[Token(Token = "0x4011DA2")]
	[FieldOffset(Offset = "0x28")]
	private List<AvatarProfileDataOverrided> m_AvatarProfileDescList;

	[Token(Token = "0x4011DA3")]
	[FieldOffset(Offset = "0x2C")]
	private List<uint> m_HideAvatarList;

	[Token(Token = "0x4011DA4")]
	[FieldOffset(Offset = "0x30")]
	private List<uint> m_IpExpiredAvatarList;

	[Token(Token = "0x4011DA5")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<ulong, proto.AvatarProfile> m_AccountAvatarDict;

	[Token(Token = "0x4011DA6")]
	[FieldOffset(Offset = "0x38")]
	private List<AvatarLevelUpCard> m_LevelUpCardList;

	[Token(Token = "0x4011DA7")]
	[FieldOffset(Offset = "0x3C")]
	private AvatarProfile m_CurrentAvatar;

	[Token(Token = "0x4011DA8")]
	[FieldOffset(Offset = "0x40")]
	private int m_UniversalDebrisCnt;

	[Token(Token = "0x4011DA9")]
	[FieldOffset(Offset = "0x44")]
	private string Key;

	[Token(Token = "0x4011DAA")]
	[FieldOffset(Offset = "0x48")]
	private bool m_NewBieAvatarGuide;

	[Token(Token = "0x4011DAB")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SuitIdCache;

	[Token(Token = "0x4011DAC")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, uint> m_OriAvatarIDToAwakenAvatarIdMap;

	[Token(Token = "0x4011DAD")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, AvatarAwaken> m_OriAvatarIDToAwakenInfoMap;

	[Token(Token = "0x4011DAE")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<uint, AvatarAwaken> m_OriAvatarIDToAwakenInfoMap_lock;

	[Token(Token = "0x4011DAF")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<uint, Dictionary<uint, AwakenTask>> m_OriAvatarToAwakenTaskMap;

	[Token(Token = "0x4011DB0")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<uint, uint> m_OriAvatarToAwakenTaskRefreshCntMap;

	[Token(Token = "0x4011DB1")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<uint, Dictionary<uint, AwakenComic>> m_OriAvatarToAwakenComicMap;

	[Token(Token = "0x4011DB2")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, List<GoPos>> m_AvatarIdToGoPosData;

	[Token(Token = "0x4011DB3")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<int, int> m_ProfileLvToSkillLv;

	[Token(Token = "0x4011DB4")]
	[FieldOffset(Offset = "0x70")]
	private List<ulong> m_RunningRequestProfileAccountIDCache;

	[Token(Token = "0x4011DB5")]
	[FieldOffset(Offset = "0x74")]
	private List<uint> m_HadReadRedDotList;

	[Token(Token = "0x4011DB6")]
	[FieldOffset(Offset = "0x78")]
	private bool m_HasRequestedMyAvatarList;

	[Token(Token = "0x4011DB7")]
	[FieldOffset(Offset = "0x7C")]
	private List<uint> m_CacheExpireAvatarLst;

	[Token(Token = "0x4011DB8")]
	public const uint COMICUNLOCKCNT_PERCOMIC_MAX = 3u;

	[Token(Token = "0x4011DB9")]
	[FieldOffset(Offset = "0x80")]
	private bool m_HadFetchAwakenComicRes;

	[Token(Token = "0x4011DBA")]
	[FieldOffset(Offset = "0x81")]
	private bool m_HadFetchAwakenTaskRes;

	[Token(Token = "0x4011DBB")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4011DBC")]
	[FieldOffset(Offset = "0x4")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4011DBD")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4011DBE")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4011DBF")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<Item, CommonRewardItemInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4011DC0")]
	[FieldOffset(Offset = "0x14")]
	private static Func<proto.AvatarProfile, uint> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4011DC1")]
	[FieldOffset(Offset = "0x18")]
	private static Func<KeyValuePair<uint, uint>, uint> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4011DC2")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<AvatarProfile> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4011DC3")]
	[FieldOffset(Offset = "0x20")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x17001460")]
	public Dictionary<uint, AvatarProfile> AvatarProfileMap
	{
		[Token(Token = "0x60138A1")]
		[Address(RVA = "0x30C572C", Offset = "0x30C572C", VA = "0x30C572C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001461")]
	public List<uint> AvailableSkills
	{
		[Token(Token = "0x60138A2")]
		[Address(RVA = "0x30C5784", Offset = "0x30C5784", VA = "0x30C5784")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001462")]
	public List<AvatarProfileDataOverrided> AvatarProfileDescList
	{
		[Token(Token = "0x60138A3")]
		[Address(RVA = "0x30C57DC", Offset = "0x30C57DC", VA = "0x30C57DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001463")]
	public List<AvatarLevelUpCard> LevelUpCardList
	{
		[Token(Token = "0x60138A4")]
		[Address(RVA = "0x30C5834", Offset = "0x30C5834", VA = "0x30C5834")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001464")]
	public AvatarProfile CurrentAvatar
	{
		[Token(Token = "0x60138A5")]
		[Address(RVA = "0x30C5B44", Offset = "0x30C5B44", VA = "0x30C5B44")]
		get
		{
			return null;
		}
		[Token(Token = "0x60138A6")]
		[Address(RVA = "0x30C5B9C", Offset = "0x30C5B9C", VA = "0x30C5B9C")]
		set
		{
		}
	}

	[Token(Token = "0x17001465")]
	public int UniversalDebrisCnt
	{
		[Token(Token = "0x60138A8")]
		[Address(RVA = "0x30C5DE0", Offset = "0x30C5DE0", VA = "0x30C5DE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60138A9")]
		[Address(RVA = "0x30C5E38", Offset = "0x30C5E38", VA = "0x30C5E38")]
		set
		{
		}
	}

	[Token(Token = "0x17001466")]
	public bool NewBieAvatarGuide
	{
		[Token(Token = "0x60138AA")]
		[Address(RVA = "0x30C5E98", Offset = "0x30C5E98", VA = "0x30C5E98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60138AB")]
		[Address(RVA = "0x30C5EF0", Offset = "0x30C5EF0", VA = "0x30C5EF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001467")]
	public List<uint> CacheExpireAvatarLst
	{
		[Token(Token = "0x60138F0")]
		[Address(RVA = "0x30D17C4", Offset = "0x30D17C4", VA = "0x30D17C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60138A0")]
	[Address(RVA = "0x30C5178", Offset = "0x30C5178", VA = "0x30C5178")]
	public UIModelAvatarProfile()
	{
	}

	[Token(Token = "0x60138A7")]
	[Address(RVA = "0x30C5D80", Offset = "0x30C5D80", VA = "0x30C5D80")]
	public void SetAvatarProfile(AvatarProfile data)
	{
	}

	[Token(Token = "0x60138AC")]
	[Address(RVA = "0x30C6004", Offset = "0x30C6004", VA = "0x30C6004", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60138AD")]
	[Address(RVA = "0x30C605C", Offset = "0x30C605C", VA = "0x30C605C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60138AE")]
	[Address(RVA = "0x30C6338", Offset = "0x30C6338", VA = "0x30C6338", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60138AF")]
	[Address(RVA = "0x30C6610", Offset = "0x30C6610", VA = "0x30C6610")]
	private void InitData()
	{
	}

	[Token(Token = "0x60138B0")]
	[Address(RVA = "0x30C38B4", Offset = "0x30C38B4", VA = "0x30C38B4")]
	public bool CheckIsHideAvatar(uint avatarid)
	{
		return default(bool);
	}

	[Token(Token = "0x60138B1")]
	[Address(RVA = "0x30C6A88", Offset = "0x30C6A88", VA = "0x30C6A88")]
	public bool IsIpExpiredAvatar(uint avatarid)
	{
		return default(bool);
	}

	[Token(Token = "0x60138B2")]
	[Address(RVA = "0x30C6B54", Offset = "0x30C6B54", VA = "0x30C6B54")]
	public uint GetAvatarIdBySkillId(uint _skillid)
	{
		return default(uint);
	}

	[Token(Token = "0x60138B3")]
	[Address(RVA = "0x30B8284", Offset = "0x30B8284", VA = "0x30B8284")]
	public AvatarProfile GetAvatarProfile(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60138B4")]
	[Address(RVA = "0x30C6DF8", Offset = "0x30C6DF8", VA = "0x30C6DF8")]
	public AvatarProfile GetAvatarProfileIncludeHidden(uint avatarID, out bool isHidden)
	{
		return null;
	}

	[Token(Token = "0x60138B5")]
	[Address(RVA = "0x30C6F40", Offset = "0x30C6F40", VA = "0x30C6F40")]
	public void LockProfile(uint avatarID)
	{
	}

	[Token(Token = "0x60138B6")]
	[Address(RVA = "0x30C6FB8", Offset = "0x30C6FB8", VA = "0x30C6FB8")]
	public int GetOpenSlotCount(uint avatarID)
	{
		return default(int);
	}

	[Token(Token = "0x60138B7")]
	[Address(RVA = "0x30C7280", Offset = "0x30C7280", VA = "0x30C7280")]
	public AvatarProfileDataOverrided GetAvatarProfileData(uint _pID)
	{
		return null;
	}

	[Token(Token = "0x60138B8")]
	[Address(RVA = "0x30C7444", Offset = "0x30C7444", VA = "0x30C7444")]
	public uint GetAvatarIDByDebrisID(uint _dID)
	{
		return default(uint);
	}

	[Token(Token = "0x60138B9")]
	[Address(RVA = "0x30C760C", Offset = "0x30C760C", VA = "0x30C760C")]
	private void UpdateAvatarInfo(List<proto.AvatarProfile> profiles)
	{
	}

	[Token(Token = "0x60138BA")]
	[Address(RVA = "0x30C8A64", Offset = "0x30C8A64", VA = "0x30C8A64")]
	public void ReadAvatarprofileRedDot(uint avatarID)
	{
	}

	[Token(Token = "0x60138BB")]
	[Address(RVA = "0x30C913C", Offset = "0x30C913C", VA = "0x30C913C")]
	private bool CheckHasTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x60138BC")]
	[Address(RVA = "0x30C920C", Offset = "0x30C920C", VA = "0x30C920C")]
	private bool CheckHasAwakenTips(AvatarProfile profile)
	{
		return default(bool);
	}

	[Token(Token = "0x60138BD")]
	[Address(RVA = "0x30C8CA8", Offset = "0x30C8CA8", VA = "0x30C8CA8")]
	private void UpdateTips()
	{
	}

	[Token(Token = "0x60138BE")]
	[Address(RVA = "0x30C9968", Offset = "0x30C9968", VA = "0x30C9968")]
	private void UpdateSkillInfo(uint[] Skills)
	{
	}

	[Token(Token = "0x60138BF")]
	[Address(RVA = "0x30C9BA4", Offset = "0x30C9BA4", VA = "0x30C9BA4")]
	private void UpdateSkillInfoById(AvatarProfile profile, uint id)
	{
	}

	[Token(Token = "0x60138C0")]
	[Address(RVA = "0x30C9CB0", Offset = "0x30C9CB0", VA = "0x30C9CB0")]
	public void UpdateDebrisCnt()
	{
	}

	[Token(Token = "0x60138C1")]
	[Address(RVA = "0x30C9E3C", Offset = "0x30C9E3C", VA = "0x30C9E3C")]
	public void UpdateInfoByInventoryItems()
	{
	}

	[Token(Token = "0x60138C2")]
	[Address(RVA = "0x30CA8F0", Offset = "0x30CA8F0", VA = "0x30CA8F0")]
	public void RequestMyAvatarList(uint httpOp = 0u, bool force = true, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60138C3")]
	[Address(RVA = "0x30CAD68", Offset = "0x30CAD68", VA = "0x30CAD68")]
	public void SetCallback(Action callback)
	{
	}

	[Token(Token = "0x60138C4")]
	[Address(RVA = "0x30CADC8", Offset = "0x30CADC8", VA = "0x30CADC8")]
	public void ForceRequestAvatarList()
	{
	}

	[Token(Token = "0x60138C5")]
	[Address(RVA = "0x30CB02C", Offset = "0x30CB02C", VA = "0x30CB02C")]
	public void RequestSkillList(uint httpOp = 0u)
	{
	}

	[Token(Token = "0x60138C6")]
	[Address(RVA = "0x30CB254", Offset = "0x30CB254", VA = "0x30CB254")]
	public void RequestLoginGetProfile(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60138C7")]
	[Address(RVA = "0x30CB488", Offset = "0x30CB488", VA = "0x30CB488")]
	public void ProcessProfileDesc(CSGetUnlockProfileInfoRes profileRes)
	{
	}

	[Token(Token = "0x60138C8")]
	[Address(RVA = "0x30CBE94", Offset = "0x30CBE94", VA = "0x30CBE94")]
	public void RequestHideAvatars()
	{
	}

	[Token(Token = "0x60138C9")]
	[Address(RVA = "0x30CC0B8", Offset = "0x30CC0B8", VA = "0x30CC0B8")]
	public void ProcessHideAvatars(CSGetHideAvatarRes res, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60138CA")]
	[Address(RVA = "0x30C9D14", Offset = "0x30C9D14", VA = "0x30C9D14")]
	private int GetUniversalDebrisCnt()
	{
		return default(int);
	}

	[Token(Token = "0x60138CB")]
	[Address(RVA = "0x30CC258", Offset = "0x30CC258", VA = "0x30CC258")]
	public void ChangeSimpleSelectedAvatar(uint selectedAvatarID)
	{
	}

	[Token(Token = "0x60138CC")]
	[Address(RVA = "0x30CC704", Offset = "0x30CC704", VA = "0x30CC704")]
	public void ChangeOnlyMsgAvatar(uint selectedAvatar)
	{
	}

	[Token(Token = "0x60138CD")]
	[Address(RVA = "0x30C83EC", Offset = "0x30C83EC", VA = "0x30C83EC")]
	public void ChangeSelectedAvatar(uint selectedAvatarID, bool callFromAvatarList = false)
	{
	}

	[Token(Token = "0x60138CE")]
	[Address(RVA = "0x30CCBBC", Offset = "0x30CCBBC", VA = "0x30CCBBC")]
	public bool CheckUnlockManually(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138CF")]
	[Address(RVA = "0x30CCD48", Offset = "0x30CCD48", VA = "0x30CCD48")]
	public bool IsUnlockLevelLimitSatisfied(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138D0")]
	[Address(RVA = "0x30C8B8C", Offset = "0x30C8B8C", VA = "0x30C8B8C")]
	public bool IsUnlockDebrisCountSatisfied(uint avatarID, bool includeUniversal = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60138D1")]
	[Address(RVA = "0x30CCED8", Offset = "0x30CCED8", VA = "0x30CCED8")]
	public bool IsUnlockOtherResourceSatisfied(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138D2")]
	[Address(RVA = "0x30CCF6C", Offset = "0x30CCF6C", VA = "0x30CCF6C")]
	public bool NeedShowProfileCouldLevelupTips(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138D3")]
	[Address(RVA = "0x30CD180", Offset = "0x30CD180", VA = "0x30CD180")]
	public bool CanUnlockNextProfile(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138D4")]
	[Address(RVA = "0x30CA578", Offset = "0x30CA578", VA = "0x30CA578")]
	public void RequestUnlockAvatarHiddenly(uint avatarID)
	{
	}

	[Token(Token = "0x60138D5")]
	[Address(RVA = "0x30CD23C", Offset = "0x30CD23C", VA = "0x30CD23C")]
	public void OnUnlockedNewAvatar(proto.AvatarProfile avatar)
	{
	}

	[Token(Token = "0x60138D6")]
	[Address(RVA = "0x30CD3C0", Offset = "0x30CD3C0", VA = "0x30CD3C0")]
	public void OnUnlockedNewSkill(uint newSkillID)
	{
	}

	[Token(Token = "0x60138D7")]
	[Address(RVA = "0x30CDA94", Offset = "0x30CDA94", VA = "0x30CDA94")]
	public bool HasActiveSkillBesidesSlot(uint avatarid, int slot)
	{
		return default(bool);
	}

	[Token(Token = "0x60138D8")]
	[Address(RVA = "0x30CDDCC", Offset = "0x30CDDCC", VA = "0x30CDDCC")]
	public uint GetActiveSkillInEquipedSkills()
	{
		return default(uint);
	}

	[Token(Token = "0x60138D9")]
	[Address(RVA = "0x30CDFB8", Offset = "0x30CDFB8", VA = "0x30CDFB8")]
	public void RequestUnlockProfile(uint avatarID, proto.EInventory.CurrencyType currencyType, bool flag = false)
	{
	}

	[Token(Token = "0x60138DA")]
	[Address(RVA = "0x30CE658", Offset = "0x30CE658", VA = "0x30CE658")]
	public void ClearNewAvatarShowList()
	{
	}

	[Token(Token = "0x60138DB")]
	[Address(RVA = "0x30CE718", Offset = "0x30CE718", VA = "0x30CE718")]
	public void ClearNewAvatarById(uint id)
	{
	}

	[Token(Token = "0x60138DC")]
	[Address(RVA = "0x30CE7E4", Offset = "0x30CE7E4", VA = "0x30CE7E4")]
	public bool CheckAavatarIsNew(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60138DD")]
	[Address(RVA = "0x30CE8B0", Offset = "0x30CE8B0", VA = "0x30CE8B0")]
	public void UpdateNewItem(Item[] newInventories)
	{
	}

	[Token(Token = "0x60138DE")]
	[Address(RVA = "0x30CED8C", Offset = "0x30CED8C", VA = "0x30CED8C")]
	private void ShowRewardList(Item awardItem, bool showmax = false)
	{
	}

	[Token(Token = "0x60138DF")]
	[Address(RVA = "0x30CF268", Offset = "0x30CF268", VA = "0x30CF268")]
	public void RequestUseUpgradeCard(uint avatarID, uint upgradeCardID)
	{
	}

	[Token(Token = "0x60138E0")]
	[Address(RVA = "0x30CF2D8", Offset = "0x30CF2D8", VA = "0x30CF2D8")]
	public int GetUpgradeCardToLevel(int _cardId)
	{
		return default(int);
	}

	[Token(Token = "0x60138E1")]
	[Address(RVA = "0x30CF498", Offset = "0x30CF498", VA = "0x30CF498")]
	public int GetSkillLevelByUsingLevelCard(int _cardId, int avatarid)
	{
		return default(int);
	}

	[Token(Token = "0x60138E2")]
	[Address(RVA = "0x30CF740", Offset = "0x30CF740", VA = "0x30CF740")]
	public int GetSkillLvByCurrentProfileLv(int profileLv)
	{
		return default(int);
	}

	[Token(Token = "0x60138E3")]
	[Address(RVA = "0x30CF80C", Offset = "0x30CF80C", VA = "0x30CF80C")]
	public List<AvatarProfileDataOverrided> GetUseUpgradeCardRewardList(int _avatarid, int tolevel)
	{
		return null;
	}

	[Token(Token = "0x60138E4")]
	[Address(RVA = "0x30CFA98", Offset = "0x30CFA98", VA = "0x30CFA98")]
	public bool HasItemRewardAfterUnlockProfile(uint avatarId, int toProfileLv)
	{
		return default(bool);
	}

	[Token(Token = "0x60138E5")]
	[Address(RVA = "0x30CFCCC", Offset = "0x30CFCCC", VA = "0x30CFCCC")]
	public uint GetAvatarLevelCardGoPos(uint levelCardId)
	{
		return default(uint);
	}

	[Token(Token = "0x60138E6")]
	[Address(RVA = "0x30CFE58", Offset = "0x30CFE58", VA = "0x30CFE58")]
	public void ProcessAvatarGoPosDate(CSGetGoPosRes res)
	{
	}

	[Token(Token = "0x60138E7")]
	[Address(RVA = "0x30D0130", Offset = "0x30D0130", VA = "0x30D0130")]
	public GoPos GetAvatarOrPetGoPosData(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60138E8")]
	[Address(RVA = "0x30D04E0", Offset = "0x30D04E0", VA = "0x30D04E0")]
	public GoPos GetAvatarBundleGoPosData(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x60138E9")]
	[Address(RVA = "0x30D03B0", Offset = "0x30D03B0", VA = "0x30D03B0")]
	private Predicate<GoPos> FindGoPosByTime(ulong now)
	{
		return null;
	}

	[Token(Token = "0x60138EA")]
	[Address(RVA = "0x30D09B8", Offset = "0x30D09B8", VA = "0x30D09B8")]
	private int SortGoPos(GoPos a, GoPos b)
	{
		return default(int);
	}

	[Token(Token = "0x60138EB")]
	[Address(RVA = "0x30D0AB4", Offset = "0x30D0AB4", VA = "0x30D0AB4")]
	public void RequestEquipSkill(uint avatarID, int skillID, int slotIndex)
	{
	}

	[Token(Token = "0x60138EC")]
	[Address(RVA = "0x30D1268", Offset = "0x30D1268", VA = "0x30D1268")]
	public void RequestUnLockSkillSlot(uint avatarID, int slotIndex, proto.EInventory.CurrencyType currencyType)
	{
	}

	[Token(Token = "0x60138ED")]
	[Address(RVA = "0x30D16F4", Offset = "0x30D16F4", VA = "0x30D16F4")]
	public void RequestUseUniversalDebris(uint targetDebrisID, int ExchangeUniversaldebrisCnt, uint avatarID)
	{
	}

	[Token(Token = "0x60138EE")]
	[Address(RVA = "0x30D1768", Offset = "0x30D1768", VA = "0x30D1768")]
	private void UpdateAvatarFirstSlotSkills(proto.AvatarProfile profileInfo)
	{
	}

	[Token(Token = "0x60138EF")]
	[Address(RVA = "0x30C7E6C", Offset = "0x30C7E6C", VA = "0x30C7E6C")]
	private void UpdateAvatarEquippedSkills(proto.AvatarProfile profileInfo)
	{
	}

	[Token(Token = "0x60138F1")]
	[Address(RVA = "0x30D181C", Offset = "0x30D181C", VA = "0x30D181C")]
	public void OnLimitAvatarChange(proto.AvatarProfile profileRes, List<Item> rewards)
	{
	}

	[Token(Token = "0x60138F2")]
	[Address(RVA = "0x30D1B44", Offset = "0x30D1B44", VA = "0x30D1B44")]
	public void OnLimitAvatarExpire(List<Item> expireItems)
	{
	}

	[Token(Token = "0x60138F3")]
	[Address(RVA = "0x30D1EC4", Offset = "0x30D1EC4", VA = "0x30D1EC4")]
	private void ProcessExpireAvatar(AvatarProfile profile)
	{
	}

	[Token(Token = "0x60138F4")]
	[Address(RVA = "0x30D1F80", Offset = "0x30D1F80", VA = "0x30D1F80")]
	public bool CheckHasAvatarExpire()
	{
		return default(bool);
	}

	[Token(Token = "0x60138F5")]
	[Address(RVA = "0x30D21D4", Offset = "0x30D21D4", VA = "0x30D21D4")]
	public List<uint> GetExpireAvatarLst()
	{
		return null;
	}

	[Token(Token = "0x60138F6")]
	[Address(RVA = "0x30D2558", Offset = "0x30D2558", VA = "0x30D2558")]
	public bool IsLimitAvatar(uint avatarId)
	{
		return default(bool);
	}

	[Token(Token = "0x60138F7")]
	[Address(RVA = "0x30D266C", Offset = "0x30D266C", VA = "0x30D266C")]
	public bool IsAvatarExpire(uint avatarId)
	{
		return default(bool);
	}

	[Token(Token = "0x60138F8")]
	[Address(RVA = "0x30CE464", Offset = "0x30CE464", VA = "0x30CE464")]
	private bool CheckAvatarAvalible(uint avatarId)
	{
		return default(bool);
	}

	[Token(Token = "0x60138F9")]
	[Address(RVA = "0x30C8078", Offset = "0x30C8078", VA = "0x30C8078")]
	private uint DoSelectOneAvatarShow(List<proto.AvatarProfile> profiles)
	{
		return default(uint);
	}

	[Token(Token = "0x60138FA")]
	[Address(RVA = "0x30D27E8", Offset = "0x30D27E8", VA = "0x30D27E8")]
	public uint GetHasAvatar()
	{
		return default(uint);
	}

	[Token(Token = "0x60138FB")]
	[Address(RVA = "0x30D2A00", Offset = "0x30D2A00", VA = "0x30D2A00")]
	public void CheckHasExpireAvatarOnReturnLobby()
	{
	}

	[Token(Token = "0x60138FC")]
	[Address(RVA = "0x30CD0B4", Offset = "0x30CD0B4", VA = "0x30CD0B4")]
	public bool IsAwakenAvatar(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138FD")]
	[Address(RVA = "0x30D2BA8", Offset = "0x30D2BA8", VA = "0x30D2BA8")]
	public bool ShouldShowAwakenEntry(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138FE")]
	[Address(RVA = "0x30C938C", Offset = "0x30C938C", VA = "0x30C938C")]
	public bool NeedShowSingleInAvatarList(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60138FF")]
	[Address(RVA = "0x30D2CB4", Offset = "0x30D2CB4", VA = "0x30D2CB4")]
	public uint GetAwakenAvatarId(uint avatarid)
	{
		return default(uint);
	}

	[Token(Token = "0x6013900")]
	[Address(RVA = "0x30D2DC0", Offset = "0x30D2DC0", VA = "0x30D2DC0")]
	public void ProcessAvatarAwakenInfo(CSGetAvatarAwakenRes res)
	{
	}

	[Token(Token = "0x6013901")]
	[Address(RVA = "0x30D33D0", Offset = "0x30D33D0", VA = "0x30D33D0")]
	public void RefreshAvatarAwakenState()
	{
	}

	[Token(Token = "0x6013902")]
	[Address(RVA = "0x30D3804", Offset = "0x30D3804", VA = "0x30D3804")]
	public AvatarSkill GetAwakenSkillByOriAvatarID(uint oriAvatarID)
	{
		return null;
	}

	[Token(Token = "0x6013903")]
	[Address(RVA = "0x30D3AA8", Offset = "0x30D3AA8", VA = "0x30D3AA8")]
	public int GetCanAvatarAwakenNeedLevel(uint oriAvatarID)
	{
		return default(int);
	}

	[Token(Token = "0x6013904")]
	[Address(RVA = "0x30D3CE4", Offset = "0x30D3CE4", VA = "0x30D3CE4")]
	public AvatarAwaken GetAwakenInfo(uint oriAvatarID)
	{
		return null;
	}

	[Token(Token = "0x6013905")]
	[Address(RVA = "0x30D3DF4", Offset = "0x30D3DF4", VA = "0x30D3DF4")]
	public AwakenComic GetAwakenComicInfo(uint oriAvatarID, uint comicID)
	{
		return null;
	}

	[Token(Token = "0x6013906")]
	[Address(RVA = "0x30D3F34", Offset = "0x30D3F34", VA = "0x30D3F34")]
	public uint GetCurrentUnlockAwakenComicCount(uint oriAvatarID)
	{
		return default(uint);
	}

	[Token(Token = "0x6013907")]
	[Address(RVA = "0x30D41B4", Offset = "0x30D41B4", VA = "0x30D41B4")]
	public uint GetCurrentUnlockAwakenComicFragmentsCnt(uint oriAvatarID)
	{
		return default(uint);
	}

	[Token(Token = "0x6013908")]
	[Address(RVA = "0x30D4428", Offset = "0x30D4428", VA = "0x30D4428")]
	public void RequestClaimAvatarAwaken(uint origionalID)
	{
	}

	[Token(Token = "0x6013909")]
	[Address(RVA = "0x30D4678", Offset = "0x30D4678", VA = "0x30D4678")]
	public void RequestGetAvatarAwakenComicInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601390A")]
	[Address(RVA = "0x30D48B0", Offset = "0x30D48B0", VA = "0x30D48B0")]
	private void UpdateAvatarAwakenComic(List<AwakenComic> ComicList)
	{
	}

	[Token(Token = "0x601390B")]
	[Address(RVA = "0x30D4CAC", Offset = "0x30D4CAC", VA = "0x30D4CAC")]
	public void RequestRefreshAvatarAwakenTaskInfo(uint origionalID)
	{
	}

	[Token(Token = "0x601390C")]
	[Address(RVA = "0x30D503C", Offset = "0x30D503C", VA = "0x30D503C")]
	private void UpdateAvatarAwakenRefreshCount(uint origionalID, uint count)
	{
	}

	[Token(Token = "0x601390D")]
	[Address(RVA = "0x30D5124", Offset = "0x30D5124", VA = "0x30D5124")]
	public uint GetCurrentRefreshCount(uint origionalID)
	{
		return default(uint);
	}

	[Token(Token = "0x601390E")]
	[Address(RVA = "0x30C95F8", Offset = "0x30C95F8", VA = "0x30C95F8")]
	public uint GetCurrentFinishTaskCount(uint origionalID)
	{
		return default(uint);
	}

	[Token(Token = "0x601390F")]
	[Address(RVA = "0x30D5230", Offset = "0x30D5230", VA = "0x30D5230")]
	public void RequestUnlockAvatarAwakenComic(uint origionalID, uint comicID)
	{
	}

	[Token(Token = "0x6013910")]
	[Address(RVA = "0x30D3BA0", Offset = "0x30D3BA0", VA = "0x30D3BA0")]
	public uint GetExChangeAwakenAvatarID(uint avatarID)
	{
		return default(uint);
	}

	[Token(Token = "0x6013911")]
	[Address(RVA = "0x30D5528", Offset = "0x30D5528", VA = "0x30D5528")]
	public uint AwakenIdToOriId(uint awakenAvatarID)
	{
		return default(uint);
	}

	[Token(Token = "0x6013912")]
	[Address(RVA = "0x30D5740", Offset = "0x30D5740", VA = "0x30D5740")]
	private void UpdateAvatarAwakenTask(List<AwakenTask> taskList)
	{
	}

	[Token(Token = "0x6013913")]
	[Address(RVA = "0x30D5B3C", Offset = "0x30D5B3C", VA = "0x30D5B3C")]
	private void UpdateAvatarAwakenTask(List<AwakenTask> taskList, uint avatarID)
	{
	}

	[Token(Token = "0x6013914")]
	[Address(RVA = "0x30D5D98", Offset = "0x30D5D98", VA = "0x30D5D98")]
	public bool CanClaimAwakenAvatarAward(uint oriAvatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013915")]
	[Address(RVA = "0x30D6264", Offset = "0x30D6264", VA = "0x30D6264")]
	public uint GetOnlyAwakenId(uint avatarid)
	{
		return default(uint);
	}

	[Token(Token = "0x6013916")]
	[Address(RVA = "0x30CEABC", Offset = "0x30CEABC", VA = "0x30CEABC")]
	public uint GetOnlyOriginId(uint avatarid)
	{
		return default(uint);
	}

	[Token(Token = "0x6013917")]
	[Address(RVA = "0x30C9498", Offset = "0x30C9498", VA = "0x30C9498")]
	public bool HasAwakenAvatar(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013918")]
	[Address(RVA = "0x30D62EC", Offset = "0x30D62EC", VA = "0x30D62EC")]
	public bool HasAvatar(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6013919")]
	[Address(RVA = "0x30D6428", Offset = "0x30D6428", VA = "0x30D6428")]
	public uint HasOwnedAvatarNum()
	{
		return default(uint);
	}

	[Token(Token = "0x601391A")]
	[Address(RVA = "0x30D67F8", Offset = "0x30D67F8", VA = "0x30D67F8")]
	public List<AwakenTask> GetAwakenTaskList(uint oriAvatarID)
	{
		return null;
	}

	[Token(Token = "0x601391B")]
	[Address(RVA = "0x30D6944", Offset = "0x30D6944", VA = "0x30D6944")]
	public AwakenTask GetAwakenTaskInfo(uint oriAvatarID, uint taskType)
	{
		return null;
	}

	[Token(Token = "0x601391C")]
	[Address(RVA = "0x30CEB44", Offset = "0x30CEB44", VA = "0x30CEB44")]
	public void RequestAvatarAwakenTaskDesc(bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601391D")]
	[Address(RVA = "0x30D6B04", Offset = "0x30D6B04", VA = "0x30D6B04")]
	public void AutoOpenBundle(uint bundleID, [Optional] Action callback)
	{
	}

	[Token(Token = "0x601391E")]
	[Address(RVA = "0x30D6D88", Offset = "0x30D6D88", VA = "0x30D6D88")]
	public void OnAwakenTaskStateChange(List<AwakenTaskChangeInfo> res)
	{
	}

	[Token(Token = "0x601391F")]
	[Address(RVA = "0x30D7430", Offset = "0x30D7430", VA = "0x30D7430")]
	public void RequestClaimAwakenTaskReward(uint avatarID, uint taskID)
	{
	}

	[Token(Token = "0x6013920")]
	[Address(RVA = "0x30D7734", Offset = "0x30D7734", VA = "0x30D7734")]
	public bool HasUnClaimAwakenTaskReward(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013921")]
	[Address(RVA = "0x30D79D8", Offset = "0x30D79D8", VA = "0x30D79D8")]
	public bool HasNewUnlockAwakenComic(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013922")]
	[Address(RVA = "0x30D6FF8", Offset = "0x30D6FF8", VA = "0x30D6FF8")]
	public void UpdateAvatarAwakenTaskState(uint avatarID, uint taskId, proto.EProfile.TaskState state, uint process = 0u)
	{
	}

	[Token(Token = "0x6013923")]
	[Address(RVA = "0x30D7BBC", Offset = "0x30D7BBC", VA = "0x30D7BBC")]
	public void RequestUpgradeAwakenSkill(uint avatarID)
	{
	}

	[Token(Token = "0x6013924")]
	[Address(RVA = "0x30D7C3C", Offset = "0x30D7C3C", VA = "0x30D7C3C")]
	public bool CanUpgradeAwakenSkill(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013925")]
	[Address(RVA = "0x30D7EFC", Offset = "0x30D7EFC", VA = "0x30D7EFC")]
	public bool ShowExchangeAwakenAvatarBtn(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013926")]
	[Address(RVA = "0x30D5EA4", Offset = "0x30D5EA4", VA = "0x30D5EA4")]
	public bool IsAwakenFinished(uint oriAvatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013927")]
	[Address(RVA = "0x30C985C", Offset = "0x30C985C", VA = "0x30C985C")]
	public bool IsOriAvatrLevelSatisfyForAwaken(uint oriAvatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x6013928")]
	[Address(RVA = "0x30D7F84", Offset = "0x30D7F84", VA = "0x30D7F84")]
	public proto.AvatarProfile GetAccountAvatarProfileById(ulong accountId)
	{
		return null;
	}

	[Token(Token = "0x6013929")]
	[Address(RVA = "0x30D8084", Offset = "0x30D8084", VA = "0x30D8084")]
	public void ClearProfileAccountIDCache()
	{
	}

	[Token(Token = "0x601392A")]
	[Address(RVA = "0x30D8144", Offset = "0x30D8144", VA = "0x30D8144")]
	public void TryRequestAvatarProfile(List<ulong> accountIDList, uint httpOp = 0u)
	{
	}

	[Token(Token = "0x601392B")]
	[Address(RVA = "0x30D86E0", Offset = "0x30D86E0", VA = "0x30D86E0")]
	private void BatchRequestAvatarProfileInCache()
	{
	}

	[Token(Token = "0x601392C")]
	[Address(RVA = "0x30D8408", Offset = "0x30D8408", VA = "0x30D8408")]
	public void RequestGeAvatarProfileBatch(List<ulong> accountIdList, uint httpOp = 0u)
	{
	}

	[Token(Token = "0x601392D")]
	[Address(RVA = "0x30D8940", Offset = "0x30D8940", VA = "0x30D8940")]
	public List<AvatarProfile> GetOwnedAvatarInfo()
	{
		return null;
	}

	[Token(Token = "0x601392E")]
	[Address(RVA = "0x30D8BEC", Offset = "0x30D8BEC", VA = "0x30D8BEC")]
	public List<ResourceID> GetOwnedAvatarResourceId()
	{
		return null;
	}

	[Token(Token = "0x601392F")]
	[Address(RVA = "0x30D8F18", Offset = "0x30D8F18", VA = "0x30D8F18")]
	private bool _003CUpdateTips_003Em__0(AvatarProfile a)
	{
		return default(bool);
	}

	[Token(Token = "0x6013930")]
	[Address(RVA = "0x30D8F64", Offset = "0x30D8F64", VA = "0x30D8F64")]
	private void _003CRequestMyAvatarList_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013931")]
	[Address(RVA = "0x30D9208", Offset = "0x30D9208", VA = "0x30D9208")]
	private void _003CForceRequestAvatarList_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013932")]
	[Address(RVA = "0x30D9378", Offset = "0x30D9378", VA = "0x30D9378")]
	private void _003CRequestSkillList_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013933")]
	[Address(RVA = "0x30D94B8", Offset = "0x30D94B8", VA = "0x30D94B8")]
	private void _003CRequestLoginGetProfile_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013934")]
	[Address(RVA = "0x30D9F7C", Offset = "0x30D9F7C", VA = "0x30D9F7C")]
	private void _003CRequestHideAvatars_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013935")]
	[Address(RVA = "0x30DA088", Offset = "0x30DA088", VA = "0x30DA088")]
	private static void _003CChangeOnlyMsgAvatar_003Em__6(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013936")]
	[Address(RVA = "0x30DA08C", Offset = "0x30DA08C", VA = "0x30DA08C")]
	private static void _003CRequestUnlockAvatarHiddenly_003Em__7(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013937")]
	[Address(RVA = "0x30DA090", Offset = "0x30DA090", VA = "0x30DA090")]
	private static void _003CShowRewardList_003Em__8()
	{
	}

	[Token(Token = "0x6013938")]
	[Address(RVA = "0x30DA150", Offset = "0x30DA150", VA = "0x30DA150")]
	private static CommonRewardItemInfo _003CShowRewardList_003Em__9(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013939")]
	[Address(RVA = "0x30DA158", Offset = "0x30DA158", VA = "0x30DA158")]
	private void _003CRequestEquipSkill_003Em__A(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601393A")]
	[Address(RVA = "0x30DA348", Offset = "0x30DA348", VA = "0x30DA348")]
	private static CommonRewardItemInfo _003COnLimitAvatarChange_003Em__B(Item item)
	{
		return null;
	}

	[Token(Token = "0x601393B")]
	[Address(RVA = "0x30DA350", Offset = "0x30DA350", VA = "0x30DA350")]
	private static uint _003CDoSelectOneAvatarShow_003Em__C(proto.AvatarProfile p)
	{
		return default(uint);
	}

	[Token(Token = "0x601393C")]
	[Address(RVA = "0x30DA374", Offset = "0x30DA374", VA = "0x30DA374")]
	private void _003CRequestClaimAvatarAwaken_003Em__D(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601393D")]
	[Address(RVA = "0x30DA73C", Offset = "0x30DA73C", VA = "0x30DA73C")]
	private void _003CRequestGetAvatarAwakenComicInfo_003Em__E(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601393E")]
	[Address(RVA = "0x30DA8AC", Offset = "0x30DA8AC", VA = "0x30DA8AC")]
	private static uint _003CAwakenIdToOriId_003Em__F(KeyValuePair<uint, uint> e)
	{
		return default(uint);
	}

	[Token(Token = "0x601393F")]
	[Address(RVA = "0x30DA91C", Offset = "0x30DA91C", VA = "0x30DA91C")]
	private bool _003CHasOwnedAvatarNum_003Em__10(AvatarProfile a)
	{
		return default(bool);
	}

	[Token(Token = "0x6013940")]
	[Address(RVA = "0x30DA990", Offset = "0x30DA990", VA = "0x30DA990")]
	private static bool _003CHasOwnedAvatarNum_003Em__11(AvatarProfile x)
	{
		return default(bool);
	}

	[Token(Token = "0x6013941")]
	[Address(RVA = "0x30DA9B4", Offset = "0x30DA9B4", VA = "0x30DA9B4")]
	private void _003CRequestAvatarAwakenTaskDesc_003Em__12(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013942")]
	[Address(RVA = "0x30DAC14", Offset = "0x30DAC14", VA = "0x30DAC14")]
	private void _003CRequestLoginGetProfile_003Em__13()
	{
	}

	[Token(Token = "0x6013943")]
	[Address(RVA = "0x30DAC20", Offset = "0x30DAC20", VA = "0x30DAC20")]
	private static CommonRewardItemInfo _003CRequestClaimAvatarAwaken_003Em__14(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6013944")]
	[Address(RVA = "0x30DAC28", Offset = "0x30DAC28", VA = "0x30DAC28")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013945")]
	[Address(RVA = "0x30DAC30", Offset = "0x30DAC30", VA = "0x30DAC30")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
