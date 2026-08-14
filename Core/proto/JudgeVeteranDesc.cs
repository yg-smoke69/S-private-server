using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C0B")]
public class JudgeVeteranDesc
{
	[Token(Token = "0x400B06C")]
	[FieldOffset(Offset = "0x8")]
	public uint pre_rank;

	[Token(Token = "0x400B06D")]
	[FieldOffset(Offset = "0xC")]
	public uint match_rank_up;

	[Token(Token = "0x400B06E")]
	[FieldOffset(Offset = "0x10")]
	public uint match_rank_down;

	[Token(Token = "0x400B06F")]
	[FieldOffset(Offset = "0x14")]
	public uint kills_down;

	[Token(Token = "0x400B070")]
	[FieldOffset(Offset = "0x18")]
	public uint damage_include_overflow_down;

	[Token(Token = "0x400B071")]
	[FieldOffset(Offset = "0x1C")]
	public uint survival_time_down;

	[Token(Token = "0x400B072")]
	[FieldOffset(Offset = "0x20")]
	public uint knockdown_count_down;

	[Token(Token = "0x400B073")]
	[FieldOffset(Offset = "0x24")]
	public uint hurts_include_overflow_up;

	[Token(Token = "0x400B074")]
	[FieldOffset(Offset = "0x28")]
	public uint win_rounds_up;

	[Token(Token = "0x400B075")]
	[FieldOffset(Offset = "0x2C")]
	public int add_score;

	[Token(Token = "0x6008266")]
	[Address(RVA = "0x30A41A0", Offset = "0x30A41A0", VA = "0x30A41A0")]
	public JudgeVeteranDesc()
	{
	}
}
