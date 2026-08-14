using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017E7")]
public class LimitedEventStore
{
	[Token(Token = "0x4009BA4")]
	[FieldOffset(Offset = "0x8")]
	public BigEventStoreDesc store_desc;

	[Token(Token = "0x4009BA5")]
	[FieldOffset(Offset = "0xC")]
	public List<BigEventStoreCommodityDesc> store_commodities;

	[Token(Token = "0x6007E41")]
	[Address(RVA = "0x30A4A98", Offset = "0x30A4A98", VA = "0x30A4A98")]
	public LimitedEventStore()
	{
	}
}
