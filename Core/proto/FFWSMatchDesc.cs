using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B96")]
public class FFWSMatchDesc
{
	[Token(Token = "0x400AD82")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD83")]
	[FieldOffset(Offset = "0xC")]
	public uint match_score_lower_bound;

	[Token(Token = "0x400AD84")]
	[FieldOffset(Offset = "0x10")]
	public uint match_score_upper_bound;

	[Token(Token = "0x400AD85")]
	[FieldOffset(Offset = "0x14")]
	public uint sword_difficulty_lower_bound;

	[Token(Token = "0x400AD86")]
	[FieldOffset(Offset = "0x18")]
	public uint sword_difficulty_upper_bound;

	[Token(Token = "0x400AD87")]
	[FieldOffset(Offset = "0x1C")]
	public uint policy_difficulty_lower_bound;

	[Token(Token = "0x400AD88")]
	[FieldOffset(Offset = "0x20")]
	public uint policy_difficulty_upper_bound;

	[Token(Token = "0x400AD89")]
	[FieldOffset(Offset = "0x24")]
	public uint[] weight;

	[Token(Token = "0x400AD8A")]
	[FieldOffset(Offset = "0x28")]
	public long start_time;

	[Token(Token = "0x400AD8B")]
	[FieldOffset(Offset = "0x30")]
	public long end_time;

	[Token(Token = "0x60081F1")]
	[Address(RVA = "0x30A050C", Offset = "0x30A050C", VA = "0x30A050C")]
	public FFWSMatchDesc()
	{
	}
}
