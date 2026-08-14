using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE6")]
public class GroupInfo
{
	[Token(Token = "0x400B6F4")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6F5")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cregion_003Ek__BackingField;

	[Token(Token = "0x400B6F6")]
	[FieldOffset(Offset = "0x14")]
	private bool _003Cauto_group_003Ek__BackingField;

	[Token(Token = "0x400B6F7")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B6F8")]
	[FieldOffset(Offset = "0x1C")]
	private List<GroupMemberInfo> _003Cmembers_003Ek__BackingField;

	[Token(Token = "0x400B6F9")]
	[FieldOffset(Offset = "0x20")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B6FA")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B6FB")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B6FC")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B6FD")]
	[FieldOffset(Offset = "0x30")]
	private string _003Cgroup_code_003Ek__BackingField;

	[Token(Token = "0x400B6FE")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Cranking_match_type_003Ek__BackingField;

	[Token(Token = "0x400B6FF")]
	[FieldOffset(Offset = "0x38")]
	private bool _003Cis_public_003Ek__BackingField;

	[Token(Token = "0x400B700")]
	[FieldOffset(Offset = "0x3C")]
	private string _003Csecret_code_003Ek__BackingField;

	[Token(Token = "0x400B701")]
	[FieldOffset(Offset = "0x40")]
	private uint _003Crequired_rank_003Ek__BackingField;

	[Token(Token = "0x400B702")]
	[FieldOffset(Offset = "0x44")]
	private string _003Cgroup_tag_003Ek__BackingField;

	[Token(Token = "0x400B703")]
	[FieldOffset(Offset = "0x48")]
	private ulong _003Cvoice_id_003Ek__BackingField;

	[Token(Token = "0x400B704")]
	[FieldOffset(Offset = "0x50")]
	private string _003Cworkshop_code_003Ek__BackingField;

	[Token(Token = "0x400B705")]
	[FieldOffset(Offset = "0x54")]
	private string _003Cworkshop_name_003Ek__BackingField;

	[Token(Token = "0x400B706")]
	[FieldOffset(Offset = "0x58")]
	private MaxLobbyDisplayInfo _003Cmax_lobby_display_info_003Ek__BackingField;

	[Token(Token = "0x400B707")]
	[FieldOffset(Offset = "0x5C")]
	private bool _003Chide_captain_lobby_003Ek__BackingField;

	[Token(Token = "0x17000B5B")]
	public ulong group_id
	{
		[Token(Token = "0x60085F7")]
		[Address(RVA = "0x33EA7C8", Offset = "0x33EA7C8", VA = "0x33EA7C8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085F8")]
		[Address(RVA = "0x33EA7D0", Offset = "0x33EA7D0", VA = "0x33EA7D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5C")]
	public string region
	{
		[Token(Token = "0x60085F9")]
		[Address(RVA = "0x33EA7E0", Offset = "0x33EA7E0", VA = "0x33EA7E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085FA")]
		[Address(RVA = "0x33EA790", Offset = "0x33EA790", VA = "0x33EA790")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5D")]
	public bool auto_group
	{
		[Token(Token = "0x60085FB")]
		[Address(RVA = "0x33EA7E8", Offset = "0x33EA7E8", VA = "0x33EA7E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085FC")]
		[Address(RVA = "0x33EA7F0", Offset = "0x33EA7F0", VA = "0x33EA7F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5E")]
	public uint group_mode
	{
		[Token(Token = "0x60085FD")]
		[Address(RVA = "0x33EA7F8", Offset = "0x33EA7F8", VA = "0x33EA7F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60085FE")]
		[Address(RVA = "0x33EA800", Offset = "0x33EA800", VA = "0x33EA800")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5F")]
	public List<GroupMemberInfo> members
	{
		[Token(Token = "0x60085FF")]
		[Address(RVA = "0x33EA808", Offset = "0x33EA808", VA = "0x33EA808")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008600")]
		[Address(RVA = "0x33EA798", Offset = "0x33EA798", VA = "0x33EA798")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B60")]
	public uint[] map_ids
	{
		[Token(Token = "0x6008601")]
		[Address(RVA = "0x33EA810", Offset = "0x33EA810", VA = "0x33EA810")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008602")]
		[Address(RVA = "0x33EA818", Offset = "0x33EA818", VA = "0x33EA818")]
		set
		{
		}
	}

	[Token(Token = "0x17000B61")]
	public uint game_mode
	{
		[Token(Token = "0x6008603")]
		[Address(RVA = "0x33EA820", Offset = "0x33EA820", VA = "0x33EA820")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008604")]
		[Address(RVA = "0x33EA828", Offset = "0x33EA828", VA = "0x33EA828")]
		set
		{
		}
	}

	[Token(Token = "0x17000B62")]
	public uint difficulty
	{
		[Token(Token = "0x6008605")]
		[Address(RVA = "0x33EA830", Offset = "0x33EA830", VA = "0x33EA830")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008606")]
		[Address(RVA = "0x33EA838", Offset = "0x33EA838", VA = "0x33EA838")]
		set
		{
		}
	}

	[Token(Token = "0x17000B63")]
	public uint match_mode
	{
		[Token(Token = "0x6008607")]
		[Address(RVA = "0x33EA840", Offset = "0x33EA840", VA = "0x33EA840")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008608")]
		[Address(RVA = "0x33EA848", Offset = "0x33EA848", VA = "0x33EA848")]
		set
		{
		}
	}

	[Token(Token = "0x17000B64")]
	public string group_code
	{
		[Token(Token = "0x6008609")]
		[Address(RVA = "0x33EA850", Offset = "0x33EA850", VA = "0x33EA850")]
		get
		{
			return null;
		}
		[Token(Token = "0x600860A")]
		[Address(RVA = "0x33EA7A0", Offset = "0x33EA7A0", VA = "0x33EA7A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B65")]
	public uint ranking_match_type
	{
		[Token(Token = "0x600860B")]
		[Address(RVA = "0x33EA858", Offset = "0x33EA858", VA = "0x33EA858")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600860C")]
		[Address(RVA = "0x33EA860", Offset = "0x33EA860", VA = "0x33EA860")]
		set
		{
		}
	}

	[Token(Token = "0x17000B66")]
	public bool is_public
	{
		[Token(Token = "0x600860D")]
		[Address(RVA = "0x33EA868", Offset = "0x33EA868", VA = "0x33EA868")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600860E")]
		[Address(RVA = "0x33EA870", Offset = "0x33EA870", VA = "0x33EA870")]
		set
		{
		}
	}

	[Token(Token = "0x17000B67")]
	public string secret_code
	{
		[Token(Token = "0x600860F")]
		[Address(RVA = "0x33EA878", Offset = "0x33EA878", VA = "0x33EA878")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008610")]
		[Address(RVA = "0x33EA7A8", Offset = "0x33EA7A8", VA = "0x33EA7A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B68")]
	public uint required_rank
	{
		[Token(Token = "0x6008611")]
		[Address(RVA = "0x33EA880", Offset = "0x33EA880", VA = "0x33EA880")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008612")]
		[Address(RVA = "0x33EA888", Offset = "0x33EA888", VA = "0x33EA888")]
		set
		{
		}
	}

	[Token(Token = "0x17000B69")]
	public string group_tag
	{
		[Token(Token = "0x6008613")]
		[Address(RVA = "0x33EA890", Offset = "0x33EA890", VA = "0x33EA890")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008614")]
		[Address(RVA = "0x33EA7B0", Offset = "0x33EA7B0", VA = "0x33EA7B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B6A")]
	public ulong voice_id
	{
		[Token(Token = "0x6008615")]
		[Address(RVA = "0x33EA898", Offset = "0x33EA898", VA = "0x33EA898")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008616")]
		[Address(RVA = "0x33EA8A0", Offset = "0x33EA8A0", VA = "0x33EA8A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B6B")]
	public string workshop_code
	{
		[Token(Token = "0x6008617")]
		[Address(RVA = "0x33EA8B0", Offset = "0x33EA8B0", VA = "0x33EA8B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008618")]
		[Address(RVA = "0x33EA7B8", Offset = "0x33EA7B8", VA = "0x33EA7B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B6C")]
	public string workshop_name
	{
		[Token(Token = "0x6008619")]
		[Address(RVA = "0x33EA8B8", Offset = "0x33EA8B8", VA = "0x33EA8B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600861A")]
		[Address(RVA = "0x33EA7C0", Offset = "0x33EA7C0", VA = "0x33EA7C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B6D")]
	public MaxLobbyDisplayInfo max_lobby_display_info
	{
		[Token(Token = "0x600861B")]
		[Address(RVA = "0x33EA8C0", Offset = "0x33EA8C0", VA = "0x33EA8C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600861C")]
		[Address(RVA = "0x33EA8C8", Offset = "0x33EA8C8", VA = "0x33EA8C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B6E")]
	public bool hide_captain_lobby
	{
		[Token(Token = "0x600861D")]
		[Address(RVA = "0x33EA8D0", Offset = "0x33EA8D0", VA = "0x33EA8D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600861E")]
		[Address(RVA = "0x33EA8D8", Offset = "0x33EA8D8", VA = "0x33EA8D8")]
		set
		{
		}
	}

	[Token(Token = "0x60085F6")]
	[Address(RVA = "0x33EA670", Offset = "0x33EA670", VA = "0x33EA670")]
	public GroupInfo()
	{
	}
}
