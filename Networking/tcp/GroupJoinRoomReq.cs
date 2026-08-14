using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE4")]
public class GroupJoinRoomReq
{
	[Token(Token = "0x400B6E8")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B6E9")]
	[FieldOffset(Offset = "0x10")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B6EA")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6EB")]
	[FieldOffset(Offset = "0x20")]
	private bool _003Cis_solo_003Ek__BackingField;

	[Token(Token = "0x400B6EC")]
	[FieldOffset(Offset = "0x24")]
	private string _003Cgroup_name_003Ek__BackingField;

	[Token(Token = "0x400B6ED")]
	[FieldOffset(Offset = "0x28")]
	private EGroup.RoomType _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x400B6EE")]
	[FieldOffset(Offset = "0x2C")]
	private string _003Cgroup_abbr_name_003Ek__BackingField;

	[Token(Token = "0x17000B4F")]
	public ulong room_id
	{
		[Token(Token = "0x60085DD")]
		[Address(RVA = "0x33EB01C", Offset = "0x33EB01C", VA = "0x33EB01C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085DE")]
		[Address(RVA = "0x33EB024", Offset = "0x33EB024", VA = "0x33EB024")]
		set
		{
		}
	}

	[Token(Token = "0x17000B50")]
	public string code
	{
		[Token(Token = "0x60085DF")]
		[Address(RVA = "0x33EB034", Offset = "0x33EB034", VA = "0x33EB034")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085E0")]
		[Address(RVA = "0x33EB004", Offset = "0x33EB004", VA = "0x33EB004")]
		set
		{
		}
	}

	[Token(Token = "0x17000B51")]
	public ulong group_id
	{
		[Token(Token = "0x60085E1")]
		[Address(RVA = "0x33EB03C", Offset = "0x33EB03C", VA = "0x33EB03C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085E2")]
		[Address(RVA = "0x33EB044", Offset = "0x33EB044", VA = "0x33EB044")]
		set
		{
		}
	}

	[Token(Token = "0x17000B52")]
	public bool is_solo
	{
		[Token(Token = "0x60085E3")]
		[Address(RVA = "0x33EB054", Offset = "0x33EB054", VA = "0x33EB054")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085E4")]
		[Address(RVA = "0x33EB05C", Offset = "0x33EB05C", VA = "0x33EB05C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B53")]
	public string group_name
	{
		[Token(Token = "0x60085E5")]
		[Address(RVA = "0x33EB064", Offset = "0x33EB064", VA = "0x33EB064")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085E6")]
		[Address(RVA = "0x33EB00C", Offset = "0x33EB00C", VA = "0x33EB00C")]
		set
		{
		}
	}

	[Token(Token = "0x17000B54")]
	public EGroup.RoomType room_type
	{
		[Token(Token = "0x60085E7")]
		[Address(RVA = "0x33EB06C", Offset = "0x33EB06C", VA = "0x33EB06C")]
		get
		{
			return default(EGroup.RoomType);
		}
		[Token(Token = "0x60085E8")]
		[Address(RVA = "0x33EB074", Offset = "0x33EB074", VA = "0x33EB074")]
		set
		{
		}
	}

	[Token(Token = "0x17000B55")]
	public string group_abbr_name
	{
		[Token(Token = "0x60085E9")]
		[Address(RVA = "0x33EB07C", Offset = "0x33EB07C", VA = "0x33EB07C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085EA")]
		[Address(RVA = "0x33EB014", Offset = "0x33EB014", VA = "0x33EB014")]
		set
		{
		}
	}

	[Token(Token = "0x60085DC")]
	[Address(RVA = "0x33EAF4C", Offset = "0x33EAF4C", VA = "0x33EAF4C")]
	public GroupJoinRoomReq()
	{
	}
}
