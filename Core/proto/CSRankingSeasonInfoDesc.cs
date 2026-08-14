using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B20")]
public class CSRankingSeasonInfoDesc
{
	[Token(Token = "0x400AA7D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AA7E")]
	[FieldOffset(Offset = "0x10")]
	public long open_time;

	[Token(Token = "0x400AA7F")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400AA80")]
	[FieldOffset(Offset = "0x20")]
	public string season_name;

	[Token(Token = "0x400AA81")]
	[FieldOffset(Offset = "0x24")]
	public uint starting_ranking_point;

	[Token(Token = "0x400AA82")]
	[FieldOffset(Offset = "0x28")]
	public string map_id;

	[Token(Token = "0x400AA83")]
	[FieldOffset(Offset = "0x2C")]
	public uint season_award_id;

	[Token(Token = "0x400AA84")]
	[FieldOffset(Offset = "0x30")]
	public uint season_award_rank;

	[Token(Token = "0x400AA85")]
	[FieldOffset(Offset = "0x34")]
	public string season_award_url;

	[Token(Token = "0x400AA86")]
	[FieldOffset(Offset = "0x38")]
	public string season_bg_url;

	[Token(Token = "0x400AA87")]
	[FieldOffset(Offset = "0x3C")]
	public uint season_peak_award_id;

	[Token(Token = "0x400AA88")]
	[FieldOffset(Offset = "0x40")]
	public uint season_peak_award_rank;

	[Token(Token = "0x400AA89")]
	[FieldOffset(Offset = "0x44")]
	public bool heroic_mark_switch;

	[Token(Token = "0x400AA8A")]
	[FieldOffset(Offset = "0x48")]
	public string new_season_tip;

	[Token(Token = "0x400AA8B")]
	[FieldOffset(Offset = "0x4C")]
	public string season_reward_bg_url;

	[Token(Token = "0x400AA8C")]
	[FieldOffset(Offset = "0x50")]
	public uint award_sessions;

	[Token(Token = "0x400AA8D")]
	[FieldOffset(Offset = "0x54")]
	public uint[] season_award_preview_rank;

	[Token(Token = "0x400AA8E")]
	[FieldOffset(Offset = "0x58")]
	public uint big_reward_id;

	[Token(Token = "0x400AA8F")]
	[FieldOffset(Offset = "0x5C")]
	public string season_name_url;

	[Token(Token = "0x600817B")]
	[Address(RVA = "0x3098CA8", Offset = "0x3098CA8", VA = "0x3098CA8")]
	public CSRankingSeasonInfoDesc()
	{
	}
}
