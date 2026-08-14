using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D57")]
public class RoomLeaveNtf
{
	[Token(Token = "0x400B957")]
	[FieldOffset(Offset = "0x8")]
	private RoomPlayerInfo _003Cleaver_info_003Ek__BackingField;

	[Token(Token = "0x400B958")]
	[FieldOffset(Offset = "0xC")]
	private RoomInfo _003Croom_info_003Ek__BackingField;

	[Token(Token = "0x17000C97")]
	public RoomPlayerInfo leaver_info
	{
		[Token(Token = "0x60088BD")]
		[Address(RVA = "0x435E7FC", Offset = "0x435E7FC", VA = "0x435E7FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088BE")]
		[Address(RVA = "0x435E804", Offset = "0x435E804", VA = "0x435E804")]
		set
		{
		}
	}

	[Token(Token = "0x17000C98")]
	public RoomInfo room_info
	{
		[Token(Token = "0x60088BF")]
		[Address(RVA = "0x435E80C", Offset = "0x435E80C", VA = "0x435E80C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60088C0")]
		[Address(RVA = "0x435E814", Offset = "0x435E814", VA = "0x435E814")]
		set
		{
		}
	}

	[Token(Token = "0x60088BC")]
	[Address(RVA = "0x435E7F4", Offset = "0x435E7F4", VA = "0x435E7F4")]
	public RoomLeaveNtf()
	{
	}
}
