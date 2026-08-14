using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001F3")]
internal class PetFoodData : CSVBaseData
{
	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000BB0")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x10")]
	public int Exp;

	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x14")]
	public uint[] SuitPetIDList;

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x1BFD314", Offset = "0x1BFD314", VA = "0x1BFD314")]
	public PetFoodData()
	{
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x1BFD398", Offset = "0x1BFD398", VA = "0x1BFD398", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x1BFD3FC", Offset = "0x1BFD3FC", VA = "0x1BFD3FC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
