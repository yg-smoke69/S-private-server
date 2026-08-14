using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2003180")]
public class UIModelMemberShip : UIBaseModel
{
	[Token(Token = "0x2003181")]
	private class MemberShipDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4012D4C")]
		[FieldOffset(Offset = "0x0")]
		private static MemberShipDelegate _I;

		[Token(Token = "0x4012D4D")]
		[FieldOffset(Offset = "0x1C")]
		private string LastSubscribedProductIdentifier;

		[Token(Token = "0x170015E7")]
		public static MemberShipDelegate I
		{
			[Token(Token = "0x6014D10")]
			[Address(RVA = "0x17664AC", Offset = "0x17664AC", VA = "0x17664AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170015E8")]
		public override string Name
		{
			[Token(Token = "0x6014D11")]
			[Address(RVA = "0x177916C", Offset = "0x177916C", VA = "0x177916C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6014D0F")]
		[Address(RVA = "0x1779164", Offset = "0x1779164", VA = "0x1779164")]
		public MemberShipDelegate()
		{
		}

		[Token(Token = "0x6014D12")]
		[Address(RVA = "0x1779210", Offset = "0x1779210", VA = "0x1779210", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6014D13")]
		[Address(RVA = "0x177951C", Offset = "0x177951C", VA = "0x177951C", Slot = "18")]
		public override void OnPurchasing(string reason, bool willPurchase, string productIdentifier, long rebateId, bool isEvent, long eventId)
		{
		}

		[Token(Token = "0x6014D14")]
		[Address(RVA = "0x1779714", Offset = "0x1779714", VA = "0x1779714", Slot = "13")]
		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x6014D15")]
		[Address(RVA = "0x1779928", Offset = "0x1779928", VA = "0x1779928", Slot = "15")]
		public override void OnRebateOptionsUpdated(string reason, bool result, long[] rebateIds)
		{
		}

		[Token(Token = "0x6014D16")]
		[Address(RVA = "0x1779A90", Offset = "0x1779A90", VA = "0x1779A90")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		[Token(Token = "0x6014D17")]
		[Address(RVA = "0x1779AC4", Offset = "0x1779AC4", VA = "0x1779AC4")]
		public void _003C_003EiFixBaseProxy_OnPurchasing(string P0, bool P1, string P2, long P3, bool P4, long P5)
		{
		}

		[Token(Token = "0x6014D18")]
		[Address(RVA = "0x1779B08", Offset = "0x1779B08", VA = "0x1779B08")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x6014D19")]
		[Address(RVA = "0x1779B28", Offset = "0x1779B28", VA = "0x1779B28")]
		public void _003C_003EiFixBaseProxy_OnRebateOptionsUpdated(string P0, bool P1, long[] P2)
		{
		}
	}

	[Token(Token = "0x2003182")]
	private sealed class _003CProcessMemberShipDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012D4E")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014D1A")]
		[Address(RVA = "0x176A748", Offset = "0x176A748", VA = "0x176A748")]
		public _003CProcessMemberShipDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014D1B")]
		[Address(RVA = "0x1778720", Offset = "0x1778720", VA = "0x1778720")]
		internal bool _003C_003Em__0(VipCardShowAwardDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003183")]
	private sealed class _003CRequestMemberShipInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012D4F")]
		[FieldOffset(Offset = "0x8")]
		internal bool isBackEndNotify;

		[Token(Token = "0x4012D50")]
		[FieldOffset(Offset = "0x9")]
		internal bool isReissue;

		[Token(Token = "0x4012D51")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMemberShip _0024this;

		[Token(Token = "0x6014D1C")]
		[Address(RVA = "0x176B644", Offset = "0x176B644", VA = "0x176B644")]
		public _003CRequestMemberShipInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014D1D")]
		[Address(RVA = "0x1778D10", Offset = "0x1778D10", VA = "0x1778D10")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003184")]
	private sealed class _003CProcessMemberShipInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012D52")]
		[FieldOffset(Offset = "0x8")]
		internal ClientMemberShipCardData cardData;

		[Token(Token = "0x6014D1E")]
		[Address(RVA = "0x176D510", Offset = "0x176D510", VA = "0x176D510")]
		public _003CProcessMemberShipInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014D1F")]
		[Address(RVA = "0x1778758", Offset = "0x1778758", VA = "0x1778758")]
		internal bool _003C_003Em__0(VipCardAwardStatus x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003185")]
	private sealed class _003CProcessLastPeriodReissueData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012D53")]
		[FieldOffset(Offset = "0x8")]
		internal uint i;

		[Token(Token = "0x6014D20")]
		[Address(RVA = "0x1770CAC", Offset = "0x1770CAC", VA = "0x1770CAC")]
		public _003CProcessLastPeriodReissueData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014D21")]
		[Address(RVA = "0x17786E8", Offset = "0x17786E8", VA = "0x17786E8")]
		internal bool _003C_003Em__0(VipCardAwardStatus x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003186")]
	private sealed class _003CProcessCurrentPeriodReissueData_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012D54")]
		[FieldOffset(Offset = "0x8")]
		internal uint i;

		[Token(Token = "0x6014D22")]
		[Address(RVA = "0x1771940", Offset = "0x1771940", VA = "0x1771940")]
		public _003CProcessCurrentPeriodReissueData_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014D23")]
		[Address(RVA = "0x17786B0", Offset = "0x17786B0", VA = "0x17786B0")]
		internal bool _003C_003Em__0(VipCardAwardStatus x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003187")]
	private sealed class _003CProcessReissueData_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012D55")]
		[FieldOffset(Offset = "0x8")]
		internal uint cliamTime;

		[Token(Token = "0x6014D24")]
		[Address(RVA = "0x1771A9C", Offset = "0x1771A9C", VA = "0x1771A9C")]
		public _003CProcessReissueData_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014D25")]
		[Address(RVA = "0x17787A4", Offset = "0x17787A4", VA = "0x17787A4")]
		internal bool _003C_003Em__0(ClientReissueItemData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003188")]
	private sealed class _003CRequestMemberShipCardCheckIn_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012D56")]
		[FieldOffset(Offset = "0x8")]
		internal bool claimAll;

		[Token(Token = "0x4012D57")]
		[FieldOffset(Offset = "0xC")]
		internal proto.EVipCard.VipCardType memberShipType;

		[Token(Token = "0x4012D58")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMemberShip _0024this;

		[Token(Token = "0x6014D26")]
		[Address(RVA = "0x1771DC4", Offset = "0x1771DC4", VA = "0x1771DC4")]
		public _003CRequestMemberShipCardCheckIn_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014D27")]
		[Address(RVA = "0x17787DC", Offset = "0x17787DC", VA = "0x17787DC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003189")]
	private sealed class _003CUpdateCheckInInfo_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012D59")]
		[FieldOffset(Offset = "0x8")]
		internal uint currentDay;

		[Token(Token = "0x6014D28")]
		[Address(RVA = "0x1771FB4", Offset = "0x1771FB4", VA = "0x1771FB4")]
		public _003CUpdateCheckInInfo_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6014D29")]
		[Address(RVA = "0x177912C", Offset = "0x177912C", VA = "0x177912C")]
		internal bool _003C_003Em__0(VipCardAwardStatus x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200318A")]
	private sealed class _003CRequestMemberShipStorePurchaseItem_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012D5A")]
		[FieldOffset(Offset = "0x8")]
		internal VipCardStoreInfo info;

		[Token(Token = "0x4012D5B")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMemberShip _0024this;

		[Token(Token = "0x6014D2A")]
		[Address(RVA = "0x1772648", Offset = "0x1772648", VA = "0x1772648")]
		public _003CRequestMemberShipStorePurchaseItem_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6014D2B")]
		[Address(RVA = "0x1778F14", Offset = "0x1778F14", VA = "0x1778F14")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200318B")]
	private sealed class _003CHasCheckIn_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012D5C")]
		[FieldOffset(Offset = "0x8")]
		internal uint currentDay;

		[Token(Token = "0x6014D2C")]
		[Address(RVA = "0x17762E8", Offset = "0x17762E8", VA = "0x17762E8")]
		public _003CHasCheckIn_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6014D2D")]
		[Address(RVA = "0x1778678", Offset = "0x1778678", VA = "0x1778678")]
		internal bool _003C_003Em__0(VipCardAwardStatus x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200318C")]
	private sealed class _003CGetRebateCardDescByRebateID_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012D5D")]
		[FieldOffset(Offset = "0x8")]
		internal long rebateID;

		[Token(Token = "0x6014D2E")]
		[Address(RVA = "0x177803C", Offset = "0x177803C", VA = "0x177803C")]
		public _003CGetRebateCardDescByRebateID_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6014D2F")]
		[Address(RVA = "0x177863C", Offset = "0x177863C", VA = "0x177863C")]
		internal bool _003C_003Em__0(VipCardRebateDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012D28")]
	public const uint MEMBERSHIPREISSUECARDID = 827000001u;

	[Token(Token = "0x4012D29")]
	public const uint MEMBERSHIPEPBADGEID = 827001001u;

	[Token(Token = "0x4012D2A")]
	public const uint REISSUESHOWDAY = 7u;

	[Token(Token = "0x4012D2B")]
	public const uint WEEKCARDDAY = 7u;

	[Token(Token = "0x4012D2C")]
	public const uint MONTHCARDDAY = 30u;

	[Token(Token = "0x4012D2D")]
	public const uint PropID_MemberShipStorePurchaseSuccess = 2u;

	[Token(Token = "0x4012D2E")]
	public const uint PropID_MemberShipCheckInSuccess = 4u;

	[Token(Token = "0x4012D2F")]
	public const uint PropID_MemberShipPurchaseSuccess = 8u;

	[Token(Token = "0x4012D30")]
	public const uint PropID_MemberShipSubscriptionBonusUpdate = 32u;

	[Token(Token = "0x4012D31")]
	public const uint PropID_MemberShipSubscriptionDone = 64u;

	[Token(Token = "0x4012D32")]
	public const uint PropID_MemberShipModelStateChange = 128u;

	[Token(Token = "0x4012D33")]
	public const uint PropID_MemberShipGetDesc = 256u;

	[Token(Token = "0x4012D34")]
	public const uint PropID_MemberShipGetInfo = 512u;

	[Token(Token = "0x4012D35")]
	public const uint PropID_MemberShipGetStoreInfo = 1024u;

	[Token(Token = "0x4012D36")]
	public const uint PropID_MemberShipOnProductUpdate = 2048u;

	[Token(Token = "0x4012D37")]
	public const uint PropID_MemberShipReissueGetInfo = 4096u;

	[Token(Token = "0x4012D38")]
	[FieldOffset(Offset = "0xC")]
	private Predicate<AwardDesc> m_PredicateGem;

	[Token(Token = "0x4012D39")]
	[FieldOffset(Offset = "0x10")]
	private ClientMemberShipCardData _003CMonthCardData_003Ek__BackingField;

	[Token(Token = "0x4012D3A")]
	[FieldOffset(Offset = "0x14")]
	private ClientMemberShipCardData _003CWeekCardData_003Ek__BackingField;

	[Token(Token = "0x4012D3B")]
	[FieldOffset(Offset = "0x18")]
	private ClientMemberShipCardData _003CSVIPCardData_003Ek__BackingField;

	[Token(Token = "0x4012D3C")]
	[FieldOffset(Offset = "0x1C")]
	private ClientReissueData _003CClientReissueData_003Ek__BackingField;

	[Token(Token = "0x4012D3D")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, bool?> m_SubscriptionBonusAvailable;

	[Token(Token = "0x4012D3E")]
	[FieldOffset(Offset = "0x24")]
	private uint m_NextResetTimeStamp;

	[Token(Token = "0x4012D3F")]
	[FieldOffset(Offset = "0x28")]
	private CSGetVipCardDescRes m_MemberShipDescRes;

	[Token(Token = "0x4012D40")]
	[FieldOffset(Offset = "0x2C")]
	private CSGetAccountVipCardInfosRes m_MemberShipInfo;

	[Token(Token = "0x4012D41")]
	[FieldOffset(Offset = "0x30")]
	private CSGetVipCardStoreInfoRes m_MemberShipStoreInfo;

	[Token(Token = "0x4012D42")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, List<AwardDesc>> m_InitAwardDicByVipCardType;

	[Token(Token = "0x4012D43")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, List<AwardDesc>> m_AllDailyAwardsDicByVipCardType;

	[Token(Token = "0x4012D44")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, List<VipCardDailyAwardDesc>> m_DailyAwardListByDayDicByVipCardType;

	[Token(Token = "0x4012D45")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, VipCardInfo> m_MemberShipInfoDic;

	[Token(Token = "0x4012D46")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, VipCardRebateDesc> m_MeberShipDiscountDescDic;

	[Token(Token = "0x4012D47")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, uint> m_MemberShipDiscountInfoDic;

	[Token(Token = "0x4012D48")]
	[FieldOffset(Offset = "0x4C")]
	private EMemberShipModelState _003CCurrentModelState_003Ek__BackingField;

	[Token(Token = "0x4012D49")]
	[FieldOffset(Offset = "0x50")]
	private EMemberShipBackEndNotifyState _003CCurrentPurchaseState_003Ek__BackingField;

	[Token(Token = "0x4012D4A")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012D4B")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AwardDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170015DF")]
	public ClientMemberShipCardData MonthCardData
	{
		[Token(Token = "0x6014CB9")]
		[Address(RVA = "0x17656F8", Offset = "0x17656F8", VA = "0x17656F8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014CBA")]
		[Address(RVA = "0x1765700", Offset = "0x1765700", VA = "0x1765700")]
		private set
		{
		}
	}

	[Token(Token = "0x170015E0")]
	public ClientMemberShipCardData WeekCardData
	{
		[Token(Token = "0x6014CBB")]
		[Address(RVA = "0x1765708", Offset = "0x1765708", VA = "0x1765708")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014CBC")]
		[Address(RVA = "0x1765710", Offset = "0x1765710", VA = "0x1765710")]
		private set
		{
		}
	}

	[Token(Token = "0x170015E1")]
	public ClientMemberShipCardData SVIPCardData
	{
		[Token(Token = "0x6014CBD")]
		[Address(RVA = "0x1765718", Offset = "0x1765718", VA = "0x1765718")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014CBE")]
		[Address(RVA = "0x1765720", Offset = "0x1765720", VA = "0x1765720")]
		private set
		{
		}
	}

	[Token(Token = "0x170015E2")]
	public ClientReissueData ClientReissueData
	{
		[Token(Token = "0x6014CBF")]
		[Address(RVA = "0x1765728", Offset = "0x1765728", VA = "0x1765728")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014CC0")]
		[Address(RVA = "0x1765730", Offset = "0x1765730", VA = "0x1765730")]
		private set
		{
		}
	}

	[Token(Token = "0x170015E3")]
	private int SubscriptionMembershipSwitch
	{
		[Token(Token = "0x6014CC1")]
		[Address(RVA = "0x1765738", Offset = "0x1765738", VA = "0x1765738")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170015E4")]
	public bool MemberShipCardEnabled
	{
		[Token(Token = "0x6014CC2")]
		[Address(RVA = "0x1765B78", Offset = "0x1765B78", VA = "0x1765B78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170015E5")]
	public EMemberShipModelState CurrentModelState
	{
		[Token(Token = "0x6014CC5")]
		[Address(RVA = "0x1766194", Offset = "0x1766194", VA = "0x1766194")]
		get
		{
			return default(EMemberShipModelState);
		}
		[Token(Token = "0x6014CC6")]
		[Address(RVA = "0x176619C", Offset = "0x176619C", VA = "0x176619C")]
		private set
		{
		}
	}

	[Token(Token = "0x170015E6")]
	public EMemberShipBackEndNotifyState CurrentPurchaseState
	{
		[Token(Token = "0x6014CC7")]
		[Address(RVA = "0x17661A4", Offset = "0x17661A4", VA = "0x17661A4")]
		get
		{
			return default(EMemberShipBackEndNotifyState);
		}
		[Token(Token = "0x6014CC8")]
		[Address(RVA = "0x17661AC", Offset = "0x17661AC", VA = "0x17661AC")]
		private set
		{
		}
	}

	[Token(Token = "0x6014CB5")]
	[Address(RVA = "0x1765330", Offset = "0x1765330", VA = "0x1765330")]
	public UIModelMemberShip()
	{
	}

	[Token(Token = "0x6014CB6")]
	[Address(RVA = "0x176559C", Offset = "0x176559C", VA = "0x176559C")]
	public static proto.EVipCard.VipCardType GetMemberShipType(RebateCardType rebateCardType)
	{
		return default(proto.EVipCard.VipCardType);
	}

	[Token(Token = "0x6014CB7")]
	[Address(RVA = "0x176561C", Offset = "0x176561C", VA = "0x176561C")]
	public static RebateCardType GetRebateCardType(proto.EVipCard.VipCardType memberShipCardType)
	{
		return default(RebateCardType);
	}

	[Token(Token = "0x6014CB8")]
	[Address(RVA = "0x1765688", Offset = "0x1765688", VA = "0x1765688")]
	public static proto.EVipCard.VipCardType ConvertToVipCardType(ESubscription.PriceType price_type)
	{
		return default(proto.EVipCard.VipCardType);
	}

	[Token(Token = "0x6014CC3")]
	[Address(RVA = "0x1765BD0", Offset = "0x1765BD0", VA = "0x1765BD0")]
	public bool CanDisplaySubscription(proto.EVipCard.VipCardType membershipType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014CC4")]
	[Address(RVA = "0x1766104", Offset = "0x1766104", VA = "0x1766104")]
	public ClientMemberShipCardData MemberShipCard(proto.EVipCard.VipCardType rebateCardType)
	{
		return null;
	}

	[Token(Token = "0x6014CC9")]
	[Address(RVA = "0x17661B4", Offset = "0x17661B4", VA = "0x17661B4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014CCA")]
	[Address(RVA = "0x176620C", Offset = "0x176620C", VA = "0x176620C")]
	public proto.EVipCard.VipCardType GetCurrentMemberShipType()
	{
		return default(proto.EVipCard.VipCardType);
	}

	[Token(Token = "0x6014CCB")]
	[Address(RVA = "0x176633C", Offset = "0x176633C", VA = "0x176633C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014CCC")]
	[Address(RVA = "0x1766590", Offset = "0x1766590", VA = "0x1766590", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014CCD")]
	[Address(RVA = "0x1766C04", Offset = "0x1766C04", VA = "0x1766C04")]
	public bool HasReissueCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6014CCE")]
	[Address(RVA = "0x1766D2C", Offset = "0x1766D2C", VA = "0x1766D2C")]
	public bool SubscriptionBonusAvailable(proto.EVipCard.VipCardType memberShipCardType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014CCF")]
	[Address(RVA = "0x17670CC", Offset = "0x17670CC", VA = "0x17670CC")]
	private Action<HttpErrorCode, object> OnGetSubscriptionBonusStatus(proto.EVipCard.VipCardType memberShipCardType)
	{
		return null;
	}

	[Token(Token = "0x6014CD0")]
	[Address(RVA = "0x17671F8", Offset = "0x17671F8", VA = "0x17671F8")]
	private void OnGetSubscriptionBonusStatus_Week(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x6014CD1")]
	[Address(RVA = "0x1767758", Offset = "0x1767758", VA = "0x1767758")]
	private void OnGetSubscriptionBonusStatus_Month(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x6014CD2")]
	[Address(RVA = "0x1767284", Offset = "0x1767284", VA = "0x1767284")]
	private void OnGetSubscriptionBonusStatus(proto.EVipCard.VipCardType memberShipCardType, HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x6014CD3")]
	[Address(RVA = "0x17677E4", Offset = "0x17677E4", VA = "0x17677E4")]
	private void OnSubscribed(string productIdentifier)
	{
	}

	[Token(Token = "0x6014CD4")]
	[Address(RVA = "0x1767EE0", Offset = "0x1767EE0", VA = "0x1767EE0")]
	public void OnProductAndRebateOptionsUpdate()
	{
	}

	[Token(Token = "0x6014CD5")]
	[Address(RVA = "0x1767FA8", Offset = "0x1767FA8", VA = "0x1767FA8")]
	public void ShowSubscriptionTips(proto.EVipCard.VipCardType memberShipCardType, Vector3 position)
	{
	}

	[Token(Token = "0x6014CD6")]
	[Address(RVA = "0x17667D4", Offset = "0x17667D4", VA = "0x17667D4")]
	public void ChangeModelState(EMemberShipModelState nextState, object[] data)
	{
	}

	[Token(Token = "0x6014CD7")]
	[Address(RVA = "0x1766A0C", Offset = "0x1766A0C", VA = "0x1766A0C")]
	public void ChangeBackEndNotifyState(EMemberShipBackEndNotifyState nextState)
	{
	}

	[Token(Token = "0x6014CD8")]
	[Address(RVA = "0x1765A68", Offset = "0x1765A68", VA = "0x1765A68")]
	public void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6014CD9")]
	[Address(RVA = "0x17682D4", Offset = "0x17682D4", VA = "0x17682D4")]
	public void RequestMemberShipDesc(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014CDA")]
	[Address(RVA = "0x1768580", Offset = "0x1768580", VA = "0x1768580")]
	public void TryProcessMemberShipDesc()
	{
	}

	[Token(Token = "0x6014CDB")]
	[Address(RVA = "0x176869C", Offset = "0x176869C", VA = "0x176869C")]
	private void ProcessMemberShipDesc(CSGetVipCardDescRes desc)
	{
	}

	[Token(Token = "0x6014CDC")]
	[Address(RVA = "0x176B16C", Offset = "0x176B16C", VA = "0x176B16C")]
	public void UpdateMemberShipProducts()
	{
	}

	[Token(Token = "0x6014CDD")]
	[Address(RVA = "0x176A750", Offset = "0x176A750", VA = "0x176A750")]
	private void RegisterProductAndRebateIDs()
	{
	}

	[Token(Token = "0x6014CDE")]
	[Address(RVA = "0x176B304", Offset = "0x176B304", VA = "0x176B304")]
	private int SortByDay(VipCardDailyAwardDesc a, VipCardDailyAwardDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014CDF")]
	[Address(RVA = "0x176B3B0", Offset = "0x176B3B0", VA = "0x176B3B0")]
	public void RequestMemberShipInfo(uint httpOption = 0u, bool isBackEndNotify = false, bool isReissue = false)
	{
	}

	[Token(Token = "0x6014CE0")]
	[Address(RVA = "0x176B64C", Offset = "0x176B64C", VA = "0x176B64C")]
	private uint GetRealCardStartTimeStamp(uint startTime)
	{
		return default(uint);
	}

	[Token(Token = "0x6014CE1")]
	[Address(RVA = "0x176B850", Offset = "0x176B850", VA = "0x176B850")]
	private void ProcessMemberShipInfo(CSGetAccountVipCardInfosRes info)
	{
	}

	[Token(Token = "0x6014CE2")]
	[Address(RVA = "0x177035C", Offset = "0x177035C", VA = "0x177035C")]
	private int SortReissueRewardDataByTime(ClientReissueItemData a, ClientReissueItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x6014CE3")]
	[Address(RVA = "0x176D518", Offset = "0x176D518", VA = "0x176D518")]
	private void CalculateReissueRewardData()
	{
	}

	[Token(Token = "0x6014CE4")]
	[Address(RVA = "0x1770408", Offset = "0x1770408", VA = "0x1770408")]
	private void ProcessLastPeriodReissueData(VipCardInfo cardInfo)
	{
	}

	[Token(Token = "0x6014CE5")]
	[Address(RVA = "0x17707AC", Offset = "0x17707AC", VA = "0x17707AC")]
	private void ProcessCurrentPeriodReissueData(VipCardInfo cardInfo)
	{
	}

	[Token(Token = "0x6014CE6")]
	[Address(RVA = "0x1770B04", Offset = "0x1770B04", VA = "0x1770B04")]
	private void ProcessFutureReviewData(VipCardInfo cardInfo)
	{
	}

	[Token(Token = "0x6014CE7")]
	[Address(RVA = "0x1770CB4", Offset = "0x1770CB4", VA = "0x1770CB4")]
	private void ProcessReissueData(EClientReissueItemType type, EClientCardTypeReissueAwardStatus status, uint day, VipCardInfo cardInfo, List<ClientReissueItemData> list)
	{
	}

	[Token(Token = "0x6014CE8")]
	[Address(RVA = "0x1771AA4", Offset = "0x1771AA4", VA = "0x1771AA4")]
	public void RequestMemberShipCardCheckIn(proto.EVipCard.VipCardType memberShipType, bool claimAll = false)
	{
	}

	[Token(Token = "0x6014CE9")]
	[Address(RVA = "0x1771DCC", Offset = "0x1771DCC", VA = "0x1771DCC")]
	private void UpdateCheckInInfo(proto.EVipCard.VipCardType memberShipType)
	{
	}

	[Token(Token = "0x6014CEA")]
	[Address(RVA = "0x1771FBC", Offset = "0x1771FBC", VA = "0x1771FBC")]
	public void RequestMemberShipStoreInfo()
	{
	}

	[Token(Token = "0x6014CEB")]
	[Address(RVA = "0x1772220", Offset = "0x1772220", VA = "0x1772220")]
	public CSGetVipCardStoreInfoRes GetMemberShipStoreInfo()
	{
		return null;
	}

	[Token(Token = "0x6014CEC")]
	[Address(RVA = "0x1772278", Offset = "0x1772278", VA = "0x1772278")]
	private int SortStoreInfoByPos(VipCardStoreInfo a, VipCardStoreInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6014CED")]
	[Address(RVA = "0x1772324", Offset = "0x1772324", VA = "0x1772324")]
	public void RequestMemberShipStorePurchaseItem(VipCardStoreInfo info)
	{
	}

	[Token(Token = "0x6014CEE")]
	[Address(RVA = "0x1772650", Offset = "0x1772650", VA = "0x1772650")]
	public void RequestMemberShipReissue(ClientReissueItemData data)
	{
	}

	[Token(Token = "0x6014CEF")]
	[Address(RVA = "0x1772930", Offset = "0x1772930", VA = "0x1772930")]
	public void PurchaseMemberShipCard(ClientMemberShipCardData memberShipCardData, bool subscribe)
	{
	}

	[Token(Token = "0x6014CF0")]
	[Address(RVA = "0x1773CB0", Offset = "0x1773CB0", VA = "0x1773CB0")]
	public void PurchaseMemberShipCard(long rebateID, string productIdentifier)
	{
	}

	[Token(Token = "0x6014CF1")]
	[Address(RVA = "0x17743F0", Offset = "0x17743F0", VA = "0x17743F0")]
	public void GetSVIPPagePurchaseRebateIDAndProductIdentifier(out long rebateId, out string productIdentifier)
	{
	}

	[Token(Token = "0x6014CF2")]
	[Address(RVA = "0x17746F8", Offset = "0x17746F8", VA = "0x17746F8")]
	private void GetRebateIDAndProductIdentifierByMemberShipCardRebateIDType(MemberShipCardRebateIDType memberShipCardRebateIDType, out long rebateId, out string productIdentifier)
	{
	}

	[Token(Token = "0x6014CF3")]
	[Address(RVA = "0x1774984", Offset = "0x1774984", VA = "0x1774984")]
	public void OnGOPNotifyPurchased(string productIdentifier, int rebateId)
	{
	}

	[Token(Token = "0x6014CF4")]
	[Address(RVA = "0x1774A78", Offset = "0x1774A78", VA = "0x1774A78")]
	public void OnBackEndNotifyPurchased(bool result, List<tcp.EVipCard.VipCardType> vipCardTypes)
	{
	}

	[Token(Token = "0x6014CF5")]
	[Address(RVA = "0x177555C", Offset = "0x177555C", VA = "0x177555C")]
	public void UpdateMemberShipTips()
	{
	}

	[Token(Token = "0x6014CF6")]
	[Address(RVA = "0x177623C", Offset = "0x177623C", VA = "0x177623C")]
	public bool CanShowCheckInAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6014CF7")]
	[Address(RVA = "0x1765F08", Offset = "0x1765F08", VA = "0x1765F08")]
	public string SubscriptionProductIdentifier(proto.EVipCard.VipCardType memberShipCardType)
	{
		return null;
	}

	[Token(Token = "0x6014CF8")]
	[Address(RVA = "0x1773AAC", Offset = "0x1773AAC", VA = "0x1773AAC")]
	public bool SupportSubscription(proto.EVipCard.VipCardType memberShipCardType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014CF9")]
	[Address(RVA = "0x17681F0", Offset = "0x17681F0", VA = "0x17681F0")]
	public PayItemData SubscriptionProduct(proto.EVipCard.VipCardType memberShipCardType)
	{
		return null;
	}

	[Token(Token = "0x6014CFA")]
	[Address(RVA = "0x1776040", Offset = "0x1776040", VA = "0x1776040")]
	public bool HasCheckIn(proto.EVipCard.VipCardType card_type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014CFB")]
	[Address(RVA = "0x1775FB8", Offset = "0x1775FB8", VA = "0x1775FB8")]
	public bool HasOwnMemberShipCard(proto.EVipCard.VipCardType card_type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014CFC")]
	[Address(RVA = "0x17762F0", Offset = "0x17762F0", VA = "0x17762F0")]
	public bool CanCheckInAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6014CFD")]
	[Address(RVA = "0x17766E0", Offset = "0x17766E0", VA = "0x17766E0")]
	public uint CalculateRemainingDiamond()
	{
		return default(uint);
	}

	[Token(Token = "0x6014CFE")]
	[Address(RVA = "0x1771948", Offset = "0x1771948", VA = "0x1771948")]
	private bool HasMemberShipByDay(VipCardInfo info, uint day)
	{
		return default(bool);
	}

	[Token(Token = "0x6014CFF")]
	[Address(RVA = "0x1776E18", Offset = "0x1776E18", VA = "0x1776E18")]
	public uint GetNextRestTimeStamp()
	{
		return default(uint);
	}

	[Token(Token = "0x6014D00")]
	[Address(RVA = "0x1776E70", Offset = "0x1776E70", VA = "0x1776E70")]
	public int GetOwnedReissueCardNum()
	{
		return default(int);
	}

	[Token(Token = "0x6014D01")]
	[Address(RVA = "0x17735F0", Offset = "0x17735F0", VA = "0x17735F0")]
	public bool HasDiscountChance(proto.EVipCard.VipCardType vipCardType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D02")]
	[Address(RVA = "0x1776F98", Offset = "0x1776F98", VA = "0x1776F98")]
	private uint CalculatePurchaseTimeByRebateIDType(MemberShipCardRebateIDType type)
	{
		return default(uint);
	}

	[Token(Token = "0x6014D03")]
	[Address(RVA = "0x17774CC", Offset = "0x17774CC", VA = "0x17774CC")]
	public bool ValidToPurchase(proto.EVipCard.VipCardType vipCardType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D04")]
	[Address(RVA = "0x1777A0C", Offset = "0x1777A0C", VA = "0x1777A0C")]
	public bool ValidToPurchase(long rebateID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D05")]
	[Address(RVA = "0x1774C14", Offset = "0x1774C14", VA = "0x1774C14")]
	private void ShowInitAward(List<tcp.EVipCard.VipCardType> vipCardTypes)
	{
	}

	[Token(Token = "0x6014D06")]
	[Address(RVA = "0x1777EC4", Offset = "0x1777EC4", VA = "0x1777EC4")]
	public VipCardRebateDesc GetRebateCardDescByRebateID(long rebateID)
	{
		return null;
	}

	[Token(Token = "0x6014D07")]
	[Address(RVA = "0x1778044", Offset = "0x1778044", VA = "0x1778044")]
	private void _003COnSubscribed_003Em__0(string product_identifier)
	{
	}

	[Token(Token = "0x6014D08")]
	[Address(RVA = "0x177812C", Offset = "0x177812C", VA = "0x177812C")]
	private void _003CRequestMemberShipDesc_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014D09")]
	[Address(RVA = "0x1778250", Offset = "0x1778250", VA = "0x1778250")]
	private void _003CRequestMemberShipStoreInfo_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014D0A")]
	[Address(RVA = "0x1778408", Offset = "0x1778408", VA = "0x1778408")]
	private void _003CRequestMemberShipReissue_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014D0B")]
	[Address(RVA = "0x17785F4", Offset = "0x17785F4", VA = "0x17785F4")]
	private static CommonRewardItemInfo _003CShowInitAward_003Em__4(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6014D0C")]
	[Address(RVA = "0x17785FC", Offset = "0x17785FC", VA = "0x17785FC")]
	private static bool _003Cm_PredicateGem_003Em__5(AwardDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D0D")]
	[Address(RVA = "0x177862C", Offset = "0x177862C", VA = "0x177862C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014D0E")]
	[Address(RVA = "0x1778634", Offset = "0x1778634", VA = "0x1778634")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
