using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000D1")]
public class ClanHonorData : CSVBaseData
{
	[Token(Token = "0x40004FA")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0xC")]
	public int Type;

	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x10")]
	public int Upperlimit;

	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x14")]
	public int Division;

	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x18")]
	public float Honor;

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x230E22C", Offset = "0x230E22C", VA = "0x230E22C")]
	public ClanHonorData()
	{
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0x230E2B0", Offset = "0x230E2B0", VA = "0x230E2B0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0x230E2BC", Offset = "0x230E2BC", VA = "0x230E2BC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
