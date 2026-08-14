using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE7")]
public class GroupMemberInfo
{
	[Token(Token = "0x400B708")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B709")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cnickname_003Ek__BackingField;

	[Token(Token = "0x400B70A")]
	[FieldOffset(Offset = "0x14")]
	private string _003Cregion_003Ek__BackingField;

	[Token(Token = "0x400B70B")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cjoin_time_003Ek__BackingField;

	[Token(Token = "0x400B70C")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Clevel_003Ek__BackingField;

	[Token(Token = "0x400B70D")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cavatar_id_003Ek__BackingField;

	[Token(Token = "0x400B70E")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Cskin_color_003Ek__BackingField;

	[Token(Token = "0x400B70F")]
	[FieldOffset(Offset = "0x2C")]
	private uint[] _003Cclothes_003Ek__BackingField;

	[Token(Token = "0x400B710")]
	[FieldOffset(Offset = "0x30")]
	private bool _003Cready_003Ek__BackingField;

	[Token(Token = "0x400B711")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Crank_003Ek__BackingField;

	[Token(Token = "0x400B712")]
	[FieldOffset(Offset = "0x38")]
	private uint _003Cranking_points_003Ek__BackingField;

	[Token(Token = "0x400B713")]
	[FieldOffset(Offset = "0x3C")]
	private uint _003Cbanner_id_003Ek__BackingField;

	[Token(Token = "0x400B714")]
	[FieldOffset(Offset = "0x40")]
	private uint _003Chead_pic_003Ek__BackingField;

	[Token(Token = "0x400B715")]
	[FieldOffset(Offset = "0x44")]
	private uint _003Crole_003Ek__BackingField;

	[Token(Token = "0x400B716")]
	[FieldOffset(Offset = "0x48")]
	private uint[] _003Cshows_003Ek__BackingField;

	[Token(Token = "0x400B717")]
	[FieldOffset(Offset = "0x4C")]
	private GroupMemberPetInfo _003Cpet_info_003Ek__BackingField;

	[Token(Token = "0x400B718")]
	[FieldOffset(Offset = "0x50")]
	private uint _003Cpve_weapon_id_003Ek__BackingField;

	[Token(Token = "0x400B719")]
	[FieldOffset(Offset = "0x54")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B71A")]
	[FieldOffset(Offset = "0x58")]
	private uint _003Ccs_rank_003Ek__BackingField;

	[Token(Token = "0x400B71B")]
	[FieldOffset(Offset = "0x5C")]
	private uint _003Ccs_ranking_points_003Ek__BackingField;

	[Token(Token = "0x400B71C")]
	[FieldOffset(Offset = "0x60")]
	private uint _003Cpin_id_003Ek__BackingField;

	[Token(Token = "0x400B71D")]
	[FieldOffset(Offset = "0x64")]
	private bool _003Cis_cs_ranking_ban_003Ek__BackingField;

	[Token(Token = "0x400B71E")]
	[FieldOffset(Offset = "0x68")]
	private List<IntimacyRelation> _003Cintimacy_relations_003Ek__BackingField;

	[Token(Token = "0x400B71F")]
	[FieldOffset(Offset = "0x6C")]
	private uint _003Cusing_version_003Ek__BackingField;

	[Token(Token = "0x400B720")]
	[FieldOffset(Offset = "0x70")]
	private bool _003Cis_emulator_003Ek__BackingField;

	[Token(Token = "0x400B721")]
	[FieldOffset(Offset = "0x74")]
	private uint _003Cgame_bag_show_003Ek__BackingField;

	[Token(Token = "0x400B722")]
	[FieldOffset(Offset = "0x78")]
	private uint _003Cpeak_rank_pos_003Ek__BackingField;

	[Token(Token = "0x400B723")]
	[FieldOffset(Offset = "0x7C")]
	private uint _003Ccs_peak_rank_pos_003Ek__BackingField;

	[Token(Token = "0x400B724")]
	[FieldOffset(Offset = "0x80")]
	private uint _003Cperiodic_rank_003Ek__BackingField;

	[Token(Token = "0x400B725")]
	[FieldOffset(Offset = "0x84")]
	private uint _003Cperiodic_ranking_points_003Ek__BackingField;

	[Token(Token = "0x400B726")]
	[FieldOffset(Offset = "0x88")]
	private List<CreditPunishInfo> _003Ccredit_punish_info_003Ek__BackingField;

	[Token(Token = "0x400B727")]
	[FieldOffset(Offset = "0x8C")]
	private EGroup.PlayerPatchOptionalResStatus _003Cpatch_optional_res_status_003Ek__BackingField;

	[Token(Token = "0x400B728")]
	[FieldOffset(Offset = "0x90")]
	private uint _003Cplatform_type_003Ek__BackingField;

	[Token(Token = "0x17000B6F")]
	public ulong account_id
	{
		[Token(Token = "0x6008620")]
		[Address(RVA = "0x33EB230", Offset = "0x33EB230", VA = "0x33EB230")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008621")]
		[Address(RVA = "0x33EB238", Offset = "0x33EB238", VA = "0x33EB238")]
		set
		{
		}
	}

	[Token(Token = "0x17000B70")]
	public string nickname
	{
		[Token(Token = "0x6008622")]
		[Address(RVA = "0x33EB248", Offset = "0x33EB248", VA = "0x33EB248")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008623")]
		[Address(RVA = "0x33EB210", Offset = "0x33EB210", VA = "0x33EB210")]
		set
		{
		}
	}

	[Token(Token = "0x17000B71")]
	public string region
	{
		[Token(Token = "0x6008624")]
		[Address(RVA = "0x33EB250", Offset = "0x33EB250", VA = "0x33EB250")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008625")]
		[Address(RVA = "0x33EB218", Offset = "0x33EB218", VA = "0x33EB218")]
		set
		{
		}
	}

	[Token(Token = "0x17000B72")]
	public ulong join_time
	{
		[Token(Token = "0x6008626")]
		[Address(RVA = "0x33EB258", Offset = "0x33EB258", VA = "0x33EB258")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008627")]
		[Address(RVA = "0x33EB260", Offset = "0x33EB260", VA = "0x33EB260")]
		set
		{
		}
	}

	[Token(Token = "0x17000B73")]
	public uint level
	{
		[Token(Token = "0x6008628")]
		[Address(RVA = "0x33EB270", Offset = "0x33EB270", VA = "0x33EB270")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008629")]
		[Address(RVA = "0x33EB278", Offset = "0x33EB278", VA = "0x33EB278")]
		set
		{
		}
	}

	[Token(Token = "0x17000B74")]
	public uint avatar_id
	{
		[Token(Token = "0x600862A")]
		[Address(RVA = "0x33EB280", Offset = "0x33EB280", VA = "0x33EB280")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600862B")]
		[Address(RVA = "0x33EB288", Offset = "0x33EB288", VA = "0x33EB288")]
		set
		{
		}
	}

	[Token(Token = "0x17000B75")]
	public uint skin_color
	{
		[Token(Token = "0x600862C")]
		[Address(RVA = "0x33EB290", Offset = "0x33EB290", VA = "0x33EB290")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600862D")]
		[Address(RVA = "0x33EB298", Offset = "0x33EB298", VA = "0x33EB298")]
		set
		{
		}
	}

	[Token(Token = "0x17000B76")]
	public uint[] clothes
	{
		[Token(Token = "0x600862E")]
		[Address(RVA = "0x33EB2A0", Offset = "0x33EB2A0", VA = "0x33EB2A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600862F")]
		[Address(RVA = "0x33EB2A8", Offset = "0x33EB2A8", VA = "0x33EB2A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B77")]
	public bool ready
	{
		[Token(Token = "0x6008630")]
		[Address(RVA = "0x33EB2B0", Offset = "0x33EB2B0", VA = "0x33EB2B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008631")]
		[Address(RVA = "0x33EB2B8", Offset = "0x33EB2B8", VA = "0x33EB2B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B78")]
	public uint rank
	{
		[Token(Token = "0x6008632")]
		[Address(RVA = "0x33EB2C0", Offset = "0x33EB2C0", VA = "0x33EB2C0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008633")]
		[Address(RVA = "0x33EB2C8", Offset = "0x33EB2C8", VA = "0x33EB2C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B79")]
	public uint ranking_points
	{
		[Token(Token = "0x6008634")]
		[Address(RVA = "0x33EB2D0", Offset = "0x33EB2D0", VA = "0x33EB2D0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008635")]
		[Address(RVA = "0x33EB2D8", Offset = "0x33EB2D8", VA = "0x33EB2D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B7A")]
	public uint banner_id
	{
		[Token(Token = "0x6008636")]
		[Address(RVA = "0x33EB2E0", Offset = "0x33EB2E0", VA = "0x33EB2E0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008637")]
		[Address(RVA = "0x33EB2E8", Offset = "0x33EB2E8", VA = "0x33EB2E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B7B")]
	public uint head_pic
	{
		[Token(Token = "0x6008638")]
		[Address(RVA = "0x33EB2F0", Offset = "0x33EB2F0", VA = "0x33EB2F0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008639")]
		[Address(RVA = "0x33EB2F8", Offset = "0x33EB2F8", VA = "0x33EB2F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B7C")]
	public uint role
	{
		[Token(Token = "0x600863A")]
		[Address(RVA = "0x33EB300", Offset = "0x33EB300", VA = "0x33EB300")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600863B")]
		[Address(RVA = "0x33EB308", Offset = "0x33EB308", VA = "0x33EB308")]
		set
		{
		}
	}

	[Token(Token = "0x17000B7D")]
	public uint[] shows
	{
		[Token(Token = "0x600863C")]
		[Address(RVA = "0x33EB310", Offset = "0x33EB310", VA = "0x33EB310")]
		get
		{
			return null;
		}
		[Token(Token = "0x600863D")]
		[Address(RVA = "0x33EB318", Offset = "0x33EB318", VA = "0x33EB318")]
		set
		{
		}
	}

	[Token(Token = "0x17000B7E")]
	public GroupMemberPetInfo pet_info
	{
		[Token(Token = "0x600863E")]
		[Address(RVA = "0x33EB320", Offset = "0x33EB320", VA = "0x33EB320")]
		get
		{
			return null;
		}
		[Token(Token = "0x600863F")]
		[Address(RVA = "0x33EB328", Offset = "0x33EB328", VA = "0x33EB328")]
		set
		{
		}
	}

	[Token(Token = "0x17000B7F")]
	public uint pve_weapon_id
	{
		[Token(Token = "0x6008640")]
		[Address(RVA = "0x33EB330", Offset = "0x33EB330", VA = "0x33EB330")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008641")]
		[Address(RVA = "0x33EB338", Offset = "0x33EB338", VA = "0x33EB338")]
		set
		{
		}
	}

	[Token(Token = "0x17000B80")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008642")]
		[Address(RVA = "0x33EB340", Offset = "0x33EB340", VA = "0x33EB340")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008643")]
		[Address(RVA = "0x33EB348", Offset = "0x33EB348", VA = "0x33EB348")]
		set
		{
		}
	}

	[Token(Token = "0x17000B81")]
	public uint cs_rank
	{
		[Token(Token = "0x6008644")]
		[Address(RVA = "0x33EB350", Offset = "0x33EB350", VA = "0x33EB350")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008645")]
		[Address(RVA = "0x33EB358", Offset = "0x33EB358", VA = "0x33EB358")]
		set
		{
		}
	}

	[Token(Token = "0x17000B82")]
	public uint cs_ranking_points
	{
		[Token(Token = "0x6008646")]
		[Address(RVA = "0x33EB360", Offset = "0x33EB360", VA = "0x33EB360")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008647")]
		[Address(RVA = "0x33EB368", Offset = "0x33EB368", VA = "0x33EB368")]
		set
		{
		}
	}

	[Token(Token = "0x17000B83")]
	public uint pin_id
	{
		[Token(Token = "0x6008648")]
		[Address(RVA = "0x33EB370", Offset = "0x33EB370", VA = "0x33EB370")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008649")]
		[Address(RVA = "0x33EB378", Offset = "0x33EB378", VA = "0x33EB378")]
		set
		{
		}
	}

	[Token(Token = "0x17000B84")]
	public bool is_cs_ranking_ban
	{
		[Token(Token = "0x600864A")]
		[Address(RVA = "0x33EB380", Offset = "0x33EB380", VA = "0x33EB380")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600864B")]
		[Address(RVA = "0x33EB388", Offset = "0x33EB388", VA = "0x33EB388")]
		set
		{
		}
	}

	[Token(Token = "0x17000B85")]
	public List<IntimacyRelation> intimacy_relations
	{
		[Token(Token = "0x600864C")]
		[Address(RVA = "0x33EB390", Offset = "0x33EB390", VA = "0x33EB390")]
		get
		{
			return null;
		}
		[Token(Token = "0x600864D")]
		[Address(RVA = "0x33EB220", Offset = "0x33EB220", VA = "0x33EB220")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B86")]
	public uint using_version
	{
		[Token(Token = "0x600864E")]
		[Address(RVA = "0x33EB398", Offset = "0x33EB398", VA = "0x33EB398")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600864F")]
		[Address(RVA = "0x33EB3A0", Offset = "0x33EB3A0", VA = "0x33EB3A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B87")]
	public bool is_emulator
	{
		[Token(Token = "0x6008650")]
		[Address(RVA = "0x33EB3A8", Offset = "0x33EB3A8", VA = "0x33EB3A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008651")]
		[Address(RVA = "0x33EB3B0", Offset = "0x33EB3B0", VA = "0x33EB3B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B88")]
	public uint game_bag_show
	{
		[Token(Token = "0x6008652")]
		[Address(RVA = "0x33EB3B8", Offset = "0x33EB3B8", VA = "0x33EB3B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008653")]
		[Address(RVA = "0x33EB3C0", Offset = "0x33EB3C0", VA = "0x33EB3C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B89")]
	public uint peak_rank_pos
	{
		[Token(Token = "0x6008654")]
		[Address(RVA = "0x33EB3C8", Offset = "0x33EB3C8", VA = "0x33EB3C8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008655")]
		[Address(RVA = "0x33EB3D0", Offset = "0x33EB3D0", VA = "0x33EB3D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B8A")]
	public uint cs_peak_rank_pos
	{
		[Token(Token = "0x6008656")]
		[Address(RVA = "0x33EB3D8", Offset = "0x33EB3D8", VA = "0x33EB3D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008657")]
		[Address(RVA = "0x33EB3E0", Offset = "0x33EB3E0", VA = "0x33EB3E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B8B")]
	public uint periodic_rank
	{
		[Token(Token = "0x6008658")]
		[Address(RVA = "0x33EB3E8", Offset = "0x33EB3E8", VA = "0x33EB3E8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008659")]
		[Address(RVA = "0x33EB3F0", Offset = "0x33EB3F0", VA = "0x33EB3F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B8C")]
	public uint periodic_ranking_points
	{
		[Token(Token = "0x600865A")]
		[Address(RVA = "0x33EB3F8", Offset = "0x33EB3F8", VA = "0x33EB3F8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600865B")]
		[Address(RVA = "0x33EB400", Offset = "0x33EB400", VA = "0x33EB400")]
		set
		{
		}
	}

	[Token(Token = "0x17000B8D")]
	public List<CreditPunishInfo> credit_punish_info
	{
		[Token(Token = "0x600865C")]
		[Address(RVA = "0x33EB408", Offset = "0x33EB408", VA = "0x33EB408")]
		get
		{
			return null;
		}
		[Token(Token = "0x600865D")]
		[Address(RVA = "0x33EB228", Offset = "0x33EB228", VA = "0x33EB228")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B8E")]
	public EGroup.PlayerPatchOptionalResStatus patch_optional_res_status
	{
		[Token(Token = "0x600865E")]
		[Address(RVA = "0x33EB410", Offset = "0x33EB410", VA = "0x33EB410")]
		get
		{
			return default(EGroup.PlayerPatchOptionalResStatus);
		}
		[Token(Token = "0x600865F")]
		[Address(RVA = "0x33EB418", Offset = "0x33EB418", VA = "0x33EB418")]
		set
		{
		}
	}

	[Token(Token = "0x17000B8F")]
	public uint platform_type
	{
		[Token(Token = "0x6008660")]
		[Address(RVA = "0x33EB420", Offset = "0x33EB420", VA = "0x33EB420")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008661")]
		[Address(RVA = "0x33EB428", Offset = "0x33EB428", VA = "0x33EB428")]
		set
		{
		}
	}

	[Token(Token = "0x600861F")]
	[Address(RVA = "0x33EB0FC", Offset = "0x33EB0FC", VA = "0x33EB0FC")]
	public GroupMemberInfo()
	{
	}
}
