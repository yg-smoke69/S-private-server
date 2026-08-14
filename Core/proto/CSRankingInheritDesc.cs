using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B27")]
public class CSRankingInheritDesc
{
	[Token(Token = "0x400AAAD")]
	[FieldOffset(Offset = "0x8")]
	public uint lower_bound;

	[Token(Token = "0x400AAAE")]
	[FieldOffset(Offset = "0xC")]
	public uint upper_bound;

	[Token(Token = "0x400AAAF")]
	[FieldOffset(Offset = "0x10")]
	public uint next_season_ranking_point;

	[Token(Token = "0x400AAB0")]
	[FieldOffset(Offset = "0x14")]
	public uint mmr_correction;

	[Token(Token = "0x6008182")]
	[Address(RVA = "0x3098C98", Offset = "0x3098C98", VA = "0x3098C98")]
	public CSRankingInheritDesc()
	{
	}
}
