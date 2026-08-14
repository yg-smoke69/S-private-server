using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017E8")]
public class CSLimitedEventStorePurchaseReq
{
	[Token(Token = "0x4009BA6")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x4009BA7")]
	[FieldOffset(Offset = "0xC")]
	public uint store_id;

	[Token(Token = "0x4009BA8")]
	[FieldOffset(Offset = "0x10")]
	public uint sku_id;

	[Token(Token = "0x4009BA9")]
	[FieldOffset(Offset = "0x14")]
	public uint cnt;

	[Token(Token = "0x4009BAA")]
	[FieldOffset(Offset = "0x18")]
	public uint currency_id;

	[Token(Token = "0x4009BAB")]
	[FieldOffset(Offset = "0x1C")]
	public uint currency_price;

	[Token(Token = "0x6007E42")]
	[Address(RVA = "0x30976E4", Offset = "0x30976E4", VA = "0x30976E4")]
	public CSLimitedEventStorePurchaseReq()
	{
	}
}
