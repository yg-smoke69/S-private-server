using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014BB")]
public class WorkshopAccountInfo
{
	[Token(Token = "0x4008FA4")]
	[FieldOffset(Offset = "0x8")]
	public uint exp;

	[Token(Token = "0x4008FA5")]
	[FieldOffset(Offset = "0xC")]
	public uint create_times;

	[Token(Token = "0x4008FA6")]
	[FieldOffset(Offset = "0x10")]
	public ulong liked_times;

	[Token(Token = "0x4008FA7")]
	[FieldOffset(Offset = "0x18")]
	public long play_duration;

	[Token(Token = "0x4008FA8")]
	[FieldOffset(Offset = "0x20")]
	public uint play_count;

	[Token(Token = "0x4008FA9")]
	[FieldOffset(Offset = "0x24")]
	public uint create_room_times;

	[Token(Token = "0x4008FAA")]
	[FieldOffset(Offset = "0x28")]
	public ulong subscription_times;

	[Token(Token = "0x4008FAB")]
	[FieldOffset(Offset = "0x30")]
	public uint award_claimed_level;

	[Token(Token = "0x6007B1C")]
	[Address(RVA = "0x33E5F80", Offset = "0x33E5F80", VA = "0x33E5F80")]
	public WorkshopAccountInfo()
	{
	}
}
