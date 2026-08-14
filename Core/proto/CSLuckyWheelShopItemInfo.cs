using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B3")]
public class CSLuckyWheelShopItemInfo
{
	[Token(Token = "0x4009D99")]
	[FieldOffset(Offset = "0x8")]
	public uint shop_item_id;

	[Token(Token = "0x4009D9A")]
	[FieldOffset(Offset = "0xC")]
	public bool is_purchased;

	[Token(Token = "0x6007F0C")]
	[Address(RVA = "0x3097A50", Offset = "0x3097A50", VA = "0x3097A50")]
	public CSLuckyWheelShopItemInfo()
	{
	}
}
