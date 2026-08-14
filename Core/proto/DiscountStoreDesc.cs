using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB9")]
public class DiscountStoreDesc
{
	[Token(Token = "0x400A837")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A838")]
	[FieldOffset(Offset = "0xC")]
	public uint loop_id;

	[Token(Token = "0x400A839")]
	[FieldOffset(Offset = "0x10")]
	public uint refresh_id;

	[Token(Token = "0x400A83A")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400A83B")]
	[FieldOffset(Offset = "0x18")]
	public uint coins_price;

	[Token(Token = "0x400A83C")]
	[FieldOffset(Offset = "0x1C")]
	public uint gems_price;

	[Token(Token = "0x400A83D")]
	[FieldOffset(Offset = "0x20")]
	public float discount_value;

	[Token(Token = "0x400A83E")]
	[FieldOffset(Offset = "0x24")]
	public uint limited_purchase_times;

	[Token(Token = "0x400A83F")]
	[FieldOffset(Offset = "0x28")]
	public uint purchase_times;

	[Token(Token = "0x400A840")]
	[FieldOffset(Offset = "0x2C")]
	public uint award_time;

	[Token(Token = "0x6008116")]
	[Address(RVA = "0x309F054", Offset = "0x309F054", VA = "0x309F054")]
	public DiscountStoreDesc()
	{
	}
}
