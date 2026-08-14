using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A6D")]
public class WinnerTakesAllDesc
{
	[Token(Token = "0x400A578")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A579")]
	[FieldOffset(Offset = "0xC")]
	public uint chip_cost;

	[Token(Token = "0x400A57A")]
	[FieldOffset(Offset = "0x10")]
	public uint diamond_cost;

	[Token(Token = "0x60080CA")]
	[Address(RVA = "0x33E57E0", Offset = "0x33E57E0", VA = "0x33E57E0")]
	public WinnerTakesAllDesc()
	{
	}
}
