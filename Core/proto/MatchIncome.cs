using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001521")]
public class MatchIncome
{
	[Token(Token = "0x40090CC")]
	[FieldOffset(Offset = "0x8")]
	public uint exp;

	[Token(Token = "0x40090CD")]
	[FieldOffset(Offset = "0xC")]
	public uint coins;

	[Token(Token = "0x40090CE")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_points;

	[Token(Token = "0x40090CF")]
	[FieldOffset(Offset = "0x14")]
	public uint kill_points;

	[Token(Token = "0x40090D0")]
	[FieldOffset(Offset = "0x18")]
	public uint damage_points;

	[Token(Token = "0x40090D1")]
	[FieldOffset(Offset = "0x1C")]
	public uint level_before;

	[Token(Token = "0x40090D2")]
	[FieldOffset(Offset = "0x20")]
	public uint level_after;

	[Token(Token = "0x40090D3")]
	[FieldOffset(Offset = "0x24")]
	public uint exp_before;

	[Token(Token = "0x40090D4")]
	[FieldOffset(Offset = "0x28")]
	public uint exp_after;

	[Token(Token = "0x40090D5")]
	[FieldOffset(Offset = "0x2C")]
	public uint coins_before;

	[Token(Token = "0x40090D6")]
	[FieldOffset(Offset = "0x30")]
	public uint coins_after;

	[Token(Token = "0x40090D7")]
	[FieldOffset(Offset = "0x34")]
	public uint coins_gained_today;

	[Token(Token = "0x40090D8")]
	[FieldOffset(Offset = "0x38")]
	public uint coins_gain_limit;

	[Token(Token = "0x40090D9")]
	[FieldOffset(Offset = "0x3C")]
	public int mmr_delta;

	[Token(Token = "0x40090DA")]
	[FieldOffset(Offset = "0x40")]
	public int ranking_points_delta;

	[Token(Token = "0x40090DB")]
	[FieldOffset(Offset = "0x44")]
	public int ranking_points_before;

	[Token(Token = "0x40090DC")]
	[FieldOffset(Offset = "0x48")]
	public int ranking_points_after;

	[Token(Token = "0x40090DD")]
	[FieldOffset(Offset = "0x4C")]
	public AwardData level_rewards;

	[Token(Token = "0x40090DE")]
	[FieldOffset(Offset = "0x50")]
	public uint daily_reward_exp;

	[Token(Token = "0x40090DF")]
	[FieldOffset(Offset = "0x54")]
	public uint daily_reward_coins;

	[Token(Token = "0x40090E0")]
	[FieldOffset(Offset = "0x58")]
	public uint rank_before;

	[Token(Token = "0x40090E1")]
	[FieldOffset(Offset = "0x5C")]
	public uint rank_after;

	[Token(Token = "0x40090E2")]
	[FieldOffset(Offset = "0x60")]
	public bool has_rank_upgrade_rewards;

	[Token(Token = "0x40090E3")]
	[FieldOffset(Offset = "0x61")]
	public bool is_rank;

	[Token(Token = "0x40090E4")]
	[FieldOffset(Offset = "0x62")]
	public bool is_logout_match;

	[Token(Token = "0x40090E5")]
	[FieldOffset(Offset = "0x64")]
	public uint honor_point_delta;

	[Token(Token = "0x40090E6")]
	[FieldOffset(Offset = "0x68")]
	public List<GameDrop> game_drops;

	[Token(Token = "0x40090E7")]
	[FieldOffset(Offset = "0x6C")]
	public bool is_loss_prevented;

	[Token(Token = "0x40090E8")]
	[FieldOffset(Offset = "0x70")]
	public uint coin_limit_event_bonus;

	[Token(Token = "0x40090E9")]
	[FieldOffset(Offset = "0x74")]
	public uint debris_limit_event_bonus;

	[Token(Token = "0x40090EA")]
	[FieldOffset(Offset = "0x78")]
	public RankingPointsDetail ranking_points_detail;

	[Token(Token = "0x40090EB")]
	[FieldOffset(Offset = "0x7C")]
	public uint race_point_delta;

	[Token(Token = "0x40090EC")]
	[FieldOffset(Offset = "0x80")]
	public uint ranking_token_id;

	[Token(Token = "0x40090ED")]
	[FieldOffset(Offset = "0x84")]
	public uint ranking_token_delta;

	[Token(Token = "0x40090EE")]
	[FieldOffset(Offset = "0x88")]
	public uint ranking_token_num;

	[Token(Token = "0x40090EF")]
	[FieldOffset(Offset = "0x8C")]
	public CoinsDetail coins_detail;

	[Token(Token = "0x40090F0")]
	[FieldOffset(Offset = "0x90")]
	public ExpDetail exp_detail;

	[Token(Token = "0x40090F1")]
	[FieldOffset(Offset = "0x94")]
	public PetExpDetail pet_exp_detail;

	[Token(Token = "0x40090F2")]
	[FieldOffset(Offset = "0x98")]
	public List<DebrisDetail> debris_detail;

	[Token(Token = "0x40090F3")]
	[FieldOffset(Offset = "0x9C")]
	public List<IngameItem> ingame_items;

	[Token(Token = "0x40090F4")]
	[FieldOffset(Offset = "0xA0")]
	public uint ranking_token_max;

	[Token(Token = "0x40090F5")]
	[FieldOffset(Offset = "0xA4")]
	public bool is_double_ranking_point_activity;

	[Token(Token = "0x40090F6")]
	[FieldOffset(Offset = "0xA5")]
	public bool is_double_token_activity;

	[Token(Token = "0x40090F7")]
	[FieldOffset(Offset = "0xA8")]
	public uint double_ranking_point_card_id;

	[Token(Token = "0x40090F8")]
	[FieldOffset(Offset = "0xAC")]
	public uint chip_num;

	[Token(Token = "0x40090F9")]
	[FieldOffset(Offset = "0xB0")]
	public uint no_deduct_card_id;

	[Token(Token = "0x40090FA")]
	[FieldOffset(Offset = "0xB4")]
	public bool is_championship;

	[Token(Token = "0x40090FB")]
	[FieldOffset(Offset = "0xB8")]
	public uint[] linkage_award_ids;

	[Token(Token = "0x40090FC")]
	[FieldOffset(Offset = "0xBC")]
	public bool is_cs_rank;

	[Token(Token = "0x40090FD")]
	[FieldOffset(Offset = "0xBD")]
	public bool is_cs_rank_protect;

	[Token(Token = "0x40090FE")]
	[FieldOffset(Offset = "0xBE")]
	public bool is_cs_streak_bonus;

	[Token(Token = "0x40090FF")]
	[FieldOffset(Offset = "0xC0")]
	public float random_map_rp_param;

	[Token(Token = "0x4009100")]
	[FieldOffset(Offset = "0xC4")]
	public uint pre_cs_star_protect_points;

	[Token(Token = "0x4009101")]
	[FieldOffset(Offset = "0xC8")]
	public uint cur_cs_star_protect_points;

	[Token(Token = "0x4009102")]
	[FieldOffset(Offset = "0xCC")]
	public bool is_cs_star_protect;

	[Token(Token = "0x4009103")]
	[FieldOffset(Offset = "0xD0")]
	public uint pre_br_heroic_count;

	[Token(Token = "0x4009104")]
	[FieldOffset(Offset = "0xD4")]
	public uint after_br_heroic_count;

	[Token(Token = "0x4009105")]
	[FieldOffset(Offset = "0xD8")]
	public uint pre_cs_heroic_count;

	[Token(Token = "0x4009106")]
	[FieldOffset(Offset = "0xDC")]
	public uint after_cs_heroic_count;

	[Token(Token = "0x4009107")]
	[FieldOffset(Offset = "0xE0")]
	public bool is_periodic_rank;

	[Token(Token = "0x4009108")]
	[FieldOffset(Offset = "0xE1")]
	public bool is_periodic_rank_protect;

	[Token(Token = "0x4009109")]
	[FieldOffset(Offset = "0xE2")]
	public bool is_periodic_streak_bonus;

	[Token(Token = "0x400910A")]
	[FieldOffset(Offset = "0xE4")]
	public uint pre_periodic_ranking_protect_points;

	[Token(Token = "0x400910B")]
	[FieldOffset(Offset = "0xE8")]
	public uint cur_periodic_ranking_protect_points;

	[Token(Token = "0x400910C")]
	[FieldOffset(Offset = "0xEC")]
	public bool is_periodic_ranking_protect;

	[Token(Token = "0x400910D")]
	[FieldOffset(Offset = "0xF0")]
	public DebrisBuffDetail debris_buff_detail;

	[Token(Token = "0x400910E")]
	[FieldOffset(Offset = "0xF4")]
	public bool is_anti_hack_protect;

	[Token(Token = "0x400910F")]
	[FieldOffset(Offset = "0xF8")]
	public uint cs_protect_compensation_points;

	[Token(Token = "0x4009110")]
	[FieldOffset(Offset = "0xFC")]
	public AwardData ranking_task_award;

	[Token(Token = "0x6007B6A")]
	[Address(RVA = "0x30A7A44", Offset = "0x30A7A44", VA = "0x30A7A44")]
	public MatchIncome()
	{
	}
}
