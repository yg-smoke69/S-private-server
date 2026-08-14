using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001379")]
public class AvatarSkillSlot
{
	[Token(Token = "0x40089A3")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x40089A4")]
	[FieldOffset(Offset = "0xC")]
	public uint skill_id;

	[Token(Token = "0x6007A7A")]
	[Address(RVA = "0x317B2BC", Offset = "0x317B2BC", VA = "0x317B2BC")]
	public AvatarSkillSlot()
	{
	}
}
