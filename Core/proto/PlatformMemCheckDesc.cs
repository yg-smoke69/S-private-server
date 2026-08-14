using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B04")]
public class PlatformMemCheckDesc
{
	[Token(Token = "0x400A9E5")]
	[FieldOffset(Offset = "0x8")]
	public string client_version;

	[Token(Token = "0x400A9E6")]
	[FieldOffset(Offset = "0xC")]
	public uint platform_type;

	[Token(Token = "0x400A9E7")]
	[FieldOffset(Offset = "0x10")]
	public uint channel_type;

	[Token(Token = "0x400A9E8")]
	[FieldOffset(Offset = "0x14")]
	public uint cpu_type;

	[Token(Token = "0x400A9E9")]
	[FieldOffset(Offset = "0x18")]
	public string mem_value;

	[Token(Token = "0x400A9EA")]
	[FieldOffset(Offset = "0x1C")]
	public uint min_random_count;

	[Token(Token = "0x400A9EB")]
	[FieldOffset(Offset = "0x20")]
	public uint max_random_count;

	[Token(Token = "0x600815F")]
	[Address(RVA = "0x33DFAFC", Offset = "0x33DFAFC", VA = "0x33DFAFC")]
	public PlatformMemCheckDesc()
	{
	}
}
