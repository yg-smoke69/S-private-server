using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D7")]
public class ClimbingTriggerSettingData : CSVBaseData
{
	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x8")]
	public uint uniqueID;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0xC")]
	public bool enbale;

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x172CFE8", Offset = "0x172CFE8", VA = "0x172CFE8")]
	public ClimbingTriggerSettingData()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x172D06C", Offset = "0x172D06C", VA = "0x172D06C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x172D0D0", Offset = "0x172D0D0", VA = "0x172D0D0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
