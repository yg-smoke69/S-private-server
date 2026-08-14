using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D7")]
public class CSGetExchangeCurrencyLocalRes
{
	[Token(Token = "0x400945F")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangeCurrencyLocalDesc> exchange_currency_local_desc;

	[Token(Token = "0x6007C21")]
	[Address(RVA = "0x3184590", Offset = "0x3184590", VA = "0x3184590")]
	public CSGetExchangeCurrencyLocalRes()
	{
	}
}
