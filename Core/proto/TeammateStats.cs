using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001536")]
public class TeammateStats
{
	[Token(Token = "0x400922A")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400922B")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x400922C")]
	[FieldOffset(Offset = "0x14")]
	public uint kills;

	[Token(Token = "0x400922D")]
	[FieldOffset(Offset = "0x18")]
	public uint avatar_id;

	[Token(Token = "0x400922E")]
	[FieldOffset(Offset = "0x1C")]
	public uint banner_id;

	[Token(Token = "0x400922F")]
	[FieldOffset(Offset = "0x20")]
	public uint head_pic;

	[Token(Token = "0x4009230")]
	[FieldOffset(Offset = "0x24")]
	public string clan_name;

	[Token(Token = "0x4009231")]
	[FieldOffset(Offset = "0x28")]
	public uint season_rank;

	[Token(Token = "0x4009232")]
	[FieldOffset(Offset = "0x2C")]
	public uint level;

	[Token(Token = "0x4009233")]
	[FieldOffset(Offset = "0x30")]
	public bool has_elite_pass;

	[Token(Token = "0x4009234")]
	[FieldOffset(Offset = "0x34")]
	public uint badge_id;

	[Token(Token = "0x4009235")]
	[FieldOffset(Offset = "0x38")]
	public uint badge_cnt;

	[Token(Token = "0x4009236")]
	[FieldOffset(Offset = "0x3C")]
	public bool show_rank;

	[Token(Token = "0x4009237")]
	[FieldOffset(Offset = "0x40")]
	public string lock_region;

	[Token(Token = "0x4009238")]
	[FieldOffset(Offset = "0x44")]
	public uint pve_damage;

	[Token(Token = "0x4009239")]
	[FieldOffset(Offset = "0x48")]
	public uint pve_primary_weapon_skin;

	[Token(Token = "0x400923A")]
	[FieldOffset(Offset = "0x4C")]
	public uint role;

	[Token(Token = "0x400923B")]
	[FieldOffset(Offset = "0x50")]
	public uint damage;

	[Token(Token = "0x400923C")]
	[FieldOffset(Offset = "0x54")]
	public uint deads;

	[Token(Token = "0x400923D")]
	[FieldOffset(Offset = "0x58")]
	public uint score;

	[Token(Token = "0x400923E")]
	[FieldOffset(Offset = "0x5C")]
	public uint assists;

	[Token(Token = "0x400923F")]
	[FieldOffset(Offset = "0x60")]
	public uint rank;

	[Token(Token = "0x4009240")]
	[FieldOffset(Offset = "0x64")]
	public uint settle_bomb;

	[Token(Token = "0x4009241")]
	[FieldOffset(Offset = "0x68")]
	public uint remove_bomb;

	[Token(Token = "0x4009242")]
	[FieldOffset(Offset = "0x6C")]
	public uint[] big_head_level_and_count;

	[Token(Token = "0x4009243")]
	[FieldOffset(Offset = "0x70")]
	public uint token_pick_count;

	[Token(Token = "0x4009244")]
	[FieldOffset(Offset = "0x74")]
	public uint escort_time;

	[Token(Token = "0x4009245")]
	[FieldOffset(Offset = "0x78")]
	public uint on_zone_time;

	[Token(Token = "0x4009246")]
	[FieldOffset(Offset = "0x7C")]
	public uint buff_trigger_count;

	[Token(Token = "0x4009247")]
	[FieldOffset(Offset = "0x80")]
	public uint pin_id;

	[Token(Token = "0x4009248")]
	[FieldOffset(Offset = "0x84")]
	public uint team_score;

	[Token(Token = "0x4009249")]
	[FieldOffset(Offset = "0x88")]
	public uint headshot_kills;

	[Token(Token = "0x400924A")]
	[FieldOffset(Offset = "0x8C")]
	public uint hp_used_count;

	[Token(Token = "0x400924B")]
	[FieldOffset(Offset = "0x90")]
	public uint survival_time;

	[Token(Token = "0x400924C")]
	[FieldOffset(Offset = "0x94")]
	public string group_name;

	[Token(Token = "0x400924D")]
	[FieldOffset(Offset = "0x98")]
	public uint group_icon;

	[Token(Token = "0x400924E")]
	[FieldOffset(Offset = "0x9C")]
	public uint[] battle_tags;

	[Token(Token = "0x400924F")]
	[FieldOffset(Offset = "0xA0")]
	public uint liked;

	[Token(Token = "0x4009250")]
	[FieldOffset(Offset = "0xA4")]
	public uint relation_mask;

	[Token(Token = "0x4009251")]
	[FieldOffset(Offset = "0xA8")]
	public uint finish_chess_time;

	[Token(Token = "0x4009252")]
	[FieldOffset(Offset = "0xAC")]
	public uint finish_chess_num;

	[Token(Token = "0x4009253")]
	[FieldOffset(Offset = "0xB0")]
	public uint total_chess_num;

	[Token(Token = "0x4009254")]
	[FieldOffset(Offset = "0xB4")]
	public uint peak_rank_pos;

	[Token(Token = "0x4009255")]
	[FieldOffset(Offset = "0xB8")]
	public uint killed_npc_num;

	[Token(Token = "0x4009256")]
	[FieldOffset(Offset = "0xBC")]
	public uint knockdown_count;

	[Token(Token = "0x4009257")]
	[FieldOffset(Offset = "0xC0")]
	public uint healing_amount;

	[Token(Token = "0x4009258")]
	[FieldOffset(Offset = "0xC4")]
	public uint revival_count;

	[Token(Token = "0x4009259")]
	[FieldOffset(Offset = "0xC8")]
	public uint resurrect_teammate_count;

	[Token(Token = "0x400925A")]
	[FieldOffset(Offset = "0xCC")]
	public uint ingame_level;

	[Token(Token = "0x400925B")]
	[FieldOffset(Offset = "0xD0")]
	public uint infection_score;

	[Token(Token = "0x400925C")]
	[FieldOffset(Offset = "0xD4")]
	public uint avatar_transform;

	[Token(Token = "0x400925D")]
	[FieldOffset(Offset = "0xD8")]
	public uint kill_streak_count;

	[Token(Token = "0x6007B7E")]
	[Address(RVA = "0x33E3744", Offset = "0x33E3744", VA = "0x33E3744")]
	public TeammateStats()
	{
	}
}
