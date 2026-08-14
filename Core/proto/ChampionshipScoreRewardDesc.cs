using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF9")]
public class ChampionshipScoreRewardDesc
{
	[Token(Token = "0x400A9AE")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A9AF")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x400A9B0")]
	[FieldOffset(Offset = "0x10")]
	public uint lower_bound;

	[Token(Token = "0x400A9B1")]
	[FieldOffset(Offset = "0x14")]
	public uint upper_bound;

	[Token(Token = "0x400A9B2")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> end_award;

	[Token(Token = "0x6008154")]
	[Address(RVA = "0x309AFF4", Offset = "0x309AFF4", VA = "0x309AFF4")]
	public ChampionshipScoreRewardDesc()
	{
	}
}
