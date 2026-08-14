using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000147")]
public class GrenadeTypeSettingData : CSVBaseData
{
	[Token(Token = "0x400084B")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x400084C")]
	[FieldOffset(Offset = "0xC")]
	public uint ItemID;

	[Token(Token = "0x400084D")]
	[FieldOffset(Offset = "0x10")]
	public int Type;

	[Token(Token = "0x400084E")]
	[FieldOffset(Offset = "0x14")]
	public string WheelIcon;

	[Token(Token = "0x400084F")]
	[FieldOffset(Offset = "0x18")]
	public uint ShowInWheel1;

	[Token(Token = "0x4000850")]
	[FieldOffset(Offset = "0x1C")]
	public uint ShowInWheel2;

	[Token(Token = "0x4000851")]
	[FieldOffset(Offset = "0x20")]
	public EGameModeCategory GameModeCategory;

	[Token(Token = "0x4000852")]
	[FieldOffset(Offset = "0x24")]
	public uint GameMode;

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x120F0F0", Offset = "0x120F0F0", VA = "0x120F0F0")]
	public GrenadeTypeSettingData()
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x120F174", Offset = "0x120F174", VA = "0x120F174", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x120F1D8", Offset = "0x120F1D8", VA = "0x120F1D8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x120F410", Offset = "0x120F410", VA = "0x120F410")]
	public static List<GrenadeTypeSettingData> GetDefaultGrenadeList(EGameModeCategory modeCategory, uint gameMode)
	{
		return null;
	}
}
