using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200150B")]
public class CSActivateAccountReq
{
	[Token(Token = "0x4009096")]
	[FieldOffset(Offset = "0x8")]
	public string email;

	[Token(Token = "0x4009097")]
	[FieldOffset(Offset = "0xC")]
	public string code;

	[Token(Token = "0x6007B54")]
	[Address(RVA = "0x317D94C", Offset = "0x317D94C", VA = "0x317D94C")]
	public CSActivateAccountReq()
	{
	}
}
