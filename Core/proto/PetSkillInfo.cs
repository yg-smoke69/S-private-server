using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200139A")]
public class PetSkillInfo
{
	[Token(Token = "0x4008A23")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x4008A24")]
	[FieldOffset(Offset = "0xC")]
	public uint skill_id;

	[Token(Token = "0x4008A25")]
	[FieldOffset(Offset = "0x10")]
	public uint skill_level;

	[Token(Token = "0x6007A95")]
	[Address(RVA = "0x33DF7B8", Offset = "0x33DF7B8", VA = "0x33DF7B8")]
	public PetSkillInfo()
	{
	}
}
