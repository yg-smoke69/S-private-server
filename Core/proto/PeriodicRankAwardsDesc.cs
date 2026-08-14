using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BED")]
public class PeriodicRankAwardsDesc
{
	[Token(Token = "0x400AFE7")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400AFE8")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x400AFE9")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> level_awards;

	[Token(Token = "0x6008248")]
	[Address(RVA = "0x33DF2BC", Offset = "0x33DF2BC", VA = "0x33DF2BC")]
	public PeriodicRankAwardsDesc()
	{
	}
}
