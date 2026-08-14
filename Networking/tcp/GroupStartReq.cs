using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CDD")]
public class GroupStartReq
{
	[Token(Token = "0x400B6CE")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6CF")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cworkshop_group_mode_003Ek__BackingField;

	[Token(Token = "0x400B6D0")]
	[FieldOffset(Offset = "0x14")]
	private List<string> _003Cworkshop_codes_003Ek__BackingField;

	[Token(Token = "0x400B6D1")]
	[FieldOffset(Offset = "0x18")]
	private bool _003Cis_workshop_team_contest_003Ek__BackingField;

	[Token(Token = "0x400B6D2")]
	[FieldOffset(Offset = "0x1C")]
	private string _003Cworkshop_name_003Ek__BackingField;

	[Token(Token = "0x400B6D3")]
	[FieldOffset(Offset = "0x20")]
	private uint[] _003Cworkshop_team_counts_003Ek__BackingField;

	[Token(Token = "0x17000B35")]
	public ulong group_id
	{
		[Token(Token = "0x60085A2")]
		[Address(RVA = "0x33EB76C", Offset = "0x33EB76C", VA = "0x33EB76C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085A3")]
		[Address(RVA = "0x33EB774", Offset = "0x33EB774", VA = "0x33EB774")]
		set
		{
		}
	}

	[Token(Token = "0x17000B36")]
	public uint workshop_group_mode
	{
		[Token(Token = "0x60085A4")]
		[Address(RVA = "0x33EB784", Offset = "0x33EB784", VA = "0x33EB784")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60085A5")]
		[Address(RVA = "0x33EB78C", Offset = "0x33EB78C", VA = "0x33EB78C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B37")]
	public List<string> workshop_codes
	{
		[Token(Token = "0x60085A6")]
		[Address(RVA = "0x33EB794", Offset = "0x33EB794", VA = "0x33EB794")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085A7")]
		[Address(RVA = "0x33EB75C", Offset = "0x33EB75C", VA = "0x33EB75C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000B38")]
	public bool is_workshop_team_contest
	{
		[Token(Token = "0x60085A8")]
		[Address(RVA = "0x33EB79C", Offset = "0x33EB79C", VA = "0x33EB79C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085A9")]
		[Address(RVA = "0x33EB7A4", Offset = "0x33EB7A4", VA = "0x33EB7A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000B39")]
	public string workshop_name
	{
		[Token(Token = "0x60085AA")]
		[Address(RVA = "0x33EB7AC", Offset = "0x33EB7AC", VA = "0x33EB7AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085AB")]
		[Address(RVA = "0x33EB764", Offset = "0x33EB764", VA = "0x33EB764")]
		set
		{
		}
	}

	[Token(Token = "0x17000B3A")]
	public uint[] workshop_team_counts
	{
		[Token(Token = "0x60085AC")]
		[Address(RVA = "0x33EB7B4", Offset = "0x33EB7B4", VA = "0x33EB7B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085AD")]
		[Address(RVA = "0x33EB7BC", Offset = "0x33EB7BC", VA = "0x33EB7BC")]
		set
		{
		}
	}

	[Token(Token = "0x60085A1")]
	[Address(RVA = "0x33EB688", Offset = "0x33EB688", VA = "0x33EB688")]
	public GroupStartReq()
	{
	}
}
