using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200172F")]
public class CSExchangeStorePurchaseRes
{
	[Token(Token = "0x400997E")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x400997F")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_times;

	[Token(Token = "0x6007D89")]
	[Address(RVA = "0x317FF2C", Offset = "0x317FF2C", VA = "0x317FF2C")]
	public CSExchangeStorePurchaseRes()
	{
	}
}
