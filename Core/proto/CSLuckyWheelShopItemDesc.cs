using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B4")]
public class CSLuckyWheelShopItemDesc
{
	[Token(Token = "0x4009D9B")]
	[FieldOffset(Offset = "0x8")]
	public uint shop_item_id;

	[Token(Token = "0x4009D9C")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.AwardType item_type;

	[Token(Token = "0x4009D9D")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x4009D9E")]
	[FieldOffset(Offset = "0x14")]
	public uint item_num;

	[Token(Token = "0x4009D9F")]
	[FieldOffset(Offset = "0x18")]
	public uint item_duration;

	[Token(Token = "0x4009DA0")]
	[FieldOffset(Offset = "0x1C")]
	public uint item_original_price;

	[Token(Token = "0x4009DA1")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType repeated_item_type;

	[Token(Token = "0x4009DA2")]
	[FieldOffset(Offset = "0x24")]
	public uint repeated_item_id;

	[Token(Token = "0x4009DA3")]
	[FieldOffset(Offset = "0x28")]
	public uint repeated_item_num;

	[Token(Token = "0x4009DA4")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_hot;

	[Token(Token = "0x4009DA5")]
	[FieldOffset(Offset = "0x2D")]
	public bool is_big_prize;

	[Token(Token = "0x6007F0D")]
	[Address(RVA = "0x3097A48", Offset = "0x3097A48", VA = "0x3097A48")]
	public CSLuckyWheelShopItemDesc()
	{
	}
}
