using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D5A")]
public class RoomKickNtf
{
	[Token(Token = "0x400B95E")]
	[FieldOffset(Offset = "0x8")]
	private RoomPlayerInfo _003Ckick_player_info_003Ek__BackingField;

	[Token(Token = "0x400B95F")]
	[FieldOffset(Offset = "0xC")]
	private RoomInfo _003Croom_info_003Ek__BackingField;

	[Token(Token = "0x17000C9E")]
	public RoomPlayerInfo kick_player_info
	{
		[Token(Token = "0x60088CE")]
		[Address(RVA = "0x435E79C", Offset = "0x435E79C", VA = "0x435E79C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088CF")]
		[Address(RVA = "0x435E7A4", Offset = "0x435E7A4", VA = "0x435E7A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000C9F")]
	public RoomInfo room_info
	{
		[Token(Token = "0x60088D0")]
		[Address(RVA = "0x435E7AC", Offset = "0x435E7AC", VA = "0x435E7AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088D1")]
		[Address(RVA = "0x435E7B4", Offset = "0x435E7B4", VA = "0x435E7B4")]
		set
		{
		}
	}

	[Token(Token = "0x60088CD")]
	[Address(RVA = "0x435E794", Offset = "0x435E794", VA = "0x435E794")]
	public RoomKickNtf()
	{
	}
}
