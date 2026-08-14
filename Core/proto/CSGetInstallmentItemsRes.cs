using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001751")]
public class CSGetInstallmentItemsRes
{
	[Token(Token = "0x40099E9")]
	[FieldOffset(Offset = "0x8")]
	public List<Item> items;

	[Token(Token = "0x6007DAB")]
	[Address(RVA = "0x31862CC", Offset = "0x31862CC", VA = "0x31862CC")]
	public CSGetInstallmentItemsRes()
	{
	}
}
