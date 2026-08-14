using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AAF")]
public class RankExchangeDisplayDesc
{
	[Token(Token = "0x400A7D0")]
	[FieldOffset(Offset = "0x8")]
	public uint exchange_award_id;

	[Token(Token = "0x400A7D1")]
	[FieldOffset(Offset = "0xC")]
	public uint exchange_award_rank;

	[Token(Token = "0x400A7D2")]
	[FieldOffset(Offset = "0x10")]
	public string exchange_store_bg_url;

	[Token(Token = "0x400A7D3")]
	[FieldOffset(Offset = "0x14")]
	public uint[] available_type;

	[Token(Token = "0x400A7D4")]
	[FieldOffset(Offset = "0x18")]
	public string exchange_store_reward_url;

	[Token(Token = "0x600810C")]
	[Address(RVA = "0x33E08EC", Offset = "0x33E08EC", VA = "0x33E08EC")]
	public RankExchangeDisplayDesc()
	{
	}
}
