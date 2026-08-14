using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001733")]
public class CSGetFlashStoreAccountInfoRes
{
	[Token(Token = "0x4009984")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009985")]
	[FieldOffset(Offset = "0x10")]
	public uint flash_store_id;

	[Token(Token = "0x4009986")]
	[FieldOffset(Offset = "0x14")]
	public List<AccountFlashStorePurchase> account_flash_store_purchase;

	[Token(Token = "0x6007D8D")]
	[Address(RVA = "0x3184D8C", Offset = "0x3184D8C", VA = "0x3184D8C")]
	public CSGetFlashStoreAccountInfoRes()
	{
	}
}
