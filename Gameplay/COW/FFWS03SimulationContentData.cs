using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200012F")]
public class FFWS03SimulationContentData : CSVBaseData
{
	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0xC")]
	public uint[] Ranking;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x10")]
	public uint ShrinkingTimes;

	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x14")]
	public float ShrinkingInterval;

	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x18")]
	public uint[] ReportsNumber;

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] ReportsType;

	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x20")]
	public string ReportSettlement;

	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x24")]
	public float ReportsRefreshInterval;

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x2302FD8", Offset = "0x2302FD8", VA = "0x2302FD8")]
	public FFWS03SimulationContentData()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x230305C", Offset = "0x230305C", VA = "0x230305C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x23032A4", Offset = "0x23032A4", VA = "0x23032A4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
