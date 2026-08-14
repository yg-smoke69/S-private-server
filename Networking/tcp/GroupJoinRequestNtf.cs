using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD5")]
public class GroupJoinRequestNtf
{
	[Token(Token = "0x400B6AB")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cjoiner_id_003Ek__BackingField;

	[Token(Token = "0x400B6AC")]
	[FieldOffset(Offset = "0x10")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B6AD")]
	[FieldOffset(Offset = "0x14")]
	private string _003Cnickname_003Ek__BackingField;

	[Token(Token = "0x400B6AE")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Crank_003Ek__BackingField;

	[Token(Token = "0x400B6AF")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cranking_points_003Ek__BackingField;

	[Token(Token = "0x400B6B0")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cemulator_score_003Ek__BackingField;

	[Token(Token = "0x400B6B1")]
	[FieldOffset(Offset = "0x24")]
	private string _003Ccountry_code_003Ek__BackingField;

	[Token(Token = "0x400B6B2")]
	[FieldOffset(Offset = "0x28")]
	private string _003Csignature_md5_003Ek__BackingField;

	[Token(Token = "0x400B6B3")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cusing_version_003Ek__BackingField;

	[Token(Token = "0x400B6B4")]
	[FieldOffset(Offset = "0x30")]
	private EGroup.InviteeType _003Ctarget_type_003Ek__BackingField;

	[Token(Token = "0x400B6B5")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Csystem_platform_003Ek__BackingField;

	[Token(Token = "0x400B6B6")]
	[FieldOffset(Offset = "0x38")]
	private MatchClientInfo _003Cclient_info_003Ek__BackingField;

	[Token(Token = "0x400B6B7")]
	[FieldOffset(Offset = "0x3C")]
	private uint _003Ccs_rank_003Ek__BackingField;

	[Token(Token = "0x400B6B8")]
	[FieldOffset(Offset = "0x40")]
	private uint _003Ccs_ranking_points_003Ek__BackingField;

	[Token(Token = "0x400B6B9")]
	[FieldOffset(Offset = "0x44")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B6BA")]
	[FieldOffset(Offset = "0x48")]
	private uint _003Cpeak_rank_pos_003Ek__BackingField;

	[Token(Token = "0x400B6BB")]
	[FieldOffset(Offset = "0x4C")]
	private uint _003Ccs_peak_rank_pos_003Ek__BackingField;

	[Token(Token = "0x17000B12")]
	public ulong joiner_id
	{
		[Token(Token = "0x6008554")]
		[Address(RVA = "0x33EAE54", Offset = "0x33EAE54", VA = "0x33EAE54")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008555")]
		[Address(RVA = "0x33EAE5C", Offset = "0x33EAE5C", VA = "0x33EAE5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B13")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008556")]
		[Address(RVA = "0x33EAE6C", Offset = "0x33EAE6C", VA = "0x33EAE6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008557")]
		[Address(RVA = "0x33EAE74", Offset = "0x33EAE74", VA = "0x33EAE74")]
		set
		{
		}
	}

	[Token(Token = "0x17000B14")]
	public string nickname
	{
		[Token(Token = "0x6008558")]
		[Address(RVA = "0x33EAE7C", Offset = "0x33EAE7C", VA = "0x33EAE7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008559")]
		[Address(RVA = "0x33EAE34", Offset = "0x33EAE34", VA = "0x33EAE34")]
		set
		{
		}
	}

	[Token(Token = "0x17000B15")]
	public uint rank
	{
		[Token(Token = "0x600855A")]
		[Address(RVA = "0x33EAE84", Offset = "0x33EAE84", VA = "0x33EAE84")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600855B")]
		[Address(RVA = "0x33EAE8C", Offset = "0x33EAE8C", VA = "0x33EAE8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B16")]
	public uint ranking_points
	{
		[Token(Token = "0x600855C")]
		[Address(RVA = "0x33EAE94", Offset = "0x33EAE94", VA = "0x33EAE94")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600855D")]
		[Address(RVA = "0x33EAE9C", Offset = "0x33EAE9C", VA = "0x33EAE9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B17")]
	public uint emulator_score
	{
		[Token(Token = "0x600855E")]
		[Address(RVA = "0x33EAEA4", Offset = "0x33EAEA4", VA = "0x33EAEA4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600855F")]
		[Address(RVA = "0x33EAEAC", Offset = "0x33EAEAC", VA = "0x33EAEAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B18")]
	public string country_code
	{
		[Token(Token = "0x6008560")]
		[Address(RVA = "0x33EAEB4", Offset = "0x33EAEB4", VA = "0x33EAEB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008561")]
		[Address(RVA = "0x33EAE3C", Offset = "0x33EAE3C", VA = "0x33EAE3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B19")]
	public string signature_md5
	{
		[Token(Token = "0x6008562")]
		[Address(RVA = "0x33EAEBC", Offset = "0x33EAEBC", VA = "0x33EAEBC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008563")]
		[Address(RVA = "0x33EAE44", Offset = "0x33EAE44", VA = "0x33EAE44")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1A")]
	public uint using_version
	{
		[Token(Token = "0x6008564")]
		[Address(RVA = "0x33EAEC4", Offset = "0x33EAEC4", VA = "0x33EAEC4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008565")]
		[Address(RVA = "0x33EAECC", Offset = "0x33EAECC", VA = "0x33EAECC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1B")]
	public EGroup.InviteeType target_type
	{
		[Token(Token = "0x6008566")]
		[Address(RVA = "0x33EAED4", Offset = "0x33EAED4", VA = "0x33EAED4")]
		get
		{
			return default(EGroup.InviteeType);
		}
		[Token(Token = "0x6008567")]
		[Address(RVA = "0x33EAEDC", Offset = "0x33EAEDC", VA = "0x33EAEDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1C")]
	public uint system_platform
	{
		[Token(Token = "0x6008568")]
		[Address(RVA = "0x33EAEE4", Offset = "0x33EAEE4", VA = "0x33EAEE4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008569")]
		[Address(RVA = "0x33EAEEC", Offset = "0x33EAEEC", VA = "0x33EAEEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1D")]
	public MatchClientInfo client_info
	{
		[Token(Token = "0x600856A")]
		[Address(RVA = "0x33EAEF4", Offset = "0x33EAEF4", VA = "0x33EAEF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600856B")]
		[Address(RVA = "0x33EAEFC", Offset = "0x33EAEFC", VA = "0x33EAEFC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1E")]
	public uint cs_rank
	{
		[Token(Token = "0x600856C")]
		[Address(RVA = "0x33EAF04", Offset = "0x33EAF04", VA = "0x33EAF04")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600856D")]
		[Address(RVA = "0x33EAF0C", Offset = "0x33EAF0C", VA = "0x33EAF0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B1F")]
	public uint cs_ranking_points
	{
		[Token(Token = "0x600856E")]
		[Address(RVA = "0x33EAF14", Offset = "0x33EAF14", VA = "0x33EAF14")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600856F")]
		[Address(RVA = "0x33EAF1C", Offset = "0x33EAF1C", VA = "0x33EAF1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B20")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x6008570")]
		[Address(RVA = "0x33EAF24", Offset = "0x33EAF24", VA = "0x33EAF24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008571")]
		[Address(RVA = "0x33EAE4C", Offset = "0x33EAE4C", VA = "0x33EAE4C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B21")]
	public uint peak_rank_pos
	{
		[Token(Token = "0x6008572")]
		[Address(RVA = "0x33EAF2C", Offset = "0x33EAF2C", VA = "0x33EAF2C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008573")]
		[Address(RVA = "0x33EAF34", Offset = "0x33EAF34", VA = "0x33EAF34")]
		set
		{
		}
	}

	[Token(Token = "0x17000B22")]
	public uint cs_peak_rank_pos
	{
		[Token(Token = "0x6008574")]
		[Address(RVA = "0x33EAF3C", Offset = "0x33EAF3C", VA = "0x33EAF3C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008575")]
		[Address(RVA = "0x33EAF44", Offset = "0x33EAF44", VA = "0x33EAF44")]
		set
		{
		}
	}

	[Token(Token = "0x6008553")]
	[Address(RVA = "0x33EAD48", Offset = "0x33EAD48", VA = "0x33EAD48")]
	public GroupJoinRequestNtf()
	{
	}
}
