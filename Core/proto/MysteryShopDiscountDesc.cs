using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ABF")]
public class MysteryShopDiscountDesc
{
	[Token(Token = "0x400A85D")]
	[FieldOffset(Offset = "0x8")]
	public string melon_pi_api_classes;

	[Token(Token = "0x400A85E")]
	[FieldOffset(Offset = "0xC")]
	public uint mystery_shop_id;

	[Token(Token = "0x400A85F")]
	[FieldOffset(Offset = "0x10")]
	public uint discount;

	[Token(Token = "0x400A860")]
	[FieldOffset(Offset = "0x14")]
	public uint weight;

	[Token(Token = "0x400A861")]
	[FieldOffset(Offset = "0x18")]
	public uint discount_show;

	[Token(Token = "0x600811C")]
	[Address(RVA = "0x30A9980", Offset = "0x30A9980", VA = "0x30A9980")]
	public MysteryShopDiscountDesc()
	{
	}
}
