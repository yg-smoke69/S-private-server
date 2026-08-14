using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA1")]
public class ChestDiscountDesc
{
	[Token(Token = "0x400A737")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A738")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400A739")]
	[FieldOffset(Offset = "0x10")]
	public long discount_start_time;

	[Token(Token = "0x400A73A")]
	[FieldOffset(Offset = "0x18")]
	public long discount_end_time;

	[Token(Token = "0x400A73B")]
	[FieldOffset(Offset = "0x20")]
	public uint discount_price_one;

	[Token(Token = "0x400A73C")]
	[FieldOffset(Offset = "0x24")]
	public uint discount_price_ten;

	[Token(Token = "0x60080FE")]
	[Address(RVA = "0x309B4D8", Offset = "0x309B4D8", VA = "0x309B4D8")]
	public ChestDiscountDesc()
	{
	}
}
