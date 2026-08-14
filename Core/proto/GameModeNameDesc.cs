using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E4")]
public class GameModeNameDesc
{
	[Token(Token = "0x400A2AC")]
	[FieldOffset(Offset = "0x8")]
	public uint mode_id;

	[Token(Token = "0x400A2AD")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x400A2AE")]
	[FieldOffset(Offset = "0x10")]
	public string translation;

	[Token(Token = "0x600803C")]
	[Address(RVA = "0x30A1994", Offset = "0x30A1994", VA = "0x30A1994")]
	public GameModeNameDesc()
	{
	}
}
