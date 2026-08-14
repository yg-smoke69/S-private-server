using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC9")]
public class Booyahday21ProcessRewardDesc
{
	[Token(Token = "0x400AED8")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AED9")]
	[FieldOffset(Offset = "0xC")]
	public uint progress;

	[Token(Token = "0x400AEDA")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> award_items;

	[Token(Token = "0x6008224")]
	[Address(RVA = "0x317CBF0", Offset = "0x317CBF0", VA = "0x317CBF0")]
	public Booyahday21ProcessRewardDesc()
	{
	}
}
