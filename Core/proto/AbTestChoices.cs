using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012F5")]
public class AbTestChoices
{
	[Token(Token = "0x40085B1")]
	[FieldOffset(Offset = "0x8")]
	public List<AbTestChoice> choices;

	[Token(Token = "0x6007A42")]
	[Address(RVA = "0x3179394", Offset = "0x3179394", VA = "0x3179394")]
	public AbTestChoices()
	{
	}
}
