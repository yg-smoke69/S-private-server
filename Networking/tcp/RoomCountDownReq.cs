using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D60")]
public class RoomCountDownReq
{
	[Token(Token = "0x400B982")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B983")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Ccount_down_seconds_003Ek__BackingField;

	[Token(Token = "0x17000CC2")]
	public ulong room_id
	{
		[Token(Token = "0x600891C")]
		[Address(RVA = "0x435DB94", Offset = "0x435DB94", VA = "0x435DB94")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x600891D")]
		[Address(RVA = "0x435DB9C", Offset = "0x435DB9C", VA = "0x435DB9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000CC3")]
	public uint count_down_seconds
	{
		[Token(Token = "0x600891E")]
		[Address(RVA = "0x435DBAC", Offset = "0x435DBAC", VA = "0x435DBAC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600891F")]
		[Address(RVA = "0x435DBB4", Offset = "0x435DBB4", VA = "0x435DBB4")]
		set
		{
		}
	}

	[Token(Token = "0x600891B")]
	[Address(RVA = "0x435DB8C", Offset = "0x435DB8C", VA = "0x435DB8C")]
	public RoomCountDownReq()
	{
	}
}
