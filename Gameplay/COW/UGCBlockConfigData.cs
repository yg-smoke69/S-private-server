using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000255")]
public class UGCBlockConfigData : CSVBaseData
{
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0xC")]
	public string TypeName;

	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x10")]
	public EBlockCategory BlockCategory;

	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x14")]
	public string Tips;

	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x18")]
	public bool IsPublished;

	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x1C")]
	public int Order;

	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0x233EE8C", Offset = "0x233EE8C", VA = "0x233EE8C")]
	public UGCBlockConfigData()
	{
	}

	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x233EF10", Offset = "0x233EF10", VA = "0x233EF10", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x233F2A0", Offset = "0x233F2A0", VA = "0x233F2A0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
