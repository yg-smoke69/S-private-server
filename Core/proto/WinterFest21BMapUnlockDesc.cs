using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B9A")]
public class WinterFest21BMapUnlockDesc
{
	[Token(Token = "0x400ADA2")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ADA3")]
	[FieldOffset(Offset = "0xC")]
	public string cdn_url;

	[Token(Token = "0x400ADA4")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400ADA5")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400ADA6")]
	[FieldOffset(Offset = "0x20")]
	public string map_story;

	[Token(Token = "0x60081F5")]
	[Address(RVA = "0x33E5984", Offset = "0x33E5984", VA = "0x33E5984")]
	public WinterFest21BMapUnlockDesc()
	{
	}
}
