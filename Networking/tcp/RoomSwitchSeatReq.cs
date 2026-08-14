using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D5E")]
public class RoomSwitchSeatReq
{
	[Token(Token = "0x400B976")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B977")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B978")]
	[FieldOffset(Offset = "0x18")]
	private ERoom.PlayerRole _003Cto_role_003Ek__BackingField;

	[Token(Token = "0x400B979")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cto_room_pos_003Ek__BackingField;

	[Token(Token = "0x400B97A")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cto_group_pos_003Ek__BackingField;

	[Token(Token = "0x400B97B")]
	[FieldOffset(Offset = "0x24")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000CB6")]
	public ulong room_id
	{
		[Token(Token = "0x6008902")]
		[Address(RVA = "0x435EEE0", Offset = "0x435EEE0", VA = "0x435EEE0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008903")]
		[Address(RVA = "0x435EEE8", Offset = "0x435EEE8", VA = "0x435EEE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB7")]
	public ulong account_id
	{
		[Token(Token = "0x6008904")]
		[Address(RVA = "0x435EEF8", Offset = "0x435EEF8", VA = "0x435EEF8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008905")]
		[Address(RVA = "0x435EF00", Offset = "0x435EF00", VA = "0x435EF00")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB8")]
	public ERoom.PlayerRole to_role
	{
		[Token(Token = "0x6008906")]
		[Address(RVA = "0x435EF10", Offset = "0x435EF10", VA = "0x435EF10")]
		get
		{
			return default(ERoom.PlayerRole);
		}
		[Token(Token = "0x6008907")]
		[Address(RVA = "0x435EF18", Offset = "0x435EF18", VA = "0x435EF18")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB9")]
	public uint to_room_pos
	{
		[Token(Token = "0x6008908")]
		[Address(RVA = "0x435EF20", Offset = "0x435EF20", VA = "0x435EF20")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008909")]
		[Address(RVA = "0x435EF28", Offset = "0x435EF28", VA = "0x435EF28")]
		set
		{
		}
	}

	[Token(Token = "0x17000CBA")]
	public uint to_group_pos
	{
		[Token(Token = "0x600890A")]
		[Address(RVA = "0x435EF30", Offset = "0x435EF30", VA = "0x435EF30")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600890B")]
		[Address(RVA = "0x435EF38", Offset = "0x435EF38", VA = "0x435EF38")]
		set
		{
		}
	}

	[Token(Token = "0x17000CBB")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x600890C")]
		[Address(RVA = "0x435EF40", Offset = "0x435EF40", VA = "0x435EF40")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x600890D")]
		[Address(RVA = "0x435EF48", Offset = "0x435EF48", VA = "0x435EF48")]
		set
		{
		}
	}

	[Token(Token = "0x6008901")]
	[Address(RVA = "0x435EED8", Offset = "0x435EED8", VA = "0x435EED8")]
	public RoomSwitchSeatReq()
	{
	}
}
