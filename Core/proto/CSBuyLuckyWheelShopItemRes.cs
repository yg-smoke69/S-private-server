using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018BA")]
public class CSBuyLuckyWheelShopItemRes
{
	[Token(Token = "0x4009DAD")]
	[FieldOffset(Offset = "0x8")]
	public CSLuckyWheelInfo wheel_info;

	[Token(Token = "0x4009DAE")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangedAward> exchanged_awards;

	[Token(Token = "0x6007F13")]
	[Address(RVA = "0x317E098", Offset = "0x317E098", VA = "0x317E098")]
	public CSBuyLuckyWheelShopItemRes()
	{
	}
}
