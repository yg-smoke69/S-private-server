using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B9")]
public class InventoryChangeMessage
{
	[Token(Token = "0x4009422")]
	[FieldOffset(Offset = "0x8")]
	public List<Item> items;

	[Token(Token = "0x6007C03")]
	[Address(RVA = "0x30A3E70", Offset = "0x30A3E70", VA = "0x30A3E70")]
	public InventoryChangeMessage()
	{
	}
}
