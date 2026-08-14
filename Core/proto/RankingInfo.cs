using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001544")]
public class RankingInfo
{
	[Token(Token = "0x400928E")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x400928F")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x4009290")]
	[FieldOffset(Offset = "0x10")]
	public uint max_rank;

	[Token(Token = "0x4009291")]
	[FieldOffset(Offset = "0x14")]
	public uint ranking_points;

	[Token(Token = "0x4009292")]
	[FieldOffset(Offset = "0x18")]
	public uint peak_rank_pos;

	[Token(Token = "0x6007B8C")]
	[Address(RVA = "0x33E0BA8", Offset = "0x33E0BA8", VA = "0x33E0BA8")]
	public RankingInfo()
	{
	}
}
