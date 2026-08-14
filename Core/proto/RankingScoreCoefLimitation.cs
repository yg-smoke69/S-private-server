using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A4E")]
public class RankingScoreCoefLimitation
{
	[Token(Token = "0x400A4CE")]
	[FieldOffset(Offset = "0x8")]
	public uint min_score;

	[Token(Token = "0x400A4CF")]
	[FieldOffset(Offset = "0xC")]
	public uint max_score;

	[Token(Token = "0x400A4D0")]
	[FieldOffset(Offset = "0x10")]
	public double min_coef;

	[Token(Token = "0x400A4D1")]
	[FieldOffset(Offset = "0x18")]
	public double max_coef;

	[Token(Token = "0x60080A6")]
	[Address(RVA = "0x33E0D00", Offset = "0x33E0D00", VA = "0x33E0D00")]
	public RankingScoreCoefLimitation()
	{
	}
}
