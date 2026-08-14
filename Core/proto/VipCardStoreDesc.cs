using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BDF")]
public class VipCardStoreDesc
{
	[Token(Token = "0x400AF4F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF50")]
	[FieldOffset(Offset = "0xC")]
	public uint pos;

	[Token(Token = "0x400AF51")]
	[FieldOffset(Offset = "0x10")]
	public uint weight;

	[Token(Token = "0x400AF52")]
	[FieldOffset(Offset = "0x14")]
	public EVipCard.GoodsType type;

	[Token(Token = "0x400AF53")]
	[FieldOffset(Offset = "0x18")]
	public uint start_time;

	[Token(Token = "0x400AF54")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_time;

	[Token(Token = "0x400AF55")]
	[FieldOffset(Offset = "0x20")]
	public EVipCard.GoodsPriceType price_type;

	[Token(Token = "0x400AF56")]
	[FieldOffset(Offset = "0x24")]
	public uint price;

	[Token(Token = "0x400AF57")]
	[FieldOffset(Offset = "0x28")]
	public uint discount_price;

	[Token(Token = "0x400AF58")]
	[FieldOffset(Offset = "0x2C")]
	public uint discount;

	[Token(Token = "0x400AF59")]
	[FieldOffset(Offset = "0x30")]
	public uint purchase_limit;

	[Token(Token = "0x400AF5A")]
	[FieldOffset(Offset = "0x34")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600823A")]
	[Address(RVA = "0x33E4E08", Offset = "0x33E4E08", VA = "0x33E4E08")]
	public VipCardStoreDesc()
	{
	}
}
