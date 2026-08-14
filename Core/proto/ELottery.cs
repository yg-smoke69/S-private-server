using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013EF")]
public class ELottery
{
	[Token(Token = "0x20013F0")]
	public enum LotteryType
	{
		[Token(Token = "0x4008B8D")]
		LotteryType_NONE,
		[Token(Token = "0x4008B8E")]
		LotteryType_ONE,
		[Token(Token = "0x4008B8F")]
		LotteryType_SOME,
		[Token(Token = "0x4008B90")]
		LotteryType_DROPUP_BUFF,
		[Token(Token = "0x4008B91")]
		LotteryType_RERANDOM
	}

	[Token(Token = "0x20013F1")]
	public enum PoolType
	{
		[Token(Token = "0x4008B93")]
		PoolType_ALL,
		[Token(Token = "0x4008B94")]
		PoolType_FR,
		[Token(Token = "0x4008B95")]
		PoolType_R,
		[Token(Token = "0x4008B96")]
		PoolType_SR,
		[Token(Token = "0x4008B97")]
		PoolType_NO_R,
		[Token(Token = "0x4008B98")]
		PoolType_NO_SR,
		[Token(Token = "0x4008B99")]
		PoolType_NO_R_SR,
		[Token(Token = "0x4008B9A")]
		PoolType_NO_FR,
		[Token(Token = "0x4008B9B")]
		PoolType_NO_FR_R,
		[Token(Token = "0x4008B9C")]
		PoolType_NO_FR_SR,
		[Token(Token = "0x4008B9D")]
		PoolType_NO_FR_R_SR,
		[Token(Token = "0x4008B9E")]
		PoolType_MUST_DROP,
		[Token(Token = "0x4008B9F")]
		PoolType_VETERAN
	}

	[Token(Token = "0x20013F2")]
	public enum CoinType
	{
		[Token(Token = "0x4008BA1")]
		CoinType_NONE,
		[Token(Token = "0x4008BA2")]
		CoinType_COINS,
		[Token(Token = "0x4008BA3")]
		CoinType_GEMS
	}

	[Token(Token = "0x20013F3")]
	public enum WeightType
	{
		[Token(Token = "0x4008BA5")]
		WeightType_NONE,
		[Token(Token = "0x4008BA6")]
		WeightType_FIRST_REWARD,
		[Token(Token = "0x4008BA7")]
		WeightType_BASE,
		[Token(Token = "0x4008BA8")]
		WeightType_SECOND_LEVEL,
		[Token(Token = "0x4008BA9")]
		WeightType_THIRD_LEVEL,
		[Token(Token = "0x4008BAA")]
		WeightType_VETERAN,
		[Token(Token = "0x4008BAB")]
		WeightType_FOURTH_LEVEL,
		[Token(Token = "0x4008BAC")]
		WeightType_FIFTH_LEVEL
	}

	[Token(Token = "0x20013F4")]
	public enum ConsumeType
	{
		[Token(Token = "0x4008BAE")]
		ConsumeType_NONE,
		[Token(Token = "0x4008BAF")]
		ConsumeType_FREE,
		[Token(Token = "0x4008BB0")]
		ConsumeType_EXCHANGE_ITEM,
		[Token(Token = "0x4008BB1")]
		ConsumeType_MONEY
	}

	[Token(Token = "0x20013F5")]
	public enum ExtraRewardState
	{
		[Token(Token = "0x4008BB3")]
		ExtraRewardState_NONE,
		[Token(Token = "0x4008BB4")]
		ExtraRewardState_RECEIVED
	}

	[Token(Token = "0x20013F6")]
	public enum Type
	{
		[Token(Token = "0x4008BB6")]
		Type_NORMAL = 0,
		[Token(Token = "0x4008BB7")]
		Type_TURNTABLE = 1,
		[Token(Token = "0x4008BB8")]
		Type_ULTRAMATE = 2,
		[Token(Token = "0x4008BB9")]
		Type_LEGENDARY = 3,
		[Token(Token = "0x4008BBA")]
		Type_LIMIT_POOL = 4,
		[Token(Token = "0x4008BBB")]
		Type_TOKEN_GACHA = 5,
		[Token(Token = "0x4008BBC")]
		Type_ENERGY_GACHA = 6,
		[Token(Token = "0x4008BBD")]
		Type_COMPLETION = 7,
		[Token(Token = "0x4008BBE")]
		Type_HACKERSTORE = 8,
		[Token(Token = "0x4008BBF")]
		Type_ACT_LIMIT_POOL = 101,
		[Token(Token = "0x4008BC0")]
		Type_ACT_REAPER = 102,
		[Token(Token = "0x4008BC1")]
		Type_ACT_ANN_POOL = 103,
		[Token(Token = "0x4008BC2")]
		Type_ACT_ANN_LIMIT_POOL = 104,
		[Token(Token = "0x4008BC3")]
		Type_ACT_COMPETITION = 105,
		[Token(Token = "0x4008BC4")]
		Type_ACT_MEGAPUNCH = 106
	}

	[Token(Token = "0x20013F7")]
	public enum RareType
	{
		[Token(Token = "0x4008BC6")]
		RareType_NORMAL,
		[Token(Token = "0x4008BC7")]
		RareType_RARE,
		[Token(Token = "0x4008BC8")]
		RareType_SUPER_RARE
	}

	[Token(Token = "0x20013F8")]
	public enum LimitPurchaseType
	{
		[Token(Token = "0x4008BCA")]
		LimitPurchaseType_NONE,
		[Token(Token = "0x4008BCB")]
		LimitPurchaseType_DAILY,
		[Token(Token = "0x4008BCC")]
		LimitPurchaseType_SUBID
	}

	[Token(Token = "0x20013F9")]
	public enum ExtraRewardCdtType
	{
		[Token(Token = "0x4008BCE")]
		ExtraRewardCdtType_NONE,
		[Token(Token = "0x4008BCF")]
		ExtraRewardCdtType_LOTTERY_COUNT,
		[Token(Token = "0x4008BD0")]
		ExtraRewardCdtType_PROGRESS
	}

	[Token(Token = "0x20013FA")]
	public enum BuffUpDisplayLevel
	{
		[Token(Token = "0x4008BD2")]
		BuffUpDisplayLevel_LOW,
		[Token(Token = "0x4008BD3")]
		BuffUpDisplayLevel_MEDIUM,
		[Token(Token = "0x4008BD4")]
		BuffUpDisplayLevel_HIGH
	}

	[Token(Token = "0x6007AD0")]
	[Address(RVA = "0x309F330", Offset = "0x309F330", VA = "0x309F330")]
	public ELottery()
	{
	}
}
