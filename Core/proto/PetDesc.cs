using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C3")]
public class PetDesc
{
	[Token(Token = "0x400A16C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A16D")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.RareType rare_type;

	[Token(Token = "0x400A16E")]
	[FieldOffset(Offset = "0x10")]
	public uint max_level;

	[Token(Token = "0x600801B")]
	[Address(RVA = "0x33DF584", Offset = "0x33DF584", VA = "0x33DF584")]
	public PetDesc()
	{
	}
}
