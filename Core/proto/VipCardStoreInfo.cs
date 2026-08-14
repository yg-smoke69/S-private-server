using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001910")]
public class VipCardStoreInfo
{
	[Token(Token = "0x4009EA8")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009EA9")]
	[FieldOffset(Offset = "0xC")]
	public uint pos;

	[Token(Token = "0x4009EAA")]
	[FieldOffset(Offset = "0x10")]
	public EVipCard.GoodsType type;

	[Token(Token = "0x4009EAB")]
	[FieldOffset(Offset = "0x14")]
	public EVipCard.GoodsPriceType price_type;

	[Token(Token = "0x4009EAC")]
	[FieldOffset(Offset = "0x18")]
	public uint price;

	[Token(Token = "0x4009EAD")]
	[FieldOffset(Offset = "0x1C")]
	public uint discount_price;

	[Token(Token = "0x4009EAE")]
	[FieldOffset(Offset = "0x20")]
	public uint discount;

	[Token(Token = "0x4009EAF")]
	[FieldOffset(Offset = "0x24")]
	public uint purchase_limit;

	[Token(Token = "0x4009EB0")]
	[FieldOffset(Offset = "0x28")]
	public List<AwardDesc> awards;

	[Token(Token = "0x4009EB1")]
	[FieldOffset(Offset = "0x2C")]
	public uint purchase_time;

	[Token(Token = "0x6007F69")]
	[Address(RVA = "0x33E4E94", Offset = "0x33E4E94", VA = "0x33E4E94")]
	public VipCardStoreInfo()
	{
	}
}
