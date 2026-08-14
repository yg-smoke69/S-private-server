using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D5C")]
public class RoomChangeReq
{
	[Token(Token = "0x400B962")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B963")]
	[FieldOffset(Offset = "0x10")]
	private string _003Croom_name_003Ek__BackingField;

	[Token(Token = "0x400B964")]
	[FieldOffset(Offset = "0x14")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B965")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400B966")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B967")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmax_member_num_003Ek__BackingField;

	[Token(Token = "0x400B968")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cmax_spectator_num_003Ek__BackingField;

	[Token(Token = "0x400B969")]
	[FieldOffset(Offset = "0x28")]
	private bool _003Cenable_death_spectate_003Ek__BackingField;

	[Token(Token = "0x400B96A")]
	[FieldOffset(Offset = "0x29")]
	private bool _003Cenable_group_icon_003Ek__BackingField;

	[Token(Token = "0x400B96B")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Clevel_visual_style_003Ek__BackingField;

	[Token(Token = "0x400B96C")]
	[FieldOffset(Offset = "0x30")]
	private uint _003Croom_setting_003Ek__BackingField;

	[Token(Token = "0x400B96D")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Croom_setting2_003Ek__BackingField;

	[Token(Token = "0x400B96E")]
	[FieldOffset(Offset = "0x38")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400B96F")]
	[FieldOffset(Offset = "0x3C")]
	private byte[] _003Ccs_advanced_setting_003Ek__BackingField;

	[Token(Token = "0x400B970")]
	[FieldOffset(Offset = "0x40")]
	private uint _003Cwerewolves_room_param_003Ek__BackingField;

	[Token(Token = "0x400B971")]
	[FieldOffset(Offset = "0x44")]
	private uint _003Cwerewolves_room_param2_003Ek__BackingField;

	[Token(Token = "0x400B972")]
	[FieldOffset(Offset = "0x48")]
	private uint _003Cwerewolves_room_param3_003Ek__BackingField;

	[Token(Token = "0x400B973")]
	[FieldOffset(Offset = "0x4C")]
	private byte[] _003Cspectate_settings_003Ek__BackingField;

	[Token(Token = "0x17000CA2")]
	public ulong room_id
	{
		[Token(Token = "0x60088D8")]
		[Address(RVA = "0x435DA34", Offset = "0x435DA34", VA = "0x435DA34")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088D9")]
		[Address(RVA = "0x435DA3C", Offset = "0x435DA3C", VA = "0x435DA3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA3")]
	public string room_name
	{
		[Token(Token = "0x60088DA")]
		[Address(RVA = "0x435DA4C", Offset = "0x435DA4C", VA = "0x435DA4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088DB")]
		[Address(RVA = "0x435DA24", Offset = "0x435DA24", VA = "0x435DA24")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA4")]
	public string code
	{
		[Token(Token = "0x60088DC")]
		[Address(RVA = "0x435DA54", Offset = "0x435DA54", VA = "0x435DA54")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088DD")]
		[Address(RVA = "0x435DA2C", Offset = "0x435DA2C", VA = "0x435DA2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA5")]
	public uint map_id
	{
		[Token(Token = "0x60088DE")]
		[Address(RVA = "0x435DA5C", Offset = "0x435DA5C", VA = "0x435DA5C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088DF")]
		[Address(RVA = "0x435DA64", Offset = "0x435DA64", VA = "0x435DA64")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA6")]
	public uint game_mode
	{
		[Token(Token = "0x60088E0")]
		[Address(RVA = "0x435DA6C", Offset = "0x435DA6C", VA = "0x435DA6C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088E1")]
		[Address(RVA = "0x435DA74", Offset = "0x435DA74", VA = "0x435DA74")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA7")]
	public uint max_member_num
	{
		[Token(Token = "0x60088E2")]
		[Address(RVA = "0x435DA7C", Offset = "0x435DA7C", VA = "0x435DA7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088E3")]
		[Address(RVA = "0x435DA84", Offset = "0x435DA84", VA = "0x435DA84")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA8")]
	public uint max_spectator_num
	{
		[Token(Token = "0x60088E4")]
		[Address(RVA = "0x435DA8C", Offset = "0x435DA8C", VA = "0x435DA8C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088E5")]
		[Address(RVA = "0x435DA94", Offset = "0x435DA94", VA = "0x435DA94")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA9")]
	public bool enable_death_spectate
	{
		[Token(Token = "0x60088E6")]
		[Address(RVA = "0x435DA9C", Offset = "0x435DA9C", VA = "0x435DA9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60088E7")]
		[Address(RVA = "0x435DAA4", Offset = "0x435DAA4", VA = "0x435DAA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CAA")]
	public bool enable_group_icon
	{
		[Token(Token = "0x60088E8")]
		[Address(RVA = "0x435DAAC", Offset = "0x435DAAC", VA = "0x435DAAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60088E9")]
		[Address(RVA = "0x435DAB4", Offset = "0x435DAB4", VA = "0x435DAB4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CAB")]
	public uint level_visual_style
	{
		[Token(Token = "0x60088EA")]
		[Address(RVA = "0x435DABC", Offset = "0x435DABC", VA = "0x435DABC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088EB")]
		[Address(RVA = "0x435DAC4", Offset = "0x435DAC4", VA = "0x435DAC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CAC")]
	public uint room_setting
	{
		[Token(Token = "0x60088EC")]
		[Address(RVA = "0x435DACC", Offset = "0x435DACC", VA = "0x435DACC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088ED")]
		[Address(RVA = "0x435DAD4", Offset = "0x435DAD4", VA = "0x435DAD4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CAD")]
	public uint room_setting2
	{
		[Token(Token = "0x60088EE")]
		[Address(RVA = "0x435DADC", Offset = "0x435DADC", VA = "0x435DADC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088EF")]
		[Address(RVA = "0x435DAE4", Offset = "0x435DAE4", VA = "0x435DAE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CAE")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x60088F0")]
		[Address(RVA = "0x435DAEC", Offset = "0x435DAEC", VA = "0x435DAEC")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x60088F1")]
		[Address(RVA = "0x435DAF4", Offset = "0x435DAF4", VA = "0x435DAF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CAF")]
	public byte[] cs_advanced_setting
	{
		[Token(Token = "0x60088F2")]
		[Address(RVA = "0x435DAFC", Offset = "0x435DAFC", VA = "0x435DAFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088F3")]
		[Address(RVA = "0x435DB04", Offset = "0x435DB04", VA = "0x435DB04")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB0")]
	public uint werewolves_room_param
	{
		[Token(Token = "0x60088F4")]
		[Address(RVA = "0x435DB0C", Offset = "0x435DB0C", VA = "0x435DB0C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088F5")]
		[Address(RVA = "0x435DB14", Offset = "0x435DB14", VA = "0x435DB14")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB1")]
	public uint werewolves_room_param2
	{
		[Token(Token = "0x60088F6")]
		[Address(RVA = "0x435DB1C", Offset = "0x435DB1C", VA = "0x435DB1C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088F7")]
		[Address(RVA = "0x435DB24", Offset = "0x435DB24", VA = "0x435DB24")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB2")]
	public uint werewolves_room_param3
	{
		[Token(Token = "0x60088F8")]
		[Address(RVA = "0x435DB2C", Offset = "0x435DB2C", VA = "0x435DB2C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60088F9")]
		[Address(RVA = "0x435DB34", Offset = "0x435DB34", VA = "0x435DB34")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB3")]
	public byte[] spectate_settings
	{
		[Token(Token = "0x60088FA")]
		[Address(RVA = "0x435DB3C", Offset = "0x435DB3C", VA = "0x435DB3C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088FB")]
		[Address(RVA = "0x435DB44", Offset = "0x435DB44", VA = "0x435DB44")]
		set
		{
		}
	}

	[Token(Token = "0x60088D7")]
	[Address(RVA = "0x435D978", Offset = "0x435D978", VA = "0x435D978")]
	public RoomChangeReq()
	{
	}
}
