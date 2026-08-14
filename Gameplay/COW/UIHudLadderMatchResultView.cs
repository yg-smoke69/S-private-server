using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003690")]
public class UIHudLadderMatchResultView : UIBaseView
{
	[Token(Token = "0x4015F22")]
	[FieldOffset(Offset = "0x14")]
	public Animation HudLadderMatchResultAnim;

	[Token(Token = "0x4015F23")]
	[FieldOffset(Offset = "0x18")]
	public Animation LadderRankInfoAnim;

	[Token(Token = "0x4015F24")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite RankAfterSprite;

	[Token(Token = "0x4015F25")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RankNameAfter;

	[Token(Token = "0x4015F26")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HeroicLevelAfterContainer;

	[Token(Token = "0x4015F27")]
	[FieldOffset(Offset = "0x28")]
	public GameObject AfterStar1;

	[Token(Token = "0x4015F28")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject AfterStar2;

	[Token(Token = "0x4015F29")]
	[FieldOffset(Offset = "0x30")]
	public GameObject AfterStar3;

	[Token(Token = "0x4015F2A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AfterStar4;

	[Token(Token = "0x4015F2B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AfterStar5;

	[Token(Token = "0x4015F2C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RankBeforeSprite;

	[Token(Token = "0x4015F2D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel RankNameBefore;

	[Token(Token = "0x4015F2E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject HeroicLevelBeforeContainer;

	[Token(Token = "0x4015F2F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BeforeStar1;

	[Token(Token = "0x4015F30")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BeforeStar2;

	[Token(Token = "0x4015F31")]
	[FieldOffset(Offset = "0x50")]
	public GameObject BeforeStar3;

	[Token(Token = "0x4015F32")]
	[FieldOffset(Offset = "0x54")]
	public GameObject BeforeStar4;

	[Token(Token = "0x4015F33")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BeforeStar5;

	[Token(Token = "0x4015F34")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Shine;

	[Token(Token = "0x4015F35")]
	[FieldOffset(Offset = "0x60")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4015F36")]
	[FieldOffset(Offset = "0x64")]
	public UILabel CurScoreTxt;

	[Token(Token = "0x4015F37")]
	[FieldOffset(Offset = "0x68")]
	public UILabel AddScoreTxt;

	[Token(Token = "0x4015F38")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel ResultBonousInfoTxt;

	[Token(Token = "0x4015F39")]
	[FieldOffset(Offset = "0x70")]
	public UITable ScoreInfoTable;

	[Token(Token = "0x4015F3A")]
	[FieldOffset(Offset = "0x74")]
	public GameObject ScoreDailyMissionOB;

	[Token(Token = "0x4015F3B")]
	[FieldOffset(Offset = "0x78")]
	public UILabel DailyMissionAddTxt;

	[Token(Token = "0x4015F3C")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject ScoreRankScOB;

	[Token(Token = "0x4015F3D")]
	[FieldOffset(Offset = "0x80")]
	public UILabel RankScAddTxt;

	[Token(Token = "0x4015F3E")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ScoreBattleScOB;

	[Token(Token = "0x4015F3F")]
	[FieldOffset(Offset = "0x88")]
	public UILabel BattleScAddTxt;

	[Token(Token = "0x4015F40")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject ScoreMapScOB;

	[Token(Token = "0x4015F41")]
	[FieldOffset(Offset = "0x90")]
	public UILabel MapScAddTxt;

	[Token(Token = "0x4015F42")]
	[FieldOffset(Offset = "0x94")]
	public GameObject TokeInfoOB;

	[Token(Token = "0x4015F43")]
	[FieldOffset(Offset = "0x98")]
	public UILabel SurvivalTimeTxt;

	[Token(Token = "0x4015F44")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel TokenTxt;

	[Token(Token = "0x4015F45")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton TokenDetailBtn;

	[Token(Token = "0x4015F46")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton BackMaskBtn;

	[Token(Token = "0x4015F47")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject ScoreVeteran;

	[Token(Token = "0x4015F48")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel VeteranAddTxt;

	[Token(Token = "0x4015F49")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject LabelAntiHack;

	[Token(Token = "0x4015F4A")]
	[FieldOffset(Offset = "0xB4")]
	public Transform RankResultBigAniContainer;

	[Token(Token = "0x601675D")]
	[Address(RVA = "0xFE7868", Offset = "0xFE7868", VA = "0xFE7868")]
	public UIHudLadderMatchResultView()
	{
	}

	[Token(Token = "0x601675E")]
	[Address(RVA = "0xFE7870", Offset = "0xFE7870", VA = "0xFE7870", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601675F")]
	[Address(RVA = "0xFE8800", Offset = "0xFE8800", VA = "0xFE8800")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
