using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001598")]
public class CSGetStoreRes
{
	[Token(Token = "0x40093AE")]
	[FieldOffset(Offset = "0x8")]
	public List<StoreDesc> store_items;

	[Token(Token = "0x6007BE0")]
	[Address(RVA = "0x3095650", Offset = "0x3095650", VA = "0x3095650")]
	public CSGetStoreRes()
	{
	}
}
