using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D8D")]
public class StandardTabTagConfig
{
	[Token(Token = "0x4011777")]
	[FieldOffset(Offset = "0x8")]
	public string text;

	[Token(Token = "0x4011778")]
	[FieldOffset(Offset = "0xC")]
	public string icon;

	[Token(Token = "0x60130F7")]
	[Address(RVA = "0x288E1D4", Offset = "0x288E1D4", VA = "0x288E1D4")]
	public StandardTabTagConfig(string text, string icon)
	{
	}
}
