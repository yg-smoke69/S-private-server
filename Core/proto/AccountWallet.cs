using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B8")]
public class AccountWallet
{
	[Token(Token = "0x400941D")]
	[FieldOffset(Offset = "0x8")]
	public uint coins;

	[Token(Token = "0x400941E")]
	[FieldOffset(Offset = "0xC")]
	public int gems;

	[Token(Token = "0x400941F")]
	[FieldOffset(Offset = "0x10")]
	public uint gop_gems;

	[Token(Token = "0x4009420")]
	[FieldOffset(Offset = "0x18")]
	public ulong total_topup;

	[Token(Token = "0x4009421")]
	[FieldOffset(Offset = "0x20")]
	public long last_topup_time;

	[Token(Token = "0x6007C02")]
	[Address(RVA = "0x3179D94", Offset = "0x3179D94", VA = "0x3179D94")]
	public AccountWallet()
	{
	}
}
