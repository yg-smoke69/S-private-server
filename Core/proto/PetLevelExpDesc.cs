using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C4")]
public class PetLevelExpDesc
{
	[Token(Token = "0x400A16F")]
	[FieldOffset(Offset = "0x8")]
	public uint lv;

	[Token(Token = "0x400A170")]
	[FieldOffset(Offset = "0xC")]
	public uint exp_normal;

	[Token(Token = "0x400A171")]
	[FieldOffset(Offset = "0x10")]
	public uint exp_good;

	[Token(Token = "0x400A172")]
	[FieldOffset(Offset = "0x14")]
	public uint exp_rare;

	[Token(Token = "0x400A173")]
	[FieldOffset(Offset = "0x18")]
	public uint exp_epic;

	[Token(Token = "0x400A174")]
	[FieldOffset(Offset = "0x1C")]
	public uint exp_legend;

	[Token(Token = "0x600801C")]
	[Address(RVA = "0x33DF710", Offset = "0x33DF710", VA = "0x33DF710")]
	public PetLevelExpDesc()
	{
	}
}
