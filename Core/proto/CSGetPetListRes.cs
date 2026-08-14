using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001553")]
public class CSGetPetListRes
{
	[Token(Token = "0x40092C1")]
	[FieldOffset(Offset = "0x8")]
	public List<PetInfo> pets;

	[Token(Token = "0x40092C2")]
	[FieldOffset(Offset = "0xC")]
	public List<PetSkinInfo> skins;

	[Token(Token = "0x40092C3")]
	[FieldOffset(Offset = "0x10")]
	public List<PetActionInfo> actions;

	[Token(Token = "0x40092C4")]
	[FieldOffset(Offset = "0x14")]
	public List<PetSkillInfo> skills;

	[Token(Token = "0x6007B9B")]
	[Address(RVA = "0x318863C", Offset = "0x318863C", VA = "0x318863C")]
	public CSGetPetListRes()
	{
	}
}
