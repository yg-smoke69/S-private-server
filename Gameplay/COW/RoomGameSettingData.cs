using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200021F")]
public class RoomGameSettingData : CSVBaseData
{
	[Token(Token = "0x4000CA1")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000CA2")]
	[FieldOffset(Offset = "0xC")]
	public uint[] GameSettingList;

	[Token(Token = "0x4000CA3")]
	[FieldOffset(Offset = "0x10")]
	public uint[] GameModes;

	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x14")]
	public bool IsCommonGameSetting;

	[Token(Token = "0x4000CA5")]
	[FieldOffset(Offset = "0x15")]
	public bool OverrideCommonSetting;

	[Token(Token = "0x6000ACB")]
	[Address(RVA = "0x2415948", Offset = "0x2415948", VA = "0x2415948")]
	public RoomGameSettingData()
	{
	}

	[Token(Token = "0x6000ACC")]
	[Address(RVA = "0x24159CC", Offset = "0x24159CC", VA = "0x24159CC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000ACD")]
	[Address(RVA = "0x2415A30", Offset = "0x2415A30", VA = "0x2415A30", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
