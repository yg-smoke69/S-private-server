using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A5C")]
public class AvatarSkillSlotGuideDesc
{
	[Token(Token = "0x400A50F")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A510")]
	[FieldOffset(Offset = "0xC")]
	public uint level_limit_lower;

	[Token(Token = "0x400A511")]
	[FieldOffset(Offset = "0x10")]
	public uint level_limit_upper;

	[Token(Token = "0x60080B4")]
	[Address(RVA = "0x317B2C4", Offset = "0x317B2C4", VA = "0x317B2C4")]
	public AvatarSkillSlotGuideDesc()
	{
	}
}
