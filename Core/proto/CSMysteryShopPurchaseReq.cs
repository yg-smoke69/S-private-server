using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200175D")]
public class CSMysteryShopPurchaseReq
{
	[Token(Token = "0x4009A13")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x4009A14")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x4009A15")]
	[FieldOffset(Offset = "0x10")]
	public uint price;

	[Token(Token = "0x4009A16")]
	[FieldOffset(Offset = "0x14")]
	public uint shop_id;

	[Token(Token = "0x6007DB7")]
	[Address(RVA = "0x3098124", Offset = "0x3098124", VA = "0x3098124")]
	public CSMysteryShopPurchaseReq()
	{
	}
}
