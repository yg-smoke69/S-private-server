using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001746")]
public class CSDiscountStorePurchaseReq
{
	[Token(Token = "0x40099C3")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x40099C4")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x40099C5")]
	[FieldOffset(Offset = "0x10")]
	public uint cnt;

	[Token(Token = "0x40099C6")]
	[FieldOffset(Offset = "0x14")]
	public EInventory.CurrencyType currency_type;

	[Token(Token = "0x40099C7")]
	[FieldOffset(Offset = "0x18")]
	public uint price;

	[Token(Token = "0x40099C8")]
	[FieldOffset(Offset = "0x1C")]
	public uint voucher_id;

	[Token(Token = "0x6007DA0")]
	[Address(RVA = "0x317F9DC", Offset = "0x317F9DC", VA = "0x317F9DC")]
	public CSDiscountStorePurchaseReq()
	{
	}
}
