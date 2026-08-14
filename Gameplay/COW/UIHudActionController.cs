using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026CD")]
internal class UIHudActionController : UIHudButtonBaseController
{
	[Token(Token = "0x20026CE")]
	public struct ActionRes
	{
		[Token(Token = "0x400EFD1")]
		[FieldOffset(Offset = "0x0")]
		public string Icon;

		[Token(Token = "0x400EFD2")]
		[FieldOffset(Offset = "0x4")]
		public string LocKey;
	}

	[Token(Token = "0x400EFA4")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudActionView m_View;

	[Token(Token = "0x400EFA5")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ACTIONICON_DEFAULT;

	[Token(Token = "0x400EFA6")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string ACTIONICON_MUSHROOM;

	[Token(Token = "0x400EFA7")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ACTIONICON_STROP;

	[Token(Token = "0x400EFA8")]
	[FieldOffset(Offset = "0xC")]
	public static readonly string ACTIONICON_QUIT;

	[Token(Token = "0x400EFA9")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ACTIONICON_USE;

	[Token(Token = "0x400EFAA")]
	[FieldOffset(Offset = "0x14")]
	public static readonly string ACTIONICON_ENTER;

	[Token(Token = "0x400EFAB")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string ACTIONICON_BUY;

	[Token(Token = "0x400EFAC")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly string ACTIONICON_PORTAL;

	[Token(Token = "0x400EFAD")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string ACTIONICON_CANDY;

	[Token(Token = "0x400EFAE")]
	[FieldOffset(Offset = "0x24")]
	public static readonly string ACTIONICON_DEPOSIT;

	[Token(Token = "0x400EFAF")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string ACTIONICON_PRAYER;

	[Token(Token = "0x400EFB0")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly string ACTIONICON_MUSIC_DANCE;

	[Token(Token = "0x400EFB1")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string ACTIONICON_PARTY_SHOOT;

	[Token(Token = "0x400EFB2")]
	[FieldOffset(Offset = "0x34")]
	public static readonly string ACTIONICON_SNOWBALLBOX;

	[Token(Token = "0x400EFB3")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string ACTIONICON_TREASURY_KEY;

	[Token(Token = "0x400EFB4")]
	[FieldOffset(Offset = "0x3C")]
	public static readonly string ACTIONICON_FAITHJUMP;

	[Token(Token = "0x400EFB5")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string ACTIONICON_FLAGBATTLECHOKEPOINT;

	[Token(Token = "0x400EFB6")]
	[FieldOffset(Offset = "0x44")]
	public static readonly string ACTIONICON_FLAGBATTLEENERGYSTONEBOX;

	[Token(Token = "0x400EFB7")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string ACTIONICONBG_DEFAULT;

	[Token(Token = "0x400EFB8")]
	[FieldOffset(Offset = "0x4C")]
	public static readonly string ACTIONICONBG_STROP;

	[Token(Token = "0x400EFB9")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string ACTIONICONBG_OPEN;

	[Token(Token = "0x400EFBA")]
	[FieldOffset(Offset = "0x54")]
	public static readonly string ACTIONICONBG_OPEN_FLIGHT;

	[Token(Token = "0x400EFBB")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string ACTIONICONBG_FALL;

	[Token(Token = "0x400EFBC")]
	[FieldOffset(Offset = "0x5C")]
	public static readonly string ACTIONICONBG_REVIVE;

	[Token(Token = "0x400EFBD")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string ACTIONICONBG_DRIFTBOTTLE;

	[Token(Token = "0x400EFBE")]
	[FieldOffset(Offset = "0x64")]
	public static readonly string ACTIONICONBG_FOLLOWEMOTE;

	[Token(Token = "0x400EFBF")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string ACTIONICONBG_BOXING;

	[Token(Token = "0x400EFC0")]
	[FieldOffset(Offset = "0x6C")]
	public static readonly string ACTIONICONBG_QUEUE;

	[Token(Token = "0x400EFC1")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string ACTIONICONBG_FOURSYMBOLSCHANGECLOTH;

	[Token(Token = "0x400EFC2")]
	[FieldOffset(Offset = "0x74")]
	public static readonly string ACTIONICONBG_CHEER_PET;

	[Token(Token = "0x400EFC3")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string ACTIONICONBG_CHATNPC;

	[Token(Token = "0x400EFC4")]
	[FieldOffset(Offset = "0x7C")]
	public static Dictionary<int, ActionRes> ActionResMap;

	[Token(Token = "0x400EFC5")]
	[FieldOffset(Offset = "0x80")]
	public static readonly Color ACTIONICONBG_COLOR_STROP;

	[Token(Token = "0x400EFC6")]
	[FieldOffset(Offset = "0x90")]
	public static readonly Vector3 LOCALPOSITION_DEFAULT;

	[Token(Token = "0x400EFC7")]
	[FieldOffset(Offset = "0x9C")]
	public static readonly Vector3 DefaultLabelPos;

	[Token(Token = "0x400EFC8")]
	[FieldOffset(Offset = "0xA8")]
	public static readonly Vector3 SpecialLabelPos;

	[Token(Token = "0x400EFC9")]
	[FieldOffset(Offset = "0x30")]
	private EHudActionType m_ActType;

	[Token(Token = "0x400EFCA")]
	[FieldOffset(Offset = "0x34")]
	private Color SpeicalBgColor;

	[Token(Token = "0x400EFCB")]
	[FieldOffset(Offset = "0x44")]
	private Color DefaultBgColor;

	[Token(Token = "0x400EFCC")]
	[FieldOffset(Offset = "0x54")]
	private BoxCollider m_Coiilder;

	[Token(Token = "0x400EFCD")]
	[FieldOffset(Offset = "0x58")]
	private float m_ActionCD;

	[Token(Token = "0x400EFCE")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ActionCDEndTime;

	[Token(Token = "0x400EFCF")]
	[FieldOffset(Offset = "0x60")]
	private bool m_TutOpenParachuteShowed;

	[Token(Token = "0x400EFD0")]
	[FieldOffset(Offset = "0x61")]
	private bool m_ShowState;

	[Token(Token = "0x600EA97")]
	[Address(RVA = "0x163D9F0", Offset = "0x163D9F0", VA = "0x163D9F0")]
	public UIHudActionController()
	{
	}

	[Token(Token = "0x600EA98")]
	[Address(RVA = "0x163DA9C", Offset = "0x163DA9C", VA = "0x163DA9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EA99")]
	[Address(RVA = "0x163DB40", Offset = "0x163DB40", VA = "0x163DB40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EA9A")]
	[Address(RVA = "0x163E000", Offset = "0x163E000", VA = "0x163E000", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EA9B")]
	[Address(RVA = "0x163E33C", Offset = "0x163E33C", VA = "0x163E33C", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EA9C")]
	[Address(RVA = "0x163E3E0", Offset = "0x163E3E0", VA = "0x163E3E0")]
	private void SetIcon(EHudActionType actType, object[] param)
	{
	}

	[Token(Token = "0x600EA9D")]
	[Address(RVA = "0x16407E8", Offset = "0x16407E8", VA = "0x16407E8")]
	private void ShowTutorial(EHudActionType actType, object[] param)
	{
	}

	[Token(Token = "0x600EA9E")]
	[Address(RVA = "0x1640F20", Offset = "0x1640F20", VA = "0x1640F20")]
	private void OnActionEnter(object[] param)
	{
	}

	[Token(Token = "0x600EA9F")]
	[Address(RVA = "0x16413CC", Offset = "0x16413CC", VA = "0x16413CC")]
	private void OnActionEnd(object[] param)
	{
	}

	[Token(Token = "0x600EAA0")]
	[Address(RVA = "0x16414E0", Offset = "0x16414E0", VA = "0x16414E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600EAA1")]
	[Address(RVA = "0x1641480", Offset = "0x1641480", VA = "0x1641480")]
	private void ClearActionCD()
	{
	}

	[Token(Token = "0x600EAA2")]
	[Address(RVA = "0x16416A4", Offset = "0x16416A4", VA = "0x16416A4")]
	protected void OnShow(object[] param)
	{
	}

	[Token(Token = "0x600EAA3")]
	[Address(RVA = "0x164189C", Offset = "0x164189C", VA = "0x164189C")]
	private void OnConflictShowChange(object[] param)
	{
	}

	[Token(Token = "0x600EAA4")]
	[Address(RVA = "0x1640250", Offset = "0x1640250", VA = "0x1640250")]
	private void SetToDefault()
	{
	}

	[Token(Token = "0x600EAA5")]
	[Address(RVA = "0x16405E4", Offset = "0x16405E4", VA = "0x16405E4")]
	private void SetBtnIcon(string spriteName)
	{
	}

	[Token(Token = "0x600EAA6")]
	[Address(RVA = "0x1641A5C", Offset = "0x1641A5C", VA = "0x1641A5C")]
	private void OnTrainingQueueInfoChange(object[] param)
	{
	}

	[Token(Token = "0x600EAA7")]
	[Address(RVA = "0x1641F98", Offset = "0x1641F98", VA = "0x1641F98")]
	private void ShowTutorialForOpenParachute()
	{
	}

	[Token(Token = "0x600EAA8")]
	[Address(RVA = "0x16420EC", Offset = "0x16420EC", VA = "0x16420EC", Slot = "33")]
	protected override void OnBtnClick()
	{
	}

	[Token(Token = "0x600EAA9")]
	[Address(RVA = "0x16421D8", Offset = "0x16421D8", VA = "0x16421D8", Slot = "35")]
	protected override void OnBtnRelease()
	{
	}

	[Token(Token = "0x600EAAA")]
	[Address(RVA = "0x16422C4", Offset = "0x16422C4", VA = "0x16422C4")]
	private void OnActionBlock(object[] param)
	{
	}

	[Token(Token = "0x600EAAB")]
	[Address(RVA = "0x1642440", Offset = "0x1642440", VA = "0x1642440")]
	private void OnBlockBtnClick()
	{
	}

	[Token(Token = "0x600EAAD")]
	[Address(RVA = "0x1643F30", Offset = "0x1643F30", VA = "0x1643F30")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EAAE")]
	[Address(RVA = "0x1643F38", Offset = "0x1643F38", VA = "0x1643F38")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EAAF")]
	[Address(RVA = "0x1643F40", Offset = "0x1643F40", VA = "0x1643F40")]
	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	[Token(Token = "0x600EAB0")]
	[Address(RVA = "0x1643F48", Offset = "0x1643F48", VA = "0x1643F48")]
	public void _003C_003EiFixBaseProxy_OnBtnRelease()
	{
	}
}
