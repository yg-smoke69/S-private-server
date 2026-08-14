using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001B8")]
public class NewPlayerInGameGuideData : CSVBaseData
{
	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x8")]
	public TutorialEventEnum EventType;

	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0xC")]
	public TutorialUIType DisplayType;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x10")]
	public float HideDelay;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x14")]
	public string HintText;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x18")]
	public bool OpenToNewBie;

	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x19")]
	public bool CanShowInWaitingRoom;

	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x1C")]
	public List<uint> MatchMode;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x20")]
	public List<uint> GameMode;

	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x24")]
	public List<uint> GroupMode;

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x28")]
	public List<uint> ShowToNewbieChoice;

	[Token(Token = "0x4000AA3")]
	[FieldOffset(Offset = "0x2C")]
	public bool ShowEveryLauncher;

	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x2D")]
	public bool AboveBigMap;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x2E")]
	public bool AbovePopup;

	[Token(Token = "0x6000956")]
	[Address(RVA = "0x28B1E6C", Offset = "0x28B1E6C", VA = "0x28B1E6C")]
	public NewPlayerInGameGuideData()
	{
	}

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x28B1EF0", Offset = "0x28B1EF0", VA = "0x28B1EF0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x28B203C", Offset = "0x28B203C", VA = "0x28B203C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
