using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CCF")]
public class GroupCreateReq
{
	[Token(Token = "0x400B673")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B674")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B675")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B676")]
	[FieldOffset(Offset = "0x14")]
	private string _003Clanguage_003Ek__BackingField;

	[Token(Token = "0x400B677")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B678")]
	[FieldOffset(Offset = "0x1C")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B679")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B67A")]
	[FieldOffset(Offset = "0x24")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B67B")]
	[FieldOffset(Offset = "0x28")]
	private EGroup.CreateFromType _003Cfrom_type_003Ek__BackingField;

	[Token(Token = "0x400B67C")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400B67D")]
	[FieldOffset(Offset = "0x30")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x400B67E")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Crequired_rank_003Ek__BackingField;

	[Token(Token = "0x400B67F")]
	[FieldOffset(Offset = "0x38")]
	private string _003Cgroup_tag_003Ek__BackingField;

	[Token(Token = "0x400B680")]
	[FieldOffset(Offset = "0x3C")]
	private string _003Cworkshop_code_003Ek__BackingField;

	[Token(Token = "0x400B681")]
	[FieldOffset(Offset = "0x40")]
	private string _003Cworkshop_name_003Ek__BackingField;

	[Token(Token = "0x17000ADA")]
	public uint[] map_ids
	{
		[Token(Token = "0x60084DE")]
		[Address(RVA = "0x33EA560", Offset = "0x33EA560", VA = "0x33EA560")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084DF")]
		[Address(RVA = "0x33EA568", Offset = "0x33EA568", VA = "0x33EA568")]
		set
		{
		}
	}

	[Token(Token = "0x17000ADB")]
	public uint game_mode
	{
		[Token(Token = "0x60084E0")]
		[Address(RVA = "0x33EA570", Offset = "0x33EA570", VA = "0x33EA570")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084E1")]
		[Address(RVA = "0x33EA578", Offset = "0x33EA578", VA = "0x33EA578")]
		set
		{
		}
	}

	[Token(Token = "0x17000ADC")]
	public uint group_mode
	{
		[Token(Token = "0x60084E2")]
		[Address(RVA = "0x33EA580", Offset = "0x33EA580", VA = "0x33EA580")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084E3")]
		[Address(RVA = "0x33EA588", Offset = "0x33EA588", VA = "0x33EA588")]
		set
		{
		}
	}

	[Token(Token = "0x17000ADD")]
	public string language
	{
		[Token(Token = "0x60084E4")]
		[Address(RVA = "0x33EA590", Offset = "0x33EA590", VA = "0x33EA590")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084E5")]
		[Address(RVA = "0x33EA538", Offset = "0x33EA538", VA = "0x33EA538")]
		set
		{
		}
	}

	[Token(Token = "0x17000ADE")]
	public uint difficulty
	{
		[Token(Token = "0x60084E6")]
		[Address(RVA = "0x33EA598", Offset = "0x33EA598", VA = "0x33EA598")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084E7")]
		[Address(RVA = "0x33EA5A0", Offset = "0x33EA5A0", VA = "0x33EA5A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000ADF")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x60084E8")]
		[Address(RVA = "0x33EA5A8", Offset = "0x33EA5A8", VA = "0x33EA5A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084E9")]
		[Address(RVA = "0x33EA540", Offset = "0x33EA540", VA = "0x33EA540")]
		private set
		{
		}
	}

	[Token(Token = "0x17000AE0")]
	public uint match_mode
	{
		[Token(Token = "0x60084EA")]
		[Address(RVA = "0x33EA5B0", Offset = "0x33EA5B0", VA = "0x33EA5B0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084EB")]
		[Address(RVA = "0x33EA5B8", Offset = "0x33EA5B8", VA = "0x33EA5B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE1")]
	public uint[] available_maps
	{
		[Token(Token = "0x60084EC")]
		[Address(RVA = "0x33EA5C0", Offset = "0x33EA5C0", VA = "0x33EA5C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084ED")]
		[Address(RVA = "0x33EA5C8", Offset = "0x33EA5C8", VA = "0x33EA5C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE2")]
	public EGroup.CreateFromType from_type
	{
		[Token(Token = "0x60084EE")]
		[Address(RVA = "0x33EA5D0", Offset = "0x33EA5D0", VA = "0x33EA5D0")]
		get
		{
			return default(EGroup.CreateFromType);
		}
		[Token(Token = "0x60084EF")]
		[Address(RVA = "0x33EA5D8", Offset = "0x33EA5D8", VA = "0x33EA5D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE3")]
	public uint system_platform
	{
		[Token(Token = "0x60084F0")]
		[Address(RVA = "0x33EA5E0", Offset = "0x33EA5E0", VA = "0x33EA5E0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084F1")]
		[Address(RVA = "0x33EA5E8", Offset = "0x33EA5E8", VA = "0x33EA5E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE4")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x60084F2")]
		[Address(RVA = "0x33EA5F0", Offset = "0x33EA5F0", VA = "0x33EA5F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084F3")]
		[Address(RVA = "0x33EA5F8", Offset = "0x33EA5F8", VA = "0x33EA5F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE5")]
	public uint required_rank
	{
		[Token(Token = "0x60084F4")]
		[Address(RVA = "0x33EA600", Offset = "0x33EA600", VA = "0x33EA600")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60084F5")]
		[Address(RVA = "0x33EA608", Offset = "0x33EA608", VA = "0x33EA608")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE6")]
	public string group_tag
	{
		[Token(Token = "0x60084F6")]
		[Address(RVA = "0x33EA610", Offset = "0x33EA610", VA = "0x33EA610")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084F7")]
		[Address(RVA = "0x33EA548", Offset = "0x33EA548", VA = "0x33EA548")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE7")]
	public string workshop_code
	{
		[Token(Token = "0x60084F8")]
		[Address(RVA = "0x33EA618", Offset = "0x33EA618", VA = "0x33EA618")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084F9")]
		[Address(RVA = "0x33EA550", Offset = "0x33EA550", VA = "0x33EA550")]
		set
		{
		}
	}

	[Token(Token = "0x17000AE8")]
	public string workshop_name
	{
		[Token(Token = "0x60084FA")]
		[Address(RVA = "0x33EA620", Offset = "0x33EA620", VA = "0x33EA620")]
		get
		{
			return null;
		}
		[Token(Token = "0x60084FB")]
		[Address(RVA = "0x33EA558", Offset = "0x33EA558", VA = "0x33EA558")]
		set
		{
		}
	}

	[Token(Token = "0x60084DD")]
	[Address(RVA = "0x33EA430", Offset = "0x33EA430", VA = "0x33EA430")]
	public GroupCreateReq()
	{
	}
}
