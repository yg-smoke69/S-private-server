using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB4")]
public class LuckyWheelCommodityDesc
{
	[Token(Token = "0x400AE47")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x400AE48")]
	[FieldOffset(Offset = "0xC")]
	public uint shop_item_id;

	[Token(Token = "0x400AE49")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.AwardType item_type;

	[Token(Token = "0x400AE4A")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400AE4B")]
	[FieldOffset(Offset = "0x18")]
	public uint item_num;

	[Token(Token = "0x400AE4C")]
	[FieldOffset(Offset = "0x1C")]
	public uint item_duration;

	[Token(Token = "0x400AE4D")]
	[FieldOffset(Offset = "0x20")]
	public uint item_original_price;

	[Token(Token = "0x400AE4E")]
	[FieldOffset(Offset = "0x24")]
	public EInventory.AwardType repeated_item_type;

	[Token(Token = "0x400AE4F")]
	[FieldOffset(Offset = "0x28")]
	public uint repeated_item_id;

	[Token(Token = "0x400AE50")]
	[FieldOffset(Offset = "0x2C")]
	public uint repeated_item_num;

	[Token(Token = "0x400AE51")]
	[FieldOffset(Offset = "0x30")]
	public bool is_hot;

	[Token(Token = "0x400AE52")]
	[FieldOffset(Offset = "0x31")]
	public bool is_big_prize;

	[Token(Token = "0x600820F")]
	[Address(RVA = "0x30A6ED0", Offset = "0x30A6ED0", VA = "0x30A6ED0")]
	public LuckyWheelCommodityDesc()
	{
	}
}
