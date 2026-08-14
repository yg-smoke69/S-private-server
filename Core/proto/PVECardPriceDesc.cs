using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ADF")]
public class PVECardPriceDesc
{
	[Token(Token = "0x400A903")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400A904")]
	[FieldOffset(Offset = "0xC")]
	public uint map_id;

	[Token(Token = "0x400A905")]
	[FieldOffset(Offset = "0x10")]
	public uint difficulty;

	[Token(Token = "0x400A906")]
	[FieldOffset(Offset = "0x14")]
	public uint ai_type;

	[Token(Token = "0x400A907")]
	[FieldOffset(Offset = "0x18")]
	public CardPriceDesc card_price;

	[Token(Token = "0x600813A")]
	[Address(RVA = "0x33DEEF4", Offset = "0x33DEEF4", VA = "0x33DEEF4")]
	public PVECardPriceDesc()
	{
	}
}
