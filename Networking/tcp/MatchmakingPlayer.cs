using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D24")]
public class MatchmakingPlayer
{
	[Token(Token = "0x400B823")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B824")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cconn_id_003Ek__BackingField;

	[Token(Token = "0x400B825")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B826")]
	[FieldOffset(Offset = "0x20")]
	private string _003Cnoti_region_003Ek__BackingField;

	[Token(Token = "0x400B827")]
	[FieldOffset(Offset = "0x24")]
	private AccountMatchInfo _003Cbasic_info_003Ek__BackingField;

	[Token(Token = "0x400B828")]
	[FieldOffset(Offset = "0x28")]
	private bool _003Cis_hacker_003Ek__BackingField;

	[Token(Token = "0x400B829")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cusing_version_003Ek__BackingField;

	[Token(Token = "0x400B82A")]
	[FieldOffset(Offset = "0x30")]
	private string _003Cip_region_003Ek__BackingField;

	[Token(Token = "0x400B82B")]
	[FieldOffset(Offset = "0x34")]
	private uint _003Cemulator_score_003Ek__BackingField;

	[Token(Token = "0x400B82C")]
	[FieldOffset(Offset = "0x38")]
	private uint _003Chacker_cdt_id_003Ek__BackingField;

	[Token(Token = "0x400B82D")]
	[FieldOffset(Offset = "0x3C")]
	private List<AccountIDCPingInfo> _003Cping_list_003Ek__BackingField;

	[Token(Token = "0x400B82E")]
	[FieldOffset(Offset = "0x40")]
	private string _003Cpre_group_idc_003Ek__BackingField;

	[Token(Token = "0x17000C10")]
	public ulong account_id
	{
		[Token(Token = "0x600878F")]
		[Address(RVA = "0x435C3C8", Offset = "0x435C3C8", VA = "0x435C3C8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008790")]
		[Address(RVA = "0x435C3D0", Offset = "0x435C3D0", VA = "0x435C3D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C11")]
	public ulong conn_id
	{
		[Token(Token = "0x6008791")]
		[Address(RVA = "0x435C3E0", Offset = "0x435C3E0", VA = "0x435C3E0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008792")]
		[Address(RVA = "0x435C3E8", Offset = "0x435C3E8", VA = "0x435C3E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C12")]
	public ulong group_id
	{
		[Token(Token = "0x6008793")]
		[Address(RVA = "0x435C3F8", Offset = "0x435C3F8", VA = "0x435C3F8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008794")]
		[Address(RVA = "0x435C400", Offset = "0x435C400", VA = "0x435C400")]
		set
		{
		}
	}

	[Token(Token = "0x17000C13")]
	public string noti_region
	{
		[Token(Token = "0x6008795")]
		[Address(RVA = "0x435C410", Offset = "0x435C410", VA = "0x435C410")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008796")]
		[Address(RVA = "0x435C3A8", Offset = "0x435C3A8", VA = "0x435C3A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C14")]
	public AccountMatchInfo basic_info
	{
		[Token(Token = "0x6008797")]
		[Address(RVA = "0x435C418", Offset = "0x435C418", VA = "0x435C418")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008798")]
		[Address(RVA = "0x435C420", Offset = "0x435C420", VA = "0x435C420")]
		set
		{
		}
	}

	[Token(Token = "0x17000C15")]
	public bool is_hacker
	{
		[Token(Token = "0x6008799")]
		[Address(RVA = "0x435C428", Offset = "0x435C428", VA = "0x435C428")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600879A")]
		[Address(RVA = "0x435C430", Offset = "0x435C430", VA = "0x435C430")]
		set
		{
		}
	}

	[Token(Token = "0x17000C16")]
	public uint using_version
	{
		[Token(Token = "0x600879B")]
		[Address(RVA = "0x435C438", Offset = "0x435C438", VA = "0x435C438")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600879C")]
		[Address(RVA = "0x435C440", Offset = "0x435C440", VA = "0x435C440")]
		set
		{
		}
	}

	[Token(Token = "0x17000C17")]
	public string ip_region
	{
		[Token(Token = "0x600879D")]
		[Address(RVA = "0x435C448", Offset = "0x435C448", VA = "0x435C448")]
		get
		{
			return null;
		}
		[Token(Token = "0x600879E")]
		[Address(RVA = "0x435C3B0", Offset = "0x435C3B0", VA = "0x435C3B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000C18")]
	public uint emulator_score
	{
		[Token(Token = "0x600879F")]
		[Address(RVA = "0x435C450", Offset = "0x435C450", VA = "0x435C450")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087A0")]
		[Address(RVA = "0x435C458", Offset = "0x435C458", VA = "0x435C458")]
		set
		{
		}
	}

	[Token(Token = "0x17000C19")]
	public uint hacker_cdt_id
	{
		[Token(Token = "0x60087A1")]
		[Address(RVA = "0x435C460", Offset = "0x435C460", VA = "0x435C460")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087A2")]
		[Address(RVA = "0x435C468", Offset = "0x435C468", VA = "0x435C468")]
		set
		{
		}
	}

	[Token(Token = "0x17000C1A")]
	public List<AccountIDCPingInfo> ping_list
	{
		[Token(Token = "0x60087A3")]
		[Address(RVA = "0x435C470", Offset = "0x435C470", VA = "0x435C470")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087A4")]
		[Address(RVA = "0x435C3B8", Offset = "0x435C3B8", VA = "0x435C3B8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000C1B")]
	public string pre_group_idc
	{
		[Token(Token = "0x60087A5")]
		[Address(RVA = "0x435C478", Offset = "0x435C478", VA = "0x435C478")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087A6")]
		[Address(RVA = "0x435C3C0", Offset = "0x435C3C0", VA = "0x435C3C0")]
		set
		{
		}
	}

	[Token(Token = "0x600878E")]
	[Address(RVA = "0x435C2AC", Offset = "0x435C2AC", VA = "0x435C2AC")]
	public MatchmakingPlayer()
	{
	}
}
