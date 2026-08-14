using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CD2")]
public class GroupAcceptJoinNtf
{
	[Token(Token = "0x400B68D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B68E")]
	[FieldOffset(Offset = "0x10")]
	private GroupMemberInfo _003Cacceptor_info_003Ek__BackingField;

	[Token(Token = "0x400B68F")]
	[FieldOffset(Offset = "0x14")]
	private uint[] _003Cmap_ids_003Ek__BackingField;

	[Token(Token = "0x400B690")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B691")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B692")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cmatch_mode_003Ek__BackingField;

	[Token(Token = "0x400B693")]
	[FieldOffset(Offset = "0x24")]
	private string _003Csecret_code_003Ek__BackingField;

	[Token(Token = "0x17000AF4")]
	public ulong group_id
	{
		[Token(Token = "0x6008515")]
		[Address(RVA = "0x33EA018", Offset = "0x33EA018", VA = "0x33EA018")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008516")]
		[Address(RVA = "0x33EA020", Offset = "0x33EA020", VA = "0x33EA020")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF5")]
	public GroupMemberInfo acceptor_info
	{
		[Token(Token = "0x6008517")]
		[Address(RVA = "0x33EA030", Offset = "0x33EA030", VA = "0x33EA030")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008518")]
		[Address(RVA = "0x33EA038", Offset = "0x33EA038", VA = "0x33EA038")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF6")]
	public uint[] map_ids
	{
		[Token(Token = "0x6008519")]
		[Address(RVA = "0x33EA040", Offset = "0x33EA040", VA = "0x33EA040")]
		get
		{
			return null;
		}
		[Token(Token = "0x600851A")]
		[Address(RVA = "0x33EA048", Offset = "0x33EA048", VA = "0x33EA048")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF7")]
	public uint game_mode
	{
		[Token(Token = "0x600851B")]
		[Address(RVA = "0x33EA050", Offset = "0x33EA050", VA = "0x33EA050")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600851C")]
		[Address(RVA = "0x33EA058", Offset = "0x33EA058", VA = "0x33EA058")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF8")]
	public uint group_mode
	{
		[Token(Token = "0x600851D")]
		[Address(RVA = "0x33EA060", Offset = "0x33EA060", VA = "0x33EA060")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600851E")]
		[Address(RVA = "0x33EA068", Offset = "0x33EA068", VA = "0x33EA068")]
		set
		{
		}
	}

	[Token(Token = "0x17000AF9")]
	public uint match_mode
	{
		[Token(Token = "0x600851F")]
		[Address(RVA = "0x33EA070", Offset = "0x33EA070", VA = "0x33EA070")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008520")]
		[Address(RVA = "0x33EA078", Offset = "0x33EA078", VA = "0x33EA078")]
		set
		{
		}
	}

	[Token(Token = "0x17000AFA")]
	public string secret_code
	{
		[Token(Token = "0x6008521")]
		[Address(RVA = "0x33EA080", Offset = "0x33EA080", VA = "0x33EA080")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008522")]
		[Address(RVA = "0x33EA010", Offset = "0x33EA010", VA = "0x33EA010")]
		set
		{
		}
	}

	[Token(Token = "0x6008514")]
	[Address(RVA = "0x33E9F70", Offset = "0x33E9F70", VA = "0x33E9F70")]
	public GroupAcceptJoinNtf()
	{
	}
}
