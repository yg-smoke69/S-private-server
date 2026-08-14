using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D53")]
public class RoomLeaveReq
{
	[Token(Token = "0x400B94D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x17000C8D")]
	public ulong room_id
	{
		[Token(Token = "0x60088A5")]
		[Address(RVA = "0x435E824", Offset = "0x435E824", VA = "0x435E824")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088A6")]
		[Address(RVA = "0x435E82C", Offset = "0x435E82C", VA = "0x435E82C")]
		set
		{
		}
	}

	[Token(Token = "0x60088A4")]
	[Address(RVA = "0x435E81C", Offset = "0x435E81C", VA = "0x435E81C")]
	public RoomLeaveReq()
	{
	}
}
