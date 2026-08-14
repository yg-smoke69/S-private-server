using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D9E")]
public class GSPrepareInfo
{
	[Token(Token = "0x400BB71")]
	[FieldOffset(Offset = "0x8")]
	private string _003Cexport_settings_url_003Ek__BackingField;

	[Token(Token = "0x400BB72")]
	[FieldOffset(Offset = "0xC")]
	private EMatch.MatchMode _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400BB73")]
	[FieldOffset(Offset = "0x10")]
	private EMatch.GameMode _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400BB74")]
	[FieldOffset(Offset = "0x14")]
	private EMatch.GroupMode _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400BB75")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400BB76")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400BB77")]
	[FieldOffset(Offset = "0x20")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400BB78")]
	[FieldOffset(Offset = "0x28")]
	private ulong _003Croom_creator_id_003Ek__BackingField;

	[Token(Token = "0x400BB79")]
	[FieldOffset(Offset = "0x30")]
	private uint _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400BB7A")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Croom_setting_003Ek__BackingField;

	[Token(Token = "0x400BB7B")]
	[FieldOffset(Offset = "0x38")]
	private uint _003Croom_setting2_003Ek__BackingField;

	[Token(Token = "0x400BB7C")]
	[FieldOffset(Offset = "0x3C")]
	private uint _003Croom_max_mmr_003Ek__BackingField;

	[Token(Token = "0x400BB7D")]
	[FieldOffset(Offset = "0x40")]
	private uint _003Croom_min_mmr_003Ek__BackingField;

	[Token(Token = "0x400BB7E")]
	[FieldOffset(Offset = "0x44")]
	private uint _003Cmax_level_003Ek__BackingField;

	[Token(Token = "0x400BB7F")]
	[FieldOffset(Offset = "0x48")]
	private uint _003Clevel_of_min_mmr_player_003Ek__BackingField;

	[Token(Token = "0x400BB80")]
	[FieldOffset(Offset = "0x4C")]
	private bool _003Cenable_death_spectate_003Ek__BackingField;

	[Token(Token = "0x400BB81")]
	[FieldOffset(Offset = "0x4D")]
	private bool _003Cenable_group_icon_003Ek__BackingField;

	[Token(Token = "0x400BB82")]
	[FieldOffset(Offset = "0x50")]
	private uint _003Cwait_join_time_003Ek__BackingField;

	[Token(Token = "0x400BB83")]
	[FieldOffset(Offset = "0x54")]
	private uint _003Cbot_cnt_lv1_003Ek__BackingField;

	[Token(Token = "0x400BB84")]
	[FieldOffset(Offset = "0x58")]
	private uint _003Cbot_cnt_lv2_003Ek__BackingField;

	[Token(Token = "0x400BB85")]
	[FieldOffset(Offset = "0x5C")]
	private uint _003Cbot_cnt_lv3_003Ek__BackingField;

	[Token(Token = "0x400BB86")]
	[FieldOffset(Offset = "0x60")]
	private uint _003Cbot_cnt_lv4_003Ek__BackingField;

	[Token(Token = "0x400BB87")]
	[FieldOffset(Offset = "0x64")]
	private uint _003Cbot_cnt_lv5_003Ek__BackingField;

	[Token(Token = "0x400BB88")]
	[FieldOffset(Offset = "0x68")]
	private uint _003Cbot_cnt_lv6_003Ek__BackingField;

	[Token(Token = "0x400BB89")]
	[FieldOffset(Offset = "0x6C")]
	private List<AIInfo> _003Cai_infos_003Ek__BackingField;

	[Token(Token = "0x400BB8A")]
	[FieldOffset(Offset = "0x70")]
	private byte[] _003Ccs_advanced_setting_003Ek__BackingField;

	[Token(Token = "0x400BB8B")]
	[FieldOffset(Offset = "0x74")]
	private uint _003Cwerewolves_room_param_003Ek__BackingField;

	[Token(Token = "0x400BB8C")]
	[FieldOffset(Offset = "0x78")]
	private uint _003Cwerewolves_room_param2_003Ek__BackingField;

	[Token(Token = "0x400BB8D")]
	[FieldOffset(Offset = "0x7C")]
	private uint _003Cwerewolves_room_param3_003Ek__BackingField;

	[Token(Token = "0x400BB8E")]
	[FieldOffset(Offset = "0x80")]
	private CustomRoomSinglePlayerMatchStats _003Ccustom_room_match_stats_003Ek__BackingField;

	[Token(Token = "0x400BB8F")]
	[FieldOffset(Offset = "0x84")]
	private uint _003Ccasual_player_safe_zone_switch_003Ek__BackingField;

	[Token(Token = "0x400BB90")]
	[FieldOffset(Offset = "0x88")]
	private ReviveTokenCost _003Crevive_token_cost_003Ek__BackingField;

	[Token(Token = "0x400BB91")]
	[FieldOffset(Offset = "0x8C")]
	private uint _003Cbot_cnt_003Ek__BackingField;

	[Token(Token = "0x400BB92")]
	[FieldOffset(Offset = "0x90")]
	private uint _003Cai_cnt_003Ek__BackingField;

	[Token(Token = "0x400BB93")]
	[FieldOffset(Offset = "0x98")]
	private ulong _003Cmatch_id_003Ek__BackingField;

	[Token(Token = "0x400BB94")]
	[FieldOffset(Offset = "0xA0")]
	private byte[] _003Cworkshop_settings_003Ek__BackingField;

	[Token(Token = "0x400BB95")]
	[FieldOffset(Offset = "0xA4")]
	private byte[] _003Cobject_attribute_settings_003Ek__BackingField;

	[Token(Token = "0x400BB96")]
	[FieldOffset(Offset = "0xA8")]
	private List<GSPlayerPrepareInfo> _003Cgs_player_prepare_infos_003Ek__BackingField;

	[Token(Token = "0x400BB97")]
	[FieldOffset(Offset = "0xAC")]
	private string _003Cworkshop_code_003Ek__BackingField;

	[Token(Token = "0x400BB98")]
	[FieldOffset(Offset = "0xB0")]
	private string _003Cworkshop_name_003Ek__BackingField;

	[Token(Token = "0x400BB99")]
	[FieldOffset(Offset = "0xB4")]
	private byte[] _003Cmode_settings_003Ek__BackingField;

	[Token(Token = "0x17000E1D")]
	public string export_settings_url
	{
		[Token(Token = "0x6008C04")]
		[Address(RVA = "0x33E9B34", Offset = "0x33E9B34", VA = "0x33E9B34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C05")]
		[Address(RVA = "0x33E9B0C", Offset = "0x33E9B0C", VA = "0x33E9B0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E1E")]
	public EMatch.MatchMode match_mode
	{
		[Token(Token = "0x6008C06")]
		[Address(RVA = "0x33E9B3C", Offset = "0x33E9B3C", VA = "0x33E9B3C")]
		get
		{
			return default(EMatch.MatchMode);
		}
		[Token(Token = "0x6008C07")]
		[Address(RVA = "0x33E9B44", Offset = "0x33E9B44", VA = "0x33E9B44")]
		set
		{
		}
	}

	[Token(Token = "0x17000E1F")]
	public EMatch.GameMode game_mode
	{
		[Token(Token = "0x6008C08")]
		[Address(RVA = "0x33E9B4C", Offset = "0x33E9B4C", VA = "0x33E9B4C")]
		get
		{
			return default(EMatch.GameMode);
		}
		[Token(Token = "0x6008C09")]
		[Address(RVA = "0x33E9B54", Offset = "0x33E9B54", VA = "0x33E9B54")]
		set
		{
		}
	}

	[Token(Token = "0x17000E20")]
	public EMatch.GroupMode group_mode
	{
		[Token(Token = "0x6008C0A")]
		[Address(RVA = "0x33E9B5C", Offset = "0x33E9B5C", VA = "0x33E9B5C")]
		get
		{
			return default(EMatch.GroupMode);
		}
		[Token(Token = "0x6008C0B")]
		[Address(RVA = "0x33E9B64", Offset = "0x33E9B64", VA = "0x33E9B64")]
		set
		{
		}
	}

	[Token(Token = "0x17000E21")]
	public uint difficulty
	{
		[Token(Token = "0x6008C0C")]
		[Address(RVA = "0x33E9B6C", Offset = "0x33E9B6C", VA = "0x33E9B6C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C0D")]
		[Address(RVA = "0x33E9B74", Offset = "0x33E9B74", VA = "0x33E9B74")]
		set
		{
		}
	}

	[Token(Token = "0x17000E22")]
	public uint map_id
	{
		[Token(Token = "0x6008C0E")]
		[Address(RVA = "0x33E9B7C", Offset = "0x33E9B7C", VA = "0x33E9B7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C0F")]
		[Address(RVA = "0x33E9B84", Offset = "0x33E9B84", VA = "0x33E9B84")]
		set
		{
		}
	}

	[Token(Token = "0x17000E23")]
	public ulong room_id
	{
		[Token(Token = "0x6008C10")]
		[Address(RVA = "0x33E9B8C", Offset = "0x33E9B8C", VA = "0x33E9B8C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008C11")]
		[Address(RVA = "0x33E9B94", Offset = "0x33E9B94", VA = "0x33E9B94")]
		set
		{
		}
	}

	[Token(Token = "0x17000E24")]
	public ulong room_creator_id
	{
		[Token(Token = "0x6008C12")]
		[Address(RVA = "0x33E9BA4", Offset = "0x33E9BA4", VA = "0x33E9BA4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008C13")]
		[Address(RVA = "0x33E9BAC", Offset = "0x33E9BAC", VA = "0x33E9BAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000E25")]
	public uint room_type
	{
		[Token(Token = "0x6008C14")]
		[Address(RVA = "0x33E9BBC", Offset = "0x33E9BBC", VA = "0x33E9BBC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C15")]
		[Address(RVA = "0x33E9BC4", Offset = "0x33E9BC4", VA = "0x33E9BC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000E26")]
	public uint room_setting
	{
		[Token(Token = "0x6008C16")]
		[Address(RVA = "0x33E9BCC", Offset = "0x33E9BCC", VA = "0x33E9BCC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C17")]
		[Address(RVA = "0x33E9BD4", Offset = "0x33E9BD4", VA = "0x33E9BD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000E27")]
	public uint room_setting2
	{
		[Token(Token = "0x6008C18")]
		[Address(RVA = "0x33E9BDC", Offset = "0x33E9BDC", VA = "0x33E9BDC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C19")]
		[Address(RVA = "0x33E9BE4", Offset = "0x33E9BE4", VA = "0x33E9BE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000E28")]
	public uint room_max_mmr
	{
		[Token(Token = "0x6008C1A")]
		[Address(RVA = "0x33E9BEC", Offset = "0x33E9BEC", VA = "0x33E9BEC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C1B")]
		[Address(RVA = "0x33E9BF4", Offset = "0x33E9BF4", VA = "0x33E9BF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000E29")]
	public uint room_min_mmr
	{
		[Token(Token = "0x6008C1C")]
		[Address(RVA = "0x33E9BFC", Offset = "0x33E9BFC", VA = "0x33E9BFC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C1D")]
		[Address(RVA = "0x33E9C04", Offset = "0x33E9C04", VA = "0x33E9C04")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2A")]
	public uint max_level
	{
		[Token(Token = "0x6008C1E")]
		[Address(RVA = "0x33E9C0C", Offset = "0x33E9C0C", VA = "0x33E9C0C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C1F")]
		[Address(RVA = "0x33E9C14", Offset = "0x33E9C14", VA = "0x33E9C14")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2B")]
	public uint level_of_min_mmr_player
	{
		[Token(Token = "0x6008C20")]
		[Address(RVA = "0x33E9C1C", Offset = "0x33E9C1C", VA = "0x33E9C1C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C21")]
		[Address(RVA = "0x33E9C24", Offset = "0x33E9C24", VA = "0x33E9C24")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2C")]
	public bool enable_death_spectate
	{
		[Token(Token = "0x6008C22")]
		[Address(RVA = "0x33E9C2C", Offset = "0x33E9C2C", VA = "0x33E9C2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008C23")]
		[Address(RVA = "0x33E9C34", Offset = "0x33E9C34", VA = "0x33E9C34")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2D")]
	public bool enable_group_icon
	{
		[Token(Token = "0x6008C24")]
		[Address(RVA = "0x33E9C3C", Offset = "0x33E9C3C", VA = "0x33E9C3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008C25")]
		[Address(RVA = "0x33E9C44", Offset = "0x33E9C44", VA = "0x33E9C44")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2E")]
	public uint wait_join_time
	{
		[Token(Token = "0x6008C26")]
		[Address(RVA = "0x33E9C4C", Offset = "0x33E9C4C", VA = "0x33E9C4C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C27")]
		[Address(RVA = "0x33E9C54", Offset = "0x33E9C54", VA = "0x33E9C54")]
		set
		{
		}
	}

	[Token(Token = "0x17000E2F")]
	public uint bot_cnt_lv1
	{
		[Token(Token = "0x6008C28")]
		[Address(RVA = "0x33E9C5C", Offset = "0x33E9C5C", VA = "0x33E9C5C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C29")]
		[Address(RVA = "0x33E9C64", Offset = "0x33E9C64", VA = "0x33E9C64")]
		set
		{
		}
	}

	[Token(Token = "0x17000E30")]
	public uint bot_cnt_lv2
	{
		[Token(Token = "0x6008C2A")]
		[Address(RVA = "0x33E9C6C", Offset = "0x33E9C6C", VA = "0x33E9C6C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C2B")]
		[Address(RVA = "0x33E9C74", Offset = "0x33E9C74", VA = "0x33E9C74")]
		set
		{
		}
	}

	[Token(Token = "0x17000E31")]
	public uint bot_cnt_lv3
	{
		[Token(Token = "0x6008C2C")]
		[Address(RVA = "0x33E9C7C", Offset = "0x33E9C7C", VA = "0x33E9C7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C2D")]
		[Address(RVA = "0x33E9C84", Offset = "0x33E9C84", VA = "0x33E9C84")]
		set
		{
		}
	}

	[Token(Token = "0x17000E32")]
	public uint bot_cnt_lv4
	{
		[Token(Token = "0x6008C2E")]
		[Address(RVA = "0x33E9C8C", Offset = "0x33E9C8C", VA = "0x33E9C8C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C2F")]
		[Address(RVA = "0x33E9C94", Offset = "0x33E9C94", VA = "0x33E9C94")]
		set
		{
		}
	}

	[Token(Token = "0x17000E33")]
	public uint bot_cnt_lv5
	{
		[Token(Token = "0x6008C30")]
		[Address(RVA = "0x33E9C9C", Offset = "0x33E9C9C", VA = "0x33E9C9C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C31")]
		[Address(RVA = "0x33E9CA4", Offset = "0x33E9CA4", VA = "0x33E9CA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000E34")]
	public uint bot_cnt_lv6
	{
		[Token(Token = "0x6008C32")]
		[Address(RVA = "0x33E9CAC", Offset = "0x33E9CAC", VA = "0x33E9CAC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C33")]
		[Address(RVA = "0x33E9CB4", Offset = "0x33E9CB4", VA = "0x33E9CB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000E35")]
	public List<AIInfo> ai_infos
	{
		[Token(Token = "0x6008C34")]
		[Address(RVA = "0x33E9CBC", Offset = "0x33E9CBC", VA = "0x33E9CBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C35")]
		[Address(RVA = "0x33E9B14", Offset = "0x33E9B14", VA = "0x33E9B14")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E36")]
	public byte[] cs_advanced_setting
	{
		[Token(Token = "0x6008C36")]
		[Address(RVA = "0x33E9CC4", Offset = "0x33E9CC4", VA = "0x33E9CC4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C37")]
		[Address(RVA = "0x33E9CCC", Offset = "0x33E9CCC", VA = "0x33E9CCC")]
		set
		{
		}
	}

	[Token(Token = "0x17000E37")]
	public uint werewolves_room_param
	{
		[Token(Token = "0x6008C38")]
		[Address(RVA = "0x33E9CD4", Offset = "0x33E9CD4", VA = "0x33E9CD4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C39")]
		[Address(RVA = "0x33E9CDC", Offset = "0x33E9CDC", VA = "0x33E9CDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000E38")]
	public uint werewolves_room_param2
	{
		[Token(Token = "0x6008C3A")]
		[Address(RVA = "0x33E9CE4", Offset = "0x33E9CE4", VA = "0x33E9CE4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C3B")]
		[Address(RVA = "0x33E9CEC", Offset = "0x33E9CEC", VA = "0x33E9CEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000E39")]
	public uint werewolves_room_param3
	{
		[Token(Token = "0x6008C3C")]
		[Address(RVA = "0x33E9CF4", Offset = "0x33E9CF4", VA = "0x33E9CF4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C3D")]
		[Address(RVA = "0x33E9CFC", Offset = "0x33E9CFC", VA = "0x33E9CFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3A")]
	public CustomRoomSinglePlayerMatchStats custom_room_match_stats
	{
		[Token(Token = "0x6008C3E")]
		[Address(RVA = "0x33E9D04", Offset = "0x33E9D04", VA = "0x33E9D04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C3F")]
		[Address(RVA = "0x33E9D0C", Offset = "0x33E9D0C", VA = "0x33E9D0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3B")]
	public uint casual_player_safe_zone_switch
	{
		[Token(Token = "0x6008C40")]
		[Address(RVA = "0x33E9D14", Offset = "0x33E9D14", VA = "0x33E9D14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C41")]
		[Address(RVA = "0x33E9D1C", Offset = "0x33E9D1C", VA = "0x33E9D1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3C")]
	public ReviveTokenCost revive_token_cost
	{
		[Token(Token = "0x6008C42")]
		[Address(RVA = "0x33E9D24", Offset = "0x33E9D24", VA = "0x33E9D24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C43")]
		[Address(RVA = "0x33E9D2C", Offset = "0x33E9D2C", VA = "0x33E9D2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3D")]
	public uint bot_cnt
	{
		[Token(Token = "0x6008C44")]
		[Address(RVA = "0x33E9D34", Offset = "0x33E9D34", VA = "0x33E9D34")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C45")]
		[Address(RVA = "0x33E9D3C", Offset = "0x33E9D3C", VA = "0x33E9D3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3E")]
	public uint ai_cnt
	{
		[Token(Token = "0x6008C46")]
		[Address(RVA = "0x33E9D44", Offset = "0x33E9D44", VA = "0x33E9D44")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008C47")]
		[Address(RVA = "0x33E9D4C", Offset = "0x33E9D4C", VA = "0x33E9D4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E3F")]
	public ulong match_id
	{
		[Token(Token = "0x6008C48")]
		[Address(RVA = "0x33E9D54", Offset = "0x33E9D54", VA = "0x33E9D54")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008C49")]
		[Address(RVA = "0x33E9D5C", Offset = "0x33E9D5C", VA = "0x33E9D5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E40")]
	public byte[] workshop_settings
	{
		[Token(Token = "0x6008C4A")]
		[Address(RVA = "0x33E9D6C", Offset = "0x33E9D6C", VA = "0x33E9D6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C4B")]
		[Address(RVA = "0x33E9D74", Offset = "0x33E9D74", VA = "0x33E9D74")]
		set
		{
		}
	}

	[Token(Token = "0x17000E41")]
	public byte[] object_attribute_settings
	{
		[Token(Token = "0x6008C4C")]
		[Address(RVA = "0x33E9D7C", Offset = "0x33E9D7C", VA = "0x33E9D7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C4D")]
		[Address(RVA = "0x33E9D84", Offset = "0x33E9D84", VA = "0x33E9D84")]
		set
		{
		}
	}

	[Token(Token = "0x17000E42")]
	public List<GSPlayerPrepareInfo> gs_player_prepare_infos
	{
		[Token(Token = "0x6008C4E")]
		[Address(RVA = "0x33E9D8C", Offset = "0x33E9D8C", VA = "0x33E9D8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C4F")]
		[Address(RVA = "0x33E9B1C", Offset = "0x33E9B1C", VA = "0x33E9B1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000E43")]
	public string workshop_code
	{
		[Token(Token = "0x6008C50")]
		[Address(RVA = "0x33E9D94", Offset = "0x33E9D94", VA = "0x33E9D94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C51")]
		[Address(RVA = "0x33E9B24", Offset = "0x33E9B24", VA = "0x33E9B24")]
		set
		{
		}
	}

	[Token(Token = "0x17000E44")]
	public string workshop_name
	{
		[Token(Token = "0x6008C52")]
		[Address(RVA = "0x33E9D9C", Offset = "0x33E9D9C", VA = "0x33E9D9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C53")]
		[Address(RVA = "0x33E9B2C", Offset = "0x33E9B2C", VA = "0x33E9B2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000E45")]
	public byte[] mode_settings
	{
		[Token(Token = "0x6008C54")]
		[Address(RVA = "0x33E9DA4", Offset = "0x33E9DA4", VA = "0x33E9DA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008C55")]
		[Address(RVA = "0x33E9DAC", Offset = "0x33E9DAC", VA = "0x33E9DAC")]
		set
		{
		}
	}

	[Token(Token = "0x6008C03")]
	[Address(RVA = "0x33E99DC", Offset = "0x33E99DC", VA = "0x33E99DC")]
	public GSPrepareInfo()
	{
	}
}
