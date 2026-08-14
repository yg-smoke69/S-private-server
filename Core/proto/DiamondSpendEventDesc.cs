using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019BA")]
public class DiamondSpendEventDesc
{
	[Token(Token = "0x400A137")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A138")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400A139")]
	[FieldOffset(Offset = "0x10")]
	public uint price_tier;

	[Token(Token = "0x400A13A")]
	[FieldOffset(Offset = "0x14")]
	public uint tier_diamond_min;

	[Token(Token = "0x400A13B")]
	[FieldOffset(Offset = "0x18")]
	public float price;

	[Token(Token = "0x400A13C")]
	[FieldOffset(Offset = "0x1C")]
	public uint start_time_stamp;

	[Token(Token = "0x400A13D")]
	[FieldOffset(Offset = "0x20")]
	public uint end_time_stamp;

	[Token(Token = "0x400A13E")]
	[FieldOffset(Offset = "0x24")]
	public uint item_id;

	[Token(Token = "0x400A13F")]
	[FieldOffset(Offset = "0x28")]
	public uint rebate_id;

	[Token(Token = "0x400A140")]
	[FieldOffset(Offset = "0x2C")]
	public uint diamond_num;

	[Token(Token = "0x6008012")]
	[Address(RVA = "0x309E780", Offset = "0x309E780", VA = "0x309E780")]
	public DiamondSpendEventDesc()
	{
	}
}
