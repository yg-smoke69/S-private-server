using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB0")]
public class RankExchangeLimitItemDesc
{
	[Token(Token = "0x400A7D5")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A7D6")]
	[FieldOffset(Offset = "0xC")]
	public uint commodity_id;

	[Token(Token = "0x400A7D7")]
	[FieldOffset(Offset = "0x10")]
	public uint type;

	[Token(Token = "0x400A7D8")]
	[FieldOffset(Offset = "0x14")]
	public uint suit_id;

	[Token(Token = "0x400A7D9")]
	[FieldOffset(Offset = "0x18")]
	public uint br_award_rank;

	[Token(Token = "0x400A7DA")]
	[FieldOffset(Offset = "0x1C")]
	public uint cs_award_rank;

	[Token(Token = "0x600810D")]
	[Address(RVA = "0x33E0998", Offset = "0x33E0998", VA = "0x33E0998")]
	public RankExchangeLimitItemDesc()
	{
	}
}
