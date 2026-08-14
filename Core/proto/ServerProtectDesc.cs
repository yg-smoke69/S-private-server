using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B7C")]
public class ServerProtectDesc
{
	[Token(Token = "0x400ACE8")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400ACE9")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x400ACEA")]
	[FieldOffset(Offset = "0x10")]
	public uint allow_percent;

	[Token(Token = "0x60081D7")]
	[Address(RVA = "0x33E21FC", Offset = "0x33E21FC", VA = "0x33E21FC")]
	public ServerProtectDesc()
	{
	}
}
