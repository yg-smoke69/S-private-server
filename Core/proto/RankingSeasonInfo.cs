using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A47")]
public class RankingSeasonInfo
{
	[Token(Token = "0x400A48F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A490")]
	[FieldOffset(Offset = "0x10")]
	public long open_time;

	[Token(Token = "0x400A491")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400A492")]
	[FieldOffset(Offset = "0x20")]
	public string season_name;

	[Token(Token = "0x400A493")]
	[FieldOffset(Offset = "0x24")]
	public uint starting_ranking_points;

	[Token(Token = "0x400A494")]
	[FieldOffset(Offset = "0x28")]
	public string map_id;

	[Token(Token = "0x400A495")]
	[FieldOffset(Offset = "0x2C")]
	public uint season_award_id;

	[Token(Token = "0x400A496")]
	[FieldOffset(Offset = "0x30")]
	public uint season_award_rank;

	[Token(Token = "0x400A497")]
	[FieldOffset(Offset = "0x34")]
	public string season_award_url;

	[Token(Token = "0x400A498")]
	[FieldOffset(Offset = "0x38")]
	public string season_bg_url;

	[Token(Token = "0x400A499")]
	[FieldOffset(Offset = "0x3C")]
	public uint season_peak_award_id;

	[Token(Token = "0x400A49A")]
	[FieldOffset(Offset = "0x40")]
	public uint season_peak_award_rank;

	[Token(Token = "0x400A49B")]
	[FieldOffset(Offset = "0x44")]
	public bool heroic_mark_switch;

	[Token(Token = "0x400A49C")]
	[FieldOffset(Offset = "0x48")]
	public string new_season_tip;

	[Token(Token = "0x400A49D")]
	[FieldOffset(Offset = "0x4C")]
	public string season_reward_bg_url;

	[Token(Token = "0x400A49E")]
	[FieldOffset(Offset = "0x50")]
	public uint award_sessions;

	[Token(Token = "0x400A49F")]
	[FieldOffset(Offset = "0x54")]
	public uint[] season_award_preview_rank;

	[Token(Token = "0x400A4A0")]
	[FieldOffset(Offset = "0x58")]
	public uint big_reward_id;

	[Token(Token = "0x400A4A1")]
	[FieldOffset(Offset = "0x5C")]
	public string season_name_url;

	[Token(Token = "0x600809F")]
	[Address(RVA = "0x33E0D08", Offset = "0x33E0D08", VA = "0x33E0D08")]
	public RankingSeasonInfo()
	{
	}
}
