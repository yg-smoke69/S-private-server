using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015D1")]
public class CSGetUnlockedFittingSlotsRes
{
	[Token(Token = "0x4009457")]
	[FieldOffset(Offset = "0x8")]
	public List<FittingSlot> fitting_slot;

	[Token(Token = "0x6007C1B")]
	[Address(RVA = "0x3095E3C", Offset = "0x3095E3C", VA = "0x3095E3C")]
	public CSGetUnlockedFittingSlotsRes()
	{
	}
}
