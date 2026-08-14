using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA3")]
public class AvatarSkill
{
	[Token(Token = "0x401184E")]
	[FieldOffset(Offset = "0x8")]
	public uint AvatarID;

	[Token(Token = "0x401184F")]
	[FieldOffset(Offset = "0xC")]
	public uint SkillID;

	[Token(Token = "0x4011850")]
	[FieldOffset(Offset = "0x10")]
	public AvatarSkillData SkillData;

	[Token(Token = "0x60131D0")]
	[Address(RVA = "0x23598CC", Offset = "0x23598CC", VA = "0x23598CC")]
	public AvatarSkill()
	{
	}
}
