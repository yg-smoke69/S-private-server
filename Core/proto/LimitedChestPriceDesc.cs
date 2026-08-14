using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE5")]
public class LimitedChestPriceDesc
{
	[Token(Token = "0x400AF99")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400AF9A")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400AF9B")]
	[FieldOffset(Offset = "0x10")]
	public uint coin_type;

	[Token(Token = "0x400AF9C")]
	[FieldOffset(Offset = "0x14")]
	public uint draw_num;

	[Token(Token = "0x400AF9D")]
	[FieldOffset(Offset = "0x18")]
	public uint[] multi_once_price;

	[Token(Token = "0x400AF9E")]
	[FieldOffset(Offset = "0x20")]
	public long limit_start_time;

	[Token(Token = "0x400AF9F")]
	[FieldOffset(Offset = "0x28")]
	public long limit_end_time;

	[Token(Token = "0x400AFA0")]
	[FieldOffset(Offset = "0x30")]
	public uint[] limit_price_one;

	[Token(Token = "0x400AFA1")]
	[FieldOffset(Offset = "0x34")]
	public uint[] price_one_type;

	[Token(Token = "0x6008240")]
	[Address(RVA = "0x30A494C", Offset = "0x30A494C", VA = "0x30A494C")]
	public LimitedChestPriceDesc()
	{
	}
}
