using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200197A")]
public class CSCustomEventStorePurchaseReq
{
	[Token(Token = "0x4009FDF")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x4009FE0")]
	[FieldOffset(Offset = "0xC")]
	public uint sku_id;

	[Token(Token = "0x4009FE1")]
	[FieldOffset(Offset = "0x10")]
	public uint amount;

	[Token(Token = "0x4009FE2")]
	[FieldOffset(Offset = "0x14")]
	public uint event_id;

	[Token(Token = "0x6007FD3")]
	[Address(RVA = "0x317F558", Offset = "0x317F558", VA = "0x317F558")]
	public CSCustomEventStorePurchaseReq()
	{
	}
}
