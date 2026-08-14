using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001523")]
public class MatchStatsExtra
{
	[Token(Token = "0x400919F")]
	[FieldOffset(Offset = "0x8")]
	public uint walk_distance;

	[Token(Token = "0x40091A0")]
	[FieldOffset(Offset = "0xC")]
	public uint profile_avatar;

	[Token(Token = "0x40091A1")]
	[FieldOffset(Offset = "0x10")]
	public List<ItemCollect> items;

	[Token(Token = "0x40091A2")]
	[FieldOffset(Offset = "0x14")]
	public List<WeaponKill> wp_kills;

	[Token(Token = "0x40091A3")]
	[FieldOffset(Offset = "0x18")]
	public uint air_drop_count;

	[Token(Token = "0x40091A4")]
	[FieldOffset(Offset = "0x1C")]
	public uint vehicle_distance;

	[Token(Token = "0x40091A5")]
	[FieldOffset(Offset = "0x20")]
	public uint hp_used_count;

	[Token(Token = "0x40091A6")]
	[FieldOffset(Offset = "0x24")]
	public uint drive_time_seconds;

	[Token(Token = "0x40091A7")]
	[FieldOffset(Offset = "0x28")]
	public uint[] loadouts;

	[Token(Token = "0x40091A8")]
	[FieldOffset(Offset = "0x2C")]
	public uint carepackage_count;

	[Token(Token = "0x40091A9")]
	[FieldOffset(Offset = "0x30")]
	public uint treasure_count;

	[Token(Token = "0x40091AA")]
	[FieldOffset(Offset = "0x34")]
	public uint kill_swimming_count;

	[Token(Token = "0x40091AB")]
	[FieldOffset(Offset = "0x38")]
	public uint swim_distance;

	[Token(Token = "0x40091AC")]
	[FieldOffset(Offset = "0x3C")]
	public uint damage_on_strop;

	[Token(Token = "0x40091AD")]
	[FieldOffset(Offset = "0x40")]
	public List<WeaponSkinKill> wp_skin_kill;

	[Token(Token = "0x40091AE")]
	[FieldOffset(Offset = "0x44")]
	public List<WeaponSkinDamage> wp_skin_damage;

	[Token(Token = "0x40091AF")]
	[FieldOffset(Offset = "0x48")]
	public uint strop_moving_distance;

	[Token(Token = "0x40091B0")]
	[FieldOffset(Offset = "0x4C")]
	public List<WeaponDamage> wp_damage;

	[Token(Token = "0x40091B1")]
	[FieldOffset(Offset = "0x50")]
	public uint oildrum_kill;

	[Token(Token = "0x40091B2")]
	[FieldOffset(Offset = "0x54")]
	public uint vehicle_explode_kill;

	[Token(Token = "0x40091B3")]
	[FieldOffset(Offset = "0x58")]
	public List<CamouflageKill> cm_kill;

	[Token(Token = "0x40091B4")]
	[FieldOffset(Offset = "0x5C")]
	public uint use_ice_wall;

	[Token(Token = "0x40091B5")]
	[FieldOffset(Offset = "0x60")]
	public List<VehicleKill> ve_kill;

	[Token(Token = "0x40091B6")]
	[FieldOffset(Offset = "0x64")]
	public List<PoseKill> po_kill;

	[Token(Token = "0x40091B7")]
	[FieldOffset(Offset = "0x68")]
	public uint smog_oil_drum_destroy_count;

	[Token(Token = "0x40091B8")]
	[FieldOffset(Offset = "0x6C")]
	public uint UAV_kill_count;

	[Token(Token = "0x40091B9")]
	[FieldOffset(Offset = "0x70")]
	public uint[] manual_event_ids;

	[Token(Token = "0x40091BA")]
	[FieldOffset(Offset = "0x74")]
	public uint dbox_count;

	[Token(Token = "0x40091BB")]
	[FieldOffset(Offset = "0x78")]
	public uint[] emote_times;

	[Token(Token = "0x40091BC")]
	[FieldOffset(Offset = "0x7C")]
	public List<locationKill> locations_kill;

	[Token(Token = "0x40091BD")]
	[FieldOffset(Offset = "0x80")]
	public List<wpIdAndKill> wp_ids_and_kill;

	[Token(Token = "0x40091BE")]
	[FieldOffset(Offset = "0x84")]
	public bool emote_used;

	[Token(Token = "0x40091BF")]
	[FieldOffset(Offset = "0x85")]
	public bool search_air_drop;

	[Token(Token = "0x40091C0")]
	[FieldOffset(Offset = "0x88")]
	public uint vehicle_destroyed_count;

	[Token(Token = "0x40091C1")]
	[FieldOffset(Offset = "0x8C")]
	public uint paint_used_count;

	[Token(Token = "0x40091C2")]
	[FieldOffset(Offset = "0x90")]
	public uint wp_id_no_skin_count;

	[Token(Token = "0x40091C3")]
	[FieldOffset(Offset = "0x94")]
	public List<locationInfo> location_info;

	[Token(Token = "0x40091C4")]
	[FieldOffset(Offset = "0x98")]
	public List<killInfo> kill_info;

	[Token(Token = "0x40091C5")]
	[FieldOffset(Offset = "0x9C")]
	public uint oildrum_damage;

	[Token(Token = "0x40091C6")]
	[FieldOffset(Offset = "0xA0")]
	public highKillInfo high_kill_info;

	[Token(Token = "0x40091C7")]
	[FieldOffset(Offset = "0xA4")]
	public List<wpIdAndDistance> wp_id_distance;

	[Token(Token = "0x40091C8")]
	[FieldOffset(Offset = "0xA8")]
	public List<killAndDistances> kill_and_distances;

	[Token(Token = "0x40091C9")]
	[FieldOffset(Offset = "0xAC")]
	public uint limited_event_rampage;

	[Token(Token = "0x40091CA")]
	[FieldOffset(Offset = "0xB0")]
	public uint[] interacted_npc_ids;

	[Token(Token = "0x40091CB")]
	[FieldOffset(Offset = "0xB4")]
	public uint[] photo_npc_ids;

	[Token(Token = "0x40091CC")]
	[FieldOffset(Offset = "0xB8")]
	public List<ThrowingCount> throwing_count;

	[Token(Token = "0x40091CD")]
	[FieldOffset(Offset = "0xBC")]
	public ulong[] like_id_list;

	[Token(Token = "0x40091CE")]
	[FieldOffset(Offset = "0xC0")]
	public uint cs_shop_cost;

	[Token(Token = "0x40091CF")]
	[FieldOffset(Offset = "0xC4")]
	public uint[] detected_behaviors;

	[Token(Token = "0x40091D0")]
	[FieldOffset(Offset = "0xC8")]
	public List<InGameReport> reports_from_others;

	[Token(Token = "0x40091D1")]
	[FieldOffset(Offset = "0xCC")]
	public List<GameMissionInfo> game_mission_info;

	[Token(Token = "0x40091D2")]
	[FieldOffset(Offset = "0xD0")]
	public bool is_killed_by_hacker;

	[Token(Token = "0x40091D3")]
	[FieldOffset(Offset = "0xD1")]
	public bool is_in_special_pool;

	[Token(Token = "0x40091D4")]
	[FieldOffset(Offset = "0xD4")]
	public uint vending_machine_use_count;

	[Token(Token = "0x40091D5")]
	[FieldOffset(Offset = "0xD8")]
	public uint active_skill_use_count;

	[Token(Token = "0x40091D6")]
	[FieldOffset(Offset = "0xDC")]
	public string workshop_code;

	[Token(Token = "0x40091D7")]
	[FieldOffset(Offset = "0xE0")]
	public bool is_ugc;

	[Token(Token = "0x40091D8")]
	[FieldOffset(Offset = "0xE4")]
	public uint[] ugc_quit_feedback;

	[Token(Token = "0x40091D9")]
	[FieldOffset(Offset = "0xE8")]
	public uint leave_sequence;

	[Token(Token = "0x40091DA")]
	[FieldOffset(Offset = "0xEC")]
	public uint sub_mode;

	[Token(Token = "0x40091DB")]
	[FieldOffset(Offset = "0xF0")]
	public uint custom_game_mode;

	[Token(Token = "0x6007B6C")]
	[Address(RVA = "0x30A80CC", Offset = "0x30A80CC", VA = "0x30A80CC")]
	public MatchStatsExtra()
	{
	}
}
