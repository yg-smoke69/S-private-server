using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000194")]
public class BigEventMailContentData : CSVBaseData
{
	[Token(Token = "0x40009B9")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0xC")]
	public int RankType;

	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x10")]
	public string BigEventName;

	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x14")]
	public string RankDesc;

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x2E68574", Offset = "0x2E68574", VA = "0x2E68574")]
	public BigEventMailContentData()
	{
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x2E685F8", Offset = "0x2E685F8", VA = "0x2E685F8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x2E6865C", Offset = "0x2E6865C", VA = "0x2E6865C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
