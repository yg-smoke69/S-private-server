using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C2A")]
public class VeteranCSBotPointDesc
{
	[Token(Token = "0x400B142")]
	[FieldOffset(Offset = "0x8")]
	public uint round_lower;

	[Token(Token = "0x400B143")]
	[FieldOffset(Offset = "0xC")]
	public uint round_upper;

	[Token(Token = "0x400B144")]
	[FieldOffset(Offset = "0x10")]
	public uint kills_lower;

	[Token(Token = "0x400B145")]
	[FieldOffset(Offset = "0x14")]
	public uint kills_upper;

	[Token(Token = "0x400B146")]
	[FieldOffset(Offset = "0x18")]
	public uint death_lower;

	[Token(Token = "0x400B147")]
	[FieldOffset(Offset = "0x1C")]
	public uint death_upper;

	[Token(Token = "0x400B148")]
	[FieldOffset(Offset = "0x20")]
	public int in_game_coef;

	[Token(Token = "0x600828E")]
	[Address(RVA = "0x33E4628", Offset = "0x33E4628", VA = "0x33E4628")]
	public VeteranCSBotPointDesc()
	{
	}
}
