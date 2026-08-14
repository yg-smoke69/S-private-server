using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A78")]
public class RankingBattleScoreDesc
{
	[Token(Token = "0x400A5B0")]
	[FieldOffset(Offset = "0x8")]
	public uint life_time_lower;

	[Token(Token = "0x400A5B1")]
	[FieldOffset(Offset = "0xC")]
	public uint life_time_upper;

	[Token(Token = "0x400A5B2")]
	[FieldOffset(Offset = "0x10")]
	public List<RankingBattleScoreDetailDesc> battle_score_details;

	[Token(Token = "0x60080D5")]
	[Address(RVA = "0x33E0AFC", Offset = "0x33E0AFC", VA = "0x33E0AFC")]
	public RankingBattleScoreDesc()
	{
	}
}
