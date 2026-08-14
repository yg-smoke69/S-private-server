using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AFF")]
public class GameServerNodeManagerDesc
{
	[Token(Token = "0x400A9D8")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A9D9")]
	[FieldOffset(Offset = "0xC")]
	public string node_name;

	[Token(Token = "0x400A9DA")]
	[FieldOffset(Offset = "0x10")]
	public string server_ip;

	[Token(Token = "0x400A9DB")]
	[FieldOffset(Offset = "0x14")]
	public bool is_default;

	[Token(Token = "0x400A9DC")]
	[FieldOffset(Offset = "0x18")]
	public uint warn_capacity;

	[Token(Token = "0x600815A")]
	[Address(RVA = "0x30A1C98", Offset = "0x30A1C98", VA = "0x30A1C98")]
	public GameServerNodeManagerDesc()
	{
	}
}
