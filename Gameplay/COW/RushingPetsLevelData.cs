using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000220")]
public class RushingPetsLevelData : CSVBaseData
{
	[Token(Token = "0x4000CA6")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000CA7")]
	[FieldOffset(Offset = "0xC")]
	public string LevelDesTxt;

	[Token(Token = "0x4000CA8")]
	[FieldOffset(Offset = "0x10")]
	public string LevelName;

	[Token(Token = "0x4000CA9")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID SpriteResID;

	[Token(Token = "0x6000ACE")]
	[Address(RVA = "0x241BB50", Offset = "0x241BB50", VA = "0x241BB50")]
	public RushingPetsLevelData()
	{
	}

	[Token(Token = "0x6000ACF")]
	[Address(RVA = "0x241BC70", Offset = "0x241BC70", VA = "0x241BC70", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AD0")]
	[Address(RVA = "0x241BCD4", Offset = "0x241BCD4", VA = "0x241BCD4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
