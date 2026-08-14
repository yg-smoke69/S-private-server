using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B24")]
public class CSRankDesc
{
	[Token(Token = "0x400AA98")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400AA99")]
	[FieldOffset(Offset = "0xC")]
	public string rank_desc;

	[Token(Token = "0x400AA9A")]
	[FieldOffset(Offset = "0x10")]
	public string rank_name;

	[Token(Token = "0x400AA9B")]
	[FieldOffset(Offset = "0x14")]
	public uint rank_up_star;

	[Token(Token = "0x400AA9C")]
	[FieldOffset(Offset = "0x18")]
	public uint lower_bound;

	[Token(Token = "0x400AA9D")]
	[FieldOffset(Offset = "0x1C")]
	public uint upper_bound;

	[Token(Token = "0x400AA9E")]
	[FieldOffset(Offset = "0x20")]
	public bool is_streak_bonus;

	[Token(Token = "0x400AA9F")]
	[FieldOffset(Offset = "0x21")]
	public bool is_rank_protect;

	[Token(Token = "0x400AAA0")]
	[FieldOffset(Offset = "0x24")]
	public uint achieve_protection_score;

	[Token(Token = "0x400AAA1")]
	[FieldOffset(Offset = "0x28")]
	public bool heroic_mark_switch;

	[Token(Token = "0x600817F")]
	[Address(RVA = "0x3098B40", Offset = "0x3098B40", VA = "0x3098B40")]
	public CSRankDesc()
	{
	}
}
