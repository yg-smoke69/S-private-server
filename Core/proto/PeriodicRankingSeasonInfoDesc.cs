using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BEA")]
public class PeriodicRankingSeasonInfoDesc
{
	[Token(Token = "0x400AFC5")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400AFC6")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400AFC7")]
	[FieldOffset(Offset = "0x10")]
	public long open_time;

	[Token(Token = "0x400AFC8")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400AFC9")]
	[FieldOffset(Offset = "0x20")]
	public string season_name;

	[Token(Token = "0x400AFCA")]
	[FieldOffset(Offset = "0x24")]
	public uint starting_ranking_point;

	[Token(Token = "0x400AFCB")]
	[FieldOffset(Offset = "0x28")]
	public string map_id;

	[Token(Token = "0x400AFCC")]
	[FieldOffset(Offset = "0x2C")]
	public uint season_award_id;

	[Token(Token = "0x400AFCD")]
	[FieldOffset(Offset = "0x30")]
	public uint season_award_rank;

	[Token(Token = "0x400AFCE")]
	[FieldOffset(Offset = "0x34")]
	public string season_award_url;

	[Token(Token = "0x400AFCF")]
	[FieldOffset(Offset = "0x38")]
	public string season_bg_url;

	[Token(Token = "0x400AFD0")]
	[FieldOffset(Offset = "0x3C")]
	public uint season_peak_award_id;

	[Token(Token = "0x400AFD1")]
	[FieldOffset(Offset = "0x40")]
	public uint season_peak_award_rank;

	[Token(Token = "0x400AFD2")]
	[FieldOffset(Offset = "0x48")]
	public long pre_dict_time;

	[Token(Token = "0x400AFD3")]
	[FieldOffset(Offset = "0x50")]
	public string new_season_tip;

	[Token(Token = "0x400AFD4")]
	[FieldOffset(Offset = "0x54")]
	public string season_reward_bg_url;

	[Token(Token = "0x400AFD5")]
	[FieldOffset(Offset = "0x58")]
	public uint award_sessions;

	[Token(Token = "0x400AFD6")]
	[FieldOffset(Offset = "0x5C")]
	public uint[] season_award_preview_rank;

	[Token(Token = "0x400AFD7")]
	[FieldOffset(Offset = "0x60")]
	public uint map_limit_num;

	[Token(Token = "0x6008245")]
	[Address(RVA = "0x33DF498", Offset = "0x33DF498", VA = "0x33DF498")]
	public PeriodicRankingSeasonInfoDesc()
	{
	}
}
