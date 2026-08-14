using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001F5")]
internal class PetLevelExpData : CSVBaseData
{
	[Token(Token = "0x4000BB4")]
	[FieldOffset(Offset = "0x8")]
	public int Lv;

	[Token(Token = "0x4000BB5")]
	[FieldOffset(Offset = "0xC")]
	public int ExpNormal;

	[Token(Token = "0x4000BB6")]
	[FieldOffset(Offset = "0x10")]
	public int ExpGood;

	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x14")]
	public int ExpRare;

	[Token(Token = "0x4000BB8")]
	[FieldOffset(Offset = "0x18")]
	public int ExpEpic;

	[Token(Token = "0x4000BB9")]
	[FieldOffset(Offset = "0x1C")]
	public int ExpLegend;

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x1BFD920", Offset = "0x1BFD920", VA = "0x1BFD920")]
	public PetLevelExpData()
	{
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x1BFD9A4", Offset = "0x1BFD9A4", VA = "0x1BFD9A4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x1BFDA08", Offset = "0x1BFDA08", VA = "0x1BFDA08", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
