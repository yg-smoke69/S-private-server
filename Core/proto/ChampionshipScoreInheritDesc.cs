using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF8")]
public class ChampionshipScoreInheritDesc
{
	[Token(Token = "0x400A9AA")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A9AB")]
	[FieldOffset(Offset = "0xC")]
	public uint lower_bound;

	[Token(Token = "0x400A9AC")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_bound;

	[Token(Token = "0x400A9AD")]
	[FieldOffset(Offset = "0x14")]
	public uint next_season_ranking_point;

	[Token(Token = "0x6008153")]
	[Address(RVA = "0x309AFEC", Offset = "0x309AFEC", VA = "0x309AFEC")]
	public ChampionshipScoreInheritDesc()
	{
	}
}
