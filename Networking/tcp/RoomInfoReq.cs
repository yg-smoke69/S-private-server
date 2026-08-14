using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D5B")]
public class RoomInfoReq
{
	[Token(Token = "0x400B960")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B961")]
	[FieldOffset(Offset = "0x10")]
	private ERoom.Type _003Croom_type_003Ek__BackingField;

	[Token(Token = "0x17000CA0")]
	public ulong room_id
	{
		[Token(Token = "0x60088D3")]
		[Address(RVA = "0x435E3EC", Offset = "0x435E3EC", VA = "0x435E3EC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088D4")]
		[Address(RVA = "0x435E3F4", Offset = "0x435E3F4", VA = "0x435E3F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000CA1")]
	public ERoom.Type room_type
	{
		[Token(Token = "0x60088D5")]
		[Address(RVA = "0x435E404", Offset = "0x435E404", VA = "0x435E404")]
		get
		{
			return default(ERoom.Type);
		}
		[Token(Token = "0x60088D6")]
		[Address(RVA = "0x435E40C", Offset = "0x435E40C", VA = "0x435E40C")]
		set
		{
		}
	}

	[Token(Token = "0x60088D2")]
	[Address(RVA = "0x435E3E4", Offset = "0x435E3E4", VA = "0x435E3E4")]
	public RoomInfoReq()
	{
	}
}
