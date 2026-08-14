using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001674")]
public class CSUnlockSkillSlotReq
{
	[Token(Token = "0x4009639")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400963A")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x400963B")]
	[FieldOffset(Offset = "0x10")]
	public uint currency_type;

	[Token(Token = "0x6007CBE")]
	[Address(RVA = "0x309A574", Offset = "0x309A574", VA = "0x309A574")]
	public CSUnlockSkillSlotReq()
	{
	}
}
