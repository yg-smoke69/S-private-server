using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200023A")]
public class SparkEventConfigData : CSVBaseData
{
	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x8")]
	public string EventType;

	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0xC")]
	public int MaxEventTimes;

	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x10")]
	public EHighlightType HighlightType;

	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x20F4CB4", Offset = "0x20F4CB4", VA = "0x20F4CB4")]
	public SparkEventConfigData()
	{
	}

	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x20F4D38", Offset = "0x20F4D38", VA = "0x20F4D38", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x20F4D90", Offset = "0x20F4D90", VA = "0x20F4D90", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
