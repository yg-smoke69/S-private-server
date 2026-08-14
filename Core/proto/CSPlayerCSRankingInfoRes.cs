using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200154A")]
public class CSPlayerCSRankingInfoRes
{
	[Token(Token = "0x400929C")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400929D")]
	[FieldOffset(Offset = "0x10")]
	public uint season_id;

	[Token(Token = "0x400929E")]
	[FieldOffset(Offset = "0x14")]
	public uint rank;

	[Token(Token = "0x400929F")]
	[FieldOffset(Offset = "0x18")]
	public uint max_rank;

	[Token(Token = "0x40092A0")]
	[FieldOffset(Offset = "0x1C")]
	public uint ranking_points;

	[Token(Token = "0x40092A1")]
	[FieldOffset(Offset = "0x20")]
	public bool show_rank;

	[Token(Token = "0x40092A2")]
	[FieldOffset(Offset = "0x24")]
	public uint star;

	[Token(Token = "0x40092A3")]
	[FieldOffset(Offset = "0x28")]
	public uint hang_ups;

	[Token(Token = "0x40092A4")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_hang_up_ban;

	[Token(Token = "0x40092A5")]
	[FieldOffset(Offset = "0x30")]
	public uint star_protect_points;

	[Token(Token = "0x40092A6")]
	[FieldOffset(Offset = "0x34")]
	public uint games_played;

	[Token(Token = "0x40092A7")]
	[FieldOffset(Offset = "0x38")]
	public CSRankingInfo last_season_info;

	[Token(Token = "0x40092A8")]
	[FieldOffset(Offset = "0x3C")]
	public uint peak_rank_pos;

	[Token(Token = "0x40092A9")]
	[FieldOffset(Offset = "0x40")]
	public uint cs_ranking_bot_points;

	[Token(Token = "0x40092AA")]
	[FieldOffset(Offset = "0x44")]
	public bool reset_reward;

	[Token(Token = "0x40092AB")]
	[FieldOffset(Offset = "0x48")]
	public uint season_reset_rank;

	[Token(Token = "0x6007B92")]
	[Address(RVA = "0x30984FC", Offset = "0x30984FC", VA = "0x30984FC")]
	public CSPlayerCSRankingInfoRes()
	{
	}
}
