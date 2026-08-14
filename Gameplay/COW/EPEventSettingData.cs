using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200011E")]
internal class EPEventSettingData : CSVBaseData
{
	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x8")]
	public uint EPEventID;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x10")]
	public DateTime StartTime;

	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x20")]
	public DateTime EndTime;

	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x30")]
	public string EPEventName;

	[Token(Token = "0x4000737")]
	[FieldOffset(Offset = "0x34")]
	public uint BadgeItemID;

	[Token(Token = "0x4000738")]
	[FieldOffset(Offset = "0x38")]
	public uint BadgeDebrisItemID;

	[Token(Token = "0x4000739")]
	[FieldOffset(Offset = "0x3C")]
	public uint FPChallengeID;

	[Token(Token = "0x400073A")]
	[FieldOffset(Offset = "0x40")]
	public uint ExtraMaxCoins;

	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID LobbyIcon;

	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x48")]
	public string ThemeColor;

	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x4C")]
	public uint FreeTreasureBoxID;

	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x50")]
	public string CdnUrl;

	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x54")]
	public ResourceID HDEPLobbyVFX;

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x1C9EDC4", Offset = "0x1C9EDC4", VA = "0x1C9EDC4")]
	public EPEventSettingData()
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x1C9EE48", Offset = "0x1C9EE48", VA = "0x1C9EE48", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x1C9EEAC", Offset = "0x1C9EEAC", VA = "0x1C9EEAC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
