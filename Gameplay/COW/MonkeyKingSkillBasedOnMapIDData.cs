using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001AC")]
internal class MonkeyKingSkillBasedOnMapIDData : CSVBaseData
{
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID InGameModel;

	[Token(Token = "0x6000936")]
	[Address(RVA = "0x228EC28", Offset = "0x228EC28", VA = "0x228EC28")]
	public MonkeyKingSkillBasedOnMapIDData()
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x228ECAC", Offset = "0x228ECAC", VA = "0x228ECAC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0x228EE44", Offset = "0x228EE44", VA = "0x228EE44", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
