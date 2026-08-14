using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D5F")]
public class RoomOwnerSwitchGroupReq
{
	[Token(Token = "0x400B97C")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B97D")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cfrom_group_pos_003Ek__BackingField;

	[Token(Token = "0x400B97E")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cfrom_group_id_003Ek__BackingField;

	[Token(Token = "0x400B97F")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cto_group_pos_003Ek__BackingField;

	[Token(Token = "0x400B980")]
	[FieldOffset(Offset = "0x28")]
	private ulong _003Cto_group_id_003Ek__BackingField;

	[Token(Token = "0x400B981")]
	[FieldOffset(Offset = "0x30")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000CBC")]
	public ulong room_id
	{
		[Token(Token = "0x600890F")]
		[Address(RVA = "0x435E9B4", Offset = "0x435E9B4", VA = "0x435E9B4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008910")]
		[Address(RVA = "0x435E9BC", Offset = "0x435E9BC", VA = "0x435E9BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000CBD")]
	public uint from_group_pos
	{
		[Token(Token = "0x6008911")]
		[Address(RVA = "0x435E9CC", Offset = "0x435E9CC", VA = "0x435E9CC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008912")]
		[Address(RVA = "0x435E9D4", Offset = "0x435E9D4", VA = "0x435E9D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CBE")]
	public ulong from_group_id
	{
		[Token(Token = "0x6008913")]
		[Address(RVA = "0x435E9DC", Offset = "0x435E9DC", VA = "0x435E9DC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008914")]
		[Address(RVA = "0x435E9E4", Offset = "0x435E9E4", VA = "0x435E9E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CBF")]
	public uint to_group_pos
	{
		[Token(Token = "0x6008915")]
		[Address(RVA = "0x435E9F4", Offset = "0x435E9F4", VA = "0x435E9F4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008916")]
		[Address(RVA = "0x435E9FC", Offset = "0x435E9FC", VA = "0x435E9FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC0")]
	public ulong to_group_id
	{
		[Token(Token = "0x6008917")]
		[Address(RVA = "0x435EA04", Offset = "0x435EA04", VA = "0x435EA04")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008918")]
		[Address(RVA = "0x435EA0C", Offset = "0x435EA0C", VA = "0x435EA0C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC1")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x6008919")]
		[Address(RVA = "0x435EA1C", Offset = "0x435EA1C", VA = "0x435EA1C")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x600891A")]
		[Address(RVA = "0x435EA24", Offset = "0x435EA24", VA = "0x435EA24")]
		set
		{
		}
	}

	[Token(Token = "0x600890E")]
	[Address(RVA = "0x435E9AC", Offset = "0x435E9AC", VA = "0x435E9AC")]
	public RoomOwnerSwitchGroupReq()
	{
	}
}
