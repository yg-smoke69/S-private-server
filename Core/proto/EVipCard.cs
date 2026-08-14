using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014C5")]
public class EVipCard
{
	[Token(Token = "0x20014C6")]
	public enum VipCardType
	{
		[Token(Token = "0x4008FC4")]
		VipCardType_NONE,
		[Token(Token = "0x4008FC5")]
		VipCardType_WEEKLY,
		[Token(Token = "0x4008FC6")]
		VipCardType_MONTHLY,
		[Token(Token = "0x4008FC7")]
		VipCardType_SVIP
	}

	[Token(Token = "0x20014C7")]
	public enum AwardStatus
	{
		[Token(Token = "0x4008FC9")]
		AwardStatus_INIT,
		[Token(Token = "0x4008FCA")]
		AwardStatus_CLAIMED,
		[Token(Token = "0x4008FCB")]
		AwardStatus_LOGIN_NOT_CLAIMED
	}

	[Token(Token = "0x20014C8")]
	public enum GoodsType
	{
		[Token(Token = "0x4008FCD")]
		GoodsType_NONE,
		[Token(Token = "0x4008FCE")]
		GoodsType_VIPONLY,
		[Token(Token = "0x4008FCF")]
		GoodsType_FREE
	}

	[Token(Token = "0x20014C9")]
	public enum GoodsPriceType
	{
		[Token(Token = "0x4008FD1")]
		GoodsPriceType_NONE,
		[Token(Token = "0x4008FD2")]
		GoodsPriceType_GEMS,
		[Token(Token = "0x4008FD3")]
		GoodsPriceType_COINS
	}

	[Token(Token = "0x20014CA")]
	public enum RebateType
	{
		[Token(Token = "0x4008FD5")]
		RebateType_NONE,
		[Token(Token = "0x4008FD6")]
		RebateType_WEEKLY,
		[Token(Token = "0x4008FD7")]
		RebateType_MONTHLY,
		[Token(Token = "0x4008FD8")]
		RebateType_WEEKLY_DISCOUNT,
		[Token(Token = "0x4008FD9")]
		RebateType_MONTHLY_DISCOUNT
	}

	[Token(Token = "0x6007B25")]
	[Address(RVA = "0x309F91C", Offset = "0x309F91C", VA = "0x309F91C")]
	public EVipCard()
	{
	}
}
