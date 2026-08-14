using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200192A")]
public class CSPlayerPeriodicRankingInfoRes
{
	[Token(Token = "0x4009EEA")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009EEB")]
	[FieldOffset(Offset = "0x10")]
	public uint season_id;

	[Token(Token = "0x4009EEC")]
	[FieldOffset(Offset = "0x14")]
	public uint rank;

	[Token(Token = "0x4009EED")]
	[FieldOffset(Offset = "0x18")]
	public uint max_rank;

	[Token(Token = "0x4009EEE")]
	[FieldOffset(Offset = "0x1C")]
	public uint ranking_points;

	[Token(Token = "0x4009EEF")]
	[FieldOffset(Offset = "0x20")]
	public uint cur_rank_points;

	[Token(Token = "0x4009EF0")]
	[FieldOffset(Offset = "0x24")]
	public uint ranking_protect_points;

	[Token(Token = "0x4009EF1")]
	[FieldOffset(Offset = "0x28")]
	public uint games_played;

	[Token(Token = "0x4009EF2")]
	[FieldOffset(Offset = "0x2C")]
	public uint game_round_played;

	[Token(Token = "0x4009EF3")]
	[FieldOffset(Offset = "0x30")]
	public PeriodicRankingInfo last_season_info;

	[Token(Token = "0x4009EF4")]
	[FieldOffset(Offset = "0x34")]
	public uint wins;

	[Token(Token = "0x4009EF5")]
	[FieldOffset(Offset = "0x38")]
	public uint kills;

	[Token(Token = "0x4009EF6")]
	[FieldOffset(Offset = "0x3C")]
	public uint damage;

	[Token(Token = "0x4009EF7")]
	[FieldOffset(Offset = "0x40")]
	public uint head_shot_kills;

	[Token(Token = "0x4009EF8")]
	[FieldOffset(Offset = "0x44")]
	public uint assists;

	[Token(Token = "0x4009EF9")]
	[FieldOffset(Offset = "0x48")]
	public uint deaths;

	[Token(Token = "0x4009EFA")]
	[FieldOffset(Offset = "0x4C")]
	public uint double_kills;

	[Token(Token = "0x4009EFB")]
	[FieldOffset(Offset = "0x50")]
	public uint four_kills;

	[Token(Token = "0x4009EFC")]
	[FieldOffset(Offset = "0x54")]
	public bool reset_reward;

	[Token(Token = "0x4009EFD")]
	[FieldOffset(Offset = "0x58")]
	public uint season_reset_rank;

	[Token(Token = "0x6007F83")]
	[Address(RVA = "0x30985A0", Offset = "0x30985A0", VA = "0x30985A0")]
	public CSPlayerPeriodicRankingInfoRes()
	{
	}
}
