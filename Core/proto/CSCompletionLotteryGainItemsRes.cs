using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016EE")]
public class CSCompletionLotteryGainItemsRes
{
	[Token(Token = "0x40097FB")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangedAward> exchanged_awards;

	[Token(Token = "0x6007D48")]
	[Address(RVA = "0x317F0BC", Offset = "0x317F0BC", VA = "0x317F0BC")]
	public CSCompletionLotteryGainItemsRes()
	{
	}
}
