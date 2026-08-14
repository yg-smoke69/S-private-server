using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C26")]
public class VeteranBotPointInitDesc
{
	[Token(Token = "0x400B128")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400B129")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400B12A")]
	[FieldOffset(Offset = "0x10")]
	public uint init_bot_point;

	[Token(Token = "0x600828A")]
	[Address(RVA = "0x33E4588", Offset = "0x33E4588", VA = "0x33E4588")]
	public VeteranBotPointInitDesc()
	{
	}
}
