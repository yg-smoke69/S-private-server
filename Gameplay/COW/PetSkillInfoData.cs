using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001FA")]
public class PetSkillInfoData : CSVBaseData
{
	[Token(Token = "0x4000BCA")]
	[FieldOffset(Offset = "0x8")]
	public int SkillID;

	[Token(Token = "0x4000BCB")]
	[FieldOffset(Offset = "0xC")]
	public int SourceType;

	[Token(Token = "0x4000BCC")]
	[FieldOffset(Offset = "0x10")]
	public int SourcePetID;

	[Token(Token = "0x4000BCD")]
	[FieldOffset(Offset = "0x14")]
	public uint[] PetIDList;

	[Token(Token = "0x4000BCE")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID Icon;

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x1C00520", Offset = "0x1C00520", VA = "0x1C00520")]
	public PetSkillInfoData()
	{
	}

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x1C005A4", Offset = "0x1C005A4", VA = "0x1C005A4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x1C00608", Offset = "0x1C00608", VA = "0x1C00608", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
