using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200027E")]
public class WorkShopResourceTypeData : CSVBaseData
{
	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x8")]
	public uint OptionID;

	[Token(Token = "0x4000F25")]
	[FieldOffset(Offset = "0xC")]
	public string OptionKey;

	[Token(Token = "0x4000F26")]
	[FieldOffset(Offset = "0x10")]
	public uint OptionSortID;

	[Token(Token = "0x4000F27")]
	[FieldOffset(Offset = "0x14")]
	public bool IsMustMode;

	[Token(Token = "0x4000F28")]
	[FieldOffset(Offset = "0x18")]
	public uint FatherOptionID;

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x21BD638", Offset = "0x21BD638", VA = "0x21BD638")]
	public WorkShopResourceTypeData()
	{
	}

	[Token(Token = "0x6000C31")]
	[Address(RVA = "0x21BD6BC", Offset = "0x21BD6BC", VA = "0x21BD6BC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x21BD720", Offset = "0x21BD720", VA = "0x21BD720", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
