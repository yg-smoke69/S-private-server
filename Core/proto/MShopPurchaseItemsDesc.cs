using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B03")]
public class MShopPurchaseItemsDesc
{
	[Token(Token = "0x400A9E3")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A9E4")]
	[FieldOffset(Offset = "0xC")]
	public EStore.PurchaseItemChannel channel;

	[Token(Token = "0x600815E")]
	[Address(RVA = "0x30A7148", Offset = "0x30A7148", VA = "0x30A7148")]
	public MShopPurchaseItemsDesc()
	{
	}
}
