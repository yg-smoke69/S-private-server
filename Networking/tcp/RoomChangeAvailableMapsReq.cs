using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D6A")]
public class RoomChangeAvailableMapsReq
{
	[Token(Token = "0x400B9E2")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B9E3")]
	[FieldOffset(Offset = "0x10")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B9E4")]
	[FieldOffset(Offset = "0x14")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000D22")]
	public ulong room_id
	{
		[Token(Token = "0x60089E6")]
		[Address(RVA = "0x435D940", Offset = "0x435D940", VA = "0x435D940")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60089E7")]
		[Address(RVA = "0x435D948", Offset = "0x435D948", VA = "0x435D948")]
		set
		{
		}
	}

	[Token(Token = "0x17000D23")]
	public uint[] available_maps
	{
		[Token(Token = "0x60089E8")]
		[Address(RVA = "0x435D958", Offset = "0x435D958", VA = "0x435D958")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089E9")]
		[Address(RVA = "0x435D960", Offset = "0x435D960", VA = "0x435D960")]
		set
		{
		}
	}

	[Token(Token = "0x17000D24")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x60089EA")]
		[Address(RVA = "0x435D968", Offset = "0x435D968", VA = "0x435D968")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x60089EB")]
		[Address(RVA = "0x435D970", Offset = "0x435D970", VA = "0x435D970")]
		set
		{
		}
	}

	[Token(Token = "0x60089E5")]
	[Address(RVA = "0x435D938", Offset = "0x435D938", VA = "0x435D938")]
	public RoomChangeAvailableMapsReq()
	{
	}
}
