using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D7")]
public class CSExchangeGachaExtraRewardRes
{
	[Token(Token = "0x400977A")]
	[FieldOffset(Offset = "0x8")]
	public uint[] exchanged_reward_list;

	[Token(Token = "0x400977B")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangedAward> extra_rewards;

	[Token(Token = "0x6007D31")]
	[Address(RVA = "0x317FE88", Offset = "0x317FE88", VA = "0x317FE88")]
	public CSExchangeGachaExtraRewardRes()
	{
	}
}
