using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC0")]
public class MysteryShopSwitchDesc
{
	[Token(Token = "0x400A862")]
	[FieldOffset(Offset = "0x8")]
	public string melon_pi_api_classes;

	[Token(Token = "0x400A863")]
	[FieldOffset(Offset = "0xC")]
	public uint mystery_shop_id;

	[Token(Token = "0x400A864")]
	[FieldOffset(Offset = "0x10")]
	public uint mystery_shop_pool_id;

	[Token(Token = "0x400A865")]
	[FieldOffset(Offset = "0x14")]
	public uint weight;

	[Token(Token = "0x400A866")]
	[FieldOffset(Offset = "0x18")]
	public uint unlock_amount;

	[Token(Token = "0x400A867")]
	[FieldOffset(Offset = "0x1C")]
	public uint switch_amount;

	[Token(Token = "0x400A868")]
	[FieldOffset(Offset = "0x20")]
	public string shop_cdn;

	[Token(Token = "0x400A869")]
	[FieldOffset(Offset = "0x24")]
	public string switch_cdn;

	[Token(Token = "0x400A86A")]
	[FieldOffset(Offset = "0x28")]
	public string pool_center_cdn;

	[Token(Token = "0x400A86B")]
	[FieldOffset(Offset = "0x2C")]
	public uint weight_arm1;

	[Token(Token = "0x400A86C")]
	[FieldOffset(Offset = "0x30")]
	public uint weight_arm2;

	[Token(Token = "0x400A86D")]
	[FieldOffset(Offset = "0x34")]
	public uint weight_arm3;

	[Token(Token = "0x400A86E")]
	[FieldOffset(Offset = "0x38")]
	public uint weight_arm4;

	[Token(Token = "0x600811D")]
	[Address(RVA = "0x30A9B24", Offset = "0x30A9B24", VA = "0x30A9B24")]
	public MysteryShopSwitchDesc()
	{
	}
}
