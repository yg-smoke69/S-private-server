using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001DAF")]
public class MatchPregameInfo
{
	[Token(Token = "0x400BC1F")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400BC20")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Chead_pic_003Ek__BackingField;

	[Token(Token = "0x400BC21")]
	[FieldOffset(Offset = "0x14")]
	private string _003Cnickname_003Ek__BackingField;

	[Token(Token = "0x400BC22")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cavatar_id_003Ek__BackingField;

	[Token(Token = "0x400BC23")]
	[FieldOffset(Offset = "0x1C")]
	private bool _003Chas_elite_pass_003Ek__BackingField;

	[Token(Token = "0x400BC24")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cbadge_cnt_003Ek__BackingField;

	[Token(Token = "0x400BC25")]
	[FieldOffset(Offset = "0x24")]
	private uint _003Cbadge_id_003Ek__BackingField;

	[Token(Token = "0x400BC26")]
	[FieldOffset(Offset = "0x28")]
	private List<BattleTagInfo> _003Cbattle_tags_003Ek__BackingField;

	[Token(Token = "0x400BC27")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Ccs_rank_003Ek__BackingField;

	[Token(Token = "0x400BC28")]
	[FieldOffset(Offset = "0x30")]
	private uint _003Ccs_ranking_points_003Ek__BackingField;

	[Token(Token = "0x400BC29")]
	[FieldOffset(Offset = "0x34")]
	private uint[] _003Ccs_heroic_seasons_003Ek__BackingField;

	[Token(Token = "0x400BC2A")]
	[FieldOffset(Offset = "0x38")]
	private StatsInfo _003Ccs_ranking_stats_003Ek__BackingField;

	[Token(Token = "0x400BC2B")]
	[FieldOffset(Offset = "0x3C")]
	private AccountPrefersInfo _003Cprefers_003Ek__BackingField;

	[Token(Token = "0x17000EC5")]
	public ulong account_id
	{
		[Token(Token = "0x6008D64")]
		[Address(RVA = "0x435B558", Offset = "0x435B558", VA = "0x435B558")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008D65")]
		[Address(RVA = "0x435B560", Offset = "0x435B560", VA = "0x435B560")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC6")]
	public uint head_pic
	{
		[Token(Token = "0x6008D66")]
		[Address(RVA = "0x435B570", Offset = "0x435B570", VA = "0x435B570")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D67")]
		[Address(RVA = "0x435B578", Offset = "0x435B578", VA = "0x435B578")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC7")]
	public string nickname
	{
		[Token(Token = "0x6008D68")]
		[Address(RVA = "0x435B580", Offset = "0x435B580", VA = "0x435B580")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D69")]
		[Address(RVA = "0x435B548", Offset = "0x435B548", VA = "0x435B548")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC8")]
	public uint avatar_id
	{
		[Token(Token = "0x6008D6A")]
		[Address(RVA = "0x435B588", Offset = "0x435B588", VA = "0x435B588")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D6B")]
		[Address(RVA = "0x435B590", Offset = "0x435B590", VA = "0x435B590")]
		set
		{
		}
	}

	[Token(Token = "0x17000EC9")]
	public bool has_elite_pass
	{
		[Token(Token = "0x6008D6C")]
		[Address(RVA = "0x435B598", Offset = "0x435B598", VA = "0x435B598")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008D6D")]
		[Address(RVA = "0x435B5A0", Offset = "0x435B5A0", VA = "0x435B5A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000ECA")]
	public uint badge_cnt
	{
		[Token(Token = "0x6008D6E")]
		[Address(RVA = "0x435B5A8", Offset = "0x435B5A8", VA = "0x435B5A8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D6F")]
		[Address(RVA = "0x435B5B0", Offset = "0x435B5B0", VA = "0x435B5B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000ECB")]
	public uint badge_id
	{
		[Token(Token = "0x6008D70")]
		[Address(RVA = "0x435B5B8", Offset = "0x435B5B8", VA = "0x435B5B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D71")]
		[Address(RVA = "0x435B5C0", Offset = "0x435B5C0", VA = "0x435B5C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000ECC")]
	public List<BattleTagInfo> battle_tags
	{
		[Token(Token = "0x6008D72")]
		[Address(RVA = "0x435B5C8", Offset = "0x435B5C8", VA = "0x435B5C8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D73")]
		[Address(RVA = "0x435B550", Offset = "0x435B550", VA = "0x435B550")]
		private set
		{
		}
	}

	[Token(Token = "0x17000ECD")]
	public uint cs_rank
	{
		[Token(Token = "0x6008D74")]
		[Address(RVA = "0x435B5D0", Offset = "0x435B5D0", VA = "0x435B5D0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D75")]
		[Address(RVA = "0x435B5D8", Offset = "0x435B5D8", VA = "0x435B5D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000ECE")]
	public uint cs_ranking_points
	{
		[Token(Token = "0x6008D76")]
		[Address(RVA = "0x435B5E0", Offset = "0x435B5E0", VA = "0x435B5E0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008D77")]
		[Address(RVA = "0x435B5E8", Offset = "0x435B5E8", VA = "0x435B5E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000ECF")]
	public uint[] cs_heroic_seasons
	{
		[Token(Token = "0x6008D78")]
		[Address(RVA = "0x435B5F0", Offset = "0x435B5F0", VA = "0x435B5F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D79")]
		[Address(RVA = "0x435B5F8", Offset = "0x435B5F8", VA = "0x435B5F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000ED0")]
	public StatsInfo cs_ranking_stats
	{
		[Token(Token = "0x6008D7A")]
		[Address(RVA = "0x435B600", Offset = "0x435B600", VA = "0x435B600")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D7B")]
		[Address(RVA = "0x435B608", Offset = "0x435B608", VA = "0x435B608")]
		set
		{
		}
	}

	[Token(Token = "0x17000ED1")]
	public AccountPrefersInfo prefers
	{
		[Token(Token = "0x6008D7C")]
		[Address(RVA = "0x435B610", Offset = "0x435B610", VA = "0x435B610")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008D7D")]
		[Address(RVA = "0x435B618", Offset = "0x435B618", VA = "0x435B618")]
		set
		{
		}
	}

	[Token(Token = "0x6008D63")]
	[Address(RVA = "0x435B474", Offset = "0x435B474", VA = "0x435B474")]
	public MatchPregameInfo()
	{
	}
}
