using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A1A")]
public class RenameCostDesc
{
	[Token(Token = "0x400A3A1")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3A2")]
	[FieldOffset(Offset = "0xC")]
	public uint diamond_cost;

	[Token(Token = "0x400A3A3")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A3A4")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400A3A5")]
	[FieldOffset(Offset = "0x18")]
	public uint on_sale_cost;

	[Token(Token = "0x6008072")]
	[Address(RVA = "0x33E172C", Offset = "0x33E172C", VA = "0x33E172C")]
	public RenameCostDesc()
	{
	}
}
