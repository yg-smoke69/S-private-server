using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF4")]
public class ChampionshipSettingDesc
{
	[Token(Token = "0x400A965")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A966")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x400A967")]
	[FieldOffset(Offset = "0x10")]
	public string trial_match_name;

	[Token(Token = "0x400A968")]
	[FieldOffset(Offset = "0x14")]
	public uint trial_match_num;

	[Token(Token = "0x400A969")]
	[FieldOffset(Offset = "0x18")]
	public uint trial_match_choose_num;

	[Token(Token = "0x400A96A")]
	[FieldOffset(Offset = "0x1C")]
	public uint final_match_choose_num;

	[Token(Token = "0x400A96B")]
	[FieldOffset(Offset = "0x20")]
	public uint min_match_num;

	[Token(Token = "0x400A96C")]
	[FieldOffset(Offset = "0x24")]
	public uint limited_item_type;

	[Token(Token = "0x400A96D")]
	[FieldOffset(Offset = "0x28")]
	public uint limited_item_id;

	[Token(Token = "0x400A96E")]
	[FieldOffset(Offset = "0x2C")]
	public uint limited_item_num;

	[Token(Token = "0x400A96F")]
	[FieldOffset(Offset = "0x30")]
	public uint seniority_list;

	[Token(Token = "0x400A970")]
	[FieldOffset(Offset = "0x34")]
	public string clan_icon_id;

	[Token(Token = "0x400A971")]
	[FieldOffset(Offset = "0x38")]
	public bool is_animation_open;

	[Token(Token = "0x400A972")]
	[FieldOffset(Offset = "0x3C")]
	public string login_animation_resource;

	[Token(Token = "0x400A973")]
	[FieldOffset(Offset = "0x40")]
	public string lobby_resource;

	[Token(Token = "0x400A974")]
	[FieldOffset(Offset = "0x44")]
	public string homepage_resource;

	[Token(Token = "0x400A975")]
	[FieldOffset(Offset = "0x48")]
	public string mode_name;

	[Token(Token = "0x400A976")]
	[FieldOffset(Offset = "0x4C")]
	public bool is_result_ani_open;

	[Token(Token = "0x400A977")]
	[FieldOffset(Offset = "0x4D")]
	public bool is_notice_open;

	[Token(Token = "0x400A978")]
	[FieldOffset(Offset = "0x50")]
	public string notice_cdn1;

	[Token(Token = "0x400A979")]
	[FieldOffset(Offset = "0x54")]
	public string notice_cdn2;

	[Token(Token = "0x400A97A")]
	[FieldOffset(Offset = "0x58")]
	public string notice_cdn3;

	[Token(Token = "0x400A97B")]
	[FieldOffset(Offset = "0x5C")]
	public string notice_cdn4;

	[Token(Token = "0x400A97C")]
	[FieldOffset(Offset = "0x60")]
	public bool senior_team_only;

	[Token(Token = "0x400A97D")]
	[FieldOffset(Offset = "0x64")]
	public uint team_scale_type;

	[Token(Token = "0x400A97E")]
	[FieldOffset(Offset = "0x68")]
	public uint game_mode;

	[Token(Token = "0x400A97F")]
	[FieldOffset(Offset = "0x6C")]
	public bool disable_weapon_skin;

	[Token(Token = "0x400A980")]
	[FieldOffset(Offset = "0x6D")]
	public bool is_replay_on;

	[Token(Token = "0x400A981")]
	[FieldOffset(Offset = "0x70")]
	public string preview_resource;

	[Token(Token = "0x400A982")]
	[FieldOffset(Offset = "0x74")]
	public uint go_pos1;

	[Token(Token = "0x400A983")]
	[FieldOffset(Offset = "0x78")]
	public uint sub_pos1;

	[Token(Token = "0x400A984")]
	[FieldOffset(Offset = "0x7C")]
	public uint go_pos2;

	[Token(Token = "0x400A985")]
	[FieldOffset(Offset = "0x80")]
	public uint sub_pos2;

	[Token(Token = "0x400A986")]
	[FieldOffset(Offset = "0x84")]
	public uint go_pos3;

	[Token(Token = "0x400A987")]
	[FieldOffset(Offset = "0x88")]
	public uint sub_pos3;

	[Token(Token = "0x400A988")]
	[FieldOffset(Offset = "0x8C")]
	public uint go_pos4;

	[Token(Token = "0x400A989")]
	[FieldOffset(Offset = "0x90")]
	public uint sub_pos4;

	[Token(Token = "0x400A98A")]
	[FieldOffset(Offset = "0x94")]
	public string notice_cdn5;

	[Token(Token = "0x400A98B")]
	[FieldOffset(Offset = "0x98")]
	public uint go_pos5;

	[Token(Token = "0x400A98C")]
	[FieldOffset(Offset = "0x9C")]
	public uint sub_pos5;

	[Token(Token = "0x400A98D")]
	[FieldOffset(Offset = "0xA0")]
	public uint leaderboard_local_size;

	[Token(Token = "0x400A98E")]
	[FieldOffset(Offset = "0xA4")]
	public string language;

	[Token(Token = "0x400A98F")]
	[FieldOffset(Offset = "0xA8")]
	public string background_resource;

	[Token(Token = "0x600814F")]
	[Address(RVA = "0x309B080", Offset = "0x309B080", VA = "0x309B080")]
	public ChampionshipSettingDesc()
	{
	}
}
