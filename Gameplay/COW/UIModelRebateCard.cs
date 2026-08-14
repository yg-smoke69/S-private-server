using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20031FA")]
public class UIModelRebateCard : UIBaseModel
{
	[Token(Token = "0x20031FB")]
	public enum ExtraRewardStatus
	{
		[Token(Token = "0x4013071")]
		None,
		[Token(Token = "0x4013072")]
		Unclaimable,
		[Token(Token = "0x4013073")]
		Claimable,
		[Token(Token = "0x4013074")]
		Claimed
	}

	[Token(Token = "0x20031FC")]
	private class RebateCardsDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4013075")]
		[FieldOffset(Offset = "0x0")]
		private static RebateCardsDelegate _I;

		[Token(Token = "0x4013076")]
		[FieldOffset(Offset = "0x1C")]
		private string LastSubscribedProductIdentifier;

		[Token(Token = "0x17001639")]
		public static RebateCardsDelegate I
		{
			[Token(Token = "0x6015172")]
			[Address(RVA = "0x31426D4", Offset = "0x31426D4", VA = "0x31426D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700163A")]
		public override string Name
		{
			[Token(Token = "0x6015173")]
			[Address(RVA = "0x3146120", Offset = "0x3146120", VA = "0x3146120", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6015171")]
		[Address(RVA = "0x3146118", Offset = "0x3146118", VA = "0x3146118")]
		public RebateCardsDelegate()
		{
		}

		[Token(Token = "0x6015174")]
		[Address(RVA = "0x31461C4", Offset = "0x31461C4", VA = "0x31461C4", Slot = "13")]
		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x6015175")]
		[Address(RVA = "0x31463EC", Offset = "0x31463EC", VA = "0x31463EC", Slot = "15")]
		public override void OnRebateOptionsUpdated(string task, bool result, long[] rebateIds)
		{
		}

		[Token(Token = "0x6015176")]
		[Address(RVA = "0x314655C", Offset = "0x314655C", VA = "0x314655C", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6015177")]
		[Address(RVA = "0x3146904", Offset = "0x3146904", VA = "0x3146904", Slot = "20")]
		public override bool OnRebateOptionRedeemed(string reason, bool result, PayUtility.RebateOptionRedeemResult update)
		{
			return default(bool);
		}

		[Token(Token = "0x6015178")]
		[Address(RVA = "0x3146E94", Offset = "0x3146E94", VA = "0x3146E94")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x6015179")]
		[Address(RVA = "0x3146EB4", Offset = "0x3146EB4", VA = "0x3146EB4")]
		public void _003C_003EiFixBaseProxy_OnRebateOptionsUpdated(string P0, bool P1, long[] P2)
		{
		}

		[Token(Token = "0x601517A")]
		[Address(RVA = "0x3146ED4", Offset = "0x3146ED4", VA = "0x3146ED4")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		[Token(Token = "0x601517B")]
		[Address(RVA = "0x3146F08", Offset = "0x3146F08", VA = "0x3146F08")]
		public bool _003C_003EiFixBaseProxy_OnRebateOptionRedeemed(string P0, bool P1, PayUtility.RebateOptionRedeemResult P2)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4013060")]
	[FieldOffset(Offset = "0xC")]
	private readonly Dictionary<int, EEventType> m_RebateCardActivityType;

	[Token(Token = "0x4013061")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, bool?> m_SubscriptionBonusAvailable;

	[Token(Token = "0x4013062")]
	[FieldOffset(Offset = "0x14")]
	private ERebateModelState m_CurrentModelState;

	[Token(Token = "0x4013063")]
	[FieldOffset(Offset = "0x18")]
	private RebateCardInfo m_MonthCardData;

	[Token(Token = "0x4013064")]
	[FieldOffset(Offset = "0x1C")]
	private RebateCardInfo m_WeekCardData;

	[Token(Token = "0x4013065")]
	[FieldOffset(Offset = "0x20")]
	private ulong m_NextResetTimeSpan;

	[Token(Token = "0x4013066")]
	public const uint PropID_RebateCardDataUpdate = 2u;

	[Token(Token = "0x4013067")]
	public const uint PropID_PurchaseSuccess = 4u;

	[Token(Token = "0x4013068")]
	public const uint PropID_RedeemSuccess = 8u;

	[Token(Token = "0x4013069")]
	public const uint PropID_RebateCardPriceUpdate = 16u;

	[Token(Token = "0x401306A")]
	public const uint PropID_ShouldNotifyChange = 32u;

	[Token(Token = "0x401306B")]
	public const uint PropID_RebateCardSubscriptionUpdate = 128u;

	[Token(Token = "0x401306C")]
	public const uint PropID_RebateCardSubscriptionBonusUpdate = 256u;

	[Token(Token = "0x401306D")]
	public const uint PropID_RebateCardSubscriptionDone = 512u;

	[Token(Token = "0x401306E")]
	private const long REDEEM_RESET_TIME_OF_DAY_UTC_MS = 68400000L;

	[Token(Token = "0x401306F")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<long, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001633")]
	public bool RebateCardEnabled
	{
		[Token(Token = "0x601513E")]
		[Address(RVA = "0x313F360", Offset = "0x313F360", VA = "0x313F360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001634")]
	public bool RebateCardSubscriptionEnabled
	{
		[Token(Token = "0x6015140")]
		[Address(RVA = "0x313F51C", Offset = "0x313F51C", VA = "0x313F51C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001635")]
	public ERebateModelState CurrentModelState
	{
		[Token(Token = "0x601514E")]
		[Address(RVA = "0x314175C", Offset = "0x314175C", VA = "0x314175C")]
		get
		{
			return default(ERebateModelState);
		}
	}

	[Token(Token = "0x17001636")]
	public RebateCardInfo MonthCardData
	{
		[Token(Token = "0x601514F")]
		[Address(RVA = "0x31417B4", Offset = "0x31417B4", VA = "0x31417B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001637")]
	public RebateCardInfo WeekCardData
	{
		[Token(Token = "0x6015150")]
		[Address(RVA = "0x314180C", Offset = "0x314180C", VA = "0x314180C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001638")]
	public bool ShouldNotify
	{
		[Token(Token = "0x6015160")]
		[Address(RVA = "0x3143D70", Offset = "0x3143D70", VA = "0x3143D70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6015161")]
		[Address(RVA = "0x3143E3C", Offset = "0x3143E3C", VA = "0x3143E3C")]
		set
		{
		}
	}

	[Token(Token = "0x601513D")]
	[Address(RVA = "0x313F1B4", Offset = "0x313F1B4", VA = "0x313F1B4")]
	public UIModelRebateCard()
	{
	}

	[Token(Token = "0x601513F")]
	[Address(RVA = "0x313F4AC", Offset = "0x313F4AC", VA = "0x313F4AC")]
	public static SubscriptionPeriod Convert(RebateCardType rct)
	{
		return default(SubscriptionPeriod);
	}

	[Token(Token = "0x6015141")]
	[Address(RVA = "0x313F864", Offset = "0x313F864", VA = "0x313F864")]
	public RebateCardInfo RebateCard(RebateCardType rebateCardType)
	{
		return null;
	}

	[Token(Token = "0x6015142")]
	[Address(RVA = "0x313F8E4", Offset = "0x313F8E4", VA = "0x313F8E4")]
	public bool SupportSubscription(RebateCardType rebateCardType)
	{
		return default(bool);
	}

	[Token(Token = "0x6015143")]
	[Address(RVA = "0x313FAE4", Offset = "0x313FAE4", VA = "0x313FAE4")]
	public bool SubscriptionBonusAvailable(RebateCardType rebateCardType)
	{
		return default(bool);
	}

	[Token(Token = "0x6015144")]
	[Address(RVA = "0x313FE80", Offset = "0x313FE80", VA = "0x313FE80")]
	private Action<HttpErrorCode, object> OnGetSubscriptionBonusStatus(RebateCardType rebateCardType)
	{
		return null;
	}

	[Token(Token = "0x6015145")]
	[Address(RVA = "0x313FFAC", Offset = "0x313FFAC", VA = "0x313FFAC")]
	private void OnGetSubscriptionBonusStatus_Week(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x6015146")]
	[Address(RVA = "0x314050C", Offset = "0x314050C", VA = "0x314050C")]
	private void OnGetSubscriptionBonusStatus_Month(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x6015147")]
	[Address(RVA = "0x3140038", Offset = "0x3140038", VA = "0x3140038")]
	private void OnGetSubscriptionBonusStatus(RebateCardType rebateCardType, HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x6015148")]
	[Address(RVA = "0x31406A8", Offset = "0x31406A8", VA = "0x31406A8")]
	public string SubscriptionProductIdentifier(RebateCardType rebateCardType)
	{
		return null;
	}

	[Token(Token = "0x6015149")]
	[Address(RVA = "0x3140928", Offset = "0x3140928", VA = "0x3140928")]
	public PayItemData SubscriptionProduct(RebateCardType rebateCardType)
	{
		return null;
	}

	[Token(Token = "0x601514A")]
	[Address(RVA = "0x3140A0C", Offset = "0x3140A0C", VA = "0x3140A0C")]
	public void SetExtraRewardActivitiesRead()
	{
	}

	[Token(Token = "0x601514B")]
	[Address(RVA = "0x3140B90", Offset = "0x3140B90", VA = "0x3140B90")]
	public ActivityGroupDesc GetExtraRewardActivityGroupDesc(RebateCardType type)
	{
		return null;
	}

	[Token(Token = "0x601514C")]
	[Address(RVA = "0x3141194", Offset = "0x3141194", VA = "0x3141194")]
	public ExtraRewardStatus GetExtraRewardStatus(ActivityGroupDesc desc)
	{
		return default(ExtraRewardStatus);
	}

	[Token(Token = "0x601514D")]
	[Address(RVA = "0x3141464", Offset = "0x3141464", VA = "0x3141464")]
	public BaseItemInfo GetExtraReward(ActivityGroupDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6015151")]
	[Address(RVA = "0x3141864", Offset = "0x3141864", VA = "0x3141864", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015152")]
	[Address(RVA = "0x31418BC", Offset = "0x31418BC", VA = "0x31418BC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015153")]
	[Address(RVA = "0x3141E80", Offset = "0x3141E80", VA = "0x3141E80", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6015154")]
	[Address(RVA = "0x3142A08", Offset = "0x3142A08", VA = "0x3142A08", Slot = "7")]
	public override void LoginOffline()
	{
	}

	[Token(Token = "0x6015155")]
	[Address(RVA = "0x3140598", Offset = "0x3140598", VA = "0x3140598")]
	public void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6015156")]
	[Address(RVA = "0x3142A74", Offset = "0x3142A74", VA = "0x3142A74")]
	private void UpdateRebateCardPriceStatus()
	{
	}

	[Token(Token = "0x6015157")]
	[Address(RVA = "0x3142AE4", Offset = "0x3142AE4", VA = "0x3142AE4")]
	private void _UpdateRebateCardLocalizedPriceStatus(RebateCardInfo rebateCardInfo)
	{
	}

	[Token(Token = "0x6015158")]
	[Address(RVA = "0x3142D34", Offset = "0x3142D34", VA = "0x3142D34")]
	private void UpdateRebateCardSubscriptionStatus()
	{
	}

	[Token(Token = "0x6015159")]
	[Address(RVA = "0x3142DA4", Offset = "0x3142DA4", VA = "0x3142DA4")]
	private void _UpdateRebateCardSubscriptionPriceStatus(RebateCardType rebateCardType)
	{
	}

	[Token(Token = "0x601515A")]
	[Address(RVA = "0x3142BC8", Offset = "0x3142BC8", VA = "0x3142BC8")]
	private RebateCardInfo.ELocalizedPriceStatus GetLocalizedPriceStatus(string productIdentifier)
	{
		return default(RebateCardInfo.ELocalizedPriceStatus);
	}

	[Token(Token = "0x601515B")]
	[Address(RVA = "0x31427B8", Offset = "0x31427B8", VA = "0x31427B8")]
	public void UpdateRebateCardTips()
	{
	}

	[Token(Token = "0x601515C")]
	[Address(RVA = "0x3140E58", Offset = "0x3140E58", VA = "0x3140E58")]
	private void UpdateExtraRewardTips()
	{
	}

	[Token(Token = "0x601515D")]
	[Address(RVA = "0x3142EE0", Offset = "0x3142EE0", VA = "0x3142EE0")]
	public void UpdateRebateCardActivity()
	{
	}

	[Token(Token = "0x601515E")]
	[Address(RVA = "0x3142F58", Offset = "0x3142F58", VA = "0x3142F58")]
	private void TryClaimExtraReward(RebateCardType rebateCardType)
	{
	}

	[Token(Token = "0x601515F")]
	[Address(RVA = "0x31419BC", Offset = "0x31419BC", VA = "0x31419BC")]
	public void ChangeModelState(ERebateModelState nextState, object[] data)
	{
	}

	[Token(Token = "0x6015162")]
	[Address(RVA = "0x31433F0", Offset = "0x31433F0", VA = "0x31433F0")]
	private void UpdateRebateCardLocalNotification()
	{
	}

	[Token(Token = "0x6015163")]
	[Address(RVA = "0x3143F50", Offset = "0x3143F50", VA = "0x3143F50")]
	public void ReloadRebateCardsData()
	{
	}

	[Token(Token = "0x6015164")]
	[Address(RVA = "0x3144368", Offset = "0x3144368", VA = "0x3144368")]
	private void OnRebateCardProductsUpdated()
	{
	}

	[Token(Token = "0x6015165")]
	[Address(RVA = "0x3144438", Offset = "0x3144438", VA = "0x3144438")]
	private void OnRebateCardSubscriptionProductsUpdated()
	{
	}

	[Token(Token = "0x6015166")]
	[Address(RVA = "0x3144508", Offset = "0x3144508", VA = "0x3144508")]
	public void PurchaseRebateCard(RebateCardData rebateCardData, bool subscribe)
	{
	}

	[Token(Token = "0x6015167")]
	[Address(RVA = "0x3144C14", Offset = "0x3144C14", VA = "0x3144C14")]
	private void OnPurchased(string productIdentifier, int rebateId)
	{
	}

	[Token(Token = "0x6015168")]
	[Address(RVA = "0x31453E8", Offset = "0x31453E8", VA = "0x31453E8")]
	public void ShowSubscriptionTips(RebateCardType rebateCardType, Vector3 position)
	{
	}

	[Token(Token = "0x6015169")]
	[Address(RVA = "0x3145628", Offset = "0x3145628", VA = "0x3145628")]
	private void OnSubscribed(string productIdentifier)
	{
	}

	[Token(Token = "0x601516A")]
	[Address(RVA = "0x3145D18", Offset = "0x3145D18", VA = "0x3145D18")]
	public void RequestGetRedeem(int rebateId)
	{
	}

	[Token(Token = "0x601516B")]
	[Address(RVA = "0x3145DEC", Offset = "0x3145DEC", VA = "0x3145DEC")]
	public void OnRebateOptionRedeemed(PayUtility.RebateOptionRedeemResult result)
	{
	}

	[Token(Token = "0x601516C")]
	[Address(RVA = "0x3145FF8", Offset = "0x3145FF8", VA = "0x3145FF8")]
	private static string _003CLogin_003Em__0(long id)
	{
		return null;
	}

	[Token(Token = "0x601516D")]
	[Address(RVA = "0x3146018", Offset = "0x3146018", VA = "0x3146018")]
	private void _003COnSubscribed_003Em__1(string product_identifier)
	{
	}

	[Token(Token = "0x601516E")]
	[Address(RVA = "0x3146100", Offset = "0x3146100", VA = "0x3146100")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x601516F")]
	[Address(RVA = "0x3146108", Offset = "0x3146108", VA = "0x3146108")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6015170")]
	[Address(RVA = "0x3146110", Offset = "0x3146110", VA = "0x3146110")]
	public void _003C_003EiFixBaseProxy_LoginOffline()
	{
	}
}
