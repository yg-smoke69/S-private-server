using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A7B")]
public class RankingScaleModifyDetailDesc
{
	[Token(Token = "0x400A5B9")]
	[FieldOffset(Offset = "0x8")]
	public int battle_param_lower;

	[Token(Token = "0x400A5BA")]
	[FieldOffset(Offset = "0xC")]
	public int battle_param_upper;

	[Token(Token = "0x400A5BB")]
	[FieldOffset(Offset = "0x10")]
	public int ranking_expected_modify;

	[Token(Token = "0x60080D8")]
	[Address(RVA = "0x33E0CF8", Offset = "0x33E0CF8", VA = "0x33E0CF8")]
	public RankingScaleModifyDetailDesc()
	{
	}
}
