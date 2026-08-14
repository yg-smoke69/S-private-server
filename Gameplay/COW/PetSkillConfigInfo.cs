using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E0B")]
public class PetSkillConfigInfo
{
	[Token(Token = "0x4011A31")]
	[FieldOffset(Offset = "0x8")]
	public uint SkillID;

	[Token(Token = "0x4011A32")]
	[FieldOffset(Offset = "0xC")]
	public int Level;

	[Token(Token = "0x4011A33")]
	[FieldOffset(Offset = "0x10")]
	public uint PetID;

	[Token(Token = "0x4011A34")]
	[FieldOffset(Offset = "0x14")]
	public bool IsLock;

	[Token(Token = "0x4011A35")]
	[FieldOffset(Offset = "0x18")]
	public PetSkillLevelData CurrentLevelData;

	[Token(Token = "0x4011A36")]
	[FieldOffset(Offset = "0x1C")]
	public PetSkillLevelData NextLevelData;

	[Token(Token = "0x601348C")]
	[Address(RVA = "0x1C001E4", Offset = "0x1C001E4", VA = "0x1C001E4")]
	public PetSkillConfigInfo(uint skill_id, uint pet_level, uint pet_id)
	{
	}
}
