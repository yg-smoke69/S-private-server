using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200010E")]
public class DefaultLanguageConfig : CSVBaseData
{
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0xC")]
	public int Lagr;

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x1C8B73C", Offset = "0x1C8B73C", VA = "0x1C8B73C")]
	public DefaultLanguageConfig()
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x1C8B7C0", Offset = "0x1C8B7C0", VA = "0x1C8B7C0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x1C8B818", Offset = "0x1C8B818", VA = "0x1C8B818", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
