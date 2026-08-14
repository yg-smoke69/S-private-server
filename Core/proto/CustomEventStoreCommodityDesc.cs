using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C0A")]
public class CustomEventStoreCommodityDesc
{
	[Token(Token = "0x400B062")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400B063")]
	[FieldOffset(Offset = "0xC")]
	public uint sku_id;

	[Token(Token = "0x400B064")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400B065")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400B066")]
	[FieldOffset(Offset = "0x18")]
	public uint item_duration;

	[Token(Token = "0x400B067")]
	[FieldOffset(Offset = "0x1C")]
	public uint item_amount;

	[Token(Token = "0x400B068")]
	[FieldOffset(Offset = "0x20")]
	public uint currency_id;

	[Token(Token = "0x400B069")]
	[FieldOffset(Offset = "0x24")]
	public uint currency_price;

	[Token(Token = "0x400B06A")]
	[FieldOffset(Offset = "0x28")]
	public uint limited_purchase_times;

	[Token(Token = "0x400B06B")]
	[FieldOffset(Offset = "0x2C")]
	public uint item_type;

	[Token(Token = "0x6008265")]
	[Address(RVA = "0x309E2F8", Offset = "0x309E2F8", VA = "0x309E2F8")]
	public CustomEventStoreCommodityDesc()
	{
	}
}
