using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D69")]
public class RoomIDReq
{
	[Token(Token = "0x400B9E0")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B9E1")]
	[FieldOffset(Offset = "0x10")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000D20")]
	public ulong room_id
	{
		[Token(Token = "0x60089E1")]
		[Address(RVA = "0x435E090", Offset = "0x435E090", VA = "0x435E090")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60089E2")]
		[Address(RVA = "0x435E098", Offset = "0x435E098", VA = "0x435E098")]
		set
		{
		}
	}

	[Token(Token = "0x17000D21")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x60089E3")]
		[Address(RVA = "0x435E0A8", Offset = "0x435E0A8", VA = "0x435E0A8")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x60089E4")]
		[Address(RVA = "0x435E0B0", Offset = "0x435E0B0", VA = "0x435E0B0")]
		set
		{
		}
	}

	[Token(Token = "0x60089E0")]
	[Address(RVA = "0x435E088", Offset = "0x435E088", VA = "0x435E088")]
	public RoomIDReq()
	{
	}
}
