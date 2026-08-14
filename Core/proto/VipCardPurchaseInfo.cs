using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001909")]
public class VipCardPurchaseInfo
{
	[Token(Token = "0x4009E98")]
	[FieldOffset(Offset = "0x8")]
	public uint rebate_id;

	[Token(Token = "0x4009E99")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_time;

	[Token(Token = "0x6007F62")]
	[Address(RVA = "0x33E4CA0", Offset = "0x33E4CA0", VA = "0x33E4CA0")]
	public VipCardPurchaseInfo()
	{
	}
}
