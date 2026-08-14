using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000258")]
public class UGCRemarkRuleData : CSVBaseData
{
	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0xC")]
	public uint SortID;

	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0x10")]
	public uint RuleType1;

	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x14")]
	public uint RuleValue1;

	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x18")]
	public uint RuleType2;

	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0x1C")]
	public uint RuleValue2;

	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x20")]
	public uint RuleType3;

	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0x24")]
	public uint RuleValue3;

	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x28")]
	public uint DisplayData1;

	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0x2C")]
	public uint DisplayData2;

	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x30")]
	public uint RemarkID;

	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x29F529C", Offset = "0x29F529C", VA = "0x29F529C")]
	public UGCRemarkRuleData()
	{
	}

	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x29F5320", Offset = "0x29F5320", VA = "0x29F5320", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x29F5384", Offset = "0x29F5384", VA = "0x29F5384", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
