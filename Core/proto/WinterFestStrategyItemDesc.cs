using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD1")]
public class WinterFestStrategyItemDesc
{
	[Token(Token = "0x400AF08")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF09")]
	[FieldOffset(Offset = "0xC")]
	public string item_name;

	[Token(Token = "0x400AF0A")]
	[FieldOffset(Offset = "0x10")]
	public string item_desc;

	[Token(Token = "0x400AF0B")]
	[FieldOffset(Offset = "0x14")]
	public string item_icon;

	[Token(Token = "0x400AF0C")]
	[FieldOffset(Offset = "0x18")]
	public uint item_source;

	[Token(Token = "0x600822C")]
	[Address(RVA = "0x33E5C7C", Offset = "0x33E5C7C", VA = "0x33E5C7C")]
	public WinterFestStrategyItemDesc()
	{
	}
}
