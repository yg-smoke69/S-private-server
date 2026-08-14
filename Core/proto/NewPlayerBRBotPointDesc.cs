using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C27")]
public class NewPlayerBRBotPointDesc
{
	[Token(Token = "0x400B12B")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400B12C")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_lower;

	[Token(Token = "0x400B12D")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_upper;

	[Token(Token = "0x400B12E")]
	[FieldOffset(Offset = "0x14")]
	public uint survive_time_lower;

	[Token(Token = "0x400B12F")]
	[FieldOffset(Offset = "0x18")]
	public uint survive_time_upper;

	[Token(Token = "0x400B130")]
	[FieldOffset(Offset = "0x1C")]
	public uint kills_lower;

	[Token(Token = "0x400B131")]
	[FieldOffset(Offset = "0x20")]
	public uint kills_upper;

	[Token(Token = "0x400B132")]
	[FieldOffset(Offset = "0x24")]
	public int in_game_coef;

	[Token(Token = "0x600828B")]
	[Address(RVA = "0x30A9C88", Offset = "0x30A9C88", VA = "0x30A9C88")]
	public NewPlayerBRBotPointDesc()
	{
	}
}
