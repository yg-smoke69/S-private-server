using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200017F")]
public class LinkEquipSetTimeData : CSVBaseData
{
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTime;

	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x20")]
	public DateTime EndTime;

	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x30")]
	public uint[] Builds;

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0xEC8308", Offset = "0xEC8308", VA = "0xEC8308")]
	public LinkEquipSetTimeData()
	{
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0xEC838C", Offset = "0xEC838C", VA = "0xEC838C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0xEC83F0", Offset = "0xEC83F0", VA = "0xEC83F0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
