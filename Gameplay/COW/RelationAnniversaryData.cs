using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000215")]
internal class RelationAnniversaryData : CSVBaseData
{
	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0xC")]
	public uint RelationType;

	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x10")]
	public uint RelationAnniversary;

	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0x1972C88", Offset = "0x1972C88", VA = "0x1972C88")]
	public RelationAnniversaryData()
	{
	}

	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0x1972D0C", Offset = "0x1972D0C", VA = "0x1972D0C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0x1972D70", Offset = "0x1972D70", VA = "0x1972D70", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
