using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D62")]
public class RoomInviteNtf
{
	[Token(Token = "0x400B985")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B986")]
	[FieldOffset(Offset = "0x10")]
	private RoomPlayerInfo _003Cinviter_info_003Ek__BackingField;

	[Token(Token = "0x400B987")]
	[FieldOffset(Offset = "0x14")]
	private uint _003Cmap_id_003Ek__BackingField;

	[Token(Token = "0x400B988")]
	[FieldOffset(Offset = "0x18")]
	private uint _003Cgame_mode_003Ek__BackingField;

	[Token(Token = "0x400B989")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Cgroup_mode_003Ek__BackingField;

	[Token(Token = "0x400B98A")]
	[FieldOffset(Offset = "0x20")]
	private ulong _003Cowner_id_003Ek__BackingField;

	[Token(Token = "0x400B98B")]
	[FieldOffset(Offset = "0x28")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000CC5")]
	public ulong room_id
	{
		[Token(Token = "0x6008924")]
		[Address(RVA = "0x435E41C", Offset = "0x435E41C", VA = "0x435E41C")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008925")]
		[Address(RVA = "0x435E424", Offset = "0x435E424", VA = "0x435E424")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC6")]
	public RoomPlayerInfo inviter_info
	{
		[Token(Token = "0x6008926")]
		[Address(RVA = "0x435E434", Offset = "0x435E434", VA = "0x435E434")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008927")]
		[Address(RVA = "0x435E43C", Offset = "0x435E43C", VA = "0x435E43C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC7")]
	public uint map_id
	{
		[Token(Token = "0x6008928")]
		[Address(RVA = "0x435E444", Offset = "0x435E444", VA = "0x435E444")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008929")]
		[Address(RVA = "0x435E44C", Offset = "0x435E44C", VA = "0x435E44C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC8")]
	public uint game_mode
	{
		[Token(Token = "0x600892A")]
		[Address(RVA = "0x435E454", Offset = "0x435E454", VA = "0x435E454")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600892B")]
		[Address(RVA = "0x435E45C", Offset = "0x435E45C", VA = "0x435E45C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC9")]
	public uint group_mode
	{
		[Token(Token = "0x600892C")]
		[Address(RVA = "0x435E464", Offset = "0x435E464", VA = "0x435E464")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600892D")]
		[Address(RVA = "0x435E46C", Offset = "0x435E46C", VA = "0x435E46C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CCA")]
	public ulong owner_id
	{
		[Token(Token = "0x600892E")]
		[Address(RVA = "0x435E474", Offset = "0x435E474", VA = "0x435E474")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600892F")]
		[Address(RVA = "0x435E47C", Offset = "0x435E47C", VA = "0x435E47C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CCB")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x6008930")]
		[Address(RVA = "0x435E48C", Offset = "0x435E48C", VA = "0x435E48C")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x6008931")]
		[Address(RVA = "0x435E494", Offset = "0x435E494", VA = "0x435E494")]
		set
		{
		}
	}

	[Token(Token = "0x6008923")]
	[Address(RVA = "0x435E414", Offset = "0x435E414", VA = "0x435E414")]
	public RoomInviteNtf()
	{
	}
}
