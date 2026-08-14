using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D21")]
public class MatchmakingGroupStartReq
{
	[Token(Token = "0x400B7FE")]
	[FieldOffset(Offset = "0x8")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B7FF")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B800")]
	[FieldOffset(Offset = "0x18")]
	private EMatch.GroupMode _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B801")]
	[FieldOffset(Offset = "0x1C")]
	private List<MatchmakingPlayer> _003Cplayers_003Ek__BackingField;

	[Token(Token = "0x400B802")]
	[FieldOffset(Offset = "0x20")]
	private EMatch.GameMode _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B803")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cdifficulty_003Ek__BackingField;

	[Token(Token = "0x400B804")]
	[FieldOffset(Offset = "0x28")]
	private bool _003Cauto_group_003Ek__BackingField;

	[Token(Token = "0x400B805")]
	[FieldOffset(Offset = "0x2C")]
	private List<GroupMemberAccounts> _003Cgroup_members_003Ek__BackingField;

	[Token(Token = "0x400B806")]
	[FieldOffset(Offset = "0x30")]
	private string _003Cgroup_idc_003Ek__BackingField;

	[Token(Token = "0x400B807")]
	[FieldOffset(Offset = "0x34")]
	private EMatch.MatchMode _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B808")]
	[FieldOffset(Offset = "0x38")]
	private uint _003Crandom_map_id_003Ek__BackingField;

	[Token(Token = "0x400B809")]
	[FieldOffset(Offset = "0x40")]
	private ulong _003Cvoice_id_003Ek__BackingField;

	[Token(Token = "0x400B80A")]
	[FieldOffset(Offset = "0x48")]
	private List<string> _003Cworkshop_codes_003Ek__BackingField;

	[Token(Token = "0x400B80B")]
	[FieldOffset(Offset = "0x4C")]
	private bool _003Cis_workshop_team_contest_003Ek__BackingField;

	[Token(Token = "0x400B80C")]
	[FieldOffset(Offset = "0x50")]
	private uint[] _003Cworkshop_team_counts_003Ek__BackingField;

	[Token(Token = "0x400B80D")]
	[FieldOffset(Offset = "0x54")]
	private uint[] _003Cvalid_map_ids_003Ek__BackingField;

	[Token(Token = "0x17000BEB")]
	public uint[] map_ids
	{
		[Token(Token = "0x6008742")]
		[Address(RVA = "0x435C068", Offset = "0x435C068", VA = "0x435C068")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008743")]
		[Address(RVA = "0x435C070", Offset = "0x435C070", VA = "0x435C070")]
		set
		{
		}
	}

	[Token(Token = "0x17000BEC")]
	public ulong group_id
	{
		[Token(Token = "0x6008744")]
		[Address(RVA = "0x435C078", Offset = "0x435C078", VA = "0x435C078")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008745")]
		[Address(RVA = "0x435C080", Offset = "0x435C080", VA = "0x435C080")]
		set
		{
		}
	}

	[Token(Token = "0x17000BED")]
	public EMatch.GroupMode group_mode
	{
		[Token(Token = "0x6008746")]
		[Address(RVA = "0x435C090", Offset = "0x435C090", VA = "0x435C090")]
		get
		{
			return default(EMatch.GroupMode);
		}
		[Token(Token = "0x6008747")]
		[Address(RVA = "0x435C098", Offset = "0x435C098", VA = "0x435C098")]
		set
		{
		}
	}

	[Token(Token = "0x17000BEE")]
	public List<MatchmakingPlayer> players
	{
		[Token(Token = "0x6008748")]
		[Address(RVA = "0x435C0A0", Offset = "0x435C0A0", VA = "0x435C0A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008749")]
		[Address(RVA = "0x435C048", Offset = "0x435C048", VA = "0x435C048")]
		private set
		{
		}
	}

	[Token(Token = "0x17000BEF")]
	public EMatch.GameMode game_mode
	{
		[Token(Token = "0x600874A")]
		[Address(RVA = "0x435C0A8", Offset = "0x435C0A8", VA = "0x435C0A8")]
		get
		{
			return default(EMatch.GameMode);
		}
		[Token(Token = "0x600874B")]
		[Address(RVA = "0x435C0B0", Offset = "0x435C0B0", VA = "0x435C0B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF0")]
	public uint difficulty
	{
		[Token(Token = "0x600874C")]
		[Address(RVA = "0x435C0B8", Offset = "0x435C0B8", VA = "0x435C0B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600874D")]
		[Address(RVA = "0x435C0C0", Offset = "0x435C0C0", VA = "0x435C0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF1")]
	public bool auto_group
	{
		[Token(Token = "0x600874E")]
		[Address(RVA = "0x435C0C8", Offset = "0x435C0C8", VA = "0x435C0C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600874F")]
		[Address(RVA = "0x435C0D0", Offset = "0x435C0D0", VA = "0x435C0D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF2")]
	public List<GroupMemberAccounts> group_members
	{
		[Token(Token = "0x6008750")]
		[Address(RVA = "0x435C0D8", Offset = "0x435C0D8", VA = "0x435C0D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008751")]
		[Address(RVA = "0x435C050", Offset = "0x435C050", VA = "0x435C050")]
		private set
		{
		}
	}

	[Token(Token = "0x17000BF3")]
	public string group_idc
	{
		[Token(Token = "0x6008752")]
		[Address(RVA = "0x435C0E0", Offset = "0x435C0E0", VA = "0x435C0E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008753")]
		[Address(RVA = "0x435C058", Offset = "0x435C058", VA = "0x435C058")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF4")]
	public EMatch.MatchMode match_mode
	{
		[Token(Token = "0x6008754")]
		[Address(RVA = "0x435C0E8", Offset = "0x435C0E8", VA = "0x435C0E8")]
		get
		{
			return default(EMatch.MatchMode);
		}
		[Token(Token = "0x6008755")]
		[Address(RVA = "0x435C0F0", Offset = "0x435C0F0", VA = "0x435C0F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF5")]
	public uint random_map_id
	{
		[Token(Token = "0x6008756")]
		[Address(RVA = "0x435C0F8", Offset = "0x435C0F8", VA = "0x435C0F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008757")]
		[Address(RVA = "0x435C100", Offset = "0x435C100", VA = "0x435C100")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF6")]
	public ulong voice_id
	{
		[Token(Token = "0x6008758")]
		[Address(RVA = "0x435C108", Offset = "0x435C108", VA = "0x435C108")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008759")]
		[Address(RVA = "0x435C110", Offset = "0x435C110", VA = "0x435C110")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF7")]
	public List<string> workshop_codes
	{
		[Token(Token = "0x600875A")]
		[Address(RVA = "0x435C120", Offset = "0x435C120", VA = "0x435C120")]
		get
		{
			return null;
		}
		[Token(Token = "0x600875B")]
		[Address(RVA = "0x435C060", Offset = "0x435C060", VA = "0x435C060")]
		private set
		{
		}
	}

	[Token(Token = "0x17000BF8")]
	public bool is_workshop_team_contest
	{
		[Token(Token = "0x600875C")]
		[Address(RVA = "0x435C128", Offset = "0x435C128", VA = "0x435C128")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600875D")]
		[Address(RVA = "0x435C130", Offset = "0x435C130", VA = "0x435C130")]
		set
		{
		}
	}

	[Token(Token = "0x17000BF9")]
	public uint[] workshop_team_counts
	{
		[Token(Token = "0x600875E")]
		[Address(RVA = "0x435C138", Offset = "0x435C138", VA = "0x435C138")]
		get
		{
			return null;
		}
		[Token(Token = "0x600875F")]
		[Address(RVA = "0x435C140", Offset = "0x435C140", VA = "0x435C140")]
		set
		{
		}
	}

	[Token(Token = "0x17000BFA")]
	public uint[] valid_map_ids
	{
		[Token(Token = "0x6008760")]
		[Address(RVA = "0x435C148", Offset = "0x435C148", VA = "0x435C148")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008761")]
		[Address(RVA = "0x435C150", Offset = "0x435C150", VA = "0x435C150")]
		set
		{
		}
	}

	[Token(Token = "0x6008741")]
	[Address(RVA = "0x435BF0C", Offset = "0x435BF0C", VA = "0x435BF0C")]
	public MatchmakingGroupStartReq()
	{
	}
}
