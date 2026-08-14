using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200154E")]
public class CSRankingInfo
{
	[Token(Token = "0x40092B4")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x40092B5")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x40092B6")]
	[FieldOffset(Offset = "0x10")]
	public uint max_rank;

	[Token(Token = "0x40092B7")]
	[FieldOffset(Offset = "0x14")]
	public uint ranking_points;

	[Token(Token = "0x40092B8")]
	[FieldOffset(Offset = "0x18")]
	public uint game_played;

	[Token(Token = "0x40092B9")]
	[FieldOffset(Offset = "0x1C")]
	public uint peak_rank_pos;

	[Token(Token = "0x6007B96")]
	[Address(RVA = "0x3098C90", Offset = "0x3098C90", VA = "0x3098C90")]
	public CSRankingInfo()
	{
	}
}
