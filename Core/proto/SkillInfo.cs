using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A57")]
public class SkillInfo
{
	[Token(Token = "0x400A4F6")]
	[FieldOffset(Offset = "0x8")]
	public uint skill_id;

	[Token(Token = "0x400A4F7")]
	[FieldOffset(Offset = "0xC")]
	public uint pre_skill_id;

	[Token(Token = "0x400A4F8")]
	[FieldOffset(Offset = "0x10")]
	public uint avatar_id;

	[Token(Token = "0x400A4F9")]
	[FieldOffset(Offset = "0x14")]
	public bool is_active_skill;

	[Token(Token = "0x400A4FA")]
	[FieldOffset(Offset = "0x18")]
	public uint skill_level;

	[Token(Token = "0x60080AF")]
	[Address(RVA = "0x33E23A4", Offset = "0x33E23A4", VA = "0x33E23A4")]
	public SkillInfo()
	{
	}
}
