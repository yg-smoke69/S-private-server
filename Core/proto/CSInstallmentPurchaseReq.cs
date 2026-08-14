using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200174F")]
public class CSInstallmentPurchaseReq
{
	[Token(Token = "0x40099E5")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x40099E6")]
	[FieldOffset(Offset = "0xC")]
	public uint price;

	[Token(Token = "0x40099E7")]
	[FieldOffset(Offset = "0x10")]
	public bool is_one_time_payment;

	[Token(Token = "0x6007DA9")]
	[Address(RVA = "0x3097418", Offset = "0x3097418", VA = "0x3097418")]
	public CSInstallmentPurchaseReq()
	{
	}
}
