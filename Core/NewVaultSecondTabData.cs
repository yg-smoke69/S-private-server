using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20001BE")]
public class NewVaultSecondTabData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x8")]
	public int SecondTabID;

	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0xC")]
	public int TabID;

	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x10")]
	public string Icon;

	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x14")]
	public int Priority;

	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x18")]
	public int IsHide;

	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x1C")]
	public int Modifier;

	[Token(Token = "0x6000969")]
	[Address(RVA = "0x1C72E50", Offset = "0x1C72E50", VA = "0x1C72E50")]
	public NewVaultSecondTabData()
	{
	}

	[Token(Token = "0x600096A")]
	[Address(RVA = "0x1C72F1C", Offset = "0x1C72F1C", VA = "0x1C72F1C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0x1C72F28", Offset = "0x1C72F28", VA = "0x1C72F28", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600096C")]
	[Address(RVA = "0x1C730A4", Offset = "0x1C730A4", VA = "0x1C730A4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}
}
