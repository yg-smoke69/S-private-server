using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD7")]
public class FreeWorkshopRoomCreateDesc
{
	[Token(Token = "0x400AF22")]
	[FieldOffset(Offset = "0x8")]
	public uint workshop_room_reload_count;

	[Token(Token = "0x400AF23")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400AF24")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400AF25")]
	[FieldOffset(Offset = "0x20")]
	public EActivity.CircleType circle_type;

	[Token(Token = "0x400AF26")]
	[FieldOffset(Offset = "0x24")]
	public uint creator_bonus_count;

	[Token(Token = "0x400AF27")]
	[FieldOffset(Offset = "0x28")]
	public uint creator_bonus_count_limit;

	[Token(Token = "0x400AF28")]
	[FieldOffset(Offset = "0x2C")]
	public bool free_forever;

	[Token(Token = "0x6008232")]
	[Address(RVA = "0x30A1278", Offset = "0x30A1278", VA = "0x30A1278")]
	public FreeWorkshopRoomCreateDesc()
	{
	}
}
