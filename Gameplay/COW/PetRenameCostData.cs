using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001F9")]
public class PetRenameCostData : CSVBaseData
{
	[Token(Token = "0x4000BC7")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000BC8")]
	[FieldOffset(Offset = "0xC")]
	public int DiamondCost;

	[Token(Token = "0x4000BC9")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID PreviewModel;

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0x1BFFF4C", Offset = "0x1BFFF4C", VA = "0x1BFFF4C")]
	public PetRenameCostData()
	{
	}

	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x1BFFFD0", Offset = "0x1BFFFD0", VA = "0x1BFFFD0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0x1C00050", Offset = "0x1C00050", VA = "0x1C00050", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
