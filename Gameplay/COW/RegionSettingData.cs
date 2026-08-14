using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000214")]
public class RegionSettingData : CSVBaseData
{
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0xC")]
	public string RegionName;

	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x10")]
	public string RegionServer;

	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x197276C", Offset = "0x197276C", VA = "0x197276C")]
	public RegionSettingData()
	{
	}

	[Token(Token = "0x6000AA7")]
	[Address(RVA = "0x19727F0", Offset = "0x19727F0", VA = "0x19727F0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AA8")]
	[Address(RVA = "0x1972854", Offset = "0x1972854", VA = "0x1972854", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000AA9")]
	[Address(RVA = "0x1972A20", Offset = "0x1972A20", VA = "0x1972A20")]
	public static string GetRegionServerName(int id)
	{
		return null;
	}
}
