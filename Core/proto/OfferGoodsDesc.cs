using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019BC")]
public class OfferGoodsDesc
{
	[Token(Token = "0x400A147")]
	[FieldOffset(Offset = "0x8")]
	public uint offer_id;

	[Token(Token = "0x400A148")]
	[FieldOffset(Offset = "0xC")]
	public uint offer_goods_id;

	[Token(Token = "0x400A149")]
	[FieldOffset(Offset = "0x10")]
	public string award_name;

	[Token(Token = "0x400A14A")]
	[FieldOffset(Offset = "0x14")]
	public uint item_id;

	[Token(Token = "0x400A14B")]
	[FieldOffset(Offset = "0x18")]
	public uint award_num;

	[Token(Token = "0x400A14C")]
	[FieldOffset(Offset = "0x1C")]
	public uint award_time;

	[Token(Token = "0x400A14D")]
	[FieldOffset(Offset = "0x20")]
	public uint item_price;

	[Token(Token = "0x400A14E")]
	[FieldOffset(Offset = "0x24")]
	public uint discount_price;

	[Token(Token = "0x400A14F")]
	[FieldOffset(Offset = "0x28")]
	public uint is_force;

	[Token(Token = "0x400A150")]
	[FieldOffset(Offset = "0x2C")]
	public uint is_replenish;

	[Token(Token = "0x6008014")]
	[Address(RVA = "0x33DEB6C", Offset = "0x33DEB6C", VA = "0x33DEB6C")]
	public OfferGoodsDesc()
	{
	}
}
