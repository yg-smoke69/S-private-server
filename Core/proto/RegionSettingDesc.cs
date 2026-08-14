using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F8")]
public class RegionSettingDesc
{
	[Token(Token = "0x400A300")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A301")]
	[FieldOffset(Offset = "0xC")]
	public string region_server;

	[Token(Token = "0x6008050")]
	[Address(RVA = "0x33E167C", Offset = "0x33E167C", VA = "0x33E167C")]
	public RegionSettingDesc()
	{
	}
}
