using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD8")]
public class CardPrice
{
	[Token(Token = "0x400A8E7")]
	[FieldOffset(Offset = "0x8")]
	public uint card_num;

	[Token(Token = "0x400A8E8")]
	[FieldOffset(Offset = "0xC")]
	public uint single_price;

	[Token(Token = "0x400A8E9")]
	[FieldOffset(Offset = "0x10")]
	public uint all_price;

	[Token(Token = "0x6008134")]
	[Address(RVA = "0x309AC40", Offset = "0x309AC40", VA = "0x309AC40")]
	public CardPrice()
	{
	}
}
