using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B9")]
public class CSClaimIntimacyAwardRes
{
	[Token(Token = "0x40096D6")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangedAward> exchange_awards;

	[Token(Token = "0x6007D1A")]
	[Address(RVA = "0x317E7D8", Offset = "0x317E7D8", VA = "0x317E7D8")]
	public CSClaimIntimacyAwardRes()
	{
	}
}
