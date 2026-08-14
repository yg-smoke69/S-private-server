using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200027D")]
internal class WorkShopPrefabResourceContentConfigData : CSVBaseData
{
	[Token(Token = "0x4000F1D")]
	[FieldOffset(Offset = "0x8")]
	public uint PrefabID;

	[Token(Token = "0x4000F1E")]
	[FieldOffset(Offset = "0xC")]
	public uint OptionID;

	[Token(Token = "0x4000F1F")]
	[FieldOffset(Offset = "0x10")]
	public uint PrefabSortID;

	[Token(Token = "0x4000F20")]
	[FieldOffset(Offset = "0x14")]
	public bool IsNew;

	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x18")]
	public List<ModeTemplate> MustMode;

	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x1C")]
	public uint MustModeSortID;

	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x20")]
	public List<ModeTemplate> ForbiddenMode;

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x21BCEC0", Offset = "0x21BCEC0", VA = "0x21BCEC0")]
	public WorkShopPrefabResourceContentConfigData()
	{
	}

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x21BCF90", Offset = "0x21BCF90", VA = "0x21BCF90", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x21BCFF4", Offset = "0x21BCFF4", VA = "0x21BCFF4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x21BD2F8", Offset = "0x21BD2F8", VA = "0x21BD2F8")]
	private List<ModeTemplate> GetModeTemplateFromConfig(string modeString)
	{
		return null;
	}
}
