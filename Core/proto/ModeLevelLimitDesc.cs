using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019EA")]
public class ModeLevelLimitDesc
{
	[Token(Token = "0x400A2C2")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400A2C3")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A2C4")]
	[FieldOffset(Offset = "0x10")]
	public uint level;

	[Token(Token = "0x6008042")]
	[Address(RVA = "0x30A8C60", Offset = "0x30A8C60", VA = "0x30A8C60")]
	public ModeLevelLimitDesc()
	{
	}
}
