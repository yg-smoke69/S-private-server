using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200172D")]
public class CSGetExchangeStoreRes
{
	[Token(Token = "0x4009973")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangeStore> exchangeStores;

	[Token(Token = "0x4009974")]
	[FieldOffset(Offset = "0xC")]
	public List<RankExchangeDisplayDesc> display_desc;

	[Token(Token = "0x4009975")]
	[FieldOffset(Offset = "0x10")]
	public List<RankExchangeLimitItemDesc> exchange_store_item_desc;

	[Token(Token = "0x6007D87")]
	[Address(RVA = "0x31846BC", Offset = "0x31846BC", VA = "0x31846BC")]
	public CSGetExchangeStoreRes()
	{
	}
}
