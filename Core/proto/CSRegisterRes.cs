using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001501")]
public class CSRegisterRes
{
	[Token(Token = "0x4009085")]
	[FieldOffset(Offset = "0x8")]
	public bool success;

	[Token(Token = "0x4009086")]
	[FieldOffset(Offset = "0xC")]
	public string reason;

	[Token(Token = "0x6007B4A")]
	[Address(RVA = "0x3099040", Offset = "0x3099040", VA = "0x3099040")]
	public CSRegisterRes()
	{
	}
}
