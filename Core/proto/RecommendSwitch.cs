using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B83")]
public class RecommendSwitch
{
	[Token(Token = "0x400AD09")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AD0A")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open_recommend;

	[Token(Token = "0x60081DE")]
	[Address(RVA = "0x33E1170", Offset = "0x33E1170", VA = "0x33E1170")]
	public RecommendSwitch()
	{
	}
}
