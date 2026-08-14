using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20032B0")]
public class UIModelVeteranSignin : UIBaseModel
{
	[Token(Token = "0x20032B1")]
	private sealed class _003CGetBigPrizeDescById_003Ec__AnonStorey0
	{
		[Token(Token = "0x40134FD")]
		[FieldOffset(Offset = "0x8")]
		internal int Id;

		[Token(Token = "0x601565C")]
		[Address(RVA = "0x1936B94", Offset = "0x1936B94", VA = "0x1936B94")]
		public _003CGetBigPrizeDescById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601565D")]
		[Address(RVA = "0x193F6D8", Offset = "0x193F6D8", VA = "0x193F6D8")]
		internal bool _003C_003Em__0(VeteranBigPrizeDesc a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032B2")]
	private sealed class _003CGetBigPriceStateById_003Ec__AnonStorey1
	{
		[Token(Token = "0x40134FE")]
		[FieldOffset(Offset = "0x8")]
		internal int Id;

		[Token(Token = "0x601565E")]
		[Address(RVA = "0x1936E18", Offset = "0x1936E18", VA = "0x1936E18")]
		public _003CGetBigPriceStateById_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601565F")]
		[Address(RVA = "0x193F618", Offset = "0x193F618", VA = "0x193F618")]
		internal bool _003C_003Em__0(VeteranBigPrizeIndexStatus a)
		{
			return default(bool);
		}

		[Token(Token = "0x6015660")]
		[Address(RVA = "0x193F658", Offset = "0x193F658", VA = "0x193F658")]
		internal bool _003C_003Em__1(VeteranBigPrizeDesc a)
		{
			return default(bool);
		}

		[Token(Token = "0x6015661")]
		[Address(RVA = "0x193F698", Offset = "0x193F698", VA = "0x193F698")]
		internal bool _003C_003Em__2(VeteranBigPrizeDesc a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032B3")]
	private sealed class _003CRequestSignin_003Ec__AnonStorey2
	{
		[Token(Token = "0x40134FF")]
		[FieldOffset(Offset = "0x8")]
		internal int rewardIndex;

		[Token(Token = "0x4013500")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x6015662")]
		[Address(RVA = "0x193A0D0", Offset = "0x193A0D0", VA = "0x193A0D0")]
		public _003CRequestSignin_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6015663")]
		[Address(RVA = "0x19414AC", Offset = "0x19414AC", VA = "0x19414AC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20032B4")]
	private sealed class _003CGetTaskInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x4013501")]
		[FieldOffset(Offset = "0x8")]
		internal uint taskId;

		[Token(Token = "0x6015664")]
		[Address(RVA = "0x193A21C", Offset = "0x193A21C", VA = "0x193A21C")]
		public _003CGetTaskInfo_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015665")]
		[Address(RVA = "0x1940440", Offset = "0x1940440", VA = "0x1940440")]
		internal bool _003C_003Em__0(VeteranTaskInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032B5")]
	private sealed class _003CGetTaskDesc_003Ec__AnonStorey4
	{
		[Token(Token = "0x4013502")]
		[FieldOffset(Offset = "0x8")]
		internal uint taskId;

		[Token(Token = "0x6015666")]
		[Address(RVA = "0x193A368", Offset = "0x193A368", VA = "0x193A368")]
		public _003CGetTaskDesc_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6015667")]
		[Address(RVA = "0x193FD40", Offset = "0x193FD40", VA = "0x193FD40")]
		internal bool _003C_003Em__0(ClientVeteranTaskDesc temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032B6")]
	private sealed class _003CGetTaskDesc_003Ec__AnonStorey5
	{
		[Token(Token = "0x4013503")]
		[FieldOffset(Offset = "0x8")]
		internal bool preload;

		[Token(Token = "0x4013504")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x4013505")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<VeteranBigPrizeDesc> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4013506")]
		[FieldOffset(Offset = "0x4")]
		private static Predicate<VeteranBigPrizeDesc> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6015668")]
		[Address(RVA = "0x193A448", Offset = "0x193A448", VA = "0x193A448")]
		public _003CGetTaskDesc_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6015669")]
		[Address(RVA = "0x193FD78", Offset = "0x193FD78", VA = "0x193FD78")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601566A")]
		[Address(RVA = "0x194027C", Offset = "0x194027C", VA = "0x194027C")]
		private static bool _003C_003Em__1(VeteranBigPrizeDesc e)
		{
			return default(bool);
		}

		[Token(Token = "0x601566B")]
		[Address(RVA = "0x1940398", Offset = "0x1940398", VA = "0x1940398")]
		private static bool _003C_003Em__2(VeteranBigPrizeDesc e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032B7")]
	private sealed class _003CGetTaskInfo_003Ec__AnonStorey6
	{
		[Token(Token = "0x4013507")]
		[FieldOffset(Offset = "0x8")]
		internal bool preload;

		[Token(Token = "0x4013508")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x601566C")]
		[Address(RVA = "0x193AC10", Offset = "0x193AC10", VA = "0x193AC10")]
		public _003CGetTaskInfo_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x601566D")]
		[Address(RVA = "0x1940478", Offset = "0x1940478", VA = "0x1940478")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20032B8")]
	private sealed class _003CGetTaskRewards_003Ec__AnonStorey7
	{
		[Token(Token = "0x4013509")]
		[FieldOffset(Offset = "0x8")]
		internal ClientVeteranTaskDesc desc;

		[Token(Token = "0x401350A")]
		[FieldOffset(Offset = "0xC")]
		internal int index;

		[Token(Token = "0x401350B")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x401350C")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601566E")]
		[Address(RVA = "0x193B27C", Offset = "0x193B27C", VA = "0x193B27C")]
		public _003CGetTaskRewards_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x601566F")]
		[Address(RVA = "0x1940698", Offset = "0x1940698", VA = "0x1940698")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015670")]
		[Address(RVA = "0x1940E7C", Offset = "0x1940E7C", VA = "0x1940E7C")]
		internal bool _003C_003Em__1(VeteranTaskInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6015671")]
		[Address(RVA = "0x1940EC8", Offset = "0x1940EC8", VA = "0x1940EC8")]
		private static CommonRewardItemInfo _003C_003Em__2(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6015672")]
		[Address(RVA = "0x1940ED0", Offset = "0x1940ED0", VA = "0x1940ED0")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x20032B9")]
	private sealed class _003CGetTaskBigPrize_003Ec__AnonStorey8
	{
		[Token(Token = "0x401350D")]
		[FieldOffset(Offset = "0x8")]
		internal int Id;

		[Token(Token = "0x401350E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x401350F")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4013510")]
		[FieldOffset(Offset = "0x4")]
		private static Action _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6015673")]
		[Address(RVA = "0x193B708", Offset = "0x193B708", VA = "0x193B708")]
		public _003CGetTaskBigPrize_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6015674")]
		[Address(RVA = "0x193F718", Offset = "0x193F718", VA = "0x193F718")]
		internal bool _003C_003Em__0(VeteranBigPrizeDesc a)
		{
			return default(bool);
		}

		[Token(Token = "0x6015675")]
		[Address(RVA = "0x193F758", Offset = "0x193F758", VA = "0x193F758")]
		internal void _003C_003Em__1(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015676")]
		[Address(RVA = "0x193FC78", Offset = "0x193FC78", VA = "0x193FC78")]
		private static CommonRewardItemInfo _003C_003Em__2(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6015677")]
		[Address(RVA = "0x193FC80", Offset = "0x193FC80", VA = "0x193FC80")]
		private static void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x20032BA")]
	private sealed class _003CRequestConfirmVeteranBundleItem_003Ec__AnonStorey9
	{
		[Token(Token = "0x4013511")]
		[FieldOffset(Offset = "0x8")]
		internal uint[] optionalOrderIDs;

		[Token(Token = "0x4013512")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x6015678")]
		[Address(RVA = "0x193DB38", Offset = "0x193DB38", VA = "0x193DB38")]
		public _003CRequestConfirmVeteranBundleItem_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6015679")]
		[Address(RVA = "0x19413D8", Offset = "0x19413D8", VA = "0x19413D8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x20032BB")]
	private sealed class _003CRequestClaimVeteranBundleAward_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4013513")]
		[FieldOffset(Offset = "0x8")]
		internal int slot;

		[Token(Token = "0x4013514")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelVeteranSignin _0024this;

		[Token(Token = "0x601567A")]
		[Address(RVA = "0x193E5A4", Offset = "0x193E5A4", VA = "0x193E5A4")]
		public _003CRequestClaimVeteranBundleAward_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x601567B")]
		[Address(RVA = "0x1941020", Offset = "0x1941020", VA = "0x1941020")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}

		[Token(Token = "0x601567C")]
		[Address(RVA = "0x1941394", Offset = "0x1941394", VA = "0x1941394")]
		internal bool _003C_003Em__1(VeteranAwardDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40134CD")]
	public const string PROGRESS_FORMAT = "{0}/{1}";

	[Token(Token = "0x40134CE")]
	public const uint VETERANTOKENID = 802000027u;

	[Token(Token = "0x40134CF")]
	private const int GIFTNUM = 6;

	[Token(Token = "0x40134D0")]
	public const int BIG_PRICE_NUMBER = 3;

	[Token(Token = "0x40134D1")]
	public const int SLOTCOUNT = 6;

	[Token(Token = "0x40134D2")]
	public const int BIGPRIZESLOT = 2;

	[Token(Token = "0x40134D3")]
	public const string DEFAULTLANG = "default";

	[Token(Token = "0x40134D4")]
	public const uint PropID_VeteranRewardUpdate = 2u;

	[Token(Token = "0x40134D5")]
	public const uint PropID_GetReward = 4u;

	[Token(Token = "0x40134D6")]
	public const uint PropID_GetTaskDesc = 8u;

	[Token(Token = "0x40134D7")]
	public const uint PropID_GetTaskInfo = 16u;

	[Token(Token = "0x40134D8")]
	public const uint PropID_GetTaskRewards = 32u;

	[Token(Token = "0x40134D9")]
	public const uint PropID_GetTaskBigPrize = 64u;

	[Token(Token = "0x40134DA")]
	public const uint PropID_GetVeteranAward = 128u;

	[Token(Token = "0x40134DB")]
	public const uint PropID_GetClaimReturnAward = 256u;

	[Token(Token = "0x40134DC")]
	public const uint PropID_GetClaimBundleAward = 512u;

	[Token(Token = "0x40134DD")]
	public const uint PropID_UpdateTaskInfo = 1024u;

	[Token(Token = "0x40134DE")]
	public const uint PropID_GetVeteranConfig = 2048u;

	[Token(Token = "0x40134DF")]
	public const uint PropID_ConfirmSelectVeteranBundle = 4096u;

	[Token(Token = "0x40134E0")]
	[FieldOffset(Offset = "0xC")]
	private bool m_WaitingForSigninResponse;

	[Token(Token = "0x40134E1")]
	[FieldOffset(Offset = "0x10")]
	private WaitingResponseHandler m_WaitingHandler;

	[Token(Token = "0x40134E2")]
	[FieldOffset(Offset = "0x14")]
	private List<ClientVeteranTaskDesc> m_TaskDescs;

	[Token(Token = "0x40134E3")]
	[FieldOffset(Offset = "0x18")]
	private List<VeteranTaskInfo> m_TaskInfos;

	[Token(Token = "0x40134E4")]
	[FieldOffset(Offset = "0x1C")]
	private VeteranBigPrizeDesc _003CBigPrizeDesc_003Ek__BackingField;

	[Token(Token = "0x40134E5")]
	[FieldOffset(Offset = "0x20")]
	private ulong _003CVeteranEndTimeStamp_003Ek__BackingField;

	[Token(Token = "0x40134E6")]
	[FieldOffset(Offset = "0x28")]
	private VeteranConfigDesc _003CVeteranConfigDesc_003Ek__BackingField;

	[Token(Token = "0x40134E7")]
	[FieldOffset(Offset = "0x2C")]
	private List<VeteranBigPrizeDesc> m_BigPrizeDescList;

	[Token(Token = "0x40134E8")]
	[FieldOffset(Offset = "0x30")]
	private List<VeteranBigPrizeIndexStatus> m_BigPriceStateList;

	[Token(Token = "0x40134E9")]
	[FieldOffset(Offset = "0x34")]
	private List<VeteranRewardItem> m_VeteranRewardList;

	[Token(Token = "0x40134EA")]
	[FieldOffset(Offset = "0x38")]
	private List<BatchShowContentDesc> m_BatchShowContentList;

	[Token(Token = "0x40134EB")]
	[FieldOffset(Offset = "0x3C")]
	private List<VeteranAwardDesc> m_VeteranAwardDescList;

	[Token(Token = "0x40134EC")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, List<VeteranAwardDesc>> m_VeteranAwardDescDic;

	[Token(Token = "0x40134ED")]
	[FieldOffset(Offset = "0x44")]
	private AwardData m_ClaimVeteranReturnAward;

	[Token(Token = "0x40134EE")]
	[FieldOffset(Offset = "0x48")]
	private CSGetVeteranRewardListRes _003CVeteranRewardListRes_003Ek__BackingField;

	[Token(Token = "0x40134EF")]
	[FieldOffset(Offset = "0x4C")]
	public List<uint> m_ClimedBundleList;

	[Token(Token = "0x40134F0")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, List<OptionalBundleShowData>> m_SortBundleDic;

	[Token(Token = "0x40134F1")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<int, uint> m_PreviewDict;

	[Token(Token = "0x40134F2")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PREF_VETERAN_README_DOT;

	[Token(Token = "0x40134F3")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsClaimReturn;

	[Token(Token = "0x40134F4")]
	[FieldOffset(Offset = "0x59")]
	private bool m_IsVeteran;

	[Token(Token = "0x40134F5")]
	[FieldOffset(Offset = "0x5A")]
	private bool m_IsFirstVeteran;

	[Token(Token = "0x40134F6")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_WeaponId;

	[Token(Token = "0x40134F7")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsSencondConfirmBtnClick;

	[Token(Token = "0x40134F8")]
	[FieldOffset(Offset = "0x61")]
	private bool m_HasIsVeteran;

	[Token(Token = "0x40134F9")]
	[FieldOffset(Offset = "0x62")]
	private bool m_PreloadedTaskDesc;

	[Token(Token = "0x40134FA")]
	[FieldOffset(Offset = "0x63")]
	private bool m_PreloadedTaskInfo;

	[Token(Token = "0x40134FB")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<VeteranRewardItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40134FC")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<VeteranAwardDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x1700169C")]
	public List<ClientVeteranTaskDesc> TaskDescs
	{
		[Token(Token = "0x6015604")]
		[Address(RVA = "0x19362EC", Offset = "0x19362EC", VA = "0x19362EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700169D")]
	public List<VeteranTaskInfo> TaskInfos
	{
		[Token(Token = "0x6015605")]
		[Address(RVA = "0x1936344", Offset = "0x1936344", VA = "0x1936344")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700169E")]
	public VeteranBigPrizeDesc BigPrizeDesc
	{
		[Token(Token = "0x6015607")]
		[Address(RVA = "0x19363A4", Offset = "0x19363A4", VA = "0x19363A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015606")]
		[Address(RVA = "0x193639C", Offset = "0x193639C", VA = "0x193639C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700169F")]
	public string LocLang
	{
		[Token(Token = "0x6015608")]
		[Address(RVA = "0x19363AC", Offset = "0x19363AC", VA = "0x19363AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A0")]
	public ulong VeteranEndTimeStamp
	{
		[Token(Token = "0x601560A")]
		[Address(RVA = "0x19364C0", Offset = "0x19364C0", VA = "0x19364C0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6015609")]
		[Address(RVA = "0x19364B0", Offset = "0x19364B0", VA = "0x19364B0")]
		private set
		{
		}
	}

	[Token(Token = "0x170016A1")]
	public ulong VeteranStartTimeStamp
	{
		[Token(Token = "0x601560B")]
		[Address(RVA = "0x19364C8", Offset = "0x19364C8", VA = "0x19364C8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170016A2")]
	public ulong VeteranDailyMissionRefreshTime
	{
		[Token(Token = "0x601560C")]
		[Address(RVA = "0x19365E0", Offset = "0x19365E0", VA = "0x19365E0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x170016A3")]
	public VeteranConfigDesc VeteranConfigDesc
	{
		[Token(Token = "0x601560D")]
		[Address(RVA = "0x19365D8", Offset = "0x19365D8", VA = "0x19365D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601560E")]
		[Address(RVA = "0x19367D4", Offset = "0x19367D4", VA = "0x19367D4")]
		private set
		{
		}
	}

	[Token(Token = "0x170016A4")]
	public List<VeteranRewardItem> VeteranRewardList
	{
		[Token(Token = "0x601560F")]
		[Address(RVA = "0x19367DC", Offset = "0x19367DC", VA = "0x19367DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A5")]
	public List<BatchShowContentDesc> BatchShowContentList
	{
		[Token(Token = "0x6015610")]
		[Address(RVA = "0x1936834", Offset = "0x1936834", VA = "0x1936834")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A6")]
	public List<VeteranAwardDesc> VeteranAwardDescList
	{
		[Token(Token = "0x6015611")]
		[Address(RVA = "0x193688C", Offset = "0x193688C", VA = "0x193688C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A7")]
	public AwardData VeteranReturnAward
	{
		[Token(Token = "0x6015612")]
		[Address(RVA = "0x19368E4", Offset = "0x19368E4", VA = "0x19368E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016A8")]
	public CSGetVeteranRewardListRes VeteranRewardListRes
	{
		[Token(Token = "0x6015613")]
		[Address(RVA = "0x193693C", Offset = "0x193693C", VA = "0x193693C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015614")]
		[Address(RVA = "0x1936944", Offset = "0x1936944", VA = "0x1936944")]
		private set
		{
		}
	}

	[Token(Token = "0x170016A9")]
	public Dictionary<int, List<OptionalBundleShowData>> SortBundleDic
	{
		[Token(Token = "0x6015615")]
		[Address(RVA = "0x193694C", Offset = "0x193694C", VA = "0x193694C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016AA")]
	public Dictionary<int, uint> PreviewDic
	{
		[Token(Token = "0x6015616")]
		[Address(RVA = "0x19369A4", Offset = "0x19369A4", VA = "0x19369A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016AB")]
	public bool IsClaimReturn
	{
		[Token(Token = "0x6015619")]
		[Address(RVA = "0x1936FD0", Offset = "0x1936FD0", VA = "0x1936FD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016AC")]
	public bool IsVeteran
	{
		[Token(Token = "0x601561A")]
		[Address(RVA = "0x1937028", Offset = "0x1937028", VA = "0x1937028")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016AD")]
	public bool IsFirstVeteran
	{
		[Token(Token = "0x601561B")]
		[Address(RVA = "0x1937080", Offset = "0x1937080", VA = "0x1937080")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016AE")]
	public uint WeaponId
	{
		[Token(Token = "0x601561C")]
		[Address(RVA = "0x19370D8", Offset = "0x19370D8", VA = "0x19370D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601561D")]
		[Address(RVA = "0x1937130", Offset = "0x1937130", VA = "0x1937130")]
		set
		{
		}
	}

	[Token(Token = "0x170016AF")]
	public bool IsSencondConfirmBtnClick
	{
		[Token(Token = "0x601561E")]
		[Address(RVA = "0x1937190", Offset = "0x1937190", VA = "0x1937190")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601561F")]
		[Address(RVA = "0x19371E8", Offset = "0x19371E8", VA = "0x19371E8")]
		set
		{
		}
	}

	[Token(Token = "0x170016B0")]
	public bool HasIsVeteran
	{
		[Token(Token = "0x6015620")]
		[Address(RVA = "0x1937248", Offset = "0x1937248", VA = "0x1937248")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016B1")]
	private int ReminderDays
	{
		[Token(Token = "0x6015629")]
		[Address(RVA = "0x1939C0C", Offset = "0x1939C0C", VA = "0x1939C0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6015603")]
	[Address(RVA = "0x1936008", Offset = "0x1936008", VA = "0x1936008")]
	public UIModelVeteranSignin()
	{
	}

	[Token(Token = "0x6015617")]
	[Address(RVA = "0x19369FC", Offset = "0x19369FC", VA = "0x19369FC")]
	public VeteranBigPrizeDesc GetBigPrizeDescById(int Id)
	{
		return null;
	}

	[Token(Token = "0x6015618")]
	[Address(RVA = "0x1936B9C", Offset = "0x1936B9C", VA = "0x1936B9C")]
	public EAttendance.VeteranTaskBigPrize GetBigPriceStateById(int Id)
	{
		return default(EAttendance.VeteranTaskBigPrize);
	}

	[Token(Token = "0x6015621")]
	[Address(RVA = "0x19372A0", Offset = "0x19372A0", VA = "0x19372A0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015622")]
	[Address(RVA = "0x19372F8", Offset = "0x19372F8", VA = "0x19372F8", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6015623")]
	[Address(RVA = "0x193737C", Offset = "0x193737C", VA = "0x193737C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6015624")]
	[Address(RVA = "0x1937490", Offset = "0x1937490", VA = "0x1937490", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015625")]
	[Address(RVA = "0x1937728", Offset = "0x1937728", VA = "0x1937728")]
	public bool IsShowVeteranEntry()
	{
		return default(bool);
	}

	[Token(Token = "0x6015626")]
	[Address(RVA = "0x1937788", Offset = "0x1937788", VA = "0x1937788")]
	public bool HaveNewRewardAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6015627")]
	[Address(RVA = "0x1937940", Offset = "0x1937940", VA = "0x1937940")]
	public void ProcessVeteranRes(CSGetVeteranRewardListRes res)
	{
	}

	[Token(Token = "0x6015628")]
	[Address(RVA = "0x1939AFC", Offset = "0x1939AFC", VA = "0x1939AFC")]
	public void ProcessBatchShowContentRes(CSGetBatchShowContentRes res)
	{
	}

	[Token(Token = "0x601562A")]
	[Address(RVA = "0x19392E8", Offset = "0x19392E8", VA = "0x19392E8")]
	private void RescheduleLocalNotifications()
	{
	}

	[Token(Token = "0x601562B")]
	[Address(RVA = "0x1939D58", Offset = "0x1939D58", VA = "0x1939D58")]
	public void RequestSignin(int rewardIndex)
	{
	}

	[Token(Token = "0x601562C")]
	[Address(RVA = "0x193A0D8", Offset = "0x193A0D8", VA = "0x193A0D8")]
	public VeteranTaskInfo GetTaskInfo(uint taskId)
	{
		return null;
	}

	[Token(Token = "0x601562D")]
	[Address(RVA = "0x193A224", Offset = "0x193A224", VA = "0x193A224")]
	public ClientVeteranTaskDesc GetTaskDesc(uint taskId)
	{
		return null;
	}

	[Token(Token = "0x601562E")]
	[Address(RVA = "0x193A370", Offset = "0x193A370", VA = "0x193A370")]
	private void OnGetTaskDesc()
	{
	}

	[Token(Token = "0x601562F")]
	[Address(RVA = "0x1937CC8", Offset = "0x1937CC8", VA = "0x1937CC8")]
	public void GetTaskDesc(bool preload = false)
	{
	}

	[Token(Token = "0x6015630")]
	[Address(RVA = "0x193A450", Offset = "0x193A450", VA = "0x193A450")]
	private void OnGetTaskInfo()
	{
	}

	[Token(Token = "0x6015631")]
	[Address(RVA = "0x193A7C4", Offset = "0x193A7C4", VA = "0x193A7C4")]
	public void GetTaskInfo(bool preload = false, bool silence = false)
	{
	}

	[Token(Token = "0x6015632")]
	[Address(RVA = "0x193AC18", Offset = "0x193AC18", VA = "0x193AC18")]
	public void RequestClaimVeteranReturnAward()
	{
	}

	[Token(Token = "0x6015633")]
	[Address(RVA = "0x193AE3C", Offset = "0x193AE3C", VA = "0x193AE3C")]
	public void GetTaskRewards(ClientVeteranTaskDesc desc, int index)
	{
	}

	[Token(Token = "0x6015634")]
	[Address(RVA = "0x193B284", Offset = "0x193B284", VA = "0x193B284")]
	public void GetTaskBigPrize(int Id)
	{
	}

	[Token(Token = "0x6015635")]
	[Address(RVA = "0x1936E20", Offset = "0x1936E20", VA = "0x1936E20")]
	public uint GetClaimedTaskNum()
	{
		return default(uint);
	}

	[Token(Token = "0x6015636")]
	[Address(RVA = "0x193B710", Offset = "0x193B710", VA = "0x193B710")]
	public void OnTcpUpdateTaskInfos(List<VeteranTaskUpdateInfo> taskinfos)
	{
	}

	[Token(Token = "0x6015637")]
	[Address(RVA = "0x193A594", Offset = "0x193A594", VA = "0x193A594")]
	public int GetWaitClaimNum()
	{
		return default(int);
	}

	[Token(Token = "0x6015638")]
	[Address(RVA = "0x1938ECC", Offset = "0x1938ECC", VA = "0x1938ECC")]
	public void OnFirstVeteranClearCache()
	{
	}

	[Token(Token = "0x6015639")]
	[Address(RVA = "0x193BF00", Offset = "0x193BF00", VA = "0x193BF00")]
	public void OnAvatarChangeClearCache()
	{
	}

	[Token(Token = "0x601563A")]
	[Address(RVA = "0x193C344", Offset = "0x193C344", VA = "0x193C344")]
	public uint GetCurrentActiviness()
	{
		return default(uint);
	}

	[Token(Token = "0x601563B")]
	[Address(RVA = "0x193BCE0", Offset = "0x193BCE0", VA = "0x193BCE0")]
	public uint GetLimitActiviness()
	{
		return default(uint);
	}

	[Token(Token = "0x601563C")]
	[Address(RVA = "0x193C3B0", Offset = "0x193C3B0", VA = "0x193C3B0")]
	public bool HasAchieveLimitActiness()
	{
		return default(bool);
	}

	[Token(Token = "0x601563D")]
	[Address(RVA = "0x193C42C", Offset = "0x193C42C", VA = "0x193C42C")]
	public bool HasNoMissionLeft()
	{
		return default(bool);
	}

	[Token(Token = "0x601563E")]
	[Address(RVA = "0x193C4AC", Offset = "0x193C4AC", VA = "0x193C4AC")]
	public bool HasClimedAllRewards()
	{
		return default(bool);
	}

	[Token(Token = "0x601563F")]
	[Address(RVA = "0x193C58C", Offset = "0x193C58C", VA = "0x193C58C")]
	public uint GetCoperationTimeLimit()
	{
		return default(uint);
	}

	[Token(Token = "0x6015640")]
	[Address(RVA = "0x193C5F8", Offset = "0x193C5F8", VA = "0x193C5F8")]
	public ClientVeteranTaskDesc GetTodayMentorTask()
	{
		return null;
	}

	[Token(Token = "0x6015641")]
	[Address(RVA = "0x193C6D0", Offset = "0x193C6D0", VA = "0x193C6D0")]
	public List<ClientVeteranTaskDesc> GetTodayDailyTask()
	{
		return null;
	}

	[Token(Token = "0x6015642")]
	[Address(RVA = "0x193C844", Offset = "0x193C844", VA = "0x193C844")]
	public bool HasClimedSlot(int slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6015643")]
	[Address(RVA = "0x193CA1C", Offset = "0x193CA1C", VA = "0x193CA1C")]
	public VeteranAwardDesc GetSlotAwardDesc(int slot)
	{
		return null;
	}

	[Token(Token = "0x6015644")]
	[Address(RVA = "0x193CBC0", Offset = "0x193CBC0", VA = "0x193CBC0")]
	public uint GetSlotActiviness(int slot)
	{
		return default(uint);
	}

	[Token(Token = "0x6015645")]
	[Address(RVA = "0x193CC3C", Offset = "0x193CC3C", VA = "0x193CC3C")]
	public OptionalBundleShowData GetOptionalShowDataBySlot(int slot)
	{
		return null;
	}

	[Token(Token = "0x6015646")]
	[Address(RVA = "0x1938388", Offset = "0x1938388", VA = "0x1938388")]
	public void ProcessPreviewDict()
	{
	}

	[Token(Token = "0x6015647")]
	[Address(RVA = "0x193D058", Offset = "0x193D058", VA = "0x193D058")]
	public List<uint> GetCurrentAvatarList()
	{
		return null;
	}

	[Token(Token = "0x6015648")]
	[Address(RVA = "0x193D28C", Offset = "0x193D28C", VA = "0x193D28C")]
	public void SetPreviewList(int slot, int itemindex, uint avatarid)
	{
	}

	[Token(Token = "0x6015649")]
	[Address(RVA = "0x193D54C", Offset = "0x193D54C", VA = "0x193D54C")]
	public string GetDefaultSlotIcon(int slot)
	{
		return null;
	}

	[Token(Token = "0x601564A")]
	[Address(RVA = "0x193D7D4", Offset = "0x193D7D4", VA = "0x193D7D4")]
	public string GetPlusSpriteNameBySlot(int slot)
	{
		return null;
	}

	[Token(Token = "0x601564B")]
	[Address(RVA = "0x193D898", Offset = "0x193D898", VA = "0x193D898")]
	public void RequestConfirmVeteranBundleItem(uint[] optionalOrderIDs)
	{
	}

	[Token(Token = "0x601564C")]
	[Address(RVA = "0x19380F0", Offset = "0x19380F0", VA = "0x19380F0")]
	public void RequestGetVeteranAwardDesc()
	{
	}

	[Token(Token = "0x601564D")]
	[Address(RVA = "0x193DB40", Offset = "0x193DB40", VA = "0x193DB40")]
	public void RequestPresense()
	{
	}

	[Token(Token = "0x601564E")]
	[Address(RVA = "0x193DD20", Offset = "0x193DD20", VA = "0x193DD20")]
	public void SenfConfidantMessage()
	{
	}

	[Token(Token = "0x601564F")]
	[Address(RVA = "0x193E1FC", Offset = "0x193E1FC", VA = "0x193E1FC")]
	public void RequestClaimVeteranBundleAward(int slot)
	{
	}

	[Token(Token = "0x6015650")]
	[Address(RVA = "0x193E5AC", Offset = "0x193E5AC", VA = "0x193E5AC")]
	public bool HasConfirmSelectBundle()
	{
		return default(bool);
	}

	[Token(Token = "0x6015651")]
	[Address(RVA = "0x193E620", Offset = "0x193E620", VA = "0x193E620")]
	public void RequestInteractionSend(ulong id, string playername)
	{
	}

	[Token(Token = "0x6015652")]
	[Address(RVA = "0x193E808", Offset = "0x193E808", VA = "0x193E808")]
	public void RequestDefaultSend(ulong id, string playername)
	{
	}

	[Token(Token = "0x6015653")]
	[Address(RVA = "0x193EA6C", Offset = "0x193EA6C", VA = "0x193EA6C")]
	public void SendClanMessage()
	{
	}

	[Token(Token = "0x6015655")]
	[Address(RVA = "0x193ED24", Offset = "0x193ED24", VA = "0x193ED24")]
	private static int _003CProcessVeteranRes_003Em__0(VeteranRewardItem a, VeteranRewardItem b)
	{
		return default(int);
	}

	[Token(Token = "0x6015656")]
	[Address(RVA = "0x193ED94", Offset = "0x193ED94", VA = "0x193ED94")]
	private void _003CRequestClaimVeteranReturnAward_003Em__1(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6015657")]
	[Address(RVA = "0x193EF38", Offset = "0x193EF38", VA = "0x193EF38")]
	private void _003CRequestGetVeteranAwardDesc_003Em__2(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6015658")]
	[Address(RVA = "0x193F5B8", Offset = "0x193F5B8", VA = "0x193F5B8")]
	private static int _003CRequestGetVeteranAwardDesc_003Em__3(VeteranAwardDesc x, VeteranAwardDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6015659")]
	[Address(RVA = "0x193F600", Offset = "0x193F600", VA = "0x193F600")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x601565A")]
	[Address(RVA = "0x193F608", Offset = "0x193F608", VA = "0x193F608")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x601565B")]
	[Address(RVA = "0x193F610", Offset = "0x193F610", VA = "0x193F610")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
