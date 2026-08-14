using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BEE")]
public class PeriodicRankTopAwardsDesc
{
	[Token(Token = "0x400AFEA")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400AFEB")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x400AFEC")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> season_awards;

	[Token(Token = "0x6008249")]
	[Address(RVA = "0x33DF3F4", Offset = "0x33DF3F4", VA = "0x33DF3F4")]
	public PeriodicRankTopAwardsDesc()
	{
	}
}
