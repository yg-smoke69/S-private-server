using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001943")]
public class CSClaimCreditScoreWeeklyRewardsRes
{
	[Token(Token = "0x4009F4A")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009F4B")]
	[FieldOffset(Offset = "0x10")]
	public ExchangeChangeData weekly_rewards;

	[Token(Token = "0x6007F9C")]
	[Address(RVA = "0x317E580", Offset = "0x317E580", VA = "0x317E580")]
	public CSClaimCreditScoreWeeklyRewardsRes()
	{
	}
}
