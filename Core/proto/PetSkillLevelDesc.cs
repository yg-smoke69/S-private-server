using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019CA")]
public class PetSkillLevelDesc
{
	[Token(Token = "0x400A182")]
	[FieldOffset(Offset = "0x8")]
	public uint skill_id;

	[Token(Token = "0x400A183")]
	[FieldOffset(Offset = "0xC")]
	public uint skill_level;

	[Token(Token = "0x400A184")]
	[FieldOffset(Offset = "0x10")]
	public uint pet_level;

	[Token(Token = "0x400A185")]
	[FieldOffset(Offset = "0x14")]
	public uint type;

	[Token(Token = "0x400A186")]
	[FieldOffset(Offset = "0x18")]
	public uint parameter1;

	[Token(Token = "0x400A187")]
	[FieldOffset(Offset = "0x1C")]
	public uint parameter2;

	[Token(Token = "0x400A188")]
	[FieldOffset(Offset = "0x20")]
	public uint parameter3;

	[Token(Token = "0x6008022")]
	[Address(RVA = "0x33DF7C8", Offset = "0x33DF7C8", VA = "0x33DF7C8")]
	public PetSkillLevelDesc()
	{
	}
}
