using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001975")]
public class CSGetCustomEventStoreRes
{
	[Token(Token = "0x4009FD7")]
	[FieldOffset(Offset = "0x8")]
	public List<CustomEventStoreDesc> store_descs;

	[Token(Token = "0x4009FD8")]
	[FieldOffset(Offset = "0xC")]
	public List<CustomEventStoreCommodityDesc> store_commodities;

	[Token(Token = "0x6007FCE")]
	[Address(RVA = "0x3183C3C", Offset = "0x3183C3C", VA = "0x3183C3C")]
	public CSGetCustomEventStoreRes()
	{
	}
}
