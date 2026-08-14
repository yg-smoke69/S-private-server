using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200153C")]
public class CSPlayerRankingSeasonStatsRes
{
	[Token(Token = "0x4009273")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009274")]
	[FieldOffset(Offset = "0x10")]
	public uint season_id;

	[Token(Token = "0x4009275")]
	[FieldOffset(Offset = "0x14")]
	public uint games_played;

	[Token(Token = "0x4009276")]
	[FieldOffset(Offset = "0x18")]
	public uint max_rank;

	[Token(Token = "0x4009277")]
	[FieldOffset(Offset = "0x1C")]
	public uint max_ranking_points;

	[Token(Token = "0x4009278")]
	[FieldOffset(Offset = "0x20")]
	public uint wins;

	[Token(Token = "0x4009279")]
	[FieldOffset(Offset = "0x24")]
	public uint top_10_percent_times;

	[Token(Token = "0x400927A")]
	[FieldOffset(Offset = "0x28")]
	public uint top_50_percent_times;

	[Token(Token = "0x400927B")]
	[FieldOffset(Offset = "0x2C")]
	public uint survival_time;

	[Token(Token = "0x400927C")]
	[FieldOffset(Offset = "0x30")]
	public uint moving_distance;

	[Token(Token = "0x400927D")]
	[FieldOffset(Offset = "0x34")]
	public uint kills;

	[Token(Token = "0x400927E")]
	[FieldOffset(Offset = "0x38")]
	public uint damage;

	[Token(Token = "0x400927F")]
	[FieldOffset(Offset = "0x3C")]
	public uint one_game_most_kills;

	[Token(Token = "0x4009280")]
	[FieldOffset(Offset = "0x40")]
	public uint one_game_most_damage;

	[Token(Token = "0x4009281")]
	[FieldOffset(Offset = "0x44")]
	public uint head_shot_kills;

	[Token(Token = "0x4009282")]
	[FieldOffset(Offset = "0x48")]
	public uint revivals;

	[Token(Token = "0x6007B84")]
	[Address(RVA = "0x30985C0", Offset = "0x30985C0", VA = "0x30985C0")]
	public CSPlayerRankingSeasonStatsRes()
	{
	}
}
