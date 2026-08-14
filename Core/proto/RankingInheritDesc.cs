using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A4A")]
public class RankingInheritDesc
{
	[Token(Token = "0x400A4A8")]
	[FieldOffset(Offset = "0x8")]
	public uint lower_bound;

	[Token(Token = "0x400A4A9")]
	[FieldOffset(Offset = "0xC")]
	public uint upper_bound;

	[Token(Token = "0x400A4AA")]
	[FieldOffset(Offset = "0x10")]
	public uint next_season_ranking_point;

	[Token(Token = "0x400A4AB")]
	[FieldOffset(Offset = "0x14")]
	public uint mmr_correction;

	[Token(Token = "0x60080A2")]
	[Address(RVA = "0x33E0BB0", Offset = "0x33E0BB0", VA = "0x33E0BB0")]
	public RankingInheritDesc()
	{
	}
}
