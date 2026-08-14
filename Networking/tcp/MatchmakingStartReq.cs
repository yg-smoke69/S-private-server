using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D20")]
public class MatchmakingStartReq
{
	[Token(Token = "0x400B7F1")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B7F2")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B7F3")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B7F4")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cwta_currency_type_003Ek__BackingField;

	[Token(Token = "0x400B7F5")]
	[FieldOffset(Offset = "0x18")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B7F6")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B7F7")]
	[FieldOffset(Offset = "0x20")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B7F8")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400B7F9")]
	[FieldOffset(Offset = "0x28")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x400B7FA")]
	[FieldOffset(Offset = "0x2C")]
	private List<string> _003Cworkshop_codes_003Ek__BackingField;

	[Token(Token = "0x400B7FB")]
	[FieldOffset(Offset = "0x30")]
	private EMatch.GroupMode _003Cworkshop_group_mode_003Ek__BackingField;

	[Token(Token = "0x400B7FC")]
	[FieldOffset(Offset = "0x34")]
	private bool _003Cis_workshop_team_contest_003Ek__BackingField;

	[Token(Token = "0x400B7FD")]
	[FieldOffset(Offset = "0x38")]
	private uint[] _003Cworkshop_team_counts_003Ek__BackingField;

	[Token(Token = "0x17000BDE")]
	public uint[] map_ids
	{
		[Token(Token = "0x6008727")]
		[Address(RVA = "0x435C5A8", Offset = "0x435C5A8", VA = "0x435C5A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008728")]
		[Address(RVA = "0x435C5B0", Offset = "0x435C5B0", VA = "0x435C5B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BDF")]
	public uint game_mode
	{
		[Token(Token = "0x6008729")]
		[Address(RVA = "0x435C5B8", Offset = "0x435C5B8", VA = "0x435C5B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600872A")]
		[Address(RVA = "0x435C5C0", Offset = "0x435C5C0", VA = "0x435C5C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE0")]
	public uint difficulty
	{
		[Token(Token = "0x600872B")]
		[Address(RVA = "0x435C5C8", Offset = "0x435C5C8", VA = "0x435C5C8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600872C")]
		[Address(RVA = "0x435C5D0", Offset = "0x435C5D0", VA = "0x435C5D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE1")]
	public uint wta_currency_type
	{
		[Token(Token = "0x600872D")]
		[Address(RVA = "0x435C5D8", Offset = "0x435C5D8", VA = "0x435C5D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600872E")]
		[Address(RVA = "0x435C5E0", Offset = "0x435C5E0", VA = "0x435C5E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE2")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x600872F")]
		[Address(RVA = "0x435C5E8", Offset = "0x435C5E8", VA = "0x435C5E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008730")]
		[Address(RVA = "0x435C598", Offset = "0x435C598", VA = "0x435C598")]
		private set
		{
		}
	}

	[Token(Token = "0x17000BE3")]
	public uint match_mode
	{
		[Token(Token = "0x6008731")]
		[Address(RVA = "0x435C5F0", Offset = "0x435C5F0", VA = "0x435C5F0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008732")]
		[Address(RVA = "0x435C5F8", Offset = "0x435C5F8", VA = "0x435C5F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE4")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008733")]
		[Address(RVA = "0x435C600", Offset = "0x435C600", VA = "0x435C600")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008734")]
		[Address(RVA = "0x435C608", Offset = "0x435C608", VA = "0x435C608")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE5")]
	public uint system_platform
	{
		[Token(Token = "0x6008735")]
		[Address(RVA = "0x435C610", Offset = "0x435C610", VA = "0x435C610")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008736")]
		[Address(RVA = "0x435C618", Offset = "0x435C618", VA = "0x435C618")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE6")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x6008737")]
		[Address(RVA = "0x435C620", Offset = "0x435C620", VA = "0x435C620")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008738")]
		[Address(RVA = "0x435C628", Offset = "0x435C628", VA = "0x435C628")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE7")]
	public List<string> workshop_codes
	{
		[Token(Token = "0x6008739")]
		[Address(RVA = "0x435C630", Offset = "0x435C630", VA = "0x435C630")]
		get
		{
			return null;
		}
		[Token(Token = "0x600873A")]
		[Address(RVA = "0x435C5A0", Offset = "0x435C5A0", VA = "0x435C5A0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000BE8")]
	public EMatch.GroupMode workshop_group_mode
	{
		[Token(Token = "0x600873B")]
		[Address(RVA = "0x435C638", Offset = "0x435C638", VA = "0x435C638")]
		get
		{
			return default(EMatch.GroupMode);
		}
		[Token(Token = "0x600873C")]
		[Address(RVA = "0x435C640", Offset = "0x435C640", VA = "0x435C640")]
		set
		{
		}
	}

	[Token(Token = "0x17000BE9")]
	public bool is_workshop_team_contest
	{
		[Token(Token = "0x600873D")]
		[Address(RVA = "0x435C648", Offset = "0x435C648", VA = "0x435C648")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600873E")]
		[Address(RVA = "0x435C650", Offset = "0x435C650", VA = "0x435C650")]
		set
		{
		}
	}

	[Token(Token = "0x17000BEA")]
	public uint[] workshop_team_counts
	{
		[Token(Token = "0x600873F")]
		[Address(RVA = "0x435C658", Offset = "0x435C658", VA = "0x435C658")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008740")]
		[Address(RVA = "0x435C660", Offset = "0x435C660", VA = "0x435C660")]
		set
		{
		}
	}

	[Token(Token = "0x6008726")]
	[Address(RVA = "0x435C4D8", Offset = "0x435C4D8", VA = "0x435C4D8")]
	public MatchmakingStartReq()
	{
	}
}
