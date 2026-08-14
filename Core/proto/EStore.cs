using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001401")]
public class EStore
{
	[Token(Token = "0x2001402")]
	public enum GiftRankType
	{
		[Token(Token = "0x4008BEB")]
		GiftRankType_NONE,
		[Token(Token = "0x4008BEC")]
		GiftRankType_RECEIVER,
		[Token(Token = "0x4008BED")]
		GiftRankType_GIVER
	}

	[Token(Token = "0x2001403")]
	public enum IapType
	{
		[Token(Token = "0x4008BEF")]
		IapType_NORMAL,
		[Token(Token = "0x4008BF0")]
		IapType_VETERAN
	}

	[Token(Token = "0x2001404")]
	public enum IapConsumeType
	{
		[Token(Token = "0x4008BF2")]
		IapConsumeType_CASH,
		[Token(Token = "0x4008BF3")]
		IapConsumeType_DIAMOND
	}

	[Token(Token = "0x2001405")]
	public enum IapSpecialDropType
	{
		[Token(Token = "0x4008BF5")]
		IapSpecialDropType_NONE,
		[Token(Token = "0x4008BF6")]
		IapSpecialDropType_HEAD_SHOT_KILLS,
		[Token(Token = "0x4008BF7")]
		IapSpecialDropType_KILLS,
		[Token(Token = "0x4008BF8")]
		IapSpecialDropType_HP_PKG_USED_CNT,
		[Token(Token = "0x4008BF9")]
		IapSpecialDropType_DAMAGE
	}

	[Token(Token = "0x2001406")]
	public enum IapStoreType
	{
		[Token(Token = "0x4008BFB")]
		IapStoreType_NONE,
		[Token(Token = "0x4008BFC")]
		IapStoreType_AFTER_FIGHT,
		[Token(Token = "0x4008BFD")]
		IapStoreType_WEB_ACTIVITY,
		[Token(Token = "0x4008BFE")]
		IapStoreType_OPTIONAL_BUNDLE,
		[Token(Token = "0x4008BFF")]
		IapStoreType_VIPCARD
	}

	[Token(Token = "0x2001407")]
	public enum IapDropSituation
	{
		[Token(Token = "0x4008C01")]
		IapDropSituation_NONE,
		[Token(Token = "0x4008C02")]
		IapDropSituation_AFTER_FIGHT,
		[Token(Token = "0x4008C03")]
		IapDropSituation_RECHARGE,
		[Token(Token = "0x4008C04")]
		IapDropSituation_EXCHANGE_ITEM
	}

	[Token(Token = "0x2001408")]
	public enum RebateCardBillStatus
	{
		[Token(Token = "0x4008C06")]
		RebateCardBillStatus_NONE,
		[Token(Token = "0x4008C07")]
		RebateCardBillStatus_HITTING,
		[Token(Token = "0x4008C08")]
		RebateCardBillStatus_DONE,
		[Token(Token = "0x4008C09")]
		RebateCardBillStatus_TIMEOUT,
		[Token(Token = "0x4008C0A")]
		RebateCardBillStatus_PENDING
	}

	[Token(Token = "0x2001409")]
	public enum BundleRefreshType
	{
		[Token(Token = "0x4008C0C")]
		BundleRefreshType_NEVER,
		[Token(Token = "0x4008C0D")]
		BundleRefreshType_DAILY,
		[Token(Token = "0x4008C0E")]
		BundleRefreshType_WEEKLY,
		[Token(Token = "0x4008C0F")]
		BundleRefreshType_MONTHLY
	}

	[Token(Token = "0x200140A")]
	public enum PbwConsumeType
	{
		[Token(Token = "0x4008C11")]
		PbwConsumeType_CASH,
		[Token(Token = "0x4008C12")]
		PbwConsumeType_DIAMOND,
		[Token(Token = "0x4008C13")]
		PbwConsumeType_FREE
	}

	[Token(Token = "0x200140B")]
	public enum PbwActivityType
	{
		[Token(Token = "0x4008C15")]
		PbwActivityType_NONE,
		[Token(Token = "0x4008C16")]
		PbwActivityType_DISCOUNT_BUNDLE,
		[Token(Token = "0x4008C17")]
		PbwActivityType_NEWBIE_BUNDLE,
		[Token(Token = "0x4008C18")]
		PbwActivityType_GROWUP_BUNDLE
	}

	[Token(Token = "0x200140C")]
	public enum PayLevelRewardHintType
	{
		[Token(Token = "0x4008C1A")]
		PayLevelRewardHintType_NONE,
		[Token(Token = "0x4008C1B")]
		PayLevelRewardHintType_NOPAY,
		[Token(Token = "0x4008C1C")]
		PayLevelRewardHintType_PAY,
		[Token(Token = "0x4008C1D")]
		PayLevelRewardHintType_ALL
	}

	[Token(Token = "0x200140D")]
	public enum PayLevelInfoState
	{
		[Token(Token = "0x4008C1F")]
		PayLevelInfoState_RECEIVED,
		[Token(Token = "0x4008C20")]
		PayLevelInfoState_FINISHED,
		[Token(Token = "0x4008C21")]
		PayLevelInfoState_AWARDED
	}

	[Token(Token = "0x200140E")]
	public enum PurchaseItemChannel
	{
		[Token(Token = "0x4008C23")]
		PurchaseItemChannel_OTHER,
		[Token(Token = "0x4008C24")]
		PurchaseItemChannel_GOOGLE_PLAY_POINT
	}

	[Token(Token = "0x200140F")]
	public enum HyperBookType
	{
		[Token(Token = "0x4008C26")]
		HyperBookType_FREE,
		[Token(Token = "0x4008C27")]
		HyperBookType_PAID
	}

	[Token(Token = "0x6007AD7")]
	[Address(RVA = "0x309F8FC", Offset = "0x309F8FC", VA = "0x309F8FC")]
	public EStore()
	{
	}
}
