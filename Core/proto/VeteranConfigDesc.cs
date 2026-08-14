using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A0D")]
public class VeteranConfigDesc
{
	[Token(Token = "0x400A34C")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A34D")]
	[FieldOffset(Offset = "0xC")]
	public uint leave_days;

	[Token(Token = "0x400A34E")]
	[FieldOffset(Offset = "0x10")]
	public uint chest_leave_days;

	[Token(Token = "0x400A34F")]
	[FieldOffset(Offset = "0x14")]
	public uint rich_veteran_min_level;

	[Token(Token = "0x400A350")]
	[FieldOffset(Offset = "0x18")]
	public uint rich_veteran_max_level;

	[Token(Token = "0x400A351")]
	[FieldOffset(Offset = "0x1C")]
	public uint senior_veteran;

	[Token(Token = "0x400A352")]
	[FieldOffset(Offset = "0x20")]
	public uint veteran_time;

	[Token(Token = "0x400A353")]
	[FieldOffset(Offset = "0x24")]
	public uint veteran_switch;

	[Token(Token = "0x400A354")]
	[FieldOffset(Offset = "0x28")]
	public uint cooperate_task_limit;

	[Token(Token = "0x400A355")]
	[FieldOffset(Offset = "0x2C")]
	public uint cooperate_task_amount;

	[Token(Token = "0x400A356")]
	[FieldOffset(Offset = "0x30")]
	public uint task_class1_amount;

	[Token(Token = "0x400A357")]
	[FieldOffset(Offset = "0x34")]
	public uint task_class2_amount;

	[Token(Token = "0x400A358")]
	[FieldOffset(Offset = "0x38")]
	public uint task_class3_amount;

	[Token(Token = "0x6008065")]
	[Address(RVA = "0x33E4630", Offset = "0x33E4630", VA = "0x33E4630")]
	public VeteranConfigDesc()
	{
	}
}
