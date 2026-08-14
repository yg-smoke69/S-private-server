using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000278")]
public class WorkshopDefaultLevelData : CSVBaseData
{
	[Token(Token = "0x4000F01")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000F02")]
	[FieldOffset(Offset = "0xC")]
	public uint MapID;

	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x10")]
	public uint ResID;

	[Token(Token = "0x4000F04")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 Position;

	[Token(Token = "0x4000F05")]
	[FieldOffset(Offset = "0x20")]
	public uint Direction;

	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x23035E8", Offset = "0x23035E8", VA = "0x23035E8")]
	public WorkshopDefaultLevelData()
	{
	}

	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x23036B8", Offset = "0x23036B8", VA = "0x23036B8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x230371C", Offset = "0x230371C", VA = "0x230371C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
