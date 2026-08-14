using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A76")]
public class RankingBotPointDesc
{
	[Token(Token = "0x400A5A0")]
	[FieldOffset(Offset = "0x8")]
	public int rank_point_add_lower;

	[Token(Token = "0x400A5A1")]
	[FieldOffset(Offset = "0xC")]
	public int rank_point_add_upper;

	[Token(Token = "0x400A5A2")]
	[FieldOffset(Offset = "0x10")]
	public int bot_point;

	[Token(Token = "0x400A5A3")]
	[FieldOffset(Offset = "0x14")]
	public uint mmr_start;

	[Token(Token = "0x400A5A4")]
	[FieldOffset(Offset = "0x18")]
	public uint mmr_end;

	[Token(Token = "0x400A5A5")]
	[FieldOffset(Offset = "0x1C")]
	public uint group_mode;

	[Token(Token = "0x400A5A6")]
	[FieldOffset(Offset = "0x20")]
	public int ingame_bot_point;

	[Token(Token = "0x60080D3")]
	[Address(RVA = "0x33E0B90", Offset = "0x33E0B90", VA = "0x33E0B90")]
	public RankingBotPointDesc()
	{
	}
}
