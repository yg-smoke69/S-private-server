using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001745")]
public class CSGetDiscountStoreDescRes
{
	[Token(Token = "0x40099C2")]
	[FieldOffset(Offset = "0x8")]
	public List<DiscountStoreDesc> discountStores;

	[Token(Token = "0x6007D9F")]
	[Address(RVA = "0x31841A0", Offset = "0x31841A0", VA = "0x31841A0")]
	public CSGetDiscountStoreDescRes()
	{
	}
}
