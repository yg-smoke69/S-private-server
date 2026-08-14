using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000217")]
public class RenameCostData : CSVBaseData
{
	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0xC")]
	public int DiamondCost;

	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x197BCAC", Offset = "0x197BCAC", VA = "0x197BCAC")]
	public RenameCostData()
	{
	}

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x197BD30", Offset = "0x197BD30", VA = "0x197BD30", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x197BD88", Offset = "0x197BD88", VA = "0x197BD88", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
