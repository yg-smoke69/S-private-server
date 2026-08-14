using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014D7")]
public class AccountInfoWithChummyState
{
	[Token(Token = "0x4009005")]
	[FieldOffset(Offset = "0x8")]
	public ChummyState chummy_state;

	[Token(Token = "0x4009006")]
	[FieldOffset(Offset = "0xC")]
	public AccountInfoBasic chummy_info;

	[Token(Token = "0x6007B2C")]
	[Address(RVA = "0x31797A4", Offset = "0x31797A4", VA = "0x31797A4")]
	public AccountInfoWithChummyState()
	{
	}
}
