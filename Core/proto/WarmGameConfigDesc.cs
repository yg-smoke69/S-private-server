using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A1B")]
public class WarmGameConfigDesc
{
	[Token(Token = "0x400A3A6")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3A7")]
	[FieldOffset(Offset = "0xC")]
	public EAccount.WarmGameType type;

	[Token(Token = "0x400A3A8")]
	[FieldOffset(Offset = "0x10")]
	public uint warm_games;

	[Token(Token = "0x400A3A9")]
	[FieldOffset(Offset = "0x14")]
	public uint[] warm_game_level;

	[Token(Token = "0x400A3AA")]
	[FieldOffset(Offset = "0x18")]
	public bool is_open;

	[Token(Token = "0x6008073")]
	[Address(RVA = "0x33E5078", Offset = "0x33E5078", VA = "0x33E5078")]
	public WarmGameConfigDesc()
	{
	}
}
