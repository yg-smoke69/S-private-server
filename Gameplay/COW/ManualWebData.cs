using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200019E")]
public class ManualWebData : CSVBaseData
{
	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0xC")]
	public string WebLink;

	[Token(Token = "0x6000904")]
	[Address(RVA = "0x15341D4", Offset = "0x15341D4", VA = "0x15341D4")]
	public ManualWebData()
	{
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0x1534258", Offset = "0x1534258", VA = "0x1534258", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0x15342B0", Offset = "0x15342B0", VA = "0x15342B0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
