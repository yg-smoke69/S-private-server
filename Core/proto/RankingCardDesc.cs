using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB5")]
public class RankingCardDesc
{
	[Token(Token = "0x400A810")]
	[FieldOffset(Offset = "0x8")]
	public uint card_id;

	[Token(Token = "0x400A811")]
	[FieldOffset(Offset = "0xC")]
	public uint ranking_point_times;

	[Token(Token = "0x400A812")]
	[FieldOffset(Offset = "0x10")]
	public uint token_times;

	[Token(Token = "0x400A813")]
	[FieldOffset(Offset = "0x14")]
	public bool is_no_deduct;

	[Token(Token = "0x400A814")]
	[FieldOffset(Offset = "0x18")]
	public uint lower_rank;

	[Token(Token = "0x400A815")]
	[FieldOffset(Offset = "0x1C")]
	public uint upper_rank;

	[Token(Token = "0x400A816")]
	[FieldOffset(Offset = "0x20")]
	public uint card_type;

	[Token(Token = "0x6008112")]
	[Address(RVA = "0x33E0BA0", Offset = "0x33E0BA0", VA = "0x33E0BA0")]
	public RankingCardDesc()
	{
	}
}
