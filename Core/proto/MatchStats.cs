using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001522")]
public class MatchStats
{
	[Token(Token = "0x4009111")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009112")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x4009113")]
	[FieldOffset(Offset = "0x18")]
	public uint survival_time;

	[Token(Token = "0x4009114")]
	[FieldOffset(Offset = "0x1C")]
	public uint rank;

	[Token(Token = "0x4009115")]
	[FieldOffset(Offset = "0x20")]
	public uint kills;

	[Token(Token = "0x4009116")]
	[FieldOffset(Offset = "0x24")]
	public uint damage;

	[Token(Token = "0x4009117")]
	[FieldOffset(Offset = "0x28")]
	public uint moving_distance;

	[Token(Token = "0x4009118")]
	[FieldOffset(Offset = "0x2C")]
	public uint revival_count;

	[Token(Token = "0x4009119")]
	[FieldOffset(Offset = "0x30")]
	public uint vehicle_kills;

	[Token(Token = "0x400911A")]
	[FieldOffset(Offset = "0x34")]
	public uint headshot_count;

	[Token(Token = "0x400911B")]
	[FieldOffset(Offset = "0x38")]
	public uint headshot_kills;

	[Token(Token = "0x400911C")]
	[FieldOffset(Offset = "0x3C")]
	public uint knockdown_count;

	[Token(Token = "0x400911D")]
	[FieldOffset(Offset = "0x40")]
	public uint pickup_count;

	[Token(Token = "0x400911E")]
	[FieldOffset(Offset = "0x44")]
	public uint assists;

	[Token(Token = "0x400911F")]
	[FieldOffset(Offset = "0x48")]
	public bool is_survive;

	[Token(Token = "0x4009120")]
	[FieldOffset(Offset = "0x4C")]
	public uint out_index;

	[Token(Token = "0x4009121")]
	[FieldOffset(Offset = "0x50")]
	public int ranking_points;

	[Token(Token = "0x4009122")]
	[FieldOffset(Offset = "0x54")]
	public MatchPlayer killer;

	[Token(Token = "0x4009123")]
	[FieldOffset(Offset = "0x58")]
	public List<MatchPlayer> killed_players;

	[Token(Token = "0x4009124")]
	[FieldOffset(Offset = "0x5C")]
	public uint down_count;

	[Token(Token = "0x4009125")]
	[FieldOffset(Offset = "0x60")]
	public uint[] achievements;

	[Token(Token = "0x4009126")]
	[FieldOffset(Offset = "0x64")]
	public uint kill_bots;

	[Token(Token = "0x4009127")]
	[FieldOffset(Offset = "0x68")]
	public bool enable_achievements;

	[Token(Token = "0x4009128")]
	[FieldOffset(Offset = "0x6C")]
	public uint avatar_id;

	[Token(Token = "0x4009129")]
	[FieldOffset(Offset = "0x70")]
	public List<TeammateStats> teammates;

	[Token(Token = "0x400912A")]
	[FieldOffset(Offset = "0x74")]
	public int avg_ranking_points;

	[Token(Token = "0x400912B")]
	[FieldOffset(Offset = "0x78")]
	public uint fratricide_damage;

	[Token(Token = "0x400912C")]
	[FieldOffset(Offset = "0x7C")]
	public uint direct_kills;

	[Token(Token = "0x400912D")]
	[FieldOffset(Offset = "0x80")]
	public uint group_mode;

	[Token(Token = "0x400912E")]
	[FieldOffset(Offset = "0x84")]
	public uint match_mode;

	[Token(Token = "0x400912F")]
	[FieldOffset(Offset = "0x88")]
	public uint player_count;

	[Token(Token = "0x4009130")]
	[FieldOffset(Offset = "0x8C")]
	public uint banner_id;

	[Token(Token = "0x4009131")]
	[FieldOffset(Offset = "0x90")]
	public uint head_pic;

	[Token(Token = "0x4009132")]
	[FieldOffset(Offset = "0x94")]
	public string clan_name;

	[Token(Token = "0x4009133")]
	[FieldOffset(Offset = "0x98")]
	public uint level;

	[Token(Token = "0x4009134")]
	[FieldOffset(Offset = "0x9C")]
	public uint season_rank;

	[Token(Token = "0x4009135")]
	[FieldOffset(Offset = "0xA0")]
	public uint game_mode;

	[Token(Token = "0x4009136")]
	[FieldOffset(Offset = "0xA4")]
	public uint map_id;

	[Token(Token = "0x4009137")]
	[FieldOffset(Offset = "0xA8")]
	public bool has_elite_pass;

	[Token(Token = "0x4009138")]
	[FieldOffset(Offset = "0xAC")]
	public uint badge_id;

	[Token(Token = "0x4009139")]
	[FieldOffset(Offset = "0xB0")]
	public uint badge_cnt;

	[Token(Token = "0x400913A")]
	[FieldOffset(Offset = "0xB4")]
	public uint[] clothes_id;

	[Token(Token = "0x400913B")]
	[FieldOffset(Offset = "0xB8")]
	public uint ep_goldlimit_bonus;

	[Token(Token = "0x400913C")]
	[FieldOffset(Offset = "0xBC")]
	public uint liked;

	[Token(Token = "0x400913D")]
	[FieldOffset(Offset = "0xC0")]
	public uint real_player_rank;

	[Token(Token = "0x400913E")]
	[FieldOffset(Offset = "0xC4")]
	public uint real_player_count;

	[Token(Token = "0x400913F")]
	[FieldOffset(Offset = "0xC8")]
	public bool show_rank;

	[Token(Token = "0x4009140")]
	[FieldOffset(Offset = "0xCC")]
	public List<RedEnvelope> use_red_envelope;

	[Token(Token = "0x4009141")]
	[FieldOffset(Offset = "0xD0")]
	public List<ReceivedRedEnvelope> received_red_envelope;

	[Token(Token = "0x4009142")]
	[FieldOffset(Offset = "0xD4")]
	public uint pet_id;

	[Token(Token = "0x4009143")]
	[FieldOffset(Offset = "0xD8")]
	public string pet_name;

	[Token(Token = "0x4009144")]
	[FieldOffset(Offset = "0xDC")]
	public List<Item> ingame_items;

	[Token(Token = "0x4009145")]
	[FieldOffset(Offset = "0xE0")]
	public uint difficulty;

	[Token(Token = "0x4009146")]
	[FieldOffset(Offset = "0xE4")]
	public uint ai_type;

	[Token(Token = "0x4009147")]
	[FieldOffset(Offset = "0xE8")]
	public uint pve_primary_weapon_skin;

	[Token(Token = "0x4009148")]
	[FieldOffset(Offset = "0xEC")]
	public uint pet_skin_id;

	[Token(Token = "0x4009149")]
	[FieldOffset(Offset = "0xF0")]
	public ReviveTokenUsed used_revive_tokens;

	[Token(Token = "0x400914A")]
	[FieldOffset(Offset = "0xF4")]
	public uint hack_reason;

	[Token(Token = "0x400914B")]
	[FieldOffset(Offset = "0xF8")]
	public bool sit_on_throne;

	[Token(Token = "0x400914C")]
	[FieldOffset(Offset = "0xFC")]
	public EStats.WinnerTakesAllCurrencyType wta_curr_type;

	[Token(Token = "0x400914D")]
	[FieldOffset(Offset = "0x100")]
	public WarmGameInfo warm_game;

	[Token(Token = "0x400914E")]
	[FieldOffset(Offset = "0x104")]
	public uint role;

	[Token(Token = "0x400914F")]
	[FieldOffset(Offset = "0x108")]
	public uint championship_type;

	[Token(Token = "0x4009150")]
	[FieldOffset(Offset = "0x10C")]
	public LinkageInfo linkage_info;

	[Token(Token = "0x4009151")]
	[FieldOffset(Offset = "0x110")]
	public uint revenge_success_times;

	[Token(Token = "0x4009152")]
	[FieldOffset(Offset = "0x114")]
	public uint game_round;

	[Token(Token = "0x4009153")]
	[FieldOffset(Offset = "0x118")]
	public uint[] teams_game_point;

	[Token(Token = "0x4009154")]
	[FieldOffset(Offset = "0x11C")]
	public List<TeammateStats> opponents;

	[Token(Token = "0x4009155")]
	[FieldOffset(Offset = "0x120")]
	public EAuth.ClientUsingVersion using_version;

	[Token(Token = "0x4009156")]
	[FieldOffset(Offset = "0x124")]
	public uint real_damage;

	[Token(Token = "0x4009157")]
	[FieldOffset(Offset = "0x128")]
	public uint settle_bomb;

	[Token(Token = "0x4009158")]
	[FieldOffset(Offset = "0x12C")]
	public uint remove_bomb;

	[Token(Token = "0x4009159")]
	[FieldOffset(Offset = "0x130")]
	public uint deaths;

	[Token(Token = "0x400915A")]
	[FieldOffset(Offset = "0x134")]
	public uint mvp_count;

	[Token(Token = "0x400915B")]
	[FieldOffset(Offset = "0x138")]
	public uint double_kills;

	[Token(Token = "0x400915C")]
	[FieldOffset(Offset = "0x13C")]
	public uint triple_kills;

	[Token(Token = "0x400915D")]
	[FieldOffset(Offset = "0x140")]
	public uint four_kills;

	[Token(Token = "0x400915E")]
	[FieldOffset(Offset = "0x144")]
	public uint newbie_choice;

	[Token(Token = "0x400915F")]
	[FieldOffset(Offset = "0x148")]
	public uint pin_id;

	[Token(Token = "0x4009160")]
	[FieldOffset(Offset = "0x14C")]
	public uint cs_ranking_hang_ups;

	[Token(Token = "0x4009161")]
	[FieldOffset(Offset = "0x150")]
	public uint random_map_cnt;

	[Token(Token = "0x4009162")]
	[FieldOffset(Offset = "0x154")]
	public int cs_star_protect_points;

	[Token(Token = "0x4009163")]
	[FieldOffset(Offset = "0x158")]
	public uint hacker_tag;

	[Token(Token = "0x4009164")]
	[FieldOffset(Offset = "0x15C")]
	public uint banned_duration;

	[Token(Token = "0x4009165")]
	[FieldOffset(Offset = "0x160")]
	public bool online_cs_rank_settle;

	[Token(Token = "0x4009166")]
	[FieldOffset(Offset = "0x164")]
	public uint battle_time;

	[Token(Token = "0x4009167")]
	[FieldOffset(Offset = "0x168")]
	public uint society_time;

	[Token(Token = "0x4009168")]
	[FieldOffset(Offset = "0x16C")]
	public bool is_cs_rank_draw;

	[Token(Token = "0x4009169")]
	[FieldOffset(Offset = "0x170")]
	public uint num_kill_smaller_than_1m;

	[Token(Token = "0x400916A")]
	[FieldOffset(Offset = "0x174")]
	public uint num_kill_smaller_than_2m;

	[Token(Token = "0x400916B")]
	[FieldOffset(Offset = "0x178")]
	public uint num_kill_greater_than_10m;

	[Token(Token = "0x400916C")]
	[FieldOffset(Offset = "0x17C")]
	public uint num_kill_greater_than_50m;

	[Token(Token = "0x400916D")]
	[FieldOffset(Offset = "0x180")]
	public uint num_kill_greater_than_100m;

	[Token(Token = "0x400916E")]
	[FieldOffset(Offset = "0x184")]
	public uint num_kill_greater_than_500m;

	[Token(Token = "0x400916F")]
	[FieldOffset(Offset = "0x188")]
	public uint num_different_weapon_kill;

	[Token(Token = "0x4009170")]
	[FieldOffset(Offset = "0x18C")]
	public uint num_kill_better_rank_player;

	[Token(Token = "0x4009171")]
	[FieldOffset(Offset = "0x190")]
	public uint avg_kill_rest_hp;

	[Token(Token = "0x4009172")]
	[FieldOffset(Offset = "0x194")]
	public uint total_shot;

	[Token(Token = "0x4009173")]
	[FieldOffset(Offset = "0x198")]
	public bool has_swum;

	[Token(Token = "0x4009174")]
	[FieldOffset(Offset = "0x19C")]
	public uint grenade_use;

	[Token(Token = "0x4009175")]
	[FieldOffset(Offset = "0x1A0")]
	public uint kill_swimming_count;

	[Token(Token = "0x4009176")]
	[FieldOffset(Offset = "0x1A4")]
	public uint medkit_use;

	[Token(Token = "0x4009177")]
	[FieldOffset(Offset = "0x1A8")]
	public uint mushroom_recovery;

	[Token(Token = "0x4009178")]
	[FieldOffset(Offset = "0x1AC")]
	public uint mushroom_use;

	[Token(Token = "0x4009179")]
	[FieldOffset(Offset = "0x1B0")]
	public uint ob_count;

	[Token(Token = "0x400917A")]
	[FieldOffset(Offset = "0x1B4")]
	public uint offline_seconds;

	[Token(Token = "0x400917B")]
	[FieldOffset(Offset = "0x1B8")]
	public uint offline_times;

	[Token(Token = "0x400917C")]
	[FieldOffset(Offset = "0x1BC")]
	public uint vehicle_time;

	[Token(Token = "0x400917D")]
	[FieldOffset(Offset = "0x1C0")]
	public uint strop_use_count;

	[Token(Token = "0x400917E")]
	[FieldOffset(Offset = "0x1C4")]
	public float aim_rot_speed;

	[Token(Token = "0x400917F")]
	[FieldOffset(Offset = "0x1C8")]
	public float auto_aim_count;

	[Token(Token = "0x4009180")]
	[FieldOffset(Offset = "0x1CC")]
	public GainedTrainingToken gained_training_token;

	[Token(Token = "0x4009181")]
	[FieldOffset(Offset = "0x1D0")]
	public uint[] kills_distance;

	[Token(Token = "0x4009182")]
	[FieldOffset(Offset = "0x1D4")]
	public string group_name;

	[Token(Token = "0x4009183")]
	[FieldOffset(Offset = "0x1D8")]
	public uint group_icon;

	[Token(Token = "0x4009184")]
	[FieldOffset(Offset = "0x1DC")]
	public uint[] battle_tags;

	[Token(Token = "0x4009185")]
	[FieldOffset(Offset = "0x1E0")]
	public uint restore_count;

	[Token(Token = "0x4009186")]
	[FieldOffset(Offset = "0x1E4")]
	public uint be_restored_count;

	[Token(Token = "0x4009187")]
	[FieldOffset(Offset = "0x1E8")]
	public uint in_videozone_time;

	[Token(Token = "0x4009188")]
	[FieldOffset(Offset = "0x1EC")]
	public uint cup_type;

	[Token(Token = "0x4009189")]
	[FieldOffset(Offset = "0x1F0")]
	public WerewolvesInfo werewolves_info;

	[Token(Token = "0x400918A")]
	[FieldOffset(Offset = "0x1F4")]
	public ClanWarAccountMatchStats clan_war_account_match_stats;

	[Token(Token = "0x400918B")]
	[FieldOffset(Offset = "0x1F8")]
	public ulong pre_group_id;

	[Token(Token = "0x400918C")]
	[FieldOffset(Offset = "0x200")]
	public int periodic_ranking_protect_points;

	[Token(Token = "0x400918D")]
	[FieldOffset(Offset = "0x204")]
	public uint finish_chess_time;

	[Token(Token = "0x400918E")]
	[FieldOffset(Offset = "0x208")]
	public uint finish_chess_num;

	[Token(Token = "0x400918F")]
	[FieldOffset(Offset = "0x20C")]
	public uint total_chess_num;

	[Token(Token = "0x4009190")]
	[FieldOffset(Offset = "0x210")]
	public UGCMatchStats ugc_matchstats;

	[Token(Token = "0x4009191")]
	[FieldOffset(Offset = "0x214")]
	public uint killed_npc_num;

	[Token(Token = "0x4009192")]
	[FieldOffset(Offset = "0x218")]
	public uint damage_include_overflow;

	[Token(Token = "0x4009193")]
	[FieldOffset(Offset = "0x21C")]
	public uint hurts_include_overflow;

	[Token(Token = "0x4009194")]
	[FieldOffset(Offset = "0x220")]
	public uint win_rounds;

	[Token(Token = "0x4009195")]
	[FieldOffset(Offset = "0x224")]
	public uint healing_amount;

	[Token(Token = "0x4009196")]
	[FieldOffset(Offset = "0x228")]
	public uint resurrect_teammate_count;

	[Token(Token = "0x4009197")]
	[FieldOffset(Offset = "0x22C")]
	public List<CreditPunishInfo> credit_punish_info;

	[Token(Token = "0x4009198")]
	[FieldOffset(Offset = "0x230")]
	public uint ingame_level;

	[Token(Token = "0x4009199")]
	[FieldOffset(Offset = "0x234")]
	public MatchPlayer knockdowner;

	[Token(Token = "0x400919A")]
	[FieldOffset(Offset = "0x238")]
	public uint cs_protect_compensation_points;

	[Token(Token = "0x400919B")]
	[FieldOffset(Offset = "0x23C")]
	public uint player_proficiency_type;

	[Token(Token = "0x400919C")]
	[FieldOffset(Offset = "0x240")]
	public uint kill_ai;

	[Token(Token = "0x400919D")]
	[FieldOffset(Offset = "0x244")]
	public uint match_start_buff_id;

	[Token(Token = "0x400919E")]
	[FieldOffset(Offset = "0x248")]
	public string map_name;

	[Token(Token = "0x6007B6B")]
	[Address(RVA = "0x30A7E84", Offset = "0x30A7E84", VA = "0x30A7E84")]
	public MatchStats()
	{
	}
}
