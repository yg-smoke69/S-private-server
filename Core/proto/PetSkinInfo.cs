using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001398")]
public class PetSkinInfo
{
	[Token(Token = "0x4008A1E")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x4008A1F")]
	[FieldOffset(Offset = "0xC")]
	public uint skin_id;

	[Token(Token = "0x4008A20")]
	[FieldOffset(Offset = "0x10")]
	public bool is_selected;

	[Token(Token = "0x6007A93")]
	[Address(RVA = "0x33DF7D8", Offset = "0x33DF7D8", VA = "0x33DF7D8")]
	public PetSkinInfo()
	{
	}
}
