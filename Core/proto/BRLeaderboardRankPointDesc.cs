using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A4B")]
public class BRLeaderboardRankPointDesc
{
	[Token(Token = "0x400A4AC")]
	[FieldOffset(Offset = "0x8")]
	public uint br_season_id;

	[Token(Token = "0x400A4AD")]
	[FieldOffset(Offset = "0xC")]
	public uint min_br_rank_point;

	[Token(Token = "0x60080A3")]
	[Address(RVA = "0x317B664", Offset = "0x317B664", VA = "0x317B664")]
	public BRLeaderboardRankPointDesc()
	{
	}
}
