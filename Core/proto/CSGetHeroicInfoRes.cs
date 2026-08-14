using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001546")]
public class CSGetHeroicInfoRes
{
	[Token(Token = "0x4009295")]
	[FieldOffset(Offset = "0x8")]
	public uint[] br_reached_season;

	[Token(Token = "0x4009296")]
	[FieldOffset(Offset = "0xC")]
	public uint[] cs_reached_season;

	[Token(Token = "0x4009297")]
	[FieldOffset(Offset = "0x10")]
	public uint[] br_reached_season_max_rank;

	[Token(Token = "0x4009298")]
	[FieldOffset(Offset = "0x14")]
	public uint[] cs_reached_season_max_rank;

	[Token(Token = "0x6007B8E")]
	[Address(RVA = "0x3185CD0", Offset = "0x3185CD0", VA = "0x3185CD0")]
	public CSGetHeroicInfoRes()
	{
	}
}
