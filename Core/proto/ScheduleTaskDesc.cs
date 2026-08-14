using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B2B")]
public class ScheduleTaskDesc
{
	[Token(Token = "0x400AAC2")]
	[FieldOffset(Offset = "0x8")]
	public uint task_id;

	[Token(Token = "0x400AAC3")]
	[FieldOffset(Offset = "0xC")]
	public ESchedule.TaskType task_type;

	[Token(Token = "0x400AAC4")]
	[FieldOffset(Offset = "0x10")]
	public string param1;

	[Token(Token = "0x400AAC5")]
	[FieldOffset(Offset = "0x14")]
	public string param2;

	[Token(Token = "0x400AAC6")]
	[FieldOffset(Offset = "0x18")]
	public string param3;

	[Token(Token = "0x400AAC7")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x400AAC8")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x400AAC9")]
	[FieldOffset(Offset = "0x30")]
	public uint loop_cycle;

	[Token(Token = "0x6008186")]
	[Address(RVA = "0x33E1ED8", Offset = "0x33E1ED8", VA = "0x33E1ED8")]
	public ScheduleTaskDesc()
	{
	}
}
