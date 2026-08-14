using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200174A")]
public class ExchangeStore
{
	[Token(Token = "0x40099D1")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeStoreDesc exchange_store_desc;

	[Token(Token = "0x40099D2")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangeStoreItemDesc> exchange_store_items;

	[Token(Token = "0x6007DA4")]
	[Address(RVA = "0x309FE0C", Offset = "0x309FE0C", VA = "0x309FE0C")]
	public ExchangeStore()
	{
	}
}
