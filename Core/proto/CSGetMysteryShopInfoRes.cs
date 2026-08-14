using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001759")]
public class CSGetMysteryShopInfoRes
{
	[Token(Token = "0x4009A04")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009A05")]
	[FieldOffset(Offset = "0x10")]
	public uint discount;

	[Token(Token = "0x4009A06")]
	[FieldOffset(Offset = "0x14")]
	public uint cur_pool_id;

	[Token(Token = "0x4009A07")]
	[FieldOffset(Offset = "0x18")]
	public uint another_pool_id;

	[Token(Token = "0x4009A08")]
	[FieldOffset(Offset = "0x1C")]
	public bool switch_open;

	[Token(Token = "0x4009A09")]
	[FieldOffset(Offset = "0x20")]
	public uint discount_show;

	[Token(Token = "0x4009A0A")]
	[FieldOffset(Offset = "0x24")]
	public uint shop_id;

	[Token(Token = "0x6007DB3")]
	[Address(RVA = "0x3188010", Offset = "0x3188010", VA = "0x3188010")]
	public CSGetMysteryShopInfoRes()
	{
	}
}
