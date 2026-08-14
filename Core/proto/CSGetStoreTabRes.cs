using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001748")]
public class CSGetStoreTabRes
{
	[Token(Token = "0x40099CB")]
	[FieldOffset(Offset = "0x8")]
	public List<StoreTableDesc> store_tables;

	[Token(Token = "0x6007DA2")]
	[Address(RVA = "0x30956DC", Offset = "0x30956DC", VA = "0x30956DC")]
	public CSGetStoreTabRes()
	{
	}
}
