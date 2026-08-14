using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200013F")]
public class GachaRandomRareData : CSVBaseData
{
	[Token(Token = "0x4000810")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0xC")]
	public int Probability;

	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x10")]
	public int RandomRare;

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x1055378", Offset = "0x1055378", VA = "0x1055378")]
	public GachaRandomRareData()
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x10553FC", Offset = "0x10553FC", VA = "0x10553FC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x1055460", Offset = "0x1055460", VA = "0x1055460", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
