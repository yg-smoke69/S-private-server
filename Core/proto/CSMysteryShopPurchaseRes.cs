using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200175E")]
public class CSMysteryShopPurchaseRes
{
	[Token(Token = "0x4009A17")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x4009A18")]
	[FieldOffset(Offset = "0xC")]
	public uint pool_id;

	[Token(Token = "0x4009A19")]
	[FieldOffset(Offset = "0x10")]
	public uint cost_gems;

	[Token(Token = "0x4009A1A")]
	[FieldOffset(Offset = "0x14")]
	public uint purchase_count;

	[Token(Token = "0x6007DB8")]
	[Address(RVA = "0x309812C", Offset = "0x309812C", VA = "0x309812C")]
	public CSMysteryShopPurchaseRes()
	{
	}
}
