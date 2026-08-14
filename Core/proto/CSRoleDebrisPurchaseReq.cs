using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C3")]
public class CSRoleDebrisPurchaseReq
{
	[Token(Token = "0x400943C")]
	[FieldOffset(Offset = "0x8")]
	public uint debris_id;

	[Token(Token = "0x400943D")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_count;

	[Token(Token = "0x400943E")]
	[FieldOffset(Offset = "0x10")]
	public uint cnt;

	[Token(Token = "0x400943F")]
	[FieldOffset(Offset = "0x14")]
	public EInventory.CurrencyType currency_type;

	[Token(Token = "0x4009440")]
	[FieldOffset(Offset = "0x18")]
	public uint price;

	[Token(Token = "0x4009441")]
	[FieldOffset(Offset = "0x1C")]
	public uint voucher_id;

	[Token(Token = "0x6007C0D")]
	[Address(RVA = "0x3099550", Offset = "0x3099550", VA = "0x3099550")]
	public CSRoleDebrisPurchaseReq()
	{
	}
}
