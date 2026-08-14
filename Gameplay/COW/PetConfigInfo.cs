using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E0A")]
internal struct PetConfigInfo
{
	[Token(Token = "0x4011A28")]
	[FieldOffset(Offset = "0x0")]
	public uint Pet_ID;

	[Token(Token = "0x4011A29")]
	[FieldOffset(Offset = "0x4")]
	public int Exp;

	[Token(Token = "0x4011A2A")]
	[FieldOffset(Offset = "0x8")]
	public int RareType;

	[Token(Token = "0x4011A2B")]
	[FieldOffset(Offset = "0xC")]
	public uint Level;

	[Token(Token = "0x4011A2C")]
	[FieldOffset(Offset = "0x10")]
	public PetData Pet_Data;

	[Token(Token = "0x4011A2D")]
	[FieldOffset(Offset = "0x14")]
	public List<PetActionData> PetAction_data_List;

	[Token(Token = "0x4011A2E")]
	[FieldOffset(Offset = "0x18")]
	public List<PetSkinData> PetSkin_Data_List;

	[Token(Token = "0x4011A2F")]
	[FieldOffset(Offset = "0x1C")]
	public List<PetSkillInfoData> PetSkill_Data_list;

	[Token(Token = "0x4011A30")]
	[FieldOffset(Offset = "0x20")]
	public PetLevelExpData Pet_Exp_Data;

	[Token(Token = "0x601348B")]
	[Address(RVA = "0x93C1E0", Offset = "0x93C1E0", VA = "0x93C1E0")]
	public PetConfigInfo(uint pet_id, uint Lv)
	{
	}
}
