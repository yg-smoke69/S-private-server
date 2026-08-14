using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C15")]
public class Rampage4BTowerProgressSettingDesc
{
	[Token(Token = "0x400B0C0")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400B0C1")]
	[FieldOffset(Offset = "0xC")]
	public uint floor;

	[Token(Token = "0x400B0C2")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc award;

	[Token(Token = "0x600826F")]
	[Address(RVA = "0x33E03E4", Offset = "0x33E03E4", VA = "0x33E03E4")]
	public Rampage4BTowerProgressSettingDesc()
	{
	}
}
