using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200152D")]
public class GameDrop
{
	[Token(Token = "0x40091F6")]
	[FieldOffset(Offset = "0x8")]
	public uint drop_id;

	[Token(Token = "0x40091F7")]
	[FieldOffset(Offset = "0xC")]
	public Item item;

	[Token(Token = "0x40091F8")]
	[FieldOffset(Offset = "0x10")]
	public uint daily_game_drop;

	[Token(Token = "0x40091F9")]
	[FieldOffset(Offset = "0x14")]
	public uint daily_drop_limit;

	[Token(Token = "0x6007B76")]
	[Address(RVA = "0x30A18D4", Offset = "0x30A18D4", VA = "0x30A18D4")]
	public GameDrop()
	{
	}
}
