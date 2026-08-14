using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000CD")]
public class ClanAreaData : CSVBaseData
{
	[Token(Token = "0x40004DF")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40004E0")]
	[FieldOffset(Offset = "0xC")]
	public string FirstGrade;

	[Token(Token = "0x40004E1")]
	[FieldOffset(Offset = "0x10")]
	public string SecondGrade;

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x230DD48", Offset = "0x230DD48", VA = "0x230DD48")]
	public ClanAreaData()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x230DDCC", Offset = "0x230DDCC", VA = "0x230DDCC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x230DDD8", Offset = "0x230DDD8", VA = "0x230DDD8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
