using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B9")]
public class CSBuyLuckyWheelShopItemReq
{
	[Token(Token = "0x4009DAB")]
	[FieldOffset(Offset = "0x8")]
	public uint wheel_id;

	[Token(Token = "0x4009DAC")]
	[FieldOffset(Offset = "0xC")]
	public uint shop_item_id;

	[Token(Token = "0x6007F12")]
	[Address(RVA = "0x317E090", Offset = "0x317E090", VA = "0x317E090")]
	public CSBuyLuckyWheelShopItemReq()
	{
	}
}
