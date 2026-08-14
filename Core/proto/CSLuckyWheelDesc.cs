using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018AF")]
public class CSLuckyWheelDesc
{
	[Token(Token = "0x4009D83")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x4009D84")]
	[FieldOffset(Offset = "0x10")]
	public long start_time_stamp;

	[Token(Token = "0x4009D85")]
	[FieldOffset(Offset = "0x18")]
	public long end_time_stamp;

	[Token(Token = "0x4009D86")]
	[FieldOffset(Offset = "0x20")]
	public uint total_free_refresh_times;

	[Token(Token = "0x4009D87")]
	[FieldOffset(Offset = "0x24")]
	public uint refresh_currency_amount;

	[Token(Token = "0x4009D88")]
	[FieldOffset(Offset = "0x28")]
	public bool is_show_weight;

	[Token(Token = "0x4009D89")]
	[FieldOffset(Offset = "0x2C")]
	public List<CSLuckyWheelDiscountDesc> discount_desc_list;

	[Token(Token = "0x4009D8A")]
	[FieldOffset(Offset = "0x30")]
	public List<CSLuckyWheelShopItemDesc> shop_item_desc_list;

	[Token(Token = "0x6007F08")]
	[Address(RVA = "0x30978A8", Offset = "0x30978A8", VA = "0x30978A8")]
	public CSLuckyWheelDesc()
	{
	}
}
