using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E18")]
public class RevenueEntranceShowData : CSVBaseData
{
	[Token(Token = "0x4011A51")]
	[FieldOffset(Offset = "0x8")]
	public uint EntranceType;

	[Token(Token = "0x4011A52")]
	[FieldOffset(Offset = "0xC")]
	public uint Priority;

	[Token(Token = "0x60134C4")]
	[Address(RVA = "0x2409170", Offset = "0x2409170", VA = "0x2409170")]
	public RevenueEntranceShowData()
	{
	}

	[Token(Token = "0x60134C5")]
	[Address(RVA = "0x24091F4", Offset = "0x24091F4", VA = "0x24091F4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60134C6")]
	[Address(RVA = "0x2409258", Offset = "0x2409258", VA = "0x2409258", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
