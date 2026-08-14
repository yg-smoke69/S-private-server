using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019FE")]
public class RegionDesc
{
	[Token(Token = "0x400A314")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A315")]
	[FieldOffset(Offset = "0xC")]
	public string region_server;

	[Token(Token = "0x400A316")]
	[FieldOffset(Offset = "0x10")]
	public string notification_region_server;

	[Token(Token = "0x400A317")]
	[FieldOffset(Offset = "0x14")]
	public uint voice_type;

	[Token(Token = "0x400A318")]
	[FieldOffset(Offset = "0x18")]
	public uint voice_server;

	[Token(Token = "0x400A319")]
	[FieldOffset(Offset = "0x1C")]
	public uint chat_server;

	[Token(Token = "0x400A31A")]
	[FieldOffset(Offset = "0x20")]
	public bool open;

	[Token(Token = "0x400A31B")]
	[FieldOffset(Offset = "0x24")]
	public string voice_server_url;

	[Token(Token = "0x6008056")]
	[Address(RVA = "0x33E12B8", Offset = "0x33E12B8", VA = "0x33E12B8")]
	public RegionDesc()
	{
	}
}
