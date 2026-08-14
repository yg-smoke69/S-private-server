using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001670")]
public class CSEquipSkillReq
{
	[Token(Token = "0x400962D")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400962E")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x400962F")]
	[FieldOffset(Offset = "0x10")]
	public uint skill_id;

	[Token(Token = "0x4009630")]
	[FieldOffset(Offset = "0x18")]
	public ulong group_id;

	[Token(Token = "0x4009631")]
	[FieldOffset(Offset = "0x20")]
	public ulong room_id;

	[Token(Token = "0x6007CBA")]
	[Address(RVA = "0x317FDDC", Offset = "0x317FDDC", VA = "0x317FDDC")]
	public CSEquipSkillReq()
	{
	}
}
