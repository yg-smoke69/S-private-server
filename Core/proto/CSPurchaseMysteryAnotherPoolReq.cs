using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001755")]
public class CSPurchaseMysteryAnotherPoolReq
{
	[Token(Token = "0x40099FD")]
	[FieldOffset(Offset = "0x8")]
	public uint price;

	[Token(Token = "0x40099FE")]
	[FieldOffset(Offset = "0xC")]
	public uint shop_id;

	[Token(Token = "0x6007DAF")]
	[Address(RVA = "0x30989C8", Offset = "0x30989C8", VA = "0x30989C8")]
	public CSPurchaseMysteryAnotherPoolReq()
	{
	}
}
