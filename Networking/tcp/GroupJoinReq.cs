using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD3")]
public class GroupJoinReq
{
	[Token(Token = "0x400B694")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cparticipant_id_003Ek__BackingField;

	[Token(Token = "0x400B695")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cself_region_003Ek__BackingField;

	[Token(Token = "0x400B696")]
	[FieldOffset(Offset = "0x14")]
	private EGroup.JoinFromType _003Cfrom_type_003Ek__BackingField;

	[Token(Token = "0x400B697")]
	[FieldOffset(Offset = "0x18")]
	private EGroup.InviteeType _003Ctarget_type_003Ek__BackingField;

	[Token(Token = "0x400B698")]
	[FieldOffset(Offset = "0x1C")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B699")]
	[FieldOffset(Offset = "0x20")]
	private string _003Cnickname_003Ek__BackingField;

	[Token(Token = "0x400B69A")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Crank_003Ek__BackingField;

	[Token(Token = "0x400B69B")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Cranking_points_003Ek__BackingField;

	[Token(Token = "0x400B69C")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cemulator_score_003Ek__BackingField;

	[Token(Token = "0x400B69D")]
	[FieldOffset(Offset = "0x30")]
	private string _003Ccountry_code_003Ek__BackingField;

	[Token(Token = "0x400B69E")]
	[FieldOffset(Offset = "0x34")]
	private string _003Csignature_md5_003Ek__BackingField;

	[Token(Token = "0x400B69F")]
	[FieldOffset(Offset = "0x38")]
	private uint _003Cusing_version_003Ek__BackingField;

	[Token(Token = "0x400B6A0")]
	[FieldOffset(Offset = "0x40")]
	private ulong _003Cpartic_group_id_003Ek__BackingField;

	[Token(Token = "0x400B6A1")]
	[FieldOffset(Offset = "0x48")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400B6A2")]
	[FieldOffset(Offset = "0x4C")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x400B6A3")]
	[FieldOffset(Offset = "0x50")]
	private uint _003Ccs_rank_003Ek__BackingField;

	[Token(Token = "0x400B6A4")]
	[FieldOffset(Offset = "0x54")]
	private uint _003Ccs_ranking_points_003Ek__BackingField;

	[Token(Token = "0x400B6A5")]
	[FieldOffset(Offset = "0x58")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B6A6")]
	[FieldOffset(Offset = "0x5C")]
	private uint _003Cpeak_rank_pos_003Ek__BackingField;

	[Token(Token = "0x400B6A7")]
	[FieldOffset(Offset = "0x60")]
	private uint _003Ccs_peak_rank_pos_003Ek__BackingField;

	[Token(Token = "0x17000AFB")]
	public ulong participant_id
	{
		[Token(Token = "0x6008524")]
		[Address(RVA = "0x33EAC20", Offset = "0x33EAC20", VA = "0x33EAC20")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008525")]
		[Address(RVA = "0x33EAC28", Offset = "0x33EAC28", VA = "0x33EAC28")]
		set
		{
		}
	}

	[Token(Token = "0x17000AFC")]
	public string self_region
	{
		[Token(Token = "0x6008526")]
		[Address(RVA = "0x33EAC38", Offset = "0x33EAC38", VA = "0x33EAC38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008527")]
		[Address(RVA = "0x33EABF8", Offset = "0x33EABF8", VA = "0x33EABF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000AFD")]
	public EGroup.JoinFromType from_type
	{
		[Token(Token = "0x6008528")]
		[Address(RVA = "0x33EAC40", Offset = "0x33EAC40", VA = "0x33EAC40")]
		get
		{
			return default(EGroup.JoinFromType);
		}
		[Token(Token = "0x6008529")]
		[Address(RVA = "0x33EAC48", Offset = "0x33EAC48", VA = "0x33EAC48")]
		set
		{
		}
	}

	[Token(Token = "0x17000AFE")]
	public EGroup.InviteeType target_type
	{
		[Token(Token = "0x600852A")]
		[Address(RVA = "0x33EAC50", Offset = "0x33EAC50", VA = "0x33EAC50")]
		get
		{
			return default(EGroup.InviteeType);
		}
		[Token(Token = "0x600852B")]
		[Address(RVA = "0x33EAC58", Offset = "0x33EAC58", VA = "0x33EAC58")]
		set
		{
		}
	}

	[Token(Token = "0x17000AFF")]
	public uint[] available_maps
	{
		[Token(Token = "0x600852C")]
		[Address(RVA = "0x33EAC60", Offset = "0x33EAC60", VA = "0x33EAC60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600852D")]
		[Address(RVA = "0x33EAC68", Offset = "0x33EAC68", VA = "0x33EAC68")]
		set
		{
		}
	}

	[Token(Token = "0x17000B00")]
	public string nickname
	{
		[Token(Token = "0x600852E")]
		[Address(RVA = "0x33EAC70", Offset = "0x33EAC70", VA = "0x33EAC70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600852F")]
		[Address(RVA = "0x33EAC00", Offset = "0x33EAC00", VA = "0x33EAC00")]
		set
		{
		}
	}

	[Token(Token = "0x17000B01")]
	public uint rank
	{
		[Token(Token = "0x6008530")]
		[Address(RVA = "0x33EAC78", Offset = "0x33EAC78", VA = "0x33EAC78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008531")]
		[Address(RVA = "0x33EAC80", Offset = "0x33EAC80", VA = "0x33EAC80")]
		set
		{
		}
	}

	[Token(Token = "0x17000B02")]
	public uint ranking_points
	{
		[Token(Token = "0x6008532")]
		[Address(RVA = "0x33EAC88", Offset = "0x33EAC88", VA = "0x33EAC88")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008533")]
		[Address(RVA = "0x33EAC90", Offset = "0x33EAC90", VA = "0x33EAC90")]
		set
		{
		}
	}

	[Token(Token = "0x17000B03")]
	public uint emulator_score
	{
		[Token(Token = "0x6008534")]
		[Address(RVA = "0x33EAC98", Offset = "0x33EAC98", VA = "0x33EAC98")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008535")]
		[Address(RVA = "0x33EACA0", Offset = "0x33EACA0", VA = "0x33EACA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B04")]
	public string country_code
	{
		[Token(Token = "0x6008536")]
		[Address(RVA = "0x33EACA8", Offset = "0x33EACA8", VA = "0x33EACA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008537")]
		[Address(RVA = "0x33EAC08", Offset = "0x33EAC08", VA = "0x33EAC08")]
		set
		{
		}
	}

	[Token(Token = "0x17000B05")]
	public string signature_md5
	{
		[Token(Token = "0x6008538")]
		[Address(RVA = "0x33EACB0", Offset = "0x33EACB0", VA = "0x33EACB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008539")]
		[Address(RVA = "0x33EAC10", Offset = "0x33EAC10", VA = "0x33EAC10")]
		set
		{
		}
	}

	[Token(Token = "0x17000B06")]
	public uint using_version
	{
		[Token(Token = "0x600853A")]
		[Address(RVA = "0x33EACB8", Offset = "0x33EACB8", VA = "0x33EACB8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600853B")]
		[Address(RVA = "0x33EACC0", Offset = "0x33EACC0", VA = "0x33EACC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B07")]
	public ulong partic_group_id
	{
		[Token(Token = "0x600853C")]
		[Address(RVA = "0x33EACC8", Offset = "0x33EACC8", VA = "0x33EACC8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600853D")]
		[Address(RVA = "0x33EACD0", Offset = "0x33EACD0", VA = "0x33EACD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B08")]
	public uint system_platform
	{
		[Token(Token = "0x600853E")]
		[Address(RVA = "0x33EACE0", Offset = "0x33EACE0", VA = "0x33EACE0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600853F")]
		[Address(RVA = "0x33EACE8", Offset = "0x33EACE8", VA = "0x33EACE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B09")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x6008540")]
		[Address(RVA = "0x33EACF0", Offset = "0x33EACF0", VA = "0x33EACF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008541")]
		[Address(RVA = "0x33EACF8", Offset = "0x33EACF8", VA = "0x33EACF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000B0A")]
	public uint cs_rank
	{
		[Token(Token = "0x6008542")]
		[Address(RVA = "0x33EAD00", Offset = "0x33EAD00", VA = "0x33EAD00")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008543")]
		[Address(RVA = "0x33EAD08", Offset = "0x33EAD08", VA = "0x33EAD08")]
		set
		{
		}
	}

	[Token(Token = "0x17000B0B")]
	public uint cs_ranking_points
	{
		[Token(Token = "0x6008544")]
		[Address(RVA = "0x33EAD10", Offset = "0x33EAD10", VA = "0x33EAD10")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008545")]
		[Address(RVA = "0x33EAD18", Offset = "0x33EAD18", VA = "0x33EAD18")]
		set
		{
		}
	}

	[Token(Token = "0x17000B0C")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x6008546")]
		[Address(RVA = "0x33EAD20", Offset = "0x33EAD20", VA = "0x33EAD20")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008547")]
		[Address(RVA = "0x33EAC18", Offset = "0x33EAC18", VA = "0x33EAC18")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B0D")]
	public uint peak_rank_pos
	{
		[Token(Token = "0x6008548")]
		[Address(RVA = "0x33EAD28", Offset = "0x33EAD28", VA = "0x33EAD28")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008549")]
		[Address(RVA = "0x33EAD30", Offset = "0x33EAD30", VA = "0x33EAD30")]
		set
		{
		}
	}

	[Token(Token = "0x17000B0E")]
	public uint cs_peak_rank_pos
	{
		[Token(Token = "0x600854A")]
		[Address(RVA = "0x33EAD38", Offset = "0x33EAD38", VA = "0x33EAD38")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600854B")]
		[Address(RVA = "0x33EAD40", Offset = "0x33EAD40", VA = "0x33EAD40")]
		set
		{
		}
	}

	[Token(Token = "0x6008523")]
	[Address(RVA = "0x33EAB00", Offset = "0x33EAB00", VA = "0x33EAB00")]
	public GroupJoinReq()
	{
	}
}
