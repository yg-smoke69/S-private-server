using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001736")]
public class CSFlashStorePurchaseRes
{
	[Token(Token = "0x400998F")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x4009990")]
	[FieldOffset(Offset = "0x10")]
	public ulong account_id;

	[Token(Token = "0x4009991")]
	[FieldOffset(Offset = "0x18")]
	public uint purchase_times;

	[Token(Token = "0x6007D90")]
	[Address(RVA = "0x3180758", Offset = "0x3180758", VA = "0x3180758")]
	public CSFlashStorePurchaseRes()
	{
	}
}
