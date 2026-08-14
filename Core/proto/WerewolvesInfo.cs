using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200144D")]
public class WerewolvesInfo
{
	[Token(Token = "0x4008D30")]
	[FieldOffset(Offset = "0x8")]
	public uint role;

	[Token(Token = "0x4008D31")]
	[FieldOffset(Offset = "0xC")]
	public uint wolf_kill;

	[Token(Token = "0x4008D32")]
	[FieldOffset(Offset = "0x10")]
	public uint wolf_task_count;

	[Token(Token = "0x4008D33")]
	[FieldOffset(Offset = "0x14")]
	public uint wolf_bunker_count;

	[Token(Token = "0x4008D34")]
	[FieldOffset(Offset = "0x18")]
	public uint civilian_task_count;

	[Token(Token = "0x4008D35")]
	[FieldOffset(Offset = "0x1C")]
	public uint vote_success_count;

	[Token(Token = "0x4008D36")]
	[FieldOffset(Offset = "0x20")]
	public uint complete_emergency_task_count;

	[Token(Token = "0x4008D37")]
	[FieldOffset(Offset = "0x24")]
	public uint vote_cnt;

	[Token(Token = "0x6007AFB")]
	[Address(RVA = "0x33E5604", Offset = "0x33E5604", VA = "0x33E5604")]
	public WerewolvesInfo()
	{
	}
}
