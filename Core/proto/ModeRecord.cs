using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B6C")]
public class ModeRecord
{
	[Token(Token = "0x400AC83")]
	[FieldOffset(Offset = "0x8")]
	public uint match_mode;

	[Token(Token = "0x400AC84")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x60081C7")]
	[Address(RVA = "0x30A8CF4", Offset = "0x30A8CF4", VA = "0x30A8CF4")]
	public ModeRecord()
	{
	}
}
