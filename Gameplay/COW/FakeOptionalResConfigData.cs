using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200012D")]
public class FakeOptionalResConfigData : CSVBaseData
{
	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x8")]
	public uint ItemID;

	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0xC")]
	public uint FakeOptionalItemID;

	[Token(Token = "0x6000750")]
	[Address(RVA = "0xDE479C", Offset = "0xDE479C", VA = "0xDE479C")]
	public FakeOptionalResConfigData()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0xDE4820", Offset = "0xDE4820", VA = "0xDE4820", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0xDE4968", Offset = "0xDE4968", VA = "0xDE4968", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
