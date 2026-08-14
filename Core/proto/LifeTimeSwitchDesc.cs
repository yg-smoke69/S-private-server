using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B1F")]
public class LifeTimeSwitchDesc
{
	[Token(Token = "0x400AA7B")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode_id;

	[Token(Token = "0x400AA7C")]
	[FieldOffset(Offset = "0xC")]
	public bool is_count;

	[Token(Token = "0x600817A")]
	[Address(RVA = "0x30A458C", Offset = "0x30A458C", VA = "0x30A458C")]
	public LifeTimeSwitchDesc()
	{
	}
}
