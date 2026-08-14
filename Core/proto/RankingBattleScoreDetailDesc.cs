using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A79")]
public class RankingBattleScoreDetailDesc
{
	[Token(Token = "0x400A5B3")]
	[FieldOffset(Offset = "0x8")]
	public float rank_percent_lower;

	[Token(Token = "0x400A5B4")]
	[FieldOffset(Offset = "0xC")]
	public float rank_percent_upper;

	[Token(Token = "0x400A5B5")]
	[FieldOffset(Offset = "0x10")]
	public int battle_score_modify;

	[Token(Token = "0x60080D6")]
	[Address(RVA = "0x33E0B88", Offset = "0x33E0B88", VA = "0x33E0B88")]
	public RankingBattleScoreDetailDesc()
	{
	}
}
