using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D5")]
public class CSGetExchangeCurrencyAllDescRes
{
	[Token(Token = "0x400945D")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangeCurrencyDesc> exchange_currency_desc;

	[Token(Token = "0x6007C1F")]
	[Address(RVA = "0x3184504", Offset = "0x3184504", VA = "0x3184504")]
	public CSGetExchangeCurrencyAllDescRes()
	{
	}
}
