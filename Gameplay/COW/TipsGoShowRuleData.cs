using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000247")]
public class TipsGoShowRuleData : CSVBaseData
{
	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x8")]
	public ETipsType TipType;

	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0xC")]
	public uint LevelLimit;

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x28A9698", Offset = "0x28A9698", VA = "0x28A9698")]
	public TipsGoShowRuleData()
	{
	}

	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x28A971C", Offset = "0x28A971C", VA = "0x28A971C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x28A9868", Offset = "0x28A9868", VA = "0x28A9868", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
