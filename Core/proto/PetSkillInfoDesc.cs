using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019CB")]
public class PetSkillInfoDesc
{
	[Token(Token = "0x400A189")]
	[FieldOffset(Offset = "0x8")]
	public uint skill_id;

	[Token(Token = "0x400A18A")]
	[FieldOffset(Offset = "0xC")]
	public uint source_type;

	[Token(Token = "0x400A18B")]
	[FieldOffset(Offset = "0x10")]
	public uint source_pet_id;

	[Token(Token = "0x400A18C")]
	[FieldOffset(Offset = "0x14")]
	public uint pet_id;

	[Token(Token = "0x6008023")]
	[Address(RVA = "0x33DF7C0", Offset = "0x33DF7C0", VA = "0x33DF7C0")]
	public PetSkillInfoDesc()
	{
	}
}
