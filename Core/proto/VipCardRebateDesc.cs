using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE2")]
public class VipCardRebateDesc
{
	[Token(Token = "0x400AF63")]
	[FieldOffset(Offset = "0x8")]
	public uint rebate_id;

	[Token(Token = "0x400AF64")]
	[FieldOffset(Offset = "0xC")]
	public List<EVipCard.RebateType> type;

	[Token(Token = "0x400AF65")]
	[FieldOffset(Offset = "0x10")]
	public uint start_time;

	[Token(Token = "0x400AF66")]
	[FieldOffset(Offset = "0x14")]
	public uint end_time;

	[Token(Token = "0x400AF67")]
	[FieldOffset(Offset = "0x18")]
	public uint purchase_times;

	[Token(Token = "0x400AF68")]
	[FieldOffset(Offset = "0x1C")]
	public uint gem_return;

	[Token(Token = "0x400AF69")]
	[FieldOffset(Offset = "0x20")]
	public float price;

	[Token(Token = "0x400AF6A")]
	[FieldOffset(Offset = "0x24")]
	public float discount_price;

	[Token(Token = "0x400AF6B")]
	[FieldOffset(Offset = "0x28")]
	public string product_identifier;

	[Token(Token = "0x400AF6C")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_drop_from_iap;

	[Token(Token = "0x400AF6D")]
	[FieldOffset(Offset = "0x30")]
	public uint warn_time;

	[Token(Token = "0x600823D")]
	[Address(RVA = "0x33E4CA8", Offset = "0x33E4CA8", VA = "0x33E4CA8")]
	public VipCardRebateDesc()
	{
	}
}
