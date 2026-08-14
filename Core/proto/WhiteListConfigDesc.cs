using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B0C")]
public class WhiteListConfigDesc
{
	[Token(Token = "0x400AA0F")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AA10")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x6008167")]
	[Address(RVA = "0x33E56A0", Offset = "0x33E56A0", VA = "0x33E56A0")]
	public WhiteListConfigDesc()
	{
	}
}
