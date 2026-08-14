using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032C7")]
public class UINewPlayerSurveyManager : SingletonModule<UINewPlayerSurveyManager>
{
	[Token(Token = "0x4013543")]
	[FieldOffset(Offset = "0xC")]
	private HashSet<uint> newPlayerSurveySet;

	[Token(Token = "0x4013544")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, NewPlayerSurveyInfo> newPlayerSurveyDic;

	[Token(Token = "0x4013545")]
	[FieldOffset(Offset = "0x14")]
	public bool HasSurveyOpened;

	[Token(Token = "0x4013546")]
	[FieldOffset(Offset = "0x15")]
	public bool NeedRefresh;

	[Token(Token = "0x4013547")]
	[FieldOffset(Offset = "0x16")]
	public bool CanOpen;

	[Token(Token = "0x4013548")]
	[FieldOffset(Offset = "0x18")]
	public string NewPlayerSurveyRewardedKey;

	[Token(Token = "0x60156C8")]
	[Address(RVA = "0x27AE5B4", Offset = "0x27AE5B4", VA = "0x27AE5B4")]
	public UINewPlayerSurveyManager()
	{
	}

	[Token(Token = "0x60156C9")]
	[Address(RVA = "0x27AE7BC", Offset = "0x27AE7BC", VA = "0x27AE7BC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60156CA")]
	[Address(RVA = "0x27AE810", Offset = "0x27AE810", VA = "0x27AE810", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60156CB")]
	[Address(RVA = "0x27ADB24", Offset = "0x27ADB24", VA = "0x27ADB24")]
	public void UpdateSurveyInfos()
	{
	}

	[Token(Token = "0x60156CC")]
	[Address(RVA = "0x27ADFC8", Offset = "0x27ADFC8", VA = "0x27ADFC8")]
	public string GetSurveyLink()
	{
		return null;
	}

	[Token(Token = "0x60156CD")]
	[Address(RVA = "0x27AE864", Offset = "0x27AE864", VA = "0x27AE864")]
	public uint GetBaseLevelKey(uint userLevel)
	{
		return default(uint);
	}
}
