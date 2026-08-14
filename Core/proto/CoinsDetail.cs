using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200152F")]
public class CoinsDetail
{
	[Token(Token = "0x4009205")]
	[FieldOffset(Offset = "0x8")]
	public uint coin_match;

	[Token(Token = "0x4009206")]
	[FieldOffset(Offset = "0xC")]
	public uint coin_clan_buff;

	[Token(Token = "0x4009207")]
	[FieldOffset(Offset = "0x10")]
	public uint coin_event_bonus;

	[Token(Token = "0x4009208")]
	[FieldOffset(Offset = "0x14")]
	public uint coin_card;

	[Token(Token = "0x4009209")]
	[FieldOffset(Offset = "0x18")]
	public uint coin_ranking;

	[Token(Token = "0x400920A")]
	[FieldOffset(Offset = "0x1C")]
	public uint coin_championship;

	[Token(Token = "0x6007B78")]
	[Address(RVA = "0x309CC74", Offset = "0x309CC74", VA = "0x309CC74")]
	public CoinsDetail()
	{
	}
}
