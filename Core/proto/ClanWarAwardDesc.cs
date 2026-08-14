using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A36")]
public class ClanWarAwardDesc
{
	[Token(Token = "0x400A421")]
	[FieldOffset(Offset = "0x8")]
	public uint award_level;

	[Token(Token = "0x400A422")]
	[FieldOffset(Offset = "0xC")]
	public uint award_bound;

	[Token(Token = "0x400A423")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> end_award;

	[Token(Token = "0x600808E")]
	[Address(RVA = "0x309C160", Offset = "0x309C160", VA = "0x309C160")]
	public ClanWarAwardDesc()
	{
	}
}
