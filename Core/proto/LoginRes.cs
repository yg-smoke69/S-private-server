using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200171F")]
public class LoginRes
{
	[Token(Token = "0x40098D0")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40098D1")]
	[FieldOffset(Offset = "0x10")]
	public uint account_type;

	[Token(Token = "0x40098D2")]
	[FieldOffset(Offset = "0x14")]
	public string region;

	[Token(Token = "0x40098D3")]
	[FieldOffset(Offset = "0x18")]
	public string nickname;

	[Token(Token = "0x40098D4")]
	[FieldOffset(Offset = "0x20")]
	public ulong create_at;

	[Token(Token = "0x40098D5")]
	[FieldOffset(Offset = "0x28")]
	public uint level;

	[Token(Token = "0x40098D6")]
	[FieldOffset(Offset = "0x2C")]
	public uint exp;

	[Token(Token = "0x40098D7")]
	[FieldOffset(Offset = "0x30")]
	public uint chat_server;

	[Token(Token = "0x40098D8")]
	[FieldOffset(Offset = "0x34")]
	public uint coins;

	[Token(Token = "0x40098D9")]
	[FieldOffset(Offset = "0x38")]
	public int gems;

	[Token(Token = "0x40098DA")]
	[FieldOffset(Offset = "0x3C")]
	public string notification_channel;

	[Token(Token = "0x40098DB")]
	[FieldOffset(Offset = "0x40")]
	public uint voice_server;

	[Token(Token = "0x40098DC")]
	[FieldOffset(Offset = "0x44")]
	public string event_log_url;

	[Token(Token = "0x40098DD")]
	[FieldOffset(Offset = "0x48")]
	public List<RegionIDMapping> region_id_mapping;

	[Token(Token = "0x40098DE")]
	[FieldOffset(Offset = "0x50")]
	public ulong clan_id;

	[Token(Token = "0x40098DF")]
	[FieldOffset(Offset = "0x58")]
	public ulong server_time;

	[Token(Token = "0x40098E0")]
	[FieldOffset(Offset = "0x60")]
	public string noti_region;

	[Token(Token = "0x40098E1")]
	[FieldOffset(Offset = "0x64")]
	public uint role;

	[Token(Token = "0x40098E2")]
	[FieldOffset(Offset = "0x68")]
	public bool is_emulator;

	[Token(Token = "0x40098E3")]
	[FieldOffset(Offset = "0x6C")]
	public uint queue_position;

	[Token(Token = "0x40098E4")]
	[FieldOffset(Offset = "0x70")]
	public uint need_waiting_secs;

	[Token(Token = "0x40098E5")]
	[FieldOffset(Offset = "0x74")]
	public bool has_elite_pass;

	[Token(Token = "0x40098E6")]
	[FieldOffset(Offset = "0x78")]
	public uint badge_id;

	[Token(Token = "0x40098E7")]
	[FieldOffset(Offset = "0x7C")]
	public uint badge_cnt;

	[Token(Token = "0x40098E8")]
	[FieldOffset(Offset = "0x80")]
	public string chat_addr;

	[Token(Token = "0x40098E9")]
	[FieldOffset(Offset = "0x84")]
	public bool show_rank;

	[Token(Token = "0x40098EA")]
	[FieldOffset(Offset = "0x88")]
	public GetBasicEPInfoRes elite_pass_basic_info;

	[Token(Token = "0x40098EB")]
	[FieldOffset(Offset = "0x8C")]
	public CSPlayerRankingInfoRes rank_info;

	[Token(Token = "0x40098EC")]
	[FieldOffset(Offset = "0x90")]
	public long return_at;

	[Token(Token = "0x40098ED")]
	[FieldOffset(Offset = "0x98")]
	public uint voice_type;

	[Token(Token = "0x40098EE")]
	[FieldOffset(Offset = "0x9C")]
	public string network_log_url;

	[Token(Token = "0x40098EF")]
	[FieldOffset(Offset = "0xA0")]
	public List<PingAddrDesc> ping_addr_desc_list;

	[Token(Token = "0x40098F0")]
	[FieldOffset(Offset = "0xA4")]
	public string ip_region;

	[Token(Token = "0x40098F1")]
	[FieldOffset(Offset = "0xA8")]
	public double ranking_peak_threshold;

	[Token(Token = "0x40098F2")]
	[FieldOffset(Offset = "0xB0")]
	public List<GameServerNodeManagerDesc> game_server_node_manager;

	[Token(Token = "0x40098F3")]
	[FieldOffset(Offset = "0xB8")]
	public ulong last_login_at;

	[Token(Token = "0x40098F4")]
	[FieldOffset(Offset = "0xC0")]
	public EAntiAddiction.AgeState age_state;

	[Token(Token = "0x40098F5")]
	[FieldOffset(Offset = "0xC4")]
	public AbTestChoices ab_test_choices;

	[Token(Token = "0x40098F6")]
	[FieldOffset(Offset = "0xC8")]
	public BlacklistInfoRes blacklist;

	[Token(Token = "0x40098F7")]
	[FieldOffset(Offset = "0xCC")]
	public string mem_value;

	[Token(Token = "0x40098F8")]
	[FieldOffset(Offset = "0xD0")]
	public uint register_variant;

	[Token(Token = "0x40098F9")]
	[FieldOffset(Offset = "0xD4")]
	public WeaponRackRes weapon_rack;

	[Token(Token = "0x40098FA")]
	[FieldOffset(Offset = "0xD8")]
	public uint vehicle_display;

	[Token(Token = "0x40098FB")]
	[FieldOffset(Offset = "0xDC")]
	public uint gloo_display;

	[Token(Token = "0x40098FC")]
	[FieldOffset(Offset = "0xE0")]
	public string clan_channel_secret;

	[Token(Token = "0x40098FD")]
	[FieldOffset(Offset = "0xE4")]
	public List<string> check_name;

	[Token(Token = "0x40098FE")]
	[FieldOffset(Offset = "0xE8")]
	public uint skyboard_display;

	[Token(Token = "0x40098FF")]
	[FieldOffset(Offset = "0xF0")]
	public long mic_muted_seconds;

	[Token(Token = "0x4009900")]
	[FieldOffset(Offset = "0xF8")]
	public bool is_optional_item_ab_test;

	[Token(Token = "0x4009901")]
	[FieldOffset(Offset = "0xFC")]
	public string voice_server_url;

	[Token(Token = "0x4009902")]
	[FieldOffset(Offset = "0x100")]
	public ReportGGPInfo report_ggp_info;

	[Token(Token = "0x6007D79")]
	[Address(RVA = "0x30A6C14", Offset = "0x30A6C14", VA = "0x30A6C14")]
	public LoginRes()
	{
	}
}
