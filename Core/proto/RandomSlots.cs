using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014FD")]
public class RandomSlots
{
	[Token(Token = "0x4009077")]
	[FieldOffset(Offset = "0x8")]
	public List<RandomSlotInfo> slots;

	[Token(Token = "0x6007B47")]
	[Address(RVA = "0x33E0728", Offset = "0x33E0728", VA = "0x33E0728")]
	public RandomSlots()
	{
	}
}
