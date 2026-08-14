using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015AC")]
public class CSGetWalletReq
{
	[Token(Token = "0x40093E1")]
	[FieldOffset(Offset = "0x8")]
	public string login_token;

	[Token(Token = "0x40093E2")]
	[FieldOffset(Offset = "0xC")]
	public bool topup_rebate;

	[Token(Token = "0x6007BF4")]
	[Address(RVA = "0x3096528", Offset = "0x3096528", VA = "0x3096528")]
	public CSGetWalletReq()
	{
	}
}
