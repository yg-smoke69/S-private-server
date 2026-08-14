using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B33")]
public class BigEventStoreCommodityDesc
{
	[Token(Token = "0x400AAF9")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400AAFA")]
	[FieldOffset(Offset = "0xC")]
	public uint sku_id;

	[Token(Token = "0x400AAFB")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400AAFC")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400AAFD")]
	[FieldOffset(Offset = "0x18")]
	public uint item_duration;

	[Token(Token = "0x400AAFE")]
	[FieldOffset(Offset = "0x1C")]
	public uint currency_id;

	[Token(Token = "0x400AAFF")]
	[FieldOffset(Offset = "0x20")]
	public uint currency_price;

	[Token(Token = "0x400AB00")]
	[FieldOffset(Offset = "0x24")]
	public uint limited_purchase_times;

	[Token(Token = "0x400AB01")]
	[FieldOffset(Offset = "0x28")]
	public uint purchase_times;

	[Token(Token = "0x400AB02")]
	[FieldOffset(Offset = "0x2C")]
	public uint item_amount;

	[Token(Token = "0x600818E")]
	[Address(RVA = "0x317C3E4", Offset = "0x317C3E4", VA = "0x317C3E4")]
	public BigEventStoreCommodityDesc()
	{
	}
}
