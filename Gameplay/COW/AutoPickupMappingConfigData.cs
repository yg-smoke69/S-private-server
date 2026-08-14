using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A3")]
public class AutoPickupMappingConfigData : CSVBaseData
{
	[Token(Token = "0x40003A1")]
	[FieldOffset(Offset = "0x8")]
	public int TypeID;

	[Token(Token = "0x40003A2")]
	[FieldOffset(Offset = "0xC")]
	public uint[] GameMode;

	[Token(Token = "0x40003A3")]
	[FieldOffset(Offset = "0x10")]
	public string TypeTitleKey;

	[Token(Token = "0x40003A4")]
	[FieldOffset(Offset = "0x14")]
	public int[] AutoPickUpSettingItem;

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x10E6AA8", Offset = "0x10E6AA8", VA = "0x10E6AA8")]
	public AutoPickupMappingConfigData()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x10E6B2C", Offset = "0x10E6B2C", VA = "0x10E6B2C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x10E6D0C", Offset = "0x10E6D0C", VA = "0x10E6D0C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
