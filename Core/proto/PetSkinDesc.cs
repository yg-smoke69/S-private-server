using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C8")]
public class PetSkinDesc
{
	[Token(Token = "0x400A17C")]
	[FieldOffset(Offset = "0x8")]
	public uint skin_id;

	[Token(Token = "0x400A17D")]
	[FieldOffset(Offset = "0xC")]
	public uint pet_id;

	[Token(Token = "0x400A17E")]
	[FieldOffset(Offset = "0x10")]
	public uint pet_level;

	[Token(Token = "0x6008020")]
	[Address(RVA = "0x33DF7D0", Offset = "0x33DF7D0", VA = "0x33DF7D0")]
	public PetSkinDesc()
	{
	}
}
