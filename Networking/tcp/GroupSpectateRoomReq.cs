using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CE5")]
public class GroupSpectateRoomReq
{
	[Token(Token = "0x400B6EF")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B6F0")]
	[FieldOffset(Offset = "0x10")]
	private string _003Ccode_003Ek__BackingField;

	[Token(Token = "0x400B6F1")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Cgroup_id_003Ek__BackingField;

	[Token(Token = "0x400B6F2")]
	[FieldOffset(Offset = "0x20")]
	private bool _003Cis_solo_003Ek__BackingField;

	[Token(Token = "0x400B6F3")]
	[FieldOffset(Offset = "0x24")]
	private EGroup.RoomType _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000B56")]
	public ulong room_id
	{
		[Token(Token = "0x60085EC")]
		[Address(RVA = "0x33EB608", Offset = "0x33EB608", VA = "0x33EB608")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085ED")]
		[Address(RVA = "0x33EB610", Offset = "0x33EB610", VA = "0x33EB610")]
		set
		{
		}
	}

	[Token(Token = "0x17000B57")]
	public string code
	{
		[Token(Token = "0x60085EE")]
		[Address(RVA = "0x33EB620", Offset = "0x33EB620", VA = "0x33EB620")]
		get
		{
			return null;
		}
		[Token(Token = "0x60085EF")]
		[Address(RVA = "0x33EB600", Offset = "0x33EB600", VA = "0x33EB600")]
		set
		{
		}
	}

	[Token(Token = "0x17000B58")]
	public ulong group_id
	{
		[Token(Token = "0x60085F0")]
		[Address(RVA = "0x33EB628", Offset = "0x33EB628", VA = "0x33EB628")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60085F1")]
		[Address(RVA = "0x33EB630", Offset = "0x33EB630", VA = "0x33EB630")]
		set
		{
		}
	}

	[Token(Token = "0x17000B59")]
	public bool is_solo
	{
		[Token(Token = "0x60085F2")]
		[Address(RVA = "0x33EB640", Offset = "0x33EB640", VA = "0x33EB640")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60085F3")]
		[Address(RVA = "0x33EB648", Offset = "0x33EB648", VA = "0x33EB648")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5A")]
	public EGroup.RoomType room_type
	{
		[Token(Token = "0x60085F4")]
		[Address(RVA = "0x33EB650", Offset = "0x33EB650", VA = "0x33EB650")]
		get
		{
			return default(EGroup.RoomType);
		}
		[Token(Token = "0x60085F5")]
		[Address(RVA = "0x33EB658", Offset = "0x33EB658", VA = "0x33EB658")]
		set
		{
		}
	}

	[Token(Token = "0x60085EB")]
	[Address(RVA = "0x33EB560", Offset = "0x33EB560", VA = "0x33EB560")]
	public GroupSpectateRoomReq()
	{
	}
}
