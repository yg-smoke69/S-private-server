using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014DE")]
public class BoybandBTradingCardAccountInfo
{
	[Token(Token = "0x4009016")]
	[FieldOffset(Offset = "0x8")]
	public List<BoybandBTradingCardInfo> infos;

	[Token(Token = "0x6007B33")]
	[Address(RVA = "0x317D40C", Offset = "0x317D40C", VA = "0x317D40C")]
	public BoybandBTradingCardAccountInfo()
	{
	}
}
