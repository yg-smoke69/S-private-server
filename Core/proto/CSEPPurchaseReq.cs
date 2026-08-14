using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F7")]
public class CSEPPurchaseReq
{
	[Token(Token = "0x4009827")]
	[FieldOffset(Offset = "0x8")]
	public bool is_bundle;

	[Token(Token = "0x4009828")]
	[FieldOffset(Offset = "0x9")]
	public bool is_customized_discount;

	[Token(Token = "0x6007D51")]
	[Address(RVA = "0x317FC7C", Offset = "0x317FC7C", VA = "0x317FC7C")]
	public CSEPPurchaseReq()
	{
	}
}
