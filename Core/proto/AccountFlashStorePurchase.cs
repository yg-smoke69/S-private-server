using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001734")]
public class AccountFlashStorePurchase
{
	[Token(Token = "0x4009987")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x4009988")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_times;

	[Token(Token = "0x6007D8E")]
	[Address(RVA = "0x3179550", Offset = "0x3179550", VA = "0x3179550")]
	public AccountFlashStorePurchase()
	{
	}
}
