using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD7")]
public class CardPriceDesc
{
	[Token(Token = "0x400A8E2")]
	[FieldOffset(Offset = "0x8")]
	public uint card_num;

	[Token(Token = "0x400A8E3")]
	[FieldOffset(Offset = "0xC")]
	public uint single_price;

	[Token(Token = "0x400A8E4")]
	[FieldOffset(Offset = "0x10")]
	public uint all_price;

	[Token(Token = "0x400A8E5")]
	[FieldOffset(Offset = "0x14")]
	public uint win_single_price;

	[Token(Token = "0x400A8E6")]
	[FieldOffset(Offset = "0x18")]
	public uint win_all_price;

	[Token(Token = "0x6008133")]
	[Address(RVA = "0x309AC48", Offset = "0x309AC48", VA = "0x309AC48")]
	public CardPriceDesc()
	{
	}
}
