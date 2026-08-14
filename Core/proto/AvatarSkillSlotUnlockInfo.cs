using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A5B")]
public class AvatarSkillSlotUnlockInfo
{
	[Token(Token = "0x400A50B")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400A50C")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x400A50D")]
	[FieldOffset(Offset = "0x10")]
	public uint gems;

	[Token(Token = "0x400A50E")]
	[FieldOffset(Offset = "0x14")]
	public uint coins;

	[Token(Token = "0x60080B3")]
	[Address(RVA = "0x317B2CC", Offset = "0x317B2CC", VA = "0x317B2CC")]
	public AvatarSkillSlotUnlockInfo()
	{
	}
}
