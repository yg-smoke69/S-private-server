using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2000241")]
internal class TDMLikeShopItem
{
	[Token(Token = "0x4000DC3")]
	[FieldOffset(Offset = "0x8")]
	public uint ItemId;

	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0xC")]
	public uint Count;

	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x28924E4", Offset = "0x28924E4", VA = "0x28924E4")]
	public TDMLikeShopItem()
	{
	}

	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x28932FC", Offset = "0x28932FC", VA = "0x28932FC")]
	public TDMLikeShopItem(PABEENFAMLF syncData)
	{
	}
}
