using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023EE")]
public class TutorialSetting
{
	[Token(Token = "0x400DFFB")]
	[FieldOffset(Offset = "0x8")]
	public TutorialEventEnum EventType;

	[Token(Token = "0x400DFFC")]
	[FieldOffset(Offset = "0xC")]
	public TutorialUIType DisplayType;

	[Token(Token = "0x400DFFD")]
	[FieldOffset(Offset = "0x10")]
	public float HideDelay;

	[Token(Token = "0x400DFFE")]
	[FieldOffset(Offset = "0x14")]
	public string HintText;

	[Token(Token = "0x400DFFF")]
	[FieldOffset(Offset = "0x18")]
	public string ParamText;

	[Token(Token = "0x400E000")]
	[FieldOffset(Offset = "0x1C")]
	public bool FinishWhenUserInteract;

	[Token(Token = "0x400E001")]
	[FieldOffset(Offset = "0x1D")]
	public bool OpenToNewBie;

	[Token(Token = "0x400E002")]
	[FieldOffset(Offset = "0x20")]
	public List<uint> ShowToNewbieChoice;

	[Token(Token = "0x400E003")]
	[FieldOffset(Offset = "0x24")]
	public bool ShowInWaitingRoom;

	[Token(Token = "0x400E004")]
	[FieldOffset(Offset = "0x25")]
	public bool ShowEveryLauncher;

	[Token(Token = "0x400E005")]
	[FieldOffset(Offset = "0x28")]
	public List<uint> MatchMode;

	[Token(Token = "0x400E006")]
	[FieldOffset(Offset = "0x2C")]
	public List<uint> GameMode;

	[Token(Token = "0x400E007")]
	[FieldOffset(Offset = "0x30")]
	public List<uint> GroupMode;

	[Token(Token = "0x400E008")]
	[FieldOffset(Offset = "0x34")]
	public bool AboveBigMap;

	[Token(Token = "0x400E009")]
	[FieldOffset(Offset = "0x35")]
	public bool AbovePopup;

	[Token(Token = "0x600CAB5")]
	[Address(RVA = "0x2330AA0", Offset = "0x2330AA0", VA = "0x2330AA0")]
	public TutorialSetting(TutorialEventEnum eType, TutorialUIType dType, string hint, bool openToNewBie, List<uint> showToNewbieChoice, bool inWaitingRoom, List<uint> eMatchMode, List<uint> eGameMode, List<uint> eGroupMode, bool showLauncher, bool aboveBigMap, bool abovePopup, float delay)
	{
	}
}
