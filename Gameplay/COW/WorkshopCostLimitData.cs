using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000274")]
public class WorkshopCostLimitData : CSVBaseData
{
	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000EE8")]
	[FieldOffset(Offset = "0xC")]
	public float CostPercent;

	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x10")]
	public string DescKey;

	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x14")]
	public Color CostColor;

	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x21BE7B0", Offset = "0x21BE7B0", VA = "0x21BE7B0")]
	public WorkshopCostLimitData()
	{
	}

	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x21BE834", Offset = "0x21BE834", VA = "0x21BE834", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x21BE898", Offset = "0x21BE898", VA = "0x21BE898", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
