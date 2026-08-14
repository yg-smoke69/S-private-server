using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A4C")]
public class RankingMatchParam
{
	[Token(Token = "0x400A4AE")]
	[FieldOffset(Offset = "0x8")]
	public int solo_chicken_points;

	[Token(Token = "0x400A4AF")]
	[FieldOffset(Offset = "0xC")]
	public int dual_chicken_points;

	[Token(Token = "0x400A4B0")]
	[FieldOffset(Offset = "0x10")]
	public int squad_chicken_points;

	[Token(Token = "0x400A4B1")]
	[FieldOffset(Offset = "0x14")]
	public int limit_death_points;

	[Token(Token = "0x400A4B2")]
	[FieldOffset(Offset = "0x18")]
	public int gap_death_points;

	[Token(Token = "0x400A4B3")]
	[FieldOffset(Offset = "0x1C")]
	public int knockdown_points;

	[Token(Token = "0x400A4B4")]
	[FieldOffset(Offset = "0x20")]
	public int revive_points;

	[Token(Token = "0x400A4B5")]
	[FieldOffset(Offset = "0x24")]
	public uint solo_battle_score_limit;

	[Token(Token = "0x400A4B6")]
	[FieldOffset(Offset = "0x28")]
	public uint solo_kill_add;

	[Token(Token = "0x400A4B7")]
	[FieldOffset(Offset = "0x2C")]
	public uint solo_kill_multi;

	[Token(Token = "0x400A4B8")]
	[FieldOffset(Offset = "0x30")]
	public uint group_battle_score_limit;

	[Token(Token = "0x400A4B9")]
	[FieldOffset(Offset = "0x34")]
	public uint group_kill_add;

	[Token(Token = "0x400A4BA")]
	[FieldOffset(Offset = "0x38")]
	public uint group_kill_multi;

	[Token(Token = "0x400A4BB")]
	[FieldOffset(Offset = "0x3C")]
	public uint damage_per_score;

	[Token(Token = "0x400A4BC")]
	[FieldOffset(Offset = "0x40")]
	public int down_points;

	[Token(Token = "0x400A4BD")]
	[FieldOffset(Offset = "0x44")]
	public int fratricide_points;

	[Token(Token = "0x400A4BE")]
	[FieldOffset(Offset = "0x48")]
	public uint first_win_rank;

	[Token(Token = "0x400A4BF")]
	[FieldOffset(Offset = "0x4C")]
	public uint first_win_kill;

	[Token(Token = "0x400A4C0")]
	[FieldOffset(Offset = "0x50")]
	public uint ranking_token_id;

	[Token(Token = "0x400A4C1")]
	[FieldOffset(Offset = "0x54")]
	public uint most_token_given;

	[Token(Token = "0x400A4C2")]
	[FieldOffset(Offset = "0x58")]
	public float ranking_extra_coins;

	[Token(Token = "0x400A4C3")]
	[FieldOffset(Offset = "0x5C")]
	public float ranking_extra_exp;

	[Token(Token = "0x400A4C4")]
	[FieldOffset(Offset = "0x60")]
	public int birth_island_quit_deduct;

	[Token(Token = "0x400A4C5")]
	[FieldOffset(Offset = "0x64")]
	public uint rp_range_add_bp_lower;

	[Token(Token = "0x400A4C6")]
	[FieldOffset(Offset = "0x68")]
	public uint rp_range_add_bp_upper;

	[Token(Token = "0x400A4C7")]
	[FieldOffset(Offset = "0x6C")]
	public int relife_teammate_points;

	[Token(Token = "0x400A4C8")]
	[FieldOffset(Offset = "0x70")]
	public int be_relife_points;

	[Token(Token = "0x400A4C9")]
	[FieldOffset(Offset = "0x74")]
	public uint min_rank_show;

	[Token(Token = "0x400A4CA")]
	[FieldOffset(Offset = "0x78")]
	public float map_rp;

	[Token(Token = "0x60080A4")]
	[Address(RVA = "0x33E0C54", Offset = "0x33E0C54", VA = "0x33E0C54")]
	public RankingMatchParam()
	{
	}
}
