using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200021E")]
public class RoomCreateCSEcoData : CSVBaseData
{
	[Token(Token = "0x4000C9A")]
	[FieldOffset(Offset = "0x8")]
	public uint Index;

	[Token(Token = "0x4000C9B")]
	[FieldOffset(Offset = "0xC")]
	public string Key;

	[Token(Token = "0x4000C9C")]
	[FieldOffset(Offset = "0x10")]
	public int Min;

	[Token(Token = "0x4000C9D")]
	[FieldOffset(Offset = "0x14")]
	public int Max;

	[Token(Token = "0x4000C9E")]
	[FieldOffset(Offset = "0x18")]
	public int Default;

	[Token(Token = "0x4000C9F")]
	[FieldOffset(Offset = "0x1C")]
	public int Step;

	[Token(Token = "0x4000CA0")]
	[FieldOffset(Offset = "0x20")]
	public bool IsOpen;

	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x240EE28", Offset = "0x240EE28", VA = "0x240EE28")]
	public RoomCreateCSEcoData()
	{
	}

	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x240EEAC", Offset = "0x240EEAC", VA = "0x240EEAC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x240F10C", Offset = "0x240F10C", VA = "0x240F10C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
