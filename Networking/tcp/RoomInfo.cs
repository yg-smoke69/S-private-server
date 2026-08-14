using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D66")]
public class RoomInfo
{
	[Token(Token = "0x400B9A7")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B9A8")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cname_003Ek__BackingField;

	[Token(Token = "0x400B9A9")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cowner_003Ek__BackingField;

	[Token(Token = "0x400B9AA")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400B9AB")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B9AC")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B9AD")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cmax_member_num_003Ek__BackingField;

	[Token(Token = "0x400B9AE")]
	[FieldOffset(Offset = "0x30")]
	private uint _003Cmax_spectator_num_003Ek__BackingField;

	[Token(Token = "0x400B9AF")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x400B9B0")]
	[FieldOffset(Offset = "0x38")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B9B1")]
	[FieldOffset(Offset = "0x3C")]
	private List<RoomGroupInfo> _003Cgroups_003Ek__BackingField;

	[Token(Token = "0x400B9B2")]
	[FieldOffset(Offset = "0x40")]
	private List<RoomPlayerInfo> _003Cspectators_003Ek__BackingField;

	[Token(Token = "0x400B9B3")]
	[FieldOffset(Offset = "0x44")]
	private bool _003Cenable_death_spectate_003Ek__BackingField;

	[Token(Token = "0x400B9B4")]
	[FieldOffset(Offset = "0x48")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400B9B5")]
	[FieldOffset(Offset = "0x4C")]
	private bool _003Cenable_group_icon_003Ek__BackingField;

	[Token(Token = "0x400B9B6")]
	[FieldOffset(Offset = "0x50")]
	private uint _003Cmatch_times_003Ek__BackingField;

	[Token(Token = "0x400B9B7")]
	[FieldOffset(Offset = "0x54")]
	private uint _003Clevel_visual_style_003Ek__BackingField;

	[Token(Token = "0x400B9B8")]
	[FieldOffset(Offset = "0x58")]
	private uint _003Croom_setting_003Ek__BackingField;

	[Token(Token = "0x400B9B9")]
	[FieldOffset(Offset = "0x5C")]
	private uint _003Croom_setting2_003Ek__BackingField;

	[Token(Token = "0x400B9BA")]
	[FieldOffset(Offset = "0x60")]
	private bool _003Cenable_emulator_check_003Ek__BackingField;

	[Token(Token = "0x400B9BB")]
	[FieldOffset(Offset = "0x61")]
	private bool _003Cis_cs_advanced_003Ek__BackingField;

	[Token(Token = "0x400B9BC")]
	[FieldOffset(Offset = "0x64")]
	private byte[] _003Ccs_advanced_setting_003Ek__BackingField;

	[Token(Token = "0x400B9BD")]
	[FieldOffset(Offset = "0x68")]
	private uint _003Cwerewolves_room_param_003Ek__BackingField;

	[Token(Token = "0x400B9BE")]
	[FieldOffset(Offset = "0x6C")]
	private uint _003Cwerewolves_room_param2_003Ek__BackingField;

	[Token(Token = "0x400B9BF")]
	[FieldOffset(Offset = "0x70")]
	private uint _003Clanguage_003Ek__BackingField;

	[Token(Token = "0x400B9C0")]
	[FieldOffset(Offset = "0x74")]
	private bool _003Ccontestant_role_check_003Ek__BackingField;

	[Token(Token = "0x400B9C1")]
	[FieldOffset(Offset = "0x78")]
	private WorkshopInfo _003Cworkshop_003Ek__BackingField;

	[Token(Token = "0x400B9C2")]
	[FieldOffset(Offset = "0x7C")]
	private uint _003Cwerewolves_room_param3_003Ek__BackingField;

	[Token(Token = "0x400B9C3")]
	[FieldOffset(Offset = "0x80")]
	private bool _003Cenough_room_card_003Ek__BackingField;

	[Token(Token = "0x400B9C4")]
	[FieldOffset(Offset = "0x81")]
	private bool _003Cowner_online_003Ek__BackingField;

	[Token(Token = "0x400B9C5")]
	[FieldOffset(Offset = "0x88")]
	private ulong _003Cvoice_id_003Ek__BackingField;

	[Token(Token = "0x400B9C6")]
	[FieldOffset(Offset = "0x90")]
	private byte[] _003Cspectate_settings_003Ek__BackingField;

	[Token(Token = "0x17000CE7")]
	public ulong id
	{
		[Token(Token = "0x600896C")]
		[Address(RVA = "0x435E1EC", Offset = "0x435E1EC", VA = "0x435E1EC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600896D")]
		[Address(RVA = "0x435E1F4", Offset = "0x435E1F4", VA = "0x435E1F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CE8")]
	public string name
	{
		[Token(Token = "0x600896E")]
		[Address(RVA = "0x435E204", Offset = "0x435E204", VA = "0x435E204")]
		get
		{
			return null;
		}
		[Token(Token = "0x600896F")]
		[Address(RVA = "0x435E1CC", Offset = "0x435E1CC", VA = "0x435E1CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000CE9")]
	public ulong owner
	{
		[Token(Token = "0x6008970")]
		[Address(RVA = "0x435E20C", Offset = "0x435E20C", VA = "0x435E20C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008971")]
		[Address(RVA = "0x435E214", Offset = "0x435E214", VA = "0x435E214")]
		set
		{
		}
	}

	[Token(Token = "0x17000CEA")]
	public uint map_id
	{
		[Token(Token = "0x6008972")]
		[Address(RVA = "0x435E224", Offset = "0x435E224", VA = "0x435E224")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008973")]
		[Address(RVA = "0x435E22C", Offset = "0x435E22C", VA = "0x435E22C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CEB")]
	public uint game_mode
	{
		[Token(Token = "0x6008974")]
		[Address(RVA = "0x435E234", Offset = "0x435E234", VA = "0x435E234")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008975")]
		[Address(RVA = "0x435E23C", Offset = "0x435E23C", VA = "0x435E23C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CEC")]
	public uint group_mode
	{
		[Token(Token = "0x6008976")]
		[Address(RVA = "0x435E244", Offset = "0x435E244", VA = "0x435E244")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008977")]
		[Address(RVA = "0x435E24C", Offset = "0x435E24C", VA = "0x435E24C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CED")]
	public uint max_member_num
	{
		[Token(Token = "0x6008978")]
		[Address(RVA = "0x435E254", Offset = "0x435E254", VA = "0x435E254")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008979")]
		[Address(RVA = "0x435E25C", Offset = "0x435E25C", VA = "0x435E25C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CEE")]
	public uint max_spectator_num
	{
		[Token(Token = "0x600897A")]
		[Address(RVA = "0x435E264", Offset = "0x435E264", VA = "0x435E264")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600897B")]
		[Address(RVA = "0x435E26C", Offset = "0x435E26C", VA = "0x435E26C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CEF")]
	public uint state
	{
		[Token(Token = "0x600897C")]
		[Address(RVA = "0x435E274", Offset = "0x435E274", VA = "0x435E274")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600897D")]
		[Address(RVA = "0x435E27C", Offset = "0x435E27C", VA = "0x435E27C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF0")]
	public string code
	{
		[Token(Token = "0x600897E")]
		[Address(RVA = "0x435E284", Offset = "0x435E284", VA = "0x435E284")]
		get
		{
			return null;
		}
		[Token(Token = "0x600897F")]
		[Address(RVA = "0x435E1D4", Offset = "0x435E1D4", VA = "0x435E1D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF1")]
	public List<RoomGroupInfo> groups
	{
		[Token(Token = "0x6008980")]
		[Address(RVA = "0x435E28C", Offset = "0x435E28C", VA = "0x435E28C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008981")]
		[Address(RVA = "0x435E1DC", Offset = "0x435E1DC", VA = "0x435E1DC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CF2")]
	public List<RoomPlayerInfo> spectators
	{
		[Token(Token = "0x6008982")]
		[Address(RVA = "0x435E294", Offset = "0x435E294", VA = "0x435E294")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008983")]
		[Address(RVA = "0x435E1E4", Offset = "0x435E1E4", VA = "0x435E1E4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000CF3")]
	public bool enable_death_spectate
	{
		[Token(Token = "0x6008984")]
		[Address(RVA = "0x435E29C", Offset = "0x435E29C", VA = "0x435E29C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008985")]
		[Address(RVA = "0x435E2A4", Offset = "0x435E2A4", VA = "0x435E2A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF4")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x6008986")]
		[Address(RVA = "0x435E2AC", Offset = "0x435E2AC", VA = "0x435E2AC")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x6008987")]
		[Address(RVA = "0x435E2B4", Offset = "0x435E2B4", VA = "0x435E2B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF5")]
	public bool enable_group_icon
	{
		[Token(Token = "0x6008988")]
		[Address(RVA = "0x435E2BC", Offset = "0x435E2BC", VA = "0x435E2BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008989")]
		[Address(RVA = "0x435E2C4", Offset = "0x435E2C4", VA = "0x435E2C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF6")]
	public uint match_times
	{
		[Token(Token = "0x600898A")]
		[Address(RVA = "0x435E2CC", Offset = "0x435E2CC", VA = "0x435E2CC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600898B")]
		[Address(RVA = "0x435E2D4", Offset = "0x435E2D4", VA = "0x435E2D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF7")]
	public uint level_visual_style
	{
		[Token(Token = "0x600898C")]
		[Address(RVA = "0x435E2DC", Offset = "0x435E2DC", VA = "0x435E2DC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600898D")]
		[Address(RVA = "0x435E2E4", Offset = "0x435E2E4", VA = "0x435E2E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF8")]
	public uint room_setting
	{
		[Token(Token = "0x600898E")]
		[Address(RVA = "0x435E2EC", Offset = "0x435E2EC", VA = "0x435E2EC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600898F")]
		[Address(RVA = "0x435E2F4", Offset = "0x435E2F4", VA = "0x435E2F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CF9")]
	public uint room_setting2
	{
		[Token(Token = "0x6008990")]
		[Address(RVA = "0x435E2FC", Offset = "0x435E2FC", VA = "0x435E2FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008991")]
		[Address(RVA = "0x435E304", Offset = "0x435E304", VA = "0x435E304")]
		set
		{
		}
	}

	[Token(Token = "0x17000CFA")]
	public bool enable_emulator_check
	{
		[Token(Token = "0x6008992")]
		[Address(RVA = "0x435E30C", Offset = "0x435E30C", VA = "0x435E30C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008993")]
		[Address(RVA = "0x435E314", Offset = "0x435E314", VA = "0x435E314")]
		set
		{
		}
	}

	[Token(Token = "0x17000CFB")]
	public bool is_cs_advanced
	{
		[Token(Token = "0x6008994")]
		[Address(RVA = "0x435E31C", Offset = "0x435E31C", VA = "0x435E31C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008995")]
		[Address(RVA = "0x435E324", Offset = "0x435E324", VA = "0x435E324")]
		set
		{
		}
	}

	[Token(Token = "0x17000CFC")]
	public byte[] cs_advanced_setting
	{
		[Token(Token = "0x6008996")]
		[Address(RVA = "0x435E32C", Offset = "0x435E32C", VA = "0x435E32C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008997")]
		[Address(RVA = "0x435E334", Offset = "0x435E334", VA = "0x435E334")]
		set
		{
		}
	}

	[Token(Token = "0x17000CFD")]
	public uint werewolves_room_param
	{
		[Token(Token = "0x6008998")]
		[Address(RVA = "0x435E33C", Offset = "0x435E33C", VA = "0x435E33C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008999")]
		[Address(RVA = "0x435E344", Offset = "0x435E344", VA = "0x435E344")]
		set
		{
		}
	}

	[Token(Token = "0x17000CFE")]
	public uint werewolves_room_param2
	{
		[Token(Token = "0x600899A")]
		[Address(RVA = "0x435E34C", Offset = "0x435E34C", VA = "0x435E34C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600899B")]
		[Address(RVA = "0x435E354", Offset = "0x435E354", VA = "0x435E354")]
		set
		{
		}
	}

	[Token(Token = "0x17000CFF")]
	public uint language
	{
		[Token(Token = "0x600899C")]
		[Address(RVA = "0x435E35C", Offset = "0x435E35C", VA = "0x435E35C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600899D")]
		[Address(RVA = "0x435E364", Offset = "0x435E364", VA = "0x435E364")]
		set
		{
		}
	}

	[Token(Token = "0x17000D00")]
	public bool contestant_role_check
	{
		[Token(Token = "0x600899E")]
		[Address(RVA = "0x435E36C", Offset = "0x435E36C", VA = "0x435E36C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600899F")]
		[Address(RVA = "0x435E374", Offset = "0x435E374", VA = "0x435E374")]
		set
		{
		}
	}

	[Token(Token = "0x17000D01")]
	public WorkshopInfo workshop
	{
		[Token(Token = "0x60089A0")]
		[Address(RVA = "0x435E37C", Offset = "0x435E37C", VA = "0x435E37C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089A1")]
		[Address(RVA = "0x435E384", Offset = "0x435E384", VA = "0x435E384")]
		set
		{
		}
	}

	[Token(Token = "0x17000D02")]
	public uint werewolves_room_param3
	{
		[Token(Token = "0x60089A2")]
		[Address(RVA = "0x435E38C", Offset = "0x435E38C", VA = "0x435E38C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60089A3")]
		[Address(RVA = "0x435E394", Offset = "0x435E394", VA = "0x435E394")]
		set
		{
		}
	}

	[Token(Token = "0x17000D03")]
	public bool enough_room_card
	{
		[Token(Token = "0x60089A4")]
		[Address(RVA = "0x435E39C", Offset = "0x435E39C", VA = "0x435E39C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60089A5")]
		[Address(RVA = "0x435E3A4", Offset = "0x435E3A4", VA = "0x435E3A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000D04")]
	public bool owner_online
	{
		[Token(Token = "0x60089A6")]
		[Address(RVA = "0x435E3AC", Offset = "0x435E3AC", VA = "0x435E3AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60089A7")]
		[Address(RVA = "0x435E3B4", Offset = "0x435E3B4", VA = "0x435E3B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000D05")]
	public ulong voice_id
	{
		[Token(Token = "0x60089A8")]
		[Address(RVA = "0x435E3BC", Offset = "0x435E3BC", VA = "0x435E3BC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60089A9")]
		[Address(RVA = "0x435E3C4", Offset = "0x435E3C4", VA = "0x435E3C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000D06")]
	public byte[] spectate_settings
	{
		[Token(Token = "0x60089AA")]
		[Address(RVA = "0x435E3D4", Offset = "0x435E3D4", VA = "0x435E3D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089AB")]
		[Address(RVA = "0x435E3DC", Offset = "0x435E3DC", VA = "0x435E3DC")]
		set
		{
		}
	}

	[Token(Token = "0x600896B")]
	[Address(RVA = "0x435E0B8", Offset = "0x435E0B8", VA = "0x435E0B8")]
	public RoomInfo()
	{
	}
}
