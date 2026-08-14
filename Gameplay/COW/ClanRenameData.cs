using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D4")]
public class ClanRenameData : CSVBaseData
{
	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x8")]
	public int Id;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0xC")]
	public int DiamondCost;

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x172BF40", Offset = "0x172BF40", VA = "0x172BF40")]
	public ClanRenameData()
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x172BFC4", Offset = "0x172BFC4", VA = "0x172BFC4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x172C028", Offset = "0x172C028", VA = "0x172C028", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
