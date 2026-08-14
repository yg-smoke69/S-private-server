using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001C2")]
public class OptionalDownloadLogSettingData : CSVBaseData
{
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0xC")]
	public string ABname;

	[Token(Token = "0x600097A")]
	[Address(RVA = "0x28C9260", Offset = "0x28C9260", VA = "0x28C9260")]
	public OptionalDownloadLogSettingData()
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0x28C92E4", Offset = "0x28C92E4", VA = "0x28C92E4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600097C")]
	[Address(RVA = "0x28C9348", Offset = "0x28C9348", VA = "0x28C9348", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
