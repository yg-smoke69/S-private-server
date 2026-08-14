using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA0")]
public class ChestPriceDesc
{
	[Token(Token = "0x400A71F")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A720")]
	[FieldOffset(Offset = "0xC")]
	public uint coin_type;

	[Token(Token = "0x400A721")]
	[FieldOffset(Offset = "0x10")]
	public uint once_price;

	[Token(Token = "0x400A722")]
	[FieldOffset(Offset = "0x14")]
	public uint ten_price;

	[Token(Token = "0x400A723")]
	[FieldOffset(Offset = "0x18")]
	public long limit_start_time;

	[Token(Token = "0x400A724")]
	[FieldOffset(Offset = "0x20")]
	public long limit_end_time;

	[Token(Token = "0x400A725")]
	[FieldOffset(Offset = "0x28")]
	public uint limit_num_one;

	[Token(Token = "0x400A726")]
	[FieldOffset(Offset = "0x2C")]
	public uint[] limit_price_one;

	[Token(Token = "0x400A727")]
	[FieldOffset(Offset = "0x30")]
	public uint limit_num_ten;

	[Token(Token = "0x400A728")]
	[FieldOffset(Offset = "0x34")]
	public uint[] limit_price_ten;

	[Token(Token = "0x400A729")]
	[FieldOffset(Offset = "0x38")]
	public uint[] exchange_itemid;

	[Token(Token = "0x400A72A")]
	[FieldOffset(Offset = "0x3C")]
	public uint exchange_once_num;

	[Token(Token = "0x400A72B")]
	[FieldOffset(Offset = "0x40")]
	public uint exchange_ten_num;

	[Token(Token = "0x400A72C")]
	[FieldOffset(Offset = "0x44")]
	public uint free_type;

	[Token(Token = "0x400A72D")]
	[FieldOffset(Offset = "0x48")]
	public uint free_cd;

	[Token(Token = "0x400A72E")]
	[FieldOffset(Offset = "0x4C")]
	public uint once_num;

	[Token(Token = "0x400A72F")]
	[FieldOffset(Offset = "0x50")]
	public uint ten_num;

	[Token(Token = "0x400A730")]
	[FieldOffset(Offset = "0x54")]
	public uint chest_sub_id;

	[Token(Token = "0x400A731")]
	[FieldOffset(Offset = "0x58")]
	public uint limit_num;

	[Token(Token = "0x400A732")]
	[FieldOffset(Offset = "0x5C")]
	public uint limit_type;

	[Token(Token = "0x400A733")]
	[FieldOffset(Offset = "0x60")]
	public uint[] multi_once_price;

	[Token(Token = "0x400A734")]
	[FieldOffset(Offset = "0x64")]
	public uint[] price_one_type;

	[Token(Token = "0x400A735")]
	[FieldOffset(Offset = "0x68")]
	public uint buff_up_price;

	[Token(Token = "0x400A736")]
	[FieldOffset(Offset = "0x6C")]
	public uint buff_reset_price;

	[Token(Token = "0x60080FD")]
	[Address(RVA = "0x309B588", Offset = "0x309B588", VA = "0x309B588")]
	public ChestPriceDesc()
	{
	}
}
