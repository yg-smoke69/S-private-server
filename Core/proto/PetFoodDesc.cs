using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C5")]
public class PetFoodDesc
{
	[Token(Token = "0x400A175")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A176")]
	[FieldOffset(Offset = "0xC")]
	public uint exp;

	[Token(Token = "0x400A177")]
	[FieldOffset(Offset = "0x10")]
	public uint[] suitable;

	[Token(Token = "0x600801D")]
	[Address(RVA = "0x33DF634", Offset = "0x33DF634", VA = "0x33DF634")]
	public PetFoodDesc()
	{
	}
}
