using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B9")]
public class CSGetFreshActivityRewardsRes
{
	[Token(Token = "0x4009B3F")]
	[FieldOffset(Offset = "0x8")]
	public AwardData awards;

	[Token(Token = "0x4009B40")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangedAward> exchange_awards;

	[Token(Token = "0x6007E13")]
	[Address(RVA = "0x3185154", Offset = "0x3185154", VA = "0x3185154")]
	public CSGetFreshActivityRewardsRes()
	{
	}
}
