using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200027F")]
public class WorkshopShowMapIconData : CSVBaseData
{
	[Token(Token = "0x4000F29")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000F2A")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x4000F2B")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID ResID;

	[Token(Token = "0x4000F2C")]
	[FieldOffset(Offset = "0x14")]
	public int Sort;

	[Token(Token = "0x4000F2D")]
	[FieldOffset(Offset = "0x18")]
	public bool ShowIcomMapRunTimeGame;

	[Token(Token = "0x4000F2E")]
	[FieldOffset(Offset = "0x1C")]
	public int MinSizeInDetailMap;

	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x2306EB4", Offset = "0x2306EB4", VA = "0x2306EB4")]
	public WorkshopShowMapIconData()
	{
	}

	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x2306F8C", Offset = "0x2306F8C", VA = "0x2306F8C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x2306FF0", Offset = "0x2306FF0", VA = "0x2306FF0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
