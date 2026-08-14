using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D73")]
public class RoomWorkshopTimeoutReq
{
	[Token(Token = "0x400B9F1")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x17000D31")]
	public ulong room_id
	{
		[Token(Token = "0x6008A0D")]
		[Address(RVA = "0x435EFA0", Offset = "0x435EFA0", VA = "0x435EFA0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008A0E")]
		[Address(RVA = "0x435EFA8", Offset = "0x435EFA8", VA = "0x435EFA8")]
		set
		{
		}
	}

	[Token(Token = "0x6008A0C")]
	[Address(RVA = "0x435EF98", Offset = "0x435EF98", VA = "0x435EF98")]
	public RoomWorkshopTimeoutReq()
	{
	}
}
