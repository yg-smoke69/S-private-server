using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200010C")]
public class CureGearSettingData : CSVBaseData
{
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x8")]
	public uint EnumID;

	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemID;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x10")]
	public uint ShowInWheel;

	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x14")]
	public uint WheelPriority;

	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x18")]
	public EGameModeCategory GameModeCategory;

	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x1C")]
	public uint GameMode;

	[Token(Token = "0x40006D3")]
	[FieldOffset(Offset = "0x20")]
	public string WheelIcon;

	[Token(Token = "0x40006D4")]
	[FieldOffset(Offset = "0x24")]
	public uint MoveStatus;

	[Token(Token = "0x40006D5")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CureGearSettingData> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x1C86C44", Offset = "0x1C86C44", VA = "0x1C86C44")]
	public CureGearSettingData()
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x1C86CC8", Offset = "0x1C86CC8", VA = "0x1C86CC8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x1C86D2C", Offset = "0x1C86D2C", VA = "0x1C86D2C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x1C86F64", Offset = "0x1C86F64", VA = "0x1C86F64")]
	public static int CureGearComparison(CureGearSettingData t1, CureGearSettingData t2)
	{
		return default(int);
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x1C8700C", Offset = "0x1C8700C", VA = "0x1C8700C")]
	public static List<CureGearSettingData> GetDefaultCureGearList(EGameModeCategory modeCategory, uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x1C87394", Offset = "0x1C87394", VA = "0x1C87394")]
	public static List<CureGearSettingData> GetEnumSortList()
	{
		return null;
	}
}
