using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D54")]
public class RoomStartReq
{
	[Token(Token = "0x400B94E")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x17000C8E")]
	public ulong room_id
	{
		[Token(Token = "0x60088A8")]
		[Address(RVA = "0x435EE90", Offset = "0x435EE90", VA = "0x435EE90")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088A9")]
		[Address(RVA = "0x435EE98", Offset = "0x435EE98", VA = "0x435EE98")]
		set
		{
		}
	}

	[Token(Token = "0x60088A7")]
	[Address(RVA = "0x435EE88", Offset = "0x435EE88", VA = "0x435EE88")]
	public RoomStartReq()
	{
	}
}
