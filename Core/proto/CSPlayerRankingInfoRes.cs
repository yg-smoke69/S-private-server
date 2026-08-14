using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200153A")]
public class CSPlayerRankingInfoRes
{
	[Token(Token = "0x4009265")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009266")]
	[FieldOffset(Offset = "0x10")]
	public uint season_id;

	[Token(Token = "0x4009267")]
	[FieldOffset(Offset = "0x14")]
	public uint rank;

	[Token(Token = "0x4009268")]
	[FieldOffset(Offset = "0x18")]
	public uint max_rank;

	[Token(Token = "0x4009269")]
	[FieldOffset(Offset = "0x1C")]
	public uint ranking_points;

	[Token(Token = "0x400926A")]
	[FieldOffset(Offset = "0x20")]
	public bool show_rank;

	[Token(Token = "0x400926B")]
	[FieldOffset(Offset = "0x24")]
	public RankingInfo last_season_info;

	[Token(Token = "0x400926C")]
	[FieldOffset(Offset = "0x28")]
	public uint match_token_num;

	[Token(Token = "0x400926D")]
	[FieldOffset(Offset = "0x2C")]
	public uint ranking_bot_points;

	[Token(Token = "0x400926E")]
	[FieldOffset(Offset = "0x30")]
	public uint peak_rank_pos;

	[Token(Token = "0x400926F")]
	[FieldOffset(Offset = "0x34")]
	public bool reset_reward;

	[Token(Token = "0x4009270")]
	[FieldOffset(Offset = "0x38")]
	public uint season_reset_rank;

	[Token(Token = "0x4009271")]
	[FieldOffset(Offset = "0x3C")]
	public uint games_played;

	[Token(Token = "0x6007B82")]
	[Address(RVA = "0x30985B0", Offset = "0x30985B0", VA = "0x30985B0")]
	public CSPlayerRankingInfoRes()
	{
	}
}
