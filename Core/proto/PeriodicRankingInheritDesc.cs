using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BEB")]
public class PeriodicRankingInheritDesc
{
	[Token(Token = "0x400AFD8")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400AFD9")]
	[FieldOffset(Offset = "0xC")]
	public uint lower_bound;

	[Token(Token = "0x400AFDA")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_bound;

	[Token(Token = "0x400AFDB")]
	[FieldOffset(Offset = "0x14")]
	public uint next_season_ranking_point;

	[Token(Token = "0x400AFDC")]
	[FieldOffset(Offset = "0x18")]
	public uint mmr_correction;

	[Token(Token = "0x6008246")]
	[Address(RVA = "0x33DF488", Offset = "0x33DF488", VA = "0x33DF488")]
	public PeriodicRankingInheritDesc()
	{
	}
}
