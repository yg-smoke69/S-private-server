using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D59")]
public class RoomKickReq
{
	[Token(Token = "0x400B95C")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Ckick_account_id_003Ek__BackingField;

	[Token(Token = "0x400B95D")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x17000C9C")]
	public ulong kick_account_id
	{
		[Token(Token = "0x60088C9")]
		[Address(RVA = "0x435E7C4", Offset = "0x435E7C4", VA = "0x435E7C4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088CA")]
		[Address(RVA = "0x435E7CC", Offset = "0x435E7CC", VA = "0x435E7CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000C9D")]
	public ulong room_id
	{
		[Token(Token = "0x60088CB")]
		[Address(RVA = "0x435E7DC", Offset = "0x435E7DC", VA = "0x435E7DC")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088CC")]
		[Address(RVA = "0x435E7E4", Offset = "0x435E7E4", VA = "0x435E7E4")]
		set
		{
		}
	}

	[Token(Token = "0x60088C8")]
	[Address(RVA = "0x435E7BC", Offset = "0x435E7BC", VA = "0x435E7BC")]
	public RoomKickReq()
	{
	}
}
