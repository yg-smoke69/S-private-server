using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001747")]
public class CSDiscountStorePurchaseRes
{
	[Token(Token = "0x40099C9")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x40099CA")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_count;

	[Token(Token = "0x6007DA1")]
	[Address(RVA = "0x317F9E4", Offset = "0x317F9E4", VA = "0x317F9E4")]
	public CSDiscountStorePurchaseRes()
	{
	}
}
