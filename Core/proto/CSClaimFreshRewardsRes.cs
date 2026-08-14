using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017BF")]
public class CSClaimFreshRewardsRes
{
	[Token(Token = "0x4009B4F")]
	[FieldOffset(Offset = "0x8")]
	public AwardData awards;

	[Token(Token = "0x4009B50")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangedAward> exchange_awards;

	[Token(Token = "0x6007E19")]
	[Address(RVA = "0x317E694", Offset = "0x317E694", VA = "0x317E694")]
	public CSClaimFreshRewardsRes()
	{
	}
}
