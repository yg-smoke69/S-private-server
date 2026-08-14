using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B2A")]
public class CSRankingBotPointIngameParam
{
	[Token(Token = "0x400AABA")]
	[FieldOffset(Offset = "0x8")]
	public uint round_lower;

	[Token(Token = "0x400AABB")]
	[FieldOffset(Offset = "0xC")]
	public uint round_upper;

	[Token(Token = "0x400AABC")]
	[FieldOffset(Offset = "0x10")]
	public uint kills_lower;

	[Token(Token = "0x400AABD")]
	[FieldOffset(Offset = "0x14")]
	public uint kills_upper;

	[Token(Token = "0x400AABE")]
	[FieldOffset(Offset = "0x18")]
	public uint death_lower;

	[Token(Token = "0x400AABF")]
	[FieldOffset(Offset = "0x1C")]
	public uint death_upper;

	[Token(Token = "0x400AAC0")]
	[FieldOffset(Offset = "0x20")]
	public int ingame_param;

	[Token(Token = "0x400AAC1")]
	[FieldOffset(Offset = "0x24")]
	public bool is_reset;

	[Token(Token = "0x6008185")]
	[Address(RVA = "0x3098C88", Offset = "0x3098C88", VA = "0x3098C88")]
	public CSRankingBotPointIngameParam()
	{
	}
}
