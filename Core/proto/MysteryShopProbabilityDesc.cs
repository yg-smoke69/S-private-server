using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC7")]
public class MysteryShopProbabilityDesc
{
	[Token(Token = "0x400A899")]
	[FieldOffset(Offset = "0x8")]
	public uint mystery_shop_id;

	[Token(Token = "0x400A89A")]
	[FieldOffset(Offset = "0xC")]
	public uint start_stage;

	[Token(Token = "0x400A89B")]
	[FieldOffset(Offset = "0x10")]
	public uint end_stage;

	[Token(Token = "0x400A89C")]
	[FieldOffset(Offset = "0x14")]
	public uint probability_weight;

	[Token(Token = "0x6008124")]
	[Address(RVA = "0x30A9B1C", Offset = "0x30A9B1C", VA = "0x30A9B1C")]
	public MysteryShopProbabilityDesc()
	{
	}
}
