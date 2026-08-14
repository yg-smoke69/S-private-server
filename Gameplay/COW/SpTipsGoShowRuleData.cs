using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200023F")]
public class SpTipsGoShowRuleData : CSVBaseData
{
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x8")]
	public ESpTipsType TipType;

	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0xC")]
	public uint LevelLimit;

	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x20F4830", Offset = "0x20F4830", VA = "0x20F4830")]
	public SpTipsGoShowRuleData()
	{
	}

	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x20F48B4", Offset = "0x20F48B4", VA = "0x20F48B4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x20F4A00", Offset = "0x20F4A00", VA = "0x20F4A00", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
