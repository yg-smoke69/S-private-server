using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C25")]
public class NewPlayerBotPointInitDesc
{
	[Token(Token = "0x400B125")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400B126")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400B127")]
	[FieldOffset(Offset = "0x10")]
	public uint init_bot_point;

	[Token(Token = "0x6008289")]
	[Address(RVA = "0x30A9C90", Offset = "0x30A9C90", VA = "0x30A9C90")]
	public NewPlayerBotPointInitDesc()
	{
	}
}
