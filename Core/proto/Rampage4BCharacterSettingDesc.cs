using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C13")]
public class Rampage4BCharacterSettingDesc
{
	[Token(Token = "0x400B0AD")]
	[FieldOffset(Offset = "0x8")]
	public uint character;

	[Token(Token = "0x400B0AE")]
	[FieldOffset(Offset = "0xC")]
	public uint avatar_show_type;

	[Token(Token = "0x400B0AF")]
	[FieldOffset(Offset = "0x10")]
	public uint avatar_res_id;

	[Token(Token = "0x400B0B0")]
	[FieldOffset(Offset = "0x14")]
	public uint voice_res_id;

	[Token(Token = "0x600826D")]
	[Address(RVA = "0x33E03BC", Offset = "0x33E03BC", VA = "0x33E03BC")]
	public Rampage4BCharacterSettingDesc()
	{
	}
}
