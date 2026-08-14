using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B3")]
public class WorkshopRoomFreeInfo
{
	[Token(Token = "0x4008F82")]
	[FieldOffset(Offset = "0x8")]
	public bool free_forever;

	[Token(Token = "0x4008F83")]
	[FieldOffset(Offset = "0x9")]
	public bool limit_open;

	[Token(Token = "0x4008F84")]
	[FieldOffset(Offset = "0xC")]
	public uint general_times;

	[Token(Token = "0x4008F85")]
	[FieldOffset(Offset = "0x10")]
	public uint init_general_times;

	[Token(Token = "0x4008F86")]
	[FieldOffset(Offset = "0x18")]
	public long next_refresh_time;

	[Token(Token = "0x6007B14")]
	[Address(RVA = "0x33E6998", Offset = "0x33E6998", VA = "0x33E6998")]
	public WorkshopRoomFreeInfo()
	{
	}
}
