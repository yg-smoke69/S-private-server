using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C9")]
public class PetActionDesc
{
	[Token(Token = "0x400A17F")]
	[FieldOffset(Offset = "0x8")]
	public uint action_id;

	[Token(Token = "0x400A180")]
	[FieldOffset(Offset = "0xC")]
	public uint pet_id;

	[Token(Token = "0x400A181")]
	[FieldOffset(Offset = "0x10")]
	public uint pet_level;

	[Token(Token = "0x6008021")]
	[Address(RVA = "0x33DF574", Offset = "0x33DF574", VA = "0x33DF574")]
	public PetActionDesc()
	{
	}
}
