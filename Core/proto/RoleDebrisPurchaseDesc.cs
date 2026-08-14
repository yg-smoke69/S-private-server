using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B44")]
public class RoleDebrisPurchaseDesc
{
	[Token(Token = "0x400AB96")]
	[FieldOffset(Offset = "0x8")]
	public uint debris_id;

	[Token(Token = "0x400AB97")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_count;

	[Token(Token = "0x400AB98")]
	[FieldOffset(Offset = "0x10")]
	public uint gold_price;

	[Token(Token = "0x400AB99")]
	[FieldOffset(Offset = "0x14")]
	public uint diamond_price;

	[Token(Token = "0x600819F")]
	[Address(RVA = "0x33E1B4C", Offset = "0x33E1B4C", VA = "0x33E1B4C")]
	public RoleDebrisPurchaseDesc()
	{
	}
}
