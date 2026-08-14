using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B7E")]
public class QuitControlDesc
{
	[Token(Token = "0x400ACF5")]
	[FieldOffset(Offset = "0x8")]
	public uint match_mode;

	[Token(Token = "0x400ACF6")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400ACF7")]
	[FieldOffset(Offset = "0x10")]
	public bool delayed_exit;

	[Token(Token = "0x60081D9")]
	[Address(RVA = "0x33E03AC", Offset = "0x33E03AC", VA = "0x33E03AC")]
	public QuitControlDesc()
	{
	}
}
