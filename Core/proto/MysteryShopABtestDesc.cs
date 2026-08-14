using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC5")]
public class MysteryShopABtestDesc
{
	[Token(Token = "0x400A893")]
	[FieldOffset(Offset = "0x8")]
	public uint mystery_shop_id;

	[Token(Token = "0x400A894")]
	[FieldOffset(Offset = "0xC")]
	public string @class;

	[Token(Token = "0x400A895")]
	[FieldOffset(Offset = "0x10")]
	public uint original_melon_pi;

	[Token(Token = "0x400A896")]
	[FieldOffset(Offset = "0x14")]
	public uint abtest_melon_pi;

	[Token(Token = "0x6008122")]
	[Address(RVA = "0x30A9828", Offset = "0x30A9828", VA = "0x30A9828")]
	public MysteryShopABtestDesc()
	{
	}
}
