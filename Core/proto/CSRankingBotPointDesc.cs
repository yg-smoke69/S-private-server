using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B29")]
public class CSRankingBotPointDesc
{
	[Token(Token = "0x400AAB3")]
	[FieldOffset(Offset = "0x8")]
	public uint mmr_start;

	[Token(Token = "0x400AAB4")]
	[FieldOffset(Offset = "0xC")]
	public uint mmr_end;

	[Token(Token = "0x400AAB5")]
	[FieldOffset(Offset = "0x10")]
	public int rank_point_add_lower;

	[Token(Token = "0x400AAB6")]
	[FieldOffset(Offset = "0x14")]
	public int rank_point_add_upper;

	[Token(Token = "0x400AAB7")]
	[FieldOffset(Offset = "0x18")]
	public int bot_point;

	[Token(Token = "0x400AAB8")]
	[FieldOffset(Offset = "0x1C")]
	public uint cs_mvp_bot_point_const;

	[Token(Token = "0x400AAB9")]
	[FieldOffset(Offset = "0x20")]
	public int ingame_bot_point;

	[Token(Token = "0x6008184")]
	[Address(RVA = "0x3098C80", Offset = "0x3098C80", VA = "0x3098C80")]
	public CSRankingBotPointDesc()
	{
	}
}
