using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001744")]
public class CSGetPBWSpecialStoreRes
{
	[Token(Token = "0x40099C1")]
	[FieldOffset(Offset = "0x8")]
	public List<SpecialStoreDesc> special_stores;

	[Token(Token = "0x6007D9E")]
	[Address(RVA = "0x31883BC", Offset = "0x31883BC", VA = "0x31883BC")]
	public CSGetPBWSpecialStoreRes()
	{
	}
}
