using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB4")]
public class RankingItemRank
{
	[Token(Token = "0x400A80C")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A80D")]
	[FieldOffset(Offset = "0xC")]
	public uint buy_rank;

	[Token(Token = "0x400A80E")]
	[FieldOffset(Offset = "0x10")]
	public uint use_rank;

	[Token(Token = "0x400A80F")]
	[FieldOffset(Offset = "0x14")]
	public RankingItemRankAffectedSeason which_season;

	[Token(Token = "0x6008111")]
	[Address(RVA = "0x33E0BB8", Offset = "0x33E0BB8", VA = "0x33E0BB8")]
	public RankingItemRank()
	{
	}
}
