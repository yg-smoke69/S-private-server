using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200017E")]
public class LinkEquipSetData : CSVBaseData
{
	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0xC")]
	public EquipIdCountDataList EquipSet1;

	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x10")]
	public EquipIdCountDataList EquipSet2;

	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x14")]
	public EquipIdCountDataList EquipSet3;

	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x18")]
	public EquipIdCountDataList EquipSet4;

	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x1C")]
	public EquipIdCountDataList EquipSet5;

	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x20")]
	public EquipIdCountDataList EquipSet6;

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0xEC7FE0", Offset = "0xEC7FE0", VA = "0xEC7FE0")]
	public LinkEquipSetData()
	{
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0xEC8064", Offset = "0xEC8064", VA = "0xEC8064", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0xEC80C8", Offset = "0xEC80C8", VA = "0xEC80C8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
