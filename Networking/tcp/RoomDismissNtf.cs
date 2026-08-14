using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D58")]
public class RoomDismissNtf
{
	[Token(Token = "0x400B959")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cleaver_id_003Ek__BackingField;

	[Token(Token = "0x400B95A")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B95B")]
	[FieldOffset(Offset = "0x18")]
	private ERoom.DismissReason _003Creason_003Ek__BackingField;

	[Token(Token = "0x17000C99")]
	public ulong leaver_id
	{
		[Token(Token = "0x60088C2")]
		[Address(RVA = "0x435DEF0", Offset = "0x435DEF0", VA = "0x435DEF0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088C3")]
		[Address(RVA = "0x435DEF8", Offset = "0x435DEF8", VA = "0x435DEF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000C9A")]
	public ulong room_id
	{
		[Token(Token = "0x60088C4")]
		[Address(RVA = "0x435DF08", Offset = "0x435DF08", VA = "0x435DF08")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088C5")]
		[Address(RVA = "0x435DF10", Offset = "0x435DF10", VA = "0x435DF10")]
		set
		{
		}
	}

	[Token(Token = "0x17000C9B")]
	public ERoom.DismissReason reason
	{
		[Token(Token = "0x60088C6")]
		[Address(RVA = "0x435DF20", Offset = "0x435DF20", VA = "0x435DF20")]
		get
		{
			return default(ERoom.DismissReason);
		}
		[Token(Token = "0x60088C7")]
		[Address(RVA = "0x435DF28", Offset = "0x435DF28", VA = "0x435DF28")]
		set
		{
		}
	}

	[Token(Token = "0x60088C1")]
	[Address(RVA = "0x435DEE8", Offset = "0x435DEE8", VA = "0x435DEE8")]
	public RoomDismissNtf()
	{
	}
}
