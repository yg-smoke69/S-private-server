using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001410")]
public class RegionIDMapping
{
	[Token(Token = "0x4008C28")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4008C29")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x6007AD8")]
	[Address(RVA = "0x33E1370", Offset = "0x33E1370", VA = "0x33E1370")]
	public RegionIDMapping()
	{
	}
}
