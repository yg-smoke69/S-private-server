using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D77")]
public class MatchStatsRes
{
	[Token(Token = "0x400B9F7")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B9F8")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Cmatch_id_003Ek__BackingField;

	[Token(Token = "0x400B9F9")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Clevel_before_003Ek__BackingField;

	[Token(Token = "0x400B9FA")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Clevel_after_003Ek__BackingField;

	[Token(Token = "0x400B9FB")]
	[FieldOffset(Offset = "0x20")]
	private byte[] _003Cincome_003Ek__BackingField;

	[Token(Token = "0x400B9FC")]
	[FieldOffset(Offset = "0x24")]
	private byte[] _003Cmatch_stats_003Ek__BackingField;

	[Token(Token = "0x400B9FD")]
	[FieldOffset(Offset = "0x28")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x17000D32")]
	public ulong account_id
	{
		[Token(Token = "0x6008A11")]
		[Address(RVA = "0x435BE44", Offset = "0x435BE44", VA = "0x435BE44")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008A12")]
		[Address(RVA = "0x435BE4C", Offset = "0x435BE4C", VA = "0x435BE4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D33")]
	public ulong match_id
	{
		[Token(Token = "0x6008A13")]
		[Address(RVA = "0x435BE5C", Offset = "0x435BE5C", VA = "0x435BE5C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008A14")]
		[Address(RVA = "0x435BE64", Offset = "0x435BE64", VA = "0x435BE64")]
		set
		{
		}
	}

	[Token(Token = "0x17000D34")]
	public uint level_before
	{
		[Token(Token = "0x6008A15")]
		[Address(RVA = "0x435BE74", Offset = "0x435BE74", VA = "0x435BE74")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A16")]
		[Address(RVA = "0x435BE7C", Offset = "0x435BE7C", VA = "0x435BE7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D35")]
	public uint level_after
	{
		[Token(Token = "0x6008A17")]
		[Address(RVA = "0x435BE84", Offset = "0x435BE84", VA = "0x435BE84")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A18")]
		[Address(RVA = "0x435BE8C", Offset = "0x435BE8C", VA = "0x435BE8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D36")]
	public byte[] income
	{
		[Token(Token = "0x6008A19")]
		[Address(RVA = "0x435BE94", Offset = "0x435BE94", VA = "0x435BE94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A1A")]
		[Address(RVA = "0x435BE9C", Offset = "0x435BE9C", VA = "0x435BE9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D37")]
	public byte[] match_stats
	{
		[Token(Token = "0x6008A1B")]
		[Address(RVA = "0x435BEA4", Offset = "0x435BEA4", VA = "0x435BEA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A1C")]
		[Address(RVA = "0x435BEAC", Offset = "0x435BEAC", VA = "0x435BEAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000D38")]
	public uint group_mode
	{
		[Token(Token = "0x6008A1D")]
		[Address(RVA = "0x435BEB4", Offset = "0x435BEB4", VA = "0x435BEB4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A1E")]
		[Address(RVA = "0x435BEBC", Offset = "0x435BEBC", VA = "0x435BEBC")]
		set
		{
		}
	}

	[Token(Token = "0x6008A10")]
	[Address(RVA = "0x435BE3C", Offset = "0x435BE3C", VA = "0x435BE3C")]
	public MatchStatsRes()
	{
	}
}
