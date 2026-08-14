using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001FB")]
public class PetSkillLevelData : CSVBaseData
{
	[Token(Token = "0x4000BCF")]
	[FieldOffset(Offset = "0x8")]
	public int SkillID;

	[Token(Token = "0x4000BD0")]
	[FieldOffset(Offset = "0xC")]
	public int SkillLevel;

	[Token(Token = "0x4000BD1")]
	[FieldOffset(Offset = "0x10")]
	public int UnlockPetLevel;

	[Token(Token = "0x4000BD2")]
	[FieldOffset(Offset = "0x14")]
	public int SkillType;

	[Token(Token = "0x4000BD3")]
	[FieldOffset(Offset = "0x18")]
	public string SkillDesc;

	[Token(Token = "0x4000BD4")]
	[FieldOffset(Offset = "0x1C")]
	public float SkillParameter1;

	[Token(Token = "0x4000BD5")]
	[FieldOffset(Offset = "0x20")]
	public float SkillParameter2;

	[Token(Token = "0x4000BD6")]
	[FieldOffset(Offset = "0x24")]
	public float SkillParameter3;

	[Token(Token = "0x4000BD7")]
	[FieldOffset(Offset = "0x28")]
	public float SkillParameter4;

	[Token(Token = "0x4000BD8")]
	[FieldOffset(Offset = "0x2C")]
	public string SkillIconStr;

	[Token(Token = "0x4000BD9")]
	[FieldOffset(Offset = "0x30")]
	public string SkillParameter1Str;

	[Token(Token = "0x4000BDA")]
	[FieldOffset(Offset = "0x34")]
	public string SkillParameter2Str;

	[Token(Token = "0x4000BDB")]
	[FieldOffset(Offset = "0x38")]
	public string SkillParameter3Str;

	[Token(Token = "0x4000BDC")]
	[FieldOffset(Offset = "0x3C")]
	public string SkillParameter4Str;

	[Token(Token = "0x4000BDD")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID SkillIconHud;

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x1C00814", Offset = "0x1C00814", VA = "0x1C00814")]
	public PetSkillLevelData()
	{
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x1C008E0", Offset = "0x1C008E0", VA = "0x1C008E0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0x1BFA974", Offset = "0x1BFA974", VA = "0x1BFA974")]
	public static string GenerateKey(int skillID, int SkillLevel)
	{
		return null;
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0x1C009E0", Offset = "0x1C009E0", VA = "0x1C009E0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000A50")]
	[Address(RVA = "0x1C00E84", Offset = "0x1C00E84", VA = "0x1C00E84")]
	private string AttachColor(string sourceStr)
	{
		return null;
	}
}
