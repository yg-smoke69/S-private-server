using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B0")]
public class CSLuckyWheelInfo
{
	[Token(Token = "0x4009D8B")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x4009D8C")]
	[FieldOffset(Offset = "0xC")]
	public uint remain_free_refresh_times;

	[Token(Token = "0x4009D8D")]
	[FieldOffset(Offset = "0x10")]
	public List<CSLuckyWheelDiscountInfo> discount_info_list;

	[Token(Token = "0x4009D8E")]
	[FieldOffset(Offset = "0x14")]
	public uint[] current_shop_item_id_list;

	[Token(Token = "0x4009D8F")]
	[FieldOffset(Offset = "0x18")]
	public List<CSLuckyWheelShopItemInfo> shop_item_info_list;

	[Token(Token = "0x6007F09")]
	[Address(RVA = "0x3097978", Offset = "0x3097978", VA = "0x3097978")]
	public CSLuckyWheelInfo()
	{
	}
}
