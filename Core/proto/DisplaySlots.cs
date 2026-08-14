using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001414")]
public class DisplaySlots
{
	[Token(Token = "0x4008C2F")]
	[FieldOffset(Offset = "0x8")]
	public List<DisplaySlot> slots;

	[Token(Token = "0x6007ADC")]
	[Address(RVA = "0x309F19C", Offset = "0x309F19C", VA = "0x309F19C")]
	public DisplaySlots()
	{
	}
}
