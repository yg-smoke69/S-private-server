using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD0")]
public class WinterFestStrategySettingDesc
{
	[Token(Token = "0x400AEFB")]
	[FieldOffset(Offset = "0x8")]
	public uint help_receive;

	[Token(Token = "0x400AEFC")]
	[FieldOffset(Offset = "0xC")]
	public uint help_order;

	[Token(Token = "0x400AEFD")]
	[FieldOffset(Offset = "0x10")]
	public uint help_order_limit;

	[Token(Token = "0x400AEFE")]
	[FieldOffset(Offset = "0x14")]
	public uint sugar_crystal;

	[Token(Token = "0x400AEFF")]
	[FieldOffset(Offset = "0x18")]
	public uint sugar_alloy;

	[Token(Token = "0x400AF00")]
	[FieldOffset(Offset = "0x1C")]
	public uint sugar_battery;

	[Token(Token = "0x400AF01")]
	[FieldOffset(Offset = "0x20")]
	public uint sugar_plastic;

	[Token(Token = "0x400AF02")]
	[FieldOffset(Offset = "0x24")]
	public uint upgrade_material;

	[Token(Token = "0x400AF03")]
	[FieldOffset(Offset = "0x28")]
	public uint token_id;

	[Token(Token = "0x400AF04")]
	[FieldOffset(Offset = "0x2C")]
	public uint crystal_id;

	[Token(Token = "0x400AF05")]
	[FieldOffset(Offset = "0x30")]
	public uint alloy_id;

	[Token(Token = "0x400AF06")]
	[FieldOffset(Offset = "0x34")]
	public uint battery_id;

	[Token(Token = "0x400AF07")]
	[FieldOffset(Offset = "0x38")]
	public uint plastic_id;

	[Token(Token = "0x600822B")]
	[Address(RVA = "0x33E5ED8", Offset = "0x33E5ED8", VA = "0x33E5ED8")]
	public WinterFestStrategySettingDesc()
	{
	}
}
