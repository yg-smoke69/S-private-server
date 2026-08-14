using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200155A")]
public class CSSelectPetSkillReq
{
	[Token(Token = "0x40092DA")]
	[FieldOffset(Offset = "0x8")]
	public uint pet_id;

	[Token(Token = "0x40092DB")]
	[FieldOffset(Offset = "0xC")]
	public uint skill_id;

	[Token(Token = "0x40092DC")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BA2")]
	[Address(RVA = "0x3099764", Offset = "0x3099764", VA = "0x3099764")]
	public CSSelectPetSkillReq()
	{
	}
}
