using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001412")]
public class ChoosedEmotes
{
	[Token(Token = "0x4008C2C")]
	[FieldOffset(Offset = "0x8")]
	public List<ChoosedEmote> emotes;

	[Token(Token = "0x6007ADA")]
	[Address(RVA = "0x309B77C", Offset = "0x309B77C", VA = "0x309B77C")]
	public ChoosedEmotes()
	{
	}
}
