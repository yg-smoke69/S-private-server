using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D50")]
public class RoomCreateReq
{
	[Token(Token = "0x400B916")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400B917")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B918")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B919")]
	[FieldOffset(Offset = "0x14")]
	private string _003Croom_name_003Ek__BackingField;

	[Token(Token = "0x400B91A")]
	[FieldOffset(Offset = "0x18")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B91B")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cmax_member_num_003Ek__BackingField;

	[Token(Token = "0x400B91C")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmax_spectator_num_003Ek__BackingField;

	[Token(Token = "0x400B91D")]
	[FieldOffset(Offset = "0x24")]
	private bool _003Cenable_death_spectate_003Ek__BackingField;

	[Token(Token = "0x400B91E")]
	[FieldOffset(Offset = "0x28")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400B91F")]
	[FieldOffset(Offset = "0x30")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B920")]
	[FieldOffset(Offset = "0x38")]
	private bool _003Cenable_group_icon_003Ek__BackingField;

	[Token(Token = "0x400B921")]
	[FieldOffset(Offset = "0x3C")]
	private uint _003Clevel_visual_style_003Ek__BackingField;

	[Token(Token = "0x400B922")]
	[FieldOffset(Offset = "0x40")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B923")]
	[FieldOffset(Offset = "0x48")]
	private uint _003Croom_setting_003Ek__BackingField;

	[Token(Token = "0x400B924")]
	[FieldOffset(Offset = "0x4C")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B925")]
	[FieldOffset(Offset = "0x50")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B926")]
	[FieldOffset(Offset = "0x58")]
	private ulong _003Creopen_id_003Ek__BackingField;

	[Token(Token = "0x400B927")]
	[FieldOffset(Offset = "0x60")]
	private uint _003Croom_setting2_003Ek__BackingField;

	[Token(Token = "0x400B928")]
	[FieldOffset(Offset = "0x64")]
	private bool _003Cenable_emulator_check_003Ek__BackingField;

	[Token(Token = "0x400B929")]
	[FieldOffset(Offset = "0x68")]
	private uint _003Ccreater_role_003Ek__BackingField;

	[Token(Token = "0x400B92A")]
	[FieldOffset(Offset = "0x6C")]
	private bool _003Cis_cs_advanced_003Ek__BackingField;

	[Token(Token = "0x400B92B")]
	[FieldOffset(Offset = "0x70")]
	private byte[] _003Ccs_advanced_setting_003Ek__BackingField;

	[Token(Token = "0x400B92C")]
	[FieldOffset(Offset = "0x74")]
	private uint _003Cwerewolves_room_param_003Ek__BackingField;

	[Token(Token = "0x400B92D")]
	[FieldOffset(Offset = "0x78")]
	private uint _003Cwerewolves_room_param2_003Ek__BackingField;

	[Token(Token = "0x400B92E")]
	[FieldOffset(Offset = "0x7C")]
	private uint _003Clanguage_003Ek__BackingField;

	[Token(Token = "0x400B92F")]
	[FieldOffset(Offset = "0x80")]
	private bool _003Ccontestant_role_check_003Ek__BackingField;

	[Token(Token = "0x400B930")]
	[FieldOffset(Offset = "0x81")]
	private bool _003Croom_data_inherit_003Ek__BackingField;

	[Token(Token = "0x400B931")]
	[FieldOffset(Offset = "0x84")]
	private uint _003Cwerewolves_room_param3_003Ek__BackingField;

	[Token(Token = "0x400B932")]
	[FieldOffset(Offset = "0x88")]
	private string _003Cworkshop_code_003Ek__BackingField;

	[Token(Token = "0x400B933")]
	[FieldOffset(Offset = "0x90")]
	private long _003Cworkshop_update_time_003Ek__BackingField;

	[Token(Token = "0x400B934")]
	[FieldOffset(Offset = "0x98")]
	private uint _003Cworkshop_map_source_003Ek__BackingField;

	[Token(Token = "0x400B935")]
	[FieldOffset(Offset = "0x9C")]
	private byte[] _003Cspectate_settings_003Ek__BackingField;

	[Token(Token = "0x400B936")]
	[FieldOffset(Offset = "0xA0")]
	private uint _003Cworkshop_map_scene_003Ek__BackingField;

	[Token(Token = "0x17000C56")]
	public uint map_id
	{
		[Token(Token = "0x6008834")]
		[Address(RVA = "0x435DCD8", Offset = "0x435DCD8", VA = "0x435DCD8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008835")]
		[Address(RVA = "0x435DCE0", Offset = "0x435DCE0", VA = "0x435DCE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C57")]
	public uint game_mode
	{
		[Token(Token = "0x6008836")]
		[Address(RVA = "0x435DCE8", Offset = "0x435DCE8", VA = "0x435DCE8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008837")]
		[Address(RVA = "0x435DCF0", Offset = "0x435DCF0", VA = "0x435DCF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C58")]
	public uint group_mode
	{
		[Token(Token = "0x6008838")]
		[Address(RVA = "0x435DCF8", Offset = "0x435DCF8", VA = "0x435DCF8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008839")]
		[Address(RVA = "0x435DD00", Offset = "0x435DD00", VA = "0x435DD00")]
		set
		{
		}
	}

	[Token(Token = "0x17000C59")]
	public string room_name
	{
		[Token(Token = "0x600883A")]
		[Address(RVA = "0x435DD08", Offset = "0x435DD08", VA = "0x435DD08")]
		get
		{
			return null;
		}
		[Token(Token = "0x600883B")]
		[Address(RVA = "0x435DCB8", Offset = "0x435DCB8", VA = "0x435DCB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C5A")]
	public string code
	{
		[Token(Token = "0x600883C")]
		[Address(RVA = "0x435DD10", Offset = "0x435DD10", VA = "0x435DD10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600883D")]
		[Address(RVA = "0x435DCC0", Offset = "0x435DCC0", VA = "0x435DCC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C5B")]
	public uint max_member_num
	{
		[Token(Token = "0x600883E")]
		[Address(RVA = "0x435DD18", Offset = "0x435DD18", VA = "0x435DD18")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600883F")]
		[Address(RVA = "0x435DD20", Offset = "0x435DD20", VA = "0x435DD20")]
		set
		{
		}
	}

	[Token(Token = "0x17000C5C")]
	public uint max_spectator_num
	{
		[Token(Token = "0x6008840")]
		[Address(RVA = "0x435DD28", Offset = "0x435DD28", VA = "0x435DD28")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008841")]
		[Address(RVA = "0x435DD30", Offset = "0x435DD30", VA = "0x435DD30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C5D")]
	public bool enable_death_spectate
	{
		[Token(Token = "0x6008842")]
		[Address(RVA = "0x435DD38", Offset = "0x435DD38", VA = "0x435DD38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008843")]
		[Address(RVA = "0x435DD40", Offset = "0x435DD40", VA = "0x435DD40")]
		set
		{
		}
	}

	[Token(Token = "0x17000C5E")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x6008844")]
		[Address(RVA = "0x435DD48", Offset = "0x435DD48", VA = "0x435DD48")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x6008845")]
		[Address(RVA = "0x435DD50", Offset = "0x435DD50", VA = "0x435DD50")]
		set
		{
		}
	}

	[Token(Token = "0x17000C5F")]
	public ulong group_id
	{
		[Token(Token = "0x6008846")]
		[Address(RVA = "0x435DD58", Offset = "0x435DD58", VA = "0x435DD58")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008847")]
		[Address(RVA = "0x435DD60", Offset = "0x435DD60", VA = "0x435DD60")]
		set
		{
		}
	}

	[Token(Token = "0x17000C60")]
	public bool enable_group_icon
	{
		[Token(Token = "0x6008848")]
		[Address(RVA = "0x435DD70", Offset = "0x435DD70", VA = "0x435DD70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008849")]
		[Address(RVA = "0x435DD78", Offset = "0x435DD78", VA = "0x435DD78")]
		set
		{
		}
	}

	[Token(Token = "0x17000C61")]
	public uint level_visual_style
	{
		[Token(Token = "0x600884A")]
		[Address(RVA = "0x435DD80", Offset = "0x435DD80", VA = "0x435DD80")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600884B")]
		[Address(RVA = "0x435DD88", Offset = "0x435DD88", VA = "0x435DD88")]
		set
		{
		}
	}

	[Token(Token = "0x17000C62")]
	public ulong room_id
	{
		[Token(Token = "0x600884C")]
		[Address(RVA = "0x435DD90", Offset = "0x435DD90", VA = "0x435DD90")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600884D")]
		[Address(RVA = "0x435DD98", Offset = "0x435DD98", VA = "0x435DD98")]
		set
		{
		}
	}

	[Token(Token = "0x17000C63")]
	public uint room_setting
	{
		[Token(Token = "0x600884E")]
		[Address(RVA = "0x435DDA8", Offset = "0x435DDA8", VA = "0x435DDA8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600884F")]
		[Address(RVA = "0x435DDB0", Offset = "0x435DDB0", VA = "0x435DDB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C64")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x6008850")]
		[Address(RVA = "0x435DDB8", Offset = "0x435DDB8", VA = "0x435DDB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008851")]
		[Address(RVA = "0x435DCC8", Offset = "0x435DCC8", VA = "0x435DCC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C65")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008852")]
		[Address(RVA = "0x435DDC0", Offset = "0x435DDC0", VA = "0x435DDC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008853")]
		[Address(RVA = "0x435DDC8", Offset = "0x435DDC8", VA = "0x435DDC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C66")]
	public ulong reopen_id
	{
		[Token(Token = "0x6008854")]
		[Address(RVA = "0x435DDD0", Offset = "0x435DDD0", VA = "0x435DDD0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008855")]
		[Address(RVA = "0x435DDD8", Offset = "0x435DDD8", VA = "0x435DDD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C67")]
	public uint room_setting2
	{
		[Token(Token = "0x6008856")]
		[Address(RVA = "0x435DDE8", Offset = "0x435DDE8", VA = "0x435DDE8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008857")]
		[Address(RVA = "0x435DDF0", Offset = "0x435DDF0", VA = "0x435DDF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C68")]
	public bool enable_emulator_check
	{
		[Token(Token = "0x6008858")]
		[Address(RVA = "0x435DDF8", Offset = "0x435DDF8", VA = "0x435DDF8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008859")]
		[Address(RVA = "0x435DE00", Offset = "0x435DE00", VA = "0x435DE00")]
		set
		{
		}
	}

	[Token(Token = "0x17000C69")]
	public uint creater_role
	{
		[Token(Token = "0x600885A")]
		[Address(RVA = "0x435DE08", Offset = "0x435DE08", VA = "0x435DE08")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600885B")]
		[Address(RVA = "0x435DE10", Offset = "0x435DE10", VA = "0x435DE10")]
		set
		{
		}
	}

	[Token(Token = "0x17000C6A")]
	public bool is_cs_advanced
	{
		[Token(Token = "0x600885C")]
		[Address(RVA = "0x435DE18", Offset = "0x435DE18", VA = "0x435DE18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600885D")]
		[Address(RVA = "0x435DE20", Offset = "0x435DE20", VA = "0x435DE20")]
		set
		{
		}
	}

	[Token(Token = "0x17000C6B")]
	public byte[] cs_advanced_setting
	{
		[Token(Token = "0x600885E")]
		[Address(RVA = "0x435DE28", Offset = "0x435DE28", VA = "0x435DE28")]
		get
		{
			return null;
		}
		[Token(Token = "0x600885F")]
		[Address(RVA = "0x435DE30", Offset = "0x435DE30", VA = "0x435DE30")]
		set
		{
		}
	}

	[Token(Token = "0x17000C6C")]
	public uint werewolves_room_param
	{
		[Token(Token = "0x6008860")]
		[Address(RVA = "0x435DE38", Offset = "0x435DE38", VA = "0x435DE38")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008861")]
		[Address(RVA = "0x435DE40", Offset = "0x435DE40", VA = "0x435DE40")]
		set
		{
		}
	}

	[Token(Token = "0x17000C6D")]
	public uint werewolves_room_param2
	{
		[Token(Token = "0x6008862")]
		[Address(RVA = "0x435DE48", Offset = "0x435DE48", VA = "0x435DE48")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008863")]
		[Address(RVA = "0x435DE50", Offset = "0x435DE50", VA = "0x435DE50")]
		set
		{
		}
	}

	[Token(Token = "0x17000C6E")]
	public uint language
	{
		[Token(Token = "0x6008864")]
		[Address(RVA = "0x435DE58", Offset = "0x435DE58", VA = "0x435DE58")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008865")]
		[Address(RVA = "0x435DE60", Offset = "0x435DE60", VA = "0x435DE60")]
		set
		{
		}
	}

	[Token(Token = "0x17000C6F")]
	public bool contestant_role_check
	{
		[Token(Token = "0x6008866")]
		[Address(RVA = "0x435DE68", Offset = "0x435DE68", VA = "0x435DE68")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008867")]
		[Address(RVA = "0x435DE70", Offset = "0x435DE70", VA = "0x435DE70")]
		set
		{
		}
	}

	[Token(Token = "0x17000C70")]
	public bool room_data_inherit
	{
		[Token(Token = "0x6008868")]
		[Address(RVA = "0x435DE78", Offset = "0x435DE78", VA = "0x435DE78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008869")]
		[Address(RVA = "0x435DE80", Offset = "0x435DE80", VA = "0x435DE80")]
		set
		{
		}
	}

	[Token(Token = "0x17000C71")]
	public uint werewolves_room_param3
	{
		[Token(Token = "0x600886A")]
		[Address(RVA = "0x435DE88", Offset = "0x435DE88", VA = "0x435DE88")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600886B")]
		[Address(RVA = "0x435DE90", Offset = "0x435DE90", VA = "0x435DE90")]
		set
		{
		}
	}

	[Token(Token = "0x17000C72")]
	public string workshop_code
	{
		[Token(Token = "0x600886C")]
		[Address(RVA = "0x435DE98", Offset = "0x435DE98", VA = "0x435DE98")]
		get
		{
			return null;
		}
		[Token(Token = "0x600886D")]
		[Address(RVA = "0x435DCD0", Offset = "0x435DCD0", VA = "0x435DCD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C73")]
	public long workshop_update_time
	{
		[Token(Token = "0x600886E")]
		[Address(RVA = "0x435DEA0", Offset = "0x435DEA0", VA = "0x435DEA0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600886F")]
		[Address(RVA = "0x435DEA8", Offset = "0x435DEA8", VA = "0x435DEA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C74")]
	public uint workshop_map_source
	{
		[Token(Token = "0x6008870")]
		[Address(RVA = "0x435DEB8", Offset = "0x435DEB8", VA = "0x435DEB8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008871")]
		[Address(RVA = "0x435DEC0", Offset = "0x435DEC0", VA = "0x435DEC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C75")]
	public byte[] spectate_settings
	{
		[Token(Token = "0x6008872")]
		[Address(RVA = "0x435DEC8", Offset = "0x435DEC8", VA = "0x435DEC8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008873")]
		[Address(RVA = "0x435DED0", Offset = "0x435DED0", VA = "0x435DED0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C76")]
	public uint workshop_map_scene
	{
		[Token(Token = "0x6008874")]
		[Address(RVA = "0x435DED8", Offset = "0x435DED8", VA = "0x435DED8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008875")]
		[Address(RVA = "0x435DEE0", Offset = "0x435DEE0", VA = "0x435DEE0")]
		set
		{
		}
	}

	[Token(Token = "0x6008833")]
	[Address(RVA = "0x435DBBC", Offset = "0x435DBBC", VA = "0x435DBBC")]
	public RoomCreateReq()
	{
	}
}
