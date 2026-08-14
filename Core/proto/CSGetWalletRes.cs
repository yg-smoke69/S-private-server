using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015AD")]
public class CSGetWalletRes
{
	[Token(Token = "0x40093E3")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40093E4")]
	[FieldOffset(Offset = "0x10")]
	public AccountWallet wallet;

	[Token(Token = "0x6007BF5")]
	[Address(RVA = "0x30965C8", Offset = "0x30965C8", VA = "0x30965C8")]
	public CSGetWalletRes()
	{
	}
}
