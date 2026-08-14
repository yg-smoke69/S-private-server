using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C29")]
public class NewPlayerCSBotPointDesc
{
	[Token(Token = "0x400B13B")]
	[FieldOffset(Offset = "0x8")]
	public uint round_lower;

	[Token(Token = "0x400B13C")]
	[FieldOffset(Offset = "0xC")]
	public uint round_upper;

	[Token(Token = "0x400B13D")]
	[FieldOffset(Offset = "0x10")]
	public uint kills_lower;

	[Token(Token = "0x400B13E")]
	[FieldOffset(Offset = "0x14")]
	public uint kills_upper;

	[Token(Token = "0x400B13F")]
	[FieldOffset(Offset = "0x18")]
	public uint death_lower;

	[Token(Token = "0x400B140")]
	[FieldOffset(Offset = "0x1C")]
	public uint death_upper;

	[Token(Token = "0x400B141")]
	[FieldOffset(Offset = "0x20")]
	public int in_game_coef;

	[Token(Token = "0x600828D")]
	[Address(RVA = "0x30A9D30", Offset = "0x30A9D30", VA = "0x30A9D30")]
	public NewPlayerCSBotPointDesc()
	{
	}
}
