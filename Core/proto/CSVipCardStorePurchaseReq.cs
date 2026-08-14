using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001912")]
public class CSVipCardStorePurchaseReq
{
	[Token(Token = "0x4009EB3")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4009EB4")]
	[FieldOffset(Offset = "0xC")]
	public uint discount_price;

	[Token(Token = "0x6007F6B")]
	[Address(RVA = "0x309AA04", Offset = "0x309AA04", VA = "0x309AA04")]
	public CSVipCardStorePurchaseReq()
	{
	}
}
