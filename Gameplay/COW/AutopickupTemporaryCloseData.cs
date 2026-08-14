using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A4")]
public class AutopickupTemporaryCloseData : CSVBaseData
{
	[Token(Token = "0x40003A5")]
	[FieldOffset(Offset = "0x8")]
	public int Type;

	[Token(Token = "0x40003A6")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemID;

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x10FAF84", Offset = "0x10FAF84", VA = "0x10FAF84")]
	public AutopickupTemporaryCloseData()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x10FB008", Offset = "0x10FB008", VA = "0x10FB008", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x10FB06C", Offset = "0x10FB06C", VA = "0x10FB06C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
