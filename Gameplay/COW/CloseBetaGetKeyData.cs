using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D8")]
public class CloseBetaGetKeyData : CSVBaseData
{
	[Token(Token = "0x400051E")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400051F")]
	[FieldOffset(Offset = "0xC")]
	public string webSite;

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x172DBAC", Offset = "0x172DBAC", VA = "0x172DBAC")]
	public CloseBetaGetKeyData()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x172DC30", Offset = "0x172DC30", VA = "0x172DC30", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x172DC88", Offset = "0x172DC88", VA = "0x172DC88", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
