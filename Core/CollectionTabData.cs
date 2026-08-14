using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000F7")]
public class CollectionTabData : CSVBaseData
{
	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x8")]
	public CSSharedItemDataManager.CollectionSubType TabID;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0xC")]
	public string TabName;

	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x10")]
	public int Priority;

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x230EED8", Offset = "0x230EED8", VA = "0x230EED8")]
	public CollectionTabData()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x230EF5C", Offset = "0x230EF5C", VA = "0x230EF5C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x230F014", Offset = "0x230F014", VA = "0x230F014", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
