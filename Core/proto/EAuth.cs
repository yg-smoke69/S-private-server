using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001452")]
public class EAuth
{
	[Token(Token = "0x2001453")]
	public enum ClientUsingVersion
	{
		[Token(Token = "0x4008D46")]
		ClientUsingVersion_NONE,
		[Token(Token = "0x4008D47")]
		ClientUsingVersion_NORMAL,
		[Token(Token = "0x4008D48")]
		ClientUsingVersion_MAX,
		[Token(Token = "0x4008D49")]
		ClientUsingVersion_FFI
	}

	[Token(Token = "0x6007AFD")]
	[Address(RVA = "0x309F260", Offset = "0x309F260", VA = "0x309F260")]
	public EAuth()
	{
	}
}
