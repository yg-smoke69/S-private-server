using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001358")]
public class ItemSlice
{
	[Token(Token = "0x40088AE")]
	[FieldOffset(Offset = "0x8")]
	public List<Item> items;

	[Token(Token = "0x6007A59")]
	[Address(RVA = "0x30A4114", Offset = "0x30A4114", VA = "0x30A4114")]
	public ItemSlice()
	{
	}
}
